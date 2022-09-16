Public Class Calculator
    Dim firstNum, secondNum, result As Double
    Private ReadOnly errorMsg = "Please enter both numbers"
    Private Delegate Function ShowError(ByVal message As String)
    Dim invalidInput As ShowError = AddressOf MessageBox.Show


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        If txtFirst.Text <> "" And txtSecond.Text <> "" Then
            firstNum = CDbl(txtFirst.Text)
            secondNum = CDbl(txtSecond.Text)
            result = firstNum + secondNum
            txtResults.Text = $"The result of {firstNum} + {secondNum} = {result}"
        Else
            invalidInput(errorMsg)
        End If
        btnPlus.BackColor = Color.Aqua
        btnMinus.BackColor = Color.FromArgb(224, 224, 224)
        btnMultiply.BackColor = Color.FromArgb(224, 224, 224)
    End Sub

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtFirst_TextChanged(sender As Object, e As EventArgs) Handles txtFirst.TextChanged
        txtResults.Clear()
    End Sub

    Private Sub txtSecond_TextChanged(sender As Object, e As EventArgs) Handles txtSecond.TextChanged
        txtResults.Clear()
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        If txtFirst.Text <> "" And txtSecond.Text <> "" Then
            firstNum = CDbl(txtFirst.Text)
            secondNum = CDbl(txtSecond.Text)
            result = firstNum - secondNum
            txtResults.Text = $"The result of {firstNum} - {secondNum} = {result}"
        Else
            invalidInput(errorMsg)
        End If
        btnPlus.BackColor = Color.FromArgb(224, 224, 224)
        btnMinus.BackColor = Color.Aqua
        btnMultiply.BackColor = Color.FromArgb(224, 224, 224)
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        If txtFirst.Text <> "" And txtSecond.Text <> "" Then
            firstNum = CDbl(txtFirst.Text)
            secondNum = CDbl(txtSecond.Text)
            result = firstNum * secondNum
            txtResults.Text = $"The result of {firstNum} x {secondNum} = {result}"
        Else
            invalidInput(errorMsg)
        End If
        btnPlus.BackColor = Color.FromArgb(224, 224, 224)
        btnMinus.BackColor = Color.FromArgb(224, 224, 224)
        btnMultiply.BackColor = Color.Aqua
    End Sub
End Class
