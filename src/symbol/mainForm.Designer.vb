<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.unicodeInput = New System.Windows.Forms.TextBox()
        Me.prefixLabel = New System.Windows.Forms.Label()
        Me.characterPreview = New System.Windows.Forms.Label()
        Me.copyButton = New System.Windows.Forms.Button()
        Me.aboutButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'unicodeInput
        '
        Me.unicodeInput.Location = New System.Drawing.Point(28, 13)
        Me.unicodeInput.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.unicodeInput.Name = "unicodeInput"
        Me.unicodeInput.Size = New System.Drawing.Size(329, 20)
        Me.unicodeInput.TabIndex = 0
        '
        'prefixLabel
        '
        Me.prefixLabel.AutoSize = True
        Me.prefixLabel.Location = New System.Drawing.Point(8, 16)
        Me.prefixLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.prefixLabel.Name = "prefixLabel"
        Me.prefixLabel.Size = New System.Drawing.Size(16, 14)
        Me.prefixLabel.TabIndex = 1
        Me.prefixLabel.Text = "\u"
        '
        'characterPreview
        '
        Me.characterPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.characterPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.characterPreview.Location = New System.Drawing.Point(11, 38)
        Me.characterPreview.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.characterPreview.Name = "characterPreview"
        Me.characterPreview.Size = New System.Drawing.Size(346, 16)
        Me.characterPreview.TabIndex = 2
        Me.characterPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'copyButton
        '
        Me.copyButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.copyButton.Location = New System.Drawing.Point(12, 57)
        Me.copyButton.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.copyButton.Name = "copyButton"
        Me.copyButton.Size = New System.Drawing.Size(74, 25)
        Me.copyButton.TabIndex = 3
        Me.copyButton.Text = "&Copy"
        Me.copyButton.UseVisualStyleBackColor = True
        '
        'aboutButton
        '
        Me.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.aboutButton.Location = New System.Drawing.Point(90, 57)
        Me.aboutButton.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.aboutButton.Name = "aboutButton"
        Me.aboutButton.Size = New System.Drawing.Size(74, 25)
        Me.aboutButton.TabIndex = 4
        Me.aboutButton.Text = "&About"
        Me.aboutButton.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(368, 88)
        Me.Controls.Add(Me.aboutButton)
        Me.Controls.Add(Me.copyButton)
        Me.Controls.Add(Me.characterPreview)
        Me.Controls.Add(Me.prefixLabel)
        Me.Controls.Add(Me.unicodeInput)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.Name = "mainForm"
        Me.Text = "Symbol"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents unicodeInput As TextBox
    Friend WithEvents prefixLabel As Label
    Friend WithEvents characterPreview As Label
    Friend WithEvents copyButton As Button
    Friend WithEvents aboutButton As Button
End Class
