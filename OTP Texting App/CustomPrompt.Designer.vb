<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomPrompt
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
        btnYes = New Button()
        btnNo = New Button()
        lblMessage = New Label()
        pbIcon = New PictureBox()
        CType(pbIcon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnYes
        ' 
        btnYes.Location = New Point(186, 80)
        btnYes.Name = "btnYes"
        btnYes.Size = New Size(75, 23)
        btnYes.TabIndex = 1
        btnYes.Text = "Yes"
        btnYes.UseVisualStyleBackColor = True
        ' 
        ' btnNo
        ' 
        btnNo.Location = New Point(338, 80)
        btnNo.Name = "btnNo"
        btnNo.Size = New Size(75, 23)
        btnNo.TabIndex = 2
        btnNo.Text = "No"
        btnNo.UseVisualStyleBackColor = True
        ' 
        ' lblMessage
        ' 
        lblMessage.BackColor = Color.Transparent
        lblMessage.ForeColor = Color.LightGray
        lblMessage.Location = New Point(161, 9)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(277, 63)
        lblMessage.TabIndex = 13
        lblMessage.Text = "*Error Message here*"
        lblMessage.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pbIcon
        ' 
        pbIcon.Image = My.Resources.Resources.WarningIcon
        pbIcon.Location = New Point(48, 23)
        pbIcon.Name = "pbIcon"
        pbIcon.Size = New Size(80, 80)
        pbIcon.SizeMode = PictureBoxSizeMode.Zoom
        pbIcon.TabIndex = 15
        pbIcon.TabStop = False
        ' 
        ' CustomPrompt
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        ClientSize = New Size(451, 124)
        Controls.Add(pbIcon)
        Controls.Add(lblMessage)
        Controls.Add(btnNo)
        Controls.Add(btnYes)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "CustomPrompt"
        StartPosition = FormStartPosition.CenterParent
        Text = "CustomPrompt"
        CType(pbIcon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnYes As Button
    Friend WithEvents btnNo As Button
    Friend WithEvents lblMessage As Label
    Friend WithEvents pbIcon As PictureBox
End Class
