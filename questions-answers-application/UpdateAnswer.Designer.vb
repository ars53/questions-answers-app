<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateAnswer
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
        Me.tbUpdateAnswer = New System.Windows.Forms.TextBox()
        Me.btnUpdateAnswerSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbUpdateAnswer
        '
        Me.tbUpdateAnswer.Location = New System.Drawing.Point(12, 12)
        Me.tbUpdateAnswer.Multiline = True
        Me.tbUpdateAnswer.Name = "tbUpdateAnswer"
        Me.tbUpdateAnswer.Size = New System.Drawing.Size(504, 328)
        Me.tbUpdateAnswer.TabIndex = 3
        '
        'btnUpdateAnswerSubmit
        '
        Me.btnUpdateAnswerSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateAnswerSubmit.Location = New System.Drawing.Point(12, 346)
        Me.btnUpdateAnswerSubmit.Name = "btnUpdateAnswerSubmit"
        Me.btnUpdateAnswerSubmit.Size = New System.Drawing.Size(504, 104)
        Me.btnUpdateAnswerSubmit.TabIndex = 2
        Me.btnUpdateAnswerSubmit.Text = "Submit"
        Me.btnUpdateAnswerSubmit.UseVisualStyleBackColor = True
        '
        'UpdateAnswer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 465)
        Me.Controls.Add(Me.tbUpdateAnswer)
        Me.Controls.Add(Me.btnUpdateAnswerSubmit)
        Me.Name = "UpdateAnswer"
        Me.Text = "Update Answer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbUpdateAnswer As TextBox
    Friend WithEvents btnUpdateAnswerSubmit As Button
End Class
