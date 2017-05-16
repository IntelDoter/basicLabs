Public Class Form1
    Private Sub drawPoint(x As Integer, y As Integer, g As Graphics, pen As Pen)
        g.DrawRectangle(pen, x, y, 1, 1)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bit As Bitmap = New Bitmap(pic.Width, pic.Height)
        Dim g As Graphics = Graphics.FromImage(bit)
        Dim MyPen As Pen = New Pen(Color.White, 1)
        g.Clear(Color.Black)
        Randomize()
        Dim index As Integer = 0

        Do
            Dim randomX As Integer = pic.Width * Rnd() + 1
            Dim randomY As Integer = pic.Height * Rnd() + 1
            drawPoint(randomX, randomY, g, MyPen)
            index += 1
            pic.Image = bit
        Loop Until index > 1000

    End Sub
End Class
