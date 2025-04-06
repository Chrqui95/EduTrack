Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim role As String = cmbRole.Text

        ' Placeholder authentication logic
        If username = "" Or password = "" Then
            MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf role = "Administrator" And username = "admin" And password = "admin123" Then
            MessageBox.Show("Welcome, Administrator!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Open the Admin Dashboard (Placeholder)
        Else
            MessageBox.Show("Invalid credentials or role selection.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
