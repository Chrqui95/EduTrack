Public Class frmStudentManager
    Private Sub btnCourses_Click(sender As Object, e As EventArgs) Handles btnCourses.Click
        clbCourses.Visible = Not clbCourses.Visible

        If clbCourses.Visible Then
            btnCourses.Text = "Hide Courses"
        Else
            btnCourses.Text = "Show Courses"
        End If
    End Sub

    Private Sub frmStudentManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EduTrackDBDS.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.EduTrackDBDS.Table)

    End Sub
End Class