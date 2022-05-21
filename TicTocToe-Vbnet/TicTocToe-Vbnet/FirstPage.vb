Public Class FirstPage
    'this boolean is for controlling the bg image of the buton music and for controlling the bg music
    Dim musicplayer As Boolean
    Private Sub btnenter_Click(sender As Object, e As EventArgs) Handles btnenter.Click

        'this condition if the playersname is the same
        If textboxplayeronename.Text.Equals(textboxplayertwoname.Text) Then
            MessageBox.Show("Same PlayerName!!!")
            'this condition if the entered Or input playername Is less than 3 charcters
        ElseIf textboxplayeronename.Text.Length < 3 Or textboxplayertwoname.Text.Length < 3 Then
            MessageBox.Show("Min of 3 char!!!")
        Else
            'Declaring Tictoctoe as a new
            Dim FormTictoctoe As New Tictoctoe
            'To pass the value of entered value in textbox you need to declared public property located in another pages
            FormTictoctoe.playeronename = textboxplayeronename.Text
            FormTictoctoe.playertwoname = textboxplayertwoname.Text
            'it will show or jump the next page
            FormTictoctoe.Show()
            'It will close this page
            Me.Hide()
        End If
    End Sub

    Private Sub FirstPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'when the game is open the backgroun music will play
        PlayLoopingBackgroundSoundFile()
        musicplayer = True
    End Sub
    'this function is for playing bg music and looping the wav file (music) is located at the debug folder
    Sub PlayLoopingBackgroundSoundFile()
        My.Computer.Audio.Play("bgmusic.wav", AudioPlayMode.BackgroundLoop)
    End Sub
    'this function is to stop the bg music
    Sub StopBackgroundSound()
        My.Computer.Audio.Stop()
    End Sub


    'this function is for controlling the bg image and music
    Private Sub btnmusic_Click(sender As Object, e As EventArgs) Handles btnmusic.Click
        If musicplayer Then
            btnmusic.Image = System.Drawing.Image.FromFile("music-off.png")
            StopBackgroundSound()
            musicplayer = False

        Else
            btnmusic.Image = System.Drawing.Image.FromFile("music-on.png")
            PlayLoopingBackgroundSoundFile()
            musicplayer = True
        End If
    End Sub
End Class