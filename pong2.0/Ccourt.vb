Public Class Ccourt
    Protected leftbound As Integer
    Protected topbound As Integer
    Protected rightbound As Integer
    Protected bottombound As Integer
    Protected centercourt As Integer

    Sub setleftbound(input As Integer)
        leftbound = input
    End Sub
    Function returnleftbound()
        Return leftbound
    End Function

    Sub setrightbound(input As Integer)
        rightbound = input
    End Sub
    Function returnrightbound()
        Return rightbound
    End Function

    Sub setbottombound(input As Integer)
        bottombound = input
    End Sub
    Function returnbottombound()
        Return bottombound
    End Function

    Sub settopbound(input As Integer)
        topbound = input
    End Sub
    Function returntopbound()
        Return topbound
    End Function

    Sub setcentercourt(input As Integer)
        centercourt = input
    End Sub
    Function returncentercourt()
        Return centercourt
    End Function
    Sub endofround(form As pong, ballers As Cball, paddler As Cpaddle)
        form.leftpaddle.Top = paddler.returnlefttop 'reset left paddle position
        form.rightpaddle.Top = paddler.returnrighttop 'reset right paddle position

        form.baller.Top = form.rightpaddle.Top + paddler.returnrighth / 2 - ballers.returnballheight / 2
        'position ball in line with centre of right paddle
        form.baller.Left = paddler.returnrightface - form.baller.Width
        'place ball immediately to left of right paddle
        ballers.setvelx(-5) 'set ball's x vector value to -5
        'generate random y vector value for ball (5 to -5
        Randomize()
        ballers.setvely((Rnd() * 10) - 5)
        form.baller.Visible = True 'restore visibility of ball

        form.balltimer.Enabled = True 'restart tmrBall
        form.paddletimer.Enabled = True 'restart tmrPaddle
    End Sub





End Class
