' Name:         Jenko Project
' Purpose:      Display the total of the sales stored in a two-dimensional array
' Programmer:   Zach Murphy on 4-2-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' displays the total sales
        Dim intSales(,) As Integer = {{1500, 2535},
                                        {2300, 3678},
                                         {1850, 2473}}
        Dim intTotal As Integer

        For Each intElement As Integer In intSales
            intTotal += intElement
        Next intElement

        lblTotal.Text = intTotal.ToString("c0")

    End Sub
End Class
