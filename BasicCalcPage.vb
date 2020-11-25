Public Class BasicCalcPage

    Public myCalc As New BasicCalculatorOperations("", "", "")

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        CalcResultBox.Text = ""
        LeftValue.Text = ""
        RightValue.Text = ""
    End Sub
    Private Sub ClearPrevBtn_Click(sender As Object, e As EventArgs) Handles ClearPrevBtn.Click
        PrevResultIndex.Text = ""
        PrevResult.Text = ""
    End Sub

    Private Sub Plus_Click(sender As Object, e As EventArgs) Handles Plus.Click
        Dim Result As String = ""

        myCalc.setLeft(LeftValue.Text)
        myCalc.setRight(RightValue.Text)
        myCalc.setOperator("+")

        myCalc.calculate()
        Result = myCalc.getResult()
        CalcResultBox.Text = Result
    End Sub

    Private Sub Minus_Click(sender As Object, e As EventArgs) Handles Minus.Click
        Dim Result As String = ""

        myCalc.setLeft(LeftValue.Text)
        myCalc.setRight(RightValue.Text)
        myCalc.setOperator("-")

        myCalc.calculate()
        Result = myCalc.getResult()
        CalcResultBox.Text = Result
    End Sub

    Private Sub Divide_Click(sender As Object, e As EventArgs) Handles Divide.Click
        Dim Result As String = ""

        myCalc.setLeft(LeftValue.Text)
        myCalc.setRight(RightValue.Text)
        myCalc.setOperator("/")

        myCalc.calculate()
        Result = myCalc.getResult()
        CalcResultBox.Text = Result
    End Sub
    Private Sub Multiply_Click(sender As Object, e As EventArgs) Handles Multiply.Click
        Dim Result As String = ""

        myCalc.setLeft(LeftValue.Text)
        myCalc.setRight(RightValue.Text)
        myCalc.setOperator("*")

        myCalc.calculate()
        Result = myCalc.getResult()
        CalcResultBox.Text = Result
    End Sub

    Private Sub GetPreviousResult_Click(sender As Object, e As EventArgs) Handles GetPreviousResult.Click
        Dim Result As String = ""
        Try
            Result = myCalc.getPreviousResult(CInt(PrevResultIndex.Text))
        Catch ex As Exception
            Result = "An error occured when attempting to get previous result ensure you entered a value from 1 to 10"
        End Try


        PrevResult.Text = Result
    End Sub

End Class
