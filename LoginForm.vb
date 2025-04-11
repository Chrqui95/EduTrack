Public Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
    Dim username As String = txtUsername.Text.Trim()
    Dim password As String = txtPassword.Text.Trim()

    If username = "" Or password = "" Then
        MessageBox.Show("Please enter Username and Password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    
                    ' Pass the username to frmAdmin
                    Dim adminForm As New frmAdmin()
                    adminForm.SetUsername(username)
                    adminForm.Show()
                Else
                    MessageBox.Show("Invalid credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        End Using
    Catch ex As Exception
        MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
End Sub
