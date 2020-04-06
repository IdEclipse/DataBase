Public Class FrmCategoria
    Private dt As New DataTable
    Private Sub FrmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        CargarInformacionCajaTextos()
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

    Public Sub Limpiar()

        IdCategoriaTextBox.Clear()
        CetegoriaTextBox.Clear()

        CetegoriaTextBox.Focus()



    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        Limpiar()
        Mostrar()

    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
#Region "Validar Formularios"
        If Me.ValidateChildren = True And CetegoriaTextBox.Text <> "" Then

        Else
            Exit Sub
        End If
#End Region

        Dim objeto As New Categoria
        Dim Operacion As New fCategoria

        objeto.Nombre = CetegoriaTextBox.Text


        If Operacion.InsertarCategoria(objeto) Then
            MsgBox("Insertado")
        End If

        Mostrar()



    End Sub


    Private Sub CargarInformacionCajaTextos()
        IdCategoriaTextBox.Text = DgvCategoria.CurrentRow.Cells("IdCategoria").Value.ToString
        CetegoriaTextBox.Text = DgvCategoria.CurrentRow.Cells("Nombre").Value.ToString

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
#Region "Validar Formularios"
        If Me.ValidateChildren = True And
                IdCategoriaTextBox.Text <> "" And
                CetegoriaTextBox.Text <> "" Then

        Else
            Exit Sub
        End If
#End Region

        Dim objeto As New Categoria
        Dim Operacion As New fCategoria


        objeto.IdCategoria = IdCategoriaTextBox.Text
        objeto.Nombre = CetegoriaTextBox.Text


        If Operacion.EditarCategoria(objeto) Then
            MsgBox("Actualizado")
        End If

        Mostrar()
    End Sub




    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        Dim objeto As New Categoria
        Dim Operacion As New fCategoria


        objeto.IdCategoria = IdCategoriaTextBox.Text


        If Operacion.EliminarCategoria(objeto.IdCategoria) Then
            MsgBox("Eliminado")
        End If

        Mostrar()

    End Sub



    Private Sub DgvCategoria_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCategoria.CellClick
        CargarInformacionCajaTextos()
    End Sub
End Class