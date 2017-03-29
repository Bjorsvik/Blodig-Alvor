<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class minside
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabBrukerinfo = New System.Windows.Forms.TabPage()
        Me.lbPoststed = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEndreInfo = New System.Windows.Forms.Button()
        Me.txtPostnummer = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.lbPoststedLabel = New System.Windows.Forms.Label()
        Me.txtFodselsdato = New System.Windows.Forms.TextBox()
        Me.lbPostnummer = New System.Windows.Forms.Label()
        Me.lbAdresse = New System.Windows.Forms.Label()
        Me.lbFodselsdato = New System.Windows.Forms.Label()
        Me.lbTelefon = New System.Windows.Forms.Label()
        Me.lbEtternavn = New System.Windows.Forms.Label()
        Me.lbFornavn = New System.Windows.Forms.Label()
        Me.txtTelefon = New System.Windows.Forms.TextBox()
        Me.txtEtternavn = New System.Windows.Forms.TextBox()
        Me.txtFornavn = New System.Windows.Forms.TextBox()
        Me.tabHistorikk = New System.Windows.Forms.TabPage()
        Me.tabReservasjon = New System.Windows.Forms.TabPage()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSkjema = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabBrukerinfo.SuspendLayout()
        Me.tabReservasjon.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabBrukerinfo)
        Me.TabControl1.Controls.Add(Me.tabHistorikk)
        Me.TabControl1.Controls.Add(Me.tabReservasjon)
        Me.TabControl1.Location = New System.Drawing.Point(0, 15)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1059, 548)
        Me.TabControl1.TabIndex = 20
        '
        'tabBrukerinfo
        '
        Me.tabBrukerinfo.Controls.Add(Me.lbPoststed)
        Me.tabBrukerinfo.Controls.Add(Me.Label1)
        Me.tabBrukerinfo.Controls.Add(Me.btnEndreInfo)
        Me.tabBrukerinfo.Controls.Add(Me.txtPostnummer)
        Me.tabBrukerinfo.Controls.Add(Me.txtAdresse)
        Me.tabBrukerinfo.Controls.Add(Me.lbPoststedLabel)
        Me.tabBrukerinfo.Controls.Add(Me.txtFodselsdato)
        Me.tabBrukerinfo.Controls.Add(Me.lbPostnummer)
        Me.tabBrukerinfo.Controls.Add(Me.lbAdresse)
        Me.tabBrukerinfo.Controls.Add(Me.lbFodselsdato)
        Me.tabBrukerinfo.Controls.Add(Me.lbTelefon)
        Me.tabBrukerinfo.Controls.Add(Me.lbEtternavn)
        Me.tabBrukerinfo.Controls.Add(Me.lbFornavn)
        Me.tabBrukerinfo.Controls.Add(Me.txtTelefon)
        Me.tabBrukerinfo.Controls.Add(Me.txtEtternavn)
        Me.tabBrukerinfo.Controls.Add(Me.txtFornavn)
        Me.tabBrukerinfo.Location = New System.Drawing.Point(4, 25)
        Me.tabBrukerinfo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabBrukerinfo.Name = "tabBrukerinfo"
        Me.tabBrukerinfo.Size = New System.Drawing.Size(1051, 519)
        Me.tabBrukerinfo.TabIndex = 0
        Me.tabBrukerinfo.Text = "Brukerinfo"
        Me.tabBrukerinfo.UseVisualStyleBackColor = True
        '
        'lbPoststed
        '
        Me.lbPoststed.AutoSize = True
        Me.lbPoststed.Location = New System.Drawing.Point(679, 256)
        Me.lbPoststed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPoststed.Name = "lbPoststed"
        Me.lbPoststed.Size = New System.Drawing.Size(51, 17)
        Me.lbPoststed.TabIndex = 16
        Me.lbPoststed.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 42)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Personalia"
        '
        'btnEndreInfo
        '
        Me.btnEndreInfo.Location = New System.Drawing.Point(703, 299)
        Me.btnEndreInfo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEndreInfo.Name = "btnEndreInfo"
        Me.btnEndreInfo.Size = New System.Drawing.Size(109, 32)
        Me.btnEndreInfo.TabIndex = 14
        Me.btnEndreInfo.Text = "Endre info"
        Me.btnEndreInfo.UseVisualStyleBackColor = True
        '
        'txtPostnummer
        '
        Me.txtPostnummer.Location = New System.Drawing.Point(679, 203)
        Me.txtPostnummer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPostnummer.Name = "txtPostnummer"
        Me.txtPostnummer.Size = New System.Drawing.Size(132, 22)
        Me.txtPostnummer.TabIndex = 12
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(679, 151)
        Me.txtAdresse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(196, 22)
        Me.txtAdresse.TabIndex = 11
        '
        'lbPoststedLabel
        '
        Me.lbPoststedLabel.AutoSize = True
        Me.lbPoststedLabel.Location = New System.Drawing.Point(607, 254)
        Me.lbPoststedLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPoststedLabel.Name = "lbPoststedLabel"
        Me.lbPoststedLabel.Size = New System.Drawing.Size(63, 17)
        Me.lbPoststedLabel.TabIndex = 10
        Me.lbPoststedLabel.Text = "Poststed"
        '
        'txtFodselsdato
        '
        Me.txtFodselsdato.Location = New System.Drawing.Point(292, 254)
        Me.txtFodselsdato.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFodselsdato.Name = "txtFodselsdato"
        Me.txtFodselsdato.Size = New System.Drawing.Size(132, 22)
        Me.txtFodselsdato.TabIndex = 9
        '
        'lbPostnummer
        '
        Me.lbPostnummer.AutoSize = True
        Me.lbPostnummer.Location = New System.Drawing.Point(584, 207)
        Me.lbPostnummer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPostnummer.Name = "lbPostnummer"
        Me.lbPostnummer.Size = New System.Drawing.Size(87, 17)
        Me.lbPostnummer.TabIndex = 8
        Me.lbPostnummer.Text = "Postnummer"
        '
        'lbAdresse
        '
        Me.lbAdresse.AutoSize = True
        Me.lbAdresse.Location = New System.Drawing.Point(611, 156)
        Me.lbAdresse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbAdresse.Name = "lbAdresse"
        Me.lbAdresse.Size = New System.Drawing.Size(60, 17)
        Me.lbAdresse.TabIndex = 7
        Me.lbAdresse.Text = "Adresse"
        '
        'lbFodselsdato
        '
        Me.lbFodselsdato.AutoSize = True
        Me.lbFodselsdato.Location = New System.Drawing.Point(191, 257)
        Me.lbFodselsdato.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbFodselsdato.Name = "lbFodselsdato"
        Me.lbFodselsdato.Size = New System.Drawing.Size(85, 17)
        Me.lbFodselsdato.TabIndex = 6
        Me.lbFodselsdato.Text = "Fødselsdato"
        '
        'lbTelefon
        '
        Me.lbTelefon.AutoSize = True
        Me.lbTelefon.Location = New System.Drawing.Point(215, 308)
        Me.lbTelefon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTelefon.Name = "lbTelefon"
        Me.lbTelefon.Size = New System.Drawing.Size(56, 17)
        Me.lbTelefon.TabIndex = 5
        Me.lbTelefon.Text = "Telefon"
        '
        'lbEtternavn
        '
        Me.lbEtternavn.AutoSize = True
        Me.lbEtternavn.Location = New System.Drawing.Point(205, 212)
        Me.lbEtternavn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbEtternavn.Name = "lbEtternavn"
        Me.lbEtternavn.Size = New System.Drawing.Size(69, 17)
        Me.lbEtternavn.TabIndex = 4
        Me.lbEtternavn.Text = "Etternavn"
        '
        'lbFornavn
        '
        Me.lbFornavn.AutoSize = True
        Me.lbFornavn.Location = New System.Drawing.Point(215, 160)
        Me.lbFornavn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbFornavn.Name = "lbFornavn"
        Me.lbFornavn.Size = New System.Drawing.Size(60, 17)
        Me.lbFornavn.TabIndex = 3
        Me.lbFornavn.Text = "Fornavn"
        '
        'txtTelefon
        '
        Me.txtTelefon.Location = New System.Drawing.Point(292, 304)
        Me.txtTelefon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(132, 22)
        Me.txtTelefon.TabIndex = 2
        '
        'txtEtternavn
        '
        Me.txtEtternavn.Location = New System.Drawing.Point(292, 208)
        Me.txtEtternavn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEtternavn.Name = "txtEtternavn"
        Me.txtEtternavn.Size = New System.Drawing.Size(132, 22)
        Me.txtEtternavn.TabIndex = 1
        '
        'txtFornavn
        '
        Me.txtFornavn.Location = New System.Drawing.Point(292, 156)
        Me.txtFornavn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFornavn.Name = "txtFornavn"
        Me.txtFornavn.Size = New System.Drawing.Size(132, 22)
        Me.txtFornavn.TabIndex = 0
        '
        'tabHistorikk
        '
        Me.tabHistorikk.Location = New System.Drawing.Point(4, 25)
        Me.tabHistorikk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabHistorikk.Name = "tabHistorikk"
        Me.tabHistorikk.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabHistorikk.Size = New System.Drawing.Size(1051, 519)
        Me.tabHistorikk.TabIndex = 1
        Me.tabHistorikk.Text = "Min Historikk"
        Me.tabHistorikk.UseVisualStyleBackColor = True
        '
        'tabReservasjon
        '
        Me.tabReservasjon.Controls.Add(Me.DateTimePicker1)
        Me.tabReservasjon.Controls.Add(Me.Button1)
        Me.tabReservasjon.Controls.Add(Me.btnSkjema)
        Me.tabReservasjon.Location = New System.Drawing.Point(4, 25)
        Me.tabReservasjon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabReservasjon.Name = "tabReservasjon"
        Me.tabReservasjon.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabReservasjon.Size = New System.Drawing.Size(1051, 519)
        Me.tabReservasjon.TabIndex = 2
        Me.tabReservasjon.Text = "Reserver Time"
        Me.tabReservasjon.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(211, 153)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(265, 22)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(700, 439)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 53)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Reserver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSkjema
        '
        Me.btnSkjema.Location = New System.Drawing.Point(871, 438)
        Me.btnSkjema.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSkjema.Name = "btnSkjema"
        Me.btnSkjema.Size = New System.Drawing.Size(135, 54)
        Me.btnSkjema.TabIndex = 0
        Me.btnSkjema.Text = "Egenerklæring"
        Me.btnSkjema.UseVisualStyleBackColor = True
        '
        'minside
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1067, 586)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "minside"
        Me.Text = "minside"
        Me.TabControl1.ResumeLayout(False)
        Me.tabBrukerinfo.ResumeLayout(False)
        Me.tabBrukerinfo.PerformLayout()
        Me.tabReservasjon.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabBrukerinfo As TabPage
    Friend WithEvents tabHistorikk As TabPage
    Friend WithEvents tabReservasjon As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSkjema As Button
    Friend WithEvents txtTelefon As TextBox
    Friend WithEvents txtEtternavn As TextBox
    Friend WithEvents txtFornavn As TextBox
    Friend WithEvents lbPostnummer As Label
    Friend WithEvents lbAdresse As Label
    Friend WithEvents lbFodselsdato As Label
    Friend WithEvents lbTelefon As Label
    Friend WithEvents lbEtternavn As Label
    Friend WithEvents lbFornavn As Label
    Friend WithEvents txtFodselsdato As TextBox
    Friend WithEvents btnEndreInfo As Button
    Friend WithEvents txtPostnummer As TextBox
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents lbPoststedLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbPoststed As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
