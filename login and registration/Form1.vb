Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        login.TopLevel = False
        Panel1.Controls.Add(login)
        login.BringToFront()
        login.Show()
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        register.TopLevel = False
        Panel1.Controls.Add(register)
        register.BringToFront()
        register.Show()
    End Sub
End Class
