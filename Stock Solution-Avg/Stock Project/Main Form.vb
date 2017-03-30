' Name:         Stock Project
' Purpose:      Displays the average stock price
' Programmer:   Zach Murphy on 3-30-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' class-level array
    Private dblPrices() As Double = {91.8, 91.6, 92, 90, 90.5, 90.05, 90.7, 90.8, 90.83}
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fill list box with prices
        For Each dblElement As Double In dblPrices
            lstPrices.Items.Add(dblElement.ToString("n2"))
        Next dblElement

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' displays the average stock price

        Dim dblTotal As Double
        Dim dblAvg As Double

        'accumulate stock prices
        For Each dblDay As Double In dblPrices
            dblTotal += dblDay
        Next dblDay

        'calc and display message
        dblAvg = dblTotal / dblPrices.Length
        lblAvg.Text = dblAvg.ToString("c2")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
