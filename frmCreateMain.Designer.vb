<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCreateMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreateMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblEdu = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        Me.btnAddRecord = New System.Windows.Forms.Button()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.imgEdu = New System.Windows.Forms.PictureBox()
        Me.msktxtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.lstGender = New System.Windows.Forms.ListBox()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.clbActiveStatus = New System.Windows.Forms.CheckedListBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.lblActiveStatus = New System.Windows.Forms.Label()
        Me.TableTableAdapter = New EduTrack.EduTrackDBDSTableAdapters.TableTableAdapter()
        Me.TableAdapterManager = New EduTrack.EduTrackDBDSTableAdapters.TableAdapterManager()
        Me.lstRole = New System.Windows.Forms.ListBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EduTrackDBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EduTrackDBDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgEdu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Teal
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1335, 36)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 50, 0)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 32)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(122, 28)
        Me.ExitToolStripMenuItem.Text = "Exit"
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
        'lblEdu
        '
        Me.lblEdu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEdu.BackColor = System.Drawing.Color.Teal
        Me.lblEdu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblEdu.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdu.ForeColor = System.Drawing.Color.White
        Me.lblEdu.Location = New System.Drawing.Point(1115, 0)
        Me.lblEdu.Name = "lblEdu"
        Me.lblEdu.Size = New System.Drawing.Size(133, 36)
        Me.lblEdu.TabIndex = 31
        Me.lblEdu.Text = "EduTrack"
        Me.lblEdu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIDDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.CountryDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.RoleDataGridViewTextBoxColumn, Me.IsActivatedDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.TableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(26, 416)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1296, 367)
        Me.DataGridView1.TabIndex = 33
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
        'btnAddRecord
        '
        Me.btnAddRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRecord.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRecord.ForeColor = System.Drawing.Color.White
        Me.btnAddRecord.Location = New System.Drawing.Point(1005, 61)
        Me.btnAddRecord.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddRecord.Name = "btnAddRecord"
        Me.btnAddRecord.Size = New System.Drawing.Size(256, 54)
        Me.btnAddRecord.TabIndex = 38
        Me.btnAddRecord.Text = "Add Record"
        Me.btnAddRecord.UseVisualStyleBackColor = False
        '
        'lblGrade
        '
        Me.lblGrade.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGrade.BackColor = System.Drawing.Color.Transparent
        Me.lblGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblGrade.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblGrade.Location = New System.Drawing.Point(544, 57)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(364, 49)
        Me.lblGrade.TabIndex = 41
        Me.lblGrade.Text = "Grade Manager"
        Me.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imgEdu
        '
        Me.imgEdu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgEdu.BackgroundImage = Global.EduTrack.My.Resources.Resources.edu
        Me.imgEdu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgEdu.Location = New System.Drawing.Point(475, 39)
        Me.imgEdu.Margin = New System.Windows.Forms.Padding(4)
        Me.imgEdu.Name = "imgEdu"
        Me.imgEdu.Size = New System.Drawing.Size(103, 85)
        Me.imgEdu.TabIndex = 42
        Me.imgEdu.TabStop = False
        '
        'msktxtPhone
        '
        Me.msktxtPhone.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.msktxtPhone.Location = New System.Drawing.Point(615, 150)
        Me.msktxtPhone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.msktxtPhone.Mask = "000-0000"
        Me.msktxtPhone.Name = "msktxtPhone"
        Me.msktxtPhone.Size = New System.Drawing.Size(181, 34)
        Me.msktxtPhone.TabIndex = 88
        '
        'lstGender
        '
        Me.lstGender.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstGender.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lstGender.FormattingEnabled = True
        Me.lstGender.ItemHeight = 28
        Me.lstGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.lstGender.Location = New System.Drawing.Point(972, 238)
        Me.lstGender.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstGender.Name = "lstGender"
        Me.lstGender.Size = New System.Drawing.Size(332, 32)
        Me.lstGender.TabIndex = 87
        '
        'lblRole
        '
        Me.lblRole.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblRole.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblRole.Location = New System.Drawing.Point(902, 315)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(82, 36)
        Me.lblRole.TabIndex = 85
        Me.lblRole.Text = "Role: "
        Me.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'clbActiveStatus
        '
        Me.clbActiveStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.clbActiveStatus.FormattingEnabled = True
        Me.clbActiveStatus.Items.AddRange(New Object() {"IsActivated"})
        Me.clbActiveStatus.Location = New System.Drawing.Point(624, 313)
        Me.clbActiveStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.clbActiveStatus.Name = "clbActiveStatus"
        Me.clbActiveStatus.Size = New System.Drawing.Size(206, 33)
        Me.clbActiveStatus.TabIndex = 83
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(615, 241)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.MaxLength = 30
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(181, 29)
        Me.txtAddress.TabIndex = 82
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(211, 317)
        Me.txtLName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLName.MaxLength = 30
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(181, 29)
        Me.txtLName.TabIndex = 81
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(211, 241)
        Me.txtFName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFName.MaxLength = 30
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(181, 29)
        Me.txtFName.TabIndex = 80
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd-MM-YYYY"
        Me.dtpDOB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Location = New System.Drawing.Point(973, 150)
        Me.dtpDOB.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(332, 34)
        Me.dtpDOB.TabIndex = 79
        '
        'lblGender
        '
        Me.lblGender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblGender.Location = New System.Drawing.Point(882, 234)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(93, 36)
        Me.lblGender.TabIndex = 78
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
        Me.lblDOB.Location = New System.Drawing.Point(836, 148)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(148, 36)
        Me.lblDOB.TabIndex = 77
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
        Me.lblAddress.Location = New System.Drawing.Point(508, 234)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(123, 36)
        Me.lblAddress.TabIndex = 76
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
        Me.lblPhone.Location = New System.Drawing.Point(520, 150)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(123, 36)
        Me.lblPhone.TabIndex = 75
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
        Me.lblLName.Location = New System.Drawing.Point(40, 315)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(173, 36)
        Me.lblLName.TabIndex = 74
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
        Me.lblFName.Location = New System.Drawing.Point(40, 241)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(173, 36)
        Me.lblFName.TabIndex = 73
        Me.lblFName.Text = "First Name:"
        Me.lblFName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblActiveStatus
        '
        Me.lblActiveStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblActiveStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblActiveStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblActiveStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActiveStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblActiveStatus.Location = New System.Drawing.Point(485, 297)
        Me.lblActiveStatus.Name = "lblActiveStatus"
        Me.lblActiveStatus.Size = New System.Drawing.Size(123, 63)
        Me.lblActiveStatus.TabIndex = 89
        Me.lblActiveStatus.Text = "Activation Status:"
        Me.lblActiveStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StudentRecordsTableAdapter = Nothing
        Me.TableAdapterManager.TableTableAdapter = Me.TableTableAdapter
        Me.TableAdapterManager.UpdateOrder = EduTrack.EduTrackDBDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lstRole
        '
        Me.lstRole.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstRole.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lstRole.FormattingEnabled = True
        Me.lstRole.ItemHeight = 28
        Me.lstRole.Items.AddRange(New Object() {"Admin", "Teacher", "Student/Parent"})
        Me.lstRole.Location = New System.Drawing.Point(973, 319)
        Me.lstRole.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstRole.Name = "lstRole"
        Me.lstRole.Size = New System.Drawing.Size(332, 32)
        Me.lstRole.TabIndex = 90
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(211, 172)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(181, 29)
        Me.txtPassword.TabIndex = 94
        '
        'txtUserID
        '
        Me.txtUserID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(211, 95)
        Me.txtUserID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserID.MaxLength = 30
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(181, 29)
        Me.txtUserID.TabIndex = 93
        '
        'lblPassword
        '
        Me.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(40, 165)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(173, 36)
        Me.lblPassword.TabIndex = 92
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
        Me.lblUsername.Location = New System.Drawing.Point(40, 88)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(173, 36)
        Me.lblUsername.TabIndex = 91
        Me.lblUsername.Text = "Username: "
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCreateMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1335, 796)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lstRole)
        Me.Controls.Add(Me.lblActiveStatus)
        Me.Controls.Add(Me.msktxtPhone)
        Me.Controls.Add(Me.lstGender)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.clbActiveStatus)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblLName)
        Me.Controls.Add(Me.lblFName)
        Me.Controls.Add(Me.imgEdu)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.btnAddRecord)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblEdu)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmCreateMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grade Manager"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EduTrackDBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EduTrackDBDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgEdu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblEdu As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EduTrackDBDSBindingSource As BindingSource
    Friend WithEvents EduTrackDBDS As EduTrackDBDS
    Friend WithEvents btnAddRecord As Button
    Friend WithEvents lblGrade As Label
    Friend WithEvents imgEdu As PictureBox
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents msktxtPhone As MaskedTextBox
    Friend WithEvents lstGender As ListBox
    Friend WithEvents lblRole As Label
    Friend WithEvents clbActiveStatus As CheckedListBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents lblGender As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblLName As Label
    Friend WithEvents lblFName As Label
    Friend WithEvents lblActiveStatus As Label
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents TableTableAdapter As EduTrackDBDSTableAdapters.TableTableAdapter
    Friend WithEvents TableAdapterManager As EduTrackDBDSTableAdapters.TableAdapterManager
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
    Friend WithEvents lstRole As ListBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
End Class
