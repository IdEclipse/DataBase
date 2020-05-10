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
        Me.LaborDataGridView = New System.Windows.Forms.DataGridView()
        Me.Ds = New CrudWizard.ds()
        Me.VetaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoLaborBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrientacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LaborBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LaborTableAdapter = New CrudWizard.dsTableAdapters.LaborTableAdapter()
        Me.FillBy1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.UTMToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.UTMToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.VetaTableAdapter = New CrudWizard.dsTableAdapters.VetaTableAdapter()
        Me.TipoLaborTableAdapter = New CrudWizard.dsTableAdapters.TipoLaborTableAdapter()
        Me.OrientacionTableAdapter = New CrudWizard.dsTableAdapters.OrientacionTableAdapter()
        Me.NivelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NivelTableAdapter = New CrudWizard.dsTableAdapters.NivelTableAdapter()
        Me.IdLaborDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdNivelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.IdVetaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.IdTipoLaborDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.UTMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdOrientacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.LaborDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VetaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoLaborBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrientacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaborBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy1ToolStrip.SuspendLayout()
        CType(Me.NivelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LaborDataGridView
        '
        Me.LaborDataGridView.AllowUserToAddRows = False
        Me.LaborDataGridView.AllowUserToDeleteRows = False
        Me.LaborDataGridView.AutoGenerateColumns = False
        Me.LaborDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LaborDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdLaborDataGridViewTextBoxColumn, Me.IdNivelDataGridViewTextBoxColumn, Me.IdVetaDataGridViewTextBoxColumn, Me.IdTipoLaborDataGridViewTextBoxColumn, Me.UTMDataGridViewTextBoxColumn, Me.IdOrientacionDataGridViewTextBoxColumn})
        Me.LaborDataGridView.DataSource = Me.LaborBindingSource
        Me.LaborDataGridView.Location = New System.Drawing.Point(12, 54)
        Me.LaborDataGridView.MultiSelect = False
        Me.LaborDataGridView.Name = "LaborDataGridView"
        Me.LaborDataGridView.ReadOnly = True
        Me.LaborDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LaborDataGridView.Size = New System.Drawing.Size(655, 290)
        Me.LaborDataGridView.TabIndex = 1
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
        'FillBy1ToolStrip
        '
        Me.FillBy1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UTMToolStripLabel, Me.UTMToolStripTextBox, Me.FillBy1ToolStripButton})
        Me.FillBy1ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBy1ToolStrip.Name = "FillBy1ToolStrip"
        Me.FillBy1ToolStrip.Size = New System.Drawing.Size(667, 39)
        Me.FillBy1ToolStrip.TabIndex = 0
        Me.FillBy1ToolStrip.Text = "FillBy1ToolStrip"
        '
        'UTMToolStripLabel
        '
        Me.UTMToolStripLabel.Name = "UTMToolStripLabel"
        Me.UTMToolStripLabel.Size = New System.Drawing.Size(35, 36)
        Me.UTMToolStripLabel.Text = "UTM:"
        '
        'UTMToolStripTextBox
        '
        Me.UTMToolStripTextBox.Name = "UTMToolStripTextBox"
        Me.UTMToolStripTextBox.Size = New System.Drawing.Size(100, 39)
        Me.UTMToolStripTextBox.Text = "UTM"
        '
        'FillBy1ToolStripButton
        '
        Me.FillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FillBy1ToolStripButton.Image = Global.CrudWizard.My.Resources.Resources.buscar
        Me.FillBy1ToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FillBy1ToolStripButton.Name = "FillBy1ToolStripButton"
        Me.FillBy1ToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.FillBy1ToolStripButton.Text = "FillBy1"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(499, 12)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 27)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(580, 12)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 27)
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
        'NivelBindingSource
        '
        Me.NivelBindingSource.DataMember = "Nivel"
        Me.NivelBindingSource.DataSource = Me.Ds
        '
        'NivelTableAdapter
        '
        Me.NivelTableAdapter.ClearBeforeFill = True
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
        'FrmFiltroLabor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 356)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.FillBy1ToolStrip)
        Me.Controls.Add(Me.LaborDataGridView)
        Me.Name = "FrmFiltroLabor"
        Me.Text = "Filtro de Labor"
        CType(Me.LaborDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VetaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoLaborBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrientacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaborBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy1ToolStrip.ResumeLayout(False)
        Me.FillBy1ToolStrip.PerformLayout()
        CType(Me.NivelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LaborDataGridView As DataGridView
    Friend WithEvents Ds As ds
    Friend WithEvents LaborBindingSource As BindingSource
    Friend WithEvents LaborTableAdapter As dsTableAdapters.LaborTableAdapter
    Friend WithEvents FillBy1ToolStrip As ToolStrip
    Friend WithEvents UTMToolStripLabel As ToolStripLabel
    Friend WithEvents UTMToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillBy1ToolStripButton As ToolStripButton
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
    Friend WithEvents IdLaborDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdNivelDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents IdVetaDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents IdTipoLaborDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents UTMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdOrientacionDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
End Class
