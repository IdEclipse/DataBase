<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLabor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLabor))
        Dim IdLaborLabel As System.Windows.Forms.Label
        Dim IdNivelLabel As System.Windows.Forms.Label
        Dim IdVetaLabel As System.Windows.Forms.Label
        Dim IdTipoLaborLabel As System.Windows.Forms.Label
        Dim UTMLabel As System.Windows.Forms.Label
        Dim IdOrientacionLabel As System.Windows.Forms.Label
        Me.lblMantenimientoVetas = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBoxDetalleVeta = New System.Windows.Forms.GroupBox()
        Me.LaborDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DsMina = New CrudWizard.dsMina()
        Me.LaborBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LaborTableAdapter = New CrudWizard.dsMinaTableAdapters.LaborTableAdapter()
        Me.TableAdapterManager = New CrudWizard.dsMinaTableAdapters.TableAdapterManager()
        Me.IdLaborTextBox = New System.Windows.Forms.TextBox()
        Me.IdNivelComboBox = New System.Windows.Forms.ComboBox()
        Me.IdVetaComboBox = New System.Windows.Forms.ComboBox()
        Me.IdTipoLaborComboBox = New System.Windows.Forms.ComboBox()
        Me.UTMTextBox = New System.Windows.Forms.TextBox()
        Me.IdOrientacionComboBox = New System.Windows.Forms.ComboBox()
        Me.IdLaborDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdNivelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdVetaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTipoLaborDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UTMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdOrientacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Label1 = New System.Windows.Forms.Label()
        IdLaborLabel = New System.Windows.Forms.Label()
        IdNivelLabel = New System.Windows.Forms.Label()
        IdVetaLabel = New System.Windows.Forms.Label()
        IdTipoLaborLabel = New System.Windows.Forms.Label()
        UTMLabel = New System.Windows.Forms.Label()
        IdOrientacionLabel = New System.Windows.Forms.Label()
        Me.GroupBoxDetalleVeta.SuspendLayout()
        CType(Me.LaborDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaborBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(470, 15)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(37, 13)
        Label1.TabIndex = 1
        Label1.Text = "Labor:"
        '
        'lblMantenimientoVetas
        '
        Me.lblMantenimientoVetas.AutoSize = True
        Me.lblMantenimientoVetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMantenimientoVetas.Location = New System.Drawing.Point(12, 9)
        Me.lblMantenimientoVetas.Name = "lblMantenimientoVetas"
        Me.lblMantenimientoVetas.Size = New System.Drawing.Size(176, 20)
        Me.lblMantenimientoVetas.TabIndex = 0
        Me.lblMantenimientoVetas.Text = "Mantenimiento Labores"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Location = New System.Drawing.Point(601, 394)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(126, 44)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBoxDetalleVeta
        '
        Me.GroupBoxDetalleVeta.Controls.Add(IdOrientacionLabel)
        Me.GroupBoxDetalleVeta.Controls.Add(Me.IdOrientacionComboBox)
        Me.GroupBoxDetalleVeta.Controls.Add(UTMLabel)
        Me.GroupBoxDetalleVeta.Controls.Add(Me.UTMTextBox)
        Me.GroupBoxDetalleVeta.Controls.Add(IdTipoLaborLabel)
        Me.GroupBoxDetalleVeta.Controls.Add(Me.IdTipoLaborComboBox)
        Me.GroupBoxDetalleVeta.Controls.Add(IdVetaLabel)
        Me.GroupBoxDetalleVeta.Controls.Add(Me.IdVetaComboBox)
        Me.GroupBoxDetalleVeta.Controls.Add(IdNivelLabel)
        Me.GroupBoxDetalleVeta.Controls.Add(Me.IdNivelComboBox)
        Me.GroupBoxDetalleVeta.Controls.Add(IdLaborLabel)
        Me.GroupBoxDetalleVeta.Controls.Add(Me.IdLaborTextBox)
        Me.GroupBoxDetalleVeta.Location = New System.Drawing.Point(12, 288)
        Me.GroupBoxDetalleVeta.Name = "GroupBoxDetalleVeta"
        Me.GroupBoxDetalleVeta.Size = New System.Drawing.Size(715, 100)
        Me.GroupBoxDetalleVeta.TabIndex = 4
        Me.GroupBoxDetalleVeta.TabStop = False
        Me.GroupBoxDetalleVeta.Text = "DetalleVeta"
        '
        'LaborDataGridView
        '
        Me.LaborDataGridView.AllowUserToAddRows = False
        Me.LaborDataGridView.AllowUserToDeleteRows = False
        Me.LaborDataGridView.AutoGenerateColumns = False
        Me.LaborDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LaborDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdLaborDataGridViewTextBoxColumn, Me.IdNivelDataGridViewTextBoxColumn, Me.IdVetaDataGridViewTextBoxColumn, Me.IdTipoLaborDataGridViewTextBoxColumn, Me.UTMDataGridViewTextBoxColumn, Me.IdOrientacionDataGridViewTextBoxColumn})
        Me.LaborDataGridView.DataSource = Me.LaborBindingSource
        Me.LaborDataGridView.Location = New System.Drawing.Point(12, 44)
        Me.LaborDataGridView.MultiSelect = False
        Me.LaborDataGridView.Name = "LaborDataGridView"
        Me.LaborDataGridView.ReadOnly = True
        Me.LaborDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LaborDataGridView.Size = New System.Drawing.Size(715, 238)
        Me.LaborDataGridView.TabIndex = 3
        '
        'btnGrabar
        '
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrabar.Location = New System.Drawing.Point(425, 394)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(92, 44)
        Me.btnGrabar.TabIndex = 9
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(325, 394)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(92, 44)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(212, 394)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(92, 44)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(112, 394)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(92, 44)
        Me.btnEditar.TabIndex = 6
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(12, 394)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(92, 44)
        Me.btnNuevo.TabIndex = 5
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(513, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(214, 20)
        Me.TextBox1.TabIndex = 2
        '
        'DsMina
        '
        Me.DsMina.DataSetName = "dsMina"
        Me.DsMina.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LaborBindingSource
        '
        Me.LaborBindingSource.DataMember = "Labor"
        Me.LaborBindingSource.DataSource = Me.DsMina
        '
        'LaborTableAdapter
        '
        Me.LaborTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DetalleProgramaTableAdapter = Nothing
        Me.TableAdapterManager.EjecutorTableAdapter = Nothing
        Me.TableAdapterManager.LaborTableAdapter = Me.LaborTableAdapter
        Me.TableAdapterManager.NivelTableAdapter = Nothing
        Me.TableAdapterManager.OrientacionTableAdapter = Nothing
        Me.TableAdapterManager.ProgramaTableAdapter = Nothing
        Me.TableAdapterManager.TipoLaborTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CrudWizard.dsMinaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VetaTableAdapter = Nothing
        '
        'IdLaborLabel
        '
        IdLaborLabel.AutoSize = True
        IdLaborLabel.Location = New System.Drawing.Point(44, 29)
        IdLaborLabel.Name = "IdLaborLabel"
        IdLaborLabel.Size = New System.Drawing.Size(19, 13)
        IdLaborLabel.TabIndex = 0
        IdLaborLabel.Text = "Id:"
        '
        'IdLaborTextBox
        '
        Me.IdLaborTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaborBindingSource, "IdLabor", True))
        Me.IdLaborTextBox.Location = New System.Drawing.Point(69, 25)
        Me.IdLaborTextBox.Name = "IdLaborTextBox"
        Me.IdLaborTextBox.Size = New System.Drawing.Size(63, 20)
        Me.IdLaborTextBox.TabIndex = 1
        '
        'IdNivelLabel
        '
        IdNivelLabel.AutoSize = True
        IdNivelLabel.Location = New System.Drawing.Point(29, 68)
        IdNivelLabel.Name = "IdNivelLabel"
        IdNivelLabel.Size = New System.Drawing.Size(34, 13)
        IdNivelLabel.TabIndex = 2
        IdNivelLabel.Text = "Nivel:"
        '
        'IdNivelComboBox
        '
        Me.IdNivelComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaborBindingSource, "IdNivel", True))
        Me.IdNivelComboBox.FormattingEnabled = True
        Me.IdNivelComboBox.Location = New System.Drawing.Point(69, 64)
        Me.IdNivelComboBox.Name = "IdNivelComboBox"
        Me.IdNivelComboBox.Size = New System.Drawing.Size(100, 21)
        Me.IdNivelComboBox.TabIndex = 3
        '
        'IdVetaLabel
        '
        IdVetaLabel.AutoSize = True
        IdVetaLabel.Location = New System.Drawing.Point(291, 27)
        IdVetaLabel.Name = "IdVetaLabel"
        IdVetaLabel.Size = New System.Drawing.Size(32, 13)
        IdVetaLabel.TabIndex = 4
        IdVetaLabel.Text = "Veta:"
        '
        'IdVetaComboBox
        '
        Me.IdVetaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaborBindingSource, "IdVeta", True))
        Me.IdVetaComboBox.FormattingEnabled = True
        Me.IdVetaComboBox.Location = New System.Drawing.Point(329, 24)
        Me.IdVetaComboBox.Name = "IdVetaComboBox"
        Me.IdVetaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.IdVetaComboBox.TabIndex = 5
        '
        'IdTipoLaborLabel
        '
        IdTipoLaborLabel.AutoSize = True
        IdTipoLaborLabel.Location = New System.Drawing.Point(262, 66)
        IdTipoLaborLabel.Name = "IdTipoLaborLabel"
        IdTipoLaborLabel.Size = New System.Drawing.Size(61, 13)
        IdTipoLaborLabel.TabIndex = 6
        IdTipoLaborLabel.Text = "Tipo Labor:"
        '
        'IdTipoLaborComboBox
        '
        Me.IdTipoLaborComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaborBindingSource, "IdTipoLabor", True))
        Me.IdTipoLaborComboBox.FormattingEnabled = True
        Me.IdTipoLaborComboBox.Location = New System.Drawing.Point(329, 63)
        Me.IdTipoLaborComboBox.Name = "IdTipoLaborComboBox"
        Me.IdTipoLaborComboBox.Size = New System.Drawing.Size(67, 21)
        Me.IdTipoLaborComboBox.TabIndex = 7
        '
        'UTMLabel
        '
        UTMLabel.AutoSize = True
        UTMLabel.Location = New System.Drawing.Point(584, 32)
        UTMLabel.Name = "UTMLabel"
        UTMLabel.Size = New System.Drawing.Size(34, 13)
        UTMLabel.TabIndex = 8
        UTMLabel.Text = "UTM:"
        '
        'UTMTextBox
        '
        Me.UTMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaborBindingSource, "UTM", True))
        Me.UTMTextBox.Location = New System.Drawing.Point(624, 29)
        Me.UTMTextBox.Name = "UTMTextBox"
        Me.UTMTextBox.Size = New System.Drawing.Size(56, 20)
        Me.UTMTextBox.TabIndex = 9
        '
        'IdOrientacionLabel
        '
        IdOrientacionLabel.AutoSize = True
        IdOrientacionLabel.Location = New System.Drawing.Point(554, 67)
        IdOrientacionLabel.Name = "IdOrientacionLabel"
        IdOrientacionLabel.Size = New System.Drawing.Size(64, 13)
        IdOrientacionLabel.TabIndex = 10
        IdOrientacionLabel.Text = "Orientacion:"
        '
        'IdOrientacionComboBox
        '
        Me.IdOrientacionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaborBindingSource, "IdOrientacion", True))
        Me.IdOrientacionComboBox.FormattingEnabled = True
        Me.IdOrientacionComboBox.Location = New System.Drawing.Point(624, 64)
        Me.IdOrientacionComboBox.Name = "IdOrientacionComboBox"
        Me.IdOrientacionComboBox.Size = New System.Drawing.Size(56, 21)
        Me.IdOrientacionComboBox.TabIndex = 11
        '
        'IdLaborDataGridViewTextBoxColumn
        '
        Me.IdLaborDataGridViewTextBoxColumn.DataPropertyName = "IdLabor"
        Me.IdLaborDataGridViewTextBoxColumn.HeaderText = "IdLabor"
        Me.IdLaborDataGridViewTextBoxColumn.Name = "IdLaborDataGridViewTextBoxColumn"
        Me.IdLaborDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdNivelDataGridViewTextBoxColumn
        '
        Me.IdNivelDataGridViewTextBoxColumn.DataPropertyName = "IdNivel"
        Me.IdNivelDataGridViewTextBoxColumn.HeaderText = "IdNivel"
        Me.IdNivelDataGridViewTextBoxColumn.Name = "IdNivelDataGridViewTextBoxColumn"
        Me.IdNivelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdVetaDataGridViewTextBoxColumn
        '
        Me.IdVetaDataGridViewTextBoxColumn.DataPropertyName = "IdVeta"
        Me.IdVetaDataGridViewTextBoxColumn.HeaderText = "IdVeta"
        Me.IdVetaDataGridViewTextBoxColumn.Name = "IdVetaDataGridViewTextBoxColumn"
        Me.IdVetaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdTipoLaborDataGridViewTextBoxColumn
        '
        Me.IdTipoLaborDataGridViewTextBoxColumn.DataPropertyName = "IdTipoLabor"
        Me.IdTipoLaborDataGridViewTextBoxColumn.HeaderText = "IdTipoLabor"
        Me.IdTipoLaborDataGridViewTextBoxColumn.Name = "IdTipoLaborDataGridViewTextBoxColumn"
        Me.IdTipoLaborDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UTMDataGridViewTextBoxColumn
        '
        Me.UTMDataGridViewTextBoxColumn.DataPropertyName = "UTM"
        Me.UTMDataGridViewTextBoxColumn.HeaderText = "UTM"
        Me.UTMDataGridViewTextBoxColumn.Name = "UTMDataGridViewTextBoxColumn"
        Me.UTMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdOrientacionDataGridViewTextBoxColumn
        '
        Me.IdOrientacionDataGridViewTextBoxColumn.DataPropertyName = "IdOrientacion"
        Me.IdOrientacionDataGridViewTextBoxColumn.HeaderText = "IdOrientacion"
        Me.IdOrientacionDataGridViewTextBoxColumn.Name = "IdOrientacionDataGridViewTextBoxColumn"
        Me.IdOrientacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'FrmLabor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(738, 450)
        Me.Controls.Add(Me.lblMantenimientoVetas)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBoxDetalleVeta)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LaborDataGridView)
        Me.Name = "FrmLabor"
        Me.Text = "FrmLabor"
        Me.GroupBoxDetalleVeta.ResumeLayout(False)
        Me.GroupBoxDetalleVeta.PerformLayout()
        CType(Me.LaborDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaborBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMantenimientoVetas As Label
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBoxDetalleVeta As GroupBox
    Friend WithEvents LaborDataGridView As DataGridView
    Friend WithEvents EstructuraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents NombreLaborDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdEstructuraDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents DsMina As dsMina
    Friend WithEvents LaborBindingSource As BindingSource
    Friend WithEvents LaborTableAdapter As dsMinaTableAdapters.LaborTableAdapter
    Friend WithEvents TableAdapterManager As dsMinaTableAdapters.TableAdapterManager
    Friend WithEvents IdOrientacionComboBox As ComboBox
    Friend WithEvents UTMTextBox As TextBox
    Friend WithEvents IdTipoLaborComboBox As ComboBox
    Friend WithEvents IdVetaComboBox As ComboBox
    Friend WithEvents IdNivelComboBox As ComboBox
    Friend WithEvents IdLaborTextBox As TextBox
    Friend WithEvents IdLaborDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdNivelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdVetaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdTipoLaborDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UTMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdOrientacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider As ErrorProvider
End Class
