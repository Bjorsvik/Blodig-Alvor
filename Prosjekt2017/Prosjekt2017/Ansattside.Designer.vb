<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ansattside
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
        Me.Statistikk = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Reservasjoner = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Reservasjonskalender = New System.Windows.Forms.MonthCalendar()
        Me.Lageroppdatering = New System.Windows.Forms.TabPage()
        Me.Lager = New System.Windows.Forms.TabPage()
        Me.btnFjernBestilling = New System.Windows.Forms.Button()
        Me.lblOversiktRes = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
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
        Me.btnSok = New System.Windows.Forms.Button()
        Me.txtSok = New System.Windows.Forms.TextBox()
        Me.lblSok = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Statistikk.SuspendLayout()
        Me.Reservasjoner.SuspendLayout()
        Me.Lager.SuspendLayout()
        Me.Blodgivning.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Innkalling.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Søk.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Statistikk
        '
        Me.Statistikk.Controls.Add(Me.TextBox1)
        Me.Statistikk.Controls.Add(Me.Label1)
        Me.Statistikk.Location = New System.Drawing.Point(4, 25)
        Me.Statistikk.Name = "Statistikk"
        Me.Statistikk.Padding = New System.Windows.Forms.Padding(3)
        Me.Statistikk.Size = New System.Drawing.Size(981, 530)
        Me.Statistikk.TabIndex = 5
        Me.Statistikk.Text = " Statistikk"
        Me.Statistikk.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(238, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Antall registrerte donører: "
        '
        'Reservasjoner
        '
        Me.Reservasjoner.Controls.Add(Me.Label2)
        Me.Reservasjoner.Controls.Add(Me.ListBox1)
        Me.Reservasjoner.Controls.Add(Me.Reservasjonskalender)
        Me.Reservasjoner.Location = New System.Drawing.Point(4, 25)
        Me.Reservasjoner.Name = "Reservasjoner"
        Me.Reservasjoner.Padding = New System.Windows.Forms.Padding(3)
        Me.Reservasjoner.Size = New System.Drawing.Size(981, 530)
        Me.Reservasjoner.TabIndex = 4
        Me.Reservasjoner.Text = "Reservasjoner"
        Me.Reservasjoner.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(446, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Reservasjoner for valgt dato:"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(449, 103)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(266, 212)
        Me.ListBox1.TabIndex = 14
        '
        'Reservasjonskalender
        '
        Me.Reservasjonskalender.Location = New System.Drawing.Point(85, 103)
        Me.Reservasjonskalender.Name = "Reservasjonskalender"
        Me.Reservasjonskalender.TabIndex = 13
        '
        'Lageroppdatering
        '
        Me.Lageroppdatering.Location = New System.Drawing.Point(4, 25)
        Me.Lageroppdatering.Name = "Lageroppdatering"
        Me.Lageroppdatering.Padding = New System.Windows.Forms.Padding(3)
        Me.Lageroppdatering.Size = New System.Drawing.Size(981, 530)
        Me.Lageroppdatering.TabIndex = 3
        Me.Lageroppdatering.Text = "Lageroppdatering"
        Me.Lageroppdatering.UseVisualStyleBackColor = True
        '
        'Lager
        '
        Me.Lager.Controls.Add(Me.btnFjernBestilling)
        Me.Lager.Controls.Add(Me.lblOversiktRes)
        Me.Lager.Controls.Add(Me.ListBox2)
        Me.Lager.Location = New System.Drawing.Point(4, 25)
        Me.Lager.Name = "Lager"
        Me.Lager.Padding = New System.Windows.Forms.Padding(3)
        Me.Lager.Size = New System.Drawing.Size(981, 530)
        Me.Lager.TabIndex = 2
        Me.Lager.Text = "Lager"
        Me.Lager.UseVisualStyleBackColor = True
        '
        'btnFjernBestilling
        '
        Me.btnFjernBestilling.Location = New System.Drawing.Point(57, 427)
        Me.btnFjernBestilling.Name = "btnFjernBestilling"
        Me.btnFjernBestilling.Size = New System.Drawing.Size(291, 23)
        Me.btnFjernBestilling.TabIndex = 3
        Me.btnFjernBestilling.Text = "Fjern bestilling"
        Me.btnFjernBestilling.UseVisualStyleBackColor = True
        '
        'lblOversiktRes
        '
        Me.lblOversiktRes.AutoSize = True
        Me.lblOversiktRes.Location = New System.Drawing.Point(54, 46)
        Me.lblOversiktRes.Name = "lblOversiktRes"
        Me.lblOversiktRes.Size = New System.Drawing.Size(168, 17)
        Me.lblOversiktRes.TabIndex = 2
        Me.lblOversiktRes.Text = "Oversikt over bestillinger:"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(57, 77)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(291, 324)
        Me.ListBox2.TabIndex = 1
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
        Me.Blodgivning.Location = New System.Drawing.Point(4, 25)
        Me.Blodgivning.Name = "Blodgivning"
        Me.Blodgivning.Padding = New System.Windows.Forms.Padding(3)
        Me.Blodgivning.Size = New System.Drawing.Size(981, 530)
        Me.Blodgivning.TabIndex = 1
        Me.Blodgivning.Text = "Blodgivning"
        Me.Blodgivning.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(197, 107)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(137, 22)
        Me.NumericUpDown1.TabIndex = 18
        '
        'btnBlodgivning
        '
        Me.btnBlodgivning.Location = New System.Drawing.Point(399, 101)
        Me.btnBlodgivning.Name = "btnBlodgivning"
        Me.btnBlodgivning.Size = New System.Drawing.Size(355, 278)
        Me.btnBlodgivning.TabIndex = 17
        Me.btnBlodgivning.Text = "Send inn"
        Me.btnBlodgivning.UseVisualStyleBackColor = True
        '
        'KalenderGivning
        '
        Me.KalenderGivning.Location = New System.Drawing.Point(58, 172)
        Me.KalenderGivning.Name = "KalenderGivning"
        Me.KalenderGivning.TabIndex = 16
        '
        'lblGivningDato
        '
        Me.lblGivningDato.AutoSize = True
        Me.lblGivningDato.Location = New System.Drawing.Point(55, 146)
        Me.lblGivningDato.Name = "lblGivningDato"
        Me.lblGivningDato.Size = New System.Drawing.Size(46, 17)
        Me.lblGivningDato.TabIndex = 15
        Me.lblGivningDato.Text = "Dato: "
        '
        'lblMengde
        '
        Me.lblMengde.AutoSize = True
        Me.lblMengde.Location = New System.Drawing.Point(55, 107)
        Me.lblMengde.Name = "lblMengde"
        Me.lblMengde.Size = New System.Drawing.Size(130, 17)
        Me.lblMengde.TabIndex = 14
        Me.lblMengde.Text = "Mengde blod (DL): "
        '
        'lblPersnr
        '
        Me.lblPersnr.AutoSize = True
        Me.lblPersnr.Location = New System.Drawing.Point(55, 54)
        Me.lblPersnr.Name = "lblPersnr"
        Me.lblPersnr.Size = New System.Drawing.Size(112, 17)
        Me.lblPersnr.TabIndex = 13
        Me.lblPersnr.Text = "Personnummer: "
        '
        'txtboxPersnr
        '
        Me.txtboxPersnr.Location = New System.Drawing.Point(197, 54)
        Me.txtboxPersnr.Name = "txtboxPersnr"
        Me.txtboxPersnr.Size = New System.Drawing.Size(137, 22)
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
        Me.Innkalling.Location = New System.Drawing.Point(4, 25)
        Me.Innkalling.Name = "Innkalling"
        Me.Innkalling.Padding = New System.Windows.Forms.Padding(3)
        Me.Innkalling.Size = New System.Drawing.Size(981, 530)
        Me.Innkalling.TabIndex = 0
        Me.Innkalling.Text = "Innkalling"
        Me.Innkalling.UseVisualStyleBackColor = True
        '
        'txtboxTilgjengelig
        '
        Me.txtboxTilgjengelig.Location = New System.Drawing.Point(579, 149)
        Me.txtboxTilgjengelig.Name = "txtboxTilgjengelig"
        Me.txtboxTilgjengelig.Size = New System.Drawing.Size(121, 22)
        Me.txtboxTilgjengelig.TabIndex = 14
        '
        'lblTilgjengeligeGivere
        '
        Me.lblTilgjengeligeGivere.AutoSize = True
        Me.lblTilgjengeligeGivere.Location = New System.Drawing.Point(411, 154)
        Me.lblTilgjengeligeGivere.Name = "lblTilgjengeligeGivere"
        Me.lblTilgjengeligeGivere.Size = New System.Drawing.Size(162, 17)
        Me.lblTilgjengeligeGivere.TabIndex = 13
        Me.lblTilgjengeligeGivere.Text = "Tilgjengelige blodgivere:"
        '
        'txtAntallGivere
        '
        Me.txtAntallGivere.Location = New System.Drawing.Point(239, 139)
        Me.txtAntallGivere.Name = "txtAntallGivere"
        Me.txtAntallGivere.Size = New System.Drawing.Size(121, 22)
        Me.txtAntallGivere.TabIndex = 12
        '
        'lblØnskedeGivere
        '
        Me.lblØnskedeGivere.AutoSize = True
        Me.lblØnskedeGivere.Location = New System.Drawing.Point(66, 142)
        Me.lblØnskedeGivere.Name = "lblØnskedeGivere"
        Me.lblØnskedeGivere.Size = New System.Drawing.Size(167, 17)
        Me.lblØnskedeGivere.TabIndex = 11
        Me.lblØnskedeGivere.Text = "Antall blodgivere ønsket: "
        '
        'cboxRhesus
        '
        Me.cboxRhesus.FormattingEnabled = True
        Me.cboxRhesus.Items.AddRange(New Object() {"+", "-"})
        Me.cboxRhesus.Location = New System.Drawing.Point(579, 78)
        Me.cboxRhesus.Name = "cboxRhesus"
        Me.cboxRhesus.Size = New System.Drawing.Size(109, 24)
        Me.cboxRhesus.TabIndex = 10
        '
        'lblRhesus
        '
        Me.lblRhesus.AutoSize = True
        Me.lblRhesus.Location = New System.Drawing.Point(509, 78)
        Me.lblRhesus.Name = "lblRhesus"
        Me.lblRhesus.Size = New System.Drawing.Size(64, 17)
        Me.lblRhesus.TabIndex = 9
        Me.lblRhesus.Text = "Rhesus: "
        '
        'cboxBlodtypeØnsket
        '
        Me.cboxBlodtypeØnsket.FormattingEnabled = True
        Me.cboxBlodtypeØnsket.Items.AddRange(New Object() {"A", "B", "AB", "0"})
        Me.cboxBlodtypeØnsket.Location = New System.Drawing.Point(239, 81)
        Me.cboxBlodtypeØnsket.Name = "cboxBlodtypeØnsket"
        Me.cboxBlodtypeØnsket.Size = New System.Drawing.Size(121, 24)
        Me.cboxBlodtypeØnsket.TabIndex = 8
        '
        'btnInnkalling
        '
        Me.btnInnkalling.Location = New System.Drawing.Point(239, 287)
        Me.btnInnkalling.Name = "btnInnkalling"
        Me.btnInnkalling.Size = New System.Drawing.Size(416, 23)
        Me.btnInnkalling.TabIndex = 7
        Me.btnInnkalling.Text = "Send innkalling"
        Me.btnInnkalling.UseVisualStyleBackColor = True
        '
        'lblBlodtypeØnsket
        '
        Me.lblBlodtypeØnsket.AutoSize = True
        Me.lblBlodtypeØnsket.Location = New System.Drawing.Point(114, 81)
        Me.lblBlodtypeØnsket.Name = "lblBlodtypeØnsket"
        Me.lblBlodtypeØnsket.Size = New System.Drawing.Size(119, 17)
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
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1012, 559)
        Me.TabControl1.TabIndex = 1
        '
        'Søk
        '
        Me.Søk.Controls.Add(Me.DataGridView1)
        Me.Søk.Controls.Add(Me.btnSok)
        Me.Søk.Controls.Add(Me.txtSok)
        Me.Søk.Controls.Add(Me.lblSok)
        Me.Søk.Location = New System.Drawing.Point(4, 25)
        Me.Søk.Name = "Søk"
        Me.Søk.Padding = New System.Windows.Forms.Padding(3)
        Me.Søk.Size = New System.Drawing.Size(1004, 530)
        Me.Søk.TabIndex = 6
        Me.Søk.Text = "Søk/Endre"
        Me.Søk.UseVisualStyleBackColor = True
        '
        'btnSok
        '
        Me.btnSok.Location = New System.Drawing.Point(532, 102)
        Me.btnSok.Name = "btnSok"
        Me.btnSok.Size = New System.Drawing.Size(75, 23)
        Me.btnSok.TabIndex = 2
        Me.btnSok.Text = "Søk!"
        Me.btnSok.UseVisualStyleBackColor = True
        '
        'txtSok
        '
        Me.txtSok.Location = New System.Drawing.Point(324, 103)
        Me.txtSok.Name = "txtSok"
        Me.txtSok.Size = New System.Drawing.Size(181, 22)
        Me.txtSok.TabIndex = 1
        '
        'lblSok
        '
        Me.lblSok.AutoSize = True
        Me.lblSok.Location = New System.Drawing.Point(151, 105)
        Me.lblSok.Name = "lblSok"
        Me.lblSok.Size = New System.Drawing.Size(167, 17)
        Me.lblSok.TabIndex = 0
        Me.lblSok.Text = "Søk etter telefonnummer:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.Location = New System.Drawing.Point(0, 165)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1004, 88)
        Me.DataGridView1.TabIndex = 4
        '
        'Ansattside
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 556)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Ansattside"
        Me.Text = "Ansattside"
        Me.Statistikk.ResumeLayout(False)
        Me.Statistikk.PerformLayout()
        Me.Reservasjoner.ResumeLayout(False)
        Me.Reservasjoner.PerformLayout()
        Me.Lager.ResumeLayout(False)
        Me.Lager.PerformLayout()
        Me.Blodgivning.ResumeLayout(False)
        Me.Blodgivning.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Innkalling.ResumeLayout(False)
        Me.Innkalling.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Søk.ResumeLayout(False)
        Me.Søk.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Statistikk As TabPage
    Friend WithEvents Reservasjoner As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Reservasjonskalender As MonthCalendar
    Friend WithEvents Lageroppdatering As TabPage
    Friend WithEvents Lager As TabPage
    Friend WithEvents lblOversiktRes As Label
    Friend WithEvents ListBox2 As ListBox
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
    Friend WithEvents btnFjernBestilling As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Søk As TabPage
    Friend WithEvents btnSok As Button
    Friend WithEvents txtSok As TextBox
    Friend WithEvents lblSok As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
