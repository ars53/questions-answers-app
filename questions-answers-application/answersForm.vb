Public Class answersForm
    Protected db As New db
    Protected question_id As Integer

    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' question_id = id
    End Sub

    Protected Sub LoadAnswers()
        db.sql = "Select * FROM answers where question_id = @question_id"
        ''db.bind("@question_id", id)
        db.fill(dgvAnswers)
    End Sub
    Private Sub LoadAnswersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsdfToolStripMenuItem.Click

    End Sub
End Class