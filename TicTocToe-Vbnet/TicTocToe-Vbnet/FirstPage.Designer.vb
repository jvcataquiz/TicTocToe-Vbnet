<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FirstPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FirstPage))
        Me.PictureBoxTitle = New System.Windows.Forms.PictureBox()
        Me.labelplayerone = New System.Windows.Forms.Label()
        Me.labelplayertwo = New System.Windows.Forms.Label()
        Me.textboxplayeronename = New System.Windows.Forms.TextBox()
        Me.textboxplayertwoname = New System.Windows.Forms.TextBox()
        Me.btnenter = New System.Windows.Forms.Button()
        Me.btnmusic = New System.Windows.Forms.Button()
        CType(Me.PictureBoxTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxTitle
        '
        Me.PictureBoxTitle.Image = CType(resources.GetObject("PictureBoxTitle.Image"), System.Drawing.Image)
        Me.PictureBoxTitle.Location = New System.Drawing.Point(-2, 12)
        Me.PictureBoxTitle.Name = "PictureBoxTitle"
        Me.PictureBoxTitle.Size = New System.Drawing.Size(336, 177)
        Me.PictureBoxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxTitle.TabIndex = 0
        Me.PictureBoxTitle.TabStop = False
        '
        'labelplayerone
        '
        Me.labelplayerone.AutoSize = True
        Me.labelplayerone.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelplayerone.Location = New System.Drawing.Point(12, 219)
        Me.labelplayerone.Name = "labelplayerone"
        Me.labelplayerone.Size = New System.Drawing.Size(150, 20)
        Me.labelplayerone.TabIndex = 1
        Me.labelplayerone.Text = "Enter Player 1 Name :"
        '
        'labelplayertwo
        '
        Me.labelplayertwo.AutoSize = True
        Me.labelplayertwo.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelplayertwo.Location = New System.Drawing.Point(12, 256)
        Me.labelplayertwo.Name = "labelplayertwo"
        Me.labelplayertwo.Size = New System.Drawing.Size(150, 20)
        Me.labelplayertwo.TabIndex = 2
        Me.labelplayertwo.Text = "Enter Player 2 Name :"
        '
        'textboxplayeronename
        '
        Me.textboxplayeronename.Cursor = System.Windows.Forms.Cursors.Hand
        Me.textboxplayeronename.Location = New System.Drawing.Point(158, 216)
        Me.textboxplayeronename.Name = "textboxplayeronename"
        Me.textboxplayeronename.PlaceholderText = "  Min 3 to Max 10 char "
        Me.textboxplayeronename.Size = New System.Drawing.Size(165, 23)
        Me.textboxplayeronename.TabIndex = 3
        Me.textboxplayeronename.TabStop = False
        '
        'textboxplayertwoname
        '
        Me.textboxplayertwoname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.textboxplayertwoname.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.textboxplayertwoname.Location = New System.Drawing.Point(158, 253)
        Me.textboxplayertwoname.MaxLength = 10
        Me.textboxplayertwoname.Name = "textboxplayertwoname"
        Me.textboxplayertwoname.PlaceholderText = "  Min 3 to Max 10 char "
        Me.textboxplayertwoname.Size = New System.Drawing.Size(165, 23)
        Me.textboxplayertwoname.TabIndex = 4
        Me.textboxplayertwoname.TabStop = False
        '
        'btnenter
        '
        Me.btnenter.BackColor = System.Drawing.Color.Red
        Me.btnenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnenter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnenter.FlatAppearance.BorderSize = 0
        Me.btnenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnenter.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnenter.ForeColor = System.Drawing.Color.SeaShell
        Me.btnenter.Location = New System.Drawing.Point(261, 287)
        Me.btnenter.Name = "btnenter"
        Me.btnenter.Size = New System.Drawing.Size(62, 29)
        Me.btnenter.TabIndex = 5
        Me.btnenter.Text = "Enter"
        Me.btnenter.UseVisualStyleBackColor = False
        '
        'btnmusic
        '
        Me.btnmusic.BackgroundImage = CType(resources.GetObject("btnmusic.BackgroundImage"), System.Drawing.Image)
        Me.btnmusic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmusic.FlatAppearance.BorderSize = 0
        Me.btnmusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmusic.Location = New System.Drawing.Point(12, 287)
        Me.btnmusic.Name = "btnmusic"
        Me.btnmusic.Size = New System.Drawing.Size(52, 45)
        Me.btnmusic.TabIndex = 6
        Me.btnmusic.UseVisualStyleBackColor = True
        '
        'FirstPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 344)
        Me.Controls.Add(Me.btnmusic)
        Me.Controls.Add(Me.btnenter)
        Me.Controls.Add(Me.textboxplayertwoname)
        Me.Controls.Add(Me.textboxplayeronename)
        Me.Controls.Add(Me.labelplayertwo)
        Me.Controls.Add(Me.labelplayerone)
        Me.Controls.Add(Me.PictureBoxTitle)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FirstPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TICTOCTOE"
        CType(Me.PictureBoxTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxTitle As PictureBox
    Friend WithEvents labelplayerone As Label
    Friend WithEvents labelplayertwo As Label
    Friend WithEvents textboxplayeronename As TextBox
    Friend WithEvents textboxplayertwoname As TextBox
    Friend WithEvents btnenter As Button
    Friend WithEvents btnmusic As Button
End Class
