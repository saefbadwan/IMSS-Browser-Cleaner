Imports ComponentOwl.BetterListView
Imports System.IO
Imports System.Runtime.InteropServices

Public Class _IMSS_ListItems
    Public Structure SHELLEXECUTEINFO
        Public cbSize As Integer
        Public fMask As Integer
        Public hwnd As IntPtr
        <MarshalAs(UnmanagedType.LPTStr)> Public lpVerb As String
        <MarshalAs(UnmanagedType.LPTStr)> Public lpFile As String
        <MarshalAs(UnmanagedType.LPTStr)> Public lpParameters As String
        <MarshalAs(UnmanagedType.LPTStr)> Public lpDirectory As String
        Dim nShow As Integer
        Dim hInstApp As IntPtr
        Dim lpIDList As IntPtr
        <MarshalAs(UnmanagedType.LPTStr)> Public lpClass As String
        Public hkeyClass As IntPtr
        Public dwHotKey As Integer
        Public hIcon As IntPtr
        Public hProcess As IntPtr
    End Structure


    Private Const SEE_MASK_INVOKEIDLIST = &HC
    Private Const SEE_MASK_NOCLOSEPROCESS = &H40
    Private Const SEE_MASK_FLAG_NO_UI = &H400
    Public Const SW_SHOW As Short = 5

    <DllImport("Shell32", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function ShellExecuteEx(ByRef lpExecInfo As SHELLEXECUTEINFO) As Boolean
    End Function
    Private _IMSS_TARGETDictionarIndex As Integer
    Public Sub New(ByRef _IMSS_ITEMSARRAYLIST As Dictionary(Of String, String), ByVal _IMSS_TARGETITEMS As String, ByVal _IMSS_KeyItems As String, ByVal _IMSS_DictionarIndex As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        _IMSS_TARGETDictionarIndex = _IMSS_DictionarIndex
        Me.Text = "Show Items Of : " & _IMSS_TARGETITEMS
        _IMSS_LOAd_TARGET_ITEMS(_IMSS_ITEMSARRAYLIST, _IMSS_KeyItems)
    End Sub

    Private _IMSS_LIST_ITEMS As New List(Of BetterListViewItem)
    Private Sub _IMSS_LOAd_TARGET_ITEMS(ByRef _IMSS_ITEMSARRAYLIST As Dictionary(Of String, String), ByVal _IMSS_KeyItems As String)
        On Error Resume Next
        Dim i As Integer = 0
        For Each _IMSS_Key In _IMSS_ITEMSARRAYLIST
            If _IMSS_Key.Value = _IMSS_KeyItems Then
                i += 1
                If i >= 1010 Then Exit For
                Dim _IMSS_ListView As New BetterListViewItem
                With _IMSS_ListView
                    .Tag = _IMSS_KeyItems
                    .Text = Path.GetFileNameWithoutExtension(_IMSS_Key.Key)
                    .Image = My.Resources._IMSS_Other_Icon_24x24
                    .Checked = True
                    .SubItems.Add(_IMSS_GetFileType(Path.GetExtension(_IMSS_Key.Key)))
                    .SubItems.Add(IMSS_SECTION_MAIN._IMSS_ByteToMegaByte(New FileInfo(_IMSS_Key.Key).Length)).ToString()
                    .SubItems.Add(_IMSS_Key.Key).Image = My.Resources._IMSS_TemporaryFile_Icon_16x16
                    .SubItems.Add(Path.GetDirectoryName(_IMSS_Key.Key).ToString()).Image = My.Resources._IMSS_Folder_Icon_16x16
                End With : _IMSS_LIST_ITEMS.Add(_IMSS_ListView) : _IMSS_ListView.Dispose()
            End If
        Next _IMSS_Key : _IMSS_AddItemToList(_IMSS_LIST_ITEMS)
    End Sub
    Private Delegate Sub _IMSS_AddItemToListDelegate(ByRef _IMSS_ITEMS As List(Of BetterListViewItem))
    Private Sub _IMSS_AddItemToList(ByRef _IMSS_ITEMS As List(Of BetterListViewItem))
        If _IMSS_ShowItemsBetterListView.InvokeRequired = True Then
            Invoke(New _IMSS_AddItemToListDelegate(AddressOf _IMSS_AddItemToList), _IMSS_ITEMS)
        Else
            _IMSS_ShowItemsBetterListView.Items.AddRange(_IMSS_ITEMS) : _IMSS_ITEMS.Clear()
            If Not _IMSS_ShowItemsBetterListView.Items.Count() = 0 Then _IMSS_ShowItemsBetterListView.Items(0).Selected = True
        End If
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not _IMSS_ShowItemsBetterListView.SelectedItems.Count = 0 Then
            Try
                Process.Start(_IMSS_ShowItemsBetterListView.SelectedItems(0).SubItems(4).Text)
            Catch : End Try
        End If
    End Sub

    Private Sub _IMSS_ShowItemsBetterListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ShowItemsBetterListView.SelectedIndexChanged
        On Error Resume Next
        For Each _IMSS_ITEMS In _IMSS_ShowItemsBetterListView.Items
            If _IMSS_ITEMS.Selected = True Then
                _IMSS_CO_Label.Text = New FileInfo(_IMSS_ITEMS.SubItems(3).Text).CreationTime.Date.ToString()
                _IMSS_MO_Label.Text = New FileInfo(_IMSS_ITEMS.SubItems(3).Text).LastWriteTime.Date.ToString()
                _IMSS_LA_Label.Text = New FileInfo(_IMSS_ITEMS.SubItems(3).Text).LastAccessTime.Date.ToString()
                _IMSS_SelectedItemImage_PictuerBox.Image = ResizeImage(Icon.ExtractAssociatedIcon(_IMSS_ITEMS.SubItems(3).Text.ToString()).ToBitmap, 41, 32)
                _IMSS_SelectedItemName_Label.Text = Path.GetFileNameWithoutExtension(_IMSS_ITEMS.SubItems(3).Text).ToString()
                _IMSS_SelctedItemType_Label.Text = _IMSS_GetFileType(Path.GetExtension(_IMSS_ITEMS.SubItems(3).Text).ToString()).ToString()
                _IMSS_SelectedItemSize_Label.Text = "Size : " & CType(IMSS_SECTION_MAIN._IMSS_ByteToMegaByte(CType(New FileInfo(_IMSS_ITEMS.SubItems(3).Text).Length, Long)), String)
            End If
        Next
    End Sub
    Private Function _IMSS_GetFileType(ByVal _IMSS_FilePath As String) As String
        Select Case _IMSS_FilePath
            Case ".exe"
                Return "Executable applicatin(.exe)"
            Case ".com"
                Return "Command File(.com)"
            Case ".shs"
                Return "Shell Scrap Object(.shs)"
            Case ".PIF"
                Return "Program Information File(.com)"
            Case ".VB"
                Return "VBScript File(.exe)"
            Case ".BAT"
                Return "Batch File(.com)"
            Case ".CMD"
                Return "Command Script(.exe)"
            Case ".SCT"
                Return "Windows Scriptlet(.com)"
            Case ".lnk"
                Return "Windows File Shortcut(.lnk)"
            Case Else
                Return _IMSS_FilePath
        End Select
    End Function
    Private Sub _IMSS_CheckAll_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_CheckAll_Button.Click
        _IMSS_CheckAll()
    End Sub

    Private Sub _IMSS_UnCheckAll_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_UnCheckAll_Button.Click
        _IMSS_UnCheckAll()
    End Sub

    Private Sub _IMSS_CheckAll()
        For Each _IMSS_ITEMS In _IMSS_ShowItemsBetterListView.Items
            _IMSS_ITEMS.Checked = True
        Next
    End Sub
    Private Sub _IMSS_UnCheckAll()
        For Each _IMSS_ITEMS In _IMSS_ShowItemsBetterListView.Items
            _IMSS_ITEMS.Checked = False
        Next
    End Sub

    Private Sub _IMSS_Delete_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Delete_Button.Click
        If Not _IMSS_ShowItemsBetterListView.SelectedItems.Count = 0 Then
            Try
                If IO.File.Exists(_IMSS_ShowItemsBetterListView.SelectedItems(0).SubItems(3).Text) Then IO.File.Delete(_IMSS_ShowItemsBetterListView.SelectedItems(0).SubItems(3).Text)
                _IMSS_ShowItemsBetterListView.SelectedItems(0).Remove()
            Catch _IMSS_EX As Exception : MessageBox.Show(_IMSS_EX.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) : End Try
        End If
    End Sub

    Private Sub _IMSS_CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_CancelButton.Click
        Me.Close()
    End Sub
    Private Sub _IMSS_Openfile_LinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles _IMSS_Openfile_LinkLabel.LinkClicked
        If Not _IMSS_ShowItemsBetterListView.SelectedItems.Count = 0 Then
            Try
                Process.Start(_IMSS_ShowItemsBetterListView.SelectedItems(0).SubItems(3).Text)
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End Try
        End If
    End Sub

    Private Sub _IMSS_OpenFolder_LinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles _IMSS_OpenFolder_LinkLabel.LinkClicked
        If Not _IMSS_ShowItemsBetterListView.SelectedItems.Count = 0 Then
            Try
                Process.Start(_IMSS_ShowItemsBetterListView.SelectedItems(0).SubItems(4).Text)
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End Try
        End If
    End Sub

    Private Sub _IMSS_FileProperties_LinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles _IMSS_FileProperties_LinkLabel.LinkClicked
        Dim sei As New SHELLEXECUTEINFO
        sei.cbSize = Marshal.SizeOf(sei)
        sei.lpVerb = "properties"
        For Each _IMSS_ITEMS In _IMSS_ShowItemsBetterListView.Items
            If _IMSS_ITEMS.Selected = True Then
                sei.lpFile = _IMSS_ITEMS.SubItems(3).Text.ToString()
            End If
        Next
        sei.nShow = SW_SHOW
        sei.fMask = SEE_MASK_INVOKEIDLIST
        If Not ShellExecuteEx(sei) Then
            Dim ex As New System.ComponentModel.Win32Exception(System.Runtime.InteropServices.Marshal.GetLastWin32Error())
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#Region " ResizeImage "
    Private Function ResizeImage(ByVal SourceImage As Drawing.Image, ByVal TargetWidth As Int32, ByVal TargetHeight As Int32) As Drawing.Bitmap
        Dim bmSource = New Drawing.Bitmap(SourceImage)
        Return ResizeImage(bmSource, TargetWidth, TargetHeight)
    End Function

    Private Function ResizeImage(ByVal bmSource As Drawing.Bitmap, ByVal TargetWidth As Int32, ByVal TargetHeight As Int32) As Drawing.Bitmap
        Dim bmDest As New Drawing.Bitmap(TargetWidth, TargetHeight, Drawing.Imaging.PixelFormat.Format32bppArgb)

        Dim nSourceAspectRatio = bmSource.Width / bmSource.Height
        Dim nDestAspectRatio = bmDest.Width / bmDest.Height

        Dim NewX = 0
        Dim NewY = 0
        Dim NewWidth = bmDest.Width
        Dim NewHeight = bmDest.Height

        If nDestAspectRatio = nSourceAspectRatio Then
            'same ratio
        ElseIf nDestAspectRatio > nSourceAspectRatio Then
            'Source is taller
            NewWidth = Convert.ToInt32(Math.Floor(nSourceAspectRatio * NewHeight))
            NewX = Convert.ToInt32(Math.Floor((bmDest.Width - NewWidth) / 2))
        Else
            'Source is wider
            NewHeight = Convert.ToInt32(Math.Floor((1 / nSourceAspectRatio) * NewWidth))
            NewY = Convert.ToInt32(Math.Floor((bmDest.Height - NewHeight) / 2))
        End If

        Using grDest = Drawing.Graphics.FromImage(bmDest)
            With grDest
                .CompositingQuality = Drawing.Drawing2D.CompositingQuality.HighQuality
                .InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                .PixelOffsetMode = Drawing.Drawing2D.PixelOffsetMode.HighQuality
                .SmoothingMode = Drawing.Drawing2D.SmoothingMode.AntiAlias
                .CompositingMode = Drawing.Drawing2D.CompositingMode.SourceOver

                .DrawImage(bmSource, NewX, NewY, NewWidth, NewHeight)
            End With
        End Using

        Return bmDest
    End Function
#End Region

    Private Sub _IMSS_OkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_OkButton.Click
        Select Case _IMSS_TARGETDictionarIndex
            Case 0
                _IMSS_RemoveUncheckedItems(_IMSS_InternetExplorer) : Exit Select
            Case 1
                _IMSS_RemoveUncheckedItems(_IMSS_GoogleChromeDictionary) : Exit Select
            Case 2
                _IMSS_RemoveUncheckedItems(_IMSS_MozillaFirefoxDictionary) : Exit Select
            Case 3
                _IMSS_RemoveUncheckedItems(_IMSS_OperaDictionary) : Exit Select
            Case 4
                _IMSS_RemoveUncheckedItems(_IMSS_SafariDictionary) : Exit Select
            Case Else
                Exit Select
        End Select : Me.Close()
    End Sub
    Private Sub _IMSS_RemoveUncheckedItems(ByRef _IMSS_TARGET As Dictionary(Of String, String))
        For Each _IMSS_ITEM In _IMSS_ShowItemsBetterListView
            If _IMSS_ITEM.Checked = False Then
                If _IMSS_TARGET.ContainsKey(_IMSS_ITEM.SubItems(3).Text) Then
                    _IMSS_TARGET.Remove(_IMSS_ITEM.SubItems(3).Text)
                    _IMSS_Int += 1
                    _IMSS_SizeInt += _IMSS_GetSizeOfFile(_IMSS_ITEM.SubItems(3).Text)
                End If
            End If
        Next
    End Sub

    Private Function _IMSS_GetSizeOfFile(ByVal _IMSS_TARGET As String) As Long
        If IO.File.Exists(_IMSS_TARGET) Then
            Return New FileInfo(_IMSS_TARGET).Length
        Else
            Return 0
        End If
    End Function
End Class