'This splashscreen is the splashscreen of this program.
'Created by Aaron Tan, 2014-11-14

Public NotInheritable Class SplashScreen

    'Shows some info on splash screen
    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ApplicationTitle.Text = "Florithmetic"
        Version.Text = "0.9.29A"
        Copyright.Text = "Licensed under the terms of the GNU General Public License version 3.0"
    End Sub

End Class
