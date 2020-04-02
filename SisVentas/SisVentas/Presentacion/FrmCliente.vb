Imports System.ComponentModel

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



    Private Sub IdClienteTextBox_Validating(sender As Object, e As CancelEventArgs) Handles IdClienteTextBox.Validating



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
        BtnGuardar.Visible = True
        BtnEditar.Visible = False
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
End Class