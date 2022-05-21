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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.labelplayerone = New System.Windows.Forms.Label()
        Me.labelplayertwo = New System.Windows.Forms.Label()
        Me.textboxplayeronename = New System.Windows.Forms.TextBox()
        Me.textboxplayertwoname = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(336, 177)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        'FirstPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 328)
        Me.Controls.Add(Me.textboxplayertwoname)
        Me.Controls.Add(Me.textboxplayeronename)
        Me.Controls.Add(Me.labelplayertwo)
        Me.Controls.Add(Me.labelplayerone)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FirstPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TICTOCTOE"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents labelplayerone As Label
    Friend WithEvents labelplayertwo As Label
    Friend WithEvents textboxplayeronename As TextBox
    Friend WithEvents textboxplayertwoname As TextBox
End Class
