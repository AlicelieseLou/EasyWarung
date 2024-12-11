Imports Microsoft.Reporting.WinForms
Imports System.IO

Public Class OrdersInsertUpdate
    Dim ordersForm As OrdersForm
    Dim Request As Integer
    Dim order As Order
    Dim orderDetail As OrderDetail

    Dim Result As String
    Dim DTPayment As New DataTable
    Dim DTOrderDetail As New DataTable

    Sub New(ordersForm As OrdersForm, Request As Integer, order As Order)
        InitializeComponent()
        Me.ordersForm = ordersForm
        Me.Request = Request
        Me.order = order

        DTPayment = My.Application.DBA.PaymentsList()
        With PaymentBunifuDropdown
            .DataSource = DTPayment
            .DisplayMember = "PaymentName"
            .ValueMember = "PaymentID"
            .SelectedIndex = 0
        End With

        If Request = 1 Then
            OrderIDBunifuTextBox.Text = My.Application.DBA.IndextationIDGetter(3, 0, DateTime.Now)
            UserNameBunifuTextBox.Text = My.Application.User.UserNames
            OrderDateBunifuDatePicker.Value = DateTime.Now
            OrderDateBunifuDatePicker.CustomFormat = "dd MMMM yyyy HH:mm:ss"

            Me.order.OrderID = OrderIDBunifuTextBox.Text
            Me.order.UserID = My.Application.User.UserID
            Me.order.PaymentID = PaymentBunifuDropdown.SelectedIndex + 1
            Me.order.OrderDateTime = Convert.ToDateTime(OrderDateBunifuDatePicker.Value)

            Result = My.Application.DBA.OrdersInsert(Me.order)
            If Result = "Order data has been successfully added to the database." Then
                ordersForm.ShowMessage("Order Successfully placed.", 1)
            Else
                ordersForm.ShowMessage(Result, 4)
            End If

        ElseIf Request = 2 OrElse Request = 3 Then
            OrderIDBunifuTextBox.Text = order.OrderID
            UserNameBunifuTextBox.Text = order.UserName
            OrderDateBunifuDatePicker.Value = order.OrderDateTime
            OrderDateBunifuDatePicker.CustomFormat = "dd MMMM yyyy HH:mm:ss"
            PaymentBunifuDropdown.SelectedIndex = order.PaymentID - 1

            If Request = 3 Then
                OrderIDBunifuTextBox.Enabled = False
                UserNameBunifuTextBox.Enabled = False
                OrderDateBunifuDatePicker.Enabled = False
                PaymentBunifuDropdown.Enabled = False
                OrderDetailBunifuDataGridView.Enabled = False
                InsertBunifuButton.Visible = False
                UpdateBunifuButton.Visible = False
                DeleteBunifuButton.Visible = False
                PrintReceiptBunifuCheckBox.Visible = False
                PrintReceiptBunifuLabel.Visible = False
                SaveBunifuButton.Visible = False
            End If
        End If

        RefreshData()
    End Sub

    Public Sub ShowMessage(Message As String, Type As Integer)
        ordersForm.ShowMessage(Message, Type)
    End Sub

    Public Sub RefreshData()
        DTOrderDetail = My.Application.DBA.OrderDetailListByID(order)

        If DTOrderDetail.Rows.Count = 0 Then
            OrderDetailBunifuDataGridView.Visible = False
        Else
            OrderDetailBunifuDataGridView.DataSource = DTOrderDetail
            OrderDetailBunifuDataGridView.Visible = True
        End If
    End Sub

    Private Sub InsertBunifuButton_Click(sender As Object, e As EventArgs) Handles InsertBunifuButton.Click
        Dim orderDetailInsert As New OrderDetailInsertUpdate(Me, 1, order, New OrderDetail)
        orderDetailInsert.ShowDialog()
    End Sub

    Private Sub UpdateBunifuButton_Click(sender As Object, e As EventArgs) Handles UpdateBunifuButton.Click
        If OrderDetailBunifuDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = OrderDetailBunifuDataGridView.SelectedRows(0)

            orderDetail = New OrderDetail
            orderDetail.No = Convert.ToInt32(selectedRow.Cells("NoOrderDetailCol").Value)
            orderDetail.DetailID = Convert.ToInt32(selectedRow.Cells("DetailIDCol").Value)
            orderDetail.ProductName = selectedRow.Cells("ProductNameOrderDetailCol").Value.ToString()
            orderDetail.ProductPrice = Convert.ToDouble(selectedRow.Cells("ProductPriceOrderDetailCol").Value)
            orderDetail.OrderAmount = Convert.ToInt32(selectedRow.Cells("OrderAmountCol").Value)
            orderDetail.Subtotal = selectedRow.Cells("SubtotalCol").Value.ToString()
            orderDetail.ProductID = selectedRow.Cells("ProductIDOrderDetailCol").Value.ToString()

            Dim orderDetailUpdate As New OrderDetailInsertUpdate(Me, 2, order, orderDetail)
            orderDetailUpdate.ShowDialog()
        End If
    End Sub

    Private Sub DeleteBunifuButton_Click(sender As Object, e As EventArgs) Handles DeleteBunifuButton.Click
        If OrderDetailBunifuDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = OrderDetailBunifuDataGridView.SelectedRows(0)

            orderDetail = New OrderDetail
            orderDetail.No = Convert.ToInt32(selectedRow.Cells("NoOrderDetailCol").Value)
            orderDetail.DetailID = Convert.ToInt32(selectedRow.Cells("DetailIDCol").Value)
            orderDetail.ProductName = selectedRow.Cells("ProductNameOrderDetailCol").Value.ToString()
            orderDetail.ProductPrice = Convert.ToDouble(selectedRow.Cells("ProductPriceOrderDetailCol").Value)
            orderDetail.OrderAmount = Convert.ToInt32(selectedRow.Cells("OrderAmountCol").Value)
            orderDetail.Subtotal = selectedRow.Cells("SubtotalCol").Value.ToString()
            orderDetail.ProductID = selectedRow.Cells("ProductIDOrderDetailCol").Value.ToString()

            Dim dialogResult As DialogResult = MessageBox.Show("Are sure want deleting the data with order product " & orderDetail.ProductName & " with price " & Convert.ToString(orderDetail.ProductPrice) & "?", "Confirmation Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If dialogResult = DialogResult.Yes Then
                Result = My.Application.DBA.OrderDetailDelete(orderDetail)
                If Result = "Order Detail data has been successfully deleted to the database." Then
                    ShowMessage("Order Detail data has been successfully deleted from table.", 1)
                    RefreshData()
                Else
                    ShowMessage(Result, 4)
                End If
            End If
        End If
    End Sub

    Private Sub SaveBunifuButton_Click(sender As Object, e As EventArgs) Handles SaveBunifuButton.Click
        Dim Result As String

        If OrderDetailBunifuDataGridView.Rows.Count > 0 Then
            order.OrderID = OrderIDBunifuTextBox.Text
            order.UserID = My.Application.User.UserID
            order.PaymentID = PaymentBunifuDropdown.SelectedIndex + 1
            order.OrderDateTime = Convert.ToDateTime(OrderDateBunifuDatePicker.Value)
            Result = My.Application.DBA.OrdersUpdate(order)

            If Result = "Order data has been successfully updated to the database." Then
                If PrintReceiptBunifuCheckBox.Checked = True Then
                    Dim Parameter As New List(Of ReportParameter)
                    Parameter.Add(New ReportParameter("ORDERID", order.OrderID.ToString()))
                    Parameter.Add(New ReportParameter("USERNAME", My.Application.User.Username.ToString()))
                    Parameter.Add(New ReportParameter("ORDERDATE", order.OrderDateTime.ToString("dd MMMM yyyy HH:mm:ss")))
                    Parameter.Add(New ReportParameter("PAYMENTTYPE", CType(PaymentBunifuDropdown.SelectedItem, DataRowView)("PaymentName").ToString()))

                    Dim DTOrder As DataTable = My.Application.DBA.OrdersList()
                    DTOrder.DefaultView.RowFilter = "[OrderID] LIKE ('%" & order.OrderID.ToString() & "%')"
                    Dim GrandTotal As String = DTOrder.DefaultView(0)("GrandTotal")
                    Parameter.Add(New ReportParameter("GRANDTOTAL", GrandTotal.ToString()))

                    Dim ReportPath As String = Application.StartupPath & "\Report\OrderReceipt.rdlc"
                    Dim ReportFile As New StreamReader(ReportPath)
                    Dim OrderReceipt As New LocalReport

                    OrderReceipt.ReportPath = ReportPath
                    OrderReceipt.LoadReportDefinition(ReportFile)
                    OrderReceipt.SetParameters(Parameter)

                    Dim ReportDataSet As New ReportDataSet
                    ReportDataSet.Tables("OrderDetail").Merge(DTOrderDetail)
                    Dim OrderReceiptDataSource As New ReportDataSource("ReportDataSet", ReportDataSet.Tables("OrderDetail"))
                    OrderReceipt.DataSources.Add(OrderReceiptDataSource)

                    Dim RP As New ReportPrinting(OrderReceipt)
                    RP.Print()
                End If

                ShowMessage("Order data has been successfully updated to the database.", 1)
                ordersForm.RefreshData()
                Close()
            Else
                ShowMessage("Order detail data must have data.", 3)
            End If
        Else

        End If
    End Sub

    Private Sub CancelBunifuButton_Click(sender As Object, e As EventArgs) Handles CancelBunifuButton.Click
        Dim Result As String

        If OrderDetailBunifuDataGridView.Rows.Count = 0 Then
            Result = My.Application.DBA.OrdersDelete(order)
        End If
        ordersForm.RefreshData()
        Close()
    End Sub
End Class