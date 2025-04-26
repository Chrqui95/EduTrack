Imports System.Data.SqlClient

Public Class frmStudentManager
    ' Stores the ID of the selected student for editing
    Dim selectedUserID As String = ""

    Private Sub frmStudentManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data from StudentRecords table
        Me.StudentRecordsTableAdapter.Fill(Me.EduTrackDBDS.StudentRecords)
    End Sub

    ' Toggles visibility of the course checklist box when btnCourses is clicked
    Private Sub btnCourses_Click(sender As Object, e As EventArgs) Handles btnCourses.Click
        clbCourses.Visible = Not clbCourses.Visible' Show/hide the course checklist
        ' Change button text accordingly
        btnCourses.Text = If(clbCourses.Visible, "Hide Courses", "Show Courses")
    End Sub

    ' Loads the selected student’s data into the form fields for editing
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ' Ensure a row is selected

        If dgvStudentRecord.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim row As DataGridViewRow = dgvStudentRecord.SelectedRows(0)
            ' Skip the row if it's a new row (usually the last empty one)
            If row.IsNewRow Then
                MessageBox.Show("Selected row is empty. Please select a valid record.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Try
                ' Extract and assign values from the selected row to the form fields
                selectedUserID = row.Cells(0).Value.ToString()
                txtFName.Text = row.Cells(1).Value.ToString()
                txtLName.Text = row.Cells(2).Value.ToString()
                msktxtPhone.Text = row.Cells(6).Value.ToString()
                txtAddress.Text = row.Cells(5).Value.ToString()
                msktxtStudentEmail.Text = row.Cells(7).Value.ToString()
                lstGender.SelectedItem = row.Cells(4).Value.ToString()
                dtpStudent.Value = DateTime.Parse(row.Cells(3).Value.ToString())

                ' Assuming courses are stored as a comma-separated string
                Dim courseList = row.Cells(8).Value.ToString().Split(","c).Select(Function(c) c.Trim()).ToList()
                ' Loop through checklist items and check the ones the student is enrolled in
                For i = 0 To clbCourses.Items.Count - 1
                    clbCourses.SetItemChecked(i, courseList.Contains(clbCourses.Items(i).ToString()))
                Next
            Catch ex As Exception
                ' Show error if data couldn't be loaded properly
                MessageBox.Show("Error reading record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' Show warning if no row was selected
            MessageBox.Show("Please select a row before clicking the Load Data button.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    ' Saves the edited data back to the database
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate that all fields are filled out
        If String.IsNullOrWhiteSpace(txtFName.Text) OrElse
           String.IsNullOrWhiteSpace(txtLName.Text) OrElse
           String.IsNullOrWhiteSpace(msktxtPhone.Text) OrElse
           String.IsNullOrWhiteSpace(txtAddress.Text) OrElse
           String.IsNullOrWhiteSpace(msktxtStudentEmail.Text) OrElse
           lstGender.SelectedIndex = -1 Then

            ' Show message if any field is empty
            MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if at least one course is selected
        If clbCourses.CheckedItems.Count = 0 Then
            MessageBox.Show("Please select at least one course.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Prepare the list of selected courses
        Dim courses As String = String.Join(", ", clbCourses.CheckedItems.Cast(Of String)())

        ' Establish connection string
        Dim connStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EduTrackDB.mdf;Integrated Security=True"

        Try
            ' Open connection to the database
            Using conn As New SqlConnection(connStr)
                conn.Open()
                ' Define SQL query for updating student record
                Dim query As String = "UPDATE StudentRecords SET FirstName=@FirstName, LastName=@LastName, PhoneNumber=@Phone, Address=@Address, " &
                                     "StudentEmail=@Email, Courses=@Courses, Gender=@Gender, DOB=@DOB WHERE StudentID=@StudentID"

                Using cmd As New SqlCommand(query, conn)
                    ' Add parameters for SQL query
                    cmd.Parameters.AddWithValue("@FirstName", txtFName.Text)
                    cmd.Parameters.AddWithValue("@LastName", txtLName.Text)
                    cmd.Parameters.AddWithValue("@Phone", msktxtPhone.Text)
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                    cmd.Parameters.AddWithValue("@Email", msktxtStudentEmail.Text)
                    cmd.Parameters.AddWithValue("@Courses", courses)
                    cmd.Parameters.AddWithValue("@Gender", lstGender.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@DOB", dtpStudent.Value)
                    cmd.Parameters.AddWithValue("@StudentID", selectedUserID)

                    ' Execute the update query
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Show success message
            MessageBox.Show("Student record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh the DataGridView
            Me.StudentRecordsTableAdapter.Fill(Me.EduTrackDBDS.StudentRecords)

        Catch ex As Exception
            ' Show error message if something goes wrong
            MessageBox.Show("Error updating student record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' When user selects "Exit" from the menu, close this form and show the main form
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        frmMain.Show()
    End Sub
End Class
