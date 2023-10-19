# cipher
ICT PROFICIENCY SAMPLE EXAMPLE - CIPHER/DECIPHER

Imports System.Text

Public Class Form1

Dim intShift As Integer = 1
Dim strCharacterSet As String = "abcdefghijklmnopqrstuvwxyz" & "ABCDEFGHIJKLMNOPQRSTUVWXYZ" & " "


Public Function Cipher(ByVal strInput As String, ByVal intShift As Integer, ByVal strCharacterSet As String) As String
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

CIPHER:
    Private Sub cipher_btn_Click(sender As Object, e As EventArgs) Handles cipher_btn.Click
        txtbox.Text = Cipher(txtbox2.Text, intShift,strCharacterSet)
    End Sub

DECIPHER:
    Private Sub decipher_btn_Click(sender As Object, e As EventArgs) Handles decipher_btn.Click
        txtbox.Text = Cipher(txtbox2.Text, intShift,String.Join("", strCharacterSet.Reverse))
    End Sub

End Class

