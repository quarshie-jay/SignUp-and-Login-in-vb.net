<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(register))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.user_picture = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Btn_browse = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Btn_back = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.lbl_firstname = New Guna.UI.WinForms.GunaLabel()
        Me.lbl_lastname = New Guna.UI.WinForms.GunaLabel()
        Me.txt_firstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_lastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dob_picker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.checkbox_status = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.check_showpassword = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.btn_register = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.combo_role = New Guna.UI2.WinForms.Guna2ComboBox()
        CType(Me.user_picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GunaLabel1.Location = New System.Drawing.Point(116, 41)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(207, 28)
        Me.GunaLabel1.TabIndex = 3
        Me.GunaLabel1.Text = "Create A New Account"
        '
        'user_picture
        '
        Me.user_picture.Image = CType(resources.GetObject("user_picture.Image"), System.Drawing.Image)
        Me.user_picture.ImageRotate = 0!
        Me.user_picture.Location = New System.Drawing.Point(147, 87)
        Me.user_picture.Name = "user_picture"
        Me.user_picture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.user_picture.Size = New System.Drawing.Size(118, 129)
        Me.user_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.user_picture.TabIndex = 4
        Me.user_picture.TabStop = False
        '
        'Btn_browse
        '
        Me.Btn_browse.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_browse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_browse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_browse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_browse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn_browse.ForeColor = System.Drawing.Color.White
        Me.Btn_browse.Location = New System.Drawing.Point(250, 192)
        Me.Btn_browse.Name = "Btn_browse"
        Me.Btn_browse.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Btn_browse.Size = New System.Drawing.Size(31, 33)
        Me.Btn_browse.TabIndex = 5
        Me.Btn_browse.Text = "+"
        '
        'Btn_back
        '
        Me.Btn_back.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_back.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_back.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn_back.ForeColor = System.Drawing.Color.White
        Me.Btn_back.Location = New System.Drawing.Point(22, 41)
        Me.Btn_back.Name = "Btn_back"
        Me.Btn_back.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Btn_back.Size = New System.Drawing.Size(31, 33)
        Me.Btn_back.TabIndex = 6
        Me.Btn_back.Text = "<"
        '
        'lbl_firstname
        '
        Me.lbl_firstname.AutoSize = True
        Me.lbl_firstname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_firstname.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl_firstname.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lbl_firstname.Location = New System.Drawing.Point(36, 243)
        Me.lbl_firstname.Name = "lbl_firstname"
        Me.lbl_firstname.Size = New System.Drawing.Size(75, 19)
        Me.lbl_firstname.TabIndex = 9
        Me.lbl_firstname.Text = "First Name"
        '
        'lbl_lastname
        '
        Me.lbl_lastname.AutoSize = True
        Me.lbl_lastname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_lastname.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl_lastname.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lbl_lastname.Location = New System.Drawing.Point(252, 243)
        Me.lbl_lastname.Name = "lbl_lastname"
        Me.lbl_lastname.Size = New System.Drawing.Size(74, 19)
        Me.lbl_lastname.TabIndex = 10
        Me.lbl_lastname.Text = "Last Name"
        '
        'txt_firstname
        '
        Me.txt_firstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_firstname.DefaultText = ""
        Me.txt_firstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_firstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_firstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_firstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_firstname.FillColor = System.Drawing.SystemColors.Menu
        Me.txt_firstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_firstname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_firstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_firstname.Location = New System.Drawing.Point(40, 265)
        Me.txt_firstname.Name = "txt_firstname"
        Me.txt_firstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_firstname.PlaceholderText = ""
        Me.txt_firstname.SelectedText = ""
        Me.txt_firstname.Size = New System.Drawing.Size(155, 36)
        Me.txt_firstname.TabIndex = 11
        Me.txt_firstname.TextOffset = New System.Drawing.Point(10, 0)
        '
        'txt_lastname
        '
        Me.txt_lastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_lastname.DefaultText = ""
        Me.txt_lastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_lastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_lastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_lastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_lastname.FillColor = System.Drawing.SystemColors.Menu
        Me.txt_lastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_lastname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_lastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_lastname.Location = New System.Drawing.Point(256, 265)
        Me.txt_lastname.Name = "txt_lastname"
        Me.txt_lastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_lastname.PlaceholderText = ""
        Me.txt_lastname.SelectedText = ""
        Me.txt_lastname.Size = New System.Drawing.Size(155, 36)
        Me.txt_lastname.TabIndex = 12
        Me.txt_lastname.TextOffset = New System.Drawing.Point(10, 0)
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.GunaLabel2.Location = New System.Drawing.Point(36, 317)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(71, 19)
        Me.GunaLabel2.TabIndex = 13
        Me.GunaLabel2.Text = "Username"
        '
        'txt_username
        '
        Me.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_username.DefaultText = ""
        Me.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_username.FillColor = System.Drawing.SystemColors.Menu
        Me.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_username.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_username.Location = New System.Drawing.Point(40, 339)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_username.PlaceholderText = ""
        Me.txt_username.SelectedText = ""
        Me.txt_username.Size = New System.Drawing.Size(155, 36)
        Me.txt_username.TabIndex = 14
        Me.txt_username.TextOffset = New System.Drawing.Point(10, 0)
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.GunaLabel3.Location = New System.Drawing.Point(255, 317)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(67, 19)
        Me.GunaLabel3.TabIndex = 15
        Me.GunaLabel3.Text = "Password"
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
        Me.txt_password.Location = New System.Drawing.Point(256, 339)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_password.PlaceholderText = ""
        Me.txt_password.SelectedText = ""
        Me.txt_password.Size = New System.Drawing.Size(155, 36)
        Me.txt_password.TabIndex = 16
        Me.txt_password.TextOffset = New System.Drawing.Point(10, 0)
        Me.txt_password.UseSystemPasswordChar = True
        '
        'dob_picker
        '
        Me.dob_picker.Checked = True
        Me.dob_picker.FillColor = System.Drawing.Color.DodgerBlue
        Me.dob_picker.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.dob_picker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dob_picker.Location = New System.Drawing.Point(40, 414)
        Me.dob_picker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dob_picker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dob_picker.Name = "dob_picker"
        Me.dob_picker.Size = New System.Drawing.Size(165, 36)
        Me.dob_picker.TabIndex = 17
        Me.dob_picker.Value = New Date(2024, 4, 27, 16, 28, 44, 475)
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.GunaLabel4.Location = New System.Drawing.Point(36, 392)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(90, 19)
        Me.GunaLabel4.TabIndex = 18
        Me.GunaLabel4.Text = "Date Of Birth"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel5.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.GunaLabel5.Location = New System.Drawing.Point(252, 392)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(35, 19)
        Me.GunaLabel5.TabIndex = 19
        Me.GunaLabel5.Text = "Role"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel6.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.GunaLabel6.Location = New System.Drawing.Point(36, 472)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(54, 19)
        Me.GunaLabel6.TabIndex = 21
        Me.GunaLabel6.Text = "Status :"
        '
        'checkbox_status
        '
        Me.checkbox_status.Animated = True
        Me.checkbox_status.AutoSize = True
        Me.checkbox_status.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkbox_status.CheckedState.BorderRadius = 0
        Me.checkbox_status.CheckedState.BorderThickness = 0
        Me.checkbox_status.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkbox_status.Location = New System.Drawing.Point(96, 477)
        Me.checkbox_status.Name = "checkbox_status"
        Me.checkbox_status.Size = New System.Drawing.Size(15, 14)
        Me.checkbox_status.TabIndex = 22
        Me.checkbox_status.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.checkbox_status.UncheckedState.BorderRadius = 0
        Me.checkbox_status.UncheckedState.BorderThickness = 0
        Me.checkbox_status.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'check_showpassword
        '
        Me.check_showpassword.Animated = True
        Me.check_showpassword.AutoSize = True
        Me.check_showpassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.check_showpassword.CheckedState.BorderRadius = 0
        Me.check_showpassword.CheckedState.BorderThickness = 0
        Me.check_showpassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.check_showpassword.Location = New System.Drawing.Point(390, 352)
        Me.check_showpassword.Name = "check_showpassword"
        Me.check_showpassword.Size = New System.Drawing.Size(15, 14)
        Me.check_showpassword.TabIndex = 23
        Me.check_showpassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.check_showpassword.UncheckedState.BorderRadius = 0
        Me.check_showpassword.UncheckedState.BorderThickness = 0
        Me.check_showpassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel7.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.GunaLabel7.Location = New System.Drawing.Point(117, 474)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(46, 19)
        Me.GunaLabel7.TabIndex = 24
        Me.GunaLabel7.Text = "Active"
        '
        'btn_register
        '
        Me.btn_register.Animated = True
        Me.btn_register.AnimationHoverSpeed = 0.07!
        Me.btn_register.AnimationSpeed = 0.03!
        Me.btn_register.BackColor = System.Drawing.Color.Transparent
        Me.btn_register.BaseColor = System.Drawing.Color.DodgerBlue
        Me.btn_register.BorderColor = System.Drawing.Color.Black
        Me.btn_register.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_register.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_register.CheckedForeColor = System.Drawing.Color.White
        Me.btn_register.CheckedImage = CType(resources.GetObject("btn_register.CheckedImage"), System.Drawing.Image)
        Me.btn_register.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_register.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_register.FocusedColor = System.Drawing.Color.Empty
        Me.btn_register.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_register.ForeColor = System.Drawing.Color.White
        Me.btn_register.Image = Nothing
        Me.btn_register.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_register.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_register.Location = New System.Drawing.Point(143, 515)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_register.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_register.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_register.OnHoverImage = Nothing
        Me.btn_register.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_register.OnPressedColor = System.Drawing.Color.Black
        Me.btn_register.Radius = 20
        Me.btn_register.Size = New System.Drawing.Size(180, 42)
        Me.btn_register.TabIndex = 25
        Me.btn_register.Text = "Register"
        Me.btn_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'combo_role
        '
        Me.combo_role.BackColor = System.Drawing.Color.Transparent
        Me.combo_role.BorderThickness = 0
        Me.combo_role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.combo_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_role.FillColor = System.Drawing.SystemColors.Menu
        Me.combo_role.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_role.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_role.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.combo_role.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.combo_role.ItemHeight = 30
        Me.combo_role.Items.AddRange(New Object() {"Admin", "Manager", "Organizer", "Labour"})
        Me.combo_role.Location = New System.Drawing.Point(256, 414)
        Me.combo_role.Name = "combo_role"
        Me.combo_role.Size = New System.Drawing.Size(174, 36)
        Me.combo_role.TabIndex = 26
        Me.combo_role.TextOffset = New System.Drawing.Point(10, 0)
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(493, 569)
        Me.Controls.Add(Me.combo_role)
        Me.Controls.Add(Me.btn_register)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.check_showpassword)
        Me.Controls.Add(Me.checkbox_status)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.dob_picker)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.txt_lastname)
        Me.Controls.Add(Me.txt_firstname)
        Me.Controls.Add(Me.lbl_lastname)
        Me.Controls.Add(Me.lbl_firstname)
        Me.Controls.Add(Me.Btn_back)
        Me.Controls.Add(Me.Btn_browse)
        Me.Controls.Add(Me.user_picture)
        Me.Controls.Add(Me.GunaLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "register"
        Me.Text = "register"
        CType(Me.user_picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents user_picture As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Btn_browse As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Btn_back As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents lbl_firstname As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_lastname As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_firstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_lastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dob_picker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents checkbox_status As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents check_showpassword As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_register As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents combo_role As Guna.UI2.WinForms.Guna2ComboBox
End Class
