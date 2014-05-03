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
    Private Declare Function GetDesktopWindow Lib "user32" () As Integer
    Private Declare Function GetWindow Lib "user32" (ByVal hwnd As Integer, ByVal wCmd As Integer) As Integer
    Private Const GW_CHILD = 5
    Private Const GW_HWNDNEXT = 2
    Public Function getTitle() As String
        Dim hwnd As Long
        '取得桌面窗口
        hwnd = GetDesktopWindow()
        '取得桌面窗口的第一个子窗口
        hwnd = GetWindow(hwnd, GW_CHILD)
        '通过循环来枚举所有的窗口
        Do While hwnd <> 0
            '取得下一个窗口的标题，并写入到列表框中
            Dim hdl As New IntPtr(hwnd) '获取活动窗口的句柄
            Dim strTitle As String = Space(GetWindowTextLength(hdl) + 1)     '用来存储窗口的标题
            GetWindowText(hwnd, strTitle, strTitle.Length)
            If strTitle <> vbNullString Or strTitle <> "Default IME" Or strTitle <> "GDI+ Window" Then
                If scanChar(strTitle) = 2 Then
                    Return strTitle
                    Exit Do
                End If
            End If
            '调用GetWindow函数，来取得下一个窗口
            hwnd = GetWindow(hwnd, GW_HWNDNEXT)
            Application.DoEvents()
        Loop
        Return ""
    End Function
    Public Function scanChar(ByVal scanStr As String) As Integer
        tmpChar = scanStr
        signFull = 0
        If InStr(tmpChar, "第") <> 0 Then signFull += 1
        If InStr(tmpChar, "集") <> 0 Then signFull += 1
        Return signFull
    End Function
    Public Sub getTvTitleAndPg()
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
