<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        components = New ComponentModel.Container()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitHub = New TextBox()
        btnStopwatch = New Button()
        btnSubmit = New Button()
        Timer1 = New Timer(components)
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lblStopwatch = New TextBox()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Location = New Point(313, 90)
        txtName.Name = "txtName"
        txtName.Size = New Size(286, 27)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Location = New Point(313, 144)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(286, 27)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhone
        ' 
        txtPhone.BorderStyle = BorderStyle.FixedSingle
        txtPhone.Location = New Point(313, 206)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(286, 27)
        txtPhone.TabIndex = 2
        ' 
        ' txtGitHub
        ' 
        txtGitHub.BorderStyle = BorderStyle.FixedSingle
        txtGitHub.Location = New Point(313, 282)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.Size = New Size(286, 27)
        txtGitHub.TabIndex = 3
        ' 
        ' btnStopwatch
        ' 
        btnStopwatch.BackColor = Color.Yellow
        btnStopwatch.BackgroundImageLayout = ImageLayout.Center
        btnStopwatch.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnStopwatch.FlatAppearance.MouseDownBackColor = Color.White
        btnStopwatch.FlatStyle = FlatStyle.Flat
        btnStopwatch.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStopwatch.Location = New Point(130, 337)
        btnStopwatch.Margin = New Padding(0)
        btnStopwatch.Name = "btnStopwatch"
        btnStopwatch.Size = New Size(270, 33)
        btnStopwatch.TabIndex = 4
        btnStopwatch.Text = "TOGGLE STOPWATCH(CTRL+T)"
        btnStopwatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = SystemColors.ActiveCaption
        btnSubmit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.Location = New Point(120, 399)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(469, 39)
        btnSubmit.TabIndex = 5
        btnSubmit.Text = "SUBMIT(CTRL+S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(166, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 28)
        Label1.TabIndex = 6
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(167, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 28)
        Label2.TabIndex = 7
        Label2.Text = "Email:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(155, 201)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 28)
        Label3.TabIndex = 8
        Label3.Text = "PhoneNo:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.FlatStyle = FlatStyle.Flat
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(107, 250)
        Label4.MinimumSize = New Size(200, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(200, 59)
        Label4.TabIndex = 9
        Label4.Text = "Github Link" & vbCrLf & "For Task 2" & vbCrLf
        Label4.TextAlign = ContentAlignment.TopCenter
        Label4.UseCompatibleTextRendering = True
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.BackColor = Color.Silver
        lblStopwatch.BorderStyle = BorderStyle.FixedSingle
        lblStopwatch.Location = New Point(416, 337)
        lblStopwatch.Margin = New Padding(3, 10, 3, 3)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.ScrollBars = ScrollBars.Horizontal
        lblStopwatch.ShortcutsEnabled = False
        lblStopwatch.Size = New Size(183, 27)
        lblStopwatch.TabIndex = 10
        lblStopwatch.Text = "00:00:00"
        lblStopwatch.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 12F)
        TextBox1.Location = New Point(155, 25)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(499, 27)
        TextBox1.TabIndex = 11
        TextBox1.Text = "Dendukuri Narendra varma Task-2 Create submission"
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox1)
        Controls.Add(lblStopwatch)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSubmit)
        Controls.Add(btnStopwatch)
        Controls.Add(txtGitHub)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        KeyPreview = True
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents btnStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblStopwatch As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
