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
        Dim IdLaborLabel As System.Windows.Forms.Label
        Dim IdNivelLabel As System.Windows.Forms.Label
        Dim IdVetaLabel As System.Windows.Forms.Label
        Dim UTMLabel As System.Windows.Forms.Label
        Dim IdOrientacionLabel As System.Windows.Forms.Label
        Dim IdTipoLaborLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLabor))
        Me.lblMantenimientoVetas = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBoxDetalleVeta = New System.Windows.Forms.GroupBox()
        Me.IdTipoLaborComboBox = New System.Windows.Forms.ComboBox()
        Me.LaborBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds = New CrudWizard.ds()
        Me.IdOrientacionComboBox = New System.Windows.Forms.ComboBox()
        Me.UTMTextBox = New System.Windows.Forms.TextBox()
        Me.IdVetaComboBox = New System.Windows.Forms.ComboBox()
        Me.IdNivelComboBox = New System.Windows.Forms.ComboBox()
        Me.IdLaborTextBox = New System.Windows.Forms.TextBox()
        Me.LaborDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LaborTableAdapter = New CrudWizard.dsTableAdapters.LaborTableAdapter()
        Me.TableAdapterManager = New CrudWizard.dsTableAdapters.TableAdapterManager()
        Me.NivelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NivelTableAdapter = New CrudWizard.dsTableAdapters.NivelTableAdapter()
        Me.VetaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VetaTableAdapter = New CrudWizard.dsTableAdapters.VetaTableAdapter()
        Me.TipoLaborBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoLaborTableAdapter = New CrudWizard.dsTableAdapters.TipoLaborTableAdapter()
        Me.OrientacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrientacionTableAdapter = New CrudWizard.dsTableAdapters.OrientacionTableAdapter()
        Me.IdLaborDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdNivelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.IdVetaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.IdTipoLaborDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.UTMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdOrientacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Label1 = New System.Windows.Forms.Label()
        IdLaborLabel = New System.Windows.Forms.Label()
        IdNivelLabel = New System.Windows.Forms.Label()
        IdVetaLabel = New System.Windows.Forms.Label()
        UTMLabel = New System.Windows.Forms.Label()
        IdOrientacionLabel = New System.Windows.Forms.Label()
        IdTipoLaborLabel1 = New System.Windows.Forms.Label()
        Me.GroupBoxDetalleVeta.SuspendLayout()
        CType(Me.LaborBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaborDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NivelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VetaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoLaborBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrientacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'IdLaborLabel
        '
        IdLaborLabel.AutoSize = True
        IdLaborLabel.Location = New System.Drawing.Point(33, 31)
        IdLaborLabel.Name = "IdLaborLabel"
        IdLaborLabel.Size = New System.Drawing.Size(49, 13)
        IdLaborLabel.TabIndex = 0
        IdLaborLabel.Text = "Id Labor:"
        '
        'IdNivelLabel
        '
        IdNivelLabel.AutoSize = True
        IdNivelLabel.Location = New System.Drawing.Point(36, 69)
        IdNivelLabel.Name = "IdNivelLabel"
        IdNivelLabel.Size = New System.Drawing.Size(46, 13)
        IdNivelLabel.TabIndex = 2
        IdNivelLabel.Text = "Id Nivel:"
        '
        'IdVetaLabel
        '
        IdVetaLabel.AutoSize = True
        IdVetaLabel.Location = New System.Drawing.Point(287, 31)
        IdVetaLabel.Name = "IdVetaLabel"
        IdVetaLabel.Size = New System.Drawing.Size(44, 13)
        IdVetaLabel.TabIndex = 4
        IdVetaLabel.Text = "Id Veta:"
        '
        'UTMLabel
        '
        UTMLabel.AutoSize = True
        UTMLabel.Location = New System.Drawing.Point(539, 31)
        UTMLabel.Name = "UTMLabel"
        UTMLabel.Size = New System.Drawing.Size(34, 13)
        UTMLabel.TabIndex = 8
        UTMLabel.Text = "UTM:"
        '
        'IdOrientacionLabel
        '
        IdOrientacionLabel.AutoSize = True
        IdOrientacionLabel.Location = New System.Drawing.Point(497, 66)
        IdOrientacionLabel.Name = "IdOrientacionLabel"
        IdOrientacionLabel.Size = New System.Drawing.Size(76, 13)
        IdOrientacionLabel.TabIndex = 10
        IdOrientacionLabel.Text = "Id Orientacion:"
        '
        'IdTipoLaborLabel1
        '
        IdTipoLaborLabel1.AutoSize = True
        IdTipoLaborLabel1.Location = New System.Drawing.Point(258, 69)
        IdTipoLaborLabel1.Name = "IdTipoLaborLabel1"
        IdTipoLaborLabel1.Size = New System.Drawing.Size(73, 13)
        IdTipoLaborLabel1.TabIndex = 11
        IdTipoLaborLabel1.Text = "Id Tipo Labor:"
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
        Me.btnSalir.Location = New System.Drawing.Point(602, 394)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(126, 44)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBoxDetalleVeta
        '
        Me.GroupBoxDetalleVeta.Controls.Add(IdTipoLaborLabel1)
        Me.GroupBoxDetalleVeta.Controls.Add(Me.IdTipoLaborComboBox)
        Me.GroupBoxDetalleVeta.Controls.Add(IdOrientacionLabel)
        Me.GroupBoxDetalleVeta.Controls.Add(Me.IdOrientacionComboBox)
        Me.GroupBoxDetalleVeta.Controls.Add(UTMLabel)
        Me.GroupBoxDetalleVeta.Controls.Add(Me.UTMTextBox)
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
        'IdTipoLaborComboBox
        '
        Me.IdTipoLaborComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LaborBindingSource, "IdTipoLabor", True))
        Me.IdTipoLaborComboBox.DataSource = Me.TipoLaborBindingSource
        Me.IdTipoLaborComboBox.DisplayMember = "NombreTipoLabor"
        Me.IdTipoLaborComboBox.FormattingEnabled = True
        Me.IdTipoLaborComboBox.Location = New System.Drawing.Point(337, 66)
        Me.IdTipoLaborComboBox.Name = "IdTipoLaborComboBox"
        Me.IdTipoLaborComboBox.Size = New System.Drawing.Size(100, 21)
        Me.IdTipoLaborComboBox.TabIndex = 12
        Me.IdTipoLaborComboBox.ValueMember = "IdTipoLabor"
        '
        'LaborBindingSource
        '
        Me.LaborBindingSource.DataMember = "Labor"
        Me.LaborBindingSource.DataSource = Me.Ds
        '
        'Ds
        '
        Me.Ds.DataSetName = "ds"
        Me.Ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdOrientacionComboBox
        '
        Me.IdOrientacionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LaborBindingSource, "IdOrientacion", True))
        Me.IdOrientacionComboBox.DataSource = Me.OrientacionBindingSource
        Me.IdOrientacionComboBox.DisplayMember = "NombreOrientacion"
        Me.IdOrientacionComboBox.FormattingEnabled = True
        Me.IdOrientacionComboBox.Location = New System.Drawing.Point(579, 63)
        Me.IdOrientacionComboBox.Name = "IdOrientacionComboBox"
        Me.IdOrientacionComboBox.Size = New System.Drawing.Size(100, 21)
        Me.IdOrientacionComboBox.TabIndex = 11
        Me.IdOrientacionComboBox.ValueMember = "IdOrientacion"
        '
        'UTMTextBox
        '
        Me.UTMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaborBindingSource, "UTM", True))
        Me.UTMTextBox.Location = New System.Drawing.Point(579, 28)
        Me.UTMTextBox.Name = "UTMTextBox"
        Me.UTMTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UTMTextBox.TabIndex = 9
        '
        'IdVetaComboBox
        '
        Me.IdVetaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LaborBindingSource, "IdVeta", True))
        Me.IdVetaComboBox.DataSource = Me.VetaBindingSource
        Me.IdVetaComboBox.DisplayMember = "NombreVeta"
        Me.IdVetaComboBox.FormattingEnabled = True
        Me.IdVetaComboBox.Location = New System.Drawing.Point(337, 28)
        Me.IdVetaComboBox.Name = "IdVetaComboBox"
        Me.IdVetaComboBox.Size = New System.Drawing.Size(100, 21)
        Me.IdVetaComboBox.TabIndex = 5
        Me.IdVetaComboBox.ValueMember = "IdVeta"
        '
        'IdNivelComboBox
        '
        Me.IdNivelComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LaborBindingSource, "IdNivel", True))
        Me.IdNivelComboBox.DataSource = Me.NivelBindingSource
        Me.IdNivelComboBox.DisplayMember = "NombreNivel"
        Me.IdNivelComboBox.FormattingEnabled = True
        Me.IdNivelComboBox.Location = New System.Drawing.Point(88, 66)
        Me.IdNivelComboBox.Name = "IdNivelComboBox"
        Me.IdNivelComboBox.Size = New System.Drawing.Size(88, 21)
        Me.IdNivelComboBox.TabIndex = 3
        Me.IdNivelComboBox.ValueMember = "IdNivel"
        '
        'IdLaborTextBox
        '
        Me.IdLaborTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaborBindingSource, "IdLabor", True))
        Me.IdLaborTextBox.Location = New System.Drawing.Point(88, 28)
        Me.IdLaborTextBox.Name = "IdLaborTextBox"
        Me.IdLaborTextBox.Size = New System.Drawing.Size(88, 20)
        Me.IdLaborTextBox.TabIndex = 1
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
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'LaborTableAdapter
        '
        Me.LaborTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LaborTableAdapter = Me.LaborTableAdapter
        Me.TableAdapterManager.NivelTableAdapter = Nothing
        Me.TableAdapterManager.OrientacionTableAdapter = Nothing
        Me.TableAdapterManager.TipoLaborTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CrudWizard.dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VetaTableAdapter = Nothing
        '
        'NivelBindingSource
        '
        Me.NivelBindingSource.DataMember = "Nivel"
        Me.NivelBindingSource.DataSource = Me.Ds
        '
        'NivelTableAdapter
        '
        Me.NivelTableAdapter.ClearBeforeFill = True
        '
        'VetaBindingSource
        '
        Me.VetaBindingSource.DataMember = "Veta"
        Me.VetaBindingSource.DataSource = Me.Ds
        '
        'VetaTableAdapter
        '
        Me.VetaTableAdapter.ClearBeforeFill = True
        '
        'TipoLaborBindingSource
        '
        Me.TipoLaborBindingSource.DataMember = "TipoLabor"
        Me.TipoLaborBindingSource.DataSource = Me.Ds
        '
        'TipoLaborTableAdapter
        '
        Me.TipoLaborTableAdapter.ClearBeforeFill = True
        '
        'OrientacionBindingSource
        '
        Me.OrientacionBindingSource.DataMember = "Orientacion"
        Me.OrientacionBindingSource.DataSource = Me.Ds
        '
        'OrientacionTableAdapter
        '
        Me.OrientacionTableAdapter.ClearBeforeFill = True
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
        Me.IdNivelDataGridViewTextBoxColumn.DataSource = Me.NivelBindingSource
        Me.IdNivelDataGridViewTextBoxColumn.DisplayMember = "NombreNivel"
        Me.IdNivelDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.IdNivelDataGridViewTextBoxColumn.HeaderText = "IdNivel"
        Me.IdNivelDataGridViewTextBoxColumn.Name = "IdNivelDataGridViewTextBoxColumn"
        Me.IdNivelDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdNivelDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdNivelDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IdNivelDataGridViewTextBoxColumn.ValueMember = "IdNivel"
        '
        'IdVetaDataGridViewTextBoxColumn
        '
        Me.IdVetaDataGridViewTextBoxColumn.DataPropertyName = "IdVeta"
        Me.IdVetaDataGridViewTextBoxColumn.DataSource = Me.VetaBindingSource
        Me.IdVetaDataGridViewTextBoxColumn.DisplayMember = "NombreVeta"
        Me.IdVetaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.IdVetaDataGridViewTextBoxColumn.HeaderText = "IdVeta"
        Me.IdVetaDataGridViewTextBoxColumn.Name = "IdVetaDataGridViewTextBoxColumn"
        Me.IdVetaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdVetaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdVetaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IdVetaDataGridViewTextBoxColumn.ValueMember = "IdVeta"
        '
        'IdTipoLaborDataGridViewTextBoxColumn
        '
        Me.IdTipoLaborDataGridViewTextBoxColumn.DataPropertyName = "IdTipoLabor"
        Me.IdTipoLaborDataGridViewTextBoxColumn.DataSource = Me.TipoLaborBindingSource
        Me.IdTipoLaborDataGridViewTextBoxColumn.DisplayMember = "NombreTipoLabor"
        Me.IdTipoLaborDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.IdTipoLaborDataGridViewTextBoxColumn.HeaderText = "IdTipoLabor"
        Me.IdTipoLaborDataGridViewTextBoxColumn.Name = "IdTipoLaborDataGridViewTextBoxColumn"
        Me.IdTipoLaborDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdTipoLaborDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdTipoLaborDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IdTipoLaborDataGridViewTextBoxColumn.ValueMember = "IdTipoLabor"
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
        Me.IdOrientacionDataGridViewTextBoxColumn.DataSource = Me.OrientacionBindingSource
        Me.IdOrientacionDataGridViewTextBoxColumn.DisplayMember = "NombreOrientacion"
        Me.IdOrientacionDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.IdOrientacionDataGridViewTextBoxColumn.HeaderText = "IdOrientacion"
        Me.IdOrientacionDataGridViewTextBoxColumn.Name = "IdOrientacionDataGridViewTextBoxColumn"
        Me.IdOrientacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdOrientacionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdOrientacionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IdOrientacionDataGridViewTextBoxColumn.ValueMember = "IdOrientacion"
        '
        'FrmLabor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(739, 450)
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
        CType(Me.LaborBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaborDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NivelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VetaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoLaborBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrientacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents Ds As ds
    Friend WithEvents LaborBindingSource As BindingSource
    Friend WithEvents LaborTableAdapter As dsTableAdapters.LaborTableAdapter
    Friend WithEvents IdTipoLaborComboBox As ComboBox
    Friend WithEvents IdOrientacionComboBox As ComboBox
    Friend WithEvents UTMTextBox As TextBox
    Friend WithEvents IdVetaComboBox As ComboBox
    Friend WithEvents IdNivelComboBox As ComboBox
    Friend WithEvents IdLaborTextBox As TextBox
    Friend WithEvents TableAdapterManager As dsTableAdapters.TableAdapterManager
    Friend WithEvents NivelBindingSource As BindingSource
    Friend WithEvents NivelTableAdapter As dsTableAdapters.NivelTableAdapter
    Friend WithEvents VetaBindingSource As BindingSource
    Friend WithEvents VetaTableAdapter As dsTableAdapters.VetaTableAdapter
    Friend WithEvents TipoLaborBindingSource As BindingSource
    Friend WithEvents TipoLaborTableAdapter As dsTableAdapters.TipoLaborTableAdapter
    Friend WithEvents OrientacionBindingSource As BindingSource
    Friend WithEvents OrientacionTableAdapter As dsTableAdapters.OrientacionTableAdapter
    Friend WithEvents IdLaborDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdNivelDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents IdVetaDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents IdTipoLaborDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents UTMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdOrientacionDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
End Class
