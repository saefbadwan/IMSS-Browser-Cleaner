Imports Microsoft.Win32

Public Class IMSS_FILES_SEARCHERS
    Public Shared Function _IMSS_CheckIfRegeditKeyExsits(ByVal _IMSS_TARGET As String) As Boolean
        Dim regKey As Object = My.Computer.Registry.CurrentUser.OpenSubKey(_IMSS_TARGET)
        If Not regKey Is Nothing Then
            regKey.close()
            Return True
        Else
            regKey.close()
            Return False
        End If
    End Function
    Public Shared Sub _IMSS_DirSearcher(ByVal _IMSS_Path As String, ByVal _IMSS_Argument As String, ByVal _IMSS_DictionryKey As String, ByRef _IMSS_Target As Dictionary(Of String, String))
        On Error Resume Next
        For Each _IMSS_File In My.Computer.FileSystem.GetFiles(_IMSS_Path, FileIO.SearchOption.SearchAllSubDirectories, _IMSS_Argument)
            _IMSS_Target.Add(_IMSS_File, _IMSS_DictionryKey)
        Next
    End Sub
    Public Shared Sub _IMSS_FileSearcher(ByVal _IMSS_Path As String, ByVal _IMSS_DictionryKey As String, ByRef _IMSS_Target As Dictionary(Of String, String))
        Try
            _IMSS_Target.Add(_IMSS_Path, _IMSS_DictionryKey)
        Catch : End Try
    End Sub
    Public Shared Sub _IMSS_RegeditSearcher(ByVal _IMSS_Path As String, ByRef _IMSS_Target As List(Of String))
            Dim _IMSS_RegeditKey As RegistryKey = Registry.CurrentUser.OpenSubKey(_IMSS_Path)
            For Each _IMSS_VALUE In _IMSS_RegeditKey.GetValueNames()
            _IMSS_Target.Add(_IMSS_Path & "\" & _IMSS_VALUE.ToString())
            Next
    End Sub
End Class
