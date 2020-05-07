<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.LogInBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CSE_DEPTDataSet = New CSE_DEPT.CSE_DEPTDataSet()
        Me.txtPasswordWord = New System.Windows.Forms.TextBox()
        Me.LabelUserName = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.cmdLogin = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.LogInTableAdapter = New CSE_DEPT.CSE_DEPTDataSetTableAdapters.LogInTableAdapter()
        CType(Me.LogInBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSE_DEPTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUserName
        '
        Me.txtUserName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LogInBindingSource, "user_name", True))
        Me.txtUserName.Location = New System.Drawing.Point(110, 28)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(124, 20)
        Me.txtUserName.TabIndex = 1
        Me.txtUserName.Text = "uni"
        '
        'LogInBindingSource
        '
        Me.LogInBindingSource.DataMember = "LogIn"
        Me.LogInBindingSource.DataSource = Me.CSE_DEPTDataSet
        '
        'CSE_DEPTDataSet
        '
        Me.CSE_DEPTDataSet.DataSetName = "CSE_DEPTDataSet"
        Me.CSE_DEPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtPasswordWord
        '
        Me.txtPasswordWord.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LogInBindingSource, "pass_word", True))
        Me.txtPasswordWord.Location = New System.Drawing.Point(110, 51)
        Me.txtPasswordWord.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPasswordWord.Name = "txtPasswordWord"
        Me.txtPasswordWord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordWord.Size = New System.Drawing.Size(124, 20)
        Me.txtPasswordWord.TabIndex = 3
        Me.txtPasswordWord.Text = "123"
        '
        'LabelUserName
        '
        Me.LabelUserName.AutoSize = True
        Me.LabelUserName.Location = New System.Drawing.Point(25, 28)
        Me.LabelUserName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelUserName.Name = "LabelUserName"
        Me.LabelUserName.Size = New System.Drawing.Size(57, 13)
        Me.LabelUserName.TabIndex = 0
        Me.LabelUserName.Text = "UserName"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Location = New System.Drawing.Point(25, 51)
        Me.LabelPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(53, 13)
        Me.LabelPassword.TabIndex = 2
        Me.LabelPassword.Text = "Password"
        '
        'cmdLogin
        '
        Me.cmdLogin.Location = New System.Drawing.Point(27, 87)
        Me.cmdLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(98, 30)
        Me.cmdLogin.TabIndex = 4
        Me.cmdLogin.Text = "Login"
        Me.cmdLogin.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(135, 87)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 30)
        Me.cmdCancel.TabIndex = 5
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'LogInTableAdapter
        '
        Me.LogInTableAdapter.ClearBeforeFill = True
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.cmdLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(256, 131)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdLogin)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.LabelUserName)
        Me.Controls.Add(Me.txtPasswordWord)
        Me.Controls.Add(Me.txtUserName)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmLogin"
        Me.Text = "Loggin"
        CType(Me.LogInBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSE_DEPTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPasswordWord As TextBox
    Friend WithEvents LabelUserName As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents cmdLogin As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents LogInBindingSource As BindingSource
    Friend WithEvents CSE_DEPTDataSet As CSE_DEPTDataSet
    Friend WithEvents LogInTableAdapter As CSE_DEPTDataSetTableAdapters.LogInTableAdapter
End Class
