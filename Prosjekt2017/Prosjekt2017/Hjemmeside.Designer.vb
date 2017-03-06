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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LabelBrukernavn
        '
        Me.LabelBrukernavn.AutoSize = True
        Me.LabelBrukernavn.Location = New System.Drawing.Point(102, 83)
        Me.LabelBrukernavn.Name = "LabelBrukernavn"
        Me.LabelBrukernavn.Size = New System.Drawing.Size(81, 17)
        Me.LabelBrukernavn.TabIndex = 0
        Me.LabelBrukernavn.Text = "Brukernavn"
        '
        'LabelPassord
        '
        Me.LabelPassord.AutoSize = True
        Me.LabelPassord.Location = New System.Drawing.Point(102, 125)
        Me.LabelPassord.Name = "LabelPassord"
        Me.LabelPassord.Size = New System.Drawing.Size(60, 17)
        Me.LabelPassord.TabIndex = 1
        Me.LabelPassord.Text = "Passord"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(243, 83)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 22)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(243, 122)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(176, 22)
        Me.TextBox2.TabIndex = 3
        '
        'Hjemmeside
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 431)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LabelPassord)
        Me.Controls.Add(Me.LabelBrukernavn)
        Me.Name = "Hjemmeside"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelBrukernavn As Label
    Friend WithEvents LabelPassord As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
