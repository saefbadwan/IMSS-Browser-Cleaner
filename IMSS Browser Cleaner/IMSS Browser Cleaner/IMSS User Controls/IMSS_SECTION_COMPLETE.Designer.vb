<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_SECTION_COMPLETE
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
        Me._IMSS_SCTIONMAIN_TITLE_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_CommandPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_OnError_label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_RestartNow_Button = New System.Windows.Forms.Button()
        Me._IMSS_Close = New System.Windows.Forms.Button()
        Me._IMSS_RESULT_COMPLETE_LSTVIEW = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_Category = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_OnErrorItems = New ComponentOwl.BetterListView.BetterListViewGroup()
        Me._IMSS_SucsessLogo_PictureBox = New System.Windows.Forms.PictureBox()
        Me._IMSS_Complete_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_GreenTick_PictureBox = New System.Windows.Forms.PictureBox()
        Me._IMSS_CommandPanel.SuspendLayout()
        CType(Me._IMSS_RESULT_COMPLETE_LSTVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_SucsessLogo_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_GreenTick_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_SCTIONMAIN_TITLE_Label
        '
        Me._IMSS_SCTIONMAIN_TITLE_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_SCTIONMAIN_TITLE_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_SCTIONMAIN_TITLE_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_SCTIONMAIN_TITLE_Label.Location = New System.Drawing.Point(42, 12)
        Me._IMSS_SCTIONMAIN_TITLE_Label.Name = "_IMSS_SCTIONMAIN_TITLE_Label"
        Me._IMSS_SCTIONMAIN_TITLE_Label.Size = New System.Drawing.Size(383, 21)
        Me._IMSS_SCTIONMAIN_TITLE_Label.TabIndex = 9
        Me._IMSS_SCTIONMAIN_TITLE_Label.Text = "The cleanup of your browsers has been completed"
        '
        '_IMSS_CommandPanel
        '
        Me._IMSS_CommandPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_CommandPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_CommandPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_CommandPanel.Controls.Add(Me._IMSS_OnError_label)
        Me._IMSS_CommandPanel.Controls.Add(Me._IMSS_RestartNow_Button)
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
        Me._IMSS_CommandPanel.TabIndex = 15
        '
        '_IMSS_OnError_label
        '
        Me._IMSS_OnError_label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me._IMSS_OnError_label.AutoSize = True
        '
        '
        '
        Me._IMSS_OnError_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_OnError_label.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_OnError_label.Location = New System.Drawing.Point(12, 16)
        Me._IMSS_OnError_label.Name = "_IMSS_OnError_label"
        Me._IMSS_OnError_label.Size = New System.Drawing.Size(267, 17)
        Me._IMSS_OnError_label.TabIndex = 2
        Me._IMSS_OnError_label.Text = "Note : This items will be delete on the first restart"
        Me._IMSS_OnError_label.Visible = False
        '
        '_IMSS_RestartNow_Button
        '
        Me._IMSS_RestartNow_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_RestartNow_Button.Location = New System.Drawing.Point(780, 12)
        Me._IMSS_RestartNow_Button.Name = "_IMSS_RestartNow_Button"
        Me._IMSS_RestartNow_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_RestartNow_Button.TabIndex = 1
        Me._IMSS_RestartNow_Button.Text = "Restart Now"
        Me._IMSS_RestartNow_Button.UseVisualStyleBackColor = True
        '
        '_IMSS_Close
        '
        Me._IMSS_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_Close.Location = New System.Drawing.Point(699, 12)
        Me._IMSS_Close.Name = "_IMSS_Close"
        Me._IMSS_Close.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Close.TabIndex = 0
        Me._IMSS_Close.Text = "Close"
        Me._IMSS_Close.UseVisualStyleBackColor = True
        '
        '_IMSS_RESULT_COMPLETE_LSTVIEW
        '
        Me._IMSS_RESULT_COMPLETE_LSTVIEW.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_RESULT_COMPLETE_LSTVIEW.BackColor = System.Drawing.Color.White
        Me._IMSS_RESULT_COMPLETE_LSTVIEW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._IMSS_RESULT_COMPLETE_LSTVIEW.Columns.AddRange(New Object() {Me._IMSS_Category})
        Me._IMSS_RESULT_COMPLETE_LSTVIEW.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_RESULT_COMPLETE_LSTVIEW.Groups.AddRange(New Object() {Me._IMSS_OnErrorItems})
        Me._IMSS_RESULT_COMPLETE_LSTVIEW.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.Sortable
        Me._IMSS_RESULT_COMPLETE_LSTVIEW.Location = New System.Drawing.Point(12, 46)
        Me._IMSS_RESULT_COMPLETE_LSTVIEW.Name = "_IMSS_RESULT_COMPLETE_LSTVIEW"
        Me._IMSS_RESULT_COMPLETE_LSTVIEW.ShowGroups = True
        Me._IMSS_RESULT_COMPLETE_LSTVIEW.Size = New System.Drawing.Size(857, 508)
        Me._IMSS_RESULT_COMPLETE_LSTVIEW.TabIndex = 16
        '
        '_IMSS_Category
        '
        Me._IMSS_Category.Name = "_IMSS_Category"
        Me._IMSS_Category.Text = "Category"
        Me._IMSS_Category.Width = 852
        '
        '_IMSS_OnErrorItems
        '
        Me._IMSS_OnErrorItems.Font = New System.Drawing.Font("Segoe UI", 10.66667!)
        Me._IMSS_OnErrorItems.Header = "Item(s) cannot be deleted right now"
        Me._IMSS_OnErrorItems.Image = Global.IMSS_Browser_Cleaner.My.Resources.Resources._IMSS_EmergencyTap_Icon_16x16
        Me._IMSS_OnErrorItems.Name = "_IMSS_OnErrorItems"
        '
        '_IMSS_SucsessLogo_PictureBox
        '
        Me._IMSS_SucsessLogo_PictureBox.BackColor = System.Drawing.Color.White
        Me._IMSS_SucsessLogo_PictureBox.Image = Global.IMSS_Browser_Cleaner.My.Resources.Resources._IMSS_Complete_Icon_140x140
        Me._IMSS_SucsessLogo_PictureBox.Location = New System.Drawing.Point(381, 224)
        Me._IMSS_SucsessLogo_PictureBox.Name = "_IMSS_SucsessLogo_PictureBox"
        Me._IMSS_SucsessLogo_PictureBox.Size = New System.Drawing.Size(140, 140)
        Me._IMSS_SucsessLogo_PictureBox.TabIndex = 17
        Me._IMSS_SucsessLogo_PictureBox.TabStop = False
        '
        '_IMSS_Complete_Label
        '
        Me._IMSS_Complete_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me._IMSS_Complete_Label.AutoSize = True
        Me._IMSS_Complete_Label.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me._IMSS_Complete_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Complete_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Complete_Label.Location = New System.Drawing.Point(288, 370)
        Me._IMSS_Complete_Label.Name = "_IMSS_Complete_Label"
        Me._IMSS_Complete_Label.Size = New System.Drawing.Size(304, 21)
        Me._IMSS_Complete_Label.TabIndex = 18
        Me._IMSS_Complete_Label.Text = "Cleanup process successfully completed"
        Me._IMSS_Complete_Label.Visible = False
        '
        '_IMSS_GreenTick_PictureBox
        '
        Me._IMSS_GreenTick_PictureBox.Image = Global.IMSS_Browser_Cleaner.My.Resources.Resources._IMSS_StatusOn_Icon_16x16
        Me._IMSS_GreenTick_PictureBox.Location = New System.Drawing.Point(12, 13)
        Me._IMSS_GreenTick_PictureBox.Name = "_IMSS_GreenTick_PictureBox"
        Me._IMSS_GreenTick_PictureBox.Size = New System.Drawing.Size(25, 21)
        Me._IMSS_GreenTick_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_GreenTick_PictureBox.TabIndex = 19
        Me._IMSS_GreenTick_PictureBox.TabStop = False
        '
        'IMSS_SECTION_COMPLETE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._IMSS_GreenTick_PictureBox)
        Me.Controls.Add(Me._IMSS_Complete_Label)
        Me.Controls.Add(Me._IMSS_SucsessLogo_PictureBox)
        Me.Controls.Add(Me._IMSS_RESULT_COMPLETE_LSTVIEW)
        Me.Controls.Add(Me._IMSS_CommandPanel)
        Me.Controls.Add(Me._IMSS_SCTIONMAIN_TITLE_Label)
        Me.Name = "IMSS_SECTION_COMPLETE"
        Me.Size = New System.Drawing.Size(877, 615)
        Me._IMSS_CommandPanel.ResumeLayout(False)
        Me._IMSS_CommandPanel.PerformLayout()
        CType(Me._IMSS_RESULT_COMPLETE_LSTVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_SucsessLogo_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_GreenTick_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _IMSS_SCTIONMAIN_TITLE_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_CommandPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_RestartNow_Button As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Close As System.Windows.Forms.Button
    Friend WithEvents _IMSS_RESULT_COMPLETE_LSTVIEW As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_Category As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_OnError_label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_OnErrorItems As ComponentOwl.BetterListView.BetterListViewGroup
    Friend WithEvents _IMSS_SucsessLogo_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_Complete_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_GreenTick_PictureBox As System.Windows.Forms.PictureBox

End Class
