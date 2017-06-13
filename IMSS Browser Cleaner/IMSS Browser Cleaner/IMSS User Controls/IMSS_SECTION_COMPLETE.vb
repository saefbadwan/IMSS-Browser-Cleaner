Public Class IMSS_SECTION_COMPLETE
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub _IMSS_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Close.Click
        Application.Exit()
    End Sub

    Private Sub _IMSS_RestartNow_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_RestartNow_Button.Click
        Shell("shutdown -r", AppWinStyle.Hide)
        Application.Exit()
    End Sub
End Class
