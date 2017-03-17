<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hjemmeside
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbTelefon = New System.Windows.Forms.Label()
        Me.lbPassord = New System.Windows.Forms.Label()
        Me.txtTelefon = New System.Windows.Forms.TextBox()
        Me.txtPassord = New System.Windows.Forms.TextBox()
        Me.btnLogginn = New System.Windows.Forms.Button()
        Me.btnRegistrer = New System.Windows.Forms.Button()
        Me.btnBlodgiver = New System.Windows.Forms.Button()
        Me.btnAnsatt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbTelefon
        '
        Me.lbTelefon.AutoSize = True
        Me.lbTelefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTelefon.Location = New System.Drawing.Point(310, 125)
        Me.lbTelefon.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTelefon.Name = "lbTelefon"
        Me.lbTelefon.Size = New System.Drawing.Size(84, 25)
        Me.lbTelefon.TabIndex = 0
        Me.lbTelefon.Text = "Telefon"
        '
        'lbPassord
        '
        Me.lbPassord.AutoSize = True
        Me.lbPassord.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPassord.Location = New System.Drawing.Point(310, 165)
        Me.lbPassord.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbPassord.Name = "lbPassord"
        Me.lbPassord.Size = New System.Drawing.Size(91, 25)
        Me.lbPassord.TabIndex = 1
        Me.lbPassord.Text = "Passord"
        '
        'txtTelefon
        '
        Me.txtTelefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefon.Location = New System.Drawing.Point(423, 122)
        Me.txtTelefon.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(133, 31)
        Me.txtTelefon.TabIndex = 2
        '
        'txtPassord
        '
        Me.txtPassord.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassord.Location = New System.Drawing.Point(423, 162)
        Me.txtPassord.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassord.Name = "txtPassord"
        Me.txtPassord.Size = New System.Drawing.Size(133, 31)
        Me.txtPassord.TabIndex = 3
        '
        'btnLogginn
        '
        Me.btnLogginn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogginn.Location = New System.Drawing.Point(205, 245)
        Me.btnLogginn.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogginn.Name = "btnLogginn"
        Me.btnLogginn.Size = New System.Drawing.Size(144, 77)
        Me.btnLogginn.TabIndex = 4
        Me.btnLogginn.Text = "Logg inn"
        Me.btnLogginn.UseVisualStyleBackColor = True
        '
        'btnRegistrer
        '
        Me.btnRegistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrer.Location = New System.Drawing.Point(442, 246)
        Me.btnRegistrer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegistrer.Name = "btnRegistrer"
        Me.btnRegistrer.Size = New System.Drawing.Size(137, 76)
        Me.btnRegistrer.TabIndex = 5
        Me.btnRegistrer.Text = "Registrer"
        Me.btnRegistrer.UseVisualStyleBackColor = True
        '
        'btnBlodgiver
        '
        Me.btnBlodgiver.Location = New System.Drawing.Point(205, 150)
        Me.btnBlodgiver.Name = "btnBlodgiver"
        Me.btnBlodgiver.Size = New System.Drawing.Size(176, 137)
        Me.btnBlodgiver.TabIndex = 6
        Me.btnBlodgiver.Text = "Blodgiver"
        Me.btnBlodgiver.UseVisualStyleBackColor = True
        '
        'btnAnsatt
        '
        Me.btnAnsatt.Location = New System.Drawing.Point(423, 150)
        Me.btnAnsatt.Name = "btnAnsatt"
        Me.btnAnsatt.Size = New System.Drawing.Size(176, 137)
        Me.btnAnsatt.TabIndex = 7
        Me.btnAnsatt.Text = "Ansatt"
        Me.btnAnsatt.UseVisualStyleBackColor = True
        '
        'Hjemmeside
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 462)
        Me.Controls.Add(Me.btnAnsatt)
        Me.Controls.Add(Me.btnBlodgiver)
        Me.Controls.Add(Me.btnRegistrer)
        Me.Controls.Add(Me.btnLogginn)
        Me.Controls.Add(Me.txtPassord)
        Me.Controls.Add(Me.txtTelefon)
        Me.Controls.Add(Me.lbPassord)
        Me.Controls.Add(Me.lbTelefon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Hjemmeside"
        Me.Text = "Hjemmeside"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbTelefon As Label
    Friend WithEvents lbPassord As Label
    Friend WithEvents txtTelefon As TextBox
    Friend WithEvents txtPassord As TextBox
    Friend WithEvents btnLogginn As Button
    Friend WithEvents btnRegistrer As Button
    Friend WithEvents btnBlodgiver As Button
    Friend WithEvents btnAnsatt As Button
End Class
