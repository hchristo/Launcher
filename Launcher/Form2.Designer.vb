<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LauncherFormScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LauncherFormScreen))
        Me.LabelMeBytes = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelMeShowServer = New System.Windows.Forms.Label()
        Me.LabelMeShowLauncher = New System.Windows.Forms.Label()
        Me.PictureBoxMeUpdate = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBoxMeClose = New System.Windows.Forms.PictureBox()
        Me.PictureBoxMeMinimized = New System.Windows.Forms.PictureBox()
        Me.PictureBoxMePlay = New System.Windows.Forms.PictureBox()
        Me.SaveFileDialogMeUpdate = New System.Windows.Forms.SaveFileDialog()
        Me.BackgroundWorkerMeUpdateDownload = New System.ComponentModel.BackgroundWorker()
        Me.PictureBoxMeInfo = New System.Windows.Forms.PictureBox()
        Me.LabelMeNews = New System.Windows.Forms.Label()
        CType(Me.PictureBoxMeUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMeClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMeMinimized, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMePlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMeInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelMeBytes
        '
        resources.ApplyResources(Me.LabelMeBytes, "LabelMeBytes")
        Me.LabelMeBytes.Name = "LabelMeBytes"
        '
        'ProgressBar1
        '
        resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Step = 2
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Name = "Label4"
        '
        'LabelMeShowServer
        '
        Me.LabelMeShowServer.BackColor = System.Drawing.Color.Transparent
        Me.LabelMeShowServer.ForeColor = System.Drawing.SystemColors.ControlLight
        resources.ApplyResources(Me.LabelMeShowServer, "LabelMeShowServer")
        Me.LabelMeShowServer.Name = "LabelMeShowServer"
        '
        'LabelMeShowLauncher
        '
        Me.LabelMeShowLauncher.BackColor = System.Drawing.Color.Transparent
        Me.LabelMeShowLauncher.ForeColor = System.Drawing.SystemColors.ControlLight
        resources.ApplyResources(Me.LabelMeShowLauncher, "LabelMeShowLauncher")
        Me.LabelMeShowLauncher.Name = "LabelMeShowLauncher"
        '
        'PictureBoxMeUpdate
        '
        Me.PictureBoxMeUpdate.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxMeUpdate.BackgroundImage = Global.Launcher.My.Resources.Resources.Update_BTN_NoCklick
        Me.PictureBoxMeUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.PictureBoxMeUpdate, "PictureBoxMeUpdate")
        Me.PictureBoxMeUpdate.Name = "PictureBoxMeUpdate"
        Me.PictureBoxMeUpdate.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Name = "Label1"
        '
        'PictureBoxMeClose
        '
        Me.PictureBoxMeClose.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxMeClose.BackgroundImage = Global.Launcher.My.Resources.Resources.Close_BTN_NoCklick
        Me.PictureBoxMeClose.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.PictureBoxMeClose, "PictureBoxMeClose")
        Me.PictureBoxMeClose.Name = "PictureBoxMeClose"
        Me.PictureBoxMeClose.TabStop = False
        '
        'PictureBoxMeMinimized
        '
        Me.PictureBoxMeMinimized.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxMeMinimized.BackgroundImage = Global.Launcher.My.Resources.Resources.Minimized_BTN_NoCklick
        Me.PictureBoxMeMinimized.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.PictureBoxMeMinimized, "PictureBoxMeMinimized")
        Me.PictureBoxMeMinimized.Name = "PictureBoxMeMinimized"
        Me.PictureBoxMeMinimized.TabStop = False
        '
        'PictureBoxMePlay
        '
        Me.PictureBoxMePlay.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxMePlay.BackgroundImage = Global.Launcher.My.Resources.Resources.BTN_Normal
        Me.PictureBoxMePlay.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.PictureBoxMePlay, "PictureBoxMePlay")
        Me.PictureBoxMePlay.Name = "PictureBoxMePlay"
        Me.PictureBoxMePlay.TabStop = False
        '
        'BackgroundWorkerMeUpdateDownload
        '
        Me.BackgroundWorkerMeUpdateDownload.WorkerReportsProgress = True
        Me.BackgroundWorkerMeUpdateDownload.WorkerSupportsCancellation = True
        '
        'PictureBoxMeInfo
        '
        Me.PictureBoxMeInfo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxMeInfo.BackgroundImage = Global.Launcher.My.Resources.Resources.Info_BTN_NoCklick
        Me.PictureBoxMeInfo.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.PictureBoxMeInfo, "PictureBoxMeInfo")
        Me.PictureBoxMeInfo.Name = "PictureBoxMeInfo"
        Me.PictureBoxMeInfo.TabStop = False
        '
        'LabelMeNews
        '
        Me.LabelMeNews.BackColor = System.Drawing.Color.Transparent
        Me.LabelMeNews.ForeColor = System.Drawing.SystemColors.ControlLightLight
        resources.ApplyResources(Me.LabelMeNews, "LabelMeNews")
        Me.LabelMeNews.Name = "LabelMeNews"
        '
        'LauncherFormScreen
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Launcher.My.Resources.Resources.Launcher_BG
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelMeBytes)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.LabelMeNews)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelMeShowServer)
        Me.Controls.Add(Me.LabelMeShowLauncher)
        Me.Controls.Add(Me.PictureBoxMeUpdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBoxMeClose)
        Me.Controls.Add(Me.PictureBoxMeMinimized)
        Me.Controls.Add(Me.PictureBoxMePlay)
        Me.Controls.Add(Me.PictureBoxMeInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LauncherFormScreen"
        CType(Me.PictureBoxMeUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMeClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMeMinimized, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMePlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMeInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelMeBytes As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelMeShowServer As Label
    Friend WithEvents LabelMeShowLauncher As Label
    Friend WithEvents PictureBoxMeUpdate As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBoxMeClose As PictureBox
    Friend WithEvents PictureBoxMeMinimized As PictureBox
    Friend WithEvents PictureBoxMePlay As PictureBox
    Friend WithEvents SaveFileDialogMeUpdate As SaveFileDialog
    Friend WithEvents BackgroundWorkerMeUpdateDownload As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBoxMeInfo As PictureBox
    Friend WithEvents LabelMeNews As Label
End Class
