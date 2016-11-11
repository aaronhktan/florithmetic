'This form allows users to customize their game.
'Created by Aaron Tan, 2014-11-14

Public Class Settings
    Public TimerLength As Integer
    Public Music As Boolean
    Public SFX As Boolean
    Public Background As Integer
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

    'Allows user to change how long the math game lasts (in seconds)
    Private Sub TBarTime_Scroll(sender As Object, e As EventArgs) Handles TBarTime.Scroll
        Select Case TBarTime.Value
            Case 0
                TimerLength = 30
            Case 1
                TimerLength = 60
            Case 2
                TimerLength = 90
            Case 3
                TimerLength = 120
            Case 4
                TimerLength = 150
            Case Else 'Case 5
                TimerLength = 180
        End Select
    End Sub

    'Enables or disables music depending on user choice
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CBoxMusic.CheckedChanged
        If CBoxMusic.Checked Then
            Music = True
            My.Computer.Audio.Play(My.Resources.Receives, _
            AudioPlayMode.BackgroundLoop)
        Else
            Music = False
            My.Computer.Audio.Stop()
        End If
    End Sub

    'Enables or disables sound effects depending on user choice
    Private Sub CBoxSFX_CheckedChanged(sender As Object, e As EventArgs) Handles CBoxSFX.CheckedChanged
        If CBoxSFX.Checked Then
            SFX = True
        Else
            SFX = False
        End If
    End Sub

    Private Sub ComBoxBack_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComBoxBack.SelectedIndexChanged
        'Changes variable based on combobox selection
        If ComBoxBack.SelectedItem = "Sky Blue" Then
            Background = 1
        ElseIf ComBoxBack.SelectedItem = "Deep Sky Blue" Then
            Background = 2
        ElseIf ComBoxBack.SelectedItem = "Light Sky Blue" Then
            Background = 3
        Else 'ComBoxBack.SelectedItem = "Blue"
            Background = 4
        End If
        'Changes background based on user choice
        Select Case Background
            Case 1
                Me.BackColor = Color.SkyBlue
                MainSplash.BackColor = Color.SkyBlue
                Credits.BackColor = Color.SkyBlue
                EndGame.BackColor = Color.SkyBlue
                EnterName.BackColor = Color.SkyBlue
                Intro.BackColor = Color.SkyBlue
                LevelChooser.BackColor = Color.SkyBlue
                MathGame.BackColor = Color.SkyBlue
                SplashScreen.BackColor = Color.SkyBlue
            Case 2
                Me.BackColor = Color.DeepSkyBlue
                MainSplash.BackColor = Color.DeepSkyBlue
                Credits.BackColor = Color.DeepSkyBlue
                EndGame.BackColor = Color.DeepSkyBlue
                EnterName.BackColor = Color.DeepSkyBlue
                Intro.BackColor = Color.DeepSkyBlue
                LevelChooser.BackColor = Color.DeepSkyBlue
                MathGame.BackColor = Color.DeepSkyBlue
                SplashScreen.BackColor = Color.DeepSkyBlue
            Case 3
                Me.BackColor = Color.LightSkyBlue
                MainSplash.BackColor = Color.LightSkyBlue
                Credits.BackColor = Color.LightSkyBlue
                EndGame.BackColor = Color.LightSkyBlue
                EnterName.BackColor = Color.LightSkyBlue
                Intro.BackColor = Color.LightSkyBlue
                LevelChooser.BackColor = Color.LightSkyBlue
                MathGame.BackColor = Color.LightSkyBlue
                SplashScreen.BackColor = Color.LightSkyBlue
            Case Else 'Case 4
                Me.BackColor = Color.SteelBlue
                MainSplash.BackColor = Color.SteelBlue
                Credits.BackColor = Color.SteelBlue
                EndGame.BackColor = Color.SteelBlue
                EnterName.BackColor = Color.SteelBlue
                Intro.BackColor = Color.SteelBlue
                LevelChooser.BackColor = Color.SteelBlue
                MathGame.BackColor = Color.SteelBlue
                SplashScreen.BackColor = Color.SteelBlue

        End Select
    End Sub

    'Hides settings and shows main menu
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        MainSplash.Show()
    End Sub

End Class