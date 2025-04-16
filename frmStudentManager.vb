Public Class frmStudentManager
    Private Sub btnCourses_Click(sender As Object, e As EventArgs) Handles btnCourses.Click
        clbCourses.Visible = Not clbCourses.Visible

        If clbCourses.Visible Then
            btnCourses.Text = "Hide Courses"
        Else
            btnCourses.Text = "Show Courses"
        End If
    End Sub
End Class