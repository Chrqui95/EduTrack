Imports System.Data.SqlClient

Public Class frmRegister
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EduTrackDB.mdf;Integrated Security=True"


    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim fname As String = txtFName.Text.Trim()
        Dim lname As String = txtLName.Text.Trim()
        Dim dob As Date = dtpDOB.Value
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim gender As String = lstGender.Text.Trim()
        Dim country As String = txtCountry.Text.Trim()
        Dim phoneNumber As String = msktxtPhone.Text.Trim()



        If fname = "" Or lname = "" Or username = "" Or password = "" Or country = "" Or phoneNumber = "" Then
            MessageBox.Show("Please fill in all fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If



        Try

            Using conn As New SqlConnection(connectionString)
                conn.Open()
                ' First check if UserID already exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM [Table] WHERE UserID = @user"
                Using checkCmd As New SqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@user", username)
                    Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If exists > 0 Then
                        MessageBox.Show("Username already taken. Please choose another.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                Dim query As String = "INSERT INTO [Table] 
                    (UserID, Password, [First Name], [Last Name], DOB, Gender, Country, [Phone Number], Role, IsActivated)
                    VALUES 
                    (@user, @pass, @fname, @lname, @dob, @gender, @country, @phone, @role, 0)"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@user", username)
                    cmd.Parameters.AddWithValue("@pass", password)
                    cmd.Parameters.AddWithValue("@fname", fname)
                    cmd.Parameters.AddWithValue("@lname", lname)
                    cmd.Parameters.AddWithValue("@dob", dob)
                    cmd.Parameters.AddWithValue("@gender", gender)
                    cmd.Parameters.AddWithValue("@country", country)
                    cmd.Parameters.AddWithValue("@phone", phoneNumber)
                    cmd.Parameters.AddWithValue("@role", "Student/Parent")
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Registration submitted! Wait for admin approval.", "Pending Approval", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    frmLogin.Show()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPlaceholderExit_Click(sender As Object, e As EventArgs) Handles btnPlaceholderExit.Click
        Me.Close()
        frmLogin.Show()

    End Sub
    Private Sub frmRegistration_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Show()
    End Sub

    Private Sub frmRegister_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
