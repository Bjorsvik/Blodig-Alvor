<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registreringsskjema
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
        Me.lblFornavn = New System.Windows.Forms.Label()
        Me.lblEtternavn = New System.Windows.Forms.Label()
        Me.lblFødselsdato = New System.Windows.Forms.Label()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.lblPostnummer = New System.Windows.Forms.Label()
        Me.lblPoststed = New System.Windows.Forms.Label()
        Me.txtFornavn = New System.Windows.Forms.TextBox()
        Me.txtEtternavn = New System.Windows.Forms.TextBox()
        Me.txtFodselsdato = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.txtPostnummer = New System.Windows.Forms.TextBox()
        Me.btnRegistrer = New System.Windows.Forms.Button()
        Me.txtTlf = New System.Windows.Forms.TextBox()
        Me.lbTlf = New System.Windows.Forms.Label()
        Me.txtPassord = New System.Windows.Forms.TextBox()
        Me.lbPassord = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBekreftPassord = New System.Windows.Forms.TextBox()
        Me.lbPoststed = New System.Windows.Forms.Label()
        Me.lbEpost = New System.Windows.Forms.Label()
        Me.txtEpost = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFornavn
        '
        Me.lblFornavn.AutoSize = True
        Me.lblFornavn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFornavn.Location = New System.Drawing.Point(191, 70)
        Me.lblFornavn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFornavn.Name = "lblFornavn"
        Me.lblFornavn.Size = New System.Drawing.Size(100, 29)
        Me.lblFornavn.TabIndex = 0
        Me.lblFornavn.Text = "Fornavn"
        '
        'lblEtternavn
        '
        Me.lblEtternavn.AutoSize = True
        Me.lblEtternavn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtternavn.Location = New System.Drawing.Point(553, 70)
        Me.lblEtternavn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEtternavn.Name = "lblEtternavn"
        Me.lblEtternavn.Size = New System.Drawing.Size(113, 29)
        Me.lblEtternavn.TabIndex = 1
        Me.lblEtternavn.Text = "Etternavn"
        '
        'lblFødselsdato
        '
        Me.lblFødselsdato.AutoSize = True
        Me.lblFødselsdato.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFødselsdato.Location = New System.Drawing.Point(173, 126)
        Me.lblFødselsdato.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFødselsdato.Name = "lblFødselsdato"
        Me.lblFødselsdato.Size = New System.Drawing.Size(147, 29)
        Me.lblFødselsdato.TabIndex = 2
        Me.lblFødselsdato.Text = "Fødslesdato"
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdresse.Location = New System.Drawing.Point(217, 199)
        Me.lblAdresse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(102, 29)
        Me.lblAdresse.TabIndex = 3
        Me.lblAdresse.Text = "Adresse"
        '
        'lblPostnummer
        '
        Me.lblPostnummer.AutoSize = True
        Me.lblPostnummer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostnummer.Location = New System.Drawing.Point(173, 244)
        Me.lblPostnummer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPostnummer.Name = "lblPostnummer"
        Me.lblPostnummer.Size = New System.Drawing.Size(149, 29)
        Me.lblPostnummer.TabIndex = 4
        Me.lblPostnummer.Text = "Postnummer"
        '
        'lblPoststed
        '
        Me.lblPoststed.AutoSize = True
        Me.lblPoststed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoststed.Location = New System.Drawing.Point(216, 289)
        Me.lblPoststed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPoststed.Name = "lblPoststed"
        Me.lblPoststed.Size = New System.Drawing.Size(107, 29)
        Me.lblPoststed.TabIndex = 5
        Me.lblPoststed.Text = "Poststed"
        '
        'txtFornavn
        '
        Me.txtFornavn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFornavn.Location = New System.Drawing.Point(360, 75)
        Me.txtFornavn.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFornavn.Name = "txtFornavn"
        Me.txtFornavn.Size = New System.Drawing.Size(132, 30)
        Me.txtFornavn.TabIndex = 6
        '
        'txtEtternavn
        '
        Me.txtEtternavn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEtternavn.Location = New System.Drawing.Point(676, 70)
        Me.txtEtternavn.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEtternavn.Name = "txtEtternavn"
        Me.txtEtternavn.Size = New System.Drawing.Size(132, 30)
        Me.txtEtternavn.TabIndex = 7
        '
        'txtFodselsdato
        '
        Me.txtFodselsdato.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFodselsdato.Location = New System.Drawing.Point(360, 126)
        Me.txtFodselsdato.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFodselsdato.Name = "txtFodselsdato"
        Me.txtFodselsdato.Size = New System.Drawing.Size(132, 30)
        Me.txtFodselsdato.TabIndex = 8
        '
        'txtAdresse
        '
        Me.txtAdresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdresse.Location = New System.Drawing.Point(360, 199)
        Me.txtAdresse.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(132, 30)
        Me.txtAdresse.TabIndex = 9
        '
        'txtPostnummer
        '
        Me.txtPostnummer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostnummer.Location = New System.Drawing.Point(360, 245)
        Me.txtPostnummer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPostnummer.Name = "txtPostnummer"
        Me.txtPostnummer.Size = New System.Drawing.Size(132, 30)
        Me.txtPostnummer.TabIndex = 10
        '
        'btnRegistrer
        '
        Me.btnRegistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrer.Location = New System.Drawing.Point(676, 386)
        Me.btnRegistrer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegistrer.Name = "btnRegistrer"
        Me.btnRegistrer.Size = New System.Drawing.Size(129, 50)
        Me.btnRegistrer.TabIndex = 16
        Me.btnRegistrer.Text = "Registrer"
        Me.btnRegistrer.UseVisualStyleBackColor = True
        '
        'txtTlf
        '
        Me.txtTlf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTlf.Location = New System.Drawing.Point(676, 192)
        Me.txtTlf.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTlf.Name = "txtTlf"
        Me.txtTlf.Size = New System.Drawing.Size(132, 30)
        Me.txtTlf.TabIndex = 11
        '
        'lbTlf
        '
        Me.lbTlf.AutoSize = True
        Me.lbTlf.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTlf.Location = New System.Drawing.Point(569, 194)
        Me.lbTlf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTlf.Name = "lbTlf"
        Me.lbTlf.Size = New System.Drawing.Size(96, 29)
        Me.lbTlf.TabIndex = 14
        Me.lbTlf.Text = "Telefon"
        '
        'txtPassord
        '
        Me.txtPassord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassord.Location = New System.Drawing.Point(360, 362)
        Me.txtPassord.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassord.Name = "txtPassord"
        Me.txtPassord.Size = New System.Drawing.Size(132, 30)
        Me.txtPassord.TabIndex = 14
        '
        'lbPassord
        '
        Me.lbPassord.AutoSize = True
        Me.lbPassord.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPassord.Location = New System.Drawing.Point(248, 366)
        Me.lbPassord.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPassord.Name = "lbPassord"
        Me.lbPassord.Size = New System.Drawing.Size(102, 29)
        Me.lbPassord.TabIndex = 18
        Me.lbPassord.Text = "Passord"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 409)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Bekreft passord"
        '
        'txtBekreftPassord
        '
        Me.txtBekreftPassord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBekreftPassord.Location = New System.Drawing.Point(360, 405)
        Me.txtBekreftPassord.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBekreftPassord.Name = "txtBekreftPassord"
        Me.txtBekreftPassord.Size = New System.Drawing.Size(132, 30)
        Me.txtBekreftPassord.TabIndex = 15
        '
        'lbPoststed
        '
        Me.lbPoststed.AutoSize = True
        Me.lbPoststed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPoststed.Location = New System.Drawing.Point(357, 289)
        Me.lbPoststed.Name = "lbPoststed"
        Me.lbPoststed.Size = New System.Drawing.Size(0, 29)
        Me.lbPoststed.TabIndex = 21
        '
        'lbEpost
        '
        Me.lbEpost.AutoSize = True
        Me.lbEpost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEpost.Location = New System.Drawing.Point(591, 245)
        Me.lbEpost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbEpost.Name = "lbEpost"
        Me.lbEpost.Size = New System.Drawing.Size(75, 29)
        Me.lbEpost.TabIndex = 22
        Me.lbEpost.Text = "Epost"
        '
        'txtEpost
        '
        Me.txtEpost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEpost.Location = New System.Drawing.Point(676, 245)
        Me.txtEpost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEpost.Name = "txtEpost"
        Me.txtEpost.Size = New System.Drawing.Size(132, 30)
        Me.txtEpost.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(367, 161)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "YYYY-MM-DD"
        '
        'Registreringsskjema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 553)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEpost)
        Me.Controls.Add(Me.lbEpost)
        Me.Controls.Add(Me.lbPoststed)
        Me.Controls.Add(Me.txtBekreftPassord)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbPassord)
        Me.Controls.Add(Me.txtPassord)
        Me.Controls.Add(Me.lbTlf)
        Me.Controls.Add(Me.txtTlf)
        Me.Controls.Add(Me.btnRegistrer)
        Me.Controls.Add(Me.txtPostnummer)
        Me.Controls.Add(Me.txtAdresse)
        Me.Controls.Add(Me.txtFodselsdato)
        Me.Controls.Add(Me.txtEtternavn)
        Me.Controls.Add(Me.txtFornavn)
        Me.Controls.Add(Me.lblPoststed)
        Me.Controls.Add(Me.lblPostnummer)
        Me.Controls.Add(Me.lblAdresse)
        Me.Controls.Add(Me.lblFødselsdato)
        Me.Controls.Add(Me.lblEtternavn)
        Me.Controls.Add(Me.lblFornavn)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Registreringsskjema"
        Me.Text = "Registreringsskjema"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFornavn As Label
    Friend WithEvents lblEtternavn As Label
    Friend WithEvents lblFødselsdato As Label
    Friend WithEvents lblAdresse As Label
    Friend WithEvents lblPostnummer As Label
    Friend WithEvents lblPoststed As Label
    Friend WithEvents txtFornavn As TextBox
    Friend WithEvents txtEtternavn As TextBox
    Friend WithEvents txtFodselsdato As TextBox
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents txtPostnummer As TextBox
    Friend WithEvents btnRegistrer As Button
    Friend WithEvents txtTlf As TextBox
    Friend WithEvents lbTlf As Label
    Friend WithEvents txtPassord As TextBox
    Friend WithEvents lbPassord As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBekreftPassord As TextBox
    Friend WithEvents lbPoststed As Label
    Friend WithEvents lbEpost As Label
    Friend WithEvents txtEpost As TextBox
    Friend WithEvents Label2 As Label
End Class
