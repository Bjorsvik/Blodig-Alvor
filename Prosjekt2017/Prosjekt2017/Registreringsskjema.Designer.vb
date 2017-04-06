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
        Me.lblPersonnummer = New System.Windows.Forms.Label()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.lblPostnummer = New System.Windows.Forms.Label()
        Me.lblPoststed = New System.Windows.Forms.Label()
        Me.txtFornavn = New System.Windows.Forms.TextBox()
        Me.txtEtternavn = New System.Windows.Forms.TextBox()
        Me.txtPersonnummer = New System.Windows.Forms.TextBox()
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
        Me.txtFodselsdato = New System.Windows.Forms.TextBox()
        Me.lbFødselsdato = New System.Windows.Forms.Label()
        Me.lblPostnrFeil = New System.Windows.Forms.Label()
        Me.lblFornavnFeil = New System.Windows.Forms.Label()
        Me.lblEtternavnFeil = New System.Windows.Forms.Label()
        Me.lblAdresseFeil = New System.Windows.Forms.Label()
        Me.lblFodselFeil = New System.Windows.Forms.Label()
        Me.lblPersnrFeil = New System.Windows.Forms.Label()
        Me.lblTelefonFeil = New System.Windows.Forms.Label()
        Me.lblEpostFeil = New System.Windows.Forms.Label()
        Me.lblPwFeil = New System.Windows.Forms.Label()
        Me.lblPw2Feil = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFornavn
        '
        Me.lblFornavn.AutoSize = True
        Me.lblFornavn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFornavn.Location = New System.Drawing.Point(164, 70)
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
        Me.lblEtternavn.Location = New System.Drawing.Point(152, 118)
        Me.lblEtternavn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEtternavn.Name = "lblEtternavn"
        Me.lblEtternavn.Size = New System.Drawing.Size(113, 29)
        Me.lblEtternavn.TabIndex = 1
        Me.lblEtternavn.Text = "Etternavn"
        '
        'lblPersonnummer
        '
        Me.lblPersonnummer.AutoSize = True
        Me.lblPersonnummer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonnummer.Location = New System.Drawing.Point(480, 118)
        Me.lblPersonnummer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPersonnummer.Name = "lblPersonnummer"
        Me.lblPersonnummer.Size = New System.Drawing.Size(178, 29)
        Me.lblPersonnummer.TabIndex = 2
        Me.lblPersonnummer.Text = "Personnummer"
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdresse.Location = New System.Drawing.Point(145, 196)
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
        Me.lblPostnummer.Location = New System.Drawing.Point(96, 247)
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
        Me.lblPoststed.Location = New System.Drawing.Point(144, 297)
        Me.lblPoststed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPoststed.Name = "lblPoststed"
        Me.lblPoststed.Size = New System.Drawing.Size(107, 29)
        Me.lblPoststed.TabIndex = 5
        Me.lblPoststed.Text = "Poststed"
        '
        'txtFornavn
        '
        Me.txtFornavn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFornavn.Location = New System.Drawing.Point(279, 70)
        Me.txtFornavn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFornavn.Name = "txtFornavn"
        Me.txtFornavn.Size = New System.Drawing.Size(132, 30)
        Me.txtFornavn.TabIndex = 1
        '
        'txtEtternavn
        '
        Me.txtEtternavn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEtternavn.Location = New System.Drawing.Point(279, 116)
        Me.txtEtternavn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEtternavn.Name = "txtEtternavn"
        Me.txtEtternavn.Size = New System.Drawing.Size(132, 30)
        Me.txtEtternavn.TabIndex = 2
        '
        'txtPersonnummer
        '
        Me.txtPersonnummer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPersonnummer.Location = New System.Drawing.Point(676, 118)
        Me.txtPersonnummer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPersonnummer.Name = "txtPersonnummer"
        Me.txtPersonnummer.Size = New System.Drawing.Size(132, 30)
        Me.txtPersonnummer.TabIndex = 6
        '
        'txtAdresse
        '
        Me.txtAdresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdresse.Location = New System.Drawing.Point(277, 196)
        Me.txtAdresse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(132, 30)
        Me.txtAdresse.TabIndex = 3
        '
        'txtPostnummer
        '
        Me.txtPostnummer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostnummer.Location = New System.Drawing.Point(277, 247)
        Me.txtPostnummer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPostnummer.Name = "txtPostnummer"
        Me.txtPostnummer.Size = New System.Drawing.Size(132, 30)
        Me.txtPostnummer.TabIndex = 4
        '
        'btnRegistrer
        '
        Me.btnRegistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrer.Location = New System.Drawing.Point(661, 418)
        Me.btnRegistrer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRegistrer.Name = "btnRegistrer"
        Me.btnRegistrer.Size = New System.Drawing.Size(129, 50)
        Me.btnRegistrer.TabIndex = 11
        Me.btnRegistrer.Text = "Registrer"
        Me.btnRegistrer.UseVisualStyleBackColor = True
        '
        'txtTlf
        '
        Me.txtTlf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTlf.Location = New System.Drawing.Point(676, 194)
        Me.txtTlf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTlf.Name = "txtTlf"
        Me.txtTlf.Size = New System.Drawing.Size(132, 30)
        Me.txtTlf.TabIndex = 7
        '
        'lbTlf
        '
        Me.lbTlf.AutoSize = True
        Me.lbTlf.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTlf.Location = New System.Drawing.Point(569, 197)
        Me.lbTlf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTlf.Name = "lbTlf"
        Me.lbTlf.Size = New System.Drawing.Size(96, 29)
        Me.lbTlf.TabIndex = 14
        Me.lbTlf.Text = "Telefon"
        '
        'txtPassord
        '
        Me.txtPassord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassord.Location = New System.Drawing.Point(417, 415)
        Me.txtPassord.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPassord.Name = "txtPassord"
        Me.txtPassord.Size = New System.Drawing.Size(132, 30)
        Me.txtPassord.TabIndex = 9
        '
        'lbPassord
        '
        Me.lbPassord.AutoSize = True
        Me.lbPassord.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPassord.Location = New System.Drawing.Point(305, 418)
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
        Me.Label1.Location = New System.Drawing.Point(224, 462)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Bekreft passord"
        '
        'txtBekreftPassord
        '
        Me.txtBekreftPassord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBekreftPassord.Location = New System.Drawing.Point(417, 458)
        Me.txtBekreftPassord.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBekreftPassord.Name = "txtBekreftPassord"
        Me.txtBekreftPassord.Size = New System.Drawing.Size(132, 30)
        Me.txtBekreftPassord.TabIndex = 10
        '
        'lbPoststed
        '
        Me.lbPoststed.AutoSize = True
        Me.lbPoststed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPoststed.Location = New System.Drawing.Point(272, 297)
        Me.lbPoststed.Name = "lbPoststed"
        Me.lbPoststed.Size = New System.Drawing.Size(0, 29)
        Me.lbPoststed.TabIndex = 21
        '
        'lbEpost
        '
        Me.lbEpost.AutoSize = True
        Me.lbEpost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEpost.Location = New System.Drawing.Point(591, 247)
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
        Me.txtEpost.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEpost.Name = "txtEpost"
        Me.txtEpost.Size = New System.Drawing.Size(132, 30)
        Me.txtEpost.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(817, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Eks.  1995-03-25"
        '
        'txtFodselsdato
        '
        Me.txtFodselsdato.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFodselsdato.Location = New System.Drawing.Point(676, 68)
        Me.txtFodselsdato.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFodselsdato.Name = "txtFodselsdato"
        Me.txtFodselsdato.Size = New System.Drawing.Size(132, 30)
        Me.txtFodselsdato.TabIndex = 5
        '
        'lbFødselsdato
        '
        Me.lbFødselsdato.AutoSize = True
        Me.lbFødselsdato.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFødselsdato.Location = New System.Drawing.Point(517, 70)
        Me.lbFødselsdato.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbFødselsdato.Name = "lbFødselsdato"
        Me.lbFødselsdato.Size = New System.Drawing.Size(147, 29)
        Me.lbFødselsdato.TabIndex = 26
        Me.lbFødselsdato.Text = "Fødselsdato"
        '
        'lblPostnrFeil
        '
        Me.lblPostnrFeil.AutoSize = True
        Me.lblPostnrFeil.Location = New System.Drawing.Point(414, 260)
        Me.lblPostnrFeil.Name = "lblPostnrFeil"
        Me.lblPostnrFeil.Size = New System.Drawing.Size(85, 17)
        Me.lblPostnrFeil.TabIndex = 27
        Me.lblPostnrFeil.Text = "lblPostnrFeil"
        '
        'lblFornavnFeil
        '
        Me.lblFornavnFeil.AutoSize = True
        Me.lblFornavnFeil.Location = New System.Drawing.Point(418, 83)
        Me.lblFornavnFeil.Name = "lblFornavnFeil"
        Me.lblFornavnFeil.Size = New System.Drawing.Size(96, 17)
        Me.lblFornavnFeil.TabIndex = 28
        Me.lblFornavnFeil.Text = "lblFornavnFeil"
        '
        'lblEtternavnFeil
        '
        Me.lblEtternavnFeil.AutoSize = True
        Me.lblEtternavnFeil.Location = New System.Drawing.Point(276, 150)
        Me.lblEtternavnFeil.Name = "lblEtternavnFeil"
        Me.lblEtternavnFeil.Size = New System.Drawing.Size(105, 17)
        Me.lblEtternavnFeil.TabIndex = 29
        Me.lblEtternavnFeil.Text = "lblEtternavnFeil"
        '
        'lblAdresseFeil
        '
        Me.lblAdresseFeil.AutoSize = True
        Me.lblAdresseFeil.Location = New System.Drawing.Point(414, 208)
        Me.lblAdresseFeil.Name = "lblAdresseFeil"
        Me.lblAdresseFeil.Size = New System.Drawing.Size(96, 17)
        Me.lblAdresseFeil.TabIndex = 30
        Me.lblAdresseFeil.Text = "lblAdresseFeil"
        '
        'lblFodselFeil
        '
        Me.lblFodselFeil.AutoSize = True
        Me.lblFodselFeil.Location = New System.Drawing.Point(718, 37)
        Me.lblFodselFeil.Name = "lblFodselFeil"
        Me.lblFodselFeil.Size = New System.Drawing.Size(86, 17)
        Me.lblFodselFeil.TabIndex = 31
        Me.lblFodselFeil.Text = "lblFodselFeil"
        '
        'lblPersnrFeil
        '
        Me.lblPersnrFeil.AutoSize = True
        Me.lblPersnrFeil.Location = New System.Drawing.Point(815, 131)
        Me.lblPersnrFeil.Name = "lblPersnrFeil"
        Me.lblPersnrFeil.Size = New System.Drawing.Size(86, 17)
        Me.lblPersnrFeil.TabIndex = 32
        Me.lblPersnrFeil.Text = "lblPersnrFeil"
        '
        'lblTelefonFeil
        '
        Me.lblTelefonFeil.AutoSize = True
        Me.lblTelefonFeil.Location = New System.Drawing.Point(818, 209)
        Me.lblTelefonFeil.Name = "lblTelefonFeil"
        Me.lblTelefonFeil.Size = New System.Drawing.Size(92, 17)
        Me.lblTelefonFeil.TabIndex = 33
        Me.lblTelefonFeil.Text = "lblTelefonFeil"
        '
        'lblEpostFeil
        '
        Me.lblEpostFeil.AutoSize = True
        Me.lblEpostFeil.Location = New System.Drawing.Point(818, 260)
        Me.lblEpostFeil.Name = "lblEpostFeil"
        Me.lblEpostFeil.Size = New System.Drawing.Size(80, 17)
        Me.lblEpostFeil.TabIndex = 34
        Me.lblEpostFeil.Text = "lblEpostFeil"
        '
        'lblPwFeil
        '
        Me.lblPwFeil.AutoSize = True
        Me.lblPwFeil.Location = New System.Drawing.Point(556, 425)
        Me.lblPwFeil.Name = "lblPwFeil"
        Me.lblPwFeil.Size = New System.Drawing.Size(62, 17)
        Me.lblPwFeil.TabIndex = 35
        Me.lblPwFeil.Text = "lblPwFeil"
        '
        'lblPw2Feil
        '
        Me.lblPw2Feil.AutoSize = True
        Me.lblPw2Feil.Location = New System.Drawing.Point(556, 472)
        Me.lblPw2Feil.Name = "lblPw2Feil"
        Me.lblPw2Feil.Size = New System.Drawing.Size(70, 17)
        Me.lblPw2Feil.TabIndex = 36
        Me.lblPw2Feil.Text = "lblPw2Feil"
        '
        'Registreringsskjema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 553)
        Me.Controls.Add(Me.lblPw2Feil)
        Me.Controls.Add(Me.lblPwFeil)
        Me.Controls.Add(Me.lblEpostFeil)
        Me.Controls.Add(Me.lblTelefonFeil)
        Me.Controls.Add(Me.lblPersnrFeil)
        Me.Controls.Add(Me.lblFodselFeil)
        Me.Controls.Add(Me.lblAdresseFeil)
        Me.Controls.Add(Me.lblEtternavnFeil)
        Me.Controls.Add(Me.lblFornavnFeil)
        Me.Controls.Add(Me.lblPostnrFeil)
        Me.Controls.Add(Me.lbFødselsdato)
        Me.Controls.Add(Me.txtFodselsdato)
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
        Me.Controls.Add(Me.txtPersonnummer)
        Me.Controls.Add(Me.txtEtternavn)
        Me.Controls.Add(Me.txtFornavn)
        Me.Controls.Add(Me.lblPoststed)
        Me.Controls.Add(Me.lblPostnummer)
        Me.Controls.Add(Me.lblAdresse)
        Me.Controls.Add(Me.lblPersonnummer)
        Me.Controls.Add(Me.lblEtternavn)
        Me.Controls.Add(Me.lblFornavn)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Registreringsskjema"
        Me.Text = "Registreringsskjema"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFornavn As Label
    Friend WithEvents lblEtternavn As Label
    Friend WithEvents lblPersonnummer As Label
    Friend WithEvents lblAdresse As Label
    Friend WithEvents lblPostnummer As Label
    Friend WithEvents lblPoststed As Label
    Friend WithEvents txtFornavn As TextBox
    Friend WithEvents txtEtternavn As TextBox
    Friend WithEvents txtPersonnummer As TextBox
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
    Friend WithEvents txtFodselsdato As TextBox
    Friend WithEvents lbFødselsdato As Label
    Friend WithEvents lblPostnrFeil As Label
    Friend WithEvents lblFornavnFeil As Label
    Friend WithEvents lblEtternavnFeil As Label
    Friend WithEvents lblAdresseFeil As Label
    Friend WithEvents lblFodselFeil As Label
    Friend WithEvents lblPersnrFeil As Label
    Friend WithEvents lblTelefonFeil As Label
    Friend WithEvents lblEpostFeil As Label
    Friend WithEvents lblPwFeil As Label
    Friend WithEvents lblPw2Feil As Label
End Class
