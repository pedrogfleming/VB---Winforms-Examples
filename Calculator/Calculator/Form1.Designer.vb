<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtSecond = New System.Windows.Forms.TextBox()
        Me.lbFirstNumber = New System.Windows.Forms.Label()
        Me.lbSecondNumber = New System.Windows.Forms.Label()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(322, 26)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(121, 109)
        Me.btnPlus.TabIndex = 0
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Location = New System.Drawing.Point(322, 143)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(121, 109)
        Me.btnMinus.TabIndex = 1
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(322, 268)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(121, 109)
        Me.btnMultiply.TabIndex = 2
        Me.btnMultiply.Text = "x"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(37, 143)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(108, 31)
        Me.txtFirst.TabIndex = 3
        '
        'txtSecond
        '
        Me.txtSecond.Location = New System.Drawing.Point(602, 143)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(108, 31)
        Me.txtSecond.TabIndex = 4
        '
        'lbFirstNumber
        '
        Me.lbFirstNumber.AutoSize = True
        Me.lbFirstNumber.Location = New System.Drawing.Point(37, 91)
        Me.lbFirstNumber.Name = "lbFirstNumber"
        Me.lbFirstNumber.Size = New System.Drawing.Size(115, 25)
        Me.lbFirstNumber.TabIndex = 5
        Me.lbFirstNumber.Text = "First Number"
        '
        'lbSecondNumber
        '
        Me.lbSecondNumber.AutoSize = True
        Me.lbSecondNumber.Location = New System.Drawing.Point(602, 91)
        Me.lbSecondNumber.Name = "lbSecondNumber"
        Me.lbSecondNumber.Size = New System.Drawing.Size(141, 25)
        Me.lbSecondNumber.TabIndex = 6
        Me.lbSecondNumber.Text = "Second Number"
        '
        'txtResults
        '
        Me.txtResults.Location = New System.Drawing.Point(12, 402)
        Me.txtResults.Name = "txtResults"
        Me.txtResults.ReadOnly = True
        Me.txtResults.Size = New System.Drawing.Size(743, 31)
        Me.txtResults.TabIndex = 7
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtResults)
        Me.Controls.Add(Me.lbSecondNumber)
        Me.Controls.Add(Me.lbFirstNumber)
        Me.Controls.Add(Me.txtSecond)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Name = "Calculator"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPlus As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtSecond As TextBox
    Friend WithEvents lbFirstNumber As Label
    Friend WithEvents lbSecondNumber As Label
    Friend WithEvents txtResults As TextBox
End Class
