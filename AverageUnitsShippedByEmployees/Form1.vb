Option Strict On
Public Class AverageWeeklyShippedByEmployees

    Const MAXIMUM_USER_INPUT As Integer = 5000  'constant integer MAXIMUM_USER_INPUT is declared, and has value of 5000
    Const MINIMUM_USER_INPUT As Integer = 0     'constant integer MINIMUM_USER_INPUT is declared, and has value of 0
    Const TOTAL_DAYS As Integer = 7             'constant integer TOTAL_DAYS is declared, and has value of 7

    Dim NUMBER_OF_EMPLOYEES As Integer = 3  'Integer NUMBER_OF_EMPLOYEES is declared, and has initial value of 3

    Dim dayCounter As Integer = 1   'Integer dayCounter is declared, and has initial value of 1
    Dim employeeCounter As Integer = 1  'Integer employeeCounter is declared, and has initial value of 1
    Dim arrayCounter As Integer 'Integer arrayCounter is declared
    Dim unitsShipped As Integer 'Integer unitsShipped is declared

    Dim averageOfEmployee1Input As Double = 0.0  'Integer averageOne is declared, and has initial value of 0.0
    Dim averageOfEmployee2Input As Double = 0.0  'Integer NUMBER_OF_EMPLOYEES is declared, and has initial value of 0.0
    Dim averageOfEmployee3Input As Double = 0.0    'Integer NUMBER_OF_EMPLOYEES is declared, and has initial value of 0.0
    Dim averageOfAllEmployees As Double = 0.0    'Integer NUMBER_OF_EMPLOYEES is declared, and has initial value of 0.0

    Dim unitsArray(MAXIMUM_USER_INPUT + 1, MINIMUM_USER_INPUT + 1) As Integer   'Array unitsArray is declared

    Dim userInput As String 'String userInput is declared
    Private txtEmployeeOneDisplay As Object

    ''' <summary>
    ''' handles Validation function
    ''' </summary>
    ''' <param name="userInput"></param>
    ''' <param name="unitsShipped"></param>
    ''' <returns></returns>
    Function Validation(ByVal userInput As String, ByRef unitsShipped As Integer) As Integer
        userInput = txtUnitsInput.Text  'userInput is declared as txtUnitsInput textbox
        If Not (Integer.TryParse(userInput, unitsShipped)) Then 'if user input is not a whole number
            lblAvgPerEmp.Text = "Please enter a Whole Number"   'Whole Number entery error
            dayCounter = dayCounter - 1 'dayCounter is decreased by 1
            txtUnitsInput.SelectAll()
            txtUnitsInput.Focus()
        Else
            'if user input is not in the valid range
            If Not (unitsShipped < MAXIMUM_USER_INPUT Or unitsShipped > MINIMUM_USER_INPUT) Then
                'display error
                lblAvgPerEmp.Text &= "Please enter units shipped quantity between " & MINIMUM_USER_INPUT.ToString() & " and " & MAXIMUM_USER_INPUT.ToString()
                dayCounter = dayCounter - 1 'decrease day by 1
                txtUnitsInput.SelectAll()
                txtUnitsInput.Focus()
            Else
                'If the data entered is not less than or equal to MAXIMUM_USER_INPUT
                If Not (employeeCounter <= NUMBER_OF_EMPLOYEES) Then
                    dayCounter = dayCounter - 1 'decrease day by 1
                    employeeCounter = employeeCounter - 1 'decrease employee number by 1
                Else
                    unitsArray(dayCounter - 1, employeeCounter - 1) = unitsShipped  'recall array

                    If employeeCounter = 1 Then     'If user is entering data for employee 1
                        'Display user input to lblEmployee1 output text box
                        txtEmployee1Output.Text += unitsArray(dayCounter - 1, employeeCounter - 1).ToString() & vbCrLf
                        lblDay.Text = "Day " & dayCounter + 1   'Display increased day in lblDay
                        dayCounter = dayCounter + 1 'Increase day by 1

                        If (dayCounter > TOTAL_DAYS) Then   'if dayCounter is greater than TOTAL_DAYS
                            For arrayCounter = 1 To MAXIMUM_USER_INPUT  'For loop
                                averageOfEmployee1Input += unitsArray(arrayCounter - 1, employeeCounter - 1) 'averageOfEmployee1Input is added to array to calculate average of employee 1 input
                            Next
                            'averageOfEmployee1Input is added to averageOfEmployee1Input and devided by TOTAL_DAYS
                            averageOfEmployee1Input = averageOfEmployee1Input / TOTAL_DAYS
                            'averageOfAllEmployees is added to averageOfEmployee1Input
                            averageOfAllEmployees += averageOfEmployee1Input
                            'formula for average and display result to lblAvgAnsForEmp1
                            lblAvgAnsForEmp1.Text = "Average: " & Math.Round(averageOfEmployee1Input, 2).ToString()
                            employeeCounter = 2 'set employeeCounter to 2
                            dayCounter = 1  'dayCounter is set to 1
                            lblDay.Text = "Day " & dayCounter   'day counter will now display DAY 1
                        End If

                    ElseIf employeeCounter = 2 Then  'If user is entering data for employee 1

                        'Display user input to lblEmployee1 output text box
                        txtEmployee2Output.Text += unitsArray(dayCounter - 1, employeeCounter - 1).ToString() & vbCrLf
                        lblDay.Text = "Day " & dayCounter + 1   'increase day by 1 each time
                        dayCounter = dayCounter + 1 'increase dayCounter by 1
                        If (dayCounter > TOTAL_DAYS) Then   'if dayCounter is greater than TOTAL_DAYS
                            For arrayCounter = 1 To TOTAL_DAYS  'For loop
                                averageOfEmployee2Input += unitsArray(arrayCounter - 1, employeeCounter - 1) 'averageOfEmployee2Input is added to array to calculate average of employee 2 input
                            Next
                            'averageOfEmployee2Input is added to averageOfEmployee2Input and devided by TOTAL_DAYS
                            averageOfEmployee2Input = averageOfEmployee2Input / TOTAL_DAYS
                            'averageOfAllEmployees is added to averageOfEmployee2Input
                            averageOfAllEmployees += averageOfEmployee2Input
                            'formula for average and display result to lblAvgAnsForEmp2
                            lblAvgAnsForEmp2.Text = "Average: " & Math.Round(averageOfEmployee2Input, 2).ToString()
                            employeeCounter = 3
                            dayCounter = 1
                            lblDay.Text = "Day " & dayCounter
                        End If

                    ElseIf employeeCounter = 3 Then 'EMPLOYEE THREE

                        'Display user input to lblEmployee3 output text box
                        txtEmployee3Output.Text += unitsArray(dayCounter - 1, employeeCounter - 1).ToString() & vbCrLf
                        lblDay.Text = "Day " & dayCounter + 1 'increase day by 1 each time
                        dayCounter = dayCounter + 1 'increase dayCounter by 1
                        If (dayCounter > TOTAL_DAYS) Then   'if dayCounter is greater than TOTAL_DAYS
                            'Loop through the array and calculate average
                            For arrayCounter = 1 To TOTAL_DAYS  'for loop
                                averageOfEmployee3Input += unitsArray(arrayCounter - 1, employeeCounter - 1)    'averageOfEmployee3Input is added to array to calculate average of employee 3 input
                            Next
                            'averageOfAllEmployees is added to averageOfEmployee3Input
                            averageOfAllEmployees += averageOfEmployee3Input
                            'formula for average and display result to lblAvgAnsForEmp3
                            lblAvgAnsForEmp3.Text = "Average: " & Math.Round(averageOfEmployee3Input, 2).ToString()
                            employeeCounter = 4 'employeeCounter is set to 4
                            dayCounter = 1  'dayCounter is set to 1
                            lblDay.Text = "Day " & dayCounter   'lblDay is set to default value of DAY 1
                            'averageOfEmployee1Input/TOTAL_DAYS is added to averageOfEmployee1Input
                            averageOfEmployee3Input = averageOfEmployee3Input / TOTAL_DAYS
                            'averageOfAllEmployees is devided by NUMBER_OF_EMPLOYEES
                            averageOfAllEmployees = averageOfAllEmployees / NUMBER_OF_EMPLOYEES
                            'final average output of all employees is desplayed here.
                            lblAvgPerEmp.Text = "Average per day: " & Math.Round(averageOfAllEmployees, 2).ToString()
                        End If
                    ElseIf employeeCounter = 4 Then
                        'do nothing
                    End If
                End If
            End If
        End If
        Return unitsShipped
    End Function

    ''' <summary>
    ''' Handles btnEnter click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Validation(userInput, unitsShipped) 'Validation function is called
        txtUnitsInput.Clear()
        txtUnitsInput.Focus()

        If employeeCounter > NUMBER_OF_EMPLOYEES Then   'if employeeCounter is greater than NUMBER_OF_EMPLOYEES
            btnEnter.Enabled = False    'btnEnter button is desabled
            txtUnitsInput.ReadOnly = True   'txtUnitsInput is set to ReadOnly
        End If

    End Sub

    ''' <summary>
    ''' Exit when pressed btnExit
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    ''' <summary>
    ''' Reset when pressed btnReset
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblAvgAnsForEmp1.Text = ""  'label lblAvgAnsForEmp1 is set to blank value
        lblAvgAnsForEmp2.Text = ""  'label lblAvgAnsForEmp2 is set to blank value
        lblAvgAnsForEmp3.Text = ""  'label lblAvgAnsForEmp3 is set to blank value
        lblAvgPerEmp.Text = ""  'label lblAvgPerEmp is set to blank value        
        txtEmployee1Output.Clear()  'textbox txtEmployee1Output is cleared
        txtEmployee2Output.Clear()  'textbox txtEmployee2Output is cleared
        txtEmployee3Output.Clear()  'textbox txtEmployee3Output is cleared
        txtUnitsInput.Clear()  'textbox txtUnitsInput is cleared
        lblDay.Text = "Day 1"   'label lblDay is set to default value of DAY 1
    End Sub

End Class
