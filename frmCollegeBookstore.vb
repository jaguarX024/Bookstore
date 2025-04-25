Option Strict On
'Program: College Bookstore Access Codes
'Developer: Cherif Haidara
'Date:5/9/2023
'Purpose: This application calculates the cost of a software for a client.
'It also records the costs in a text file

Imports System.Net.Http.Headers

Public Class frmCollegeBookstore

    Private _decDailyTotal As Decimal = 0D
    Private Sub frmCollegeBookstore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnFinalTotal_Click(sender As Object, e As EventArgs) Handles btnFinalTotal.Click
        'This event handler checks the informations entered by the user 
        'to assure that it's valid

        Dim objStudent As Student
        Dim objSimpleCustomer As SimpleCustomer
        Dim inputError As Boolean = False


        lblDailyTotalInNumber.Visible = False
        lblDailyTotal.Visible = False

        'Check the credit card number
        If txtCreditCardNumber.TextLength < 16 Then
            MsgBox("Enter the full credit card number",, "Error")
            txtCreditCardNumber.Clear()
            txtCreditCardNumber.Focus()
            inputError = True
        ElseIf txtCreditCardNumber.TextLength > 16 Then
            MsgBox("You entered more than 16 digits for the card number",, "Error")
            txtCreditCardNumber.Clear()
            txtCreditCardNumber.Focus()
            inputError = True
        ElseIf Not IsNumeric(txtCreditCardNumber.Text) Then
            MsgBox("Enter a series of digits for the credit card number",, "Error")
            txtCreditCardNumber.Clear()
            txtCreditCardNumber.Focus()
            inputError = True

            'Check the expiration date
        ElseIf Not IsNumeric(txtExpirationDate.Text) Then
            MsgBox("Enter card expiration date",, "Error")
            txtExpirationDate.Clear()
            txtExpirationDate.Focus()
            inputError = True
        ElseIf Convert.ToInt32(txtExpirationDate.Text) < 2025 Then
            MsgBox("Your card has expired. Enter another card",, "Error")
            txtExpirationDate.Clear()
            txtExpirationDate.Focus()
            inputError = True

            'Check that a software was selected
        ElseIf cboSoftwares.SelectedIndex < 0 Then
            MsgBox("Select the software to purchase",, "Error")
            cboSoftwares.Focus()
            inputError = True

            'If no Error was found, process the purchase
        ElseIf Not inputError Then
            If radStudent.Checked Then
                objStudent = New Student(txtCreditCardNumber.Text,
                       Convert.ToString(cboSoftwares.SelectedItem), cboSoftwares.SelectedIndex)
                lblTotal.Visible = True
                lblTotalNumber.Visible = True
                lblTotalNumber.Text = objStudent.ComputeCosts().ToString("C2")
                _decDailyTotal += objStudent.ComputeCosts()

            Else
                objSimpleCustomer = New SimpleCustomer(txtCreditCardNumber.Text,
               Convert.ToString(cboSoftwares.SelectedItem), cboSoftwares.SelectedIndex)
                lblTotal.Visible = True
                lblTotalNumber.Visible = True
                lblTotalNumber.Text = objSimpleCustomer.ComputeCosts().ToString("C2")
                _decDailyTotal += objSimpleCustomer.ComputeCosts()

            End If





        End If


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This event handler clears all data entered  by the user and
        'reset the stadard settings

        txtCreditCardNumber.Clear()
        txtExpirationDate.Clear()
        cboSoftwares.Text = "Select a software"
        radCustomer.Checked = False
        radStudent.Checked = True
        lblDailyTotal.Visible = False
        lblDailyTotalInNumber.Visible = False
        lblTotal.Visible = False
        lblTotalNumber.Visible = False

    End Sub

    Private Sub btnDailyTotal_Click(sender As Object, e As EventArgs) Handles btnDailyTotal.Click
        lblDailyTotalInNumber.Visible = True
        lblDailyTotal.Visible = True

        lblDailyTotalInNumber.Text = _decDailyTotal.ToString("C2")



    End Sub
End Class
