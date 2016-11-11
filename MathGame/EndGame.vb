'This form is used to show the final score of the user.
'Created by Aaron Tan, 2014-11-14

Public Class EndGame
    Dim MouseX As Integer
    Dim MouseY As Integer
    Dim Drag As Boolean
    Dim StrBug As String
    Dim StrAction As String

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

    'Loads items based on whether you finished game
    Private Sub EndGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblCorrect.Text = "Correct: " & MathGame.Correct 'Shows number of questions answered correctly
        LblIncorrect.Text = "Incorrect: " & MathGame.Incorrect 'Shows number of questions answered incorrectly
        If MathGame.Correct = 0 And MathGame.Answered = 0 Then
            LblPercentage.Text = "Percentage: 0%" 'Instead of showing NaN when doing 0/0, shows 0
        Else
            LblPercentage.Text = "Percentage: " & Int(MathGame.Correct / MathGame.Answered * 100) & "%" 'Shows percentage or correctness
        End If
        LblAnswered.Text = "Questions answered: " & MathGame.Answered 'Shows number of answred questions
        LblTime.Text = "Time taken: " & MathGame.Time 'Shows amount of time taken
        LblAverage.Text = "Questions/Second: " & Int(MathGame.Answered / MathGame.Time * 100) / 100 'Shows average number of questions per answer
        'Shows message based on bug choice of user
        Select Case EnterName.Bug
            Case 1
                StrBug = "Izzy"
                If MathGame.Succeeded Then
                    StrAction = " to her flowers!"
                Else
                    StrAction = "'s flowers wilted..."
                End If
            Case 2
                StrBug = "Willy"
                If MathGame.Succeeded Then
                    StrAction = " to win his race!"
                Else
                    StrAction = " lost his race..."
                End If
            Case 3
                StrBug = "Paul"
                If MathGame.Succeeded Then
                    StrAction = " to his hive!"
                Else
                    StrAction = " couldn't find his hive."
                End If
            Case 4
                StrBug = "Yvonne"
                If MathGame.Succeeded Then
                    StrAction = " to finish her web!"
                Else
                    StrAction = "'s web got torn down."
                End If
            Case Else 'Case 5
                StrBug = "Henry"
                If MathGame.Succeeded Then
                    StrAction = " to his beloved lettuce leaf."
                Else
                    StrAction = " didn't eat lunch today."
                End If
        End Select
        'Shows text and plays sound effect based on whether user won
        If MathGame.Succeeded Then
            My.Computer.Audio.Stop()
            If Settings.SFX Then
                My.Computer.Audio.Play(My.Resources.Tada, _
            AudioPlayMode.Background)
            End If
            LblEnd.Text = "Congratulations, " & EnterName.StrName & "!" 'If you got the insect home, congratulations!
            LblMessage.Text = "You got " & StrBug & StrAction 'Shows effect of user on bug's actions
        Else
            My.Computer.Audio.Stop()
            If Settings.SFX Then
                My.Computer.Audio.Play(My.Resources.Sad_Trombone, _
            AudioPlayMode.Background)
            End If
            LblEnd.Text = "Oh no!" 'If you don't, then disappointment ensues
            LblMessage.Text = "You didn't do enough math, so " & StrBug & StrAction
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        'Hides current form; shows main menu and plays main menu music
        EnterName.Dispose()
        MainSplash.Show() 'Shows intro again
        If Settings.Music = True Then
            My.Computer.Audio.Play(My.Resources.Receives, _
            AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Stop()
        End If
        Me.Close()
    End Sub

    'Closes form
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        End
    End Sub

    'Minimizes form
    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Reloads game, saving user selected difficulty and name
    Private Sub BtnReplay_Click(sender As Object, e As EventArgs) Handles BtnReplay.Click
        MathGame.Show()
        Me.Dispose()
    End Sub

End Class