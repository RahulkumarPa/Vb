''' <summary>
''' Author: Rahulkumar Patel
''' Project Name: Semester Average
''' Date: 10-June-2018
''' Description: Application For calculating Semester Average Grade
'''              of 6 subjects in VB.
''' </summary>
Public Class frmSemesterAverage
    'To store the value of all courses it's 6
    Dim semesterGrade(6) As Double
    'sum of all course's mark
    Dim sumForAverage As Double = 0
    'Store Average of all course's mark
    Dim averageGrade As Double = 0
    'To take userInput
    Dim userInputDouble As Double = 0
    'Both are use to check limmite 0 & 100
    Dim minimunMark As Double = 0
    Dim maximumMark As Double = 100

    Private Sub frmSemesterAverage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        For indexForSum As Integer = 0 To semesterGrade.Length - 1 'Loop for Array and start from 0 to length of array -1
            sumForAverage += semesterGrade(indexForSum)            'Array with index add in sumForAverage variable
        Next

        averageGrade = Math.Round((sumForAverage / 6), 2)           'calculation for averagemarks and store in 2 decimal
        lbSemesterAverageMarks.Text = averageGrade.ToString          'show averagemarks in lable
        lbAverageSemesterGrade.Text = displayGrade(averageGrade)     'Call thefunction for determaine the  grade

        'disable all textboxes
        tbCourse1.ReadOnly = True
        tbCourse2.ReadOnly = True
        tbCourse3.ReadOnly = True
        tbCourse4.ReadOnly = True
        tbCourse5.ReadOnly = True
        tbCourse6.ReadOnly = True
    End Sub

    'Create a function which use to find course grade based on marks which are user input
    Function displayGrade(ByVal mark As Double) As String
        If (mark >= 90 AndAlso mark <= 100) Then
            Dim ForAplus As String = "A+"
            Return ForAplus
        ElseIf (mark >= 85 AndAlso mark <= 89) Then
            Dim ForA As String = "A"
            Return ForA
        ElseIf (mark >= 80 AndAlso mark <= 84) Then
            Dim ForAMinus As String = "A-"
            Return ForAMinus
        ElseIf (mark >= 77 AndAlso mark <= 79) Then
            Dim ForBplus As String = "B+"
            Return ForBplus
        ElseIf (mark >= 73 AndAlso mark <= 76) Then
            Dim ForB As String = "B"
            Return ForB
        ElseIf (mark >= 70 AndAlso mark <= 72) Then
            Dim ForBMinus As String = "B-"
            Return ForBMinus
        ElseIf (mark >= 67 AndAlso mark <= 69) Then
            Dim ForCplus As String = "C+"
            Return ForCplus
        ElseIf (mark >= 63 AndAlso mark <= 66) Then
            Dim ForC As String = "C"
            Return ForC
        ElseIf (mark >= 60 AndAlso mark <= 62) Then
            Dim ForCMinus As String = "C-"
            Return ForCMinus
        ElseIf (mark >= 57 AndAlso mark <= 59) Then
            Dim ForDplus As String = "D+"
            Return ForDplus
        ElseIf (mark >= 53 AndAlso mark <= 56) Then
            Dim ForD As String = "D"
            Return ForD
        ElseIf (mark >= 50 AndAlso mark <= 52) Then
            Dim ForDMinus As String = "D-"
            Return ForDMinus
        ElseIf (mark >= 0 AndAlso mark <= 49) Then
            Dim ForF As String = "F"
            Return ForF
        End If

    End Function

    Private Sub tbCourse1_LostFocus(sender As Object, e As EventArgs) Handles tbCourse1.LostFocus
        Dim userInputCourse1 As String = ""                                 'new variable for userinput
        userInputCourse1 = tbCourse1.Text                                   'Course 1 textbox input store in new variable
        'validate user input is in range or not
        If (Double.TryParse(userInputCourse1, userInputDouble) AndAlso
           userInputDouble >= minimunMark AndAlso
           userInputDouble <= maximumMark) Then

            lbCourse1SemesterGrade.Text = displayGrade(userInputDouble)      'Call the function 
            semesterGrade(0) = userInputDouble                              'Store the user input in array
            lbResult.Text = ""                                               'create  the error lable and it's empty

        Else
            tbCourse1.Focus()                                              'Course 1 textbox get focus if envalid
            tbCourse1.SelectionStart = 0                                   'selection start from 0 
            tbCourse1.SelectionLength = tbCourse1.Text.Length              'selection up to end of text length
            lbResult.Text = "Please enter Valid number in Course 1 between 0 and 100!" + vbCrLf 'Print the error message in error label

        End If
    End Sub

    Private Sub tbCourse2_LostFocus(sender As Object, e As EventArgs) Handles tbCourse2.LostFocus
        Dim userInputCourse2 As String = ""
        userInputCourse2 = tbCourse2.Text
        If (Double.TryParse(userInputCourse2, userInputDouble) AndAlso
           userInputDouble >= minimunMark AndAlso
           userInputDouble <= maximumMark) Then

            lbCourse2SemesterGrade.Text = displayGrade(userInputDouble)
            semesterGrade(1) = userInputDouble
            lbResult.Text = ""

        Else
            tbCourse2.Focus()
            tbCourse2.SelectionStart = 0
            tbCourse2.SelectionLength = tbCourse1.Text.Length
            lbResult.Text = "Please enter Valid number in Course 2 between 0 and 100!" + vbCrLf

        End If
    End Sub

    Private Sub tbCourse3_LostFocus(sender As Object, e As EventArgs) Handles tbCourse3.LostFocus
        Dim userInputCourse3 As String = ""
        userInputCourse3 = tbCourse3.Text
        If (Double.TryParse(userInputCourse3, userInputDouble) AndAlso
           userInputDouble >= minimunMark AndAlso
           userInputDouble <= maximumMark) Then

            lbCourse3SemesterGrade.Text = displayGrade(userInputDouble)
            semesterGrade(2) = userInputDouble
            lbResult.Text = ""

        Else
            tbCourse3.Focus()
            tbCourse3.SelectionStart = 0
            tbCourse3.SelectionLength = tbCourse3.Text.Length
            lbResult.Text = "Please enter Valid number in Course 3 between 0 and 100!" + vbCrLf

        End If
    End Sub

    Private Sub tbCourse4_LostFocus(sender As Object, e As EventArgs) Handles tbCourse4.LostFocus
        Dim userInputCourse4 As String = ""
        userInputCourse4 = tbCourse4.Text
        If (Double.TryParse(userInputCourse4, userInputDouble) AndAlso
           userInputDouble >= minimunMark AndAlso
           userInputDouble <= maximumMark) Then

            lbCourse4SemesterGrade.Text = displayGrade(userInputDouble)
            semesterGrade(3) = userInputDouble
            lbResult.Text = ""

        Else
            tbCourse4.Focus()
            tbCourse4.SelectionStart = 0
            tbCourse4.SelectionLength = tbCourse4.Text.Length
            lbResult.Text = "Please enter Valid number in Course 4 between 0 and 100!" + vbCrLf

        End If
    End Sub

    Private Sub tbCourse5_LostFocus(sender As Object, e As EventArgs) Handles tbCourse5.LostFocus
        Dim userInputCourse5 As String = ""
        userInputCourse5 = tbCourse5.Text
        If (Double.TryParse(userInputCourse5, userInputDouble) AndAlso
           userInputDouble >= minimunMark AndAlso
           userInputDouble <= maximumMark) Then

            lbCourse5SemesterGrade.Text = displayGrade(userInputDouble)
            semesterGrade(4) = userInputDouble
            lbResult.Text = ""

        Else
            tbCourse5.Focus()
            tbCourse5.SelectionStart = 0
            tbCourse5.SelectionLength = tbCourse5.Text.Length
            lbResult.Text = "Please enter Valid number in Course 5 between 0 and 100!" + vbCrLf

        End If
    End Sub

    Private Sub tbCourse6_LostFocus(sender As Object, e As EventArgs) Handles tbCourse6.LostFocus
        Dim userInputCourse6 As String = ""
        userInputCourse6 = tbCourse6.Text

        If (Double.TryParse(userInputCourse6, userInputDouble) AndAlso
           userInputDouble >= minimunMark AndAlso
           userInputDouble <= maximumMark) Then

            lbCourse6SemesterGrade.Text = displayGrade(userInputDouble)
            semesterGrade(5) = userInputDouble
            lbResult.Text = ""


        Else
            tbCourse6.Focus()
            tbCourse6.SelectionStart = 0
            tbCourse6.SelectionLength = tbCourse6.Text.Length
            lbResult.Text = "Please enter Valid number in Course 6 between 0 and 100!" + vbCrLf

        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'To reate All the input textboxes clear
        tbCourse1.Clear()
        tbCourse2.Clear()
        tbCourse3.Clear()
        tbCourse4.Clear()
        tbCourse5.Clear()
        tbCourse6.Clear()

        'To create All the textboxes ebable 
        tbCourse1.ReadOnly = False
        tbCourse2.ReadOnly = False
        tbCourse3.ReadOnly = False
        tbCourse4.ReadOnly = False
        tbCourse5.ReadOnly = False
        tbCourse6.ReadOnly = False

        'To create All the grade's lable clear
        lbCourse1SemesterGrade.Text = ""
        lbCourse2SemesterGrade.Text = ""
        lbCourse3SemesterGrade.Text = ""
        lbCourse4SemesterGrade.Text = ""
        lbCourse5SemesterGrade.Text = ""
        lbCourse6SemesterGrade.Text = ""
        lbAverageSemesterGrade.Text = ""
        lbSemesterAverageMarks.Text = ""
        lbResult.Text = ""
        For counter As Integer = 0 To semesterGrade.Length - 1 'Loop for the array to delete it.
            semesterGrade(counter) = 0                         'To set semester grade array value = 0
        Next
        sumForAverage = 0                                       'To set sum variable for array = 0
        averageGrade = 0                                         'To set Average variable = 0
        tbCourse1.Focus()
    End Sub

    'To exite the application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub lbSemesterAverageMarks_Click(sender As Object, e As EventArgs) Handles lbSemesterAverageMarks.Click

    End Sub

    Private Sub tbCourse4_TextChanged(sender As Object, e As EventArgs) Handles tbCourse4.TextChanged

    End Sub
End Class
