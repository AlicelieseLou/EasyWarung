Public Class UserLoginForm
    Dim security As New Security
    Dim MyParent As DashboardForm

    Sub New(_MyParent As DashboardForm)
        InitializeComponent()
        Me.MyParent = _MyParent
    End Sub

    Private Sub SignInBunifuButton_Click(sender As Object, e As EventArgs) Handles SignInBunifuButton.Click
        If String.IsNullOrEmpty(UsernameBunifuTextBox.Text) AndAlso String.IsNullOrEmpty(UsernameBunifuTextBox.Text) AndAlso String.IsNullOrEmpty(PasswordBunifuTextBox.Text) AndAlso String.IsNullOrEmpty(PasswordBunifuTextBox.Text) Then
            MyParent.ShowMessage("All fields must be completed before proceeding.", 3)
        Else
            My.Application.User = My.Application.DBA.UserLogin(Trim(UsernameBunifuTextBox.Text), security.GetHash(Trim(PasswordBunifuTextBox.Text)))

            If Not My.Application.User Is Nothing Then
                MyParent.UserLogin()
                Close()
            Else
                MyParent.ShowMessage("Username/Password is wrong.", 3)
            End If
        End If
    End Sub

    Private Sub CancelBunifuButton_Click(sender As Object, e As EventArgs) Handles CancelBunifuButton.Click
        Close()
    End Sub

    Private Sub UsernameBunifuTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles UsernameBunifuTextBox.KeyUp
        If e.KeyCode = Keys.Enter Then
            SignInBunifuButton_Click(sender, e)
        End If
    End Sub

    Private Sub PasswordBunifuTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles PasswordBunifuTextBox.KeyUp
        If e.KeyCode = Keys.Enter Then
            SignInBunifuButton_Click(sender, e)
        End If
    End Sub
End Class