Imports System.Globalization
Imports System.Windows

Public Class MainForm
    Dim MyParent As DashboardForm
    Dim LoginStartTime As DateTime

    Public Sub New(MyParent As DashboardForm, LoginStartTime As DateTime)
        InitializeComponent()
        Me.MyParent = MyParent
        Me.LoginStartTime = LoginStartTime

        WelcomeBunifuLabel.Text = "Have a nice day, " + My.Application.User.UserNames + "."
        If My.Application.DBA.CheckDBConn Then
            StatusBunifuLabel.ForeColor = Color.Green
            StatusBunifuLabel.Text = "Status: Connected to the server."
        Else
            StatusBunifuLabel.ForeColor = Color.Red
            StatusBunifuLabel.Text = "Status: Disconnected from the server."
        End If
    End Sub

    Private Sub GitHubBunifuLabel_MouseHover(sender As Object, e As EventArgs) Handles GitHubBunifuLabel.MouseHover
        GitHubBunifuLabel.ForeColor = Color.Red
    End Sub

    Private Sub GitHubBunifuLabel_MouseLeave(sender As Object, e As EventArgs) Handles GitHubBunifuLabel.MouseLeave
        GitHubBunifuLabel.ForeColor = Color.Blue
    End Sub

    Private Sub GitHubBunifuLabel_Click(sender As Object, e As EventArgs) Handles GitHubBunifuLabel.Click
        Dim UrlLink As String = "https://github.com/AlicelieseLou"

        Try
            Process.Start(New ProcessStartInfo With {
                .FileName = UrlLink,
                .UseShellExecute = True
            })
        Catch ex As Exception
            MyParent.ShowMessage("Unable to open the browser. Please ensure the link is valid.", 4)
        End Try
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        DateTimeBunifuLabel.Text = Format(Now.ToString("dddd, dd MMMM yyyy HH:mm:ss", New CultureInfo("id-ID")))

        Dim ElapsedTime As TimeSpan = DateTime.Now - LoginStartTime
        LoggedBunifuLabel.Text = "Logged in for: " & ElapsedTime.ToString("hh\:mm\:ss")
    End Sub

    Private Sub AboutMeForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer.Start()
    End Sub
End Class