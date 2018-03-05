<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Assignment3
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
        Me.btnPlayer1 = New System.Windows.Forms.Button()
        Me.lblDirection1 = New System.Windows.Forms.Label()
        Me.btnPlayer2 = New System.Windows.Forms.Button()
        Me.lblDirection3 = New System.Windows.Forms.Label()
        Me.lblDirection2 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.picPlayer2 = New System.Windows.Forms.PictureBox()
        Me.picPlayer1 = New System.Windows.Forms.PictureBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPlayer1
        '
        Me.btnPlayer1.BackColor = System.Drawing.Color.Tomato
        Me.btnPlayer1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer1.ForeColor = System.Drawing.Color.White
        Me.btnPlayer1.Location = New System.Drawing.Point(140, 320)
        Me.btnPlayer1.Name = "btnPlayer1"
        Me.btnPlayer1.Size = New System.Drawing.Size(101, 36)
        Me.btnPlayer1.TabIndex = 6
        Me.btnPlayer1.Text = "Dice of player1"
        Me.btnPlayer1.UseVisualStyleBackColor = False
        '
        'lblDirection1
        '
        Me.lblDirection1.AutoSize = True
        Me.lblDirection1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirection1.Location = New System.Drawing.Point(165, 281)
        Me.lblDirection1.Name = "lblDirection1"
        Me.lblDirection1.Size = New System.Drawing.Size(50, 14)
        Me.lblDirection1.TabIndex = 3
        Me.lblDirection1.Text = "Player 1"
        '
        'btnPlayer2
        '
        Me.btnPlayer2.BackColor = System.Drawing.Color.SlateBlue
        Me.btnPlayer2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer2.ForeColor = System.Drawing.Color.White
        Me.btnPlayer2.Location = New System.Drawing.Point(387, 320)
        Me.btnPlayer2.Name = "btnPlayer2"
        Me.btnPlayer2.Size = New System.Drawing.Size(105, 36)
        Me.btnPlayer2.TabIndex = 7
        Me.btnPlayer2.Text = "Dice of player2"
        Me.btnPlayer2.UseVisualStyleBackColor = False
        '
        'lblDirection3
        '
        Me.lblDirection3.AutoSize = True
        Me.lblDirection3.Font = New System.Drawing.Font("Stencil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirection3.Location = New System.Drawing.Point(252, 253)
        Me.lblDirection3.Name = "lblDirection3"
        Me.lblDirection3.Size = New System.Drawing.Size(129, 18)
        Me.lblDirection3.TabIndex = 2
        Me.lblDirection3.Text = "Number of dice"
        '
        'lblDirection2
        '
        Me.lblDirection2.AutoSize = True
        Me.lblDirection2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirection2.Location = New System.Drawing.Point(414, 281)
        Me.lblDirection2.Name = "lblDirection2"
        Me.lblDirection2.Size = New System.Drawing.Size(50, 14)
        Me.lblDirection2.TabIndex = 4
        Me.lblDirection2.Text = "Player 2"
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutput.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(285, 281)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(66, 57)
        Me.lblOutput.TabIndex = 5
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(210, 146)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(219, 40)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Candy Land"
        '
        'lblResult
        '
        Me.lblResult.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.lblResult.Location = New System.Drawing.Point(140, 199)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(352, 36)
        Me.lblResult.TabIndex = 1
        Me.lblResult.Text = "none"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Gainsboro
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.btnExit.ForeColor = System.Drawing.Color.Gray
        Me.btnExit.Location = New System.Drawing.Point(275, 444)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 26)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "&Surrender"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.btnClear.ForeColor = System.Drawing.Color.Gray
        Me.btnClear.Location = New System.Drawing.Point(275, 412)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 26)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "&New Game"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'picPlayer2
        '
        Me.picPlayer2.Image = Global.Assignment_3.My.Resources.Resources._2
        Me.picPlayer2.Location = New System.Drawing.Point(-1, -1)
        Me.picPlayer2.Name = "picPlayer2"
        Me.picPlayer2.Size = New System.Drawing.Size(29, 65)
        Me.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayer2.TabIndex = 10
        Me.picPlayer2.TabStop = False
        '
        'picPlayer1
        '
        Me.picPlayer1.Image = Global.Assignment_3.My.Resources.Resources._1
        Me.picPlayer1.Location = New System.Drawing.Point(28, -1)
        Me.picPlayer1.Name = "picPlayer1"
        Me.picPlayer1.Size = New System.Drawing.Size(36, 65)
        Me.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer1.TabIndex = 9
        Me.picPlayer1.TabStop = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(415, 71)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(158, 36)
        Me.lblID.TabIndex = 11
        Me.lblID.Text = "<Hyeongwoo Park>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Assigment 3 CS 115<2871>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<Winter><2015>"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(415, 107)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 12)
        Me.lblTime.TabIndex = 12
        '
        'Assignment3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(641, 650)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picPlayer2)
        Me.Controls.Add(Me.picPlayer1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblDirection2)
        Me.Controls.Add(Me.lblDirection3)
        Me.Controls.Add(Me.btnPlayer2)
        Me.Controls.Add(Me.lblDirection1)
        Me.Controls.Add(Me.btnPlayer1)
        Me.Name = "Assignment3"
        Me.Text = "Board Game"
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPlayer1 As System.Windows.Forms.Button
    Friend WithEvents lblDirection1 As System.Windows.Forms.Label
    Friend WithEvents btnPlayer2 As System.Windows.Forms.Button
    Friend WithEvents lblDirection3 As System.Windows.Forms.Label
    Friend WithEvents lblDirection2 As System.Windows.Forms.Label
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents picPlayer1 As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label

End Class
