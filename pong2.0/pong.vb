Public Class pong

    Private courter As New Ccourt
    Private paddler As New Cpaddle
    Private ballers As New Cball
    Private scorer As New Cscore
    Private counter As Integer = 0 'counts everytime game ends
    Private paused As Boolean = False 'detects wether or not the game is paused
    Private hacks As Boolean = False 'used to activate user hacks


    Private Sub pong_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ballers.setballwidth(baller.Width) 'sets the variables for the size of the ball
        ballers.setballheight(baller.Height)

        courter.setleftbound(pingpongtable.Left + 5) 'sets where the boarders are for the ping pong table
        courter.setrightbound(pingpongtable.Left + pingpongtable.Width - 5) 'basically makes a mini rectangle in the rectangle
        courter.settopbound(pingpongtable.Top + 5)
        courter.setbottombound(pingpongtable.Top + pingpongtable.Height - 5)
        courter.setcentercourt(pingpongtable.Left + pingpongtable.Width / 2)

        paddler.setlefth(leftpaddle.Height) 'sets the height of the paddles
        paddler.setrighth(rightpaddle.Height)

        paddler.setlefttop(pingpongtable.Top + pingpongtable.Height / 2 - leftpaddle.Height / 2) 'sets the y coordinate of the top of the paddle
        paddler.setrighttop(pingpongtable.Top + pingpongtable.Height / 2 - rightpaddle.Height / 2)

        paddler.setleftface(leftpaddle.Left + leftpaddle.Width) 'sets the x coordinate for the face of paddle
        paddler.setrightface(rightpaddle.Left)

    End Sub

    Private Sub balltimer_Tick(sender As Object, e As EventArgs) Handles balltimer.Tick
        baller.Top = baller.Top + ballers.returnvely 'each tick it moves the ball by the x velocity and the y velocity
        baller.Left = baller.Left + ballers.returnvelx


        If baller.Top < courter.returntopbound Then
            baller.Top = courter.returntopbound
        End If
        If baller.Top > (courter.returnbottombound - ballers.returnballheight) Then
            baller.Top = (courter.returnbottombound - ballers.returnballheight)
        End If


        If baller.Top <= courter.returntopbound Or baller.Top >= (courter.returnbottombound - ballers.returnballheight) Then
            ballers.setvely(-1 * ballers.returnvely) 'flips the vertical vector of the ball when it hits the boundry
        End If

        If ballers.returnvelx < 0 Then 'ball is moving from right to left
            If baller.Top > (leftpaddle.Top - ballers.returnballheight) And baller.Top < (leftpaddle.Top + paddler.returnlefth) Then 'hits the paddle
                If baller.Left <= paddler.returnleftface Then

                    Randomize()
                    Select Case CInt((Rnd() * 6) + 0)
                        Case 0
                            ballers.setvely(-5)   'this all basically sends the ball the otherway and randomly choses a vector for it to be sent at
                            ballers.setvelx(2)
                        Case 1
                            ballers.setvely(-4)
                            ballers.setvelx(3) 'all x vel is positive as it goes left to right
                        Case 2
                            ballers.setvely(-3)
                            ballers.setvelx(4)
                        Case 3
                            ballers.setvely(0)
                            ballers.setvelx(5)
                        Case 4
                            ballers.setvely(3)
                            ballers.setvelx(4)
                        Case 5
                            ballers.setvely(4)
                            ballers.setvelx(3)
                        Case 6
                            ballers.setvely(5)
                            ballers.setvelx(2)
                    End Select
                End If
            Else
                If baller.Left <= courter.returnleftbound Then

                    scorer.scoreapoint(Me, paddler, scorer, ballers)
                End If
            End If
        ElseIf ballers.returnvelx > 0 Then 'ball is moving from left to right
            If baller.Top > (rightpaddle.Top - ballers.returnballheight) And baller.Top < (rightpaddle.Top + paddler.returnrighth) Then
                If (baller.Left + ballers.returnballwidth) > rightpaddle.Left Then


                    Select Case CInt((Rnd() * 6) + 0)
                        Case 0
                            ballers.setvely(-5)
                            ballers.setvelx(-2) 'same as above but for right paddle
                        Case 1
                            ballers.setvely(-4)
                            ballers.setvelx(-3)
                        Case 2
                            ballers.setvely(-3)
                            ballers.setvelx(-4)
                        Case 3
                            ballers.setvely(0)
                            ballers.setvelx(-5)
                        Case 4
                            ballers.setvely(3)
                            ballers.setvelx(-4)
                        Case 5
                            ballers.setvely(4)
                            ballers.setvelx(-3)
                        Case 6
                            ballers.setvely(5)
                            ballers.setvelx(-2)
                    End Select

                End If
            Else
                If baller.Left > (courter.returnrightbound - ballers.returnballwidth) Then

                    scorer.scoreapoint(Me, paddler, scorer, ballers)
                End If
            End If
        End If
    End Sub

    Private Sub paddletimer_Tick(sender As Object, e As EventArgs) Handles paddletimer.Tick
        'this is the bot code for the left bat but it is rather dodgy but i tried

        If ballers.returnvelx < 0 Then 'detects when the balls moving towards it 
            If (baller.Top + ballers.returnballheight / 2) > (leftpaddle.Top + paddler.returnlefth / 2) Then ' if balls above center
                If (leftpaddle.Top + paddler.returnlefth) < courter.returnbottombound Then 'means it won't move if its already at the bottom of the court
                    leftpaddle.Top += 3 'moves computer paddle down 
                End If
            ElseIf (baller.Top + ballers.returnballheight / 2) < (leftpaddle.Top + paddler.returnlefth / 2) Then 'balls above center
                If leftpaddle.Top > courter.returntopbound Then 'wont move if already at top
                    leftpaddle.Top -= 3 'move computer paddle up 
                End If
            End If

        Else 'moves back to the middle after hitting the ball
            If leftpaddle.Top < paddler.returnlefttop Then

                leftpaddle.Top += 1
            ElseIf leftpaddle.Top > paddler.returnlefttop Then

                leftpaddle.Top -= 1
            End If
        End If


        'make sure left paddle is between top and bottom borders of court
        If leftpaddle.Top < courter.returntopbound Then
            leftpaddle.Top = courter.returntopbound
        ElseIf leftpaddle.Top > (courter.returnbottombound - paddler.returnlefth) Then
            leftpaddle.Top = (courter.returnbottombound - paddler.returnlefth)
        End If


        'make sure right paddle is between top and bottom boundaries of court
        If rightpaddle.Top < courter.returntopbound Then
            rightpaddle.Top = courter.returntopbound
        ElseIf rightpaddle.Top > (courter.returnbottombound - paddler.returnrighth) Then
            rightpaddle.Top = (courter.returnbottombound - paddler.returnrighth)
        End If


        'used to test but basically hacks for user
        If hacks = True Then
            rightpaddle.Top = baller.Top - 10
        End If
    End Sub



    Private Sub play_Click(sender As Object, e As EventArgs) Handles play.Click
        baller.Top = rightpaddle.Top + paddler.returnrighth / 2 - ballers.returnballheight / 2 'resets positions
        baller.Left = paddler.returnrightface - baller.Width
        baller.Visible = True
        ballers.setvelx(-5) 'this will make sure its going to the bot to start and then it will randomly pick y vector to make it more random
        Randomize()
        ballers.setvely(CInt(Rnd() * 8) - 8)
        paddletimer.Enabled = True
        balltimer.Enabled = True
        play.Enabled = False
    End Sub

    Private Sub Pause_Click(sender As Object, e As EventArgs) Handles Pause.Click
        If paused = False Then
            Pause.Text = "resume"
            balltimer.Enabled = False
            paddletimer.Enabled = False
            paused = True
        Else
            Pause.Text = "pause"
            balltimer.Enabled = True
            paddletimer.Enabled = True
            paused = False
        End If

    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        Application.Restart()
    End Sub

    Private Sub Escape_Click(sender As Object, e As EventArgs) Handles Escape.Click
        Me.Close()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If balltimer.Enabled = True Then
            If keyData = Keys.Up Then
                rightpaddle.Top -= 10 'detects key presses for up down and turn on cheats
            End If
            If keyData = Keys.Down Then
                rightpaddle.Top += 10
            End If
            If keyData = Keys.L Then
                If hacks = True Then
                    hacks = False
                Else
                    hacks = True
                End If
            End If
        End If

    End Function
End Class
