<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lbResult = New System.Windows.Forms.Label()
        Me.tbWeekDataEntry = New System.Windows.Forms.TextBox()
        Me.lbDays = New System.Windows.Forms.Label()
        Me.tbUnitsInput = New System.Windows.Forms.TextBox()
        Me.lbUnits = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(263, 358)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 30)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(143, 358)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 30)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(17, 358)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(100, 30)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lbResult
        '
        Me.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbResult.Location = New System.Drawing.Point(34, 294)
        Me.lbResult.Name = "lbResult"
        Me.lbResult.Size = New System.Drawing.Size(329, 30)
        Me.lbResult.TabIndex = 12
        Me.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbWeekDataEntry
        '
        Me.tbWeekDataEntry.Location = New System.Drawing.Point(80, 77)
        Me.tbWeekDataEntry.Multiline = True
        Me.tbWeekDataEntry.Name = "tbWeekDataEntry"
        Me.tbWeekDataEntry.Size = New System.Drawing.Size(250, 200)
        Me.tbWeekDataEntry.TabIndex = 11
        '
        'lbDays
        '
        Me.lbDays.Location = New System.Drawing.Point(244, 40)
        Me.lbDays.Name = "lbDays"
        Me.lbDays.Size = New System.Drawing.Size(51, 17)
        Me.lbDays.TabIndex = 10
        Me.lbDays.Text = "&Day 1:"
        Me.lbDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbUnitsInput
        '
        Me.tbUnitsInput.Location = New System.Drawing.Point(117, 40)
        Me.tbUnitsInput.Name = "tbUnitsInput"
        Me.tbUnitsInput.Size = New System.Drawing.Size(108, 22)
        Me.tbUnitsInput.TabIndex = 9
        '
        'lbUnits
        '
        Me.lbUnits.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lbUnits.Location = New System.Drawing.Point(31, 37)
        Me.lbUnits.Name = "lbUnits"
        Me.lbUnits.Size = New System.Drawing.Size(80, 23)
        Me.lbUnits.TabIndex = 8
        Me.lbUnits.Text = "&Units:"
        Me.lbUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 425)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lbResult)
        Me.Controls.Add(Me.tbWeekDataEntry)
        Me.Controls.Add(Me.lbDays)
        Me.Controls.Add(Me.tbUnitsInput)
        Me.Controls.Add(Me.lbUnits)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents lbResult As Label
    Friend WithEvents tbWeekDataEntry As TextBox
    Friend WithEvents lbDays As Label
    Friend WithEvents tbUnitsInput As TextBox
    Friend WithEvents lbUnits As Label
End Class
