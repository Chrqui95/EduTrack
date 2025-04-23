<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRecordsViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecordsViewer))
        Me.TableAdapterManager = New EduTrack.EduTrackDBDSTableAdapters.TableAdapterManager()
        Me.TableTableAdapter = New EduTrack.EduTrackDBDSTableAdapters.TableTableAdapter()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblActiveStatus = New System.Windows.Forms.Label()
        Me.msktxtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.imgEdu = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvMainRecords = New System.Windows.Forms.DataGridView()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsActivatedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EduTrackDBDS = New EduTrack.EduTrackDBDS()
        Me.EduTrackDBDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblEdu = New System.Windows.Forms.Label()
        Me.lblAttendance = New System.Windows.Forms.Label()
        Me.txtRole = New System.Windows.Forms.TextBox()
        Me.txtActivationStatus = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        CType(Me.imgEdu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvMainRecords, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lblRole
        '
        Me.lblRole.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblRole.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblRole.Location = New System.Drawing.Point(500, 280)
        Me.lblRole.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(62, 29)
        Me.lblRole.TabIndex = 126
        Me.lblRole.Text = "Role: "
        Me.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(320, 356)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.Size = New System.Drawing.Size(137, 25)
        Me.txtPassword.TabIndex = 125
        '
        'txtUserID
        '
        Me.txtUserID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(320, 293)
        Me.txtUserID.MaxLength = 30
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(137, 25)
        Me.txtUserID.TabIndex = 124
        '
        'lblPassword
        '
        Me.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(191, 350)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(130, 29)
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
        Me.lblUsername.Location = New System.Drawing.Point(191, 288)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(130, 29)
        Me.lblUsername.TabIndex = 122
        Me.lblUsername.Text = "Username: "
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblActiveStatus
        '
        Me.lblActiveStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblActiveStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblActiveStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblActiveStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActiveStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblActiveStatus.Location = New System.Drawing.Point(797, 280)
        Me.lblActiveStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblActiveStatus.Name = "lblActiveStatus"
        Me.lblActiveStatus.Size = New System.Drawing.Size(92, 51)
        Me.lblActiveStatus.TabIndex = 121
        Me.lblActiveStatus.Text = "Activation Status:"
        Me.lblActiveStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'msktxtPhone
        '
        Me.msktxtPhone.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.msktxtPhone.Location = New System.Drawing.Point(582, 137)
        Me.msktxtPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.msktxtPhone.Mask = "000-0000"
        Me.msktxtPhone.Name = "msktxtPhone"
        Me.msktxtPhone.ReadOnly = True
        Me.msktxtPhone.Size = New System.Drawing.Size(111, 29)
        Me.msktxtPhone.TabIndex = 119
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(582, 215)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(137, 25)
        Me.txtAddress.TabIndex = 117
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(319, 215)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.ReadOnly = True
        Me.txtLName.Size = New System.Drawing.Size(137, 25)
        Me.txtLName.TabIndex = 116
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(319, 141)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.ReadOnly = True
        Me.txtFName.Size = New System.Drawing.Size(137, 25)
        Me.txtFName.TabIndex = 115
        '
        'lblGender
        '
        Me.lblGender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblGender.Location = New System.Drawing.Point(837, 215)
        Me.lblGender.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(70, 29)
        Me.lblGender.TabIndex = 113
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
        Me.lblDOB.Location = New System.Drawing.Point(796, 141)
        Me.lblDOB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(111, 29)
        Me.lblDOB.TabIndex = 112
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
        Me.lblAddress.Location = New System.Drawing.Point(500, 211)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(92, 29)
        Me.lblAddress.TabIndex = 111
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
        Me.lblPhone.Location = New System.Drawing.Point(512, 136)
        Me.lblPhone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(92, 29)
        Me.lblPhone.TabIndex = 110
        Me.lblPhone.Text = "Phone:"
        Me.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLName
        '
        Me.lblLName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLName.BackColor = System.Drawing.Color.Transparent
        Me.lblLName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblLName.Location = New System.Drawing.Point(205, 211)
        Me.lblLName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(130, 29)
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
        Me.lblFName.Location = New System.Drawing.Point(205, 136)
        Me.lblFName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(130, 29)
        Me.lblFName.TabIndex = 108
        Me.lblFName.Text = "First Name:"
        Me.lblFName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnView.FlatAppearance.BorderSize = 0
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Image = Global.EduTrack.My.Resources.Resources.check1
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.Location = New System.Drawing.Point(26, 234)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(167, 50)
        Me.btnView.TabIndex = 0
        Me.btnView.Text = "View Record"
        Me.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnView.UseVisualStyleBackColor = False
        '
        'imgEdu
        '
        Me.imgEdu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgEdu.BackgroundImage = Global.EduTrack.My.Resources.Resources.edu
        Me.imgEdu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgEdu.Location = New System.Drawing.Point(10, 38)
        Me.imgEdu.Name = "imgEdu"
        Me.imgEdu.Size = New System.Drawing.Size(77, 69)
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
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1209, 29)
        Me.MenuStrip1.TabIndex = 101
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 50, 0)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(40, 25)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OptionsToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 50, 0)
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(68, 25)
        Me.OptionsToolStripMenuItem.Text = "Options"
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
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutUsToolStripMenuItem.Text = "About Program"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HelpToolStripMenuItem.Text = "About Company"
        '
        'HowToToolStripMenuItem
        '
        Me.HowToToolStripMenuItem.Name = "HowToToolStripMenuItem"
        Me.HowToToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HowToToolStripMenuItem.Text = "How To"
        '
        'dgvMainRecords
        '
        Me.dgvMainRecords.AutoGenerateColumns = False
        Me.dgvMainRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMainRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIDDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.CountryDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.RoleDataGridViewTextBoxColumn, Me.IsActivatedDataGridViewCheckBoxColumn})
        Me.dgvMainRecords.DataSource = Me.TableBindingSource
        Me.dgvMainRecords.Location = New System.Drawing.Point(10, 404)
        Me.dgvMainRecords.Name = "dgvMainRecords"
        Me.dgvMainRecords.RowHeadersWidth = 51
        Me.dgvMainRecords.Size = New System.Drawing.Size(1180, 279)
        Me.dgvMainRecords.TabIndex = 103
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.Width = 125
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.Width = 125
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.Width = 125
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.Width = 125
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        Me.DOBDataGridViewTextBoxColumn.Width = 125
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.Width = 125
        '
        'CountryDataGridViewTextBoxColumn
        '
        Me.CountryDataGridViewTextBoxColumn.DataPropertyName = "Country"
        Me.CountryDataGridViewTextBoxColumn.HeaderText = "Country"
        Me.CountryDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CountryDataGridViewTextBoxColumn.Name = "CountryDataGridViewTextBoxColumn"
        Me.CountryDataGridViewTextBoxColumn.Width = 125
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        Me.PhoneNumberDataGridViewTextBoxColumn.Width = 125
        '
        'RoleDataGridViewTextBoxColumn
        '
        Me.RoleDataGridViewTextBoxColumn.DataPropertyName = "Role"
        Me.RoleDataGridViewTextBoxColumn.HeaderText = "Role"
        Me.RoleDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RoleDataGridViewTextBoxColumn.Name = "RoleDataGridViewTextBoxColumn"
        Me.RoleDataGridViewTextBoxColumn.Width = 125
        '
        'IsActivatedDataGridViewCheckBoxColumn
        '
        Me.IsActivatedDataGridViewCheckBoxColumn.DataPropertyName = "IsActivated"
        Me.IsActivatedDataGridViewCheckBoxColumn.HeaderText = "IsActivated"
        Me.IsActivatedDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.IsActivatedDataGridViewCheckBoxColumn.Name = "IsActivatedDataGridViewCheckBoxColumn"
        Me.IsActivatedDataGridViewCheckBoxColumn.Width = 125
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
        Me.lblEdu.Location = New System.Drawing.Point(887, 0)
        Me.lblEdu.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEdu.Name = "lblEdu"
        Me.lblEdu.Size = New System.Drawing.Size(100, 29)
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
        Me.lblAttendance.Location = New System.Drawing.Point(101, 53)
        Me.lblAttendance.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAttendance.Name = "lblAttendance"
        Me.lblAttendance.Size = New System.Drawing.Size(273, 40)
        Me.lblAttendance.TabIndex = 104
        Me.lblAttendance.Text = "View Records"
        Me.lblAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRole
        '
        Me.txtRole.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRole.Location = New System.Drawing.Point(550, 286)
        Me.txtRole.Name = "txtRole"
        Me.txtRole.ReadOnly = True
        Me.txtRole.Size = New System.Drawing.Size(209, 25)
        Me.txtRole.TabIndex = 127
        '
        'txtActivationStatus
        '
        Me.txtActivationStatus.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActivationStatus.Location = New System.Drawing.Point(895, 297)
        Me.txtActivationStatus.Name = "txtActivationStatus"
        Me.txtActivationStatus.ReadOnly = True
        Me.txtActivationStatus.Size = New System.Drawing.Size(236, 25)
        Me.txtActivationStatus.TabIndex = 128
        '
        'txtGender
        '
        Me.txtGender.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.Location = New System.Drawing.Point(912, 221)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ReadOnly = True
        Me.txtGender.Size = New System.Drawing.Size(219, 25)
        Me.txtGender.TabIndex = 129
        '
        'txtDOB
        '
        Me.txtDOB.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDOB.Location = New System.Drawing.Point(912, 146)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.ReadOnly = True
        Me.txtDOB.Size = New System.Drawing.Size(219, 25)
        Me.txtDOB.TabIndex = 130
        '
        'frmRecordsViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1209, 687)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtActivationStatus)
        Me.Controls.Add(Me.txtRole)
        Me.Controls.Add(Me.lblEdu)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblActiveStatus)
        Me.Controls.Add(Me.msktxtPhone)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblLName)
        Me.Controls.Add(Me.lblFName)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.imgEdu)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgvMainRecords)
        Me.Controls.Add(Me.lblAttendance)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmRecordsViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Records"
        CType(Me.imgEdu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvMainRecords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EduTrackDBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EduTrackDBDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableAdapterManager As EduTrackDBDSTableAdapters.TableAdapterManager
    Friend WithEvents TableTableAdapter As EduTrackDBDSTableAdapters.TableTableAdapter
    Friend WithEvents lblRole As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblActiveStatus As Label
    Friend WithEvents msktxtPhone As MaskedTextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblLName As Label
    Friend WithEvents lblFName As Label
    Friend WithEvents btnView As Button
    Friend WithEvents imgEdu As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvMainRecords As DataGridView
    Friend WithEvents UserIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsActivatedDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents EduTrackDBDS As EduTrackDBDS
    Friend WithEvents EduTrackDBDSBindingSource As BindingSource
    Friend WithEvents lblEdu As Label
    Friend WithEvents lblAttendance As Label
    Friend WithEvents txtRole As TextBox
    Friend WithEvents txtActivationStatus As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtDOB As TextBox
    Friend WithEvents HowToToolStripMenuItem As ToolStripMenuItem
End Class
