Public Class FrmCategoria
    Private dt As New DataTable
    Private Sub FrmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        CargarInformacionCajaTextos()
    End Sub

    Private Sub CargarInformacionCajaTextos()
        IdCategoriaTextBox.Text = DgvCategoria.CurrentRow.Cells("IdCategoria").Value.ToString
        CetegoriaTextBox.Text = DgvCategoria.CurrentRow.Cells("Nombre").Value.ToString

    End Sub

    Private Sub Mostrar()
        Dim categoria As New fCategoria
        dt = categoria.Mostrar
        DgvCategoria.Columns.Item("Eliminar").Visible = False

        If dt.Rows.Count <> 0 Then
            DgvCategoria.DataSource = dt
        Else
            DgvCategoria.DataSource = Nothing
        End If
    End Sub

End Class