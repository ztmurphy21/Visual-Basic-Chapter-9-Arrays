﻿' Name:         Warren Project
' Purpose:      Display the amount sold for each candy type
' Programmer:   Zach Murphy on 4-2-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fill the list box with values

        lstCandy.Items.Add("Choco Bar")
        lstCandy.Items.Add("Choco Bar-Peanuts")
        lstCandy.Items.Add("Kit Kat")
        lstCandy.Items.Add("Peanut Butter Cups")
        lstCandy.Items.Add("Take 5 Bar")
        lstCandy.SelectedIndex = 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' add amount sold to the appropriate total

        ' declare array and variables
        Static intCandies(4) As Integer
        Dim intSold As Integer
        Dim intSub As Integer

        Integer.TryParse(txtSold.Text, intSold)
        intSub = lstCandy.SelectedIndex

        ' update array value
        If intSub >= 0 AndAlso intSub <= intCandies.GetUpperBound(0) Then
            intCandies(intSub) += intSold
        Else
            MessageBox.Show("Can't update this candy's sales.", "Warren School", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' display array values
        lblChocoBar.Text = intCandies(0).ToString
        lblChocoBarPeanuts.Text = intCandies(1).ToString
        lblKitKat.Text = intCandies(2).ToString
        lblPeanutButCups.Text = intCandies(3).ToString
        lblTake5Bar.Text = intCandies(4).ToString 'this is my favorite candy bar!

        txtSold.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtSold_Enter(sender As Object, e As EventArgs) Handles txtSold.Enter
        txtSold.SelectAll()
    End Sub

    Private Sub txtSold_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSold.KeyPress
        ' allow numbers, the hyphen, and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> "-" AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles txtSold.TextChanged, lstCandy.SelectedIndexChanged
        lblChocoBar.Text = String.Empty
        lblChocoBarPeanuts.Text = String.Empty
        lblKitKat.Text = String.Empty
        lblPeanutButCups.Text = String.Empty
        lblTake5Bar.Text = String.Empty
    End Sub
End Class
