'This is the main menu of the game; it allows users to choose where they want to navigate.
'Created by Aaron Tan, 2014-11-14

Public Class MainSplash
    Dim Timer1 As Integer
    Dim Timer2 As Integer
    Dim Timer3 As Integer
    Dim Timer4 As Integer
    Dim DragonflyX As Integer
    Dim DragonflyY As Integer
    Dim MouseX As Integer
    Dim MouseY As Integer
    Dim Drag As Boolean
    Dim LoadTimes As Integer

    'Allows for dragging of borderless form
    Private Sub MathGame_Mousedown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Drag = True
        MouseX = Windows.Forms.Cursor.Position.X - Me.Left
        MouseY = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub MathGame_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If Drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - MouseY
            Me.Left = Windows.Forms.Cursor.Position.X - MouseX
        End If
    End Sub

    Private Sub MathGame_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        Drag = False
    End Sub

    Private Sub MathGame_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.Click
        Settings.Hide()
        Credits.Hide()
        Help.Hide()
    End Sub

    'Highlights both the text and button
    Private Sub BtnPlay_MouseOver(Sender As Object, e As EventArgs) Handles BtnPlay.MouseEnter
        BtnGo1.BackColor = Color.Gainsboro
    End Sub

    Private Sub BtnPlay_MouseLeave(Sender As Object, e As EventArgs) Handles BtnPlay.MouseLeave
        BtnGo1.BackColor = Color.Transparent
    End Sub

    Private Sub BtnSettings_MouseEnter(Sender As Object, e As EventArgs) Handles BtnSettings.MouseEnter
        BtnGo2.BackColor = Color.Gainsboro
    End Sub

    Private Sub BtnSettings_MouseLeave(Sender As Object, e As EventArgs) Handles BtnSettings.MouseLeave
        BtnGo2.BackColor = Color.Transparent
    End Sub

    Private Sub BtnCredits_MouseEnter(Sender As Object, e As EventArgs) Handles BtnCredits.MouseEnter
        BtnGo3.BackColor = Color.Gainsboro
    End Sub

    Private Sub BtnCredits_MouseLeave(Sender As Object, e As EventArgs) Handles BtnCredits.MouseLeave
        BtnGo3.BackColor = Color.Transparent
    End Sub

    Private Sub BtnGo1_MouseOver(Sender As Object, e As EventArgs) Handles BtnGo1.MouseEnter
        BtnPlay.BackColor = Color.Gainsboro
    End Sub

    Private Sub BtnGo1_MouseLeave(Sender As Object, e As EventArgs) Handles BtnGo1.MouseLeave
        BtnPlay.BackColor = Color.Transparent
    End Sub

    Private Sub BtnGo2_MouseEnter(Sender As Object, e As EventArgs) Handles BtnGo2.MouseEnter
        BtnSettings.BackColor = Color.Gainsboro
    End Sub

    Private Sub BtnGo2_MouseLeave(Sender As Object, e As EventArgs) Handles BtnGo2.MouseLeave
        BtnSettings.BackColor = Color.Transparent
    End Sub

    Private Sub BtnGo3_MouseEnter(Sender As Object, e As EventArgs) Handles BtnGo3.MouseEnter
        BtnCredits.BackColor = Color.Gainsboro
    End Sub

    Private Sub BtnGo3_MouseLeave(Sender As Object, e As EventArgs) Handles BtnGo3.MouseLeave
        BtnCredits.BackColor = Color.Transparent
    End Sub

    Private Sub MainSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTimes = LoadTimes + 1 'Variable used to determine whether first time loading
        TimerBee.Start() 'Controls movement of bee
        TimerSpider.Start() 'Controls movement of spider
        TimerButterfly.Start() 'Controls movement of butterfly
        TimerDragon.Start() 'Controls movement of dragonfly
        PBoxInsect.Location = New Point(1, 168) 'Sets insect locations
        PBoxSpider.Location = New Point(617, 324)
        PBoxButterfly.Location = New Point(186, 40)
        PBoxDragonfly.Location = New Point(699, 221)
        My.Computer.Audio.Play(My.Resources.Receives, _
        AudioPlayMode.BackgroundLoop) 'Plays background music on launch
        If LoadTimes = 1 Then 'Sets default settings
            Settings.TimerLength = 60
            Settings.Background = 1
            Settings.Music = True
        End If
    End Sub

    'Controls path of bee
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerBee.Tick
        Timer1 = Timer1 + 1
        Select Case Timer1
            Case 1 To 35
                PBoxInsect.Location = New Point(PBoxInsect.Location.X + 2, PBoxInsect.Location.Y + 0.5)
            Case 36 To 110
                PBoxInsect.Location = New Point(PBoxInsect.Location.X + 4, PBoxInsect.Location.Y + 1)
            Case 111 To 150
                PBoxInsect.Location = New Point(PBoxInsect.Location.X + 2, PBoxInsect.Location.Y - 1)
            Case 151 To 210
                PBoxInsect.Location = New Point(PBoxInsect.Location.X + 3, PBoxInsect.Location.Y)
            Case Else
                PBoxInsect.Location = New Point(PBoxInsect.Location.X + 5, PBoxInsect.Location.Y - 3)
        End Select
        If Timer1 = 300 Then 'Restarts cycle
            PBoxInsect.Location = New Point(1, 168)
            Timer1 = 0
            TimerBee.Stop()
            TimerBee.Start()
        End If
    End Sub

    'Controls path of spider
    Private Sub TimerSpider_Tick(sender As Object, e As EventArgs) Handles TimerSpider.Tick
        Timer2 = Timer2 + 1
        Select Case Timer2
            Case 1 To 29
                PBoxSpider.Location = New Point(PBoxSpider.Location.X + 1, PBoxSpider.Location.Y + 1)
            Case 30 To 59
                PBoxSpider.Location = New Point(PBoxSpider.Location.X - 1, PBoxSpider.Location.Y - 0.5)
            Case 60 To 85
                PBoxSpider.Location = New Point(PBoxSpider.Location.X, PBoxSpider.Location.Y - 1)
            Case Else 'Case >85
                PBoxSpider.Location = New Point(617, 324)
                Timer2 = 0
        End Select
    End Sub

    'Controls path of butterfly
    Private Sub TimerButterfly_Tick(sender As Object, e As EventArgs) Handles TimerButterfly.Tick
        Timer3 = Timer3 + 1
        Select Case Timer3
            Case 1 To 20
                PBoxButterfly.Location = New Point(PBoxButterfly.Location.X + 2, PBoxButterfly.Location.Y - 1)
            Case 21 To 50
                PBoxButterfly.Location = New Point(PBoxButterfly.Location.X + 1, PBoxButterfly.Location.Y + 2)
            Case 51 To 60
                PBoxButterfly.Location = New Point(PBoxButterfly.Location.X + 1, PBoxButterfly.Location.Y - 1)
            Case 61 To 80
                PBoxButterfly.Location = New Point(PBoxButterfly.Location.X + 1, PBoxButterfly.Location.Y + 2)
            Case 81 To 90
                PBoxButterfly.Location = New Point(PBoxButterfly.Location.X + 1, PBoxButterfly.Location.Y - 1)
            Case 91 To 110
                PBoxButterfly.Location = New Point(PBoxButterfly.Location.X + 1, PBoxButterfly.Location.Y + 1)
            Case 111 To 130
                PBoxButterfly.Location = New Point(PBoxButterfly.Location.X + 1, PBoxButterfly.Location.Y - 2)
            Case 131 To 140
                PBoxButterfly.Location = New Point(PBoxButterfly.Location.X + 1, PBoxButterfly.Location.Y + 1)
            Case 141 To 160
                PBoxButterfly.Location = New Point(PBoxButterfly.Location.X + 1, PBoxButterfly.Location.Y - 3)
            Case 161 To 190
                PBoxButterfly.Location = New Point(PBoxButterfly.Location.X + 2, PBoxButterfly.Location.Y + 2)
            Case 191 To 220
                PBoxButterfly.Location = New Point(PBoxButterfly.Location.X + 2, PBoxButterfly.Location.Y - 2)
            Case 221 To 250
                PBoxButterfly.Location = New Point(PBoxButterfly.Location.X + 0.5, PBoxButterfly.Location.Y)
            Case 251 To 280
                PBoxButterfly.Location = New Point(PBoxButterfly.Location.X - 0.5, PBoxButterfly.Location.Y)
            Case 281 To 310
                PBoxButterfly.Location = New Point(PBoxButterfly.Location.X - 2, PBoxButterfly.Location.Y + 2)
            Case 311 To 340
                PBoxButterfly.Location = New Point(PBoxButterfly.Location.X - 2, PBoxButterfly.Location.Y - 2)
            Case 341 To 360
                PBoxButterfly.Location = New Point(PBoxButterfly.Location.X - 1, PBoxButterfly.Location.Y + 3)
            Case 361 To 370
                PBoxButterfly.Location = New Point(PBoxButterfly.Location.X - 1, PBoxButterfly.Location.Y - 1)
            Case 371 To 390
                PBoxButterfly.Location = New Point(PBoxButterfly.Location.X - 1, PBoxButterfly.Location.Y + 2)
            Case 391 To 410
                PBoxButterfly.Location = New Point(PBoxButterfly.Location.X - 1, PBoxButterfly.Location.Y - 1)
            Case 411 To 420
                PBoxButterfly.Location = New Point(PBoxButterfly.Location.X - 1, PBoxButterfly.Location.Y + 1)
            Case 421 To 440
                PBoxButterfly.Location = New Point(PBoxButterfly.Location.X - 1, PBoxButterfly.Location.Y - 2)
            Case 441 To 450
                PBoxButterfly.Location = New Point(PBoxButterfly.Location.X - 1, PBoxButterfly.Location.Y + 1)
            Case 451 To 480
                PBoxButterfly.Location = New Point(PBoxButterfly.Location.X - 1, PBoxButterfly.Location.Y - 2)
            Case 481 To 500
                PBoxButterfly.Location = New Point(PBoxButterfly.Location.X - 2, PBoxButterfly.Location.Y + 1)
            Case Else
                PBoxButterfly.Location = New Point(186, 40)
                Timer3 = 0
        End Select
    End Sub

    'Controls path of dragonfly
    Private Sub TimerDragon_Tick(sender As Object, e As EventArgs) Handles TimerDragon.Tick
        DragonflyX = PBoxDragonfly.Location.X
        DragonflyY = PBoxDragonfly.Location.Y
        Timer4 = Timer4 + 1
        Select Case Timer4
            Case 1 To 35
                PBoxDragonfly.Location = New Point(PBoxDragonfly.Location.X - 2, PBoxDragonfly.Location.Y - 1)
            Case 36 To 70
                PBoxDragonfly.Location = New Point(PBoxDragonfly.Location.X - 4, PBoxDragonfly.Location.Y + 1)
            Case 71 To 120
                PBoxDragonfly.Location = New Point(PBoxDragonfly.Location.X - 1, PBoxDragonfly.Location.Y - 0.65)
            Case 121 To 160
                PBoxDragonfly.Location = New Point(PBoxDragonfly.Location.X - 3, PBoxDragonfly.Location.Y)
            Case 161 To 190
                PBoxDragonfly.Location = New Point(PBoxDragonfly.Location.X - 4, PBoxDragonfly.Location.Y + 2)
            Case Else
                PBoxDragonfly.Location = New Point(PBoxDragonfly.Location.X - 2.501, PBoxDragonfly.Location.Y)
        End Select
        If Timer4 = 350 Then 'Resets dragonfly once it leaves screen
            PBoxDragonfly.Location = New Point(699, 221)
            Timer4 = 0
            TimerDragon.Stop()
            TimerDragon.Start()
        End If
    End Sub

    'Closes program
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        End
    End Sub

    'Minimizes program
    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Shows name entering form and hides current form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnPlay.Click
        EnterName.Show()
        Me.Hide()
    End Sub

    Private Sub BtnGo1_Click(sender As Object, e As EventArgs) Handles BtnGo1.Click
        EnterName.Show()
        Me.Hide()
    End Sub

    'Shows settings form on top of current form
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click
        Settings.Show()
        Settings.BringToFront()
    End Sub

    Private Sub BtnGo2_Click(sender As Object, e As EventArgs) Handles BtnGo2.Click
        Settings.Show()
        Settings.BringToFront()
    End Sub

    'Shows credits form on top of current form
    Private Sub BtnCredits_Click(sender As Object, e As EventArgs) Handles BtnCredits.Click
        Credits.Show()
        Credits.BringToFront()
    End Sub

    Private Sub BtnGo3_Click(sender As Object, e As EventArgs) Handles BtnGo3.Click
        Credits.Show()
        Credits.BringToFront()
    End Sub

    'Shows credits form, which also has info about game
    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click
        Credits.Show()
        Credits.BringToFront()
    End Sub

    'Shows help form
    Private Sub BtnAsk_Click(sender As Object, e As EventArgs) Handles BtnAsk.Click
        Help.Show()
        Help.BringToFront()
    End Sub
End Class