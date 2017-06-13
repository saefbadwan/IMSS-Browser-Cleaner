<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _IMSS_ListItems
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_IMSS_ListItems))
        Me._IMSS_MainPanel = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_ItemPictureBox = New System.Windows.Forms.PictureBox()
        Me._IMSS_FileOptionPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_SelectedItemSize_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_SelctedItemType_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_SelectedItemName_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_FileProperties_LinkLabel = New System.Windows.Forms.LinkLabel()
        Me._IMSS_OpenFolder_LinkLabel = New System.Windows.Forms.LinkLabel()
        Me._IMSS_Openfile_LinkLabel = New System.Windows.Forms.LinkLabel()
        Me._IMSS_LA_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_MO_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_CO_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_LastAccess_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_ModifiedOn_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_CreatedOn_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_SelectedItemImage_PictuerBox = New System.Windows.Forms.PictureBox()
        Me._IMSS_ShowItemsBetterListView = New ComponentOwl.BetterListView.BetterListView()
        Me.BetterListViewColumnHeader1 = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.BetterListViewColumnHeader4 = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.BetterListViewColumnHeader2 = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.BetterListViewColumnHeader3 = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.BetterListViewColumnHeader5 = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_SelectedForCleanUpProcess = New ComponentOwl.BetterListView.BetterListViewGroup()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_Delete_Button = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_UnCheckAll_Button = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_CheckAll_Button = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_OkButton = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_CancelButton = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_MainPanel.SuspendLayout()
        CType(Me._IMSS_ItemPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_FileOptionPanel.SuspendLayout()
        CType(Me._IMSS_SelectedItemImage_PictuerBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_ShowItemsBetterListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        Me.SuspendLayout()
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainPanel.Controls.Add(Me.LabelX1)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_ItemPictureBox)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_FileOptionPanel)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_ShowItemsBetterListView)
        Me._IMSS_MainPanel.Controls.Add(Me.PanelEx2)
        Me._IMSS_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(1017, 552)
        Me._IMSS_MainPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MainPanel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(254, Byte), Integer))
        Me._IMSS_MainPanel.Style.BackColor2.Color = System.Drawing.Color.White
        Me._IMSS_MainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MainPanel.Style.BorderWidth = 0
        Me._IMSS_MainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MainPanel.Style.GradientAngle = 90
        Me._IMSS_MainPanel.TabIndex = 0
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(59, 14)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(230, 16)
        Me.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.LabelX1.TabIndex = 6
        Me.LabelX1.Text = "Please select the files you wish to delete."
        '
        '_IMSS_ItemPictureBox
        '
        Me._IMSS_ItemPictureBox.Image = Global.IMSS_Browser_Cleaner.My.Resources.Resources._IMSS_ListItems_Icon_48x48
        Me._IMSS_ItemPictureBox.Location = New System.Drawing.Point(7, 2)
        Me._IMSS_ItemPictureBox.Name = "_IMSS_ItemPictureBox"
        Me._IMSS_ItemPictureBox.Size = New System.Drawing.Size(47, 40)
        Me._IMSS_ItemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_ItemPictureBox.TabIndex = 5
        Me._IMSS_ItemPictureBox.TabStop = False
        '
        '_IMSS_FileOptionPanel
        '
        Me._IMSS_FileOptionPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_FileOptionPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_FileOptionPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_FileOptionPanel.Controls.Add(Me._IMSS_SelectedItemSize_Label)
        Me._IMSS_FileOptionPanel.Controls.Add(Me._IMSS_SelctedItemType_Label)
        Me._IMSS_FileOptionPanel.Controls.Add(Me._IMSS_SelectedItemName_Label)
        Me._IMSS_FileOptionPanel.Controls.Add(Me._IMSS_FileProperties_LinkLabel)
        Me._IMSS_FileOptionPanel.Controls.Add(Me._IMSS_OpenFolder_LinkLabel)
        Me._IMSS_FileOptionPanel.Controls.Add(Me._IMSS_Openfile_LinkLabel)
        Me._IMSS_FileOptionPanel.Controls.Add(Me._IMSS_LA_Label)
        Me._IMSS_FileOptionPanel.Controls.Add(Me._IMSS_MO_Label)
        Me._IMSS_FileOptionPanel.Controls.Add(Me._IMSS_CO_Label)
        Me._IMSS_FileOptionPanel.Controls.Add(Me._IMSS_LastAccess_Label)
        Me._IMSS_FileOptionPanel.Controls.Add(Me._IMSS_ModifiedOn_Label)
        Me._IMSS_FileOptionPanel.Controls.Add(Me._IMSS_CreatedOn_Label)
        Me._IMSS_FileOptionPanel.Controls.Add(Me._IMSS_SelectedItemImage_PictuerBox)
        Me._IMSS_FileOptionPanel.Location = New System.Drawing.Point(8, 444)
        Me._IMSS_FileOptionPanel.Name = "_IMSS_FileOptionPanel"
        Me._IMSS_FileOptionPanel.Size = New System.Drawing.Size(1000, 69)
        Me._IMSS_FileOptionPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_FileOptionPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me._IMSS_FileOptionPanel.Style.BackColor2.Color = System.Drawing.Color.WhiteSmoke
        Me._IMSS_FileOptionPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_FileOptionPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_FileOptionPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_FileOptionPanel.Style.GradientAngle = 90
        Me._IMSS_FileOptionPanel.TabIndex = 4
        '
        '_IMSS_SelectedItemSize_Label
        '
        Me._IMSS_SelectedItemSize_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_SelectedItemSize_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_SelectedItemSize_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_SelectedItemSize_Label.Location = New System.Drawing.Point(60, 46)
        Me._IMSS_SelectedItemSize_Label.Name = "_IMSS_SelectedItemSize_Label"
        Me._IMSS_SelectedItemSize_Label.Size = New System.Drawing.Size(35, 16)
        Me._IMSS_SelectedItemSize_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_SelectedItemSize_Label.TabIndex = 12
        Me._IMSS_SelectedItemSize_Label.Text = "Name"
        '
        '_IMSS_SelctedItemType_Label
        '
        Me._IMSS_SelctedItemType_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_SelctedItemType_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_SelctedItemType_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_SelctedItemType_Label.Location = New System.Drawing.Point(60, 26)
        Me._IMSS_SelctedItemType_Label.Name = "_IMSS_SelctedItemType_Label"
        Me._IMSS_SelctedItemType_Label.Size = New System.Drawing.Size(29, 16)
        Me._IMSS_SelctedItemType_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_SelctedItemType_Label.TabIndex = 11
        Me._IMSS_SelctedItemType_Label.Text = "Type"
        '
        '_IMSS_SelectedItemName_Label
        '
        Me._IMSS_SelectedItemName_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_SelectedItemName_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_SelectedItemName_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_SelectedItemName_Label.Location = New System.Drawing.Point(60, 6)
        Me._IMSS_SelectedItemName_Label.Name = "_IMSS_SelectedItemName_Label"
        Me._IMSS_SelectedItemName_Label.Size = New System.Drawing.Size(35, 16)
        Me._IMSS_SelectedItemName_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_SelectedItemName_Label.TabIndex = 10
        Me._IMSS_SelectedItemName_Label.Text = "Name"
        '
        '_IMSS_FileProperties_LinkLabel
        '
        Me._IMSS_FileProperties_LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_FileProperties_LinkLabel.AutoSize = True
        Me._IMSS_FileProperties_LinkLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_FileProperties_LinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me._IMSS_FileProperties_LinkLabel.LinkColor = System.Drawing.SystemColors.HotTrack
        Me._IMSS_FileProperties_LinkLabel.Location = New System.Drawing.Point(905, 47)
        Me._IMSS_FileProperties_LinkLabel.Name = "_IMSS_FileProperties_LinkLabel"
        Me._IMSS_FileProperties_LinkLabel.Size = New System.Drawing.Size(88, 15)
        Me._IMSS_FileProperties_LinkLabel.TabIndex = 9
        Me._IMSS_FileProperties_LinkLabel.TabStop = True
        Me._IMSS_FileProperties_LinkLabel.Text = "File Properties"
        '
        '_IMSS_OpenFolder_LinkLabel
        '
        Me._IMSS_OpenFolder_LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_OpenFolder_LinkLabel.AutoSize = True
        Me._IMSS_OpenFolder_LinkLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_OpenFolder_LinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me._IMSS_OpenFolder_LinkLabel.LinkColor = System.Drawing.SystemColors.HotTrack
        Me._IMSS_OpenFolder_LinkLabel.Location = New System.Drawing.Point(905, 26)
        Me._IMSS_OpenFolder_LinkLabel.Name = "_IMSS_OpenFolder_LinkLabel"
        Me._IMSS_OpenFolder_LinkLabel.Size = New System.Drawing.Size(74, 15)
        Me._IMSS_OpenFolder_LinkLabel.TabIndex = 8
        Me._IMSS_OpenFolder_LinkLabel.TabStop = True
        Me._IMSS_OpenFolder_LinkLabel.Text = "Open folder"
        '
        '_IMSS_Openfile_LinkLabel
        '
        Me._IMSS_Openfile_LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_Openfile_LinkLabel.AutoSize = True
        Me._IMSS_Openfile_LinkLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Openfile_LinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me._IMSS_Openfile_LinkLabel.LinkColor = System.Drawing.SystemColors.HotTrack
        Me._IMSS_Openfile_LinkLabel.Location = New System.Drawing.Point(905, 6)
        Me._IMSS_Openfile_LinkLabel.Name = "_IMSS_Openfile_LinkLabel"
        Me._IMSS_Openfile_LinkLabel.Size = New System.Drawing.Size(58, 15)
        Me._IMSS_Openfile_LinkLabel.TabIndex = 7
        Me._IMSS_Openfile_LinkLabel.TabStop = True
        Me._IMSS_Openfile_LinkLabel.Text = "&Open file"
        '
        '_IMSS_LA_Label
        '
        Me._IMSS_LA_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_LA_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_LA_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_LA_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_LA_Label.Location = New System.Drawing.Point(717, 47)
        Me._IMSS_LA_Label.Name = "_IMSS_LA_Label"
        Me._IMSS_LA_Label.Size = New System.Drawing.Size(74, 16)
        Me._IMSS_LA_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_LA_Label.TabIndex = 6
        Me._IMSS_LA_Label.Text = "Created On :"
        '
        '_IMSS_MO_Label
        '
        Me._IMSS_MO_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_MO_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_MO_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_MO_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_MO_Label.Location = New System.Drawing.Point(717, 26)
        Me._IMSS_MO_Label.Name = "_IMSS_MO_Label"
        Me._IMSS_MO_Label.Size = New System.Drawing.Size(74, 16)
        Me._IMSS_MO_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_MO_Label.TabIndex = 5
        Me._IMSS_MO_Label.Text = "Created On :"
        '
        '_IMSS_CO_Label
        '
        Me._IMSS_CO_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_CO_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_CO_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_CO_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_CO_Label.Location = New System.Drawing.Point(717, 5)
        Me._IMSS_CO_Label.Name = "_IMSS_CO_Label"
        Me._IMSS_CO_Label.Size = New System.Drawing.Size(74, 16)
        Me._IMSS_CO_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_CO_Label.TabIndex = 4
        Me._IMSS_CO_Label.Text = "Created On :"
        '
        '_IMSS_LastAccess_Label
        '
        Me._IMSS_LastAccess_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_LastAccess_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_LastAccess_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_LastAccess_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_LastAccess_Label.Location = New System.Drawing.Point(614, 47)
        Me._IMSS_LastAccess_Label.Name = "_IMSS_LastAccess_Label"
        Me._IMSS_LastAccess_Label.Size = New System.Drawing.Size(75, 16)
        Me._IMSS_LastAccess_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_LastAccess_Label.TabIndex = 3
        Me._IMSS_LastAccess_Label.Text = "Last Access :"
        '
        '_IMSS_ModifiedOn_Label
        '
        Me._IMSS_ModifiedOn_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_ModifiedOn_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_ModifiedOn_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_ModifiedOn_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_ModifiedOn_Label.Location = New System.Drawing.Point(614, 26)
        Me._IMSS_ModifiedOn_Label.Name = "_IMSS_ModifiedOn_Label"
        Me._IMSS_ModifiedOn_Label.Size = New System.Drawing.Size(77, 16)
        Me._IMSS_ModifiedOn_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_ModifiedOn_Label.TabIndex = 2
        Me._IMSS_ModifiedOn_Label.Text = "Modified On :"
        '
        '_IMSS_CreatedOn_Label
        '
        Me._IMSS_CreatedOn_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_CreatedOn_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_CreatedOn_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_CreatedOn_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_CreatedOn_Label.Location = New System.Drawing.Point(614, 5)
        Me._IMSS_CreatedOn_Label.Name = "_IMSS_CreatedOn_Label"
        Me._IMSS_CreatedOn_Label.Size = New System.Drawing.Size(74, 16)
        Me._IMSS_CreatedOn_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_CreatedOn_Label.TabIndex = 1
        Me._IMSS_CreatedOn_Label.Text = "Created On :"
        '
        '_IMSS_SelectedItemImage_PictuerBox
        '
        Me._IMSS_SelectedItemImage_PictuerBox.Location = New System.Drawing.Point(3, 21)
        Me._IMSS_SelectedItemImage_PictuerBox.Name = "_IMSS_SelectedItemImage_PictuerBox"
        Me._IMSS_SelectedItemImage_PictuerBox.Size = New System.Drawing.Size(41, 32)
        Me._IMSS_SelectedItemImage_PictuerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_SelectedItemImage_PictuerBox.TabIndex = 0
        Me._IMSS_SelectedItemImage_PictuerBox.TabStop = False
        '
        '_IMSS_ShowItemsBetterListView
        '
        Me._IMSS_ShowItemsBetterListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_ShowItemsBetterListView.CheckBoxes = ComponentOwl.BetterListView.BetterListViewCheckBoxes.TwoState
        Me._IMSS_ShowItemsBetterListView.Columns.AddRange(New Object() {Me.BetterListViewColumnHeader1, Me.BetterListViewColumnHeader4, Me.BetterListViewColumnHeader2, Me.BetterListViewColumnHeader3, Me.BetterListViewColumnHeader5})
        Me._IMSS_ShowItemsBetterListView.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_ShowItemsBetterListView.Groups.AddRange(New Object() {Me._IMSS_SelectedForCleanUpProcess})
        Me._IMSS_ShowItemsBetterListView.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.Sortable
        Me._IMSS_ShowItemsBetterListView.Location = New System.Drawing.Point(8, 46)
        Me._IMSS_ShowItemsBetterListView.Name = "_IMSS_ShowItemsBetterListView"
        Me._IMSS_ShowItemsBetterListView.Size = New System.Drawing.Size(1000, 386)
        Me._IMSS_ShowItemsBetterListView.TabIndex = 0
        '
        'BetterListViewColumnHeader1
        '
        Me.BetterListViewColumnHeader1.Name = "BetterListViewColumnHeader1"
        Me.BetterListViewColumnHeader1.Text = "File Name"
        Me.BetterListViewColumnHeader1.Width = 227
        '
        'BetterListViewColumnHeader4
        '
        Me.BetterListViewColumnHeader4.Name = "BetterListViewColumnHeader4"
        Me.BetterListViewColumnHeader4.Text = "File Type"
        Me.BetterListViewColumnHeader4.Width = 197
        '
        'BetterListViewColumnHeader2
        '
        Me.BetterListViewColumnHeader2.Name = "BetterListViewColumnHeader2"
        Me.BetterListViewColumnHeader2.Text = "File Size"
        Me.BetterListViewColumnHeader2.Width = 100
        '
        'BetterListViewColumnHeader3
        '
        Me.BetterListViewColumnHeader3.Name = "BetterListViewColumnHeader3"
        Me.BetterListViewColumnHeader3.Text = "File Path"
        Me.BetterListViewColumnHeader3.Width = 141
        '
        'BetterListViewColumnHeader5
        '
        Me.BetterListViewColumnHeader5.Name = "BetterListViewColumnHeader5"
        Me.BetterListViewColumnHeader5.Text = "Folder Path"
        Me.BetterListViewColumnHeader5.Width = 331
        '
        '_IMSS_SelectedForCleanUpProcess
        '
        Me._IMSS_SelectedForCleanUpProcess.Font = New System.Drawing.Font("Segoe UI", 10.66667!)
        Me._IMSS_SelectedForCleanUpProcess.Header = "Select items for clean up"
        Me._IMSS_SelectedForCleanUpProcess.Name = "_IMSS_SelectedForCleanUpProcess"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me._IMSS_Delete_Button)
        Me.PanelEx2.Controls.Add(Me._IMSS_UnCheckAll_Button)
        Me.PanelEx2.Controls.Add(Me._IMSS_CheckAll_Button)
        Me.PanelEx2.Controls.Add(Me._IMSS_OkButton)
        Me.PanelEx2.Controls.Add(Me._IMSS_CancelButton)
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx2.Location = New System.Drawing.Point(0, 521)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(1017, 31)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.PanelEx2.Style.BackColor2.Color = System.Drawing.Color.White
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 3
        '
        '_IMSS_Delete_Button
        '
        Me._IMSS_Delete_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_Delete_Button.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me._IMSS_Delete_Button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_Delete_Button.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Delete_Button.Location = New System.Drawing.Point(755, 4)
        Me._IMSS_Delete_Button.Name = "_IMSS_Delete_Button"
        Me._IMSS_Delete_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Delete_Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Delete_Button.TabIndex = 4
        Me._IMSS_Delete_Button.Text = "Delete"
        '
        '_IMSS_UnCheckAll_Button
        '
        Me._IMSS_UnCheckAll_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_UnCheckAll_Button.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me._IMSS_UnCheckAll_Button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_UnCheckAll_Button.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_UnCheckAll_Button.Location = New System.Drawing.Point(674, 4)
        Me._IMSS_UnCheckAll_Button.Name = "_IMSS_UnCheckAll_Button"
        Me._IMSS_UnCheckAll_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_UnCheckAll_Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_UnCheckAll_Button.TabIndex = 3
        Me._IMSS_UnCheckAll_Button.Text = "UnCheck All"
        '
        '_IMSS_CheckAll_Button
        '
        Me._IMSS_CheckAll_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_CheckAll_Button.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me._IMSS_CheckAll_Button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_CheckAll_Button.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_CheckAll_Button.Location = New System.Drawing.Point(594, 4)
        Me._IMSS_CheckAll_Button.Name = "_IMSS_CheckAll_Button"
        Me._IMSS_CheckAll_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_CheckAll_Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_CheckAll_Button.TabIndex = 2
        Me._IMSS_CheckAll_Button.Text = "Check All"
        '
        '_IMSS_OkButton
        '
        Me._IMSS_OkButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_OkButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me._IMSS_OkButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_OkButton.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_OkButton.Location = New System.Drawing.Point(849, 4)
        Me._IMSS_OkButton.Name = "_IMSS_OkButton"
        Me._IMSS_OkButton.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_OkButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_OkButton.TabIndex = 1
        Me._IMSS_OkButton.Text = "OK"
        '
        '_IMSS_CancelButton
        '
        Me._IMSS_CancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_CancelButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me._IMSS_CancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_CancelButton.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_CancelButton.Location = New System.Drawing.Point(930, 4)
        Me._IMSS_CancelButton.Name = "_IMSS_CancelButton"
        Me._IMSS_CancelButton.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_CancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_CancelButton.TabIndex = 0
        Me._IMSS_CancelButton.Text = "Cancel"
        '
        '_IMSS_ListItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 552)
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(681, 426)
        Me.Name = "_IMSS_ListItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Show Items :"
        Me._IMSS_MainPanel.ResumeLayout(False)
        Me._IMSS_MainPanel.PerformLayout()
        CType(Me._IMSS_ItemPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_FileOptionPanel.ResumeLayout(False)
        Me._IMSS_FileOptionPanel.PerformLayout()
        CType(Me._IMSS_SelectedItemImage_PictuerBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_ShowItemsBetterListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_ShowItemsBetterListView As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents BetterListViewColumnHeader1 As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents BetterListViewColumnHeader2 As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents BetterListViewColumnHeader3 As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents BetterListViewColumnHeader4 As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents BetterListViewColumnHeader5 As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_ItemPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_OkButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_CancelButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_Delete_Button As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_UnCheckAll_Button As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_CheckAll_Button As DevComponents.DotNetBar.ButtonX
    '  Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents _IMSS_FileOptionPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_SelectedItemSize_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_SelctedItemType_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_SelectedItemName_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_FileProperties_LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents _IMSS_OpenFolder_LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents _IMSS_Openfile_LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents _IMSS_LA_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_MO_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_CO_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_LastAccess_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_ModifiedOn_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_CreatedOn_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_SelectedItemImage_PictuerBox As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_SelectedForCleanUpProcess As ComponentOwl.BetterListView.BetterListViewGroup
End Class
