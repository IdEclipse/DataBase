Public Class FrmCliente
    Private dt As New DataTable

    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()

    End Sub

    Private Sub Mostrar()
        Dim cliente As New fCliente
        dt = cliente.Mostrar
        DgvListado.Columns.Item("Eliminar").Visible = False

        If dt.Rows.Count <> 0 Then
            DgvListado.DataSource = dt
        Else
            DgvListado.DataSource = Nothing
        End If
    End Sub
End Class