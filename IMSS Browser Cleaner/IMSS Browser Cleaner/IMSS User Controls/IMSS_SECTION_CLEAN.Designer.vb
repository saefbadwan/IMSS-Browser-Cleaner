<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_SECTION_CLEAN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_SECTION_CLEAN))
        Me._IMSS_CheckingCategoryTarget_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_DESC_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Scanning_ProgressBar = New System.Windows.Forms.ProgressBar()
        Me._IMSS_SCTIONMAIN_TITLE_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_WArning_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_CleanupLogo_PictureBox = New System.Windows.Forms.PictureBox()
        Me._IMSS_Warning_Icon = New System.Windows.Forms.PictureBox()
        Me._IMSS_Loading_PictureBox = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me._IMSS_CleanupLogo_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_Warning_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_Loading_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_CheckingCategoryTarget_Label
        '
        Me._IMSS_CheckingCategoryTarget_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_CheckingCategoryTarget_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_CheckingCategoryTarget_Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._IMSS_CheckingCategoryTarget_Label.Location = New System.Drawing.Point(120, 130)
        Me._IMSS_CheckingCategoryTarget_Label.Name = "_IMSS_CheckingCategoryTarget_Label"
        Me._IMSS_CheckingCategoryTarget_Label.Size = New System.Drawing.Size(96, 15)
        Me._IMSS_CheckingCategoryTarget_Label.TabIndex = 12
        Me._IMSS_CheckingCategoryTarget_Label.Tag = ""
        Me._IMSS_CheckingCategoryTarget_Label.Text = "Checking category :"
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
        Me._IMSS_DESC_Label.TabIndex = 10
        Me._IMSS_DESC_Label.Text = "Please wait while IMSS Browser Cleaner searches your computer for items of your I" & _
            "nternet browsers that could be deleted."
        '
        '_IMSS_Scanning_ProgressBar
        '
        Me._IMSS_Scanning_ProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_Scanning_ProgressBar.Location = New System.Drawing.Point(98, 105)
        Me._IMSS_Scanning_ProgressBar.MarqueeAnimationSpeed = 4
        Me._IMSS_Scanning_ProgressBar.Name = "_IMSS_Scanning_ProgressBar"
        Me._IMSS_Scanning_ProgressBar.Size = New System.Drawing.Size(760, 19)
        Me._IMSS_Scanning_ProgressBar.TabIndex = 9
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
        Me._IMSS_SCTIONMAIN_TITLE_Label.Size = New System.Drawing.Size(360, 21)
        Me._IMSS_SCTIONMAIN_TITLE_Label.TabIndex = 8
        Me._IMSS_SCTIONMAIN_TITLE_Label.Text = "Please wait while your browsers are cleaned up"
        '
        '_IMSS_WArning_Label
        '
        Me._IMSS_WArning_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_WArning_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_WArning_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_WArning_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_WArning_Label.Location = New System.Drawing.Point(498, 596)
        Me._IMSS_WArning_Label.Name = "_IMSS_WArning_Label"
        Me._IMSS_WArning_Label.Size = New System.Drawing.Size(379, 16)
        Me._IMSS_WArning_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_WArning_Label.TabIndex = 19
        Me._IMSS_WArning_Label.Text = "During the deletion, the computer may stop responding temporarily"
        '
        '_IMSS_CleanupLogo_PictureBox
        '
        Me._IMSS_CleanupLogo_PictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me._IMSS_CleanupLogo_PictureBox.Image = Global.IMSS_Browser_Cleaner.My.Resources.Resources._IMSS_BrowsersCleanup_Icon_155x147
        Me._IMSS_CleanupLogo_PictureBox.Location = New System.Drawing.Point(31, 395)
        Me._IMSS_CleanupLogo_PictureBox.Name = "_IMSS_CleanupLogo_PictureBox"
        Me._IMSS_CleanupLogo_PictureBox.Size = New System.Drawing.Size(155, 147)
        Me._IMSS_CleanupLogo_PictureBox.TabIndex = 21
        Me._IMSS_CleanupLogo_PictureBox.TabStop = False
        '
        '_IMSS_Warning_Icon
        '
        Me._IMSS_Warning_Icon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_Warning_Icon.Image = Global.IMSS_Browser_Cleaner.My.Resources.Resources._IMSS_ProcessingWarning_Icon_16x16
        Me._IMSS_Warning_Icon.InitialImage = Nothing
        Me._IMSS_Warning_Icon.Location = New System.Drawing.Point(476, 596)
        Me._IMSS_Warning_Icon.Name = "_IMSS_Warning_Icon"
        Me._IMSS_Warning_Icon.Size = New System.Drawing.Size(16, 16)
        Me._IMSS_Warning_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me._IMSS_Warning_Icon.TabIndex = 20
        Me._IMSS_Warning_Icon.TabStop = False
        '
        '_IMSS_Loading_PictureBox
        '
        Me._IMSS_Loading_PictureBox.Image = CType(resources.GetObject("_IMSS_Loading_PictureBox.Image"), System.Drawing.Image)
        Me._IMSS_Loading_PictureBox.Location = New System.Drawing.Point(98, 129)
        Me._IMSS_Loading_PictureBox.Name = "_IMSS_Loading_PictureBox"
        Me._IMSS_Loading_PictureBox.Size = New System.Drawing.Size(16, 16)
        Me._IMSS_Loading_PictureBox.TabIndex = 13
        Me._IMSS_Loading_PictureBox.TabStop = False
        '
        'BackgroundWorker1
        '
        '
        'IMSS_SECTION_CLEAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._IMSS_CleanupLogo_PictureBox)
        Me.Controls.Add(Me._IMSS_Warning_Icon)
        Me.Controls.Add(Me._IMSS_WArning_Label)
        Me.Controls.Add(Me._IMSS_Loading_PictureBox)
        Me.Controls.Add(Me._IMSS_CheckingCategoryTarget_Label)
        Me.Controls.Add(Me._IMSS_DESC_Label)
        Me.Controls.Add(Me._IMSS_Scanning_ProgressBar)
        Me.Controls.Add(Me._IMSS_SCTIONMAIN_TITLE_Label)
        Me.Name = "IMSS_SECTION_CLEAN"
        Me.Size = New System.Drawing.Size(877, 615)
        CType(Me._IMSS_CleanupLogo_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_Warning_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_Loading_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _IMSS_CheckingCategoryTarget_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_DESC_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Scanning_ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents _IMSS_SCTIONMAIN_TITLE_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Loading_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_Warning_Icon As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_WArning_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_CleanupLogo_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
