Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text.Json
Imports System.Diagnostics

Public Class ViewSubmissionsForm
    Private submissions As List(Of Submission)
    Private currentIndex As Integer = -1

    Public Sub New()
        InitializeComponent()
        FetchAllSubmissions()

        ' Enable KeyPreview to allow form to receive key events before controls
        Me.KeyPreview = True
    End Sub

    Private Async Sub FetchAllSubmissions()
        submissions = Await FetchSubmissionsFromBackend()

        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            ' Sort submissions by timestamp
            submissions = submissions.OrderBy(Function(s) s.Timestamp).ToList()


            ' Set the current index to the first submission
            currentIndex = 0
            DisplayCurrentSubmission()
        End If
    End Sub

    Private Sub DisplayCurrentSubmission()
        If currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            Dim currentSubmission = submissions(currentIndex)
            Debug.WriteLine(currentSubmission
                            )
            Debug.WriteLine($"ID: {currentSubmission.Id}")


            lblName.Text = currentSubmission.Name
            lblEmail.Text = currentSubmission.Email
            lblPhone.Text = currentSubmission.Phone
            lblGit.Text = currentSubmission.GitHub
            lblStop.Text = currentSubmission.Time



            ' Debug output of the current submission
            Debug.WriteLine($"Name: {currentSubmission.Name}")
            Debug.WriteLine($"Email: {currentSubmission.Email}")
            Debug.WriteLine($"Phone: {currentSubmission.Phone}")
            Debug.WriteLine($"GitHub: {currentSubmission.GitHub}")
            Debug.WriteLine($"Time: {currentSubmission.Time}")
            Debug.WriteLine($"Timestamp: {currentSubmission.Timestamp}")

            ' Optionally, you can also log to Console for testing
            Console.WriteLine($"Name: {currentSubmission.Name}, Email: {currentSubmission.Email}, Phone: {currentSubmission.Phone}, GitHub: {currentSubmission.GitHub}, Time: {currentSubmission.Time}, Timestamp: {currentSubmission.Timestamp}")
        Else
            ClearLabels()
        End If
    End Sub

    Private Sub ClearLabels()
        lblName.Text = ""
        lblEmail.Text = ""
        lblPhone.Text = ""
        lblGit.Text = ""
        lblTime.Text = ""
        lblStop.Text = ""
    End Sub

    Private Async Function FetchSubmissionsFromBackend() As Task(Of List(Of Submission))
        Try
            Using client As New HttpClient()
                client.BaseAddress = New Uri("http://localhost:3000")

                ' Clear default headers and add application/json accept header
                client.DefaultRequestHeaders.Accept.Clear()
                client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

                ' Send GET request
                Dim response As HttpResponseMessage = Await client.GetAsync("/read")

                ' Check response status
                If response.IsSuccessStatusCode Then
                    Dim jsonString As String = Await response.Content.ReadAsStringAsync()

                    ' Debug output of JSON string received
                    Debug.WriteLine($"Received JSON: {jsonString}")

                    ' Deserialize JSON to List(Of Submission)
                    Dim submissions As List(Of Submission) = JsonSerializer.Deserialize(Of List(Of Submission))(jsonString)

                    ' Debug output of the submissions list
                    For Each submission In submissions
                        Debug.WriteLine(submission)
                    Next

                    Return submissions
                Else
                    Console.WriteLine($"Failed to fetch submissions. Status code: {response.StatusCode}")
                    Return Nothing
                End If
            End Using
        Catch ex As Exception
            Console.WriteLine("Error fetching submissions from backend: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplayCurrentSubmission()
        Else
            MessageBox.Show("You have reached the end of the submissions ", "End of Submissions", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplayCurrentSubmission()
        Else
            MessageBox.Show("You have reached the beginning of the submissions.", "Beginning of Submissions", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
            e.Handled = True ' Prevent further processing of the key event
        ElseIf e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
            e.Handled = True ' Prevent further processing of the key event
        End If
    End Sub


End Class