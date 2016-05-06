<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aboutForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aboutForm))
        Me.headlineLabel = New System.Windows.Forms.Label()
        Me.copyrightLabel = New System.Windows.Forms.Label()
        Me.okButton = New System.Windows.Forms.Button()
        Me.websiteLinkLabel = New WindowsApplication143.FixedLinkLabel()
        Me.SuspendLayout()
        '
        'headlineLabel
        '
        Me.headlineLabel.AutoSize = True
        Me.headlineLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headlineLabel.Location = New System.Drawing.Point(12, 9)
        Me.headlineLabel.Name = "headlineLabel"
        Me.headlineLabel.Size = New System.Drawing.Size(56, 16)
        Me.headlineLabel.TabIndex = 0
        Me.headlineLabel.Text = "Symbol"
        '
        'copyrightLabel
        '
        Me.copyrightLabel.AutoSize = True
        Me.copyrightLabel.Location = New System.Drawing.Point(12, 35)
        Me.copyrightLabel.Name = "copyrightLabel"
        Me.copyrightLabel.Size = New System.Drawing.Size(211, 14)
        Me.copyrightLabel.TabIndex = 2
        Me.copyrightLabel.Text = "Copyright © Brennced. All rights reserved." & Global.Microsoft.VisualBasic.ChrW(13)
        '
        'okButton
        '
        Me.okButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.okButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.okButton.Location = New System.Drawing.Point(203, 67)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(74, 25)
        Me.okButton.TabIndex = 3
        Me.okButton.Text = "&OK"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'websiteLinkLabel
        '
        Me.websiteLinkLabel.AutoSize = True
        Me.websiteLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.websiteLinkLabel.Location = New System.Drawing.Point(12, 49)
        Me.websiteLinkLabel.Name = "websiteLinkLabel"
        Me.websiteLinkLabel.Size = New System.Drawing.Size(89, 14)
        Me.websiteLinkLabel.TabIndex = 1
        Me.websiteLinkLabel.TabStop = True
        Me.websiteLinkLabel.Text = "&Visit my Website!"
        '
        'aboutForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(289, 104)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.websiteLinkLabel)
        Me.Controls.Add(Me.headlineLabel)
        Me.Controls.Add(Me.copyrightLabel)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "aboutForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents headlineLabel As Label
    Friend WithEvents websiteLinkLabel As FixedLinkLabel
    Friend WithEvents copyrightLabel As Label
    Friend WithEvents okButton As Button
End Class
