Public Module Encryption
    ''' <summary>
    ''' Encrypt text using AES Algorithm
    ''' </summary>
    ''' <param name="text">Text to encrypt</param>
    ''' <param name="password">Password with which to encrypt</param>
    ''' <returns>Returns encrypted text</returns>
    ''' <remarks></remarks>
    Public Function Encrypt(text As String, password As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(password))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(text)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
            Throw New ArgumentException(ex.Message)
        End Try
    End Function
    ''' <summary>
    ''' Decrypt text using AES Algorithm
    ''' </summary>
    ''' <param name="text">Text to decrypt</param>
    ''' <param name="password">Password with which to decrypt</param>
    ''' <returns>Returns decrypted text</returns>
    ''' <remarks></remarks>
    Public Function Decrypt(text As String, password As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(password))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(text)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
            Throw New ArgumentException(ex.Message)
        End Try
    End Function
    ''' <summary>
    ''' Encrypt file to protect from hackers asking ransom
    ''' </summary>
    ''' <param name="file">File to Ransomware Protect</param>
    ''' <param name="key">Password to encrypt with</param>
    ''' <remarks></remarks>
    Public Sub CryptoRansomwareEncryption(ByVal file As String, ByVal key As String)
        If My.Computer.FileSystem.FileExists(file) Then
            My.Computer.FileSystem.WriteAllBytes(file, Bytes_AES_Encrypt(My.Computer.FileSystem.ReadAllBytes(file), key), False)
        End If
    End Sub
    ''' <summary>
    ''' Decrypt file from protection from hackers asking ransom
    ''' </summary>
    ''' <param name="file">File to Ransomware Unprotect</param>
    ''' <param name="key">Password to decrypt with</param>
    ''' <remarks></remarks>
    Public Sub CryptoRansomwareDecryption(ByVal file As String, ByVal key As String)
        If My.Computer.FileSystem.FileExists(file) Then
            My.Computer.FileSystem.WriteAllBytes(file, Bytes_AES_Decrypt(My.Computer.FileSystem.ReadAllBytes(file), key), False)
        End If
    End Sub
    Private Function Bytes_AES_Encrypt(ByVal input As Byte(), ByVal key As String) As Byte()
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim SHA256 As New System.Security.Cryptography.SHA256Cng
        Dim ciphertext As String = ""
        Try
            AES.Key = SHA256.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(key))
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = input
            Return DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length)
        Catch ex As Exception
            Throw New ArgumentException(ex.Message)
        End Try
    End Function
    Private Function Bytes_AES_Decrypt(ByVal input As Byte(), ByVal key As String) As Byte()
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim SHA256 As New System.Security.Cryptography.SHA256Cng
        Try
            AES.Key = SHA256.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(key))
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = input
            Return DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length)
        Catch ex As Exception
            Throw New ArgumentException(ex.Message)
        End Try
    End Function
    ''' <summary>
    ''' Super Encrypt text using AES Algorithm and SHA1 Algorithm
    ''' </summary>
    ''' <param name="text">Text to encrypt</param>
    ''' <param name="password">Password with which to encrypt</param>
    ''' <returns>Returns encrypted text</returns>
    ''' <remarks></remarks>2
    Public Function SuperEncrypt(text As String, password As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(password))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(text)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch ex As Exception
            Throw New ArgumentException(ex.Message)
        End Try
        Dim Hash_SHA1 As New System.Security.Cryptography.SHA1CryptoServiceProvider
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_SHA1.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(password))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(encrypted)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
            Throw New ArgumentException(ex.Message)
        End Try
    End Function
    ''' <summary>
    ''' Super Decrypt text using AES Algorithm and SHA1 Algorithm
    ''' </summary>
    ''' <param name="text">Text to decrypt</param>
    ''' <param name="password">Password with which to decrypt</param>
    ''' <returns>Returns decrypted text</returns>
    ''' <remarks></remarks>
    Public Function SuperDecrypt(text As String, password As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.SHA1CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(password))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(text)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch ex As Exception
            Throw New ArgumentException(ex.Message)
        End Try
        Dim Hash_SHA1 As New System.Security.Cryptography.MD5CryptoServiceProvider
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_SHA1.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(password))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(decrypted)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
            Throw New ArgumentException(ex.Message)
        End Try
    End Function
End Module
