Imports System
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit.API.Native

Namespace RichUsingSearchAPI

    Public Partial Class Form1
        Inherits Form

        Private searchString As String = "$match$"

        Private replaceString As String = "REPLACED"

        Private replaceRtfPart As String = "{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;\red255\green0\blue0 ;}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}{\*\cs2\sbasedon1\cf0 Line Number;}}\sectd\pard\plain\ql{\cf2  }{\cf2 (}{\cf2 #$number$}{\cf2 )}\cf2}"

        Public Sub New()
            InitializeComponent()
            richEditControl1.LoadDocument(Directory.GetCurrentDirectory() & "\..\..\test.rtf")
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            SearchAndReplace()
        End Sub

        Private Sub SearchAndReplace()
            Dim count As Integer = 1
            ' To prevent flickering
            richEditControl1.Document.BeginUpdate()
            ' Get first search result and start iterating
            Dim searchResult As ISearchResult = richEditControl1.Document.StartSearch(searchString, SearchOptions.CaseSensitive, SearchDirection.Forward, richEditControl1.Document.Range)
            While searchResult.FindNext()
                searchResult.Replace(String.Empty)
                Dim insertRange As DocumentRange = richEditControl1.Document.InsertText(searchResult.CurrentResult.Start, replaceString)
                richEditControl1.Document.InsertRtfText(insertRange.End, replaceRtfPart.Replace("$number$", count.ToString()))
                count += 1
            End While

            richEditControl1.Document.EndUpdate()
        End Sub
    End Class
End Namespace
