Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim len As Double
        Dim width As Double
        Dim height As Double
        Dim amount As Double
        Dim cubeSide As Double
        Dim paralSide As Double

        Dim roundedLen As Double
        Dim roundedWidth As Double
        Dim roundedHeight As Double

        len = lengthTextBox.Text
        width = widthTextBox.Text
        height = heightTextBox.Text

        roundedLen = Math.Round(len, 2)
        roundedWidth = Math.Round(width, 2)
        roundedHeight = Math.Round(height, 2)

        roundedLengthLabel.Text = roundedLen
        roundedWidthLabel.Text = roundedWidth
        roundedHeightLabel.Text = roundedHeight

        amount = roundedHeight * roundedWidth * roundedLen
        cubeSide = Math.Round(Math.Pow(amount, 1 / 3), 1)
        paralSide = 2 * (roundedLen * roundedWidth + roundedWidth * roundedHeight + roundedLen * roundedHeight)
        resultLabel.Text = amount
        areaLabel.Text = paralSide
        sideLabel.Text = cubeSide
        diffLabel.Text = paralSide - 6 * Math.Pow(cubeSide, 2)

    End Sub

End Class
