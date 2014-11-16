﻿Imports Microsoft.VisualBasic.FileIO.FileSystem
Module mdCstBg
    Private fileDld As Net.WebClient
    Dim trdBGTrd As System.Threading.Thread
    '公共变量
    Public wrd(4) As String
    Public bgImageList(4) As Image
    Public cirColor(4, 1) As Color
    Dim srcStr, srcStr2, srcStr3, srcStr4 As String
    Dim clrIn, clrIn2, clrIn3 As String
    Public Sub downloadFile(ByVal Url As String, ByVal Path As String)
        If Url = "-" Then Exit Sub
        Try
            fileDld = New Net.WebClient
            fileDld.DownloadFile(New Uri(Url), Path)
        Catch ex As Exception
        End Try
    End Sub
    Public Sub cstBGDownloadStarter()
        trdBGTrd = New Threading.Thread(New System.Threading.ThreadStart(AddressOf cstConfig))
        trdBGTrd.Start()
    End Sub
    Private Sub cstConfig()
        '初始化
        initDefault()
        '下载配置信息
        downloadFile("http://ndev.cu.cc/cfgol/config_dsgjex.ndev", folderPath & "\webcfg.ini")
        If FileExists(folderPath & "\webcfg.ini") = False Then Exit Sub
        '读取配置信息
        '-判断日期
        If GetINI("cfg", "date", "0", "\webcfg.ini") <> Year(Now) & Month(Now) & Date.Today.Day Then Exit Sub
        '-载入文字和图片
        For i = 0 To 4
            srcStr4 = GetINI("cfg", "wrd" & i + 1, "", "\webcfg.ini")
            wrd(i) = IIf(srcStr4 = "", getWrd(i), srcStr4)
        Next
        For i = 0 To 4
            clrIn = GetINI("cfg", "clr" & i + 1, "", "\webcfg.ini")
            If clrIn <> "" Then
                clrIn2 = Split(clrIn, ";")(0)
                clrIn3 = Split(clrIn, ";")(1)
                cirColor(i, 0) = IIf(clrIn2 = "", Color.Orange.ToArgb, Color.FromArgb(clrIn2))
                cirColor(i, 1) = IIf(clrIn3 = "", Color.DodgerBlue.ToArgb, Color.FromArgb(clrIn3))
            End If
        Next
        For i = 0 To 4
            srcStr = GetINI("cfg", "src" & i + 1, "", "\webcfg.ini")
            If srcStr <> "" Then
                srcStr2 = Split(srcStr, ";")(0)
                srcStr3 = Split(srcStr, ";")(1)
                downloadFile(srcStr2, folderPath & srcStr3)
                bgImageList(i) = IIf(srcStr2 = "", getImg(i), _
                                 IIf(FileExists(folderPath & srcStr3), Image.FromFile(folderPath & srcStr3), getImg(i)))
            End If
        Next
    End Sub
    Private Sub initDefault()
        For i = 0 To 4
            bgImageList(i) = getImg(i)
            wrd(i) = getWrd(i)
            cirColor(i, 0) = Color.Orange
            cirColor(i, 1) = Color.DodgerBlue
        Next
    End Sub
    Private Function getWrd(ByVal idx As Integer) As String
        Select Case idx
            Case 0
                Return "凌晨"
            Case 1
                Return "早上"
            Case 2
                Return "中午"
            Case 3
                Return "下午"
            Case 4
                Return "晚上"
        End Select
        Return ""
    End Function
    Private Function getImg(ByVal idx As Integer) As Image
        Select Case idx
            Case 0
                Return My.Resources.bg_midnight_01
            Case 1
                Return My.Resources.bg_morning_01
            Case 2
                Return My.Resources.bg_noon_01
            Case 3
                Return My.Resources.bg_afternoon_01
            Case 4
                Return My.Resources.bg_evening_01
        End Select
        Return My.Resources.bg_nm_rnd1
    End Function
End Module
