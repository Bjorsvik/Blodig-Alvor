<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ansattside
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
        Me.Statistikk = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Reservasjoner = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Reservasjonskalender = New System.Windows.Forms.MonthCalendar()
        Me.Lageroppdatering = New System.Windows.Forms.TabPage()
        Me.Lager = New System.Windows.Forms.TabPage()
        Me.Blodgivning = New System.Windows.Forms.TabPage()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.btnBlodgivning = New System.Windows.Forms.Button()
        Me.KalenderGivning = New System.Windows.Forms.MonthCalendar()
        Me.lblGivningDato = New System.Windows.Forms.Label()
        Me.lblMengde = New System.Windows.Forms.Label()
        Me.lblPersnr = New System.Windows.Forms.Label()
        Me.txtboxPersnr = New System.Windows.Forms.TextBox()
        Me.Innkalling = New System.Windows.Forms.TabPage()
        Me.txtboxTilgjengelig = New System.Windows.Forms.TextBox()
        Me.lblTilgjengeligeGivere = New System.Windows.Forms.Label()
        Me.txtAntallGivere = New System.Windows.Forms.TextBox()
        Me.lblØnskedeGivere = New System.Windows.Forms.Label()
        Me.cboxRhesus = New System.Windows.Forms.ComboBox()
        Me.lblRhesus = New System.Windows.Forms.Label()
        Me.cboxBlodtypeØnsket = New System.Windows.Forms.ComboBox()
        Me.btnInnkalling = New System.Windows.Forms.Button()
        Me.lblBlodtypeØnsket = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Søk = New System.Windows.Forms.TabPage()
        Me.btnOppdater = New System.Windows.Forms.Button()
        Me.btnSlett = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSok = New System.Windows.Forms.Button()
        Me.txtSok = New System.Windows.Forms.TextBox()
        Me.lblSok = New System.Windows.Forms.Label()
        Me.gridBlodlager = New System.Windows.Forms.DataGridView()
        Me.Statistikk.SuspendLayout()
        Me.Reservasjoner.SuspendLayout()
        Me.Lager.SuspendLayout()
        Me.Blodgivning.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Innkalling.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Søk.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridBlodlager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Statistikk
        '
        Me.Statistikk.Controls.Add(Me.TextBox1)
        Me.Statistikk.Controls.Add(Me.Label1)
        Me.Statistikk.Location = New System.Drawing.Point(4, 22)
        Me.Statistikk.Margin = New System.Windows.Forms.Padding(2)
        Me.Statistikk.Name = "Statistikk"
        Me.Statistikk.Padding = New System.Windows.Forms.Padding(2)
        Me.Statistikk.Size = New System.Drawing.Size(751, 428)
        Me.Statistikk.TabIndex = 5
        Me.Statistikk.Text = " Statistikk"
        Me.Statistikk.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(178, 28)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(76, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Antall registrerte donører: "
        '
        'Reservasjoner
        '
        Me.Reservasjoner.Controls.Add(Me.Label2)
        Me.Reservasjoner.Controls.Add(Me.ListBox1)
        Me.Reservasjoner.Controls.Add(Me.Reservasjonskalender)
        Me.Reservasjoner.Location = New System.Drawing.Point(4, 22)
        Me.Reservasjoner.Margin = New System.Windows.Forms.Padding(2)
        Me.Reservasjoner.Name = "Reservasjoner"
        Me.Reservasjoner.Padding = New System.Windows.Forms.Padding(2)
        Me.Reservasjoner.Size = New System.Drawing.Size(751, 428)
        Me.Reservasjoner.TabIndex = 4
        Me.Reservasjoner.Text = "Reservasjoner"
        Me.Reservasjoner.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(334, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Reservasjoner for valgt dato:"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(337, 84)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(200, 173)
        Me.ListBox1.TabIndex = 14
        '
        'Reservasjonskalender
        '
        Me.Reservasjonskalender.Location = New System.Drawing.Point(64, 84)
        Me.Reservasjonskalender.Margin = New System.Windows.Forms.Padding(7)
        Me.Reservasjonskalender.Name = "Reservasjonskalender"
        Me.Reservasjonskalender.TabIndex = 13
        '
        'Lageroppdatering
        '
        Me.Lageroppdatering.Location = New System.Drawing.Point(4, 22)
        Me.Lageroppdatering.Margin = New System.Windows.Forms.Padding(2)
        Me.Lageroppdatering.Name = "Lageroppdatering"
        Me.Lageroppdatering.Padding = New System.Windows.Forms.Padding(2)
        Me.Lageroppdatering.Size = New System.Drawing.Size(751, 428)
        Me.Lageroppdatering.TabIndex = 3
        Me.Lageroppdatering.Text = "Lageroppdatering"
        Me.Lageroppdatering.UseVisualStyleBackColor = True
        '
        'Lager
        '
        Me.Lager.Controls.Add(Me.gridBlodlager)
        Me.Lager.Location = New System.Drawing.Point(4, 22)
        Me.Lager.Margin = New System.Windows.Forms.Padding(2)
        Me.Lager.Name = "Lager"
        Me.Lager.Padding = New System.Windows.Forms.Padding(2)
        Me.Lager.Size = New System.Drawing.Size(751, 428)
        Me.Lager.TabIndex = 2
        Me.Lager.Text = "Lager"
        Me.Lager.UseVisualStyleBackColor = True
        '
        'Blodgivning
        '
        Me.Blodgivning.Controls.Add(Me.NumericUpDown1)
        Me.Blodgivning.Controls.Add(Me.btnBlodgivning)
        Me.Blodgivning.Controls.Add(Me.KalenderGivning)
        Me.Blodgivning.Controls.Add(Me.lblGivningDato)
        Me.Blodgivning.Controls.Add(Me.lblMengde)
        Me.Blodgivning.Controls.Add(Me.lblPersnr)
        Me.Blodgivning.Controls.Add(Me.txtboxPersnr)
        Me.Blodgivning.Location = New System.Drawing.Point(4, 22)
        Me.Blodgivning.Margin = New System.Windows.Forms.Padding(2)
        Me.Blodgivning.Name = "Blodgivning"
        Me.Blodgivning.Padding = New System.Windows.Forms.Padding(2)
        Me.Blodgivning.Size = New System.Drawing.Size(751, 428)
        Me.Blodgivning.TabIndex = 1
        Me.Blodgivning.Text = "Blodgivning"
        Me.Blodgivning.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(148, 87)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(2)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(103, 20)
        Me.NumericUpDown1.TabIndex = 18
        '
        'btnBlodgivning
        '
        Me.btnBlodgivning.Location = New System.Drawing.Point(299, 82)
        Me.btnBlodgivning.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBlodgivning.Name = "btnBlodgivning"
        Me.btnBlodgivning.Size = New System.Drawing.Size(266, 226)
        Me.btnBlodgivning.TabIndex = 17
        Me.btnBlodgivning.Text = "Send inn"
        Me.btnBlodgivning.UseVisualStyleBackColor = True
        '
        'KalenderGivning
        '
        Me.KalenderGivning.Location = New System.Drawing.Point(44, 140)
        Me.KalenderGivning.Margin = New System.Windows.Forms.Padding(7)
        Me.KalenderGivning.Name = "KalenderGivning"
        Me.KalenderGivning.TabIndex = 16
        '
        'lblGivningDato
        '
        Me.lblGivningDato.AutoSize = True
        Me.lblGivningDato.Location = New System.Drawing.Point(41, 119)
        Me.lblGivningDato.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGivningDato.Name = "lblGivningDato"
        Me.lblGivningDato.Size = New System.Drawing.Size(36, 13)
        Me.lblGivningDato.TabIndex = 15
        Me.lblGivningDato.Text = "Dato: "
        '
        'lblMengde
        '
        Me.lblMengde.AutoSize = True
        Me.lblMengde.Location = New System.Drawing.Point(41, 87)
        Me.lblMengde.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMengde.Name = "lblMengde"
        Me.lblMengde.Size = New System.Drawing.Size(98, 13)
        Me.lblMengde.TabIndex = 14
        Me.lblMengde.Text = "Mengde blod (DL): "
        '
        'lblPersnr
        '
        Me.lblPersnr.AutoSize = True
        Me.lblPersnr.Location = New System.Drawing.Point(41, 44)
        Me.lblPersnr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPersnr.Name = "lblPersnr"
        Me.lblPersnr.Size = New System.Drawing.Size(83, 13)
        Me.lblPersnr.TabIndex = 13
        Me.lblPersnr.Text = "Personnummer: "
        '
        'txtboxPersnr
        '
        Me.txtboxPersnr.Location = New System.Drawing.Point(148, 44)
        Me.txtboxPersnr.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxPersnr.Name = "txtboxPersnr"
        Me.txtboxPersnr.Size = New System.Drawing.Size(104, 20)
        Me.txtboxPersnr.TabIndex = 11
        '
        'Innkalling
        '
        Me.Innkalling.Controls.Add(Me.txtboxTilgjengelig)
        Me.Innkalling.Controls.Add(Me.lblTilgjengeligeGivere)
        Me.Innkalling.Controls.Add(Me.txtAntallGivere)
        Me.Innkalling.Controls.Add(Me.lblØnskedeGivere)
        Me.Innkalling.Controls.Add(Me.cboxRhesus)
        Me.Innkalling.Controls.Add(Me.lblRhesus)
        Me.Innkalling.Controls.Add(Me.cboxBlodtypeØnsket)
        Me.Innkalling.Controls.Add(Me.btnInnkalling)
        Me.Innkalling.Controls.Add(Me.lblBlodtypeØnsket)
        Me.Innkalling.Location = New System.Drawing.Point(4, 22)
        Me.Innkalling.Margin = New System.Windows.Forms.Padding(2)
        Me.Innkalling.Name = "Innkalling"
        Me.Innkalling.Padding = New System.Windows.Forms.Padding(2)
        Me.Innkalling.Size = New System.Drawing.Size(751, 428)
        Me.Innkalling.TabIndex = 0
        Me.Innkalling.Text = "Innkalling"
        Me.Innkalling.UseVisualStyleBackColor = True
        '
        'txtboxTilgjengelig
        '
        Me.txtboxTilgjengelig.Location = New System.Drawing.Point(434, 121)
        Me.txtboxTilgjengelig.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxTilgjengelig.Name = "txtboxTilgjengelig"
        Me.txtboxTilgjengelig.Size = New System.Drawing.Size(92, 20)
        Me.txtboxTilgjengelig.TabIndex = 14
        '
        'lblTilgjengeligeGivere
        '
        Me.lblTilgjengeligeGivere.AutoSize = True
        Me.lblTilgjengeligeGivere.Location = New System.Drawing.Point(308, 125)
        Me.lblTilgjengeligeGivere.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTilgjengeligeGivere.Name = "lblTilgjengeligeGivere"
        Me.lblTilgjengeligeGivere.Size = New System.Drawing.Size(121, 13)
        Me.lblTilgjengeligeGivere.TabIndex = 13
        Me.lblTilgjengeligeGivere.Text = "Tilgjengelige blodgivere:"
        '
        'txtAntallGivere
        '
        Me.txtAntallGivere.Location = New System.Drawing.Point(179, 113)
        Me.txtAntallGivere.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAntallGivere.Name = "txtAntallGivere"
        Me.txtAntallGivere.Size = New System.Drawing.Size(92, 20)
        Me.txtAntallGivere.TabIndex = 12
        '
        'lblØnskedeGivere
        '
        Me.lblØnskedeGivere.AutoSize = True
        Me.lblØnskedeGivere.Location = New System.Drawing.Point(50, 115)
        Me.lblØnskedeGivere.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblØnskedeGivere.Name = "lblØnskedeGivere"
        Me.lblØnskedeGivere.Size = New System.Drawing.Size(126, 13)
        Me.lblØnskedeGivere.TabIndex = 11
        Me.lblØnskedeGivere.Text = "Antall blodgivere ønsket: "
        '
        'cboxRhesus
        '
        Me.cboxRhesus.FormattingEnabled = True
        Me.cboxRhesus.Items.AddRange(New Object() {"+", "-"})
        Me.cboxRhesus.Location = New System.Drawing.Point(434, 63)
        Me.cboxRhesus.Margin = New System.Windows.Forms.Padding(2)
        Me.cboxRhesus.Name = "cboxRhesus"
        Me.cboxRhesus.Size = New System.Drawing.Size(83, 21)
        Me.cboxRhesus.TabIndex = 10
        '
        'lblRhesus
        '
        Me.lblRhesus.AutoSize = True
        Me.lblRhesus.Location = New System.Drawing.Point(382, 63)
        Me.lblRhesus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRhesus.Name = "lblRhesus"
        Me.lblRhesus.Size = New System.Drawing.Size(49, 13)
        Me.lblRhesus.TabIndex = 9
        Me.lblRhesus.Text = "Rhesus: "
        '
        'cboxBlodtypeØnsket
        '
        Me.cboxBlodtypeØnsket.FormattingEnabled = True
        Me.cboxBlodtypeØnsket.Items.AddRange(New Object() {"A", "B", "AB", "0"})
        Me.cboxBlodtypeØnsket.Location = New System.Drawing.Point(179, 66)
        Me.cboxBlodtypeØnsket.Margin = New System.Windows.Forms.Padding(2)
        Me.cboxBlodtypeØnsket.Name = "cboxBlodtypeØnsket"
        Me.cboxBlodtypeØnsket.Size = New System.Drawing.Size(92, 21)
        Me.cboxBlodtypeØnsket.TabIndex = 8
        '
        'btnInnkalling
        '
        Me.btnInnkalling.Location = New System.Drawing.Point(179, 233)
        Me.btnInnkalling.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInnkalling.Name = "btnInnkalling"
        Me.btnInnkalling.Size = New System.Drawing.Size(312, 19)
        Me.btnInnkalling.TabIndex = 7
        Me.btnInnkalling.Text = "Send innkalling"
        Me.btnInnkalling.UseVisualStyleBackColor = True
        '
        'lblBlodtypeØnsket
        '
        Me.lblBlodtypeØnsket.AutoSize = True
        Me.lblBlodtypeØnsket.Location = New System.Drawing.Point(86, 66)
        Me.lblBlodtypeØnsket.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBlodtypeØnsket.Name = "lblBlodtypeØnsket"
        Me.lblBlodtypeØnsket.Size = New System.Drawing.Size(90, 13)
        Me.lblBlodtypeØnsket.TabIndex = 6
        Me.lblBlodtypeØnsket.Text = "Ønsket blodtype: "
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Innkalling)
        Me.TabControl1.Controls.Add(Me.Blodgivning)
        Me.TabControl1.Controls.Add(Me.Lager)
        Me.TabControl1.Controls.Add(Me.Lageroppdatering)
        Me.TabControl1.Controls.Add(Me.Reservasjoner)
        Me.TabControl1.Controls.Add(Me.Statistikk)
        Me.TabControl1.Controls.Add(Me.Søk)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(759, 454)
        Me.TabControl1.TabIndex = 1
        '
        'Søk
        '
        Me.Søk.Controls.Add(Me.btnOppdater)
        Me.Søk.Controls.Add(Me.btnSlett)
        Me.Søk.Controls.Add(Me.DataGridView1)
        Me.Søk.Controls.Add(Me.btnSok)
        Me.Søk.Controls.Add(Me.txtSok)
        Me.Søk.Controls.Add(Me.lblSok)
        Me.Søk.Location = New System.Drawing.Point(4, 22)
        Me.Søk.Margin = New System.Windows.Forms.Padding(2)
        Me.Søk.Name = "Søk"
        Me.Søk.Padding = New System.Windows.Forms.Padding(2)
        Me.Søk.Size = New System.Drawing.Size(751, 428)
        Me.Søk.TabIndex = 6
        Me.Søk.Text = "Søk/Endre"
        Me.Søk.UseVisualStyleBackColor = True
        '
        'btnOppdater
        '
        Me.btnOppdater.Location = New System.Drawing.Point(546, 85)
        Me.btnOppdater.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOppdater.Name = "btnOppdater"
        Me.btnOppdater.Size = New System.Drawing.Size(67, 19)
        Me.btnOppdater.TabIndex = 6
        Me.btnOppdater.Text = "Oppdater"
        Me.btnOppdater.UseVisualStyleBackColor = True
        '
        'btnSlett
        '
        Me.btnSlett.Location = New System.Drawing.Point(474, 84)
        Me.btnSlett.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSlett.Name = "btnSlett"
        Me.btnSlett.Size = New System.Drawing.Size(56, 19)
        Me.btnSlett.TabIndex = 5
        Me.btnSlett.Text = "Slett"
        Me.btnSlett.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.Location = New System.Drawing.Point(0, 125)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(756, 72)
        Me.DataGridView1.TabIndex = 4
        '
        'btnSok
        '
        Me.btnSok.Location = New System.Drawing.Point(413, 83)
        Me.btnSok.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSok.Name = "btnSok"
        Me.btnSok.Size = New System.Drawing.Size(56, 19)
        Me.btnSok.TabIndex = 2
        Me.btnSok.Text = "Søk!"
        Me.btnSok.UseVisualStyleBackColor = True
        '
        'txtSok
        '
        Me.txtSok.Location = New System.Drawing.Point(243, 84)
        Me.txtSok.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSok.Name = "txtSok"
        Me.txtSok.Size = New System.Drawing.Size(156, 20)
        Me.txtSok.TabIndex = 1
        '
        'lblSok
        '
        Me.lblSok.AutoSize = True
        Me.lblSok.Location = New System.Drawing.Point(113, 85)
        Me.lblSok.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSok.Name = "lblSok"
        Me.lblSok.Size = New System.Drawing.Size(125, 13)
        Me.lblSok.TabIndex = 0
        Me.lblSok.Text = "Søk etter telefonnummer:"
        '
        'gridBlodlager
        '
        Me.gridBlodlager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridBlodlager.Location = New System.Drawing.Point(192, 75)
        Me.gridBlodlager.Name = "gridBlodlager"
        Me.gridBlodlager.Size = New System.Drawing.Size(323, 213)
        Me.gridBlodlager.TabIndex = 0
        '
        'Ansattside
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 452)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Ansattside"
        Me.Text = "Ansattside"
        Me.Statistikk.ResumeLayout(False)
        Me.Statistikk.PerformLayout()
        Me.Reservasjoner.ResumeLayout(False)
        Me.Reservasjoner.PerformLayout()
        Me.Lager.ResumeLayout(False)
        Me.Blodgivning.ResumeLayout(False)
        Me.Blodgivning.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Innkalling.ResumeLayout(False)
        Me.Innkalling.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Søk.ResumeLayout(False)
        Me.Søk.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridBlodlager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Statistikk As TabPage
    Friend WithEvents Reservasjoner As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Reservasjonskalender As MonthCalendar
    Friend WithEvents Lageroppdatering As TabPage
    Friend WithEvents Lager As TabPage
    Friend WithEvents Blodgivning As TabPage
    Friend WithEvents btnBlodgivning As Button
    Friend WithEvents KalenderGivning As MonthCalendar
    Friend WithEvents lblGivningDato As Label
    Friend WithEvents lblMengde As Label
    Friend WithEvents lblPersnr As Label
    Friend WithEvents txtboxPersnr As TextBox
    Friend WithEvents Innkalling As TabPage
    Friend WithEvents txtAntallGivere As TextBox
    Friend WithEvents lblØnskedeGivere As Label
    Friend WithEvents cboxRhesus As ComboBox
    Friend WithEvents lblRhesus As Label
    Friend WithEvents cboxBlodtypeØnsket As ComboBox
    Friend WithEvents btnInnkalling As Button
    Friend WithEvents lblBlodtypeØnsket As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents txtboxTilgjengelig As TextBox
    Friend WithEvents lblTilgjengeligeGivere As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Søk As TabPage
    Friend WithEvents btnSok As Button
    Friend WithEvents txtSok As TextBox
    Friend WithEvents lblSok As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnOppdater As Button
    Friend WithEvents btnSlett As Button
    Friend WithEvents gridBlodlager As DataGridView
End Class
