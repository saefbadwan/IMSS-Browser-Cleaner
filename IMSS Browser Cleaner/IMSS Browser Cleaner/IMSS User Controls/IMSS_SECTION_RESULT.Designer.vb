<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_SECTION_RESULT
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me._IMSS_SCTIONRESULT_TITLE_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_CheckingCategory_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_ChromeCheckBox_Panel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_Chrome_CheckBox = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me._IMSS_OperaCheckBox_Panel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_Opera_CheckBox = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me._IMSS_MozillaFireFoxCheckBox_Panel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_MozillaFireFox_CheckBox = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me._IMSS_InternetExplorerCheckBox_Panel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_InternetExplorer_CheckBox = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me._IMSS_SafariCheckBox_Panel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_Safari_CheckBox = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me._IMSS_RESULT_LSTVIEW = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_Category = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Elements = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_EstimatedSize = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_MicrosoftInternetExplorer = New ComponentOwl.BetterListView.BetterListViewGroup()
        Me._IMSS_GoogleChrome = New ComponentOwl.BetterListView.BetterListViewGroup()
        Me._IMSS_MozillaFirefox = New ComponentOwl.BetterListView.BetterListViewGroup()
        Me._IMSS_Opera = New ComponentOwl.BetterListView.BetterListViewGroup()
        Me._IMSS_Safari = New ComponentOwl.BetterListView.BetterListViewGroup()
        Me._IMSS_CommandPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_ViewItems_Button = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_Clean_Button = New System.Windows.Forms.Button()
        Me._IMSS_Close = New System.Windows.Forms.Button()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_RESULT_LABEL = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_OutPutPanels_Labels = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_TotaleSelectedItemsSizeToDelete_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_ItemToDeleteTotalNumber_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_FullSize_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_TotalItems_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_TotalCleanUpPotential_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_SelectedForCleanUp_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_ChromeCheckBox_Panel.SuspendLayout()
        Me._IMSS_OperaCheckBox_Panel.SuspendLayout()
        Me._IMSS_MozillaFireFoxCheckBox_Panel.SuspendLayout()
        Me._IMSS_InternetExplorerCheckBox_Panel.SuspendLayout()
        Me._IMSS_SafariCheckBox_Panel.SuspendLayout()
        CType(Me._IMSS_RESULT_LSTVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_CommandPanel.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me._IMSS_OutPutPanels_Labels.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.SuspendLayout()
        '
        '_IMSS_SCTIONRESULT_TITLE_Label
        '
        Me._IMSS_SCTIONRESULT_TITLE_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_SCTIONRESULT_TITLE_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_SCTIONRESULT_TITLE_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_SCTIONRESULT_TITLE_Label.Location = New System.Drawing.Point(14, 12)
        Me._IMSS_SCTIONRESULT_TITLE_Label.Name = "_IMSS_SCTIONRESULT_TITLE_Label"
        Me._IMSS_SCTIONRESULT_TITLE_Label.Size = New System.Drawing.Size(476, 21)
        Me._IMSS_SCTIONRESULT_TITLE_Label.TabIndex = 3
        Me._IMSS_SCTIONRESULT_TITLE_Label.Text = "Select the items to be deleted for the current clean up process"
        '
        '_IMSS_CheckingCategory_Label
        '
        Me._IMSS_CheckingCategory_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_CheckingCategory_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_CheckingCategory_Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._IMSS_CheckingCategory_Label.Location = New System.Drawing.Point(14, 44)
        Me._IMSS_CheckingCategory_Label.Name = "_IMSS_CheckingCategory_Label"
        Me._IMSS_CheckingCategory_Label.Size = New System.Drawing.Size(52, 15)
        Me._IMSS_CheckingCategory_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_CheckingCategory_Label.TabIndex = 7
        Me._IMSS_CheckingCategory_Label.Tag = ""
        Me._IMSS_CheckingCategory_Label.Text = "Browsers :"
        '
        '_IMSS_ChromeCheckBox_Panel
        '
        Me._IMSS_ChromeCheckBox_Panel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_ChromeCheckBox_Panel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_ChromeCheckBox_Panel.Controls.Add(Me._IMSS_Chrome_CheckBox)
        Me._IMSS_ChromeCheckBox_Panel.Location = New System.Drawing.Point(72, 38)
        Me._IMSS_ChromeCheckBox_Panel.Name = "_IMSS_ChromeCheckBox_Panel"
        Me._IMSS_ChromeCheckBox_Panel.Size = New System.Drawing.Size(52, 29)
        Me._IMSS_ChromeCheckBox_Panel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_ChromeCheckBox_Panel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_ChromeCheckBox_Panel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._IMSS_ChromeCheckBox_Panel.Style.BackgroundImage = Global.IMSS_Browser_Cleaner.My.Resources.Resources._IMSS_Chrome_Icon_16x24
        Me._IMSS_ChromeCheckBox_Panel.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.CenterLeft
        Me._IMSS_ChromeCheckBox_Panel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_ChromeCheckBox_Panel.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(200, Byte), Integer))
        Me._IMSS_ChromeCheckBox_Panel.Style.BorderWidth = 0
        Me._IMSS_ChromeCheckBox_Panel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me._IMSS_ChromeCheckBox_Panel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_ChromeCheckBox_Panel.Style.GradientAngle = 90
        Me._IMSS_ChromeCheckBox_Panel.TabIndex = 8
        '
        '_IMSS_Chrome_CheckBox
        '
        '
        '
        '
        Me._IMSS_Chrome_CheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Chrome_CheckBox.Location = New System.Drawing.Point(29, 5)
        Me._IMSS_Chrome_CheckBox.Name = "_IMSS_Chrome_CheckBox"
        Me._IMSS_Chrome_CheckBox.Size = New System.Drawing.Size(20, 19)
        Me._IMSS_Chrome_CheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Chrome_CheckBox.TabIndex = 9
        Me._IMSS_Chrome_CheckBox.Text = "CheckBoxX1"
        '
        '_IMSS_OperaCheckBox_Panel
        '
        Me._IMSS_OperaCheckBox_Panel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_OperaCheckBox_Panel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_OperaCheckBox_Panel.Controls.Add(Me._IMSS_Opera_CheckBox)
        Me._IMSS_OperaCheckBox_Panel.Location = New System.Drawing.Point(240, 38)
        Me._IMSS_OperaCheckBox_Panel.Name = "_IMSS_OperaCheckBox_Panel"
        Me._IMSS_OperaCheckBox_Panel.Size = New System.Drawing.Size(52, 29)
        Me._IMSS_OperaCheckBox_Panel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_OperaCheckBox_Panel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_OperaCheckBox_Panel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._IMSS_OperaCheckBox_Panel.Style.BackgroundImage = Global.IMSS_Browser_Cleaner.My.Resources.Resources._IMSS_Opera_Icon_16x24
        Me._IMSS_OperaCheckBox_Panel.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.CenterLeft
        Me._IMSS_OperaCheckBox_Panel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_OperaCheckBox_Panel.Style.BorderColor.Color = System.Drawing.Color.Silver
        Me._IMSS_OperaCheckBox_Panel.Style.BorderWidth = 0
        Me._IMSS_OperaCheckBox_Panel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me._IMSS_OperaCheckBox_Panel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_OperaCheckBox_Panel.Style.GradientAngle = 90
        Me._IMSS_OperaCheckBox_Panel.TabIndex = 9
        '
        '_IMSS_Opera_CheckBox
        '
        '
        '
        '
        Me._IMSS_Opera_CheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Opera_CheckBox.Location = New System.Drawing.Point(29, 5)
        Me._IMSS_Opera_CheckBox.Name = "_IMSS_Opera_CheckBox"
        Me._IMSS_Opera_CheckBox.Size = New System.Drawing.Size(20, 19)
        Me._IMSS_Opera_CheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Opera_CheckBox.TabIndex = 9
        Me._IMSS_Opera_CheckBox.Text = "CheckBoxX1"
        '
        '_IMSS_MozillaFireFoxCheckBox_Panel
        '
        Me._IMSS_MozillaFireFoxCheckBox_Panel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MozillaFireFoxCheckBox_Panel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MozillaFireFoxCheckBox_Panel.Controls.Add(Me._IMSS_MozillaFireFox_CheckBox)
        Me._IMSS_MozillaFireFoxCheckBox_Panel.Location = New System.Drawing.Point(127, 38)
        Me._IMSS_MozillaFireFoxCheckBox_Panel.Name = "_IMSS_MozillaFireFoxCheckBox_Panel"
        Me._IMSS_MozillaFireFoxCheckBox_Panel.Size = New System.Drawing.Size(52, 29)
        Me._IMSS_MozillaFireFoxCheckBox_Panel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MozillaFireFoxCheckBox_Panel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_MozillaFireFoxCheckBox_Panel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._IMSS_MozillaFireFoxCheckBox_Panel.Style.BackgroundImage = Global.IMSS_Browser_Cleaner.My.Resources.Resources._IMSS_MozillaFireFox_Icon_16x24
        Me._IMSS_MozillaFireFoxCheckBox_Panel.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.CenterLeft
        Me._IMSS_MozillaFireFoxCheckBox_Panel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MozillaFireFoxCheckBox_Panel.Style.BorderColor.Color = System.Drawing.Color.Silver
        Me._IMSS_MozillaFireFoxCheckBox_Panel.Style.BorderWidth = 0
        Me._IMSS_MozillaFireFoxCheckBox_Panel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me._IMSS_MozillaFireFoxCheckBox_Panel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MozillaFireFoxCheckBox_Panel.Style.GradientAngle = 90
        Me._IMSS_MozillaFireFoxCheckBox_Panel.TabIndex = 10
        '
        '_IMSS_MozillaFireFox_CheckBox
        '
        '
        '
        '
        Me._IMSS_MozillaFireFox_CheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_MozillaFireFox_CheckBox.Location = New System.Drawing.Point(29, 5)
        Me._IMSS_MozillaFireFox_CheckBox.Name = "_IMSS_MozillaFireFox_CheckBox"
        Me._IMSS_MozillaFireFox_CheckBox.Size = New System.Drawing.Size(20, 19)
        Me._IMSS_MozillaFireFox_CheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MozillaFireFox_CheckBox.TabIndex = 9
        Me._IMSS_MozillaFireFox_CheckBox.Text = "CheckBoxX1"
        '
        '_IMSS_InternetExplorerCheckBox_Panel
        '
        Me._IMSS_InternetExplorerCheckBox_Panel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_InternetExplorerCheckBox_Panel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_InternetExplorerCheckBox_Panel.Controls.Add(Me._IMSS_InternetExplorer_CheckBox)
        Me._IMSS_InternetExplorerCheckBox_Panel.Location = New System.Drawing.Point(185, 38)
        Me._IMSS_InternetExplorerCheckBox_Panel.Name = "_IMSS_InternetExplorerCheckBox_Panel"
        Me._IMSS_InternetExplorerCheckBox_Panel.Size = New System.Drawing.Size(52, 29)
        Me._IMSS_InternetExplorerCheckBox_Panel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_InternetExplorerCheckBox_Panel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_InternetExplorerCheckBox_Panel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._IMSS_InternetExplorerCheckBox_Panel.Style.BackgroundImage = Global.IMSS_Browser_Cleaner.My.Resources.Resources._IMSS_InternetExplorer_Icon_16x24
        Me._IMSS_InternetExplorerCheckBox_Panel.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.CenterLeft
        Me._IMSS_InternetExplorerCheckBox_Panel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_InternetExplorerCheckBox_Panel.Style.BorderColor.Color = System.Drawing.Color.Silver
        Me._IMSS_InternetExplorerCheckBox_Panel.Style.BorderWidth = 0
        Me._IMSS_InternetExplorerCheckBox_Panel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me._IMSS_InternetExplorerCheckBox_Panel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_InternetExplorerCheckBox_Panel.Style.GradientAngle = 90
        Me._IMSS_InternetExplorerCheckBox_Panel.TabIndex = 11
        '
        '_IMSS_InternetExplorer_CheckBox
        '
        '
        '
        '
        Me._IMSS_InternetExplorer_CheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_InternetExplorer_CheckBox.Location = New System.Drawing.Point(29, 5)
        Me._IMSS_InternetExplorer_CheckBox.Name = "_IMSS_InternetExplorer_CheckBox"
        Me._IMSS_InternetExplorer_CheckBox.Size = New System.Drawing.Size(20, 19)
        Me._IMSS_InternetExplorer_CheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_InternetExplorer_CheckBox.TabIndex = 9
        Me._IMSS_InternetExplorer_CheckBox.Text = "CheckBoxX1"
        '
        '_IMSS_SafariCheckBox_Panel
        '
        Me._IMSS_SafariCheckBox_Panel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_SafariCheckBox_Panel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_SafariCheckBox_Panel.Controls.Add(Me._IMSS_Safari_CheckBox)
        Me._IMSS_SafariCheckBox_Panel.Location = New System.Drawing.Point(295, 38)
        Me._IMSS_SafariCheckBox_Panel.Name = "_IMSS_SafariCheckBox_Panel"
        Me._IMSS_SafariCheckBox_Panel.Size = New System.Drawing.Size(52, 29)
        Me._IMSS_SafariCheckBox_Panel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_SafariCheckBox_Panel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_SafariCheckBox_Panel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._IMSS_SafariCheckBox_Panel.Style.BackgroundImage = Global.IMSS_Browser_Cleaner.My.Resources.Resources._IMSS_Safari_Icon_16x24
        Me._IMSS_SafariCheckBox_Panel.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.CenterLeft
        Me._IMSS_SafariCheckBox_Panel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_SafariCheckBox_Panel.Style.BorderColor.Color = System.Drawing.Color.Silver
        Me._IMSS_SafariCheckBox_Panel.Style.BorderWidth = 0
        Me._IMSS_SafariCheckBox_Panel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me._IMSS_SafariCheckBox_Panel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_SafariCheckBox_Panel.Style.GradientAngle = 90
        Me._IMSS_SafariCheckBox_Panel.TabIndex = 12
        '
        '_IMSS_Safari_CheckBox
        '
        '
        '
        '
        Me._IMSS_Safari_CheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Safari_CheckBox.Location = New System.Drawing.Point(29, 5)
        Me._IMSS_Safari_CheckBox.Name = "_IMSS_Safari_CheckBox"
        Me._IMSS_Safari_CheckBox.Size = New System.Drawing.Size(20, 19)
        Me._IMSS_Safari_CheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Safari_CheckBox.TabIndex = 9
        Me._IMSS_Safari_CheckBox.Text = "CheckBoxX1"
        '
        '_IMSS_RESULT_LSTVIEW
        '
        Me._IMSS_RESULT_LSTVIEW.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_RESULT_LSTVIEW.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._IMSS_RESULT_LSTVIEW.CheckBoxes = ComponentOwl.BetterListView.BetterListViewCheckBoxes.TwoState
        Me._IMSS_RESULT_LSTVIEW.Columns.AddRange(New Object() {Me._IMSS_Category, Me._IMSS_Elements, Me._IMSS_EstimatedSize})
        Me._IMSS_RESULT_LSTVIEW.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_RESULT_LSTVIEW.Groups.AddRange(New Object() {Me._IMSS_MicrosoftInternetExplorer, Me._IMSS_GoogleChrome, Me._IMSS_MozillaFirefox, Me._IMSS_Opera, Me._IMSS_Safari})
        Me._IMSS_RESULT_LSTVIEW.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.Sortable
        Me._IMSS_RESULT_LSTVIEW.Location = New System.Drawing.Point(2, 3)
        Me._IMSS_RESULT_LSTVIEW.Name = "_IMSS_RESULT_LSTVIEW"
        Me._IMSS_RESULT_LSTVIEW.ShowGroups = True
        Me._IMSS_RESULT_LSTVIEW.Size = New System.Drawing.Size(865, 434)
        Me._IMSS_RESULT_LSTVIEW.TabIndex = 13
        '
        '_IMSS_Category
        '
        Me._IMSS_Category.Name = "_IMSS_Category"
        Me._IMSS_Category.Text = "Category"
        Me._IMSS_Category.Width = 656
        '
        '_IMSS_Elements
        '
        Me._IMSS_Elements.Name = "_IMSS_Elements"
        Me._IMSS_Elements.Text = "Elements"
        Me._IMSS_Elements.Width = 104
        '
        '_IMSS_EstimatedSize
        '
        Me._IMSS_EstimatedSize.Name = "_IMSS_EstimatedSize"
        Me._IMSS_EstimatedSize.Text = "Estimated Size"
        Me._IMSS_EstimatedSize.Width = 103
        '
        '_IMSS_MicrosoftInternetExplorer
        '
        Me._IMSS_MicrosoftInternetExplorer.Font = New System.Drawing.Font("Segoe UI", 10.66667!)
        Me._IMSS_MicrosoftInternetExplorer.Header = "Microsoft Internet Explorer"
        Me._IMSS_MicrosoftInternetExplorer.Name = "_IMSS_MicrosoftInternetExplorer"
        '
        '_IMSS_GoogleChrome
        '
        Me._IMSS_GoogleChrome.Font = New System.Drawing.Font("Segoe UI", 10.66667!)
        Me._IMSS_GoogleChrome.Header = "Google Chrome"
        Me._IMSS_GoogleChrome.Name = "_IMSS_GoogleChrome"
        '
        '_IMSS_MozillaFirefox
        '
        Me._IMSS_MozillaFirefox.Font = New System.Drawing.Font("Segoe UI", 10.66667!)
        Me._IMSS_MozillaFirefox.Header = "Mozilla Firefox"
        Me._IMSS_MozillaFirefox.Name = "_IMSS_MozillaFirefox"
        '
        '_IMSS_Opera
        '
        Me._IMSS_Opera.Font = New System.Drawing.Font("Segoe UI", 10.66667!)
        Me._IMSS_Opera.Header = "Opera"
        Me._IMSS_Opera.Name = "_IMSS_Opera"
        '
        '_IMSS_Safari
        '
        Me._IMSS_Safari.Font = New System.Drawing.Font("Segoe UI", 10.66667!)
        Me._IMSS_Safari.Header = "Safari"
        Me._IMSS_Safari.Name = "_IMSS_Safari"
        '
        '_IMSS_CommandPanel
        '
        Me._IMSS_CommandPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_CommandPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_CommandPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_CommandPanel.Controls.Add(Me._IMSS_ViewItems_Button)
        Me._IMSS_CommandPanel.Controls.Add(Me._IMSS_Clean_Button)
        Me._IMSS_CommandPanel.Controls.Add(Me._IMSS_Close)
        Me._IMSS_CommandPanel.Location = New System.Drawing.Point(0, 569)
        Me._IMSS_CommandPanel.Name = "_IMSS_CommandPanel"
        Me._IMSS_CommandPanel.Size = New System.Drawing.Size(877, 46)
        Me._IMSS_CommandPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_CommandPanel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_CommandPanel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._IMSS_CommandPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_CommandPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_CommandPanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top
        Me._IMSS_CommandPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_CommandPanel.Style.GradientAngle = 90
        Me._IMSS_CommandPanel.TabIndex = 14
        '
        '_IMSS_ViewItems_Button
        '
        Me._IMSS_ViewItems_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_ViewItems_Button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_ViewItems_Button.Location = New System.Drawing.Point(12, 12)
        Me._IMSS_ViewItems_Button.Name = "_IMSS_ViewItems_Button"
        Me._IMSS_ViewItems_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_ViewItems_Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_ViewItems_Button.TabIndex = 2
        Me._IMSS_ViewItems_Button.Text = "View Items"
        '
        '_IMSS_Clean_Button
        '
        Me._IMSS_Clean_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_Clean_Button.Enabled = False
        Me._IMSS_Clean_Button.Location = New System.Drawing.Point(794, 12)
        Me._IMSS_Clean_Button.Name = "_IMSS_Clean_Button"
        Me._IMSS_Clean_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Clean_Button.TabIndex = 1
        Me._IMSS_Clean_Button.Text = "Clean"
        Me._IMSS_Clean_Button.UseVisualStyleBackColor = True
        '
        '_IMSS_Close
        '
        Me._IMSS_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_Close.Location = New System.Drawing.Point(713, 12)
        Me._IMSS_Close.Name = "_IMSS_Close"
        Me._IMSS_Close.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Close.TabIndex = 0
        Me._IMSS_Close.Text = "Close"
        Me._IMSS_Close.UseVisualStyleBackColor = True
        '
        'PanelEx1
        '
        Me.PanelEx1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me._IMSS_RESULT_LABEL)
        Me.PanelEx1.Controls.Add(Me._IMSS_OutPutPanels_Labels)
        Me.PanelEx1.Controls.Add(Me._IMSS_RESULT_LSTVIEW)
        Me.PanelEx1.Location = New System.Drawing.Point(4, 75)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(868, 488)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.White
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.White
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 15
        '
        '_IMSS_RESULT_LABEL
        '
        Me._IMSS_RESULT_LABEL.AutoSize = True
        '
        '
        '
        Me._IMSS_RESULT_LABEL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_RESULT_LABEL.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_RESULT_LABEL.Location = New System.Drawing.Point(356, 225)
        Me._IMSS_RESULT_LABEL.Name = "_IMSS_RESULT_LABEL"
        Me._IMSS_RESULT_LABEL.Size = New System.Drawing.Size(157, 18)
        Me._IMSS_RESULT_LABEL.TabIndex = 14
        Me._IMSS_RESULT_LABEL.Text = "There is no items found"
        '
        '_IMSS_OutPutPanels_Labels
        '
        Me._IMSS_OutPutPanels_Labels.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_OutPutPanels_Labels.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_OutPutPanels_Labels.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_OutPutPanels_Labels.Controls.Add(Me.PanelEx2)
        Me._IMSS_OutPutPanels_Labels.Controls.Add(Me._IMSS_TotalCleanUpPotential_Label)
        Me._IMSS_OutPutPanels_Labels.Controls.Add(Me._IMSS_SelectedForCleanUp_Label)
        Me._IMSS_OutPutPanels_Labels.Location = New System.Drawing.Point(0, 438)
        Me._IMSS_OutPutPanels_Labels.Name = "_IMSS_OutPutPanels_Labels"
        Me._IMSS_OutPutPanels_Labels.Size = New System.Drawing.Size(868, 50)
        Me._IMSS_OutPutPanels_Labels.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_OutPutPanels_Labels.Style.BackColor1.Color = System.Drawing.Color.WhiteSmoke
        Me._IMSS_OutPutPanels_Labels.Style.BackColor2.Color = System.Drawing.Color.Gainsboro
        Me._IMSS_OutPutPanels_Labels.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_OutPutPanels_Labels.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_OutPutPanels_Labels.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_OutPutPanels_Labels.Style.GradientAngle = 90
        Me._IMSS_OutPutPanels_Labels.TabIndex = 1
        '
        'PanelEx2
        '
        Me.PanelEx2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me._IMSS_TotaleSelectedItemsSizeToDelete_Label)
        Me.PanelEx2.Controls.Add(Me._IMSS_ItemToDeleteTotalNumber_Label)
        Me.PanelEx2.Controls.Add(Me._IMSS_FullSize_Label)
        Me.PanelEx2.Controls.Add(Me._IMSS_TotalItems_Label)
        Me.PanelEx2.Location = New System.Drawing.Point(667, 3)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(198, 44)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.Color = System.Drawing.Color.WhiteSmoke
        Me.PanelEx2.Style.BackColor2.Color = System.Drawing.Color.Gainsboro
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.BorderWidth = 0
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 5
        '
        '_IMSS_TotaleSelectedItemsSizeToDelete_Label
        '
        Me._IMSS_TotaleSelectedItemsSizeToDelete_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_TotaleSelectedItemsSizeToDelete_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_TotaleSelectedItemsSizeToDelete_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_TotaleSelectedItemsSizeToDelete_Label.Location = New System.Drawing.Point(114, 4)
        Me._IMSS_TotaleSelectedItemsSizeToDelete_Label.Name = "_IMSS_TotaleSelectedItemsSizeToDelete_Label"
        Me._IMSS_TotaleSelectedItemsSizeToDelete_Label.Size = New System.Drawing.Size(14, 17)
        Me._IMSS_TotaleSelectedItemsSizeToDelete_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_TotaleSelectedItemsSizeToDelete_Label.TabIndex = 5
        Me._IMSS_TotaleSelectedItemsSizeToDelete_Label.Text = """"""
        '
        '_IMSS_ItemToDeleteTotalNumber_Label
        '
        Me._IMSS_ItemToDeleteTotalNumber_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_ItemToDeleteTotalNumber_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_ItemToDeleteTotalNumber_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_ItemToDeleteTotalNumber_Label.Location = New System.Drawing.Point(13, 4)
        Me._IMSS_ItemToDeleteTotalNumber_Label.Name = "_IMSS_ItemToDeleteTotalNumber_Label"
        Me._IMSS_ItemToDeleteTotalNumber_Label.Size = New System.Drawing.Size(42, 17)
        Me._IMSS_ItemToDeleteTotalNumber_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_ItemToDeleteTotalNumber_Label.TabIndex = 2
        Me._IMSS_ItemToDeleteTotalNumber_Label.Text = "29000"
        '
        '_IMSS_FullSize_Label
        '
        Me._IMSS_FullSize_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_FullSize_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_FullSize_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_FullSize_Label.Location = New System.Drawing.Point(114, 24)
        Me._IMSS_FullSize_Label.Name = "_IMSS_FullSize_Label"
        Me._IMSS_FullSize_Label.Size = New System.Drawing.Size(14, 17)
        Me._IMSS_FullSize_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_FullSize_Label.TabIndex = 4
        Me._IMSS_FullSize_Label.Text = """"""
        '
        '_IMSS_TotalItems_Label
        '
        Me._IMSS_TotalItems_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_TotalItems_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_TotalItems_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_TotalItems_Label.Location = New System.Drawing.Point(13, 24)
        Me._IMSS_TotalItems_Label.Name = "_IMSS_TotalItems_Label"
        Me._IMSS_TotalItems_Label.Size = New System.Drawing.Size(41, 17)
        Me._IMSS_TotalItems_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_TotalItems_Label.TabIndex = 3
        Me._IMSS_TotalItems_Label.Text = "29000"
        '
        '_IMSS_TotalCleanUpPotential_Label
        '
        Me._IMSS_TotalCleanUpPotential_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_TotalCleanUpPotential_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_TotalCleanUpPotential_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_TotalCleanUpPotential_Label.Location = New System.Drawing.Point(8, 24)
        Me._IMSS_TotalCleanUpPotential_Label.Name = "_IMSS_TotalCleanUpPotential_Label"
        Me._IMSS_TotalCleanUpPotential_Label.Size = New System.Drawing.Size(151, 17)
        Me._IMSS_TotalCleanUpPotential_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_TotalCleanUpPotential_Label.TabIndex = 1
        Me._IMSS_TotalCleanUpPotential_Label.Text = "Total clean-up potential:"
        '
        '_IMSS_SelectedForCleanUp_Label
        '
        Me._IMSS_SelectedForCleanUp_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_SelectedForCleanUp_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_SelectedForCleanUp_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_SelectedForCleanUp_Label.Location = New System.Drawing.Point(8, 4)
        Me._IMSS_SelectedForCleanUp_Label.Name = "_IMSS_SelectedForCleanUp_Label"
        Me._IMSS_SelectedForCleanUp_Label.Size = New System.Drawing.Size(142, 17)
        Me._IMSS_SelectedForCleanUp_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_SelectedForCleanUp_Label.TabIndex = 0
        Me._IMSS_SelectedForCleanUp_Label.Text = "Selected for clean-up:"
        '
        'IMSS_SECTION_RESULT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me._IMSS_CommandPanel)
        Me.Controls.Add(Me._IMSS_SafariCheckBox_Panel)
        Me.Controls.Add(Me._IMSS_OperaCheckBox_Panel)
        Me.Controls.Add(Me._IMSS_InternetExplorerCheckBox_Panel)
        Me.Controls.Add(Me._IMSS_MozillaFireFoxCheckBox_Panel)
        Me.Controls.Add(Me._IMSS_ChromeCheckBox_Panel)
        Me.Controls.Add(Me._IMSS_CheckingCategory_Label)
        Me.Controls.Add(Me._IMSS_SCTIONRESULT_TITLE_Label)
        Me.Name = "IMSS_SECTION_RESULT"
        Me.Size = New System.Drawing.Size(877, 615)
        Me._IMSS_ChromeCheckBox_Panel.ResumeLayout(False)
        Me._IMSS_OperaCheckBox_Panel.ResumeLayout(False)
        Me._IMSS_MozillaFireFoxCheckBox_Panel.ResumeLayout(False)
        Me._IMSS_InternetExplorerCheckBox_Panel.ResumeLayout(False)
        Me._IMSS_SafariCheckBox_Panel.ResumeLayout(False)
        CType(Me._IMSS_RESULT_LSTVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_CommandPanel.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me._IMSS_OutPutPanels_Labels.ResumeLayout(False)
        Me._IMSS_OutPutPanels_Labels.PerformLayout()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _IMSS_SCTIONRESULT_TITLE_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_CheckingCategory_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_ChromeCheckBox_Panel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_Chrome_CheckBox As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents _IMSS_Opera_CheckBox As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents _IMSS_OperaCheckBox_Panel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_MozillaFireFox_CheckBox As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents _IMSS_MozillaFireFoxCheckBox_Panel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_InternetExplorerCheckBox_Panel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_InternetExplorer_CheckBox As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents _IMSS_SafariCheckBox_Panel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_Safari_CheckBox As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents _IMSS_RESULT_LSTVIEW As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_CommandPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_Clean_Button As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Close As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Category As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Elements As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_EstimatedSize As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_OutPutPanels_Labels As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_TotaleSelectedItemsSizeToDelete_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_ItemToDeleteTotalNumber_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_FullSize_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_TotalItems_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_TotalCleanUpPotential_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_SelectedForCleanUp_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_GoogleChrome As ComponentOwl.BetterListView.BetterListViewGroup
    Friend WithEvents _IMSS_MicrosoftInternetExplorer As ComponentOwl.BetterListView.BetterListViewGroup
    Friend WithEvents _IMSS_MozillaFirefox As ComponentOwl.BetterListView.BetterListViewGroup
    Friend WithEvents _IMSS_Safari As ComponentOwl.BetterListView.BetterListViewGroup
    Friend WithEvents _IMSS_Opera As ComponentOwl.BetterListView.BetterListViewGroup
    Friend WithEvents _IMSS_ViewItems_Button As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_RESULT_LABEL As DevComponents.DotNetBar.LabelX

End Class
