Imports System.IO

Public Class ProductsInsertUpdate
    Private productsForm As ProductsForm
    Private Request As Integer
    Private product As Product

    Private openFileDialog As New OpenFileDialog
    Private DTCategory As New DataTable

    Public Sub New(productsForm As ProductsForm, Request As Integer, product As Product)
        InitializeComponent()
        Me.productsForm = productsForm
        Me.Request = Request
        Me.product = product

        DTCategory = My.Application.DBA.CategoriesList()
        With CategoryBunifuDropdown
            .DataSource = DTCategory
            .DisplayMember = "CategoryName"
            .ValueMember = "CategoryID"
            .SelectedIndex = -1
        End With

        If Request = 2 OrElse Request = 3 Then
            ProductNameBunifuTextBox.Text = product.ProductName
            ProductPriceBunifuTextBox.Text = Convert.ToString(product.ProductPrice)
            CategoryBunifuDropdown.SelectedIndex = product.CategoryID - 1

            Using MemoryStream As New MemoryStream(product.ProductImage, 0, product.ProductImage.Length)
                MemoryStream.Write(product.ProductImage, 0, product.ProductImage.Length)
                ProductBunifuPictureBox.Image = Image.FromStream(MemoryStream)
            End Using

            If Request = 3 Then
                ProductNameBunifuTextBox.Enabled = False
                ProductPriceBunifuTextBox.Enabled = False
                CategoryBunifuDropdown.Enabled = False
                ProductBunifuPictureBox.Enabled = False
                SaveBunifuButton.Visible = False
            End If
        End If
    End Sub

    Private Sub ProductBunifuPictureBox_Click(sender As Object, e As EventArgs) Handles ProductBunifuPictureBox.Click
        openFileDialog.Multiselect = False
        openFileDialog.Title = "Select an image for the product."
        openFileDialog.InitialDirectory = Environment.SpecialFolder.CommonPictures
        openFileDialog.Filter = "Image File|*.jpg;*.jpeg;*.png;*.bmp"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ProductBunifuPictureBox.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub SaveBunifuButton_Click(sender As Object, e As EventArgs) Handles SaveBunifuButton.Click
        Dim Result As String

        If Not String.IsNullOrEmpty(ProductNameBunifuTextBox.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(ProductNameBunifuTextBox.Text.Trim()) AndAlso
           Not String.IsNullOrEmpty(ProductPriceBunifuTextBox.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(ProductPriceBunifuTextBox.Text.Trim()) AndAlso
           Not CategoryBunifuDropdown.SelectedIndex = -1 AndAlso
           (If(Request = 1, Not String.IsNullOrEmpty(openFileDialog.FileName) AndAlso Not String.IsNullOrWhiteSpace(openFileDialog.FileName), True)) Then
            product.ProductName = ProductNameBunifuTextBox.Text.Trim()
            product.ProductPrice = Convert.ToDouble(ProductPriceBunifuTextBox.Text.Trim())
            product.CategoryID = CategoryBunifuDropdown.SelectedIndex + 1

            Try
                Dim MemoryStream As New MemoryStream()
                ProductBunifuPictureBox.Image.Save(MemoryStream, ProductBunifuPictureBox.Image.RawFormat)
                If product.ProductImage IsNot MemoryStream.GetBuffer() Then
                    product.ProductImage = MemoryStream.GetBuffer()
                End If
            Catch ex As Exception

            End Try

            If Request = 1 Then
                Result = My.Application.DBA.ProductsInsert(product)
                If Result = "Product data has been successfully added to the database." Then
                    productsForm.ShowMessage(Result, 1)
                    productsForm.RefreshData()
                    Close()
                Else
                    productsForm.ShowMessage(Result, 4)
                End If
            Else
                Result = My.Application.DBA.ProductsUpdate(product)
                If Result = "Product data has been successfully updated to the database." Then
                    productsForm.ShowMessage(Result, 1)
                    productsForm.RefreshData()
                    Close()
                Else
                    productsForm.ShowMessage(Result, 4)
                End If
            End If
        Else
            productsForm.ShowMessage("All fields must be completed before proceeding.", 3)
        End If
    End Sub

    Private Sub CancelBunifuButton_Click(sender As Object, e As EventArgs) Handles CancelBunifuButton.Click
        Close()
    End Sub
End Class