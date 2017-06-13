Imports System.IO
Imports ComponentOwl.BetterListView
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar

Public Class IMSS_SECTION_MAIN
    Private _IMSS_START_THREAD As New Threading.Thread(AddressOf _IMSS_Initiate)
    Private _IMSS_SECTION_RESULT As New IMSS_SECTION_RESULT
    Private _IMSS_TotalCleanUpPotentialOfElemints As Long = 0
    Private _IMSS_TotalCleanUpPotentialOfSize As Long = 0

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _IMSS_START_THREAD.Start()
    End Sub

    Private Sub _IMSS_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Cancel.Click
        Try
            If _IMSS_START_THREAD.IsAlive = True Then : _IMSS_START_THREAD.Abort() : End If : Catch : End Try
        Application.Exit()
    End Sub
#Region "IMSS Invoke Delegate Section"
    Private Delegate Sub _IMSS_CheckingCategory_LabelIvokeDelegate(ByVal _IMSS_VALUE As String)
    Private Sub _IMSS_CheckingCategory_LabelInvoke(ByVal _IMSS_VALUE As String)
        If _IMSS_CheckingCategory_Label.InvokeRequired = True Then
            Invoke(New _IMSS_CheckingCategory_LabelIvokeDelegate(AddressOf _IMSS_CheckingCategory_LabelInvoke), _IMSS_VALUE)
        Else
            _IMSS_CheckingCategory_Label.Text = _IMSS_VALUE
        End If
    End Sub
    Private Sub _IMSS_CheckingCategoryTarget_LabelInvoke(ByVal _IMSS_VALUE As String)
        If _IMSS_CheckingCategoryTarget_Label.InvokeRequired = True Then
            Invoke(New _IMSS_CheckingCategory_LabelIvokeDelegate(AddressOf _IMSS_CheckingCategoryTarget_LabelInvoke), _IMSS_VALUE)
        Else
            _IMSS_CheckingCategoryTarget_Label.Text = _IMSS_VALUE
        End If
    End Sub
    Private Delegate Sub _IMSS_AddSetpDelegate(ByVal _IMSS_VALUE As Integer)
    Private Sub _IMSS_AddSetp(ByVal _IMSS_VALUE As Integer)
        If _IMSS_Main_StepIndicator.InvokeRequired = True Then
            Invoke(New _IMSS_AddSetpDelegate(AddressOf _IMSS_AddSetp), _IMSS_VALUE)
        Else
            _IMSS_Main_StepIndicator.CurrentStep = _IMSS_VALUE
        End If
    End Sub
#End Region

    Private _IMSS_CheckInternetExplorer As Boolean = False
    Private _IMSS_CheckGoogleChrome As Boolean = False
    Private _IMSS_CheckMozillaFirefox As Boolean = False
    Private _IMSS_CheckSafari As Boolean = False
    Private _IMSS_CheckOpera As Boolean = False

    Private Sub _IMSS_Initiate()
        On Error Resume Next

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''' Internet Explorer ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If Directory.Exists(IMSS_PATHS.InternetExplorerCookies) Then
            IMSS_FILES_SEARCHERS._IMSS_DirSearcher(IMSS_PATHS.InternetExplorerCookies, "*.*", "_IMSS_CookiesInternetExplorer", _IMSS_InternetExplorer)
            _IMSS_CheckInternetExplorer = True
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Internet Explorer")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Cookies")
            _IMSS_AddSetp(1)
        End If

        If Directory.Exists(IMSS_PATHS.InternetExplorerCookiesDomStore) Then
            IMSS_FILES_SEARCHERS._IMSS_DirSearcher(IMSS_PATHS.InternetExplorerCookiesDomStore, "*.*", "_IMSS_Cookies_DOM_Store", _IMSS_InternetExplorer)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Internet Explorer")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Cookies (DOM Store)")
            _IMSS_AddSetp(2)
        End If

        If Directory.Exists(IMSS_PATHS.InternetExplorerTemps) Then
            IMSS_FILES_SEARCHERS._IMSS_DirSearcher(IMSS_PATHS.InternetExplorerTemps, "*.*", "_IMSS_Temporary_Interent_Files", _IMSS_InternetExplorer)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Internet Explorer")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Temporary Interent Files")
            _IMSS_AddSetp(3)
        End If

        If Directory.Exists(IMSS_PATHS.InternetExplorerHistory) Then
            IMSS_FILES_SEARCHERS._IMSS_DirSearcher(IMSS_PATHS.InternetExplorerHistory, "*.*", "_IMSS_HistoryInternetExplorer", _IMSS_InternetExplorer)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Internet Explorer")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> History")
            _IMSS_AddSetp(4)
        End If

        If IMSS_FILES_SEARCHERS._IMSS_CheckIfRegeditKeyExsits(IMSS_PATHS.InternetExplorerRecentlyTypedUrls) = True Then
            IMSS_FILES_SEARCHERS._IMSS_RegeditSearcher(IMSS_PATHS.InternetExplorerRecentlyTypedUrls, _IMSS_InternetExplorerRegistryPath)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Internet Explorer")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Recently Typed URLs")
            _IMSS_AddSetp(5)
        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' Chrome '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If Directory.Exists(IMSS_PATHS.GoogleChromeCookiesLocalStorage) Then
            IMSS_FILES_SEARCHERS._IMSS_DirSearcher(IMSS_PATHS.GoogleChromeCookiesLocalStorage, "*.*", "_IMSS_CookiesLS", _IMSS_GoogleChromeDictionary)
            _IMSS_CheckGoogleChrome = True
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Google Chrome")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Cookies (Local Storage)")
            _IMSS_AddSetp(6)
        End If

        If Directory.Exists(IMSS_PATHS.GoogleChromeCookiesDBs) Then
            IMSS_FILES_SEARCHERS._IMSS_DirSearcher(IMSS_PATHS.GoogleChromeCookiesDBs, "*.*", "_IMSS_CookiesDB", _IMSS_GoogleChromeDictionary)
            _IMSS_CheckGoogleChrome = True
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Google Chrome")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Cookies (DB)")
            _IMSS_AddSetp(7)
        End If

        If Directory.Exists(IMSS_PATHS.GoogleChromeCookies) Then
            IMSS_FILES_SEARCHERS._IMSS_DirSearcher(IMSS_PATHS.GoogleChromeCookies, "*.*", "_IMSS_Cookies", _IMSS_GoogleChromeDictionary)
            _IMSS_CheckGoogleChrome = True
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Google Chrome")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Cookies")
            _IMSS_AddSetp(8)
        End If

        If Directory.Exists(IMSS_PATHS.GoogleChromeCache) Then
            IMSS_FILES_SEARCHERS._IMSS_DirSearcher(IMSS_PATHS.GoogleChromeCache, "*.*", "_IMSS_Cache", _IMSS_GoogleChromeDictionary)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Google Chrome")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Cache")
            _IMSS_AddSetp(9)
        End If

        If Directory.Exists(IMSS_PATHS.GoogleChromeInternetHistory) Then
            IMSS_FILES_SEARCHERS._IMSS_DirSearcher(IMSS_PATHS.GoogleChromeInternetHistory, "*History*", "_IMSS_InternetHistory", _IMSS_GoogleChromeDictionary)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Google Chrome")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Internet History")
            _IMSS_AddSetp(10)
        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''' Mozilla Firefox ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If File.Exists(IMSS_PATHS.MozillaFireFoxCookies) Then
            IMSS_FILES_SEARCHERS._IMSS_FileSearcher(IMSS_PATHS.MozillaFireFoxCookies, "_IMSS_Cookies", _IMSS_MozillaFirefoxDictionary)
            _IMSS_CheckMozillaFirefox = True
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Mozilla Firefox")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Cookies")
            _IMSS_AddSetp(11)
        End If

        If File.Exists(IMSS_PATHS.MozillaFireFoxCookiesWebAppsStore) Then
            IMSS_FILES_SEARCHERS._IMSS_FileSearcher(IMSS_PATHS.MozillaFireFoxCookiesWebAppsStore, "_IMSS_CookiesWebAppsStore", _IMSS_MozillaFirefoxDictionary)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Mozilla Firefox")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Cookies (Web Apps Store)")
            _IMSS_AddSetp(12)
        End If

        If File.Exists(IMSS_PATHS.MozillaFireFoxDownloads) Then
            IMSS_FILES_SEARCHERS._IMSS_FileSearcher(IMSS_PATHS.MozillaFireFoxDownloads, "_IMSS_DownloadHistory", _IMSS_MozillaFirefoxDictionary)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Mozilla Firefox")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Download History")
            _IMSS_AddSetp(13)
        End If

        If File.Exists(IMSS_PATHS.MozillaFireFoxFormHistory) Then
            IMSS_FILES_SEARCHERS._IMSS_FileSearcher(IMSS_PATHS.MozillaFireFoxFormHistory, "_IMSS_FormHistory", _IMSS_MozillaFirefoxDictionary)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Mozilla Firefox")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Form History")
            _IMSS_AddSetp(14)
        End If

        If Directory.Exists(IMSS_PATHS.MozillaFireFoxCache) Then
            IMSS_FILES_SEARCHERS._IMSS_DirSearcher(IMSS_PATHS.MozillaFireFoxCache, "*History*", "_IMSS_History", _IMSS_MozillaFirefoxDictionary)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Mozilla Firefox")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> History")
            _IMSS_AddSetp(15)
        End If

        If File.Exists(IMSS_PATHS.MozillaFirefoxSessionStore) Then
            IMSS_FILES_SEARCHERS._IMSS_FileSearcher(IMSS_PATHS.MozillaFirefoxSessionStore, "_IMSS_SessionStore", _IMSS_MozillaFirefoxDictionary)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Mozilla Firefox")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Session Store")
            _IMSS_AddSetp(16)
        End If

        If File.Exists(IMSS_PATHS.MozillaFirefoxSessionStoreBackup) Then
            IMSS_FILES_SEARCHERS._IMSS_FileSearcher(IMSS_PATHS.MozillaFirefoxSessionStoreBackup, "_IMSS_SessionStoreBackup", _IMSS_MozillaFirefoxDictionary)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Mozilla Firefox")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Session Store (Backup)")
            _IMSS_AddSetp(17)
        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' Safari '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If File.Exists(IMSS_PATHS.SafariCache) Then
            IMSS_FILES_SEARCHERS._IMSS_FileSearcher(IMSS_PATHS.SafariCache, "_IMSS_Cache", _IMSS_SafariDictionary)
            _IMSS_CheckSafari = True
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Safari")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Cache")
            _IMSS_AddSetp(18)
        End If

        If File.Exists(IMSS_PATHS.SafariHistory) Then
            IMSS_FILES_SEARCHERS._IMSS_FileSearcher(IMSS_PATHS.SafariHistory, "_IMSS_History", _IMSS_SafariDictionary)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Safari")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> History")
            _IMSS_AddSetp(19)
        End If

        If Directory.Exists(IMSS_PATHS.SafariWebpagePreviews) Then
            IMSS_FILES_SEARCHERS._IMSS_DirSearcher(IMSS_PATHS.SafariWebpagePreviews, "*History*", "_IMSS_WebpagePreviews", _IMSS_SafariDictionary)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Safari")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Webpage Previews")
            _IMSS_AddSetp(20)
        End If

        If File.Exists(IMSS_PATHS.SafariHistoryDownloadsPlist) Then
            IMSS_FILES_SEARCHERS._IMSS_FileSearcher(IMSS_PATHS.SafariHistoryDownloadsPlist, "_IMSS_DownloadHistory", _IMSS_SafariDictionary)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Safari")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Download History")
            _IMSS_AddSetp(21)
        End If

        If File.Exists(IMSS_PATHS.SafariHistoryLastSessionPlist) Then
            IMSS_FILES_SEARCHERS._IMSS_FileSearcher(IMSS_PATHS.SafariHistoryLastSessionPlist, "_IMSS_LastSession", _IMSS_SafariDictionary)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Safari")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Last Session")
            _IMSS_AddSetp(22)
        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' Opera ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If Directory.Exists(IMSS_PATHS.OperaCache) Then
            IMSS_FILES_SEARCHERS._IMSS_DirSearcher(IMSS_PATHS.OperaCache, "*.*", "_IMSS_CacheOperaDictionary", _IMSS_OperaDictionary)
            _IMSS_CheckOpera = True
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Opera")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Cache")
            _IMSS_AddSetp(23)
        End If

        If Directory.Exists(IMSS_PATHS.OperaOPCache) Then
            IMSS_FILES_SEARCHERS._IMSS_DirSearcher(IMSS_PATHS.OperaOPCache, "*.*", "_IMSS_CacheOP", _IMSS_OperaDictionary)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Opera")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Cache (OP)")
            _IMSS_AddSetp(24)
        End If

        If Directory.Exists(IMSS_PATHS.OperaIconCache) Then
            IMSS_FILES_SEARCHERS._IMSS_DirSearcher(IMSS_PATHS.OperaIconCache, "*.*", "_IMSS_CacheIcons", _IMSS_OperaDictionary)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Opera")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Cache (Icons)")
            _IMSS_AddSetp(25)
        End If

        If Directory.Exists(IMSS_PATHS.OperaInternetHistory_1) Then
            IMSS_FILES_SEARCHERS._IMSS_DirSearcher(IMSS_PATHS.OperaInternetHistory_1, "*.*", "_IMSS_InternetHistory_1", _IMSS_OperaDictionary)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Opera")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Internet History (1)")
            _IMSS_AddSetp(26)
        End If

        If File.Exists(IMSS_PATHS.OperaInternetHistory_2) Then
            IMSS_FILES_SEARCHERS._IMSS_FileSearcher(IMSS_PATHS.OperaInternetHistory_2, "_IMSS_InternetHistory_2", _IMSS_OperaDictionary)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Opera")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Internet History (2)")
            _IMSS_AddSetp(27)
        End If

        If File.Exists(IMSS_PATHS.OperaInternetHistory_3) Then
            IMSS_FILES_SEARCHERS._IMSS_FileSearcher(IMSS_PATHS.OperaInternetHistory_3, "_IMSS_InternetHistory_3", _IMSS_OperaDictionary)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Opera")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Internet History (3)")
            _IMSS_AddSetp(28)
        End If

        If File.Exists(IMSS_PATHS.OperaInternetHistory_4) Then
            IMSS_FILES_SEARCHERS._IMSS_FileSearcher(IMSS_PATHS.OperaInternetHistory_4, "_IMSS_InternetHistory_4", _IMSS_OperaDictionary)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Opera")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Internet History (4)")
            _IMSS_AddSetp(29)
        End If

        If File.Exists(IMSS_PATHS.OperaInternetHistory_5) Then
            IMSS_FILES_SEARCHERS._IMSS_FileSearcher(IMSS_PATHS.OperaInternetHistory_5, "_IMSS_InternetHistory_5", _IMSS_OperaDictionary)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Opera")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Internet History (5)")
            _IMSS_AddSetp(30)
        End If

        If File.Exists(IMSS_PATHS.OperaInternetHistory_6) Then
            IMSS_FILES_SEARCHERS._IMSS_FileSearcher(IMSS_PATHS.OperaInternetHistory_6, "_IMSS_InternetHistory_6", _IMSS_OperaDictionary)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Opera")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Internet History (6)")
            _IMSS_AddSetp(31)
        End If

        If File.Exists(IMSS_PATHS.OperaCookies) Then
            IMSS_FILES_SEARCHERS._IMSS_FileSearcher(IMSS_PATHS.OperaCookies, "_IMSS_CookiesOperaDictionary", _IMSS_OperaDictionary)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Opera")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Cookies")
            _IMSS_AddSetp(32)
        End If

        If Directory.Exists(IMSS_PATHS.OperaWebsiteIcon) Then
            IMSS_FILES_SEARCHERS._IMSS_DirSearcher(IMSS_PATHS.OperaWebsiteIcon, "*.*", "_IMSS_WebsiteIcons", _IMSS_OperaDictionary)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Opera")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Website Icons")
            _IMSS_AddSetp(33)
        End If

        If Directory.Exists(IMSS_PATHS.OperaCacheTempDownloads) Then
            IMSS_FILES_SEARCHERS._IMSS_DirSearcher(IMSS_PATHS.OperaCacheTempDownloads, "*.*", "_IMSS_DownloadHistory", _IMSS_OperaDictionary)
            _IMSS_CheckingCategory_LabelInvoke("Checking category : Opera")
            _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Download History")
            _IMSS_AddSetp(34)
        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' IMSS OnComplete Sanning Files ''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        _IMSS_AddSetp(34)

        _IMSS_CheckingCategory_LabelInvoke("Checking category : Complete")
        _IMSS_CheckingCategoryTarget_LabelInvoke(" >> Prepering Items")

        If _IMSS_CheckInternetExplorer = True Then
            _IMSS_LoadInternetExplore()
        Else
            With _IMSS_SECTION_RESULT
                ._IMSS_InternetExplorer_CheckBox.Checked = False
                ._IMSS_InternetExplorer_CheckBox.Enabled = False
                ._IMSS_InternetExplorerCheckBox_Panel.Style.BackColor1.Color = Color.White
                ._IMSS_InternetExplorerCheckBox_Panel.Style.BackColor2.Color = Color.White
            End With
        End If


        If _IMSS_CheckSafari Then
            _IMSS_LoadSafari()
        Else
            With _IMSS_SECTION_RESULT
                ._IMSS_Safari_CheckBox.Checked = False
                ._IMSS_Safari_CheckBox.Enabled = False
                ._IMSS_SafariCheckBox_Panel.Style.BackColor1.Color = Color.White
                ._IMSS_SafariCheckBox_Panel.Style.BackColor2.Color = Color.White
            End With
        End If


        If _IMSS_CheckMozillaFirefox Then
            _IMSS_LoadMozillaFirefox()
        Else
            With _IMSS_SECTION_RESULT
                ._IMSS_MozillaFireFox_CheckBox.Checked = False
                ._IMSS_MozillaFireFox_CheckBox.Enabled = False
                ._IMSS_MozillaFireFoxCheckBox_Panel.Style.BackColor1.Color = Color.White
                ._IMSS_MozillaFireFoxCheckBox_Panel.Style.BackColor2.Color = Color.White
            End With
        End If

        If _IMSS_CheckGoogleChrome Then
            _IMSS_LoadChrome()
        Else
            With _IMSS_SECTION_RESULT
                ._IMSS_Chrome_CheckBox.Checked = False
                ._IMSS_Chrome_CheckBox.Enabled = False
                ._IMSS_ChromeCheckBox_Panel.Style.BackColor1.Color = Color.White
                ._IMSS_ChromeCheckBox_Panel.Style.BackColor2.Color = Color.White
            End With
        End If

        If _IMSS_CheckOpera Then
            _IMSS_LoadOpera()
        Else
            With _IMSS_SECTION_RESULT
                ._IMSS_Opera_CheckBox.Checked = False
                ._IMSS_Opera_CheckBox.Enabled = False
                ._IMSS_OperaCheckBox_Panel.Style.BackColor1.Color = Color.White
                ._IMSS_OperaCheckBox_Panel.Style.BackColor2.Color = Color.White
            End With
        End If
        _IMSS_ChangeLabelInvoke(_IMSS_TotalCleanUpPotentialOfElemints)
        _IMSS_ChangeLabelSizeInvoke(_IMSS_TotalCleanUpPotentialOfSize)
        Invoke(New _IMSS_OnCompleteDelegate(AddressOf _IMSS_OnComplete))
    End Sub
#Region "IMSS Load Items Uint"
    Private Sub _IMSS_LoadInternetExplore()
        Dim _IMSS_InternetExplorerCookies As Integer = 0
        Dim _IMSS_InternetExplorerCookiesSize As Long = 0

        Dim _IMSS_InternetExplorerCookies_DOM_Store As Integer = 0
        Dim _IMSS_InternetExplorerCookies_DOM_StoreSize As Long = 0

        Dim _IMSS_InternetExplorerTemporary_Interent_Files As Integer = 0
        Dim _IMSS_InternetExplorerTemporary_Interent_FilesSize As Long = 0

        Dim _IMSS_InternetExplorerHistory As Integer = 0
        Dim _IMSS_InternetExplorerHistorySize As Long = 0

        Dim _IMSS_ITEMS_LIST_RANGE As New List(Of BetterListViewItem)

        _IMSS_CheangeCheckBoxValue(_IMSS_SECTION_RESULT._IMSS_InternetExplorer_CheckBox, True)
        For Each _IMSS_Key In _IMSS_InternetExplorer
            Select Case _IMSS_Key.Value
                Case "_IMSS_CookiesInternetExplorer"
                    _IMSS_InternetExplorerCookies += 1
                    _IMSS_InternetExplorerCookiesSize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_Cookies_DOM_Store"
                    _IMSS_InternetExplorerCookies_DOM_Store += 1
                    _IMSS_InternetExplorerCookies_DOM_StoreSize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_Temporary_Interent_Files"
                    _IMSS_InternetExplorerTemporary_Interent_Files += 1
                    _IMSS_InternetExplorerTemporary_Interent_FilesSize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_HistoryInternetExplorer"
                    _IMSS_InternetExplorerHistory += 1
                    _IMSS_InternetExplorerHistorySize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case Else : Exit Select
            End Select
        Next _IMSS_Key
        If Not _IMSS_InternetExplorerCookies = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "Cookies"
                .Tag = "_IMSS_CookiesInternetExplorer|" & _IMSS_InternetExplorerCookiesSize
                .Checked = True
                .SubItems.Add(_IMSS_InternetExplorerCookies) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_InternetExplorerCookiesSize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_InternetExplorerCookiesSize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If
        If Not _IMSS_InternetExplorerCookies_DOM_Store = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "Cookies (DOM Store)"
                .Tag = "_IMSS_Cookies_DOM_Store|" & _IMSS_InternetExplorerCookies_DOM_StoreSize
                .Checked = True
                .SubItems.Add(_IMSS_InternetExplorerCookies_DOM_Store) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_InternetExplorerCookies_DOM_StoreSize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_InternetExplorerCookies_DOM_StoreSize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If
        If Not _IMSS_InternetExplorerTemporary_Interent_Files = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "Temporary Interent Files"
                .Tag = "_IMSS_Temporary_Interent_Files|" & _IMSS_InternetExplorerTemporary_Interent_FilesSize
                .Checked = True
                .SubItems.Add(_IMSS_InternetExplorerTemporary_Interent_Files) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_InternetExplorerTemporary_Interent_FilesSize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_InternetExplorerTemporary_Interent_FilesSize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If
        If Not _IMSS_InternetExplorerHistory = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "History"
                .Tag = "_IMSS_HistoryInternetExplorer|" & _IMSS_InternetExplorerHistorySize
                .Checked = True
                .SubItems.Add(_IMSS_InternetExplorerHistory) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_InternetExplorerHistorySize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_InternetExplorerHistorySize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If
        '--------- IMSS Full up lists
        If _IMSS_InternetExplorerCookies + _IMSS_InternetExplorerCookies_DOM_Store + _IMSS_InternetExplorerTemporary_Interent_Files + _IMSS_InternetExplorerHistory > 0 Then
            _IMSS_TotalCleanUpPotentialOfElemints += _IMSS_InternetExplorerCookies + _IMSS_InternetExplorerCookies_DOM_Store + _IMSS_InternetExplorerTemporary_Interent_Files + _IMSS_InternetExplorerHistory
            _IMSS_AddItemInvoke(_IMSS_SECTION_RESULT._IMSS_RESULT_LSTVIEW, _IMSS_ITEMS_LIST_RANGE, 0)
        End If
    End Sub
    Private Sub _IMSS_LoadSafari()
        Dim _IMSS_SafariCache As Integer = 0
        Dim _IMSS_SafariCookiesCacheSize As Long = 0

        Dim _IMSS_SafariHistorye As Integer = 0
        Dim _IMSS_SafariHistorySize As Long = 0

        Dim _IMSS_SafariWebpagePreviews As Integer = 0
        Dim _IMSS_SafariWebpagePreviewsSize As Long = 0

        Dim _IMSS_SafariDownloadHistoryy As Integer = 0
        Dim _IMSS_SafariDownloadHistorySize As Long = 0

        Dim _IMSS_SafariLastSession As Integer = 0
        Dim _IMSS_SafariLastSessionSize As Long = 0

        _IMSS_CheangeCheckBoxValue(_IMSS_SECTION_RESULT._IMSS_Safari_CheckBox, True)
        For Each _IMSS_Key In _IMSS_SafariDictionary
            Select Case _IMSS_Key.Value
                Case "_IMSS_Cache"
                    _IMSS_SafariCache += 1
                    _IMSS_SafariCookiesCacheSize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_History"
                    _IMSS_SafariHistorye += 1
                    _IMSS_SafariHistorySize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_WebpagePreviews"
                    _IMSS_SafariWebpagePreviews += 1
                    _IMSS_SafariWebpagePreviewsSize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_DownloadHistory"
                    _IMSS_SafariDownloadHistoryy += 1
                    _IMSS_SafariDownloadHistorySize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_LastSession"
                    _IMSS_SafariLastSession += 1
                    _IMSS_SafariLastSessionSize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case Else : Exit Select
            End Select
        Next _IMSS_Key
        Dim _IMSS_ITEMS_LIST_RANGE As New List(Of BetterListViewItem)
        If Not _IMSS_SafariCache = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "Cache"
                .Tag = "_IMSS_Cache|" & _IMSS_SafariCookiesCacheSize
                .Checked = True
                .SubItems.Add(_IMSS_SafariCache) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_SafariCookiesCacheSize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_SafariCookiesCacheSize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If
        If Not _IMSS_SafariHistorye = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "History"
                .Tag = "_IMSS_History|" & _IMSS_SafariHistorySize
                .Checked = True
                .SubItems.Add(_IMSS_SafariHistorye) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_SafariHistorySize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_SafariHistorySize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If
        If Not _IMSS_SafariWebpagePreviews = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "Webpage Previews"
                .Tag = "_IMSS_WebpagePreviews|" & _IMSS_SafariWebpagePreviewsSize
                .Checked = True
                .SubItems.Add(_IMSS_SafariWebpagePreviews) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_SafariWebpagePreviewsSize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_SafariWebpagePreviewsSize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If
        If Not _IMSS_SafariDownloadHistoryy = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "Download History"
                .Tag = "_IMSS_DownloadHistory|" & _IMSS_SafariDownloadHistorySize
                .Checked = True
                .SubItems.Add(_IMSS_SafariDownloadHistoryy) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_SafariDownloadHistorySize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_SafariDownloadHistorySize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If
        If Not _IMSS_SafariLastSession = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "Last Session"
                .Tag = "_IMSS_LastSession|" & _IMSS_SafariLastSessionSize
                .Checked = True
                .SubItems.Add(_IMSS_SafariLastSession) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_SafariLastSessionSize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_SafariLastSessionSize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If
        '--------- IMSS Full up lists
        If _IMSS_SafariCache + _IMSS_SafariHistorye + _IMSS_SafariWebpagePreviews + _IMSS_SafariDownloadHistoryy + _IMSS_SafariLastSession > 0 Then
            _IMSS_TotalCleanUpPotentialOfElemints += _IMSS_SafariCache + _IMSS_SafariHistorye + _IMSS_SafariWebpagePreviews + _IMSS_SafariDownloadHistoryy + _IMSS_SafariLastSession
            _IMSS_AddItemInvoke(_IMSS_SECTION_RESULT._IMSS_RESULT_LSTVIEW, _IMSS_ITEMS_LIST_RANGE, 4)
        End If
    End Sub
    Private Sub _IMSS_LoadChrome()
        Dim _IMSS_GoogleChromeCookiesLS As Integer = 0
        Dim _IMSS_GoogleChromeCookiesLSSize As Long = 0

        Dim _IMSS_GoogleChromeCookiesDB As Integer = 0
        Dim _IMSS_GoogleChromeCookiesDBSize As Long = 0

        Dim _IMSS_GoogleChromeCookies As Integer = 0
        Dim _IMSS_GoogleChromeCookiesSize As Long = 0

        Dim _IMSS_GoogleChromeCache As Integer = 0
        Dim _IMSS_GoogleChromeCacheSize As Long = 0

        Dim _IMSS_GoogleChromeInternetHistory As Integer = 0
        Dim _IMSS_GoogleChromeInternetHistorySize As Long = 0

        _IMSS_CheangeCheckBoxValue(_IMSS_SECTION_RESULT._IMSS_Chrome_CheckBox, True)

        For Each _IMSS_Key In _IMSS_GoogleChromeDictionary
            Select Case _IMSS_Key.Value
                Case "_IMSS_CookiesLS"
                    _IMSS_GoogleChromeCookiesLS += 1
                    _IMSS_GoogleChromeCookiesLSSize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_CookiesDB"
                    _IMSS_GoogleChromeCookiesDB += 1
                    _IMSS_GoogleChromeCookiesDBSize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_Cookies"
                    _IMSS_GoogleChromeCookies += 1
                    _IMSS_GoogleChromeCookiesSize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_Cache"
                    _IMSS_GoogleChromeCache += 1
                    _IMSS_GoogleChromeCacheSize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_InternetHistory"
                    _IMSS_GoogleChromeInternetHistory += 1
                    _IMSS_GoogleChromeInternetHistorySize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case Else : Exit Select
            End Select
        Next _IMSS_Key
        Dim _IMSS_ITEMS_LIST_RANGE As New List(Of BetterListViewItem)
        If Not _IMSS_GoogleChromeCookiesLS = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "Cookies (Local Storage)"
                .Tag = "_IMSS_CookiesLS|" & _IMSS_GoogleChromeCookiesLSSize
                .Checked = True
                .SubItems.Add(_IMSS_GoogleChromeCookiesLS) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_GoogleChromeCookiesLSSize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_GoogleChromeCookiesLSSize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If
        If Not _IMSS_GoogleChromeCookiesDB = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "Cookies (DB)"
                .Tag = "_IMSS_CookiesDB|" & _IMSS_GoogleChromeCookiesDBSize
                .Checked = True
                .SubItems.Add(_IMSS_GoogleChromeCookiesDB) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_GoogleChromeCookiesDBSize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_GoogleChromeCookiesDBSize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If
        If Not _IMSS_GoogleChromeCookies = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "Cookies"
                .Tag = "_IMSS_Cookies|" & _IMSS_GoogleChromeCookiesSize
                .Checked = True
                .SubItems.Add(_IMSS_GoogleChromeCookies) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_GoogleChromeCookiesSize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_GoogleChromeCookiesSize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If
        If Not _IMSS_GoogleChromeCache = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "Cache"
                .Tag = "_IMSS_Cache|" & _IMSS_GoogleChromeCacheSize
                .Checked = True
                .SubItems.Add(_IMSS_GoogleChromeCache) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_GoogleChromeCacheSize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_GoogleChromeCacheSize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If
        If Not _IMSS_GoogleChromeInternetHistory = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "Internet History"
                .Tag = "_IMSS_InternetHistory|" & _IMSS_GoogleChromeInternetHistorySize
                .Checked = True
                .SubItems.Add(_IMSS_GoogleChromeInternetHistory) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_GoogleChromeInternetHistorySize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_GoogleChromeInternetHistorySize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If
        '--------- IMSS Full up lists
        If _IMSS_GoogleChromeCookiesLS + _IMSS_GoogleChromeCookiesDB + _IMSS_GoogleChromeCookies + _IMSS_GoogleChromeCache + _IMSS_GoogleChromeInternetHistory > 0 Then
            _IMSS_TotalCleanUpPotentialOfElemints += _IMSS_GoogleChromeCookiesLS + _IMSS_GoogleChromeCookiesDB + _IMSS_GoogleChromeCookies + _IMSS_GoogleChromeCache + _IMSS_GoogleChromeInternetHistory
            _IMSS_AddItemInvoke(_IMSS_SECTION_RESULT._IMSS_RESULT_LSTVIEW, _IMSS_ITEMS_LIST_RANGE, 1)
        End If
    End Sub
    Private Sub _IMSS_LoadMozillaFirefox()
        Dim _IMSS_MozillaFirefoxCookies As Integer = 0
        Dim _IMSS_MozillaFirefoxCookiesSize As Long = 0

        Dim _IMSS_MozillaFirefoxCookiesWebAppsStore As Integer = 0
        Dim _IMSS_MozillaFirefoxCookiesWebAppsStoreSize As Long = 0

        Dim _IMSS_MozillaFirefoxDownloadHistory As Integer = 0
        Dim _IMSS_MozillaFirefoxDownloadHistorySize As Long = 0

        Dim _IMSS_MozillaFirefoxFormHistory As Integer = 0
        Dim _IMSS_MozillaFirefoxFormHistorySize As Long = 0

        Dim _IMSS_MozillaFirefoxHistory As Integer = 0
        Dim _IMSS_MozillaFirefoxHistorySize As Long = 0 ' 

        Dim _IMSS_MozillaFirefoxSessionStoreBackup As Integer = 0
        Dim _IMSS_MozillaFirefoxSessionStoreBackupSize As Long = 0

        _IMSS_CheangeCheckBoxValue(_IMSS_SECTION_RESULT._IMSS_MozillaFireFox_CheckBox, True)

        For Each _IMSS_Key In _IMSS_MozillaFirefoxDictionary
            Select Case _IMSS_Key.Value
                Case "_IMSS_Cookies"
                    _IMSS_MozillaFirefoxCookies += 1
                    _IMSS_MozillaFirefoxCookiesSize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_CookiesWebAppsStore"
                    _IMSS_MozillaFirefoxCookiesWebAppsStore += 1
                    _IMSS_MozillaFirefoxCookiesWebAppsStoreSize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_DownloadHistory"
                    _IMSS_MozillaFirefoxDownloadHistory += 1
                    _IMSS_MozillaFirefoxDownloadHistorySize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_FormHistory"
                    _IMSS_MozillaFirefoxFormHistory += 1
                    _IMSS_MozillaFirefoxFormHistorySize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_History"
                    _IMSS_MozillaFirefoxHistory += 1
                    _IMSS_MozillaFirefoxHistorySize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_SessionStoreBackup"
                    _IMSS_MozillaFirefoxSessionStoreBackup += 1
                    _IMSS_MozillaFirefoxSessionStoreBackupSize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case Else : Exit Select
            End Select
        Next _IMSS_Key
        Dim _IMSS_ITEMS_LIST_RANGE As New List(Of BetterListViewItem)
        If Not _IMSS_MozillaFirefoxCookies = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "Cookies"
                .Tag = "_IMSS_Cookies|" & _IMSS_MozillaFirefoxCookiesSize
                .Checked = True
                .SubItems.Add(_IMSS_MozillaFirefoxCookies) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_MozillaFirefoxCookiesSize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_MozillaFirefoxCookiesSize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If
        If Not _IMSS_MozillaFirefoxCookiesWebAppsStore = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "Cookies (Web Apps Store)"
                .Tag = "_IMSS_CookiesWebAppsStore|" & _IMSS_MozillaFirefoxCookiesWebAppsStoreSize
                .Checked = True
                .SubItems.Add(_IMSS_MozillaFirefoxCookiesWebAppsStore) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_MozillaFirefoxCookiesWebAppsStoreSize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_MozillaFirefoxCookiesWebAppsStoreSize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If
        If Not _IMSS_MozillaFirefoxDownloadHistory = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "Download History"
                .Tag = "_IMSS_DownloadHistory|" & _IMSS_MozillaFirefoxDownloadHistorySize
                .Checked = True
                .SubItems.Add(_IMSS_MozillaFirefoxDownloadHistory) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_MozillaFirefoxDownloadHistorySize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_MozillaFirefoxDownloadHistorySize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If
        If Not _IMSS_MozillaFirefoxFormHistory = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "Form History"
                .Tag = "_IMSS_FormHistory|" & _IMSS_MozillaFirefoxFormHistorySize
                .Checked = True
                .SubItems.Add(_IMSS_MozillaFirefoxFormHistory) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_MozillaFirefoxFormHistorySize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_MozillaFirefoxFormHistorySize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If
        If Not _IMSS_MozillaFirefoxHistory = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "History"
                .Tag = "_IMSS_History|" & _IMSS_MozillaFirefoxHistorySize
                .Checked = True
                .SubItems.Add(_IMSS_MozillaFirefoxHistory) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_MozillaFirefoxHistorySize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_MozillaFirefoxHistorySize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If

        If Not _IMSS_MozillaFirefoxHistory = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "Session Store (Backup)"
                .Tag = "_IMSS_SessionStoreBackup|" & _IMSS_MozillaFirefoxSessionStoreBackupSize
                .Checked = True
                .SubItems.Add(_IMSS_MozillaFirefoxSessionStoreBackup) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_MozillaFirefoxSessionStoreBackupSize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_MozillaFirefoxSessionStoreBackupSize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If

        '--------- IMSS Full up lists
        If _IMSS_MozillaFirefoxCookies + _IMSS_MozillaFirefoxCookiesWebAppsStore + _IMSS_MozillaFirefoxDownloadHistory + _IMSS_MozillaFirefoxFormHistory + _IMSS_MozillaFirefoxHistory _
            + _IMSS_MozillaFirefoxSessionStoreBackup > 0 Then
            _IMSS_TotalCleanUpPotentialOfElemints += _IMSS_MozillaFirefoxCookies + _IMSS_MozillaFirefoxCookiesWebAppsStore + _IMSS_MozillaFirefoxDownloadHistory + _IMSS_MozillaFirefoxFormHistory + _IMSS_MozillaFirefoxHistory + _IMSS_MozillaFirefoxSessionStoreBackup
            _IMSS_AddItemInvoke(_IMSS_SECTION_RESULT._IMSS_RESULT_LSTVIEW, _IMSS_ITEMS_LIST_RANGE, 2)
        End If
    End Sub
    Private Sub _IMSS_LoadOpera()
        Dim _IMSS_OperaCache As Integer = 0
        Dim _IMSS_OperaCacheSize As Long = 0

        Dim _IMSS_OperaCacheOP As Integer = 0
        Dim _IMSS_OperaCacheOPSize As Long = 0

        Dim _IMSS_OperaCacheIcons As Integer = 0
        Dim _IMSS_OperaCacheIconsSize As Long = 0

        Dim _IMSS_OperaInternetHistory As Integer = 0
        Dim _IMSS_OperaInternetHistorySize As Long = 0

        Dim _IMSS_OperaCookies As Integer = 0
        Dim _IMSS_OperaCookiesSize As Long = 0 ' 

        Dim _IMSS_OperaWebsiteIcons As Integer = 0
        Dim _IMSS_OperaWebsiteIconsSize As Long = 0

        Dim _IMSS_OperaDownloadHistory As Integer = 0
        Dim _IMSS_OperaDownloadHistorySize As Long = 0

        _IMSS_CheangeCheckBoxValue(_IMSS_SECTION_RESULT._IMSS_Opera_CheckBox, True)

        For Each _IMSS_Key In _IMSS_OperaDictionary
            Select Case _IMSS_Key.Value
                Case "_IMSS_CacheOperaDictionary"
                    _IMSS_OperaCache += 1
                    _IMSS_OperaCacheSize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_CacheOP"
                    _IMSS_OperaCacheOP += 1
                    _IMSS_OperaCacheOPSize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_CacheIcons"
                    _IMSS_OperaCacheIcons += 1
                    _IMSS_OperaCacheIconsSize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_InternetHistory_1"
                    _IMSS_OperaInternetHistory += 1
                    _IMSS_OperaInternetHistorySize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_InternetHistory_2"
                    _IMSS_OperaInternetHistory += 1
                    _IMSS_OperaInternetHistorySize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_InternetHistory_3"
                    _IMSS_OperaInternetHistory += 1
                    _IMSS_OperaInternetHistorySize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_InternetHistory_4"
                    _IMSS_OperaInternetHistory += 1
                    _IMSS_OperaInternetHistorySize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_InternetHistory_5"
                    _IMSS_OperaInternetHistory += 1
                    _IMSS_OperaInternetHistorySize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_InternetHistory_6"
                    _IMSS_OperaInternetHistory += 1
                    _IMSS_OperaInternetHistorySize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_CookiesOperaDictionary"
                    _IMSS_OperaCookies += 1
                    _IMSS_OperaCookiesSize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_WebsiteIcons"
                    _IMSS_OperaWebsiteIcons += 1
                    _IMSS_OperaWebsiteIconsSize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case "_IMSS_DownloadHistory"
                    _IMSS_OperaDownloadHistory += 1
                    _IMSS_OperaDownloadHistorySize += _IMSS_FILESIZE(_IMSS_Key.Key) : Exit Select
                Case Else : Exit Select
            End Select
        Next _IMSS_Key
        Dim _IMSS_ITEMS_LIST_RANGE As New List(Of BetterListViewItem)
        If Not _IMSS_OperaCache = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "Cache"
                .Tag = "_IMSS_CacheOperaDictionary|" & _IMSS_OperaCacheSize
                .Checked = True
                .SubItems.Add(_IMSS_OperaCache) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_OperaCacheSize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_OperaCacheSize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If
        If Not _IMSS_OperaCacheOP = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "Cache (OP)"
                .Tag = "_IMSS_CacheOP|" & _IMSS_OperaCacheOPSize
                .Checked = True
                .SubItems.Add(_IMSS_OperaCacheOP) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_OperaCacheOPSize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_OperaCacheOPSize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If
        If Not _IMSS_OperaCacheIcons = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "Cache (Icons)"
                .Tag = "_IMSS_CacheIcons|" & _IMSS_OperaCacheIconsSize
                .Checked = True
                .SubItems.Add(_IMSS_OperaCacheIcons) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_OperaCacheIconsSize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_OperaCacheIconsSize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If
        If Not _IMSS_OperaInternetHistory = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "Internet History"
                .Tag = "_IMSS_InternetHistory|" & _IMSS_OperaInternetHistorySize
                .Checked = True
                .SubItems.Add(_IMSS_OperaInternetHistory) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_OperaInternetHistorySize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_OperaInternetHistorySize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If
        If Not _IMSS_OperaCookies = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "Cookies"
                .Tag = "_IMSS_CookiesOperaDictionary|" & _IMSS_OperaCookiesSize
                .Checked = True
                .SubItems.Add(_IMSS_OperaCookies) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_OperaCookiesSize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_OperaCookiesSize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If
        If Not _IMSS_OperaWebsiteIcons = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "Website Icons"
                .Tag = "_IMSS_WebsiteIcons|" & _IMSS_OperaWebsiteIconsSize
                .Checked = True
                .SubItems.Add(_IMSS_OperaWebsiteIcons) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_OperaWebsiteIconsSize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_OperaWebsiteIconsSize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If
        If Not _IMSS_OperaDownloadHistory = 0 Then
            Dim _IMSS_TempItems As New BetterListViewItem()
            With _IMSS_TempItems
                .Text = "Download History"
                .Tag = "_IMSS_DownloadHistory|" & _IMSS_OperaDownloadHistorySize
                .Checked = True
                .SubItems.Add(_IMSS_OperaDownloadHistory) : _IMSS_TotalCleanUpPotentialOfSize += _IMSS_OperaDownloadHistorySize
                .SubItems.Add(_IMSS_ByteToMegaByte(_IMSS_OperaDownloadHistorySize))
            End With : _IMSS_ITEMS_LIST_RANGE.Add(_IMSS_TempItems) : _IMSS_TempItems.Dispose()
        End If

        '--------- IMSS Full up lists
        If _IMSS_OperaCache + _IMSS_OperaCacheOP + _IMSS_OperaCacheIcons + _IMSS_OperaInternetHistory + _IMSS_OperaCookies _
            + _IMSS_OperaWebsiteIcons + _IMSS_OperaDownloadHistory > 0 Then
            _IMSS_TotalCleanUpPotentialOfElemints += _IMSS_OperaCache + _IMSS_OperaCacheOP + _IMSS_OperaCacheIcons + _IMSS_OperaInternetHistory + _IMSS_OperaCookies + _IMSS_OperaWebsiteIcons + _IMSS_OperaDownloadHistory
            _IMSS_AddItemInvoke(_IMSS_SECTION_RESULT._IMSS_RESULT_LSTVIEW, _IMSS_ITEMS_LIST_RANGE, 3)
        End If
    End Sub
#End Region

#Region "IMSS OPER FUNCTIONS UINT"
    Private Function _IMSS_FILESIZE(ByRef _IMSS_TARGET As String) As Long
        If IO.File.Exists(_IMSS_TARGET) Then Return New FileInfo(_IMSS_TARGET).Length Else Return 0
    End Function
    Private Shared Function checkIfValueIsDecimal(ByVal value As String) As String
        Dim result As String
        If value.Contains(",") Then : result = CDbl(value).ToString("###.##")
        Else : result = CDbl(value).ToString("###.00") : End If
        Return result
    End Function

    Public Shared Function _IMSS_ByteToMegaByte(ByVal ObjectSize As String) As String
        Dim oneByte As Integer = 1
        Dim kiloByte As Integer = 1024
        Dim megaByte As Integer = 1048576
        Dim gigaByte As Integer = 1073741824
        Dim terraByte As Long = 1099511627776
        Dim pettaByte As Long = 1125899906842624

        Select Case CLng(ObjectSize)
            Case 0 To kiloByte - 1
                If (CDbl(checkIfValueIsDecimal(CStr(CDec(ObjectSize) / oneByte))) >= 1000) = False Then
                    ObjectSize = CStr(CInt(ObjectSize) / 1) + " Bytes"
                Else : ObjectSize = "1,00 KB" : End If

            Case kiloByte To megaByte - 1
                If (CDbl(checkIfValueIsDecimal(CStr(CDec(ObjectSize) / kiloByte))) >= 1000) = False Then
                    ObjectSize = checkIfValueIsDecimal(CStr(CDec(ObjectSize) / kiloByte)) + " KB"
                Else : ObjectSize = "1,00 MB" : End If

            Case megaByte To gigaByte - 1
                If (CDbl(checkIfValueIsDecimal(CStr(CDec(ObjectSize) / megaByte))) >= 1000) = False Then
                    ObjectSize = checkIfValueIsDecimal(CStr(CDec(ObjectSize) / megaByte)) + " MB"
                Else : ObjectSize = "1,00 GB" : End If

            Case gigaByte To terraByte - 1
                If (CDbl(checkIfValueIsDecimal(CStr(CDec(ObjectSize) / gigaByte))) >= 1000) = False Then
                    ObjectSize = checkIfValueIsDecimal(CStr(CDec(ObjectSize) / gigaByte)) + " GB"
                Else : ObjectSize = "1,00 TB" : End If

            Case terraByte To pettaByte - 1
                If (CDbl(checkIfValueIsDecimal(CStr(CDec(ObjectSize) / terraByte))) >= 1000) = False Then
                    ObjectSize = checkIfValueIsDecimal(CStr(CDec(ObjectSize) / terraByte)) + " TB"
                Else : ObjectSize = "1,00 PB" : End If
        End Select
        Return ObjectSize
    End Function
#End Region

#Region "IMSS LISTS INVOKE OPER"
    Private Delegate Sub _IMSS_CheangeCheckBoxValueDelegate(ByRef _IMSS_CHECKBOX As CheckBoxX, ByVal _IMSS_VALUE As Boolean)
    Private Sub _IMSS_CheangeCheckBoxValue(ByRef _IMSS_CHECKBOX As CheckBoxX, ByVal _IMSS_VALUE As Boolean)
        If _IMSS_CHECKBOX.InvokeRequired = True Then
            Invoke(New _IMSS_CheangeCheckBoxValueDelegate(AddressOf _IMSS_CheangeCheckBoxValue), _IMSS_CHECKBOX, _IMSS_VALUE)
        Else
            _IMSS_CHECKBOX.Checked = _IMSS_VALUE
        End If
    End Sub
    Private Delegate Sub _IMSS_AddItemInvokeDelegate(ByRef _IMSS_TARGET_LIST As BetterListView, ByRef _IMSS_VALUSE As List(Of BetterListViewItem), ByVal _IMSS_TARGETGROUP As Integer)
    Private Sub _IMSS_AddItemInvoke(ByRef _IMSS_TARGET_LIST As BetterListView, ByRef _IMSS_VALUSE As List(Of BetterListViewItem), ByVal _IMSS_TARGETGROUP As Integer)
        If _IMSS_SECTION_RESULT._IMSS_RESULT_LSTVIEW.InvokeRequired = True Then
            Invoke(New _IMSS_AddItemInvokeDelegate(AddressOf _IMSS_AddItemInvoke), _IMSS_TARGET_LIST, _IMSS_VALUSE, _IMSS_TARGETGROUP)
        Else
            _IMSS_TARGET_LIST.Groups(_IMSS_TARGETGROUP).Items.AddRange(_IMSS_VALUSE) : _IMSS_VALUSE.Clear()
        End If
    End Sub
    Private Delegate Sub _IMSS_ChangeLabelInvokeDelegate(ByVal _IMSS_VALUE As Long)
    Private Sub _IMSS_ChangeLabelInvoke(ByVal _IMSS_VALUE As Long)
        If _IMSS_SECTION_RESULT._IMSS_TotalItems_Label.InvokeRequired = True Then
            Invoke(New _IMSS_ChangeLabelInvokeDelegate(AddressOf _IMSS_ChangeLabelInvoke), _IMSS_VALUE)
        Else
            _IMSS_SECTION_RESULT._IMSS_TotalItems_Label.Text = CType(_IMSS_VALUE, String) - 1 & " - Item"
            _IMSS_SECTION_RESULT._IMSS_ItemToDeleteTotalNumber_Label.Text = CType(_IMSS_VALUE, String) - 1 & " - Item"
        End If
    End Sub
    Private Delegate Sub _IMSS_ChangeLabelSizeInvokeDelegate(ByVal _IMSS_VALUE As Long)
    Private Sub _IMSS_ChangeLabelSizeInvoke(ByVal _IMSS_VALUE As Long)
        If _IMSS_SECTION_RESULT._IMSS_TotalItems_Label.InvokeRequired = True Then
            Invoke(New _IMSS_ChangeLabelSizeInvokeDelegate(AddressOf _IMSS_ChangeLabelSizeInvoke), _IMSS_VALUE)
        Else
            _IMSS_SECTION_RESULT._IMSS_FullSize_Label.Text = _IMSS_ByteToMegaByte(_IMSS_VALUE)
            _IMSS_SECTION_RESULT._IMSS_TotaleSelectedItemsSizeToDelete_Label.Text = _IMSS_ByteToMegaByte(_IMSS_VALUE)
            _IMSS_SECTION_RESULT._IMSS_TotaleSelectedItemsSizeToDelete_Label.Tag = _IMSS_VALUE
        End If
    End Sub
#End Region

    Private Delegate Sub _IMSS_OnCompleteDelegate()
    Private Sub _IMSS_OnComplete()
        With MainWindow._IMSS_MainPanel.Controls
            .Clear()
            _IMSS_SECTION_RESULT.Visible = True
            _IMSS_SECTION_RESULT.Dock = DockStyle.Fill
            _IMSS_SECTION_RESULT.BringToFront()
            If Not _IMSS_SECTION_RESULT._IMSS_RESULT_LSTVIEW.Items.Count() = 0 Then
                _IMSS_SECTION_RESULT._IMSS_Clean_Button.Enabled = True
                _IMSS_SECTION_RESULT._IMSS_RESULT_LABEL.Visible = False
            Else
                _IMSS_SECTION_RESULT._IMSS_Clean_Button.Enabled = False
                _IMSS_SECTION_RESULT._IMSS_RESULT_LABEL.Visible = True
            End If
            .Add(_IMSS_SECTION_RESULT)
        End With
    End Sub

End Class
