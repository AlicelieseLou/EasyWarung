Imports Microsoft.Reporting.WinForms
Imports System.IO

Public Class UsersForm
    Dim MyParent As DashboardForm
    Dim DTUser As DataTable
    Dim user As User
    Dim Filter As String

    Sub New(MyParent As DashboardForm)
        InitializeComponent()
        Me.MyParent = MyParent
        RefreshData()
    End Sub

    Public Sub ShowMessage(Message As String, Type As Integer)
        MyParent.ShowMessage(Message, Type)
    End Sub

    Public Sub RefreshData()
        DTUser = My.Application.DBA.UsersList()
        If DTUser.Rows.Count = 0 Then
            UsersBunifuDataGridView.Visible = False
        Else
            UsersBunifuDataGridView.DataSource = DTUser
            UsersBunifuDataGridView.Visible = True

            If Not My.Application.User.UserRoleInt = 0 Then
                Filter = "([UserRoleInt] <> 0)"
            Else
                Filter = ""
            End If
            DTUser.DefaultView.RowFilter = Filter
        End If
    End Sub

    Private Sub Search()
        Dim Search As String = ""

        If Not String.IsNullOrEmpty(SearchBunifuTextBox.Text) AndAlso Not String.IsNullOrWhiteSpace(SearchBunifuTextBox.Text) Then
            Search = "[UserID] LIKE ('%" & SearchBunifuTextBox.Text.Trim() & "%') OR 
                      [UserName] LIKE ('%" & SearchBunifuTextBox.Text.Trim() & "%') OR 
                      [UserAddress] LIKE ('%" & SearchBunifuTextBox.Text.Trim() & "%') OR 
                      [UserEmail] LIKE ('%" & SearchBunifuTextBox.Text.Trim() & "%') OR 
                      [UserPhone] LIKE ('%" & SearchBunifuTextBox.Text.Trim() & "%') OR 
                      [UserRoleStr] LIKE ('%" & SearchBunifuTextBox.Text.Trim() & "%')"
        End If

        If Not My.Application.User.UserRoleInt = 0 Then
            If String.IsNullOrEmpty(Search) AndAlso String.IsNullOrWhiteSpace(Search) Then
                Filter = "([UserRoleInt] <> 0)"
            Else
                Filter = "([UserRoleInt] <> 0) AND (" & Search & ")"
            End If
        Else
            Filter = Search
        End If
        DTUser.DefaultView.RowFilter = Filter
    End Sub

    Private Sub SearchBunifuTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles SearchBunifuTextBox.KeyUp
        Search()
    End Sub

    Private Sub InsertBunifuButton_Click(sender As Object, e As EventArgs) Handles InsertBunifuButton.Click
        Dim usersInsert As New UsersInsertUpdate(Me, 1, New User())
        usersInsert.ShowDialog()
    End Sub

    Private Sub UpdateBunifuButton_Click(sender As Object, e As EventArgs) Handles UpdateBunifuButton.Click
        If UsersBunifuDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = UsersBunifuDataGridView.SelectedRows(0)

            user = New User
            user.UserID = selectedRow.Cells("UserIDCol").Value.ToString()
            user.UserNames = selectedRow.Cells("UserNamesCol").Value.ToString()
            user.UserAddress = selectedRow.Cells("UserAddressCol").Value.ToString()
            user.UserEmail = selectedRow.Cells("UserEmailCol").Value.ToString()
            user.UserPhone = selectedRow.Cells("UserPhoneCol").Value.ToString()
            user.UserRoleStr = selectedRow.Cells("UserRoleStrCol").Value.ToString()
            user.Username = selectedRow.Cells("UsernameCol").Value.ToString()
            user.UserImage = CType(selectedRow.Cells("UserImageCol").Value, Byte())
            user.UserStatusStr = selectedRow.Cells("UserStatusStrCol").Value
            user.UserRoleInt = Convert.ToInt32(selectedRow.Cells("UserRoleIntCol").Value)
            user.UserStatusInt = Convert.ToInt32(selectedRow.Cells("UserStatusIntCol").Value)

            Dim usersUpdate As New UsersInsertUpdate(Me, 2, user)
            usersUpdate.ShowDialog()
        End If
    End Sub

    Private Sub DeleteBunifuButton_Click(sender As Object, e As EventArgs) Handles DeleteBunifuButton.Click
        Dim Result As String

        If UsersBunifuDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = UsersBunifuDataGridView.SelectedRows(0)

            user = New User
            user.UserID = selectedRow.Cells("UserIDCol").Value.ToString()
            user.UserNames = selectedRow.Cells("UserNamesCol").Value.ToString()
            user.UserAddress = selectedRow.Cells("UserAddressCol").Value.ToString()
            user.UserEmail = selectedRow.Cells("UserEmailCol").Value.ToString()
            user.UserPhone = selectedRow.Cells("UserPhoneCol").Value.ToString()
            user.UserRoleStr = selectedRow.Cells("UserRoleStrCol").Value.ToString()
            user.Username = selectedRow.Cells("UsernameCol").Value.ToString()
            user.UserImage = CType(selectedRow.Cells("UserImageCol").Value, Byte())
            user.UserStatusStr = selectedRow.Cells("UserStatusStrCol").Value
            user.UserRoleInt = Convert.ToInt32(selectedRow.Cells("UserRoleIntCol").Value)
            user.UserStatusInt = Convert.ToInt32(selectedRow.Cells("UserStatusIntCol").Value)

            Dim dialogResult As DialogResult = MessageBox.Show("Are sure want deleting the data with name " & user.UserNames & "?", "Confirmation Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If dialogResult = DialogResult.Yes Then
                Result = My.Application.DBA.UsersDelete(user)
                If Result = "User data has been successfully deleted to the database." Then
                    ShowMessage(Result, 1)
                    RefreshData()
                Else
                    ShowMessage(Result, 4)
                End If
            End If
        End If
    End Sub

    Private Sub DetailBunifuButton_Click(sender As Object, e As EventArgs) Handles DetailBunifuButton.Click
        If UsersBunifuDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = UsersBunifuDataGridView.SelectedRows(0)

            user = New User
            user.UserID = selectedRow.Cells("UserIDCol").Value.ToString()
            user.UserNames = selectedRow.Cells("UserNamesCol").Value.ToString()
            user.UserAddress = selectedRow.Cells("UserAddressCol").Value.ToString()
            user.UserEmail = selectedRow.Cells("UserEmailCol").Value.ToString()
            user.UserPhone = selectedRow.Cells("UserPhoneCol").Value.ToString()
            user.UserRoleStr = selectedRow.Cells("UserRoleStrCol").Value.ToString()
            user.Username = selectedRow.Cells("UsernameCol").Value.ToString()
            user.UserImage = CType(selectedRow.Cells("UserImageCol").Value, Byte())
            user.UserStatusStr = selectedRow.Cells("UserStatusStrCol").Value
            user.UserRoleInt = Convert.ToInt32(selectedRow.Cells("UserRoleIntCol").Value)
            user.UserStatusInt = Convert.ToInt32(selectedRow.Cells("UserStatusIntCol").Value)

            Dim usersDetail As New UsersInsertUpdate(Me, 3, user)
            usersDetail.ShowDialog()
        End If
    End Sub

    Private Sub ReportBunifuButton_Click(sender As Object, e As EventArgs) Handles ReportBunifuButton.Click
        Dim ReportPath As String = Application.StartupPath & "\Report\UsersReport.rdlc"
        Dim ReportFile As New StreamReader(ReportPath)
        Dim UsersReport As New LocalReport

        UsersReport.ReportPath = ReportPath
        UsersReport.LoadReportDefinition(ReportFile)

        Dim ReportDataSet As New ReportDataSet
        ReportDataSet.Tables("Users").Merge(DTUser)
        Dim UsersDataSource As New ReportDataSource("ReportDataSet", ReportDataSet.Tables("Users"))
        UsersReport.DataSources.Add(UsersDataSource)

        Dim RP As New ReportPrinting(UsersReport)
        RP.Print()
    End Sub
End Class