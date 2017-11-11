Public Class frmCreateAnswer
    Protected db As db = New db
    Protected question_id As Integer

    Public Sub New(ByRef qid As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        question_id = qid

        tbQuestID.Text = question_id
    End Sub

    Private Sub btnQuestionSubmit_Click(sender As Object, e As EventArgs) Handles btnQuestionSubmit.Click
        db.sql = "INSERT INTO answers (answer, question_id) VALUES (@answer, @question_id)"
        db.bind("@answer", txtAnswer.Text)
        db.bind("@question_id", tbQuestID.Text)
        db.execute()
        Me.Dispose()

    End Sub
End Class