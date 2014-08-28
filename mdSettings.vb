Imports Microsoft.VisualBasic.FileIO.FileSystem
Module mdSettings
    Public pref_HOUR As Integer = 2
    Public pref_MIN As Integer = 0
    Public pref_VOL As Integer = 40
    Public pref_VOL_EFF_HOUR As Integer = 23
    Public pref_VOL_EFF_MIN As Integer = 0
    Public pref_VOL_XP As Integer = 20
    Public pref_VOL_XP_MSG As Integer = 1
    Public chk_RECORD As Boolean = False
    Public chk_VOLCTRL As Boolean = False
    Public set_TVP As String = ""
    '====
    Public folderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\定时关机Ex\"
    '====
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32
    'OSVersion
    Public osMajorVersion As Integer
    Dim os As OperatingSystem = Environment.OSVersion
    Public Sub ReadSettings()
        osMajorVersion = os.Version.Major
        If DirectoryExists(folderPath) = False Then MkDir(folderPath)
        If FileExists(folderPath & "config.ini") = False Then Exit Sub
        pref_HOUR = GetINI("pref", "HOUR", pref_HOUR)
        pref_MIN = GetINI("pref", "MIN", pref_MIN)
        pref_VOL = GetINI("pref", "VOL", pref_VOL)
        pref_VOL_EFF_HOUR = GetINI("pref", "VOL_EFF_HOUR", pref_VOL_EFF_HOUR)
        pref_VOL_EFF_MIN = GetINI("pref", "VOL_EFF_MIN", pref_VOL_EFF_MIN)
        pref_VOL_XP = GetINI("pref", "VOL_XP", pref_VOL_XP)
        pref_VOL_XP_MSG = GetINI("pref", "VOL_XP_MSG", pref_VOL_XP_MSG)
        chk_RECORD = GetINI("funcenable", "TVP", chk_RECORD)
        chk_VOLCTRL = GetINI("funcenable", "VOLC", chk_VOLCTRL)
        set_TVP = GetINI("set", "TVP", "")
    End Sub
    Public Sub SaveSettings()
        If DirectoryExists(folderPath) = False Then MkDir(folderPath)
        WriteINI("pref", "HOUR", pref_HOUR)
        WriteINI("pref", "MIN", pref_MIN)
        WriteINI("pref", "VOL", pref_VOL)
        WriteINI("pref", "VOL_EFF_HOUR", pref_VOL_EFF_HOUR)
        WriteINI("pref", "VOL_EFF_MIN", pref_VOL_EFF_MIN)
        WriteINI("pref", "VOL_XP", pref_VOL_XP)
        WriteINI("pref", "VOL_XP_MSG", pref_VOL_XP_MSG)
        WriteINI("funcenable", "TVP", chk_RECORD)
        WriteINI("funcenable", "VOLC", chk_VOLCTRL)
        WriteINI("set", "TVP", set_TVP)
    End Sub
    Public Function GetINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String) As String
        Dim Str As String = ""
        Str = LSet(Str, 256)
        GetPrivateProfileString(Section, AppName, lpDefault, Str, Len(Str), folderPath & "\config.ini")
        Return Microsoft.VisualBasic.Left(Str, InStr(Str, Chr(0)) - 1)
    End Function

    Public Function WriteINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String) As Long
        WriteINI = WritePrivateProfileString(Section, AppName, lpDefault, folderPath & "\config.ini")
    End Function
End Module
