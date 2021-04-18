Public Class Cscore
    Protected winScore As Integer = 11 'score that must be attained to win game
    Protected courter As New Ccourt
    Protected leftscore As Integer
    Protected rightscore As Integer
    Protected lastPoint As Integer 'game scores and last player to score

    Sub setwinscore(input As Integer)
        winScore = input
    End Sub
    Function returnwinscore()
        Return winScore
    End Function

    Sub setrightscore(input As Integer)
        rightscore = input
    End Sub
    Function returnrightscore()
        Return rightscore
    End Function

    Sub setleftscore(input As Integer)
        leftscore = input
    End Sub
    Function returnleftscore()
        Return leftscore
    End Function

    Sub setlastpoint(input As Integer)
        lastPoint = input
    End Sub
    Function returnlastpoint()
        Return lastPoint
    End Function
    Sub scoreapoint(form As pong, paddler As Cpaddle, scorer As Cscore, ballers As Cball, bot As Boolean)
        form.balltimer.Enabled = False
        form.paddletimer.Enabled = False
        If form.baller.Left < paddler.returnleftface Then
            scorer.setrightscore(scorer.returnrightscore + 1)
            form.rightpaddlescore.Text += 1
        ElseIf form.baller.Left + ballers.returnballwidth > paddler.returnrightface Then
            scorer.setleftscore(scorer.returnleftscore + 1)
            form.leftpaddlescore.Text += 1
        End If
        form.baller.Visible = False
        If scorer.returnleftscore = 10 Then
            MsgBox("computer wins")
            Application.Restart()
        ElseIf scorer.returnrightscore = 10 Then
            MsgBox("user wins")
            Application.Restart()
        Else
            courter.endofround(form, ballers, paddler, bot)
        End If
    End Sub
End Class
