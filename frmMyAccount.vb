Imports System.Data.SqlClient

Public Class frmMyAccount
    ' Current user info from session
    Private selectedUserID As String = Session.CurrentUserID
    Private currentUserRole As String = Session.CurrentUserRole

    Private Sub frmMyAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize controls
        txtUserID.ReadOnly = True
        txtFName.ReadOnly = True
        txtLName.ReadOnly = True
        txtDOB.Enabled = False
        txtGender.Enabled = False
        txtAddress.ReadOnly = True
        msktxtPhone.ReadOnly = True
        txtRole.Enabled = False

        ' Hide student-specific controls by default
        lblStudentEmail.Visible = False
        txtStudentEmail.Visible = False
        lblCourses.Visible = False
        clbCourses.Visible = False

        ' Load main user data
        Dim connStr = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EduTrackDB.mdf;Integrated Security=True"
        Try
            Using conn As New SqlConnection(connStr)
                conn.Open()
                ' Fetch from main table
                Dim mainSql = "SELECT [UserID],[Password],[First Name],[Last Name],DOB,Gender,Country,[Phone Number],Role FROM [Table] WHERE UserID=@UID"
                Using cmd As New SqlCommand(mainSql, conn)
                    cmd.Parameters.AddWithValue("@UID", selectedUserID)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtUserID.Text = reader("UserID").ToString()
                            txtPassword.Text = reader("Password").ToString()
                            txtFName.Text = reader("First Name").ToString()
                            txtLName.Text = reader("Last Name").ToString()
                            txtDOB.Text = Convert.ToDateTime(reader("DOB"))
                            txtGender.Text = reader("Gender").ToString()
                            txtAddress.Text = reader("Country").ToString()
                            msktxtPhone.Text = reader("Phone Number").ToString()
                            txtRole.Text = reader("Role").ToString()
                        End If
                    End Using
                End Using

                ' If student, load student-specific info
                If currentUserRole = "Student/Parent" Then
                    lblStudentEmail.Visible = True
                    txtStudentEmail.Visible = True
                    lblCourses.Visible = True
                    clbCourses.Visible = True

                    ' Populate courses list and fetch existing
                    clbCourses.Items.Clear()
                    clbCourses.Items.AddRange(New String() {"Computer Science", "Biology", "Bio/Chem", "Accounting", "Math/Physics", "Bio/Math", "Primary Ed."})

                    ' Fetch email & courses
                    Dim stuSql = "SELECT StudentEmail, Courses FROM StudentRecords WHERE StudentID=@UID"
                    Using stuCmd As New SqlCommand(stuSql, conn)
                        stuCmd.Parameters.AddWithValue("@UID", selectedUserID)
                        Using stuReader As SqlDataReader = stuCmd.ExecuteReader()
                            If stuReader.Read() Then
                                txtStudentEmail.Text = stuReader("StudentEmail").ToString()
                                Dim courses = stuReader("Courses").ToString().Split(","c).Select(Function(c) c.Trim()).ToList()
                                For i = 0 To clbCourses.Items.Count - 1
                                    clbCourses.SetItemChecked(i, courses.Contains(clbCourses.Items(i).ToString()))
                                Next
                            End If
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading account info: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Only password can be changed
        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim connStr = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EduTrackDB.mdf;Integrated Security=True"
        Try
            Using conn As New SqlConnection(connStr)
                conn.Open()
                ' Update only password
                Dim updSql = "UPDATE [Table] SET [Password]=@Password WHERE UserID=@UID"
                Using cmd As New SqlCommand(updSql, conn)
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                    cmd.Parameters.AddWithValue("@UID", selectedUserID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving password: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        frmMain.Show()
    End Sub
End Class
