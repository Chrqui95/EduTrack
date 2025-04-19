<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblDash = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAdminManage = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnDashAttendance = New System.Windows.Forms.Button()
        Me.btnDashGrades = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlViewGrades = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnStudentGrades = New System.Windows.Forms.Button()
        Me.pnlViewAttendance = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pnlMngAttendance = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.btnTeacherAttendance = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.btnTeacherGrades = New System.Windows.Forms.Button()
        Me.btnStudentAttendance = New System.Windows.Forms.Button()
        Me.pnlAccount = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnStudentSettings = New System.Windows.Forms.Button()
        Me.EduTrackDBDS = New EduTrack.EduTrackDBDS()
        Me.EduTrackDBDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlMngStudent = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnStudentManager = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlMngGrades = New System.Windows.Forms.Panel()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.btnTeacherGrade = New System.Windows.Forms.Button()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlViewGrades.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlViewAttendance.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMngAttendance.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAccount.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EduTrackDBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EduTrackDBDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMngStudent.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMngGrades.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDash
        '
        Me.lblDash.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDash.BackColor = System.Drawing.Color.Transparent
        Me.lblDash.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblDash.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblDash.Location = New System.Drawing.Point(52, -38)
        Me.lblDash.Name = "lblDash"
        Me.lblDash.Size = New System.Drawing.Size(213, 50)
        Me.lblDash.TabIndex = 21
        Me.lblDash.Text = "Dashboard"
        Me.lblDash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWelcome
        '
        Me.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblWelcome.Location = New System.Drawing.Point(1315, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(263, 28)
        Me.lblWelcome.TabIndex = 30
        Me.lblWelcome.Text = "Welcome: Username"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.btnAdminManage)
        Me.Panel1.Controls.Add(Me.btnSettings)
        Me.Panel1.Controls.Add(Me.btnDashAttendance)
        Me.Panel1.Controls.Add(Me.btnDashGrades)
        Me.Panel1.Controls.Add(Me.lblDash)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 36)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(332, 772)
        Me.Panel1.TabIndex = 27
        '
        'btnAdminManage
        '
        Me.btnAdminManage.BackColor = System.Drawing.Color.Teal
        Me.btnAdminManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminManage.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminManage.ForeColor = System.Drawing.Color.White
        Me.btnAdminManage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdminManage.Location = New System.Drawing.Point(35, 454)
        Me.btnAdminManage.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdminManage.Name = "btnAdminManage"
        Me.btnAdminManage.Size = New System.Drawing.Size(256, 54)
        Me.btnAdminManage.TabIndex = 37
        Me.btnAdminManage.Text = "User Management"
        Me.btnAdminManage.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackgroundImage = Global.EduTrack.My.Resources.Resources.settings
        Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.Image = Global.EduTrack.My.Resources.Resources.settings1
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Location = New System.Drawing.Point(4, 647)
        Me.btnSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(140, 54)
        Me.btnSettings.TabIndex = 37
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnDashAttendance
        '
        Me.btnDashAttendance.BackColor = System.Drawing.Color.Teal
        Me.btnDashAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashAttendance.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashAttendance.ForeColor = System.Drawing.Color.White
        Me.btnDashAttendance.Location = New System.Drawing.Point(35, 313)
        Me.btnDashAttendance.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDashAttendance.Name = "btnDashAttendance"
        Me.btnDashAttendance.Size = New System.Drawing.Size(256, 54)
        Me.btnDashAttendance.TabIndex = 35
        Me.btnDashAttendance.Text = "My Attendance"
        Me.btnDashAttendance.UseVisualStyleBackColor = False
        '
        'btnDashGrades
        '
        Me.btnDashGrades.BackColor = System.Drawing.Color.Teal
        Me.btnDashGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashGrades.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashGrades.ForeColor = System.Drawing.Color.White
        Me.btnDashGrades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashGrades.Location = New System.Drawing.Point(35, 165)
        Me.btnDashGrades.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDashGrades.Name = "btnDashGrades"
        Me.btnDashGrades.Size = New System.Drawing.Size(256, 54)
        Me.btnDashGrades.TabIndex = 34
        Me.btnDashGrades.Text = "My Grades"
        Me.btnDashGrades.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Teal
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1678, 36)
        Me.MenuStrip1.TabIndex = 28
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 50, 0)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 32)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(146, 28)
        Me.HomeToolStripMenuItem.Text = "Home "
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(146, 28)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OptionsToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 50, 0)
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(84, 32)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutUsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(71, 32)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(165, 28)
        Me.AboutUsToolStripMenuItem.Text = "About Us"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(165, 28)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'pnlViewGrades
        '
        Me.pnlViewGrades.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlViewGrades.Controls.Add(Me.PictureBox1)
        Me.pnlViewGrades.Controls.Add(Me.btnStudentGrades)
        Me.pnlViewGrades.Location = New System.Drawing.Point(404, 278)
        Me.pnlViewGrades.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlViewGrades.Name = "pnlViewGrades"
        Me.pnlViewGrades.Size = New System.Drawing.Size(303, 186)
        Me.pnlViewGrades.TabIndex = 31
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.EduTrack.My.Resources.Resources.test
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(75, 30)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(149, 78)
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'btnStudentGrades
        '
        Me.btnStudentGrades.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnStudentGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentGrades.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentGrades.ForeColor = System.Drawing.Color.White
        Me.btnStudentGrades.Location = New System.Drawing.Point(23, 114)
        Me.btnStudentGrades.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStudentGrades.Name = "btnStudentGrades"
        Me.btnStudentGrades.Size = New System.Drawing.Size(256, 54)
        Me.btnStudentGrades.TabIndex = 37
        Me.btnStudentGrades.Text = "View Grades"
        Me.btnStudentGrades.UseVisualStyleBackColor = False
        '
        'pnlViewAttendance
        '
        Me.pnlViewAttendance.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlViewAttendance.Controls.Add(Me.PictureBox2)
        Me.pnlViewAttendance.Controls.Add(Me.Panel7)
        Me.pnlViewAttendance.Controls.Add(Me.btnStudentAttendance)
        Me.pnlViewAttendance.Location = New System.Drawing.Point(877, 278)
        Me.pnlViewAttendance.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlViewAttendance.Name = "pnlViewAttendance"
        Me.pnlViewAttendance.Size = New System.Drawing.Size(303, 186)
        Me.pnlViewAttendance.TabIndex = 32
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.EduTrack.My.Resources.Resources.check
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(99, 30)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(125, 78)
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'pnlMngAttendance
        '
        Me.pnlMngAttendance.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlMngAttendance.Controls.Add(Me.PictureBox5)
        Me.pnlMngAttendance.Controls.Add(Me.btnTeacherAttendance)
        Me.pnlMngAttendance.Location = New System.Drawing.Point(877, 278)
        Me.pnlMngAttendance.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlMngAttendance.Name = "pnlMngAttendance"
        Me.pnlMngAttendance.Size = New System.Drawing.Size(303, 186)
        Me.pnlMngAttendance.TabIndex = 38
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.EduTrack.My.Resources.Resources.check
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(99, 30)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(125, 78)
        Me.PictureBox5.TabIndex = 39
        Me.PictureBox5.TabStop = False
        '
        'btnTeacherAttendance
        '
        Me.btnTeacherAttendance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnTeacherAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeacherAttendance.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeacherAttendance.ForeColor = System.Drawing.Color.White
        Me.btnTeacherAttendance.Location = New System.Drawing.Point(24, 114)
        Me.btnTeacherAttendance.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTeacherAttendance.Name = "btnTeacherAttendance"
        Me.btnTeacherAttendance.Size = New System.Drawing.Size(256, 54)
        Me.btnTeacherAttendance.TabIndex = 37
        Me.btnTeacherAttendance.Text = "Manage Attendance"
        Me.btnTeacherAttendance.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel7.Controls.Add(Me.PictureBox6)
        Me.Panel7.Controls.Add(Me.btnTeacherGrades)
        Me.Panel7.Location = New System.Drawing.Point(-449, 0)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(303, 186)
        Me.Panel7.TabIndex = 37
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.EduTrack.My.Resources.Resources.test
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox6.Location = New System.Drawing.Point(75, 30)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(149, 78)
        Me.PictureBox6.TabIndex = 38
        Me.PictureBox6.TabStop = False
        '
        'btnTeacherGrades
        '
        Me.btnTeacherGrades.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnTeacherGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeacherGrades.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeacherGrades.ForeColor = System.Drawing.Color.White
        Me.btnTeacherGrades.Location = New System.Drawing.Point(23, 114)
        Me.btnTeacherGrades.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTeacherGrades.Name = "btnTeacherGrades"
        Me.btnTeacherGrades.Size = New System.Drawing.Size(256, 54)
        Me.btnTeacherGrades.TabIndex = 37
        Me.btnTeacherGrades.Text = "Manage Grades"
        Me.btnTeacherGrades.UseVisualStyleBackColor = False
        '
        'btnStudentAttendance
        '
        Me.btnStudentAttendance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnStudentAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentAttendance.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentAttendance.ForeColor = System.Drawing.Color.White
        Me.btnStudentAttendance.Location = New System.Drawing.Point(24, 114)
        Me.btnStudentAttendance.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStudentAttendance.Name = "btnStudentAttendance"
        Me.btnStudentAttendance.Size = New System.Drawing.Size(256, 54)
        Me.btnStudentAttendance.TabIndex = 37
        Me.btnStudentAttendance.Text = "View Attendance"
        Me.btnStudentAttendance.UseVisualStyleBackColor = False
        '
        'pnlAccount
        '
        Me.pnlAccount.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlAccount.Controls.Add(Me.PictureBox3)
        Me.pnlAccount.Controls.Add(Me.btnStudentSettings)
        Me.pnlAccount.Location = New System.Drawing.Point(1356, 278)
        Me.pnlAccount.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlAccount.Name = "pnlAccount"
        Me.pnlAccount.Size = New System.Drawing.Size(303, 186)
        Me.pnlAccount.TabIndex = 33
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.EduTrack.My.Resources.Resources.settings
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(73, 30)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(149, 78)
        Me.PictureBox3.TabIndex = 39
        Me.PictureBox3.TabStop = False
        '
        'btnStudentSettings
        '
        Me.btnStudentSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnStudentSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentSettings.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentSettings.ForeColor = System.Drawing.Color.White
        Me.btnStudentSettings.Location = New System.Drawing.Point(21, 114)
        Me.btnStudentSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStudentSettings.Name = "btnStudentSettings"
        Me.btnStudentSettings.Size = New System.Drawing.Size(256, 54)
        Me.btnStudentSettings.TabIndex = 37
        Me.btnStudentSettings.Text = "My Account"
        Me.btnStudentSettings.UseVisualStyleBackColor = False
        '
        'EduTrackDBDS
        '
        Me.EduTrackDBDS.DataSetName = "EduTrackDBDS"
        Me.EduTrackDBDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EduTrackDBDSBindingSource
        '
        Me.EduTrackDBDSBindingSource.DataSource = Me.EduTrackDBDS
        Me.EduTrackDBDSBindingSource.Position = 0
        '
        'pnlMngStudent
        '
        Me.pnlMngStudent.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlMngStudent.Controls.Add(Me.PictureBox4)
        Me.pnlMngStudent.Controls.Add(Me.btnStudentManager)
        Me.pnlMngStudent.Location = New System.Drawing.Point(877, 551)
        Me.pnlMngStudent.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlMngStudent.Name = "pnlMngStudent"
        Me.pnlMngStudent.Size = New System.Drawing.Size(303, 186)
        Me.pnlMngStudent.TabIndex = 39
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.EduTrack.My.Resources.Resources.user
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(99, 30)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(125, 78)
        Me.PictureBox4.TabIndex = 39
        Me.PictureBox4.TabStop = False
        '
        'btnStudentManager
        '
        Me.btnStudentManager.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnStudentManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentManager.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentManager.ForeColor = System.Drawing.Color.White
        Me.btnStudentManager.Location = New System.Drawing.Point(24, 114)
        Me.btnStudentManager.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStudentManager.Name = "btnStudentManager"
        Me.btnStudentManager.Size = New System.Drawing.Size(256, 54)
        Me.btnStudentManager.TabIndex = 37
        Me.btnStudentManager.Text = "Student Manager"
        Me.btnStudentManager.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Black", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(841, 40)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(468, 114)
        Me.lblTitle.TabIndex = 40
        Me.lblTitle.Text = "EduTrack"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlMngGrades
        '
        Me.pnlMngGrades.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlMngGrades.Controls.Add(Me.PictureBox8)
        Me.pnlMngGrades.Controls.Add(Me.btnTeacherGrade)
        Me.pnlMngGrades.Location = New System.Drawing.Point(404, 278)
        Me.pnlMngGrades.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlMngGrades.Name = "pnlMngGrades"
        Me.pnlMngGrades.Size = New System.Drawing.Size(303, 186)
        Me.pnlMngGrades.TabIndex = 42
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImage = Global.EduTrack.My.Resources.Resources.test
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox8.Location = New System.Drawing.Point(75, 30)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(149, 78)
        Me.PictureBox8.TabIndex = 38
        Me.PictureBox8.TabStop = False
        '
        'btnTeacherGrade
        '
        Me.btnTeacherGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnTeacherGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeacherGrade.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeacherGrade.ForeColor = System.Drawing.Color.White
        Me.btnTeacherGrade.Location = New System.Drawing.Point(23, 114)
        Me.btnTeacherGrade.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTeacherGrade.Name = "btnTeacherGrade"
        Me.btnTeacherGrade.Size = New System.Drawing.Size(256, 54)
        Me.btnTeacherGrade.TabIndex = 37
        Me.btnTeacherGrade.Text = "Manage Grades"
        Me.btnTeacherGrade.UseVisualStyleBackColor = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox7.BackgroundImage = Global.EduTrack.My.Resources.Resources.edu
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox7.Location = New System.Drawing.Point(677, 16)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(185, 156)
        Me.PictureBox7.TabIndex = 41
        Me.PictureBox7.TabStop = False
        '
        'btnAccount
        '
        Me.btnAccount.BackgroundImage = Global.EduTrack.My.Resources.Resources.user
        Me.btnAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAccount.FlatAppearance.BorderSize = 0
        Me.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccount.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccount.Location = New System.Drawing.Point(1849, 49)
        Me.btnAccount.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(61, 52)
        Me.btnAccount.TabIndex = 36
        Me.btnAccount.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1678, 808)
        Me.Controls.Add(Me.pnlMngGrades)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlMngStudent)
        Me.Controls.Add(Me.btnAccount)
        Me.Controls.Add(Me.pnlAccount)
        Me.Controls.Add(Me.pnlViewAttendance)
        Me.Controls.Add(Me.pnlViewGrades)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pnlMngAttendance)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin View -Debug"
        Me.Panel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlViewGrades.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlViewAttendance.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMngAttendance.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAccount.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EduTrackDBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EduTrackDBDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMngStudent.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMngGrades.ResumeLayout(False)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblDash As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnDashGrades As Button
    Friend WithEvents pnlViewGrades As Panel
    Friend WithEvents pnlViewAttendance As Panel
    Friend WithEvents pnlAccount As Panel
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnDashAttendance As Button
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAccount As Button
    Friend WithEvents btnStudentGrades As Button
    Friend WithEvents btnStudentAttendance As Button
    Friend WithEvents btnStudentSettings As Button
    Friend WithEvents EduTrackDBDS As EduTrackDBDS
    Friend WithEvents EduTrackDBDSBindingSource As BindingSource
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnAdminManage As Button
    Friend WithEvents pnlMngAttendance As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnTeacherAttendance As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents btnTeacherGrades As Button
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlMngStudent As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnStudentManager As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlMngGrades As Panel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents btnTeacherGrade As Button
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
