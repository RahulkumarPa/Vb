<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAwesomeness
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
        Me.LblAwesomenessPrompt = New System.Windows.Forms.Label()
        Me.btnYes1 = New System.Windows.Forms.Button()
        Me.btnNo2 = New System.Windows.Forms.Button()
        Me.btnNo3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblAwesomenessPrompt
        '
        Me.LblAwesomenessPrompt.Location = New System.Drawing.Point(52, 27)
        Me.LblAwesomenessPrompt.Name = "LblAwesomenessPrompt"
        Me.LblAwesomenessPrompt.Size = New System.Drawing.Size(254, 56)
        Me.LblAwesomenessPrompt.TabIndex = 0
        Me.LblAwesomenessPrompt.Text = "The computer has detacted its Awesomeness if its true you are Awesomeness."
        Me.LblAwesomenessPrompt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnYes1
        '
        Me.btnYes1.Location = New System.Drawing.Point(53, 149)
        Me.btnYes1.Name = "btnYes1"
        Me.btnYes1.Size = New System.Drawing.Size(75, 41)
        Me.btnYes1.TabIndex = 1
        Me.btnYes1.Text = "&Yes"
        Me.btnYes1.UseVisualStyleBackColor = True
        '
        'btnNo2
        '
        Me.btnNo2.Location = New System.Drawing.Point(143, 149)
        Me.btnNo2.Name = "btnNo2"
        Me.btnNo2.Size = New System.Drawing.Size(75, 41)
        Me.btnNo2.TabIndex = 2
        Me.btnNo2.Text = "&No"
        Me.btnNo2.UseVisualStyleBackColor = True
        '
        'btnNo3
        '
        Me.btnNo3.Location = New System.Drawing.Point(231, 149)
        Me.btnNo3.Name = "btnNo3"
        Me.btnNo3.Size = New System.Drawing.Size(75, 41)
        Me.btnNo3.TabIndex = 0
        Me.btnNo3.Text = "&No"
        Me.btnNo3.UseVisualStyleBackColor = True
        '
        'frmAwesomeness
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 253)
        Me.Controls.Add(Me.btnNo3)
        Me.Controls.Add(Me.btnNo2)
        Me.Controls.Add(Me.btnYes1)
        Me.Controls.Add(Me.LblAwesomenessPrompt)
        Me.Name = "frmAwesomeness"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Awesomeness"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblAwesomenessPrompt As Label
    Friend WithEvents btnYes1 As Button
    Friend WithEvents btnNo2 As Button
    Friend WithEvents btnNo3 As Button
End Class
