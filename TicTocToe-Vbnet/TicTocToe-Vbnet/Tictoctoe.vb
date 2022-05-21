Public Class Tictoctoe
    'This Boolean Is to control the flow of the Game
    Dim playerturn As Boolean = True

    'When this button click the Game will Exit
    Private Sub btnquit_Click(sender As Object, e As EventArgs) Handles btnquit.Click
        'This Close Function will close the Game
        Me.Close()
    End Sub

    'I grouped all button one To nine in one Function
    Private Sub btnclickonetonine(sender As Object, e As EventArgs) Handles MyBase.Click, btnupperright.Click, btnupperleft.Click, btnupper.Click, btnright.Click, btnmiddle.Click, btnleft.Click, btnbottomright.Click, btnbottomleft.Click, btnbottom.Click
        'using Try Catch to secure the game for not being crash in the middle of the game, it also secure the pushed button not to push again
        Try
            Dim btntextonetonine As Button = CType(sender, Button)

            'this condition Is determining the value of playerturn then assigning a text value
            If playerturn Then
                btntextonetonine.Text = "X"
                'inverting the value 
                playerturn = False


            Else
                btntextonetonine.Text = "O"

                'inverting the value 
                playerturn = True

            End If
            'This part Is for the design and disabling the tiles of the game
            btntextonetonine.Enabled = False
            If btntextonetonine.Enabled = False Then
                btntextonetonine.BackColor = System.Drawing.Color.White
            Else
                btntextonetonine.BackColor = System.Drawing.Color.Black
                btntextonetonine.Text = ""

            End If
            'calling the function
            WinnerChecker()

        Catch ex As Exception
            MessageBox.Show("Oppppsss!!!Pushed Already ")
        End Try

    End Sub
    'this Function is() For determining the winner of the game
    Public Sub WinnerChecker()
        '   UpperBox horizontal result 
        If btnupperleft.Text = btnupper.Text And btnupper.Text = btnupperright.Text And btnupperleft.Enabled = False Then
            PlayerChecker(btnupperleft.Text)
            btnnewgame.PerformClick()
            'MiddeleBox horizontal result 
        ElseIf btnleft.Text = btnmiddle.Text And btnmiddle.Text = btnright.Text And btnleft.Enabled = False Then
            PlayerChecker(btnleft.Text)
            btnnewgame.PerformClick()
            'BottomBox horizontal result 
        ElseIf btnbottomleft.Text = btnbottom.Text And btnbottom.Text = btnbottomright.Text And btnbottomleft.Enabled = False Then
            PlayerChecker(btnbottomleft.Text)
            btnnewgame.PerformClick()
            'Left Vertical result
        ElseIf btnupperleft.Text = btnleft.Text And btnleft.Text = btnbottomleft.Text And btnupperleft.Enabled = False Then
            PlayerChecker(btnupperleft.Text)
            btnnewgame.PerformClick()
            'Middle Vertical result
        ElseIf btnupper.Text = btnmiddle.Text And btnmiddle.Text = btnbottom.Text And btnupper.Enabled = False Then
            PlayerChecker(btnupper.Text)
            btnnewgame.PerformClick()
            'Right Vertical result
        ElseIf btnupperright.Text = btnright.Text And btnright.Text = btnbottomright.Text And btnupperright.Enabled = False Then
            PlayerChecker(btnupperright.Text)
            btnnewgame.PerformClick()
            'Diagonal result \
        ElseIf btnupperleft.Text = btnmiddle.Text And btnmiddle.Text = btnbottomright.Text And btnupperleft.Enabled = False Then
            PlayerChecker(btnupperleft.Text)
            btnnewgame.PerformClick()
            'Diagonal result /
        ElseIf btnupperright.Text = btnmiddle.Text And btnmiddle.Text = btnbottomleft.Text And btnupperright.Enabled = False Then
            PlayerChecker(btnupperright.Text)
            btnnewgame.PerformClick()
        End If

    End Sub

    'To minimize the space And Memory i use this function to determin the winner of the game
    Function PlayerChecker(check) As String
        If check = "X" Then
            Return MessageBox.Show("Winner: Player 1")
        Else
            Return MessageBox.Show("Winner: Player 2")
        End If

    End Function

    Private Sub btnnewgame_Click(sender As Object, e As EventArgs) Handles btnnewgame.Click
        Dim btnonetoninereset() As Button = {btnupperleft, btnupper, btnupperright, btnleft, btnmiddle, btnright, btnbottomleft, btnbottom, btnbottomright}
        For Each i In btnonetoninereset
            i.Enabled = True
            i.Text = ""
            i.BackColor = System.Drawing.Color.Black

        Next
    End Sub

End Class
