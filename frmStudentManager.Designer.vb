<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentManager))
        Me.lblStudent = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblEdu = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.imgEdu = New System.Windows.Forms.PictureBox()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.dtpStudent = New System.Windows.Forms.DateTimePicker()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.clbCourses = New System.Windows.Forms.CheckedListBox()
        Me.btnCourses = New System.Windows.Forms.Button()
        Me.dgvStudentRecord = New System.Windows.Forms.DataGridView()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoursesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentRecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EduTrackDBDS = New EduTrack.EduTrackDBDS()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblStudentEmail = New System.Windows.Forms.Label()
        Me.msktxtStudentEmail = New System.Windows.Forms.MaskedTextBox()
        Me.lstGender = New System.Windows.Forms.ListBox()
        Me.StudentRecordsTableAdapter = New EduTrack.EduTrackDBDSTableAdapters.StudentRecordsTableAdapter()
        Me.msktxtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.imgEdu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStudentRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentRecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EduTrackDBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStudent
        '
        Me.lblStudent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStudent.BackColor = System.Drawing.Color.Transparent
        Me.lblStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblStudent.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblStudent.Location = New System.Drawing.Point(144, 57)
        Me.lblStudent.Name = "lblStudent"
        Me.lblStudent.Size = New System.Drawing.Size(364, 49)
        Me.lblStudent.TabIndex = 43
        Me.lblStudent.Text = "Student Manager"
        Me.lblStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Teal
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1612, 36)
        Me.MenuStrip1.TabIndex = 45
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
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
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.AboutUsToolStripMenuItem.Text = "About Us"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'lblEdu
        '
        Me.lblEdu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEdu.BackColor = System.Drawing.Color.Teal
        Me.lblEdu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblEdu.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdu.ForeColor = System.Drawing.Color.White
        Me.lblEdu.Location = New System.Drawing.Point(1403, 0)
        Me.lblEdu.Name = "lblEdu"
        Me.lblEdu.Size = New System.Drawing.Size(133, 36)
        Me.lblEdu.TabIndex = 48
        Me.lblEdu.Text = "EduTrack"
        Me.lblEdu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.EduTrack.My.Resources.Resources.diskette
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(59, 242)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(136, 57)
        Me.btnSave.TabIndex = 50
        Me.btnSave.Text = "  Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = Global.EduTrack.My.Resources.Resources.check1
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(13, 145)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(223, 62)
        Me.btnEdit.TabIndex = 49
        Me.btnEdit.Text = "Edit Student Record"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'imgEdu
        '
        Me.imgEdu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgEdu.BackgroundImage = Global.EduTrack.My.Resources.Resources.edu
        Me.imgEdu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgEdu.Location = New System.Drawing.Point(57, 41)
        Me.imgEdu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.imgEdu.Name = "imgEdu"
        Me.imgEdu.Size = New System.Drawing.Size(103, 85)
        Me.imgEdu.TabIndex = 44
        Me.imgEdu.TabStop = False
        '
        'lblFName
        '
        Me.lblFName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFName.BackColor = System.Drawing.Color.Transparent
        Me.lblFName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblFName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblFName.Location = New System.Drawing.Point(301, 171)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(173, 36)
        Me.lblFName.TabIndex = 52
        Me.lblFName.Text = "First Name:"
        Me.lblFName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLName
        '
        Me.lblLName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLName.BackColor = System.Drawing.Color.Transparent
        Me.lblLName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblLName.Location = New System.Drawing.Point(301, 263)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(173, 36)
        Me.lblLName.TabIndex = 53
        Me.lblLName.Text = "Last Name:"
        Me.lblLName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPhone
        '
        Me.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPhone.BackColor = System.Drawing.Color.Transparent
        Me.lblPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblPhone.Location = New System.Drawing.Point(739, 170)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(123, 36)
        Me.lblPhone.TabIndex = 54
        Me.lblPhone.Text = "Phone:"
        Me.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAddress
        '
        Me.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(724, 262)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(123, 36)
        Me.lblAddress.TabIndex = 55
        Me.lblAddress.Text = "Address:"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDOB
        '
        Me.lblDOB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDOB.BackColor = System.Drawing.Color.Transparent
        Me.lblDOB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDOB.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblDOB.Location = New System.Drawing.Point(1063, 170)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(148, 36)
        Me.lblDOB.TabIndex = 56
        Me.lblDOB.Text = "Date Of Birth:"
        Me.lblDOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGender
        '
        Me.lblGender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblGender.Location = New System.Drawing.Point(1117, 262)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(93, 36)
        Me.lblGender.TabIndex = 57
        Me.lblGender.Text = "Gender:"
        Me.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpStudent
        '
        Me.dtpStudent.CustomFormat = "dd-MM-YYYY"
        Me.dtpStudent.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStudent.Location = New System.Drawing.Point(1203, 171)
        Me.dtpStudent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpStudent.Name = "dtpStudent"
        Me.dtpStudent.Size = New System.Drawing.Size(332, 34)
        Me.dtpStudent.TabIndex = 58
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(453, 176)
        Me.txtFName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(181, 29)
        Me.txtFName.TabIndex = 60
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(453, 268)
        Me.txtLName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(181, 29)
        Me.txtLName.TabIndex = 61
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(833, 267)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(181, 29)
        Me.txtAddress.TabIndex = 63
        '
        'clbCourses
        '
        Me.clbCourses.FormattingEnabled = True
        Me.clbCourses.Items.AddRange(New Object() {"ComputerScience", "Biology", "Bio/Chem", "Accounting", "Math/Physics", "Bio/Math", "PrimaryEd"})
        Me.clbCourses.Location = New System.Drawing.Point(644, 338)
        Me.clbCourses.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.clbCourses.Name = "clbCourses"
        Me.clbCourses.Size = New System.Drawing.Size(279, 123)
        Me.clbCourses.TabIndex = 66
        Me.clbCourses.Visible = False
        '
        'btnCourses
        '
        Me.btnCourses.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCourses.BackgroundImage = Global.EduTrack.My.Resources.Resources.settings
        Me.btnCourses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCourses.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCourses.Location = New System.Drawing.Point(453, 332)
        Me.btnCourses.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCourses.Name = "btnCourses"
        Me.btnCourses.Size = New System.Drawing.Size(183, 37)
        Me.btnCourses.TabIndex = 67
        Me.btnCourses.Text = "Show Courses"
        Me.btnCourses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCourses.UseVisualStyleBackColor = False
        '
        'dgvStudentRecord
        '
        Me.dgvStudentRecord.AutoGenerateColumns = False
        Me.dgvStudentRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudentRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DOBDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn3, Me.StudentEmailDataGridViewTextBoxColumn, Me.CoursesDataGridViewTextBoxColumn})
        Me.dgvStudentRecord.DataSource = Me.StudentRecordsBindingSource
        Me.dgvStudentRecord.Location = New System.Drawing.Point(13, 544)
        Me.dgvStudentRecord.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvStudentRecord.Name = "dgvStudentRecord"
        Me.dgvStudentRecord.RowHeadersWidth = 51
        Me.dgvStudentRecord.Size = New System.Drawing.Size(1565, 343)
        Me.dgvStudentRecord.TabIndex = 46
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        Me.StudentIDDataGridViewTextBoxColumn.Width = 125
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
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
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PhoneNumber"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PhoneNumber"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'StudentEmailDataGridViewTextBoxColumn
        '
        Me.StudentEmailDataGridViewTextBoxColumn.DataPropertyName = "StudentEmail"
        Me.StudentEmailDataGridViewTextBoxColumn.HeaderText = "StudentEmail"
        Me.StudentEmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StudentEmailDataGridViewTextBoxColumn.Name = "StudentEmailDataGridViewTextBoxColumn"
        Me.StudentEmailDataGridViewTextBoxColumn.Width = 125
        '
        'CoursesDataGridViewTextBoxColumn
        '
        Me.CoursesDataGridViewTextBoxColumn.DataPropertyName = "Courses"
        Me.CoursesDataGridViewTextBoxColumn.HeaderText = "Courses"
        Me.CoursesDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CoursesDataGridViewTextBoxColumn.Name = "CoursesDataGridViewTextBoxColumn"
        Me.CoursesDataGridViewTextBoxColumn.Width = 125
        '
        'StudentRecordsBindingSource
        '
        Me.StudentRecordsBindingSource.DataMember = "StudentRecords"
        Me.StudentRecordsBindingSource.DataSource = Me.EduTrackDBDS
        '
        'EduTrackDBDS
        '
        Me.EduTrackDBDS.DataSetName = "EduTrackDBDS"
        Me.EduTrackDBDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblStudentEmail
        '
        Me.lblStudentEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStudentEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblStudentEmail.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblStudentEmail.Location = New System.Drawing.Point(1003, 338)
        Me.lblStudentEmail.Name = "lblStudentEmail"
        Me.lblStudentEmail.Size = New System.Drawing.Size(149, 36)
        Me.lblStudentEmail.TabIndex = 69
        Me.lblStudentEmail.Text = "Student Email:"
        Me.lblStudentEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'msktxtStudentEmail
        '
        Me.msktxtStudentEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.msktxtStudentEmail.Location = New System.Drawing.Point(1123, 334)
        Me.msktxtStudentEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.msktxtStudentEmail.Mask = "aaaaaa00@aaa"
        Me.msktxtStudentEmail.Name = "msktxtStudentEmail"
        Me.msktxtStudentEmail.Size = New System.Drawing.Size(192, 34)
        Me.msktxtStudentEmail.TabIndex = 70
        '
        'lstGender
        '
        Me.lstGender.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstGender.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lstGender.FormattingEnabled = True
        Me.lstGender.ItemHeight = 28
        Me.lstGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.lstGender.Location = New System.Drawing.Point(1203, 268)
        Me.lstGender.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstGender.Name = "lstGender"
        Me.lstGender.Size = New System.Drawing.Size(252, 32)
        Me.lstGender.TabIndex = 71
        '
        'StudentRecordsTableAdapter
        '
        Me.StudentRecordsTableAdapter.ClearBeforeFill = True
        '
        'msktxtPhone
        '
        Me.msktxtPhone.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.msktxtPhone.Location = New System.Drawing.Point(833, 171)
        Me.msktxtPhone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.msktxtPhone.Mask = "000-0000"
        Me.msktxtPhone.Name = "msktxtPhone"
        Me.msktxtPhone.Size = New System.Drawing.Size(147, 34)
        Me.msktxtPhone.TabIndex = 72
        '
        'frmStudentManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1612, 846)
        Me.Controls.Add(Me.msktxtPhone)
        Me.Controls.Add(Me.lstGender)
        Me.Controls.Add(Me.msktxtStudentEmail)
        Me.Controls.Add(Me.lblStudentEmail)
        Me.Controls.Add(Me.btnCourses)
        Me.Controls.Add(Me.clbCourses)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.dtpStudent)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblLName)
        Me.Controls.Add(Me.lblFName)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lblEdu)
        Me.Controls.Add(Me.dgvStudentRecord)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.imgEdu)
        Me.Controls.Add(Me.lblStudent)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmStudentManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Manager"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.imgEdu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStudentRecord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentRecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EduTrackDBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgEdu As PictureBox
    Friend WithEvents lblStudent As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblEdu As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lblFName As Label
    Friend WithEvents lblLName As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents dtpStudent As DateTimePicker
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents clbCourses As CheckedListBox
    Friend WithEvents btnCourses As Button
    Friend WithEvents dgvStudentRecord As DataGridView
    Friend WithEvents UserIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsActivatedDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents CountryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblStudentEmail As Label
    Friend WithEvents msktxtStudentEmail As MaskedTextBox
    Friend WithEvents lstGender As ListBox
    Friend WithEvents EduTrackDBDS As EduTrackDBDS
    Friend WithEvents StudentRecordsBindingSource As BindingSource
    Friend WithEvents StudentRecordsTableAdapter As EduTrackDBDSTableAdapters.StudentRecordsTableAdapter
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents StudentEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoursesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents msktxtPhone As MaskedTextBox
End Class
