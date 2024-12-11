Public Class DatabaseConfigurationForm
    Sub New()
        InitializeComponent()
        ServerAddressBunifuTextBox.Text = My.Application.CRW.ServerAddress
        DatabaseInstanceBunifuTextBox.Text = My.Application.CRW.DBInstance
        DatabaseNameBunifuTextBox.Text = My.Application.CRW.DBName
        UsernameBunifuTextBox.Text = My.Application.CRW.UserDB
    End Sub

    Private Sub SaveBunifuButton_Click(sender As Object, e As EventArgs) Handles SaveBunifuButton.Click
        If Not String.IsNullOrEmpty(ServerAddressBunifuTextBox.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(ServerAddressBunifuTextBox.Text.Trim()) AndAlso
           Not String.IsNullOrEmpty(DatabaseNameBunifuTextBox.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(DatabaseNameBunifuTextBox.Text.Trim()) AndAlso
           Not String.IsNullOrEmpty(UsernameBunifuTextBox.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(UsernameBunifuTextBox.Text.Trim()) AndAlso
           Not String.IsNullOrEmpty(PasswordBunifuTextBox.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(PasswordBunifuTextBox.Text.Trim()) Then

            Dim ServerAddress As String = ServerAddressBunifuTextBox.Text.Trim()
            Dim DatabaseInstance As String = DatabaseInstanceBunifuTextBox.Text.Trim()
            Dim DatabaseName As String = DatabaseNameBunifuTextBox.Text.Trim()
            Dim Username As String = UsernameBunifuTextBox.Text.Trim()
            Dim Password As String = PasswordBunifuTextBox.Text.Trim()
            My.Application.CRW.WriteConfig(ServerAddress, DatabaseInstance, DatabaseName, Username, Password)
            Application.Restart()
        End If
    End Sub

    Private Sub CancelBunifuButton_Click(sender As Object, e As EventArgs) Handles CancelBunifuButton.Click
        Close()
    End Sub
End Class