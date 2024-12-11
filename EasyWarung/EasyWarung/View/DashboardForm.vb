Public Class DashboardForm
    Private CurrentChildForm As Form
    Private LoginStartTime As DateTime

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub SecurityControl(Condition As Boolean)
        DashboardBunifuButton.Visible = Not Condition
        CategoriesBunifuButton.Visible = Not Condition
        ProductsBunifuButton.Visible = Not Condition
        OrdersBunifuButton.Visible = Not Condition
        EmployeesBunifuButton.Visible = Not Condition
        SettingBunifuButton.Visible = Not Condition
        LogoutBunifuButton.Visible = Not Condition
        SignInBunifuButton.Visible = Condition
    End Sub

    Public Sub ShowMessage(Message As String, Type As Integer)
        If Type = 1 Then
            BunifuSnackbar.Show(Me, Message,
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 4000,
            "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopCenter)
        ElseIf Type = 2 Then
            BunifuSnackbar.Show(Me, Message,
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information, 4000,
            "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopCenter)
        ElseIf Type = 3 Then
            BunifuSnackbar.Show(Me, Message,
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning, 4000,
            "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopCenter)
        ElseIf Type = 4 Then
            BunifuSnackbar.Show(Me, Message,
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 4000,
            "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopCenter)
        End If
    End Sub

    Public Sub UserLogin()
        LoginStartTime = DateTime.Now
        SignInBunifuButton.Visible = False
        If My.Application.User.UserRoleInt = 0 OrElse My.Application.User.UserRoleInt = 1 Then
            CategoriesBunifuButton.Visible = True
            ProductsBunifuButton.Visible = True
            EmployeesBunifuButton.Visible = True
        End If

        DashboardBunifuButton.Visible = True
        OrdersBunifuButton.Visible = True
        SettingBunifuButton.Visible = True
        LogoutBunifuButton.Visible = True

        OpenChildForm(New MainForm(Me, LoginStartTime))
    End Sub

    Private Sub OpenChildForm(ChildForm As Form)
        If CurrentChildForm IsNot Nothing Then
            CurrentChildForm.Close()
        End If
        CurrentChildForm = ChildForm

        ChildForm.TopLevel = False
        ChildForm.FormBorderStyle = FormBorderStyle.None
        ChildForm.Dock = DockStyle.Fill
        DesktopBunifuPanel.Controls.Add(ChildForm)
        DesktopBunifuPanel.Tag = ChildForm
        ChildForm.BringToFront()
        ChildForm.Show()
    End Sub

    Private Sub DashboardBunifuButton_Click(sender As Object, e As EventArgs) Handles DashboardBunifuButton.Click
        OpenChildForm(New MainForm(Me, LoginStartTime))
    End Sub

    Private Sub CategoriesBunifuButton_Click(sender As Object, e As EventArgs) Handles CategoriesBunifuButton.Click
        OpenChildForm(New CategoriesForm(Me))
    End Sub

    Private Sub ProductsBunifuButton_Click(sender As Object, e As EventArgs) Handles ProductsBunifuButton.Click
        OpenChildForm(New ProductsForm(Me))
    End Sub

    Private Sub OrdersBunifuButton_Click(sender As Object, e As EventArgs) Handles OrdersBunifuButton.Click
        OpenChildForm(New OrdersForm(Me))
    End Sub

    Private Sub EmployeesBunifuButton_Click(sender As Object, e As EventArgs) Handles EmployeesBunifuButton.Click
        OpenChildForm(New UsersForm(Me))
    End Sub

    Private Sub SettingBunifuButton_Click(sender As Object, e As EventArgs) Handles SettingBunifuButton.Click
        OpenChildForm(New SettingForm(Me))
    End Sub

    Private Sub LogoutBunifuButton_Click(sender As Object, e As EventArgs) Handles LogoutBunifuButton.Click
        If CurrentChildForm IsNot Nothing Then
            CurrentChildForm.Close()
        End If

        SecurityControl(False)
        My.Application.User = Nothing
        LoginBunifuButton_Click(sender, e)
    End Sub

    Private Sub LoginBunifuButton_Click(sender As Object, e As EventArgs) Handles SignInBunifuButton.Click
        SecurityControl(True)
        Dim userLoginForm As New UserLoginForm(Me)
        userLoginForm.ShowDialog()
    End Sub

    Private Sub DashboardForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoginBunifuButton_Click(sender, e)
    End Sub
End Class