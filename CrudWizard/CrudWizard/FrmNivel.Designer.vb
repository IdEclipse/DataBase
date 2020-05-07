<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNivel
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdVetaLabel As System.Windows.Forms.Label
        Dim NombreVetaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNivel))
        Me.lblMantenimientoVetas = New System.Windows.Forms.Label()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBoxDetalleVeta = New System.Windows.Forms.GroupBox()
        Me.NombreNivelTextBox = New System.Windows.Forms.TextBox()
        Me.NivelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMina = New CrudWizard.dsMina()
        Me.IdNivelTextBox = New System.Windows.Forms.TextBox()
        Me.NivelDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdNivelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreNivelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NivelTableAdapter = New CrudWizard.dsMinaTableAdapters.NivelTableAdapter()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        IdVetaLabel = New System.Windows.Forms.Label()
        NombreVetaLabel = New System.Windows.Forms.Label()
        Me.GroupBoxDetalleVeta.SuspendLayout()
        CType(Me.NivelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NivelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdVetaLabel
        '
        IdVetaLabel.AutoSize = True
        IdVetaLabel.Location = New System.Drawing.Point(18, 26)
        IdVetaLabel.Name = "IdVetaLabel"
        IdVetaLabel.Size = New System.Drawing.Size(46, 13)
        IdVetaLabel.TabIndex = 0
        IdVetaLabel.Text = "Id Nivel:"
        '
        'NombreVetaLabel
        '
        NombreVetaLabel.AutoSize = True
        NombreVetaLabel.Location = New System.Drawing.Point(18, 52)
        NombreVetaLabel.Name = "NombreVetaLabel"
        NombreVetaLabel.Size = New System.Drawing.Size(74, 13)
        NombreVetaLabel.TabIndex = 2
        NombreVetaLabel.Text = "Nombre Nivel:"
        '
        'lblMantenimientoVetas
        '
        Me.lblMantenimientoVetas.AutoSize = True
        Me.lblMantenimientoVetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMantenimientoVetas.Location = New System.Drawing.Point(12, 25)
        Me.lblMantenimientoVetas.Name = "lblMantenimientoVetas"
        Me.lblMantenimientoVetas.Size = New System.Drawing.Size(151, 20)
        Me.lblMantenimientoVetas.TabIndex = 0
        Me.lblMantenimientoVetas.Text = "Mantenimiento Nivel"
        '
        'btnGrabar
        '
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrabar.Location = New System.Drawing.Point(425, 382)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(92, 44)
        Me.btnGrabar.TabIndex = 7
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(325, 382)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(92, 44)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(212, 382)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(92, 44)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(112, 382)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(92, 44)
        Me.btnEditar.TabIndex = 4
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(12, 382)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(92, 44)
        Me.btnNuevo.TabIndex = 3
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Location = New System.Drawing.Point(662, 382)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(126, 44)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBoxDetalleVeta
        '
        Me.GroupBoxDetalleVeta.Controls.Add(IdVetaLabel)
        Me.GroupBoxDetalleVeta.Controls.Add(Me.NombreNivelTextBox)
        Me.GroupBoxDetalleVeta.Controls.Add(Me.IdNivelTextBox)
        Me.GroupBoxDetalleVeta.Controls.Add(NombreVetaLabel)
        Me.GroupBoxDetalleVeta.Location = New System.Drawing.Point(12, 288)
        Me.GroupBoxDetalleVeta.Name = "GroupBoxDetalleVeta"
        Me.GroupBoxDetalleVeta.Size = New System.Drawing.Size(776, 88)
        Me.GroupBoxDetalleVeta.TabIndex = 2
        Me.GroupBoxDetalleVeta.TabStop = False
        Me.GroupBoxDetalleVeta.Text = "DetalleVeta"
        '
        'NombreNivelTextBox
        '
        Me.NombreNivelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NivelBindingSource, "NombreNivel", True))
        Me.NombreNivelTextBox.Enabled = False
        Me.NombreNivelTextBox.Location = New System.Drawing.Point(96, 49)
        Me.NombreNivelTextBox.Name = "NombreNivelTextBox"
        Me.NombreNivelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreNivelTextBox.TabIndex = 3
        '
        'NivelBindingSource
        '
        Me.NivelBindingSource.DataMember = "Nivel"
        Me.NivelBindingSource.DataSource = Me.DsMina
        '
        'DsMina
        '
        Me.DsMina.DataSetName = "dsMina"
        Me.DsMina.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdNivelTextBox
        '
        Me.IdNivelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NivelBindingSource, "IdNivel", True))
        Me.IdNivelTextBox.Enabled = False
        Me.IdNivelTextBox.Location = New System.Drawing.Point(96, 23)
        Me.IdNivelTextBox.Name = "IdNivelTextBox"
        Me.IdNivelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdNivelTextBox.TabIndex = 1
        '
        'NivelDataGridView
        '
        Me.NivelDataGridView.AllowUserToAddRows = False
        Me.NivelDataGridView.AllowUserToDeleteRows = False
        Me.NivelDataGridView.AutoGenerateColumns = False
        Me.NivelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NivelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdNivelDataGridViewTextBoxColumn, Me.NombreNivelDataGridViewTextBoxColumn})
        Me.NivelDataGridView.DataSource = Me.NivelBindingSource
        Me.NivelDataGridView.Location = New System.Drawing.Point(12, 62)
        Me.NivelDataGridView.MultiSelect = False
        Me.NivelDataGridView.Name = "NivelDataGridView"
        Me.NivelDataGridView.ReadOnly = True
        Me.NivelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.NivelDataGridView.Size = New System.Drawing.Size(776, 220)
        Me.NivelDataGridView.TabIndex = 1
        '
        'IdNivelDataGridViewTextBoxColumn
        '
        Me.IdNivelDataGridViewTextBoxColumn.DataPropertyName = "IdNivel"
        Me.IdNivelDataGridViewTextBoxColumn.HeaderText = "IdNivel"
        Me.IdNivelDataGridViewTextBoxColumn.Name = "IdNivelDataGridViewTextBoxColumn"
        Me.IdNivelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreNivelDataGridViewTextBoxColumn
        '
        Me.NombreNivelDataGridViewTextBoxColumn.DataPropertyName = "NombreNivel"
        Me.NombreNivelDataGridViewTextBoxColumn.HeaderText = "NombreNivel"
        Me.NombreNivelDataGridViewTextBoxColumn.Name = "NombreNivelDataGridViewTextBoxColumn"
        Me.NombreNivelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NivelTableAdapter
        '
        Me.NivelTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'FrmNivel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 434)
        Me.Controls.Add(Me.lblMantenimientoVetas)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBoxDetalleVeta)
        Me.Controls.Add(Me.NivelDataGridView)
        Me.Name = "FrmNivel"
        Me.Text = "Mantenimiento Nivel"
        Me.GroupBoxDetalleVeta.ResumeLayout(False)
        Me.GroupBoxDetalleVeta.PerformLayout()
        CType(Me.NivelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NivelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents NombreNivelTextBox As TextBox
    Friend WithEvents IdNivelTextBox As TextBox
    Friend WithEvents NivelDataGridView As DataGridView
    Friend WithEvents DsMina As dsMina
    Friend WithEvents NivelBindingSource As BindingSource
    Friend WithEvents NivelTableAdapter As dsMinaTableAdapters.NivelTableAdapter
    Friend WithEvents IdNivelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreNivelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider As ErrorProvider
End Class
