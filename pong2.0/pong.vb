Public Class pong

    Private courter As New Ccourt
    Private paddler As New Cpaddle
    Private ballers As New Cball
    Private scorer As New Cscore
    Private counter As Integer = 0 'counts everytime game ends
    Private paused As Boolean = False 'detects wether or not the game is paused



    Private Sub pong_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ballers.setballwidth(baller.Width) 'sets the variables for the size of the ball
        ballers.setballheight(baller.Height)

        courter.setleftbound(pingpongtable.Left + 5) 'sets where the boarders are for the ping pong table
        courter.setrightbound(pingpongtable.Left + pingpongtable.Width - 5)
        courter.settopbound(pingpongtable.Top + 5)
        courter.setbottombound(pingpongtable.Top + pingpongtable.Height - 5)
        courter.setcentercourt(pingpongtable.Left + pingpongtable.Width / 2)

        paddler.setlefth(leftpaddle.Height)
        paddler.setrighth(rightpaddle.Height)

        paddler.setlefttop(pingpongtable.Top + pingpongtable.Height / 2 - leftpaddle.Height / 2)
        paddler.setrighttop(pingpongtable.Top + pingpongtable.Height / 2 - rightpaddle.Height / 2)

        paddler.setleftface(leftpaddle.Left + leftpaddle.Width)
        paddler.setrightface(rightpaddle.Left)

    End Sub



    Private Sub paddletimer_Tick(sender As Object, e As EventArgs) Handles paddletimer.Tick


        If baller.Left < (courter.returncentercourt - ballers.returnballwidth / 2) And ballers.returnvelx < 0 Then 'we know ball is on left traveling left
            If (baller.Top + ballers.returnballheight / 2) > (leftpaddle.Top + paddler.returnlefth / 2) Then ' we know ball is below center 
                If (leftpaddle.Top + paddler.returnlefth) < courter.returnbottombound Then 'detects if paddle is at bottom of court
                    leftpaddle.Top += 4 'moves left paddle down 
                End If
            ElseIf (baller.Top + ballers.returnballheight / 2) < (leftpaddle.Top + paddler.returnlefth / 2) Then 'we know ballabovecenter
                If leftpaddle.Top > courter.returntopbound Then 'paddle is not yet at top of court
                    leftpaddle.Top -= 4 'move left paddle up 
                End If
            End If
        Else 'ball is not in left court or is moving away from left paddle
            If leftpaddle.Top < paddler.returnlefttop Then
                'left paddle is above initial start position
                leftpaddle.Top += 1 'move paddle down by 1 pixel
            ElseIf leftpaddle.Top > paddler.returnlefttop Then
                'left paddle is below initial start position
                leftpaddle.Top -= 1 'move paddle up by 1 pixel
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
    End Sub

    Private Sub balltimer_Tick(sender As Object, e As EventArgs) Handles balltimer.Tick
        baller.Top = baller.Top + ballers.returnvely 'move ball up or down by vy pixels
        baller.Left = baller.Left + ballers.returnvelx 'move ball left or right by vx pixels

        If baller.Top < courter.returntopbound Then
            baller.Top = courter.returntopbound
        End If
        'keep ball below upper boundary of court

        If baller.Top > (courter.returnbottombound - ballers.returnballheight) Then
            baller.Top = (courter.returnbottombound - ballers.returnballheight)
        End If
        'keep ball above lower boundary of court
        If baller.Top <= courter.returntopbound Or baller.Top >= (courter.returnbottombound - ballers.returnballheight) Then
            ballers.setvely(-1 * ballers.returnvely)
        End If
        'make ball "bounce"(change vertical direction of ball)
        If ballers.returnvelx < 0 Then 'ball is moving from right to left
            If baller.Top > (leftpaddle.Top - ballers.returnballheight) And baller.Top < (leftpaddle.Top + paddler.returnlefth) Then
                'vertical coordinates of ball and left paddle overlap
                If baller.Left <= paddler.returnleftface Then 'ball has made contact with left paddle
                    'change direction of ball and generate x and y vector values for ball
                    'based on randon selection of paddleZone values (+3 to -3)
                    Randomize()
                    paddler.setpaddlezone(CInt((Rnd() * 6) - 3))
                    Select Case paddler.returnpaddlezone()
                        Case 3
                            ballers.setvely(-5)
                            ballers.setvelx(2)
                        Case 2
                            ballers.setvely(-4)
                            ballers.setvelx(3)
                        Case 1
                            ballers.setvely(-3)
                            ballers.setvelx(4)
                        Case 0
                            ballers.setvely(0)
                            ballers.setvelx(5)
                        Case -1
                            ballers.setvely(3)
                            ballers.setvelx(4)
                        Case -2
                            ballers.setvely(4)
                            ballers.setvelx(3)
                        Case -3
                            ballers.setvely(5)
                            ballers.setvelx(2)
                    End Select
                End If
            Else
                If baller.Left <= courter.returnleftbound Then
                    'vertical coordinates of ball and left paddle do not overlap
                    'and ball has reached left boundary of court
                    scoreapoint()
                End If
            End If
        ElseIf ballers.returnvelx > 0 Then 'ball is moving from left to right
            If baller.Top > (rightpaddle.Top - ballers.returnballheight) And baller.Top < (rightpaddle.Top + paddler.returnrighth) Then
                'vertical coordinates of ball and right paddle overlap
                If (baller.Left + ballers.returnballwidth) > rightpaddle.Left Then
                    'ball has made contact with right paddle

                    'change direction of ball and generate x and y vector values for ball
                    'depending on calculated paddleZone value (+3 to -3)
                    Select Case paddler.returnpaddlezone()
                        Case 3
                            ballers.setvely(-5)
                            ballers.setvelx(-2)
                        Case 2
                            ballers.setvely(-4)
                            ballers.setvelx(-3)
                        Case 1
                            ballers.setvely(-3)
                            ballers.setvelx(-4)
                        Case 0
                            ballers.setvely(0)
                            ballers.setvelx(-5)
                        Case -1
                            ballers.setvely(3)
                            ballers.setvelx(-4)
                        Case -2
                            ballers.setvely(4)
                            ballers.setvelx(-3)
                        Case -3
                            ballers.setvely(5)
                            ballers.setvelx(-2)
                    End Select

                End If
            Else
                If baller.Left > (courter.returnrightbound - ballers.returnballwidth) Then
                    'vertical coordinates of ball and right paddle do not overlap
                    'and ball has reached right boundary of court
                    scoreapoint()
                End If
            End If
        End If
    End Sub

    Private Sub scoreapoint()
        balltimer.Enabled = False
        paddletimer.Enabled = False
        If baller.Left < paddler.returnleftface Then
            scorer.setrightscore(scorer.returnrightscore + 1)
            rightpaddlescore.Text += 1
        ElseIf baller.Left + ballers.returnballwidth > paddler.returnrightface Then
            scorer.setleftscore(scorer.returnleftscore + 1)
            leftpaddlescore.Text += 1
        End If
        baller.Visible = False
        If scorer.returnleftscore = 10 Then
            MsgBox("computer wins")
            Application.Restart()
        ElseIf scorer.returnrightscore = 10 Then
            MsgBox("user wins")
            Application.Restart()
        Else
            endofround()
        End If
    End Sub
    Private Sub endofround()
        leftpaddle.Top = paddler.returnlefttop 'reset left paddle position
        rightpaddle.Top = paddler.returnrighttop 'reset right paddle position

        baller.Top = rightpaddle.Top + paddler.returnrighth / 2 - ballers.returnballheight / 2
        'position ball in line with centre of right paddle
        baller.Left = paddler.returnrightface - baller.Width
        'place ball immediately to left of right paddle
        ballers.setvelx(-5) 'set ball's x vector value to -5
        'generate random y vector value for ball (5 to -5
        Randomize()
        ballers.setvely((Rnd() * 10) - 5)
        baller.Visible = True 'restore visibility of ball

        balltimer.Enabled = True 'restart tmrBall
        paddletimer.Enabled = True 'restart tmrPaddle
    End Sub


    Private Sub play_Click(sender As Object, e As EventArgs) Handles play.Click
        baller.Top = rightpaddle.Top + paddler.returnrighth / 2 - ballers.returnballheight / 2
        'position ball in line with centre of right paddle
        baller.Left = paddler.returnrightface - baller.Width
        'place ball immediately to left of right paddle
        baller.Visible = True 'make ball visible
        ballers.setvelx(-5) 'set ball's x vector to -5
        'generate random y vector value for ball (5 to -5)
        Randomize()
        ballers.setvely((Rnd() * 10) - 5)
        paddletimer.Enabled = True 'start tmrPaddle
        balltimer.Enabled = True 'start tmrBall
        play.Enabled = False 'disable Start button
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
                rightpaddle.Top -= 10
            End If
            If keyData = Keys.Down Then
                rightpaddle.Top += 10
            End If
        End If

    End Function
End Class
