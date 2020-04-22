<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCourse
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
        Me.cboFaculty = New System.Windows.Forms.ComboBox()
        Me.lblFacultyName = New System.Windows.Forms.Label()
        Me.GroupBoxCourseList = New System.Windows.Forms.GroupBox()
        Me.lstCurse = New System.Windows.Forms.ListBox()
        Me.GroupBoxCourseInformation = New System.Windows.Forms.GroupBox()
        Me.txtCurseId = New System.Windows.Forms.TextBox()
        Me.txtEnrollment = New System.Windows.Forms.TextBox()
        Me.txtCredits = New System.Windows.Forms.TextBox()
        Me.txtClassroom = New System.Windows.Forms.TextBox()
        Me.txtSchedule = New System.Windows.Forms.TextBox()
        Me.lblEnrollment = New System.Windows.Forms.Label()
        Me.lblCredut = New System.Windows.Forms.Label()
        Me.lblClassroom = New System.Windows.Forms.Label()
        Me.lblSchedule = New System.Windows.Forms.Label()
        Me.lblCurseId = New System.Windows.Forms.Label()
        Me.cmdSelect = New System.Windows.Forms.Button()
        Me.cmdInsert = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.GroupBoxFacultyName.SuspendLayout()
        Me.GroupBoxCourseList.SuspendLayout()
        Me.GroupBoxCourseInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxFacultyName
        '
        Me.GroupBoxFacultyName.Controls.Add(Me.cboFaculty)
        Me.GroupBoxFacultyName.Controls.Add(Me.lblFacultyName)
        Me.GroupBoxFacultyName.Location = New System.Drawing.Point(5, 5)
        Me.GroupBoxFacultyName.Name = "GroupBoxFacultyName"
        Me.GroupBoxFacultyName.Size = New System.Drawing.Size(439, 123)
        Me.GroupBoxFacultyName.TabIndex = 0
        Me.GroupBoxFacultyName.TabStop = False
        Me.GroupBoxFacultyName.Text = "Faculty Name"
        '
        'cboFaculty
        '
        Me.cboFaculty.FormattingEnabled = True
        Me.cboFaculty.Location = New System.Drawing.Point(146, 45)
        Me.cboFaculty.Name = "cboFaculty"
        Me.cboFaculty.Size = New System.Drawing.Size(274, 24)
        Me.cboFaculty.TabIndex = 1
        Me.cboFaculty.Text = "Faculty"
        '
        'lblFacultyName
        '
        Me.lblFacultyName.AutoSize = True
        Me.lblFacultyName.Location = New System.Drawing.Point(16, 47)
        Me.lblFacultyName.Name = "lblFacultyName"
        Me.lblFacultyName.Size = New System.Drawing.Size(94, 17)
        Me.lblFacultyName.TabIndex = 0
        Me.lblFacultyName.Text = "Faculty Name"
        '
        'GroupBoxCourseList
        '
        Me.GroupBoxCourseList.Controls.Add(Me.lstCurse)
        Me.GroupBoxCourseList.Location = New System.Drawing.Point(5, 151)
        Me.GroupBoxCourseList.Name = "GroupBoxCourseList"
        Me.GroupBoxCourseList.Size = New System.Drawing.Size(365, 267)
        Me.GroupBoxCourseList.TabIndex = 4
        Me.GroupBoxCourseList.TabStop = False
        Me.GroupBoxCourseList.Text = "Course List"
        '
        'lstCurse
        '
        Me.lstCurse.FormattingEnabled = True
        Me.lstCurse.ItemHeight = 16
        Me.lstCurse.Location = New System.Drawing.Point(5, 23)
        Me.lstCurse.Name = "lstCurse"
        Me.lstCurse.Size = New System.Drawing.Size(355, 228)
        Me.lstCurse.TabIndex = 0
        '
        'GroupBoxCourseInformation
        '
        Me.GroupBoxCourseInformation.Controls.Add(Me.txtCurseId)
        Me.GroupBoxCourseInformation.Controls.Add(Me.txtEnrollment)
        Me.GroupBoxCourseInformation.Controls.Add(Me.txtCredits)
        Me.GroupBoxCourseInformation.Controls.Add(Me.txtClassroom)
        Me.GroupBoxCourseInformation.Controls.Add(Me.txtSchedule)
        Me.GroupBoxCourseInformation.Controls.Add(Me.lblEnrollment)
        Me.GroupBoxCourseInformation.Controls.Add(Me.lblCredut)
        Me.GroupBoxCourseInformation.Controls.Add(Me.lblClassroom)
        Me.GroupBoxCourseInformation.Controls.Add(Me.lblSchedule)
        Me.GroupBoxCourseInformation.Controls.Add(Me.lblCurseId)
        Me.GroupBoxCourseInformation.Location = New System.Drawing.Point(375, 151)
        Me.GroupBoxCourseInformation.Name = "GroupBoxCourseInformation"
        Me.GroupBoxCourseInformation.Size = New System.Drawing.Size(296, 267)
        Me.GroupBoxCourseInformation.TabIndex = 5
        Me.GroupBoxCourseInformation.TabStop = False
        Me.GroupBoxCourseInformation.Text = "Course Information"
        '
        'txtCurseId
        '
        Me.txtCurseId.Location = New System.Drawing.Point(99, 49)
        Me.txtCurseId.Name = "txtCurseId"
        Me.txtCurseId.Size = New System.Drawing.Size(181, 22)
        Me.txtCurseId.TabIndex = 1
        Me.txtCurseId.Text = "CurseId"
        '
        'txtEnrollment
        '
        Me.txtEnrollment.Location = New System.Drawing.Point(99, 201)
        Me.txtEnrollment.Name = "txtEnrollment"
        Me.txtEnrollment.Size = New System.Drawing.Size(181, 22)
        Me.txtEnrollment.TabIndex = 9
        Me.txtEnrollment.Text = "Enrollment"
        '
        'txtCredits
        '
        Me.txtCredits.Location = New System.Drawing.Point(99, 163)
        Me.txtCredits.Name = "txtCredits"
        Me.txtCredits.Size = New System.Drawing.Size(181, 22)
        Me.txtCredits.TabIndex = 7
        Me.txtCredits.Text = "Credits"
        '
        'txtClassroom
        '
        Me.txtClassroom.Location = New System.Drawing.Point(99, 125)
        Me.txtClassroom.Name = "txtClassroom"
        Me.txtClassroom.Size = New System.Drawing.Size(181, 22)
        Me.txtClassroom.TabIndex = 5
        Me.txtClassroom.Text = "Classroom"
        '
        'txtSchedule
        '
        Me.txtSchedule.Location = New System.Drawing.Point(99, 87)
        Me.txtSchedule.Name = "txtSchedule"
        Me.txtSchedule.Size = New System.Drawing.Size(181, 22)
        Me.txtSchedule.TabIndex = 3
        Me.txtSchedule.Text = "Schedule"
        '
        'lblEnrollment
        '
        Me.lblEnrollment.AutoSize = True
        Me.lblEnrollment.Location = New System.Drawing.Point(19, 201)
        Me.lblEnrollment.Name = "lblEnrollment"
        Me.lblEnrollment.Size = New System.Drawing.Size(75, 17)
        Me.lblEnrollment.TabIndex = 8
        Me.lblEnrollment.Text = "Enrollment"
        '
        'lblCredut
        '
        Me.lblCredut.AutoSize = True
        Me.lblCredut.Location = New System.Drawing.Point(19, 163)
        Me.lblCredut.Name = "lblCredut"
        Me.lblCredut.Size = New System.Drawing.Size(50, 17)
        Me.lblCredut.TabIndex = 6
        Me.lblCredut.Text = "Credut"
        '
        'lblClassroom
        '
        Me.lblClassroom.AutoSize = True
        Me.lblClassroom.Location = New System.Drawing.Point(19, 125)
        Me.lblClassroom.Name = "lblClassroom"
        Me.lblClassroom.Size = New System.Drawing.Size(74, 17)
        Me.lblClassroom.TabIndex = 4
        Me.lblClassroom.Text = "Classroom"
        '
        'lblSchedule
        '
        Me.lblSchedule.AutoSize = True
        Me.lblSchedule.Location = New System.Drawing.Point(19, 87)
        Me.lblSchedule.Name = "lblSchedule"
        Me.lblSchedule.Size = New System.Drawing.Size(67, 17)
        Me.lblSchedule.TabIndex = 2
        Me.lblSchedule.Text = "Schedule"
        '
        'lblCurseId
        '
        Me.lblCurseId.AutoSize = True
        Me.lblCurseId.Location = New System.Drawing.Point(19, 49)
        Me.lblCurseId.Name = "lblCurseId"
        Me.lblCurseId.Size = New System.Drawing.Size(60, 17)
        Me.lblCurseId.TabIndex = 0
        Me.lblCurseId.Text = "Curse Id"
        '
        'cmdSelect
        '
        Me.cmdSelect.Location = New System.Drawing.Point(513, 14)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(142, 32)
        Me.cmdSelect.TabIndex = 1
        Me.cmdSelect.Text = "Select"
        Me.cmdSelect.UseVisualStyleBackColor = True
        '
        'cmdInsert
        '
        Me.cmdInsert.Location = New System.Drawing.Point(513, 52)
        Me.cmdInsert.Name = "cmdInsert"
        Me.cmdInsert.Size = New System.Drawing.Size(142, 32)
        Me.cmdInsert.TabIndex = 2
        Me.cmdInsert.Text = "Insert"
        Me.cmdInsert.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(513, 90)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(142, 32)
        Me.cmdBack.TabIndex = 3
        Me.cmdBack.Text = "Back"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'FrmCurse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 428)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdInsert)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.GroupBoxCourseInformation)
        Me.Controls.Add(Me.GroupBoxCourseList)
        Me.Controls.Add(Me.GroupBoxFacultyName)
        Me.Name = "FrmCurse"
        Me.Text = "FrmCourse"
        Me.GroupBoxFacultyName.ResumeLayout(False)
        Me.GroupBoxFacultyName.PerformLayout()
        Me.GroupBoxCourseList.ResumeLayout(False)
        Me.GroupBoxCourseInformation.ResumeLayout(False)
        Me.GroupBoxCourseInformation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxFacultyName As GroupBox
    Friend WithEvents cboFaculty As ComboBox
    Friend WithEvents lblFacultyName As Label
    Friend WithEvents GroupBoxCourseList As GroupBox
    Friend WithEvents lstCurse As ListBox
    Friend WithEvents GroupBoxCourseInformation As GroupBox
    Friend WithEvents txtCurseId As TextBox
    Friend WithEvents txtEnrollment As TextBox
    Friend WithEvents txtCredits As TextBox
    Friend WithEvents txtClassroom As TextBox
    Friend WithEvents txtSchedule As TextBox
    Friend WithEvents lblEnrollment As Label
    Friend WithEvents lblCredut As Label
    Friend WithEvents lblClassroom As Label
    Friend WithEvents lblSchedule As Label
    Friend WithEvents lblCurseId As Label
    Friend WithEvents cmdSelect As Button
    Friend WithEvents cmdInsert As Button
    Friend WithEvents cmdBack As Button
End Class
