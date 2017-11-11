Public Class UpdateAnswer
    Protected question_id As Integer
    Protected answer_id As Integer
    Protected db As New db
    Public Sub New(ByVal aid As Integer, ByVal answer As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        answer_id = aid

        tbUpdateAnswer.Text = answer
    End Sub

    Private Sub btnUpdateAnswerSubmit_Click(sender As Object, e As EventArgs) Handles btnUpdateAnswerSubmit.Click
        db.sql = "UPDATE answers SET answer = @answer WHERE id = @answer_id"
        db.bind("@answer_id", answer_id)
        db.bind("@answer", tbUpdateAnswer.Text)
        db.execute()
        Me.Dispose()

    End Sub
End Class