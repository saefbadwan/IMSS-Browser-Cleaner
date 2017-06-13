Module IMSS_PUBLIc_FUNC
    '------------------------------Internet Explorer------------------------------
    Public _IMSS_InternetExplorer As New Dictionary(Of String, String)
    Public _IMSS_InternetExplorerRegistryPath As New List(Of String)
    '------------------------------Google Chrome----------------------------------
    Public _IMSS_GoogleChromeDictionary As New Dictionary(Of String, String)
    '------------------------------Mozilla Firefox--------------------------------
    Public _IMSS_MozillaFirefoxDictionary As New Dictionary(Of String, String)
    '------------------------------Safari-----------------------------------------
    Public _IMSS_SafariDictionary As New Dictionary(Of String, String)
    '------------------------------Opera------------------------------------------
    Public _IMSS_OperaDictionary As New Dictionary(Of String, String)
    Public _IMSS_Int As Long = 0
    Public _IMSS_SizeInt As Long = 0
    Public _IMSS_SELECTED_ITEMS As New List(Of String)
    Public _IMSS_SELECTED_ITEMS_ONERROR As New List(Of String)
End Module
