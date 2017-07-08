Imports System
Imports GemBox.Document

Module Module1

    Sub Main()

        ' If using Professional version, put your serial key below.
        ComponentInfo.SetLicense("FREE-LIMITED-KEY")

        Dim inputPassword As String = "inpass"
        Dim outputPassword As String = "outpass"

        Dim document = DocumentModel.Load("DocxEncryption.docx", New DocxLoadOptions With {.Password = inputPassword})
        document.Save("DOCX Encryption.docx", New DocxSaveOptions With {.Password = outputPassword})

    End Sub

End Module