''' <summary>
''' Author: Rahulkumar Patel
''' Project Name: AvarageUnitsShipped
''' Date: 24-May-2018
''' Description: Application For finding avarage units shipped  in week per day.
''' </summary>

Public Class Form1

    'store the value of days
    Dim weeklyShippedUnits(7) As Integer
    'store sum of all days unit
    Dim sumForAverage As Integer = 0
    'store the result of average shipped units
    Dim avarageShippedUnits As Double = 0
    'counter value for increment
    Dim counterForArray As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tbWeekDataEntry_TextChanged(sender As Object, e As EventArgs) Handles tbWeekDataEntry.TextChanged

    End Sub

    Private Sub tbUnitsInput_TextChanged(sender As Object, e As EventArgs) Handles tbUnitsInput.TextChanged

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' Holds the user input as a string
        Dim userInput As String = ""
        ' Holds the user input if it converts to a Integer
        Dim userInputInteger As Integer = 0
        'minimum unit value
        Dim minimunUnits = 0
        'maximum unit value
        Dim maximumUnits = 1000
        'string for output
        Dim outputForWeeklyView As String = String.Empty


        'Take the user input from textbox and store in variable
        userInput = tbUnitsInput.Text
        'Try Parse the input for checking of integer
        'check the minimum value of input
        'check the maximum value of input
        'Make Resultant lable string empty
        If (Integer.TryParse(userInput, userInputInteger) AndAlso
           userInputInteger >= minimunUnits AndAlso
           userInputInteger <= maximumUnits) Then
            lbResult.Text = ""
            'store the current value in array index
            weeklyShippedUnits(counterForArray) = CInt((userInput))
            'display the unit value enter in input textbox in output textbox
            tbWeekDataEntry.Text += weeklyShippedUnits(counterForArray).ToString() + vbCrLf
            'Increment the counter for array
            counterForArray += 1
            'Focus on the textbox
            tbUnitsInput.ResetText()
            'Set the day as per data enter
            lbDays.Text = "Day" + (counterForArray + 1).ToString + ":"
        Else
            ' set selection start 0 for select of text in textbox
            tbUnitsInput.SelectionStart = 0
            'Selection upto the length of text string
            tbUnitsInput.SelectionLength = tbUnitsInput.Text.Length
            'display the error message on lable
            lbResult.Text = "Please Enter the units between 0 to 1000."
        End If
        'compare the length with counter
        If (counterForArray = weeklyShippedUnits.Length - 1) Then
            For indexForSum As Integer = 0 To weeklyShippedUnits.Length - 1 'Loop for sumation of Array value
                sumForAverage += weeklyShippedUnits(indexForSum)            'Array with appropriate index add in sumForAverage variable
            Next

            'calculate the average for all 7 days shipped unit
            avarageShippedUnits = Math.Round((sumForAverage / 7), 2)
            'display the output average in result lable
            lbResult.Text = "Average per day:" + (avarageShippedUnits).ToString
            'user input textbox readonly
            tbUnitsInput.ReadOnly = True
            'enter button disable
            btnEnter.Enabled = False
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Clear the input textbox for unit shipped
        tbUnitsInput.Clear()
        'to create the input textbox writable
        tbUnitsInput.ReadOnly = False
        'to enable the enter button
        btnEnter.Enabled = True
        'to reset sumforavarage variable as 0
        sumForAverage = 0
        'Reset varageshppedunit variable to 0
        avarageShippedUnits = 0
        'Do the focus on input textbox
        tbUnitsInput.Focus()
        'Clear weekly united shipped text box that show all the united enter by user
        tbWeekDataEntry.Clear()
        'Make empty the resultant lable
        lbResult.Text = ""
        'Reset Day show lable to day 1:
        lbDays.Text = "Day 1:"
        'Reset Increment variable to 0
        counterForArray = 0

        'Loop for the delete the array value.Loop start from 0 to length of array -1
        For resetTheArray As Integer = 0 To weeklyShippedUnits.Length - 1
            weeklyShippedUnits(resetTheArray) = 0                         ' weekly shipped unit array value 0
        Next

    End Sub

    'Exit the application on click of exit button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub lbDays_Click(sender As Object, e As EventArgs) Handles lbDays.Click

    End Sub
End Class
