<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemesterAverage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbResult = New System.Windows.Forms.Label()
        Me.lbSemesterAverageMarks = New System.Windows.Forms.Label()
        Me.lbSemesterAverage = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.tbCourse6 = New System.Windows.Forms.TextBox()
        Me.tbCourse5 = New System.Windows.Forms.TextBox()
        Me.tbCourse4 = New System.Windows.Forms.TextBox()
        Me.tbCourse3 = New System.Windows.Forms.TextBox()
        Me.tbCourse2 = New System.Windows.Forms.TextBox()
        Me.tbCourse1 = New System.Windows.Forms.TextBox()
        Me.lbAverageSemesterGrade = New System.Windows.Forms.Label()
        Me.lbCourse6SemesterGrade = New System.Windows.Forms.Label()
        Me.lbCourse5SemesterGrade = New System.Windows.Forms.Label()
        Me.lbCourse4SemesterGrade = New System.Windows.Forms.Label()
        Me.lbCourse3SemesterGrade = New System.Windows.Forms.Label()
        Me.lbCourse2SemesterGrade = New System.Windows.Forms.Label()
        Me.lbCourse1SemesterGrade = New System.Windows.Forms.Label()
        Me.lbSemester = New System.Windows.Forms.Label()
        Me.lbCourse6 = New System.Windows.Forms.Label()
        Me.lbCourse5 = New System.Windows.Forms.Label()
        Me.lbCourse4 = New System.Windows.Forms.Label()
        Me.lbCourse3 = New System.Windows.Forms.Label()
        Me.lbCourse2 = New System.Windows.Forms.Label()
        Me.lbCouuser1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbResult
        '
        Me.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbResult.Location = New System.Drawing.Point(47, 336)
        Me.lbResult.Name = "lbResult"
        Me.lbResult.Size = New System.Drawing.Size(370, 233)
        Me.lbResult.TabIndex = 15
        '
        'lbSemesterAverageMarks
        '
        Me.lbSemesterAverageMarks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSemesterAverageMarks.Location = New System.Drawing.Point(171, 283)
        Me.lbSemesterAverageMarks.Name = "lbSemesterAverageMarks"
        Me.lbSemesterAverageMarks.Size = New System.Drawing.Size(100, 22)
        Me.lbSemesterAverageMarks.TabIndex = 13
        Me.lbSemesterAverageMarks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbSemesterAverage
        '
        Me.lbSemesterAverage.Location = New System.Drawing.Point(168, 283)
        Me.lbSemesterAverage.Name = "lbSemesterAverage"
        Me.lbSemesterAverage.Size = New System.Drawing.Size(100, 22)
        Me.lbSemesterAverage.TabIndex = 51
        Me.lbSemesterAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(302, 598)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(93, 33)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(171, 598)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 33)
        Me.btnReset.TabIndex = 17
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(47, 598)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(103, 33)
        Me.btnCalculate.TabIndex = 16
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'tbCourse6
        '
        Me.tbCourse6.Location = New System.Drawing.Point(171, 238)
        Me.tbCourse6.Name = "tbCourse6"
        Me.tbCourse6.Size = New System.Drawing.Size(100, 22)
        Me.tbCourse6.TabIndex = 11
        Me.tbCourse6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCourse5
        '
        Me.tbCourse5.Location = New System.Drawing.Point(171, 193)
        Me.tbCourse5.Name = "tbCourse5"
        Me.tbCourse5.Size = New System.Drawing.Size(100, 22)
        Me.tbCourse5.TabIndex = 9
        Me.tbCourse5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCourse4
        '
        Me.tbCourse4.Location = New System.Drawing.Point(171, 148)
        Me.tbCourse4.Name = "tbCourse4"
        Me.tbCourse4.Size = New System.Drawing.Size(100, 22)
        Me.tbCourse4.TabIndex = 7
        Me.tbCourse4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCourse3
        '
        Me.tbCourse3.Location = New System.Drawing.Point(171, 103)
        Me.tbCourse3.Name = "tbCourse3"
        Me.tbCourse3.Size = New System.Drawing.Size(100, 22)
        Me.tbCourse3.TabIndex = 5
        Me.tbCourse3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCourse2
        '
        Me.tbCourse2.Location = New System.Drawing.Point(171, 58)
        Me.tbCourse2.Name = "tbCourse2"
        Me.tbCourse2.Size = New System.Drawing.Size(100, 22)
        Me.tbCourse2.TabIndex = 3
        Me.tbCourse2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCourse1
        '
        Me.tbCourse1.Location = New System.Drawing.Point(171, 13)
        Me.tbCourse1.Name = "tbCourse1"
        Me.tbCourse1.Size = New System.Drawing.Size(100, 22)
        Me.tbCourse1.TabIndex = 1
        Me.tbCourse1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbAverageSemesterGrade
        '
        Me.lbAverageSemesterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAverageSemesterGrade.Location = New System.Drawing.Point(302, 283)
        Me.lbAverageSemesterGrade.Name = "lbAverageSemesterGrade"
        Me.lbAverageSemesterGrade.Size = New System.Drawing.Size(100, 22)
        Me.lbAverageSemesterGrade.TabIndex = 14
        Me.lbAverageSemesterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbCourse6SemesterGrade
        '
        Me.lbCourse6SemesterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourse6SemesterGrade.Location = New System.Drawing.Point(302, 238)
        Me.lbCourse6SemesterGrade.Name = "lbCourse6SemesterGrade"
        Me.lbCourse6SemesterGrade.Size = New System.Drawing.Size(100, 22)
        Me.lbCourse6SemesterGrade.TabIndex = 12
        Me.lbCourse6SemesterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbCourse5SemesterGrade
        '
        Me.lbCourse5SemesterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourse5SemesterGrade.Location = New System.Drawing.Point(302, 193)
        Me.lbCourse5SemesterGrade.Name = "lbCourse5SemesterGrade"
        Me.lbCourse5SemesterGrade.Size = New System.Drawing.Size(100, 22)
        Me.lbCourse5SemesterGrade.TabIndex = 10
        Me.lbCourse5SemesterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbCourse4SemesterGrade
        '
        Me.lbCourse4SemesterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourse4SemesterGrade.Location = New System.Drawing.Point(302, 148)
        Me.lbCourse4SemesterGrade.Name = "lbCourse4SemesterGrade"
        Me.lbCourse4SemesterGrade.Size = New System.Drawing.Size(100, 20)
        Me.lbCourse4SemesterGrade.TabIndex = 8
        Me.lbCourse4SemesterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbCourse3SemesterGrade
        '
        Me.lbCourse3SemesterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourse3SemesterGrade.Location = New System.Drawing.Point(302, 103)
        Me.lbCourse3SemesterGrade.Name = "lbCourse3SemesterGrade"
        Me.lbCourse3SemesterGrade.Size = New System.Drawing.Size(100, 22)
        Me.lbCourse3SemesterGrade.TabIndex = 6
        Me.lbCourse3SemesterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbCourse2SemesterGrade
        '
        Me.lbCourse2SemesterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourse2SemesterGrade.Location = New System.Drawing.Point(302, 58)
        Me.lbCourse2SemesterGrade.Name = "lbCourse2SemesterGrade"
        Me.lbCourse2SemesterGrade.Size = New System.Drawing.Size(100, 22)
        Me.lbCourse2SemesterGrade.TabIndex = 4
        Me.lbCourse2SemesterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbCourse1SemesterGrade
        '
        Me.lbCourse1SemesterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourse1SemesterGrade.Location = New System.Drawing.Point(302, 13)
        Me.lbCourse1SemesterGrade.Name = "lbCourse1SemesterGrade"
        Me.lbCourse1SemesterGrade.Size = New System.Drawing.Size(100, 22)
        Me.lbCourse1SemesterGrade.TabIndex = 2
        Me.lbCourse1SemesterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbSemester
        '
        Me.lbSemester.Location = New System.Drawing.Point(71, 283)
        Me.lbSemester.Name = "lbSemester"
        Me.lbSemester.Size = New System.Drawing.Size(100, 22)
        Me.lbSemester.TabIndex = 44
        Me.lbSemester.Text = "Semester:"
        Me.lbSemester.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourse6
        '
        Me.lbCourse6.Location = New System.Drawing.Point(71, 238)
        Me.lbCourse6.Name = "lbCourse6"
        Me.lbCourse6.Size = New System.Drawing.Size(100, 22)
        Me.lbCourse6.TabIndex = 41
        Me.lbCourse6.Text = "Course  6:"
        Me.lbCourse6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourse5
        '
        Me.lbCourse5.Location = New System.Drawing.Point(71, 193)
        Me.lbCourse5.Name = "lbCourse5"
        Me.lbCourse5.Size = New System.Drawing.Size(100, 22)
        Me.lbCourse5.TabIndex = 38
        Me.lbCourse5.Text = "Course  5:"
        Me.lbCourse5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourse4
        '
        Me.lbCourse4.Location = New System.Drawing.Point(71, 148)
        Me.lbCourse4.Name = "lbCourse4"
        Me.lbCourse4.Size = New System.Drawing.Size(100, 22)
        Me.lbCourse4.TabIndex = 35
        Me.lbCourse4.Text = "Course  4:"
        Me.lbCourse4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourse3
        '
        Me.lbCourse3.Location = New System.Drawing.Point(71, 103)
        Me.lbCourse3.Name = "lbCourse3"
        Me.lbCourse3.Size = New System.Drawing.Size(100, 22)
        Me.lbCourse3.TabIndex = 32
        Me.lbCourse3.Text = "Course  3:"
        Me.lbCourse3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourse2
        '
        Me.lbCourse2.Location = New System.Drawing.Point(71, 58)
        Me.lbCourse2.Name = "lbCourse2"
        Me.lbCourse2.Size = New System.Drawing.Size(100, 22)
        Me.lbCourse2.TabIndex = 29
        Me.lbCourse2.Text = "Course  2:"
        Me.lbCourse2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCouuser1
        '
        Me.lbCouuser1.Location = New System.Drawing.Point(71, 13)
        Me.lbCouuser1.Name = "lbCouuser1"
        Me.lbCouuser1.Size = New System.Drawing.Size(100, 22)
        Me.lbCouuser1.TabIndex = 26
        Me.lbCouuser1.Text = "Course  1:"
        Me.lbCouuser1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmSemesterAverage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(525, 660)
        Me.Controls.Add(Me.lbResult)
        Me.Controls.Add(Me.lbSemesterAverageMarks)
        Me.Controls.Add(Me.lbSemesterAverage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.tbCourse6)
        Me.Controls.Add(Me.tbCourse5)
        Me.Controls.Add(Me.tbCourse4)
        Me.Controls.Add(Me.tbCourse3)
        Me.Controls.Add(Me.tbCourse2)
        Me.Controls.Add(Me.tbCourse1)
        Me.Controls.Add(Me.lbAverageSemesterGrade)
        Me.Controls.Add(Me.lbCourse6SemesterGrade)
        Me.Controls.Add(Me.lbCourse5SemesterGrade)
        Me.Controls.Add(Me.lbCourse4SemesterGrade)
        Me.Controls.Add(Me.lbCourse3SemesterGrade)
        Me.Controls.Add(Me.lbCourse2SemesterGrade)
        Me.Controls.Add(Me.lbCourse1SemesterGrade)
        Me.Controls.Add(Me.lbSemester)
        Me.Controls.Add(Me.lbCourse6)
        Me.Controls.Add(Me.lbCourse5)
        Me.Controls.Add(Me.lbCourse4)
        Me.Controls.Add(Me.lbCourse3)
        Me.Controls.Add(Me.lbCourse2)
        Me.Controls.Add(Me.lbCouuser1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSemesterAverage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbResult As Label
    Friend WithEvents lbSemesterAverageMarks As Label
    Friend WithEvents lbSemesterAverage As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents tbCourse6 As TextBox
    Friend WithEvents tbCourse5 As TextBox
    Friend WithEvents tbCourse4 As TextBox
    Friend WithEvents tbCourse3 As TextBox
    Friend WithEvents tbCourse2 As TextBox
    Friend WithEvents tbCourse1 As TextBox
    Friend WithEvents lbAverageSemesterGrade As Label
    Friend WithEvents lbCourse6SemesterGrade As Label
    Friend WithEvents lbCourse5SemesterGrade As Label
    Friend WithEvents lbCourse4SemesterGrade As Label
    Friend WithEvents lbCourse3SemesterGrade As Label
    Friend WithEvents lbCourse2SemesterGrade As Label
    Friend WithEvents lbCourse1SemesterGrade As Label
    Friend WithEvents lbSemester As Label
    Friend WithEvents lbCourse6 As Label
    Friend WithEvents lbCourse5 As Label
    Friend WithEvents lbCourse4 As Label
    Friend WithEvents lbCourse3 As Label
    Friend WithEvents lbCourse2 As Label
    Friend WithEvents lbCouuser1 As Label
End Class
