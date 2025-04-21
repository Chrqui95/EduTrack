Imports System.Data.SqlClient

Public Class frmCreateMain

    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click
        ' Basic validation
        If String.IsNullOrWhiteSpace(txtUserID.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtFName.Text) OrElse
           String.IsNullOrWhiteSpace(txtLName.Text) OrElse
           String.IsNullOrWhiteSpace(txtAddress.Text) OrElse
           String.IsNullOrWhiteSpace(msktxtPhone.Text) OrElse
           lstGender.SelectedIndex = -1 OrElse
           lstRole.SelectedIndex = -1 Then

            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim connStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EduTrackDB.mdf;Integrated Security=True"

        Try
            Using conn As New SqlConnection(connStr)
                conn.Open()

                ' Using VALUES in the order of the table's columns
                Dim query As String = "INSERT INTO [Table] VALUES (@UserID, @Password, @FName, @LName, @DOB, @Gender, @Country, @Phone, @Role, @IsActivated)"
                Dim isActive As Boolean = False

                ' Check if the first item in clbActiveStatus is checked
                If clbActiveStatus.GetItemChecked(0) Then
                    isActive = True
                End If

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@UserID", txtUserID.Text)
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                    cmd.Parameters.AddWithValue("@FName", txtFName.Text)
                    cmd.Parameters.AddWithValue("@LName", txtLName.Text)
                    cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value)
                    cmd.Parameters.AddWithValue("@Gender", lstGender.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Country", txtAddress.Text)
                    cmd.Parameters.AddWithValue("@Phone", msktxtPhone.Text)
                    cmd.Parameters.AddWithValue("@Role", lstRole.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@IsActivated", isActive)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("New user record created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()

        Catch ex As SqlException When ex.Number = 2627
            MessageBox.Show("UserID already exists. Please choose a unique UserID.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Error while creating record: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearFields()
        txtUserID.Clear()
        txtPassword.Clear()
        txtFName.Clear()
        txtLName.Clear()
        txtAddress.Clear()
        msktxtPhone.Clear()
        lstGender.SelectedIndex = -1
        lstRole.SelectedIndex = -1
        dtpDOB.Value = Date.Today
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        frmMain.Show()
    End Sub
End Class
