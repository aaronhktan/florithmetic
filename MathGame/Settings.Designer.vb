<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.TBarTime = New System.Windows.Forms.TrackBar()
        Me.CBoxMusic = New System.Windows.Forms.CheckBox()
        Me.CBoxSFX = New System.Windows.Forms.CheckBox()
        Me.ComBoxBack = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl30 = New System.Windows.Forms.Label()
        Me.Lbl180 = New System.Windows.Forms.Label()
        CType(Me.TBarTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BtnBack.TabIndex = 32
        Me.BtnBack.UseVisualStyleBackColor = False
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
        Me.LblTitle.TabIndex = 39
        Me.LblTitle.Text = "Settings"
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TBarTime
        '
        Me.TBarTime.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TBarTime.LargeChange = 2
        Me.TBarTime.Location = New System.Drawing.Point(155, 100)
        Me.TBarTime.Maximum = 5
        Me.TBarTime.Name = "TBarTime"
        Me.TBarTime.Size = New System.Drawing.Size(180, 45)
        Me.TBarTime.TabIndex = 40
        Me.TBarTime.Value = 1
        '
        'CBoxMusic
        '
        Me.CBoxMusic.AutoSize = True
        Me.CBoxMusic.Checked = True
        Me.CBoxMusic.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBoxMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBoxMusic.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBoxMusic.Location = New System.Drawing.Point(218, 159)
        Me.CBoxMusic.MinimumSize = New System.Drawing.Size(62, 0)
        Me.CBoxMusic.Name = "CBoxMusic"
        Me.CBoxMusic.Size = New System.Drawing.Size(62, 21)
        Me.CBoxMusic.TabIndex = 41
        Me.CBoxMusic.Text = "Music"
        Me.CBoxMusic.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CBoxMusic.UseVisualStyleBackColor = True
        '
        'CBoxSFX
        '
        Me.CBoxSFX.AutoSize = True
        Me.CBoxSFX.Checked = True
        Me.CBoxSFX.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBoxSFX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBoxSFX.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBoxSFX.Location = New System.Drawing.Point(207, 187)
        Me.CBoxSFX.MinimumSize = New System.Drawing.Size(84, 0)
        Me.CBoxSFX.Name = "CBoxSFX"
        Me.CBoxSFX.Size = New System.Drawing.Size(84, 21)
        Me.CBoxSFX.TabIndex = 42
        Me.CBoxSFX.Text = "Sound FX"
        Me.CBoxSFX.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CBoxSFX.UseVisualStyleBackColor = True
        '
        'ComBoxBack
        '
        Me.ComBoxBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComBoxBack.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComBoxBack.FormattingEnabled = True
        Me.ComBoxBack.Items.AddRange(New Object() {"Sky Blue", "Deep Sky Blue", "Light Sky Blue", "Blue"})
        Me.ComBoxBack.Location = New System.Drawing.Point(188, 253)
        Me.ComBoxBack.Name = "ComBoxBack"
        Me.ComBoxBack.Size = New System.Drawing.Size(125, 25)
        Me.ComBoxBack.TabIndex = 43
        Me.ComBoxBack.Text = "Sky Blue"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(207, 71)
        Me.Label1.MinimumSize = New System.Drawing.Size(83, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 18)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Timer length"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Open Sans Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(225, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 18)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Sound"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Open Sans Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(185, 224)
        Me.Label3.MinimumSize = New System.Drawing.Size(128, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 18)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Background Colour"
        '
        'Lbl30
        '
        Me.Lbl30.AutoSize = True
        Me.Lbl30.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl30.Location = New System.Drawing.Point(136, 100)
        Me.Lbl30.Name = "Lbl30"
        Me.Lbl30.Size = New System.Drawing.Size(22, 17)
        Me.Lbl30.TabIndex = 47
        Me.Lbl30.Text = "30"
        Me.Lbl30.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Lbl180
        '
        Me.Lbl180.AutoSize = True
        Me.Lbl180.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl180.Location = New System.Drawing.Point(334, 100)
        Me.Lbl180.Name = "Lbl180"
        Me.Lbl180.Size = New System.Drawing.Size(29, 17)
        Me.Lbl180.TabIndex = 48
        Me.Lbl180.Text = "180"
        Me.Lbl180.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Settings
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(498, 305)
        Me.Controls.Add(Me.Lbl180)
        Me.Controls.Add(Me.Lbl30)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComBoxBack)
        Me.Controls.Add(Me.CBoxSFX)
        Me.Controls.Add(Me.CBoxMusic)
        Me.Controls.Add(Me.TBarTime)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.BtnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        CType(Me.TBarTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnBack As System.Windows.Forms.Button
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents TBarTime As System.Windows.Forms.TrackBar
    Friend WithEvents CBoxMusic As System.Windows.Forms.CheckBox
    Friend WithEvents CBoxSFX As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lbl30 As System.Windows.Forms.Label
    Friend WithEvents Lbl180 As System.Windows.Forms.Label
    Friend WithEvents ComBoxBack As System.Windows.Forms.ComboBox
End Class
