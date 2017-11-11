Public Class answersForm
    Protected db As New db
    Protected question_id As Integer
    'Protected answer_id As Integer

    Public Sub New(ByRef qid As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        question_id = qid
    End Sub

    Protected Sub LoadAnswers()
        db.sql = "Select * FROM answers where question_id = @question_id"
        db.bind("@question_id", question_id)
        db.fill(dgvAnswers)
    End Sub

    Private Sub AsdfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsdfToolStripMenuItem.Click
        LoadAnswers()

    End Sub

    Private Sub answersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAnswers()
    End Sub

    Private Sub CreateAnswerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateAnswerToolStripMenuItem.Click
        Dim createAnswer As New frmCreateAnswer(question_id)
        createAnswer.ShowDialog()
        LoadAnswers()

    End Sub

    Private Sub UpdateAnswerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAnswerToolStripMenuItem.Click
        Dim update As New UpdateAnswer(getAnswerID(), getAnswerValue("answer"))
        update.showdialog()
        LoadAnswers()

    End Sub
    Public Function getAnswerId() As Integer
        Return getAnswerValue("id")
    End Function

    Public Function getAnswerValue(ByVal column As String)
        Return dgvAnswers.Item(column, dgvAnswers.CurrentRow.Index).Value
    End Function

    Private Sub DeleteAnswerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAnswerToolStripMenuItem.Click
        Dim confirm As Integer = MessageBox.Show("You sure you want to delete?", "Delete", MessageBoxButtons.YesNoCancel)
        If confirm = DialogResult.Yes Then
            db.sql = "DELETE FROM answers WHERE id = @answer_id"
            db.bind("@answer_id", getAnswerID)
            db.execute()
            LoadAnswers()
        End If
        Me.Dispose()

    End Sub
End Class