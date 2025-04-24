<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlViewAllRecords = New System.Windows.Forms.Panel()
        Me.btnViewAllRecords = New System.Windows.Forms.Button()
        Me.pnlEditMainRecords = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnTeacherGrades = New System.Windows.Forms.Button()
        Me.btnEditMainRecords = New System.Windows.Forms.Button()
        Me.pnlDelete = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.pnlAccount = New System.Windows.Forms.Panel()
        Me.btnMyAccount = New System.Windows.Forms.Button()
        Me.EduTrackDBDS = New EduTrack.EduTrackDBDS()
        Me.EduTrackDBDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlEditStudentRecords = New System.Windows.Forms.Panel()
        Me.btnEditStudentRecords = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlCreateNewRecords = New System.Windows.Forms.Panel()
        Me.btnCreateNewRecords = New System.Windows.Forms.Button()
        Me.Version = New System.Windows.Forms.Label()
        Me.frmMind = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlViewAllRecords.SuspendLayout()
        Me.pnlEditMainRecords.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.pnlDelete.SuspendLayout()
        Me.pnlAccount.SuspendLayout()
        CType(Me.EduTrackDBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EduTrackDBDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEditStudentRecords.SuspendLayout()
        Me.pnlCreateNewRecords.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Teal
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(954, 29)
        Me.MenuStrip1.TabIndex = 28
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ExitToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 50, 0)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(40, 25)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Image = Global.EduTrack.My.Resources.Resources.power_off
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(206, 26)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        Me.ExitToolStripMenuItem1.ToolTipText = "Exit the application."
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditRecordToolStripMenuItem, Me.DeleteRecordToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OptionsToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 50, 0)
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(43, 25)
        Me.OptionsToolStripMenuItem.Text = "Edit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutUsToolStripMenuItem, Me.HelpToolStripMenuItem, Me.HowToToolStripMenuItem})
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(58, 25)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.AboutUsToolStripMenuItem.Text = "About Program"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.HelpToolStripMenuItem.Text = "About Company"
        '
        'HowToToolStripMenuItem
        '
        Me.HowToToolStripMenuItem.Name = "HowToToolStripMenuItem"
        Me.HowToToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HowToToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.HowToToolStripMenuItem.Text = "How To"
        Me.HowToToolStripMenuItem.ToolTipText = "Guide on how to use the program."
        '
        'pnlViewAllRecords
        '
        Me.pnlViewAllRecords.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlViewAllRecords.Controls.Add(Me.PictureBox1)
        Me.pnlViewAllRecords.Controls.Add(Me.btnViewAllRecords)
        Me.pnlViewAllRecords.Location = New System.Drawing.Point(22, 374)
        Me.pnlViewAllRecords.Name = "pnlViewAllRecords"
        Me.pnlViewAllRecords.Size = New System.Drawing.Size(227, 151)
        Me.pnlViewAllRecords.TabIndex = 31
        '
        'btnViewAllRecords
        '
        Me.btnViewAllRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnViewAllRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewAllRecords.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAllRecords.ForeColor = System.Drawing.Color.White
        Me.btnViewAllRecords.Location = New System.Drawing.Point(17, 93)
        Me.btnViewAllRecords.Name = "btnViewAllRecords"
        Me.btnViewAllRecords.Size = New System.Drawing.Size(192, 44)
        Me.btnViewAllRecords.TabIndex = 3
        Me.btnViewAllRecords.Text = "View All Records"
        Me.btnViewAllRecords.UseVisualStyleBackColor = False
        '
        'pnlEditMainRecords
        '
        Me.pnlEditMainRecords.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlEditMainRecords.Controls.Add(Me.PictureBox2)
        Me.pnlEditMainRecords.Controls.Add(Me.Panel7)
        Me.pnlEditMainRecords.Controls.Add(Me.btnEditMainRecords)
        Me.pnlEditMainRecords.Location = New System.Drawing.Point(704, 152)
        Me.pnlEditMainRecords.Name = "pnlEditMainRecords"
        Me.pnlEditMainRecords.Size = New System.Drawing.Size(227, 151)
        Me.pnlEditMainRecords.TabIndex = 32
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel7.Controls.Add(Me.PictureBox6)
        Me.Panel7.Controls.Add(Me.btnTeacherGrades)
        Me.Panel7.Location = New System.Drawing.Point(-337, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(227, 151)
        Me.Panel7.TabIndex = 37
        '
        'btnTeacherGrades
        '
        Me.btnTeacherGrades.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnTeacherGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeacherGrades.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeacherGrades.ForeColor = System.Drawing.Color.White
        Me.btnTeacherGrades.Location = New System.Drawing.Point(17, 93)
        Me.btnTeacherGrades.Name = "btnTeacherGrades"
        Me.btnTeacherGrades.Size = New System.Drawing.Size(192, 44)
        Me.btnTeacherGrades.TabIndex = 37
        Me.btnTeacherGrades.Text = "Manage Grades"
        Me.btnTeacherGrades.UseVisualStyleBackColor = False
        '
        'btnEditMainRecords
        '
        Me.btnEditMainRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnEditMainRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditMainRecords.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditMainRecords.ForeColor = System.Drawing.Color.White
        Me.btnEditMainRecords.Location = New System.Drawing.Point(18, 93)
        Me.btnEditMainRecords.Name = "btnEditMainRecords"
        Me.btnEditMainRecords.Size = New System.Drawing.Size(192, 44)
        Me.btnEditMainRecords.TabIndex = 2
        Me.btnEditMainRecords.Text = "Edit Main Records"
        Me.btnEditMainRecords.UseVisualStyleBackColor = False
        '
        'pnlDelete
        '
        Me.pnlDelete.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlDelete.Controls.Add(Me.PictureBox5)
        Me.pnlDelete.Controls.Add(Me.btnDelete)
        Me.pnlDelete.Location = New System.Drawing.Point(22, 152)
        Me.pnlDelete.Name = "pnlDelete"
        Me.pnlDelete.Size = New System.Drawing.Size(227, 151)
        Me.pnlDelete.TabIndex = 38
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(18, 93)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(192, 44)
        Me.btnDelete.TabIndex = 0
        Me.btnDelete.Text = "Delete Records"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'pnlAccount
        '
        Me.pnlAccount.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlAccount.Controls.Add(Me.PictureBox3)
        Me.pnlAccount.Controls.Add(Me.btnMyAccount)
        Me.pnlAccount.Location = New System.Drawing.Point(369, 232)
        Me.pnlAccount.Name = "pnlAccount"
        Me.pnlAccount.Size = New System.Drawing.Size(227, 151)
        Me.pnlAccount.TabIndex = 33
        '
        'btnMyAccount
        '
        Me.btnMyAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyAccount.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyAccount.ForeColor = System.Drawing.Color.White
        Me.btnMyAccount.Location = New System.Drawing.Point(16, 93)
        Me.btnMyAccount.Name = "btnMyAccount"
        Me.btnMyAccount.Size = New System.Drawing.Size(192, 44)
        Me.btnMyAccount.TabIndex = 1
        Me.btnMyAccount.Text = "My Account"
        Me.ToolTip1.SetToolTip(Me.btnMyAccount, "Edit account settings and password")
        Me.btnMyAccount.UseVisualStyleBackColor = False
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
        'pnlEditStudentRecords
        '
        Me.pnlEditStudentRecords.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlEditStudentRecords.Controls.Add(Me.PictureBox4)
        Me.pnlEditStudentRecords.Controls.Add(Me.btnEditStudentRecords)
        Me.pnlEditStudentRecords.Location = New System.Drawing.Point(369, 466)
        Me.pnlEditStudentRecords.Name = "pnlEditStudentRecords"
        Me.pnlEditStudentRecords.Size = New System.Drawing.Size(227, 151)
        Me.pnlEditStudentRecords.TabIndex = 39
        '
        'btnEditStudentRecords
        '
        Me.btnEditStudentRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnEditStudentRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditStudentRecords.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditStudentRecords.ForeColor = System.Drawing.Color.White
        Me.btnEditStudentRecords.Location = New System.Drawing.Point(18, 93)
        Me.btnEditStudentRecords.Name = "btnEditStudentRecords"
        Me.btnEditStudentRecords.Size = New System.Drawing.Size(192, 44)
        Me.btnEditStudentRecords.TabIndex = 4
        Me.btnEditStudentRecords.Text = "Edit Student Records"
        Me.btnEditStudentRecords.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Black", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(367, 50)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(351, 93)
        Me.lblTitle.TabIndex = 40
        Me.lblTitle.Text = "EduTrack"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlCreateNewRecords
        '
        Me.pnlCreateNewRecords.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlCreateNewRecords.Controls.Add(Me.PictureBox8)
        Me.pnlCreateNewRecords.Controls.Add(Me.btnCreateNewRecords)
        Me.pnlCreateNewRecords.Location = New System.Drawing.Point(704, 398)
        Me.pnlCreateNewRecords.Name = "pnlCreateNewRecords"
        Me.pnlCreateNewRecords.Size = New System.Drawing.Size(227, 151)
        Me.pnlCreateNewRecords.TabIndex = 42
        '
        'btnCreateNewRecords
        '
        Me.btnCreateNewRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnCreateNewRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateNewRecords.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateNewRecords.ForeColor = System.Drawing.Color.White
        Me.btnCreateNewRecords.Location = New System.Drawing.Point(17, 93)
        Me.btnCreateNewRecords.Name = "btnCreateNewRecords"
        Me.btnCreateNewRecords.Size = New System.Drawing.Size(192, 44)
        Me.btnCreateNewRecords.TabIndex = 5
        Me.btnCreateNewRecords.Text = "Create New Records"
        Me.btnCreateNewRecords.UseVisualStyleBackColor = False
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.Font = New System.Drawing.Font("Cascadia Mono Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.ForeColor = System.Drawing.Color.Teal
        Me.Version.Location = New System.Drawing.Point(798, 630)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(144, 17)
        Me.Version.TabIndex = 43
        Me.Version.Text = "Pre-Release 1.0.0"
        '
        'frmMind
        '
        Me.frmMind.AutoSize = True
        Me.frmMind.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmMind.Location = New System.Drawing.Point(411, 127)
        Me.frmMind.Name = "frmMind"
        Me.frmMind.Size = New System.Drawing.Size(148, 16)
        Me.frmMind.TabIndex = 48
        Me.frmMind.Text = "By MindFrame Studios"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.EduTrack.My.Resources.Resources.check
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(74, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(94, 63)
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.EduTrack.My.Resources.Resources.test
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox6.Location = New System.Drawing.Point(56, 24)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(112, 63)
        Me.PictureBox6.TabIndex = 38
        Me.PictureBox6.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImage = Global.EduTrack.My.Resources.Resources.test
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox8.Location = New System.Drawing.Point(56, 24)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(112, 63)
        Me.PictureBox8.TabIndex = 38
        Me.PictureBox8.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.EduTrack.My.Resources.Resources.user
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(74, 24)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(94, 63)
        Me.PictureBox4.TabIndex = 39
        Me.PictureBox4.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox7.BackgroundImage = Global.EduTrack.My.Resources.Resources.edu
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox7.Location = New System.Drawing.Point(255, 32)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(139, 127)
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
        Me.btnAccount.Location = New System.Drawing.Point(1387, 40)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(46, 42)
        Me.btnAccount.TabIndex = 36
        Me.btnAccount.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.EduTrack.My.Resources.Resources.settings
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(55, 24)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(112, 63)
        Me.PictureBox3.TabIndex = 39
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.EduTrack.My.Resources.Resources.test
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(56, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 63)
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Image = Global.EduTrack.My.Resources.Resources.plus
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.HomeToolStripMenuItem.Text = "&New Record"
        Me.HomeToolStripMenuItem.ToolTipText = "Create a new user record."
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.EduTrack.My.Resources.Resources.view
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.ExitToolStripMenuItem.Text = "View Records"
        Me.ExitToolStripMenuItem.ToolTipText = "View all user records."
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = Global.EduTrack.My.Resources.Resources.exit__1_
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.LogoutToolStripMenuItem.Text = "Log Out"
        Me.LogoutToolStripMenuItem.ToolTipText = "Log out of your account."
        '
        'EditRecordToolStripMenuItem
        '
        Me.EditRecordToolStripMenuItem.Image = Global.EduTrack.My.Resources.Resources.pencil
        Me.EditRecordToolStripMenuItem.Name = "EditRecordToolStripMenuItem"
        Me.EditRecordToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditRecordToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.EditRecordToolStripMenuItem.Text = "Edit Record"
        Me.EditRecordToolStripMenuItem.ToolTipText = "Edit the main user records."
        '
        'DeleteRecordToolStripMenuItem
        '
        Me.DeleteRecordToolStripMenuItem.Image = Global.EduTrack.My.Resources.Resources.delete__1_
        Me.DeleteRecordToolStripMenuItem.Name = "DeleteRecordToolStripMenuItem"
        Me.DeleteRecordToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteRecordToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.DeleteRecordToolStripMenuItem.Text = "Delete Record"
        Me.DeleteRecordToolStripMenuItem.ToolTipText = "Delete records from the users."
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.EduTrack.My.Resources.Resources.delete__1_
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(74, 24)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(94, 63)
        Me.PictureBox5.TabIndex = 39
        Me.PictureBox5.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(954, 656)
        Me.Controls.Add(Me.frmMind)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.pnlEditMainRecords)
        Me.Controls.Add(Me.pnlCreateNewRecords)
        Me.Controls.Add(Me.pnlEditStudentRecords)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnAccount)
        Me.Controls.Add(Me.pnlAccount)
        Me.Controls.Add(Me.pnlViewAllRecords)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pnlDelete)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EduTrack"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlViewAllRecords.ResumeLayout(False)
        Me.pnlEditMainRecords.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.pnlDelete.ResumeLayout(False)
        Me.pnlAccount.ResumeLayout(False)
        CType(Me.EduTrackDBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EduTrackDBDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEditStudentRecords.ResumeLayout(False)
        Me.pnlCreateNewRecords.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents pnlViewAllRecords As Panel
    Friend WithEvents pnlEditMainRecords As Panel
    Friend WithEvents pnlAccount As Panel
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAccount As Button
    Friend WithEvents btnViewAllRecords As Button
    Friend WithEvents btnEditMainRecords As Button
    Friend WithEvents btnMyAccount As Button
    Friend WithEvents EduTrackDBDS As EduTrackDBDS
    Friend WithEvents EduTrackDBDSBindingSource As BindingSource
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents pnlDelete As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents btnTeacherGrades As Button
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlEditStudentRecords As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnEditStudentRecords As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlCreateNewRecords As Panel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents btnCreateNewRecords As Button
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HowToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Version As Label
    Friend WithEvents frmMind As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
