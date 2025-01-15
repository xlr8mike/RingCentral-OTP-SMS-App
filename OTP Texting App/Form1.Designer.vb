<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txtToPhoneNumber = New TextBox()
        btnSendOtp = New Button()
        lblOtpSent = New Label()
        lblSentTo = New Label()
        btnAuthorize = New Button()
        GroupBox1 = New GroupBox()
        lblAuthorized = New Label()
        lblTokenCounter = New Label()
        GroupBox2 = New GroupBox()
        lblFromPhoneNumber = New Label()
        lblSuccessMessage = New Label()
        lblFromNumberTitle = New Label()
        lblToPhoneNumber = New Label()
        GroupBox3 = New GroupBox()
        lblLastSent = New Label()
        lblLastSentTitle = New Label()
        txtCurrentOTP = New TextBox()
        GroupBox4 = New GroupBox()
        pbCountdown = New ProgressBar()
        lblCountdown = New Label()
        lblOPTCodeTitle = New Label()
        hideSuccessMessageTimer = New Timer(components)
        lblDescription = New Label()
        lblCreator = New Label()
        pbLogo = New PictureBox()
        GroupBox5 = New GroupBox()
        Label1 = New Label()
        btnEditMessage = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox5.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtToPhoneNumber
        ' 
        txtToPhoneNumber.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        txtToPhoneNumber.ForeColor = Color.White
        txtToPhoneNumber.Location = New Point(121, 36)
        txtToPhoneNumber.Name = "txtToPhoneNumber"
        txtToPhoneNumber.Size = New Size(106, 23)
        txtToPhoneNumber.TabIndex = 2
        ' 
        ' btnSendOtp
        ' 
        btnSendOtp.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btnSendOtp.ForeColor = Color.White
        btnSendOtp.Location = New Point(6, 70)
        btnSendOtp.Name = "btnSendOtp"
        btnSendOtp.Size = New Size(221, 45)
        btnSendOtp.TabIndex = 3
        btnSendOtp.Text = "Send OTP Code!"
        btnSendOtp.UseVisualStyleBackColor = False
        ' 
        ' lblOtpSent
        ' 
        lblOtpSent.AutoSize = True
        lblOtpSent.ForeColor = Color.LightGray
        lblOtpSent.Location = New Point(6, 19)
        lblOtpSent.Name = "lblOtpSent"
        lblOtpSent.Size = New Size(91, 15)
        lblOtpSent.TabIndex = 2
        lblOtpSent.Text = "OTP Code Sent: "
        ' 
        ' lblSentTo
        ' 
        lblSentTo.AutoSize = True
        lblSentTo.ForeColor = Color.LightGray
        lblSentTo.Location = New Point(6, 34)
        lblSentTo.Name = "lblSentTo"
        lblSentTo.Size = New Size(47, 15)
        lblSentTo.TabIndex = 3
        lblSentTo.Text = "Sent to:"
        ' 
        ' btnAuthorize
        ' 
        btnAuthorize.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btnAuthorize.Dock = DockStyle.Top
        btnAuthorize.ForeColor = Color.White
        btnAuthorize.Location = New Point(3, 19)
        btnAuthorize.Name = "btnAuthorize"
        btnAuthorize.Size = New Size(360, 47)
        btnAuthorize.TabIndex = 4
        btnAuthorize.TabStop = False
        btnAuthorize.Text = "Authorize with your RingCentral Account"
        btnAuthorize.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        GroupBox1.Controls.Add(lblAuthorized)
        GroupBox1.Controls.Add(lblTokenCounter)
        GroupBox1.Controls.Add(btnAuthorize)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(19, 79)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(366, 108)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Authorization"
        ' 
        ' lblAuthorized
        ' 
        lblAuthorized.BackColor = Color.Red
        lblAuthorized.Dock = DockStyle.Bottom
        lblAuthorized.ForeColor = Color.Black
        lblAuthorized.Location = New Point(3, 75)
        lblAuthorized.Name = "lblAuthorized"
        lblAuthorized.Size = New Size(360, 15)
        lblAuthorized.TabIndex = 7
        lblAuthorized.Text = "Not Authorized"
        lblAuthorized.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTokenCounter
        ' 
        lblTokenCounter.BackColor = Color.Transparent
        lblTokenCounter.Dock = DockStyle.Bottom
        lblTokenCounter.ForeColor = Color.White
        lblTokenCounter.Location = New Point(3, 90)
        lblTokenCounter.Name = "lblTokenCounter"
        lblTokenCounter.Size = New Size(360, 15)
        lblTokenCounter.TabIndex = 6
        lblTokenCounter.Text = "Waiting for Authorization"
        lblTokenCounter.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        GroupBox2.Controls.Add(lblFromPhoneNumber)
        GroupBox2.Controls.Add(lblSuccessMessage)
        GroupBox2.Controls.Add(lblFromNumberTitle)
        GroupBox2.Controls.Add(lblToPhoneNumber)
        GroupBox2.Controls.Add(btnSendOtp)
        GroupBox2.Controls.Add(txtToPhoneNumber)
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(15, 191)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(232, 136)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "Texting"
        ' 
        ' lblFromPhoneNumber
        ' 
        lblFromPhoneNumber.AutoSize = True
        lblFromPhoneNumber.Location = New Point(133, 18)
        lblFromPhoneNumber.Name = "lblFromPhoneNumber"
        lblFromPhoneNumber.Size = New Size(94, 15)
        lblFromPhoneNumber.TabIndex = 13
        lblFromPhoneNumber.Text = "Please Authorize"
        ' 
        ' lblSuccessMessage
        ' 
        lblSuccessMessage.Dock = DockStyle.Bottom
        lblSuccessMessage.ForeColor = Color.LightGreen
        lblSuccessMessage.Location = New Point(3, 118)
        lblSuccessMessage.Name = "lblSuccessMessage"
        lblSuccessMessage.Size = New Size(226, 15)
        lblSuccessMessage.TabIndex = 12
        lblSuccessMessage.Text = "Placeholder!"
        lblSuccessMessage.TextAlign = ContentAlignment.MiddleCenter
        lblSuccessMessage.Visible = False
        ' 
        ' lblFromNumberTitle
        ' 
        lblFromNumberTitle.AutoSize = True
        lblFromNumberTitle.ForeColor = Color.LightGray
        lblFromNumberTitle.Location = New Point(6, 18)
        lblFromNumberTitle.Name = "lblFromNumberTitle"
        lblFromNumberTitle.Size = New Size(126, 15)
        lblFromNumberTitle.TabIndex = 10
        lblFromNumberTitle.Text = "Texting From Number:"
        ' 
        ' lblToPhoneNumber
        ' 
        lblToPhoneNumber.AutoSize = True
        lblToPhoneNumber.ForeColor = Color.LightGray
        lblToPhoneNumber.Location = New Point(6, 41)
        lblToPhoneNumber.Name = "lblToPhoneNumber"
        lblToPhoneNumber.Size = New Size(110, 15)
        lblToPhoneNumber.TabIndex = 9
        lblToPhoneNumber.Text = "Texting To Number:"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        GroupBox3.Controls.Add(lblLastSent)
        GroupBox3.Controls.Add(lblLastSentTitle)
        GroupBox3.Controls.Add(lblOtpSent)
        GroupBox3.Controls.Add(lblSentTo)
        GroupBox3.ForeColor = Color.White
        GroupBox3.Location = New Point(15, 387)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(375, 58)
        GroupBox3.TabIndex = 9
        GroupBox3.TabStop = False
        GroupBox3.Text = "Info Sent"
        ' 
        ' lblLastSent
        ' 
        lblLastSent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblLastSent.BackColor = Color.Transparent
        lblLastSent.ForeColor = Color.LightGray
        lblLastSent.Location = New Point(245, 34)
        lblLastSent.Name = "lblLastSent"
        lblLastSent.Size = New Size(124, 12)
        lblLastSent.TabIndex = 12
        lblLastSent.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLastSentTitle
        ' 
        lblLastSentTitle.AutoSize = True
        lblLastSentTitle.ForeColor = Color.LightGray
        lblLastSentTitle.Location = New Point(274, 19)
        lblLastSentTitle.Name = "lblLastSentTitle"
        lblLastSentTitle.Size = New Size(72, 15)
        lblLastSentTitle.TabIndex = 12
        lblLastSentTitle.Text = "Last Sent At:"
        ' 
        ' txtCurrentOTP
        ' 
        txtCurrentOTP.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        txtCurrentOTP.Dock = DockStyle.Bottom
        txtCurrentOTP.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCurrentOTP.ForeColor = Color.White
        txtCurrentOTP.Location = New Point(3, 98)
        txtCurrentOTP.Name = "txtCurrentOTP"
        txtCurrentOTP.ReadOnly = True
        txtCurrentOTP.Size = New Size(128, 35)
        txtCurrentOTP.TabIndex = 10
        txtCurrentOTP.TabStop = False
        txtCurrentOTP.Text = "Placeholder"
        txtCurrentOTP.TextAlign = HorizontalAlignment.Center
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        GroupBox4.Controls.Add(pbCountdown)
        GroupBox4.Controls.Add(lblCountdown)
        GroupBox4.Controls.Add(lblOPTCodeTitle)
        GroupBox4.Controls.Add(txtCurrentOTP)
        GroupBox4.ForeColor = Color.White
        GroupBox4.Location = New Point(256, 191)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(134, 136)
        GroupBox4.TabIndex = 11
        GroupBox4.TabStop = False
        GroupBox4.Text = "Current OTP Code"
        ' 
        ' pbCountdown
        ' 
        pbCountdown.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        pbCountdown.Location = New Point(16, 59)
        pbCountdown.Maximum = 30
        pbCountdown.Name = "pbCountdown"
        pbCountdown.Size = New Size(100, 15)
        pbCountdown.Style = ProgressBarStyle.Continuous
        pbCountdown.TabIndex = 12
        pbCountdown.Value = 30
        ' 
        ' lblCountdown
        ' 
        lblCountdown.Dock = DockStyle.Top
        lblCountdown.ForeColor = Color.White
        lblCountdown.Location = New Point(3, 19)
        lblCountdown.Name = "lblCountdown"
        lblCountdown.Size = New Size(128, 31)
        lblCountdown.TabIndex = 12
        lblCountdown.Text = "Placeholder text"
        lblCountdown.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblOPTCodeTitle
        ' 
        lblOPTCodeTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblOPTCodeTitle.ForeColor = Color.LightGray
        lblOPTCodeTitle.Location = New Point(3, 74)
        lblOPTCodeTitle.Name = "lblOPTCodeTitle"
        lblOPTCodeTitle.Size = New Size(128, 21)
        lblOPTCodeTitle.TabIndex = 11
        lblOPTCodeTitle.Text = "Current OTP Code"
        lblOPTCodeTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' hideSuccessMessageTimer
        ' 
        hideSuccessMessageTimer.Interval = 10000
        ' 
        ' lblDescription
        ' 
        lblDescription.ForeColor = Color.LightGray
        lblDescription.Location = New Point(99, 12)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(277, 63)
        lblDescription.TabIndex = 12
        lblDescription.Text = "Welcome to the OTP Texting App! " & vbCrLf & "To get started, authorize your account, enter the recipient's phone number, and click 'Send OTP Code'. " & vbCrLf & "A new OTP code will be generated every 30 seconds."
        lblDescription.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCreator
        ' 
        lblCreator.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lblCreator.AutoSize = True
        lblCreator.ForeColor = Color.LightGray
        lblCreator.Location = New Point(124, 446)
        lblCreator.Name = "lblCreator"
        lblCreator.Size = New Size(266, 15)
        lblCreator.TabIndex = 13
        lblCreator.Text = "Created by Charles Hammer @ Paragon Tech Inc."
        lblCreator.TextAlign = ContentAlignment.BottomRight
        ' 
        ' pbLogo
        ' 
        pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), Image)
        pbLogo.Location = New Point(24, 7)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(69, 68)
        pbLogo.SizeMode = PictureBoxSizeMode.Zoom
        pbLogo.TabIndex = 14
        pbLogo.TabStop = False
        ' 
        ' GroupBox5
        ' 
        GroupBox5.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        GroupBox5.Controls.Add(Label1)
        GroupBox5.Controls.Add(btnEditMessage)
        GroupBox5.ForeColor = Color.White
        GroupBox5.Location = New Point(14, 333)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(375, 48)
        GroupBox5.TabIndex = 15
        GroupBox5.TabStop = False
        GroupBox5.Text = "Edit Text Message"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 8F)
        Label1.ForeColor = Color.LightGray
        Label1.Location = New Point(3, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(264, 32)
        Label1.TabIndex = 17
        Label1.Text = "By default we have a standard message. To edit click the button to the right."
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnEditMessage
        ' 
        btnEditMessage.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btnEditMessage.ForeColor = Color.White
        btnEditMessage.Location = New Point(273, 13)
        btnEditMessage.Name = "btnEditMessage"
        btnEditMessage.Size = New Size(98, 29)
        btnEditMessage.TabIndex = 16
        btnEditMessage.TabStop = False
        btnEditMessage.Text = "Edit Message"
        btnEditMessage.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        ClientSize = New Size(402, 466)
        Controls.Add(GroupBox5)
        Controls.Add(pbLogo)
        Controls.Add(lblCreator)
        Controls.Add(lblDescription)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "OTP Texting App"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        GroupBox5.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtToPhoneNumber As TextBox
    Friend WithEvents btnSendOtp As Button
    Friend WithEvents lblOtpSent As Label
    Friend WithEvents lblSentTo As Label
    Friend WithEvents btnAuthorize As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblToPhoneNumber As Label
    Friend WithEvents lblFromNumberTitle As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtCurrentOTP As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblOPTCodeTitle As Label
    Friend WithEvents lblCountdown As Label
    Friend WithEvents lblSuccessMessage As Label
    Friend WithEvents hideSuccessMessageTimer As Timer
    Friend WithEvents lblTokenCounter As Label
    Friend WithEvents lblLastSent As Label
    Friend WithEvents lblLastSentTitle As Label
    Friend WithEvents pbCountdown As ProgressBar
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblCreator As Label
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents lblFromPhoneNumber As Label
    Friend WithEvents lblAuthorized As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnEditMessage As Button
    Friend WithEvents Label1 As Label
End Class
