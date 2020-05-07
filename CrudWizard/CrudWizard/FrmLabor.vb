Public Class FrmLabor
    Dim Opcion As Integer = 0
    Dim posicion As Integer
    Private Sub FrmLabor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsMina.Labor' Puede moverla o quitarla según sea necesario.
        Me.LaborTableAdapter.Fill(Me.DsMina.Labor)
        'TODO: esta línea de código carga datos en la tabla 'DsMina.Nivel' Puede moverla o quitarla según sea necesario.

        Me.LaborTableAdapter.Fill(Me.DsMina.Labor)


        GroupBoxDetalleVeta.Enabled = False

    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        GroupBoxDetalleVeta.Enabled = True
        AlternaBotones()
        HabilitaCajaTexto()

        'Deshabilitar Binding
        posicion = LaborBindingSource.Position
        LaborBindingSource.SuspendBinding()

        Opcion = 1  'Opcion cuando se graba
        LaborDataGridView.Enabled = False
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        GroupBoxDetalleVeta.Enabled = True
        AlternaBotones()
        HabilitaCajaTexto()

        Opcion = 2  'Opcion cuando se edita

        'Desactivar el Grid para evitar cambiar de registro
        LaborDataGridView.Enabled = False
        posicion = LaborBindingSource.Position
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        GroupBoxDetalleVeta.Enabled = False
        AlternaBotones()
        DeshabilitaCajaTexto()

        Select Case Opcion

            Case 1  'Grabar


                'Retiramos los capturadores de errores
                ErrorProvider.SetError(NombreLaborTextBox, "")

                'Guardar posicion del elemento seleccionado
                LaborDataGridView.Enabled = True        'Habilito el DGV
                LaborBindingSource.ResumeBinding()      'Desatablesco el binding
                LaborBindingSource.Position = posicion  'Restablesco posicion en el grid



            Case 2  'Editar

                'Guardar posicion del elemento seleccionado
                LaborDataGridView.Enabled = True        'Habilito el DGV
                LaborTableAdapter.Fill(DsMina.Labor)
                LaborBindingSource.Position = posicion



        End Select
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'Preguntar si esta seguro de birrar el registro
        Dim Respuesta As MsgBoxResult
        posicion = LaborBindingSource.Position
        Respuesta = MessageBox.Show("Borrar el registro actual", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If LaborDataGridView.RowCount > 0 Then

            If Respuesta = vbYes Then
                LaborTableAdapter.DeleteQuery(IdLaborTextBox.Text)

                'Refrescar el DS
                LaborTableAdapter.Fill(DsMina.Labor)
                LaborBindingSource.Position = posicion - 1
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
                        'LaborTableAdapter.InsertQuery(NombreLaborTextBox.Text.ToUpper, IdVetaComboBox.SelectedValue, IdNivelComboBox.SelectedValue, cboEstructura.SelectedValue)
                        LaborTableAdapter.InsertQuery(NombreLaborTextBox.Text.ToUpper, IdVetaComboBox.SelectedValue, IdNivelComboBox.SelectedValue, cboEstructura.SelectedValue)
                        Me.LaborTableAdapter.Fill(Me.DsMina.Labor)
                        MessageBox.Show("Registro guardado correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        DeshabilitaCajaTexto()
                        LaborBindingSource.ResumeBinding()  'Conectar el Binding
                        LaborTableAdapter.Fill(DsMina.Labor)
                        LaborBindingSource.MoveLast()       'Movel al ultimo registro
                        LaborDataGridView.Enabled = True
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
                    LaborTableAdapter.UpdateQuery(NombreLaborTextBox.Text.ToUpper, IdVetaComboBox.SelectedValue, IdNivelComboBox.SelectedValue, cboEstructura.SelectedValue, IdLaborTextBox.Text)
                    Me.LaborTableAdapter.Fill(Me.DsMina.Labor)
                    MessageBox.Show("Registro Actualizaco correctamente", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DeshabilitaCajaTexto()
                    LaborDataGridView.Enabled = True
                    AlternaBotones()
                Else
                    Exit Sub

                End If

        End Select
        GroupBoxDetalleVeta.Enabled = False

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
        IdLaborTextBox.Enabled = Not valor    'Autonumerico, siempre protegido
        NombreLaborTextBox.Enabled = valor
        'Enfocar la caja de texto
        NombreLaborTextBox.Focus()

    End Sub

    'Procedimiento para deshabilitar caja de textos
    Private Sub DeshabilitaCajaTexto()
        Dim valor As Boolean = False
        IdLaborTextBox.Enabled = valor    'Autonumerico, siempre protegido
        NombreLaborTextBox.Enabled = valor
        'Enfocar la caja de texto
        NombreLaborTextBox.Focus()
    End Sub

    Function ValidarCaja() As Boolean
        If NombreLaborTextBox.Text = "" Then
            ErrorProvider.SetError(NombreLaborTextBox, "Ingrese Nombre")
            Return False

        Else
            ErrorProvider.SetError(NombreLaborTextBox, "")

            Return True
        End If
    End Function

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Private Sub btnEditarVeta_Click(sender As Object, e As EventArgs)
        Dim frm As New FrmVeta
        frm.ShowDialog()

    End Sub

    Private Sub LaborBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LaborBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsMina)

    End Sub
End Class