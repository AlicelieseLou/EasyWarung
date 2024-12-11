Public Class CategoriesInsertUpdate
    Private categoriesForm As CategoriesForm
    Private Request As Integer
    Private Category As Category

    Public Sub New(categoriesForm As CategoriesForm, Request As Integer, Category As Category)
        InitializeComponent()
        Me.categoriesForm = categoriesForm
        Me.Request = Request
        Me.Category = Category

        If Request = 2 OrElse Request = 3 Then
            CategoryNameBunifuTextBox.Text = Category.CategoryName
            If Request = 3 Then
                CategoryNameBunifuTextBox.Enabled = False
                SaveBunifuButton.Visible = False
            End If
        End If
    End Sub

    Private Sub SaveBunifuButton_Click(sender As Object, e As EventArgs) Handles SaveBunifuButton.Click
        Dim Result As String

        If Not String.IsNullOrEmpty(CategoryNameBunifuTextBox.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(CategoryNameBunifuTextBox.Text.Trim()) Then
            Category.CategoryName = CategoryNameBunifuTextBox.Text.Trim()
            If Request = 1 Then
                Result = My.Application.DBA.CategoriesInsert(Category)
                If Result = "Category data has been successfully added to the database." Then
                    categoriesForm.ShowMessage(Result, 1)
                    categoriesForm.RefreshData()
                    Close()
                Else
                    categoriesForm.ShowMessage(Result, 4)
                End If
            Else
                Result = My.Application.DBA.CategoriesUpdate(Category)
                If Result = "Category data has been successfully updated to the database." Then
                    categoriesForm.ShowMessage(Result, 1)
                    categoriesForm.RefreshData()
                    Close()
                Else
                    categoriesForm.ShowMessage(Result, 4)
                End If
            End If
        Else
            categoriesForm.ShowMessage("All fields must be completed before proceeding.", 3)
        End If
    End Sub

    Private Sub CancelBunifuButton_Click(sender As Object, e As EventArgs) Handles CancelBunifuButton.Click
        Close()
    End Sub
End Class