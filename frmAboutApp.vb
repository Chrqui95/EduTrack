Public Class frmAboutApp
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        frmLogin.txtPassword.Text = ""
        frmLogin.txtUsername.Text = ""
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub frmAboutApp_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
            frmMain.Show()
        End If
    End Sub

    Private Sub frmAboutApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lnkDownload.Links.Add(0, lnkDownload.Text.Length, "https://edutrackbeta.netlify.app/")
    End Sub

    Private Sub lnkDownload_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkDownload.LinkClicked
        Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Me.Hide()
        frmAboutCompany.Show()
    End Sub

    Private Sub HowToToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToToolStripMenuItem.Click
        frmMain.OpenPDF()
    End Sub
End Class