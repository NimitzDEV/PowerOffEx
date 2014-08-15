Imports System.Reflection
Imports System.Security.Cryptography
Imports System.IO

Public Class EmbeddedAssembly

    Shared dic As Dictionary(Of String, Assembly) = Nothing

    Public Shared Sub Load(embeddedResource As String, fileName As String)
        If dic Is Nothing Then
            dic = New Dictionary(Of String, Assembly)()
        End If

        Dim ba As Byte() = Nothing
        Dim asm As Assembly = Nothing
        Dim curAsm As Assembly = Assembly.GetExecutingAssembly()

        Using stm As Stream = curAsm.GetManifestResourceStream(embeddedResource)

            If stm Is Nothing Then
                Throw New Exception(embeddedResource & " is not found in Embedded Resources.")
            End If

            ba = New Byte(CInt(stm.Length) - 1) {}
            stm.Read(ba, 0, CInt(stm.Length))
            Try
                asm = Assembly.Load(ba)

                dic.Add(asm.FullName, asm)
                Return

            Catch
            End Try
        End Using

        Dim fileOk As Boolean = False
        Dim tempFile As String = ""

        Using sha1 As New SHA1CryptoServiceProvider()

            Dim fileHash As String = BitConverter.ToString(sha1.ComputeHash(ba)).Replace("-", String.Empty)


            tempFile = Path.GetTempPath() & fileName

            If File.Exists(tempFile) Then

                Dim bb As Byte() = File.ReadAllBytes(tempFile)
                Dim fileHash2 As String = BitConverter.ToString(sha1.ComputeHash(bb)).Replace("-", String.Empty)

                If fileHash = fileHash2 Then
                    fileOk = True
                Else
                    fileOk = False
                End If
            Else
                fileOk = False
            End If
        End Using
        If Not fileOk Then
            System.IO.File.WriteAllBytes(tempFile, ba)
        End If

        asm = Assembly.LoadFile(tempFile)

        dic.Add(asm.FullName, asm)
    End Sub

    Public Shared Function [Get](assemblyFullName As String) As Assembly
        If dic Is Nothing OrElse dic.Count = 0 Then
            Return Nothing
        End If

        If dic.ContainsKey(assemblyFullName) Then
            Return dic(assemblyFullName)
        End If

        Return Nothing

    End Function



End Class
