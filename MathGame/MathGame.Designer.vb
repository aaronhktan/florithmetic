<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MathGame))
        Me.TimerStart = New System.Windows.Forms.Timer(Me.components)
        Me.LblTimer = New System.Windows.Forms.Label()
        Me.LblNum1 = New System.Windows.Forms.Label()
        Me.TxtAns = New System.Windows.Forms.TextBox()
        Me.PBoxBlue = New System.Windows.Forms.PictureBox()
        Me.PBoxSunFlower = New System.Windows.Forms.PictureBox()
        Me.PBoxDaisy = New System.Windows.Forms.PictureBox()
        Me.PBoxRed = New System.Windows.Forms.PictureBox()
        Me.PBoxPink = New System.Windows.Forms.PictureBox()
        Me.LblNum2 = New System.Windows.Forms.Label()
        Me.LblOperation = New System.Windows.Forms.Label()
        Me.LblEquals = New System.Windows.Forms.Label()
        Me.BtnCheck = New System.Windows.Forms.Button()
        Me.LblNum3 = New System.Windows.Forms.Label()
        Me.LblOperation2 = New System.Windows.Forms.Label()
        Me.LblBracket1 = New System.Windows.Forms.Label()
        Me.LblBracket2 = New System.Windows.Forms.Label()
        Me.LblBracket3 = New System.Windows.Forms.Label()
        Me.LblBracket4 = New System.Windows.Forms.Label()
        Me.PBoxTimer = New System.Windows.Forms.PictureBox()
        Me.PBoxCheck = New System.Windows.Forms.PictureBox()
        Me.LblCorrect = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.LblFlower1 = New System.Windows.Forms.Label()
        Me.LblFlower2 = New System.Windows.Forms.Label()
        Me.LblFlower3 = New System.Windows.Forms.Label()
        Me.LblFlower4 = New System.Windows.Forms.Label()
        Me.LblFlower5 = New System.Windows.Forms.Label()
        Me.TimerFlower = New System.Windows.Forms.Timer(Me.components)
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.PBoxButterfly = New System.Windows.Forms.PictureBox()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnMinimize = New System.Windows.Forms.Button()
        Me.PBoxEnd = New System.Windows.Forms.PictureBox()
        Me.PBoxBee = New System.Windows.Forms.PictureBox()
        Me.PBoxDragon = New System.Windows.Forms.PictureBox()
        Me.PBoxButterfly2 = New System.Windows.Forms.PictureBox()
        Me.PBoxFly = New System.Windows.Forms.PictureBox()
        Me.LblInsect1 = New System.Windows.Forms.Label()
        Me.LblInsect2 = New System.Windows.Forms.Label()
        Me.BtnReplay = New System.Windows.Forms.Button()
        Me.ImgListBugs = New System.Windows.Forms.ImageList(Me.components)
        Me.ImgListEnd = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.PBoxBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxSunFlower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxDaisy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxPink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxButterfly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxBee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxDragon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxButterfly2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxFly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerStart
        '
        Me.TimerStart.Interval = 1000
        '
        'LblTimer
        '
        Me.LblTimer.AutoSize = True
        Me.LblTimer.BackColor = System.Drawing.Color.Transparent
        Me.LblTimer.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTimer.Location = New System.Drawing.Point(36, 530)
        Me.LblTimer.Name = "LblTimer"
        Me.LblTimer.Size = New System.Drawing.Size(18, 20)
        Me.LblTimer.TabIndex = 0
        Me.LblTimer.Text = "1"
        '
        'LblNum1
        '
        Me.LblNum1.AutoSize = True
        Me.LblNum1.BackColor = System.Drawing.Color.Transparent
        Me.LblNum1.Font = New System.Drawing.Font("Open Sans Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNum1.Location = New System.Drawing.Point(208, 224)
        Me.LblNum1.MinimumSize = New System.Drawing.Size(60, 0)
        Me.LblNum1.Name = "LblNum1"
        Me.LblNum1.Size = New System.Drawing.Size(60, 47)
        Me.LblNum1.TabIndex = 1
        Me.LblNum1.Text = "10"
        Me.LblNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtAns
        '
        Me.TxtAns.Font = New System.Drawing.Font("Open Sans Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAns.Location = New System.Drawing.Point(446, 224)
        Me.TxtAns.MaxLength = 5
        Me.TxtAns.MinimumSize = New System.Drawing.Size(88, 4)
        Me.TxtAns.Name = "TxtAns"
        Me.TxtAns.Size = New System.Drawing.Size(88, 51)
        Me.TxtAns.TabIndex = 2
        '
        'PBoxBlue
        '
        Me.PBoxBlue.BackColor = System.Drawing.Color.Transparent
        Me.PBoxBlue.BackgroundImage = CType(resources.GetObject("PBoxBlue.BackgroundImage"), System.Drawing.Image)
        Me.PBoxBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBoxBlue.Location = New System.Drawing.Point(560, 344)
        Me.PBoxBlue.Name = "PBoxBlue"
        Me.PBoxBlue.Size = New System.Drawing.Size(105, 138)
        Me.PBoxBlue.TabIndex = 3
        Me.PBoxBlue.TabStop = False
        '
        'PBoxSunFlower
        '
        Me.PBoxSunFlower.BackColor = System.Drawing.Color.Transparent
        Me.PBoxSunFlower.BackgroundImage = CType(resources.GetObject("PBoxSunFlower.BackgroundImage"), System.Drawing.Image)
        Me.PBoxSunFlower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBoxSunFlower.Location = New System.Drawing.Point(160, 364)
        Me.PBoxSunFlower.Name = "PBoxSunFlower"
        Me.PBoxSunFlower.Size = New System.Drawing.Size(105, 138)
        Me.PBoxSunFlower.TabIndex = 4
        Me.PBoxSunFlower.TabStop = False
        '
        'PBoxDaisy
        '
        Me.PBoxDaisy.BackColor = System.Drawing.Color.Transparent
        Me.PBoxDaisy.BackgroundImage = CType(resources.GetObject("PBoxDaisy.BackgroundImage"), System.Drawing.Image)
        Me.PBoxDaisy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBoxDaisy.Location = New System.Drawing.Point(427, 374)
        Me.PBoxDaisy.Name = "PBoxDaisy"
        Me.PBoxDaisy.Size = New System.Drawing.Size(88, 119)
        Me.PBoxDaisy.TabIndex = 5
        Me.PBoxDaisy.TabStop = False
        '
        'PBoxRed
        '
        Me.PBoxRed.BackColor = System.Drawing.Color.Transparent
        Me.PBoxRed.BackgroundImage = CType(resources.GetObject("PBoxRed.BackgroundImage"), System.Drawing.Image)
        Me.PBoxRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBoxRed.Location = New System.Drawing.Point(287, 325)
        Me.PBoxRed.Name = "PBoxRed"
        Me.PBoxRed.Size = New System.Drawing.Size(105, 138)
        Me.PBoxRed.TabIndex = 6
        Me.PBoxRed.TabStop = False
        '
        'PBoxPink
        '
        Me.PBoxPink.BackColor = System.Drawing.Color.Transparent
        Me.PBoxPink.BackgroundImage = CType(resources.GetObject("PBoxPink.BackgroundImage"), System.Drawing.Image)
        Me.PBoxPink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBoxPink.Location = New System.Drawing.Point(40, 325)
        Me.PBoxPink.Name = "PBoxPink"
        Me.PBoxPink.Size = New System.Drawing.Size(105, 138)
        Me.PBoxPink.TabIndex = 7
        Me.PBoxPink.TabStop = False
        '
        'LblNum2
        '
        Me.LblNum2.AutoSize = True
        Me.LblNum2.BackColor = System.Drawing.Color.Transparent
        Me.LblNum2.Font = New System.Drawing.Font("Open Sans Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNum2.Location = New System.Drawing.Point(326, 224)
        Me.LblNum2.MinimumSize = New System.Drawing.Size(60, 0)
        Me.LblNum2.Name = "LblNum2"
        Me.LblNum2.Size = New System.Drawing.Size(60, 47)
        Me.LblNum2.TabIndex = 8
        Me.LblNum2.Text = "10"
        Me.LblNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblOperation
        '
        Me.LblOperation.AutoSize = True
        Me.LblOperation.BackColor = System.Drawing.Color.Transparent
        Me.LblOperation.Font = New System.Drawing.Font("Open Sans Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOperation.Location = New System.Drawing.Point(280, 224)
        Me.LblOperation.Name = "LblOperation"
        Me.LblOperation.Size = New System.Drawing.Size(40, 47)
        Me.LblOperation.TabIndex = 9
        Me.LblOperation.Text = "+"
        Me.LblOperation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblEquals
        '
        Me.LblEquals.AutoSize = True
        Me.LblEquals.BackColor = System.Drawing.Color.Transparent
        Me.LblEquals.Font = New System.Drawing.Font("Open Sans Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEquals.Location = New System.Drawing.Point(400, 224)
        Me.LblEquals.Name = "LblEquals"
        Me.LblEquals.Size = New System.Drawing.Size(40, 47)
        Me.LblEquals.TabIndex = 10
        Me.LblEquals.Text = "="
        '
        'BtnCheck
        '
        Me.BtnCheck.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnCheck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCheck.FlatAppearance.BorderSize = 0
        Me.BtnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCheck.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCheck.Location = New System.Drawing.Point(548, 224)
        Me.BtnCheck.Name = "BtnCheck"
        Me.BtnCheck.Size = New System.Drawing.Size(78, 51)
        Me.BtnCheck.TabIndex = 11
        Me.BtnCheck.Text = "Check!"
        Me.BtnCheck.UseVisualStyleBackColor = False
        '
        'LblNum3
        '
        Me.LblNum3.AutoSize = True
        Me.LblNum3.BackColor = System.Drawing.Color.Transparent
        Me.LblNum3.Font = New System.Drawing.Font("Open Sans Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNum3.Location = New System.Drawing.Point(97, 224)
        Me.LblNum3.MinimumSize = New System.Drawing.Size(60, 0)
        Me.LblNum3.Name = "LblNum3"
        Me.LblNum3.Size = New System.Drawing.Size(60, 47)
        Me.LblNum3.TabIndex = 12
        Me.LblNum3.Text = "10"
        Me.LblNum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblNum3.Visible = False
        '
        'LblOperation2
        '
        Me.LblOperation2.AutoSize = True
        Me.LblOperation2.BackColor = System.Drawing.Color.Transparent
        Me.LblOperation2.Font = New System.Drawing.Font("Open Sans Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOperation2.Location = New System.Drawing.Point(162, 224)
        Me.LblOperation2.Name = "LblOperation2"
        Me.LblOperation2.Size = New System.Drawing.Size(40, 47)
        Me.LblOperation2.TabIndex = 13
        Me.LblOperation2.Text = "+"
        Me.LblOperation2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblOperation2.Visible = False
        '
        'LblBracket1
        '
        Me.LblBracket1.AutoSize = True
        Me.LblBracket1.BackColor = System.Drawing.Color.Transparent
        Me.LblBracket1.Font = New System.Drawing.Font("Open Sans Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBracket1.Location = New System.Drawing.Point(83, 222)
        Me.LblBracket1.Name = "LblBracket1"
        Me.LblBracket1.Size = New System.Drawing.Size(30, 47)
        Me.LblBracket1.TabIndex = 14
        Me.LblBracket1.Text = "("
        Me.LblBracket1.Visible = False
        '
        'LblBracket2
        '
        Me.LblBracket2.AutoSize = True
        Me.LblBracket2.BackColor = System.Drawing.Color.Transparent
        Me.LblBracket2.Font = New System.Drawing.Font("Open Sans Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBracket2.Location = New System.Drawing.Point(194, 222)
        Me.LblBracket2.Name = "LblBracket2"
        Me.LblBracket2.Size = New System.Drawing.Size(30, 47)
        Me.LblBracket2.TabIndex = 15
        Me.LblBracket2.Text = "("
        Me.LblBracket2.Visible = False
        '
        'LblBracket3
        '
        Me.LblBracket3.AutoSize = True
        Me.LblBracket3.BackColor = System.Drawing.Color.Transparent
        Me.LblBracket3.Font = New System.Drawing.Font("Open Sans Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBracket3.Location = New System.Drawing.Point(257, 222)
        Me.LblBracket3.Name = "LblBracket3"
        Me.LblBracket3.Size = New System.Drawing.Size(30, 47)
        Me.LblBracket3.TabIndex = 16
        Me.LblBracket3.Text = ")"
        Me.LblBracket3.Visible = False
        '
        'LblBracket4
        '
        Me.LblBracket4.AutoSize = True
        Me.LblBracket4.Font = New System.Drawing.Font("Open Sans Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBracket4.Location = New System.Drawing.Point(372, 222)
        Me.LblBracket4.Name = "LblBracket4"
        Me.LblBracket4.Size = New System.Drawing.Size(30, 47)
        Me.LblBracket4.TabIndex = 17
        Me.LblBracket4.Text = ")"
        Me.LblBracket4.Visible = False
        '
        'PBoxTimer
        '
        Me.PBoxTimer.BackColor = System.Drawing.Color.Transparent
        Me.PBoxTimer.BackgroundImage = CType(resources.GetObject("PBoxTimer.BackgroundImage"), System.Drawing.Image)
        Me.PBoxTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBoxTimer.Location = New System.Drawing.Point(3, 521)
        Me.PBoxTimer.Name = "PBoxTimer"
        Me.PBoxTimer.Size = New System.Drawing.Size(35, 36)
        Me.PBoxTimer.TabIndex = 19
        Me.PBoxTimer.TabStop = False
        '
        'PBoxCheck
        '
        Me.PBoxCheck.BackColor = System.Drawing.Color.Transparent
        Me.PBoxCheck.BackgroundImage = CType(resources.GetObject("PBoxCheck.BackgroundImage"), System.Drawing.Image)
        Me.PBoxCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBoxCheck.Location = New System.Drawing.Point(664, 521)
        Me.PBoxCheck.Name = "PBoxCheck"
        Me.PBoxCheck.Size = New System.Drawing.Size(35, 36)
        Me.PBoxCheck.TabIndex = 20
        Me.PBoxCheck.TabStop = False
        '
        'LblCorrect
        '
        Me.LblCorrect.AutoSize = True
        Me.LblCorrect.BackColor = System.Drawing.Color.Transparent
        Me.LblCorrect.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCorrect.Location = New System.Drawing.Point(643, 530)
        Me.LblCorrect.Name = "LblCorrect"
        Me.LblCorrect.Size = New System.Drawing.Size(22, 20)
        Me.LblCorrect.TabIndex = 21
        Me.LblCorrect.Text = " 0"
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
        Me.BtnBack.TabIndex = 22
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'LblFlower1
        '
        Me.LblFlower1.AutoSize = True
        Me.LblFlower1.BackColor = System.Drawing.Color.Transparent
        Me.LblFlower1.Font = New System.Drawing.Font("Open Sans Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFlower1.Location = New System.Drawing.Point(28, 304)
        Me.LblFlower1.MinimumSize = New System.Drawing.Size(135, 0)
        Me.LblFlower1.Name = "LblFlower1"
        Me.LblFlower1.Size = New System.Drawing.Size(145, 18)
        Me.LblFlower1.TabIndex = 24
        Me.LblFlower1.Text = "Can you be my friend?"
        Me.LblFlower1.Visible = False
        '
        'LblFlower2
        '
        Me.LblFlower2.AutoSize = True
        Me.LblFlower2.BackColor = System.Drawing.Color.Transparent
        Me.LblFlower2.Font = New System.Drawing.Font("Open Sans Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFlower2.Location = New System.Drawing.Point(143, 334)
        Me.LblFlower2.MinimumSize = New System.Drawing.Size(135, 0)
        Me.LblFlower2.Name = "LblFlower2"
        Me.LblFlower2.Size = New System.Drawing.Size(145, 18)
        Me.LblFlower2.TabIndex = 25
        Me.LblFlower2.Text = "Can you be my friend?"
        Me.LblFlower2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LblFlower2.Visible = False
        '
        'LblFlower3
        '
        Me.LblFlower3.AutoSize = True
        Me.LblFlower3.BackColor = System.Drawing.Color.Transparent
        Me.LblFlower3.Font = New System.Drawing.Font("Open Sans Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFlower3.Location = New System.Drawing.Point(273, 304)
        Me.LblFlower3.MinimumSize = New System.Drawing.Size(135, 0)
        Me.LblFlower3.Name = "LblFlower3"
        Me.LblFlower3.Size = New System.Drawing.Size(144, 18)
        Me.LblFlower3.TabIndex = 26
        Me.LblFlower3.Text = "Fantabulous, William!"
        Me.LblFlower3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LblFlower3.Visible = False
        '
        'LblFlower4
        '
        Me.LblFlower4.AutoSize = True
        Me.LblFlower4.BackColor = System.Drawing.Color.Transparent
        Me.LblFlower4.Font = New System.Drawing.Font("Open Sans Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFlower4.Location = New System.Drawing.Point(405, 353)
        Me.LblFlower4.MinimumSize = New System.Drawing.Size(135, 0)
        Me.LblFlower4.Name = "LblFlower4"
        Me.LblFlower4.Size = New System.Drawing.Size(145, 18)
        Me.LblFlower4.TabIndex = 27
        Me.LblFlower4.Text = "Can you be my friend?"
        Me.LblFlower4.Visible = False
        '
        'LblFlower5
        '
        Me.LblFlower5.AutoSize = True
        Me.LblFlower5.BackColor = System.Drawing.Color.Transparent
        Me.LblFlower5.Font = New System.Drawing.Font("Open Sans Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFlower5.Location = New System.Drawing.Point(545, 323)
        Me.LblFlower5.MinimumSize = New System.Drawing.Size(135, 0)
        Me.LblFlower5.Name = "LblFlower5"
        Me.LblFlower5.Size = New System.Drawing.Size(145, 18)
        Me.LblFlower5.TabIndex = 28
        Me.LblFlower5.Text = "Can you be my friend?"
        Me.LblFlower5.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LblFlower5.Visible = False
        '
        'TimerFlower
        '
        Me.TimerFlower.Interval = 1000
        '
        'BtnClose
        '
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Location = New System.Drawing.Point(648, 12)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(42, 34)
        Me.BtnClose.TabIndex = 29
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(702, 560)
        Me.ShapeContainer1.TabIndex = 30
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape1.BorderWidth = 5
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 153
        Me.LineShape1.X2 = 553
        Me.LineShape1.Y1 = 541
        Me.LineShape1.Y2 = 541
        '
        'PBoxButterfly
        '
        Me.PBoxButterfly.BackColor = System.Drawing.Color.Transparent
        Me.PBoxButterfly.BackgroundImage = CType(resources.GetObject("PBoxButterfly.BackgroundImage"), System.Drawing.Image)
        Me.PBoxButterfly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBoxButterfly.Location = New System.Drawing.Point(133, 515)
        Me.PBoxButterfly.Name = "PBoxButterfly"
        Me.PBoxButterfly.Size = New System.Drawing.Size(40, 40)
        Me.PBoxButterfly.TabIndex = 31
        Me.PBoxButterfly.TabStop = False
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(292, 20)
        Me.LblTitle.MinimumSize = New System.Drawing.Size(100, 0)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(100, 18)
        Me.LblTitle.TabIndex = 39
        Me.LblTitle.Text = "Math Game"
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
        'PBoxEnd
        '
        Me.PBoxEnd.BackColor = System.Drawing.Color.Transparent
        Me.PBoxEnd.BackgroundImage = CType(resources.GetObject("PBoxEnd.BackgroundImage"), System.Drawing.Image)
        Me.PBoxEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBoxEnd.Location = New System.Drawing.Point(548, 515)
        Me.PBoxEnd.Name = "PBoxEnd"
        Me.PBoxEnd.Size = New System.Drawing.Size(40, 40)
        Me.PBoxEnd.TabIndex = 41
        Me.PBoxEnd.TabStop = False
        '
        'PBoxBee
        '
        Me.PBoxBee.BackColor = System.Drawing.Color.Transparent
        Me.PBoxBee.BackgroundImage = CType(resources.GetObject("PBoxBee.BackgroundImage"), System.Drawing.Image)
        Me.PBoxBee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBoxBee.Location = New System.Drawing.Point(60, 124)
        Me.PBoxBee.Name = "PBoxBee"
        Me.PBoxBee.Size = New System.Drawing.Size(80, 48)
        Me.PBoxBee.TabIndex = 42
        Me.PBoxBee.TabStop = False
        '
        'PBoxDragon
        '
        Me.PBoxDragon.BackColor = System.Drawing.Color.Transparent
        Me.PBoxDragon.BackgroundImage = CType(resources.GetObject("PBoxDragon.BackgroundImage"), System.Drawing.Image)
        Me.PBoxDragon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBoxDragon.Location = New System.Drawing.Point(521, 64)
        Me.PBoxDragon.Name = "PBoxDragon"
        Me.PBoxDragon.Size = New System.Drawing.Size(114, 88)
        Me.PBoxDragon.TabIndex = 43
        Me.PBoxDragon.TabStop = False
        '
        'PBoxButterfly2
        '
        Me.PBoxButterfly2.BackColor = System.Drawing.Color.Transparent
        Me.PBoxButterfly2.BackgroundImage = CType(resources.GetObject("PBoxButterfly2.BackgroundImage"), System.Drawing.Image)
        Me.PBoxButterfly2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBoxButterfly2.Location = New System.Drawing.Point(202, 53)
        Me.PBoxButterfly2.Name = "PBoxButterfly2"
        Me.PBoxButterfly2.Size = New System.Drawing.Size(101, 78)
        Me.PBoxButterfly2.TabIndex = 44
        Me.PBoxButterfly2.TabStop = False
        '
        'PBoxFly
        '
        Me.PBoxFly.BackColor = System.Drawing.Color.Transparent
        Me.PBoxFly.BackgroundImage = CType(resources.GetObject("PBoxFly.BackgroundImage"), System.Drawing.Image)
        Me.PBoxFly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBoxFly.Location = New System.Drawing.Point(375, 122)
        Me.PBoxFly.Name = "PBoxFly"
        Me.PBoxFly.Size = New System.Drawing.Size(100, 50)
        Me.PBoxFly.TabIndex = 45
        Me.PBoxFly.TabStop = False
        '
        'LblInsect1
        '
        Me.LblInsect1.AutoSize = True
        Me.LblInsect1.Font = New System.Drawing.Font("Open Sans Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInsect1.Location = New System.Drawing.Point(180, 154)
        Me.LblInsect1.MinimumSize = New System.Drawing.Size(148, 0)
        Me.LblInsect1.Name = "LblInsect1"
        Me.LblInsect1.Size = New System.Drawing.Size(148, 18)
        Me.LblInsect1.TabIndex = 46
        Me.LblInsect1.Text = "good job, hhhhhhhhhh"
        Me.LblInsect1.Visible = False
        '
        'LblInsect2
        '
        Me.LblInsect2.AutoSize = True
        Me.LblInsect2.BackColor = System.Drawing.Color.Transparent
        Me.LblInsect2.Font = New System.Drawing.Font("Open Sans Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInsect2.Location = New System.Drawing.Point(347, 82)
        Me.LblInsect2.MinimumSize = New System.Drawing.Size(150, 0)
        Me.LblInsect2.Name = "LblInsect2"
        Me.LblInsect2.Size = New System.Drawing.Size(150, 18)
        Me.LblInsect2.TabIndex = 47
        Me.LblInsect2.Text = "Good job, hhhhhhhhhh"
        Me.LblInsect2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LblInsect2.Visible = False
        '
        'BtnReplay
        '
        Me.BtnReplay.BackgroundImage = CType(resources.GetObject("BtnReplay.BackgroundImage"), System.Drawing.Image)
        Me.BtnReplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnReplay.FlatAppearance.BorderSize = 0
        Me.BtnReplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReplay.Location = New System.Drawing.Point(600, 12)
        Me.BtnReplay.Name = "BtnReplay"
        Me.BtnReplay.Size = New System.Drawing.Size(42, 34)
        Me.BtnReplay.TabIndex = 48
        Me.BtnReplay.UseVisualStyleBackColor = True
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
        'ImgListEnd
        '
        Me.ImgListEnd.ImageStream = CType(resources.GetObject("ImgListEnd.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgListEnd.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgListEnd.Images.SetKeyName(0, "PurpleFlower.png")
        Me.ImgListEnd.Images.SetKeyName(1, "raceflag1.png")
        Me.ImgListEnd.Images.SetKeyName(2, "Beehive.png")
        Me.ImgListEnd.Images.SetKeyName(3, "spiderweb2.png")
        Me.ImgListEnd.Images.SetKeyName(4, "lettuceleaf.png")
        '
        'MathGame
        '
        Me.AcceptButton = Me.BtnCheck
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.BtnBack
        Me.ClientSize = New System.Drawing.Size(702, 560)
        Me.Controls.Add(Me.BtnReplay)
        Me.Controls.Add(Me.LblInsect2)
        Me.Controls.Add(Me.LblInsect1)
        Me.Controls.Add(Me.PBoxFly)
        Me.Controls.Add(Me.PBoxButterfly2)
        Me.Controls.Add(Me.PBoxDragon)
        Me.Controls.Add(Me.BtnMinimize)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.LblFlower5)
        Me.Controls.Add(Me.LblFlower4)
        Me.Controls.Add(Me.LblFlower3)
        Me.Controls.Add(Me.LblFlower2)
        Me.Controls.Add(Me.LblFlower1)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.LblCorrect)
        Me.Controls.Add(Me.PBoxCheck)
        Me.Controls.Add(Me.PBoxTimer)
        Me.Controls.Add(Me.LblBracket4)
        Me.Controls.Add(Me.LblBracket3)
        Me.Controls.Add(Me.LblBracket2)
        Me.Controls.Add(Me.LblBracket1)
        Me.Controls.Add(Me.LblOperation2)
        Me.Controls.Add(Me.LblNum3)
        Me.Controls.Add(Me.BtnCheck)
        Me.Controls.Add(Me.LblEquals)
        Me.Controls.Add(Me.LblOperation)
        Me.Controls.Add(Me.LblNum2)
        Me.Controls.Add(Me.PBoxPink)
        Me.Controls.Add(Me.PBoxDaisy)
        Me.Controls.Add(Me.PBoxBlue)
        Me.Controls.Add(Me.TxtAns)
        Me.Controls.Add(Me.LblNum1)
        Me.Controls.Add(Me.LblTimer)
        Me.Controls.Add(Me.PBoxRed)
        Me.Controls.Add(Me.PBoxSunFlower)
        Me.Controls.Add(Me.PBoxButterfly)
        Me.Controls.Add(Me.PBoxEnd)
        Me.Controls.Add(Me.PBoxBee)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MathGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Florithmetic"
        Me.TransparencyKey = System.Drawing.Color.Red
        CType(Me.PBoxBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxSunFlower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxDaisy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxPink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxTimer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxButterfly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxBee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxDragon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxButterfly2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxFly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimerStart As System.Windows.Forms.Timer
    Friend WithEvents LblTimer As System.Windows.Forms.Label
    Friend WithEvents LblNum1 As System.Windows.Forms.Label
    Friend WithEvents TxtAns As System.Windows.Forms.TextBox
    Friend WithEvents PBoxBlue As System.Windows.Forms.PictureBox
    Friend WithEvents PBoxSunFlower As System.Windows.Forms.PictureBox
    Friend WithEvents PBoxDaisy As System.Windows.Forms.PictureBox
    Friend WithEvents PBoxRed As System.Windows.Forms.PictureBox
    Friend WithEvents PBoxPink As System.Windows.Forms.PictureBox
    Friend WithEvents LblNum2 As System.Windows.Forms.Label
    Friend WithEvents LblOperation As System.Windows.Forms.Label
    Friend WithEvents LblEquals As System.Windows.Forms.Label
    Friend WithEvents BtnCheck As System.Windows.Forms.Button
    Friend WithEvents LblNum3 As System.Windows.Forms.Label
    Friend WithEvents LblOperation2 As System.Windows.Forms.Label
    Friend WithEvents LblBracket1 As System.Windows.Forms.Label
    Friend WithEvents LblBracket2 As System.Windows.Forms.Label
    Friend WithEvents LblBracket3 As System.Windows.Forms.Label
    Friend WithEvents LblBracket4 As System.Windows.Forms.Label
    Friend WithEvents PBoxTimer As System.Windows.Forms.PictureBox
    Friend WithEvents PBoxCheck As System.Windows.Forms.PictureBox
    Friend WithEvents LblCorrect As System.Windows.Forms.Label
    Friend WithEvents BtnBack As System.Windows.Forms.Button
    Friend WithEvents LblFlower1 As System.Windows.Forms.Label
    Friend WithEvents LblFlower2 As System.Windows.Forms.Label
    Friend WithEvents LblFlower3 As System.Windows.Forms.Label
    Friend WithEvents LblFlower4 As System.Windows.Forms.Label
    Friend WithEvents LblFlower5 As System.Windows.Forms.Label
    Friend WithEvents TimerFlower As System.Windows.Forms.Timer
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents PBoxButterfly As System.Windows.Forms.PictureBox
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents BtnMinimize As System.Windows.Forms.Button
    Friend WithEvents PBoxEnd As System.Windows.Forms.PictureBox
    Friend WithEvents PBoxBee As System.Windows.Forms.PictureBox
    Friend WithEvents PBoxDragon As System.Windows.Forms.PictureBox
    Friend WithEvents PBoxButterfly2 As System.Windows.Forms.PictureBox
    Friend WithEvents PBoxFly As System.Windows.Forms.PictureBox
    Friend WithEvents LblInsect1 As System.Windows.Forms.Label
    Friend WithEvents LblInsect2 As System.Windows.Forms.Label
    Friend WithEvents BtnReplay As System.Windows.Forms.Button
    Friend WithEvents ImgListBugs As System.Windows.Forms.ImageList
    Friend WithEvents ImgListEnd As System.Windows.Forms.ImageList

End Class
