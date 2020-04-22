<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStudent
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
        Me.GroupBoxStudentName = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBoxCourseSelectef = New System.Windows.Forms.GroupBox()
        Me.GroupBoxStudentInformation = New System.Windows.Forms.GroupBox()
        Me.lblStudentId = New System.Windows.Forms.Label()
        Me.lblSchoolYear = New System.Windows.Forms.Label()
        Me.lblGPA = New System.Windows.Forms.Label()
        Me.lblMajor = New System.Windows.Forms.Label()
        Me.lblCredits = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtStudentId = New System.Windows.Forms.TextBox()
        Me.txtSchoolYear = New System.Windows.Forms.TextBox()
        Me.txtGPA = New System.Windows.Forms.TextBox()
        Me.txtMajor = New System.Windows.Forms.TextBox()
        Me.txtCredits = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.cboStudent = New System.Windows.Forms.ComboBox()
        Me.lstCourse = New System.Windows.Forms.ListBox()
        Me.pbxStudent = New System.Windows.Forms.PictureBox()
        Me.cmdSelect = New System.Windows.Forms.Button()
        Me.cmdInsert = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.GroupBoxStudentName.SuspendLayout()
        Me.GroupBoxCourseSelectef.SuspendLayout()
        Me.GroupBoxStudentInformation.SuspendLayout()
        CType(Me.pbxStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxStudentName
        '
        Me.GroupBoxStudentName.Controls.Add(Me.cboStudent)
        Me.GroupBoxStudentName.Controls.Add(Me.lblStudentName)
        Me.GroupBoxStudentName.Location = New System.Drawing.Point(5, 5)
        Me.GroupBoxStudentName.Name = "GroupBoxStudentName"
        Me.GroupBoxStudentName.Size = New System.Drawing.Size(354, 111)
        Me.GroupBoxStudentName.TabIndex = 0
        Me.GroupBoxStudentName.TabStop = False
        Me.GroupBoxStudentName.Text = "Student Name"
        '
        'GroupBoxCourseSelectef
        '
        Me.GroupBoxCourseSelectef.Controls.Add(Me.lstCourse)
        Me.GroupBoxCourseSelectef.Location = New System.Drawing.Point(365, 5)
        Me.GroupBoxCourseSelectef.Name = "GroupBoxCourseSelectef"
        Me.GroupBoxCourseSelectef.Size = New System.Drawing.Size(261, 111)
        Me.GroupBoxCourseSelectef.TabIndex = 1
        Me.GroupBoxCourseSelectef.TabStop = False
        Me.GroupBoxCourseSelectef.Text = "Course Selectef"
        '
        'GroupBoxStudentInformation
        '
        Me.GroupBoxStudentInformation.Controls.Add(Me.txtEmail)
        Me.GroupBoxStudentInformation.Controls.Add(Me.txtCredits)
        Me.GroupBoxStudentInformation.Controls.Add(Me.txtMajor)
        Me.GroupBoxStudentInformation.Controls.Add(Me.txtGPA)
        Me.GroupBoxStudentInformation.Controls.Add(Me.txtSchoolYear)
        Me.GroupBoxStudentInformation.Controls.Add(Me.txtStudentId)
        Me.GroupBoxStudentInformation.Controls.Add(Me.lblEmail)
        Me.GroupBoxStudentInformation.Controls.Add(Me.lblCredits)
        Me.GroupBoxStudentInformation.Controls.Add(Me.lblMajor)
        Me.GroupBoxStudentInformation.Controls.Add(Me.lblGPA)
        Me.GroupBoxStudentInformation.Controls.Add(Me.lblSchoolYear)
        Me.GroupBoxStudentInformation.Controls.Add(Me.lblStudentId)
        Me.GroupBoxStudentInformation.Location = New System.Drawing.Point(272, 121)
        Me.GroupBoxStudentInformation.Name = "GroupBoxStudentInformation"
        Me.GroupBoxStudentInformation.Size = New System.Drawing.Size(354, 280)
        Me.GroupBoxStudentInformation.TabIndex = 5
        Me.GroupBoxStudentInformation.TabStop = False
        Me.GroupBoxStudentInformation.Text = "Student Information"
        '
        'lblStudentId
        '
        Me.lblStudentId.AutoSize = True
        Me.lblStudentId.Location = New System.Drawing.Point(25, 40)
        Me.lblStudentId.Name = "lblStudentId"
        Me.lblStudentId.Size = New System.Drawing.Size(68, 17)
        Me.lblStudentId.TabIndex = 0
        Me.lblStudentId.Text = "StudentId"
        '
        'lblSchoolYear
        '
        Me.lblSchoolYear.AutoSize = True
        Me.lblSchoolYear.Location = New System.Drawing.Point(25, 80)
        Me.lblSchoolYear.Name = "lblSchoolYear"
        Me.lblSchoolYear.Size = New System.Drawing.Size(85, 17)
        Me.lblSchoolYear.TabIndex = 2
        Me.lblSchoolYear.Text = "School Year"
        '
        'lblGPA
        '
        Me.lblGPA.AutoSize = True
        Me.lblGPA.Location = New System.Drawing.Point(25, 120)
        Me.lblGPA.Name = "lblGPA"
        Me.lblGPA.Size = New System.Drawing.Size(37, 17)
        Me.lblGPA.TabIndex = 4
        Me.lblGPA.Text = "GPA"
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.Location = New System.Drawing.Point(25, 160)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(43, 17)
        Me.lblMajor.TabIndex = 6
        Me.lblMajor.Text = "Major"
        '
        'lblCredits
        '
        Me.lblCredits.AutoSize = True
        Me.lblCredits.Location = New System.Drawing.Point(25, 200)
        Me.lblCredits.Name = "lblCredits"
        Me.lblCredits.Size = New System.Drawing.Size(52, 17)
        Me.lblCredits.TabIndex = 8
        Me.lblCredits.Text = "Credits"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(25, 240)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "Email"
        '
        'txtStudentId
        '
        Me.txtStudentId.Location = New System.Drawing.Point(133, 37)
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.Size = New System.Drawing.Size(202, 22)
        Me.txtStudentId.TabIndex = 1
        Me.txtStudentId.Text = "StudentId"
        '
        'txtSchoolYear
        '
        Me.txtSchoolYear.Location = New System.Drawing.Point(133, 78)
        Me.txtSchoolYear.Name = "txtSchoolYear"
        Me.txtSchoolYear.Size = New System.Drawing.Size(202, 22)
        Me.txtSchoolYear.TabIndex = 3
        Me.txtSchoolYear.Text = "School Year"
        '
        'txtGPA
        '
        Me.txtGPA.Location = New System.Drawing.Point(133, 118)
        Me.txtGPA.Name = "txtGPA"
        Me.txtGPA.Size = New System.Drawing.Size(202, 22)
        Me.txtGPA.TabIndex = 5
        Me.txtGPA.Text = "GPA"
        '
        'txtMajor
        '
        Me.txtMajor.Location = New System.Drawing.Point(133, 158)
        Me.txtMajor.Name = "txtMajor"
        Me.txtMajor.Size = New System.Drawing.Size(202, 22)
        Me.txtMajor.TabIndex = 7
        Me.txtMajor.Text = "Major"
        '
        'txtCredits
        '
        Me.txtCredits.Location = New System.Drawing.Point(133, 198)
        Me.txtCredits.Name = "txtCredits"
        Me.txtCredits.Size = New System.Drawing.Size(202, 22)
        Me.txtCredits.TabIndex = 9
        Me.txtCredits.Text = "Credits"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(133, 238)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(202, 22)
        Me.txtEmail.TabIndex = 11
        Me.txtEmail.Text = "Email"
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Location = New System.Drawing.Point(6, 42)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(98, 17)
        Me.lblStudentName.TabIndex = 0
        Me.lblStudentName.Text = "Student Name"
        '
        'cboStudent
        '
        Me.cboStudent.FormattingEnabled = True
        Me.cboStudent.Location = New System.Drawing.Point(128, 40)
        Me.cboStudent.Name = "cboStudent"
        Me.cboStudent.Size = New System.Drawing.Size(216, 24)
        Me.cboStudent.TabIndex = 1
        Me.cboStudent.Text = "Student"
        '
        'lstCourse
        '
        Me.lstCourse.FormattingEnabled = True
        Me.lstCourse.ItemHeight = 16
        Me.lstCourse.Location = New System.Drawing.Point(5, 23)
        Me.lstCourse.Name = "lstCourse"
        Me.lstCourse.Size = New System.Drawing.Size(250, 84)
        Me.lstCourse.TabIndex = 0
        '
        'pbxStudent
        '
        Me.pbxStudent.Location = New System.Drawing.Point(5, 127)
        Me.pbxStudent.Name = "pbxStudent"
        Me.pbxStudent.Size = New System.Drawing.Size(209, 214)
        Me.pbxStudent.TabIndex = 3
        Me.pbxStudent.TabStop = False
        '
        'cmdSelect
        '
        Me.cmdSelect.Location = New System.Drawing.Point(5, 366)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(77, 32)
        Me.cmdSelect.TabIndex = 2
        Me.cmdSelect.Text = "Select"
        Me.cmdSelect.UseVisualStyleBackColor = True
        '
        'cmdInsert
        '
        Me.cmdInsert.Location = New System.Drawing.Point(96, 366)
        Me.cmdInsert.Name = "cmdInsert"
        Me.cmdInsert.Size = New System.Drawing.Size(77, 32)
        Me.cmdInsert.TabIndex = 3
        Me.cmdInsert.Text = "Insert"
        Me.cmdInsert.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(187, 366)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(77, 32)
        Me.cmdBack.TabIndex = 4
        Me.cmdBack.Text = "Back"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'FrmStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 410)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdInsert)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.pbxStudent)
        Me.Controls.Add(Me.GroupBoxStudentInformation)
        Me.Controls.Add(Me.GroupBoxCourseSelectef)
        Me.Controls.Add(Me.GroupBoxStudentName)
        Me.Name = "FrmStudent"
        Me.Text = "FrmStudent"
        Me.GroupBoxStudentName.ResumeLayout(False)
        Me.GroupBoxStudentName.PerformLayout()
        Me.GroupBoxCourseSelectef.ResumeLayout(False)
        Me.GroupBoxStudentInformation.ResumeLayout(False)
        Me.GroupBoxStudentInformation.PerformLayout()
        CType(Me.pbxStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxStudentName As GroupBox
    Friend WithEvents cboStudent As ComboBox
    Friend WithEvents lblStudentName As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBoxCourseSelectef As GroupBox
    Friend WithEvents lstCourse As ListBox
    Friend WithEvents GroupBoxStudentInformation As GroupBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtCredits As TextBox
    Friend WithEvents txtMajor As TextBox
    Friend WithEvents txtGPA As TextBox
    Friend WithEvents txtSchoolYear As TextBox
    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblCredits As Label
    Friend WithEvents lblMajor As Label
    Friend WithEvents lblGPA As Label
    Friend WithEvents lblSchoolYear As Label
    Friend WithEvents lblStudentId As Label
    Friend WithEvents pbxStudent As PictureBox
    Friend WithEvents cmdSelect As Button
    Friend WithEvents cmdInsert As Button
    Friend WithEvents cmdBack As Button
End Class
