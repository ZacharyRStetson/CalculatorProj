Public Class RefactorCalcPage
    Public myCalc As New RefactorCalculatorOperations("", "")
    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        CalcResult.Text = ""
        EquationStr.Text = ""
        MemIndex.Text = ""
    End Sub

    Private Sub Zero_Click(sender As Object, e As EventArgs) Handles Zero.Click
        EquationStr.Text = EquationStr.Text + "0"
    End Sub

    Private Sub One_Click(sender As Object, e As EventArgs) Handles One.Click
        EquationStr.Text = EquationStr.Text + "1"
    End Sub

    Private Sub Two_Click(sender As Object, e As EventArgs) Handles Two.Click
        EquationStr.Text = EquationStr.Text + "2"
    End Sub

    Private Sub Three_Click(sender As Object, e As EventArgs) Handles Three.Click
        EquationStr.Text = EquationStr.Text + "3"
    End Sub

    Private Sub Four_Click(sender As Object, e As EventArgs) Handles Four.Click
        EquationStr.Text = EquationStr.Text + "4"
    End Sub

    Private Sub Five_Click(sender As Object, e As EventArgs) Handles Five.Click
        EquationStr.Text = EquationStr.Text + "5"
    End Sub

    Private Sub Six_Click(sender As Object, e As EventArgs) Handles Six.Click
        EquationStr.Text = EquationStr.Text + "6"
    End Sub

    Private Sub Seven_Click(sender As Object, e As EventArgs) Handles Seven.Click
        EquationStr.Text = EquationStr.Text + "7"
    End Sub

    Private Sub Eight_Click(sender As Object, e As EventArgs) Handles Eight.Click
        EquationStr.Text = EquationStr.Text + "8"
    End Sub

    Private Sub Nine_Click(sender As Object, e As EventArgs) Handles Nine.Click
        EquationStr.Text = EquationStr.Text + "9"
    End Sub

    Private Sub Plus_Click(sender As Object, e As EventArgs) Handles Plus.Click
        If EquationStr.Text.Length > 0 Then ' Wont allow an operator at the begining of an equation
            If EquationStr.Text(EquationStr.Text.Length - 1) <> "+" Then ' this line ensure that the user wont enter in two + symbols back to back which causes and error
                EquationStr.Text = EquationStr.Text + "+"
            End If
        End If
    End Sub

    Private Sub Minus_Click(sender As Object, e As EventArgs) Handles Minus.Click
        If EquationStr.Text.Length > 0 Then ' Wont allow an operator at the begining of an equation
            If EquationStr.Text.Length > 0 And EquationStr.Text(EquationStr.Text.Length - 1) <> "-" Then ' this line ensure that the user wont enter in two - symbols back to back which causes and error
                EquationStr.Text = EquationStr.Text + "-"
            End If
        End If
    End Sub

    Private Sub Multiply_Click(sender As Object, e As EventArgs) Handles Multiply.Click
        If EquationStr.Text.Length > 0 Then ' Wont allow an operator at the begining of an equation
            If EquationStr.Text.Length > 0 And EquationStr.Text(EquationStr.Text.Length - 1) <> "*" Then ' this line ensure that the user wont enter in two * symbols back to back which causes and error
                EquationStr.Text = EquationStr.Text + "*"
            End If
        End If
    End Sub

    Private Sub Divide_Click(sender As Object, e As EventArgs) Handles Divide.Click
        If EquationStr.Text.Length > 0 Then ' Wont allow an operator at the begining of an equation
            If EquationStr.Text.Length > 0 And EquationStr.Text(EquationStr.Text.Length - 1) <> "/" Then ' this line ensure that the user wont enter in two / symbols back to back which causes and error
                EquationStr.Text = EquationStr.Text + "/"
            End If
        End If
    End Sub

    Private Sub Dec_Click(sender As Object, e As EventArgs) Handles Dec.Click
        If EquationStr.Text.Length = 0 Then 'Allows for entry of . at the front of equation string
            EquationStr.Text = EquationStr.Text + "."
        ElseIf EquationStr.Text.Length > 0 And EquationStr.Text(EquationStr.Text.Length - 1) <> "." Then ' this line ensure that the user wont enter in two . symbols back to back which causes and error
            EquationStr.Text = EquationStr.Text + "."
        End If
    End Sub

    Private Sub Equals_Click(sender As Object, e As EventArgs) Handles EqualsSymbol.Click
        Dim Result As String
        Result = myCalc.calculate(EquationStr.Text)

        CalcResult.Text = "= " + Result
    End Sub

    Private Sub MemRecall_Click(sender As Object, e As EventArgs) Handles MemRecall.Click
        Dim MemResult As String = ""

        Try
            MemResult = myCalc.getPreviousResult(CInt(MemIndex.Text))
        Catch ex As Exception
            MemResult = "Error: an invalid index was passed to Mem Recall"
        End Try


        CalcResult.Text = ""
        EquationStr.Text = ""

        CalcResult.Text = "MR(" + MemIndex.Text + "): " + MemResult

    End Sub
End Class