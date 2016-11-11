<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Intro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Intro))
        Me.PBoxBug = New System.Windows.Forms.PictureBox()
        Me.LblIntro = New System.Windows.Forms.Label()
        Me.BtnYes = New System.Windows.Forms.Button()
        Me.BtnYes2 = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnMinimize = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.ImgListBugs = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.PBoxBug, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBoxBug
        '
        Me.PBoxBug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBoxBug.Location = New System.Drawing.Point(123, 135)
        Me.PBoxBug.Name = "PBoxBug"
        Me.PBoxBug.Size = New System.Drawing.Size(71, 69)
        Me.PBoxBug.TabIndex = 0
        Me.PBoxBug.TabStop = False
        '
        'LblIntro
        '
        Me.LblIntro.AutoSize = True
        Me.LblIntro.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIntro.Location = New System.Drawing.Point(273, 114)
        Me.LblIntro.Name = "LblIntro"
        Me.LblIntro.Size = New System.Drawing.Size(378, 90)
        Me.LblIntro.TabIndex = 1
        Me.LblIntro.Text = "Hey there! My name is Sam, and I'm a beautiful pink butterfly. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "I need you to so" & _
    "lve math questions so I can get home faster!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "I only have one minute though, so " & _
    "hurry!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Will you help me?"
        Me.LblIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnYes
        '
        Me.BtnYes.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnYes.FlatAppearance.BorderSize = 0
        Me.BtnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnYes.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnYes.Location = New System.Drawing.Point(370, 219)
        Me.BtnYes.Name = "BtnYes"
        Me.BtnYes.Size = New System.Drawing.Size(75, 26)
        Me.BtnYes.TabIndex = 2
        Me.BtnYes.Text = "Of course!"
        Me.BtnYes.UseVisualStyleBackColor = False
        '
        'BtnYes2
        '
        Me.BtnYes2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnYes2.FlatAppearance.BorderSize = 0
        Me.BtnYes2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnYes2.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnYes2.Location = New System.Drawing.Point(484, 219)
        Me.BtnYes2.Name = "BtnYes2"
        Me.BtnYes2.Size = New System.Drawing.Size(76, 26)
        Me.BtnYes2.TabIndex = 3
        Me.BtnYes2.Text = "Definitely!"
        Me.BtnYes2.UseVisualStyleBackColor = False
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
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(259, 20)
        Me.LblTitle.MinimumSize = New System.Drawing.Size(200, 0)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(200, 18)
        Me.LblTitle.TabIndex = 32
        Me.LblTitle.Text = "Introduction"
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
        Me.BtnMinimize.TabIndex = 33
        Me.BtnMinimize.UseVisualStyleBackColor = True
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
        Me.BtnBack.TabIndex = 34
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'ImgListBugs
        '
        Me.ImgListBugs.ImageStream = CType(resources.GetObject("ImgListBugs.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgListBugs.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgListBugs.Images.SetKeyName(0, "Butterfly2.png")
        Me.ImgListBugs.Images.SetKeyName(1, "dragonfly2.png")
        Me.ImgListBugs.Images.SetKeyName(2, "Bee2.png")
        Me.ImgListBugs.Images.SetKeyName(3, "black-cartoon-spider-square.png")
        Me.ImgListBugs.Images.SetKeyName(4, "snail.png")
        '
        'Intro
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(733, 465)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnMinimize)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnYes2)
        Me.Controls.Add(Me.BtnYes)
        Me.Controls.Add(Me.LblIntro)
        Me.Controls.Add(Me.PBoxBug)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Intro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Introduction"
        CType(Me.PBoxBug, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PBoxBug As System.Windows.Forms.PictureBox
    Friend WithEvents LblIntro As System.Windows.Forms.Label
    Friend WithEvents BtnYes As System.Windows.Forms.Button
    Friend WithEvents BtnYes2 As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents BtnMinimize As System.Windows.Forms.Button
    Friend WithEvents BtnBack As System.Windows.Forms.Button
    Friend WithEvents ImgListBugs As System.Windows.Forms.ImageList
End Class
