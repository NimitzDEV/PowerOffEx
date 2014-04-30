Module tvTracker
    '--------------全局变量
    Public tvTitle As String
    Public tvProgress As String
    Public oldTvTitle As String
    Public oldTvProgress As String
    '---------本模块私有变量
    Dim tmpChar As String
    Dim tmpChar2 As String
    Dim signFull As Integer
    Private Declare Function GetWindowText Lib "user32" Alias "GetWindowTextA" (ByVal hwnd As IntPtr, ByVal lpString As String, ByVal cch As Integer) As Integer
    Private Declare Function GetWindowTextLength Lib "user32" Alias "GetWindowTextLengthA" (ByVal hwnd As IntPtr) As Integer
    Declare Function GetForegroundWindow Lib "user32" () As Integer
    Public Function getTitle() As String
        For Each proc As Process In Process.GetProcesses
            If proc.MainWindowTitle <> "" Then
                tmpChar2 = proc.MainWindowTitle
                Debug.Print("+" & proc.MainWindowTitle)
                If scanChar(tmpChar2) = 2 Then
                    Return tmpChar2
                    Exit Function
                End If
            End If
        Next
        Dim hdl As New IntPtr(GetForegroundWindow) '获取活动窗口的句柄
        Dim strTitle As String = Space(GetWindowTextLength(hdl) + 1) '构造窗口标题字符串缓冲区
        GetWindowText(hdl, strTitle, strTitle.Length) '获取窗口文字
        Debug.Print("-" & strTitle)
        If strTitle <> "" Then
            If scanChar(strTitle) = 2 Then
                Return strTitle
                Exit Function
            End If
        End If
        Return ""
    End Function
    Public Function scanChar(ByVal scanStr As String) As Integer
        tmpChar = scanStr
        signFull = 0
        If InStr(tmpChar, "第") <> 0 Then signFull += 1
        If InStr(tmpChar, "集") <> 0 Then signFull += 1
        Debug.Print(signFull)
        Return signFull
    End Function
    Public Sub getTvTitleAndPg()
        'If scanChar() <> 2 Then Exit Sub
        tmpChar = getTitle()
        If tmpChar = "" Then Exit Sub
        tvTitle = tmpChar.Substring(0, InStr(tmpChar, "第") - 1)
        tvTitle.Trim()
        tvTitle.Replace(" ", "")
        Debug.Print("标题" & tvTitle)
        Debug.Print(InStr(tmpChar, "集") + 1)
        tvProgress = tmpChar.Substring(InStr(tmpChar, "第") - 1, InStr(tmpChar, "集") - InStr(tmpChar, "第") + 1)
        Debug.Print("集数" & tvProgress)
    End Sub
End Module
