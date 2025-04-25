'Class: Student
'Developer: Cherif Haidara
'Date: 5/9/2023
'Purpose: Calculates the cost for a student by applying a discount and creating a record
'for the purchase.

Option Strict On

Public Class Student
    Inherits SimpleCustomer

    'class variables
    'Discounts
    Private _decVisioDiscount As Decimal = 0.06D
    Private _decQuickbooksDicount As Decimal = 0.08D
    Private _decProjectDicount As Decimal = 0.08D
    Private _PowerBiDicount As Decimal = 0.05D
    Private _speedTypeDicount As Decimal = 0.02D

    Dim objStudentCostsFile As RecordFile

    Sub New(ByVal strCreditCard As String, ByVal strSoftware As String,
            ByVal intIndex As Integer)

        MyBase.New(strCreditCard, strSoftware, intIndex)

    End Sub

    Public Overrides Function ComputeCosts() As Decimal
        Select Case _intIndex
            Case 0
                _decCost = _decVisio - (_decVisio * _decVisioDiscount)
                objStudentCostsFile = New RecordFile(_strCreditCardNumber, _strSoftware,
              "6% discount", _decCost)
                objStudentCostsFile.WriteRecord()


            Case 1
                _decCost = _decQuickbooks - (_decQuickbooks * _decQuickbooksDicount)
                objStudentCostsFile = New RecordFile(_strCreditCardNumber, _strSoftware,
              "8% discount", _decCost)
                objStudentCostsFile.WriteRecord()
            Case 2
                _decCost = _decProject - (_decProject * _decProjectDicount)
                objStudentCostsFile = New RecordFile(_strCreditCardNumber, _strSoftware,
              "8% discount", _decCost)
                objStudentCostsFile.WriteRecord()
            Case 3
                _decCost = _PowerBi - (_PowerBi * _PowerBiDicount)
                objStudentCostsFile = New RecordFile(_strCreditCardNumber, _strSoftware,
              "5% discount", _decCost)
                objStudentCostsFile.WriteRecord()
            Case 4
                _decCost = _speedType - (_speedType * _speedTypeDicount)
                objStudentCostsFile = New RecordFile(_strCreditCardNumber, _strSoftware,
              "2% discount", _decCost)
                objStudentCostsFile.WriteRecord()




        End Select

        Return _decCost
    End Function
End Class
