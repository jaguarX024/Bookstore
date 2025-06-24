'Class: Student
'Developer: Cherif Haidara
'Date: 5/9/2023
'Purpose: Calculates the cost for a student by applying a discount and creating a record
'for the purchase.

Option Strict On

Public Class Student
    Inherits SimpleCustomer ' Inherits properties and methods from SimpleCustomer

    ' Class variables to define specific discounts for students
    Private _decVisioDiscount As Decimal = 0.06D
    Private _decQuickbooksDicount As Decimal = 0.08D
    Private _decProjectDicount As Decimal = 0.08D
    Private _PowerBiDicount As Decimal = 0.05D
    Private _speedTypeDicount As Decimal = 0.02D

    ' Object to handle writing student cost records to a file
    Dim objStudentCostsFile As RecordFile

    ' Constructor for the Student class
    Sub New(ByVal strCreditCard As String, ByVal strSoftware As String,
            ByVal intIndex As Integer)

        MyBase.New(strCreditCard, strSoftware, intIndex) ' Calls the constructor of the base class (SimpleCustomer)
    End Sub

    ' Overrides the ComputeCosts function from the base class to apply student discounts
    Public Overrides Function ComputeCosts() As Decimal
        ' Determines the software cost and applies the corresponding student discount
        Select Case _intIndex
            Case 0 ' Visio
                _decCost = _decVisio - (_decVisio * _decVisioDiscount)
                ' Creates a new RecordFile object with the discounted cost and writes the record
                objStudentCostsFile = New RecordFile(_strCreditCardNumber, _strSoftware,
              "6% discount", _decCost)
                objStudentCostsFile.WriteRecord()

            Case 1 ' Quickbooks
                _decCost = _decQuickbooks - (_decQuickbooks * _decQuickbooksDicount)
                objStudentCostsFile = New RecordFile(_strCreditCardNumber, _strSoftware,
              "8% discount", _decCost)
                objStudentCostsFile.WriteRecord()
            Case 2 ' Project
                _decCost = _decProject - (_decProject * _decProjectDicount)
                objStudentCostsFile = New RecordFile(_strCreditCardNumber, _strSoftware,
              "8% discount", _decCost)
                objStudentCostsFile.WriteRecord()
            Case 3 ' PowerBi
                _decCost = _PowerBi - (_PowerBi * _PowerBiDicount)
                objStudentCostsFile = New RecordFile(_strCreditCardNumber, _strSoftware,
              "5% discount", _decCost)
                objStudentCostsFile.WriteRecord()
            Case 4 ' SpeedType
                _decCost = _speedType - (_speedType * _speedTypeDicount)
                objStudentCostsFile = New RecordFile(_strCreditCardNumber, _strSoftware,
              "2% discount", _decCost)
                objStudentCostsFile.WriteRecord()

        End Select

        Return _decCost ' Returns the final discounted cost
    End Function
End Class
