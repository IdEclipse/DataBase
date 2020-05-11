<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFiltroLabor
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
        Me.NivelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds = New CrudWizard.ds()
        Me.VetaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoLaborBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrientacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LaborBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LaborTableAdapter = New CrudWizard.dsTableAdapters.LaborTableAdapter()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.VetaTableAdapter = New CrudWizard.dsTableAdapters.VetaTableAdapter()
        Me.TipoLaborTableAdapter = New CrudWizard.dsTableAdapters.TipoLaborTableAdapter()
        Me.OrientacionTableAdapter = New CrudWizard.dsTableAdapters.OrientacionTableAdapter()
        Me.NivelTableAdapter = New CrudWizard.dsTableAdapters.NivelTableAdapter()
        Me.LaborDataGridView = New Zuby.ADGV.AdvancedDataGridView()
        Me.IdLaborDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdNivelDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.IdVetaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.IdTipoLaborDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.UTMDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdOrientacionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.lblMantenimientoVetas = New System.Windows.Forms.Label()
        CType(Me.NivelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VetaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoLaborBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrientacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaborBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaborDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NivelBindingSource
        '
        Me.NivelBindingSource.DataMember = "Nivel"
        Me.NivelBindingSource.DataSource = Me.Ds
        '
        'Ds
        '
        Me.Ds.DataSetName = "ds"
        Me.Ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VetaBindingSource
        '
        Me.VetaBindingSource.DataMember = "Veta"
        Me.VetaBindingSource.DataSource = Me.Ds
        '
        'TipoLaborBindingSource
        '
        Me.TipoLaborBindingSource.DataMember = "TipoLabor"
        Me.TipoLaborBindingSource.DataSource = Me.Ds
        '
        'OrientacionBindingSource
        '
        Me.OrientacionBindingSource.DataMember = "Orientacion"
        Me.OrientacionBindingSource.DataSource = Me.Ds
        '
        'LaborBindingSource
        '
        Me.LaborBindingSource.DataMember = "Labor"
        Me.LaborBindingSource.DataSource = Me.Ds
        '
        'LaborTableAdapter
        '
        Me.LaborTableAdapter.ClearBeforeFill = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(480, 335)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(87, 32)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(583, 335)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(87, 32)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'VetaTableAdapter
        '
        Me.VetaTableAdapter.ClearBeforeFill = True
        '
        'TipoLaborTableAdapter
        '
        Me.TipoLaborTableAdapter.ClearBeforeFill = True
        '
        'OrientacionTableAdapter
        '
        Me.OrientacionTableAdapter.ClearBeforeFill = True
        '
        'NivelTableAdapter
        '
        Me.NivelTableAdapter.ClearBeforeFill = True
        '
        'LaborDataGridView
        '
        Me.LaborDataGridView.AllowUserToAddRows = False
        Me.LaborDataGridView.AllowUserToDeleteRows = False
        Me.LaborDataGridView.AutoGenerateColumns = False
        Me.LaborDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LaborDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdLaborDataGridViewTextBoxColumn1, Me.IdNivelDataGridViewTextBoxColumn1, Me.IdVetaDataGridViewTextBoxColumn1, Me.IdTipoLaborDataGridViewTextBoxColumn1, Me.UTMDataGridViewTextBoxColumn1, Me.IdOrientacionDataGridViewTextBoxColumn1})
        Me.LaborDataGridView.DataSource = Me.LaborBindingSource
        Me.LaborDataGridView.FilterAndSortEnabled = True
        Me.LaborDataGridView.Location = New System.Drawing.Point(7, 43)
        Me.LaborDataGridView.MultiSelect = False
        Me.LaborDataGridView.Name = "LaborDataGridView"
        Me.LaborDataGridView.ReadOnly = True
        Me.LaborDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LaborDataGridView.Size = New System.Drawing.Size(663, 286)
        Me.LaborDataGridView.TabIndex = 4
        '
        'IdLaborDataGridViewTextBoxColumn1
        '
        Me.IdLaborDataGridViewTextBoxColumn1.DataPropertyName = "IdLabor"
        Me.IdLaborDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IdLaborDataGridViewTextBoxColumn1.MinimumWidth = 22
        Me.IdLaborDataGridViewTextBoxColumn1.Name = "IdLaborDataGridViewTextBoxColumn1"
        Me.IdLaborDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdLaborDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'IdNivelDataGridViewTextBoxColumn1
        '
        Me.IdNivelDataGridViewTextBoxColumn1.DataPropertyName = "IdNivel"
        Me.IdNivelDataGridViewTextBoxColumn1.DataSource = Me.NivelBindingSource
        Me.IdNivelDataGridViewTextBoxColumn1.DisplayMember = "NombreNivel"
        Me.IdNivelDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.IdNivelDataGridViewTextBoxColumn1.HeaderText = "Nivel"
        Me.IdNivelDataGridViewTextBoxColumn1.MinimumWidth = 22
        Me.IdNivelDataGridViewTextBoxColumn1.Name = "IdNivelDataGridViewTextBoxColumn1"
        Me.IdNivelDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdNivelDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdNivelDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.IdNivelDataGridViewTextBoxColumn1.ValueMember = "IdNivel"
        '
        'IdVetaDataGridViewTextBoxColumn1
        '
        Me.IdVetaDataGridViewTextBoxColumn1.DataPropertyName = "IdVeta"
        Me.IdVetaDataGridViewTextBoxColumn1.DataSource = Me.VetaBindingSource
        Me.IdVetaDataGridViewTextBoxColumn1.DisplayMember = "NombreVeta"
        Me.IdVetaDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.IdVetaDataGridViewTextBoxColumn1.HeaderText = "Veta"
        Me.IdVetaDataGridViewTextBoxColumn1.MinimumWidth = 22
        Me.IdVetaDataGridViewTextBoxColumn1.Name = "IdVetaDataGridViewTextBoxColumn1"
        Me.IdVetaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdVetaDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdVetaDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.IdVetaDataGridViewTextBoxColumn1.ValueMember = "IdVeta"
        '
        'IdTipoLaborDataGridViewTextBoxColumn1
        '
        Me.IdTipoLaborDataGridViewTextBoxColumn1.DataPropertyName = "IdTipoLabor"
        Me.IdTipoLaborDataGridViewTextBoxColumn1.DataSource = Me.TipoLaborBindingSource
        Me.IdTipoLaborDataGridViewTextBoxColumn1.DisplayMember = "NombreTipoLabor"
        Me.IdTipoLaborDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.IdTipoLaborDataGridViewTextBoxColumn1.HeaderText = "Tipo Labor"
        Me.IdTipoLaborDataGridViewTextBoxColumn1.MinimumWidth = 22
        Me.IdTipoLaborDataGridViewTextBoxColumn1.Name = "IdTipoLaborDataGridViewTextBoxColumn1"
        Me.IdTipoLaborDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdTipoLaborDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdTipoLaborDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.IdTipoLaborDataGridViewTextBoxColumn1.ValueMember = "IdTipoLabor"
        '
        'UTMDataGridViewTextBoxColumn1
        '
        Me.UTMDataGridViewTextBoxColumn1.DataPropertyName = "UTM"
        Me.UTMDataGridViewTextBoxColumn1.HeaderText = "UTM"
        Me.UTMDataGridViewTextBoxColumn1.MinimumWidth = 22
        Me.UTMDataGridViewTextBoxColumn1.Name = "UTMDataGridViewTextBoxColumn1"
        Me.UTMDataGridViewTextBoxColumn1.ReadOnly = True
        Me.UTMDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'IdOrientacionDataGridViewTextBoxColumn1
        '
        Me.IdOrientacionDataGridViewTextBoxColumn1.DataPropertyName = "IdOrientacion"
        Me.IdOrientacionDataGridViewTextBoxColumn1.DataSource = Me.OrientacionBindingSource
        Me.IdOrientacionDataGridViewTextBoxColumn1.DisplayMember = "NombreOrientacion"
        Me.IdOrientacionDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.IdOrientacionDataGridViewTextBoxColumn1.HeaderText = "Orientacion"
        Me.IdOrientacionDataGridViewTextBoxColumn1.MinimumWidth = 22
        Me.IdOrientacionDataGridViewTextBoxColumn1.Name = "IdOrientacionDataGridViewTextBoxColumn1"
        Me.IdOrientacionDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdOrientacionDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdOrientacionDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.IdOrientacionDataGridViewTextBoxColumn1.ValueMember = "IdOrientacion"
        '
        'lblMantenimientoVetas
        '
        Me.lblMantenimientoVetas.AutoSize = True
        Me.lblMantenimientoVetas.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMantenimientoVetas.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblMantenimientoVetas.Location = New System.Drawing.Point(7, 9)
        Me.lblMantenimientoVetas.Name = "lblMantenimientoVetas"
        Me.lblMantenimientoVetas.Size = New System.Drawing.Size(177, 19)
        Me.lblMantenimientoVetas.TabIndex = 5
        Me.lblMantenimientoVetas.Text = "FILTRO DE LABORES"
        '
        'FrmFiltroLabor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(677, 374)
        Me.Controls.Add(Me.lblMantenimientoVetas)
        Me.Controls.Add(Me.LaborDataGridView)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "FrmFiltroLabor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtro de Labor"
        CType(Me.NivelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VetaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoLaborBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrientacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaborBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaborDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ds As ds
    Friend WithEvents LaborBindingSource As BindingSource
    Friend WithEvents LaborTableAdapter As dsTableAdapters.LaborTableAdapter
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents VetaBindingSource As BindingSource
    Friend WithEvents VetaTableAdapter As dsTableAdapters.VetaTableAdapter
    Friend WithEvents TipoLaborBindingSource As BindingSource
    Friend WithEvents TipoLaborTableAdapter As dsTableAdapters.TipoLaborTableAdapter
    Friend WithEvents OrientacionBindingSource As BindingSource
    Friend WithEvents OrientacionTableAdapter As dsTableAdapters.OrientacionTableAdapter
    Friend WithEvents NivelBindingSource As BindingSource
    Friend WithEvents NivelTableAdapter As dsTableAdapters.NivelTableAdapter
    Friend WithEvents LaborDataGridView As Zuby.ADGV.AdvancedDataGridView
    Friend WithEvents lblMantenimientoVetas As Label
    Friend WithEvents IdLaborDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdNivelDataGridViewTextBoxColumn1 As DataGridViewComboBoxColumn
    Friend WithEvents IdVetaDataGridViewTextBoxColumn1 As DataGridViewComboBoxColumn
    Friend WithEvents IdTipoLaborDataGridViewTextBoxColumn1 As DataGridViewComboBoxColumn
    Friend WithEvents UTMDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdOrientacionDataGridViewTextBoxColumn1 As DataGridViewComboBoxColumn
End Class
