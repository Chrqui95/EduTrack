<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.lstGender = New System.Windows.Forms.ListBox()
        Me.msktxtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnPlaceholderExit = New System.Windows.Forms.Button()
        Me.pnlLogin.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLogin
        '
        Me.pnlLogin.BackColor = System.Drawing.Color.White
        Me.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLogin.Controls.Add(Me.lstGender)
        Me.pnlLogin.Controls.Add(Me.msktxtPhone)
        Me.pnlLogin.Controls.Add(Me.lblGender)
        Me.pnlLogin.Controls.Add(Me.lblCountry)
        Me.pnlLogin.Controls.Add(Me.lblPhone)
        Me.pnlLogin.Controls.Add(Me.txtCountry)
        Me.pnlLogin.Controls.Add(Me.dtpDOB)
        Me.pnlLogin.Controls.Add(Me.lblDOB)
        Me.pnlLogin.Controls.Add(Me.lblPassword)
        Me.pnlLogin.Controls.Add(Me.lblUsername)
        Me.pnlLogin.Controls.Add(Me.txtPassword)
        Me.pnlLogin.Controls.Add(Me.txtUsername)
        Me.pnlLogin.Controls.Add(Me.lblLName)
        Me.pnlLogin.Controls.Add(Me.lblFName)
        Me.pnlLogin.Controls.Add(Me.PictureBox2)
        Me.pnlLogin.Controls.Add(Me.txtLName)
        Me.pnlLogin.Controls.Add(Me.PictureBox1)
        Me.pnlLogin.Controls.Add(Me.txtFName)
        Me.pnlLogin.Controls.Add(Me.btnRegister)
        Me.pnlLogin.Location = New System.Drawing.Point(13, 160)
        Me.pnlLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(786, 438)
        Me.pnlLogin.TabIndex = 22
        '
        'lstGender
        '
        Me.lstGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstGender.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lstGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lstGender.FormattingEnabled = True
        Me.lstGender.ItemHeight = 21
        Me.lstGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.lstGender.Location = New System.Drawing.Point(422, 189)
        Me.lstGender.Name = "lstGender"
        Me.lstGender.Size = New System.Drawing.Size(286, 23)
        Me.lstGender.TabIndex = 46
        '
        'msktxtPhone
        '
        Me.msktxtPhone.BeepOnError = True
        Me.msktxtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.msktxtPhone.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.msktxtPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.msktxtPhone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.msktxtPhone.Location = New System.Drawing.Point(422, 60)
        Me.msktxtPhone.Mask = "000-0000"
        Me.msktxtPhone.Name = "msktxtPhone"
        Me.msktxtPhone.Size = New System.Drawing.Size(286, 29)
        Me.msktxtPhone.TabIndex = 45
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(429, 160)
        Me.lblGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(66, 23)
        Me.lblGender.TabIndex = 42
        Me.lblGender.Text = "Gender"
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountry.Location = New System.Drawing.Point(431, 100)
        Me.lblCountry.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(71, 23)
        Me.lblCountry.TabIndex = 38
        Me.lblCountry.Text = "Country"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(426, 37)
        Me.lblPhone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(127, 23)
        Me.lblPhone.TabIndex = 37
        Me.lblPhone.Text = "Phone Number"
        '
        'txtCountry
        '
        Me.txtCountry.BackColor = System.Drawing.Color.White
        Me.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCountry.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCountry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtCountry.Location = New System.Drawing.Point(423, 125)
        Me.txtCountry.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCountry.MaxLength = 20
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(286, 29)
        Me.txtCountry.TabIndex = 36
        '
        'dtpDOB
        '
        Me.dtpDOB.Location = New System.Drawing.Point(58, 189)
        Me.dtpDOB.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(285, 22)
        Me.dtpDOB.TabIndex = 34
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.Location = New System.Drawing.Point(66, 164)
        Me.lblDOB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(107, 23)
        Me.lblDOB.TabIndex = 32
        Me.lblDOB.Text = "Date of Birth"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(430, 223)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(80, 23)
        Me.lblPassword.TabIndex = 30
        Me.lblPassword.Text = "Password"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(61, 223)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(87, 23)
        Me.lblUsername.TabIndex = 29
        Me.lblUsername.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(422, 248)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.MaxLength = 30
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(286, 29)
        Me.txtPassword.TabIndex = 28
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(58, 248)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.MaxLength = 20
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(286, 29)
        Me.txtUsername.TabIndex = 27
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLName.Location = New System.Drawing.Point(66, 98)
        Me.lblLName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(91, 23)
        Me.lblLName.TabIndex = 26
        Me.lblLName.Text = "Last Name"
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFName.Location = New System.Drawing.Point(61, 35)
        Me.lblFName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(92, 23)
        Me.lblFName.TabIndex = 21
        Me.lblFName.Text = "First Name"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.EduTrack.My.Resources.Resources.lock
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Image = Global.EduTrack.My.Resources.Resources.user1
        Me.PictureBox2.Location = New System.Drawing.Point(384, 248)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 31)
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'txtLName
        '
        Me.txtLName.BackColor = System.Drawing.Color.White
        Me.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtLName.Location = New System.Drawing.Point(58, 123)
        Me.txtLName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLName.MaxLength = 20
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(286, 29)
        Me.txtLName.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.EduTrack.My.Resources.Resources.user1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.EduTrack.My.Resources.Resources.user1
        Me.PictureBox1.Location = New System.Drawing.Point(20, 60)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 31)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'txtFName
        '
        Me.txtFName.BackColor = System.Drawing.Color.White
        Me.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtFName.Location = New System.Drawing.Point(58, 60)
        Me.txtFName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFName.MaxLength = 20
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(286, 29)
        Me.txtFName.TabIndex = 0
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnRegister.Location = New System.Drawing.Point(235, 337)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(325, 44)
        Me.btnRegister.TabIndex = 2
        Me.btnRegister.Text = "REGISTER"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(235, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(461, 74)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "EduTrack"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.EduTrack.My.Resources.Resources.edu
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(107, 7)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(217, 144)
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'btnPlaceholderExit
        '
        Me.btnPlaceholderExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPlaceholderExit.Location = New System.Drawing.Point(607, 12)
        Me.btnPlaceholderExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPlaceholderExit.Name = "btnPlaceholderExit"
        Me.btnPlaceholderExit.Size = New System.Drawing.Size(1, 1)
        Me.btnPlaceholderExit.TabIndex = 24
        Me.btnPlaceholderExit.TabStop = False
        Me.btnPlaceholderExit.Text = "0"
        Me.btnPlaceholderExit.UseVisualStyleBackColor = True
        '
        'frmRegister
        '
        Me.AcceptButton = Me.btnRegister
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.BackgroundImage = Global.EduTrack.My.Resources.Resources.back
        Me.CancelButton = Me.btnPlaceholderExit
        Me.ClientSize = New System.Drawing.Size(812, 677)
        Me.Controls.Add(Me.btnPlaceholderExit)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.pnlLogin)
        Me.Controls.Add(Me.Label6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents lblLName As Label
    Friend WithEvents lblFName As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents btnPlaceholderExit As Button
    Friend WithEvents lblGender As Label
    Friend WithEvents lblCountry As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents msktxtPhone As MaskedTextBox
    Friend WithEvents lstGender As ListBox
End Class
