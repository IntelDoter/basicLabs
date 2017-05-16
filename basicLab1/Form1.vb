Public Class Form1
    Private x As Integer
    Private y As Integer

    Private Sub btnInside_Click(sender As Object, e As EventArgs) Handles btnInside.Click
        Dim k As Integer
        Dim m As Integer
        x = 1
        y = 2
        k = 3
        m = 4
        'Print x, y, k, m
        textOutput.Text = Str(x) + ", " + Str(y) + ", " + Str(k) + ", " + Str(m)
    End Sub

    Private Sub btnOutside_Click(sender As Object, e As EventArgs) Handles btnOutside.Click
        Dim k As Integer
        Dim m As Integer
        x = 5
        y = 6
        k = 7
        m = 8
        textOutput.Text = Str(x) + ", " + Str(y) + ", " + Str(k) + ", " + Str(m)
    End Sub

    Friend WithEvents iterateZ As Button

    Private Sub iterateZ_Click(sender As Object, e As EventArgs) Handles iterateZ.Click
        Static z As Integer = 0
        z += 1
        textOutput.Text = Str(z)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
