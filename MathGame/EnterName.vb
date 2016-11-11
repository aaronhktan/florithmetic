'This form is used to prompt the user to enter their name.
'Created by Aaron Tan, 2014-11-14

Public Class EnterName
    Dim MouseX As Integer
    Dim MouseY As Integer
    Dim Drag As Boolean
    Public StrName As String
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

    'Closes game
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        End
    End Sub

    'Hides current form; shows main menu
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        MainSplash.Show()
    End Sub

    'Minimizes program
    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Checks whether user entered a name
    Private Sub NameCheck()
        If TxtName.Text = "" Then 'No name has been entered!
            MessageBox.Show("I need your name!", _
            "Invalid Name", MessageBoxButtons.OK, _
            MessageBoxIcon.Exclamation) 'Message, buttons, and icon in messagebox
        Else
            StrName = TxtName.Text 'Saves name if entered, then closes form and shows intro
            Intro.Show()
            Me.Hide()
        End If
    End Sub

    'Sets bug and checks name
    Private Sub BtnButterfly_Click(sender As Object, e As EventArgs) Handles BtnButterfly.Click
        Bug = 1
        NameCheck()
    End Sub

    Private Sub BtnDragon_Click(sender As Object, e As EventArgs) Handles BtnDragon.Click
        Bug = 2
        NameCheck()
    End Sub

    Private Sub BtnBee_Click(sender As Object, e As EventArgs) Handles BtnBee.Click
        Bug = 3
        NameCheck()
    End Sub

    Private Sub BtnSpider_Click(sender As Object, e As EventArgs) Handles BtnSpider.Click
        Bug = 4
        NameCheck()
    End Sub

    Private Sub BtnSnail_Click(sender As Object, e As EventArgs) Handles BtnSnail.Click
        Bug = 5
        NameCheck()
    End Sub

End Class