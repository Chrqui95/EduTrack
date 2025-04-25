Imports System.Data.SqlClient
Public Class frmDelete
    ' Property to hold the current user's ID
    Public Property CurrentUserID As String

    ' Loads all user records from the database into the DataGridView
    Private Sub LoadData()
        Try
            Using conn As New SqlConnection(connectionString)
                ' Retrieve all records from the table
                Dim adapter As New SqlDataAdapter("SELECT * FROM [Table]", conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                ' Bind the data to the DataGridView
                dgvMainRecords.DataSource = dt
            End Using
        Catch ex As Exception
            ' Show error if the data loading fails
            MessageBox.Show("Error loading records: " & ex.Message)
        End Try
    End Sub
    ' Form load event: triggers data loading when the form opens
    Private Sub frmDeleteRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.StudentRecordsTableAdapter.Fill(Me.EduTrackDBDS.StudentRecords)
        LoadData()
    End Sub


    ' Connection string to connect to the local SQL Server database file
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EduTrackDB.mdf;Integrated Security=True"

    ' Click event for the Delete button
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Check if any row is selected in the DataGridView
        If dgvMainRecords.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the UserID of the selected row (first column)
        Dim selectedUserID As String = dgvMainRecords.SelectedRows(0).Cells(0).Value.ToString()

        ' Prevent deletion if the selected user is the one currently logged in
        If selectedUserID = Session.CurrentUserID Then
            MessageBox.Show("You cannot delete your own admin account while logged in.", "Action Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ask the user to confirm the deletion
        Dim confirmResult As DialogResult = MessageBox.Show($"Are you sure you want to delete the user: {selectedUserID}?",
                                                                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' If the user confirms
        If confirmResult = DialogResult.Yes Then
            Try
                Using conn As New SqlConnection(connectionString)
                    conn.Open()
                    ' SQL DELETE statement to remove the selected record
                    Dim query As String = "DELETE FROM [Table] WHERE UserID = @userID"
                    Using cmd As New SqlCommand(query, conn)
                        ' Set the parameter value to the selected user ID
                        cmd.Parameters.AddWithValue("@userID", selectedUserID)
                        ' Execute the delete command
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                ' Notify the user of success
                MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData() ' Refresh the grid after deletion
            Catch ex As Exception
                ' Show an error message if the deletion fails
                MessageBox.Show("Error deleting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' Exit menu item click event
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' Close the current form and show the main form
        Me.Close()
        frmMain.Show()
    End Sub

End Class
