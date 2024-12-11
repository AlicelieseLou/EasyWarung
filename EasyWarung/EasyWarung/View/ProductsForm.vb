Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class ProductsForm
    Dim MyParent As New DashboardForm
    Dim DTProduct As New DataTable
    Dim product As Product

    Sub New(MyParent As DashboardForm)
        InitializeComponent()
        Me.MyParent = MyParent
        RefreshData()
    End Sub

    Public Sub ShowMessage(Message As String, Type As Integer)
        MyParent.ShowMessage(Message, Type)
    End Sub

    Public Sub RefreshData()
        DTProduct = My.Application.DBA.ProductsList()
        If DTProduct.Rows.Count = 0 Then
            ProductsBunifuDataGridView.Visible = False
        Else
            ProductsBunifuDataGridView.DataSource = DTProduct
            ProductsBunifuDataGridView.Visible = True
        End If
    End Sub

    Private Sub Search()
        If Not String.IsNullOrEmpty(SearchBunifuTextBox.Text) And Not String.IsNullOrWhiteSpace(SearchBunifuTextBox.Text) Then
            Dim filter As String = "[ProductID] LIKE ('%" & SearchBunifuTextBox.Text.Trim() & "%') OR 
                                    [ProductName] LIKE ('%" & SearchBunifuTextBox.Text.Trim() & "%') OR
                                    [ProductPriceStr] LIKE ('%" & SearchBunifuTextBox.Text.Trim() & "%') OR
                                    [CategoryName] LIKE ('%" & SearchBunifuTextBox.Text.Trim() & "%')"

            DTProduct.DefaultView.RowFilter = filter
        Else
            DTProduct.DefaultView.RowFilter = ""
        End If
    End Sub

    Private Sub SearchBunifuTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles SearchBunifuTextBox.KeyUp
        Search()
    End Sub

    Private Sub InsertBunifuButton_Click(sender As Object, e As EventArgs) Handles InsertBunifuButton.Click
        Dim productsInsert As New ProductsInsertUpdate(Me, 1, New Product)
        productsInsert.ShowDialog()
    End Sub

    Private Sub UpdateBunifuButton_Click(sender As Object, e As EventArgs) Handles UpdateBunifuButton.Click
        If ProductsBunifuDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = ProductsBunifuDataGridView.SelectedRows(0)

            product = New Product
            product.No = Convert.ToInt32(selectedRow.Cells("NoProductCol").Value)
            product.ProductID = selectedRow.Cells("ProductIDCol").Value.ToString()
            product.ProductName = selectedRow.Cells("ProductNameCol").Value.ToString()
            product.ProductPrice = Convert.ToDouble(selectedRow.Cells("ProductPriceCol").Value)
            product.ProductPriceStr = selectedRow.Cells("ProductPriceStrCol").Value.ToString()
            product.CategoryID = Convert.ToInt32(selectedRow.Cells("CategoryProductIDCol").Value)
            product.CategoryName = selectedRow.Cells("CategoryProductNameCol").Value.ToString()
            product.ProductImage = CType(selectedRow.Cells("ProductImageCol").Value, Byte())

            Dim productsUpdate As New ProductsInsertUpdate(Me, 2, product)
            productsUpdate.ShowDialog()
        End If
    End Sub

    Private Sub DeleteBunifuButton_Click(sender As Object, e As EventArgs) Handles DeleteBunifuButton.Click
        Dim Result As String

        If ProductsBunifuDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = ProductsBunifuDataGridView.SelectedRows(0)

            product = New Product
            product.No = Convert.ToInt32(selectedRow.Cells("NoProductCol").Value)
            product.ProductID = selectedRow.Cells("ProductIDCol").Value.ToString()
            product.ProductName = selectedRow.Cells("ProductNameCol").Value.ToString()
            product.ProductPrice = Convert.ToDouble(selectedRow.Cells("ProductPriceCol").Value)
            product.ProductPriceStr = selectedRow.Cells("ProductPriceStrCol").Value.ToString()
            product.CategoryID = Convert.ToInt32(selectedRow.Cells("CategoryProductIDCol").Value)
            product.CategoryName = selectedRow.Cells("CategoryProductNameCol").Value.ToString()
            product.ProductImage = CType(selectedRow.Cells("ProductImageCol").Value, Byte())

            Dim dialogResult As DialogResult = MessageBox.Show("Are sure want deleting the data with name " & product.ProductName & "?", "Confirmation Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If dialogResult = DialogResult.Yes Then
                Result = My.Application.DBA.ProductsDelete(product)
                If Result = "Product data has been successfully deleted to the database." Then
                    ShowMessage(Result, 1)
                    RefreshData()
                Else
                    ShowMessage(Result, 4)
                End If
            End If
        End If
    End Sub

    Private Sub DetailBunifuButton_Click(sender As Object, e As EventArgs) Handles DetailBunifuButton.Click
        If ProductsBunifuDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = ProductsBunifuDataGridView.SelectedRows(0)

            product = New Product
            product.No = Convert.ToInt32(selectedRow.Cells("NoProductCol").Value)
            product.ProductID = selectedRow.Cells("ProductIDCol").Value.ToString()
            product.ProductName = selectedRow.Cells("ProductNameCol").Value.ToString()
            product.ProductPrice = Convert.ToDouble(selectedRow.Cells("ProductPriceCol").Value)
            product.ProductPriceStr = selectedRow.Cells("ProductPriceStrCol").Value.ToString()
            product.CategoryID = Convert.ToInt32(selectedRow.Cells("CategoryProductIDCol").Value)
            product.CategoryName = selectedRow.Cells("CategoryProductNameCol").Value.ToString()
            product.ProductImage = CType(selectedRow.Cells("ProductImageCol").Value, Byte())

            Dim productsDetail As New ProductsInsertUpdate(Me, 3, product)
            productsDetail.ShowDialog()
        End If
    End Sub

    Private Sub ReportBunifuButton_Click(sender As Object, e As EventArgs) Handles ReportBunifuButton.Click
        Dim ReportPath As String = Application.StartupPath & "\Report\ProductsReport.rdlc"
        Dim ReportFile As New StreamReader(ReportPath)
        Dim ProductsReport As New LocalReport

        ProductsReport.ReportPath = ReportPath
        ProductsReport.LoadReportDefinition(ReportFile)

        Dim ReportDataSet As New ReportDataSet
        ReportDataSet.Tables("Products").Merge(DTProduct)
        Dim ProductsDataSource As New ReportDataSource("ReportDataSet", ReportDataSet.Tables("Products"))
        ProductsReport.DataSources.Add(ProductsDataSource)

        Dim RP As New ReportPrinting(ProductsReport)
        RP.Print()
    End Sub
End Class