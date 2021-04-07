Public Class pong

    Dim paddleZone As Integer 'section of paddle that detects when the ball hits

    Dim winScore As Integer = 11 'score that must be attained to win game

    Dim scoreLeft, scoreRight, lastPoint As Integer 'game scores and last player to score

    Dim upFlag As Boolean = False 'True when left mouse button held down

    Dim dnFlag As Boolean = False 'True when right mouse button held down

    Dim breakCount As Integer = 0 'counter for tmrBreak clock ticks

    Dim intLCourt, intRcourt, intTCourt, intBCourt, intCCourt As Integer

    'left, right, top and bottom boundaries of court

    Dim intBallW, intBallH As Integer 'ball width and height

    Dim intPadLH, intPadRH As Integer 'left and right paddle heights

    Dim intPadLTop, intPadRTop As Integer 'initial y coordinate for top of paddles

    Dim intPadFaceL, intPadFaceR 'x coordinates for contact surfaces of left and right paddles

    Private Sub pong_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
