<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EndGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EndGame))
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.LblEnd = New System.Windows.Forms.Label()
        Me.LblCorrect = New System.Windows.Forms.Label()
        Me.LblIncorrect = New System.Windows.Forms.Label()
        Me.LblPercentage = New System.Windows.Forms.Label()
        Me.LblMessage = New System.Windows.Forms.Label()
        Me.BtnMinimize = New System.Windows.Forms.Button()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnReplay = New System.Windows.Forms.Button()
        Me.LblAverage = New System.Windows.Forms.Label()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.LblAnswered = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Location = New System.Drawing.Point(444, 12)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(42, 34)
        Me.BtnClose.TabIndex = 31
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.Transparent
        Me.BtnBack.BackgroundImage = CType(resources.GetObject("BtnBack.BackgroundImage"), System.Drawing.Image)
        Me.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnBack.FlatAppearance.BorderSize = 0
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBack.Location = New System.Drawing.Point(12, 12)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(42, 34)
        Me.BtnBack.TabIndex = 30
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'LblEnd
        '
        Me.LblEnd.AutoSize = True
        Me.LblEnd.BackColor = System.Drawing.Color.Transparent
        Me.LblEnd.Font = New System.Drawing.Font("Open Sans Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEnd.Location = New System.Drawing.Point(49, 80)
        Me.LblEnd.MinimumSize = New System.Drawing.Size(400, 0)
        Me.LblEnd.Name = "LblEnd"
        Me.LblEnd.Size = New System.Drawing.Size(400, 37)
        Me.LblEnd.TabIndex = 32
        Me.LblEnd.Text = "Label1"
        Me.LblEnd.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblCorrect
        '
        Me.LblCorrect.AutoSize = True
        Me.LblCorrect.BackColor = System.Drawing.Color.Transparent
        Me.LblCorrect.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCorrect.Location = New System.Drawing.Point(91, 184)
        Me.LblCorrect.MinimumSize = New System.Drawing.Size(150, 0)
        Me.LblCorrect.Name = "LblCorrect"
        Me.LblCorrect.Size = New System.Drawing.Size(150, 18)
        Me.LblCorrect.TabIndex = 33
        Me.LblCorrect.Text = "Label1"
        '
        'LblIncorrect
        '
        Me.LblIncorrect.AutoSize = True
        Me.LblIncorrect.BackColor = System.Drawing.Color.Transparent
        Me.LblIncorrect.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIncorrect.Location = New System.Drawing.Point(91, 213)
        Me.LblIncorrect.MinimumSize = New System.Drawing.Size(150, 0)
        Me.LblIncorrect.Name = "LblIncorrect"
        Me.LblIncorrect.Size = New System.Drawing.Size(150, 18)
        Me.LblIncorrect.TabIndex = 34
        Me.LblIncorrect.Text = "Label1"
        '
        'LblPercentage
        '
        Me.LblPercentage.AutoSize = True
        Me.LblPercentage.BackColor = System.Drawing.Color.Transparent
        Me.LblPercentage.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPercentage.Location = New System.Drawing.Point(91, 244)
        Me.LblPercentage.MinimumSize = New System.Drawing.Size(150, 0)
        Me.LblPercentage.Name = "LblPercentage"
        Me.LblPercentage.Size = New System.Drawing.Size(150, 18)
        Me.LblPercentage.TabIndex = 35
        Me.LblPercentage.Text = "Label1"
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.BackColor = System.Drawing.Color.Transparent
        Me.LblMessage.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblMessage.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMessage.Location = New System.Drawing.Point(0, 139)
        Me.LblMessage.MinimumSize = New System.Drawing.Size(498, 0)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Size = New System.Drawing.Size(498, 22)
        Me.LblMessage.TabIndex = 36
        Me.LblMessage.Text = "Label1"
        Me.LblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnMinimize
        '
        Me.BtnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.BtnMinimize.BackgroundImage = CType(resources.GetObject("BtnMinimize.BackgroundImage"), System.Drawing.Image)
        Me.BtnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnMinimize.FlatAppearance.BorderSize = 0
        Me.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimize.Location = New System.Drawing.Point(60, 12)
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.Size = New System.Drawing.Size(42, 34)
        Me.BtnMinimize.TabIndex = 37
        Me.BtnMinimize.UseVisualStyleBackColor = False
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.BackColor = System.Drawing.Color.Transparent
        Me.LblTitle.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(149, 20)
        Me.LblTitle.MinimumSize = New System.Drawing.Size(200, 0)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(200, 18)
        Me.LblTitle.TabIndex = 38
        Me.LblTitle.Text = "Score"
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnReplay
        '
        Me.BtnReplay.BackColor = System.Drawing.Color.Transparent
        Me.BtnReplay.BackgroundImage = CType(resources.GetObject("BtnReplay.BackgroundImage"), System.Drawing.Image)
        Me.BtnReplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnReplay.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnReplay.FlatAppearance.BorderSize = 0
        Me.BtnReplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReplay.Location = New System.Drawing.Point(396, 12)
        Me.BtnReplay.Name = "BtnReplay"
        Me.BtnReplay.Size = New System.Drawing.Size(42, 34)
        Me.BtnReplay.TabIndex = 40
        Me.BtnReplay.UseVisualStyleBackColor = False
        '
        'LblAverage
        '
        Me.LblAverage.AutoSize = True
        Me.LblAverage.BackColor = System.Drawing.Color.Transparent
        Me.LblAverage.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAverage.Location = New System.Drawing.Point(247, 244)
        Me.LblAverage.MinimumSize = New System.Drawing.Size(150, 0)
        Me.LblAverage.Name = "LblAverage"
        Me.LblAverage.Size = New System.Drawing.Size(150, 18)
        Me.LblAverage.TabIndex = 43
        Me.LblAverage.Text = "Label1"
        '
        'LblTime
        '
        Me.LblTime.AutoSize = True
        Me.LblTime.BackColor = System.Drawing.Color.Transparent
        Me.LblTime.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTime.Location = New System.Drawing.Point(247, 213)
        Me.LblTime.MinimumSize = New System.Drawing.Size(150, 0)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(150, 18)
        Me.LblTime.TabIndex = 42
        Me.LblTime.Text = "Label1"
        '
        'LblAnswered
        '
        Me.LblAnswered.AutoSize = True
        Me.LblAnswered.BackColor = System.Drawing.Color.Transparent
        Me.LblAnswered.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAnswered.Location = New System.Drawing.Point(247, 183)
        Me.LblAnswered.MinimumSize = New System.Drawing.Size(150, 0)
        Me.LblAnswered.Name = "LblAnswered"
        Me.LblAnswered.Size = New System.Drawing.Size(150, 18)
        Me.LblAnswered.TabIndex = 41
        Me.LblAnswered.Text = "Label1"
        '
        'EndGame
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CancelButton = Me.BtnBack
        Me.ClientSize = New System.Drawing.Size(498, 305)
        Me.Controls.Add(Me.LblAverage)
        Me.Controls.Add(Me.LblTime)
        Me.Controls.Add(Me.LblAnswered)
        Me.Controls.Add(Me.BtnReplay)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.BtnMinimize)
        Me.Controls.Add(Me.LblMessage)
        Me.Controls.Add(Me.LblPercentage)
        Me.Controls.Add(Me.LblIncorrect)
        Me.Controls.Add(Me.LblCorrect)
        Me.Controls.Add(Me.LblEnd)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnBack)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EndGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Score"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnBack As System.Windows.Forms.Button
    Friend WithEvents LblEnd As System.Windows.Forms.Label
    Friend WithEvents LblCorrect As System.Windows.Forms.Label
    Friend WithEvents LblIncorrect As System.Windows.Forms.Label
    Friend WithEvents LblPercentage As System.Windows.Forms.Label
    Friend WithEvents LblMessage As System.Windows.Forms.Label
    Friend WithEvents BtnMinimize As System.Windows.Forms.Button
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents BtnReplay As System.Windows.Forms.Button
    Friend WithEvents LblAverage As System.Windows.Forms.Label
    Friend WithEvents LblTime As System.Windows.Forms.Label
    Friend WithEvents LblAnswered As System.Windows.Forms.Label
End Class
