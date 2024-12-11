<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoriesInsertUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CategoriesInsertUpdate))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges()
        Me.CategoryNameBunifuLabel = New Bunifu.UI.WinForms.BunifuLabel()
        Me.CategoryNameBunifuTextBox = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.CancelBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2()
        Me.SaveBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2()
        Me.SuspendLayout()
        '
        'CategoryNameBunifuLabel
        '
        Me.CategoryNameBunifuLabel.AllowParentOverrides = False
        Me.CategoryNameBunifuLabel.AutoEllipsis = False
        Me.CategoryNameBunifuLabel.AutoSize = False
        Me.CategoryNameBunifuLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.CategoryNameBunifuLabel.CursorType = System.Windows.Forms.Cursors.Default
        Me.CategoryNameBunifuLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryNameBunifuLabel.ForeColor = System.Drawing.Color.Transparent
        Me.CategoryNameBunifuLabel.Location = New System.Drawing.Point(12, 22)
        Me.CategoryNameBunifuLabel.Name = "CategoryNameBunifuLabel"
        Me.CategoryNameBunifuLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CategoryNameBunifuLabel.Size = New System.Drawing.Size(135, 25)
        Me.CategoryNameBunifuLabel.TabIndex = 0
        Me.CategoryNameBunifuLabel.Text = "Category Name:"
        Me.CategoryNameBunifuLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.CategoryNameBunifuLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'CategoryNameBunifuTextBox
        '
        Me.CategoryNameBunifuTextBox.AcceptsReturn = False
        Me.CategoryNameBunifuTextBox.AcceptsTab = False
        Me.CategoryNameBunifuTextBox.AnimationSpeed = 200
        Me.CategoryNameBunifuTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.CategoryNameBunifuTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.CategoryNameBunifuTextBox.AutoSizeHeight = True
        Me.CategoryNameBunifuTextBox.BackColor = System.Drawing.Color.Transparent
        Me.CategoryNameBunifuTextBox.BackgroundImage = CType(resources.GetObject("CategoryNameBunifuTextBox.BackgroundImage"), System.Drawing.Image)
        Me.CategoryNameBunifuTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.CategoryNameBunifuTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.CategoryNameBunifuTextBox.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CategoryNameBunifuTextBox.BorderColorIdle = System.Drawing.Color.Silver
        Me.CategoryNameBunifuTextBox.BorderRadius = 1
        Me.CategoryNameBunifuTextBox.BorderThickness = 1
        Me.CategoryNameBunifuTextBox.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal
        Me.CategoryNameBunifuTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CategoryNameBunifuTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CategoryNameBunifuTextBox.DefaultFont = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryNameBunifuTextBox.DefaultText = ""
        Me.CategoryNameBunifuTextBox.FillColor = System.Drawing.Color.White
        Me.CategoryNameBunifuTextBox.ForeColor = System.Drawing.Color.Black
        Me.CategoryNameBunifuTextBox.HideSelection = True
        Me.CategoryNameBunifuTextBox.IconLeft = Nothing
        Me.CategoryNameBunifuTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.CategoryNameBunifuTextBox.IconPadding = 10
        Me.CategoryNameBunifuTextBox.IconRight = Nothing
        Me.CategoryNameBunifuTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.CategoryNameBunifuTextBox.Lines = New String(-1) {}
        Me.CategoryNameBunifuTextBox.Location = New System.Drawing.Point(153, 12)
        Me.CategoryNameBunifuTextBox.MaxLength = 32767
        Me.CategoryNameBunifuTextBox.MinimumSize = New System.Drawing.Size(1, 1)
        Me.CategoryNameBunifuTextBox.Modified = False
        Me.CategoryNameBunifuTextBox.Multiline = False
        Me.CategoryNameBunifuTextBox.Name = "CategoryNameBunifuTextBox"
        StateProperties1.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.CategoryNameBunifuTextBox.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.CategoryNameBunifuTextBox.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.CategoryNameBunifuTextBox.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Black
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.CategoryNameBunifuTextBox.OnIdleState = StateProperties4
        Me.CategoryNameBunifuTextBox.Padding = New System.Windows.Forms.Padding(3)
        Me.CategoryNameBunifuTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CategoryNameBunifuTextBox.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.CategoryNameBunifuTextBox.PlaceholderText = "Enter text"
        Me.CategoryNameBunifuTextBox.ReadOnly = False
        Me.CategoryNameBunifuTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.CategoryNameBunifuTextBox.SelectedText = ""
        Me.CategoryNameBunifuTextBox.SelectionLength = 0
        Me.CategoryNameBunifuTextBox.SelectionStart = 0
        Me.CategoryNameBunifuTextBox.ShortcutsEnabled = True
        Me.CategoryNameBunifuTextBox.Size = New System.Drawing.Size(260, 44)
        Me.CategoryNameBunifuTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.CategoryNameBunifuTextBox.TabIndex = 1
        Me.CategoryNameBunifuTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.CategoryNameBunifuTextBox.TextMarginBottom = 0
        Me.CategoryNameBunifuTextBox.TextMarginLeft = 3
        Me.CategoryNameBunifuTextBox.TextMarginTop = 1
        Me.CategoryNameBunifuTextBox.TextPlaceholder = "Enter text"
        Me.CategoryNameBunifuTextBox.UseSystemPasswordChar = False
        Me.CategoryNameBunifuTextBox.WordWrap = True
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
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.CancelBunifuButton.CustomizableEdges = BorderEdges1
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
        Me.CancelBunifuButton.Location = New System.Drawing.Point(223, 67)
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
        Me.CancelBunifuButton.TabIndex = 2
        Me.CancelBunifuButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CancelBunifuButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.CancelBunifuButton.TextMarginLeft = 0
        Me.CancelBunifuButton.TextPadding = New System.Windows.Forms.Padding(0)
        Me.CancelBunifuButton.UseDefaultRadiusAndThickness = True
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
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.SaveBunifuButton.CustomizableEdges = BorderEdges2
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
        Me.SaveBunifuButton.Location = New System.Drawing.Point(12, 67)
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
        Me.SaveBunifuButton.TabIndex = 3
        Me.SaveBunifuButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SaveBunifuButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.SaveBunifuButton.TextMarginLeft = 0
        Me.SaveBunifuButton.TextPadding = New System.Windows.Forms.Padding(0)
        Me.SaveBunifuButton.UseDefaultRadiusAndThickness = True
        '
        'CategoriesInsert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(425, 118)
        Me.Controls.Add(Me.SaveBunifuButton)
        Me.Controls.Add(Me.CancelBunifuButton)
        Me.Controls.Add(Me.CategoryNameBunifuTextBox)
        Me.Controls.Add(Me.CategoryNameBunifuLabel)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "CategoriesInsert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CategoriesInsert"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CategoryNameBunifuLabel As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents CategoryNameBunifuTextBox As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents CancelBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton2
    Friend WithEvents SaveBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton2
End Class
