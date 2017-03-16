<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class minside
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
        Me.lbFornavn = New System.Windows.Forms.Label()
        Me.lbEtternavn = New System.Windows.Forms.Label()
        Me.lbFodselsdato = New System.Windows.Forms.Label()
        Me.lbTelefon = New System.Windows.Forms.Label()
        Me.lbAdresse = New System.Windows.Forms.Label()
        Me.lbPostnummer = New System.Windows.Forms.Label()
        Me.lbPoststed = New System.Windows.Forms.Label()
        Me.lbEpost = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabBrukerinfo = New System.Windows.Forms.TabPage()
        Me.tabHistorikk = New System.Windows.Forms.TabPage()
        Me.tabReservasjon = New System.Windows.Forms.TabPage()
        Me.btnSkjema = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabBrukerinfo.SuspendLayout()
        Me.tabReservasjon.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbFornavn
        '
        Me.lbFornavn.AutoSize = True
        Me.lbFornavn.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFornavn.Location = New System.Drawing.Point(411, 94)
        Me.lbFornavn.Name = "lbFornavn"
        Me.lbFornavn.Size = New System.Drawing.Size(82, 26)
        Me.lbFornavn.TabIndex = 4
        Me.lbFornavn.Text = "Fornavn"
        '
        'lbEtternavn
        '
        Me.lbEtternavn.AutoSize = True
        Me.lbEtternavn.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEtternavn.Location = New System.Drawing.Point(411, 127)
        Me.lbEtternavn.Name = "lbEtternavn"
        Me.lbEtternavn.Size = New System.Drawing.Size(98, 26)
        Me.lbEtternavn.TabIndex = 5
        Me.lbEtternavn.Text = "Etternavn"
        '
        'lbFodselsdato
        '
        Me.lbFodselsdato.AutoSize = True
        Me.lbFodselsdato.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFodselsdato.Location = New System.Drawing.Point(411, 157)
        Me.lbFodselsdato.Name = "lbFodselsdato"
        Me.lbFodselsdato.Size = New System.Drawing.Size(117, 26)
        Me.lbFodselsdato.TabIndex = 6
        Me.lbFodselsdato.Text = "Fodselsdato"
        '
        'lbTelefon
        '
        Me.lbTelefon.AutoSize = True
        Me.lbTelefon.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTelefon.Location = New System.Drawing.Point(411, 208)
        Me.lbTelefon.Name = "lbTelefon"
        Me.lbTelefon.Size = New System.Drawing.Size(80, 26)
        Me.lbTelefon.TabIndex = 7
        Me.lbTelefon.Text = "Telefon"
        '
        'lbAdresse
        '
        Me.lbAdresse.AutoSize = True
        Me.lbAdresse.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAdresse.Location = New System.Drawing.Point(410, 235)
        Me.lbAdresse.Name = "lbAdresse"
        Me.lbAdresse.Size = New System.Drawing.Size(83, 26)
        Me.lbAdresse.TabIndex = 8
        Me.lbAdresse.Text = "Adresse"
        '
        'lbPostnummer
        '
        Me.lbPostnummer.AutoSize = True
        Me.lbPostnummer.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPostnummer.Location = New System.Drawing.Point(410, 263)
        Me.lbPostnummer.Name = "lbPostnummer"
        Me.lbPostnummer.Size = New System.Drawing.Size(118, 26)
        Me.lbPostnummer.TabIndex = 9
        Me.lbPostnummer.Text = "Postnummer"
        '
        'lbPoststed
        '
        Me.lbPoststed.AutoSize = True
        Me.lbPoststed.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPoststed.Location = New System.Drawing.Point(410, 292)
        Me.lbPoststed.Name = "lbPoststed"
        Me.lbPoststed.Size = New System.Drawing.Size(87, 26)
        Me.lbPoststed.TabIndex = 10
        Me.lbPoststed.Text = "Poststed"
        '
        'lbEpost
        '
        Me.lbEpost.AutoSize = True
        Me.lbEpost.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEpost.Location = New System.Drawing.Point(411, 184)
        Me.lbEpost.Name = "lbEpost"
        Me.lbEpost.Size = New System.Drawing.Size(61, 26)
        Me.lbEpost.TabIndex = 11
        Me.lbEpost.Text = "Epost"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(319, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 26)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Epost:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(291, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 26)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Poststed:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(260, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 26)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Postnummer:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(295, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 26)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Adresse:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(298, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 26)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Telefon:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(263, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 26)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Fodselsdato:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(282, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 26)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Etternavn:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(298, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 26)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Fornavn:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabBrukerinfo)
        Me.TabControl1.Controls.Add(Me.tabHistorikk)
        Me.TabControl1.Controls.Add(Me.tabReservasjon)
        Me.TabControl1.Location = New System.Drawing.Point(0, 12)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(794, 445)
        Me.TabControl1.TabIndex = 20
        '
        'tabBrukerinfo
        '
        Me.tabBrukerinfo.Controls.Add(Me.Label1)
        Me.tabBrukerinfo.Controls.Add(Me.Label7)
        Me.tabBrukerinfo.Controls.Add(Me.lbTelefon)
        Me.tabBrukerinfo.Controls.Add(Me.Label4)
        Me.tabBrukerinfo.Controls.Add(Me.Label8)
        Me.tabBrukerinfo.Controls.Add(Me.lbPostnummer)
        Me.tabBrukerinfo.Controls.Add(Me.lbEtternavn)
        Me.tabBrukerinfo.Controls.Add(Me.lbFornavn)
        Me.tabBrukerinfo.Controls.Add(Me.Label3)
        Me.tabBrukerinfo.Controls.Add(Me.lbAdresse)
        Me.tabBrukerinfo.Controls.Add(Me.lbPoststed)
        Me.tabBrukerinfo.Controls.Add(Me.lbEpost)
        Me.tabBrukerinfo.Controls.Add(Me.lbFodselsdato)
        Me.tabBrukerinfo.Controls.Add(Me.Label5)
        Me.tabBrukerinfo.Controls.Add(Me.Label2)
        Me.tabBrukerinfo.Controls.Add(Me.Label6)
        Me.tabBrukerinfo.Location = New System.Drawing.Point(4, 22)
        Me.tabBrukerinfo.Name = "tabBrukerinfo"
        Me.tabBrukerinfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBrukerinfo.Size = New System.Drawing.Size(786, 419)
        Me.tabBrukerinfo.TabIndex = 0
        Me.tabBrukerinfo.Text = "Brukerinfo"
        Me.tabBrukerinfo.UseVisualStyleBackColor = True
        '
        'tabHistorikk
        '
        Me.tabHistorikk.Location = New System.Drawing.Point(4, 22)
        Me.tabHistorikk.Name = "tabHistorikk"
        Me.tabHistorikk.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHistorikk.Size = New System.Drawing.Size(786, 419)
        Me.tabHistorikk.TabIndex = 1
        Me.tabHistorikk.Text = "Min Historikk"
        Me.tabHistorikk.UseVisualStyleBackColor = True
        '
        'tabReservasjon
        '
        Me.tabReservasjon.Controls.Add(Me.Button1)
        Me.tabReservasjon.Controls.Add(Me.btnSkjema)
        Me.tabReservasjon.Location = New System.Drawing.Point(4, 22)
        Me.tabReservasjon.Name = "tabReservasjon"
        Me.tabReservasjon.Padding = New System.Windows.Forms.Padding(3)
        Me.tabReservasjon.Size = New System.Drawing.Size(786, 419)
        Me.tabReservasjon.TabIndex = 2
        Me.tabReservasjon.Text = "Reserver Time"
        Me.tabReservasjon.UseVisualStyleBackColor = True
        '
        'btnSkjema
        '
        Me.btnSkjema.Location = New System.Drawing.Point(653, 356)
        Me.btnSkjema.Name = "btnSkjema"
        Me.btnSkjema.Size = New System.Drawing.Size(101, 44)
        Me.btnSkjema.TabIndex = 0
        Me.btnSkjema.Text = "Egenerklæring"
        Me.btnSkjema.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(525, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 43)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Reserver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'minside
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(800, 476)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "minside"
        Me.Text = "minside"
        Me.TabControl1.ResumeLayout(False)
        Me.tabBrukerinfo.ResumeLayout(False)
        Me.tabBrukerinfo.PerformLayout()
        Me.tabReservasjon.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbFornavn As Label
    Friend WithEvents lbEtternavn As Label
    Friend WithEvents lbFodselsdato As Label
    Friend WithEvents lbTelefon As Label
    Friend WithEvents lbAdresse As Label
    Friend WithEvents lbPostnummer As Label
    Friend WithEvents lbPoststed As Label
    Friend WithEvents lbEpost As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabBrukerinfo As TabPage
    Friend WithEvents tabHistorikk As TabPage
    Friend WithEvents tabReservasjon As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSkjema As Button
End Class
