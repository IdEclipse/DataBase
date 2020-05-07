<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.DoubleInput = New DevComponents.Editors.DoubleInput()
        Me.IntegerInput = New DevComponents.Editors.IntegerInput()
        Me.DateTimeInput = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.IpAddressInput = New DevComponents.Editors.IpAddressInput()
        CType(Me.DoubleInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IntegerInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTimeInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IpAddressInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(266, 73)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(136, 43)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'DoubleInput
        '
        '
        '
        '
        Me.DoubleInput.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DoubleInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DoubleInput.ButtonDropDown.Enabled = False
        Me.DoubleInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.DoubleInput.Colors.Highlight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DoubleInput.FocusHighlightColor = System.Drawing.Color.White
        Me.DoubleInput.Increment = 1.0R
        Me.DoubleInput.Location = New System.Drawing.Point(26, 99)
        Me.DoubleInput.MinValue = 0R
        Me.DoubleInput.Name = "DoubleInput"
        Me.DoubleInput.Size = New System.Drawing.Size(136, 20)
        Me.DoubleInput.TabIndex = 2
        '
        'IntegerInput
        '
        '
        '
        '
        Me.IntegerInput.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.IntegerInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.IntegerInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.IntegerInput.Location = New System.Drawing.Point(26, 70)
        Me.IntegerInput.MinValue = 0
        Me.IntegerInput.Name = "IntegerInput"
        Me.IntegerInput.Size = New System.Drawing.Size(136, 20)
        Me.IntegerInput.TabIndex = 0
        '
        'DateTimeInput
        '
        '
        '
        '
        Me.DateTimeInput.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DateTimeInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DateTimeInput.ButtonDropDown.Visible = True
        Me.DateTimeInput.IsPopupCalendarOpen = False
        Me.DateTimeInput.Location = New System.Drawing.Point(26, 128)
        '
        '
        '
        '
        '
        '
        Me.DateTimeInput.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DateTimeInput.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DateTimeInput.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DateTimeInput.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimeInput.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DateTimeInput.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DateTimeInput.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DateTimeInput.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DateTimeInput.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput.MonthCalendar.DisplayMonth = New Date(2020, 4, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.DateTimeInput.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DateTimeInput.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimeInput.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DateTimeInput.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput.MonthCalendar.TodayButtonVisible = True
        Me.DateTimeInput.Name = "DateTimeInput"
        Me.DateTimeInput.Size = New System.Drawing.Size(136, 20)
        Me.DateTimeInput.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DateTimeInput.TabIndex = 3
        '
        'IpAddressInput
        '
        Me.IpAddressInput.AutoOverwrite = True
        '
        '
        '
        Me.IpAddressInput.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.IpAddressInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.IpAddressInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.IpAddressInput.ButtonFreeText.Visible = True
        Me.IpAddressInput.Location = New System.Drawing.Point(26, 157)
        Me.IpAddressInput.Name = "IpAddressInput"
        Me.IpAddressInput.Size = New System.Drawing.Size(136, 20)
        Me.IpAddressInput.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.IpAddressInput.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 347)
        Me.Controls.Add(Me.IpAddressInput)
        Me.Controls.Add(Me.DateTimeInput)
        Me.Controls.Add(Me.IntegerInput)
        Me.Controls.Add(Me.DoubleInput)
        Me.Controls.Add(Me.BtnSalir)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DoubleInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IntegerInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTimeInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IpAddressInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSalir As Button
    Friend WithEvents DoubleInput As DevComponents.Editors.DoubleInput
    Friend WithEvents IntegerInput As DevComponents.Editors.IntegerInput
    Friend WithEvents DateTimeInput As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents IpAddressInput As DevComponents.Editors.IpAddressInput
End Class
