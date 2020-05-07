Public Class FrmSelection
    Private Sub FrmSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CboSelection.Items.Add("Faculty Information")
        CboSelection.Items.Add("Course Information")
        CboSelection.Items.Add("Student Information")
        CboSelection.SelectedIndex = 0

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Application.Exit()
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        Dim frmFacultad As New FrmFaculty
        Dim frmCurso As New FrmCourse
        Dim frmEstudiante As New FrmStudent

        If CboSelection.Text = "Faculty Information" Then frmFacultad.Show()
        If CboSelection.Text = "Course Information" Then frmCurso.Show()
        If CboSelection.Text = "Student Information" Then frmEstudiante.Show()



    End Sub
End Class