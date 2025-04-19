Imports System.Data.SqlClient

Public Class frmRegister
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EduTrackDB.mdf;Integrated Security=True"

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim fname As String = txtFName.Text.Trim()
        Dim lname As String = txtLName.Text.Trim()
        Dim dob As Date = dtpDOB.Value
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If fname = "" Or lname = "" Or username = "" Or password = "" Then
            MessageBox.Show("Please fill in all fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO [Table] (UserID, Password, Role, IsActivated, First Name, Last Name, DOB) 
                                       VALUES (@user, @pass, @role, 0, @fname, @lname, @dob)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@user", username)
                    cmd.Parameters.AddWithValue("@pass", password)
                    cmd.Parameters.AddWithValue("@role", "Student/Parent") ' Default role
                    cmd.Parameters.AddWithValue("@fname", fname)
                    cmd.Parameters.AddWithValue("@lname", lname)
                    cmd.Parameters.AddWithValue("@dob", dob)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Registration submitted! Wait for admin approval.", "Pending Approval", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
