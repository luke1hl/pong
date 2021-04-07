Public Class Cball
    Protected velx As Single
    Protected vely As Single
    Protected ballwidth As Integer
    Protected ballheight As Integer

    Function returnvelx()
        Return velx
    End Function
    Sub setvelx(input As Single)
        velx = input
    End Sub



    Function returnvely()
        Return vely
    End Function
    Sub setvely(input As Single)
        vely = input
    End Sub


    Function returnballwidth()
        Return ballwidth
    End Function
    Sub setballwidth(input As Integer)
        ballwidth = input
    End Sub


    Function returnballheight()
        Return ballheight
    End Function
    Sub setballheight(input As Integer)
        ballheight = input
    End Sub

End Class
