Imports System.Data.SqlClient

Public Class frmLogin
    ' Adjust the path based on where your .mdf is located and its name
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EduTrackDB.mdf;Integrated Security=True"



    ' Handles the Login button click event
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Retrieve and trim the username and password input
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' Validate input fields
        If username = "" Or password = "" Then
            MessageBox.Show("Please enter Username or Password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            ' Open a connection to the database
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                ' Check for active user and get role - to see if the user exists, is active, and retrieve their role
                Dim query As String = "SELECT Role FROM [Table] WHERE UserID = @user AND Password = @pass AND IsActivated = 1"
                Using cmd As New SqlCommand(query, conn)
                    ' Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@user", username)
                    cmd.Parameters.AddWithValue("@pass", password)


                    ' Execute the query and retrieve the role
                    Dim role As Object = cmd.ExecuteScalar()

                    If role IsNot Nothing Then
                        ' If user is found, convert role to string
                        Dim userRole As String = role.ToString()

                        ' Set session variables
                        Session.CurrentUserID = username
                        Session.CurrentUserRole = userRole

                        ' Show success message
                        MessageBox.Show("Login successful! Role: " & userRole, "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Hide login form and open the main form
                        Me.Hide()
                        Dim mainForm As New frmMain()
                        mainForm.Show()
                    Else
                        ' If user not found or not activated
                        MessageBox.Show("Invalid credentials or account not activated.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                End Using
            End Using
        Catch ex As Exception
            ' Handle database connection errors
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Handles the "Forgot Password" button click event
    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        ' Show contact information for password reset
        MessageBox.Show("To reset your password contact :" & Environment.NewLine & "admin@edu-track.tech" & Environment.NewLine & "675-8524", "Contact Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Handles the Exit button click event
    Private Sub btnPlaceholderExit_Click(sender As Object, e As EventArgs) Handles btnPlaceholderExit.Click
        ' Close the login form
        Me.Close()
    End Sub

    ' Handles the Register button click event
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Show the registration form and hide the login form
        frmRegister.Show()
        Me.Hide()
    End Sub
End Class
