Imports System.Data.SqlClient

Public Class frmRecordsViewer


    Dim selectedUserID As String = ""

    Private Sub frmMainRecordView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data from the main table
        Me.TableTableAdapter.Fill(Me.EduTrackDBDS.Table)
        txtUserID.ReadOnly = True
    End Sub

    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EduTrackDB.mdf;Integrated Security=True"
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

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If dgvMainRecords.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim row As DataGridViewRow = dgvMainRecords.SelectedRows(0)
        If row.IsNewRow Then
            txtUserID.Text = ""
            txtPassword.Text = ""
            txtFName.Text = ""
            txtLName.Text = ""
            txtDOB.Text = ""
            txtGender.Text = ""
            txtAddress.Text = ""
            msktxtPhone.Text = ""
            txtRole.Text = ""
            txtActivationStatus.Text = ""
        Else
            Try

                Dim userID As String = row.Cells(0).Value.ToString()
                selectedUserID = userID
                txtUserID.Text = userID
                txtPassword.Text = row.Cells(1).Value.ToString()
                txtFName.Text = row.Cells(2).Value.ToString()
                txtLName.Text = row.Cells(3).Value.ToString()
                txtDOB.Text = Convert.ToDateTime(row.Cells(4).Value)
                txtGender.Text = row.Cells(5).Value.ToString()
                txtAddress.Text = row.Cells(6).Value.ToString()
                msktxtPhone.Text = row.Cells(7).Value.ToString()
                txtRole.Text = row.Cells(8).Value.ToString()
                txtActivationStatus.Text = row.Cells(9).Value.ToString()
            Catch ex As Exception
                MessageBox.Show("Error loading record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        frmAboutApp.Show()
        Me.Hide()
    End Sub

    Private Sub frmRecordsViewer_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
            frmMain.Show()
        End If
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Me.Hide()
        frmAboutCompany.Show()
    End Sub

    Private Sub HowToToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToToolStripMenuItem.Click
        frmMain.OpenPDF()
    End Sub
End Class
