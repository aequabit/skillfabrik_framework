<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading
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
        Me.components = New System.ComponentModel.Container()
        Me.ProgBar = New System.Windows.Forms.ProgressBar()
        Me.ProgTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ProgBar
        '
        Me.ProgBar.Location = New System.Drawing.Point(12, 12)
        Me.ProgBar.Name = "ProgBar"
        Me.ProgBar.Size = New System.Drawing.Size(347, 36)
        Me.ProgBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgBar.TabIndex = 0
        '
        'ProgTimer
        '
        Me.ProgTimer.Interval = 120
        '
        'Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 60)
        Me.Controls.Add(Me.ProgBar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Loading"
        Me.ShowIcon = False
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProgBar As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgTimer As System.Windows.Forms.Timer
End Class
