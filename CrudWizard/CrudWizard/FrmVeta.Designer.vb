<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVeta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVeta))
        Me.VetaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VetaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ds = New CrudWizard.ds()
        Me.IdVetaTextBox = New System.Windows.Forms.TextBox()
        Me.NombreVetaTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBoxDetalleVeta = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.lblMantenimientoVetas = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.VetaTableAdapter = New CrudWizard.dsTableAdapters.VetaTableAdapter()
        Me.TableAdapterManager = New CrudWizard.dsTableAdapters.TableAdapterManager()
        IdVetaLabel = New System.Windows.Forms.Label()
        NombreVetaLabel = New System.Windows.Forms.Label()
        CType(Me.VetaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VetaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDetalleVeta.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdVetaLabel
        '
        IdVetaLabel.AutoSize = True
        IdVetaLabel.Location = New System.Drawing.Point(18, 26)
        IdVetaLabel.Name = "IdVetaLabel"
        IdVetaLabel.Size = New System.Drawing.Size(44, 13)
        IdVetaLabel.TabIndex = 0
        IdVetaLabel.Text = "Id Veta:"
        '
        'NombreVetaLabel
        '
        NombreVetaLabel.AutoSize = True
        NombreVetaLabel.Location = New System.Drawing.Point(18, 52)
        NombreVetaLabel.Name = "NombreVetaLabel"
        NombreVetaLabel.Size = New System.Drawing.Size(72, 13)
        NombreVetaLabel.TabIndex = 2
        NombreVetaLabel.Text = "Nombre Veta:"
        '
        'VetaDataGridView
        '
        Me.VetaDataGridView.AllowUserToAddRows = False
        Me.VetaDataGridView.AllowUserToDeleteRows = False
        Me.VetaDataGridView.AutoGenerateColumns = False
        Me.VetaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VetaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.VetaDataGridView.DataSource = Me.VetaBindingSource
        Me.VetaDataGridView.Location = New System.Drawing.Point(12, 55)
        Me.VetaDataGridView.MultiSelect = False
        Me.VetaDataGridView.Name = "VetaDataGridView"
        Me.VetaDataGridView.ReadOnly = True
        Me.VetaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VetaDataGridView.Size = New System.Drawing.Size(776, 220)
        Me.VetaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdVeta"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdVeta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NombreVeta"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NombreVeta"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'VetaBindingSource
        '
        Me.VetaBindingSource.DataMember = "Veta"
        Me.VetaBindingSource.DataSource = Me.ds
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdVetaTextBox
        '
        Me.IdVetaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VetaBindingSource, "IdVeta", True))
        Me.IdVetaTextBox.Enabled = False
        Me.IdVetaTextBox.Location = New System.Drawing.Point(96, 23)
        Me.IdVetaTextBox.Name = "IdVetaTextBox"
        Me.IdVetaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdVetaTextBox.TabIndex = 1
        '
        'NombreVetaTextBox
        '
        Me.NombreVetaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VetaBindingSource, "NombreVeta", True))
        Me.NombreVetaTextBox.Enabled = False
        Me.NombreVetaTextBox.Location = New System.Drawing.Point(96, 49)
        Me.NombreVetaTextBox.Name = "NombreVetaTextBox"
        Me.NombreVetaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreVetaTextBox.TabIndex = 3
        '
        'GroupBoxDetalleVeta
        '
        Me.GroupBoxDetalleVeta.Controls.Add(IdVetaLabel)
        Me.GroupBoxDetalleVeta.Controls.Add(Me.NombreVetaTextBox)
        Me.GroupBoxDetalleVeta.Controls.Add(Me.IdVetaTextBox)
        Me.GroupBoxDetalleVeta.Controls.Add(NombreVetaLabel)
        Me.GroupBoxDetalleVeta.Location = New System.Drawing.Point(12, 281)
        Me.GroupBoxDetalleVeta.Name = "GroupBoxDetalleVeta"
        Me.GroupBoxDetalleVeta.Size = New System.Drawing.Size(776, 88)
        Me.GroupBoxDetalleVeta.TabIndex = 1
        Me.GroupBoxDetalleVeta.TabStop = False
        Me.GroupBoxDetalleVeta.Text = "DetalleVeta"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Location = New System.Drawing.Point(661, 375)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(126, 44)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(12, 375)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(92, 44)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(112, 375)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(92, 44)
        Me.btnEditar.TabIndex = 3
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(212, 375)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(92, 44)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(325, 375)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(92, 44)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrabar.Location = New System.Drawing.Point(425, 375)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(92, 44)
        Me.btnGrabar.TabIndex = 6
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'lblMantenimientoVetas
        '
        Me.lblMantenimientoVetas.AutoSize = True
        Me.lblMantenimientoVetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMantenimientoVetas.Location = New System.Drawing.Point(12, 18)
        Me.lblMantenimientoVetas.Name = "lblMantenimientoVetas"
        Me.lblMantenimientoVetas.Size = New System.Drawing.Size(160, 20)
        Me.lblMantenimientoVetas.TabIndex = 0
        Me.lblMantenimientoVetas.Text = "Mantenimiento Vetas"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'VetaTableAdapter
        '
        Me.VetaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        'Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        'Me.TableAdapterManager.DetalleProgramaTableAdapter = Nothing
        'Me.TableAdapterManager.EjecutorTableAdapter = Nothing
        'Me.TableAdapterManager.LaborTableAdapter = Nothing
        'Me.TableAdapterManager.NivelTableAdapter = Nothing
        'Me.TableAdapterManager.ProgramaTableAdapter = Nothing
        'Me.TableAdapterManager.UpdateOrder = CrudWizard.dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        'Me.TableAdapterManager.VetaTableAdapter = Me.VetaTableAdapter
        '
        'FrmVeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 424)
        Me.Controls.Add(Me.lblMantenimientoVetas)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBoxDetalleVeta)
        Me.Controls.Add(Me.VetaDataGridView)
        Me.Name = "FrmVeta"
        Me.Text = "Mantenimiento Veta"
        Me.TopMost = True
        CType(Me.VetaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VetaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDetalleVeta.ResumeLayout(False)
        Me.GroupBoxDetalleVeta.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ds As ds
    Friend WithEvents VetaBindingSource As BindingSource
    Friend WithEvents VetaTableAdapter As dsTableAdapters.VetaTableAdapter
    Friend WithEvents TableAdapterManager As dsTableAdapters.TableAdapterManager
    Friend WithEvents VetaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IdVetaTextBox As TextBox
    Friend WithEvents NombreVetaTextBox As TextBox
    Friend WithEvents GroupBoxDetalleVeta As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents lblMantenimientoVetas As Label
    Friend WithEvents ErrorProvider As ErrorProvider
End Class
