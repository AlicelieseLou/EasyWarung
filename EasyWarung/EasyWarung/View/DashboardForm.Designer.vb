<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges5 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges6 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges7 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges8 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.BunifuSnackbar = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        Me.DesktopBunifuPanel = New Bunifu.UI.WinForms.BunifuPanel()
        Me.TitleBarBunifuPanel = New Bunifu.UI.WinForms.BunifuPanel()
        Me.BunifuFormControlBox = New Bunifu.UI.WinForms.BunifuFormControlBox()
        Me.MenuBunifuPanel = New Bunifu.UI.WinForms.BunifuPanel()
        Me.BottomBunifuSeparator = New Bunifu.UI.WinForms.BunifuSeparator()
        Me.SettingBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.LogoutBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.SignInBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.EmployeesBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.OrdersBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.ProductsBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.CategoriesBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.DashboardBunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.TopBunifuSeparator = New Bunifu.UI.WinForms.BunifuSeparator()
        Me.LogoBunifuPanel = New Bunifu.UI.WinForms.BunifuPanel()
        Me.LogoBunifuPictureBox = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TitleBarBunifuPanel.SuspendLayout()
        Me.MenuBunifuPanel.SuspendLayout()
        Me.LogoBunifuPanel.SuspendLayout()
        CType(Me.LogoBunifuPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuSnackbar
        '
        Me.BunifuSnackbar.AllowDragging = False
        Me.BunifuSnackbar.AllowMultipleViews = True
        Me.BunifuSnackbar.ClickToClose = True
        Me.BunifuSnackbar.DoubleClickToClose = True
        Me.BunifuSnackbar.DurationAfterIdle = 3000
        Me.BunifuSnackbar.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar.ErrorOptions.ActionBorderRadius = 1
        Me.BunifuSnackbar.ErrorOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuSnackbar.ErrorOptions.ActionForeColor = System.Drawing.Color.Black
        Me.BunifuSnackbar.ErrorOptions.BackColor = System.Drawing.Color.White
        Me.BunifuSnackbar.ErrorOptions.BorderColor = System.Drawing.Color.White
        Me.BunifuSnackbar.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BunifuSnackbar.ErrorOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BunifuSnackbar.ErrorOptions.ForeColor = System.Drawing.Color.Black
        Me.BunifuSnackbar.ErrorOptions.Icon = CType(resources.GetObject("resource.Icon"), System.Drawing.Image)
        Me.BunifuSnackbar.ErrorOptions.IconLeftMargin = 12
        Me.BunifuSnackbar.FadeCloseIcon = False
        Me.BunifuSnackbar.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner
        Me.BunifuSnackbar.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar.InformationOptions.ActionBorderRadius = 1
        Me.BunifuSnackbar.InformationOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuSnackbar.InformationOptions.ActionForeColor = System.Drawing.Color.Black
        Me.BunifuSnackbar.InformationOptions.BackColor = System.Drawing.Color.White
        Me.BunifuSnackbar.InformationOptions.BorderColor = System.Drawing.Color.White
        Me.BunifuSnackbar.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar.InformationOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BunifuSnackbar.InformationOptions.ForeColor = System.Drawing.Color.Black
        Me.BunifuSnackbar.InformationOptions.Icon = CType(resources.GetObject("resource.Icon1"), System.Drawing.Image)
        Me.BunifuSnackbar.InformationOptions.IconLeftMargin = 12
        Me.BunifuSnackbar.Margin = 10
        Me.BunifuSnackbar.MaximumSize = New System.Drawing.Size(0, 0)
        Me.BunifuSnackbar.MaximumViews = 7
        Me.BunifuSnackbar.MessageRightMargin = 15
        Me.BunifuSnackbar.MessageTopMargin = 0
        Me.BunifuSnackbar.MinimumSize = New System.Drawing.Size(0, 0)
        Me.BunifuSnackbar.ShowBorders = False
        Me.BunifuSnackbar.ShowCloseIcon = True
        Me.BunifuSnackbar.ShowIcon = True
        Me.BunifuSnackbar.ShowShadows = True
        Me.BunifuSnackbar.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar.SuccessOptions.ActionBorderRadius = 1
        Me.BunifuSnackbar.SuccessOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuSnackbar.SuccessOptions.ActionForeColor = System.Drawing.Color.Black
        Me.BunifuSnackbar.SuccessOptions.BackColor = System.Drawing.Color.White
        Me.BunifuSnackbar.SuccessOptions.BorderColor = System.Drawing.Color.White
        Me.BunifuSnackbar.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.BunifuSnackbar.SuccessOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BunifuSnackbar.SuccessOptions.ForeColor = System.Drawing.Color.Black
        Me.BunifuSnackbar.SuccessOptions.Icon = CType(resources.GetObject("resource.Icon2"), System.Drawing.Image)
        Me.BunifuSnackbar.SuccessOptions.IconLeftMargin = 12
        Me.BunifuSnackbar.ViewsMargin = 7
        Me.BunifuSnackbar.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar.WarningOptions.ActionBorderRadius = 1
        Me.BunifuSnackbar.WarningOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuSnackbar.WarningOptions.ActionForeColor = System.Drawing.Color.Black
        Me.BunifuSnackbar.WarningOptions.BackColor = System.Drawing.Color.White
        Me.BunifuSnackbar.WarningOptions.BorderColor = System.Drawing.Color.White
        Me.BunifuSnackbar.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BunifuSnackbar.WarningOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BunifuSnackbar.WarningOptions.ForeColor = System.Drawing.Color.Black
        Me.BunifuSnackbar.WarningOptions.Icon = CType(resources.GetObject("resource.Icon3"), System.Drawing.Image)
        Me.BunifuSnackbar.WarningOptions.IconLeftMargin = 12
        Me.BunifuSnackbar.ZoomCloseIcon = True
        '
        'DesktopBunifuPanel
        '
        Me.DesktopBunifuPanel.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.DesktopBunifuPanel.BackgroundImage = CType(resources.GetObject("DesktopBunifuPanel.BackgroundImage"), System.Drawing.Image)
        Me.DesktopBunifuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DesktopBunifuPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.DesktopBunifuPanel.BorderRadius = 3
        Me.DesktopBunifuPanel.BorderThickness = 1
        Me.DesktopBunifuPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DesktopBunifuPanel.Location = New System.Drawing.Point(260, 40)
        Me.DesktopBunifuPanel.Name = "DesktopBunifuPanel"
        Me.DesktopBunifuPanel.ShowBorders = True
        Me.DesktopBunifuPanel.Size = New System.Drawing.Size(1126, 748)
        Me.DesktopBunifuPanel.TabIndex = 2
        '
        'TitleBarBunifuPanel
        '
        Me.TitleBarBunifuPanel.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TitleBarBunifuPanel.BackgroundImage = CType(resources.GetObject("TitleBarBunifuPanel.BackgroundImage"), System.Drawing.Image)
        Me.TitleBarBunifuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TitleBarBunifuPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TitleBarBunifuPanel.BorderRadius = 3
        Me.TitleBarBunifuPanel.BorderThickness = 1
        Me.TitleBarBunifuPanel.Controls.Add(Me.BunifuFormControlBox)
        Me.TitleBarBunifuPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBarBunifuPanel.Location = New System.Drawing.Point(260, 0)
        Me.TitleBarBunifuPanel.Name = "TitleBarBunifuPanel"
        Me.TitleBarBunifuPanel.ShowBorders = True
        Me.TitleBarBunifuPanel.Size = New System.Drawing.Size(1126, 40)
        Me.TitleBarBunifuPanel.TabIndex = 1
        '
        'BunifuFormControlBox
        '
        Me.BunifuFormControlBox.BunifuFormDrag = Nothing
        Me.BunifuFormControlBox.CloseBoxOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BunifuFormControlBox.CloseBoxOptions.BorderRadius = 0
        Me.BunifuFormControlBox.CloseBoxOptions.Enabled = True
        Me.BunifuFormControlBox.CloseBoxOptions.EnableDefaultAction = True
        Me.BunifuFormControlBox.CloseBoxOptions.HoverColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuFormControlBox.CloseBoxOptions.Icon = CType(resources.GetObject("BunifuFormControlBox.CloseBoxOptions.Icon"), System.Drawing.Image)
        Me.BunifuFormControlBox.CloseBoxOptions.IconAlt = Nothing
        Me.BunifuFormControlBox.CloseBoxOptions.IconColor = System.Drawing.Color.White
        Me.BunifuFormControlBox.CloseBoxOptions.IconHoverColor = System.Drawing.Color.White
        Me.BunifuFormControlBox.CloseBoxOptions.IconPressedColor = System.Drawing.Color.White
        Me.BunifuFormControlBox.CloseBoxOptions.IconSize = New System.Drawing.Size(18, 18)
        Me.BunifuFormControlBox.CloseBoxOptions.PressedColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuFormControlBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFormControlBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.BunifuFormControlBox.HelpBox = False
        Me.BunifuFormControlBox.HelpBoxOptions.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFormControlBox.HelpBoxOptions.BorderRadius = 0
        Me.BunifuFormControlBox.HelpBoxOptions.Enabled = True
        Me.BunifuFormControlBox.HelpBoxOptions.EnableDefaultAction = True
        Me.BunifuFormControlBox.HelpBoxOptions.HoverColor = System.Drawing.Color.LightGray
        Me.BunifuFormControlBox.HelpBoxOptions.Icon = CType(resources.GetObject("BunifuFormControlBox.HelpBoxOptions.Icon"), System.Drawing.Image)
        Me.BunifuFormControlBox.HelpBoxOptions.IconAlt = Nothing
        Me.BunifuFormControlBox.HelpBoxOptions.IconColor = System.Drawing.Color.Black
        Me.BunifuFormControlBox.HelpBoxOptions.IconHoverColor = System.Drawing.Color.Black
        Me.BunifuFormControlBox.HelpBoxOptions.IconPressedColor = System.Drawing.Color.Black
        Me.BunifuFormControlBox.HelpBoxOptions.IconSize = New System.Drawing.Size(22, 22)
        Me.BunifuFormControlBox.HelpBoxOptions.PressedColor = System.Drawing.Color.Silver
        Me.BunifuFormControlBox.Location = New System.Drawing.Point(989, 0)
        Me.BunifuFormControlBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BunifuFormControlBox.MaximizeBox = False
        Me.BunifuFormControlBox.MaximizeBoxOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BunifuFormControlBox.MaximizeBoxOptions.BorderRadius = 0
        Me.BunifuFormControlBox.MaximizeBoxOptions.Enabled = True
        Me.BunifuFormControlBox.MaximizeBoxOptions.EnableDefaultAction = True
        Me.BunifuFormControlBox.MaximizeBoxOptions.HoverColor = System.Drawing.Color.LightGray
        Me.BunifuFormControlBox.MaximizeBoxOptions.Icon = CType(resources.GetObject("BunifuFormControlBox.MaximizeBoxOptions.Icon"), System.Drawing.Image)
        Me.BunifuFormControlBox.MaximizeBoxOptions.IconAlt = CType(resources.GetObject("BunifuFormControlBox.MaximizeBoxOptions.IconAlt"), System.Drawing.Image)
        Me.BunifuFormControlBox.MaximizeBoxOptions.IconColor = System.Drawing.Color.White
        Me.BunifuFormControlBox.MaximizeBoxOptions.IconHoverColor = System.Drawing.Color.White
        Me.BunifuFormControlBox.MaximizeBoxOptions.IconPressedColor = System.Drawing.Color.White
        Me.BunifuFormControlBox.MaximizeBoxOptions.IconSize = New System.Drawing.Size(16, 16)
        Me.BunifuFormControlBox.MaximizeBoxOptions.PressedColor = System.Drawing.Color.Silver
        Me.BunifuFormControlBox.MinimizeBox = True
        Me.BunifuFormControlBox.MinimizeBoxOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BunifuFormControlBox.MinimizeBoxOptions.BorderRadius = 0
        Me.BunifuFormControlBox.MinimizeBoxOptions.Enabled = True
        Me.BunifuFormControlBox.MinimizeBoxOptions.EnableDefaultAction = True
        Me.BunifuFormControlBox.MinimizeBoxOptions.HoverColor = System.Drawing.Color.LightGray
        Me.BunifuFormControlBox.MinimizeBoxOptions.Icon = CType(resources.GetObject("BunifuFormControlBox.MinimizeBoxOptions.Icon"), System.Drawing.Image)
        Me.BunifuFormControlBox.MinimizeBoxOptions.IconAlt = Nothing
        Me.BunifuFormControlBox.MinimizeBoxOptions.IconColor = System.Drawing.Color.White
        Me.BunifuFormControlBox.MinimizeBoxOptions.IconHoverColor = System.Drawing.Color.White
        Me.BunifuFormControlBox.MinimizeBoxOptions.IconPressedColor = System.Drawing.Color.White
        Me.BunifuFormControlBox.MinimizeBoxOptions.IconSize = New System.Drawing.Size(14, 14)
        Me.BunifuFormControlBox.MinimizeBoxOptions.PressedColor = System.Drawing.Color.Silver
        Me.BunifuFormControlBox.Name = "BunifuFormControlBox"
        Me.BunifuFormControlBox.ShowDesignBorders = False
        Me.BunifuFormControlBox.Size = New System.Drawing.Size(137, 40)
        Me.BunifuFormControlBox.TabIndex = 0
        '
        'MenuBunifuPanel
        '
        Me.MenuBunifuPanel.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.MenuBunifuPanel.BackgroundImage = CType(resources.GetObject("MenuBunifuPanel.BackgroundImage"), System.Drawing.Image)
        Me.MenuBunifuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuBunifuPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.MenuBunifuPanel.BorderRadius = 0
        Me.MenuBunifuPanel.BorderThickness = 0
        Me.MenuBunifuPanel.Controls.Add(Me.BottomBunifuSeparator)
        Me.MenuBunifuPanel.Controls.Add(Me.SettingBunifuButton)
        Me.MenuBunifuPanel.Controls.Add(Me.LogoutBunifuButton)
        Me.MenuBunifuPanel.Controls.Add(Me.SignInBunifuButton)
        Me.MenuBunifuPanel.Controls.Add(Me.EmployeesBunifuButton)
        Me.MenuBunifuPanel.Controls.Add(Me.OrdersBunifuButton)
        Me.MenuBunifuPanel.Controls.Add(Me.ProductsBunifuButton)
        Me.MenuBunifuPanel.Controls.Add(Me.CategoriesBunifuButton)
        Me.MenuBunifuPanel.Controls.Add(Me.DashboardBunifuButton)
        Me.MenuBunifuPanel.Controls.Add(Me.TopBunifuSeparator)
        Me.MenuBunifuPanel.Controls.Add(Me.LogoBunifuPanel)
        Me.MenuBunifuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuBunifuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuBunifuPanel.Name = "MenuBunifuPanel"
        Me.MenuBunifuPanel.ShowBorders = True
        Me.MenuBunifuPanel.Size = New System.Drawing.Size(260, 788)
        Me.MenuBunifuPanel.TabIndex = 0
        '
        'BottomBunifuSeparator
        '
        Me.BottomBunifuSeparator.BackColor = System.Drawing.Color.Transparent
        Me.BottomBunifuSeparator.BackgroundImage = CType(resources.GetObject("BottomBunifuSeparator.BackgroundImage"), System.Drawing.Image)
        Me.BottomBunifuSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BottomBunifuSeparator.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat
        Me.BottomBunifuSeparator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomBunifuSeparator.LineColor = System.Drawing.Color.Silver
        Me.BottomBunifuSeparator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid
        Me.BottomBunifuSeparator.LineThickness = 1
        Me.BottomBunifuSeparator.Location = New System.Drawing.Point(0, 639)
        Me.BottomBunifuSeparator.Name = "BottomBunifuSeparator"
        Me.BottomBunifuSeparator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal
        Me.BottomBunifuSeparator.Size = New System.Drawing.Size(260, 14)
        Me.BottomBunifuSeparator.TabIndex = 9
        '
        'SettingBunifuButton
        '
        Me.SettingBunifuButton.AllowAnimations = True
        Me.SettingBunifuButton.AllowMouseEffects = True
        Me.SettingBunifuButton.AllowToggling = False
        Me.SettingBunifuButton.AnimationSpeed = 200
        Me.SettingBunifuButton.AutoGenerateColors = False
        Me.SettingBunifuButton.AutoRoundBorders = False
        Me.SettingBunifuButton.AutoSizeLeftIcon = True
        Me.SettingBunifuButton.AutoSizeRightIcon = True
        Me.SettingBunifuButton.BackColor = System.Drawing.Color.Transparent
        Me.SettingBunifuButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.SettingBunifuButton.BackgroundImage = CType(resources.GetObject("SettingBunifuButton.BackgroundImage"), System.Drawing.Image)
        Me.SettingBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.SettingBunifuButton.ButtonText = "Setting"
        Me.SettingBunifuButton.ButtonTextMarginLeft = 0
        Me.SettingBunifuButton.ColorContrastOnClick = 45
        Me.SettingBunifuButton.ColorContrastOnHover = 45
        Me.SettingBunifuButton.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.SettingBunifuButton.CustomizableEdges = BorderEdges1
        Me.SettingBunifuButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SettingBunifuButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.SettingBunifuButton.DisabledFillColor = System.Drawing.Color.Empty
        Me.SettingBunifuButton.DisabledForecolor = System.Drawing.Color.Empty
        Me.SettingBunifuButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SettingBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.SettingBunifuButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingBunifuButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.SettingBunifuButton.IconLeft = Global.EasyWarung.My.Resources.Resources.setting
        Me.SettingBunifuButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SettingBunifuButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.SettingBunifuButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.SettingBunifuButton.IconMarginLeft = 11
        Me.SettingBunifuButton.IconPadding = 10
        Me.SettingBunifuButton.IconRight = Nothing
        Me.SettingBunifuButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SettingBunifuButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.SettingBunifuButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.SettingBunifuButton.IconSize = 25
        Me.SettingBunifuButton.IdleBorderColor = System.Drawing.Color.Empty
        Me.SettingBunifuButton.IdleBorderRadius = 0
        Me.SettingBunifuButton.IdleBorderThickness = 0
        Me.SettingBunifuButton.IdleFillColor = System.Drawing.Color.Empty
        Me.SettingBunifuButton.IdleIconLeftImage = Global.EasyWarung.My.Resources.Resources.setting
        Me.SettingBunifuButton.IdleIconRightImage = Nothing
        Me.SettingBunifuButton.IndicateFocus = False
        Me.SettingBunifuButton.Location = New System.Drawing.Point(0, 653)
        Me.SettingBunifuButton.Name = "SettingBunifuButton"
        Me.SettingBunifuButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.SettingBunifuButton.OnDisabledState.BorderRadius = 1
        Me.SettingBunifuButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.SettingBunifuButton.OnDisabledState.BorderThickness = 1
        Me.SettingBunifuButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SettingBunifuButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.SettingBunifuButton.OnDisabledState.IconLeftImage = Nothing
        Me.SettingBunifuButton.OnDisabledState.IconRightImage = Nothing
        Me.SettingBunifuButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.SettingBunifuButton.onHoverState.BorderRadius = 1
        Me.SettingBunifuButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.SettingBunifuButton.onHoverState.BorderThickness = 1
        Me.SettingBunifuButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.SettingBunifuButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.SettingBunifuButton.onHoverState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.setting_white
        Me.SettingBunifuButton.onHoverState.IconRightImage = Nothing
        Me.SettingBunifuButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.SettingBunifuButton.OnIdleState.BorderRadius = 1
        Me.SettingBunifuButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.SettingBunifuButton.OnIdleState.BorderThickness = 1
        Me.SettingBunifuButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.SettingBunifuButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.SettingBunifuButton.OnIdleState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.setting
        Me.SettingBunifuButton.OnIdleState.IconRightImage = Nothing
        Me.SettingBunifuButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.SettingBunifuButton.OnPressedState.BorderRadius = 1
        Me.SettingBunifuButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.SettingBunifuButton.OnPressedState.BorderThickness = 1
        Me.SettingBunifuButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.SettingBunifuButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.SettingBunifuButton.OnPressedState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.setting_white
        Me.SettingBunifuButton.OnPressedState.IconRightImage = Nothing
        Me.SettingBunifuButton.Size = New System.Drawing.Size(260, 45)
        Me.SettingBunifuButton.TabIndex = 8
        Me.SettingBunifuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SettingBunifuButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.SettingBunifuButton.TextMarginLeft = 0
        Me.SettingBunifuButton.TextPadding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.SettingBunifuButton.UseDefaultRadiusAndThickness = True
        '
        'LogoutBunifuButton
        '
        Me.LogoutBunifuButton.AllowAnimations = True
        Me.LogoutBunifuButton.AllowMouseEffects = True
        Me.LogoutBunifuButton.AllowToggling = False
        Me.LogoutBunifuButton.AnimationSpeed = 200
        Me.LogoutBunifuButton.AutoGenerateColors = False
        Me.LogoutBunifuButton.AutoRoundBorders = False
        Me.LogoutBunifuButton.AutoSizeLeftIcon = True
        Me.LogoutBunifuButton.AutoSizeRightIcon = True
        Me.LogoutBunifuButton.BackColor = System.Drawing.Color.Transparent
        Me.LogoutBunifuButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.LogoutBunifuButton.BackgroundImage = CType(resources.GetObject("LogoutBunifuButton.BackgroundImage"), System.Drawing.Image)
        Me.LogoutBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.LogoutBunifuButton.ButtonText = "Logout"
        Me.LogoutBunifuButton.ButtonTextMarginLeft = 0
        Me.LogoutBunifuButton.ColorContrastOnClick = 45
        Me.LogoutBunifuButton.ColorContrastOnHover = 45
        Me.LogoutBunifuButton.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.LogoutBunifuButton.CustomizableEdges = BorderEdges2
        Me.LogoutBunifuButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LogoutBunifuButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.LogoutBunifuButton.DisabledFillColor = System.Drawing.Color.Empty
        Me.LogoutBunifuButton.DisabledForecolor = System.Drawing.Color.Empty
        Me.LogoutBunifuButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LogoutBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.LogoutBunifuButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutBunifuButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.LogoutBunifuButton.IconLeft = Global.EasyWarung.My.Resources.Resources.logout
        Me.LogoutBunifuButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutBunifuButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.LogoutBunifuButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.LogoutBunifuButton.IconMarginLeft = 11
        Me.LogoutBunifuButton.IconPadding = 10
        Me.LogoutBunifuButton.IconRight = Nothing
        Me.LogoutBunifuButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LogoutBunifuButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.LogoutBunifuButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.LogoutBunifuButton.IconSize = 25
        Me.LogoutBunifuButton.IdleBorderColor = System.Drawing.Color.Empty
        Me.LogoutBunifuButton.IdleBorderRadius = 0
        Me.LogoutBunifuButton.IdleBorderThickness = 0
        Me.LogoutBunifuButton.IdleFillColor = System.Drawing.Color.Empty
        Me.LogoutBunifuButton.IdleIconLeftImage = Global.EasyWarung.My.Resources.Resources.logout
        Me.LogoutBunifuButton.IdleIconRightImage = Nothing
        Me.LogoutBunifuButton.IndicateFocus = False
        Me.LogoutBunifuButton.Location = New System.Drawing.Point(0, 698)
        Me.LogoutBunifuButton.Name = "LogoutBunifuButton"
        Me.LogoutBunifuButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.LogoutBunifuButton.OnDisabledState.BorderRadius = 1
        Me.LogoutBunifuButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.LogoutBunifuButton.OnDisabledState.BorderThickness = 1
        Me.LogoutBunifuButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.LogoutBunifuButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.LogoutBunifuButton.OnDisabledState.IconLeftImage = Nothing
        Me.LogoutBunifuButton.OnDisabledState.IconRightImage = Nothing
        Me.LogoutBunifuButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LogoutBunifuButton.onHoverState.BorderRadius = 1
        Me.LogoutBunifuButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.LogoutBunifuButton.onHoverState.BorderThickness = 1
        Me.LogoutBunifuButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LogoutBunifuButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.LogoutBunifuButton.onHoverState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.logout_white
        Me.LogoutBunifuButton.onHoverState.IconRightImage = Nothing
        Me.LogoutBunifuButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LogoutBunifuButton.OnIdleState.BorderRadius = 1
        Me.LogoutBunifuButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.LogoutBunifuButton.OnIdleState.BorderThickness = 1
        Me.LogoutBunifuButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LogoutBunifuButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.LogoutBunifuButton.OnIdleState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.logout
        Me.LogoutBunifuButton.OnIdleState.IconRightImage = Nothing
        Me.LogoutBunifuButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LogoutBunifuButton.OnPressedState.BorderRadius = 1
        Me.LogoutBunifuButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.LogoutBunifuButton.OnPressedState.BorderThickness = 1
        Me.LogoutBunifuButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LogoutBunifuButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.LogoutBunifuButton.OnPressedState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.logout_white
        Me.LogoutBunifuButton.OnPressedState.IconRightImage = Nothing
        Me.LogoutBunifuButton.Size = New System.Drawing.Size(260, 45)
        Me.LogoutBunifuButton.TabIndex = 7
        Me.LogoutBunifuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutBunifuButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.LogoutBunifuButton.TextMarginLeft = 0
        Me.LogoutBunifuButton.TextPadding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.LogoutBunifuButton.UseDefaultRadiusAndThickness = True
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
        Me.SignInBunifuButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.SignInBunifuButton.BackgroundImage = CType(resources.GetObject("SignInBunifuButton.BackgroundImage"), System.Drawing.Image)
        Me.SignInBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.SignInBunifuButton.ButtonText = "Sign In"
        Me.SignInBunifuButton.ButtonTextMarginLeft = 0
        Me.SignInBunifuButton.ColorContrastOnClick = 45
        Me.SignInBunifuButton.ColorContrastOnHover = 45
        Me.SignInBunifuButton.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges3.BottomLeft = True
        BorderEdges3.BottomRight = True
        BorderEdges3.TopLeft = True
        BorderEdges3.TopRight = True
        Me.SignInBunifuButton.CustomizableEdges = BorderEdges3
        Me.SignInBunifuButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SignInBunifuButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.SignInBunifuButton.DisabledFillColor = System.Drawing.Color.Empty
        Me.SignInBunifuButton.DisabledForecolor = System.Drawing.Color.Empty
        Me.SignInBunifuButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SignInBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.SignInBunifuButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignInBunifuButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.SignInBunifuButton.IconLeft = Global.EasyWarung.My.Resources.Resources.sign_in
        Me.SignInBunifuButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SignInBunifuButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.SignInBunifuButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.SignInBunifuButton.IconMarginLeft = 11
        Me.SignInBunifuButton.IconPadding = 10
        Me.SignInBunifuButton.IconRight = Nothing
        Me.SignInBunifuButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SignInBunifuButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.SignInBunifuButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.SignInBunifuButton.IconSize = 25
        Me.SignInBunifuButton.IdleBorderColor = System.Drawing.Color.Empty
        Me.SignInBunifuButton.IdleBorderRadius = 0
        Me.SignInBunifuButton.IdleBorderThickness = 0
        Me.SignInBunifuButton.IdleFillColor = System.Drawing.Color.Empty
        Me.SignInBunifuButton.IdleIconLeftImage = Global.EasyWarung.My.Resources.Resources.sign_in
        Me.SignInBunifuButton.IdleIconRightImage = Nothing
        Me.SignInBunifuButton.IndicateFocus = False
        Me.SignInBunifuButton.Location = New System.Drawing.Point(0, 743)
        Me.SignInBunifuButton.Name = "SignInBunifuButton"
        Me.SignInBunifuButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.SignInBunifuButton.OnDisabledState.BorderRadius = 1
        Me.SignInBunifuButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.SignInBunifuButton.OnDisabledState.BorderThickness = 1
        Me.SignInBunifuButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SignInBunifuButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.SignInBunifuButton.OnDisabledState.IconLeftImage = Nothing
        Me.SignInBunifuButton.OnDisabledState.IconRightImage = Nothing
        Me.SignInBunifuButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SignInBunifuButton.onHoverState.BorderRadius = 1
        Me.SignInBunifuButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.SignInBunifuButton.onHoverState.BorderThickness = 1
        Me.SignInBunifuButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SignInBunifuButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.SignInBunifuButton.onHoverState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.sign_in_white
        Me.SignInBunifuButton.onHoverState.IconRightImage = Nothing
        Me.SignInBunifuButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.SignInBunifuButton.OnIdleState.BorderRadius = 1
        Me.SignInBunifuButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.SignInBunifuButton.OnIdleState.BorderThickness = 1
        Me.SignInBunifuButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.SignInBunifuButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.SignInBunifuButton.OnIdleState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.sign_in
        Me.SignInBunifuButton.OnIdleState.IconRightImage = Nothing
        Me.SignInBunifuButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.SignInBunifuButton.OnPressedState.BorderRadius = 1
        Me.SignInBunifuButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.SignInBunifuButton.OnPressedState.BorderThickness = 1
        Me.SignInBunifuButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.SignInBunifuButton.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.SignInBunifuButton.OnPressedState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.sign_in
        Me.SignInBunifuButton.OnPressedState.IconRightImage = Nothing
        Me.SignInBunifuButton.Size = New System.Drawing.Size(260, 45)
        Me.SignInBunifuButton.TabIndex = 10
        Me.SignInBunifuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SignInBunifuButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.SignInBunifuButton.TextMarginLeft = 0
        Me.SignInBunifuButton.TextPadding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.SignInBunifuButton.UseDefaultRadiusAndThickness = True
        '
        'EmployeesBunifuButton
        '
        Me.EmployeesBunifuButton.AllowAnimations = True
        Me.EmployeesBunifuButton.AllowMouseEffects = True
        Me.EmployeesBunifuButton.AllowToggling = False
        Me.EmployeesBunifuButton.AnimationSpeed = 200
        Me.EmployeesBunifuButton.AutoGenerateColors = False
        Me.EmployeesBunifuButton.AutoRoundBorders = False
        Me.EmployeesBunifuButton.AutoSizeLeftIcon = True
        Me.EmployeesBunifuButton.AutoSizeRightIcon = True
        Me.EmployeesBunifuButton.BackColor = System.Drawing.Color.Transparent
        Me.EmployeesBunifuButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.EmployeesBunifuButton.BackgroundImage = CType(resources.GetObject("EmployeesBunifuButton.BackgroundImage"), System.Drawing.Image)
        Me.EmployeesBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.EmployeesBunifuButton.ButtonText = "Employees"
        Me.EmployeesBunifuButton.ButtonTextMarginLeft = 0
        Me.EmployeesBunifuButton.ColorContrastOnClick = 45
        Me.EmployeesBunifuButton.ColorContrastOnHover = 45
        Me.EmployeesBunifuButton.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges4.BottomLeft = True
        BorderEdges4.BottomRight = True
        BorderEdges4.TopLeft = True
        BorderEdges4.TopRight = True
        Me.EmployeesBunifuButton.CustomizableEdges = BorderEdges4
        Me.EmployeesBunifuButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.EmployeesBunifuButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.EmployeesBunifuButton.DisabledFillColor = System.Drawing.Color.Empty
        Me.EmployeesBunifuButton.DisabledForecolor = System.Drawing.Color.Empty
        Me.EmployeesBunifuButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.EmployeesBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.EmployeesBunifuButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeesBunifuButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.EmployeesBunifuButton.IconLeft = Global.EasyWarung.My.Resources.Resources.employees
        Me.EmployeesBunifuButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmployeesBunifuButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.EmployeesBunifuButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.EmployeesBunifuButton.IconMarginLeft = 11
        Me.EmployeesBunifuButton.IconPadding = 10
        Me.EmployeesBunifuButton.IconRight = Nothing
        Me.EmployeesBunifuButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EmployeesBunifuButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.EmployeesBunifuButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.EmployeesBunifuButton.IconSize = 25
        Me.EmployeesBunifuButton.IdleBorderColor = System.Drawing.Color.Empty
        Me.EmployeesBunifuButton.IdleBorderRadius = 0
        Me.EmployeesBunifuButton.IdleBorderThickness = 0
        Me.EmployeesBunifuButton.IdleFillColor = System.Drawing.Color.Empty
        Me.EmployeesBunifuButton.IdleIconLeftImage = Global.EasyWarung.My.Resources.Resources.employees
        Me.EmployeesBunifuButton.IdleIconRightImage = Nothing
        Me.EmployeesBunifuButton.IndicateFocus = False
        Me.EmployeesBunifuButton.Location = New System.Drawing.Point(0, 335)
        Me.EmployeesBunifuButton.Name = "EmployeesBunifuButton"
        Me.EmployeesBunifuButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.EmployeesBunifuButton.OnDisabledState.BorderRadius = 1
        Me.EmployeesBunifuButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.EmployeesBunifuButton.OnDisabledState.BorderThickness = 1
        Me.EmployeesBunifuButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.EmployeesBunifuButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.EmployeesBunifuButton.OnDisabledState.IconLeftImage = Nothing
        Me.EmployeesBunifuButton.OnDisabledState.IconRightImage = Nothing
        Me.EmployeesBunifuButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.EmployeesBunifuButton.onHoverState.BorderRadius = 1
        Me.EmployeesBunifuButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.EmployeesBunifuButton.onHoverState.BorderThickness = 1
        Me.EmployeesBunifuButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.EmployeesBunifuButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.EmployeesBunifuButton.onHoverState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.employees_white
        Me.EmployeesBunifuButton.onHoverState.IconRightImage = Nothing
        Me.EmployeesBunifuButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.EmployeesBunifuButton.OnIdleState.BorderRadius = 1
        Me.EmployeesBunifuButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.EmployeesBunifuButton.OnIdleState.BorderThickness = 1
        Me.EmployeesBunifuButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.EmployeesBunifuButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.EmployeesBunifuButton.OnIdleState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.employees
        Me.EmployeesBunifuButton.OnIdleState.IconRightImage = Nothing
        Me.EmployeesBunifuButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.EmployeesBunifuButton.OnPressedState.BorderRadius = 1
        Me.EmployeesBunifuButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.EmployeesBunifuButton.OnPressedState.BorderThickness = 1
        Me.EmployeesBunifuButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.EmployeesBunifuButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.EmployeesBunifuButton.OnPressedState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.employees_white
        Me.EmployeesBunifuButton.OnPressedState.IconRightImage = Nothing
        Me.EmployeesBunifuButton.Size = New System.Drawing.Size(260, 45)
        Me.EmployeesBunifuButton.TabIndex = 6
        Me.EmployeesBunifuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmployeesBunifuButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.EmployeesBunifuButton.TextMarginLeft = 0
        Me.EmployeesBunifuButton.TextPadding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.EmployeesBunifuButton.UseDefaultRadiusAndThickness = True
        '
        'OrdersBunifuButton
        '
        Me.OrdersBunifuButton.AllowAnimations = True
        Me.OrdersBunifuButton.AllowMouseEffects = True
        Me.OrdersBunifuButton.AllowToggling = False
        Me.OrdersBunifuButton.AnimationSpeed = 200
        Me.OrdersBunifuButton.AutoGenerateColors = False
        Me.OrdersBunifuButton.AutoRoundBorders = False
        Me.OrdersBunifuButton.AutoSizeLeftIcon = True
        Me.OrdersBunifuButton.AutoSizeRightIcon = True
        Me.OrdersBunifuButton.BackColor = System.Drawing.Color.Transparent
        Me.OrdersBunifuButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.OrdersBunifuButton.BackgroundImage = CType(resources.GetObject("OrdersBunifuButton.BackgroundImage"), System.Drawing.Image)
        Me.OrdersBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.OrdersBunifuButton.ButtonText = "Orders"
        Me.OrdersBunifuButton.ButtonTextMarginLeft = 0
        Me.OrdersBunifuButton.ColorContrastOnClick = 45
        Me.OrdersBunifuButton.ColorContrastOnHover = 45
        Me.OrdersBunifuButton.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges5.BottomLeft = True
        BorderEdges5.BottomRight = True
        BorderEdges5.TopLeft = True
        BorderEdges5.TopRight = True
        Me.OrdersBunifuButton.CustomizableEdges = BorderEdges5
        Me.OrdersBunifuButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.OrdersBunifuButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.OrdersBunifuButton.DisabledFillColor = System.Drawing.Color.Empty
        Me.OrdersBunifuButton.DisabledForecolor = System.Drawing.Color.Empty
        Me.OrdersBunifuButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.OrdersBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.OrdersBunifuButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrdersBunifuButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.OrdersBunifuButton.IconLeft = Global.EasyWarung.My.Resources.Resources.orders
        Me.OrdersBunifuButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OrdersBunifuButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.OrdersBunifuButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.OrdersBunifuButton.IconMarginLeft = 11
        Me.OrdersBunifuButton.IconPadding = 10
        Me.OrdersBunifuButton.IconRight = Nothing
        Me.OrdersBunifuButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OrdersBunifuButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.OrdersBunifuButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.OrdersBunifuButton.IconSize = 25
        Me.OrdersBunifuButton.IdleBorderColor = System.Drawing.Color.Empty
        Me.OrdersBunifuButton.IdleBorderRadius = 0
        Me.OrdersBunifuButton.IdleBorderThickness = 0
        Me.OrdersBunifuButton.IdleFillColor = System.Drawing.Color.Empty
        Me.OrdersBunifuButton.IdleIconLeftImage = Global.EasyWarung.My.Resources.Resources.orders
        Me.OrdersBunifuButton.IdleIconRightImage = Nothing
        Me.OrdersBunifuButton.IndicateFocus = False
        Me.OrdersBunifuButton.Location = New System.Drawing.Point(0, 290)
        Me.OrdersBunifuButton.Name = "OrdersBunifuButton"
        Me.OrdersBunifuButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.OrdersBunifuButton.OnDisabledState.BorderRadius = 1
        Me.OrdersBunifuButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.OrdersBunifuButton.OnDisabledState.BorderThickness = 1
        Me.OrdersBunifuButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.OrdersBunifuButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.OrdersBunifuButton.OnDisabledState.IconLeftImage = Nothing
        Me.OrdersBunifuButton.OnDisabledState.IconRightImage = Nothing
        Me.OrdersBunifuButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.OrdersBunifuButton.onHoverState.BorderRadius = 1
        Me.OrdersBunifuButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.OrdersBunifuButton.onHoverState.BorderThickness = 1
        Me.OrdersBunifuButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.OrdersBunifuButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.OrdersBunifuButton.onHoverState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.orders_white
        Me.OrdersBunifuButton.onHoverState.IconRightImage = Nothing
        Me.OrdersBunifuButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.OrdersBunifuButton.OnIdleState.BorderRadius = 1
        Me.OrdersBunifuButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.OrdersBunifuButton.OnIdleState.BorderThickness = 1
        Me.OrdersBunifuButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.OrdersBunifuButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.OrdersBunifuButton.OnIdleState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.orders
        Me.OrdersBunifuButton.OnIdleState.IconRightImage = Nothing
        Me.OrdersBunifuButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.OrdersBunifuButton.OnPressedState.BorderRadius = 1
        Me.OrdersBunifuButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.OrdersBunifuButton.OnPressedState.BorderThickness = 1
        Me.OrdersBunifuButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.OrdersBunifuButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.OrdersBunifuButton.OnPressedState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.orders_white
        Me.OrdersBunifuButton.OnPressedState.IconRightImage = Nothing
        Me.OrdersBunifuButton.Size = New System.Drawing.Size(260, 45)
        Me.OrdersBunifuButton.TabIndex = 5
        Me.OrdersBunifuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OrdersBunifuButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.OrdersBunifuButton.TextMarginLeft = 0
        Me.OrdersBunifuButton.TextPadding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.OrdersBunifuButton.UseDefaultRadiusAndThickness = True
        '
        'ProductsBunifuButton
        '
        Me.ProductsBunifuButton.AllowAnimations = True
        Me.ProductsBunifuButton.AllowMouseEffects = True
        Me.ProductsBunifuButton.AllowToggling = False
        Me.ProductsBunifuButton.AnimationSpeed = 200
        Me.ProductsBunifuButton.AutoGenerateColors = False
        Me.ProductsBunifuButton.AutoRoundBorders = False
        Me.ProductsBunifuButton.AutoSizeLeftIcon = True
        Me.ProductsBunifuButton.AutoSizeRightIcon = True
        Me.ProductsBunifuButton.BackColor = System.Drawing.Color.Transparent
        Me.ProductsBunifuButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.ProductsBunifuButton.BackgroundImage = CType(resources.GetObject("ProductsBunifuButton.BackgroundImage"), System.Drawing.Image)
        Me.ProductsBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.ProductsBunifuButton.ButtonText = "Products"
        Me.ProductsBunifuButton.ButtonTextMarginLeft = 0
        Me.ProductsBunifuButton.ColorContrastOnClick = 45
        Me.ProductsBunifuButton.ColorContrastOnHover = 45
        Me.ProductsBunifuButton.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges6.BottomLeft = True
        BorderEdges6.BottomRight = True
        BorderEdges6.TopLeft = True
        BorderEdges6.TopRight = True
        Me.ProductsBunifuButton.CustomizableEdges = BorderEdges6
        Me.ProductsBunifuButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.ProductsBunifuButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ProductsBunifuButton.DisabledFillColor = System.Drawing.Color.Empty
        Me.ProductsBunifuButton.DisabledForecolor = System.Drawing.Color.Empty
        Me.ProductsBunifuButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProductsBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.ProductsBunifuButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductsBunifuButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.ProductsBunifuButton.IconLeft = Global.EasyWarung.My.Resources.Resources.products
        Me.ProductsBunifuButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProductsBunifuButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.ProductsBunifuButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.ProductsBunifuButton.IconMarginLeft = 11
        Me.ProductsBunifuButton.IconPadding = 10
        Me.ProductsBunifuButton.IconRight = Nothing
        Me.ProductsBunifuButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ProductsBunifuButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.ProductsBunifuButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.ProductsBunifuButton.IconSize = 25
        Me.ProductsBunifuButton.IdleBorderColor = System.Drawing.Color.Empty
        Me.ProductsBunifuButton.IdleBorderRadius = 0
        Me.ProductsBunifuButton.IdleBorderThickness = 0
        Me.ProductsBunifuButton.IdleFillColor = System.Drawing.Color.Empty
        Me.ProductsBunifuButton.IdleIconLeftImage = Global.EasyWarung.My.Resources.Resources.products
        Me.ProductsBunifuButton.IdleIconRightImage = Nothing
        Me.ProductsBunifuButton.IndicateFocus = False
        Me.ProductsBunifuButton.Location = New System.Drawing.Point(0, 245)
        Me.ProductsBunifuButton.Name = "ProductsBunifuButton"
        Me.ProductsBunifuButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ProductsBunifuButton.OnDisabledState.BorderRadius = 1
        Me.ProductsBunifuButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.ProductsBunifuButton.OnDisabledState.BorderThickness = 1
        Me.ProductsBunifuButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ProductsBunifuButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.ProductsBunifuButton.OnDisabledState.IconLeftImage = Nothing
        Me.ProductsBunifuButton.OnDisabledState.IconRightImage = Nothing
        Me.ProductsBunifuButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ProductsBunifuButton.onHoverState.BorderRadius = 1
        Me.ProductsBunifuButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.ProductsBunifuButton.onHoverState.BorderThickness = 1
        Me.ProductsBunifuButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ProductsBunifuButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.ProductsBunifuButton.onHoverState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.products_white
        Me.ProductsBunifuButton.onHoverState.IconRightImage = Nothing
        Me.ProductsBunifuButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ProductsBunifuButton.OnIdleState.BorderRadius = 1
        Me.ProductsBunifuButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.ProductsBunifuButton.OnIdleState.BorderThickness = 1
        Me.ProductsBunifuButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ProductsBunifuButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.ProductsBunifuButton.OnIdleState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.products
        Me.ProductsBunifuButton.OnIdleState.IconRightImage = Nothing
        Me.ProductsBunifuButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ProductsBunifuButton.OnPressedState.BorderRadius = 1
        Me.ProductsBunifuButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.ProductsBunifuButton.OnPressedState.BorderThickness = 1
        Me.ProductsBunifuButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ProductsBunifuButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.ProductsBunifuButton.OnPressedState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.products_white
        Me.ProductsBunifuButton.OnPressedState.IconRightImage = Nothing
        Me.ProductsBunifuButton.Size = New System.Drawing.Size(260, 45)
        Me.ProductsBunifuButton.TabIndex = 4
        Me.ProductsBunifuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProductsBunifuButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.ProductsBunifuButton.TextMarginLeft = 0
        Me.ProductsBunifuButton.TextPadding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.ProductsBunifuButton.UseDefaultRadiusAndThickness = True
        '
        'CategoriesBunifuButton
        '
        Me.CategoriesBunifuButton.AllowAnimations = True
        Me.CategoriesBunifuButton.AllowMouseEffects = True
        Me.CategoriesBunifuButton.AllowToggling = False
        Me.CategoriesBunifuButton.AnimationSpeed = 200
        Me.CategoriesBunifuButton.AutoGenerateColors = False
        Me.CategoriesBunifuButton.AutoRoundBorders = False
        Me.CategoriesBunifuButton.AutoSizeLeftIcon = True
        Me.CategoriesBunifuButton.AutoSizeRightIcon = True
        Me.CategoriesBunifuButton.BackColor = System.Drawing.Color.Transparent
        Me.CategoriesBunifuButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.CategoriesBunifuButton.BackgroundImage = CType(resources.GetObject("CategoriesBunifuButton.BackgroundImage"), System.Drawing.Image)
        Me.CategoriesBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.CategoriesBunifuButton.ButtonText = "Categories"
        Me.CategoriesBunifuButton.ButtonTextMarginLeft = 0
        Me.CategoriesBunifuButton.ColorContrastOnClick = 45
        Me.CategoriesBunifuButton.ColorContrastOnHover = 45
        Me.CategoriesBunifuButton.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges7.BottomLeft = True
        BorderEdges7.BottomRight = True
        BorderEdges7.TopLeft = True
        BorderEdges7.TopRight = True
        Me.CategoriesBunifuButton.CustomizableEdges = BorderEdges7
        Me.CategoriesBunifuButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.CategoriesBunifuButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.CategoriesBunifuButton.DisabledFillColor = System.Drawing.Color.Empty
        Me.CategoriesBunifuButton.DisabledForecolor = System.Drawing.Color.Empty
        Me.CategoriesBunifuButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.CategoriesBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.CategoriesBunifuButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoriesBunifuButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.CategoriesBunifuButton.IconLeft = Global.EasyWarung.My.Resources.Resources.categories
        Me.CategoriesBunifuButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CategoriesBunifuButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.CategoriesBunifuButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.CategoriesBunifuButton.IconMarginLeft = 11
        Me.CategoriesBunifuButton.IconPadding = 10
        Me.CategoriesBunifuButton.IconRight = Nothing
        Me.CategoriesBunifuButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CategoriesBunifuButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.CategoriesBunifuButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.CategoriesBunifuButton.IconSize = 25
        Me.CategoriesBunifuButton.IdleBorderColor = System.Drawing.Color.Empty
        Me.CategoriesBunifuButton.IdleBorderRadius = 0
        Me.CategoriesBunifuButton.IdleBorderThickness = 0
        Me.CategoriesBunifuButton.IdleFillColor = System.Drawing.Color.Empty
        Me.CategoriesBunifuButton.IdleIconLeftImage = Global.EasyWarung.My.Resources.Resources.categories
        Me.CategoriesBunifuButton.IdleIconRightImage = Nothing
        Me.CategoriesBunifuButton.IndicateFocus = False
        Me.CategoriesBunifuButton.Location = New System.Drawing.Point(0, 200)
        Me.CategoriesBunifuButton.Name = "CategoriesBunifuButton"
        Me.CategoriesBunifuButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.CategoriesBunifuButton.OnDisabledState.BorderRadius = 1
        Me.CategoriesBunifuButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.CategoriesBunifuButton.OnDisabledState.BorderThickness = 1
        Me.CategoriesBunifuButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.CategoriesBunifuButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.CategoriesBunifuButton.OnDisabledState.IconLeftImage = Nothing
        Me.CategoriesBunifuButton.OnDisabledState.IconRightImage = Nothing
        Me.CategoriesBunifuButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.CategoriesBunifuButton.onHoverState.BorderRadius = 1
        Me.CategoriesBunifuButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.CategoriesBunifuButton.onHoverState.BorderThickness = 1
        Me.CategoriesBunifuButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.CategoriesBunifuButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.CategoriesBunifuButton.onHoverState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.categories_white
        Me.CategoriesBunifuButton.onHoverState.IconRightImage = Nothing
        Me.CategoriesBunifuButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.CategoriesBunifuButton.OnIdleState.BorderRadius = 1
        Me.CategoriesBunifuButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.CategoriesBunifuButton.OnIdleState.BorderThickness = 1
        Me.CategoriesBunifuButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.CategoriesBunifuButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.CategoriesBunifuButton.OnIdleState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.categories
        Me.CategoriesBunifuButton.OnIdleState.IconRightImage = Nothing
        Me.CategoriesBunifuButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.CategoriesBunifuButton.OnPressedState.BorderRadius = 1
        Me.CategoriesBunifuButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.CategoriesBunifuButton.OnPressedState.BorderThickness = 1
        Me.CategoriesBunifuButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.CategoriesBunifuButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.CategoriesBunifuButton.OnPressedState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.categories_white
        Me.CategoriesBunifuButton.OnPressedState.IconRightImage = Nothing
        Me.CategoriesBunifuButton.Size = New System.Drawing.Size(260, 45)
        Me.CategoriesBunifuButton.TabIndex = 3
        Me.CategoriesBunifuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CategoriesBunifuButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.CategoriesBunifuButton.TextMarginLeft = 0
        Me.CategoriesBunifuButton.TextPadding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.CategoriesBunifuButton.UseDefaultRadiusAndThickness = True
        '
        'DashboardBunifuButton
        '
        Me.DashboardBunifuButton.AllowAnimations = True
        Me.DashboardBunifuButton.AllowMouseEffects = True
        Me.DashboardBunifuButton.AllowToggling = False
        Me.DashboardBunifuButton.AnimationSpeed = 200
        Me.DashboardBunifuButton.AutoGenerateColors = False
        Me.DashboardBunifuButton.AutoRoundBorders = False
        Me.DashboardBunifuButton.AutoSizeLeftIcon = True
        Me.DashboardBunifuButton.AutoSizeRightIcon = True
        Me.DashboardBunifuButton.BackColor = System.Drawing.Color.Transparent
        Me.DashboardBunifuButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.DashboardBunifuButton.BackgroundImage = CType(resources.GetObject("DashboardBunifuButton.BackgroundImage"), System.Drawing.Image)
        Me.DashboardBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.DashboardBunifuButton.ButtonText = "Dashboard"
        Me.DashboardBunifuButton.ButtonTextMarginLeft = 0
        Me.DashboardBunifuButton.ColorContrastOnClick = 45
        Me.DashboardBunifuButton.ColorContrastOnHover = 45
        Me.DashboardBunifuButton.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges8.BottomLeft = True
        BorderEdges8.BottomRight = True
        BorderEdges8.TopLeft = True
        BorderEdges8.TopRight = True
        Me.DashboardBunifuButton.CustomizableEdges = BorderEdges8
        Me.DashboardBunifuButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.DashboardBunifuButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DashboardBunifuButton.DisabledFillColor = System.Drawing.Color.Empty
        Me.DashboardBunifuButton.DisabledForecolor = System.Drawing.Color.Empty
        Me.DashboardBunifuButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.DashboardBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.DashboardBunifuButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashboardBunifuButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DashboardBunifuButton.IconLeft = Global.EasyWarung.My.Resources.Resources.dashboard
        Me.DashboardBunifuButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardBunifuButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.DashboardBunifuButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.DashboardBunifuButton.IconMarginLeft = 11
        Me.DashboardBunifuButton.IconPadding = 10
        Me.DashboardBunifuButton.IconRight = Nothing
        Me.DashboardBunifuButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DashboardBunifuButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.DashboardBunifuButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.DashboardBunifuButton.IconSize = 25
        Me.DashboardBunifuButton.IdleBorderColor = System.Drawing.Color.Empty
        Me.DashboardBunifuButton.IdleBorderRadius = 0
        Me.DashboardBunifuButton.IdleBorderThickness = 0
        Me.DashboardBunifuButton.IdleFillColor = System.Drawing.Color.Empty
        Me.DashboardBunifuButton.IdleIconLeftImage = Global.EasyWarung.My.Resources.Resources.dashboard
        Me.DashboardBunifuButton.IdleIconRightImage = Nothing
        Me.DashboardBunifuButton.IndicateFocus = False
        Me.DashboardBunifuButton.Location = New System.Drawing.Point(0, 155)
        Me.DashboardBunifuButton.Name = "DashboardBunifuButton"
        Me.DashboardBunifuButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DashboardBunifuButton.OnDisabledState.BorderRadius = 1
        Me.DashboardBunifuButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.DashboardBunifuButton.OnDisabledState.BorderThickness = 1
        Me.DashboardBunifuButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.DashboardBunifuButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.DashboardBunifuButton.OnDisabledState.IconLeftImage = Nothing
        Me.DashboardBunifuButton.OnDisabledState.IconRightImage = Nothing
        Me.DashboardBunifuButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.DashboardBunifuButton.onHoverState.BorderRadius = 1
        Me.DashboardBunifuButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.DashboardBunifuButton.onHoverState.BorderThickness = 1
        Me.DashboardBunifuButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.DashboardBunifuButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.DashboardBunifuButton.onHoverState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.dashboard_white
        Me.DashboardBunifuButton.onHoverState.IconRightImage = Nothing
        Me.DashboardBunifuButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.DashboardBunifuButton.OnIdleState.BorderRadius = 1
        Me.DashboardBunifuButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.DashboardBunifuButton.OnIdleState.BorderThickness = 1
        Me.DashboardBunifuButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.DashboardBunifuButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DashboardBunifuButton.OnIdleState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.dashboard
        Me.DashboardBunifuButton.OnIdleState.IconRightImage = Nothing
        Me.DashboardBunifuButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.DashboardBunifuButton.OnPressedState.BorderRadius = 1
        Me.DashboardBunifuButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.DashboardBunifuButton.OnPressedState.BorderThickness = 1
        Me.DashboardBunifuButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.DashboardBunifuButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.DashboardBunifuButton.OnPressedState.IconLeftImage = Global.EasyWarung.My.Resources.Resources.dashboard_white
        Me.DashboardBunifuButton.OnPressedState.IconRightImage = Nothing
        Me.DashboardBunifuButton.Size = New System.Drawing.Size(260, 45)
        Me.DashboardBunifuButton.TabIndex = 2
        Me.DashboardBunifuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardBunifuButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DashboardBunifuButton.TextMarginLeft = 0
        Me.DashboardBunifuButton.TextPadding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.DashboardBunifuButton.UseDefaultRadiusAndThickness = True
        '
        'TopBunifuSeparator
        '
        Me.TopBunifuSeparator.BackColor = System.Drawing.Color.Transparent
        Me.TopBunifuSeparator.BackgroundImage = CType(resources.GetObject("TopBunifuSeparator.BackgroundImage"), System.Drawing.Image)
        Me.TopBunifuSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TopBunifuSeparator.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat
        Me.TopBunifuSeparator.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopBunifuSeparator.LineColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.TopBunifuSeparator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid
        Me.TopBunifuSeparator.LineThickness = 1
        Me.TopBunifuSeparator.Location = New System.Drawing.Point(0, 141)
        Me.TopBunifuSeparator.Name = "TopBunifuSeparator"
        Me.TopBunifuSeparator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal
        Me.TopBunifuSeparator.Size = New System.Drawing.Size(260, 14)
        Me.TopBunifuSeparator.TabIndex = 1
        '
        'LogoBunifuPanel
        '
        Me.LogoBunifuPanel.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LogoBunifuPanel.BackgroundImage = CType(resources.GetObject("LogoBunifuPanel.BackgroundImage"), System.Drawing.Image)
        Me.LogoBunifuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoBunifuPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LogoBunifuPanel.BorderRadius = 3
        Me.LogoBunifuPanel.BorderThickness = 1
        Me.LogoBunifuPanel.Controls.Add(Me.LogoBunifuPictureBox)
        Me.LogoBunifuPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.LogoBunifuPanel.Location = New System.Drawing.Point(0, 0)
        Me.LogoBunifuPanel.Name = "LogoBunifuPanel"
        Me.LogoBunifuPanel.ShowBorders = True
        Me.LogoBunifuPanel.Size = New System.Drawing.Size(260, 141)
        Me.LogoBunifuPanel.TabIndex = 0
        '
        'LogoBunifuPictureBox
        '
        Me.LogoBunifuPictureBox.AllowFocused = False
        Me.LogoBunifuPictureBox.AutoSizeHeight = False
        Me.LogoBunifuPictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LogoBunifuPictureBox.BorderRadius = 0
        Me.LogoBunifuPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogoBunifuPictureBox.Image = CType(resources.GetObject("LogoBunifuPictureBox.Image"), System.Drawing.Image)
        Me.LogoBunifuPictureBox.IsCircle = True
        Me.LogoBunifuPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoBunifuPictureBox.Name = "LogoBunifuPictureBox"
        Me.LogoBunifuPictureBox.Size = New System.Drawing.Size(260, 141)
        Me.LogoBunifuPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoBunifuPictureBox.TabIndex = 0
        Me.LogoBunifuPictureBox.TabStop = False
        Me.LogoBunifuPictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'NotifyIcon
        '
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "NotifyIcon"
        Me.NotifyIcon.Visible = True
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1386, 788)
        Me.Controls.Add(Me.DesktopBunifuPanel)
        Me.Controls.Add(Me.TitleBarBunifuPanel)
        Me.Controls.Add(Me.MenuBunifuPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EasyWarung"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TitleBarBunifuPanel.ResumeLayout(False)
        Me.MenuBunifuPanel.ResumeLayout(False)
        Me.LogoBunifuPanel.ResumeLayout(False)
        CType(Me.LogoBunifuPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuBunifuPanel As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents LogoBunifuPanel As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents LogoBunifuPictureBox As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents TopBunifuSeparator As Bunifu.UI.WinForms.BunifuSeparator
    Friend WithEvents DashboardBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents EmployeesBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents OrdersBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents ProductsBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents CategoriesBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents LogoutBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents SettingBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BottomBunifuSeparator As Bunifu.UI.WinForms.BunifuSeparator
    Friend WithEvents TitleBarBunifuPanel As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents DesktopBunifuPanel As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents BunifuFormControlBox As Bunifu.UI.WinForms.BunifuFormControlBox
    Friend WithEvents BunifuSnackbar As Bunifu.UI.WinForms.BunifuSnackbar
    Friend WithEvents SignInBunifuButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents NotifyIcon As NotifyIcon
End Class
