<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LevelChooser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LevelChooser))
        Me.LblInstruct = New System.Windows.Forms.Label()
        Me.BtnEasy = New System.Windows.Forms.Button()
        Me.BtnMedium = New System.Windows.Forms.Button()
        Me.BtnHard = New System.Windows.Forms.Button()
        Me.LblEasy = New System.Windows.Forms.Label()
        Me.LblMedium = New System.Windows.Forms.Label()
        Me.LblHard = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnMinimize = New System.Windows.Forms.Button()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblInstruct
        '
        Me.LblInstruct.AutoSize = True
        Me.LblInstruct.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInstruct.Location = New System.Drawing.Point(254, 75)
        Me.LblInstruct.Name = "LblInstruct"
        Me.LblInstruct.Size = New System.Drawing.Size(210, 17)
        Me.LblInstruct.TabIndex = 4
        Me.LblInstruct.Text = "Click on a butterfly to choose a level!"
        '
        'BtnEasy
        '
        Me.BtnEasy.BackgroundImage = CType(resources.GetObject("BtnEasy.BackgroundImage"), System.Drawing.Image)
        Me.BtnEasy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnEasy.FlatAppearance.BorderSize = 0
        Me.BtnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEasy.Location = New System.Drawing.Point(117, 149)
        Me.BtnEasy.Name = "BtnEasy"
        Me.BtnEasy.Size = New System.Drawing.Size(104, 99)
        Me.BtnEasy.TabIndex = 6
        Me.BtnEasy.UseVisualStyleBackColor = True
        '
        'BtnMedium
        '
        Me.BtnMedium.BackgroundImage = CType(resources.GetObject("BtnMedium.BackgroundImage"), System.Drawing.Image)
        Me.BtnMedium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnMedium.FlatAppearance.BorderSize = 0
        Me.BtnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMedium.Location = New System.Drawing.Point(312, 149)
        Me.BtnMedium.Name = "BtnMedium"
        Me.BtnMedium.Size = New System.Drawing.Size(102, 99)
        Me.BtnMedium.TabIndex = 7
        Me.BtnMedium.UseVisualStyleBackColor = True
        '
        'BtnHard
        '
        Me.BtnHard.BackgroundImage = CType(resources.GetObject("BtnHard.BackgroundImage"), System.Drawing.Image)
        Me.BtnHard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnHard.FlatAppearance.BorderSize = 0
        Me.BtnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHard.Location = New System.Drawing.Point(507, 149)
        Me.BtnHard.Name = "BtnHard"
        Me.BtnHard.Size = New System.Drawing.Size(106, 99)
        Me.BtnHard.TabIndex = 8
        Me.BtnHard.UseVisualStyleBackColor = True
        '
        'LblEasy
        '
        Me.LblEasy.AutoSize = True
        Me.LblEasy.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEasy.Location = New System.Drawing.Point(151, 251)
        Me.LblEasy.Name = "LblEasy"
        Me.LblEasy.Size = New System.Drawing.Size(34, 17)
        Me.LblEasy.TabIndex = 9
        Me.LblEasy.Text = "Easy"
        '
        'LblMedium
        '
        Me.LblMedium.AutoSize = True
        Me.LblMedium.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMedium.Location = New System.Drawing.Point(335, 251)
        Me.LblMedium.Name = "LblMedium"
        Me.LblMedium.Size = New System.Drawing.Size(54, 17)
        Me.LblMedium.TabIndex = 10
        Me.LblMedium.Text = "Medium"
        '
        'LblHard
        '
        Me.LblHard.AutoSize = True
        Me.LblHard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHard.Location = New System.Drawing.Point(542, 251)
        Me.LblHard.Name = "LblHard"
        Me.LblHard.Size = New System.Drawing.Size(34, 15)
        Me.LblHard.TabIndex = 11
        Me.LblHard.Text = "Hard"
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
        'BtnMinimize
        '
        Me.BtnMinimize.BackgroundImage = CType(resources.GetObject("BtnMinimize.BackgroundImage"), System.Drawing.Image)
        Me.BtnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnMinimize.FlatAppearance.BorderSize = 0
        Me.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimize.Location = New System.Drawing.Point(60, 12)
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.Size = New System.Drawing.Size(42, 34)
        Me.BtnMinimize.TabIndex = 38
        Me.BtnMinimize.UseVisualStyleBackColor = True
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
        Me.LblTitle.Text = "Level Picker"
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LevelChooser
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(733, 465)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.BtnMinimize)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.LblHard)
        Me.Controls.Add(Me.LblMedium)
        Me.Controls.Add(Me.LblEasy)
        Me.Controls.Add(Me.BtnHard)
        Me.Controls.Add(Me.BtnMedium)
        Me.Controls.Add(Me.BtnEasy)
        Me.Controls.Add(Me.LblInstruct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LevelChooser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Level Picker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblInstruct As System.Windows.Forms.Label
    Friend WithEvents BtnEasy As System.Windows.Forms.Button
    Friend WithEvents BtnMedium As System.Windows.Forms.Button
    Friend WithEvents BtnHard As System.Windows.Forms.Button
    Friend WithEvents LblEasy As System.Windows.Forms.Label
    Friend WithEvents LblMedium As System.Windows.Forms.Label
    Friend WithEvents LblHard As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnBack As System.Windows.Forms.Button
    Friend WithEvents BtnMinimize As System.Windows.Forms.Button
    Friend WithEvents LblTitle As System.Windows.Forms.Label
End Class
