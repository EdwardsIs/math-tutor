' Program Name: Elementary Math Tutor
' Author:       Isaiah Edwards
' Date:         04/29/19
' Purpose:      This program allows the user to generate sample tables
'               for addition or multiplication, for review purposes.

Public Class frmTutor
    Private Sub mnuAddition_Click(sender As Object, e As EventArgs) Handles mnuAddition.Click

        ' Setting the current operation menu item as checked
        For Each item In mnuOperation.DropDownItems
            item.checked = False
        Next
        mnuAddition.Checked = True


    End Sub

    Private Sub mnuMultiplication_Click(sender As Object, e As EventArgs) Handles mnuMultiplication.Click

        ' Setting the current operation menu item as checked
        For Each item In mnuOperation.DropDownItems
            item.checked = False
        Next
        mnuMultiplication.Checked = True


    End Sub

    Private Sub createListAddition(intVal As Integer, intLimit As Integer)
        ' This method creates the list for addition, given
        ' the upper limit, and the actual value for the examples

        ' Clearing anything that may be in the list box right now
        lstExamples.Items.Clear()

        ' Do loop to add the examples
        Dim intCount As Integer
        For intCount = 0 To intLimit
            Dim strExample As String
            strExample = intVal & " + " & intCount & "=" & (intVal + intCount).ToString()
            lstExamples.Items.Add(strExample)
        Next
    End Sub

    Private Sub createListMultiplication(intVal As Integer, intLimit As Integer)
        ' This method creates the list for multiplication, given
        ' the upper limit, and the actual value for the examples

        ' Clearing anything that may be in the list box right now
        lstExamples.Items.Clear()

        ' Do loop to add the examples
        Dim intCount As Integer
        For intCount = 0 To intLimit
            Dim strExample As String
            strExample = intVal & " * " & intCount & "=" & (intVal * intCount).ToString()
            lstExamples.Items.Add(strExample)
        Next
    End Sub

    Private Sub btnCreateList_Click(sender As Object, e As EventArgs) Handles btnCreateList.Click
        ' This method handles the click event for the Create List button.
        ' It checks to make sure the user has selected a grade level, as well
        ' as an operation to display.

        If mnuMultiplication.Checked Or mnuAddition.Checked Then
            ' An operation has been chosen
            If radEarlyElementary.Checked Then
                ' Lower grade level was chosen
                Dim intVal As Integer = getUserInput(6)
                If mnuAddition.Checked Then
                    ' Addition was checked
                    createListAddition(intVal, 6)
                Else
                    ' Multiplication was checked
                    createListMultiplication(intVal, 6)
                End If
            ElseIf radUpperElementary.Checked Then
                ' Upper grade level was chosen
                Dim intVal As Integer = getUserInput(12)
                If mnuAddition.Checked Then
                    ' Addition was checked
                    createListAddition(intVal, 12)
                Else
                    ' Multiplication was checked
                    createListMultiplication(intVal, 12)
                End If
            Else
                ' No grade level was chosen - Error
                MsgBox("Error - Please choose a grade level", , "Error")
            End If
        Else
            ' No operation was chosen - Error
            MsgBox("Error - Please choose an operation from the Operations menu", , "Error")
        End If
    End Sub

    Private Function getUserInput(ByVal intRangeLimit As Integer) As Integer
        ' This function handles getting user input, based off
        ' an upper range limit passed from the calling method.
        ' The function starts a loop which asks for input between 
        ' 0 and the upper range limit.  The loop will not exit until 
        ' the input is valid

        ' Defining variables for use in loop
        Dim intVal As Integer = -1
        Dim strVal As String
        Dim blnBadInput As Boolean = True
        Dim strInputMsg As String = "Enter a number between 0 and " & intRangeLimit
        Dim strErrorMsg As String = "Error - Enter a number between 0 and " & intRangeLimit

        ' Loop to get and validate user input
        Do
            strVal = InputBox(strInputMsg, "Enter Number", " ")
            If IsNumeric(strVal) Then
                intVal = Convert.ToInt32(strVal)
                If intVal >= 0 And intVal <= intRangeLimit Then
                    blnBadInput = False
                Else
                    strInputMsg = strErrorMsg
                End If
            Else
                strInputMsg = strErrorMsg
            End If
        Loop While blnBadInput

        ' Returning intVal if input was good
        Return intVal
    End Function

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' This method handles the clear menu item click event.
        ' It clears all input/output
        For Each item In mnuOperation.DropDownItems
            item.checked = False
        Next
        lstExamples.Items.Clear()
        radEarlyElementary.Checked = False
        radUpperElementary.Checked = False
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' This method handles the exit menu item click event.
        ' It exits the program
        Close()
    End Sub
End Class
