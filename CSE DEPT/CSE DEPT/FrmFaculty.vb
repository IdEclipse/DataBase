Public Class FrmFaculty
    Private Sub FrmFaculty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CSE_DEPTDataSet.Faculty' Puede moverla o quitarla según sea necesario.

        CboFaculty.Items.Add("Black Anderson")
        CboFaculty.Items.Add("Debby Angles")
        CboFaculty.Items.Add("Alice Brown")
        CboFaculty.Items.Add("Ying Bai")
        CboFaculty.Items.Add("Satish Bhalla")
        CboFaculty.Items.Add("Jeff Henry")
        CboFaculty.Items.Add("Steve Johnson")
        CboFaculty.Items.Add("Jenney King")
        CboFaculty.SelectedIndex = 0



        Me.FacultyTableAdapter.Fill(Me.CSE_DEPTDataSet.Faculty)

    End Sub

    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click
        Dim adaptador As New CSE_DEPTDataSetTableAdapters.FacultyTableAdapter
        adaptador.ClearBeforeFill = True
        adaptador.FillByFacultadNombre(CSE_DEPTDataSet.Faculty, CboFaculty.Text)

        If CSE_DEPTDataSet.Faculty.Count = 0 Then
            MessageBox.Show("No existe Facultad !")
        End If

    End Sub
End Class