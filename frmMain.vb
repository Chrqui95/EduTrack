Imports System.Data.SqlClient
' Chris fix this

Public Class frmMain
    Public UserRole As String = CurrentUserID
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hide all panels initially
        pnlDelete.Visible = False
        pnlMngGrades.Visible = False
        pnlMngStudent.Visible = False
        pnlViewAttendance.Visible = False
        pnlViewGrades.Visible = False

        Select Case UserRole
            Case "Admin"
                pnlDelete.Visible = True
                pnlMngGrades.Visible = True
                pnlMngStudent.Visible = True

            Case "Teacher"
                pnlDelete.Visible = True
                pnlMngGrades.Visible = True
                FileToolStripMenuItem.Visible = False
                DeleteRecordToolStripMenuItem.Visible = False

            Case "Student/Parent"
                pnlViewAttendance.Visible = True
                pnlViewGrades.Visible = True
                FileToolStripMenuItem.Visible = False
                EditRecordToolStripMenuItem.Visible = False


            Case Else
                MessageBox.Show("Unknown role. Limited access.")
        End Select
    End Sub

    ' Method to set the username in the lblWelcome label
    Public Sub SetUsername(username As String)
        lblWelcome.Text = "Logged in as: " & username
    End Sub

    Private Sub btnTeacherGrade_Click(sender As Object, e As EventArgs) Handles btnTeacherGrade.Click
        Me.Hide()
        frmGradeManager.Show()
    End Sub

    Private Sub btnStudentManager_Click(sender As Object, e As EventArgs) Handles btnStudentManager.Click
        Me.Hide()
        frmStudentManager.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If UserRole = "Admin" Then
            Dim deleteForm As New frmDelete()
            deleteForm.Show()
        Else
            MessageBox.Show("Access Denied. Only Admins can delete records.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnDashGrades_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmGradeViewer.Show()
    End Sub

    Private Sub btnDashAttendance_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmAttendanceView.Show()
    End Sub

    Private Sub btnStudentAttendance_Click(sender As Object, e As EventArgs) Handles btnStudentAttendance.Click

    End Sub

    Private Sub DeleteRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRecordToolStripMenuItem.Click
        If UserRole = "Admin" Then
            Dim deleteForm As New frmDelete()
            deleteForm.Show()
        Else
            MessageBox.Show("Access Denied. Only Admins can delete records.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class
