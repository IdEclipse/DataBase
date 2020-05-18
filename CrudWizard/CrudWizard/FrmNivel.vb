Public Class FrmNivel
    Dim Opcion As Integer = 0
    Dim posicion As Integer

    Private Sub FrmNivel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ds.Nivel' Puede moverla o quitarla según sea necesario.
        Me.NivelTableAdapter.Fill(Me.Ds.Nivel)
        'TODO: esta línea de código carga datos en la tabla 'ds.Nivel' Puede moverla o quitarla según sea necesario.
        Me.NivelTableAdapter.Fill(Me.ds.Nivel)

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        AlternaBotones()
        HabilitaCajaTexto()

        'Deshabilitar Binding
        posicion = NivelBindingSource.Position
        NivelBindingSource.SuspendBinding()

        Opcion = 1  'Opcion cuando se graba
        NivelDataGridView.Enabled = False

    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        AlternaBotones()
        HabilitaCajaTexto()

        Opcion = 2  'Opcion cuando se edita

        'Desactivar el Grid para evitar cambiar de registro
        NivelDataGridView.Enabled = False
        posicion = NivelBindingSource.Position
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        AlternaBotones()
        DeshabilitaCajaTexto()

        Select Case Opcion

            Case 1  'Grabar


                'Retiramos los capturadores de errores
                ErrorProvider.SetError(NombreNivelTextBox, "")

                'Guardar posicion del elemento seleccionado
                NivelDataGridView.Enabled = True        'Habilito el DGV
                NivelBindingSource.ResumeBinding()      'Desatablesco el binding
                NivelBindingSource.Position = posicion  'Restablesco posicion en el grid



            Case 2  'Editar

                'Guardar posicion del elemento seleccionado
                NivelDataGridView.Enabled = True        'Habilito el DGV
                NivelTableAdapter.Fill(ds.Nivel)
                NivelBindingSource.Position = posicion



        End Select
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'Preguntar si esta seguro de birrar el registro
        Dim Respuesta As MsgBoxResult
        posicion = NivelBindingSource.Position
        Respuesta = MessageBox.Show("Borrar el registro actual", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If NivelDataGridView.RowCount > 0 Then

            If Respuesta = vbYes Then
                NivelTableAdapter.NivelDeleteQuery(IdNivelTextBox.Text)

                'Refrescar el DS
                NivelTableAdapter.Fill(Ds.Nivel)
                NivelBindingSource.Position = posicion - 1
            Else
                Exit Sub
            End If

        Else
            MessageBox.Show("No existe registro en el Grid", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Select Case Opcion

            Case 1

                If ValidarCaja() = True Then
                    Try
                        NivelTableAdapter.NivelInsertQuery(NombreNivelTextBox.Text.ToUpper)
                        Me.NivelTableAdapter.Fill(Me.Ds.Nivel)
                        MessageBox.Show("Registro guardado correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        DeshabilitaCajaTexto()
                        NivelBindingSource.ResumeBinding()  'Conectar el Binding
                        NivelTableAdapter.Fill(Ds.Nivel)
                        NivelBindingSource.MoveLast()       'Movel al ultimo registro
                        NivelDataGridView.Enabled = True
                        AlternaBotones()
                    Catch ex As Exception
                        MessageBox.Show("Error, registro duplicado", "Error Registrando", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        btnCancelar.PerformClick()
                    End Try

                Else
                    Exit Sub

                End If


            Case 2


                If ValidarCaja() = True Then
                    NivelTableAdapter.NivelUpdateQuery(NombreNivelTextBox.Text.ToUpper, IdNivelTextBox.Text)
                    Me.NivelTableAdapter.Fill(Me.Ds.Nivel)
                    MessageBox.Show("Registro Actualizaco correctamente", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DeshabilitaCajaTexto()
                    NivelDataGridView.Enabled = True
                    AlternaBotones()
                Else
                    Exit Sub

                End If

        End Select

    End Sub


    Private Sub AlternaBotones()
        If btnNuevo.Enabled = True Then
            btnNuevo.Enabled = False
            btnEditar.Enabled = False
            btnEliminar.Enabled = False
            btnCancelar.Enabled = True
            btnGrabar.Enabled = True
        Else
            btnNuevo.Enabled = True
            btnEditar.Enabled = True
            btnEliminar.Enabled = True
            btnCancelar.Enabled = False
            btnGrabar.Enabled = False
        End If
    End Sub


    'Procedimiento para habilitar caja de textos
    Private Sub HabilitaCajaTexto()
        Dim valor As Boolean = True
        IdNivelTextBox.Enabled = Not valor    'Autonumerico, siempre protegido
        NombreNivelTextBox.Enabled = valor
        'Enfocar la caja de texto
        NombreNivelTextBox.Focus()

    End Sub

    'Procedimiento para deshabilitar caja de textos
    Private Sub DeshabilitaCajaTexto()
        Dim valor As Boolean = False
        IdNivelTextBox.Enabled = valor    'Autonumerico, siempre protegido
        NombreNivelTextBox.Enabled = valor
        'Enfocar la caja de texto
        NombreNivelTextBox.Focus()
    End Sub

    Function ValidarCaja() As Boolean
        If NombreNivelTextBox.Text = "" Then
            ErrorProvider.SetError(NombreNivelTextBox, "Ingrese Nombre")
            Return False

        Else
            ErrorProvider.SetError(NombreNivelTextBox, "")

            Return True
        End If
    End Function

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub
End Class