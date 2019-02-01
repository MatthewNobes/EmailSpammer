Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim num As String = txtNum.Text
        Dim intnum As Integer = Convert.ToInt32(num)
        For i As Integer = 1 To intnum
            Dim objOutlook As Object
            Dim objOutlookMsg As Object
            objOutlook = CreateObject("Outlook.Application")
            objOutlookMsg = objOutlook.CreateItem(0)
            With objOutlookMsg
                .To = txtAddress.Text  'destination email address
                .Cc = txtAddress.Text
                .Subject = txtSubject.Text + i.ToString
                .Body = txtBody.Text
                .Send() 'Let´s go!
            End With
            objOutlookMsg = Nothing
            objOutlook = Nothing
        Next
    End Sub
End Class
