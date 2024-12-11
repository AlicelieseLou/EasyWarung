<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingForm))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.DesktopBunifuPanel = New Bunifu.UI.WinForms.BunifuPanel()
        Me.SideBarBunifuPanel = New Bunifu.UI.WinForms.BunifuPanel()
        Me.DatabaseSettingBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.UserSettingBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuPanel1 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.SideBarBunifuPanel.SuspendLayout()
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
        Me.DesktopBunifuPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DesktopBunifuPanel.Location = New System.Drawing.Point(260, 0)
        Me.DesktopBunifuPanel.Name = "DesktopBunifuPanel"
        Me.DesktopBunifuPanel.ShowBorders = True
        Me.DesktopBunifuPanel.Size = New System.Drawing.Size(845, 724)
        Me.DesktopBunifuPanel.TabIndex = 1
        '
        'SideBarBunifuPanel
        '
        Me.SideBarBunifuPanel.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.SideBarBunifuPanel.BackgroundImage = CType(resources.GetObject("SideBarBunifuPanel.BackgroundImage"), System.Drawing.Image)
        Me.SideBarBunifuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SideBarBunifuPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.SideBarBunifuPanel.BorderRadius = 0
        Me.SideBarBunifuPanel.BorderThickness = 0
        Me.SideBarBunifuPanel.Controls.Add(Me.DatabaseSettingBunifuButton)
        Me.SideBarBunifuPanel.Controls.Add(Me.UserSettingBunifuButton)
        Me.SideBarBunifuPanel.Controls.Add(Me.BunifuPanel1)
        Me.SideBarBunifuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SideBarBunifuPanel.Location = New System.Drawing.Point(0, 0)
        Me.SideBarBunifuPanel.Name = "SideBarBunifuPanel"
        Me.SideBarBunifuPanel.ShowBorders = True
        Me.SideBarBunifuPanel.Size = New System.Drawing.Size(260, 724)
        Me.SideBarBunifuPanel.TabIndex = 0
        '
        'DatabaseSettingBunifuButton
        '
        Me.DatabaseSettingBunifuButton.AllowAnimations = True
        Me.DatabaseSettingBunifuButton.AllowMouseEffects = True
        Me.DatabaseSettingBunifuButton.AllowToggling = False
        Me.DatabaseSettingBunifuButton.AnimationSpeed = 200
        Me.DatabaseSettingBunifuButton.AutoGenerateColors = False
        Me.DatabaseSettingBunifuButton.AutoRoundBorders = False
        Me.DatabaseSettingBunifuButton.AutoSizeLeftIcon = True
        Me.DatabaseSettingBunifuButton.AutoSizeRightIcon = True
        Me.DatabaseSettingBunifuButton.BackColor = System.Drawing.Color.Transparent
        Me.DatabaseSettingBunifuButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.DatabaseSettingBunifuButton.BackgroundImage = CType(resources.GetObject("DatabaseSettingBunifuButton.BackgroundImage"), System.Drawing.Image)
        Me.DatabaseSettingBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.DatabaseSettingBunifuButton.ButtonText = "Database Configuration"
        Me.DatabaseSettingBunifuButton.ButtonTextMarginLeft = 0
        Me.DatabaseSettingBunifuButton.ColorContrastOnClick = 45
        Me.DatabaseSettingBunifuButton.ColorContrastOnHover = 45
        Me.DatabaseSettingBunifuButton.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.DatabaseSettingBunifuButton.CustomizableEdges = BorderEdges1
        Me.DatabaseSettingBunifuButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.DatabaseSettingBunifuButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DatabaseSettingBunifuButton.DisabledFillColor = System.Drawing.Color.Empty
        Me.DatabaseSettingBunifuButton.DisabledForecolor = System.Drawing.Color.Empty
        Me.DatabaseSettingBunifuButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.DatabaseSettingBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.DatabaseSettingBunifuButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatabaseSettingBunifuButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DatabaseSettingBunifuButton.IconLeft = Global.EasyWarung.My.Resources.Resources.database
        Me.DatabaseSettingBunifuButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DatabaseSettingBunifuButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.DatabaseSettingBunifuButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.DatabaseSettingBunifuButton.IconMarginLeft = 11
        Me.DatabaseSettingBunifuButton.IconPadding = 10
        Me.DatabaseSettingBunifuButton.IconRight = Global.EasyWarung.My.Resources.Resources.right
        Me.DatabaseSettingBunifuButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DatabaseSettingBunifuButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.DatabaseSettingBunifuButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.DatabaseSettingBunifuButton.IconSize = 25
        Me.DatabaseSettingBunifuButton.IdleBorderColor = System.Drawing.Color.Empty
        Me.DatabaseSettingBunifuButton.IdleBorderRadius = 0
        Me.DatabaseSettingBunifuButton.IdleBorderThickness = 0
        Me.DatabaseSettingBunifuButton.IdleFillColor = System.Drawing.Color.Empty
        Me.DatabaseSettingBunifuButton.IdleIconLeftImage = Global.EasyWarung.My.Resources.Resources.database
        Me.DatabaseSettingBunifuButton.IdleIconRightImage = Global.EasyWarung.My.Resources.Resources.right
        Me.DatabaseSettingBunifuButton.IndicateFocus = False
        Me.DatabaseSettingBunifuButton.Location = New System.Drawing.Point(0, 105)
        Me.DatabaseSettingBunifuButton.Name = "DatabaseSettingBunifuButton"
        Me.DatabaseSettingBunifuButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DatabaseSettingBunifuButton.OnDisabledState.BorderRadius = 1
        Me.DatabaseSettingBunifuButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.DatabaseSettingBunifuButton.OnDisabledState.BorderThickness = 1
        Me.DatabaseSettingBunifuButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.DatabaseSettingBunifuButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.DatabaseSettingBunifuButton.OnDisabledState.IconLeftImage = Nothing
        Me.DatabaseSettingBunifuButton.OnDisabledState.IconRightImage = Nothing
        Me.DatabaseSettingBunifuButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.DatabaseSettingBunifuButton.onHoverState.BorderRadius = 1
        Me.DatabaseSettingBunifuButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.DatabaseSettingBunifuButton.onHoverState.BorderThickness = 1
        Me.DatabaseSettingBunifuButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.DatabaseSettingBunifuButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.DatabaseSettingBunifuButton.onHoverState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.database_white
        Me.DatabaseSettingBunifuButton.onHoverState.IconRightImage = Global.EasyWarung.My.Resources.Resources.right_white
        Me.DatabaseSettingBunifuButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.DatabaseSettingBunifuButton.OnIdleState.BorderRadius = 1
        Me.DatabaseSettingBunifuButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.DatabaseSettingBunifuButton.OnIdleState.BorderThickness = 1
        Me.DatabaseSettingBunifuButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.DatabaseSettingBunifuButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DatabaseSettingBunifuButton.OnIdleState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.database
        Me.DatabaseSettingBunifuButton.OnIdleState.IconRightImage = Global.EasyWarung.My.Resources.Resources.right
        Me.DatabaseSettingBunifuButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.DatabaseSettingBunifuButton.OnPressedState.BorderRadius = 1
        Me.DatabaseSettingBunifuButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.DatabaseSettingBunifuButton.OnPressedState.BorderThickness = 1
        Me.DatabaseSettingBunifuButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.DatabaseSettingBunifuButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.DatabaseSettingBunifuButton.OnPressedState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.database_white
        Me.DatabaseSettingBunifuButton.OnPressedState.IconRightImage = Global.EasyWarung.My.Resources.Resources.right_white
        Me.DatabaseSettingBunifuButton.Size = New System.Drawing.Size(260, 45)
        Me.DatabaseSettingBunifuButton.TabIndex = 4
        Me.DatabaseSettingBunifuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DatabaseSettingBunifuButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DatabaseSettingBunifuButton.TextMarginLeft = 0
        Me.DatabaseSettingBunifuButton.TextPadding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.DatabaseSettingBunifuButton.UseDefaultRadiusAndThickness = True
        '
        'UserSettingBunifuButton
        '
        Me.UserSettingBunifuButton.AllowAnimations = True
        Me.UserSettingBunifuButton.AllowMouseEffects = True
        Me.UserSettingBunifuButton.AllowToggling = False
        Me.UserSettingBunifuButton.AnimationSpeed = 200
        Me.UserSettingBunifuButton.AutoGenerateColors = False
        Me.UserSettingBunifuButton.AutoRoundBorders = False
        Me.UserSettingBunifuButton.AutoSizeLeftIcon = True
        Me.UserSettingBunifuButton.AutoSizeRightIcon = True
        Me.UserSettingBunifuButton.BackColor = System.Drawing.Color.Transparent
        Me.UserSettingBunifuButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.UserSettingBunifuButton.BackgroundImage = CType(resources.GetObject("UserSettingBunifuButton.BackgroundImage"), System.Drawing.Image)
        Me.UserSettingBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.UserSettingBunifuButton.ButtonText = "User Profile"
        Me.UserSettingBunifuButton.ButtonTextMarginLeft = 0
        Me.UserSettingBunifuButton.ColorContrastOnClick = 45
        Me.UserSettingBunifuButton.ColorContrastOnHover = 45
        Me.UserSettingBunifuButton.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.UserSettingBunifuButton.CustomizableEdges = BorderEdges2
        Me.UserSettingBunifuButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.UserSettingBunifuButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.UserSettingBunifuButton.DisabledFillColor = System.Drawing.Color.Empty
        Me.UserSettingBunifuButton.DisabledForecolor = System.Drawing.Color.Empty
        Me.UserSettingBunifuButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.UserSettingBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.UserSettingBunifuButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserSettingBunifuButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.UserSettingBunifuButton.IconLeft = Global.EasyWarung.My.Resources.Resources.user_setting
        Me.UserSettingBunifuButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UserSettingBunifuButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.UserSettingBunifuButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.UserSettingBunifuButton.IconMarginLeft = 11
        Me.UserSettingBunifuButton.IconPadding = 10
        Me.UserSettingBunifuButton.IconRight = Global.EasyWarung.My.Resources.Resources.right
        Me.UserSettingBunifuButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UserSettingBunifuButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.UserSettingBunifuButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.UserSettingBunifuButton.IconSize = 25
        Me.UserSettingBunifuButton.IdleBorderColor = System.Drawing.Color.Empty
        Me.UserSettingBunifuButton.IdleBorderRadius = 0
        Me.UserSettingBunifuButton.IdleBorderThickness = 0
        Me.UserSettingBunifuButton.IdleFillColor = System.Drawing.Color.Empty
        Me.UserSettingBunifuButton.IdleIconLeftImage = Global.EasyWarung.My.Resources.Resources.user_setting
        Me.UserSettingBunifuButton.IdleIconRightImage = Global.EasyWarung.My.Resources.Resources.right
        Me.UserSettingBunifuButton.IndicateFocus = False
        Me.UserSettingBunifuButton.Location = New System.Drawing.Point(0, 60)
        Me.UserSettingBunifuButton.Name = "UserSettingBunifuButton"
        Me.UserSettingBunifuButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.UserSettingBunifuButton.OnDisabledState.BorderRadius = 1
        Me.UserSettingBunifuButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.UserSettingBunifuButton.OnDisabledState.BorderThickness = 1
        Me.UserSettingBunifuButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.UserSettingBunifuButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.UserSettingBunifuButton.OnDisabledState.IconLeftImage = Nothing
        Me.UserSettingBunifuButton.OnDisabledState.IconRightImage = Nothing
        Me.UserSettingBunifuButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.UserSettingBunifuButton.onHoverState.BorderRadius = 1
        Me.UserSettingBunifuButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.UserSettingBunifuButton.onHoverState.BorderThickness = 1
        Me.UserSettingBunifuButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.UserSettingBunifuButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.UserSettingBunifuButton.onHoverState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.user_setting_white
        Me.UserSettingBunifuButton.onHoverState.IconRightImage = Global.EasyWarung.My.Resources.Resources.right_white
        Me.UserSettingBunifuButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.UserSettingBunifuButton.OnIdleState.BorderRadius = 1
        Me.UserSettingBunifuButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.UserSettingBunifuButton.OnIdleState.BorderThickness = 1
        Me.UserSettingBunifuButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.UserSettingBunifuButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.UserSettingBunifuButton.OnIdleState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.user_setting
        Me.UserSettingBunifuButton.OnIdleState.IconRightImage = Global.EasyWarung.My.Resources.Resources.right
        Me.UserSettingBunifuButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.UserSettingBunifuButton.OnPressedState.BorderRadius = 1
        Me.UserSettingBunifuButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.UserSettingBunifuButton.OnPressedState.BorderThickness = 1
        Me.UserSettingBunifuButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.UserSettingBunifuButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.UserSettingBunifuButton.OnPressedState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.user_setting_white
        Me.UserSettingBunifuButton.OnPressedState.IconRightImage = Global.EasyWarung.My.Resources.Resources.right_white
        Me.UserSettingBunifuButton.Size = New System.Drawing.Size(260, 45)
        Me.UserSettingBunifuButton.TabIndex = 3
        Me.UserSettingBunifuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UserSettingBunifuButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.UserSettingBunifuButton.TextMarginLeft = 0
        Me.UserSettingBunifuButton.TextPadding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.UserSettingBunifuButton.UseDefaultRadiusAndThickness = True
        '
        'BunifuPanel1
        '
        Me.BunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BunifuPanel1.BackgroundImage = CType(resources.GetObject("BunifuPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BunifuPanel1.BorderRadius = 0
        Me.BunifuPanel1.BorderThickness = 0
        Me.BunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuPanel1.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuPanel1.Name = "BunifuPanel1"
        Me.BunifuPanel1.ShowBorders = True
        Me.BunifuPanel1.Size = New System.Drawing.Size(260, 60)
        Me.BunifuPanel1.TabIndex = 0
        '
        'SettingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1105, 724)
        Me.Controls.Add(Me.DesktopBunifuPanel)
        Me.Controls.Add(Me.SideBarBunifuPanel)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "SettingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SettingForm"
        Me.SideBarBunifuPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SideBarBunifuPanel As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents DesktopBunifuPanel As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents BunifuPanel1 As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents DatabaseSettingBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents UserSettingBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton
End Class
