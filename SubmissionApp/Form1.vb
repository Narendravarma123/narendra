Public Class Form1
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' Enable KeyPreview to allow form to receive key events before controls
        Me.KeyPreview = True
    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.N Then
            Dim createForm As New CreateSubmissionForm()
            createForm.Show()
            e.Handled = True ' Prevent further processing of the key event
        ElseIf e.Control AndAlso e.KeyCode = Keys.V Then
            Dim viewForm As New ViewSubmissionsForm()
            viewForm.Show()
            e.Handled = True ' Prevent further processing of the key event
        End If
    End Sub
End Class
