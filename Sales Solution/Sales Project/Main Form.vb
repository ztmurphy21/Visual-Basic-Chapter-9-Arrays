' Name:         Sales Project
' Purpose:      Multiplies each array element by 125% and then
'               displays the array contents in a list box
' Programmer:   Zach Murphy on 4-4-2017
Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' multiplies each array element by 125% and then displays 
        ' the results with two decimal places in a list box

        Dim dblSales(,) As Double = {{36.75, 54}, {35, 46.5}, {40.5, 27}, {59, 24}}
        Dim increaseResult As Double

        For intRow As Integer = 0 To 5 Step +1
            For intCol As Integer = 0 To 5 Step +1
                increaseResult = dblSales(intRow, intCol) * 0.025
                dblSales(intRow, intCol) = increaseResult + dblSales(intRow, intCol)

            Next intCol
        Next intRow
        lstSales.Items.Add(dblSales(0, 0))

    End Sub
End Class
