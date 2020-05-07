Imports System.ComponentModel
Imports System.Text.RegularExpressions  'para poder utilizar las expresiones regulares
Public Class Form1
    Dim ER_SoloNumeros As New Regex("^-?[0-9]+([.][0-9]+)?$")
    Dim ER_SoloLetras As New Regex("^[a-zA-Z\s]{2,254}$")
    Dim ER_Telefono As New Regex("^\d{9}$")



    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()

    End Sub


    Private Sub txtNumero_Validating(sender As Object, e As CancelEventArgs) Handles txtNumero.Validating
        If ER_SoloNumeros.IsMatch(txtNumero.Text) Then

            ErrorProvider.SetError(txtNumero, "")
        Else
            'MessageBox.Show("False")
            ErrorProvider.SetError(txtNumero, "Data no valida")
            txtNumero.Focus()
            txtNumero.SelectAll()
        End If
    End Sub

    Private Sub txtTexto_TextChanged(sender As Object, e As EventArgs) Handles txtTexto.TextChanged

    End Sub

    Private Sub txtTexto_Validating(sender As Object, e As CancelEventArgs) Handles txtTexto.Validating
        If ER_SoloLetras.IsMatch(txtTexto.Text) Then

            ErrorProvider.SetError(txtTexto, "")
        Else
            'MessageBox.Show("False")
            ErrorProvider.SetError(txtTexto, "Data no valida")
            txtTexto.Focus()
            txtTexto.SelectAll()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtTelefono_Validating(sender As Object, e As CancelEventArgs) Handles TxtTelefono.Validating
        If ER_Telefono.IsMatch(TxtTelefono.Text) Then

            ErrorProvider.SetError(TxtTelefono, "")
        Else
            'MessageBox.Show("False")
            ErrorProvider.SetError(TxtTelefono, "Data no valida")
            TxtTelefono.Focus()
            TxtTelefono.SelectAll()
        End If
    End Sub
End Class
