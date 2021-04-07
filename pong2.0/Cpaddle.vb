Public Class Cpaddle
    Protected paddleZone As Integer 'the paddlezone
    Protected lefth As Integer
    Protected righth As Integer 'left and right paddle heights
    Protected lefttop As Integer
    Protected righttop As Integer 'y coordinate for the top of the paddle
    Protected leftface As Integer
    Protected rightface As Integer 'x coordinates face of paddle

    Sub setpaddlezone(input As Integer)
        paddleZone = input
    End Sub
    Function returnpaddlezone()
        Return paddleZone
    End Function

    Sub setlefth(input As Integer)
        lefth = input
    End Sub
    Function returnlefth()
        Return lefth
    End Function

    Sub setrighth(input As Integer)
        righth = input
    End Sub
    Function returnrighth()
        Return righth
    End Function

    Sub setlefttop(input As Integer)
        lefttop = input
    End Sub
    Function returnlefttop()
        Return lefttop
    End Function

    Sub setrighttop(input As Integer)
        righttop = input
    End Sub
    Function returnrighttop()
        Return righttop
    End Function

    Sub setleftface(input As Integer)
        leftface = input
    End Sub
    Function returnleftface()
        Return leftface
    End Function

    Sub setrightface(input As Integer)
        rightface = input
    End Sub
    Function returnrightface()
        Return rightface
    End Function
End Class
