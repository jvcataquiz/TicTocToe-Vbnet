Public Class FirstPage
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
        PlayLoopingBackgroundSoundFile()
        musicplayer = True
    End Sub
    Sub PlayLoopingBackgroundSoundFile()
        My.Computer.Audio.Play("bgmusic.wav", AudioPlayMode.BackgroundLoop)
    End Sub
    Sub StopBackgroundSound()
        My.Computer.Audio.Stop()
    End Sub

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