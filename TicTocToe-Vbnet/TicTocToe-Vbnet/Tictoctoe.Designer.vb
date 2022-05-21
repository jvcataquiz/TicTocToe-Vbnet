<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tictoctoe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tictoctoe))
        Me.btnupperleft = New System.Windows.Forms.Button()
        Me.btnupper = New System.Windows.Forms.Button()
        Me.btnupperright = New System.Windows.Forms.Button()
        Me.btnleft = New System.Windows.Forms.Button()
        Me.btnmiddle = New System.Windows.Forms.Button()
        Me.btnright = New System.Windows.Forms.Button()
        Me.btnbottomleft = New System.Windows.Forms.Button()
        Me.btnbottom = New System.Windows.Forms.Button()
        Me.btnbottomright = New System.Windows.Forms.Button()
        Me.btnquit = New System.Windows.Forms.Button()
        Me.btnnewgame = New System.Windows.Forms.Button()
        Me.LabelPlayer1 = New System.Windows.Forms.Label()
        Me.LabelPlayer2 = New System.Windows.Forms.Label()
        Me.LabelScore = New System.Windows.Forms.Label()
        Me.playeronescore = New System.Windows.Forms.Label()
        Me.playertwoscore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnupperleft
        '
        Me.btnupperleft.BackColor = System.Drawing.Color.Black
        Me.btnupperleft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupperleft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupperleft.Font = New System.Drawing.Font("Segoe UI", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnupperleft.ForeColor = System.Drawing.Color.White
        Me.btnupperleft.Location = New System.Drawing.Point(12, 71)
        Me.btnupperleft.Name = "btnupperleft"
        Me.btnupperleft.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnupperleft.Size = New System.Drawing.Size(100, 100)
        Me.btnupperleft.TabIndex = 0
        Me.btnupperleft.TabStop = False
        Me.btnupperleft.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnupperleft.UseVisualStyleBackColor = False
        '
        'btnupper
        '
        Me.btnupper.BackColor = System.Drawing.Color.Black
        Me.btnupper.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupper.Font = New System.Drawing.Font("Segoe UI", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnupper.ForeColor = System.Drawing.Color.White
        Me.btnupper.Location = New System.Drawing.Point(118, 71)
        Me.btnupper.Name = "btnupper"
        Me.btnupper.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnupper.Size = New System.Drawing.Size(100, 100)
        Me.btnupper.TabIndex = 1
        Me.btnupper.TabStop = False
        Me.btnupper.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnupper.UseVisualStyleBackColor = False
        '
        'btnupperright
        '
        Me.btnupperright.BackColor = System.Drawing.Color.Black
        Me.btnupperright.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupperright.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupperright.Font = New System.Drawing.Font("Segoe UI", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnupperright.ForeColor = System.Drawing.Color.White
        Me.btnupperright.Location = New System.Drawing.Point(224, 71)
        Me.btnupperright.Name = "btnupperright"
        Me.btnupperright.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnupperright.Size = New System.Drawing.Size(100, 100)
        Me.btnupperright.TabIndex = 2
        Me.btnupperright.TabStop = False
        Me.btnupperright.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnupperright.UseVisualStyleBackColor = False
        '
        'btnleft
        '
        Me.btnleft.BackColor = System.Drawing.Color.Black
        Me.btnleft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnleft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnleft.Font = New System.Drawing.Font("Segoe UI", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnleft.ForeColor = System.Drawing.Color.White
        Me.btnleft.Location = New System.Drawing.Point(12, 177)
        Me.btnleft.Name = "btnleft"
        Me.btnleft.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnleft.Size = New System.Drawing.Size(100, 100)
        Me.btnleft.TabIndex = 3
        Me.btnleft.TabStop = False
        Me.btnleft.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnleft.UseVisualStyleBackColor = False
        '
        'btnmiddle
        '
        Me.btnmiddle.BackColor = System.Drawing.Color.Black
        Me.btnmiddle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmiddle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmiddle.Font = New System.Drawing.Font("Segoe UI", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnmiddle.ForeColor = System.Drawing.Color.White
        Me.btnmiddle.Location = New System.Drawing.Point(118, 177)
        Me.btnmiddle.Name = "btnmiddle"
        Me.btnmiddle.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnmiddle.Size = New System.Drawing.Size(100, 100)
        Me.btnmiddle.TabIndex = 4
        Me.btnmiddle.TabStop = False
        Me.btnmiddle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnmiddle.UseVisualStyleBackColor = False
        '
        'btnright
        '
        Me.btnright.BackColor = System.Drawing.Color.Black
        Me.btnright.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnright.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnright.Font = New System.Drawing.Font("Segoe UI", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnright.ForeColor = System.Drawing.Color.White
        Me.btnright.Location = New System.Drawing.Point(224, 177)
        Me.btnright.Name = "btnright"
        Me.btnright.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnright.Size = New System.Drawing.Size(100, 100)
        Me.btnright.TabIndex = 5
        Me.btnright.TabStop = False
        Me.btnright.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnright.UseVisualStyleBackColor = False
        '
        'btnbottomleft
        '
        Me.btnbottomleft.BackColor = System.Drawing.Color.Black
        Me.btnbottomleft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbottomleft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbottomleft.Font = New System.Drawing.Font("Segoe UI", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnbottomleft.ForeColor = System.Drawing.Color.White
        Me.btnbottomleft.Location = New System.Drawing.Point(12, 284)
        Me.btnbottomleft.Name = "btnbottomleft"
        Me.btnbottomleft.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnbottomleft.Size = New System.Drawing.Size(100, 100)
        Me.btnbottomleft.TabIndex = 6
        Me.btnbottomleft.TabStop = False
        Me.btnbottomleft.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnbottomleft.UseVisualStyleBackColor = False
        '
        'btnbottom
        '
        Me.btnbottom.BackColor = System.Drawing.Color.Black
        Me.btnbottom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbottom.Font = New System.Drawing.Font("Segoe UI", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnbottom.ForeColor = System.Drawing.Color.White
        Me.btnbottom.Location = New System.Drawing.Point(118, 284)
        Me.btnbottom.Name = "btnbottom"
        Me.btnbottom.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnbottom.Size = New System.Drawing.Size(100, 100)
        Me.btnbottom.TabIndex = 7
        Me.btnbottom.TabStop = False
        Me.btnbottom.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnbottom.UseVisualStyleBackColor = False
        '
        'btnbottomright
        '
        Me.btnbottomright.BackColor = System.Drawing.Color.Black
        Me.btnbottomright.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbottomright.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbottomright.Font = New System.Drawing.Font("Segoe UI", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnbottomright.ForeColor = System.Drawing.Color.White
        Me.btnbottomright.Location = New System.Drawing.Point(224, 284)
        Me.btnbottomright.Name = "btnbottomright"
        Me.btnbottomright.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnbottomright.Size = New System.Drawing.Size(100, 100)
        Me.btnbottomright.TabIndex = 8
        Me.btnbottomright.TabStop = False
        Me.btnbottomright.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnbottomright.UseVisualStyleBackColor = False
        '
        'btnquit
        '
        Me.btnquit.BackColor = System.Drawing.Color.Red
        Me.btnquit.FlatAppearance.BorderSize = 0
        Me.btnquit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnquit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnquit.Location = New System.Drawing.Point(265, 401)
        Me.btnquit.Name = "btnquit"
        Me.btnquit.Size = New System.Drawing.Size(59, 23)
        Me.btnquit.TabIndex = 9
        Me.btnquit.Text = "QUIT"
        Me.btnquit.UseVisualStyleBackColor = False
        '
        'btnnewgame
        '
        Me.btnnewgame.BackColor = System.Drawing.Color.Yellow
        Me.btnnewgame.FlatAppearance.BorderSize = 0
        Me.btnnewgame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnewgame.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnnewgame.Location = New System.Drawing.Point(144, 401)
        Me.btnnewgame.Name = "btnnewgame"
        Me.btnnewgame.Size = New System.Drawing.Size(115, 23)
        Me.btnnewgame.TabIndex = 10
        Me.btnnewgame.Text = "NEW GAME"
        Me.btnnewgame.UseVisualStyleBackColor = False
        '
        'LabelPlayer1
        '
        Me.LabelPlayer1.AutoSize = True
        Me.LabelPlayer1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelPlayer1.ForeColor = System.Drawing.Color.Red
        Me.LabelPlayer1.Location = New System.Drawing.Point(200, 19)
        Me.LabelPlayer1.Name = "LabelPlayer1"
        Me.LabelPlayer1.Size = New System.Drawing.Size(66, 19)
        Me.LabelPlayer1.TabIndex = 11
        Me.LabelPlayer1.Text = "Player 1 :"
        '
        'LabelPlayer2
        '
        Me.LabelPlayer2.AutoSize = True
        Me.LabelPlayer2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelPlayer2.ForeColor = System.Drawing.Color.Red
        Me.LabelPlayer2.Location = New System.Drawing.Point(200, 38)
        Me.LabelPlayer2.Name = "LabelPlayer2"
        Me.LabelPlayer2.Size = New System.Drawing.Size(66, 19)
        Me.LabelPlayer2.TabIndex = 12
        Me.LabelPlayer2.Text = "Player 2 :"
        '
        'LabelScore
        '
        Me.LabelScore.AutoSize = True
        Me.LabelScore.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelScore.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelScore.Location = New System.Drawing.Point(274, 3)
        Me.LabelScore.Name = "LabelScore"
        Me.LabelScore.Size = New System.Drawing.Size(43, 15)
        Me.LabelScore.TabIndex = 13
        Me.LabelScore.Text = "SCORE"
        '
        'playeronescore
        '
        Me.playeronescore.AutoSize = True
        Me.playeronescore.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.playeronescore.Location = New System.Drawing.Point(272, 17)
        Me.playeronescore.Name = "playeronescore"
        Me.playeronescore.Size = New System.Drawing.Size(19, 21)
        Me.playeronescore.TabIndex = 14
        Me.playeronescore.Text = "0"
        '
        'playertwoscore
        '
        Me.playertwoscore.AutoSize = True
        Me.playertwoscore.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.playertwoscore.Location = New System.Drawing.Point(272, 35)
        Me.playertwoscore.Name = "playertwoscore"
        Me.playertwoscore.Size = New System.Drawing.Size(19, 21)
        Me.playertwoscore.TabIndex = 15
        Me.playertwoscore.Text = "0"
        '
        'Tictoctoe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.ClientSize = New System.Drawing.Size(338, 436)
        Me.ControlBox = False
        Me.Controls.Add(Me.playertwoscore)
        Me.Controls.Add(Me.playeronescore)
        Me.Controls.Add(Me.LabelScore)
        Me.Controls.Add(Me.LabelPlayer2)
        Me.Controls.Add(Me.LabelPlayer1)
        Me.Controls.Add(Me.btnnewgame)
        Me.Controls.Add(Me.btnquit)
        Me.Controls.Add(Me.btnbottomright)
        Me.Controls.Add(Me.btnbottom)
        Me.Controls.Add(Me.btnbottomleft)
        Me.Controls.Add(Me.btnright)
        Me.Controls.Add(Me.btnmiddle)
        Me.Controls.Add(Me.btnleft)
        Me.Controls.Add(Me.btnupperright)
        Me.Controls.Add(Me.btnupper)
        Me.Controls.Add(Me.btnupperleft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Tictoctoe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TicTocToe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnupperleft As Button
    Friend WithEvents btnupper As Button
    Friend WithEvents btnupperright As Button
    Friend WithEvents btnleft As Button
    Friend WithEvents btnmiddle As Button
    Friend WithEvents btnright As Button
    Friend WithEvents btnbottomleft As Button
    Friend WithEvents btnbottom As Button
    Friend WithEvents btnbottomright As Button
    Friend WithEvents btnquit As Button
    Friend WithEvents btnnewgame As Button
    Friend WithEvents LabelPlayer1 As Label
    Friend WithEvents LabelPlayer2 As Label
    Friend WithEvents LabelScore As Label
    Friend WithEvents playeronescore As Label
    Friend WithEvents playertwoscore As Label
End Class
