Public Class FrmPrincipal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MyCompanyDataSet.Employee' Puede moverla o quitarla según sea necesario.
        Me.EmployeeTableAdapter.Fill(Me.MyCompanyDataSet.Employee)

    End Sub
End Class
