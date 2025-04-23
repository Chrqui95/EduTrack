<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAboutApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAboutApp))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.frmMind = New System.Windows.Forms.Label()
        Me.lnkDownload = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1075, 29)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 50, 0)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(40, 25)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(119, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
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
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HelpToolStripMenuItem.Text = "About Company"
        '
        'HowToToolStripMenuItem
        '
        Me.HowToToolStripMenuItem.Name = "HowToToolStripMenuItem"
        Me.HowToToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.HowToToolStripMenuItem.Text = "How To"
        '
        'PictureBox7
        '
        Me.PictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox7.BackgroundImage = Global.EduTrack.My.Resources.Resources.edu
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox7.Location = New System.Drawing.Point(326, 51)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(123, 117)
        Me.PictureBox7.TabIndex = 43
        Me.PictureBox7.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Black", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(438, 69)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(335, 83)
        Me.lblTitle.TabIndex = 42
        Me.lblTitle.Text = "EduTrack"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDesc
        '
        Me.lblDesc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblDesc.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblDesc.Location = New System.Drawing.Point(299, 214)
        Me.lblDesc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(505, 235)
        Me.lblDesc.TabIndex = 44
        Me.lblDesc.Text = resources.GetString("lblDesc.Text")
        Me.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblDate.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(11, 625)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(252, 35)
        Me.lblDate.TabIndex = 45
        Me.lblDate.Text = "Date Created: April 1, 2025"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblVersion.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblVersion.Location = New System.Drawing.Point(898, 629)
        Me.lblVersion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(177, 31)
        Me.lblVersion.TabIndex = 46
        Me.lblVersion.Text = "Pre-Release 1.0.0"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMind
        '
        Me.frmMind.AutoSize = True
        Me.frmMind.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmMind.Location = New System.Drawing.Point(477, 152)
        Me.frmMind.Name = "frmMind"
        Me.frmMind.Size = New System.Drawing.Size(148, 16)
        Me.frmMind.TabIndex = 47
        Me.frmMind.Text = "By MindFrame Studios"
        '
        'lnkDownload
        '
        Me.lnkDownload.AutoSize = True
        Me.lnkDownload.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkDownload.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkDownload.LinkColor = System.Drawing.Color.Teal
        Me.lnkDownload.Location = New System.Drawing.Point(477, 486)
        Me.lnkDownload.Name = "lnkDownload"
        Me.lnkDownload.Size = New System.Drawing.Size(169, 17)
        Me.lnkDownload.TabIndex = 49
        Me.lnkDownload.TabStop = True
        Me.lnkDownload.Text = "EduTrack Download Page"
        Me.lnkDownload.VisitedLinkColor = System.Drawing.Color.Teal
        '
        'frmAboutApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 669)
        Me.Controls.Add(Me.lnkDownload)
        Me.Controls.Add(Me.frmMind)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAboutApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About Program"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HowToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents frmMind As Label
    Friend WithEvents lnkDownload As LinkLabel
End Class
