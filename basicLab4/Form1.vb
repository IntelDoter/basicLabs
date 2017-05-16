Public Class Form1
    Private Sub drawPoint(x As Integer, y As Integer, g As Graphics, pen As Pen)
        g.DrawRectangle(pen, x, y, 1, 1)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bit As Bitmap = New Bitmap(pic.Width, pic.Height) 'создаем рисунок
        Dim g As Graphics = Graphics.FromImage(bit) 'получаем графику для рисования
        Dim MyPen As Pen = New Pen(Color.White, 1) 'создаем перо с белым цветом и толщиной 1 пиксель
        g.Clear(Color.Black) 'очищаем полотно и красим в черный цвет
        Randomize() 'инициализируем генератор случайных чисел 
        Dim index As Integer = 0 'инициализируем счетчик нарисованных звезд
        Dim starCount As Integer = 1000 'инициализируем количество звезд, которые будут нарисованы

        'Do 'Начало цикла
        'Dim randomX As Integer = pic.Width * Rnd() + 1 'получаем случайную координату X
        'Dim randomY As Integer = pic.Height * Rnd() + 1 'получаем случайную координату Y
        'drawPoint(randomX, randomY, g, MyPen) 'рисуем точку, так как в basic нет метода для рисования точки, задаем собственную функцию
        'index += 1 'итерируем счетчик звезд
        'Loop Until index > starCount 'продолжать цикл, пока количество звезд не привысит заданное количество

        Dim randomX As Integer = pic.Width * Rnd() + 1
        Dim randomY As Integer = pic.Height * Rnd() + 1
        Dim r As Double = Math.Sqrt(Math.Pow(randomX, 2) + Math.Pow(randomY, 2))
        Dim fi As Double = Math.Atan(randomY / randomX)


        pic.Image = bit 'рисуем на PictureBox
    End Sub
End Class
