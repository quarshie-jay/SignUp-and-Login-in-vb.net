Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Imports MySqlConnector
Imports System.IO

Public Class register

    Dim i As Integer

    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=loginreg")

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Btn_back_Click(sender As Object, e As EventArgs) Handles Btn_back.Click
        Me.Dispose()
    End Sub

    Private Sub check_showpassword_CheckedChanged(sender As Object, e As EventArgs) Handles check_showpassword.CheckedChanged
        If check_showpassword.Checked = True Then
            txt_password.UseSystemPasswordChar = False
            txt_password.PasswordChar = ControlChars.NullChar
        Else
            txt_password.UseSystemPasswordChar = True
            txt_password.PasswordChar = "*"

        End If
    End Sub

    Private Sub Btn_browse_Click(sender As Object, e As EventArgs) Handles Btn_browse.Click
        Dim pop As OpenFileDialog = New OpenFileDialog
        If pop.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            user_picture.Image = Image.FromFile(pop.FileName)
        End If
    End Sub

    Sub save()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `login` (`firstname`, `lastname`, `username` , `password`, `dob`, `role`, `status`, `pic`) VALUES (@firstname, @lastname, @username, @password, @dob, @role, @status, @pic)", conn)


            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@firstname", txt_firstname.Text)
            cmd.Parameters.AddWithValue("@lastname", txt_lastname.Text)
            cmd.Parameters.AddWithValue("@username", txt_username.Text)
            cmd.Parameters.AddWithValue("@password", txt_password.Text)
            cmd.Parameters.AddWithValue("@dob", CDate(dob_picker.Text))
            cmd.Parameters.AddWithValue("@role", combo_role.Text)
            cmd.Parameters.AddWithValue("@status", CBool(checkbox_status.Checked.ToString))


            Dim Filesize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            user_picture.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.GetBuffer
            Filesize = mstream.Length
            mstream.Close()

            cmd.Parameters.AddWithValue("@pic", picture)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New user Registered Success!", vbInformation)
            Else
                MsgBox("New User Registration Failed!", vbCritical)
            End If

            txt_firstname.Clear()
            txt_lastname.Clear()
            txt_username.Clear()
            combo_role.Text = ""
            user_picture.Image = Nothing
            checkbox_status.Checked = False

            Me.Dispose()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try

    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        save()
    End Sub
End Class