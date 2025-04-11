Imports System.Data.SqlClient
' Chris fix this
Public Class frmAdmin
  ' Method to set the username in the lblWelcome label
    Public Sub SetUsername(username As String)
        lblWelcome.Text = "Logged in as: " & username
    End Sub
End Class
