Public Class Form1
    Private Sub BtnAns_Click(sender As Object, e As EventArgs) Handles btnAns.Click
        Dim strReply As String
        strReply = ReplyBox.Text.ToString()
        Try
            If strReply.Contains("later") Or strReply.Contains(TimeString) Or strReply.Contains("soon") Then

            Else
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class
