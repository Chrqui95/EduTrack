Imports System.Data.SqlClient

Public Class frmRegister
    ' Connection string to the local SQL database
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EduTrackDB.mdf;Integrated Security=True"


    ' Handles the click event for the Register button
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Gather all input values from form fields
        Dim fname As String = txtFName.Text.Trim()
        Dim lname As String = txtLName.Text.Trim()
        Dim dob As Date = dtpDOB.Value
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim gender As String = lstGender.Text.Trim()
        Dim country As String = txtCountry.Text.Trim()
        Dim phoneNumber As String = msktxtPhone.Text.Trim()



        ' Check for any empty required fields
        If fname = "" Or lname = "" Or username = "" Or password = "" Or country = "" Or phoneNumber = "" Then
            MessageBox.Show("Please fill in all fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Stop processing if validation fails
        End If



        Try
            ' Establish database connection
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                ' First check if UserID already exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM [Table] WHERE UserID = @user"
                Using checkCmd As New SqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@user", username)
                    Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    ' If username is taken, show message and exit
                    If exists > 0 Then
                        MessageBox.Show("Username already taken. Please choose another.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                ' Prepare insert query for new user registration
                Dim query As String = "INSERT INTO [Table] 
                    (UserID, Password, [First Name], [Last Name], DOB, Gender, Country, [Phone Number], Role, IsActivated)
                    VALUES 
                    (@user, @pass, @fname, @lname, @dob, @gender, @country, @phone, @role, 0)"

                ' Execute the insert command with the collected values
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
                    ' Inform user of success and return to login screen
                    MessageBox.Show("Registration submitted! Wait for admin approval.", "Pending Approval", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    frmLogin.Show()
                End Using
            End Using
        Catch ex As Exception
            ' Catch and show any unexpected errors
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Handles click on the exit button (placeholder) to return to login screen
    Private Sub btnPlaceholderExit_Click(sender As Object, e As EventArgs) Handles btnPlaceholderExit.Click
        Me.Close()
        frmLogin.Show()

    End Sub
    ' Ensures the login form is shown if registration form is closed manually
    Private Sub frmRegistration_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Show()
    End Sub

End Class
