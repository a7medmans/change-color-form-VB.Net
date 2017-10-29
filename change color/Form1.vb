Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TrackBar1.Maximum = 255
        TrackBar2.Maximum = 255
        TrackBar3.Maximum = 255
        TrackBar1.Minimum = 0
        TrackBar2.Minimum = 0
        TrackBar3.Minimum = 0

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll, TrackBar2.Scroll, TrackBar3.Scroll
        changecolor()
    End Sub
    Public Function changecolor()
        Dim r, g, b As Integer
        r = TrackBar1.Value
        g = TrackBar2.Value
        b = TrackBar3.Value
        Me.BackColor = Color.FromArgb(r, g, b)
    End Function
End Class
