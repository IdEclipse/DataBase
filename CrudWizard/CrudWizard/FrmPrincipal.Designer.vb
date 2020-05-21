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
        Me.StatusStripPrincipal = New System.Windows.Forms.StatusStrip()
        Me.ToolStripMenuBotones = New System.Windows.Forms.ToolStrip()
        Me.MenuStripPrincipal = New System.Windows.Forms.MenuStrip()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaborToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStripPrincipal
        '
        Me.StatusStripPrincipal.Location = New System.Drawing.Point(0, 593)
        Me.StatusStripPrincipal.Name = "StatusStripPrincipal"
        Me.StatusStripPrincipal.Size = New System.Drawing.Size(1251, 22)
        Me.StatusStripPrincipal.TabIndex = 1
        Me.StatusStripPrincipal.Text = "Principal"
        '
        'ToolStripMenuBotones
        '
        Me.ToolStripMenuBotones.Location = New System.Drawing.Point(0, 24)
        Me.ToolStripMenuBotones.Name = "ToolStripMenuBotones"
        Me.ToolStripMenuBotones.Size = New System.Drawing.Size(1251, 25)
        Me.ToolStripMenuBotones.TabIndex = 2
        Me.ToolStripMenuBotones.Text = "MenuBotones"
        '
        'MenuStripPrincipal
        '
        Me.MenuStripPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem, Me.MantenimientoToolStripMenuItem})
        Me.MenuStripPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripPrincipal.Name = "MenuStripPrincipal"
        Me.MenuStripPrincipal.Size = New System.Drawing.Size(1251, 24)
        Me.MenuStripPrincipal.TabIndex = 3
        Me.MenuStripPrincipal.Text = "Principal"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaborToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'LaborToolStripMenuItem
        '
        Me.LaborToolStripMenuItem.Name = "LaborToolStripMenuItem"
        Me.LaborToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LaborToolStripMenuItem.Text = "Labor"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1251, 615)
        Me.Controls.Add(Me.ToolStripMenuBotones)
        Me.Controls.Add(Me.StatusStripPrincipal)
        Me.Controls.Add(Me.MenuStripPrincipal)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStripPrincipal
        Me.Name = "FrmPrincipal"
        Me.Text = "FrmPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStripPrincipal.ResumeLayout(False)
        Me.MenuStripPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStripPrincipal As StatusStrip
    Friend WithEvents ToolStripMenuBotones As ToolStrip
    Friend WithEvents MenuStripPrincipal As MenuStrip
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaborToolStripMenuItem As ToolStripMenuItem
End Class
