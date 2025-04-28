Imports System.Data.SqlClient

Public Class frmMainRecordEdit
    Dim selectedUserID As String = ""
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EduTrackDB.mdf;Integrated Security=True"
    Public Sub LoadData()
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

    Private Sub frmMainRecordView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data from the main table
        Me.TableTableAdapter.Fill(Me.EduTrackDBDS.Table)
        txtUserID.ReadOnly = True
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvMainRecords.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim row As DataGridViewRow = dgvMainRecords.SelectedRows(0)
        If row.IsNewRow Then
            MessageBox.Show("Selected row is empty. Please select a valid record.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim userID As String = row.Cells(0).Value.ToString()

        ' Prevent editing your own account
        If userID = Session.CurrentUserID Then
            MessageBox.Show("You cannot edit your own account here.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            selectedUserID = userID
            txtUserID.Text = userID
            txtPassword.Text = row.Cells(1).Value.ToString()
            txtFName.Text = row.Cells(2).Value.ToString()
            txtLName.Text = row.Cells(3).Value.ToString()
            dtpDOB.Value = Convert.ToDateTime(row.Cells(4).Value)
            lstGender.SelectedItem = row.Cells(5).Value.ToString()
            txtAddress.Text = row.Cells(6).Value.ToString()
            msktxtPhone.Text = row.Cells(7).Value.ToString()
            lstRole.SelectedItem = row.Cells(8).Value.ToString()
            clbActiveStatus.SetItemChecked(0, Convert.ToBoolean(row.Cells(9).Value))
        Catch ex As Exception
            MessageBox.Show("Error loading record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate required fields
        If String.IsNullOrWhiteSpace(txtUserID.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtFName.Text) OrElse
           String.IsNullOrWhiteSpace(txtLName.Text) OrElse
           String.IsNullOrWhiteSpace(txtAddress.Text) OrElse
           String.IsNullOrWhiteSpace(msktxtPhone.Text) OrElse
            lstGender.SelectedIndex = -1 OrElse
            lstRole.SelectedIndex = -1 Then

            MessageBox.Show("All fields must be filled out." & Environment.NewLine & "Please remember to select gender and role before saving records! ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        selectedUserID = txtUserID.Text.Trim()
        Dim isActive As Boolean = clbActiveStatus.GetItemChecked(0)
        Dim selectedRole As String = lstRole.SelectedItem.ToString()

        Dim connStr = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EduTrackDB.mdf;Integrated Security=True"

        Try
            Using conn As New SqlConnection(connStr)
                conn.Open()

                ' 1) Update main [Table]
                Dim updateMain As String =
                  "UPDATE [Table] SET " &
                  "[Password]=@Password, " &
                  "[First Name]=@FName, " &
                  "[Last Name]=@LName, " &
                  "DOB=@DOB, " &
                  "Gender=@Gender, " &
                  "Country=@Country, " &
                  "[Phone Number]=@Phone, " &
                  "Role=@Role, " &
                  "IsActivated=@IsActive " &
                  "WHERE UserID=@UserID"

                Using cmd As New SqlCommand(updateMain, conn)
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                    cmd.Parameters.AddWithValue("@FName", txtFName.Text)
                    cmd.Parameters.AddWithValue("@LName", txtLName.Text)
                    cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value)
                    cmd.Parameters.AddWithValue("@Gender", lstGender.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Country", txtAddress.Text)
                    cmd.Parameters.AddWithValue("@Phone", msktxtPhone.Text)
                    cmd.Parameters.AddWithValue("@Role", selectedRole)
                    cmd.Parameters.AddWithValue("@IsActive", isActive)
                    cmd.Parameters.AddWithValue("@UserID", selectedUserID)
                    cmd.ExecuteNonQuery()
                End Using

                ' 2) Sync StudentRecords
                If selectedRole = "Student/Parent" AndAlso isActive Then
                    ' Insert or update student record
                    Dim checkSql = "SELECT COUNT(*) FROM StudentRecords WHERE StudentID=@UserID"
                    Using chk As New SqlCommand(checkSql, conn)
                        chk.Parameters.AddWithValue("@UserID", selectedUserID)
                        Dim cnt = Convert.ToInt32(chk.ExecuteScalar())

                        If cnt > 0 Then
                            ' Update
                            Dim updStu =
                              "UPDATE StudentRecords SET " &
                              "FirstName=@FName, " &
                              "LastName=@LName, " &
                              "DOB=@DOB, " &
                              "Gender=@Gender, " &
                              "PhoneNumber=@Phone, " &
                              "Address=@Address " &
                              "WHERE StudentID=@UserID"
                            Using sCmd As New SqlCommand(updStu, conn)
                                sCmd.Parameters.AddWithValue("@FName", txtFName.Text)
                                sCmd.Parameters.AddWithValue("@LName", txtLName.Text)
                                sCmd.Parameters.AddWithValue("@DOB", dtpDOB.Value)
                                sCmd.Parameters.AddWithValue("@Gender", lstGender.SelectedItem.ToString())
                                sCmd.Parameters.AddWithValue("@Phone", msktxtPhone.Text)
                                sCmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                                sCmd.Parameters.AddWithValue("@UserID", selectedUserID)
                                sCmd.ExecuteNonQuery()
                            End Using
                        Else
                            ' Insert with non-null defaults for StudentEmail & Courses
                            Dim insStu =
                              "INSERT INTO StudentRecords (StudentID,FirstName,LastName,DOB,Gender,PhoneNumber,Address,StudentEmail,Courses) " &
                              "VALUES (@UserID,@FName,@LName,@DOB,@Gender,@Phone,@Address,'', 'Not Assigned')"
                            Using sCmd As New SqlCommand(insStu, conn)
                                sCmd.Parameters.AddWithValue("@UserID", selectedUserID)
                                sCmd.Parameters.AddWithValue("@FName", txtFName.Text)
                                sCmd.Parameters.AddWithValue("@LName", txtLName.Text)
                                sCmd.Parameters.AddWithValue("@DOB", dtpDOB.Value)
                                sCmd.Parameters.AddWithValue("@Gender", lstGender.SelectedItem.ToString())
                                sCmd.Parameters.AddWithValue("@Phone", msktxtPhone.Text)
                                sCmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                                sCmd.ExecuteNonQuery()
                            End Using
                        End If
                    End Using
                Else
                    ' If either not a student or not active > delete
                    Dim delStu = "DELETE FROM StudentRecords WHERE StudentID=@UserID"
                    Using dCmd As New SqlCommand(delStu, conn)
                        dCmd.Parameters.AddWithValue("@UserID", selectedUserID)
                        dCmd.ExecuteNonQuery()
                    End Using
                End If
            End Using

            MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TableTableAdapter.Fill(Me.EduTrackDBDS.Table)
        Catch ex As Exception
            MessageBox.Show("Error updating record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        frmAboutApp.Show()
        Me.Hide()
    End Sub

    Private Sub frmMainRecordEdit_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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
