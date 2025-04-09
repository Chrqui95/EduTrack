<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen1
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.prgSplash = New System.Windows.Forms.ProgressBar()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.ApplicationTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Version = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'prgSplash
        '
        Me.prgSplash.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.prgSplash.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.prgSplash.Location = New System.Drawing.Point(43, 210)
        Me.prgSplash.Name = "prgSplash"
        Me.prgSplash.Size = New System.Drawing.Size(473, 10)
        Me.prgSplash.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.prgSplash.TabIndex = 8
        '
        'Copyright
        '
        Me.Copyright.AutoSize = True
        Me.Copyright.Font = New System.Drawing.Font("Cascadia Mono SemiLight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.Location = New System.Drawing.Point(12, 248)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(80, 17)
        Me.Copyright.TabIndex = 7
        Me.Copyright.Text = "Copyright"
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.AutoSize = True
        Me.ApplicationTitle.Font = New System.Drawing.Font("Cascadia Mono", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationTitle.ForeColor = System.Drawing.Color.Teal
        Me.ApplicationTitle.Location = New System.Drawing.Point(175, 45)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New System.Drawing.Size(341, 85)
        Me.ApplicationTitle.TabIndex = 6
        Me.ApplicationTitle.Text = "EduTrack"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.EduTrack.My.Resources.Resources.edu
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(146, 145)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.Font = New System.Drawing.Font("Cascadia Mono Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.ForeColor = System.Drawing.Color.Teal
        Me.Version.Location = New System.Drawing.Point(503, 248)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(48, 17)
        Me.Version.TabIndex = 9
        Me.Version.Text = "V.1.0"
        '
        'SplashScreen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 274)
        Me.ControlBox = False
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.prgSplash)
        Me.Controls.Add(Me.Copyright)
        Me.Controls.Add(Me.ApplicationTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents prgSplash As ProgressBar
    Friend WithEvents Copyright As Label
    Friend WithEvents ApplicationTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Version As Label
End Class
