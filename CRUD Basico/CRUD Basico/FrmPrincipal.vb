Public Class FrmPrincipal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MyCompanyDataSet.Employee' Puede moverla o quitarla según sea necesario.
        Me.EmployeeTableAdapter.Fill(Me.MyCompanyDataSet.Employee)

    End Sub

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        EmployeeTableAdapter.InsertQuery(IdNumberTextBox.Text, NameTextBox.Text, MailTextBox.Text, BirthdayDateTimePicker.Value)

    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        EmployeeBindingSource.SuspendBinding()
        IdPKTextBox.Clear()
        IdNumberTextBox.Clear()
        NameTextBox.Clear()
        MailTextBox.Clear()
        BirthdayDateTimePicker.Value = Date.Now
    End Sub
End Class
