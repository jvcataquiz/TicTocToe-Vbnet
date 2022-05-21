Public Class FirstPage
    Private Sub btnenter_Click(sender As Object, e As EventArgs) Handles btnenter.Click
        If textboxplayeronename.Text.Equals(textboxplayertwoname.Text) Then
            MessageBox.Show("Same PlayerName!!!")
        ElseIf textboxplayeronename.Text.Length < 3 Or textboxplayertwoname.Text.Length < 3 Then
            MessageBox.Show("Min of 3 char!!!")
        Else
            Dim FormTictoctoe As New Tictoctoe
            FormTictoctoe.playeronename = textboxplayeronename.Text
            FormTictoctoe.playertwoname = textboxplayertwoname.Text
            FormTictoctoe.Show()

            Me.Hide()



        End If
    End Sub
End Class