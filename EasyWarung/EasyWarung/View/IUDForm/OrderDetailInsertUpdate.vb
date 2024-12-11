Imports Bunifu.UI.WinForms

Public Class OrderDetailInsertUpdate
    Dim ordersInsertUpdateForm As OrdersInsertUpdate
    Dim Request As Integer
    Dim order As Order
    Dim orderDetail As OrderDetail

    Dim DTProduct As New DataTable

    Sub New(ordersInsertUpdateForm As OrdersInsertUpdate, Request As Integer, order As Order, orderDetail As OrderDetail)
        InitializeComponent()
        Me.ordersInsertUpdateForm = ordersInsertUpdateForm
        Me.Request = Request
        Me.order = order
        Me.orderDetail = orderDetail

        DTProduct = My.Application.DBA.ProductsList()
        With ProductNameBunifuDropdown
            .DataSource = DTProduct
            .DisplayMember = "ProductName"
            .ValueMember = "ProductID"
            .SelectedIndex = -1
        End With

        If Request = 2 Then
            ProductNameBunifuDropdown.SelectedValue = orderDetail.ProductID
            If ProductNameBunifuDropdown.SelectedIndex >= 0 Then
                If SamePriceBunifuCheckBox.Checked = True Then
                    Dim ProductID As String = ProductNameBunifuDropdown.SelectedValue.ToString()

                    For Each row As DataRow In DTProduct.Rows
                        If row("ProductID").ToString() = ProductID Then
                            Dim ProductPrice As String = row("ProductPrice").ToString()
                            If Not ProductPrice = orderDetail.ProductPrice Then
                                SamePriceBunifuCheckBox.Checked = False
                            End If
                            Exit For
                        End If
                    Next
                Else
                    ProductPriceBunifuTextBox.Clear()
                End If
            End If

            ProductPriceBunifuTextBox.Text = orderDetail.ProductPrice
            ProductAmountBunifuTextBox.Text = orderDetail.OrderAmount
        End If
    End Sub

    Private Sub ProductNameBunifuDropdown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProductNameBunifuDropdown.SelectedIndexChanged
        If ProductNameBunifuDropdown.SelectedIndex >= 0 Then
            If SamePriceBunifuCheckBox.Checked = True Then
                Dim ProductID As String = ProductNameBunifuDropdown.SelectedValue.ToString()

                For Each row As DataRow In DTProduct.Rows
                    If row("ProductID").ToString() = ProductID Then
                        Dim ProductPrice As String = row("ProductPrice").ToString()
                        ProductPriceBunifuTextBox.Text = ProductPrice
                        Exit For
                    End If
                Next
            Else
                ProductPriceBunifuTextBox.Clear()
            End If
        End If
    End Sub

    Private Sub SamePriceBunifuCheckBox_CheckedChanged(sender As Object, e As BunifuCheckBox.CheckedChangedEventArgs) Handles SamePriceBunifuCheckBox.CheckedChanged
        ProductNameBunifuDropdown_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub SaveBunifuButton_Click(sender As Object, e As EventArgs) Handles SaveBunifuButton.Click
        Dim Result As String

        If ProductNameBunifuDropdown.SelectedIndex >= 0 AndAlso
           Not String.IsNullOrEmpty(ProductPriceBunifuTextBox.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(ProductPriceBunifuTextBox.Text.Trim()) AndAlso
           Not String.IsNullOrEmpty(ProductAmountBunifuTextBox.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(ProductAmountBunifuTextBox.Text.Trim()) Then

            Dim ProductPrice As Double
            Dim OrderAmount As Integer

            If Double.TryParse(ProductPriceBunifuTextBox.Text.Trim(), ProductPrice) Then
                If Integer.TryParse(ProductAmountBunifuTextBox.Text.Trim(), OrderAmount) Then

                    orderDetail.ProductID = ProductNameBunifuDropdown.SelectedValue.ToString()
                    orderDetail.ProductPrice = ProductPrice
                    orderDetail.OrderAmount = OrderAmount

                    If Request = 1 Then
                        Result = My.Application.DBA.OrderDetailInsert(order, orderDetail)
                        If Result = "Order Detail data has been successfully added to the database." Then
                            ordersInsertUpdateForm.ShowMessage("Order Detail data has been successfully added to the order table.", 1)
                            ordersInsertUpdateForm.RefreshData()
                            Close()
                        Else
                            ordersInsertUpdateForm.ShowMessage(Result, 4)
                        End If
                    Else
                        Result = My.Application.DBA.OrderDetailUpdate(order, orderDetail)
                        If Result = "Order Detail data has been successfully updated to the database." Then
                            ordersInsertUpdateForm.ShowMessage("Order Detail data has been successfully updated to the order table.", 1)
                            ordersInsertUpdateForm.RefreshData()
                            Close()
                        Else
                            ordersInsertUpdateForm.ShowMessage(Result, 4)
                        End If
                    End If
                Else
                    ordersInsertUpdateForm.ShowMessage("Please enter a valid product amount (numeric).", 3)
                End If
            Else
                ordersInsertUpdateForm.ShowMessage("Please enter a valid product price (numeric).", 3)
            End If
        Else
            ordersInsertUpdateForm.ShowMessage("All fields must be completed before proceeding.", 3)
        End If
    End Sub

    Private Sub CancelBunifuButton_Click(sender As Object, e As EventArgs) Handles CancelBunifuButton.Click
        Close()
    End Sub
End Class