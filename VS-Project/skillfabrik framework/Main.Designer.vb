<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("csgo_prototype")
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("headzeets")
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("headzots v4")
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UnloadButton = New System.Windows.Forms.Button()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.Trennlinie = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.AppBox = New System.Windows.Forms.ListView()
        Me.Apps = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ConBox = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(461, 115)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'UnloadButton
        '
        Me.UnloadButton.Enabled = False
        Me.UnloadButton.Location = New System.Drawing.Point(94, 296)
        Me.UnloadButton.Name = "UnloadButton"
        Me.UnloadButton.Size = New System.Drawing.Size(75, 23)
        Me.UnloadButton.TabIndex = 6
        Me.UnloadButton.Text = "Unload"
        Me.UnloadButton.UseVisualStyleBackColor = True
        '
        'LoadButton
        '
        Me.LoadButton.Location = New System.Drawing.Point(13, 296)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(75, 23)
        Me.LoadButton.TabIndex = 5
        Me.LoadButton.Text = "Load"
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'Trennlinie
        '
        Me.Trennlinie.AutoSize = True
        Me.Trennlinie.BackColor = System.Drawing.SystemColors.Control
        Me.Trennlinie.Enabled = False
        Me.Trennlinie.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Trennlinie.Location = New System.Drawing.Point(11, 280)
        Me.Trennlinie.Name = "Trennlinie"
        Me.Trennlinie.Size = New System.Drawing.Size(469, 13)
        Me.Trennlinie.TabIndex = 4
        Me.Trennlinie.Text = "_____________________________________________________________________________"
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(401, 296)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 6
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'AppBox
        '
        Me.AppBox.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Apps})
        Me.AppBox.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem10, ListViewItem11, ListViewItem12})
        Me.AppBox.Location = New System.Drawing.Point(14, 137)
        Me.AppBox.Name = "AppBox"
        Me.AppBox.Size = New System.Drawing.Size(214, 140)
        Me.AppBox.TabIndex = 7
        Me.AppBox.UseCompatibleStateImageBehavior = False
        Me.AppBox.View = System.Windows.Forms.View.Details
        '
        'Apps
        '
        Me.Apps.Text = "Available Applications"
        Me.Apps.Width = 210
        '
        'ConBox
        '
        Me.ConBox.Enabled = False
        Me.ConBox.Location = New System.Drawing.Point(234, 137)
        Me.ConBox.Multiline = True
        Me.ConBox.Name = "ConBox"
        Me.ConBox.ReadOnly = True
        Me.ConBox.Size = New System.Drawing.Size(240, 140)
        Me.ConBox.TabIndex = 8
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 330)
        Me.Controls.Add(Me.ConBox)
        Me.Controls.Add(Me.AppBox)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.UnloadButton)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.Trennlinie)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.Text = "skillfabrik framework"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents UnloadButton As System.Windows.Forms.Button
    Friend WithEvents LoadButton As System.Windows.Forms.Button
    Friend WithEvents Trennlinie As System.Windows.Forms.Label
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents AppBox As System.Windows.Forms.ListView
    Friend WithEvents Apps As System.Windows.Forms.ColumnHeader
    Friend WithEvents ConBox As System.Windows.Forms.TextBox
End Class
