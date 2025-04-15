Imports System.Data.SqlClient
' Chris fix this
Public Class frmAdmin
    ' Method to set the username in the lblWelcome label
    Public Sub SetUsername(username As String)
        lblWelcome.Text = "Logged in as: " & username
    End Sub

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
