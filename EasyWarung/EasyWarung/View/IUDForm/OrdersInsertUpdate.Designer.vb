<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrdersInsertUpdate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrdersInsertUpdate))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim BorderEdges6 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges()
        Dim BorderEdges7 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges()
        Dim BorderEdges8 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges()
        Dim BorderEdges9 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges()
        Dim BorderEdges10 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges()
        Dim StateProperties9 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties10 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties11 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties12 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties13 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties14 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties15 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties16 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Me.OrderIDBunifuLabel = New Bunifu.UI.WinForms.BunifuLabel()
        Me.UserNameBunifuLabel = New Bunifu.UI.WinForms.BunifuLabel()
        Me.OrderDateBunifuLabel = New Bunifu.UI.WinForms.BunifuLabel()
        Me.PaymentBunifuLabel = New Bunifu.UI.WinForms.BunifuLabel()
        Me.PaymentBunifuDropdown = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.OrderDetailBunifuDataGridView = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.PrintReceiptBunifuLabel = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.OrderDateBunifuDatePicker = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.PrintReceiptBunifuCheckBox = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.SaveBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2()
        Me.CancelBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2()
        Me.UpdateBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2()
        Me.InsertBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2()
        Me.DeleteBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2()
        Me.UserNameBunifuTextBox = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.OrderIDBunifuTextBox = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.NoOrderDetailCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameOrderDetailCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductPriceOrderDetailCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderAmountCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailIDCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductIDOrderDetailCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.OrderDetailBunifuDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrderIDBunifuLabel
        '
        Me.OrderIDBunifuLabel.AllowParentOverrides = False
        Me.OrderIDBunifuLabel.AutoEllipsis = False
        Me.OrderIDBunifuLabel.AutoSize = False
        Me.OrderIDBunifuLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.OrderIDBunifuLabel.CursorType = System.Windows.Forms.Cursors.Default
        Me.OrderIDBunifuLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderIDBunifuLabel.ForeColor = System.Drawing.Color.Transparent
        Me.OrderIDBunifuLabel.Location = New System.Drawing.Point(44, 22)
        Me.OrderIDBunifuLabel.Name = "OrderIDBunifuLabel"
        Me.OrderIDBunifuLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OrderIDBunifuLabel.Size = New System.Drawing.Size(103, 25)
        Me.OrderIDBunifuLabel.TabIndex = 2
        Me.OrderIDBunifuLabel.Text = "Order ID: "
        Me.OrderIDBunifuLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.OrderIDBunifuLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'UserNameBunifuLabel
        '
        Me.UserNameBunifuLabel.AllowParentOverrides = False
        Me.UserNameBunifuLabel.AutoEllipsis = False
        Me.UserNameBunifuLabel.AutoSize = False
        Me.UserNameBunifuLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.UserNameBunifuLabel.CursorType = System.Windows.Forms.Cursors.Default
        Me.UserNameBunifuLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameBunifuLabel.ForeColor = System.Drawing.Color.Transparent
        Me.UserNameBunifuLabel.Location = New System.Drawing.Point(44, 72)
        Me.UserNameBunifuLabel.Name = "UserNameBunifuLabel"
        Me.UserNameBunifuLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UserNameBunifuLabel.Size = New System.Drawing.Size(103, 25)
        Me.UserNameBunifuLabel.TabIndex = 4
        Me.UserNameBunifuLabel.Text = "User Name: "
        Me.UserNameBunifuLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.UserNameBunifuLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'OrderDateBunifuLabel
        '
        Me.OrderDateBunifuLabel.AllowParentOverrides = False
        Me.OrderDateBunifuLabel.AutoEllipsis = False
        Me.OrderDateBunifuLabel.AutoSize = False
        Me.OrderDateBunifuLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.OrderDateBunifuLabel.CursorType = System.Windows.Forms.Cursors.Default
        Me.OrderDateBunifuLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderDateBunifuLabel.ForeColor = System.Drawing.Color.Transparent
        Me.OrderDateBunifuLabel.Location = New System.Drawing.Point(631, 22)
        Me.OrderDateBunifuLabel.Name = "OrderDateBunifuLabel"
        Me.OrderDateBunifuLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OrderDateBunifuLabel.Size = New System.Drawing.Size(103, 25)
        Me.OrderDateBunifuLabel.TabIndex = 6
        Me.OrderDateBunifuLabel.Text = "Order Date: "
        Me.OrderDateBunifuLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.OrderDateBunifuLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'PaymentBunifuLabel
        '
        Me.PaymentBunifuLabel.AllowParentOverrides = False
        Me.PaymentBunifuLabel.AutoEllipsis = False
        Me.PaymentBunifuLabel.AutoSize = False
        Me.PaymentBunifuLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.PaymentBunifuLabel.CursorType = System.Windows.Forms.Cursors.Default
        Me.PaymentBunifuLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentBunifuLabel.ForeColor = System.Drawing.Color.Transparent
        Me.PaymentBunifuLabel.Location = New System.Drawing.Point(631, 72)
        Me.PaymentBunifuLabel.Name = "PaymentBunifuLabel"
        Me.PaymentBunifuLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PaymentBunifuLabel.Size = New System.Drawing.Size(103, 25)
        Me.PaymentBunifuLabel.TabIndex = 8
        Me.PaymentBunifuLabel.Text = "Payment: "
        Me.PaymentBunifuLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.PaymentBunifuLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'PaymentBunifuDropdown
        '
        Me.PaymentBunifuDropdown.BackColor = System.Drawing.Color.Transparent
        Me.PaymentBunifuDropdown.BackgroundColor = System.Drawing.Color.White
        Me.PaymentBunifuDropdown.BorderColor = System.Drawing.Color.Silver
        Me.PaymentBunifuDropdown.BorderRadius = 1
        Me.PaymentBunifuDropdown.Color = System.Drawing.Color.Silver
        Me.PaymentBunifuDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.PaymentBunifuDropdown.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PaymentBunifuDropdown.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PaymentBunifuDropdown.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PaymentBunifuDropdown.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PaymentBunifuDropdown.DisabledIndicatorColor = System.Drawing.Color.DarkGray
        Me.PaymentBunifuDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.PaymentBunifuDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin
        Me.PaymentBunifuDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PaymentBunifuDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.PaymentBunifuDropdown.FillDropDown = True
        Me.PaymentBunifuDropdown.FillIndicator = False
        Me.PaymentBunifuDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PaymentBunifuDropdown.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentBunifuDropdown.ForeColor = System.Drawing.Color.Black
        Me.PaymentBunifuDropdown.FormattingEnabled = True
        Me.PaymentBunifuDropdown.Icon = Nothing
        Me.PaymentBunifuDropdown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.PaymentBunifuDropdown.IndicatorColor = System.Drawing.Color.DarkGray
        Me.PaymentBunifuDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.PaymentBunifuDropdown.IndicatorThickness = 2
        Me.PaymentBunifuDropdown.IsDropdownOpened = False
        Me.PaymentBunifuDropdown.ItemBackColor = System.Drawing.Color.White
        Me.PaymentBunifuDropdown.ItemBorderColor = System.Drawing.Color.White
        Me.PaymentBunifuDropdown.ItemForeColor = System.Drawing.Color.Black
        Me.PaymentBunifuDropdown.ItemHeight = 26
        Me.PaymentBunifuDropdown.ItemHighLightColor = System.Drawing.Color.DodgerBlue
        Me.PaymentBunifuDropdown.ItemHighLightForeColor = System.Drawing.Color.White
        Me.PaymentBunifuDropdown.ItemTopMargin = 3
        Me.PaymentBunifuDropdown.Location = New System.Drawing.Point(740, 68)
        Me.PaymentBunifuDropdown.Name = "PaymentBunifuDropdown"
        Me.PaymentBunifuDropdown.Size = New System.Drawing.Size(260, 32)
        Me.PaymentBunifuDropdown.TabIndex = 13
        Me.PaymentBunifuDropdown.Text = Nothing
        Me.PaymentBunifuDropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.PaymentBunifuDropdown.TextLeftMargin = 5
        '
        'OrderDetailBunifuDataGridView
        '
        Me.OrderDetailBunifuDataGridView.AllowCustomTheming = False
        Me.OrderDetailBunifuDataGridView.AllowUserToAddRows = False
        Me.OrderDetailBunifuDataGridView.AllowUserToDeleteRows = False
        Me.OrderDetailBunifuDataGridView.AllowUserToResizeColumns = False
        Me.OrderDetailBunifuDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.OrderDetailBunifuDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.OrderDetailBunifuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.OrderDetailBunifuDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.OrderDetailBunifuDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OrderDetailBunifuDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.OrderDetailBunifuDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OrderDetailBunifuDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.OrderDetailBunifuDataGridView.ColumnHeadersHeight = 40
        Me.OrderDetailBunifuDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoOrderDetailCol, Me.ProductNameOrderDetailCol, Me.ProductPriceOrderDetailCol, Me.OrderAmountCol, Me.SubtotalCol, Me.DetailIDCol, Me.ProductIDOrderDetailCol})
        Me.OrderDetailBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.OrderDetailBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.OrderDetailBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White
        Me.OrderDetailBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.OrderDetailBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.OrderDetailBunifuDataGridView.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.OrderDetailBunifuDataGridView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.OrderDetailBunifuDataGridView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.OrderDetailBunifuDataGridView.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.OrderDetailBunifuDataGridView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.OrderDetailBunifuDataGridView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.OrderDetailBunifuDataGridView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.OrderDetailBunifuDataGridView.CurrentTheme.Name = Nothing
        Me.OrderDetailBunifuDataGridView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.OrderDetailBunifuDataGridView.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.OrderDetailBunifuDataGridView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.OrderDetailBunifuDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.OrderDetailBunifuDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OrderDetailBunifuDataGridView.DefaultCellStyle = DataGridViewCellStyle6
        Me.OrderDetailBunifuDataGridView.EnableHeadersVisualStyles = False
        Me.OrderDetailBunifuDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.OrderDetailBunifuDataGridView.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.OrderDetailBunifuDataGridView.HeaderBgColor = System.Drawing.Color.Empty
        Me.OrderDetailBunifuDataGridView.HeaderForeColor = System.Drawing.Color.White
        Me.OrderDetailBunifuDataGridView.Location = New System.Drawing.Point(12, 177)
        Me.OrderDetailBunifuDataGridView.MultiSelect = False
        Me.OrderDetailBunifuDataGridView.Name = "OrderDetailBunifuDataGridView"
        Me.OrderDetailBunifuDataGridView.ReadOnly = True
        Me.OrderDetailBunifuDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OrderDetailBunifuDataGridView.RowHeadersVisible = False
        Me.OrderDetailBunifuDataGridView.RowTemplate.Height = 40
        Me.OrderDetailBunifuDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.OrderDetailBunifuDataGridView.Size = New System.Drawing.Size(988, 400)
        Me.OrderDetailBunifuDataGridView.TabIndex = 17
        Me.OrderDetailBunifuDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark
        '
        'PrintReceiptBunifuLabel
        '
        Me.PrintReceiptBunifuLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton
        Me.PrintReceiptBunifuLabel.AllowParentOverrides = False
        Me.PrintReceiptBunifuLabel.AutoEllipsis = False
        Me.PrintReceiptBunifuLabel.AutoSize = False
        Me.PrintReceiptBunifuLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.PrintReceiptBunifuLabel.CursorType = System.Windows.Forms.Cursors.Default
        Me.PrintReceiptBunifuLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.PrintReceiptBunifuLabel.ForeColor = System.Drawing.Color.Transparent
        Me.PrintReceiptBunifuLabel.Location = New System.Drawing.Point(50, 606)
        Me.PrintReceiptBunifuLabel.Name = "PrintReceiptBunifuLabel"
        Me.PrintReceiptBunifuLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PrintReceiptBunifuLabel.Size = New System.Drawing.Size(101, 25)
        Me.PrintReceiptBunifuLabel.TabIndex = 27
        Me.PrintReceiptBunifuLabel.Text = "Print Receipt"
        Me.PrintReceiptBunifuLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintReceiptBunifuLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.CursorType = Nothing
        Me.BunifuLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BunifuLabel2.Location = New System.Drawing.Point(323, 387)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(366, 25)
        Me.BunifuLabel2.TabIndex = 30
        Me.BunifuLabel2.Text = "Add new data to display the order detail list"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.CursorType = Nothing
        Me.BunifuLabel1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BunifuLabel1.Location = New System.Drawing.Point(364, 344)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(268, 31)
        Me.BunifuLabel1.TabIndex = 29
        Me.BunifuLabel1.Text = "The data is currently empty"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'OrderDateBunifuDatePicker
        '
        Me.OrderDateBunifuDatePicker.BackColor = System.Drawing.Color.White
        Me.OrderDateBunifuDatePicker.BorderColor = System.Drawing.Color.Silver
        Me.OrderDateBunifuDatePicker.BorderRadius = 1
        Me.OrderDateBunifuDatePicker.CalendarFont = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderDateBunifuDatePicker.Color = System.Drawing.Color.Silver
        Me.OrderDateBunifuDatePicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin
        Me.OrderDateBunifuDatePicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.OrderDateBunifuDatePicker.DisabledColor = System.Drawing.Color.Gray
        Me.OrderDateBunifuDatePicker.DisplayWeekNumbers = False
        Me.OrderDateBunifuDatePicker.DPHeight = 0
        Me.OrderDateBunifuDatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.OrderDateBunifuDatePicker.Enabled = False
        Me.OrderDateBunifuDatePicker.FillDatePicker = False
        Me.OrderDateBunifuDatePicker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.OrderDateBunifuDatePicker.ForeColor = System.Drawing.Color.Black
        Me.OrderDateBunifuDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.OrderDateBunifuDatePicker.Icon = CType(resources.GetObject("OrderDateBunifuDatePicker.Icon"), System.Drawing.Image)
        Me.OrderDateBunifuDatePicker.IconColor = System.Drawing.Color.Gray
        Me.OrderDateBunifuDatePicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.OrderDateBunifuDatePicker.LeftTextMargin = 5
        Me.OrderDateBunifuDatePicker.Location = New System.Drawing.Point(740, 18)
        Me.OrderDateBunifuDatePicker.MinimumSize = New System.Drawing.Size(4, 32)
        Me.OrderDateBunifuDatePicker.Name = "OrderDateBunifuDatePicker"
        Me.OrderDateBunifuDatePicker.Size = New System.Drawing.Size(260, 32)
        Me.OrderDateBunifuDatePicker.TabIndex = 28
        '
        'PrintReceiptBunifuCheckBox
        '
        Me.PrintReceiptBunifuCheckBox.AllowBindingControlAnimation = False
        Me.PrintReceiptBunifuCheckBox.AllowBindingControlColorChanges = False
        Me.PrintReceiptBunifuCheckBox.AllowBindingControlLocation = False
        Me.PrintReceiptBunifuCheckBox.AllowCheckBoxAnimation = False
        Me.PrintReceiptBunifuCheckBox.AllowCheckmarkAnimation = True
        Me.PrintReceiptBunifuCheckBox.AllowOnHoverStates = True
        Me.PrintReceiptBunifuCheckBox.AutoCheck = True
        Me.PrintReceiptBunifuCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.PrintReceiptBunifuCheckBox.BackgroundImage = CType(resources.GetObject("PrintReceiptBunifuCheckBox.BackgroundImage"), System.Drawing.Image)
        Me.PrintReceiptBunifuCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PrintReceiptBunifuCheckBox.BindingControl = Me.PrintReceiptBunifuLabel
        Me.PrintReceiptBunifuCheckBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.PrintReceiptBunifuCheckBox.BorderRadius = 12
        Me.PrintReceiptBunifuCheckBox.Checked = True
        Me.PrintReceiptBunifuCheckBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked
        Me.PrintReceiptBunifuCheckBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.PrintReceiptBunifuCheckBox.CustomCheckmarkImage = Nothing
        Me.PrintReceiptBunifuCheckBox.Location = New System.Drawing.Point(20, 608)
        Me.PrintReceiptBunifuCheckBox.MinimumSize = New System.Drawing.Size(17, 17)
        Me.PrintReceiptBunifuCheckBox.Name = "PrintReceiptBunifuCheckBox"
        Me.PrintReceiptBunifuCheckBox.OnCheck.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.PrintReceiptBunifuCheckBox.OnCheck.BorderRadius = 12
        Me.PrintReceiptBunifuCheckBox.OnCheck.BorderThickness = 2
        Me.PrintReceiptBunifuCheckBox.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.PrintReceiptBunifuCheckBox.OnCheck.CheckmarkColor = System.Drawing.Color.White
        Me.PrintReceiptBunifuCheckBox.OnCheck.CheckmarkThickness = 2
        Me.PrintReceiptBunifuCheckBox.OnDisable.BorderColor = System.Drawing.Color.LightGray
        Me.PrintReceiptBunifuCheckBox.OnDisable.BorderRadius = 12
        Me.PrintReceiptBunifuCheckBox.OnDisable.BorderThickness = 2
        Me.PrintReceiptBunifuCheckBox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent
        Me.PrintReceiptBunifuCheckBox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray
        Me.PrintReceiptBunifuCheckBox.OnDisable.CheckmarkThickness = 2
        Me.PrintReceiptBunifuCheckBox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.PrintReceiptBunifuCheckBox.OnHoverChecked.BorderRadius = 12
        Me.PrintReceiptBunifuCheckBox.OnHoverChecked.BorderThickness = 2
        Me.PrintReceiptBunifuCheckBox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.PrintReceiptBunifuCheckBox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White
        Me.PrintReceiptBunifuCheckBox.OnHoverChecked.CheckmarkThickness = 2
        Me.PrintReceiptBunifuCheckBox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PrintReceiptBunifuCheckBox.OnHoverUnchecked.BorderRadius = 12
        Me.PrintReceiptBunifuCheckBox.OnHoverUnchecked.BorderThickness = 1
        Me.PrintReceiptBunifuCheckBox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent
        Me.PrintReceiptBunifuCheckBox.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.PrintReceiptBunifuCheckBox.OnUncheck.BorderRadius = 12
        Me.PrintReceiptBunifuCheckBox.OnUncheck.BorderThickness = 1
        Me.PrintReceiptBunifuCheckBox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent
        Me.PrintReceiptBunifuCheckBox.Size = New System.Drawing.Size(21, 21)
        Me.PrintReceiptBunifuCheckBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu
        Me.PrintReceiptBunifuCheckBox.TabIndex = 20
        Me.PrintReceiptBunifuCheckBox.ThreeState = False
        Me.PrintReceiptBunifuCheckBox.ToolTipText = Nothing
        '
        'SaveBunifuButton
        '
        Me.SaveBunifuButton.AllowAnimations = True
        Me.SaveBunifuButton.AllowMouseEffects = True
        Me.SaveBunifuButton.AllowToggling = False
        Me.SaveBunifuButton.AnimationSpeed = 200
        Me.SaveBunifuButton.AutoGenerateColors = False
        Me.SaveBunifuButton.AutoRoundBorders = False
        Me.SaveBunifuButton.AutoSizeLeftIcon = True
        Me.SaveBunifuButton.AutoSizeRightIcon = True
        Me.SaveBunifuButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveBunifuButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SaveBunifuButton.BackgroundImage = CType(resources.GetObject("SaveBunifuButton.BackgroundImage"), System.Drawing.Image)
        Me.SaveBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.SaveBunifuButton.ButtonText = "Save"
        Me.SaveBunifuButton.ButtonTextMarginLeft = 0
        Me.SaveBunifuButton.ColorContrastOnClick = 45
        Me.SaveBunifuButton.ColorContrastOnHover = 45
        Me.SaveBunifuButton.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges6.BottomLeft = True
        BorderEdges6.BottomRight = True
        BorderEdges6.TopLeft = True
        BorderEdges6.TopRight = True
        Me.SaveBunifuButton.CustomizableEdges = BorderEdges6
        Me.SaveBunifuButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SaveBunifuButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.SaveBunifuButton.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SaveBunifuButton.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.SaveBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed
        Me.SaveBunifuButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBunifuButton.ForeColor = System.Drawing.Color.White
        Me.SaveBunifuButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveBunifuButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.SaveBunifuButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.SaveBunifuButton.IconMarginLeft = 11
        Me.SaveBunifuButton.IconPadding = 10
        Me.SaveBunifuButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SaveBunifuButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.SaveBunifuButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.SaveBunifuButton.IconSize = 25
        Me.SaveBunifuButton.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SaveBunifuButton.IdleBorderRadius = 1
        Me.SaveBunifuButton.IdleBorderThickness = 1
        Me.SaveBunifuButton.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SaveBunifuButton.IdleIconLeftImage = Nothing
        Me.SaveBunifuButton.IdleIconRightImage = Nothing
        Me.SaveBunifuButton.IndicateFocus = False
        Me.SaveBunifuButton.Location = New System.Drawing.Point(599, 599)
        Me.SaveBunifuButton.Name = "SaveBunifuButton"
        Me.SaveBunifuButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.SaveBunifuButton.OnDisabledState.BorderRadius = 1
        Me.SaveBunifuButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.SaveBunifuButton.OnDisabledState.BorderThickness = 1
        Me.SaveBunifuButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SaveBunifuButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.SaveBunifuButton.OnDisabledState.IconLeftImage = Nothing
        Me.SaveBunifuButton.OnDisabledState.IconRightImage = Nothing
        Me.SaveBunifuButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SaveBunifuButton.onHoverState.BorderRadius = 1
        Me.SaveBunifuButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.SaveBunifuButton.onHoverState.BorderThickness = 1
        Me.SaveBunifuButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SaveBunifuButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.SaveBunifuButton.onHoverState.IconLeftImage = Nothing
        Me.SaveBunifuButton.onHoverState.IconRightImage = Nothing
        Me.SaveBunifuButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SaveBunifuButton.OnIdleState.BorderRadius = 1
        Me.SaveBunifuButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.SaveBunifuButton.OnIdleState.BorderThickness = 1
        Me.SaveBunifuButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SaveBunifuButton.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.SaveBunifuButton.OnIdleState.IconLeftImage = Nothing
        Me.SaveBunifuButton.OnIdleState.IconRightImage = Nothing
        Me.SaveBunifuButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SaveBunifuButton.OnPressedState.BorderRadius = 1
        Me.SaveBunifuButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.SaveBunifuButton.OnPressedState.BorderThickness = 1
        Me.SaveBunifuButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SaveBunifuButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.SaveBunifuButton.OnPressedState.IconLeftImage = Nothing
        Me.SaveBunifuButton.OnPressedState.IconRightImage = Nothing
        Me.SaveBunifuButton.Size = New System.Drawing.Size(190, 39)
        Me.SaveBunifuButton.TabIndex = 19
        Me.SaveBunifuButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SaveBunifuButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.SaveBunifuButton.TextMarginLeft = 0
        Me.SaveBunifuButton.TextPadding = New System.Windows.Forms.Padding(0)
        Me.SaveBunifuButton.UseDefaultRadiusAndThickness = True
        '
        'CancelBunifuButton
        '
        Me.CancelBunifuButton.AllowAnimations = True
        Me.CancelBunifuButton.AllowMouseEffects = True
        Me.CancelBunifuButton.AllowToggling = False
        Me.CancelBunifuButton.AnimationSpeed = 200
        Me.CancelBunifuButton.AutoGenerateColors = False
        Me.CancelBunifuButton.AutoRoundBorders = False
        Me.CancelBunifuButton.AutoSizeLeftIcon = True
        Me.CancelBunifuButton.AutoSizeRightIcon = True
        Me.CancelBunifuButton.BackColor = System.Drawing.Color.Transparent
        Me.CancelBunifuButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CancelBunifuButton.BackgroundImage = CType(resources.GetObject("CancelBunifuButton.BackgroundImage"), System.Drawing.Image)
        Me.CancelBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.CancelBunifuButton.ButtonText = "Cancel"
        Me.CancelBunifuButton.ButtonTextMarginLeft = 0
        Me.CancelBunifuButton.ColorContrastOnClick = 45
        Me.CancelBunifuButton.ColorContrastOnHover = 45
        Me.CancelBunifuButton.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges7.BottomLeft = True
        BorderEdges7.BottomRight = True
        BorderEdges7.TopLeft = True
        BorderEdges7.TopRight = True
        Me.CancelBunifuButton.CustomizableEdges = BorderEdges7
        Me.CancelBunifuButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.CancelBunifuButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.CancelBunifuButton.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.CancelBunifuButton.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.CancelBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed
        Me.CancelBunifuButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBunifuButton.ForeColor = System.Drawing.Color.White
        Me.CancelBunifuButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelBunifuButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.CancelBunifuButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.CancelBunifuButton.IconMarginLeft = 11
        Me.CancelBunifuButton.IconPadding = 10
        Me.CancelBunifuButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CancelBunifuButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.CancelBunifuButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.CancelBunifuButton.IconSize = 25
        Me.CancelBunifuButton.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CancelBunifuButton.IdleBorderRadius = 1
        Me.CancelBunifuButton.IdleBorderThickness = 1
        Me.CancelBunifuButton.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CancelBunifuButton.IdleIconLeftImage = Nothing
        Me.CancelBunifuButton.IdleIconRightImage = Nothing
        Me.CancelBunifuButton.IndicateFocus = False
        Me.CancelBunifuButton.Location = New System.Drawing.Point(810, 599)
        Me.CancelBunifuButton.Name = "CancelBunifuButton"
        Me.CancelBunifuButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.CancelBunifuButton.OnDisabledState.BorderRadius = 1
        Me.CancelBunifuButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.CancelBunifuButton.OnDisabledState.BorderThickness = 1
        Me.CancelBunifuButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.CancelBunifuButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.CancelBunifuButton.OnDisabledState.IconLeftImage = Nothing
        Me.CancelBunifuButton.OnDisabledState.IconRightImage = Nothing
        Me.CancelBunifuButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CancelBunifuButton.onHoverState.BorderRadius = 1
        Me.CancelBunifuButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.CancelBunifuButton.onHoverState.BorderThickness = 1
        Me.CancelBunifuButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CancelBunifuButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.CancelBunifuButton.onHoverState.IconLeftImage = Nothing
        Me.CancelBunifuButton.onHoverState.IconRightImage = Nothing
        Me.CancelBunifuButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CancelBunifuButton.OnIdleState.BorderRadius = 1
        Me.CancelBunifuButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.CancelBunifuButton.OnIdleState.BorderThickness = 1
        Me.CancelBunifuButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CancelBunifuButton.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.CancelBunifuButton.OnIdleState.IconLeftImage = Nothing
        Me.CancelBunifuButton.OnIdleState.IconRightImage = Nothing
        Me.CancelBunifuButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CancelBunifuButton.OnPressedState.BorderRadius = 1
        Me.CancelBunifuButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.CancelBunifuButton.OnPressedState.BorderThickness = 1
        Me.CancelBunifuButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CancelBunifuButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.CancelBunifuButton.OnPressedState.IconLeftImage = Nothing
        Me.CancelBunifuButton.OnPressedState.IconRightImage = Nothing
        Me.CancelBunifuButton.Size = New System.Drawing.Size(190, 39)
        Me.CancelBunifuButton.TabIndex = 18
        Me.CancelBunifuButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CancelBunifuButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.CancelBunifuButton.TextMarginLeft = 0
        Me.CancelBunifuButton.TextPadding = New System.Windows.Forms.Padding(0)
        Me.CancelBunifuButton.UseDefaultRadiusAndThickness = True
        '
        'UpdateBunifuButton
        '
        Me.UpdateBunifuButton.AllowAnimations = True
        Me.UpdateBunifuButton.AllowMouseEffects = True
        Me.UpdateBunifuButton.AllowToggling = False
        Me.UpdateBunifuButton.AnimationSpeed = 200
        Me.UpdateBunifuButton.AutoGenerateColors = False
        Me.UpdateBunifuButton.AutoRoundBorders = False
        Me.UpdateBunifuButton.AutoSizeLeftIcon = True
        Me.UpdateBunifuButton.AutoSizeRightIcon = True
        Me.UpdateBunifuButton.BackColor = System.Drawing.Color.Transparent
        Me.UpdateBunifuButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.UpdateBunifuButton.BackgroundImage = CType(resources.GetObject("UpdateBunifuButton.BackgroundImage"), System.Drawing.Image)
        Me.UpdateBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.UpdateBunifuButton.ButtonText = "Update"
        Me.UpdateBunifuButton.ButtonTextMarginLeft = 0
        Me.UpdateBunifuButton.ColorContrastOnClick = 45
        Me.UpdateBunifuButton.ColorContrastOnHover = 45
        Me.UpdateBunifuButton.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges8.BottomLeft = True
        BorderEdges8.BottomRight = True
        BorderEdges8.TopLeft = True
        BorderEdges8.TopRight = True
        Me.UpdateBunifuButton.CustomizableEdges = BorderEdges8
        Me.UpdateBunifuButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.UpdateBunifuButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.UpdateBunifuButton.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.UpdateBunifuButton.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.UpdateBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed
        Me.UpdateBunifuButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBunifuButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.UpdateBunifuButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateBunifuButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.UpdateBunifuButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.UpdateBunifuButton.IconMarginLeft = 11
        Me.UpdateBunifuButton.IconPadding = 10
        Me.UpdateBunifuButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UpdateBunifuButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.UpdateBunifuButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.UpdateBunifuButton.IconSize = 25
        Me.UpdateBunifuButton.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.UpdateBunifuButton.IdleBorderRadius = 1
        Me.UpdateBunifuButton.IdleBorderThickness = 1
        Me.UpdateBunifuButton.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.UpdateBunifuButton.IdleIconLeftImage = Global.EasyWarung.My.Resources.Resources.update
        Me.UpdateBunifuButton.IdleIconRightImage = Nothing
        Me.UpdateBunifuButton.IndicateFocus = False
        Me.UpdateBunifuButton.Location = New System.Drawing.Point(698, 123)
        Me.UpdateBunifuButton.Name = "UpdateBunifuButton"
        Me.UpdateBunifuButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.UpdateBunifuButton.OnDisabledState.BorderRadius = 1
        Me.UpdateBunifuButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.UpdateBunifuButton.OnDisabledState.BorderThickness = 1
        Me.UpdateBunifuButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.UpdateBunifuButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.UpdateBunifuButton.OnDisabledState.IconLeftImage = Nothing
        Me.UpdateBunifuButton.OnDisabledState.IconRightImage = Nothing
        Me.UpdateBunifuButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.UpdateBunifuButton.onHoverState.BorderRadius = 1
        Me.UpdateBunifuButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.UpdateBunifuButton.onHoverState.BorderThickness = 1
        Me.UpdateBunifuButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.UpdateBunifuButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.UpdateBunifuButton.onHoverState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.update_white
        Me.UpdateBunifuButton.onHoverState.IconRightImage = Nothing
        Me.UpdateBunifuButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.UpdateBunifuButton.OnIdleState.BorderRadius = 1
        Me.UpdateBunifuButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.UpdateBunifuButton.OnIdleState.BorderThickness = 1
        Me.UpdateBunifuButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.UpdateBunifuButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.UpdateBunifuButton.OnIdleState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.update
        Me.UpdateBunifuButton.OnIdleState.IconRightImage = Nothing
        Me.UpdateBunifuButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.UpdateBunifuButton.OnPressedState.BorderRadius = 1
        Me.UpdateBunifuButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.UpdateBunifuButton.OnPressedState.BorderThickness = 1
        Me.UpdateBunifuButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.UpdateBunifuButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.UpdateBunifuButton.OnPressedState.IconLeftImage = Nothing
        Me.UpdateBunifuButton.OnPressedState.IconRightImage = Nothing
        Me.UpdateBunifuButton.Size = New System.Drawing.Size(150, 39)
        Me.UpdateBunifuButton.TabIndex = 16
        Me.UpdateBunifuButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UpdateBunifuButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.UpdateBunifuButton.TextMarginLeft = 0
        Me.UpdateBunifuButton.TextPadding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.UpdateBunifuButton.UseDefaultRadiusAndThickness = True
        '
        'InsertBunifuButton
        '
        Me.InsertBunifuButton.AllowAnimations = True
        Me.InsertBunifuButton.AllowMouseEffects = True
        Me.InsertBunifuButton.AllowToggling = False
        Me.InsertBunifuButton.AnimationSpeed = 200
        Me.InsertBunifuButton.AutoGenerateColors = False
        Me.InsertBunifuButton.AutoRoundBorders = False
        Me.InsertBunifuButton.AutoSizeLeftIcon = True
        Me.InsertBunifuButton.AutoSizeRightIcon = True
        Me.InsertBunifuButton.BackColor = System.Drawing.Color.Transparent
        Me.InsertBunifuButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.InsertBunifuButton.BackgroundImage = CType(resources.GetObject("InsertBunifuButton.BackgroundImage"), System.Drawing.Image)
        Me.InsertBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.InsertBunifuButton.ButtonText = "Create new"
        Me.InsertBunifuButton.ButtonTextMarginLeft = 0
        Me.InsertBunifuButton.ColorContrastOnClick = 45
        Me.InsertBunifuButton.ColorContrastOnHover = 45
        Me.InsertBunifuButton.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges9.BottomLeft = True
        BorderEdges9.BottomRight = False
        BorderEdges9.TopLeft = True
        BorderEdges9.TopRight = False
        Me.InsertBunifuButton.CustomizableEdges = BorderEdges9
        Me.InsertBunifuButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.InsertBunifuButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.InsertBunifuButton.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.InsertBunifuButton.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.InsertBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed
        Me.InsertBunifuButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InsertBunifuButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.InsertBunifuButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.InsertBunifuButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.InsertBunifuButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.InsertBunifuButton.IconMarginLeft = 11
        Me.InsertBunifuButton.IconPadding = 10
        Me.InsertBunifuButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.InsertBunifuButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.InsertBunifuButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.InsertBunifuButton.IconSize = 25
        Me.InsertBunifuButton.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.InsertBunifuButton.IdleBorderRadius = 15
        Me.InsertBunifuButton.IdleBorderThickness = 1
        Me.InsertBunifuButton.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.InsertBunifuButton.IdleIconLeftImage = Global.EasyWarung.My.Resources.Resources.add
        Me.InsertBunifuButton.IdleIconRightImage = Nothing
        Me.InsertBunifuButton.IndicateFocus = False
        Me.InsertBunifuButton.Location = New System.Drawing.Point(546, 123)
        Me.InsertBunifuButton.Name = "InsertBunifuButton"
        Me.InsertBunifuButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.InsertBunifuButton.OnDisabledState.BorderRadius = 15
        Me.InsertBunifuButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.InsertBunifuButton.OnDisabledState.BorderThickness = 1
        Me.InsertBunifuButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.InsertBunifuButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.InsertBunifuButton.OnDisabledState.IconLeftImage = Nothing
        Me.InsertBunifuButton.OnDisabledState.IconRightImage = Nothing
        Me.InsertBunifuButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.InsertBunifuButton.onHoverState.BorderRadius = 15
        Me.InsertBunifuButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.InsertBunifuButton.onHoverState.BorderThickness = 1
        Me.InsertBunifuButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.InsertBunifuButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.InsertBunifuButton.onHoverState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.add_white
        Me.InsertBunifuButton.onHoverState.IconRightImage = Nothing
        Me.InsertBunifuButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.InsertBunifuButton.OnIdleState.BorderRadius = 15
        Me.InsertBunifuButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.InsertBunifuButton.OnIdleState.BorderThickness = 1
        Me.InsertBunifuButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.InsertBunifuButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.InsertBunifuButton.OnIdleState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.add
        Me.InsertBunifuButton.OnIdleState.IconRightImage = Nothing
        Me.InsertBunifuButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.InsertBunifuButton.OnPressedState.BorderRadius = 15
        Me.InsertBunifuButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.InsertBunifuButton.OnPressedState.BorderThickness = 1
        Me.InsertBunifuButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.InsertBunifuButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.InsertBunifuButton.OnPressedState.IconLeftImage = Nothing
        Me.InsertBunifuButton.OnPressedState.IconRightImage = Nothing
        Me.InsertBunifuButton.Size = New System.Drawing.Size(150, 39)
        Me.InsertBunifuButton.TabIndex = 15
        Me.InsertBunifuButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.InsertBunifuButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.InsertBunifuButton.TextMarginLeft = 0
        Me.InsertBunifuButton.TextPadding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.InsertBunifuButton.UseDefaultRadiusAndThickness = True
        '
        'DeleteBunifuButton
        '
        Me.DeleteBunifuButton.AllowAnimations = True
        Me.DeleteBunifuButton.AllowMouseEffects = True
        Me.DeleteBunifuButton.AllowToggling = False
        Me.DeleteBunifuButton.AnimationSpeed = 200
        Me.DeleteBunifuButton.AutoGenerateColors = False
        Me.DeleteBunifuButton.AutoRoundBorders = False
        Me.DeleteBunifuButton.AutoSizeLeftIcon = True
        Me.DeleteBunifuButton.AutoSizeRightIcon = True
        Me.DeleteBunifuButton.BackColor = System.Drawing.Color.Transparent
        Me.DeleteBunifuButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.DeleteBunifuButton.BackgroundImage = CType(resources.GetObject("DeleteBunifuButton.BackgroundImage"), System.Drawing.Image)
        Me.DeleteBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.DeleteBunifuButton.ButtonText = "Delete"
        Me.DeleteBunifuButton.ButtonTextMarginLeft = 0
        Me.DeleteBunifuButton.ColorContrastOnClick = 45
        Me.DeleteBunifuButton.ColorContrastOnHover = 45
        Me.DeleteBunifuButton.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges10.BottomLeft = False
        BorderEdges10.BottomRight = True
        BorderEdges10.TopLeft = False
        BorderEdges10.TopRight = True
        Me.DeleteBunifuButton.CustomizableEdges = BorderEdges10
        Me.DeleteBunifuButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.DeleteBunifuButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DeleteBunifuButton.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.DeleteBunifuButton.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.DeleteBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed
        Me.DeleteBunifuButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBunifuButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DeleteBunifuButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteBunifuButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.DeleteBunifuButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.DeleteBunifuButton.IconMarginLeft = 11
        Me.DeleteBunifuButton.IconPadding = 10
        Me.DeleteBunifuButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DeleteBunifuButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.DeleteBunifuButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.DeleteBunifuButton.IconSize = 25
        Me.DeleteBunifuButton.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.DeleteBunifuButton.IdleBorderRadius = 15
        Me.DeleteBunifuButton.IdleBorderThickness = 1
        Me.DeleteBunifuButton.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.DeleteBunifuButton.IdleIconLeftImage = Global.EasyWarung.My.Resources.Resources.delete
        Me.DeleteBunifuButton.IdleIconRightImage = Nothing
        Me.DeleteBunifuButton.IndicateFocus = False
        Me.DeleteBunifuButton.Location = New System.Drawing.Point(850, 123)
        Me.DeleteBunifuButton.Name = "DeleteBunifuButton"
        Me.DeleteBunifuButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DeleteBunifuButton.OnDisabledState.BorderRadius = 15
        Me.DeleteBunifuButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.DeleteBunifuButton.OnDisabledState.BorderThickness = 1
        Me.DeleteBunifuButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.DeleteBunifuButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.DeleteBunifuButton.OnDisabledState.IconLeftImage = Nothing
        Me.DeleteBunifuButton.OnDisabledState.IconRightImage = Nothing
        Me.DeleteBunifuButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.DeleteBunifuButton.onHoverState.BorderRadius = 15
        Me.DeleteBunifuButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.DeleteBunifuButton.onHoverState.BorderThickness = 1
        Me.DeleteBunifuButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.DeleteBunifuButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.DeleteBunifuButton.onHoverState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.delete_white
        Me.DeleteBunifuButton.onHoverState.IconRightImage = Nothing
        Me.DeleteBunifuButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.DeleteBunifuButton.OnIdleState.BorderRadius = 15
        Me.DeleteBunifuButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.DeleteBunifuButton.OnIdleState.BorderThickness = 1
        Me.DeleteBunifuButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.DeleteBunifuButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DeleteBunifuButton.OnIdleState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.delete
        Me.DeleteBunifuButton.OnIdleState.IconRightImage = Nothing
        Me.DeleteBunifuButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.DeleteBunifuButton.OnPressedState.BorderRadius = 15
        Me.DeleteBunifuButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.DeleteBunifuButton.OnPressedState.BorderThickness = 1
        Me.DeleteBunifuButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.DeleteBunifuButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.DeleteBunifuButton.OnPressedState.IconLeftImage = Nothing
        Me.DeleteBunifuButton.OnPressedState.IconRightImage = Nothing
        Me.DeleteBunifuButton.Size = New System.Drawing.Size(150, 39)
        Me.DeleteBunifuButton.TabIndex = 14
        Me.DeleteBunifuButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DeleteBunifuButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DeleteBunifuButton.TextMarginLeft = 0
        Me.DeleteBunifuButton.TextPadding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.DeleteBunifuButton.UseDefaultRadiusAndThickness = True
        '
        'UserNameBunifuTextBox
        '
        Me.UserNameBunifuTextBox.AcceptsReturn = False
        Me.UserNameBunifuTextBox.AcceptsTab = False
        Me.UserNameBunifuTextBox.AnimationSpeed = 200
        Me.UserNameBunifuTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.UserNameBunifuTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.UserNameBunifuTextBox.AutoSizeHeight = True
        Me.UserNameBunifuTextBox.BackColor = System.Drawing.Color.Transparent
        Me.UserNameBunifuTextBox.BackgroundImage = CType(resources.GetObject("UserNameBunifuTextBox.BackgroundImage"), System.Drawing.Image)
        Me.UserNameBunifuTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.UserNameBunifuTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.UserNameBunifuTextBox.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserNameBunifuTextBox.BorderColorIdle = System.Drawing.Color.Silver
        Me.UserNameBunifuTextBox.BorderRadius = 1
        Me.UserNameBunifuTextBox.BorderThickness = 1
        Me.UserNameBunifuTextBox.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal
        Me.UserNameBunifuTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.UserNameBunifuTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserNameBunifuTextBox.DefaultFont = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameBunifuTextBox.DefaultText = ""
        Me.UserNameBunifuTextBox.Enabled = False
        Me.UserNameBunifuTextBox.FillColor = System.Drawing.Color.White
        Me.UserNameBunifuTextBox.ForeColor = System.Drawing.Color.Black
        Me.UserNameBunifuTextBox.HideSelection = True
        Me.UserNameBunifuTextBox.IconLeft = Nothing
        Me.UserNameBunifuTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.UserNameBunifuTextBox.IconPadding = 10
        Me.UserNameBunifuTextBox.IconRight = Nothing
        Me.UserNameBunifuTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.UserNameBunifuTextBox.Lines = New String(-1) {}
        Me.UserNameBunifuTextBox.Location = New System.Drawing.Point(153, 62)
        Me.UserNameBunifuTextBox.MaxLength = 32767
        Me.UserNameBunifuTextBox.MinimumSize = New System.Drawing.Size(1, 1)
        Me.UserNameBunifuTextBox.Modified = False
        Me.UserNameBunifuTextBox.Multiline = False
        Me.UserNameBunifuTextBox.Name = "UserNameBunifuTextBox"
        StateProperties9.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties9.FillColor = System.Drawing.Color.Empty
        StateProperties9.ForeColor = System.Drawing.Color.Empty
        StateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.UserNameBunifuTextBox.OnActiveState = StateProperties9
        StateProperties10.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties10.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.UserNameBunifuTextBox.OnDisabledState = StateProperties10
        StateProperties11.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties11.FillColor = System.Drawing.Color.Empty
        StateProperties11.ForeColor = System.Drawing.Color.Empty
        StateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.UserNameBunifuTextBox.OnHoverState = StateProperties11
        StateProperties12.BorderColor = System.Drawing.Color.Silver
        StateProperties12.FillColor = System.Drawing.Color.White
        StateProperties12.ForeColor = System.Drawing.Color.Black
        StateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.UserNameBunifuTextBox.OnIdleState = StateProperties12
        Me.UserNameBunifuTextBox.Padding = New System.Windows.Forms.Padding(3)
        Me.UserNameBunifuTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserNameBunifuTextBox.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.UserNameBunifuTextBox.PlaceholderText = "Enter text"
        Me.UserNameBunifuTextBox.ReadOnly = False
        Me.UserNameBunifuTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UserNameBunifuTextBox.SelectedText = ""
        Me.UserNameBunifuTextBox.SelectionLength = 0
        Me.UserNameBunifuTextBox.SelectionStart = 0
        Me.UserNameBunifuTextBox.ShortcutsEnabled = True
        Me.UserNameBunifuTextBox.Size = New System.Drawing.Size(260, 44)
        Me.UserNameBunifuTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.UserNameBunifuTextBox.TabIndex = 5
        Me.UserNameBunifuTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.UserNameBunifuTextBox.TextMarginBottom = 0
        Me.UserNameBunifuTextBox.TextMarginLeft = 3
        Me.UserNameBunifuTextBox.TextMarginTop = 1
        Me.UserNameBunifuTextBox.TextPlaceholder = "Enter text"
        Me.UserNameBunifuTextBox.UseSystemPasswordChar = False
        Me.UserNameBunifuTextBox.WordWrap = True
        '
        'OrderIDBunifuTextBox
        '
        Me.OrderIDBunifuTextBox.AcceptsReturn = False
        Me.OrderIDBunifuTextBox.AcceptsTab = False
        Me.OrderIDBunifuTextBox.AnimationSpeed = 200
        Me.OrderIDBunifuTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OrderIDBunifuTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.OrderIDBunifuTextBox.AutoSizeHeight = True
        Me.OrderIDBunifuTextBox.BackColor = System.Drawing.Color.Transparent
        Me.OrderIDBunifuTextBox.BackgroundImage = CType(resources.GetObject("OrderIDBunifuTextBox.BackgroundImage"), System.Drawing.Image)
        Me.OrderIDBunifuTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.OrderIDBunifuTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.OrderIDBunifuTextBox.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OrderIDBunifuTextBox.BorderColorIdle = System.Drawing.Color.Silver
        Me.OrderIDBunifuTextBox.BorderRadius = 1
        Me.OrderIDBunifuTextBox.BorderThickness = 1
        Me.OrderIDBunifuTextBox.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal
        Me.OrderIDBunifuTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.OrderIDBunifuTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OrderIDBunifuTextBox.DefaultFont = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderIDBunifuTextBox.DefaultText = ""
        Me.OrderIDBunifuTextBox.Enabled = False
        Me.OrderIDBunifuTextBox.FillColor = System.Drawing.Color.White
        Me.OrderIDBunifuTextBox.ForeColor = System.Drawing.Color.Black
        Me.OrderIDBunifuTextBox.HideSelection = True
        Me.OrderIDBunifuTextBox.IconLeft = Nothing
        Me.OrderIDBunifuTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.OrderIDBunifuTextBox.IconPadding = 10
        Me.OrderIDBunifuTextBox.IconRight = Nothing
        Me.OrderIDBunifuTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.OrderIDBunifuTextBox.Lines = New String(-1) {}
        Me.OrderIDBunifuTextBox.Location = New System.Drawing.Point(153, 12)
        Me.OrderIDBunifuTextBox.MaxLength = 32767
        Me.OrderIDBunifuTextBox.MinimumSize = New System.Drawing.Size(1, 1)
        Me.OrderIDBunifuTextBox.Modified = False
        Me.OrderIDBunifuTextBox.Multiline = False
        Me.OrderIDBunifuTextBox.Name = "OrderIDBunifuTextBox"
        StateProperties13.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties13.FillColor = System.Drawing.Color.Empty
        StateProperties13.ForeColor = System.Drawing.Color.Empty
        StateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.OrderIDBunifuTextBox.OnActiveState = StateProperties13
        StateProperties14.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties14.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.OrderIDBunifuTextBox.OnDisabledState = StateProperties14
        StateProperties15.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties15.FillColor = System.Drawing.Color.Empty
        StateProperties15.ForeColor = System.Drawing.Color.Empty
        StateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.OrderIDBunifuTextBox.OnHoverState = StateProperties15
        StateProperties16.BorderColor = System.Drawing.Color.Silver
        StateProperties16.FillColor = System.Drawing.Color.White
        StateProperties16.ForeColor = System.Drawing.Color.Black
        StateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.OrderIDBunifuTextBox.OnIdleState = StateProperties16
        Me.OrderIDBunifuTextBox.Padding = New System.Windows.Forms.Padding(3)
        Me.OrderIDBunifuTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.OrderIDBunifuTextBox.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.OrderIDBunifuTextBox.PlaceholderText = "Enter text"
        Me.OrderIDBunifuTextBox.ReadOnly = False
        Me.OrderIDBunifuTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.OrderIDBunifuTextBox.SelectedText = ""
        Me.OrderIDBunifuTextBox.SelectionLength = 0
        Me.OrderIDBunifuTextBox.SelectionStart = 0
        Me.OrderIDBunifuTextBox.ShortcutsEnabled = True
        Me.OrderIDBunifuTextBox.Size = New System.Drawing.Size(260, 44)
        Me.OrderIDBunifuTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.OrderIDBunifuTextBox.TabIndex = 3
        Me.OrderIDBunifuTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.OrderIDBunifuTextBox.TextMarginBottom = 0
        Me.OrderIDBunifuTextBox.TextMarginLeft = 3
        Me.OrderIDBunifuTextBox.TextMarginTop = 1
        Me.OrderIDBunifuTextBox.TextPlaceholder = "Enter text"
        Me.OrderIDBunifuTextBox.UseSystemPasswordChar = False
        Me.OrderIDBunifuTextBox.WordWrap = True
        '
        'NoOrderDetailCol
        '
        Me.NoOrderDetailCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NoOrderDetailCol.DataPropertyName = "No."
        Me.NoOrderDetailCol.HeaderText = "No."
        Me.NoOrderDetailCol.Name = "NoOrderDetailCol"
        Me.NoOrderDetailCol.ReadOnly = True
        Me.NoOrderDetailCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NoOrderDetailCol.Width = 74
        '
        'ProductNameOrderDetailCol
        '
        Me.ProductNameOrderDetailCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductNameOrderDetailCol.DataPropertyName = "ProductName"
        Me.ProductNameOrderDetailCol.HeaderText = "Product Name"
        Me.ProductNameOrderDetailCol.Name = "ProductNameOrderDetailCol"
        Me.ProductNameOrderDetailCol.ReadOnly = True
        Me.ProductNameOrderDetailCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ProductPriceOrderDetailCol
        '
        Me.ProductPriceOrderDetailCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductPriceOrderDetailCol.DataPropertyName = "ProductPrice"
        Me.ProductPriceOrderDetailCol.HeaderText = "Product Price"
        Me.ProductPriceOrderDetailCol.Name = "ProductPriceOrderDetailCol"
        Me.ProductPriceOrderDetailCol.ReadOnly = True
        Me.ProductPriceOrderDetailCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'OrderAmountCol
        '
        Me.OrderAmountCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.OrderAmountCol.DataPropertyName = "OrderAmount"
        Me.OrderAmountCol.HeaderText = "Product Amount"
        Me.OrderAmountCol.Name = "OrderAmountCol"
        Me.OrderAmountCol.ReadOnly = True
        Me.OrderAmountCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OrderAmountCol.Width = 169
        '
        'SubtotalCol
        '
        Me.SubtotalCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SubtotalCol.DataPropertyName = "Subtotal"
        Me.SubtotalCol.HeaderText = "Subtotal"
        Me.SubtotalCol.Name = "SubtotalCol"
        Me.SubtotalCol.ReadOnly = True
        Me.SubtotalCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DetailIDCol
        '
        Me.DetailIDCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DetailIDCol.DataPropertyName = "DetailID"
        Me.DetailIDCol.HeaderText = "DetailID"
        Me.DetailIDCol.Name = "DetailIDCol"
        Me.DetailIDCol.ReadOnly = True
        Me.DetailIDCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DetailIDCol.Visible = False
        Me.DetailIDCol.Width = 106
        '
        'ProductIDOrderDetailCol
        '
        Me.ProductIDOrderDetailCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ProductIDOrderDetailCol.DataPropertyName = "ProductID"
        Me.ProductIDOrderDetailCol.HeaderText = "ProductID"
        Me.ProductIDOrderDetailCol.Name = "ProductIDOrderDetailCol"
        Me.ProductIDOrderDetailCol.ReadOnly = True
        Me.ProductIDOrderDetailCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProductIDOrderDetailCol.Visible = False
        Me.ProductIDOrderDetailCol.Width = 122
        '
        'OrdersInsertUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1012, 650)
        Me.Controls.Add(Me.OrderDateBunifuDatePicker)
        Me.Controls.Add(Me.PrintReceiptBunifuLabel)
        Me.Controls.Add(Me.PrintReceiptBunifuCheckBox)
        Me.Controls.Add(Me.SaveBunifuButton)
        Me.Controls.Add(Me.CancelBunifuButton)
        Me.Controls.Add(Me.OrderDetailBunifuDataGridView)
        Me.Controls.Add(Me.UpdateBunifuButton)
        Me.Controls.Add(Me.InsertBunifuButton)
        Me.Controls.Add(Me.DeleteBunifuButton)
        Me.Controls.Add(Me.PaymentBunifuDropdown)
        Me.Controls.Add(Me.PaymentBunifuLabel)
        Me.Controls.Add(Me.OrderDateBunifuLabel)
        Me.Controls.Add(Me.UserNameBunifuTextBox)
        Me.Controls.Add(Me.UserNameBunifuLabel)
        Me.Controls.Add(Me.OrderIDBunifuTextBox)
        Me.Controls.Add(Me.OrderIDBunifuLabel)
        Me.Controls.Add(Me.BunifuLabel2)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "OrdersInsertUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OrdersInsertUpdate"
        CType(Me.OrderDetailBunifuDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OrderIDBunifuTextBox As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents OrderIDBunifuLabel As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents UserNameBunifuTextBox As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents UserNameBunifuLabel As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents OrderDateBunifuLabel As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents PaymentBunifuLabel As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents PaymentBunifuDropdown As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents UpdateBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton2
    Friend WithEvents InsertBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton2
    Friend WithEvents DeleteBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton2
    Friend WithEvents OrderDetailBunifuDataGridView As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents SaveBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton2
    Friend WithEvents CancelBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton2
    Friend WithEvents PrintReceiptBunifuCheckBox As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents PrintReceiptBunifuLabel As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents OrderDateBunifuDatePicker As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents NoOrderDetailCol As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameOrderDetailCol As DataGridViewTextBoxColumn
    Friend WithEvents ProductPriceOrderDetailCol As DataGridViewTextBoxColumn
    Friend WithEvents OrderAmountCol As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalCol As DataGridViewTextBoxColumn
    Friend WithEvents DetailIDCol As DataGridViewTextBoxColumn
    Friend WithEvents ProductIDOrderDetailCol As DataGridViewTextBoxColumn
End Class
