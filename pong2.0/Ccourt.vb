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
    Sub endofround(form As pong, ballers As Cball, paddler As Cpaddle, bot As Boolean)
        form.leftpaddle.Top = paddler.returnlefttop
        form.rightpaddle.Top = paddler.returnrighttop

        form.baller.Top = form.rightpaddle.Top + paddler.returnrighth / 2 - ballers.returnballheight / 2
        form.baller.Left = paddler.returnrightface - form.baller.Width
        ballers.setvelx(-5)
        Randomize()
        ballers.setvely(CInt(Rnd() * 8) - 8)
        form.baller.Visible = True

        form.balltimer.Enabled = True
        form.paddletimer.Enabled = bot
    End Sub





End Class
