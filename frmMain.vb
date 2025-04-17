Imports System.Data.SqlClient
' Chris fix this
Public Class frmMain
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
