<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MainBunifuPanel = New Bunifu.UI.WinForms.BunifuPanel()
        Me.LoggedBunifuLabel = New Bunifu.UI.WinForms.BunifuLabel()
        Me.StatusBunifuLabel = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BottomBunifuPanel = New Bunifu.UI.WinForms.BunifuPanel()
        Me.GitHubBunifuLabel = New Bunifu.UI.WinForms.BunifuLabel()
        Me.CategoryNameBunifuLabel = New Bunifu.UI.WinForms.BunifuLabel()
        Me.DateTimeBunifuLabel = New Bunifu.UI.WinForms.BunifuLabel()
        Me.LogoBunifuPictureBox = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.WelcomeBunifuLabel = New Bunifu.UI.WinForms.BunifuLabel()
        Me.MainBunifuPanel.SuspendLayout()
        Me.BottomBunifuPanel.SuspendLayout()
        CType(Me.LogoBunifuPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainBunifuPanel
        '
        Me.MainBunifuPanel.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.MainBunifuPanel.BackgroundImage = CType(resources.GetObject("MainBunifuPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainBunifuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainBunifuPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.MainBunifuPanel.BorderRadius = 3
        Me.MainBunifuPanel.BorderThickness = 0
        Me.MainBunifuPanel.Controls.Add(Me.LoggedBunifuLabel)
        Me.MainBunifuPanel.Controls.Add(Me.StatusBunifuLabel)
        Me.MainBunifuPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MainBunifuPanel.Location = New System.Drawing.Point(0, 674)
        Me.MainBunifuPanel.Name = "MainBunifuPanel"
        Me.MainBunifuPanel.ShowBorders = True
        Me.MainBunifuPanel.Size = New System.Drawing.Size(1105, 50)
        Me.MainBunifuPanel.TabIndex = 0
        '
        'LoggedBunifuLabel
        '
        Me.LoggedBunifuLabel.AllowParentOverrides = False
        Me.LoggedBunifuLabel.AutoEllipsis = False
        Me.LoggedBunifuLabel.AutoSize = False
        Me.LoggedBunifuLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.LoggedBunifuLabel.CursorType = System.Windows.Forms.Cursors.Default
        Me.LoggedBunifuLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoggedBunifuLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.LoggedBunifuLabel.Location = New System.Drawing.Point(786, -3)
        Me.LoggedBunifuLabel.Name = "LoggedBunifuLabel"
        Me.LoggedBunifuLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LoggedBunifuLabel.Size = New System.Drawing.Size(307, 50)
        Me.LoggedBunifuLabel.TabIndex = 10
        Me.LoggedBunifuLabel.Text = "Logged in for:"
        Me.LoggedBunifuLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.LoggedBunifuLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'StatusBunifuLabel
        '
        Me.StatusBunifuLabel.AllowParentOverrides = False
        Me.StatusBunifuLabel.AutoEllipsis = False
        Me.StatusBunifuLabel.AutoSize = False
        Me.StatusBunifuLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.StatusBunifuLabel.CursorType = System.Windows.Forms.Cursors.Default
        Me.StatusBunifuLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBunifuLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.StatusBunifuLabel.Location = New System.Drawing.Point(12, 0)
        Me.StatusBunifuLabel.Name = "StatusBunifuLabel"
        Me.StatusBunifuLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StatusBunifuLabel.Size = New System.Drawing.Size(307, 50)
        Me.StatusBunifuLabel.TabIndex = 9
        Me.StatusBunifuLabel.Text = "Status:"
        Me.StatusBunifuLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.StatusBunifuLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BottomBunifuPanel
        '
        Me.BottomBunifuPanel.BackgroundColor = System.Drawing.Color.Transparent
        Me.BottomBunifuPanel.BackgroundImage = CType(resources.GetObject("BottomBunifuPanel.BackgroundImage"), System.Drawing.Image)
        Me.BottomBunifuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BottomBunifuPanel.BorderColor = System.Drawing.Color.Transparent
        Me.BottomBunifuPanel.BorderRadius = 3
        Me.BottomBunifuPanel.BorderThickness = 1
        Me.BottomBunifuPanel.Controls.Add(Me.WelcomeBunifuLabel)
        Me.BottomBunifuPanel.Controls.Add(Me.GitHubBunifuLabel)
        Me.BottomBunifuPanel.Controls.Add(Me.CategoryNameBunifuLabel)
        Me.BottomBunifuPanel.Controls.Add(Me.DateTimeBunifuLabel)
        Me.BottomBunifuPanel.Controls.Add(Me.LogoBunifuPictureBox)
        Me.BottomBunifuPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BottomBunifuPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomBunifuPanel.Name = "BottomBunifuPanel"
        Me.BottomBunifuPanel.ShowBorders = True
        Me.BottomBunifuPanel.Size = New System.Drawing.Size(1105, 674)
        Me.BottomBunifuPanel.TabIndex = 1
        '
        'GitHubBunifuLabel
        '
        Me.GitHubBunifuLabel.AllowParentOverrides = False
        Me.GitHubBunifuLabel.AutoEllipsis = False
        Me.GitHubBunifuLabel.AutoSize = False
        Me.GitHubBunifuLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GitHubBunifuLabel.CursorType = System.Windows.Forms.Cursors.Hand
        Me.GitHubBunifuLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GitHubBunifuLabel.ForeColor = System.Drawing.Color.Blue
        Me.GitHubBunifuLabel.Location = New System.Drawing.Point(573, 629)
        Me.GitHubBunifuLabel.Name = "GitHubBunifuLabel"
        Me.GitHubBunifuLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GitHubBunifuLabel.Size = New System.Drawing.Size(104, 25)
        Me.GitHubBunifuLabel.TabIndex = 9
        Me.GitHubBunifuLabel.Text = "AlicelieseLou"
        Me.GitHubBunifuLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.GitHubBunifuLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
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
        Me.CategoryNameBunifuLabel.Location = New System.Drawing.Point(427, 629)
        Me.CategoryNameBunifuLabel.Name = "CategoryNameBunifuLabel"
        Me.CategoryNameBunifuLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CategoryNameBunifuLabel.Size = New System.Drawing.Size(140, 25)
        Me.CategoryNameBunifuLabel.TabIndex = 8
        Me.CategoryNameBunifuLabel.Text = "Made With ❤ By:"
        Me.CategoryNameBunifuLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.CategoryNameBunifuLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'DateTimeBunifuLabel
        '
        Me.DateTimeBunifuLabel.AllowParentOverrides = False
        Me.DateTimeBunifuLabel.AutoEllipsis = False
        Me.DateTimeBunifuLabel.AutoSize = False
        Me.DateTimeBunifuLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.DateTimeBunifuLabel.CursorType = System.Windows.Forms.Cursors.Default
        Me.DateTimeBunifuLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold)
        Me.DateTimeBunifuLabel.ForeColor = System.Drawing.Color.Transparent
        Me.DateTimeBunifuLabel.Location = New System.Drawing.Point(152, 513)
        Me.DateTimeBunifuLabel.Name = "DateTimeBunifuLabel"
        Me.DateTimeBunifuLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DateTimeBunifuLabel.Size = New System.Drawing.Size(800, 60)
        Me.DateTimeBunifuLabel.TabIndex = 5
        Me.DateTimeBunifuLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.DateTimeBunifuLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'LogoBunifuPictureBox
        '
        Me.LogoBunifuPictureBox.AllowFocused = False
        Me.LogoBunifuPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LogoBunifuPictureBox.AutoSizeHeight = True
        Me.LogoBunifuPictureBox.BorderRadius = 0
        Me.LogoBunifuPictureBox.Image = Global.EasyWarung.My.Resources.Resources.logo
        Me.LogoBunifuPictureBox.IsCircle = True
        Me.LogoBunifuPictureBox.Location = New System.Drawing.Point(383, 168)
        Me.LogoBunifuPictureBox.Name = "LogoBunifuPictureBox"
        Me.LogoBunifuPictureBox.Size = New System.Drawing.Size(339, 339)
        Me.LogoBunifuPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoBunifuPictureBox.TabIndex = 0
        Me.LogoBunifuPictureBox.TabStop = False
        Me.LogoBunifuPictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'WelcomeBunifuLabel
        '
        Me.WelcomeBunifuLabel.AllowParentOverrides = False
        Me.WelcomeBunifuLabel.AutoEllipsis = False
        Me.WelcomeBunifuLabel.AutoSize = False
        Me.WelcomeBunifuLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.WelcomeBunifuLabel.CursorType = System.Windows.Forms.Cursors.Default
        Me.WelcomeBunifuLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold)
        Me.WelcomeBunifuLabel.ForeColor = System.Drawing.Color.Transparent
        Me.WelcomeBunifuLabel.Location = New System.Drawing.Point(152, 102)
        Me.WelcomeBunifuLabel.Name = "WelcomeBunifuLabel"
        Me.WelcomeBunifuLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WelcomeBunifuLabel.Size = New System.Drawing.Size(800, 60)
        Me.WelcomeBunifuLabel.TabIndex = 10
        Me.WelcomeBunifuLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.WelcomeBunifuLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'AboutMeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1105, 724)
        Me.Controls.Add(Me.BottomBunifuPanel)
        Me.Controls.Add(Me.MainBunifuPanel)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AboutMeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AboutMeForm"
        Me.MainBunifuPanel.ResumeLayout(False)
        Me.BottomBunifuPanel.ResumeLayout(False)
        CType(Me.LogoBunifuPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainBunifuPanel As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents BottomBunifuPanel As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents LogoBunifuPictureBox As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents DateTimeBunifuLabel As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents CategoryNameBunifuLabel As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents GitHubBunifuLabel As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents StatusBunifuLabel As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Timer As Timer
    Friend WithEvents LoggedBunifuLabel As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents WelcomeBunifuLabel As Bunifu.UI.WinForms.BunifuLabel
End Class
