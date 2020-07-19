' Name:         Adalene Project
' Purpose:      Select and view records.
' Programmer:   Austin Parker// Date: July 12, 2020

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AdaleneDataSet.Stores' table. You can move, or remove it, as needed.
        Me.StoresTableAdapter.Fill(Me.AdaleneDataSet.Stores)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'If statement to determine which query to display based on radio button checked
        If radCompany.Checked Then
            StoresTableAdapter.FillByCompany(AdaleneDataSet.Stores)
        ElseIf radFranchisee.Checked Then
            StoresTableAdapter.FillByFranchise(AdaleneDataSet.Stores)
        Else
            StoresTableAdapter.FillByAllOwned(AdaleneDataSet.Stores)
        End If
    End Sub

    Private Sub radAll_CheckedChanged(sender As Object, e As EventArgs) Handles radAll.CheckedChanged

    End Sub

    Private Sub radCompany_CheckedChanged(sender As Object, e As EventArgs) Handles radCompany.CheckedChanged

    End Sub

    Private Sub radFranchisee_CheckedChanged(sender As Object, e As EventArgs) Handles radFranchisee.CheckedChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
