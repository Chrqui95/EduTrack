<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnPassword = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnPlaceholderExit = New System.Windows.Forms.Button()
        Me.pnlLogin.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(200, 92)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(346, 60)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "EduTrack"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(77, 157)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(244, 36)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'pnlLogin
        '
        Me.pnlLogin.BackColor = System.Drawing.Color.White
        Me.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLogin.Controls.Add(Me.btnRegister)
        Me.pnlLogin.Controls.Add(Me.lblPassword)
        Me.pnlLogin.Controls.Add(Me.lblUsername)
        Me.pnlLogin.Controls.Add(Me.PictureBox2)
        Me.pnlLogin.Controls.Add(Me.txtPassword)
        Me.pnlLogin.Controls.Add(Me.PictureBox1)
        Me.pnlLogin.Controls.Add(Me.txtUsername)
        Me.pnlLogin.Controls.Add(Me.btnPassword)
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Location = New System.Drawing.Point(105, 180)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(390, 231)
        Me.pnlLogin.TabIndex = 19
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.White
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnRegister.Location = New System.Drawing.Point(223, 196)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(156, 28)
        Me.btnRegister.TabIndex = 27
        Me.btnRegister.Text = "Create an Account"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(112, 92)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(64, 17)
        Me.lblPassword.TabIndex = 26
        Me.lblPassword.Text = "Password"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(108, 41)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(67, 17)
        Me.lblUsername.TabIndex = 21
        Me.lblUsername.Text = "Username"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.EduTrack.My.Resources.Resources.lock
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Image = Global.EduTrack.My.Resources.Resources.user1
        Me.PictureBox2.Location = New System.Drawing.Point(77, 112)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 25)
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(106, 112)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(215, 25)
        Me.txtPassword.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.EduTrack.My.Resources.Resources.user1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.EduTrack.My.Resources.Resources.user1
        Me.PictureBox1.Location = New System.Drawing.Point(77, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 25)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(106, 61)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(215, 25)
        Me.txtUsername.TabIndex = 0
        '
        'btnPassword
        '
        Me.btnPassword.BackColor = System.Drawing.Color.White
        Me.btnPassword.FlatAppearance.BorderSize = 0
        Me.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnPassword.Location = New System.Drawing.Point(19, 197)
        Me.btnPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(156, 28)
        Me.btnPassword.TabIndex = 4
        Me.btnPassword.Text = "Forgot Password?"
        Me.btnPassword.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.EduTrack.My.Resources.Resources.edu
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(104, 56)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(163, 117)
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'btnPlaceholderExit
        '
        Me.btnPlaceholderExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPlaceholderExit.Location = New System.Drawing.Point(22, 11)
        Me.btnPlaceholderExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPlaceholderExit.Name = "btnPlaceholderExit"
        Me.btnPlaceholderExit.Size = New System.Drawing.Size(1, 1)
        Me.btnPlaceholderExit.TabIndex = 21
        Me.btnPlaceholderExit.Text = "0"
        Me.btnPlaceholderExit.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.BackgroundImage = Global.EduTrack.My.Resources.Resources.back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnPlaceholderExit
        Me.ClientSize = New System.Drawing.Size(606, 468)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.pnlLogin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnPlaceholderExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EduTrack"
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnPassword As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnPlaceholderExit As Button
    Friend WithEvents btnRegister As Button
End Class
