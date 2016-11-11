Module Variables 'Makes variables accessible to other forms
    Public Difficulty As Integer
End Module

'This form allows the user to choose what level they want the math game to be.
'Created by Aaron Tan, 2014-11-14

Public Class LevelChooser
    Dim MouseX As Integer
    Dim MouseY As Integer
    Dim Drag As Boolean

    'Allows dragging of borderless forms
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

    'Assigns difficulty and shows game
    Private Sub BtnEasy_Click(sender As Object, e As EventArgs) Handles BtnEasy.Click
        Difficulty = 1 'Assigns the difficulty of easy
        MathGame.Show() 'Shows game form
        Me.Hide() 'Hides current form
    End Sub

    Private Sub BtnMedium_Click(sender As Object, e As EventArgs) Handles BtnMedium.Click
        Difficulty = 2
        MathGame.Show()
        Me.Hide()
    End Sub

    Private Sub BtnHard_Click(sender As Object, e As EventArgs) Handles BtnHard.Click
        Difficulty = 3
        MathGame.Show()
        Me.Hide()
    End Sub

    'Closes program
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        End
    End Sub

    'Hides form and shows last form
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Intro.Show()
        Me.Hide()
    End Sub

    'Minimizes current form
    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class