' Name:         City Project
' Purpose:      Display a city name followed by a comma, a space, and the state name
' Programmer:   Zach Murphy on 4-4-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private strCities() As String = {"Chicago", "Bowling Green", "Boston", "Lansing", "Brentwood"}
    Private strStates() As String = {"Illinois", "Kentucky", "Massachusetts", "Michigan", "Tennessee"}

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' displays the contents of the arrays using this format: city, state

        lstCitiesAndStates.Items.Clear()
        lstCitiesAndStates.Items.Add(strCities(0) + ", " + strStates(0))
        lstCitiesAndStates.Items.Add(strCities(1) + ", " + strStates(1))
        lstCitiesAndStates.Items.Add(strCities(2) + ", " + strStates(2))
        lstCitiesAndStates.Items.Add(strCities(3) + ", " + strStates(3))
        lstCitiesAndStates.Items.Add(strCities(4) + ", " + strStates(4))
    End Sub
End Class
