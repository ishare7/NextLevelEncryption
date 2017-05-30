Imports NextLevelEncryption
Public Class Form1

    Private Sub btnEncrypt_Click(sender As Object, e As EventArgs) Handles btnEncrypt.Click
        If Not String.IsNullOrWhiteSpace(tbText.Text) AndAlso Not String.IsNullOrWhiteSpace(tbPassword.Text) Then
            tbEncrypted.Text = Encryption.Encrypt(tbText.Text, tbPassword.Text)
        End If
    End Sub

    Private Sub btnSuperEncrypt_Click(sender As Object, e As EventArgs) Handles btnSuperEncrypt.Click
        If Not String.IsNullOrWhiteSpace(tbText.Text) AndAlso Not String.IsNullOrWhiteSpace(tbPassword.Text) Then
            tbEncrypted.Text = Encryption.SuperEncrypt(tbText.Text, tbPassword.Text)
        End If
    End Sub

    Private Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
        Try
            If Not String.IsNullOrWhiteSpace(tbEncrypted.Text) AndAlso Not String.IsNullOrWhiteSpace(tbPassword.Text) Then
                tbText.Text = Encryption.Decrypt(tbEncrypted.Text, tbPassword.Text)
            End If
        Catch ex As Exception
            If Not ex.Message = "Padding is invalid and cannot be removed." Then
                MsgBox(ex.Message, 64)
            Else
                MsgBox("Error! Try super decrypting.", 64)
            End If
        End Try
    End Sub

    Private Sub btnSuperDecrypt_Click(sender As Object, e As EventArgs) Handles btnSuperDecrypt.Click
        Try
            If Not String.IsNullOrWhiteSpace(tbEncrypted.Text) AndAlso Not String.IsNullOrWhiteSpace(tbPassword.Text) Then
                tbText.Text = Encryption.SuperDecrypt(tbEncrypted.Text, tbPassword.Text)
            End If
        Catch ex As Exception
            If Not ex.Message = "Padding is invalid and cannot be removed." Then
                MsgBox(ex.Message, 64)
            Else
                MsgBox("Error! Try just decrypting.", 64)
            End If
        End Try
    End Sub

    Private Sub btnRansomwareProtect_Click(sender As Object, e As EventArgs) Handles btnRansomwareProtect.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If OpenFileDialog1.FileNames.Count = 1 Then
                Encryption.CryptoRansomwareEncryption(OpenFileDialog1.FileName, tbPassword2.Text)
                MsgBox("Successfully Ransomware protected """ & IO.Path.GetFileName(OpenFileDialog1.FileName) & """", 64)
            Else
                Dim list As String = ""
                For Each file As String In OpenFileDialog1.FileNames
                    Encryption.CryptoRansomwareEncryption(file, tbPassword2.Text)
                    list += IO.Path.GetFileName(file) & vbCrLf
                Next
                MsgBox("Successfully Ransomware protected " & OpenFileDialog1.FileNames.Count & " files!" & vbCrLf & vbCrLf & "                  Files:" & vbCrLf & list.Trim, 64)
            End If
        End If
    End Sub

    Private Sub btnRansomwareUnprotect_Click(sender As Object, e As EventArgs) Handles btnRansomwareUnprotect.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If OpenFileDialog1.FileNames.Count = 1 Then
                Encryption.CryptoRansomwareDecryption(OpenFileDialog1.FileName, tbPassword2.Text)
                MsgBox("Successfully Ransomware unprotected """ & IO.Path.GetFileName(OpenFileDialog1.FileName) & """", 64)
            Else
                Dim list As String = ""
                For Each file As String In OpenFileDialog1.FileNames
                    Encryption.CryptoRansomwareDecryption(file, tbPassword2.Text)
                    list += IO.Path.GetFileName(file) & vbCrLf
                Next
                MsgBox("Successfully Ransomware unprotected " & OpenFileDialog1.FileNames.Count & " files!" & vbCrLf & vbCrLf & "                  Files:" & vbCrLf & list.Trim, 64)
            End If
        End If
    End Sub

    Private Sub btn_toBinary_Click(sender As Object, e As EventArgs) Handles btn_toBinary.Click
        If Not String.IsNullOrWhiteSpace(tbText.Text) Then
            tbEncrypted.Text = Encoding.StringToBinary(tbText.Text)
        End If
    End Sub

    Private Sub btn_fromBinary_Click(sender As Object, e As EventArgs) Handles btn_fromBinary.Click
        If Not String.IsNullOrWhiteSpace(tbEncrypted.Text) Then
            tbText.Text = Encoding.BinaryToString(tbEncrypted.Text)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        On Error Resume Next
        Clipboard.SetText(tbText.Text)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        On Error Resume Next
        Clipboard.SetText(tbEncrypted.Text)
    End Sub
End Class