' Name:         Paper Project
' Purpose:      Displays the price of an item
' Programmer:  Zach Murphy on 4-2-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' declare two-dimensional array
    Private strItems(,) As String = {{"A45G", "8.99"},
                                     {"J63Y", "12.99"},
                                     {"M93K", "5.99"},
                                     {"C20P", "13.5"},
                                     {"F77T", "7.25"}}

    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click
        ' display an item's price

        Dim strSearchId As String
        Dim intRow As Integer
        Dim dblItemPrice As Double

        strSearchId = txtId.Text

        ' search the first column for the ID
        ' continue searching until the end of the  
        ' first column or the ID is found
        Do Until intRow > strItems.GetUpperBound(0) OrElse
                strItems(intRow, 0) = strSearchId
            intRow += 1
        Loop

        If intRow <= strItems.GetUpperBound(0) Then
            Double.TryParse(strItems(intRow, 1), dblItemPrice)
            If chkDisc.Checked Then
                dblItemPrice *= 0.9
            End If
            lblPrice.Text = dblItemPrice.ToString("c2")
        Else
            MessageBox.Show("Indvalid ID", "Paper Warehouse", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtId_Enter(sender As Object, e As EventArgs) Handles txtId.Enter
        txtId.SelectAll()
    End Sub

    Private Sub ClearPrice(sender As Object, e As EventArgs) Handles txtId.TextChanged, chkDisc.CheckedChanged
        lblPrice.Text = String.Empty
    End Sub
End Class
