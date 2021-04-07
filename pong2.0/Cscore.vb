Public Class Cscore
    Protected winScore As Integer = 11 'score that must be attained to win game

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


End Class
