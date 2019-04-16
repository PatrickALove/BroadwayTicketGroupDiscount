' Author :     Patrick Andrew Love- 1683445
' Date   :     02/26/2019
' Purpose:     This Windows Classic Desktop application creates a discount based on the
'              size of a group using case statements and outputs the cost to them into
'              a message box. It uses data validation to ensure all correct values are
'              typed the way they should be expected.



Public Class frmBroadwayTicketGroup
    Private Sub grpCostBySize_Enter(sender As Object, e As EventArgs) Handles grpCostBySize.Enter

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' btnCalculate_Click even handler is to determine and display all output based on group
        ' size and cost per ticket. This will have case statements to handle the data input.
        Dim groupSize As String = cmbGroupSize.Text
        Dim intTicketPrice As Integer
        Dim numOfTickets As Integer
        If IsNumeric(txtNumOfTickets.Text) And txtNumOfTickets.Text <> "" Then
            numOfTickets = Convert.ToInt32(txtNumOfTickets.Text)
            If (numOfTickets >= 1 AndAlso numOfTickets <= 100) Then 'validate no of tickets
                Select Case groupSize
                    Case "1-8"
                        intTicketPrice = 249 * numOfTickets
                        MsgBox("Ticket Price= $" + intTicketPrice.ToString())
                    Case "9-12"
                        intTicketPrice = 219 * numOfTickets
                        MsgBox("Ticket Price= $" & intTicketPrice.ToString())
                    Case "13-24"
                        intTicketPrice = 199 * numOfTickets
                        MsgBox("Ticket Price= $" & intTicketPrice.ToString())
                    Case "25-99"
                        intTicketPrice = 169 * numOfTickets
                        MsgBox("Ticket Pric= $" & intTicketPrice.ToString())
                    Case Else
                        MsgBox("Please select valid range")

                End Select
            Else
                MsgBox("Please put ticket range 1-100 only")
            End If
        Else
            'Display error message if user entered invalid numbers
            MsgBox("Please enter a numeric value",, "Input Error")
            txtNumOfTickets.Text = ""
            cmbGroupSize.Text = ""
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumOfTickets.Clear()
        cmbGroupSize.Text = ""
    End Sub

    Private Sub frmBroadwayTicketGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
