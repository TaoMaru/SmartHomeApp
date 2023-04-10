' Program name: Smart Home App
' Developer: Maria Jackson
' Date: April 9, 2023
' Purpose: The user selects a month from the drop down list to view that month's electric savings.
''          The user may also click Display Statistics to view the average savings for the year and
''          the month that had the most significant savings. Savings data are read from a file.

Public Class frmSmartHome
    Private Sub frmSmartHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnStats.Visible = False
        lblAvg.Text = ""
        lblMost.Text = ""
        lblStats.Text = "Select a month to view savings"
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged
        btnStats.Visible = True


    End Sub

    Private Function ReadFile(ByVal fileName As String) As Boolean
        Dim isValid As Boolean = False
        Dim ioReader As IO.StreamReader


        Try
            ioReader = IO.File.OpenText(fileName)
            isValid = True
            Return isValid
        Catch ex As System.IO.FileNotFoundException
            MsgBox("There was trouble reading the file. Please try again.", vbOKOnly, "File Read Error")

        End Try

    End Function

    Private Sub GetData(ByVal fileName As String)
        ' extracts data from file, populates array
        Dim savings(12) As String
        Dim intIndex As Integer

        If (ReadFile("savings.txt")) Then
            For intIndex = 0 To (savings.Length - 1)
                savings(intIndex) = Convert.ToInt32("intIndex")
            Next
        End If



    End Sub

End Class
