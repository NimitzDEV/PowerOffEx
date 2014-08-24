Module mdDebugArgs

    Public Sub startArgsChecking()

        For Each s As String In My.Application.CommandLineArgs
            argsExc(s)
        Next
    End Sub
    Private Sub argsExc(ByVal args As String)
        Select Case args
            Case "values"
                debugShowValues()
            Case "evn"
        End Select
    End Sub
    Private Sub debugShowValues()
        MsgBox("chkISLT:" & checkIsLaptop() & vbCrLf _
       & "OMV:" & osMajorVersion & vbCrLf _
       & "BSV:" & batteryStatus & vbCrLf _
& "BPV:" & batteryPercent & vbCrLf _
& "BLV:" & batteryLife & vbCrLf _
& "BCSIndex:" & batteryChargeStatus _
       , MsgBoxStyle.OkOnly, "VALUES")
    End Sub
End Module
