Imports System.Data.SqlClient

Public Class LoginForm
    ' Adjust the path based on where your .mdf is located and its name
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EduTrackDB.mdf;Integrated Security=True"


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim role As String = cmbRole.Text()

        If username = "" Or password = "" Or String.IsNullOrEmpty(role) Then
            MessageBox.Show("Please enter Username, Password, and select Role.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM [Table] WHERE UserID = @user AND Password = @pass AND Role = @role"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@user", username)
                    cmd.Parameters.AddWithValue("@pass", password)
                    cmd.Parameters.AddWithValue("@role", role)

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then
                        MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Hide()
                        BaseForm1.Show()
                    Else
                        MessageBox.Show("Invalid credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
