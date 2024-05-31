Imports MySqlConnector
Imports System.IO


Public Class login
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=loginreg")

    Dim dr As MySqlDataReader



    Private Sub check_showpassword_CheckedChanged(sender As Object, e As EventArgs) Handles check_showpassword.CheckedChanged
        If check_showpassword.Checked = True Then
            txt_password.UseSystemPasswordChar = False
            txt_password.PasswordChar = ControlChars.NullChar
        Else
            txt_password.UseSystemPasswordChar = True
            txt_password.PasswordChar = "*"

        End If
    End Sub


    Sub usercomboload()
        conn.Open()

        combo_username.Items.Clear()
        Dim cmd As New MySqlCommand("SELECT * FROM login", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            combo_username.Items.Add(dr.GetString(3))
        End While
        dr.Close()
        conn.Close()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usercomboload()
    End Sub

    Private Sub combo_username_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_username.SelectedIndexChanged
        Dim picture() As Byte
        user_picture_load.Image = Nothing

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM login WHERE username=@username", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", combo_username.Text)

            dr = cmd.ExecuteReader()
            If dr.Read() Then
                picture = CType(dr("pic"), Byte())
                Dim mstream As New System.IO.MemoryStream(picture)
                user_picture_load.Image = Image.FromStream(mstream)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try


    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM login WHERE username=@username AND password=@password", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", combo_username.Text)
            cmd.Parameters.AddWithValue("@password", txt_password.Text)
            Dim username As String = ""
            Dim password As String = ""
            dr = cmd.ExecuteReader
            If (dr.Read() = True) Then
                username = dr("username")
                password = dr("password")
                MsgBox("OK!", vbInformation)
            Else
                MsgBox("Wrong password!", vbCritical)
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class