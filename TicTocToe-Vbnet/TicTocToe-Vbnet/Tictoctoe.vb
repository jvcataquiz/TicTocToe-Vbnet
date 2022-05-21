Public Class Tictoctoe
    Dim playerturn As Boolean = True

    Private Sub btnquit_Click(sender As Object, e As EventArgs) Handles btnquit.Click
        Me.Close()
    End Sub

    Private Sub btnclickonetonine(sender As Object, e As EventArgs) Handles MyBase.Click, btnupperright.Click, btnupperleft.Click, btnupper.Click, btnright.Click, btnmiddle.Click, btnleft.Click, btnbottomright.Click, btnbottomleft.Click, btnbottom.Click
        Dim btntextonetonine As Button = CType(sender, Button)
        If playerturn Then
            btntextonetonine.Text = "X"
            playerturn = False

        Else
            btntextonetonine.Text = "O"
            playerturn = True

        End If

    End Sub
End Class
