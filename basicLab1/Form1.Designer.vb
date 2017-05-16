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
        Me.textOutput = New System.Windows.Forms.Label()
        Me.btnInside = New System.Windows.Forms.Button()
        Me.btnOutside = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textOutput
        '
        Me.textOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textOutput.Location = New System.Drawing.Point(94, 81)
        Me.textOutput.Name = "textOutput"
        Me.textOutput.Size = New System.Drawing.Size(100, 20)
        Me.textOutput.TabIndex = 0
        Me.textOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnInside
        '
        Me.btnInside.Location = New System.Drawing.Point(78, 133)
        Me.btnInside.Name = "btnInside"
        Me.btnInside.Size = New System.Drawing.Size(136, 23)
        Me.btnInside.TabIndex = 1
        Me.btnInside.Text = "Показать внутренние"
        Me.btnInside.UseVisualStyleBackColor = True
        '
        'btnOutside
        '
        Me.btnOutside.Location = New System.Drawing.Point(78, 162)
        Me.btnOutside.Name = "btnOutside"
        Me.btnOutside.Size = New System.Drawing.Size(136, 23)
        Me.btnOutside.TabIndex = 2
        Me.btnOutside.Text = "Показать внешние"
        Me.btnOutside.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnOutside)
        Me.Controls.Add(Me.btnInside)
        Me.Controls.Add(Me.textOutput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents textOutput As Label
    Friend WithEvents btnInside As Button
    Friend WithEvents btnOutside As Button
End Class
