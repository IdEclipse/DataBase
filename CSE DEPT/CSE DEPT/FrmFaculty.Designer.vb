<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFaculty
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
        Me.GroupBoxFacultyName = New System.Windows.Forms.GroupBox()
        Me.CboFaculty = New System.Windows.Forms.ComboBox()
        Me.LblFacultyName = New System.Windows.Forms.Label()
        Me.GroupBoxFacultyInformation = New System.Windows.Forms.GroupBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblCollege = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblOffice = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pbxPhoto = New System.Windows.Forms.PictureBox()
        Me.cmdSelect = New System.Windows.Forms.Button()
        Me.cmdInsert = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.GroupBoxFacultyName.SuspendLayout()
        Me.GroupBoxFacultyInformation.SuspendLayout()
        CType(Me.pbxPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxFacultyName
        '
        Me.GroupBoxFacultyName.Controls.Add(Me.CboFaculty)
        Me.GroupBoxFacultyName.Controls.Add(Me.LblFacultyName)
        Me.GroupBoxFacultyName.Location = New System.Drawing.Point(262, 23)
        Me.GroupBoxFacultyName.Name = "GroupBoxFacultyName"
        Me.GroupBoxFacultyName.Size = New System.Drawing.Size(408, 114)
        Me.GroupBoxFacultyName.TabIndex = 0
        Me.GroupBoxFacultyName.TabStop = False
        Me.GroupBoxFacultyName.Text = "Faculty Name"
        '
        'CboFaculty
        '
        Me.CboFaculty.FormattingEnabled = True
        Me.CboFaculty.Location = New System.Drawing.Point(164, 40)
        Me.CboFaculty.Name = "CboFaculty"
        Me.CboFaculty.Size = New System.Drawing.Size(175, 24)
        Me.CboFaculty.TabIndex = 1
        Me.CboFaculty.Text = "Faculty"
        '
        'LblFacultyName
        '
        Me.LblFacultyName.AutoSize = True
        Me.LblFacultyName.Location = New System.Drawing.Point(20, 43)
        Me.LblFacultyName.Name = "LblFacultyName"
        Me.LblFacultyName.Size = New System.Drawing.Size(94, 17)
        Me.LblFacultyName.TabIndex = 0
        Me.LblFacultyName.Text = "Faculty Name"
        '
        'GroupBoxFacultyInformation
        '
        Me.GroupBoxFacultyInformation.Controls.Add(Me.lblEmail)
        Me.GroupBoxFacultyInformation.Controls.Add(Me.lblCollege)
        Me.GroupBoxFacultyInformation.Controls.Add(Me.lblPhone)
        Me.GroupBoxFacultyInformation.Controls.Add(Me.lblOffice)
        Me.GroupBoxFacultyInformation.Controls.Add(Me.lblTitle)
        Me.GroupBoxFacultyInformation.Location = New System.Drawing.Point(262, 142)
        Me.GroupBoxFacultyInformation.Name = "GroupBoxFacultyInformation"
        Me.GroupBoxFacultyInformation.Size = New System.Drawing.Size(408, 252)
        Me.GroupBoxFacultyInformation.TabIndex = 1
        Me.GroupBoxFacultyInformation.TabStop = False
        Me.GroupBoxFacultyInformation.Text = "Faculty Information"
        '
        'lblEmail
        '
        Me.lblEmail.BackColor = System.Drawing.Color.White
        Me.lblEmail.Location = New System.Drawing.Point(20, 200)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(346, 18)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email"
        '
        'lblCollege
        '
        Me.lblCollege.BackColor = System.Drawing.Color.White
        Me.lblCollege.Location = New System.Drawing.Point(20, 162)
        Me.lblCollege.Name = "lblCollege"
        Me.lblCollege.Size = New System.Drawing.Size(346, 18)
        Me.lblCollege.TabIndex = 3
        Me.lblCollege.Text = "College"
        '
        'lblPhone
        '
        Me.lblPhone.BackColor = System.Drawing.Color.White
        Me.lblPhone.Location = New System.Drawing.Point(20, 124)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(346, 18)
        Me.lblPhone.TabIndex = 2
        Me.lblPhone.Text = "Phone"
        '
        'lblOffice
        '
        Me.lblOffice.BackColor = System.Drawing.Color.White
        Me.lblOffice.Location = New System.Drawing.Point(20, 86)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Size = New System.Drawing.Size(346, 18)
        Me.lblOffice.TabIndex = 1
        Me.lblOffice.Text = "Office"
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 48)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(346, 18)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title"
        '
        'pbxPhoto
        '
        Me.pbxPhoto.Location = New System.Drawing.Point(20, 23)
        Me.pbxPhoto.Name = "pbxPhoto"
        Me.pbxPhoto.Size = New System.Drawing.Size(212, 208)
        Me.pbxPhoto.TabIndex = 2
        Me.pbxPhoto.TabStop = False
        '
        'cmdSelect
        '
        Me.cmdSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdSelect.Location = New System.Drawing.Point(20, 420)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(110, 32)
        Me.cmdSelect.TabIndex = 2
        Me.cmdSelect.Text = "Select"
        Me.cmdSelect.UseVisualStyleBackColor = True
        '
        'cmdInsert
        '
        Me.cmdInsert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdInsert.Location = New System.Drawing.Point(155, 420)
        Me.cmdInsert.Name = "cmdInsert"
        Me.cmdInsert.Size = New System.Drawing.Size(110, 32)
        Me.cmdInsert.TabIndex = 3
        Me.cmdInsert.Text = "Insert"
        Me.cmdInsert.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdUpdate.Location = New System.Drawing.Point(290, 420)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(110, 32)
        Me.cmdUpdate.TabIndex = 4
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.Location = New System.Drawing.Point(425, 420)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(110, 32)
        Me.cmdDelete.TabIndex = 5
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdBack.Location = New System.Drawing.Point(560, 420)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(110, 32)
        Me.cmdBack.TabIndex = 6
        Me.cmdBack.Text = "Back"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'frmFaculty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 464)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdInsert)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.pbxPhoto)
        Me.Controls.Add(Me.GroupBoxFacultyInformation)
        Me.Controls.Add(Me.GroupBoxFacultyName)
        Me.Name = "frmFaculty"
        Me.Text = "frmFaculty"
        Me.GroupBoxFacultyName.ResumeLayout(False)
        Me.GroupBoxFacultyName.PerformLayout()
        Me.GroupBoxFacultyInformation.ResumeLayout(False)
        CType(Me.pbxPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxFacultyName As GroupBox
    Friend WithEvents CboFaculty As ComboBox
    Friend WithEvents LblFacultyName As Label
    Friend WithEvents GroupBoxFacultyInformation As GroupBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblCollege As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblOffice As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents pbxPhoto As PictureBox
    Friend WithEvents cmdSelect As Button
    Friend WithEvents cmdInsert As Button
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdBack As Button
End Class
