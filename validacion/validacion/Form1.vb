Imports System.Text.RegularExpressions  'Expresiones Regulares
Public Class Form1
    Dim SoloLetras As New Regex("^[a-zA-Z\s]{2,25}$")
    Dim SoloNumeros As New Regex("^[0-9]{2}$")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If SoloLetras.IsMatch(txtNombre.Text) Then
            ErrorProvider.SetError(txtNombre, "")
            e.Cancel = False
        Else
            ErrorProvider.SetError(txtNombre, "dato invalido")
            e.Cancel = True
            txtNombre.Focus()
            txtNombre.SelectAll()
        End If
    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEdad.Validating
        If SoloNumeros.IsMatch(txtEdad.Text) Then
            ErrorProvider.SetError(txtEdad, "")
            e.Cancel = False
        Else
            ErrorProvider.SetError(txtEdad, "dato invalido")
            e.Cancel = True
            txtEdad.Focus()
            txtEdad.SelectAll()
        End If
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If Me.ValidateChildren = True Then
            MessageBox.Show("ok")
        Else
            MessageBox.Show("problemas en la informacion")
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub
End Class
