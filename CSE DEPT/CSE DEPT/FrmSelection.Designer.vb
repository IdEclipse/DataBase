<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelection
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
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.CboSelection = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.Location = New System.Drawing.Point(23, 77)
        Me.cmdOk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(115, 33)
        Me.cmdOk.TabIndex = 1
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(170, 77)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(115, 33)
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'CboSelection
        '
        Me.CboSelection.FormattingEnabled = True
        Me.CboSelection.Location = New System.Drawing.Point(25, 26)
        Me.CboSelection.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CboSelection.Name = "CboSelection"
        Me.CboSelection.Size = New System.Drawing.Size(260, 21)
        Me.CboSelection.TabIndex = 0
        Me.CboSelection.Text = "Faculty Information"
        '
        'FrmSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 121)
        Me.Controls.Add(Me.CboSelection)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdOk)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmSelection"
        Me.Text = "FrmSelection"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdOk As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents CboSelection As ComboBox
End Class
