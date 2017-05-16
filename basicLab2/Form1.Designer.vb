<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lengthLabel = New System.Windows.Forms.Label()
        Me.lengthTextBox = New System.Windows.Forms.TextBox()
        Me.widthTextBox = New System.Windows.Forms.TextBox()
        Me.widthLabel = New System.Windows.Forms.Label()
        Me.heightTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.roundedLengthLabel = New System.Windows.Forms.Label()
        Me.roundedWidthLabel = New System.Windows.Forms.Label()
        Me.roundedHeightLabel = New System.Windows.Forms.Label()
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.areaLabel = New System.Windows.Forms.Label()
        Me.sideLabel = New System.Windows.Forms.Label()
        Me.diffLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lengthLabel
        '
        Me.lengthLabel.AutoSize = True
        Me.lengthLabel.Location = New System.Drawing.Point(13, 13)
        Me.lengthLabel.Name = "lengthLabel"
        Me.lengthLabel.Size = New System.Drawing.Size(40, 13)
        Me.lengthLabel.TabIndex = 0
        Me.lengthLabel.Text = "Длина"
        Me.lengthLabel.UseMnemonic = False
        '
        'lengthTextBox
        '
        Me.lengthTextBox.Location = New System.Drawing.Point(70, 10)
        Me.lengthTextBox.Name = "lengthTextBox"
        Me.lengthTextBox.Size = New System.Drawing.Size(100, 20)
        Me.lengthTextBox.TabIndex = 1
        '
        'widthTextBox
        '
        Me.widthTextBox.Location = New System.Drawing.Point(70, 53)
        Me.widthTextBox.Name = "widthTextBox"
        Me.widthTextBox.Size = New System.Drawing.Size(100, 20)
        Me.widthTextBox.TabIndex = 3
        '
        'widthLabel
        '
        Me.widthLabel.AutoSize = True
        Me.widthLabel.Location = New System.Drawing.Point(13, 56)
        Me.widthLabel.Name = "widthLabel"
        Me.widthLabel.Size = New System.Drawing.Size(46, 13)
        Me.widthLabel.TabIndex = 2
        Me.widthLabel.Text = "Ширина"
        Me.widthLabel.UseMnemonic = False
        '
        'heightTextBox
        '
        Me.heightTextBox.Location = New System.Drawing.Point(70, 97)
        Me.heightTextBox.Name = "heightTextBox"
        Me.heightTextBox.Size = New System.Drawing.Size(100, 20)
        Me.heightTextBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Высота"
        Me.Label1.UseMnemonic = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(404, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Вычислить "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'roundedLengthLabel
        '
        Me.roundedLengthLabel.AutoSize = True
        Me.roundedLengthLabel.Location = New System.Drawing.Point(192, 13)
        Me.roundedLengthLabel.Name = "roundedLengthLabel"
        Me.roundedLengthLabel.Size = New System.Drawing.Size(0, 13)
        Me.roundedLengthLabel.TabIndex = 10
        '
        'roundedWidthLabel
        '
        Me.roundedWidthLabel.AutoSize = True
        Me.roundedWidthLabel.Location = New System.Drawing.Point(192, 60)
        Me.roundedWidthLabel.Name = "roundedWidthLabel"
        Me.roundedWidthLabel.Size = New System.Drawing.Size(0, 13)
        Me.roundedWidthLabel.TabIndex = 11
        '
        'roundedHeightLabel
        '
        Me.roundedHeightLabel.AutoSize = True
        Me.roundedHeightLabel.Location = New System.Drawing.Point(192, 104)
        Me.roundedHeightLabel.Name = "roundedHeightLabel"
        Me.roundedHeightLabel.Size = New System.Drawing.Size(0, 13)
        Me.roundedHeightLabel.TabIndex = 12
        '
        'resultLabel
        '
        Me.resultLabel.AutoSize = True
        Me.resultLabel.Location = New System.Drawing.Point(401, 17)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(0, 13)
        Me.resultLabel.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(323, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Объем"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(323, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Площадь"
        '
        'areaLabel
        '
        Me.areaLabel.AutoSize = True
        Me.areaLabel.Location = New System.Drawing.Point(404, 41)
        Me.areaLabel.Name = "areaLabel"
        Me.areaLabel.Size = New System.Drawing.Size(0, 13)
        Me.areaLabel.TabIndex = 18
        '
        'sideLabel
        '
        Me.sideLabel.AutoSize = True
        Me.sideLabel.Location = New System.Drawing.Point(404, 70)
        Me.sideLabel.Name = "sideLabel"
        Me.sideLabel.Size = New System.Drawing.Size(0, 13)
        Me.sideLabel.TabIndex = 19
        '
        'diffLabel
        '
        Me.diffLabel.AutoSize = True
        Me.diffLabel.Location = New System.Drawing.Point(404, 97)
        Me.diffLabel.Name = "diffLabel"
        Me.diffLabel.Size = New System.Drawing.Size(0, 13)
        Me.diffLabel.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(323, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Сторона"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(323, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Разница"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 163)
        Me.Controls.Add(Me.diffLabel)
        Me.Controls.Add(Me.sideLabel)
        Me.Controls.Add(Me.areaLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.roundedHeightLabel)
        Me.Controls.Add(Me.roundedWidthLabel)
        Me.Controls.Add(Me.roundedLengthLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.heightTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.widthTextBox)
        Me.Controls.Add(Me.widthLabel)
        Me.Controls.Add(Me.lengthTextBox)
        Me.Controls.Add(Me.lengthLabel)
        Me.Name = "Form1"
        Me.Text = "Вычисление площади и объема"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lengthLabel As Label
    Friend WithEvents lengthTextBox As TextBox
    Friend WithEvents widthTextBox As TextBox
    Friend WithEvents widthLabel As Label
    Friend WithEvents heightTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents roundedLengthLabel As Label
    Friend WithEvents roundedWidthLabel As Label
    Friend WithEvents roundedHeightLabel As Label
    Friend WithEvents resultLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents areaLabel As Label
    Friend WithEvents sideLabel As Label
    Friend WithEvents diffLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
