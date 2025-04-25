Imports System.Data.SqlClient

Public Class frmLogin
    ' Adjust the path based on where your .mdf is located and its name
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EduTrackDB.mdf;Integrated Security=True"




    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Please enter Username or Password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                ' Check for active user and get role
                Dim query As String = "SELECT Role FROM [Table] WHERE UserID = @user AND Password = @pass AND IsActivated = 1"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@user", username)
                    cmd.Parameters.AddWithValue("@pass", password)

                    Dim role As Object = cmd.ExecuteScalar()

                    If role IsNot Nothing Then
                        Dim userRole As String = role.ToString()

                        ' Set session variables
                        Session.CurrentUserID = username
                        Session.CurrentUserRole = userRole

                        MessageBox.Show("Login successful! Role: " & userRole, "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Me.Hide()
                        Dim mainForm As New frmMain()
                        mainForm.UserRole = Session.CurrentUserRole ' Pass the role to frmMain
                        mainForm.Show()
                    Else
                        MessageBox.Show("Invalid credentials or account not activated.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        frmRegister.Show()
        Me.Hide()
    End Sub

    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Application.Exit()
        End If
    End Sub

    Private Sub frmLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class