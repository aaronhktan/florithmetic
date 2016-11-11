'This form is used to introduce the premise of the game, including the character name and their goal.
'Created by Aaron Tan, 2014-11-14

Public Class Intro
    Dim MouseX As Integer
    Dim MouseY As Integer
    Dim Drag As Boolean
    Public Bug As Integer

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

    Private Sub Intro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Shows dialogue depending on user's favourite bug
        If EnterName.Bug = 1 Then
            PBoxBug.BackgroundImage = ImgListBugs.Images(0)
            LblIntro.Text = "Hey there! My name is Izzy, and I'm a beautiful pink butterfly. " & ControlChars.NewLine & "I need you to solve math questions so I can get to flowers." & ControlChars.NewLine & "I only have one minute though, so hurry!" & ControlChars.NewLine & ControlChars.NewLine & "Will you help me?"
        ElseIf EnterName.Bug = 2 Then
            PBoxBug.BackgroundImage = ImgListBugs.Images(1)
            LblIntro.Text = "Hey there! My name is Willy, and I'm the fastest dragonfly of all! " & ControlChars.NewLine & "I need you to solve math questions so I can win my race." & ControlChars.NewLine & "I only have one minute though, so hurry!" & ControlChars.NewLine & ControlChars.NewLine & "Will you help me?"
        ElseIf EnterName.Bug = 3 Then
            PBoxBug.BackgroundImage = ImgListBugs.Images(2)
            LblIntro.Text = "Hey there! My name is Paul, and I'm the big bumblebee! " & ControlChars.NewLine & "I need you to solve math questions so I can find my hive." & ControlChars.NewLine & "I only have one minute though, so hurry!" & ControlChars.NewLine & ControlChars.NewLine & "Will you help me?"
        ElseIf EnterName.Bug = 4 Then
            PBoxBug.BackgroundImage = ImgListBugs.Images(3)
            LblIntro.Text = "Hey there! My name is Yvonne, and I weave the best webs! " & ControlChars.NewLine & "I need you to solve math questions so I can finish my web." & ControlChars.NewLine & "I only have one minute though, so hurry!" & ControlChars.NewLine & ControlChars.NewLine & "Will you help me?"
        Else 'EnterName.Bug = 5
            PBoxBug.BackgroundImage = ImgListBugs.Images(4)
            LblIntro.Text = "Hey there! My name is Henry, and I'm a happy snail. " & ControlChars.NewLine & "I need you to solve math questions so I can get to my lettuce leaf." & ControlChars.NewLine & "I only have one minute though, so hurry!" & ControlChars.NewLine & ControlChars.NewLine & "Will you help me?"
        End If
    End Sub

    'Closes form and shows level chooser
    Private Sub BtnYes_Click(sender As Object, e As EventArgs) Handles BtnYes.Click
        LevelChooser.Show()
        Me.Dispose()
    End Sub

    Private Sub BtnYes2_Click(sender As Object, e As EventArgs) Handles BtnYes2.Click
        LevelChooser.Show()
        Me.Dispose()
    End Sub

    'Closes form
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        End
    End Sub

    'Minimizes program
    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Closes form and shows name entering form
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Dispose()
        EnterName.Show()
    End Sub

End Class