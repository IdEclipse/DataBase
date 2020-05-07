Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        Dim adaptador As New CSE_DEPTDataSetTableAdapters.LogInTableAdapter
        Dim formulario As New FrmSelection

        adaptador.ClearBeforeFill = True
        adaptador.FillByNamePassword(CSE_DEPTDataSet.LogIn, txtUserName.Text, txtPasswordWord.Text)

        If CSE_DEPTDataSet.LogIn.Count = 0 Then
            MessageBox.Show("Usuario / Password error")
            Exit Sub
        End If
        formulario.Show()
        Me.Hide()


    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Application.Exit()
    End Sub
End Class
