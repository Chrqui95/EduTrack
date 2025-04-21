Imports System.Data.SqlClient

Public Class frmMain
    Public UserRole As String = CurrentUserID

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hide all panels initially
        pnlDelete.Visible = False
        pnlCreateNewRecords.Visible = False
        pnlEditStudentRecords.Visible = False
        pnlEditMainRecords.Visible = False
        pnlViewAllRecords.Visible = False

        Select Case UserRole
            Case "Admin"
                pnlDelete.Visible = True
                pnlCreateNewRecords.Visible = True
                pnlEditStudentRecords.Visible = True
                pnlEditMainRecords.Visible = True
                pnlViewAllRecords.Visible = True

            Case "Teacher"
                pnlEditStudentRecords.Visible = True
                FileToolStripMenuItem.Visible = False
                DeleteRecordToolStripMenuItem.Visible = False

            Case "Student/Parent"
                FileToolStripMenuItem.Visible = False
                EditRecordToolStripMenuItem.Visible = False

            Case Else
                MessageBox.Show("Unknown role. Limited access.")
        End Select
    End Sub

    ' Refresh the student record sync when form regains focus
    Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        SyncStudentRecords()
    End Sub

    ' Method to set the username in the lblWelcome label
    Public Sub SetUsername()
        Dim username As String = Session.CurrentUserID
        lblWelcome.Text = "Logged in as: " & username
    End Sub

    Private Sub SyncStudentRecords()
        Dim connStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EduTrackDB.mdf;Integrated Security=True"

        Try
            Using conn As New SqlConnection(connStr)
                conn.Open()

                ' Step 1: Load all activated student/parent users
                Dim selectQuery As String = "SELECT UserID, [First Name], [Last Name], DOB, Gender, [Phone Number], Country " &
                                        "FROM [Table] WHERE Role = 'Student/Parent' AND IsActivated = 1"

                Dim studentList As New List(Of Dictionary(Of String, Object))

                Using selectCmd As New SqlCommand(selectQuery, conn)
                    Using reader As SqlDataReader = selectCmd.ExecuteReader()
                        While reader.Read()
                            Dim student As New Dictionary(Of String, Object) From {
                            {"UserID", reader("UserID")},
                            {"FirstName", reader("First Name")},
                            {"LastName", reader("Last Name")},
                            {"DOB", reader("DOB")},
                            {"Gender", reader("Gender")},
                            {"PhoneNumber", reader("Phone Number")},
                            {"Country", reader("Country")}
                        }
                            studentList.Add(student)
                        End While
                    End Using
                End Using

                ' Step 2: Insert only if not exists
                For Each student In studentList
                    Dim checkCmd As New SqlCommand("SELECT COUNT(*) FROM StudentRecords WHERE StudentID = @StudentID", conn)
                    checkCmd.Parameters.AddWithValue("@StudentID", student("UserID").ToString())

                    Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If exists = 0 Then
                        Dim insertCmd As New SqlCommand("INSERT INTO StudentRecords (StudentID, FirstName, LastName, DOB, Gender, PhoneNumber, Address, StudentEmail, Courses) " &
                                                    "VALUES (@ID, @FName, @LName, @DOB, @Gender, @Phone, @Address, '', '')", conn)

                        insertCmd.Parameters.AddWithValue("@ID", student("UserID").ToString())
                        insertCmd.Parameters.AddWithValue("@FName", student("FirstName").ToString())
                        insertCmd.Parameters.AddWithValue("@LName", student("LastName").ToString())
                        insertCmd.Parameters.AddWithValue("@DOB", Convert.ToDateTime(student("DOB")))
                        insertCmd.Parameters.AddWithValue("@Gender", student("Gender").ToString())
                        insertCmd.Parameters.AddWithValue("@Phone", student("PhoneNumber").ToString())
                        insertCmd.Parameters.AddWithValue("@Address", student("Country").ToString())

                        insertCmd.ExecuteNonQuery()
                    End If
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Error during student sync: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Button Event Handlers
    Private Sub btnCreateNewRecords_Click(sender As Object, e As EventArgs) Handles btnCreateNewRecords.Click
        Me.Hide()
        frmCreateMain.Show()
    End Sub

    Private Sub btnEditStudentRecords_Click(sender As Object, e As EventArgs) Handles btnEditStudentRecords.Click
        Me.Hide()
        frmStudentManager.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If UserRole = "Admin" Then
            Dim deleteForm As New frmDelete()
            Me.Hide()
            deleteForm.Show()
        Else
            MessageBox.Show("Access Denied. Only Admins can delete records.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnDashGrades_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmRecordsViewer.Show()
    End Sub

    Private Sub btnDashAttendance_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmMainRecordEdit.Show()
    End Sub



    Private Sub DeleteRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRecordToolStripMenuItem.Click
        If UserRole = "Admin" Then
            Dim deleteForm As New frmDelete()
            deleteForm.Show()
        Else
            MessageBox.Show("Access Denied. Only Admins can delete records.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEditMainRecords_Click(sender As Object, e As EventArgs) Handles btnEditMainRecords.Click
        Me.Hide()
        frmMainRecordEdit.Show()
    End Sub

    Private Sub btnViewAllRecords_Click(sender As Object, e As EventArgs) Handles btnViewAllRecords.Click
        Me.Hide()
        frmRecordsViewer.Show()
    End Sub

    Private Sub btnMyAccount_Click(sender As Object, e As EventArgs) Handles btnMyAccount.Click
        Me.Hide()
        frmMyAccount.Show()
    End Sub
End Class
