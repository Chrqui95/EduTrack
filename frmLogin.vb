Imports System.Data.SqlClient

Public Class frmLogin
    ' Adjust the path based on where your .mdf is located and its name
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EduTrackDB.mdf;Integrated Security=True"


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        ' Dim role As String = cmbRole.Text()

        If username = "" Or password = "" Then
            MessageBox.Show("Please enter Username or Password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM [Table] WHERE UserID = @user AND Password = @pass"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@user", username)
                    cmd.Parameters.AddWithValue("@pass", password)

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then
                        MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Hide()
                        frmMain.Show()
                    Else
                        MessageBox.Show("Invalid credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        MessageBox.Show("To reset your password contact :" & Environment.NewLine & "admin@edu-track.tech" & Environment.NewLine & "675-8524", "Contact Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnPlaceholderExit_Click(sender As Object, e As EventArgs) Handles btnPlaceholderExit.Click
        Me.Close()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class