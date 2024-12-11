Public Class SettingForm
    Dim MyParent As DashboardForm
    Private CurrentChildForm As Form

    Sub New(MyParent As DashboardForm)
        InitializeComponent()
        Me.MyParent = MyParent

        If Not My.Application.User.UserRoleInt = 0 Then
            DatabaseSettingBunifuButton.Visible = False
        End If
    End Sub

    Private Sub OpenChildForm(ChildForm As Form)
        If CurrentChildForm IsNot Nothing Then
            CurrentChildForm.Close()
        End If
        CurrentChildForm = ChildForm

        ChildForm.TopLevel = False
        ChildForm.FormBorderStyle = FormBorderStyle.None
        ChildForm.Dock = DockStyle.None
        ChildForm.Location = New Point(
            (DesktopBunifuPanel.Width - ChildForm.Width) \ 2,
            (DesktopBunifuPanel.Height - ChildForm.Height) \ 2
        )
        DesktopBunifuPanel.Controls.Add(ChildForm)
        DesktopBunifuPanel.Tag = ChildForm
        ChildForm.BringToFront()
        ChildForm.Show()
    End Sub

    Private Sub ShowMessage(Message As String, Type As Integer)
        MyParent.ShowMessage(Message, Type)
    End Sub

    Private Sub UserSettingBunifuButton_Click(sender As Object, e As EventArgs) Handles UserSettingBunifuButton.Click
        OpenChildForm(New UsersInsertUpdate(New UsersForm(MyParent), 2, My.Application.User))
    End Sub

    Private Sub DatabaseSettingBunifuButton_Click(sender As Object, e As EventArgs) Handles DatabaseSettingBunifuButton.Click
        OpenChildForm(New DatabaseConfigurationForm())
    End Sub
End Class