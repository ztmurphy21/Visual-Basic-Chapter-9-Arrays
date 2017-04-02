' Name:         Presidents Project
' Purpose:      Display the name of a president's vice president 
' Programmer:   Zachary Murphy on 4-2-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' class-level array
    Private strVicePres() As String = {"John Adams",
                                       "Richard Nixon",
                                       "Lyndon Johnson",
                                       "George H.W. Bush",
                                       "Joe Biden"}

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fill list boxes with names of presidents
        lstPresidents.Items.Add("George Washington")
        lstPresidents.Items.Add("Dwight Eisenhower")
        lstPresidents.Items.Add("John F. Kennedy")
        lstPresidents.Items.Add("Ronald Reagan")
        lstPresidents.Items.Add("Barack Obama")
        lstPresidents.Items.Add("Abraham Lincoln")
        lstPresidents.SelectedIndex = 0
    End Sub

    Private Sub lstPresidents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPresidents.SelectedIndexChanged
        ' display associated name from strVicePres array
        Dim intSub As Integer = lstPresidents.SelectedIndex
        If intSub >= 0 AndAlso intSub <= strVicePres.GetUpperBound(0) Then
            lblVicePres.Text = strVicePres(intSub)
        Else
            lblVicePres.Text = "N/A"
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
