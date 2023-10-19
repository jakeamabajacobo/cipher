# cipher
ICT PROFICIENCY SAMPLE EXAMPLE - CIPHER/DECIPHER


Imports System.Text

Public Class Form1

    Public Function Cipher(ByVal strInput As String,
         ByVal intShift As Integer, Optional ByVal strCharacterSet _
         As String = "abcdefghijklmnopqrstuvwxyz" &
         "ABCDEFGHIJKLMNOPQRSTUVWXYZ" & " ") As String

        Dim sbEncrypt As New StringBuilder With {.Capacity = strInput.Length}
        For Each c As Char In strInput
            Dim intChar As Integer = strCharacterSet.IndexOf(c)
            Do Until (intChar + intShift) < (strCharacterSet.Length)
                intChar -= strCharacterSet.Length
            Loop
            sbEncrypt.Append(strCharacterSet(intChar + intShift))
        Next c

        Return sbEncrypt.ToString
    End Function

    Private Sub cipher_btn_Click(sender As Object, e As EventArgs) Handles cipher_btn.Click
        txtbox2.Text = Cipher(txtbox2.Text, intShift:=1)
    End Sub

    Private Sub decipher_btn_Click(sender As Object, e As EventArgs) Handles decipher_btn.Click
        Dim strCharacterSet As String = "abcdefghijklmnopqrstuvwxyz" & "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        txtbox2.Text = Cipher(txtbox2.Text, 1, String.Join("", strCharacterSet.Reverse))
    End Sub

End Class

