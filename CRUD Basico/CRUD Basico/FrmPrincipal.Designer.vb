<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim IdPKLabel As System.Windows.Forms.Label
        Dim IdNumberLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim MailLabel As System.Windows.Forms.Label
        Dim BirthdayLabel As System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdPKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyCompanyDataSet = New CRUD_Basico.MyCompanyDataSet()
        Me.EmployeeTableAdapter = New CRUD_Basico.MyCompanyDataSetTableAdapters.EmployeeTableAdapter()
        Me.TableAdapterManager = New CRUD_Basico.MyCompanyDataSetTableAdapters.TableAdapterManager()
        Me.IdPKTextBox = New System.Windows.Forms.TextBox()
        Me.IdNumberTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.MailTextBox = New System.Windows.Forms.TextBox()
        Me.BirthdayDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        IdPKLabel = New System.Windows.Forms.Label()
        IdNumberLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        MailLabel = New System.Windows.Forms.Label()
        BirthdayLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyCompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdPKLabel
        '
        IdPKLabel.AutoSize = True
        IdPKLabel.Location = New System.Drawing.Point(634, 27)
        IdPKLabel.Name = "IdPKLabel"
        IdPKLabel.Size = New System.Drawing.Size(36, 13)
        IdPKLabel.TabIndex = 1
        IdPKLabel.Text = "Id PK:"
        '
        'IdNumberLabel
        '
        IdNumberLabel.AutoSize = True
        IdNumberLabel.Location = New System.Drawing.Point(634, 53)
        IdNumberLabel.Name = "IdNumberLabel"
        IdNumberLabel.Size = New System.Drawing.Size(59, 13)
        IdNumberLabel.TabIndex = 3
        IdNumberLabel.Text = "Id Number:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(634, 79)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 5
        NameLabel.Text = "Name:"
        '
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Location = New System.Drawing.Point(634, 105)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(29, 13)
        MailLabel.TabIndex = 7
        MailLabel.Text = "Mail:"
        '
        'BirthdayLabel
        '
        BirthdayLabel.AutoSize = True
        BirthdayLabel.Location = New System.Drawing.Point(634, 132)
        BirthdayLabel.Name = "BirthdayLabel"
        BirthdayLabel.Size = New System.Drawing.Size(48, 13)
        BirthdayLabel.TabIndex = 9
        BirthdayLabel.Text = "Birthday:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPKDataGridViewTextBoxColumn, Me.IdNumberDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.MailDataGridViewTextBoxColumn, Me.BirthdayDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmployeeBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 27)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(583, 190)
        Me.DataGridView1.TabIndex = 0
        '
        'IdPKDataGridViewTextBoxColumn
        '
        Me.IdPKDataGridViewTextBoxColumn.DataPropertyName = "IdPK"
        Me.IdPKDataGridViewTextBoxColumn.HeaderText = "IdPK"
        Me.IdPKDataGridViewTextBoxColumn.Name = "IdPKDataGridViewTextBoxColumn"
        Me.IdPKDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPKDataGridViewTextBoxColumn.Width = 50
        '
        'IdNumberDataGridViewTextBoxColumn
        '
        Me.IdNumberDataGridViewTextBoxColumn.DataPropertyName = "IdNumber"
        Me.IdNumberDataGridViewTextBoxColumn.HeaderText = "IdNumber"
        Me.IdNumberDataGridViewTextBoxColumn.Name = "IdNumberDataGridViewTextBoxColumn"
        Me.IdNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MailDataGridViewTextBoxColumn
        '
        Me.MailDataGridViewTextBoxColumn.DataPropertyName = "Mail"
        Me.MailDataGridViewTextBoxColumn.HeaderText = "Mail"
        Me.MailDataGridViewTextBoxColumn.Name = "MailDataGridViewTextBoxColumn"
        Me.MailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BirthdayDataGridViewTextBoxColumn
        '
        Me.BirthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday"
        Me.BirthdayDataGridViewTextBoxColumn.HeaderText = "Birthday"
        Me.BirthdayDataGridViewTextBoxColumn.Name = "BirthdayDataGridViewTextBoxColumn"
        Me.BirthdayDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.MyCompanyDataSet
        '
        'MyCompanyDataSet
        '
        Me.MyCompanyDataSet.DataSetName = "MyCompanyDataSet"
        Me.MyCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.UpdateOrder = CRUD_Basico.MyCompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdPKTextBox
        '
        Me.IdPKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "IdPK", True))
        Me.IdPKTextBox.Location = New System.Drawing.Point(699, 24)
        Me.IdPKTextBox.Name = "IdPKTextBox"
        Me.IdPKTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdPKTextBox.TabIndex = 2
        '
        'IdNumberTextBox
        '
        Me.IdNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "IdNumber", True))
        Me.IdNumberTextBox.Location = New System.Drawing.Point(699, 50)
        Me.IdNumberTextBox.Name = "IdNumberTextBox"
        Me.IdNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdNumberTextBox.TabIndex = 4
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(699, 76)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NameTextBox.TabIndex = 6
        '
        'MailTextBox
        '
        Me.MailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Mail", True))
        Me.MailTextBox.Location = New System.Drawing.Point(699, 102)
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MailTextBox.TabIndex = 8
        '
        'BirthdayDateTimePicker
        '
        Me.BirthdayDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeBindingSource, "Birthday", True))
        Me.BirthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BirthdayDateTimePicker.Location = New System.Drawing.Point(699, 128)
        Me.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker"
        Me.BirthdayDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.BirthdayDateTimePicker.TabIndex = 10
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Location = New System.Drawing.Point(22, 274)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(148, 36)
        Me.BtnInsertar.TabIndex = 11
        Me.BtnInsertar.Text = "Insertar"
        Me.BtnInsertar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Location = New System.Drawing.Point(188, 274)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(148, 36)
        Me.BtnBorrar.TabIndex = 11
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 419)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(IdPKLabel)
        Me.Controls.Add(Me.IdPKTextBox)
        Me.Controls.Add(IdNumberLabel)
        Me.Controls.Add(Me.IdNumberTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(MailLabel)
        Me.Controls.Add(Me.MailTextBox)
        Me.Controls.Add(BirthdayLabel)
        Me.Controls.Add(Me.BirthdayDateTimePicker)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmPrincipal"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyCompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MyCompanyDataSet As MyCompanyDataSet
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As MyCompanyDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents IdPKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BirthdayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As MyCompanyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdPKTextBox As TextBox
    Friend WithEvents IdNumberTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents MailTextBox As TextBox
    Friend WithEvents BirthdayDateTimePicker As DateTimePicker
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents BtnBorrar As Button
End Class
