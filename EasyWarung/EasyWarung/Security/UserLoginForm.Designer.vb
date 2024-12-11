<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserLoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserLoginForm))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges()
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties7 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties8 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Me.LeftSideBunifuPanel = New Bunifu.UI.WinForms.BunifuPanel()
        Me.LogoBunifuPictureBox = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.RightSideBunifuPanel = New Bunifu.UI.WinForms.BunifuPanel()
        Me.SignInBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2()
        Me.CancelBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2()
        Me.PasswordBunifuTextBox = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.PasswordBunifuLabel = New Bunifu.UI.WinForms.BunifuLabel()
        Me.UsernameBunifuTextBox = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.UsernameBunifuLabel = New Bunifu.UI.WinForms.BunifuLabel()
        Me.LeftSideBunifuPanel.SuspendLayout()
        CType(Me.LogoBunifuPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RightSideBunifuPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'LeftSideBunifuPanel
        '
        Me.LeftSideBunifuPanel.BackgroundColor = System.Drawing.Color.Transparent
        Me.LeftSideBunifuPanel.BackgroundImage = CType(resources.GetObject("LeftSideBunifuPanel.BackgroundImage"), System.Drawing.Image)
        Me.LeftSideBunifuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LeftSideBunifuPanel.BorderColor = System.Drawing.Color.Transparent
        Me.LeftSideBunifuPanel.BorderRadius = 3
        Me.LeftSideBunifuPanel.BorderThickness = 1
        Me.LeftSideBunifuPanel.Controls.Add(Me.LogoBunifuPictureBox)
        Me.LeftSideBunifuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftSideBunifuPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftSideBunifuPanel.Name = "LeftSideBunifuPanel"
        Me.LeftSideBunifuPanel.ShowBorders = True
        Me.LeftSideBunifuPanel.Size = New System.Drawing.Size(360, 360)
        Me.LeftSideBunifuPanel.TabIndex = 0
        '
        'LogoBunifuPictureBox
        '
        Me.LogoBunifuPictureBox.AllowFocused = False
        Me.LogoBunifuPictureBox.AutoSizeHeight = True
        Me.LogoBunifuPictureBox.BorderRadius = 0
        Me.LogoBunifuPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogoBunifuPictureBox.Image = Global.EasyWarung.My.Resources.Resources.logo
        Me.LogoBunifuPictureBox.IsCircle = True
        Me.LogoBunifuPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoBunifuPictureBox.Name = "LogoBunifuPictureBox"
        Me.LogoBunifuPictureBox.Size = New System.Drawing.Size(360, 360)
        Me.LogoBunifuPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoBunifuPictureBox.TabIndex = 0
        Me.LogoBunifuPictureBox.TabStop = False
        Me.LogoBunifuPictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'RightSideBunifuPanel
        '
        Me.RightSideBunifuPanel.BackgroundColor = System.Drawing.Color.Transparent
        Me.RightSideBunifuPanel.BackgroundImage = CType(resources.GetObject("RightSideBunifuPanel.BackgroundImage"), System.Drawing.Image)
        Me.RightSideBunifuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RightSideBunifuPanel.BorderColor = System.Drawing.Color.Transparent
        Me.RightSideBunifuPanel.BorderRadius = 3
        Me.RightSideBunifuPanel.BorderThickness = 1
        Me.RightSideBunifuPanel.Controls.Add(Me.SignInBunifuButton)
        Me.RightSideBunifuPanel.Controls.Add(Me.CancelBunifuButton)
        Me.RightSideBunifuPanel.Controls.Add(Me.PasswordBunifuTextBox)
        Me.RightSideBunifuPanel.Controls.Add(Me.PasswordBunifuLabel)
        Me.RightSideBunifuPanel.Controls.Add(Me.UsernameBunifuTextBox)
        Me.RightSideBunifuPanel.Controls.Add(Me.UsernameBunifuLabel)
        Me.RightSideBunifuPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightSideBunifuPanel.Location = New System.Drawing.Point(360, 0)
        Me.RightSideBunifuPanel.Name = "RightSideBunifuPanel"
        Me.RightSideBunifuPanel.ShowBorders = True
        Me.RightSideBunifuPanel.Size = New System.Drawing.Size(360, 360)
        Me.RightSideBunifuPanel.TabIndex = 0
        '
        'SignInBunifuButton
        '
        Me.SignInBunifuButton.AllowAnimations = True
        Me.SignInBunifuButton.AllowMouseEffects = True
        Me.SignInBunifuButton.AllowToggling = False
        Me.SignInBunifuButton.AnimationSpeed = 200
        Me.SignInBunifuButton.AutoGenerateColors = False
        Me.SignInBunifuButton.AutoRoundBorders = False
        Me.SignInBunifuButton.AutoSizeLeftIcon = True
        Me.SignInBunifuButton.AutoSizeRightIcon = True
        Me.SignInBunifuButton.BackColor = System.Drawing.Color.Transparent
        Me.SignInBunifuButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SignInBunifuButton.BackgroundImage = CType(resources.GetObject("SignInBunifuButton.BackgroundImage"), System.Drawing.Image)
        Me.SignInBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.SignInBunifuButton.ButtonText = "Sign In"
        Me.SignInBunifuButton.ButtonTextMarginLeft = 0
        Me.SignInBunifuButton.ColorContrastOnClick = 45
        Me.SignInBunifuButton.ColorContrastOnHover = 45
        Me.SignInBunifuButton.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.SignInBunifuButton.CustomizableEdges = BorderEdges1
        Me.SignInBunifuButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SignInBunifuButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.SignInBunifuButton.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SignInBunifuButton.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.SignInBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed
        Me.SignInBunifuButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignInBunifuButton.ForeColor = System.Drawing.Color.White
        Me.SignInBunifuButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SignInBunifuButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.SignInBunifuButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.SignInBunifuButton.IconMarginLeft = 11
        Me.SignInBunifuButton.IconPadding = 10
        Me.SignInBunifuButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SignInBunifuButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.SignInBunifuButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.SignInBunifuButton.IconSize = 25
        Me.SignInBunifuButton.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SignInBunifuButton.IdleBorderRadius = 1
        Me.SignInBunifuButton.IdleBorderThickness = 1
        Me.SignInBunifuButton.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SignInBunifuButton.IdleIconLeftImage = Nothing
        Me.SignInBunifuButton.IdleIconRightImage = Nothing
        Me.SignInBunifuButton.IndicateFocus = False
        Me.SignInBunifuButton.Location = New System.Drawing.Point(30, 290)
        Me.SignInBunifuButton.Name = "SignInBunifuButton"
        Me.SignInBunifuButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.SignInBunifuButton.OnDisabledState.BorderRadius = 1
        Me.SignInBunifuButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.SignInBunifuButton.OnDisabledState.BorderThickness = 1
        Me.SignInBunifuButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SignInBunifuButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.SignInBunifuButton.OnDisabledState.IconLeftImage = Nothing
        Me.SignInBunifuButton.OnDisabledState.IconRightImage = Nothing
        Me.SignInBunifuButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SignInBunifuButton.onHoverState.BorderRadius = 1
        Me.SignInBunifuButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.SignInBunifuButton.onHoverState.BorderThickness = 1
        Me.SignInBunifuButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SignInBunifuButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.SignInBunifuButton.onHoverState.IconLeftImage = Nothing
        Me.SignInBunifuButton.onHoverState.IconRightImage = Nothing
        Me.SignInBunifuButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SignInBunifuButton.OnIdleState.BorderRadius = 1
        Me.SignInBunifuButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.SignInBunifuButton.OnIdleState.BorderThickness = 1
        Me.SignInBunifuButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SignInBunifuButton.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.SignInBunifuButton.OnIdleState.IconLeftImage = Nothing
        Me.SignInBunifuButton.OnIdleState.IconRightImage = Nothing
        Me.SignInBunifuButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SignInBunifuButton.OnPressedState.BorderRadius = 1
        Me.SignInBunifuButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.SignInBunifuButton.OnPressedState.BorderThickness = 1
        Me.SignInBunifuButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SignInBunifuButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.SignInBunifuButton.OnPressedState.IconLeftImage = Nothing
        Me.SignInBunifuButton.OnPressedState.IconRightImage = Nothing
        Me.SignInBunifuButton.Size = New System.Drawing.Size(140, 39)
        Me.SignInBunifuButton.TabIndex = 3
        Me.SignInBunifuButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SignInBunifuButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.SignInBunifuButton.TextMarginLeft = 0
        Me.SignInBunifuButton.TextPadding = New System.Windows.Forms.Padding(0)
        Me.SignInBunifuButton.UseDefaultRadiusAndThickness = True
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
        Me.CancelBunifuButton.Location = New System.Drawing.Point(190, 290)
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
        Me.CancelBunifuButton.Size = New System.Drawing.Size(140, 39)
        Me.CancelBunifuButton.TabIndex = 4
        Me.CancelBunifuButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CancelBunifuButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.CancelBunifuButton.TextMarginLeft = 0
        Me.CancelBunifuButton.TextPadding = New System.Windows.Forms.Padding(0)
        Me.CancelBunifuButton.UseDefaultRadiusAndThickness = True
        '
        'PasswordBunifuTextBox
        '
        Me.PasswordBunifuTextBox.AcceptsReturn = False
        Me.PasswordBunifuTextBox.AcceptsTab = False
        Me.PasswordBunifuTextBox.AnimationSpeed = 200
        Me.PasswordBunifuTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.PasswordBunifuTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.PasswordBunifuTextBox.AutoSizeHeight = True
        Me.PasswordBunifuTextBox.BackColor = System.Drawing.Color.Transparent
        Me.PasswordBunifuTextBox.BackgroundImage = CType(resources.GetObject("PasswordBunifuTextBox.BackgroundImage"), System.Drawing.Image)
        Me.PasswordBunifuTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.PasswordBunifuTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PasswordBunifuTextBox.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordBunifuTextBox.BorderColorIdle = System.Drawing.Color.Silver
        Me.PasswordBunifuTextBox.BorderRadius = 1
        Me.PasswordBunifuTextBox.BorderThickness = 1
        Me.PasswordBunifuTextBox.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal
        Me.PasswordBunifuTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.PasswordBunifuTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordBunifuTextBox.DefaultFont = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordBunifuTextBox.DefaultText = ""
        Me.PasswordBunifuTextBox.FillColor = System.Drawing.Color.White
        Me.PasswordBunifuTextBox.ForeColor = System.Drawing.Color.Black
        Me.PasswordBunifuTextBox.HideSelection = True
        Me.PasswordBunifuTextBox.IconLeft = Nothing
        Me.PasswordBunifuTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordBunifuTextBox.IconPadding = 10
        Me.PasswordBunifuTextBox.IconRight = Nothing
        Me.PasswordBunifuTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordBunifuTextBox.Lines = New String(-1) {}
        Me.PasswordBunifuTextBox.Location = New System.Drawing.Point(30, 225)
        Me.PasswordBunifuTextBox.MaxLength = 32767
        Me.PasswordBunifuTextBox.MinimumSize = New System.Drawing.Size(1, 1)
        Me.PasswordBunifuTextBox.Modified = False
        Me.PasswordBunifuTextBox.Multiline = False
        Me.PasswordBunifuTextBox.Name = "PasswordBunifuTextBox"
        StateProperties1.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.PasswordBunifuTextBox.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.PasswordBunifuTextBox.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.PasswordBunifuTextBox.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Black
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.PasswordBunifuTextBox.OnIdleState = StateProperties4
        Me.PasswordBunifuTextBox.Padding = New System.Windows.Forms.Padding(3)
        Me.PasswordBunifuTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordBunifuTextBox.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.PasswordBunifuTextBox.PlaceholderText = "Enter text"
        Me.PasswordBunifuTextBox.ReadOnly = False
        Me.PasswordBunifuTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PasswordBunifuTextBox.SelectedText = ""
        Me.PasswordBunifuTextBox.SelectionLength = 0
        Me.PasswordBunifuTextBox.SelectionStart = 0
        Me.PasswordBunifuTextBox.ShortcutsEnabled = True
        Me.PasswordBunifuTextBox.Size = New System.Drawing.Size(300, 44)
        Me.PasswordBunifuTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.PasswordBunifuTextBox.TabIndex = 2
        Me.PasswordBunifuTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.PasswordBunifuTextBox.TextMarginBottom = 0
        Me.PasswordBunifuTextBox.TextMarginLeft = 3
        Me.PasswordBunifuTextBox.TextMarginTop = 1
        Me.PasswordBunifuTextBox.TextPlaceholder = "Enter text"
        Me.PasswordBunifuTextBox.UseSystemPasswordChar = False
        Me.PasswordBunifuTextBox.WordWrap = True
        '
        'PasswordBunifuLabel
        '
        Me.PasswordBunifuLabel.AllowParentOverrides = False
        Me.PasswordBunifuLabel.AutoEllipsis = False
        Me.PasswordBunifuLabel.AutoSize = False
        Me.PasswordBunifuLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.PasswordBunifuLabel.CursorType = System.Windows.Forms.Cursors.Default
        Me.PasswordBunifuLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordBunifuLabel.ForeColor = System.Drawing.Color.Transparent
        Me.PasswordBunifuLabel.Location = New System.Drawing.Point(30, 195)
        Me.PasswordBunifuLabel.Name = "PasswordBunifuLabel"
        Me.PasswordBunifuLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PasswordBunifuLabel.Size = New System.Drawing.Size(135, 25)
        Me.PasswordBunifuLabel.TabIndex = 0
        Me.PasswordBunifuLabel.Text = "Password:"
        Me.PasswordBunifuLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.PasswordBunifuLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'UsernameBunifuTextBox
        '
        Me.UsernameBunifuTextBox.AcceptsReturn = False
        Me.UsernameBunifuTextBox.AcceptsTab = False
        Me.UsernameBunifuTextBox.AnimationSpeed = 200
        Me.UsernameBunifuTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.UsernameBunifuTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.UsernameBunifuTextBox.AutoSizeHeight = True
        Me.UsernameBunifuTextBox.BackColor = System.Drawing.Color.Transparent
        Me.UsernameBunifuTextBox.BackgroundImage = CType(resources.GetObject("UsernameBunifuTextBox.BackgroundImage"), System.Drawing.Image)
        Me.UsernameBunifuTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.UsernameBunifuTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.UsernameBunifuTextBox.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameBunifuTextBox.BorderColorIdle = System.Drawing.Color.Silver
        Me.UsernameBunifuTextBox.BorderRadius = 1
        Me.UsernameBunifuTextBox.BorderThickness = 1
        Me.UsernameBunifuTextBox.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal
        Me.UsernameBunifuTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.UsernameBunifuTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsernameBunifuTextBox.DefaultFont = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameBunifuTextBox.DefaultText = ""
        Me.UsernameBunifuTextBox.FillColor = System.Drawing.Color.White
        Me.UsernameBunifuTextBox.ForeColor = System.Drawing.Color.Black
        Me.UsernameBunifuTextBox.HideSelection = True
        Me.UsernameBunifuTextBox.IconLeft = Nothing
        Me.UsernameBunifuTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.UsernameBunifuTextBox.IconPadding = 10
        Me.UsernameBunifuTextBox.IconRight = Nothing
        Me.UsernameBunifuTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.UsernameBunifuTextBox.Lines = New String(-1) {}
        Me.UsernameBunifuTextBox.Location = New System.Drawing.Point(30, 135)
        Me.UsernameBunifuTextBox.MaxLength = 32767
        Me.UsernameBunifuTextBox.MinimumSize = New System.Drawing.Size(1, 1)
        Me.UsernameBunifuTextBox.Modified = False
        Me.UsernameBunifuTextBox.Multiline = False
        Me.UsernameBunifuTextBox.Name = "UsernameBunifuTextBox"
        StateProperties5.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties5.FillColor = System.Drawing.Color.Empty
        StateProperties5.ForeColor = System.Drawing.Color.Empty
        StateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.UsernameBunifuTextBox.OnActiveState = StateProperties5
        StateProperties6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties6.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.UsernameBunifuTextBox.OnDisabledState = StateProperties6
        StateProperties7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties7.FillColor = System.Drawing.Color.Empty
        StateProperties7.ForeColor = System.Drawing.Color.Empty
        StateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.UsernameBunifuTextBox.OnHoverState = StateProperties7
        StateProperties8.BorderColor = System.Drawing.Color.Silver
        StateProperties8.FillColor = System.Drawing.Color.White
        StateProperties8.ForeColor = System.Drawing.Color.Black
        StateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.UsernameBunifuTextBox.OnIdleState = StateProperties8
        Me.UsernameBunifuTextBox.Padding = New System.Windows.Forms.Padding(3)
        Me.UsernameBunifuTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameBunifuTextBox.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.UsernameBunifuTextBox.PlaceholderText = "Enter text"
        Me.UsernameBunifuTextBox.ReadOnly = False
        Me.UsernameBunifuTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UsernameBunifuTextBox.SelectedText = ""
        Me.UsernameBunifuTextBox.SelectionLength = 0
        Me.UsernameBunifuTextBox.SelectionStart = 0
        Me.UsernameBunifuTextBox.ShortcutsEnabled = True
        Me.UsernameBunifuTextBox.Size = New System.Drawing.Size(300, 44)
        Me.UsernameBunifuTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.UsernameBunifuTextBox.TabIndex = 1
        Me.UsernameBunifuTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.UsernameBunifuTextBox.TextMarginBottom = 0
        Me.UsernameBunifuTextBox.TextMarginLeft = 3
        Me.UsernameBunifuTextBox.TextMarginTop = 1
        Me.UsernameBunifuTextBox.TextPlaceholder = "Enter text"
        Me.UsernameBunifuTextBox.UseSystemPasswordChar = False
        Me.UsernameBunifuTextBox.WordWrap = True
        '
        'UsernameBunifuLabel
        '
        Me.UsernameBunifuLabel.AllowParentOverrides = False
        Me.UsernameBunifuLabel.AutoEllipsis = False
        Me.UsernameBunifuLabel.AutoSize = False
        Me.UsernameBunifuLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.UsernameBunifuLabel.CursorType = System.Windows.Forms.Cursors.Default
        Me.UsernameBunifuLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameBunifuLabel.ForeColor = System.Drawing.Color.Transparent
        Me.UsernameBunifuLabel.Location = New System.Drawing.Point(30, 105)
        Me.UsernameBunifuLabel.Name = "UsernameBunifuLabel"
        Me.UsernameBunifuLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UsernameBunifuLabel.Size = New System.Drawing.Size(135, 25)
        Me.UsernameBunifuLabel.TabIndex = 0
        Me.UsernameBunifuLabel.Text = "Username:"
        Me.UsernameBunifuLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.UsernameBunifuLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'UserLoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(720, 360)
        Me.Controls.Add(Me.RightSideBunifuPanel)
        Me.Controls.Add(Me.LeftSideBunifuPanel)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "UserLoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserLoginForm"
        Me.LeftSideBunifuPanel.ResumeLayout(False)
        CType(Me.LogoBunifuPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RightSideBunifuPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LeftSideBunifuPanel As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents LogoBunifuPictureBox As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents RightSideBunifuPanel As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents PasswordBunifuTextBox As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents PasswordBunifuLabel As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents UsernameBunifuTextBox As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents UsernameBunifuLabel As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents SignInBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton2
    Friend WithEvents CancelBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton2
End Class
