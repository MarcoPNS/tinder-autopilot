Imports SharpTinder
Public Class MainViewer

    'Das Tinder Telefon
    Dim Client As New TinderClient
    Dim userId As String = "100001706025627"
    Dim accessToken As String = "EAAGm0PX4ZCpsBAAZB3nVs08icGbDVxXZCDc5FF8gHn0DXb79c6XXx0qZCTJCD5uwaZBa0ORpZCAV6DicwPsbUIrIU70UP7C67ZA0UfhKf2Ifqt0jnntZBP9ndPZCMZAHE3b5wgjm83LSVpCqZB2eaLc8ywWCXmb9t5xSCgjLovOVavNqohRBgEJEDjxXjhXS9E9rGuBJZBKFhuTSaQZDZD"
    'Beginn der Action
    Private Sub MainViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t = Client.Login(userId, accessToken)
        Task.WaitAll(New Task() {t})
        Console.WriteLine("Token: " & Client.AuthToken)
        Console.WriteLine("logged in: " & t.Result)
        GetTinderMatches()
    End Sub
    Private Sub GetTinderMatches()
        Dim t = Client.GetUpdates(New DateTime(2000, 1, 1))
        Task.WaitAll(New Task() {t})
        Dim res = t.Result

        For Each m In res.Matches
            If m.Person IsNot Nothing Then Console.WriteLine($"{m.Person.Name} ({m.Id}) - {2016 - m.Person.BirthDate.Year}")
        Next
    End Sub
End Class
