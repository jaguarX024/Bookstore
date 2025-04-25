'Class: SimpleCustomer
'Developer: Cherif Haidara
'Date: 5/9/2023
'Purpose: Calculates the cost for simple customer that's not a student and creates a record 
'for the purchase.



Option Strict On
Public Class SimpleCustomer
    'Class variables
    Protected _strCreditCardNumber As String
    Protected _strSoftware As String
    Protected _intIndex As Integer
    Protected _decCost As Decimal
    'Prices
    Protected _decVisio As Decimal = 14.99D
    Protected _decQuickbooks As Decimal = 24.99D
    Protected _decProject As Decimal = 17.99D
    Protected _PowerBi As Decimal = 9.99D
    Protected _speedType As Decimal = 29.99D


    Dim objCustomerCostsFile As RecordFile

    Sub New(ByVal strCreditCard As String, ByVal strSoftware As String,
            ByVal intIndex As Integer)

        _strCreditCardNumber = strCreditCard
        _strSoftware = strSoftware
        _intIndex = intIndex
    End Sub






    Overridable Function ComputeCosts() As Decimal
        Select Case _intIndex
            Case 0
                _decCost = _decVisio
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

        Return _decCost
    End Function
End Class
