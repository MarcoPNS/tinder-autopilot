Imports RestSharp
Public Class MainViewer

    'Das Tinder Telefon
    Dim Client As New RestClient("https://api.gotinder.com/")
    Dim userId As String = "100001706025627"
    Dim accessToken As String = "t"
    'Beginn der Action
    Private Sub ViewerVisible(sender As Object, e As EventArgs) Handles MyBase.Shown
        Log("Tinder Autopilot Dashboard started")
        'LoginToTinder()
        'GetTinderMatches()
    End Sub
    Private Sub LoginToTinder()

    End Sub
    Private Sub GetTinderMatches()

    End Sub

    Private Sub FireSwitched(sender As Object, e As EventArgs) Handles FireSwitch.CheckedChanged
        If FireSwitch.Checked = True Then
            OnFire.Visible = True
            TinderWorker.RunWorkerAsync()
        Else
            OnFire.Visible = False
            TinderWorker.CancelAsync()
        End If
    End Sub
    Public Sub TinderAuth()

    End Sub
    Public Sub GetNewProfile()

    End Sub

    Private Sub TinderWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles TinderWorker.DoWork

    End Sub

    Private Sub LoadForm(sender As Object, e As EventArgs) Handles MyBase.Load
        FacebookAuthBox.Text = My.Settings.FacebookAuth
        TinderAuthBox.Text = My.Settings.TinderAuth
        FacebookAccIDBox.Text = My.Settings.FacebookID
    End Sub
    Public Sub Log(msg As String)
        LogBox.AppendText(msg & vbNewLine)
        StatusLabel.Text = (msg)
    End Sub
    Public Sub StartTheWork()

    End Sub
    Private Sub SavingAuthCodes(sender As Object, e As EventArgs) Handles SaveAuth.Click
        My.Settings.FacebookAuth = FacebookAuthBox.Text
        My.Settings.TinderAuth = TinderAuthBox.Text
        My.Settings.FacebookID = FacebookAccIDBox.Text
        My.Settings.Save()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles StatusLabel.Click

    End Sub
End Class
