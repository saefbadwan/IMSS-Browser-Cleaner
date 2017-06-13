Imports ComponentOwl.BetterListView

Public Class IMSS_SECTION_RESULT

    Private Sub _IMSS_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Close.Click
        Application.Exit()
    End Sub
    Private _IMSS_ChromeItems As New List(Of BetterListViewItem)
    Private Sub _IMSS_Chrome_CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Chrome_CheckBox.CheckedChanged
        _IMSS_RESULT_LSTVIEW.BeginUpdate()
        If _IMSS_Chrome_CheckBox.CheckState = CheckState.Unchecked Then : _IMSS_ChromeItems.Clear()
            For index = 0 To _IMSS_RESULT_LSTVIEW.Groups(1).Items.Count() - 1 Step 1
                _IMSS_ChromeItems.Add(_IMSS_RESULT_LSTVIEW.Groups(1).Items(index)) : _IMSS_RESULT_LSTVIEW.Groups(1).Items(index).Checked = False : _IMSS_RESULT_LSTVIEW.Groups(1).Items(index).Remove()
            Next index
        Else
            If Not _IMSS_ChromeItems.Count = 0 Then
                _IMSS_RESULT_LSTVIEW.Groups(1).Items.AddRange(_IMSS_ChromeItems)
                _IMSS_CheckItems(1)
            End If
        End If
        _IMSS_RESULT_LSTVIEW.EndUpdate()
    End Sub

    Private _IMSS_MozillaFireFox_List As New List(Of BetterListViewItem)
    Private Sub _IMSS_MozillaFireFox_CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_MozillaFireFox_CheckBox.CheckedChanged
        If _IMSS_MozillaFireFox_CheckBox.CheckState = CheckState.Unchecked Then : _IMSS_MozillaFireFox_List.Clear()
            For index = 0 To _IMSS_RESULT_LSTVIEW.Groups(2).Items.Count() - 1 Step 1
                _IMSS_MozillaFireFox_List.Add(_IMSS_RESULT_LSTVIEW.Groups(2).Items(index)) : _IMSS_RESULT_LSTVIEW.Groups(2).Items(index).Checked = False : _IMSS_RESULT_LSTVIEW.Groups(2).Items(index).Remove()
            Next index
        Else
            If Not _IMSS_MozillaFireFox_List.Count = 0 Then
                _IMSS_RESULT_LSTVIEW.Groups(2).Items.AddRange(_IMSS_MozillaFireFox_List)
                _IMSS_CheckItems(2)
            End If
        End If
    End Sub
    Private _IMSS_InternetExplorer_List As New List(Of BetterListViewItem)
    Private Sub _IMSS_InternetExplorer_CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_InternetExplorer_CheckBox.CheckedChanged
        If _IMSS_InternetExplorer_CheckBox.CheckState = CheckState.Unchecked Then : _IMSS_InternetExplorer_List.Clear()
            For index = 0 To _IMSS_RESULT_LSTVIEW.Groups(0).Items.Count() - 1 Step 1
                _IMSS_InternetExplorer_List.Add(_IMSS_RESULT_LSTVIEW.Groups(0).Items(index)) : _IMSS_RESULT_LSTVIEW.Groups(0).Items(index).Checked = False : _IMSS_RESULT_LSTVIEW.Groups(0).Items(index).Remove()
            Next index
        Else
            If Not _IMSS_InternetExplorer_List.Count = 0 Then
                _IMSS_RESULT_LSTVIEW.Groups(0).Items.AddRange(_IMSS_InternetExplorer_List)
                _IMSS_CheckItems(0)
            End If
        End If
    End Sub
    Private _IMSS_Opera_List As New List(Of BetterListViewItem)
    Private Sub _IMSS_Opera_CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Opera_CheckBox.CheckedChanged
        If _IMSS_Opera_CheckBox.CheckState = CheckState.Unchecked Then : _IMSS_Opera_List.Clear()
            For index = 0 To _IMSS_RESULT_LSTVIEW.Groups(4).Items.Count() - 1 Step 1
                _IMSS_Opera_List.Add(_IMSS_RESULT_LSTVIEW.Groups(4).Items(index)) : _IMSS_RESULT_LSTVIEW.Groups(4).Items(index).Checked = False : _IMSS_RESULT_LSTVIEW.Groups(4).Items(index).Remove()
            Next index
        Else
            If Not _IMSS_Opera_List.Count = 0 Then
                _IMSS_RESULT_LSTVIEW.Groups(4).Items.AddRange(_IMSS_Opera_List)
                _IMSS_CheckItems(4)
            End If
        End If
    End Sub
    Private _IMSS_Safari_List As New List(Of BetterListViewItem)
    Private Sub _IMSS_Safari_CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Safari_CheckBox.CheckedChanged
        If _IMSS_Safari_CheckBox.CheckState = CheckState.Unchecked Then : _IMSS_Safari_List.Clear()
            For index = 0 To _IMSS_RESULT_LSTVIEW.Groups(5).Items.Count() - 1 Step 1
                _IMSS_Safari_List.Add(_IMSS_RESULT_LSTVIEW.Groups(5).Items(index)) : _IMSS_RESULT_LSTVIEW.Groups(5).Items(index).Checked = False : _IMSS_RESULT_LSTVIEW.Groups(5).Items(index).Remove()
            Next index
        Else
            If Not _IMSS_Safari_List.Count = 0 Then
                _IMSS_CheckItems(5)
                _IMSS_RESULT_LSTVIEW.Groups(5).Items.AddRange(_IMSS_Safari_List)
            End If
        End If
    End Sub
    Private Sub _IMSS_CheckItems(ByVal _IMSS_GROUPINDEX As Integer)
        For _IMSS_ITEM = 0 To _IMSS_RESULT_LSTVIEW.Groups(_IMSS_GROUPINDEX).Items.Count() - 1 Step 1
            If CType(_IMSS_RESULT_LSTVIEW.Groups(_IMSS_GROUPINDEX).Items(_IMSS_ITEM).SubItems(1).Text, Long) = 0 Then
                _IMSS_RESULT_LSTVIEW.Groups(_IMSS_GROUPINDEX).Items(_IMSS_ITEM).Remove()
            Else
                If Not _IMSS_RESULT_LSTVIEW.Groups(_IMSS_GROUPINDEX).Items(_IMSS_ITEM).Checked = True Then
                    _IMSS_RESULT_LSTVIEW.Groups(_IMSS_GROUPINDEX).Items(_IMSS_ITEM).Checked = True
                End If
            End If
        Next _IMSS_ITEM
    End Sub

    'Private Sub _IMSS_OperaCheckBox_Panel_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_OperaCheckBox_Panel.MouseEnter
    '    If _IMSS_Opera_CheckBox.CheckState = CheckState.Checked Then
    '        _IMSS_Browser_Tooltip.SetBalloonText(_IMSS_OperaCheckBox_Panel, "Opera is installed")
    '    Else
    '        _IMSS_Browser_Tooltip.SetBalloonText(_IMSS_OperaCheckBox_Panel, "Opera : Not installed and no data found")
    '    End If
    'End Sub

    'Private Sub _IMSS_SafariCheckBox_Panel_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_SafariCheckBox_Panel.MouseEnter
    '    If _IMSS_Safari_CheckBox.CheckState = CheckState.Checked Then
    '        _IMSS_Browser_Tooltip.SetBalloonText(_IMSS_SafariCheckBox_Panel, "Safari is installed")
    '    Else
    '        _IMSS_Browser_Tooltip.SetBalloonText(_IMSS_SafariCheckBox_Panel, "Safari : Not installed and no data found")
    '    End If
    'End Sub

    'Private Sub _IMSS_InternetExplorerCheckBox_Panel_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_InternetExplorerCheckBox_Panel.MouseEnter
    '    If _IMSS_InternetExplorer_CheckBox.CheckState = CheckState.Checked Then
    '        _IMSS_Browser_Tooltip.SetBalloonText(_IMSS_InternetExplorerCheckBox_Panel, "Microsoft Internet Explorer is installed")
    '    Else
    '        _IMSS_Browser_Tooltip.SetBalloonText(_IMSS_InternetExplorerCheckBox_Panel, "Microsoft Internet Explorer (Internet Explorer browser) : Not installed " & Environment.NewLine & " and no data found")
    '    End If
    'End Sub

    'Private Sub _IMSS_MozillaFireFoxCheckBox_Panel_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_MozillaFireFoxCheckBox_Panel.MouseEnter
    '    If _IMSS_MozillaFireFox_CheckBox.CheckState = CheckState.Checked Then
    '        _IMSS_Browser_Tooltip.SetBalloonText(_IMSS_MozillaFireFoxCheckBox_Panel, "Mozilla FireFox is installed")
    '    Else
    '        _IMSS_Browser_Tooltip.SetBalloonText(_IMSS_MozillaFireFoxCheckBox_Panel, "Mozilla FireFox (Mozilla FireFox-based browser) : Not installed " & Environment.NewLine & " and no data found")
    '    End If
    'End Sub

    'Private Sub _IMSS_ChromeCheckBox_Panel_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ChromeCheckBox_Panel.MouseEnter
    '    If _IMSS_Chrome_CheckBox.CheckState = CheckState.Checked Then
    '        _IMSS_Browser_Tooltip.SetBalloonText(_IMSS_ChromeCheckBox_Panel, "Google Chrome is installed")
    '    Else
    '        _IMSS_Browser_Tooltip.SetBalloonText(_IMSS_ChromeCheckBox_Panel, "Google Chrome (Chromium-based browser) : Not installed " & Environment.NewLine & " and no data found")
    '    End If
    'End Sub

    Private Sub _IMSS_RESULT_LSTVIEW_ItemChecked(ByVal sender As Object, ByVal eventArgs As ComponentOwl.BetterListView.BetterListViewItemCheckedEventArgs) Handles _IMSS_RESULT_LSTVIEW.ItemChecked
        Dim _IMSS_ArrayParts() As String = eventArgs.Item.Tag.ToString().Split("|")
        If eventArgs.NewCheckState = CheckState.Checked Then
            _IMSS_TotaleSelectedItemsSizeToDelete_Label.Text = IMSS_SECTION_MAIN._IMSS_ByteToMegaByte(CType(_IMSS_TotaleSelectedItemsSizeToDelete_Label.Tag, Long) + CType(_IMSS_ArrayParts(1), Long))
            _IMSS_TotaleSelectedItemsSizeToDelete_Label.Tag = (CType(_IMSS_TotaleSelectedItemsSizeToDelete_Label.Tag, Long) + CType(_IMSS_ArrayParts(1), Long)).ToString()
        Else
            _IMSS_TotaleSelectedItemsSizeToDelete_Label.Text = IMSS_SECTION_MAIN._IMSS_ByteToMegaByte(CType(_IMSS_TotaleSelectedItemsSizeToDelete_Label.Tag, Long) - CType(_IMSS_ArrayParts(1), Long))
            _IMSS_TotaleSelectedItemsSizeToDelete_Label.Tag = (CType(_IMSS_TotaleSelectedItemsSizeToDelete_Label.Tag, Long) - CType(_IMSS_ArrayParts(1), Long)).ToString()
        End If : _IMSS_CheckTotalSelectedItems()
    End Sub
    Private Sub _IMSS_CheckTotalSelectedItems()
        Dim _IMSS_TotalSelectedItems As Long = 0
        For Each _IMSS_ITEM In _IMSS_RESULT_LSTVIEW
            If _IMSS_ITEM.Checked = True Then
                _IMSS_TotalSelectedItems += CType(_IMSS_ITEM.SubItems(1).Text, Long)
            End If
        Next
        _IMSS_ItemToDeleteTotalNumber_Label.Text = CType(_IMSS_TotalSelectedItems, String) & " - Item"
    End Sub

    Private Sub _IMSS_ViewItems_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ViewItems_Button.Click
        If Not _IMSS_RESULT_LSTVIEW.SelectedItems.Count = 0 Then
            If Not _IMSS_RESULT_LSTVIEW.SelectedItems(0).SubItems(1).Text = "" Then
                Dim _IMSS_ArrayParts() As String = _IMSS_RESULT_LSTVIEW.SelectedItems(0).Tag.ToString().Split("|")
                Select Case _IMSS_RESULT_LSTVIEW.SelectedItems(0).Group.Index
                    Case 0
                        _IMSS_SowListItems(_IMSS_InternetExplorer, _IMSS_ArrayParts(0), 0)
                    Case 1
                        _IMSS_SowListItems(_IMSS_GoogleChromeDictionary, _IMSS_ArrayParts(0), 1)
                    Case 2
                        _IMSS_SowListItems(_IMSS_MozillaFirefoxDictionary, _IMSS_ArrayParts(0), 2)
                    Case 3
                        _IMSS_SowListItems(_IMSS_OperaDictionary, _IMSS_ArrayParts(0), 3)
                    Case 4
                        _IMSS_SowListItems(_IMSS_SafariDictionary, _IMSS_ArrayParts(0), 4)
                    Case Else : Exit Select
                End Select
            End If
        End If
    End Sub
    Private Sub _IMSS_SowListItems(ByRef _IMSS_DICTIONRY_TARGET As Dictionary(Of String, String), ByVal _IMSS_ITEMS_TARGET As String, ByVal _IMSS_DictionarIndex As Integer)
        Dim _IMSS_ListItems As New _IMSS_ListItems(_IMSS_DICTIONRY_TARGET, _IMSS_RESULT_LSTVIEW.SelectedItems(0).Group.Header, _IMSS_ITEMS_TARGET, _IMSS_DictionarIndex)
        _IMSS_ListItems.ShowDialog()
        _IMSS_RESULT_LSTVIEW.SelectedItems(0).SubItems(1).Text = CType(CType(_IMSS_RESULT_LSTVIEW.SelectedItems(0).SubItems(1).Text, Long) - CType(_IMSS_Int, Long), String) : _IMSS_Int = 0
        Dim _IMSS_ArrayParts() As String = _IMSS_RESULT_LSTVIEW.SelectedItems(0).Tag.ToString().Split("|")
        _IMSS_RESULT_LSTVIEW.SelectedItems(0).Tag = _IMSS_ArrayParts(0) & "|" & (CType(_IMSS_ArrayParts(1), Long) - _IMSS_SizeInt)
        _IMSS_TotaleSelectedItemsSizeToDelete_Label.Text = IMSS_SECTION_MAIN._IMSS_ByteToMegaByte(CType(_IMSS_TotaleSelectedItemsSizeToDelete_Label.Tag, Long) - CType(_IMSS_SizeInt, Long))
        _IMSS_TotaleSelectedItemsSizeToDelete_Label.Tag = (CType(_IMSS_TotaleSelectedItemsSizeToDelete_Label.Tag, Long) - CType(_IMSS_SizeInt, Long)).ToString() : _IMSS_SizeInt = 0
        _IMSS_RESULT_LSTVIEW.SelectedItems(0).Checked = False : _IMSS_RESULT_LSTVIEW.SelectedItems(0).Checked = True
        If CType(_IMSS_RESULT_LSTVIEW.SelectedItems(0).SubItems(1).Text, Long) = 0 Then _IMSS_RESULT_LSTVIEW.SelectedItems(0).Remove()
    End Sub

    Private Sub _IMSS_Clean_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Clean_Button.Click
        For Each _IMSS_ITEM In _IMSS_RESULT_LSTVIEW.CheckedItems
            Dim _IMSS_ArrayParts() As String = _IMSS_ITEM.Tag.ToString().Split("|")
            Select Case _IMSS_ITEM.Group.Index
                Case 0
                    _IMSS_GEtTargetItems(_IMSS_InternetExplorer, _IMSS_ArrayParts(0)) : Exit Select
                Case 1
                    _IMSS_GEtTargetItems(_IMSS_GoogleChromeDictionary, _IMSS_ArrayParts(0)) : Exit Select
                Case 2
                    _IMSS_GEtTargetItems(_IMSS_MozillaFirefoxDictionary, _IMSS_ArrayParts(0)) : Exit Select
                Case 3
                    _IMSS_GEtTargetItems(_IMSS_OperaDictionary, _IMSS_ArrayParts(0)) : Exit Select
                Case 4
                    _IMSS_GEtTargetItems(_IMSS_SafariDictionary, _IMSS_ArrayParts(0)) : Exit Select
                Case Else
                    Exit Select
            End Select
        Next _IMSS_ITEM
        Dim _IMSS_SECTION_CLEAN As New IMSS_SECTION_CLEAN
        _IMSS_SECTION_CLEAN._IMSS_Scanning_ProgressBar.Maximum = _IMSS_SELECTED_ITEMS.Count()
        _IMSS_SECTION_CLEAN.Dock = DockStyle.Fill
        _IMSS_SECTION_CLEAN.BringToFront()
        MainWindow._IMSS_MainPanel.Controls.Clear()
        MainWindow._IMSS_MainPanel.Controls.Add(_IMSS_SECTION_CLEAN)
    End Sub
    Private Sub _IMSS_GEtTargetItems(ByRef _IMSS_Dectionary As Dictionary(Of String, String), ByVal _IMSS_KEY_TARGET As String)
        For Each _IMSS_ITEM In _IMSS_Dectionary
            If _IMSS_ITEM.Value = _IMSS_KEY_TARGET Then
                _IMSS_SELECTED_ITEMS.Add(_IMSS_ITEM.Key)
            End If
        Next _IMSS_ITEM
    End Sub
End Class
