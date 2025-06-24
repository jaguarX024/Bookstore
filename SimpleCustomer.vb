'Class: SimpleCustomer
'Developer: Cherif Haidara
'Date: 5/9/2023
'Purpose: Calculates the cost for simple customer that's not a student and creates a record 
'for the purchase.



Option Strict On

Public Class SimpleCustomer
    ' Class variables to store customer and software details
    Protected _strCreditCardNumber As String
    Protected _strSoftware As String
    Protected _intIndex As Integer
    Protected _decCost As Decimal

    ' Predefined prices for different software
    Protected _decVisio As Decimal = 14.99D
    Protected _decQuickbooks As Decimal = 24.99D
    Protected _decProject As Decimal = 17.99D
    Protected _PowerBi As Decimal = 9.99D
    Protected _speedType As Decimal = 29.99D

    ' Object to handle writing customer cost records to a file
    Dim objCustomerCostsFile As RecordFile

    ' Constructor for the SimpleCustomer class
    Sub New(ByVal strCreditCard As String, ByVal strSoftware As String,
            ByVal intIndex As Integer)

        ' Assigns passed values to the class's protected member variables
        _strCreditCardNumber = strCreditCard
        _strSoftware = strSoftware
        _intIndex = intIndex
    End Sub

    ' Computes the cost of the selected software and writes the record
    Overridable Function ComputeCosts() As Decimal
        ' Uses a Select Case statement to determine cost based on software index
        Select Case _intIndex
            Case 0
                _decCost = _decVisio
                ' Creates a new RecordFile object and writes the transaction
                objCustomerCostsFile = New RecordFile(_strCreditCardNumber, _strSoftware,
              "0% discount", _decCost)
                objCustomerCostsFile.WriteRecord()

            Case 1
                _decCost = _decQuickbooks
                objCustomerCostsFile = New RecordFile(_strCreditCardNumber, _strSoftware,
              "0% discount", _decCost)
                objCustomerCostsFile.WriteRecord()
            Case 2
                _decCost = _decProject
                objCustomerCostsFile = New RecordFile(_strCreditCardNumber, _strSoftware,
              "0% discount", _decCost)
                objCustomerCostsFile.WriteRecord()
            Case 3
                _decCost = _PowerBi
                objCustomerCostsFile = New RecordFile(_strCreditCardNumber, _strSoftware,
              "0% discount", _decCost)
                objCustomerCostsFile.WriteRecord()
            Case 4
                _decCost = _speedType
                objCustomerCostsFile = New RecordFile(_strCreditCardNumber, _strSoftware,
              "0% discount", _decCost)
                objCustomerCostsFile.WriteRecord()

        End Select

        ' Returns the computed cost
        Return _decCost
    End Function
End Class