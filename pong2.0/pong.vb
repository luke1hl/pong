Public Class pong




    Dim upFlag As Boolean = False 'True when left mouse button held down

    Dim dnFlag As Boolean = False 'True when right mouse button held down

    Dim breakCount As Integer = 0 'counter for tmrBreak clock ticks

    Dim intLCourt, intRcourt, intTCourt, intBCourt, intCCourt As Integer

    'left, right, top and bottom boundaries of court





    Private Sub pong_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
