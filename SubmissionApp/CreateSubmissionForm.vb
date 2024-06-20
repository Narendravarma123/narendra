Imports System.Diagnostics
Imports System.Net.Http
Imports System.Text
Imports System.Text.Json

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()
    Private WithEvents timer As New Timer()

    Private ReadOnly baseURL As String = "http://localhost:3000" ' Replace with your server URL

    Public Sub New()
        InitializeComponent()
        InitializeTimer()

        ' Enable KeyPreview to allow form to receive key events before controls
        Me.KeyPreview = True
    End Sub

    Private Sub InitializeTimer()
        timer.Interval = 1000 ' Interval in milliseconds (1 second)
        AddHandler timer.Tick, AddressOf Timer_Tick
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        lblStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub btnStopwatch_Click(sender As Object, e As EventArgs) Handles btnStopwatch.Click
        ToggleStopwatch()
    End Sub

    Private Sub ToggleStopwatch()
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            timer.Stop() ' Stop the timer when stopwatch is paused
            btnStopwatch.Text = "Resume"
        Else
            stopwatch.Start()
            timer.Start() ' Start the timer when stopwatch is running
            btnStopwatch.Text = "Pause"
        End If
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Create timestamp
        Dim timestamp As DateTime = DateTime.UtcNow

        ' Create a new Submission object
        Dim submission As New Submission(txtName.Text, txtEmail.Text, txtPhone.Text, txtGitHub.Text, lblStopwatch.Text, timestamp)

        ' Send submission data to backend
        Dim success As Boolean = Await SendSubmissionToBackend(submission)

        If success Then
            ' Show submission saved message
            MessageBox.Show("Submission saved successfully!")

            ' Optionally, clear input fields and reset stopwatch
            txtName.Text = ""
            txtEmail.Text = ""
            txtPhone.Text = ""
            txtGitHub.Text = ""
            stopwatch.Reset()
            lblStopwatch.Text = "00:00:00"
        Else
            MessageBox.Show("Failed to save submission. Please try again.")
        End If
    End Sub

    Private Async Function SendSubmissionToBackend(submission As Submission) As Task(Of Boolean)
        Try
            Using client As New HttpClient()
                client.BaseAddress = New Uri(baseURL)
                client.DefaultRequestHeaders.Accept.Clear()
                client.DefaultRequestHeaders.Accept.Add(New Headers.MediaTypeWithQualityHeaderValue("application/json"))

                ' Send POST request with JSON body
                Dim json As String = JsonSerializer.Serialize(submission)
                Dim content As New StringContent(json, Encoding.UTF8, "application/json")

                Dim response As HttpResponseMessage = Await client.PostAsync("/submit", content)

                ' Check response status
                Return response.IsSuccessStatusCode
            End Using
        Catch ex As Exception
            Console.WriteLine("Error sending submission to backend: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            ToggleStopwatch()
        End If
    End Sub

    Private Sub CreateSubmissionForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ensure timer is stopped and resources are released when form closes
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        End If
        timer.Dispose()
    End Sub
End Class

Public Class Submission
    Public Property Id As String ' Use appropriate data type (e.g., Integer, String) based on your backend ID generation
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GitHub As String
    Public Property Time As String ' Assuming this is the stopwatch time string
    Public Property Timestamp As DateTime ' Ensure the Timestamp property matches the format in JSON

    ' Default constructor
    Public Sub New()
    End Sub

    ' Constructor with parameters
    Public Sub New(name As String, email As String, phone As String, github As String, time As String, timestamp As DateTime)
        Me.Name = name
        Me.Email = email
        Me.Phone = phone
        Me.GitHub = github
        Me.Time = time
        Me.Timestamp = timestamp
    End Sub
End Class
