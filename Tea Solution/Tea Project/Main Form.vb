' Name:         Tea Project
' Purpose:      Displays the contents of an array in a list box
' Programmer:   Zach Murphy on 4-4-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Dim dblPounds() As Double = {35.6, 15, 67.9, 78.8, 12.5, 27.5}
    Private intLastSub As Integer = dblPounds.GetUpperBound(0)

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ' display array in ascending order

        lstPounds.Items.Clear()
        Array.Sort(dblPounds)
        For intSub As Integer = 0 To intLastSub
            lstPounds.Items.Add(dblPounds(intSub))
        Next intSub

    End Sub

    Private Sub btnForEachNext_Click(sender As Object, e As EventArgs) Handles btnForEachNext.Click
        ' display array in descending order

        lstPounds.Items.Clear()
        Array.Sort(dblPounds)
        Array.Reverse(dblPounds)
        Dim intSub As Double = 0
        For Each intSub In dblPounds
            lstPounds.Items.Add(intSub)
        Next intSub

    End Sub
End Class
