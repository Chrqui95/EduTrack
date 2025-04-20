Imports System.Data.SqlClient
Public Class frmDelete
    Public Property CurrentUserID As String

    Private Sub LoadData()
        Try
            Using conn As New SqlConnection(connectionString)
                Dim adapter As New SqlDataAdapter("SELECT * FROM [Table]", conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvMainRecords.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading records: " & ex.Message)
        End Try
    End Sub
    Private Sub frmDeleteRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub


    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EduTrackDB.mdf;Integrated Security=True"

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvMainRecords.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedUserID As String = dgvMainRecords.SelectedRows(0).Cells(0).Value.ToString()

        If selectedUserID = Session.CurrentUserID Then
            MessageBox.Show("You cannot delete your own admin account while logged in.", "Action Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirmResult As DialogResult = MessageBox.Show($"Are you sure you want to delete the user: {selectedUserID}?",
                                                                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            Try
                Using conn As New SqlConnection(connectionString)
                    conn.Open()
                    Dim query As String = "DELETE FROM [Table] WHERE UserID = @userID"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@userID", selectedUserID)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData() ' Refresh the grid after deletion
            Catch ex As Exception
                MessageBox.Show("Error deleting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub
End Class