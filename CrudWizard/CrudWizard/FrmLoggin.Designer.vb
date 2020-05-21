<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLoggin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLoggin))
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.UsuarioTableAdapter = New CrudWizard.dsTableAdapters.UsuarioTableAdapter()
        Me.Ds = New CrudWizard.ds()
        Me.LabelUsuario = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBoxGrupo1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.Ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxGrupo1.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(175, 24)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNombre.TabIndex = 0
        Me.TextBoxNombre.Text = "Donell"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(175, 58)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPassword.TabIndex = 1
        Me.TextBoxPassword.Text = "8675"
        '
        'btnIngresar
        '
        Me.btnIngresar.Image = CType(resources.GetObject("btnIngresar.Image"), System.Drawing.Image)
        Me.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIngresar.Location = New System.Drawing.Point(190, 121)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(114, 44)
        Me.btnIngresar.TabIndex = 8
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'Ds
        '
        Me.Ds.DataSetName = "ds"
        Me.Ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelUsuario
        '
        Me.LabelUsuario.AutoSize = True
        Me.LabelUsuario.Location = New System.Drawing.Point(110, 27)
        Me.LabelUsuario.Name = "LabelUsuario"
        Me.LabelUsuario.Size = New System.Drawing.Size(43, 13)
        Me.LabelUsuario.TabIndex = 9
        Me.LabelUsuario.Text = "Usuario"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Location = New System.Drawing.Point(110, 65)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(53, 13)
        Me.LabelPassword.TabIndex = 9
        Me.LabelPassword.Text = "Password"
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(12, 121)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(114, 44)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBoxGrupo1
        '
        Me.GroupBoxGrupo1.Controls.Add(Me.PictureBox)
        Me.GroupBoxGrupo1.Controls.Add(Me.LabelUsuario)
        Me.GroupBoxGrupo1.Controls.Add(Me.LabelPassword)
        Me.GroupBoxGrupo1.Controls.Add(Me.TextBoxNombre)
        Me.GroupBoxGrupo1.Controls.Add(Me.TextBoxPassword)
        Me.GroupBoxGrupo1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBoxGrupo1.Name = "GroupBoxGrupo1"
        Me.GroupBoxGrupo1.Size = New System.Drawing.Size(292, 103)
        Me.GroupBoxGrupo1.TabIndex = 10
        Me.GroupBoxGrupo1.TabStop = False
        '
        'PictureBox
        '
        Me.PictureBox.Image = CType(resources.GetObject("PictureBox.Image"), System.Drawing.Image)
        Me.PictureBox.Location = New System.Drawing.Point(6, 11)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(87, 85)
        Me.PictureBox.TabIndex = 10
        Me.PictureBox.TabStop = False
        '
        'FrmLoggin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(316, 171)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBoxGrupo1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIngresar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmLoggin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Control - Planeamiento"
        CType(Me.Ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxGrupo1.ResumeLayout(False)
        Me.GroupBoxGrupo1.PerformLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents UsuarioTableAdapter As dsTableAdapters.UsuarioTableAdapter
    Friend WithEvents Ds As ds
    Friend WithEvents LabelUsuario As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBoxGrupo1 As GroupBox
    Friend WithEvents PictureBox As PictureBox
End Class
