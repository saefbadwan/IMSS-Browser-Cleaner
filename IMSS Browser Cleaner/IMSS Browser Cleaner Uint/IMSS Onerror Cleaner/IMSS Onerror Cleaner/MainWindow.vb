' بسم الله الرحمن الرحيم
Public Class MainWindow
    Dim _IMSS_HostsPath As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "_IMSS_Cleaner.IMSSDATA")

    Private Sub _IMSS_LOAD_TARGETS()
        Dim objReader As New System.IO.StreamReader(_IMSS_HostsPath)
        Dim _IMSS_LINE As String = String.Empty
        Do While objReader.Peek() <> -1
            _IMSS_LINE = objReader.ReadLine()
            _IMSS_ChangeLabel(_IMSS_LINE)
            _IMSS_DeleteTargets(_IMSS_LINE)
        Loop : objReader.Close()
        Try : IO.File.Delete(_IMSS_HostsPath) : Catch : End Try
        Application.Exit()
    End Sub
    Private Sub _IMSS_DeleteTargets(ByVal _IMSS_TARGET As String)
        If IO.File.Exists(_IMSS_TARGET) Then
            Try : IO.File.Delete(_IMSS_TARGET) : Catch : End Try
        ElseIf IO.Directory.Exists(_IMSS_TARGET) Then
            Try : IO.Directory.Delete(_IMSS_TARGET) : Catch : End Try
        Else
            Try : IO.File.Delete(_IMSS_TARGET) : Catch : End Try
        End If
    End Sub
    Private Delegate Sub _IMSS_ChangeLabelDelegate(ByVal _IMSS_VALUES As String)
    Private Sub _IMSS_ChangeLabel(ByVal _IMSS_VALUES As String)
        If _IMSS_Cleaning_Label.InvokeRequired = True Then
            Invoke(New _IMSS_ChangeLabelDelegate(AddressOf _IMSS_ChangeLabel), _IMSS_VALUES)
        Else
            _IMSS_Cleaning_Label.Text = _IMSS_VALUES
        End If
    End Sub

    Private Sub MainWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not IO.File.Exists(_IMSS_HostsPath) Then
            Application.ExitThread()
        Else
            Dim _IMSS_THREAD As New Threading.Thread(AddressOf _IMSS_LOAD_TARGETS) : _IMSS_THREAD.Start()
        End If
    End Sub
End Class
