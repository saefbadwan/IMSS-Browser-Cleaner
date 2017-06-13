Imports System.IO

Public Class IMSS_SECTION_CLEAN
    Private _IMSS_SECTION_COMPLETE As New IMSS_SECTION_COMPLETE
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        _IMSS_SECTION_COMPLETE.Dock = DockStyle.Fill
        _IMSS_SECTION_COMPLETE.Visible = True
        _IMSS_SECTION_COMPLETE.BringToFront()
        ' Add any initialization after the InitializeComponent() call.
        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Private Sub _IMSS_STARTS()
        For Each _IMSS_ITEM In _IMSS_SELECTED_ITEMS
            _IMSS_ChangeProgressViaUint()
            _IMSS_ChangeLabel(_IMSS_ITEM)
            _IMSS_DeleteTarget(_IMSS_ITEM)
        Next
    End Sub
#Region "IMSS INVOKE FUNC OPER"
    Private Delegate Sub _IMSS_ChangeProgressViaUintDelegate()
    Private Sub _IMSS_ChangeProgressViaUint()
        If _IMSS_Scanning_ProgressBar.InvokeRequired = True Then
            Invoke(New _IMSS_ChangeProgressViaUintDelegate(AddressOf _IMSS_ChangeProgressViaUint))
        Else
            _IMSS_Scanning_ProgressBar.Value += 1
        End If
    End Sub
    Private Delegate Sub _IMSS_ChangeLabelDelegate(ByVal _IMSS_VALUE As String)
    Private Sub _IMSS_ChangeLabel(ByVal _IMSS_VALUE As String)
        If _IMSS_CheckingCategoryTarget_Label.InvokeRequired = True Then
            Invoke(New _IMSS_ChangeLabelDelegate(AddressOf _IMSS_ChangeLabel), _IMSS_VALUE)
        Else
            _IMSS_CheckingCategoryTarget_Label.Text = _IMSS_VALUE
        End If
    End Sub
#End Region
    Private Sub _IMSS_DeleteTarget(ByVal _IMSS_TARGET As String)
        Try
            IO.File.Delete(_IMSS_TARGET)
        Catch
            _IMSS_SELECTED_ITEMS_ONERROR.Add(_IMSS_TARGET)
        End Try
    End Sub

    Private Sub _IMSS_OnComplete()
        If Not _IMSS_SELECTED_ITEMS_ONERROR.Count() = 0 Then
            _IMSS_SECTION_COMPLETE._IMSS_OnError_label.Visible = True
            _IMSS_SECTION_COMPLETE._IMSS_RestartNow_Button.Visible = True
            _IMSS_SECTION_COMPLETE._IMSS_SucsessLogo_PictureBox.Visible = False
            _IMSS_SECTION_COMPLETE._IMSS_Complete_Label.Visible = False
            MainWindow.AcceptButton = _IMSS_SECTION_COMPLETE._IMSS_RestartNow_Button
            _IMSS_CreateRunOnce()
        Else
            _IMSS_SECTION_COMPLETE._IMSS_OnError_label.Visible = False
            _IMSS_SECTION_COMPLETE._IMSS_RestartNow_Button.Visible = False
            _IMSS_SECTION_COMPLETE._IMSS_SucsessLogo_PictureBox.Visible = True
            _IMSS_SECTION_COMPLETE._IMSS_Complete_Label.Visible = True
            _IMSS_SECTION_COMPLETE._IMSS_Close.Location = New Point(780, 12)
            MainWindow.AcceptButton = _IMSS_SECTION_COMPLETE._IMSS_Close
        End If
    End Sub
    Dim _IMSS_HostsPath As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "_IMSS_Cleaner.IMSSDATA")
    Private Sub _IMSS_CreateRunOnce()
        If Not IO.File.Exists(IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "_IMSS_Cleaner.exe")) Then
            _IMSS_Writepaths()
        Else
            If IO.File.Exists(IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "_IMSS_Cleaner.exe")) Then IO.File.Delete(IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "_IMSS_Cleaner.exe"))
            If IO.File.Exists(IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "IMSS Onerror Cleaner.exe.config")) Then IO.File.Delete(IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "IMSS Onerror Cleaner.exe.config"))
            _IMSS_Writepaths()
        End If
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce", "_IMSS_CLEANER", IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "_IMSS_Cleaner.exe"))
        If IO.File.Exists(_IMSS_HostsPath) Then : IO.File.Delete(_IMSS_HostsPath)
            IO.File.Create(_IMSS_HostsPath).Dispose()
        End If
        For Each _IMSS_ITEM In _IMSS_SELECTED_ITEMS_ONERROR
            _IMSS_WriteItemToHostFile(_IMSS_ITEM)
        Next
    End Sub
    Private Sub _IMSS_Writepaths()
        IO.File.WriteAllBytes(IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "_IMSS_Cleaner.exe"), My.Resources.IMSS_Onerror_Cleaner)
        IO.File.WriteAllBytes(IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "IMSS Onerror Cleaner.exe.config"), My.Resources.IMSS_Onerror_Cleaner_exe)
    End Sub
    Private Sub _IMSS_WriteItemToHostFile(ByRef _IMSS_TARGET As String)
        Using sw As StreamWriter = File.AppendText(_IMSS_HostsPath)
            sw.WriteLine(_IMSS_TARGET)
        End Using
    End Sub
    Private Sub _IMSS_Complete()
        MainWindow._IMSS_MainPanel.Controls.Clear()
        MainWindow._IMSS_MainPanel.Controls.Add(_IMSS_SECTION_COMPLETE)
    End Sub
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        System.Threading.Thread.Sleep(1000)
        _IMSS_STARTS()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        _IMSS_OnComplete()
        For Each _IMSS_ITEM In _IMSS_SELECTED_ITEMS_ONERROR
            _IMSS_SECTION_COMPLETE._IMSS_RESULT_COMPLETE_LSTVIEW.Groups(0).Items.Add(_IMSS_ITEM)
        Next : _IMSS_Complete()
    End Sub
End Class
