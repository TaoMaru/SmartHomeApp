' Program name: Smart Home App
' Developer: Maria Jackson
' Date: April 9, 2023 - Update April 15, 2023
' Purpose: The user selects a month from the drop down list to view that month's electric savings.
''          The user may also click Display Statistics to view the average savings for the year and
''          the month that had the most significant savings. Savings data are read from a file.
''File Path: C:\VB\savings.txt

Option Strict On

Public Class frmSmartHome

    Private _intSizeOfArray As Integer = 11
    Private _strSavings(_intSizeOfArray) As String
    Private _decBill(_intSizeOfArray) As Decimal

    Private Sub frmSmartHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' reset form and read savings file at path: C:\VB\savings.txt
        btnStats.Visible = False
        lblAvg.Text = ""
        lblMost.Text = ""
        lblStats.Text = "Please select a month to view savings"

        'check file & get data if found to populate cboMonth
        If ReadFile() Then
            GetData()
        End If
    End Sub

    Private Function ReadFile() As Boolean
        'checks file
        Dim boolIsValid = False 'indicates valid or invalid file
        Dim ioReader As IO.StreamReader
        'read file 
        Try
            ioReader = IO.File.OpenText("C:\VB\savings.txt")
            boolIsValid = True
            ioReader.Close()
        Catch ex As System.IO.FileNotFoundException
            MsgBox("There was trouble reading the file. Please try again.", vbOKOnly, "File Read Error")

        End Try
        Return boolIsValid
    End Function

    Private Sub GetData()
        ' populate strSavings and decBill srrays with data
        Dim ioReader As IO.StreamReader
        Dim strSavingsAmt As String
        Dim intCount As Integer = 0
        Dim intFill As Integer

        Try
            ioReader = IO.File.OpenText("C:\VB\savings.txt")
            ' read file one line at a time
            Do While ioReader.Peek <> -1
                _strSavings(intCount) = ioReader.ReadLine()
                strSavingsAmt = ioReader.ReadLine()
                _decBill(intCount) = Convert.ToDecimal(strSavingsAmt)
                intCount += 1
            Loop
            ioReader.Close()
            For intFill = 0 To (_strSavings.Length() - 1)
                cboMonth.Items.Add(_strSavings(intFill))

            Next
        Catch ex As System.IO.FileNotFoundException
            MsgBox("There was trouble reading the file. Please try again.", vbOKOnly, "File Read Error")

        End Try
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged
        ' a month has been selected, directs which month's data will be shown
        ' reveals btnStats
        Dim intSelectedIndex As Integer = cboMonth.SelectedIndex
        Dim strMonthStats As String = "The electric savings for {0} is {1}."
        lblStats.Text = String.Format(strMonthStats, _strSavings(intSelectedIndex),
                                      _decBill(intSelectedIndex).ToString("C2"))

        btnStats.Visible = True
    End Sub

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        'computes and displays the average monthly savings for the year
        ' determines and displays the month with the largest savings
        DisplayAvgSavings()
        DisplayMaxSavings()
    End Sub

    Private Function FindMaxSavings() As String
        'finds & returns the max savings of the year using Math.Max to compare monthly values
        Dim intMonths As Integer
        Dim intLargestSavingsValue As Integer = 0
        Dim intIndexValue As Integer = 0
        Dim strLargestValue As String = ""
        ' compare the values in _decBill to find the greatest:
        For Each intMonths In _decBill
            intLargestSavingsValue = Math.Max(intLargestSavingsValue, intMonths)
            If intMonths >= intLargestSavingsValue Then
                strLargestValue = _strSavings(intIndexValue)
            End If
            intIndexValue += 1
        Next
        Return strLargestValue
    End Function

    Private Sub DisplayMaxSavings()
        'calls FindMaxSavings() to update lblMost text and display the month of greatest savings
        lblMost.Text = FindMaxSavings() & " had the most significant monthly savings"
    End Sub


    Private Function ComputeAverage() As Decimal
        ' computes & returns the average monthly savings of the year
        Dim intCountMonths As Integer
        Dim intMonths As Integer = 0
        Dim decTotalBill As Decimal = 0D
        Dim decAvg As Decimal = 0D
        ' add all the savings
        For Each intCountMonths In _decBill
            decTotalBill += _decBill(intMonths)
            intMonths += 1
        Next
        'average the total savings
        decAvg = decTotalBill / Convert.ToDecimal(_decBill.Length())
        Return decAvg
    End Function

    Private Sub DisplayAvgSavings()
        ' calls computeAverage() to update lblAvg text and display the avg savings
        Dim strAvgSavings = ComputeAverage().ToString("C2")
        lblAvg.Text = "The average monthly savings: " & strAvgSavings
    End Sub
End Class
