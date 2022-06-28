Public Class Calculator

    Dim firstNum, secondNum As Decimal
    Dim operatorSelect As Boolean = False
    Dim operation As Integer

    Private Sub Num0_Click(sender As Object, e As EventArgs) Handles Num0.Click
        DisplayScreen.Text = DisplayScreen.Text & 0
    End Sub

    Private Sub Num1_Click(sender As Object, e As EventArgs) Handles Num1.Click
        DisplayScreen.Text = DisplayScreen.Text & 1
    End Sub

    Private Sub Num2_Click(sender As Object, e As EventArgs) Handles Num2.Click
        DisplayScreen.Text = DisplayScreen.Text & 2
    End Sub

    Private Sub Num3_Click(sender As Object, e As EventArgs) Handles Num3.Click
        DisplayScreen.Text = DisplayScreen.Text & 3
    End Sub

    Private Sub Num4_Click(sender As Object, e As EventArgs) Handles Num4.Click
        DisplayScreen.Text = DisplayScreen.Text & 4
    End Sub

    Private Sub Num5_Click(sender As Object, e As EventArgs) Handles Num5.Click
        DisplayScreen.Text = DisplayScreen.Text & 5
    End Sub

    Private Sub Num6_Click(sender As Object, e As EventArgs) Handles Num6.Click
        DisplayScreen.Text = DisplayScreen.Text & 6
    End Sub

    Private Sub Num7_Click(sender As Object, e As EventArgs) Handles Num7.Click
        DisplayScreen.Text = DisplayScreen.Text & 7
    End Sub

    Private Sub Num8_Click(sender As Object, e As EventArgs) Handles Num8.Click
        DisplayScreen.Text = DisplayScreen.Text & 8
    End Sub

    Private Sub Num9_Click(sender As Object, e As EventArgs) Handles Num9.Click
        DisplayScreen.Text = DisplayScreen.Text & 9
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayScreen.Text = ""
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        firstNum = DisplayScreen.Text
        DisplayScreen.Text = ""
        operatorSelect = True
        operation = 1 '+'
    End Sub

    Private Sub SubsButton_Click(sender As Object, e As EventArgs) Handles SubsButton.Click
        firstNum = DisplayScreen.Text
        DisplayScreen.Text = ""
        operatorSelect = True
        operation = 2 '-'
    End Sub

    Private Sub MulButton_Click(sender As Object, e As EventArgs) Handles MulButton.Click
        firstNum = DisplayScreen.Text
        DisplayScreen.Text = ""
        operatorSelect = True
        operation = 3 '*'
    End Sub

    Private Sub DivButton_Click(sender As Object, e As EventArgs) Handles DivButton.Click
        firstNum = DisplayScreen.Text
        DisplayScreen.Text = ""
        operatorSelect = True
        operation = 4 '/'
    End Sub

    Private Sub EqualButton_Click(sender As Object, e As EventArgs) Handles EqualButton.Click
        If operatorSelect = True Then
            secondNum = DisplayScreen.Text
            If operation = 1 Then
                DisplayScreen.Text = firstNum + secondNum
            ElseIf operation = 2 Then
                DisplayScreen.Text = firstNum - secondNum
            ElseIf operation = 3 Then
                DisplayScreen.Text = firstNum * secondNum
            Else
                If secondNum <> 0 Then
                    DisplayScreen.Text = firstNum / secondNum
                End If
            End If
            operatorSelect = True
        End If
    End Sub

    Private Sub DotButton_Click(sender As Object, e As EventArgs) Handles DotButton.Click
        If Not (DisplayScreen.Text.Contains(".")) Then
            DisplayScreen.Text += "."
        End If
    End Sub
End Class
