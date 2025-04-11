Imports System.Data.SqlClient
' Chris fix this
Public Class frmAdmin
    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Connection String to your database
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EduTrackDB.mdf;Integrated Security=True"

        ' SQL Query to retrieve the username
        Dim query As String = "SELECT username FROM Users WHERE user_id = @UserId"

        ' Replace this with the actual logged-in user ID
        Dim userId As Integer = 1 ' Example: Replace with dynamically fetched ID

        Try
            ' Create a connection to the database
            Using connection As New SqlConnection(connectionString)
                ' Create a command to execute the SQL query
                Using command As New SqlCommand(query, connection)
                    ' Add parameter to the query
                    command.Parameters.AddWithValue("@UserId", userId)

                    ' Open the connection
                    connection.Open()

                    ' Execute the query and fetch the result
                    Dim username As Object = command.ExecuteScalar()

                    ' Display the result in the label
                    If username IsNot Nothing Then
                        lblWelcome.Text = "Logged in as: " & username.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Handle exceptions (e.g., database errors)
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class