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

    Sub New(ByVal strCreditCard As String, ByVal strSoftware As String,
            ByVal strDiscount As String, ByVal decCost As Decimal)

        _strCreditCard = strCreditCard
        _strSoftware = strSoftware
        _strDiscount = strDiscount
        _decCost = decCost


    End Sub

    Sub WriteRecord()
        'Opens the Record text file and write the record in a comma-delimited file

        Dim strFileLocation As String = "C:\Users\haida\OneDrive\Documents\HaidaraCherif_PE10\College Bookstore Access Codes\College Bookstore Access Codes\Record.txt"

        Try
            Dim objWriter As IO.StreamWriter = IO.File.AppendText(strFileLocation)

            objWriter.Write(_strCreditCard & ",")
            objWriter.Write(_strSoftware & ",")
            objWriter.Write(_strDiscount & ",")
            objWriter.WriteLine("$" & _decCost)
            objWriter.Close()



        Catch ex As Exception
            MsgBox("Unable to find the Record text file",, "Error")
            Application.Exit()


        End Try
    End Sub

End Class
