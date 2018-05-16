<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginFormScreen
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginFormScreen))
        Me.PictureBoxMeClose = New System.Windows.Forms.PictureBox()
        Me.PictureBoxMeMinimized = New System.Windows.Forms.PictureBox()
        Me.PictureBoxMeInfo = New System.Windows.Forms.PictureBox()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.LabelMeNews = New System.Windows.Forms.Label()
        Me.PictureBoxLogin = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxMeClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMeMinimized, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMeInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxMeClose
        '
        Me.PictureBoxMeClose.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxMeClose.BackgroundImage = Global.Launcher.My.Resources.Resources.Close_BTN_NoCklick
        resources.ApplyResources(Me.PictureBoxMeClose, "PictureBoxMeClose")
        Me.PictureBoxMeClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxMeClose.Name = "PictureBoxMeClose"
        Me.PictureBoxMeClose.TabStop = False
        '
        'PictureBoxMeMinimized
        '
        Me.PictureBoxMeMinimized.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxMeMinimized.BackgroundImage = Global.Launcher.My.Resources.Resources.Minimized_BTN_NoCklick
        resources.ApplyResources(Me.PictureBoxMeMinimized, "PictureBoxMeMinimized")
        Me.PictureBoxMeMinimized.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxMeMinimized.Name = "PictureBoxMeMinimized"
        Me.PictureBoxMeMinimized.TabStop = False
        '
        'PictureBoxMeInfo
        '
        Me.PictureBoxMeInfo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxMeInfo.BackgroundImage = Global.Launcher.My.Resources.Resources.Info_BTN_NoCklick
        resources.ApplyResources(Me.PictureBoxMeInfo, "PictureBoxMeInfo")
        Me.PictureBoxMeInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxMeInfo.Name = "PictureBoxMeInfo"
        Me.PictureBoxMeInfo.TabStop = False
        '
        'TextBoxUsername
        '
        resources.ApplyResources(Me.TextBoxUsername, "TextBoxUsername")
        Me.TextBoxUsername.Name = "TextBoxUsername"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Name = "Label1"
        '
        'TextBoxPassword
        '
        resources.ApplyResources(Me.TextBoxPassword, "TextBoxPassword")
        Me.TextBoxPassword.Name = "TextBoxPassword"
        '
        'LabelMeNews
        '
        Me.LabelMeNews.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.LabelMeNews, "LabelMeNews")
        Me.LabelMeNews.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelMeNews.Name = "LabelMeNews"
        '
        'PictureBoxLogin
        '
        Me.PictureBoxLogin.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogin.BackgroundImage = Global.Launcher.My.Resources.Resources.Login_BTN_NoClick
        resources.ApplyResources(Me.PictureBoxLogin, "PictureBoxLogin")
        Me.PictureBoxLogin.Name = "PictureBoxLogin"
        Me.PictureBoxLogin.TabStop = False
        '
        'LoginFormScreen
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBoxLogin)
        Me.Controls.Add(Me.LabelMeNews)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.PictureBoxMeInfo)
        Me.Controls.Add(Me.PictureBoxMeClose)
        Me.Controls.Add(Me.PictureBoxMeMinimized)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginFormScreen"
        CType(Me.PictureBoxMeClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMeMinimized, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMeInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBoxMeMinimized As PictureBox
    Friend WithEvents PictureBoxMeClose As PictureBox
    Friend WithEvents PictureBoxMeInfo As PictureBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelMeNews As Label
    Friend WithEvents PictureBoxLogin As PictureBox
    Friend WithEvents TextBoxPassword As TextBox
End Class
