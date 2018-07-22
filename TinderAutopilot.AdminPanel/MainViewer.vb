Imports RestSharp
Imports Newtonsoft.Json.Linq
Imports System.Threading
Imports System.Net
Imports System.IO
Public Class MainViewer

    'Das Tinder Telefon
    Dim Client As New RestClient("https://api.gotinder.com/")
    Dim LoggedIn As Boolean = False
    Dim userId As String = "100001706025627"
    Dim MyProfile As String
    Dim accessToken As String = ""
    'Beginn der Action
    Private Sub ViewerVisible(sender As Object, e As EventArgs) Handles MyBase.Shown
        Log("Tinder Autopilot Dashboard started")
        If Directory.Exists(Application.StartupPath & "\swipes\") Then
            Directory.CreateDirectory(Application.StartupPath & "\swipes\")
        End If
    End Sub
    Private Sub GetTinderMatch()

    End Sub

    Private Sub FireSwitched(sender As Object, e As EventArgs) Handles FireSwitch.CheckedChanged
        If LoggedIn = False Then
            FireSwitch.Checked = False
            Log("Can't start Autopilot. Please auth your account.")
            Return
        End If
        If FireSwitch.Checked = True Then
            Log("Autopilot started")
            OnFire.Visible = True
            TinderWorker.RunWorkerAsync()
        Else
            OnFire.Visible = False
            TinderWorker.CancelAsync()
            Log("Autopilot stopped")
        End If
    End Sub
    Public Sub TinderAuth()
        Try
            If Not TinderAuthBox.Text = "" Then
                AuthWithTinderToken()
                FacebookAccIDBox.Enabled = False
                FacebookAuthBox.Enabled = False
                TinderAuthBox.Enabled = False
                SaveAuth.Enabled = False
                LoggedIn = True
                Return
            ElseIf Not FacebookAuthBox.Text = "" Then
                If Not FacebookAccIDBox.Text = "" Then

                End If
            End If
            Throw New Exception("Auth failed. Missing Infos.")
        Catch ex As Exception
            Log(ex.Message)
        End Try
    End Sub
    Public Sub AuthWithTinderToken()
        Dim AuthRequest As New RestRequest("profile")
        AuthRequest.AddHeader("X-auth-token", My.Settings.TinderAuth)
        Dim answer As IRestResponse = Client.Execute(AuthRequest)
        MyProfile = answer.Content
        Log("Own Profile filled: " & answer.Content)
        Dim ProfileJson As JObject = JObject.Parse(MyProfile)
        CurrentUserLabel.Text = ProfileJson.SelectToken("name").ToString & " (" & String.Format("{0:dd/MM/yyyy}", ProfileJson.SelectToken("birth_date").ToString) & ")"
        Log("Success auth with Tinder Token")
    End Sub
    Public Sub AuthWithFacebookToken()
        Dim AuthRequest As New RestRequest("auth")
        AuthRequest.AddParameter("facebook_token", FacebookAuthBox.Text)
        AuthRequest.AddParameter("facebook_id", FacebookAccIDBox.Text)
        Dim answer As IRestResponse = Client.Execute(AuthRequest)
        MyProfile = answer.Content
        Log("Own Profile filled: " & answer.Content)
        Dim ProfileJson As JObject = JObject.Parse(MyProfile)
        CurrentUserLabel.Text = ProfileJson.SelectToken("name").ToString & " (" & String.Format("{0:dd/MM/yyyy}", ProfileJson.SelectToken("birth_date").ToString) & ")"
        AuthRequest.AddHeader("X-auth-token", My.Settings.TinderAuth)
        Log("Success auth with Facebook Token")
    End Sub
    Public Function GetTinderMeta() As JObject
        Dim AuthRequest As New RestRequest("meta")
        AuthRequest.AddHeader("X-auth-token", My.Settings.TinderAuth)
        Dim answer As IRestResponse = Client.Execute(AuthRequest)
        Log("Got own Meta Data: " & answer.Content)
        Dim AnswerJson As JObject = JObject.Parse(answer.Content)
        Return AnswerJson
    End Function
    Public Function GetNewProfile() As String
        Dim AuthRequest As New RestRequest("user/recs")
        AuthRequest.AddHeader("X-auth-token", My.Settings.TinderAuth)
        Dim answer As IRestResponse = Client.Execute(AuthRequest)
        Return answer.Content
    End Function

    Private Sub TinderWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles TinderWorker.DoWork
        Do
            If TinderWorker.CancellationPending = True Then
                Return
            End If
            Dim LikeHer As Boolean = False
            Dim NewProfileString As String = GetNewProfile()
            Dim NewProfile As JObject = JObject.Parse(NewProfileString)
            Dim ResultSet As JObject = JObject.Parse(NewProfile.Item("results").Item(0).ToString)
            Dim ProfileID As String = ResultSet.SelectToken("_id").ToString
            Dim ProfileName As String = ResultSet.SelectToken("name").ToString
            Dim PicSet As JObject = JObject.Parse(ResultSet.Item("photos").Item(0).ToString)
            Console.WriteLine("Found pictures " & PicSet.ToString)
            Dim PictureID As String = PicSet.SelectToken("fileName").ToString
            Dim tags As String() = My.Settings.LikeTags.Split(New Char() {"-"c})
            For Each Item In tags
                If NewProfileString.Contains(Item) Then
                    LikeHer = True
                    Console.WriteLine("Profile contains Tag " & Item)
                End If
            Next
            Dim ResultText As String
            If LikeHer = True Then
                Dim AuthRequest As New RestRequest("like/" & ProfileID)
                AuthRequest.AddHeader("X-auth-token", My.Settings.TinderAuth)
                Dim answer As IRestResponse = Client.Execute(AuthRequest)
                Console.WriteLine("Liked a Profile with ID " & ProfileID & " API Result: " & answer.Content)
                ResultText = ProfileName & "-Liked-" & ProfileID
            Else
                Dim AuthRequest As New RestRequest("pass/" & ProfileID)
                AuthRequest.AddHeader("X-auth-token", My.Settings.TinderAuth)
                Dim answer As IRestResponse = Client.Execute(AuthRequest)
                Console.WriteLine("Pass a Profile with ID " & ProfileID & " API Result: " & answer.Content)
                ResultText = ProfileName & "-Passed-" & ProfileID
            End If
            Try
                Using sw As StreamWriter = File.AppendText(Application.StartupPath & "\swipes.html")
                    sw.WriteLine("<br>")
                    sw.WriteLine("<img src=""https://images-ssl.gotinder.com/" & ProfileID & "/1080x1080_" & PictureID & """ height=""200"" width=""200"">")
                    sw.WriteLine("<br>" & ResultText & "<br>")
                End Using
                Console.WriteLine("Try download " & "https://images-ssl.gotinder.com/" & ProfileID & "/1080x1080_" & PictureID)
                Console.WriteLine("Added profile reference and saved")
            Catch ex As Exception

            End Try

            Thread.Sleep(10000)
        Loop
    End Sub
    Public Sub SwipeRight(id As String)
        'not needed
    End Sub
    Public Sub SwipeLeft(id As String)

    End Sub
    Private Sub LoadForm(sender As Object, e As EventArgs) Handles MyBase.Load
        FacebookAuthBox.Text = My.Settings.FacebookAuth
        TinderAuthBox.Text = My.Settings.TinderAuth
        FacebookAccIDBox.Text = My.Settings.FacebookID
    End Sub
    Public Sub Log(msg As String)
        LogBox.AppendText(msg & vbNewLine)
        StatusLabel.Text = (msg)
        Console.WriteLine(msg)
    End Sub
    Public Sub StartTheWork()

    End Sub
    Private Sub SavingAuthCodes(sender As Object, e As EventArgs) Handles SaveAuth.Click
        Try
            TinderAuth()
            My.Settings.FacebookAuth = FacebookAuthBox.Text
            My.Settings.TinderAuth = TinderAuthBox.Text
            My.Settings.FacebookID = FacebookAccIDBox.Text
            My.Settings.Save()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddTagSwitch(sender As Object, e As EventArgs) Handles AddTagBox.TextChanged
        If Not AddTagBox.Text = "" Then
            AddTagButton.Enabled = True
        Else
            AddTagButton.Enabled = False
        End If
    End Sub

    Private Sub AddTagButton_Click(sender As Object, e As EventArgs) Handles AddTagButton.Click
        TagListView.Items.Add(AddTagBox.Text)
        Log(AddTagBox.Text & " added to Tag List")
        AddTagBox.Clear()
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Dim SaveString As String = ""
        For Each Item In TagListView.Items
            SaveString = SaveString & Item & "-"
        Next
        SaveString = SaveString.Remove(SaveString.Length - 1)
        My.Settings.LikeTags = SaveString
        My.Settings.Save()
        Log("Saved Tag String: " & SaveString)
    End Sub

    Private Sub DeleteTag(sender As Object, e As EventArgs) Handles DelTagItem.Click
        TagListView.SelectedItems.Remove(TagListView.SelectedItem)
    End Sub

    Private Sub TagListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TagListView.SelectedIndexChanged
        DelTagItem.Enabled = True
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://findmyfbid.com/")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.facebook.com/login.php?skip_api_login=1&api_key=464891386855067&signed_next=1&next=https%3A%2F%2Fwww.facebook.com%2Fv2.8%2Fdialog%2Foauth%3Fchannel%3Dhttps%253A%252F%252Fstaticxx.facebook.com%252Fconnect%252Fxd_arbiter%252Fr%252FbSTT5dUx9MY.js%253Fversion%253D42%2523cb%253Df3cc083e377b028%2526domain%253Dtinder.com%2526origin%253Dhttps%25253A%25252F%25252Ftinder.com%25252Ff2984747849e2a4%2526relation%253Dopener%26redirect_uri%3Dhttps%253A%252F%252Fstaticxx.facebook.com%252Fconnect%252Fxd_arbiter%252Fr%252FbSTT5dUx9MY.js%253Fversion%253D42%2523cb%253Df30b25354398c58%2526domain%253Dtinder.com%2526origin%253Dhttps%25253A%25252F%25252Ftinder.com%25252Ff2984747849e2a4%2526relation%253Dopener%2526frame%253Df224bf576396578%26display%3Dpopup%26scope%3Duser_birthday%252Cuser_photos%252Cemail%252Cuser_friends%252Cuser_likes%26response_type%3Dtoken%252Csigned_request%26domain%3Dtinder.com%26origin%3D1%26client_id%3D464891386855067%26ret%3Dlogin%26sdk%3Djoey%26logger_id%3D2cb28a7a-1f42-b041-752c-846b78eb9856&cancel_url=https%3A%2F%2Fstaticxx.facebook.com%2Fconnect%2Fxd_arbiter%2Fr%2FbSTT5dUx9MY.js%3Fversion%3D42%23cb%3Df30b25354398c58%26domain%3Dtinder.com%26origin%3Dhttps%253A%252F%252Ftinder.com%252Ff2984747849e2a4%26relation%3Dopener%26frame%3Df224bf576396578%26error%3Daccess_denied%26error_code%3D200%26error_description%3DPermissions%2Berror%26error_reason%3Duser_denied%26e2e%3D%257B%257D&display=popup&locale=de_DE&logger_id=2cb28a7a-1f42-b041-752c-846b78eb9856")
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        WebBrowser1.Refresh()
    End Sub
End Class
