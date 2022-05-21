﻿Public Class Tictoctoe
    'This Boolean Is to control the flow of the Game
    Dim playerturn As Boolean = True

    'When this button click the Game will Exit
    Private Sub btnquit_Click(sender As Object, e As EventArgs) Handles btnquit.Click
        'This Close Function will close the Game
        Me.Close()
    End Sub

    'I grouped all button one To nine in one Function
    Private Sub btnclickonetonine(sender As Object, e As EventArgs) Handles MyBase.Click, btnupperright.Click, btnupperleft.Click, btnupper.Click, btnright.Click, btnmiddle.Click, btnleft.Click, btnbottomright.Click, btnbottomleft.Click, btnbottom.Click

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
        btntextonetonine.Enabled = False
        If btntextonetonine.Enabled = False Then
            btntextonetonine.BackColor = System.Drawing.Color.White
        Else
            btntextonetonine.BackColor = System.Drawing.Color.Black
            btntextonetonine.Text = ""

        End If
        'calling the function
        WinnerChecker()
    End Sub
    'this Function is() For determining the winner of the game
    Public Sub WinnerChecker()
        'UpperBox horizontal result 
        If btnupperleft.Text = btnupper.Text And btnupper.Text = btnupperright.Text And btnupperleft.Enabled = False Then
            PlayerChecker(btnupperleft.Text)
            'MiddeleBox horizontal result 
        ElseIf btnleft.Text = btnmiddle.Text And btnmiddle.Text = btnright.Text And btnleft.Enabled = False Then
            PlayerChecker(btnupperleft.Text)
            'BottomBox horizontal result 
        ElseIf btnbottomleft.Text = btnbottom.Text And btnbottom.Text = btnbottomright.Text And btnbottomleft.Enabled = False Then
            PlayerChecker(btnupperleft.Text)
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

End Class
