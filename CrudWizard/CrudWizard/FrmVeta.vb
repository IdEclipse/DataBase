Public Class FrmVeta
    Dim Opcion As Integer = 0
    Dim posicion As Integer

    Private Sub FrmVeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsMina.Veta' Puede moverla o quitarla según sea necesario.
        Me.VetaTableAdapter.Fill(Me.ds.Veta)

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        AlternaBotones()
        HabilitaCajaTexto()

        'Deshabilitar Binding
        posicion = VetaBindingSource.Position
        VetaBindingSource.SuspendBinding()

        Opcion = 1  'Opcion cuando se graba
        VetaDataGridView.Enabled = False

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
        IdVetaTextBox.Enabled = Not valor    'Autonumerico, siempre protegido
        NombreVetaTextBox.Enabled = valor
        'Enfocar la caja de texto
        NombreVetaTextBox.Focus()

    End Sub

    'Procedimiento para deshabilitar caja de textos
    Private Sub DeshabilitaCajaTexto()
        Dim valor As Boolean = False
        IdVetaTextBox.Enabled = valor    'Autonumerico, siempre protegido
        NombreVetaTextBox.Enabled = valor
        'Enfocar la caja de texto
        NombreVetaTextBox.Focus()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        AlternaBotones()
        HabilitaCajaTexto()

        Opcion = 2  'Opcion cuando se edita

        'Desactivar el Grid para evitar cambiar de registro
        VetaDataGridView.Enabled = False
        posicion = VetaBindingSource.Position
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        AlternaBotones()
        DeshabilitaCajaTexto()

        Select Case Opcion

            Case 1  'Grabar


                'Retiramos los capturadores de errores
                ErrorProvider.SetError(NombreVetaTextBox, "")

                'Guardar posicion del elemento seleccionado
                VetaDataGridView.Enabled = True        'Habilito el DGV
                VetaBindingSource.ResumeBinding()      'Desatablesco el binding
                VetaBindingSource.Position = posicion  'Restablesco posicion en el grid



            Case 2  'Editar

                'Guardar posicion del elemento seleccionado
                VetaDataGridView.Enabled = True        'Habilito el DGV
                VetaTableAdapter.Fill(ds.Veta)
                VetaBindingSource.Position = posicion



        End Select
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'Preguntar si esta seguro de birrar el registro
        Dim Respuesta As MsgBoxResult
        posicion = VetaBindingSource.Position
        Respuesta = MessageBox.Show("Borrar el registro actual", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If VetaDataGridView.RowCount > 0 Then

            If Respuesta = vbYes Then
                'VetaTableAdapter.DeleteQuery(IdVetaTextBox.Text)

                'Refrescar el DS
                VetaTableAdapter.Fill(ds.Veta)
                VetaBindingSource.Position = posicion - 1
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
                        'VetaTableAdapter.InsertQuery(NombreVetaTextBox.Text.ToUpper)
                        MessageBox.Show("Registro guardado correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        DeshabilitaCajaTexto()
                        VetaBindingSource.ResumeBinding()  'Conectar el Binding
                        VetaTableAdapter.Fill(ds.Veta)
                        VetaBindingSource.MoveLast()       'Movel al ultimo registro
                        VetaDataGridView.Enabled = True
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
                    'VetaTableAdapter.UpdateQuery(NombreVetaTextBox.Text.ToUpper, IdVetaTextBox.Text)
                    MessageBox.Show("Registro Actualizaco correctamente", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DeshabilitaCajaTexto()
                    VetaDataGridView.Enabled = True
                    AlternaBotones()
                Else
                    Exit Sub

                End If

        End Select

    End Sub


    Function ValidarCaja() As Boolean
        If NombreVetaTextBox.Text = "" Then
            ErrorProvider.SetError(NombreVetaTextBox, "Ingrese Nombre")
            Return False

        Else
            ErrorProvider.SetError(NombreVetaTextBox, "")

            Return True
        End If
    End Function


End Class