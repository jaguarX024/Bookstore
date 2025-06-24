'Class: Record File
'Developer: Cherif Haidara
'Date:5/9/2023
'Purpose: This class create a records file for all purchases. It writes a comma-delimited record
'file that contains the client credit card number, the purchased software, the discount, and
'the subtotal

Option Strict On

Public Class RecordFile
    Private _strCreditCard As String
    Private _strSoftware As String
    Private _strDiscount As String
    Private _decCost As Decimal

    ' Constructor for the RecordFile class
    Sub New(ByVal strCreditCard As String, ByVal strSoftware As String,
            ByVal strDiscount As String, ByVal decCost As Decimal)

        ' Assigns passed values to private member variables
        _strCreditCard = strCreditCard
        _strSoftware = strSoftware
        _strDiscount = strDiscount
        _decCost = decCost

    End Sub

    ' Writes the record to a comma-delimited text file
    Sub WriteRecord()
        ' Defines the file path for the Record text file
        Dim strFileLocation As String = "C:\Users\haida\OneDrive\Documents\HaidaraCherif_PE10\College Bookstore Access Codes\College Bookstore Access Codes\Record.txt"

        Try
            ' Opens the file in append mode to add new text
            Dim objWriter As IO.StreamWriter = IO.File.AppendText(strFileLocation)

            ' Writes data fields, delimited by commas
            objWriter.Write(_strCreditCard & ",")
            objWriter.Write(_strSoftware & ",")
            objWriter.Write(_strDiscount & ",")
            objWriter.WriteLine("$" & _decCost) ' Writes the cost and a new line
            objWriter.Close() ' Closes the writer, saving changes

        Catch ex As Exception
            ' Handles potential errors, such as file not found
            MsgBox("Unable to find the Record text file", , "Error")
            Application.Exit() ' Exits the application on error

        End Try
    End Sub

End Class