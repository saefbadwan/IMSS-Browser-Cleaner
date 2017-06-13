Public Class MainWindow
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _IMSS_SETUP_MAIN_START()
    End Sub
    Private Sub _IMSS_SETUP_MAIN_START()
        Dim _IMSS_SECTION_MAIN As New IMSS_SECTION_MAIN
        _IMSS_SECTION_MAIN.Visible = True
        _IMSS_SECTION_MAIN.Dock = DockStyle.Fill
        _IMSS_MainPanel.Controls.Add(_IMSS_SECTION_MAIN)
        Me.AcceptButton = _IMSS_SECTION_MAIN._IMSS_Cancel
    End Sub

End Class
