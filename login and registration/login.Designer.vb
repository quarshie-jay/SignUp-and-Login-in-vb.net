<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.user_picture_load = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.combo_username = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txt_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.check_showpassword = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.btn_login = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        CType(Me.user_picture_load, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GunaLabel1.Location = New System.Drawing.Point(189, 43)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(107, 28)
        Me.GunaLabel1.TabIndex = 2
        Me.GunaLabel1.Text = "Login Here"
        '
        'user_picture_load
        '
        Me.user_picture_load.Image = CType(resources.GetObject("user_picture_load.Image"), System.Drawing.Image)
        Me.user_picture_load.ImageRotate = 0!
        Me.user_picture_load.Location = New System.Drawing.Point(178, 100)
        Me.user_picture_load.Name = "user_picture_load"
        Me.user_picture_load.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.user_picture_load.Size = New System.Drawing.Size(118, 129)
        Me.user_picture_load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.user_picture_load.TabIndex = 3
        Me.user_picture_load.TabStop = False
        '
        'combo_username
        '
        Me.combo_username.BackColor = System.Drawing.Color.Transparent
        Me.combo_username.BorderThickness = 0
        Me.combo_username.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.combo_username.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_username.FillColor = System.Drawing.SystemColors.Menu
        Me.combo_username.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_username.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.combo_username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.combo_username.ItemHeight = 30
        Me.combo_username.Location = New System.Drawing.Point(134, 282)
        Me.combo_username.Name = "combo_username"
        Me.combo_username.Size = New System.Drawing.Size(200, 36)
        Me.combo_username.TabIndex = 4
        Me.combo_username.TextOffset = New System.Drawing.Point(10, 0)
        '
        'txt_password
        '
        Me.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_password.DefaultText = ""
        Me.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.FillColor = System.Drawing.SystemColors.Menu
        Me.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.Location = New System.Drawing.Point(134, 355)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_password.PlaceholderText = ""
        Me.txt_password.SelectedText = ""
        Me.txt_password.Size = New System.Drawing.Size(200, 36)
        Me.txt_password.TabIndex = 5
        Me.txt_password.TextOffset = New System.Drawing.Point(10, 0)
        Me.txt_password.UseSystemPasswordChar = True
        '
        'check_showpassword
        '
        Me.check_showpassword.Animated = True
        Me.check_showpassword.AutoSize = True
        Me.check_showpassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.check_showpassword.CheckedState.BorderRadius = 0
        Me.check_showpassword.CheckedState.BorderThickness = 0
        Me.check_showpassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.check_showpassword.Location = New System.Drawing.Point(315, 366)
        Me.check_showpassword.Name = "check_showpassword"
        Me.check_showpassword.Size = New System.Drawing.Size(15, 14)
        Me.check_showpassword.TabIndex = 6
        Me.check_showpassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.check_showpassword.UncheckedState.BorderRadius = 0
        Me.check_showpassword.UncheckedState.BorderThickness = 0
        Me.check_showpassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'btn_login
        '
        Me.btn_login.Animated = True
        Me.btn_login.AnimationHoverSpeed = 0.07!
        Me.btn_login.AnimationSpeed = 0.03!
        Me.btn_login.BackColor = System.Drawing.Color.Transparent
        Me.btn_login.BaseColor = System.Drawing.Color.DodgerBlue
        Me.btn_login.BorderColor = System.Drawing.Color.Black
        Me.btn_login.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_login.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_login.CheckedForeColor = System.Drawing.Color.White
        Me.btn_login.CheckedImage = CType(resources.GetObject("btn_login.CheckedImage"), System.Drawing.Image)
        Me.btn_login.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_login.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_login.FocusedColor = System.Drawing.Color.Empty
        Me.btn_login.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Image = Nothing
        Me.btn_login.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_login.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_login.Location = New System.Drawing.Point(143, 430)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_login.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_login.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_login.OnHoverImage = Nothing
        Me.btn_login.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_login.OnPressedColor = System.Drawing.Color.Black
        Me.btn_login.Radius = 20
        Me.btn_login.Size = New System.Drawing.Size(180, 42)
        Me.btn_login.TabIndex = 7
        Me.btn_login.Text = "LOGIN"
        Me.btn_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.GunaLabel2.Location = New System.Drawing.Point(138, 260)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(71, 19)
        Me.GunaLabel2.TabIndex = 8
        Me.GunaLabel2.Text = "Username"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.GunaLabel3.Location = New System.Drawing.Point(138, 333)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(67, 19)
        Me.GunaLabel3.TabIndex = 9
        Me.GunaLabel3.Text = "Password"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(493, 569)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.check_showpassword)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.combo_username)
        Me.Controls.Add(Me.user_picture_load)
        Me.Controls.Add(Me.GunaLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        CType(Me.user_picture_load, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents user_picture_load As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents combo_username As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txt_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents check_showpassword As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents btn_login As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
End Class
