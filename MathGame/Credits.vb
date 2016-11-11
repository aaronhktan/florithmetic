'This form is used to show credits!
'Created by Aaron Tan, 2014-11-14

Public Class Credits
    Dim MouseX As Integer
    Dim MouseY As Integer
    Dim Drag As Boolean
    Dim Clicked As Integer
    Dim LogoClicked As Integer
    Dim CowClicked As Integer

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


    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        'Closes form, and shows main form again
        Me.Dispose()
        MainSplash.Show()
    End Sub

    'An easter egg
    Private Sub LblTest5_Click(sender As Object, e As EventArgs) Handles LblTest7.Click
        Clicked = Clicked + 1
        If ((Clicked Mod 2) = 0) Then
            PBoxEaster.Visible = False
            PBoxCow.Visible = False
            PBoxLogo.Visible = True
            LblThank.Text = "Thanks for playing;" & ControlChars.NewLine & "enjoy!"
        Else
            PBoxEaster.Visible = True
            PBoxCow.Visible = False
            PBoxLogo.Visible = False
            LblThank.Text = "YVONNE SAYS HI!"
        End If
    End Sub

    'Another easter egg
    Private Sub PBoxLogo_Click(sender As Object, e As EventArgs) Handles PBoxLogo.Click
        LogoClicked = LogoClicked + 1
        If LogoClicked >= 7 Then
            PBoxLogo.Visible = False
            PBoxEaster.Visible = False
            PBoxCow.Visible = True
            LblThank.Text = "Mr. Moo Moo wonders why" & ControlChars.NewLine & "you are clicking a logo."
            LblVersionNum.Text = "He is slightly worried."
        End If
    End Sub

    Private Sub PBoxCow_Click(sender As Object, e As EventArgs) Handles PBoxCow.Click
        CowClicked = CowClicked + 1
        If ((CowClicked Mod 2) = 0) Then
            PBoxCow.Visible = False
            PBoxLogo.Visible = True
            LblThank.Text = "Thanks for playing;" & ControlChars.NewLine & "enjoy!"
            LblVersionNum.Text = "You are using" & ControlChars.NewLine & "FLorithmetic 1.29.99.A"
        Else
            PBoxCow.Visible = True
            PBoxEaster.Visible = False
            PBoxLogo.Visible = False
            LblThank.Text = "Mr. Moo Moo wonders why" & ControlChars.NewLine & "you are clicking a logo."
            LblVersionNum.Text = "He is slightly worried."
        End If
    End Sub

    Private Sub Credits_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class