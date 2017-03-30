' Name:         Stock Project
' Purpose:      Displays the highest stock price and number of days at that price
' Programmer:   Zach Murphy on 3-30-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' class-level array
    Private dblPrices() As Double = {91.8, 91.6, 92,
        90, 90.5, 90.05, 90.12, 90.7, 90.8, 90.83, 92, 89.5, 90, 92}

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fill list box with prices

        For Each dblElement As Double In dblPrices
            lstPrices.Items.Add(dblElement.ToString("n2"))
        Next dblElement
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' displays the highest stock price and number of
        ' days the stock closed at that price

        Dim intLastSub As Integer = dblPrices.GetUpperBound(0)
        Dim dblHighest As Double = dblPrices(0)
        Dim intDays As Integer = 1

        For intSub As Integer = 1 To intLastSub
            If dblPrices(intSub) = dblHighest Then
                intDays += 1
            Else
                If dblPrices(intSub) > dblHighest Then
                    dblHighest = dblPrices(intSub)
                    intDays = 1
                End If
            End If
        Next intSub

        lblHighest.Text = dblHighest.ToString("c2")
        lblDays.Text = intDays.ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
