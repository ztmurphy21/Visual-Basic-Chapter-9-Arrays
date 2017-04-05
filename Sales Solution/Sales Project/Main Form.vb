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


        For intRow As Integer = 0 To dblSales.GetUpperBound(0)
            For intCol As Integer = 0 To dblSales.GetUpperBound(1)
                dblSales(intRow, intCol) += dblSales(intRow, intCol) * 0.25
            Next intCol
        Next intRow



        lstSales.Items.Add(dblSales(0, 0).ToString("c2"))
        lstSales.Items.Add(dblSales(0, 1).ToString("c2"))
        lstSales.Items.Add(dblSales(1, 0).ToString("c2"))
        lstSales.Items.Add(dblSales(1, 1).ToString("c2"))
        lstSales.Items.Add(dblSales(2, 0).ToString("c2"))
        lstSales.Items.Add(dblSales(2, 1).ToString("c2"))
        lstSales.Items.Add(dblSales(3, 0).ToString("c2"))
        lstSales.Items.Add(dblSales(3, 1).ToString("c2"))





    End Sub
End Class
