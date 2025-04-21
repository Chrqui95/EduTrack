<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMyAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMyAccount))
        Me.TableAdapterManager = New EduTrack.EduTrackDBDSTableAdapters.TableAdapterManager()
        Me.TableTableAdapter = New EduTrack.EduTrackDBDSTableAdapters.TableTableAdapter()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.imgEdu = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EduTrackDBDS = New EduTrack.EduTrackDBDS()
        Me.EduTrackDBDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblEdu = New System.Windows.Forms.Label()
        Me.lblAttendance = New System.Windows.Forms.Label()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtStudentEmail = New System.Windows.Forms.TextBox()
        Me.txtRole = New System.Windows.Forms.TextBox()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblStudentEmail = New System.Windows.Forms.Label()
        Me.msktxtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.clbCourses = New System.Windows.Forms.CheckedListBox()
        Me.lblCourses = New System.Windows.Forms.Label()
        CType(Me.imgEdu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EduTrackDBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EduTrackDBDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StudentRecordsTableAdapter = Nothing
        Me.TableAdapterManager.TableTableAdapter = Me.TableTableAdapter
        Me.TableAdapterManager.UpdateOrder = EduTrack.EduTrackDBDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(392, 215)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(181, 29)
        Me.txtPassword.TabIndex = 125
        '
        'txtUserID
        '
        Me.txtUserID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(158, 642)
        Me.txtUserID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserID.MaxLength = 30
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(181, 29)
        Me.txtUserID.TabIndex = 124
        '
        'lblPassword
        '
        Me.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(203, 215)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(173, 36)
        Me.lblPassword.TabIndex = 123
        Me.lblPassword.Text = "Password:"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(6, 635)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(173, 36)
        Me.lblUsername.TabIndex = 122
        Me.lblUsername.Text = "Username: "
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(158, 493)
        Me.txtLName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.ReadOnly = True
        Me.txtLName.Size = New System.Drawing.Size(181, 29)
        Me.txtLName.TabIndex = 116
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(158, 350)
        Me.txtFName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.ReadOnly = True
        Me.txtFName.Size = New System.Drawing.Size(181, 29)
        Me.txtFName.TabIndex = 115
        '
        'lblLName
        '
        Me.lblLName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLName.BackColor = System.Drawing.Color.Transparent
        Me.lblLName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblLName.Location = New System.Drawing.Point(6, 488)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(173, 36)
        Me.lblLName.TabIndex = 109
        Me.lblLName.Text = "Last Name:"
        Me.lblLName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFName
        '
        Me.lblFName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFName.BackColor = System.Drawing.Color.Transparent
        Me.lblFName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblFName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblFName.Location = New System.Drawing.Point(6, 345)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(173, 36)
        Me.lblFName.TabIndex = 108
        Me.lblFName.Text = "First Name:"
        Me.lblFName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.EduTrack.My.Resources.Resources.diskette
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(43, 199)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(136, 57)
        Me.btnSave.TabIndex = 107
        Me.btnSave.Text = "  Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'imgEdu
        '
        Me.imgEdu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgEdu.BackgroundImage = Global.EduTrack.My.Resources.Resources.edu
        Me.imgEdu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgEdu.Location = New System.Drawing.Point(13, 47)
        Me.imgEdu.Margin = New System.Windows.Forms.Padding(4)
        Me.imgEdu.Name = "imgEdu"
        Me.imgEdu.Size = New System.Drawing.Size(103, 85)
        Me.imgEdu.TabIndex = 105
        Me.imgEdu.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Teal
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1612, 36)
        Me.MenuStrip1.TabIndex = 101
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
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
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
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.EduTrackDBDS
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
        'lblEdu
        '
        Me.lblEdu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEdu.BackColor = System.Drawing.Color.Teal
        Me.lblEdu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblEdu.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdu.ForeColor = System.Drawing.Color.White
        Me.lblEdu.Location = New System.Drawing.Point(1188, 7)
        Me.lblEdu.Name = "lblEdu"
        Me.lblEdu.Size = New System.Drawing.Size(133, 36)
        Me.lblEdu.TabIndex = 102
        Me.lblEdu.Text = "EduTrack"
        Me.lblEdu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAttendance
        '
        Me.lblAttendance.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAttendance.BackColor = System.Drawing.Color.Transparent
        Me.lblAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAttendance.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttendance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblAttendance.Location = New System.Drawing.Point(135, 65)
        Me.lblAttendance.Name = "lblAttendance"
        Me.lblAttendance.Size = New System.Drawing.Size(364, 49)
        Me.lblAttendance.TabIndex = 104
        Me.lblAttendance.Text = "My Account"
        Me.lblAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDOB
        '
        Me.txtDOB.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDOB.Location = New System.Drawing.Point(1206, 352)
        Me.txtDOB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.ReadOnly = True
        Me.txtDOB.Size = New System.Drawing.Size(291, 29)
        Me.txtDOB.TabIndex = 142
        '
        'txtGender
        '
        Me.txtGender.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.Location = New System.Drawing.Point(1206, 495)
        Me.txtGender.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ReadOnly = True
        Me.txtGender.Size = New System.Drawing.Size(291, 29)
        Me.txtGender.TabIndex = 141
        '
        'txtStudentEmail
        '
        Me.txtStudentEmail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentEmail.Location = New System.Drawing.Point(1206, 642)
        Me.txtStudentEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStudentEmail.Name = "txtStudentEmail"
        Me.txtStudentEmail.ReadOnly = True
        Me.txtStudentEmail.Size = New System.Drawing.Size(291, 29)
        Me.txtStudentEmail.TabIndex = 140
        '
        'txtRole
        '
        Me.txtRole.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRole.Location = New System.Drawing.Point(665, 642)
        Me.txtRole.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRole.Name = "txtRole"
        Me.txtRole.ReadOnly = True
        Me.txtRole.Size = New System.Drawing.Size(206, 29)
        Me.txtRole.TabIndex = 139
        '
        'lblRole
        '
        Me.lblRole.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblRole.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblRole.Location = New System.Drawing.Point(593, 635)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(82, 36)
        Me.lblRole.TabIndex = 138
        Me.lblRole.Text = "Role: "
        Me.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStudentEmail
        '
        Me.lblStudentEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStudentEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblStudentEmail.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblStudentEmail.Location = New System.Drawing.Point(1017, 622)
        Me.lblStudentEmail.Name = "lblStudentEmail"
        Me.lblStudentEmail.Size = New System.Drawing.Size(182, 63)
        Me.lblStudentEmail.TabIndex = 137
        Me.lblStudentEmail.Text = "Student Email:"
        Me.lblStudentEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'msktxtPhone
        '
        Me.msktxtPhone.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.msktxtPhone.Location = New System.Drawing.Point(665, 343)
        Me.msktxtPhone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.msktxtPhone.Mask = "000-0000"
        Me.msktxtPhone.Name = "msktxtPhone"
        Me.msktxtPhone.ReadOnly = True
        Me.msktxtPhone.Size = New System.Drawing.Size(206, 34)
        Me.msktxtPhone.TabIndex = 136
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(665, 495)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(206, 29)
        Me.txtAddress.TabIndex = 135
        '
        'lblGender
        '
        Me.lblGender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblGender.Location = New System.Drawing.Point(1106, 488)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(93, 36)
        Me.lblGender.TabIndex = 134
        Me.lblGender.Text = "Gender:"
        Me.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDOB
        '
        Me.lblDOB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDOB.BackColor = System.Drawing.Color.Transparent
        Me.lblDOB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDOB.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblDOB.Location = New System.Drawing.Point(1052, 345)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(148, 36)
        Me.lblDOB.TabIndex = 133
        Me.lblDOB.Text = "Date Of Birth:"
        Me.lblDOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAddress
        '
        Me.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(565, 488)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(123, 36)
        Me.lblAddress.TabIndex = 132
        Me.lblAddress.Text = "Address:"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPhone
        '
        Me.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPhone.BackColor = System.Drawing.Color.Transparent
        Me.lblPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblPhone.Location = New System.Drawing.Point(565, 343)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(123, 36)
        Me.lblPhone.TabIndex = 131
        Me.lblPhone.Text = "Phone:"
        Me.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'clbCourses
        '
        Me.clbCourses.FormattingEnabled = True
        Me.clbCourses.Items.AddRange(New Object() {"ComputerScience", "Biology", "Bio/Chem", "Accounting", "Math/Physics", "Bio/Math", "PrimaryEd"})
        Me.clbCourses.Location = New System.Drawing.Point(831, 133)
        Me.clbCourses.Margin = New System.Windows.Forms.Padding(4)
        Me.clbCourses.Name = "clbCourses"
        Me.clbCourses.Size = New System.Drawing.Size(279, 123)
        Me.clbCourses.TabIndex = 143
        Me.clbCourses.Visible = False
        '
        'lblCourses
        '
        Me.lblCourses.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCourses.BackColor = System.Drawing.Color.Transparent
        Me.lblCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCourses.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblCourses.Location = New System.Drawing.Point(660, 182)
        Me.lblCourses.Name = "lblCourses"
        Me.lblCourses.Size = New System.Drawing.Size(148, 36)
        Me.lblCourses.TabIndex = 144
        Me.lblCourses.Text = "Courses"
        Me.lblCourses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMyAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1612, 846)
        Me.Controls.Add(Me.lblCourses)
        Me.Controls.Add(Me.clbCourses)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtStudentEmail)
        Me.Controls.Add(Me.txtRole)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.lblStudentEmail)
        Me.Controls.Add(Me.msktxtPhone)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.lblLName)
        Me.Controls.Add(Me.lblFName)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.imgEdu)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblEdu)
        Me.Controls.Add(Me.lblAttendance)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmMyAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Account"
        CType(Me.imgEdu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EduTrackDBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EduTrackDBDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableAdapterManager As EduTrackDBDSTableAdapters.TableAdapterManager
    Friend WithEvents TableTableAdapter As EduTrackDBDSTableAdapters.TableTableAdapter
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents lblLName As Label
    Friend WithEvents lblFName As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents imgEdu As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents EduTrackDBDS As EduTrackDBDS
    Friend WithEvents EduTrackDBDSBindingSource As BindingSource
    Friend WithEvents lblEdu As Label
    Friend WithEvents lblAttendance As Label
    Friend WithEvents txtDOB As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtStudentEmail As TextBox
    Friend WithEvents txtRole As TextBox
    Friend WithEvents lblRole As Label
    Friend WithEvents lblStudentEmail As Label
    Friend WithEvents msktxtPhone As MaskedTextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents clbCourses As CheckedListBox
    Friend WithEvents lblCourses As Label
End Class
