Imports System.Text.Encoding
Public Module Encoding
    ''' <summary>
    ''' Converts an input string to binary
    ''' </summary>
    ''' <param name="input">String to convert to binary</param>
    ''' <returns>Returns input string to binary</returns>
    ''' <remarks></remarks>
    Public Function StringToBinary(input As String) As String
        Dim Value As String = Nothing
        Dim Re As New System.Text.StringBuilder
        For Each Character As Byte In System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            Re.Append(System.Convert.ToString(Character, 2).PadLeft(8, "0"))
        Next

        Value = Re.ToString.Substring(0, Re.ToString.Length - 0)
        Return Value
    End Function
    ''' <summary>
    ''' Converts input binary to string
    ''' </summary>
    ''' <param name="input">Binary input to covert back to string</param>
    ''' <returns>Returns binary input converted to string</returns>
    ''' <remarks></remarks>
    Public Function BinaryToString(input As String) As String
        Try
            Dim Values As String = Nothing
            Dim Character As String = System.Text.RegularExpressions.Regex.Replace(input, "[^01]", "")
            Dim ByteArrays((Character.Length / 8) - 1) As Byte
            For Index As Integer = 0 To ByteArrays.Length - 1
                ByteArrays(Index) = System.Convert.ToByte(Character.Substring(Index * 8, 8), 2)
            Next
            Values = System.Text.ASCIIEncoding.ASCII.GetString(ByteArrays)
            Return Values
        Catch ex As Exception
            Throw New ArgumentException("Error! Please provide valid binary characters!")
        End Try
    End Function
    ''' <summary>
    ''' Encrypt a file with Base64
    ''' </summary>
    ''' <param name="file">File to encrypt</param>
    ''' <remarks></remarks>
    Public Sub Base64Encrypt(file As String)
        IO.File.WriteAllText(file, System.Convert.ToBase64String(IO.File.ReadAllBytes(file), Base64FormattingOptions.InsertLineBreaks))
    End Sub
    ''' <summary>
    ''' Decrypt a file with Base64
    ''' </summary>
    ''' <param name="file">File to decrypt</param>
    ''' <remarks></remarks>
    Public Sub Base64Decrypt(file As String)
        IO.File.WriteAllBytes(file, System.Convert.FromBase64String(IO.File.ReadAllText(file)))
    End Sub
    ''' <summary>
    ''' Encodes a string from one encoding to another.
    ''' </summary>
    ''' <param name="input">String to encode</param>
    ''' <param name="original">Input string encoding</param>
    ''' <param name="output">Output string encoding</param>
    ''' <returns>Returns input string encoded into output encoding</returns>
    ''' <remarks></remarks>
    Public Function Encode(input As String, original As Text.Encoding, output As Text.Encoding) As String
        Return output.GetString(original.GetBytes(input))
    End Function
    ''' <summary>
    ''' Encodes a string from one encoding to another.
    ''' </summary>
    ''' <param name="input">String to encode</param>
    ''' <param name="original">Input string encoding</param>
    ''' <param name="output">Output string encoding</param>
    ''' <returns>Returns input string encoded into output encoding</returns>
    ''' <remarks></remarks>
    Public Function Encode(input As Char(), original As Text.Encoding, output As Text.Encoding) As String
        Return output.GetString(original.GetBytes(input))
    End Function
    ''' <summary>
    ''' Encodes a string from one encoding to another.
    ''' </summary>
    ''' <param name="input">String to encode</param>
    ''' <param name="original">Input string encoding</param>
    ''' <param name="output">Output string encoding</param>
    ''' <returns>Returns input string encoded into output encoding</returns>
    ''' <remarks></remarks>
    Public Function Encode(input As Byte(), original As Text.Encoding, output As Text.Encoding) As String
        Return output.GetString(input)
    End Function
    ''' <summary>
    ''' Encodes an array of strings from one encoding to another.
    ''' </summary>
    ''' <param name="input">String array to encode</param>
    ''' <param name="original">Input string encoding</param>
    ''' <param name="output">Output string encoding</param>
    ''' <returns>Returns input string encoded into output encoding</returns>
    ''' <remarks></remarks>
    Public Function Encode(input As String(), original As Text.Encoding, output As Text.Encoding) As String()
        Dim list As New List(Of String)
        For Each s As String In input
            list.Add(output.GetString(original.GetBytes(s)))
        Next
        Return list.ToArray
    End Function
End Module
