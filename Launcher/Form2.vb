Imports System.ComponentModel
Imports System.IO, System.Net
Imports System.Text

Public Class LauncherFormScreen

    Public Shared ReadOnly Property Latain1 As Encoding
    Public Sub CheckForUpdates()
        Try
            Dim request As HttpWebRequest = WebRequest.Create("https://static.download.project-unit.de/_launcher_download/_launcher_version.txt")
            Dim response As HttpWebResponse = request.GetResponse()
            Dim sr As StreamReader = New StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd()
            Dim currentversion As String = Application.ProductVersion
            LabelMeShowLauncher.Text = currentversion.ToString
            LabelMeShowServer.Text = newestversion.ToString
            If LabelMeShowServer.Text > LabelMeShowLauncher.Text Then
                Select Case MsgBox("Es wurde ein Launcher Update gefunden!" & vbNewLine & vbNewLine & "Wollen Sie das Update Runterladen?", MsgBoxStyle.YesNo, "Update Benachrichtigung!")
                    Case MsgBoxResult.Yes
                        Me.Hide()
ShowDialog:

                        SaveFileDialogMeUpdate.Filter = "Executable |*.exe"
                        SaveFileDialogMeUpdate.ShowDialog()
                        SaveFileDialogMeUpdate.Title = "Datei Speichern unter..."
                        SaveFileDialogMeUpdate.CheckFileExists = True
                        SaveFileDialogMeUpdate.CheckPathExists = True
                        SaveFileDialogMeUpdate.FilterIndex = 2
                        SaveFileDialogMeUpdate.RestoreDirectory = True
                        'SaveFileDialogMeUpdate.InitialDirectory = "\%ProgrammData%\Project-Unit\"
                        If SaveFileDialogMeUpdate.FileName = Nothing Then
                            GoTo DialogCancel
                        End If
                        Pfad = SaveFileDialogMeUpdate.FileName
                        Try
                            Me.Show()
                            Httpclient = New WebClient
                            Dim URL As String = "https://speed.hetzner.de/10GB.bin"
                            Application.DoEvents()
                            Httpclient.DownloadFileAsync(New Uri(URL), Pfad)
                            Application.DoEvents()
                        Catch ex As Exception
                            MsgBox("Ein Fehler ist aufgetreten" & vbNewLine & ex.ToString, MsgBoxStyle.Critical, "Error")
                            Me.Show()
                            End
                        End Try
                    Case MsgBoxResult.No
DialogCancel:
                        MsgBox("Update Abbruch durch Benutzer." & vbNewLine & "Sie verwenden eine alte Version, das kann zufolge Haben, dass das Spiel eventuell nicht mehr funktioniert!", MsgBoxStyle.Critical, "Abbruch des Updates durch benutzer!")
                        Me.Show()
                End Select
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PictureBoxMeClose_Click(sender As Object, e As EventArgs) Handles PictureBoxMeClose.Click
        PictureBoxMeClose.BackColor = Color.Transparent
        Select Case MsgBox("Willst du das Spiel wirklich Beenden?", MsgBoxStyle.YesNo, "Spiel Beenden!")
            Case MsgBoxResult.Yes
                LoginFormScreen.Close()
                Me.Close()
            Case MsgBoxResult.No
                Me.Show()
        End Select

    End Sub

    Private Sub PictureBoxMeMinimized_Click(sender As Object, e As EventArgs) Handles PictureBoxMeMinimized.Click
        PictureBoxMeMinimized.BackColor = Color.Transparent
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private WithEvents Httpclient As WebClient
    Dim Pfad As String = Nothing

    Private Sub LauncherFormScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelMeShowLauncher.Text = Application.ProductVersion
        CheckForUpdates()
        Dim news As New WebClient With {
            .Credentials = New NetworkCredential("", "")
        }
        LabelMeNews.Text = New WebClient().DownloadString("https://static.laucherinfo.project-unit.de/_info.htm")
    End Sub

    Private Sub PictureBoxMePlay_Click(sender As Object, e As EventArgs) Handles PictureBoxMePlay.Click
        PictureBoxMePlay.Parent = Me
        PictureBoxMePlay.BackColor = Color.Transparent
        Try
            Process.Start(My.Application.Info.DirectoryPath.ToString & "\Start_Game.exe")
            Application.Exit()
        Catch ex As Exception
            MsgBox("Leider wurde das Spiel noch nicht Installiert!", MsgBoxStyle.Critical, "Wichtiger Hinweis")
        End Try

    End Sub

    Private Sub PictureBoxMePlay_MouseEnter(sender As Object, e As EventArgs) Handles PictureBoxMePlay.MouseEnter
        PictureBoxMePlay.BackgroundImage = My.Resources.BTN_Click
    End Sub

    Private Sub PictureBoxMePlay_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxMePlay.MouseLeave
        PictureBoxMePlay.BackgroundImage = My.Resources.BTN_Normal

    End Sub

    Private Sub PictureBoxMeMinimized_MouseEnter(sender As Object, e As EventArgs) Handles PictureBoxMeMinimized.MouseEnter
        PictureBoxMeMinimized.BackgroundImage = My.Resources.Minimized_BTN_OnCklick
    End Sub

    Private Sub PictureBoxMeMinimized_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxMeMinimized.MouseLeave
        PictureBoxMeMinimized.BackgroundImage = My.Resources.Minimized_BTN_NoCklick
    End Sub

    Private Sub PictureBoxMeClose_MouseEnter(sender As Object, e As EventArgs) Handles PictureBoxMeClose.MouseEnter
        PictureBoxMeClose.BackgroundImage = My.Resources.Close_BTN_OnCklick
    End Sub

    Private Sub PictureBoxMeClose_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxMeClose.MouseLeave
        PictureBoxMeClose.BackgroundImage = My.Resources.Close_BTN_NoCklick
    End Sub

    Private Sub PictureBoxMeUpdate_Click(sender As Object, e As EventArgs) Handles PictureBoxMeUpdate.Click
        CheckForUpdates()
        Me.Show()
    End Sub

    Private Sub PictureBoxMeUpdate_MouseEnter(sender As Object, e As EventArgs) Handles PictureBoxMeUpdate.MouseEnter
        PictureBoxMeUpdate.BackgroundImage = My.Resources.Update_BTN_OnCklick
    End Sub

    Private Sub PictureBoxMeUpdate_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxMeUpdate.MouseLeave
        PictureBoxMeUpdate.BackgroundImage = My.Resources.Update_BTN_NoCklick
    End Sub

    Private Sub PictureBoxMeInfo_MouseEnter(sender As Object, e As EventArgs) Handles PictureBoxMeInfo.MouseEnter
        PictureBoxMeInfo.BackgroundImage = My.Resources.Info_BTN_OnCklick
    End Sub

    Private Sub PictureBoxMeInfo_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxMeInfo.MouseLeave
        PictureBoxMeInfo.BackgroundImage = My.Resources.Info_BTN_NoCklick
    End Sub

    Private Sub LabelMeShowLauncher_Click(sender As Object, e As EventArgs) Handles LabelMeShowLauncher.Click
        LabelMeShowLauncher.Text = Application.ProductVersion
    End Sub

    Private Sub LauncherFormScreen_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Me.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else : End If
    End Sub

    Private Sub Httpclient_DownloadFileCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs) Handles Httpclient.DownloadFileCompleted
        If e.Error Is Nothing Then
            MsgBox("Download Erfolgreich")
        End If
        MsgBox("Fehler beim Download", MsgBoxStyle.Critical, "Download Fehlgeschlagen")
    End Sub

    Private Sub Httpclient_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles Httpclient.DownloadProgressChanged
        Me.ProgressBar1.Value = e.ProgressPercentage
        Dim totalbytes As Decimal = FormatNumber(e.TotalBytesToReceive / 1000000, 2)
        Dim bytes As Decimal = FormatNumber(e.BytesReceived / 1000000, 2)
        Me.LabelMeBytes.Text = bytes & " MB von " & totalbytes & " MB "
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start("https://www.project-unit.de")
    End Sub

    Private Sub PictureBoxMeInfo_Click(sender As Object, e As EventArgs) Handles PictureBoxMeInfo.Click
        DevFormInfo.Show()
    End Sub

    Private Sub BackgroundWorkerMeUpdateDownload_ProgressChanged(ByVal sender As Object,
        ByVal e As ProgressChangedEventArgs) _
        Handles BackgroundWorkerMeUpdateDownload.ProgressChanged
        Me.ProgressBar1.Value = e.ProgressPercentage
    End Sub
    Private Sub BackgroundWorkerMeUpdateDownload_RunWorkerCompleted(ByVal sender As Object,
         ByVal e As RunWorkerCompletedEventArgs) _
         Handles BackgroundWorkerMeUpdateDownload.RunWorkerCompleted
        MsgBox("Download Erfolgreich")
    End Sub
End Class