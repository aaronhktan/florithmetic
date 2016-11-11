<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainSplash))
        Me.BtnMinimize = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblMathTitle = New System.Windows.Forms.Label()
        Me.BtnPlay = New System.Windows.Forms.Button()
        Me.BtnSettings = New System.Windows.Forms.Button()
        Me.BtnCredits = New System.Windows.Forms.Button()
        Me.PBoxInsect = New System.Windows.Forms.PictureBox()
        Me.TimerBee = New System.Windows.Forms.Timer(Me.components)
        Me.PBoxSpider = New System.Windows.Forms.PictureBox()
        Me.TimerSpider = New System.Windows.Forms.Timer(Me.components)
        Me.PBoxButterfly = New System.Windows.Forms.PictureBox()
        Me.TimerButterfly = New System.Windows.Forms.Timer(Me.components)
        Me.PBoxDragonfly = New System.Windows.Forms.PictureBox()
        Me.TimerDragon = New System.Windows.Forms.Timer(Me.components)
        Me.BtnAbout = New System.Windows.Forms.Button()
        Me.BtnAsk = New System.Windows.Forms.Button()
        Me.BtnGo1 = New System.Windows.Forms.Button()
        Me.BtnGo2 = New System.Windows.Forms.Button()
        Me.BtnGo3 = New System.Windows.Forms.Button()
        Me.LblGameTitle = New System.Windows.Forms.Label()
        CType(Me.PBoxInsect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxSpider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxButterfly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxDragonfly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnMinimize
        '
        Me.BtnMinimize.BackgroundImage = CType(resources.GetObject("BtnMinimize.BackgroundImage"), System.Drawing.Image)
        Me.BtnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnMinimize.FlatAppearance.BorderSize = 0
        Me.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimize.Location = New System.Drawing.Point(12, 12)
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.Size = New System.Drawing.Size(42, 34)
        Me.BtnMinimize.TabIndex = 41
        Me.BtnMinimize.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Location = New System.Drawing.Point(679, 12)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(42, 34)
        Me.BtnClose.TabIndex = 40
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'LblMathTitle
        '
        Me.LblMathTitle.AutoSize = True
        Me.LblMathTitle.Font = New System.Drawing.Font("Open Sans", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMathTitle.Location = New System.Drawing.Point(49, 97)
        Me.LblMathTitle.Name = "LblMathTitle"
        Me.LblMathTitle.Size = New System.Drawing.Size(178, 39)
        Me.LblMathTitle.TabIndex = 42
        Me.LblMathTitle.Text = "Florithmetic"
        '
        'BtnPlay
        '
        Me.BtnPlay.BackColor = System.Drawing.Color.Transparent
        Me.BtnPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPlay.FlatAppearance.BorderSize = 0
        Me.BtnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPlay.Font = New System.Drawing.Font("Open Sans Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPlay.Location = New System.Drawing.Point(549, 62)
        Me.BtnPlay.Name = "BtnPlay"
        Me.BtnPlay.Size = New System.Drawing.Size(67, 44)
        Me.BtnPlay.TabIndex = 44
        Me.BtnPlay.Text = "Play"
        Me.BtnPlay.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.BtnPlay.UseVisualStyleBackColor = False
        '
        'BtnSettings
        '
        Me.BtnSettings.BackColor = System.Drawing.Color.Transparent
        Me.BtnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSettings.FlatAppearance.BorderSize = 0
        Me.BtnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSettings.Font = New System.Drawing.Font("Open Sans Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSettings.Location = New System.Drawing.Point(506, 101)
        Me.BtnSettings.Name = "BtnSettings"
        Me.BtnSettings.Size = New System.Drawing.Size(110, 40)
        Me.BtnSettings.TabIndex = 45
        Me.BtnSettings.Text = "Settings"
        Me.BtnSettings.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.BtnSettings.UseVisualStyleBackColor = False
        '
        'BtnCredits
        '
        Me.BtnCredits.BackColor = System.Drawing.Color.Transparent
        Me.BtnCredits.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCredits.FlatAppearance.BorderSize = 0
        Me.BtnCredits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.BtnCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCredits.Font = New System.Drawing.Font("Open Sans Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCredits.Location = New System.Drawing.Point(506, 141)
        Me.BtnCredits.Name = "BtnCredits"
        Me.BtnCredits.Size = New System.Drawing.Size(110, 38)
        Me.BtnCredits.TabIndex = 46
        Me.BtnCredits.Text = "Credits"
        Me.BtnCredits.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.BtnCredits.UseVisualStyleBackColor = False
        '
        'PBoxInsect
        '
        Me.PBoxInsect.BackColor = System.Drawing.Color.Transparent
        Me.PBoxInsect.BackgroundImage = CType(resources.GetObject("PBoxInsect.BackgroundImage"), System.Drawing.Image)
        Me.PBoxInsect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBoxInsect.Location = New System.Drawing.Point(-1, 168)
        Me.PBoxInsect.Name = "PBoxInsect"
        Me.PBoxInsect.Size = New System.Drawing.Size(36, 41)
        Me.PBoxInsect.TabIndex = 47
        Me.PBoxInsect.TabStop = False
        '
        'TimerBee
        '
        '
        'PBoxSpider
        '
        Me.PBoxSpider.BackColor = System.Drawing.Color.Transparent
        Me.PBoxSpider.BackgroundImage = CType(resources.GetObject("PBoxSpider.BackgroundImage"), System.Drawing.Image)
        Me.PBoxSpider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBoxSpider.Location = New System.Drawing.Point(603, 350)
        Me.PBoxSpider.Name = "PBoxSpider"
        Me.PBoxSpider.Size = New System.Drawing.Size(38, 42)
        Me.PBoxSpider.TabIndex = 49
        Me.PBoxSpider.TabStop = False
        '
        'TimerSpider
        '
        Me.TimerSpider.Interval = 300
        '
        'PBoxButterfly
        '
        Me.PBoxButterfly.BackColor = System.Drawing.Color.Transparent
        Me.PBoxButterfly.BackgroundImage = CType(resources.GetObject("PBoxButterfly.BackgroundImage"), System.Drawing.Image)
        Me.PBoxButterfly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBoxButterfly.Location = New System.Drawing.Point(186, 40)
        Me.PBoxButterfly.Name = "PBoxButterfly"
        Me.PBoxButterfly.Size = New System.Drawing.Size(55, 54)
        Me.PBoxButterfly.TabIndex = 50
        Me.PBoxButterfly.TabStop = False
        '
        'TimerButterfly
        '
        Me.TimerButterfly.Interval = 25
        '
        'PBoxDragonfly
        '
        Me.PBoxDragonfly.BackColor = System.Drawing.Color.Transparent
        Me.PBoxDragonfly.BackgroundImage = CType(resources.GetObject("PBoxDragonfly.BackgroundImage"), System.Drawing.Image)
        Me.PBoxDragonfly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBoxDragonfly.Location = New System.Drawing.Point(699, 221)
        Me.PBoxDragonfly.Name = "PBoxDragonfly"
        Me.PBoxDragonfly.Size = New System.Drawing.Size(41, 40)
        Me.PBoxDragonfly.TabIndex = 51
        Me.PBoxDragonfly.TabStop = False
        '
        'TimerDragon
        '
        Me.TimerDragon.Interval = 50
        '
        'BtnAbout
        '
        Me.BtnAbout.BackgroundImage = CType(resources.GetObject("BtnAbout.BackgroundImage"), System.Drawing.Image)
        Me.BtnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnAbout.FlatAppearance.BorderSize = 0
        Me.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbout.Location = New System.Drawing.Point(631, 12)
        Me.BtnAbout.Name = "BtnAbout"
        Me.BtnAbout.Size = New System.Drawing.Size(42, 34)
        Me.BtnAbout.TabIndex = 52
        Me.BtnAbout.UseVisualStyleBackColor = True
        '
        'BtnAsk
        '
        Me.BtnAsk.BackgroundImage = CType(resources.GetObject("BtnAsk.BackgroundImage"), System.Drawing.Image)
        Me.BtnAsk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnAsk.FlatAppearance.BorderSize = 0
        Me.BtnAsk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAsk.Location = New System.Drawing.Point(60, 12)
        Me.BtnAsk.Name = "BtnAsk"
        Me.BtnAsk.Size = New System.Drawing.Size(42, 34)
        Me.BtnAsk.TabIndex = 53
        Me.BtnAsk.UseVisualStyleBackColor = True
        '
        'BtnGo1
        '
        Me.BtnGo1.BackgroundImage = CType(resources.GetObject("BtnGo1.BackgroundImage"), System.Drawing.Image)
        Me.BtnGo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnGo1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGo1.FlatAppearance.BorderSize = 0
        Me.BtnGo1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.BtnGo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGo1.Location = New System.Drawing.Point(608, 62)
        Me.BtnGo1.Name = "BtnGo1"
        Me.BtnGo1.Size = New System.Drawing.Size(32, 44)
        Me.BtnGo1.TabIndex = 54
        Me.BtnGo1.UseVisualStyleBackColor = True
        '
        'BtnGo2
        '
        Me.BtnGo2.BackgroundImage = CType(resources.GetObject("BtnGo2.BackgroundImage"), System.Drawing.Image)
        Me.BtnGo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnGo2.FlatAppearance.BorderSize = 0
        Me.BtnGo2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.BtnGo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGo2.Location = New System.Drawing.Point(608, 101)
        Me.BtnGo2.Name = "BtnGo2"
        Me.BtnGo2.Size = New System.Drawing.Size(32, 44)
        Me.BtnGo2.TabIndex = 55
        Me.BtnGo2.UseVisualStyleBackColor = True
        '
        'BtnGo3
        '
        Me.BtnGo3.BackgroundImage = CType(resources.GetObject("BtnGo3.BackgroundImage"), System.Drawing.Image)
        Me.BtnGo3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnGo3.FlatAppearance.BorderSize = 0
        Me.BtnGo3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.BtnGo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGo3.Location = New System.Drawing.Point(608, 141)
        Me.BtnGo3.Name = "BtnGo3"
        Me.BtnGo3.Size = New System.Drawing.Size(32, 38)
        Me.BtnGo3.TabIndex = 56
        Me.BtnGo3.UseVisualStyleBackColor = True
        '
        'LblGameTitle
        '
        Me.LblGameTitle.AutoSize = True
        Me.LblGameTitle.Font = New System.Drawing.Font("Open Sans Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGameTitle.Location = New System.Drawing.Point(64, 136)
        Me.LblGameTitle.Name = "LblGameTitle"
        Me.LblGameTitle.Size = New System.Drawing.Size(156, 20)
        Me.LblGameTitle.TabIndex = 57
        Me.LblGameTitle.Text = "A Game by Aaron Tan"
        Me.LblGameTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MainSplash
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(733, 465)
        Me.Controls.Add(Me.LblGameTitle)
        Me.Controls.Add(Me.BtnGo3)
        Me.Controls.Add(Me.BtnGo2)
        Me.Controls.Add(Me.BtnGo1)
        Me.Controls.Add(Me.BtnAsk)
        Me.Controls.Add(Me.BtnAbout)
        Me.Controls.Add(Me.PBoxDragonfly)
        Me.Controls.Add(Me.PBoxButterfly)
        Me.Controls.Add(Me.PBoxSpider)
        Me.Controls.Add(Me.PBoxInsect)
        Me.Controls.Add(Me.BtnCredits)
        Me.Controls.Add(Me.BtnSettings)
        Me.Controls.Add(Me.BtnPlay)
        Me.Controls.Add(Me.LblMathTitle)
        Me.Controls.Add(Me.BtnMinimize)
        Me.Controls.Add(Me.BtnClose)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Florithmetic - Main Menu"
        CType(Me.PBoxInsect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxSpider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxButterfly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxDragonfly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnMinimize As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents LblMathTitle As System.Windows.Forms.Label
    Friend WithEvents BtnPlay As System.Windows.Forms.Button
    Friend WithEvents BtnSettings As System.Windows.Forms.Button
    Friend WithEvents BtnCredits As System.Windows.Forms.Button
    Friend WithEvents PBoxInsect As System.Windows.Forms.PictureBox
    Friend WithEvents TimerBee As System.Windows.Forms.Timer
    Friend WithEvents PBoxSpider As System.Windows.Forms.PictureBox
    Friend WithEvents TimerSpider As System.Windows.Forms.Timer
    Friend WithEvents PBoxButterfly As System.Windows.Forms.PictureBox
    Friend WithEvents TimerButterfly As System.Windows.Forms.Timer
    Friend WithEvents PBoxDragonfly As System.Windows.Forms.PictureBox
    Friend WithEvents TimerDragon As System.Windows.Forms.Timer
    Friend WithEvents BtnAbout As System.Windows.Forms.Button
    Friend WithEvents BtnAsk As System.Windows.Forms.Button
    Friend WithEvents BtnGo1 As System.Windows.Forms.Button
    Friend WithEvents BtnGo2 As System.Windows.Forms.Button
    Friend WithEvents BtnGo3 As System.Windows.Forms.Button
    Friend WithEvents LblGameTitle As System.Windows.Forms.Label
End Class
