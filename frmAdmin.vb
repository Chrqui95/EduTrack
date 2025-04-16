Imports System.Data.SqlClient
' Chris fix this
Public Class frmAdmin
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
End Class
