﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.txtPersonnummer = New System.Windows.Forms.TextBox()
        Me.lbPostnummer = New System.Windows.Forms.Label()
        Me.lbAdresse = New System.Windows.Forms.Label()
        Me.lbPersonnummer = New System.Windows.Forms.Label()
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
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
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
        Me.TabControl1.Location = New System.Drawing.Point(0, 12)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(794, 445)
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
        Me.tabBrukerinfo.Controls.Add(Me.txtPersonnummer)
        Me.tabBrukerinfo.Controls.Add(Me.lbPostnummer)
        Me.tabBrukerinfo.Controls.Add(Me.lbAdresse)
        Me.tabBrukerinfo.Controls.Add(Me.lbPersonnummer)
        Me.tabBrukerinfo.Controls.Add(Me.lbTelefon)
        Me.tabBrukerinfo.Controls.Add(Me.lbEtternavn)
        Me.tabBrukerinfo.Controls.Add(Me.lbFornavn)
        Me.tabBrukerinfo.Controls.Add(Me.txtTelefon)
        Me.tabBrukerinfo.Controls.Add(Me.txtEtternavn)
        Me.tabBrukerinfo.Controls.Add(Me.txtFornavn)
        Me.tabBrukerinfo.Location = New System.Drawing.Point(4, 22)
        Me.tabBrukerinfo.Name = "tabBrukerinfo"
        Me.tabBrukerinfo.Size = New System.Drawing.Size(786, 419)
        Me.tabBrukerinfo.TabIndex = 0
        Me.tabBrukerinfo.Text = "Brukerinfo"
        Me.tabBrukerinfo.UseVisualStyleBackColor = True
        '
        'lbPoststed
        '
        Me.lbPoststed.AutoSize = True
        Me.lbPoststed.Location = New System.Drawing.Point(509, 208)
        Me.lbPoststed.Name = "lbPoststed"
        Me.lbPoststed.Size = New System.Drawing.Size(39, 13)
        Me.lbPoststed.TabIndex = 16
        Me.lbPoststed.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 33)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Personalia"
        '
        'btnEndreInfo
        '
        Me.btnEndreInfo.Location = New System.Drawing.Point(527, 243)
        Me.btnEndreInfo.Name = "btnEndreInfo"
        Me.btnEndreInfo.Size = New System.Drawing.Size(82, 26)
        Me.btnEndreInfo.TabIndex = 14
        Me.btnEndreInfo.Text = "Endre info"
        Me.btnEndreInfo.UseVisualStyleBackColor = True
        '
        'txtPostnummer
        '
        Me.txtPostnummer.Location = New System.Drawing.Point(509, 165)
        Me.txtPostnummer.Name = "txtPostnummer"
        Me.txtPostnummer.Size = New System.Drawing.Size(100, 20)
        Me.txtPostnummer.TabIndex = 12
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(509, 123)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(148, 20)
        Me.txtAdresse.TabIndex = 11
        '
        'lbPoststedLabel
        '
        Me.lbPoststedLabel.AutoSize = True
        Me.lbPoststedLabel.Location = New System.Drawing.Point(455, 206)
        Me.lbPoststedLabel.Name = "lbPoststedLabel"
        Me.lbPoststedLabel.Size = New System.Drawing.Size(48, 13)
        Me.lbPoststedLabel.TabIndex = 10
        Me.lbPoststedLabel.Text = "Poststed"
        '
        'txtPersonnummer
        '
        Me.txtPersonnummer.Location = New System.Drawing.Point(219, 206)
        Me.txtPersonnummer.Name = "txtPersonnummer"
        Me.txtPersonnummer.Size = New System.Drawing.Size(100, 20)
        Me.txtPersonnummer.TabIndex = 9
        '
        'lbPostnummer
        '
        Me.lbPostnummer.AutoSize = True
        Me.lbPostnummer.Location = New System.Drawing.Point(438, 168)
        Me.lbPostnummer.Name = "lbPostnummer"
        Me.lbPostnummer.Size = New System.Drawing.Size(65, 13)
        Me.lbPostnummer.TabIndex = 8
        Me.lbPostnummer.Text = "Postnummer"
        '
        'lbAdresse
        '
        Me.lbAdresse.AutoSize = True
        Me.lbAdresse.Location = New System.Drawing.Point(458, 127)
        Me.lbAdresse.Name = "lbAdresse"
        Me.lbAdresse.Size = New System.Drawing.Size(45, 13)
        Me.lbAdresse.TabIndex = 7
        Me.lbAdresse.Text = "Adresse"
        '
        'lbPersonnummer
        '
        Me.lbPersonnummer.AutoSize = True
        Me.lbPersonnummer.Location = New System.Drawing.Point(136, 209)
        Me.lbPersonnummer.Name = "lbPersonnummer"
        Me.lbPersonnummer.Size = New System.Drawing.Size(77, 13)
        Me.lbPersonnummer.TabIndex = 6
        Me.lbPersonnummer.Text = "Personnummer"
        '
        'lbTelefon
        '
        Me.lbTelefon.AutoSize = True
        Me.lbTelefon.Location = New System.Drawing.Point(161, 267)
        Me.lbTelefon.Name = "lbTelefon"
        Me.lbTelefon.Size = New System.Drawing.Size(43, 13)
        Me.lbTelefon.TabIndex = 5
        Me.lbTelefon.Text = "Telefon"
        '
        'lbEtternavn
        '
        Me.lbEtternavn.AutoSize = True
        Me.lbEtternavn.Location = New System.Drawing.Point(160, 172)
        Me.lbEtternavn.Name = "lbEtternavn"
        Me.lbEtternavn.Size = New System.Drawing.Size(53, 13)
        Me.lbEtternavn.TabIndex = 4
        Me.lbEtternavn.Text = "Etternavn"
        '
        'lbFornavn
        '
        Me.lbFornavn.AutoSize = True
        Me.lbFornavn.Location = New System.Drawing.Point(161, 130)
        Me.lbFornavn.Name = "lbFornavn"
        Me.lbFornavn.Size = New System.Drawing.Size(46, 13)
        Me.lbFornavn.TabIndex = 3
        Me.lbFornavn.Text = "Fornavn"
        '
        'txtTelefon
        '
        Me.txtTelefon.Location = New System.Drawing.Point(219, 264)
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefon.TabIndex = 2
        '
        'txtEtternavn
        '
        Me.txtEtternavn.Location = New System.Drawing.Point(219, 169)
        Me.txtEtternavn.Name = "txtEtternavn"
        Me.txtEtternavn.Size = New System.Drawing.Size(100, 20)
        Me.txtEtternavn.TabIndex = 1
        '
        'txtFornavn
        '
        Me.txtFornavn.Location = New System.Drawing.Point(219, 127)
        Me.txtFornavn.Name = "txtFornavn"
        Me.txtFornavn.Size = New System.Drawing.Size(100, 20)
        Me.txtFornavn.TabIndex = 0
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
        Me.tabReservasjon.Controls.Add(Me.MonthCalendar1)
        Me.tabReservasjon.Controls.Add(Me.DateTimePicker1)
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
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(80, 82)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 4
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
        'btnSkjema
        '
        Me.btnSkjema.Location = New System.Drawing.Point(653, 356)
        Me.btnSkjema.Name = "btnSkjema"
        Me.btnSkjema.Size = New System.Drawing.Size(101, 44)
        Me.btnSkjema.TabIndex = 0
        Me.btnSkjema.Text = "Egenerklæring"
        Me.btnSkjema.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(411, 96)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 5
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
    Friend WithEvents lbPersonnummer As Label
    Friend WithEvents lbTelefon As Label
    Friend WithEvents lbEtternavn As Label
    Friend WithEvents lbFornavn As Label
    Friend WithEvents txtPersonnummer As TextBox
    Friend WithEvents btnEndreInfo As Button
    Friend WithEvents txtPostnummer As TextBox
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents lbPoststedLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbPoststed As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents MonthCalendar1 As MonthCalendar
End Class
