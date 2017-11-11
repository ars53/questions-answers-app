<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateAnswer
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
        Me.btnQuestionSubmit = New System.Windows.Forms.Button()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.tbQuestID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnQuestionSubmit
        '
        Me.btnQuestionSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuestionSubmit.Location = New System.Drawing.Point(12, 232)
        Me.btnQuestionSubmit.Name = "btnQuestionSubmit"
        Me.btnQuestionSubmit.Size = New System.Drawing.Size(546, 107)
        Me.btnQuestionSubmit.TabIndex = 3
        Me.btnQuestionSubmit.Text = "Submit"
        Me.btnQuestionSubmit.UseVisualStyleBackColor = True
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(12, 12)
        Me.txtAnswer.Multiline = True
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(546, 174)
        Me.txtAnswer.TabIndex = 2
        '
        'tbQuestID
        '
        Me.tbQuestID.Location = New System.Drawing.Point(227, 193)
        Me.tbQuestID.Name = "tbQuestID"
        Me.tbQuestID.Size = New System.Drawing.Size(100, 20)
        Me.tbQuestID.TabIndex = 4
        Me.tbQuestID.Text = "Question ID"
        '
        'frmCreateAnswer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 351)
        Me.Controls.Add(Me.tbQuestID)
        Me.Controls.Add(Me.btnQuestionSubmit)
        Me.Controls.Add(Me.txtAnswer)
        Me.Name = "frmCreateAnswer"
        Me.Text = "Create Answer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnQuestionSubmit As Button
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents tbQuestID As TextBox
End Class
