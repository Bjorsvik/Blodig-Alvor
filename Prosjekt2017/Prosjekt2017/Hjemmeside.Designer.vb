<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hjemmeside
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
        Me.LabelBrukernavn = New System.Windows.Forms.Label()
        Me.LabelPassord = New System.Windows.Forms.Label()
        Me.txtBrukernavn = New System.Windows.Forms.TextBox()
        Me.txtPassord = New System.Windows.Forms.TextBox()
        Me.Logginnknapp = New System.Windows.Forms.Button()
        Me.Registreringsknapp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelBrukernavn
        '
        Me.LabelBrukernavn.AutoSize = True
        Me.LabelBrukernavn.Location = New System.Drawing.Point(156, 86)
        Me.LabelBrukernavn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelBrukernavn.Name = "LabelBrukernavn"
        Me.LabelBrukernavn.Size = New System.Drawing.Size(62, 13)
        Me.LabelBrukernavn.TabIndex = 0
        Me.LabelBrukernavn.Text = "Brukernavn"
        '
        'LabelPassord
        '
        Me.LabelPassord.AutoSize = True
        Me.LabelPassord.Location = New System.Drawing.Point(156, 121)
        Me.LabelPassord.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPassord.Name = "LabelPassord"
        Me.LabelPassord.Size = New System.Drawing.Size(45, 13)
        Me.LabelPassord.TabIndex = 1
        Me.LabelPassord.Text = "Passord"
        '
        'txtBrukernavn
        '
        Me.txtBrukernavn.Location = New System.Drawing.Point(262, 86)
        Me.txtBrukernavn.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBrukernavn.Name = "txtBrukernavn"
        Me.txtBrukernavn.Size = New System.Drawing.Size(133, 20)
        Me.txtBrukernavn.TabIndex = 2
        '
        'txtPassord
        '
        Me.txtPassord.Location = New System.Drawing.Point(262, 118)
        Me.txtPassord.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassord.Name = "txtPassord"
        Me.txtPassord.Size = New System.Drawing.Size(133, 20)
        Me.txtPassord.TabIndex = 3
        '
        'Logginnknapp
        '
        Me.Logginnknapp.Location = New System.Drawing.Point(142, 167)
        Me.Logginnknapp.Margin = New System.Windows.Forms.Padding(2)
        Me.Logginnknapp.Name = "Logginnknapp"
        Me.Logginnknapp.Size = New System.Drawing.Size(132, 32)
        Me.Logginnknapp.TabIndex = 4
        Me.Logginnknapp.Text = "Logg inn"
        Me.Logginnknapp.UseVisualStyleBackColor = True
        '
        'Registreringsknapp
        '
        Me.Registreringsknapp.Location = New System.Drawing.Point(307, 167)
        Me.Registreringsknapp.Margin = New System.Windows.Forms.Padding(2)
        Me.Registreringsknapp.Name = "Registreringsknapp"
        Me.Registreringsknapp.Size = New System.Drawing.Size(97, 32)
        Me.Registreringsknapp.TabIndex = 5
        Me.Registreringsknapp.Text = "Registrer"
        Me.Registreringsknapp.UseVisualStyleBackColor = True
        '
        'Hjemmeside
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 309)
        Me.Controls.Add(Me.Registreringsknapp)
        Me.Controls.Add(Me.Logginnknapp)
        Me.Controls.Add(Me.txtPassord)
        Me.Controls.Add(Me.txtBrukernavn)
        Me.Controls.Add(Me.LabelPassord)
        Me.Controls.Add(Me.LabelBrukernavn)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Hjemmeside"
        Me.Text = "Hjemmeside"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelBrukernavn As Label
    Friend WithEvents LabelPassord As Label
    Friend WithEvents txtBrukernavn As TextBox
    Friend WithEvents txtPassord As TextBox
    Friend WithEvents Logginnknapp As Button
    Friend WithEvents Registreringsknapp As Button
End Class
