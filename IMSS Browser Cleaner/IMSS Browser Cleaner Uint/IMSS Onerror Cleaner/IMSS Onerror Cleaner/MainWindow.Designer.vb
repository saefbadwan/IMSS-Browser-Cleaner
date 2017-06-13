<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Me._IMSS_Cleaning_ProgressBar = New System.Windows.Forms.ProgressBar()
        Me._IMSS_Cleaning_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        '_IMSS_Cleaning_ProgressBar
        '
        Me._IMSS_Cleaning_ProgressBar.Location = New System.Drawing.Point(13, 22)
        Me._IMSS_Cleaning_ProgressBar.MarqueeAnimationSpeed = 4
        Me._IMSS_Cleaning_ProgressBar.Name = "_IMSS_Cleaning_ProgressBar"
        Me._IMSS_Cleaning_ProgressBar.Size = New System.Drawing.Size(447, 23)
        Me._IMSS_Cleaning_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me._IMSS_Cleaning_ProgressBar.TabIndex = 0
        '
        '_IMSS_Cleaning_Label
        '
        Me._IMSS_Cleaning_Label.AutoSize = True
        Me._IMSS_Cleaning_Label.Location = New System.Drawing.Point(13, 52)
        Me._IMSS_Cleaning_Label.Name = "_IMSS_Cleaning_Label"
        Me._IMSS_Cleaning_Label.Size = New System.Drawing.Size(15, 13)
        Me._IMSS_Cleaning_Label.TabIndex = 1
        Me._IMSS_Cleaning_Label.Text = """"""
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 73)
        Me.Controls.Add(Me._IMSS_Cleaning_Label)
        Me.Controls.Add(Me._IMSS_Cleaning_ProgressBar)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(488, 111)
        Me.MinimumSize = New System.Drawing.Size(488, 111)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cleaning the remaining elements"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _IMSS_Cleaning_ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents _IMSS_Cleaning_Label As System.Windows.Forms.Label

End Class
