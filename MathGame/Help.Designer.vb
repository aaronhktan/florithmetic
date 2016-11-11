<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Help))
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.PBoxxkcd = New System.Windows.Forms.PictureBox()
        Me.LblContact = New System.Windows.Forms.Label()
        CType(Me.PBoxxkcd, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BtnBack.TabIndex = 42
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(153, 20)
        Me.LblTitle.MinimumSize = New System.Drawing.Size(200, 0)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(200, 18)
        Me.LblTitle.TabIndex = 43
        Me.LblTitle.Text = "Help"
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PBoxxkcd
        '
        Me.PBoxxkcd.BackgroundImage = CType(resources.GetObject("PBoxxkcd.BackgroundImage"), System.Drawing.Image)
        Me.PBoxxkcd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBoxxkcd.Location = New System.Drawing.Point(85, 60)
        Me.PBoxxkcd.Name = "PBoxxkcd"
        Me.PBoxxkcd.Size = New System.Drawing.Size(327, 144)
        Me.PBoxxkcd.TabIndex = 44
        Me.PBoxxkcd.TabStop = False
        '
        'LblContact
        '
        Me.LblContact.AutoSize = True
        Me.LblContact.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContact.Location = New System.Drawing.Point(115, 215)
        Me.LblContact.Name = "LblContact"
        Me.LblContact.Size = New System.Drawing.Size(267, 75)
        Me.LblContact.TabIndex = 45
        Me.LblContact.Text = "Have you found something that makes the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "pattern of lights go all wrong?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cont" & _
    "act Aaron at cheeseisdisgusting@gmail.com, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and get an entry into the credits a" & _
    "s a bug reporter!"
        Me.LblContact.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Help
        '
        Me.AcceptButton = Me.BtnBack
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.BtnBack
        Me.ClientSize = New System.Drawing.Size(498, 305)
        Me.Controls.Add(Me.LblContact)
        Me.Controls.Add(Me.PBoxxkcd)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.BtnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Help"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help"
        CType(Me.PBoxxkcd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnBack As System.Windows.Forms.Button
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents PBoxxkcd As System.Windows.Forms.PictureBox
    Friend WithEvents LblContact As System.Windows.Forms.Label
End Class
