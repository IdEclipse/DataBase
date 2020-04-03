<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCliente
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
        Dim IdClienteLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim DNILabel As System.Windows.Forms.Label
        Me.DgvListado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdClienteTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.DNITextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.LnkMensaje = New System.Windows.Forms.LinkLabel()
        Me.CboCampo = New System.Windows.Forms.ComboBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        IdClienteLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        DNILabel = New System.Windows.Forms.Label()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdClienteLabel
        '
        IdClienteLabel.AutoSize = True
        IdClienteLabel.Location = New System.Drawing.Point(20, 25)
        IdClienteLabel.Name = "IdClienteLabel"
        IdClienteLabel.Size = New System.Drawing.Size(54, 13)
        IdClienteLabel.TabIndex = 2
        IdClienteLabel.Text = "Id Cliente:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(20, 51)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "Nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(20, 77)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(47, 13)
        ApellidoLabel.TabIndex = 6
        ApellidoLabel.Text = "Apellido:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(20, 103)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 8
        DireccionLabel.Text = "Direccion:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(20, 129)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 10
        TelefonoLabel.Text = "Telefono:"
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Location = New System.Drawing.Point(20, 155)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(29, 13)
        DNILabel.TabIndex = 12
        DNILabel.Text = "DNI:"
        '
        'DgvListado
        '
        Me.DgvListado.AllowUserToAddRows = False
        Me.DgvListado.AllowUserToDeleteRows = False
        Me.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.DgvListado.Location = New System.Drawing.Point(13, 50)
        Me.DgvListado.MultiSelect = False
        Me.DgvListado.Name = "DgvListado"
        Me.DgvListado.ReadOnly = True
        Me.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListado.Size = New System.Drawing.Size(549, 147)
        Me.DgvListado.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'IdClienteTextBox
        '
        Me.IdClienteTextBox.Enabled = False
        Me.IdClienteTextBox.Location = New System.Drawing.Point(81, 22)
        Me.IdClienteTextBox.Name = "IdClienteTextBox"
        Me.IdClienteTextBox.Size = New System.Drawing.Size(107, 20)
        Me.IdClienteTextBox.TabIndex = 3
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Location = New System.Drawing.Point(81, 48)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(202, 20)
        Me.NombreTextBox.TabIndex = 5
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.Location = New System.Drawing.Point(81, 74)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(202, 20)
        Me.ApellidoTextBox.TabIndex = 7
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.Location = New System.Drawing.Point(81, 100)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(202, 20)
        Me.DireccionTextBox.TabIndex = 9
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.Location = New System.Drawing.Point(81, 126)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(107, 20)
        Me.TelefonoTextBox.TabIndex = 11
        '
        'DNITextBox
        '
        Me.DNITextBox.Location = New System.Drawing.Point(81, 152)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.Size = New System.Drawing.Size(107, 20)
        Me.DNITextBox.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.BtnEditar)
        Me.GroupBox1.Controls.Add(Me.BtnNuevo)
        Me.GroupBox1.Controls.Add(Me.IdClienteTextBox)
        Me.GroupBox1.Controls.Add(IdClienteLabel)
        Me.GroupBox1.Controls.Add(Me.DNITextBox)
        Me.GroupBox1.Controls.Add(DNILabel)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.TelefonoTextBox)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(TelefonoLabel)
        Me.GroupBox1.Controls.Add(ApellidoLabel)
        Me.GroupBox1.Controls.Add(Me.DireccionTextBox)
        Me.GroupBox1.Controls.Add(Me.ApellidoTextBox)
        Me.GroupBox1.Controls.Add(DireccionLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 235)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(208, 203)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(95, 26)
        Me.BtnEliminar.TabIndex = 14
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(107, 203)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(95, 26)
        Me.BtnEditar.TabIndex = 14
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(6, 203)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(95, 26)
        Me.BtnNuevo.TabIndex = 14
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(364, 203)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(95, 26)
        Me.BtnCancelar.TabIndex = 14
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnGuardar)
        Me.GroupBox2.Controls.Add(Me.BtnCancelar)
        Me.GroupBox2.Controls.Add(Me.LnkMensaje)
        Me.GroupBox2.Controls.Add(Me.CboCampo)
        Me.GroupBox2.Controls.Add(Me.DgvListado)
        Me.GroupBox2.Controls.Add(Me.TxtBuscar)
        Me.GroupBox2.Location = New System.Drawing.Point(349, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(574, 236)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Clientes"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(466, 203)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(95, 26)
        Me.BtnGuardar.TabIndex = 14
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'LnkMensaje
        '
        Me.LnkMensaje.AutoSize = True
        Me.LnkMensaje.Location = New System.Drawing.Point(251, 128)
        Me.LnkMensaje.Name = "LnkMensaje"
        Me.LnkMensaje.Size = New System.Drawing.Size(58, 13)
        Me.LnkMensaje.TabIndex = 4
        Me.LnkMensaje.TabStop = True
        Me.LnkMensaje.Text = "Inexistente"
        Me.LnkMensaje.Visible = False
        '
        'CboCampo
        '
        Me.CboCampo.FormattingEnabled = True
        Me.CboCampo.Items.AddRange(New Object() {"Nombre", "Apellido", "Telefono", "DNI"})
        Me.CboCampo.Location = New System.Drawing.Point(13, 23)
        Me.CboCampo.Name = "CboCampo"
        Me.CboCampo.Size = New System.Drawing.Size(147, 21)
        Me.CboCampo.TabIndex = 0
        Me.CboCampo.Text = "DNI"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(178, 24)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(384, 20)
        Me.TxtBuscar.TabIndex = 3
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'FrmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 269)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Clientes"
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvListado As DataGridView
    Friend WithEvents IdClienteTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents DNITextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CboCampo As ComboBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents LnkMensaje As LinkLabel
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents BtnGuardar As Button
End Class
