Imports System.Text.RegularExpressions

Public Class Form1

    Dim SoloLetras As New Regex("^[a-zA-Z\s]{2,25}$")   'solo ingreso de letras
    Dim SoloNumero As New Regex("^[0-9]{2}$")   'solo ingreso de numeros 10 - 99
    Dim SoloTelefono As New Regex("^\d{9}$")   'restringe numero de 9 digitos



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If SoloLetras.IsMatch(txtNombre.Text) Then
            e.Cancel = False    'si valido el ingreso
            ErrorProvider.SetError(txtNombre, "")
        Else
            e.Cancel = True     'no valido el ingreso
            ErrorProvider.SetError(txtNombre, "error en la informacion")
            txtNombre.Focus()
            txtNombre.SelectAll()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        txtNombre.CausesValidation = False
        txtEdad.CausesValidation = False
        txtTelefono.CausesValidation = False

        Me.Close()

    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        If Me.ValidateChildren = True Then
            MessageBox.Show("Ingresando Data")
        End If
    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEdad.Validating
        If SoloNumero.IsMatch(txtEdad.Text) Then
            e.Cancel = False    'si valido el ingreso
            ErrorProvider.SetError(txtEdad, "")
        Else
            e.Cancel = True     'no valido el ingreso
            ErrorProvider.SetError(txtEdad, "error en la informacion")
            txtEdad.Focus()
            txtEdad.SelectAll()
        End If
    End Sub

    Private Sub txtTelefono_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTelefono.Validating
        If SoloTelefono.IsMatch(txtTelefono.Text) Then
            e.Cancel = False    'si valido el ingreso
            ErrorProvider.SetError(txtTelefono, "")
        Else
            e.Cancel = True     'no valido el ingreso
            ErrorProvider.SetError(txtTelefono, "error en la informacion")
            txtTelefono.Focus()
            txtTelefono.SelectAll()
        End If
    End Sub
End Class
