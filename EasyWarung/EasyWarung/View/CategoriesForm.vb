Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class CategoriesForm
    Dim MyParent As New DashboardForm
    Dim DTCategory As New DataTable
    Dim category As Category

    Sub New(MyParent As DashboardForm)
        InitializeComponent()
        Me.MyParent = MyParent
        RefreshData()
    End Sub

    Public Sub ShowMessage(Message As String, Type As Integer)
        MyParent.ShowMessage(Message, Type)
    End Sub

    Public Sub RefreshData()
        DTCategory = My.Application.DBA.CategoriesList()
        If DTCategory.Rows.Count = 0 Then
            CategoriesBunifuDataGridView.Visible = False
        Else
            CategoriesBunifuDataGridView.DataSource = DTCategory
            CategoriesBunifuDataGridView.Visible = True
        End If
    End Sub

    Private Sub Search()
        If Not String.IsNullOrEmpty(SearchBunifuTextBox.Text) And Not String.IsNullOrWhiteSpace(SearchBunifuTextBox.Text) Then
            DTCategory.DefaultView.RowFilter = "[CategoryName] LIKE ('%" & SearchBunifuTextBox.Text.Trim() & "%')"
        Else
            DTCategory.DefaultView.RowFilter = ""
        End If
    End Sub

    Private Sub SearchBunifuTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles SearchBunifuTextBox.KeyUp
        Search()
    End Sub

    Private Sub InsertBunifuButton_Click(sender As Object, e As EventArgs) Handles InsertBunifuButton.Click
        Dim categoriesInsert As New CategoriesInsertUpdate(Me, 1, New Category)
        categoriesInsert.ShowDialog()
    End Sub

    Private Sub UpdateBunifuButton_Click(sender As Object, e As EventArgs) Handles UpdateBunifuButton.Click
        If CategoriesBunifuDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = CategoriesBunifuDataGridView.SelectedRows(0)

            category = New Category
            category.No = Convert.ToInt32(selectedRow.Cells("NoCategoryCol").Value)
            category.CategoryID = Convert.ToInt32(selectedRow.Cells("CategoryIDCol").Value)
            category.CategoryName = selectedRow.Cells("CategoryNameCol").Value.ToString()
            category.CategoryStatusInt = Convert.ToInt32(selectedRow.Cells("CategoryStatusIntCol").Value)
            category.CategoryStatusStr = selectedRow.Cells("CategoryStatusStrCol").Value.ToString()

            Dim categoriesUpdate As New CategoriesInsertUpdate(Me, 2, category)
            categoriesUpdate.ShowDialog()
        End If
    End Sub

    Private Sub DeleteBunifuButton_Click(sender As Object, e As EventArgs) Handles DeleteBunifuButton.Click
        Dim Result As String

        If CategoriesBunifuDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = CategoriesBunifuDataGridView.SelectedRows(0)

            category = New Category
            category.No = Convert.ToInt32(selectedRow.Cells("NoCategoryCol").Value)
            category.CategoryID = Convert.ToInt32(selectedRow.Cells("CategoryIDCol").Value)
            category.CategoryName = selectedRow.Cells("CategoryNameCol").Value.ToString()
            category.CategoryStatusInt = Convert.ToInt32(selectedRow.Cells("CategoryStatusIntCol").Value)
            category.CategoryStatusStr = selectedRow.Cells("CategoryStatusStrCol").Value.ToString()

            Dim dialogResult As DialogResult = MessageBox.Show("Are sure want deleting the data with name " & category.CategoryName & "?", "Confirmation Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If dialogResult = DialogResult.Yes Then
                Result = My.Application.DBA.CategoriesDelete(category)
                If Result = "Category data has been successfully deleted to the database." Then
                    ShowMessage(Result, 1)
                    RefreshData()
                Else
                    ShowMessage(Result, 4)
                End If
            End If
        End If
    End Sub

    Private Sub DetailBunifuButton_Click(sender As Object, e As EventArgs) Handles DetailBunifuButton.Click
        If CategoriesBunifuDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = CategoriesBunifuDataGridView.SelectedRows(0)

            category = New Category
            category.No = Convert.ToInt32(selectedRow.Cells("NoCategoryCol").Value)
            category.CategoryID = Convert.ToInt32(selectedRow.Cells("CategoryIDCol").Value)
            category.CategoryName = selectedRow.Cells("CategoryNameCol").Value.ToString()
            category.CategoryStatusInt = Convert.ToInt32(selectedRow.Cells("CategoryStatusIntCol").Value)
            category.CategoryStatusStr = selectedRow.Cells("CategoryStatusStrCol").Value.ToString()

            Dim categoriesDetail As New CategoriesInsertUpdate(Me, 3, category)
            categoriesDetail.ShowDialog()
        End If
    End Sub

    Private Sub ReportBunifuButton_Click(sender As Object, e As EventArgs) Handles ReportBunifuButton.Click
        Dim ReportPath As String = Application.StartupPath & "\Report\CategoriesReport.rdlc"
        Dim ReportFile As New StreamReader(ReportPath)
        Dim CategoriesReport As New LocalReport

        CategoriesReport.ReportPath = ReportPath
        CategoriesReport.LoadReportDefinition(ReportFile)

        Dim ReportDataSet As New ReportDataSet
        ReportDataSet.Tables("Categories").Merge(DTCategory)
        Dim CategoriesDataSource As New ReportDataSource("ReportDataSet", ReportDataSet.Tables("Categories"))
        CategoriesReport.DataSources.Add(CategoriesDataSource)

        Dim RP As New ReportPrinting(CategoriesReport)
        RP.Print()
    End Sub
End Class