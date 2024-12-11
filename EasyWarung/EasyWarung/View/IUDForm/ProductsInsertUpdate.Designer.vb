<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductsInsertUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductsInsertUpdate))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties7 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties8 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Me.ProductNameBunifuLabel = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.ProductBunifuPictureBox = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.ProductPriceBunifuTextBox = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.SaveBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2()
        Me.CancelBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2()
        Me.ProductNameBunifuTextBox = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.CategoryBunifuDropdown = New Bunifu.UI.WinForms.BunifuDropdown()
        CType(Me.ProductBunifuPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductNameBunifuLabel
        '
        Me.ProductNameBunifuLabel.AllowParentOverrides = False
        Me.ProductNameBunifuLabel.AutoEllipsis = False
        Me.ProductNameBunifuLabel.AutoSize = False
        Me.ProductNameBunifuLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.ProductNameBunifuLabel.CursorType = System.Windows.Forms.Cursors.Default
        Me.ProductNameBunifuLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ProductNameBunifuLabel.ForeColor = System.Drawing.Color.Transparent
        Me.ProductNameBunifuLabel.Location = New System.Drawing.Point(224, 22)
        Me.ProductNameBunifuLabel.Name = "ProductNameBunifuLabel"
        Me.ProductNameBunifuLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ProductNameBunifuLabel.Size = New System.Drawing.Size(135, 25)
        Me.ProductNameBunifuLabel.TabIndex = 4
        Me.ProductNameBunifuLabel.Text = "Product Name:"
        Me.ProductNameBunifuLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.ProductNameBunifuLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.AutoSize = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuLabel1.Location = New System.Drawing.Point(224, 72)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(135, 25)
        Me.BunifuLabel1.TabIndex = 8
        Me.BunifuLabel1.Text = "Product Price:"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.AutoSize = False
        Me.BunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuLabel2.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuLabel2.Location = New System.Drawing.Point(224, 116)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(135, 25)
        Me.BunifuLabel2.TabIndex = 11
        Me.BunifuLabel2.Text = "Product Category:"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'ProductBunifuPictureBox
        '
        Me.ProductBunifuPictureBox.AllowFocused = False
        Me.ProductBunifuPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProductBunifuPictureBox.AutoSizeHeight = True
        Me.ProductBunifuPictureBox.BorderRadius = 0
        Me.ProductBunifuPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProductBunifuPictureBox.Image = Global.EasyWarung.My.Resources.Resources.no_picture
        Me.ProductBunifuPictureBox.IsCircle = True
        Me.ProductBunifuPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.ProductBunifuPictureBox.Name = "ProductBunifuPictureBox"
        Me.ProductBunifuPictureBox.Size = New System.Drawing.Size(200, 200)
        Me.ProductBunifuPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ProductBunifuPictureBox.TabIndex = 10
        Me.ProductBunifuPictureBox.TabStop = False
        Me.ProductBunifuPictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'ProductPriceBunifuTextBox
        '
        Me.ProductPriceBunifuTextBox.AcceptsReturn = False
        Me.ProductPriceBunifuTextBox.AcceptsTab = False
        Me.ProductPriceBunifuTextBox.AnimationSpeed = 200
        Me.ProductPriceBunifuTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.ProductPriceBunifuTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.ProductPriceBunifuTextBox.AutoSizeHeight = True
        Me.ProductPriceBunifuTextBox.BackColor = System.Drawing.Color.Transparent
        Me.ProductPriceBunifuTextBox.BackgroundImage = CType(resources.GetObject("ProductPriceBunifuTextBox.BackgroundImage"), System.Drawing.Image)
        Me.ProductPriceBunifuTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.ProductPriceBunifuTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ProductPriceBunifuTextBox.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductPriceBunifuTextBox.BorderColorIdle = System.Drawing.Color.Silver
        Me.ProductPriceBunifuTextBox.BorderRadius = 1
        Me.ProductPriceBunifuTextBox.BorderThickness = 1
        Me.ProductPriceBunifuTextBox.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal
        Me.ProductPriceBunifuTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ProductPriceBunifuTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ProductPriceBunifuTextBox.DefaultFont = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductPriceBunifuTextBox.DefaultText = ""
        Me.ProductPriceBunifuTextBox.FillColor = System.Drawing.Color.White
        Me.ProductPriceBunifuTextBox.ForeColor = System.Drawing.Color.Black
        Me.ProductPriceBunifuTextBox.HideSelection = True
        Me.ProductPriceBunifuTextBox.IconLeft = Nothing
        Me.ProductPriceBunifuTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.ProductPriceBunifuTextBox.IconPadding = 10
        Me.ProductPriceBunifuTextBox.IconRight = Nothing
        Me.ProductPriceBunifuTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.ProductPriceBunifuTextBox.Lines = New String(-1) {}
        Me.ProductPriceBunifuTextBox.Location = New System.Drawing.Point(365, 62)
        Me.ProductPriceBunifuTextBox.MaxLength = 32767
        Me.ProductPriceBunifuTextBox.MinimumSize = New System.Drawing.Size(1, 1)
        Me.ProductPriceBunifuTextBox.Modified = False
        Me.ProductPriceBunifuTextBox.Multiline = False
        Me.ProductPriceBunifuTextBox.Name = "ProductPriceBunifuTextBox"
        StateProperties1.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.ProductPriceBunifuTextBox.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.ProductPriceBunifuTextBox.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.ProductPriceBunifuTextBox.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Black
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.ProductPriceBunifuTextBox.OnIdleState = StateProperties4
        Me.ProductPriceBunifuTextBox.Padding = New System.Windows.Forms.Padding(3)
        Me.ProductPriceBunifuTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ProductPriceBunifuTextBox.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.ProductPriceBunifuTextBox.PlaceholderText = "Enter text"
        Me.ProductPriceBunifuTextBox.ReadOnly = False
        Me.ProductPriceBunifuTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ProductPriceBunifuTextBox.SelectedText = ""
        Me.ProductPriceBunifuTextBox.SelectionLength = 0
        Me.ProductPriceBunifuTextBox.SelectionStart = 0
        Me.ProductPriceBunifuTextBox.ShortcutsEnabled = True
        Me.ProductPriceBunifuTextBox.Size = New System.Drawing.Size(260, 44)
        Me.ProductPriceBunifuTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.ProductPriceBunifuTextBox.TabIndex = 9
        Me.ProductPriceBunifuTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ProductPriceBunifuTextBox.TextMarginBottom = 0
        Me.ProductPriceBunifuTextBox.TextMarginLeft = 3
        Me.ProductPriceBunifuTextBox.TextMarginTop = 1
        Me.ProductPriceBunifuTextBox.TextPlaceholder = "Enter text"
        Me.ProductPriceBunifuTextBox.UseSystemPasswordChar = False
        Me.ProductPriceBunifuTextBox.WordWrap = True
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
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.SaveBunifuButton.CustomizableEdges = BorderEdges1
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
        Me.SaveBunifuButton.Location = New System.Drawing.Point(224, 173)
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
        Me.SaveBunifuButton.TabIndex = 7
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
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.CancelBunifuButton.CustomizableEdges = BorderEdges2
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
        Me.CancelBunifuButton.Location = New System.Drawing.Point(435, 173)
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
        Me.CancelBunifuButton.TabIndex = 6
        Me.CancelBunifuButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CancelBunifuButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.CancelBunifuButton.TextMarginLeft = 0
        Me.CancelBunifuButton.TextPadding = New System.Windows.Forms.Padding(0)
        Me.CancelBunifuButton.UseDefaultRadiusAndThickness = True
        '
        'ProductNameBunifuTextBox
        '
        Me.ProductNameBunifuTextBox.AcceptsReturn = False
        Me.ProductNameBunifuTextBox.AcceptsTab = False
        Me.ProductNameBunifuTextBox.AnimationSpeed = 200
        Me.ProductNameBunifuTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.ProductNameBunifuTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.ProductNameBunifuTextBox.AutoSizeHeight = True
        Me.ProductNameBunifuTextBox.BackColor = System.Drawing.Color.Transparent
        Me.ProductNameBunifuTextBox.BackgroundImage = CType(resources.GetObject("ProductNameBunifuTextBox.BackgroundImage"), System.Drawing.Image)
        Me.ProductNameBunifuTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.ProductNameBunifuTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ProductNameBunifuTextBox.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductNameBunifuTextBox.BorderColorIdle = System.Drawing.Color.Silver
        Me.ProductNameBunifuTextBox.BorderRadius = 1
        Me.ProductNameBunifuTextBox.BorderThickness = 1
        Me.ProductNameBunifuTextBox.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal
        Me.ProductNameBunifuTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ProductNameBunifuTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ProductNameBunifuTextBox.DefaultFont = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductNameBunifuTextBox.DefaultText = ""
        Me.ProductNameBunifuTextBox.FillColor = System.Drawing.Color.White
        Me.ProductNameBunifuTextBox.ForeColor = System.Drawing.Color.Black
        Me.ProductNameBunifuTextBox.HideSelection = True
        Me.ProductNameBunifuTextBox.IconLeft = Nothing
        Me.ProductNameBunifuTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.ProductNameBunifuTextBox.IconPadding = 10
        Me.ProductNameBunifuTextBox.IconRight = Nothing
        Me.ProductNameBunifuTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.ProductNameBunifuTextBox.Lines = New String(-1) {}
        Me.ProductNameBunifuTextBox.Location = New System.Drawing.Point(365, 12)
        Me.ProductNameBunifuTextBox.MaxLength = 32767
        Me.ProductNameBunifuTextBox.MinimumSize = New System.Drawing.Size(1, 1)
        Me.ProductNameBunifuTextBox.Modified = False
        Me.ProductNameBunifuTextBox.Multiline = False
        Me.ProductNameBunifuTextBox.Name = "ProductNameBunifuTextBox"
        StateProperties5.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties5.FillColor = System.Drawing.Color.Empty
        StateProperties5.ForeColor = System.Drawing.Color.Empty
        StateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.ProductNameBunifuTextBox.OnActiveState = StateProperties5
        StateProperties6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties6.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.ProductNameBunifuTextBox.OnDisabledState = StateProperties6
        StateProperties7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties7.FillColor = System.Drawing.Color.Empty
        StateProperties7.ForeColor = System.Drawing.Color.Empty
        StateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.ProductNameBunifuTextBox.OnHoverState = StateProperties7
        StateProperties8.BorderColor = System.Drawing.Color.Silver
        StateProperties8.FillColor = System.Drawing.Color.White
        StateProperties8.ForeColor = System.Drawing.Color.Black
        StateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.ProductNameBunifuTextBox.OnIdleState = StateProperties8
        Me.ProductNameBunifuTextBox.Padding = New System.Windows.Forms.Padding(3)
        Me.ProductNameBunifuTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ProductNameBunifuTextBox.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.ProductNameBunifuTextBox.PlaceholderText = "Enter text"
        Me.ProductNameBunifuTextBox.ReadOnly = False
        Me.ProductNameBunifuTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ProductNameBunifuTextBox.SelectedText = ""
        Me.ProductNameBunifuTextBox.SelectionLength = 0
        Me.ProductNameBunifuTextBox.SelectionStart = 0
        Me.ProductNameBunifuTextBox.ShortcutsEnabled = True
        Me.ProductNameBunifuTextBox.Size = New System.Drawing.Size(260, 44)
        Me.ProductNameBunifuTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.ProductNameBunifuTextBox.TabIndex = 5
        Me.ProductNameBunifuTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ProductNameBunifuTextBox.TextMarginBottom = 0
        Me.ProductNameBunifuTextBox.TextMarginLeft = 3
        Me.ProductNameBunifuTextBox.TextMarginTop = 1
        Me.ProductNameBunifuTextBox.TextPlaceholder = "Enter text"
        Me.ProductNameBunifuTextBox.UseSystemPasswordChar = False
        Me.ProductNameBunifuTextBox.WordWrap = True
        '
        'CategoryBunifuDropdown
        '
        Me.CategoryBunifuDropdown.BackColor = System.Drawing.Color.Transparent
        Me.CategoryBunifuDropdown.BackgroundColor = System.Drawing.Color.White
        Me.CategoryBunifuDropdown.BorderColor = System.Drawing.Color.Silver
        Me.CategoryBunifuDropdown.BorderRadius = 1
        Me.CategoryBunifuDropdown.Color = System.Drawing.Color.Silver
        Me.CategoryBunifuDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.CategoryBunifuDropdown.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.CategoryBunifuDropdown.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.CategoryBunifuDropdown.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.CategoryBunifuDropdown.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.CategoryBunifuDropdown.DisabledIndicatorColor = System.Drawing.Color.DarkGray
        Me.CategoryBunifuDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CategoryBunifuDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin
        Me.CategoryBunifuDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryBunifuDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.CategoryBunifuDropdown.FillDropDown = True
        Me.CategoryBunifuDropdown.FillIndicator = False
        Me.CategoryBunifuDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CategoryBunifuDropdown.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryBunifuDropdown.ForeColor = System.Drawing.Color.Black
        Me.CategoryBunifuDropdown.FormattingEnabled = True
        Me.CategoryBunifuDropdown.Icon = Nothing
        Me.CategoryBunifuDropdown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.CategoryBunifuDropdown.IndicatorColor = System.Drawing.Color.DarkGray
        Me.CategoryBunifuDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.CategoryBunifuDropdown.IndicatorThickness = 2
        Me.CategoryBunifuDropdown.IsDropdownOpened = False
        Me.CategoryBunifuDropdown.ItemBackColor = System.Drawing.Color.White
        Me.CategoryBunifuDropdown.ItemBorderColor = System.Drawing.Color.White
        Me.CategoryBunifuDropdown.ItemForeColor = System.Drawing.Color.Black
        Me.CategoryBunifuDropdown.ItemHeight = 26
        Me.CategoryBunifuDropdown.ItemHighLightColor = System.Drawing.Color.DodgerBlue
        Me.CategoryBunifuDropdown.ItemHighLightForeColor = System.Drawing.Color.White
        Me.CategoryBunifuDropdown.ItemTopMargin = 3
        Me.CategoryBunifuDropdown.Location = New System.Drawing.Point(365, 112)
        Me.CategoryBunifuDropdown.Name = "CategoryBunifuDropdown"
        Me.CategoryBunifuDropdown.Size = New System.Drawing.Size(260, 32)
        Me.CategoryBunifuDropdown.TabIndex = 12
        Me.CategoryBunifuDropdown.Text = Nothing
        Me.CategoryBunifuDropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.CategoryBunifuDropdown.TextLeftMargin = 5
        '
        'ProductsInsertUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(637, 224)
        Me.Controls.Add(Me.CategoryBunifuDropdown)
        Me.Controls.Add(Me.BunifuLabel2)
        Me.Controls.Add(Me.ProductBunifuPictureBox)
        Me.Controls.Add(Me.ProductPriceBunifuTextBox)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.SaveBunifuButton)
        Me.Controls.Add(Me.CancelBunifuButton)
        Me.Controls.Add(Me.ProductNameBunifuTextBox)
        Me.Controls.Add(Me.ProductNameBunifuLabel)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ProductsInsertUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProductsInsertUpdate"
        CType(Me.ProductBunifuPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SaveBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton2
    Friend WithEvents CancelBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton2
    Friend WithEvents ProductNameBunifuTextBox As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents ProductNameBunifuLabel As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents ProductPriceBunifuTextBox As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents ProductBunifuPictureBox As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents CategoryBunifuDropdown As Bunifu.UI.WinForms.BunifuDropdown
End Class
