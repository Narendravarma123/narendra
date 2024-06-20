<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewSubmissionsForm))
        btnPrevious = New Button()
        btnNext = New Button()
        lblNameLabel = New Label()
        lblEmailLabel = New Label()
        lblPhoneLabel = New Label()
        lblGitHubLabel = New Label()
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        TextBox1 = New TextBox()
        lblStop = New Label()
        lblGit = New Label()
        TextBox2 = New TextBox()
        lblTime = New TextBox()
        lblDelete = New PictureBox()
        lblEdit = New PictureBox()
        CType(lblDelete, ComponentModel.ISupportInitialize).BeginInit()
        CType(lblEdit, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnPrevious.FlatStyle = FlatStyle.Flat
        btnPrevious.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPrevious.Location = New Point(106, 373)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(282, 29)
        btnPrevious.TabIndex = 0
        btnPrevious.Text = "PREVIOUS(CTRL+P)"
        btnPrevious.UseCompatibleTextRendering = True
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.Cyan
        btnNext.FlatStyle = FlatStyle.Flat
        btnNext.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNext.Location = New Point(425, 372)
        btnNext.Margin = New Padding(0)
        btnNext.MinimumSize = New Size(280, 30)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(280, 30)
        btnNext.TabIndex = 1
        btnNext.Text = "NEXT(CTRL+N)"
        btnNext.UseCompatibleTextRendering = True
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' lblNameLabel
        ' 
        lblNameLabel.AutoSize = True
        lblNameLabel.Font = New Font("Segoe UI", 12F)
        lblNameLabel.Location = New Point(153, 98)
        lblNameLabel.Name = "lblNameLabel"
        lblNameLabel.Size = New Size(68, 28)
        lblNameLabel.TabIndex = 2
        lblNameLabel.Text = "Name:"
        ' 
        ' lblEmailLabel
        ' 
        lblEmailLabel.AutoSize = True
        lblEmailLabel.Font = New Font("Segoe UI", 12F)
        lblEmailLabel.Location = New Point(153, 135)
        lblEmailLabel.Name = "lblEmailLabel"
        lblEmailLabel.Size = New Size(63, 28)
        lblEmailLabel.TabIndex = 3
        lblEmailLabel.Text = "Email:"
        ' 
        ' lblPhoneLabel
        ' 
        lblPhoneLabel.AutoSize = True
        lblPhoneLabel.Font = New Font("Segoe UI", 12F)
        lblPhoneLabel.Location = New Point(153, 177)
        lblPhoneLabel.Name = "lblPhoneLabel"
        lblPhoneLabel.Size = New Size(71, 28)
        lblPhoneLabel.TabIndex = 4
        lblPhoneLabel.Text = "Phone:"
        ' 
        ' lblGitHubLabel
        ' 
        lblGitHubLabel.AutoSize = True
        lblGitHubLabel.Font = New Font("Segoe UI", 12F)
        lblGitHubLabel.Location = New Point(144, 216)
        lblGitHubLabel.Name = "lblGitHubLabel"
        lblGitHubLabel.Size = New Size(120, 112)
        lblGitHubLabel.TabIndex = 5
        lblGitHubLabel.Text = "GitHub Link " & vbCrLf & "For Task 2:" & vbCrLf & vbCrLf & vbCrLf
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.BackColor = SystemColors.ActiveBorder
        lblName.BorderStyle = BorderStyle.FixedSingle
        lblName.Font = New Font("Segoe UI", 12F)
        lblName.Location = New Point(342, 98)
        lblName.MinimumSize = New Size(340, 20)
        lblName.Name = "lblName"
        lblName.Size = New Size(340, 30)
        lblName.TabIndex = 7
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.BackColor = SystemColors.ActiveBorder
        lblEmail.BorderStyle = BorderStyle.FixedSingle
        lblEmail.Font = New Font("Segoe UI", 12F)
        lblEmail.Location = New Point(342, 135)
        lblEmail.MinimumSize = New Size(340, 20)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(340, 30)
        lblEmail.TabIndex = 8
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.BackColor = SystemColors.ActiveBorder
        lblPhone.BorderStyle = BorderStyle.FixedSingle
        lblPhone.Font = New Font("Segoe UI", 12F)
        lblPhone.Location = New Point(342, 179)
        lblPhone.MinimumSize = New Size(340, 20)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(340, 30)
        lblPhone.TabIndex = 9
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ButtonFace
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 12F)
        TextBox1.Location = New Point(123, 277)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(141, 27)
        TextBox1.TabIndex = 12
        TextBox1.Text = "Stopwatch time"
        ' 
        ' lblStop
        ' 
        lblStop.AutoSize = True
        lblStop.BackColor = SystemColors.ActiveBorder
        lblStop.BorderStyle = BorderStyle.FixedSingle
        lblStop.Font = New Font("Segoe UI", 12F)
        lblStop.Location = New Point(344, 274)
        lblStop.MinimumSize = New Size(340, 20)
        lblStop.Name = "lblStop"
        lblStop.Size = New Size(340, 30)
        lblStop.TabIndex = 13
        ' 
        ' lblGit
        ' 
        lblGit.AutoSize = True
        lblGit.BackColor = SystemColors.ActiveBorder
        lblGit.BorderStyle = BorderStyle.FixedSingle
        lblGit.Font = New Font("Segoe UI", 12F)
        lblGit.Location = New Point(342, 228)
        lblGit.MinimumSize = New Size(340, 20)
        lblGit.Name = "lblGit"
        lblGit.Size = New Size(340, 30)
        lblGit.TabIndex = 14
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Segoe UI", 14F)
        TextBox2.Location = New Point(106, 27)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(618, 32)
        TextBox2.TabIndex = 15
        TextBox2.Text = "Dendukuri Narendra varma,Slidely Task 2-VIew Submissions"
        ' 
        ' lblTime
        ' 
        lblTime.BorderStyle = BorderStyle.None
        lblTime.Location = New Point(355, 317)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(248, 20)
        lblTime.TabIndex = 11
        lblTime.Visible = False
        ' 
        ' lblDelete
        ' 
        lblDelete.Image = My.Resources.Resources.delete
        lblDelete.InitialImage = CType(resources.GetObject("lblDelete.InitialImage"), Image)
        lblDelete.Location = New Point(702, 137)
        lblDelete.Name = "lblDelete"
        lblDelete.Size = New Size(36, 28)
        lblDelete.SizeMode = PictureBoxSizeMode.StretchImage
        lblDelete.TabIndex = 16
        lblDelete.TabStop = False
        ' 
        ' lblEdit
        ' 
        lblEdit.Image = CType(resources.GetObject("lblEdit.Image"), Image)
        lblEdit.InitialImage = CType(resources.GetObject("lblEdit.InitialImage"), Image)
        lblEdit.Location = New Point(702, 206)
        lblEdit.Name = "lblEdit"
        lblEdit.Size = New Size(36, 34)
        lblEdit.SizeMode = PictureBoxSizeMode.StretchImage
        lblEdit.TabIndex = 17
        lblEdit.TabStop = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = SystemColors.Window
        ClientSize = New Size(800, 450)
        Controls.Add(lblEdit)
        Controls.Add(lblDelete)
        Controls.Add(TextBox2)
        Controls.Add(lblGit)
        Controls.Add(lblStop)
        Controls.Add(TextBox1)
        Controls.Add(lblTime)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(lblGitHubLabel)
        Controls.Add(lblPhoneLabel)
        Controls.Add(lblEmailLabel)
        Controls.Add(lblNameLabel)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        MinimumSize = New Size(250, 20)
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        CType(lblDelete, ComponentModel.ISupportInitialize).EndInit()
        CType(lblEdit, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lblNameLabel As Label
    Friend WithEvents lblEmailLabel As Label
    Friend WithEvents lblPhoneLabel As Label
    Friend WithEvents lblGitHubLabel As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblStop As Label
    Friend WithEvents lblGit As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblTime As TextBox
    Friend WithEvents lblDelete As PictureBox
    Friend WithEvents lblEdit As PictureBox
End Class
