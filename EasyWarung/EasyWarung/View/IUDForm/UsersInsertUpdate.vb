Imports System.IO

Public Class UsersInsertUpdate
    Private usersForm As UsersForm
    Private Request As Integer
    Private user As User

    Private security As New Security
    Private openFileDialog As New OpenFileDialog

    Public Sub New(usersForm As UsersForm, Request As Integer, user As User)
        InitializeComponent()
        Me.usersForm = usersForm
        Me.Request = Request
        Me.user = user

        If Not My.Application.User.UserRoleInt = 0 Then
            SuperAdminBunifuRadioButton.Enabled = False
        End If

        If Request = 2 OrElse Request = 3 Then
            UserNamesBunifuTextBox.Text = user.UserNames
            UserAddressBunifuTextBox.Text = user.UserAddress
            UserEmailBunifuTextBox.Text = user.UserEmail
            UserPhoneBunifuTextBox.Text = user.UserPhone
            UsernameBunifuTextBox.Text = user.Username

            If user.UserRoleInt = 0 Then
                SuperAdminBunifuRadioButton.Checked = True
            ElseIf user.UserRoleInt = 1 Then
                AdminBunifuRadioButton.Checked = True
            Else
                OperatorBunifuRadioButton.Checked = True
            End If

            Using memoryStream As New MemoryStream(user.UserImage, 0, user.UserImage.Length)
                memoryStream.Write(user.UserImage, 0, user.UserImage.Length)
                UserBunifuPictureBox.Image = Image.FromStream(memoryStream)
            End Using

            If Request = 3 Then
                UserNamesBunifuTextBox.Enabled = False
                UserAddressBunifuTextBox.Enabled = False
                UserEmailBunifuTextBox.Enabled = False
                UserPhoneBunifuTextBox.Enabled = False
                UsernameBunifuTextBox.Enabled = False
                SuperAdminBunifuRadioButton.Enabled = False
                AdminBunifuRadioButton.Enabled = False
                OperatorBunifuRadioButton.Enabled = False
                PasswordBunifuTextBox.Enabled = False
                RetypePasswordBunifuTextBox.Enabled = False
                UserBunifuPictureBox.Enabled = False
                SaveBunifuButton.Visible = False
            End If
        End If
    End Sub

    Private Sub UserBunifuPictureBox_Click(sender As Object, e As EventArgs) Handles UserBunifuPictureBox.Click
        openFileDialog.Multiselect = False
        openFileDialog.Title = "Select an image for the user."
        openFileDialog.InitialDirectory = Environment.SpecialFolder.CommonPictures
        openFileDialog.Filter = "Image File|*.jpg;*.jpeg;*.png;*.bmp"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            UserBunifuPictureBox.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub SaveBunifuButton_Click(sender As Object, e As EventArgs) Handles SaveBunifuButton.Click
        Dim Result As String

        If Not String.IsNullOrEmpty(UserNamesBunifuTextBox.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(UserNamesBunifuTextBox.Text.Trim()) AndAlso
           Not String.IsNullOrEmpty(UserAddressBunifuTextBox.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(UserAddressBunifuTextBox.Text.Trim()) AndAlso
           Not String.IsNullOrEmpty(UserEmailBunifuTextBox.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(UserEmailBunifuTextBox.Text.Trim()) AndAlso
           Not String.IsNullOrEmpty(UserPhoneBunifuTextBox.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(UserPhoneBunifuTextBox.Text.Trim()) AndAlso
           (SuperAdminBunifuRadioButton.Checked OrElse AdminBunifuRadioButton.Checked OrElse OperatorBunifuRadioButton.Checked) AndAlso
           Not String.IsNullOrEmpty(UsernameBunifuTextBox.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(UsernameBunifuTextBox.Text.Trim()) AndAlso
           Not String.IsNullOrEmpty(PasswordBunifuTextBox.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(PasswordBunifuTextBox.Text.Trim()) AndAlso
           Not String.IsNullOrEmpty(RetypePasswordBunifuTextBox.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(RetypePasswordBunifuTextBox.Text.Trim()) AndAlso
           (If(Request = 1, Not String.IsNullOrEmpty(openFileDialog.FileName) AndAlso Not String.IsNullOrWhiteSpace(openFileDialog.FileName), True)) Then

            If security.GetHash(PasswordBunifuTextBox.Text.Trim()) = security.GetHash(RetypePasswordBunifuTextBox.Text.Trim()) Then
                user.UserNames = UserNamesBunifuTextBox.Text.Trim()
                user.UserAddress = UserAddressBunifuTextBox.Text.Trim()
                user.UserEmail = UserEmailBunifuTextBox.Text.Trim()
                user.UserPhone = UserPhoneBunifuTextBox.Text.Trim()
                user.Username = UsernameBunifuTextBox.Text.Trim()
                user.Password = security.GetHash(PasswordBunifuTextBox.Text.Trim())

                If SuperAdminBunifuRadioButton.Checked = True Then
                    user.UserRoleInt = 0
                ElseIf AdminBunifuRadioButton.Checked = True Then
                    user.UserRoleInt = 1
                Else
                    user.UserRoleInt = 2
                End If
                Try
                    Dim memoryStream As New MemoryStream()
                    UserBunifuPictureBox.Image.Save(memoryStream, UserBunifuPictureBox.Image.RawFormat)
                    If user.UserImage IsNot memoryStream.GetBuffer() Then
                        user.UserImage = memoryStream.GetBuffer()
                    End If
                Catch ex As Exception

                End Try

                If Request = 1 Then
                    Result = My.Application.DBA.UsersInsert(user)
                    If Result = "User data has been successfully added to the database." Then
                        usersForm.ShowMessage(Result, 1)
                        usersForm.RefreshData()
                        Close()
                    Else
                        usersForm.ShowMessage(Result, 4)
                    End If
                Else
                    Result = My.Application.DBA.UsersUpdate(user)
                    If Result = "User data has been successfully updated to the database." Then
                        usersForm.ShowMessage(Result, 1)
                        usersForm.RefreshData()
                        Close()
                    Else
                        usersForm.ShowMessage(Result, 4)
                    End If
                End If
            Else
                usersForm.ShowMessage("Password and Retype Password is not same.", 3)
            End If
        Else
            usersForm.ShowMessage("All fields must be completed before proceeding.", 3)
        End If
    End Sub

    Private Sub CancelBunifuButton_Click(sender As Object, e As EventArgs) Handles CancelBunifuButton.Click
        Close()
    End Sub
End Class