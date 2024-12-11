<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdersForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrdersForm))
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim BorderEdges51 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges()
        Dim BorderEdges52 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges()
        Dim BorderEdges53 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges()
        Dim BorderEdges54 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges()
        Dim BorderEdges55 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges()
        Dim StateProperties41 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties42 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties43 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties44 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Me.DesktopBunifuPanel = New Bunifu.UI.WinForms.BunifuPanel()
        Me.OrdersBunifuDataGridView = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.NoOrderCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderIDCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderDateTimeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrandTotalCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameOrderCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderStatusStrCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIDOrderCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentIDCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderStatusIntCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataControlBunifuPanel = New Bunifu.UI.WinForms.BunifuPanel()
        Me.DetailBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2()
        Me.ReportBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2()
        Me.UpdateBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2()
        Me.InsertBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2()
        Me.DeleteBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.TopBunifuPanel = New Bunifu.UI.WinForms.BunifuPanel()
        Me.SearchBunifuTextBox = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.StatusContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangeStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreparingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReadyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeliveredToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompletedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesktopBunifuPanel.SuspendLayout()
        CType(Me.OrdersBunifuDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataControlBunifuPanel.SuspendLayout()
        Me.TopBunifuPanel.SuspendLayout()
        Me.StatusContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DesktopBunifuPanel
        '
        Me.DesktopBunifuPanel.BackgroundColor = System.Drawing.Color.Transparent
        Me.DesktopBunifuPanel.BackgroundImage = CType(resources.GetObject("DesktopBunifuPanel.BackgroundImage"), System.Drawing.Image)
        Me.DesktopBunifuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DesktopBunifuPanel.BorderColor = System.Drawing.Color.Transparent
        Me.DesktopBunifuPanel.BorderRadius = 3
        Me.DesktopBunifuPanel.BorderThickness = 1
        Me.DesktopBunifuPanel.Controls.Add(Me.OrdersBunifuDataGridView)
        Me.DesktopBunifuPanel.Controls.Add(Me.DataControlBunifuPanel)
        Me.DesktopBunifuPanel.Controls.Add(Me.BunifuLabel2)
        Me.DesktopBunifuPanel.Controls.Add(Me.BunifuLabel1)
        Me.DesktopBunifuPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DesktopBunifuPanel.Location = New System.Drawing.Point(0, 68)
        Me.DesktopBunifuPanel.Name = "DesktopBunifuPanel"
        Me.DesktopBunifuPanel.ShowBorders = True
        Me.DesktopBunifuPanel.Size = New System.Drawing.Size(1105, 656)
        Me.DesktopBunifuPanel.TabIndex = 4
        '
        'OrdersBunifuDataGridView
        '
        Me.OrdersBunifuDataGridView.AllowCustomTheming = False
        Me.OrdersBunifuDataGridView.AllowUserToAddRows = False
        Me.OrdersBunifuDataGridView.AllowUserToDeleteRows = False
        Me.OrdersBunifuDataGridView.AllowUserToResizeColumns = False
        Me.OrdersBunifuDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle31.ForeColor = System.Drawing.Color.White
        Me.OrdersBunifuDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle31
        Me.OrdersBunifuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.OrdersBunifuDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.OrdersBunifuDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OrdersBunifuDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.OrdersBunifuDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle32.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OrdersBunifuDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle32
        Me.OrdersBunifuDataGridView.ColumnHeadersHeight = 40
        Me.OrdersBunifuDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoOrderCol, Me.OrderIDCol, Me.OrderDateTimeCol, Me.PaymentNameCol, Me.GrandTotalCol, Me.UserNameOrderCol, Me.OrderStatusStrCol, Me.UserIDOrderCol, Me.PaymentIDCol, Me.OrderStatusIntCol})
        Me.OrdersBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.OrdersBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.OrdersBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White
        Me.OrdersBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.OrdersBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.OrdersBunifuDataGridView.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.OrdersBunifuDataGridView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.OrdersBunifuDataGridView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.OrdersBunifuDataGridView.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.OrdersBunifuDataGridView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.OrdersBunifuDataGridView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.OrdersBunifuDataGridView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.OrdersBunifuDataGridView.CurrentTheme.Name = Nothing
        Me.OrdersBunifuDataGridView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.OrdersBunifuDataGridView.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.OrdersBunifuDataGridView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.OrdersBunifuDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.OrdersBunifuDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle33.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle33.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle33.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OrdersBunifuDataGridView.DefaultCellStyle = DataGridViewCellStyle33
        Me.OrdersBunifuDataGridView.EnableHeadersVisualStyles = False
        Me.OrdersBunifuDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.OrdersBunifuDataGridView.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.OrdersBunifuDataGridView.HeaderBgColor = System.Drawing.Color.Empty
        Me.OrdersBunifuDataGridView.HeaderForeColor = System.Drawing.Color.White
        Me.OrdersBunifuDataGridView.Location = New System.Drawing.Point(12, 71)
        Me.OrdersBunifuDataGridView.MultiSelect = False
        Me.OrdersBunifuDataGridView.Name = "OrdersBunifuDataGridView"
        Me.OrdersBunifuDataGridView.ReadOnly = True
        Me.OrdersBunifuDataGridView.RowHeadersVisible = False
        Me.OrdersBunifuDataGridView.RowTemplate.Height = 40
        Me.OrdersBunifuDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.OrdersBunifuDataGridView.Size = New System.Drawing.Size(1081, 573)
        Me.OrdersBunifuDataGridView.TabIndex = 2
        Me.OrdersBunifuDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark
        '
        'NoOrderCol
        '
        Me.NoOrderCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NoOrderCol.DataPropertyName = "No."
        Me.NoOrderCol.HeaderText = "No."
        Me.NoOrderCol.Name = "NoOrderCol"
        Me.NoOrderCol.ReadOnly = True
        Me.NoOrderCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NoOrderCol.Width = 74
        '
        'OrderIDCol
        '
        Me.OrderIDCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.OrderIDCol.DataPropertyName = "OrderID"
        Me.OrderIDCol.HeaderText = "Order ID"
        Me.OrderIDCol.Name = "OrderIDCol"
        Me.OrderIDCol.ReadOnly = True
        Me.OrderIDCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'OrderDateTimeCol
        '
        Me.OrderDateTimeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.OrderDateTimeCol.DataPropertyName = "OrderDateTime"
        Me.OrderDateTimeCol.HeaderText = "Order Date"
        Me.OrderDateTimeCol.Name = "OrderDateTimeCol"
        Me.OrderDateTimeCol.ReadOnly = True
        Me.OrderDateTimeCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'PaymentNameCol
        '
        Me.PaymentNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PaymentNameCol.DataPropertyName = "PaymentName"
        Me.PaymentNameCol.HeaderText = "Payment"
        Me.PaymentNameCol.Name = "PaymentNameCol"
        Me.PaymentNameCol.ReadOnly = True
        Me.PaymentNameCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'GrandTotalCol
        '
        Me.GrandTotalCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.GrandTotalCol.DataPropertyName = "GrandTotal"
        Me.GrandTotalCol.HeaderText = "Grand Total"
        Me.GrandTotalCol.Name = "GrandTotalCol"
        Me.GrandTotalCol.ReadOnly = True
        Me.GrandTotalCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrandTotalCol.Width = 131
        '
        'UserNameOrderCol
        '
        Me.UserNameOrderCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UserNameOrderCol.DataPropertyName = "UserName"
        Me.UserNameOrderCol.HeaderText = "User Name"
        Me.UserNameOrderCol.Name = "UserNameOrderCol"
        Me.UserNameOrderCol.ReadOnly = True
        Me.UserNameOrderCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'OrderStatusStrCol
        '
        Me.OrderStatusStrCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.OrderStatusStrCol.DataPropertyName = "OrderStatusStr"
        Me.OrderStatusStrCol.HeaderText = "Status"
        Me.OrderStatusStrCol.Name = "OrderStatusStrCol"
        Me.OrderStatusStrCol.ReadOnly = True
        Me.OrderStatusStrCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'UserIDOrderCol
        '
        Me.UserIDOrderCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UserIDOrderCol.DataPropertyName = "UserID"
        Me.UserIDOrderCol.HeaderText = "User ID"
        Me.UserIDOrderCol.Name = "UserIDOrderCol"
        Me.UserIDOrderCol.ReadOnly = True
        Me.UserIDOrderCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UserIDOrderCol.Visible = False
        Me.UserIDOrderCol.Width = 86
        '
        'PaymentIDCol
        '
        Me.PaymentIDCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PaymentIDCol.DataPropertyName = "PaymentID"
        Me.PaymentIDCol.HeaderText = "Payment ID"
        Me.PaymentIDCol.Name = "PaymentIDCol"
        Me.PaymentIDCol.ReadOnly = True
        Me.PaymentIDCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PaymentIDCol.Visible = False
        Me.PaymentIDCol.Width = 116
        '
        'OrderStatusIntCol
        '
        Me.OrderStatusIntCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.OrderStatusIntCol.DataPropertyName = "OrderStatusInt"
        Me.OrderStatusIntCol.HeaderText = "OrderStatusInt"
        Me.OrderStatusIntCol.Name = "OrderStatusIntCol"
        Me.OrderStatusIntCol.ReadOnly = True
        Me.OrderStatusIntCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OrderStatusIntCol.Visible = False
        Me.OrderStatusIntCol.Width = 141
        '
        'DataControlBunifuPanel
        '
        Me.DataControlBunifuPanel.BackgroundColor = System.Drawing.Color.Transparent
        Me.DataControlBunifuPanel.BackgroundImage = CType(resources.GetObject("DataControlBunifuPanel.BackgroundImage"), System.Drawing.Image)
        Me.DataControlBunifuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DataControlBunifuPanel.BorderColor = System.Drawing.Color.Transparent
        Me.DataControlBunifuPanel.BorderRadius = 3
        Me.DataControlBunifuPanel.BorderThickness = 1
        Me.DataControlBunifuPanel.Controls.Add(Me.DetailBunifuButton)
        Me.DataControlBunifuPanel.Controls.Add(Me.ReportBunifuButton)
        Me.DataControlBunifuPanel.Controls.Add(Me.UpdateBunifuButton)
        Me.DataControlBunifuPanel.Controls.Add(Me.InsertBunifuButton)
        Me.DataControlBunifuPanel.Controls.Add(Me.DeleteBunifuButton)
        Me.DataControlBunifuPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataControlBunifuPanel.Location = New System.Drawing.Point(0, 0)
        Me.DataControlBunifuPanel.Name = "DataControlBunifuPanel"
        Me.DataControlBunifuPanel.ShowBorders = True
        Me.DataControlBunifuPanel.Size = New System.Drawing.Size(1105, 63)
        Me.DataControlBunifuPanel.TabIndex = 0
        '
        'DetailBunifuButton
        '
        Me.DetailBunifuButton.AllowAnimations = True
        Me.DetailBunifuButton.AllowMouseEffects = True
        Me.DetailBunifuButton.AllowToggling = False
        Me.DetailBunifuButton.AnimationSpeed = 200
        Me.DetailBunifuButton.AutoGenerateColors = False
        Me.DetailBunifuButton.AutoRoundBorders = False
        Me.DetailBunifuButton.AutoSizeLeftIcon = True
        Me.DetailBunifuButton.AutoSizeRightIcon = True
        Me.DetailBunifuButton.BackColor = System.Drawing.Color.Transparent
        Me.DetailBunifuButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.DetailBunifuButton.BackgroundImage = CType(resources.GetObject("DetailBunifuButton.BackgroundImage"), System.Drawing.Image)
        Me.DetailBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.DetailBunifuButton.ButtonText = "Detail"
        Me.DetailBunifuButton.ButtonTextMarginLeft = 0
        Me.DetailBunifuButton.ColorContrastOnClick = 45
        Me.DetailBunifuButton.ColorContrastOnHover = 45
        Me.DetailBunifuButton.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges51.BottomLeft = False
        BorderEdges51.BottomRight = True
        BorderEdges51.TopLeft = False
        BorderEdges51.TopRight = True
        Me.DetailBunifuButton.CustomizableEdges = BorderEdges51
        Me.DetailBunifuButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.DetailBunifuButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DetailBunifuButton.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.DetailBunifuButton.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.DetailBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed
        Me.DetailBunifuButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailBunifuButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DetailBunifuButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DetailBunifuButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.DetailBunifuButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.DetailBunifuButton.IconMarginLeft = 11
        Me.DetailBunifuButton.IconPadding = 10
        Me.DetailBunifuButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DetailBunifuButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.DetailBunifuButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.DetailBunifuButton.IconSize = 25
        Me.DetailBunifuButton.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.DetailBunifuButton.IdleBorderRadius = 15
        Me.DetailBunifuButton.IdleBorderThickness = 1
        Me.DetailBunifuButton.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.DetailBunifuButton.IdleIconLeftImage = Global.EasyWarung.My.Resources.Resources.detail
        Me.DetailBunifuButton.IdleIconRightImage = Nothing
        Me.DetailBunifuButton.IndicateFocus = False
        Me.DetailBunifuButton.Location = New System.Drawing.Point(164, 12)
        Me.DetailBunifuButton.Name = "DetailBunifuButton"
        Me.DetailBunifuButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DetailBunifuButton.OnDisabledState.BorderRadius = 15
        Me.DetailBunifuButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.DetailBunifuButton.OnDisabledState.BorderThickness = 1
        Me.DetailBunifuButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.DetailBunifuButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.DetailBunifuButton.OnDisabledState.IconLeftImage = Nothing
        Me.DetailBunifuButton.OnDisabledState.IconRightImage = Nothing
        Me.DetailBunifuButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.DetailBunifuButton.onHoverState.BorderRadius = 15
        Me.DetailBunifuButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.DetailBunifuButton.onHoverState.BorderThickness = 1
        Me.DetailBunifuButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.DetailBunifuButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.DetailBunifuButton.onHoverState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.detail_white
        Me.DetailBunifuButton.onHoverState.IconRightImage = Nothing
        Me.DetailBunifuButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.DetailBunifuButton.OnIdleState.BorderRadius = 15
        Me.DetailBunifuButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.DetailBunifuButton.OnIdleState.BorderThickness = 1
        Me.DetailBunifuButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.DetailBunifuButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DetailBunifuButton.OnIdleState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.detail
        Me.DetailBunifuButton.OnIdleState.IconRightImage = Nothing
        Me.DetailBunifuButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.DetailBunifuButton.OnPressedState.BorderRadius = 15
        Me.DetailBunifuButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.DetailBunifuButton.OnPressedState.BorderThickness = 1
        Me.DetailBunifuButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.DetailBunifuButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.DetailBunifuButton.OnPressedState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.detail_white
        Me.DetailBunifuButton.OnPressedState.IconRightImage = Nothing
        Me.DetailBunifuButton.Size = New System.Drawing.Size(150, 39)
        Me.DetailBunifuButton.TabIndex = 5
        Me.DetailBunifuButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DetailBunifuButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DetailBunifuButton.TextMarginLeft = 0
        Me.DetailBunifuButton.TextPadding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.DetailBunifuButton.UseDefaultRadiusAndThickness = True
        '
        'ReportBunifuButton
        '
        Me.ReportBunifuButton.AllowAnimations = True
        Me.ReportBunifuButton.AllowMouseEffects = True
        Me.ReportBunifuButton.AllowToggling = False
        Me.ReportBunifuButton.AnimationSpeed = 200
        Me.ReportBunifuButton.AutoGenerateColors = False
        Me.ReportBunifuButton.AutoRoundBorders = False
        Me.ReportBunifuButton.AutoSizeLeftIcon = True
        Me.ReportBunifuButton.AutoSizeRightIcon = True
        Me.ReportBunifuButton.BackColor = System.Drawing.Color.Transparent
        Me.ReportBunifuButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ReportBunifuButton.BackgroundImage = CType(resources.GetObject("ReportBunifuButton.BackgroundImage"), System.Drawing.Image)
        Me.ReportBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.ReportBunifuButton.ButtonText = "Report"
        Me.ReportBunifuButton.ButtonTextMarginLeft = 0
        Me.ReportBunifuButton.ColorContrastOnClick = 45
        Me.ReportBunifuButton.ColorContrastOnHover = 45
        Me.ReportBunifuButton.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges52.BottomLeft = True
        BorderEdges52.BottomRight = False
        BorderEdges52.TopLeft = True
        BorderEdges52.TopRight = False
        Me.ReportBunifuButton.CustomizableEdges = BorderEdges52
        Me.ReportBunifuButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.ReportBunifuButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ReportBunifuButton.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ReportBunifuButton.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.ReportBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed
        Me.ReportBunifuButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportBunifuButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.ReportBunifuButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReportBunifuButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.ReportBunifuButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.ReportBunifuButton.IconMarginLeft = 11
        Me.ReportBunifuButton.IconPadding = 10
        Me.ReportBunifuButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ReportBunifuButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.ReportBunifuButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.ReportBunifuButton.IconSize = 25
        Me.ReportBunifuButton.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ReportBunifuButton.IdleBorderRadius = 15
        Me.ReportBunifuButton.IdleBorderThickness = 1
        Me.ReportBunifuButton.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ReportBunifuButton.IdleIconLeftImage = Global.EasyWarung.My.Resources.Resources.report
        Me.ReportBunifuButton.IdleIconRightImage = Nothing
        Me.ReportBunifuButton.IndicateFocus = False
        Me.ReportBunifuButton.Location = New System.Drawing.Point(12, 12)
        Me.ReportBunifuButton.Name = "ReportBunifuButton"
        Me.ReportBunifuButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ReportBunifuButton.OnDisabledState.BorderRadius = 15
        Me.ReportBunifuButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.ReportBunifuButton.OnDisabledState.BorderThickness = 1
        Me.ReportBunifuButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ReportBunifuButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.ReportBunifuButton.OnDisabledState.IconLeftImage = Nothing
        Me.ReportBunifuButton.OnDisabledState.IconRightImage = Nothing
        Me.ReportBunifuButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ReportBunifuButton.onHoverState.BorderRadius = 15
        Me.ReportBunifuButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.ReportBunifuButton.onHoverState.BorderThickness = 1
        Me.ReportBunifuButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ReportBunifuButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.ReportBunifuButton.onHoverState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.report_white
        Me.ReportBunifuButton.onHoverState.IconRightImage = Nothing
        Me.ReportBunifuButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ReportBunifuButton.OnIdleState.BorderRadius = 15
        Me.ReportBunifuButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.ReportBunifuButton.OnIdleState.BorderThickness = 1
        Me.ReportBunifuButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ReportBunifuButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.ReportBunifuButton.OnIdleState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.report
        Me.ReportBunifuButton.OnIdleState.IconRightImage = Nothing
        Me.ReportBunifuButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ReportBunifuButton.OnPressedState.BorderRadius = 15
        Me.ReportBunifuButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.ReportBunifuButton.OnPressedState.BorderThickness = 1
        Me.ReportBunifuButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ReportBunifuButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.ReportBunifuButton.OnPressedState.IconLeftImage = Nothing
        Me.ReportBunifuButton.OnPressedState.IconRightImage = Nothing
        Me.ReportBunifuButton.Size = New System.Drawing.Size(150, 39)
        Me.ReportBunifuButton.TabIndex = 4
        Me.ReportBunifuButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ReportBunifuButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.ReportBunifuButton.TextMarginLeft = 0
        Me.ReportBunifuButton.TextPadding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.ReportBunifuButton.UseDefaultRadiusAndThickness = True
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
        BorderEdges53.BottomLeft = True
        BorderEdges53.BottomRight = True
        BorderEdges53.TopLeft = True
        BorderEdges53.TopRight = True
        Me.UpdateBunifuButton.CustomizableEdges = BorderEdges53
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
        Me.UpdateBunifuButton.Location = New System.Drawing.Point(791, 12)
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
        Me.UpdateBunifuButton.TabIndex = 3
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
        BorderEdges54.BottomLeft = True
        BorderEdges54.BottomRight = False
        BorderEdges54.TopLeft = True
        BorderEdges54.TopRight = False
        Me.InsertBunifuButton.CustomizableEdges = BorderEdges54
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
        Me.InsertBunifuButton.Location = New System.Drawing.Point(639, 12)
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
        Me.InsertBunifuButton.TabIndex = 2
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
        BorderEdges55.BottomLeft = False
        BorderEdges55.BottomRight = True
        BorderEdges55.TopLeft = False
        BorderEdges55.TopRight = True
        Me.DeleteBunifuButton.CustomizableEdges = BorderEdges55
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
        Me.DeleteBunifuButton.Location = New System.Drawing.Point(943, 12)
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
        Me.DeleteBunifuButton.TabIndex = 0
        Me.DeleteBunifuButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DeleteBunifuButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DeleteBunifuButton.TextMarginLeft = 0
        Me.DeleteBunifuButton.TextPadding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.DeleteBunifuButton.UseDefaultRadiusAndThickness = True
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.CursorType = Nothing
        Me.BunifuLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BunifuLabel2.Location = New System.Drawing.Point(395, 355)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(314, 25)
        Me.BunifuLabel2.TabIndex = 4
        Me.BunifuLabel2.Text = "Add new data to display the order list"
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
        Me.BunifuLabel1.Location = New System.Drawing.Point(418, 312)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(268, 31)
        Me.BunifuLabel1.TabIndex = 3
        Me.BunifuLabel1.Text = "The data is currently empty"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'TopBunifuPanel
        '
        Me.TopBunifuPanel.BackgroundColor = System.Drawing.Color.Transparent
        Me.TopBunifuPanel.BackgroundImage = CType(resources.GetObject("TopBunifuPanel.BackgroundImage"), System.Drawing.Image)
        Me.TopBunifuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TopBunifuPanel.BorderColor = System.Drawing.Color.Transparent
        Me.TopBunifuPanel.BorderRadius = 0
        Me.TopBunifuPanel.BorderThickness = 0
        Me.TopBunifuPanel.Controls.Add(Me.SearchBunifuTextBox)
        Me.TopBunifuPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopBunifuPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopBunifuPanel.Name = "TopBunifuPanel"
        Me.TopBunifuPanel.ShowBorders = True
        Me.TopBunifuPanel.Size = New System.Drawing.Size(1105, 68)
        Me.TopBunifuPanel.TabIndex = 3
        '
        'SearchBunifuTextBox
        '
        Me.SearchBunifuTextBox.AcceptsReturn = False
        Me.SearchBunifuTextBox.AcceptsTab = False
        Me.SearchBunifuTextBox.AnimationSpeed = 200
        Me.SearchBunifuTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.SearchBunifuTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.SearchBunifuTextBox.AutoSize = True
        Me.SearchBunifuTextBox.AutoSizeHeight = True
        Me.SearchBunifuTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.SearchBunifuTextBox.BackgroundImage = CType(resources.GetObject("SearchBunifuTextBox.BackgroundImage"), System.Drawing.Image)
        Me.SearchBunifuTextBox.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.SearchBunifuTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SearchBunifuTextBox.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.SearchBunifuTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.SearchBunifuTextBox.BorderRadius = 30
        Me.SearchBunifuTextBox.BorderThickness = 1
        Me.SearchBunifuTextBox.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal
        Me.SearchBunifuTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.SearchBunifuTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchBunifuTextBox.DefaultFont = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBunifuTextBox.DefaultText = ""
        Me.SearchBunifuTextBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.SearchBunifuTextBox.ForeColor = System.Drawing.Color.White
        Me.SearchBunifuTextBox.HideSelection = True
        Me.SearchBunifuTextBox.IconLeft = Global.EasyWarung.My.Resources.Resources.search
        Me.SearchBunifuTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchBunifuTextBox.IconPadding = 10
        Me.SearchBunifuTextBox.IconRight = Nothing
        Me.SearchBunifuTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchBunifuTextBox.Lines = New String(-1) {}
        Me.SearchBunifuTextBox.Location = New System.Drawing.Point(12, 12)
        Me.SearchBunifuTextBox.MaxLength = 32767
        Me.SearchBunifuTextBox.MinimumSize = New System.Drawing.Size(2, 2)
        Me.SearchBunifuTextBox.Modified = False
        Me.SearchBunifuTextBox.Multiline = False
        Me.SearchBunifuTextBox.Name = "SearchBunifuTextBox"
        StateProperties41.BorderColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        StateProperties41.FillColor = System.Drawing.Color.Empty
        StateProperties41.ForeColor = System.Drawing.Color.Empty
        StateProperties41.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.SearchBunifuTextBox.OnActiveState = StateProperties41
        StateProperties42.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties42.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties42.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.SearchBunifuTextBox.OnDisabledState = StateProperties42
        StateProperties43.BorderColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        StateProperties43.FillColor = System.Drawing.Color.Empty
        StateProperties43.ForeColor = System.Drawing.Color.Empty
        StateProperties43.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.SearchBunifuTextBox.OnHoverState = StateProperties43
        StateProperties44.BorderColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        StateProperties44.FillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer))
        StateProperties44.ForeColor = System.Drawing.Color.White
        StateProperties44.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.SearchBunifuTextBox.OnIdleState = StateProperties44
        Me.SearchBunifuTextBox.Padding = New System.Windows.Forms.Padding(3)
        Me.SearchBunifuTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchBunifuTextBox.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.SearchBunifuTextBox.PlaceholderText = "Telusuri"
        Me.SearchBunifuTextBox.ReadOnly = False
        Me.SearchBunifuTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SearchBunifuTextBox.SelectedText = ""
        Me.SearchBunifuTextBox.SelectionLength = 0
        Me.SearchBunifuTextBox.SelectionStart = 0
        Me.SearchBunifuTextBox.ShortcutsEnabled = True
        Me.SearchBunifuTextBox.Size = New System.Drawing.Size(1081, 44)
        Me.SearchBunifuTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.SearchBunifuTextBox.TabIndex = 0
        Me.SearchBunifuTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SearchBunifuTextBox.TextMarginBottom = 0
        Me.SearchBunifuTextBox.TextMarginLeft = 10
        Me.SearchBunifuTextBox.TextMarginTop = 1
        Me.SearchBunifuTextBox.TextPlaceholder = "Telusuri"
        Me.SearchBunifuTextBox.UseSystemPasswordChar = False
        Me.SearchBunifuTextBox.WordWrap = True
        '
        'StatusContextMenuStrip
        '
        Me.StatusContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.StatusContextMenuStrip.DropShadowEnabled = False
        Me.StatusContextMenuStrip.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeStatusToolStripMenuItem})
        Me.StatusContextMenuStrip.Name = "StatusContextMenuStrip"
        Me.StatusContextMenuStrip.ShowImageMargin = False
        Me.StatusContextMenuStrip.Size = New System.Drawing.Size(160, 52)
        '
        'ChangeStatusToolStripMenuItem
        '
        Me.ChangeStatusToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ChangeStatusToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ChangeStatusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PendingToolStripMenuItem, Me.PreparingToolStripMenuItem, Me.ReadyToolStripMenuItem, Me.DeliveredToolStripMenuItem, Me.CompletedToolStripMenuItem})
        Me.ChangeStatusToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ChangeStatusToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ChangeStatusToolStripMenuItem.Name = "ChangeStatusToolStripMenuItem"
        Me.ChangeStatusToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.ChangeStatusToolStripMenuItem.Text = "Change Status"
        '
        'PendingToolStripMenuItem
        '
        Me.PendingToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.PendingToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PendingToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PendingToolStripMenuItem.Name = "PendingToolStripMenuItem"
        Me.PendingToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.PendingToolStripMenuItem.Text = "Pending"
        '
        'PreparingToolStripMenuItem
        '
        Me.PreparingToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.PreparingToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PreparingToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PreparingToolStripMenuItem.Name = "PreparingToolStripMenuItem"
        Me.PreparingToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.PreparingToolStripMenuItem.Text = "Preparing"
        '
        'ReadyToolStripMenuItem
        '
        Me.ReadyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ReadyToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ReadyToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReadyToolStripMenuItem.Name = "ReadyToolStripMenuItem"
        Me.ReadyToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.ReadyToolStripMenuItem.Text = "Ready"
        '
        'DeliveredToolStripMenuItem
        '
        Me.DeliveredToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.DeliveredToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DeliveredToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DeliveredToolStripMenuItem.Name = "DeliveredToolStripMenuItem"
        Me.DeliveredToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.DeliveredToolStripMenuItem.Text = "Delivered"
        '
        'CompletedToolStripMenuItem
        '
        Me.CompletedToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.CompletedToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CompletedToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CompletedToolStripMenuItem.Name = "CompletedToolStripMenuItem"
        Me.CompletedToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.CompletedToolStripMenuItem.Text = "Completed"
        '
        'OrdersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1105, 724)
        Me.Controls.Add(Me.DesktopBunifuPanel)
        Me.Controls.Add(Me.TopBunifuPanel)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "OrdersForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OrdersForm"
        Me.DesktopBunifuPanel.ResumeLayout(False)
        Me.DesktopBunifuPanel.PerformLayout()
        CType(Me.OrdersBunifuDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataControlBunifuPanel.ResumeLayout(False)
        Me.TopBunifuPanel.ResumeLayout(False)
        Me.TopBunifuPanel.PerformLayout()
        Me.StatusContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DesktopBunifuPanel As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents OrdersBunifuDataGridView As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents DataControlBunifuPanel As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents ReportBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton2
    Friend WithEvents UpdateBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton2
    Friend WithEvents InsertBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton2
    Friend WithEvents DeleteBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton2
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents TopBunifuPanel As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents SearchBunifuTextBox As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents DetailBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton2
    Friend WithEvents NoOrderCol As DataGridViewTextBoxColumn
    Friend WithEvents OrderIDCol As DataGridViewTextBoxColumn
    Friend WithEvents OrderDateTimeCol As DataGridViewTextBoxColumn
    Friend WithEvents PaymentNameCol As DataGridViewTextBoxColumn
    Friend WithEvents GrandTotalCol As DataGridViewTextBoxColumn
    Friend WithEvents UserNameOrderCol As DataGridViewTextBoxColumn
    Friend WithEvents OrderStatusStrCol As DataGridViewTextBoxColumn
    Friend WithEvents UserIDOrderCol As DataGridViewTextBoxColumn
    Friend WithEvents PaymentIDCol As DataGridViewTextBoxColumn
    Friend WithEvents OrderStatusIntCol As DataGridViewTextBoxColumn
    Friend WithEvents StatusContextMenuStrip As ContextMenuStrip
    Friend WithEvents ChangeStatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PendingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreparingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReadyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeliveredToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompletedToolStripMenuItem As ToolStripMenuItem
End Class
