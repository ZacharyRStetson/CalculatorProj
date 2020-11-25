Imports System.Text.RegularExpressions

Public Class RefactorCalculatorOperations

    Public EquationTxt As String = ""
    Public calcOperator As String = ""
    Public ErrorMSG As String = ""
    Public calcReturn As String = ""
    Public PreviousResult(10) As String

    Public Sub New(Equation As String, myOperator As String)
        EquationTxt = Equation
        calcOperator = myOperator
    End Sub

    Public Function calculate(Equation As String) As String
        Dim EquationSplit As String()
        Dim TempIndex As Integer = 0
        Dim Pattern As String = "([*/+\-])"
        Dim Val1 As String = ""
        Dim Val2 As String = ""
        Dim ReplaceVal As String = ""
        Dim Total As Double = 0
        ErrorMSG = ""

        EquationSplit = Regex.Split(Equation, Pattern) 'splits the equation string using a regex pattern with +-*/ that will keep the operators for use later

        If EquationSplit(EquationSplit.Length - 1) = "" Or EquationSplit(0) = "" Then 'Catches the event in which a user enters an equation without a leading and ending digit
            ErrorMSG = "Equation must start and end with a digit"
            Return ErrorMSG
        End If
        'The following Do While loops execute in PEMDAS order to ensure correct calculation without the use of Datatable.Compute()

        Do While Array.FindIndex(EquationSplit, Function(s) s = "*") <> -1 'Checks the split string for multiplication operators and multiplies the two values in front of and behind the * operator
            TempIndex = Array.FindIndex(EquationSplit, Function(s) s = "*")
            Val1 = EquationSplit(TempIndex - 1)
            Val2 = EquationSplit(TempIndex + 1)
            EquationSplit(TempIndex + 1) = Nothing
            EquationSplit(TempIndex) = Nothing

            ReplaceVal = CDbl(Val1) * CDbl(Val2)
            EquationSplit(TempIndex - 1) = ReplaceVal
            EquationSplit = shiftArray(EquationSplit, TempIndex)
        Loop

        Do While Array.FindIndex(EquationSplit, Function(s) s = "/") <> -1 'Checks the split string for Divide operators and multiplies the two values in front of and behind the / operator
            TempIndex = Array.FindIndex(EquationSplit, Function(s) s = "/")
            Val1 = EquationSplit(TempIndex - 1)
            Val2 = EquationSplit(TempIndex + 1)
            EquationSplit(TempIndex + 1) = Nothing
            EquationSplit(TempIndex) = Nothing

            If Val2 = 0 Then
                ErrorMSG = "Error: Cannot divide by zero"
            Else
                ReplaceVal = CDbl(Val1) / CDbl(Val2)
            End If
            EquationSplit(TempIndex - 1) = ReplaceVal
            EquationSplit = shiftArray(EquationSplit, TempIndex)
        Loop

        Do While Array.FindIndex(EquationSplit, Function(s) s = "+") <> -1 'Checks the split string for Addition operators and multiplies the two values in front of and behind the / operator
            TempIndex = Array.FindIndex(EquationSplit, Function(s) s = "+")
            Val1 = EquationSplit(TempIndex - 1)
            Val2 = EquationSplit(TempIndex + 1)
            EquationSplit(TempIndex + 1) = Nothing
            EquationSplit(TempIndex) = Nothing


            ReplaceVal = CDbl(Val1) + CDbl(Val2)
            EquationSplit(TempIndex - 1) = ReplaceVal
            EquationSplit = shiftArray(EquationSplit, TempIndex)
        Loop

        Do While Array.FindIndex(EquationSplit, Function(s) s = "-") <> -1 'Checks the split string for Subtraction operators and multiplies the two values in front of and behind the / operator
            TempIndex = Array.FindIndex(EquationSplit, Function(s) s = "-")
            Val1 = EquationSplit(TempIndex - 1)
            Val2 = EquationSplit(TempIndex + 1)
            EquationSplit(TempIndex + 1) = Nothing
            EquationSplit(TempIndex) = Nothing


            ReplaceVal = CDbl(Val1) - CDbl(Val2)
            EquationSplit(TempIndex - 1) = ReplaceVal
            EquationSplit = shiftArray(EquationSplit, TempIndex)
        Loop

        calcReturn = EquationSplit(0) ' After calculation and shiftArray, result of equation will exist in the 0 index of the array

        If InStr(ErrorMSG, "Error:") Then
            Return ErrorMSG
        Else
            setPreviousResult()
            Return calcReturn
        End If
    End Function

    Public Sub setPreviousResult()
        For i As Integer = 10 To 1 Step -1
            PreviousResult(i) = PreviousResult(i - 1)
        Next
        PreviousResult(0) = calcReturn

    End Sub
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

    Public Function shiftArray(inputArray As Array, Index As Integer) As Array ' Shifts array so that all relevant data is at the begining
        For i As Integer = Index To (inputArray.Length - 3)
            inputArray(i) = inputArray(i + 2)
            inputArray(i + 2) = Nothing
        Next

        Return inputArray

    End Function
End Class
