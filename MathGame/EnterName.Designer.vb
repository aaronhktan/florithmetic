<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterName
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnterName))
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.LblName = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnMinimize = New System.Windows.Forms.Button()
        Me.BtnButterfly = New System.Windows.Forms.Button()
        Me.BtnBee = New System.Windows.Forms.Button()
        Me.BtnDragon = New System.Windows.Forms.Button()
        Me.BtnSnail = New System.Windows.Forms.Button()
        Me.BtnSpider = New System.Windows.Forms.Button()
        Me.LblInsect = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(304, 110)
        Me.TxtName.MaxLength = 10
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(100, 20)
        Me.TxtName.TabIndex = 0
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.Location = New System.Drawing.Point(292, 70)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(136, 18)
        Me.LblName.TabIndex = 2
        Me.LblName.Text = "Put your name here..."
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
        Me.BtnClose.TabIndex = 31
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.BackgroundImage = CType(resources.GetObject("BtnBack.BackgroundImage"), System.Drawing.Image)
        Me.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnBack.FlatAppearance.BorderSize = 0
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBack.Location = New System.Drawing.Point(12, 12)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(42, 34)
        Me.BtnBack.TabIndex = 30
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(259, 20)
        Me.LblTitle.MinimumSize = New System.Drawing.Size(200, 0)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(200, 18)
        Me.LblTitle.TabIndex = 39
        Me.LblTitle.Text = "Personalization"
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnMinimize
        '
        Me.BtnMinimize.BackgroundImage = CType(resources.GetObject("BtnMinimize.BackgroundImage"), System.Drawing.Image)
        Me.BtnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnMinimize.FlatAppearance.BorderSize = 0
        Me.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimize.Location = New System.Drawing.Point(60, 12)
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.Size = New System.Drawing.Size(42, 34)
        Me.BtnMinimize.TabIndex = 40
        Me.BtnMinimize.UseVisualStyleBackColor = True
        '
        'BtnButterfly
        '
        Me.BtnButterfly.BackgroundImage = CType(resources.GetObject("BtnButterfly.BackgroundImage"), System.Drawing.Image)
        Me.BtnButterfly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnButterfly.FlatAppearance.BorderSize = 0
        Me.BtnButterfly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnButterfly.Location = New System.Drawing.Point(166, 195)
        Me.BtnButterfly.Name = "BtnButterfly"
        Me.BtnButterfly.Size = New System.Drawing.Size(71, 71)
        Me.BtnButterfly.TabIndex = 41
        Me.BtnButterfly.UseVisualStyleBackColor = True
        '
        'BtnBee
        '
        Me.BtnBee.BackgroundImage = CType(resources.GetObject("BtnBee.BackgroundImage"), System.Drawing.Image)
        Me.BtnBee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnBee.FlatAppearance.BorderSize = 0
        Me.BtnBee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBee.Location = New System.Drawing.Point(320, 195)
        Me.BtnBee.Name = "BtnBee"
        Me.BtnBee.Size = New System.Drawing.Size(71, 71)
        Me.BtnBee.TabIndex = 42
        Me.BtnBee.UseVisualStyleBackColor = True
        '
        'BtnDragon
        '
        Me.BtnDragon.BackgroundImage = CType(resources.GetObject("BtnDragon.BackgroundImage"), System.Drawing.Image)
        Me.BtnDragon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnDragon.FlatAppearance.BorderSize = 0
        Me.BtnDragon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDragon.Location = New System.Drawing.Point(243, 195)
        Me.BtnDragon.Name = "BtnDragon"
        Me.BtnDragon.Size = New System.Drawing.Size(71, 71)
        Me.BtnDragon.TabIndex = 43
        Me.BtnDragon.UseVisualStyleBackColor = True
        '
        'BtnSnail
        '
        Me.BtnSnail.BackgroundImage = CType(resources.GetObject("BtnSnail.BackgroundImage"), System.Drawing.Image)
        Me.BtnSnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSnail.FlatAppearance.BorderSize = 0
        Me.BtnSnail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSnail.Location = New System.Drawing.Point(474, 195)
        Me.BtnSnail.Name = "BtnSnail"
        Me.BtnSnail.Size = New System.Drawing.Size(71, 71)
        Me.BtnSnail.TabIndex = 44
        Me.BtnSnail.UseVisualStyleBackColor = True
        '
        'BtnSpider
        '
        Me.BtnSpider.BackgroundImage = CType(resources.GetObject("BtnSpider.BackgroundImage"), System.Drawing.Image)
        Me.BtnSpider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSpider.FlatAppearance.BorderSize = 0
        Me.BtnSpider.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSpider.Location = New System.Drawing.Point(397, 195)
        Me.BtnSpider.Name = "BtnSpider"
        Me.BtnSpider.Size = New System.Drawing.Size(71, 71)
        Me.BtnSpider.TabIndex = 45
        Me.BtnSpider.UseVisualStyleBackColor = True
        '
        'LblInsect
        '
        Me.LblInsect.AutoSize = True
        Me.LblInsect.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInsect.Location = New System.Drawing.Point(240, 158)
        Me.LblInsect.Name = "LblInsect"
        Me.LblInsect.Size = New System.Drawing.Size(234, 18)
        Me.LblInsect.TabIndex = 46
        Me.LblInsect.Text = "...and then choose your favourite bug!"
        '
        'EnterName
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(733, 465)
        Me.Controls.Add(Me.LblInsect)
        Me.Controls.Add(Me.BtnSpider)
        Me.Controls.Add(Me.BtnSnail)
        Me.Controls.Add(Me.BtnDragon)
        Me.Controls.Add(Me.BtnBee)
        Me.Controls.Add(Me.BtnButterfly)
        Me.Controls.Add(Me.BtnMinimize)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.TxtName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EnterName"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personalization"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents LblName As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnBack As System.Windows.Forms.Button
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents BtnMinimize As System.Windows.Forms.Button
    Friend WithEvents BtnButterfly As System.Windows.Forms.Button
    Friend WithEvents BtnBee As System.Windows.Forms.Button
    Friend WithEvents BtnDragon As System.Windows.Forms.Button
    Friend WithEvents BtnSnail As System.Windows.Forms.Button
    Friend WithEvents BtnSpider As System.Windows.Forms.Button
    Friend WithEvents LblInsect As System.Windows.Forms.Label
End Class
