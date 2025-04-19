Imports System.Data.SqlClient
' Chris fix this

Public Class frmMain
    Public UserRole As String
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hide all panels initially
        pnlMngAttendance.Visible = False
        pnlMngGrades.Visible = False
        pnlMngStudent.Visible = False
        pnlViewAttendance.Visible = False
        pnlViewGrades.Visible = False

        Select Case UserRole
            Case "Admin"
                pnlMngAttendance.Visible = True
                pnlMngGrades.Visible = True
                pnlMngStudent.Visible = True

            Case "Teacher"
                pnlMngAttendance.Visible = True
                pnlMngGrades.Visible = True

            Case "Student/Parent"
                pnlViewAttendance.Visible = True
                pnlViewGrades.Visible = True

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

    Private Sub btnTeacherAttendance_Click(sender As Object, e As EventArgs) Handles btnTeacherAttendance.Click
        Me.Hide()
        frmAttendance.Show()
    End Sub

    Private Sub btnDashGrades_Click(sender As Object, e As EventArgs) Handles btnDashGrades.Click
        Me.Hide()
        frmGradeViewer.Show()
    End Sub

    Private Sub btnDashAttendance_Click(sender As Object, e As EventArgs) Handles btnDashAttendance.Click
        Me.Hide()
        frmAttendanceView.Show()
    End Sub

End Class
