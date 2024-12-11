Imports Microsoft.Reporting.WinForms
Imports System.IO

Public Class OrdersForm
    Dim MyParent As New DashboardForm
    Dim DTOrder As New DataTable
    Dim order As Order

    Sub New(MyParent As DashboardForm)
        InitializeComponent()
        Me.MyParent = MyParent
        RefreshData()
    End Sub

    Public Sub ShowMessage(Message As String, Type As Integer)
        MyParent.ShowMessage(Message, Type)
    End Sub

    Public Sub RefreshData()
        DTOrder = My.Application.DBA.OrdersList()
        If DTOrder.Rows.Count = 0 Then
            OrdersBunifuDataGridView.Visible = False
        Else
            OrdersBunifuDataGridView.DataSource = DTOrder
            OrdersBunifuDataGridView.Visible = True
        End If
    End Sub

    Private Sub Search()
        If Not String.IsNullOrEmpty(SearchBunifuTextBox.Text) And Not String.IsNullOrWhiteSpace(SearchBunifuTextBox.Text) Then
            Dim filter As String = "[OrderID] LIKE ('%" & SearchBunifuTextBox.Text.Trim() & "%') OR 
                                    [UserName] LIKE ('%" & SearchBunifuTextBox.Text.Trim() & "%') OR
                                    [PaymentName] LIKE ('%" & SearchBunifuTextBox.Text.Trim() & "%') OR
                                    [OrderStatusStr] LIKE ('%" & SearchBunifuTextBox.Text.Trim() & "%') OR
                                    [GrandTotal] LIKE ('%" & SearchBunifuTextBox.Text.Trim() & "%')"

            DTOrder.DefaultView.RowFilter = filter
        Else
            DTOrder.DefaultView.RowFilter = ""
        End If
    End Sub

    Private Sub SearchBunifuTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles SearchBunifuTextBox.KeyUp
        Search()
    End Sub

    Private Sub OrderStatusUpdate(Status As Integer)
        Dim Result As String

        Result = My.Application.DBA.OrderStatusUpdate(order, Status)
        If Result = "Order status has been successfully updated to the database." Then
            ShowMessage(Result, 1)
            RefreshData()
        Else
            ShowMessage(Result, 4)
        End If
    End Sub

    Private Sub InsertBunifuButton_Click(sender As Object, e As EventArgs) Handles InsertBunifuButton.Click
        Dim ordersInsert As New OrdersInsertUpdate(Me, 1, New Order)
        ordersInsert.ShowDialog()
    End Sub

    Private Sub UpdateBunifuButton_Click(sender As Object, e As EventArgs) Handles UpdateBunifuButton.Click
        If OrdersBunifuDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = OrdersBunifuDataGridView.SelectedRows(0)

            order.No = Convert.ToInt32(selectedRow.Cells("NoOrderCol").Value)
            order.OrderID = selectedRow.Cells("OrderIDCol").Value.ToString()
            order.OrderDateTime = Convert.ToDateTime(selectedRow.Cells("OrderDateTimeCol").Value)
            order.UserID = selectedRow.Cells("UserIDOrderCol").Value.ToString()
            order.UserName = selectedRow.Cells("UserNameOrderCol").Value.ToString()
            order.PaymentID = Convert.ToInt32(selectedRow.Cells("PaymentIDCol").Value)
            order.PaymentName = selectedRow.Cells("PaymentNameCol").Value.ToString()
            order.OrderStatusStr = selectedRow.Cells("OrderStatusStrCol").Value.ToString()
            order.OrderStatusInt = Convert.ToInt32(selectedRow.Cells("OrderStatusIntCol").Value)
            order.GrandTotal = selectedRow.Cells("GrandTotalCol").Value.ToString()

            Dim ordersUpdate As New OrdersInsertUpdate(Me, 2, order)
            ordersUpdate.ShowDialog()
        End If
    End Sub

    Private Sub DeleteBunifuButton_Click(sender As Object, e As EventArgs) Handles DeleteBunifuButton.Click
        If OrdersBunifuDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = OrdersBunifuDataGridView.SelectedRows(0)

            order.No = Convert.ToInt32(selectedRow.Cells("NoOrderCol").Value)
            order.OrderID = selectedRow.Cells("OrderIDCol").Value.ToString()
            order.OrderDateTime = Convert.ToDateTime(selectedRow.Cells("OrderDateTimeCol").Value)
            order.UserID = selectedRow.Cells("UserIDOrderCol").Value.ToString()
            order.UserName = selectedRow.Cells("UserNameOrderCol").Value.ToString()
            order.PaymentID = Convert.ToInt32(selectedRow.Cells("PaymentIDCol").Value)
            order.PaymentName = selectedRow.Cells("PaymentNameCol").Value.ToString()
            order.OrderStatusStr = selectedRow.Cells("OrderStatusStrCol").Value.ToString()
            order.OrderStatusInt = Convert.ToInt32(selectedRow.Cells("OrderStatusIntCol").Value)
            order.GrandTotal = selectedRow.Cells("GrandTotalCol").Value.ToString()

            Dim dialogResult As DialogResult = MessageBox.Show("Are sure want deleting the order with ID: " & order.OrderID & "?", "Confirmation Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If dialogResult = DialogResult.Yes Then
                OrderStatusUpdate(0)
            End If
        End If
    End Sub

    Private Sub DetailBunifuButton_Click(sender As Object, e As EventArgs) Handles DetailBunifuButton.Click
        If OrdersBunifuDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = OrdersBunifuDataGridView.SelectedRows(0)

            order.No = Convert.ToInt32(selectedRow.Cells("NoOrderCol").Value)
            order.OrderID = selectedRow.Cells("OrderIDCol").Value.ToString()
            order.OrderDateTime = Convert.ToDateTime(selectedRow.Cells("OrderDateTimeCol").Value)
            order.UserID = selectedRow.Cells("UserIDOrderCol").Value.ToString()
            order.UserName = selectedRow.Cells("UserNameOrderCol").Value.ToString()
            order.PaymentID = Convert.ToInt32(selectedRow.Cells("PaymentIDCol").Value)
            order.PaymentName = selectedRow.Cells("PaymentNameCol").Value.ToString()
            order.OrderStatusStr = selectedRow.Cells("OrderStatusStrCol").Value.ToString()
            order.OrderStatusInt = Convert.ToInt32(selectedRow.Cells("OrderStatusIntCol").Value)
            order.GrandTotal = selectedRow.Cells("GrandTotalCol").Value.ToString()

            Dim ordersDetail As New OrdersInsertUpdate(Me, 3, order)
            ordersDetail.ShowDialog()
        End If
    End Sub

    Private Sub ReportBunifuButton_Click(sender As Object, e As EventArgs) Handles ReportBunifuButton.Click
        Dim ReportPath As String = Application.StartupPath & "\Report\OrdersReport.rdlc"
        Dim ReportFile As New StreamReader(ReportPath)
        Dim OrdersReport As New LocalReport

        OrdersReport.ReportPath = ReportPath
        OrdersReport.LoadReportDefinition(ReportFile)

        Dim ReportDataSet As New ReportDataSet
        ReportDataSet.Tables("Orders").Merge(DTOrder)
        Dim OrdersDataSource As New ReportDataSource("ReportDataSet", ReportDataSet.Tables("Orders"))
        OrdersReport.DataSources.Add(OrdersDataSource)

        Dim RP As New ReportPrinting(OrdersReport)
        RP.Print()
    End Sub

    Private Sub OrdersBunifuDataGridView_MouseDown(sender As Object, e As MouseEventArgs) Handles OrdersBunifuDataGridView.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim HT As DataGridView.HitTestInfo
            HT = OrdersBunifuDataGridView.HitTest(e.X, e.Y)
            If HT.Type = DataGridViewHitTestType.Cell Then
                order.No = OrdersBunifuDataGridView.Item("NoOrderCol", HT.RowIndex).Value
                order.OrderID = OrdersBunifuDataGridView.Item("OrderIDCol", HT.RowIndex).Value
                order.OrderDateTime = OrdersBunifuDataGridView.Item("OrderDateTimeCol", HT.RowIndex).Value
                order.UserID = OrdersBunifuDataGridView.Item("UserIDOrderCol", HT.RowIndex).Value
                order.UserName = OrdersBunifuDataGridView.Item("UserNameOrderCol", HT.RowIndex).Value
                order.PaymentID = OrdersBunifuDataGridView.Item("PaymentIDCol", HT.RowIndex).Value
                order.PaymentName = OrdersBunifuDataGridView.Item("PaymentNameCol", HT.RowIndex).Value
                order.OrderStatusStr = OrdersBunifuDataGridView.Item("OrderStatusStrCol", HT.RowIndex).Value
                order.OrderStatusInt = OrdersBunifuDataGridView.Item("OrderStatusIntCol", HT.RowIndex).Value
                order.GrandTotal = OrdersBunifuDataGridView.Item("GrandTotalCol", HT.RowIndex).Value
                OrdersBunifuDataGridView.Rows(HT.RowIndex).Selected = True
                OrdersBunifuDataGridView.ContextMenuStrip = StatusContextMenuStrip
            Else
                OrdersBunifuDataGridView.ContextMenuStrip = Nothing
            End If
        Else
            OrdersBunifuDataGridView.ContextMenuStrip = Nothing
        End If
    End Sub

    Private Sub PendingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PendingToolStripMenuItem.Click
        OrderStatusUpdate(1)
    End Sub

    Private Sub PreparingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreparingToolStripMenuItem.Click
        OrderStatusUpdate(2)
    End Sub

    Private Sub ReadyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReadyToolStripMenuItem.Click
        OrderStatusUpdate(3)
    End Sub

    Private Sub DeliveredToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeliveredToolStripMenuItem.Click
        OrderStatusUpdate(4)
    End Sub

    Private Sub CompletedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompletedToolStripMenuItem.Click
        OrderStatusUpdate(5)
    End Sub
End Class