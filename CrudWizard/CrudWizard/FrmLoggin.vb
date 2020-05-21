Public Class FrmLoggin
    Private intentos As Integer = 0


    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        UsuarioTableAdapter.FillBy(Ds.Usuario, TextBoxNombre.Text, TextBoxPassword.Text)
        If Ds.Usuario.Rows.Count > 0 Then
            Dim frm As New FrmPrincipal
            Me.Hide()
            FrmPrincipal.Show()

        Else
            MessageBox.Show("Error en Loggin " + " [" + (2 - intentos).ToString + "]  Intentos Restantes")
            intentos = intentos + 1
            If intentos = 3 Then
                Application.Exit()
            End If
        End If


    End Sub

    Private Sub FrmLoggin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub
End Class