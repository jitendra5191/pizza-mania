Public Class Form1

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If GunaTextBox1.Text = "1" And GunaTextBox2.Text = "2" Then
            MsgBox("Login Successful")
            Dash.Show()
            GunaTextBox1.Clear()
            GunaTextBox2.Clear()
            Me.Hide()

        Else
            MsgBox("Incorrect Username Or Password")
        End If
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Application.Exit()

    End Sub
End Class
