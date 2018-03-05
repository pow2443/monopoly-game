Option Strict On
Option Explicit On
'----------------------------------------------------------
' Assignment (Candy Land)
' by <Hyeongwoo Park>
' version 1.0
' Board Game
'----------------------------------------------------------
Public Class Assignment3

    Const intSQUARE_SIZE As Integer = 65
    Dim lblArray(35) As Label                   'array of labels that make up the game board
    Dim intRules(35) As Integer                 'parallel array containing rules for the squares corresponding to lblArray entries
    Dim rand As New Random                      'random
    Dim dice As Integer                         'Saving number of a dice       
    Dim initP1Position, initP2Position As New System.Drawing.Point(0, 0) 'Saving initial location to each picture
    Dim P1P2PosDistX As Integer                 'the value for when the pictures is on same place
    Dim p1Position As Integer                   'position of player 1 on board
    Dim p2Position As Integer                   'position of player 2 on board
    Dim isGameOver As Boolean = False           'for exit


    Private Function Random(ByRef dieSize As Integer) As Integer
        'Return a random integer in the range of 'size'
        Return rand.Next(dieSize) + 1

    End Function

    Private Sub Assignment3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'player1 starts first
        btnPlayer2.Enabled = False

        'clear the game result label
        lblResult.Text = ""

        'Output Time
        lblTime.Text = (DateString & " " & TimeString)

        'gets initial player markers locations
        initP1Position = picPlayer1.Location
        initP2Position = picPlayer2.Location
        'gets initial player markers distance in x
        P1P2PosDistX = initP1Position.X - initP2Position.X


        
        Dim intCount As Integer

        'This for..Next Loop sets properties of each label in the array. The Select..Case statement
        'places the labels around the edges of the form 
        For intCount = 0 To (lblArray.Length - 1)

            lblArray(intCount) = New Label
            lblArray(intCount).Size = New System.Drawing.Size(intSQUARE_SIZE, intSQUARE_SIZE)
            lblArray(intCount).BorderStyle = BorderStyle.FixedSingle
            lblArray(intCount).Name = "lbl" & intCount
            lblArray(intCount).Visible = True

            'The following line display the array index on each square
            If intCount = 0 Then

                lblArray(intCount).Text = "Start"


            ElseIf intCount = 35 Then

                lblArray(intCount).Text = "Finish Line"

            Else

                lblArray(intCount).Text = intCount.ToString

            End If


            Select Case intCount

                Case Is < 10
                    lblArray(intCount).Location = New System.Drawing.Point(intSQUARE_SIZE * intCount, 0)
                Case 10 To 18
                    lblArray(intCount).Location =
                        New System.Drawing.Point(intSQUARE_SIZE * 9, intSQUARE_SIZE * (intCount - 9))
                Case 19 To 27
                    lblArray(intCount).Location =
                        New System.Drawing.Point(intSQUARE_SIZE * 9 - intSQUARE_SIZE * (intCount - 18),
                                                 intSQUARE_SIZE * 9)
                Case 28 To 35
                    lblArray(intCount).Location =
                        New System.Drawing.Point(0, intSQUARE_SIZE * 9 - intSQUARE_SIZE * (intCount - 27))

            End Select


            ' Set colors of the labels
            Select Case intCount Mod 6
                Case 0
                    lblArray(intCount).BackColor = Color.MistyRose

                Case 1
                    lblArray(intCount).BackColor = Color.Yellow

                Case 2
                    lblArray(intCount).BackColor = Color.DeepSkyBlue

                Case 3
                    lblArray(intCount).BackColor = Color.Violet

                Case 4
                    lblArray(intCount).BackColor = Color.Lime

                Case 5

                    lblArray(intCount).BackColor = Color.Salmon

            End Select

            Controls.Add(lblArray(intCount))

        Next


        'Initialize special squares
        SetRules()

    End Sub

    'Set the rules to intRules
    Private Sub SetRules()

        lblArray(7).Text = "2 steps back"
        intRules(7) = -2

        'a new rule added
        lblArray(9).Text = "Airplane!"
        intRules(9) = Random(6)

        lblArray(13).Text = "1 step forward"
        intRules(13) = 1

        lblArray(19).Text = "2 steps forward"
        intRules(19) = 2

        lblArray(32).Text = "1 step back"
        intRules(32) = -1

    End Sub


    'Do math to move to new position
    Sub moving(ByRef movement As Integer, ByRef pic As PictureBox)

        'clear system label
        lblResult.Text = ""


        'Check the rule of position 
        'and apply the rule to player!
        If movement = 7 Then
            movement = movement + intRules(7)
            lblResult.Text = pic.Name.Substring(3) & " " & lblArray(7).Text
        ElseIf movement = 9 Then
            movement = movement + intRules(9)
            lblResult.Text = pic.Name.Substring(3) & " " & lblArray(9).Text
        ElseIf movement = 13 Then
            movement = movement + intRules(13)
            lblResult.Text = pic.Name.Substring(3) & " " & lblArray(13).Text
        ElseIf movement = 19 Then
            movement = movement + intRules(19)
            lblResult.Text = pic.Name.Substring(3) & " " & lblArray(19).Text
        ElseIf movement = 32 Then
            movement = movement + intRules(32)
            lblResult.Text = pic.Name.Substring(3) & " " & lblArray(32).Text
        End If

        'moving the picture to new position
        Select Case movement
            Case Is < 10
                pic.Location = New System.Drawing.Point(intSQUARE_SIZE * movement, 0)
            Case 10 To 18
                pic.Location =
                    New System.Drawing.Point(intSQUARE_SIZE * 9, intSQUARE_SIZE * (movement - 9))
            Case 19 To 27
                pic.Location =
                    New System.Drawing.Point(intSQUARE_SIZE * 9 - intSQUARE_SIZE * (movement - 18),
                                             intSQUARE_SIZE * 9)
            Case 28 To 35
                pic.Location =
                    New System.Drawing.Point(0, intSQUARE_SIZE * 9 - intSQUARE_SIZE * (movement - 27))
        End Select

        'always player1 right align 
        If pic.Name = "picPlayer1" Then
            pic.Left += P1P2PosDistX
        End If

    End Sub

    'To exit 
    Sub GameOver()
        btnPlayer1.Enabled = False
        btnPlayer2.Enabled = False
        isGameOver = True
    End Sub


    Private Sub btnPlayer1_Click(sender As Object, e As EventArgs) Handles btnPlayer1.Click

        'Cast a dice
        'Output the number of dice
        dice = Random(6)
        lblOutput.Text = dice.ToString

        'Save the position
        p1Position = p1Position + dice

        'check the position of player1
        'if the position is not over 35, keep going the game
        If p1Position < 35 Then
            moving(p1Position, picPlayer1)

        ElseIf p1Position = 35 Then
            btnPlayer1.Enabled = False
            btnPlayer2.Enabled = False
            moving(p1Position, picPlayer1)
            lblResult.Text = "Player1's Win"
            'focus exit button
            btnExit.Focus()
            'disable die buttons
            GameOver()

        ElseIf p1Position >= 36 Then
            p1Position = p1Position - dice

        End If

        If Not isGameOver Then
            'switches turn
            btnPlayer1.Enabled = False
            btnPlayer2.Enabled = True
        End If
        'focus player 2 button
        btnPlayer2.Focus()

    End Sub


    Private Sub btnPlayer2_Click(sender As Object, e As EventArgs) Handles btnPlayer2.Click

        'Cast a dice
        'Output the number of dice
        dice = Random(6)
        lblOutput.Text = dice.ToString


        'Save the position
        p2Position = p2Position + dice


        'check the position of player1
        'if the position is not over 35, keep going the game
        If p2Position < 35 Then
            moving(p2Position, picPlayer2)

        ElseIf p2Position = 35 Then

            btnPlayer1.Enabled = False
            btnPlayer2.Enabled = False
            moving(p2Position, picPlayer2)
            lblResult.Text = "Player2's Win"
            'focus exit button
            btnExit.Focus()
            'disable die buttons
            GameOver()

        ElseIf p2Position > 35 Then

            p2Position = p2Position - dice

        End If

        If Not isGameOver Then
            'switches turn
            btnPlayer1.Enabled = True
            btnPlayer2.Enabled = False
        End If

        'focus player 2 button
        btnPlayer1.Focus()
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'initializes and resets
        isGameOver = False
        p1Position = 0
        p2Position = 0
        picPlayer1.Location = initP1Position
        picPlayer2.Location = initP2Position
        btnPlayer1.Enabled = True
        btnPlayer2.Enabled = False
        lblOutput.Text = ""
        lblResult.Text = ""
    End Sub


    'Close the program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class


