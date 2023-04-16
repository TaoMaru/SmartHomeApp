' Program name: Smart Home App
' Developer: Maria Jackson
' Date: April 9, 2023
' Purpose: The user selects a month from the drop down list to view that month's electric savings.
''          The user may also click Display Statistics to view the average savings for the year and
''          the month that had the most significant savings. Savings data are read from a file.

Option Strict On

Public Class frmSmartHome

    Private _intSizeOfArray As Integer = 11
    Private _strSavings(_intSizeOfArray) As String
    Private _decBill(_intSizeOfArray) As Decimal

    Private Sub frmSmartHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnStats.Visible = False
        lblAvg.Text = ""
        lblMost.Text = ""
        lblStats.Text = "Select a month to view savings"
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
        ComputeAverage()
        FindMaxSavings()
    End Sub

    Private Sub FindMaxSavings()
        Dim intMonths As Integer
        Dim intLargestSavingsValue As Integer = 0
        Dim intIndexValue As Integer = 0
        Dim strLargestValue As String = ""

        For Each intMonths In _decBill
            intLargestSavingsValue = Math.Max(intLargestSavingsValue, intMonths)
            If intMonths >= intLargestSavingsValue Then
                strLargestValue = _strSavings(intIndexValue)
            End If
            intIndexValue += 1
        Next
        lblMost.Text = strLargestValue & "had the most significant monthly savings"
    End Sub


    Private Sub ComputeAverage()
        ' computes the average monthly savings of the year
        ' updates lblAvg text to display avg savings
        Dim intCountMonths As Integer
        Dim intMonths As Integer = 0
        Dim decTotalBill As Decimal = 0D
        Dim decAvg As Decimal = 0D

        For Each intCountMonths In _decBill
            decTotalBill += _decBill(intMonths)
            intMonths += 1
        Next
        decAvg = decTotalBill / Convert.ToDecimal(_decBill.Length())
        lblAvg.Text = "The average monthly savings: " & decAvg.ToString("C2")
    End Sub
End Class
