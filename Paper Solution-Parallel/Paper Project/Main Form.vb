' Name:         Paper Project
' Purpose:      Displays the price of an item
' Programmer:   zach Murphy on 4-2-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' declare parallel arrays
    Private strIds() As String =
        {"A45G", "J63Y", "M93K", "C20P", "F77T"}
    Private dblPrices() As Double = {8.99, 12.99, 5.99, 13.5, 7.25}

    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click
        ' display an item's price

        Dim strSearchId As String
        Dim intSub As Integer
        Dim dblItemPrice As Double

        strSearchId = txtId.Text

        ' search the strIds array until the
        ' end of the array or the ID is found
        Do Until intSub = strIds.Length OrElse
              strIds(intSub) = strSearchId
            intSub += 1
        Loop

        If intSub < strIds.Length Then
            dblItemPrice = dblPrices(intSub)
            If chkDisc.Checked Then
                dblItemPrice *= 0.9
            End If
            lblPrice.Text = dblItemPrice.ToString("c2")
        Else
            MessageBox.Show("Invalid ID", "Paper Warehouse", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
