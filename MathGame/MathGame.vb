'This is the main game. It is fun, and has many flowers.
'Created by Aaron Tan, 2014-11-14

Public Class MathGame
    Dim StartTime As DateTime
    Dim FlowerTime As DateTime
    Public Time As Integer
    Dim Num1 As Integer
    Dim Num2 As Integer
    Dim Num3 As Integer
    Dim Ans As Integer
    Dim Operation As Integer
    Dim Operation2 As Integer
    Dim Brackets As Integer
    Dim Flower As Integer
    Dim Insect As Integer
    Dim Comment As Integer
    Dim Comment2 As Integer
    Dim StrComment As String
    Dim StrComment2 As String
    Public Correct As Integer
    Public Incorrect As Integer
    Public Answered As Integer
    Public Succeeded As Boolean
    Dim MouseX As Integer
    Dim MouseY As Integer
    Dim Drag As Boolean

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

    Private Sub MathGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize() 'Randomizes each time program loads
        StartTime = Now 'Sets time game started as now
        TimerStart.Enabled = True 'Enables timer measuring difference in time
        Generation() 'Generates question
        Dim ToolTip1 As New ToolTip() 'Shows tooltips if hovering over objects
        ToolTip1.AutoPopDelay = 500
        ToolTip1.SetToolTip(Me.BtnReplay, "Restart") 'Shows names of objects on hover
        ToolTip1.SetToolTip(Me.PBoxPink, "Pinky")
        ToolTip1.SetToolTip(Me.PBoxRed, "Scarlet")
        ToolTip1.SetToolTip(Me.PBoxSunFlower, "Sunny")
        ToolTip1.SetToolTip(Me.PBoxDaisy, "Daisy")
        ToolTip1.SetToolTip(Me.PBoxBlue, "Skye")
        ToolTip1.SetToolTip(Me.PBoxFly, "Freddie")
        ToolTip1.SetToolTip(Me.PBoxButterfly2, "Beatie")
        ToolTip1.SetToolTip(Me.PBoxDragon, "Jerome")
        ToolTip1.SetToolTip(Me.PBoxBee, "Bumbly")
        PBoxButterfly.Location = New Point(133, 521) 'Sets location of user-selected insect
        If Difficulty = 1 Then 'Plays different track for each level
            If Settings.Music Then
                My.Computer.Audio.Play(My.Resources.Neo, _
                    AudioPlayMode.BackgroundLoop)
            End If
        ElseIf Difficulty = 2 Then
            If Settings.Music Then
                My.Computer.Audio.Play(My.Resources.Prime_Movers, _
                    AudioPlayMode.BackgroundLoop)
            End If
        Else 'Difficulty = 3
            If Settings.Music Then
                My.Computer.Audio.Play(My.Resources.Tetramery, _
                    AudioPlayMode.BackgroundLoop)
            End If
        End If
        Select Case EnterName.Bug 'Sets bug picture and destination picture to user selected bug
            Case 1
                PBoxButterfly.BackgroundImage = ImgListBugs.Images(0)
                PBoxEnd.BackgroundImage = ImgListEnd.Images(0)
            Case 2
                PBoxButterfly.BackgroundImage = ImgListBugs.Images(1)
                PBoxEnd.BackgroundImage = ImgListEnd.Images(1)
            Case 3
                PBoxButterfly.BackgroundImage = ImgListBugs.Images(2)
                PBoxEnd.BackgroundImage = ImgListEnd.Images(2)
            Case 4
                PBoxButterfly.BackgroundImage = ImgListBugs.Images(3)
                PBoxEnd.BackgroundImage = ImgListEnd.Images(3)
            Case Else 'Case 5
                PBoxButterfly.BackgroundImage = ImgListBugs.Images(4)
                PBoxEnd.BackgroundImage = ImgListEnd.Images(4)
        End Select
        LblTimer.Text = Settings.TimerLength 'On launch, shows setting of how long game will take
    End Sub

    'Checks answer
    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles BtnCheck.Click
        FlowerHide() 'Hides previous comments
        InsectHide()
        If IsNumeric(TxtAns.Text) Then
            Answered = Answered + 1 'User has answered one additional question!
            Flower = Int(5 * Rnd() + 1) 'Generates a where comment appears
            TimerFlower.Start() 'Starts timer
            FlowerTime = Now 'Marks starttime of flower comment
            If TxtAns.Text = Ans Then 'They got it right!
                Correct = Correct + 1 'Adds 1 to number of questions correctly answered
                PBoxButterfly.Location = New Point(PBoxButterfly.Location.X + 40, PBoxButterfly.Location.Y) 'Moves butterfly 25 points right
                If PBoxButterfly.Location.X >= 554 Then
                    PBoxButterfly.Visible = False
                End If
                If PBoxButterfly.Location.X > 554 Then 'If bug is at destination, game ends.
                    Succeeded = True
                    BtnClose.PerformClick()
                End If
                Comment = Int(20 * Rnd() + 1) 'Generates a comment
                Comment2 = Int(5 * Rnd() + 1) 'Generates a second comment
                Insect = Int(2 * Rnd() + 1) 'Generates where second comment appears
                Select Case Comment 'Generates one of 20 comments to show for flowers on bottom
                    Case 1
                        StrComment = "Good job, " & EnterName.StrName & "!"
                    Case 2
                        StrComment = "Awesome!"
                    Case 3
                        StrComment = "That is SO cool!"
                    Case 4
                        StrComment = "You're so fast!"
                    Case 5
                        StrComment = "Nice!"
                    Case 6
                        StrComment = "Wow, " & EnterName.StrName & "!"
                    Case 7
                        StrComment = "Cool."
                    Case 8
                        StrComment = "Amazeballs!"
                    Case 9
                        StrComment = "Rad."
                    Case 10
                        StrComment = "Awesomesauce!"
                    Case 11
                        StrComment = "Wow. Very math."
                    Case 12
                        StrComment = "You are AWESOME."
                    Case 13
                        StrComment = "Nice job!"
                    Case 14
                        StrComment = "Simply amazing."
                    Case 15
                        StrComment = "Fantabulous, " & EnterName.StrName & "."
                    Case 16
                        StrComment = "That is great!"
                    Case 17
                        StrComment = "You are too good."
                    Case 18
                        StrComment = "Too good for me!"
                    Case 19
                        StrComment = "You are so great."
                    Case Else 'Case 20
                        StrComment = "Amazing, " & EnterName.StrName & "!"
                End Select
                Select Case Comment2 'Generates one of 5 comments to show for insects on top
                    Case 1
                        StrComment2 = "Good job, " & EnterName.StrName & "!"
                    Case 2
                        StrComment2 = "Wow, " & EnterName.StrName & "!"
                    Case 3
                        StrComment2 = "Great, " & EnterName.StrName & "!"
                    Case 4
                        StrComment2 = "Awesome, " & EnterName.StrName & "!"
                    Case Else 'Case 5
                        StrComment2 = "Amazing, " & EnterName.StrName & "!"
                End Select
                FlowerShow() 'Shows new comment
                InsectShow()
                LblCorrect.Text = Correct 'Shows number of questions correctly answered
                TxtAns.Text = "" 'Clears previous answer
                LblBracket1.Visible = False 'Clears any brackets from (now answered) question
                LblBracket2.Visible = False
                LblBracket3.Visible = False
                LblBracket4.Visible = False
                Generation() 'Generates new question
            Else
                Incorrect = Incorrect + 1 'User answered incorrectly
                If PBoxButterfly.Location.X = 133 Then 'If is at start, then no penalty
                Else 'If not at start, bug moves back. :(
                    PBoxButterfly.Location = New Point(PBoxButterfly.Location.X - 20, PBoxButterfly.Location.Y)
                End If
                Comment = Int(5 * Rnd() + 1) 'Shows a comment of disappointment
                Select Case Comment
                    Case 1
                        StrComment = "Uh oh!"
                    Case 2
                        StrComment = "Woopsies!"
                    Case 3
                        StrComment = "Whoopsie daisy!"
                    Case 4
                        StrComment = "Oh no!"
                    Case Else 'Case 5
                        StrComment = "Nuh uh."
                End Select
                FlowerShow() 'Shows disappointed comment
                TxtAns.Text = "" 'Clears incorrect answer
            End If
        Else
            Comment = Int(5 * Rnd() + 1) 'Generates a comment saying that there is no number
            Select Case Comment
                Case 1
                    StrComment = "There's nothing!"
                Case 2
                    StrComment = "Oh dear..."
                Case 3
                    StrComment = "Nothing? ..."
                Case 4
                    StrComment = "That's not a number!"
                Case Else 'Case 5
                    StrComment = "Math is numbers!"
            End Select
            FlowerShow() 'Shows comment
            TxtAns.Text = "" 'Clears text
        End If
    End Sub

    'Generates new questions
    Private Sub Generation()
        If Difficulty = 1 Then 'Easy
            Num1 = Int(6 * Rnd()) 'Generates a random integer between 1 and 5
            Num2 = Int(6 * Rnd())
            Operation = Int(2 * Rnd() + 2) 'Generates either 2 or 3; limits to addition and subtraction
        ElseIf Difficulty = 2 Then 'Medium
            Num1 = Int(11 * Rnd()) 'Generates number between 1 and 10
            Num2 = Int(11 * Rnd())
            Operation = Int(3 * Rnd() + 1) 'Generation integers 1-3; has multiplication
        Else 'Difficulty = 3, hard
            LblOperation2.Visible = True 'Shows second operation, unique to hard difficulty
            Operation2 = Int(3 * Rnd() + 1) 'Generates first operation
            Operation = Int(3 * Rnd() + 1) 'Generates second operaton
            Num1 = Int(11 * Rnd()) 'Generates number between 1 and 10
            Num2 = Int(11 * Rnd())
            Num3 = Int(11 * Rnd())
            LblNum3.Visible = True 'Shows third number, not visible with other levels
            LblNum3.Text = Num3 'Shows num3 in label of third number
            If Operation2 = 2 Or Operation2 = 3 Then
                If Operation = 2 Or Operation = 3 Then
                    Brackets = 1 'No brackets are needed because same level of BEDMAS
                Else 'Operation = 1, which means that the second sign is multiplication.
                    Brackets = Int(2 * Rnd() + 1) 'Generates integers 1-2, no brackets or brackets around first two terms.
                End If
            Else 'Operation2 = 1, which means that the first sign is multiplication; makes brackets redundant
                If Operation = 2 Or Operation = 3 Then 'There can be no brackets or brackets around the first two terms
                    Do
                        Brackets = Int(3 * Rnd() + 1) 'If number generator generates 2, then it regenerates number until not 2
                    Loop While Brackets = 2
                Else 'Operation = 1, which means that all operations are multiplication
                    Brackets = 1 'No brackets are needed
                End If
            End If
            If Brackets = 1 Then 'No brackets
                LblBracket1.Visible = False
                LblBracket3.Visible = False
            ElseIf Brackets = 2 Then 'Brackets around first and second term
                LblBracket1.Visible = True
                LblBracket3.Visible = True
            Else 'Brackets around second and third term
                LblBracket2.Visible = True
                LblBracket4.Visible = True
            End If
        End If
        LblNum1.Text = Num1 'Shows numbers in labels
        LblNum2.Text = Num2
        If Operation = 1 Then 'Shows appropriate operation signs
            LblOperation.Text = "x"
        ElseIf Operation = 2 Then
            LblOperation.Text = "+"
        Else 'Operation = 3
            LblOperation.Text = "-"
        End If
        If Difficulty = 1 Or Difficulty = 2 Then 'User selected easy or medium
            If Operation = 1 Then 'Operation is multiplication
                Ans = Num1 * Num2
            ElseIf Operation = 2 Then 'Operation is addition
                Ans = Num1 + Num2
            Else 'Operation = 3 and operation is subtraction
                Ans = Num1 - Num2
            End If
        Else 'User selected hard!
            If Operation2 = 1 Then 'Shows appropriate sign in second operation
                LblOperation2.Text = "x"
            ElseIf Operation2 = 2 Then
                LblOperation2.Text = "+"
            Else 'Operation2 = 3
                LblOperation2.Text = "-"
            End If
            If Brackets = 1 Then 'No brackets; do stuff in BEDMAS
                If Operation2 = 1 Then 'Multiplication is first operation
                    Ans = Num3 * Num1
                    If Operation = 1 Then 'Multiplication is second operation
                        Ans = Ans * Num2
                    ElseIf Operation = 2 Then 'Addition is second operation
                        Ans = Ans + Num2
                    Else 'Operation = 3, subtraction is third operation
                        Ans = Ans - Num2
                    End If
                ElseIf Operation2 = 2 Then 'First operation is addition
                    If Operation = 1 Then 'Second operation is multiplication
                        Ans = Num1 * Num2
                        Ans = Ans + Num3
                    ElseIf Operation = 2 Then 'Second operation is addition
                        Ans = Num3 + Num1 + Num2
                    Else 'Operation = 3, second operation is subtraction
                        Ans = Num3 + Num1 - Num2
                    End If
                Else 'First operation is subtraction
                    If Operation = 1 Then 'Second operation is multiplication
                        Ans = Num1 * Num2
                        Ans = Num3 - Ans
                    ElseIf Operation = 2 Then 'Second operation is addition
                        Ans = Num3 - Num1 + Num2
                    Else 'Operation = 3, second operation is also subtraction
                        Ans = Num3 - Num1 - Num2
                    End If
                End If
            ElseIf Brackets = 2 Then 'Brackets around first two terms
                If Operation2 = 1 Then 'Operation is multiplication
                    Ans = Num3 * Num1
                ElseIf Operation2 = 2 Then 'Operation is addition
                    Ans = Num3 + Num1
                Else 'Operation2 = 3, operation is subtraction
                    Ans = Num3 - Num1
                End If
                If Operation = 1 Then 'Second operation is multiplication
                    Ans = Ans * Num2
                ElseIf Operation = 2 Then 'Second operation is addition
                    Ans = Ans + Num2
                Else 'Operation = 3, second operation is subtraction
                    Ans = Ans - Num2
                End If
            Else 'Brackets = 3, brackets around last two terms
                If Operation = 1 Then 'Operation is multiplication
                    Ans = Num1 * Num2
                ElseIf Operation = 2 Then 'Operation is addition
                    Ans = Num1 + Num2
                Else 'Operation = 3, and operation is subtraction
                    Ans = Num1 - Num2
                End If
                If Operation2 = 1 Then 'Second operation is multiplication
                    Ans = Ans * Num3
                ElseIf Operation = 2 Then 'Second operation is addition
                    Ans = Ans + Num3
                Else 'Operation = 3, second operation is subtraction
                    Ans = Num3 - Ans
                End If
            End If
        End If
    End Sub

    'Hides flower comments
    Private Sub FlowerHide()
        Select Case Flower
            Case 1
                LblFlower1.Visible = False
            Case 2
                LblFlower2.Visible = False
            Case 3
                LblFlower3.Visible = False
            Case 4
                LblFlower4.Visible = False
            Case Else 'Case 5
                LblFlower5.Visible = False
        End Select
    End Sub

    'Shows flower's comment
    Private Sub FlowerShow()
        Select Case Flower
            Case 1
                LblFlower1.Visible = True
                LblFlower1.Text = StrComment
            Case 2
                LblFlower2.Visible = True
                LblFlower2.Text = StrComment
            Case 3
                LblFlower3.Visible = True
                LblFlower3.Text = StrComment
            Case 4
                LblFlower4.Visible = True
                LblFlower4.Text = StrComment
            Case Else 'Case 5
                LblFlower5.Visible = True
                LblFlower5.Text = StrComment
        End Select
    End Sub

    'Shows insect's comment
    Private Sub InsectShow()
        Select Case Insect
            Case 1
                LblInsect1.Visible = True
                LblInsect1.Text = StrComment2
            Case Else 'Case 2
                LblInsect2.Visible = True
                LblInsect2.Text = StrComment2
        End Select
    End Sub

    'Hides insect comments
    Private Sub InsectHide()
        LblInsect1.Visible = False
        LblInsect2.Visible = False
    End Sub

    'Updates time remaining every time timer ticks
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerStart.Tick
        Time = DateDiff(DateInterval.Second, StartTime, Now)
        LblTimer.Text = Settings.TimerLength - Time 'Shows time difference between now and start of game
        If Settings.TimerLength - Time = 10 Then 'Changes font colour and style when only 10 seconds left
            Me.LblTimer.Font = New System.Drawing.Font("Open Sans", 22.0!,
            System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point,
            CType(0, Byte))
            LblTimer.ForeColor = Color.OrangeRed
            LblTimer.Location = New Point(33, 518)
        ElseIf Settings.TimerLength - Time = 0 Then 'Closes once time is up
            BtnClose.PerformClick()
        End If
    End Sub

    'Closes current form and shows main menu
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        My.Computer.Audio.Stop() 'Stops music of level and plays main menu music
        My.Computer.Audio.Play(My.Resources.Receives, _
        AudioPlayMode.Background)
        Me.Close()
        MainSplash.Show()
    End Sub

    'Closes form
    Private Sub BtnQuit_Click(sender As Object, e As EventArgs)
        End
    End Sub

    'Shows flower comments for 5 seconds, and shows encouraging comments after 7
    Private Sub TimerFlower_Tick(sender As Object, e As EventArgs) Handles TimerFlower.Tick
        If DateDiff(DateInterval.Second, FlowerTime, Now) = 5 Then 'Hides after 5 seconds
            FlowerHide()
            InsectHide()
        ElseIf DateDiff(DateInterval.Second, FlowerTime, Now) >= 7 Then 'Shows encouragement message after 7 seconds
            Flower = Int(5 * Rnd() + 1)
            FlowerTime = Now
            Comment = Int(5 * Rnd() + 1) 'Generates random comment
            Select Case Comment
                Case 1
                    StrComment = "Keep on going!"
                Case 2
                    StrComment = "Don't give up!"
                Case 3
                    StrComment = "Let's go, " & EnterName.StrName
                Case 4
                    StrComment = "Faster, faster!"
                Case Else 'Case 5
                    StrComment = "You can do it!"
            End Select
            FlowerShow()
        End If
    End Sub

    'Shows last form (with stats) if user decides to quit
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        My.Computer.Audio.Stop()
        EndGame.Show()
        Me.Close()
    End Sub

    'Minimizes game
    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Regenerates form, if user wants to refresh
    Private Sub LblReplay_Click(sender As Object, e As EventArgs) Handles BtnReplay.Click
        MathGame_Load(Me, New System.EventArgs)
    End Sub

End Class
