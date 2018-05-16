Imports System.Net
Imports System.Text

Public Class LoginFormScreen

    Dim wClient As New WebClient
    Private Sub LoginFormScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelMeNews.Text = New WebClient().DownloadString("https://static.laucherinfo.project-unit.de/_info.htm")
    End Sub
    Public Shared ReadOnly Property Latain1 As Encoding
    Private Sub PictureBoxMeClose_Click(sender As Object, e As EventArgs) Handles PictureBoxMeClose.Click
        PictureBoxMeClose.BackColor = Color.Transparent
        Select Case MsgBox("Willst du das Spiel wirklich Beenden?", MsgBoxStyle.YesNo, "Spiel Beenden!")
            Case MsgBoxResult.Yes
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

    Private Sub PictureBoxMeInfo_MouseEnter(sender As Object, e As EventArgs) Handles PictureBoxMeInfo.MouseEnter
        PictureBoxMeInfo.BackgroundImage = My.Resources.Info_BTN_OnCklick
    End Sub

    Private Sub PictureBoxMeInfo_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxMeInfo.MouseLeave
        PictureBoxMeInfo.BackgroundImage = My.Resources.Info_BTN_NoCklick
    End Sub
    Private Sub LoginFormScreen_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Me.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else : End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start("https://www.project-unit.de")
    End Sub

    Private Sub PictureBoxMeInfo_Click(sender As Object, e As EventArgs) Handles PictureBoxMeInfo.Click
        DevFormInfo.Show()
    End Sub
    Private Sub PictureBoxLogin_MouseEnter(sender As Object, e As EventArgs) Handles PictureBoxLogin.MouseEnter
        PictureBoxLogin.BackgroundImage = My.Resources.Login_BTN_Click

    End Sub

    Private Sub PictureBoxLogin_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxLogin.MouseLeave
        PictureBoxLogin.BackgroundImage = My.Resources.Login_BTN_NoClick
    End Sub

    Private Sub PictureBoxLogin_Click(sender As Object, e As EventArgs) Handles PictureBoxLogin.Click
        Dim result As String = wClient.DownloadString("https://www.project-unit.de/_register_and_login/handler.php?action=login&username=" + TextBoxUsername.Text + "&password=" + TextBoxPassword.Text)

        If result = "1" Then

            MsgBox("Du bist eingeloggt!", MsgBoxStyle.Information, "Erfolgreich!")
            Dim newForm2 As New LauncherFormScreen

            newForm2.Show()
            Me.Hide()

        ElseIf result = "0" Then

            MsgBox("Benutzername oder Passwort falsch.", MsgBoxStyle.Critical, "Fehler beim Login")
        End If
    End Sub

    Private Sub TextBoxUsername_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsername.TextChanged

    End Sub
End Class