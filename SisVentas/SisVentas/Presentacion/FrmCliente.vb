Imports System.ComponentModel

Public Class FrmCliente
    Private dt As New DataTable

    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        CargarInformacionCajaTextos()

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





    Private Sub NombreTextBox_Validating(sender As Object, e As CancelEventArgs) Handles NombreTextBox.Validating
#Region "ValidarCajaTexto"
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ErrorIcono.SetError(sender, "")
        Else
            ErrorIcono.SetError(sender, "Informacion requerida")
        End If
#End Region
    End Sub

    Private Sub ApellidoTextBox_Validating(sender As Object, e As CancelEventArgs) Handles ApellidoTextBox.Validating
#Region "ValidarCajaTexto"
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ErrorIcono.SetError(sender, "")
        Else
            ErrorIcono.SetError(sender, "Informacion requerida")
        End If
#End Region
    End Sub

    Private Sub DireccionTextBox_Validating(sender As Object, e As CancelEventArgs) Handles DireccionTextBox.Validating
#Region "ValidarCajaTexto"
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ErrorIcono.SetError(sender, "")
        Else
            ErrorIcono.SetError(sender, "Informacion requerida")
        End If
#End Region
    End Sub

    Private Sub TelefonoTextBox_Validating(sender As Object, e As CancelEventArgs) Handles TelefonoTextBox.Validating
#Region "ValidarCajaTexto"
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ErrorIcono.SetError(sender, "")
        Else
            ErrorIcono.SetError(sender, "Informacion requerida")
        End If
#End Region
    End Sub

    Private Sub DNITextBox_Validating(sender As Object, e As CancelEventArgs) Handles DNITextBox.Validating
#Region "ValidarCajaTexto"
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ErrorIcono.SetError(sender, "")
        Else
            ErrorIcono.SetError(sender, "Informacion requerida")
        End If
#End Region
    End Sub


    Public Sub Limpiar()

        NombreTextBox.Clear()
        ApellidoTextBox.Clear()
        DireccionTextBox.Clear()
        TelefonoTextBox.Clear()
        DNITextBox.Clear()
        IdClienteTextBox.Clear()
        NombreTextBox.Focus()



    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        Limpiar()
        Mostrar()

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
#Region "Validar Formularios"
        If Me.ValidateChildren = True And
                NombreTextBox.Text <> "" And
                ApellidoTextBox.Text <> "" And
                DireccionTextBox.Text <> "" And
                TelefonoTextBox.Text <> "" And
                DNITextBox.Text <> "" Then
        Else
            Exit Sub
        End If
#End Region

        Dim objeto As New Cliente
        Dim Operacion As New fCliente

        objeto.Nombre = NombreTextBox.Text
        objeto.Apellido = ApellidoTextBox.Text
        objeto.Direccion = DireccionTextBox.Text
        objeto.Telefono = TelefonoTextBox.Text
        objeto.Dni = DNITextBox.Text

        If Operacion.InsertarCliente(objeto) Then
            MsgBox("Insertado")
        End If

        Mostrar()



    End Sub



    Private Sub CargarInformacionCajaTextos()
        IdClienteTextBox.Text = DgvListado.CurrentRow.Cells("IdCliente").Value.ToString
        NombreTextBox.Text = DgvListado.CurrentRow.Cells("Nombre").Value.ToString
        ApellidoTextBox.Text = DgvListado.CurrentRow.Cells("Apellido").Value.ToString
        DireccionTextBox.Text = DgvListado.CurrentRow.Cells("Direccion").Value.ToString
        TelefonoTextBox.Text = DgvListado.CurrentRow.Cells("Telefono").Value.ToString
        DNITextBox.Text = DgvListado.CurrentRow.Cells("DNI").Value.ToString
    End Sub



    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
#Region "Validar Formularios"
        If Me.ValidateChildren = True And
                NombreTextBox.Text <> "" And
                ApellidoTextBox.Text <> "" And
                DireccionTextBox.Text <> "" And
                TelefonoTextBox.Text <> "" And
                DNITextBox.Text <> "" Then
        Else
            Exit Sub
        End If
#End Region

        Dim objeto As New Cliente
        Dim Operacion As New fCliente


        objeto.IdCliente = IdClienteTextBox.Text
        objeto.Nombre = NombreTextBox.Text
        objeto.Apellido = ApellidoTextBox.Text
        objeto.Direccion = DireccionTextBox.Text
        objeto.Telefono = TelefonoTextBox.Text
        objeto.Dni = DNITextBox.Text

        If Operacion.EditarCliente(objeto) Then
            MsgBox("Actualizado")
        End If

        Mostrar()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        Dim objeto As New Cliente
        Dim Operacion As New fCliente


        objeto.IdCliente = IdClienteTextBox.Text


        If Operacion.EliminarCliente(objeto.IdCliente) Then
            MsgBox("Eliminado")
        End If

        Mostrar()

    End Sub



    Private Sub DgvListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellClick
        CargarInformacionCajaTextos()
    End Sub
End Class