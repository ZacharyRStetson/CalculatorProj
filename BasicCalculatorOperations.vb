Public Class BasicCalculatorOperations

    Public LeftSide As String = ""
    Public RightSide As String = ""
    Public calcOperator As String = ""
    Public calcReturn As Double = 0
    Public ErrorMSG As String = ""
    Public PreviousResult(10) As String

    Public Sub New(left As String, right As String, myOperator As String)
        LeftSide = left
        RightSide = right
        calcOperator = myOperator
    End Sub

    Public Sub setLeft(value As String)
        LeftSide = value
    End Sub
    Public Sub setRight(value As String)
        RightSide = value
    End Sub

    Public Sub setOperator(value As String)
        calcOperator = value
    End Sub

    Public Sub calculate()
        ErrorMSG = ""
        'Client side validation
        If String.IsNullOrWhiteSpace(LeftSide) Or String.IsNullOrWhiteSpace(RightSide) Then 'Checks for blank entries in both left and right values
            ErrorMSG = "Error: You must enter a value for both left and right numbers for calculation to work"
        ElseIf IsNumeric(LeftSide) = False Or IsNumeric(RightSide) = False Then 'Checks for numeric values in both left and right values
            ErrorMSG = "Error: Only numbers are valid for the calculation"
        ElseIf calcOperator = "/" And RightSide = "0" Then 'Checks for dividing by Zero
            ErrorMSG = "Error: Cannot divide by 0"
        End If

        If ErrorMSG = "" Then 'If no error found then execute calculation
            Try
                If calcOperator = "+" Then
                    calcReturn = CInt(LeftSide) + CInt(RightSide)
                ElseIf calcOperator = "-" Then
                    calcReturn = CInt(LeftSide) - CInt(RightSide)
                ElseIf calcOperator = "/" Then
                    calcReturn = CInt(LeftSide) / CInt(RightSide)
                ElseIf calcOperator = "*" Then
                    calcReturn = CInt(LeftSide) * CInt(RightSide)
                End If
            Catch ex As OverflowException
                ErrorMSG = "Error: Overflow detected the result is too large or too small"
            End Try
        End If


    End Sub

    Public Function getResult() As String

        If InStr(ErrorMSG, "Error:") Then
            Return ErrorMSG
        Else
            setPreviousResult()
            Return CStr(calcReturn)
        End If
    End Function

    Public Function getPreviousResult(index As Int16) As String
        If index > 0 And index < 11 Then
            If PreviousResult(index) = Nothing Then
                Return "No previous result found, enter more calculations and try again"
            Else
                Return PreviousResult(index)
            End If
        Else
            Return "Error: you must select and index of 1-10"
        End If

    End Function

    Public Sub setPreviousResult()
        For i As Int16 = 10 To 1 Step -1
            PreviousResult(i) = PreviousResult(i - 1)
        Next
        PreviousResult(0) = CStr(calcReturn)

    End Sub

End Class

