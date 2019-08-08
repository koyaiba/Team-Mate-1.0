Public Class Form2
    Private Sub BtnAns_Click(sender As Object, e As EventArgs) Handles btnAns.Click
        Dim strReply As String
        strReply = ReplyBox.Text.ToString()
        Try
            If strReply.Contains("later") Or strReply.Contains(TimeString) Or strReply.Contains("soon") Or strReply.Contains("tonight") Then
                Form1.Show()
                Me.Hide()
            Else
                Form1.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            Form1.Show()
            Me.Hide()
        End Try
    End Sub
End Class