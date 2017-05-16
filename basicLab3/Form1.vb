Public Class Form1
    Dim bit As Bitmap
    Dim g As Graphics
    Dim MyPen As Pen
    Dim newZero As Integer = 300

    Function arcCos(x As Double)
        Return Math.Atan(-x / Math.Sqrt(-x * x + 1)) + 2 * Math.Atan(1)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()
        Dim len As Integer
        Dim aForDraw As Integer
        Dim bForDraw As Integer
        Dim cForDraw As Integer
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim sqrtA As Double
        Dim sqrtB As Double
        Dim sqrtC As Double
        Dim pointX As Integer
        Dim pointY As Integer
        Dim cosinus As Double
        Dim Numbers = New Integer(2) {}
        Dim square As Double
        Dim Random As Integer

        len = 100
        Random = Math.Round(len * Rnd() + 1) 'получаем случайное значение числа в пределах от 0 до 100
        Numbers(0) = Random 'записываем его в массив
        Numbers(1) = len - Random 'записываем разницы между начальным отрезком и случайным
        Array.Sort(Numbers) 'сортируем массив, таким образом последний элемент в массиве является наибольшим, так как массив сортируется по возрастанию
        Random = Math.Round(Numbers(2) * Rnd() + 1) 'проделываем аналогичную операцию для этого наибольшего числа
        Numbers(0) = Random
        Numbers(2) = Numbers(2) - Random
        Array.Sort(Numbers) 'получаем отсортированный массив, в котором последний элемент и является наибольшим

        Label2.Text = Str(Numbers(0)) + " " + Str(Numbers(1)) + " " + Str(Numbers(2))
        g.Clear(Color.White)
        a = Numbers(0)
        b = Numbers(1)
        c = Numbers(2)
        aForDraw = a * 10
        bForDraw = b * 10
        cForDraw = c * 10

        If (aForDraw + bForDraw - cForDraw > 0) Then
            cosinus = (Math.Pow(aForDraw, 2) + Math.Pow(cForDraw, 2) - Math.Pow(bForDraw, 2)) / (2 * aForDraw * cForDraw)
            pointX = newZero - Int(aForDraw * cosinus)
            pointY = newZero - Int(aForDraw * Math.Pow((1 - Math.Pow(cosinus, 2)), 1 / 2))

            g.DrawLine(MyPen, 0, newZero, cForDraw, newZero)
            g.DrawLine(MyPen, 0, newZero, pointX, pointY)
            g.DrawLine(MyPen, cForDraw, newZero, pointX, pointY)
            Label1.Text = "Построение выполнено"
        Else
            Label1.Text = "Построение невозможно"
        End If
        pic.Image = bit

        square = 0.5 * cForDraw * pointY / 100

        sqrtA = arcCos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c)) * (180 / Math.PI)
        sqrtB = arcCos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c)) * (180 / Math.PI)
        sqrtC = 180 - sqrtA - sqrtB

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bit = New Bitmap(pic.Width, pic.Height)
        g = Graphics.FromImage(bit)
        MyPen = New Pen(Color.Blue, 1)
    End Sub
End Class
