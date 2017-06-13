<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_SECTION_MAIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_SECTION_MAIN))
        Me._IMSS_Cancel = New System.Windows.Forms.Button()
        Me._IMSS_CommandPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_SCTIONMAIN_TITLE_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Scanning_ProgressBar = New System.Windows.Forms.ProgressBar()
        Me._IMSS_DESC_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Loading_PictureBox = New System.Windows.Forms.PictureBox()
        Me._IMSS_CheckingCategory_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_CheckingCategoryTarget_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_MainLogo_PictureBox = New System.Windows.Forms.PictureBox()
        Me._IMSS_Main_StepIndicator = New DevComponents.DotNetBar.Controls.StepIndicator()
        Me._IMSS_CommandPanel.SuspendLayout()
        CType(Me._IMSS_Loading_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_MainLogo_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_Cancel
        '
        Me._IMSS_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_Cancel.Location = New System.Drawing.Point(783, 12)
        Me._IMSS_Cancel.Name = "_IMSS_Cancel"
        Me._IMSS_Cancel.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Cancel.TabIndex = 0
        Me._IMSS_Cancel.Text = "Cancel"
        Me._IMSS_Cancel.UseVisualStyleBackColor = True
        '
        '_IMSS_CommandPanel
        '
        Me._IMSS_CommandPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_CommandPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_CommandPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_CommandPanel.Controls.Add(Me._IMSS_Cancel)
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
        Me._IMSS_CommandPanel.TabIndex = 1
        '
        '_IMSS_SCTIONMAIN_TITLE_Label
        '
        Me._IMSS_SCTIONMAIN_TITLE_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_SCTIONMAIN_TITLE_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_SCTIONMAIN_TITLE_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_SCTIONMAIN_TITLE_Label.Location = New System.Drawing.Point(76, 31)
        Me._IMSS_SCTIONMAIN_TITLE_Label.Name = "_IMSS_SCTIONMAIN_TITLE_Label"
        Me._IMSS_SCTIONMAIN_TITLE_Label.Size = New System.Drawing.Size(388, 21)
        Me._IMSS_SCTIONMAIN_TITLE_Label.TabIndex = 2
        Me._IMSS_SCTIONMAIN_TITLE_Label.Text = "Searching for items that may be able to be deleted"
        '
        '_IMSS_Scanning_ProgressBar
        '
        Me._IMSS_Scanning_ProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_Scanning_ProgressBar.Location = New System.Drawing.Point(98, 105)
        Me._IMSS_Scanning_ProgressBar.MarqueeAnimationSpeed = 4
        Me._IMSS_Scanning_ProgressBar.Name = "_IMSS_Scanning_ProgressBar"
        Me._IMSS_Scanning_ProgressBar.Size = New System.Drawing.Size(760, 19)
        Me._IMSS_Scanning_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me._IMSS_Scanning_ProgressBar.TabIndex = 3
        '
        '_IMSS_DESC_Label
        '
        Me._IMSS_DESC_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_DESC_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_DESC_Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._IMSS_DESC_Label.Location = New System.Drawing.Point(76, 58)
        Me._IMSS_DESC_Label.Name = "_IMSS_DESC_Label"
        Me._IMSS_DESC_Label.Size = New System.Drawing.Size(582, 15)
        Me._IMSS_DESC_Label.TabIndex = 4
        Me._IMSS_DESC_Label.Text = "Please wait while IMSS Browser Cleaner searches your computer for items of your I" & _
            "nternet browsers that could be deleted."
        '
        '_IMSS_Loading_PictureBox
        '
        Me._IMSS_Loading_PictureBox.Image = CType(resources.GetObject("_IMSS_Loading_PictureBox.Image"), System.Drawing.Image)
        Me._IMSS_Loading_PictureBox.Location = New System.Drawing.Point(76, 84)
        Me._IMSS_Loading_PictureBox.Name = "_IMSS_Loading_PictureBox"
        Me._IMSS_Loading_PictureBox.Size = New System.Drawing.Size(16, 16)
        Me._IMSS_Loading_PictureBox.TabIndex = 5
        Me._IMSS_Loading_PictureBox.TabStop = False
        '
        '_IMSS_CheckingCategory_Label
        '
        Me._IMSS_CheckingCategory_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_CheckingCategory_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_CheckingCategory_Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._IMSS_CheckingCategory_Label.Location = New System.Drawing.Point(98, 84)
        Me._IMSS_CheckingCategory_Label.Name = "_IMSS_CheckingCategory_Label"
        Me._IMSS_CheckingCategory_Label.Size = New System.Drawing.Size(96, 15)
        Me._IMSS_CheckingCategory_Label.TabIndex = 6
        Me._IMSS_CheckingCategory_Label.Tag = ""
        Me._IMSS_CheckingCategory_Label.Text = "Checking category :"
        '
        '_IMSS_CheckingCategoryTarget_Label
        '
        Me._IMSS_CheckingCategoryTarget_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_CheckingCategoryTarget_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_CheckingCategoryTarget_Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._IMSS_CheckingCategoryTarget_Label.Location = New System.Drawing.Point(98, 143)
        Me._IMSS_CheckingCategoryTarget_Label.Name = "_IMSS_CheckingCategoryTarget_Label"
        Me._IMSS_CheckingCategoryTarget_Label.Size = New System.Drawing.Size(96, 15)
        Me._IMSS_CheckingCategoryTarget_Label.TabIndex = 7
        Me._IMSS_CheckingCategoryTarget_Label.Tag = ""
        Me._IMSS_CheckingCategoryTarget_Label.Text = "Checking category :"
        '
        '_IMSS_MainLogo_PictureBox
        '
        Me._IMSS_MainLogo_PictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me._IMSS_MainLogo_PictureBox.Image = Global.IMSS_Browser_Cleaner.My.Resources.Resources._IMSS_Browsers_Icon_155x147
        Me._IMSS_MainLogo_PictureBox.Location = New System.Drawing.Point(31, 395)
        Me._IMSS_MainLogo_PictureBox.Name = "_IMSS_MainLogo_PictureBox"
        Me._IMSS_MainLogo_PictureBox.Size = New System.Drawing.Size(155, 147)
        Me._IMSS_MainLogo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_MainLogo_PictureBox.TabIndex = 8
        Me._IMSS_MainLogo_PictureBox.TabStop = False
        '
        '_IMSS_Main_StepIndicator
        '
        Me._IMSS_Main_StepIndicator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_Main_StepIndicator.Location = New System.Drawing.Point(98, 130)
        Me._IMSS_Main_StepIndicator.Name = "_IMSS_Main_StepIndicator"
        Me._IMSS_Main_StepIndicator.Size = New System.Drawing.Size(760, 4)
        Me._IMSS_Main_StepIndicator.StepCount = 34
        Me._IMSS_Main_StepIndicator.TabIndex = 9
        Me._IMSS_Main_StepIndicator.Text = "StepIndicator1"
        '
        'IMSS_SECTION_MAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._IMSS_Main_StepIndicator)
        Me.Controls.Add(Me._IMSS_MainLogo_PictureBox)
        Me.Controls.Add(Me._IMSS_CheckingCategoryTarget_Label)
        Me.Controls.Add(Me._IMSS_CheckingCategory_Label)
        Me.Controls.Add(Me._IMSS_Loading_PictureBox)
        Me.Controls.Add(Me._IMSS_DESC_Label)
        Me.Controls.Add(Me._IMSS_Scanning_ProgressBar)
        Me.Controls.Add(Me._IMSS_SCTIONMAIN_TITLE_Label)
        Me.Controls.Add(Me._IMSS_CommandPanel)
        Me.Name = "IMSS_SECTION_MAIN"
        Me.Size = New System.Drawing.Size(877, 615)
        Me._IMSS_CommandPanel.ResumeLayout(False)
        CType(Me._IMSS_Loading_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_MainLogo_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _IMSS_Cancel As System.Windows.Forms.Button
    Friend WithEvents _IMSS_CommandPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_SCTIONMAIN_TITLE_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Scanning_ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents _IMSS_DESC_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Loading_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_CheckingCategory_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_CheckingCategoryTarget_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_MainLogo_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_Main_StepIndicator As DevComponents.DotNetBar.Controls.StepIndicator

End Class
