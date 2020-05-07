Imports System.Text.RegularExpressions
Public Class Form1
    Dim Er_SoloLetras As New Regex("^[a-zA-Z\s]{2,25}$")
    Dim Er_SoloNumeros As New Regex("^[0-9]{2}$")
    Dim Er_telefonos As New Regex("^\d{9}$")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If Er_SoloLetras.IsMatch(txtNombre.Text) Then
            ErrorProvider.SetError(txtNombre, "")
            e.Cancel = False
        Else
            ErrorProvider.SetError(txtNombre, "Data no valida")
            txtNombre.Focus()
            txtNombre.SelectAll()
            e.Cancel = True
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If Me.ValidateChildren = True Then
            Application.Exit()
        End If

    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEdad.Validating
        If Er_SoloNumeros.IsMatch(txtEdad.Text) Then
            ErrorProvider.SetError(txtEdad, "")
            e.Cancel = False

        Else
            ErrorProvider.SetError(txtEdad, "Data no valida")
            txtEdad.Focus()
            txtEdad.SelectAll()
            e.Cancel = True
        End If
    End Sub

    Private Sub txtTelefono_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTelefono.Validating
        If Er_telefonos.IsMatch(txtTelefono.Text) Then
            ErrorProvider.SetError(txtTelefono, "")
            e.Cancel = False
        Else
            ErrorProvider.SetError(txtTelefono, "Data no valida")
            txtTelefono.Focus()
            txtTelefono.SelectAll()
            e.Cancel = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
