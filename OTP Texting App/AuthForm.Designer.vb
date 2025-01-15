<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuthForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AuthForm))
        wvAuth = New Microsoft.Web.WebView2.WinForms.WebView2()
        CType(wvAuth, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' wvAuth
        ' 
        wvAuth.AllowExternalDrop = True
        wvAuth.CreationProperties = Nothing
        wvAuth.DefaultBackgroundColor = Color.White
        wvAuth.Location = New Point(12, 12)
        wvAuth.Name = "wvAuth"
        wvAuth.Size = New Size(606, 518)
        wvAuth.TabIndex = 0
        wvAuth.ZoomFactor = 1R
        ' 
        ' AuthForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(630, 542)
        Controls.Add(wvAuth)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "AuthForm"
        Text = "RingCentral Authorization"
        CType(wvAuth, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents wvAuth As Microsoft.Web.WebView2.WinForms.WebView2
End Class
