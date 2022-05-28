Public Class Tictoctoe
    'This Boolean Is to control the flow of the Game
    Dim playerturn As Boolean = True
    Dim p_onescore As UShort
    Dim p_twoscore As UShort
    Public Property playeronename As String
    Public Property playertwoname As String

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

            'This part Is for the design and disabling the tiles of the game

            'playerturn <> playerturn

            If btntextonetonine.Text.Equals("") Then
                If playerturn Then
                    btntextonetonine.Text = "X"
                    'inverting the value 
                    playerturn = False

                Else
                    btntextonetonine.Text = "O"
                    'inverting the value 
                    playerturn = True
                End If
            ElseIf btntextonetonine.Text.Equals("X") Then
                btntextonetonine.Text = "X"
            ElseIf btntextonetonine.Text.Equals("O") Then
                btntextonetonine.Text = "O"
            End If
            'Scorer counter
            WinnerChecker()
            playeronescore.Text = Convert.ToString(p_onescore)
            playertwoscore.Text = Convert.ToString(p_twoscore)
        Catch ex As Exception
            MessageBox.Show("Oppppsss!!! ")
        End Try

    End Sub
    'this Function is() For determining the winner of the game
    Public Sub WinnerChecker()
        '   UpperBox horizontal result 
        If btnupperleft.Text.Equals(btnupper.Text) And btnupper.Text.Equals(btnupperright.Text) And btnupperleft.Text <> "" Then
            PlayerChecker(btnupperleft.Text)
            btnnewgame.PerformClick()
            'MiddeleBox horizontal result 
        ElseIf btnleft.Text.Equals(btnmiddle.Text) And btnmiddle.Text.Equals(btnright.Text) And btnleft.Text <> "" Then
            PlayerChecker(btnleft.Text)
            btnnewgame.PerformClick()
            'BottomBox horizontal result 
        ElseIf btnbottomleft.Text.Equals(btnbottom.Text) And btnbottom.Text.Equals(btnbottomright.Text) And btnbottomleft.Text <> "" Then
            PlayerChecker(btnbottomleft.Text)
            btnnewgame.PerformClick()
            'Left Vertical result
        ElseIf btnupperleft.Text.Equals(btnleft.Text) And btnleft.Text.Equals(btnbottomleft.Text) And btnupperleft.Text <> "" Then
            PlayerChecker(btnupperleft.Text)
            btnnewgame.PerformClick()
            'Middle Vertical result
        ElseIf btnupper.Text = btnmiddle.Text And btnmiddle.Text = btnbottom.Text And btnupper.Text <> "" Then
            PlayerChecker(btnupper.Text)
            btnnewgame.PerformClick()
            'Right Vertical result
        ElseIf btnupperright.Text = btnright.Text And btnright.Text = btnbottomright.Text And btnupperright.Text <> "" Then
            PlayerChecker(btnupperright.Text)
            btnnewgame.PerformClick()
            'Diagonal result \
        ElseIf btnupperleft.Text.Equals(btnmiddle.Text) And btnmiddle.Text.Equals(btnbottomright.Text) And btnupperleft.Text <> "" Then
            PlayerChecker(btnupperleft.Text)
            btnnewgame.PerformClick()
            'Diagonal result /
        ElseIf btnupperright.Text.Equals(btnmiddle.Text) And btnmiddle.Text.Equals(btnbottomleft.Text) And btnupperright.Text <> "" Then
            PlayerChecker(btnupperright.Text)
            btnnewgame.PerformClick()
        End If

    End Sub

    'To minimize the space And Memory i use this function to determin the winner of the game
    Function PlayerChecker(check) As String
        If check.Equals("X") Then
            p_onescore += 1
            Return MessageBox.Show("Winner: " + LabelPlayer1.Text)

        Else
            p_twoscore += 1
            Return MessageBox.Show("Winner: " + LabelPlayer2.Text)
        End If

    End Function

    Private Sub btnnewgame_Click(sender As Object, e As EventArgs) Handles btnnewgame.Click

        'to minimize the space of the workplace and the memory i use array then concatinate the function i need to reset
        Dim btnonetoninereset() As Button = {btnupperleft, btnupper, btnupperright, btnleft, btnmiddle, btnright, btnbottomleft, btnbottom, btnbottomright}
        For Each i In btnonetoninereset
            i.Text = ""
        Next
        playerturn = True
    End Sub

    Private Sub Tictoctoe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setting label for player names
        LabelPlayer1.Text = playeronename
        LabelPlayer2.Text = playertwoname
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        'hiding this page and jump to the first page
        Me.Hide()
        FirstPage.Show()
    End Sub
End Class
