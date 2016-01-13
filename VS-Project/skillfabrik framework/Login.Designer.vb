<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.PassLabel = New System.Windows.Forms.Label()
        Me.PassBox = New System.Windows.Forms.TextBox()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.Trennlinie = New System.Windows.Forms.Label()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(12, 14)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(36, 13)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Login:"
        '
        'PassLabel
        '
        Me.PassLabel.AutoSize = True
        Me.PassLabel.Location = New System.Drawing.Point(12, 40)
        Me.PassLabel.Name = "PassLabel"
        Me.PassLabel.Size = New System.Drawing.Size(56, 13)
        Me.PassLabel.TabIndex = 0
        Me.PassLabel.Text = "Password:"
        '
        'PassBox
        '
        Me.PassBox.Location = New System.Drawing.Point(72, 37)
        Me.PassBox.Name = "PassBox"
        Me.PassBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassBox.Size = New System.Drawing.Size(209, 20)
        Me.PassBox.TabIndex = 1
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(72, 11)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(209, 20)
        Me.NameBox.TabIndex = 1
        '
        'Trennlinie
        '
        Me.Trennlinie.AutoSize = True
        Me.Trennlinie.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Trennlinie.Location = New System.Drawing.Point(10, 74)
        Me.Trennlinie.Name = "Trennlinie"
        Me.Trennlinie.Size = New System.Drawing.Size(271, 13)
        Me.Trennlinie.TabIndex = 2
        Me.Trennlinie.Text = "____________________________________________"
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(12, 90)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(75, 23)
        Me.LoginButton.TabIndex = 3
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(93, 90)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 3
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 122)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.Trennlinie)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.PassBox)
        Me.Controls.Add(Me.PassLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.Text = "skillfabrik framework - login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents PassLabel As System.Windows.Forms.Label
    Friend WithEvents PassBox As System.Windows.Forms.TextBox
    Friend WithEvents NameBox As System.Windows.Forms.TextBox
    Friend WithEvents Trennlinie As System.Windows.Forms.Label
    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button

End Class
