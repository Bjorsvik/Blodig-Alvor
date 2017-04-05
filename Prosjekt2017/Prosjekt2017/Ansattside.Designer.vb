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
        Me.Lager = New System.Windows.Forms.TabPage()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLagerPersonnummer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboBlodplater = New System.Windows.Forms.ComboBox()
        Me.cboBlodplasma = New System.Windows.Forms.ComboBox()
        Me.cboBlodlegeme = New System.Windows.Forms.ComboBox()
        Me.gridBlodlager = New System.Windows.Forms.DataGridView()
        Me.Blodtype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Blodplasma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Blodplater = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Blodceller = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Blodgivning = New System.Windows.Forms.TabPage()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.btnBlodgivning = New System.Windows.Forms.Button()
        Me.lblMengde = New System.Windows.Forms.Label()
        Me.lblPersnr = New System.Windows.Forms.Label()
        Me.txtboxPersnr = New System.Windows.Forms.TextBox()
        Me.Innkalling = New System.Windows.Forms.TabPage()
        Me.txtboxTilgjengelig = New System.Windows.Forms.TextBox()
        Me.lblTilgjengeligeGivere = New System.Windows.Forms.Label()
        Me.txtAntallGivere = New System.Windows.Forms.TextBox()
        Me.lblØnskedeGivere = New System.Windows.Forms.Label()
        Me.cboRhesus = New System.Windows.Forms.ComboBox()
        Me.lblRhesus = New System.Windows.Forms.Label()
        Me.cboBlodtypeInnkalling = New System.Windows.Forms.ComboBox()
        Me.btnInnkalling = New System.Windows.Forms.Button()
        Me.lblBlodtypeØnsket = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Søk = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboBlodType = New System.Windows.Forms.ComboBox()
        Me.btnEndreInfo = New System.Windows.Forms.Button()
        Me.lbPoststed = New System.Windows.Forms.Label()
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
        Me.btnSok = New System.Windows.Forms.Button()
        Me.txtSok = New System.Windows.Forms.TextBox()
        Me.lblSok = New System.Windows.Forms.Label()
        Me.Statistikk.SuspendLayout()
        Me.Reservasjoner.SuspendLayout()
        Me.Lager.SuspendLayout()
        CType(Me.gridBlodlager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Blodgivning.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Innkalling.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Søk.SuspendLayout()
        Me.SuspendLayout()
        '
        'Statistikk
        '
        Me.Statistikk.Controls.Add(Me.TextBox1)
        Me.Statistikk.Controls.Add(Me.Label1)
        Me.Statistikk.Location = New System.Drawing.Point(4, 25)
        Me.Statistikk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Statistikk.Name = "Statistikk"
        Me.Statistikk.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Statistikk.Size = New System.Drawing.Size(1004, 530)
        Me.Statistikk.TabIndex = 5
        Me.Statistikk.Text = " Statistikk"
        Me.Statistikk.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(237, 34)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.Reservasjoner.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Reservasjoner.Name = "Reservasjoner"
        Me.Reservasjoner.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Reservasjoner.Size = New System.Drawing.Size(1004, 530)
        Me.Reservasjoner.TabIndex = 4
        Me.Reservasjoner.Text = "Reservasjoner"
        Me.Reservasjoner.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(445, 66)
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
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(265, 212)
        Me.ListBox1.TabIndex = 14
        '
        'Reservasjonskalender
        '
        Me.Reservasjonskalender.Location = New System.Drawing.Point(85, 103)
        Me.Reservasjonskalender.Name = "Reservasjonskalender"
        Me.Reservasjonskalender.TabIndex = 13
        '
        'Lager
        '
        Me.Lager.Controls.Add(Me.btnTest)
        Me.Lager.Controls.Add(Me.Label7)
        Me.Lager.Controls.Add(Me.txtLagerPersonnummer)
        Me.Lager.Controls.Add(Me.Label6)
        Me.Lager.Controls.Add(Me.Label5)
        Me.Lager.Controls.Add(Me.Label4)
        Me.Lager.Controls.Add(Me.Label3)
        Me.Lager.Controls.Add(Me.cboBlodplater)
        Me.Lager.Controls.Add(Me.cboBlodplasma)
        Me.Lager.Controls.Add(Me.cboBlodlegeme)
        Me.Lager.Controls.Add(Me.gridBlodlager)
        Me.Lager.Location = New System.Drawing.Point(4, 25)
        Me.Lager.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Lager.Name = "Lager"
        Me.Lager.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Lager.Size = New System.Drawing.Size(1004, 530)
        Me.Lager.TabIndex = 2
        Me.Lager.Text = "Lager"
        Me.Lager.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(741, 447)
        Me.btnTest.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(155, 28)
        Me.btnTest.TabIndex = 11
        Me.btnTest.Text = "Sett inn blodprodukt"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(689, 144)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Personnummer"
        '
        'txtLagerPersonnummer
        '
        Me.txtLagerPersonnummer.Location = New System.Drawing.Point(800, 140)
        Me.txtLagerPersonnummer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLagerPersonnummer.Name = "txtLagerPersonnummer"
        Me.txtLagerPersonnummer.Size = New System.Drawing.Size(132, 22)
        Me.txtLagerPersonnummer.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(705, 284)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Blodplater"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(696, 249)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Blodplasma"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(653, 209)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Røde blodlegemer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(713, 177)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Blodtype"
        '
        'cboBlodplater
        '
        Me.cboBlodplater.FormattingEnabled = True
        Me.cboBlodplater.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cboBlodplater.Location = New System.Drawing.Point(800, 281)
        Me.cboBlodplater.Margin = New System.Windows.Forms.Padding(4)
        Me.cboBlodplater.Name = "cboBlodplater"
        Me.cboBlodplater.Size = New System.Drawing.Size(160, 24)
        Me.cboBlodplater.TabIndex = 4
        Me.cboBlodplater.Text = "1"
        '
        'cboBlodplasma
        '
        Me.cboBlodplasma.FormattingEnabled = True
        Me.cboBlodplasma.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cboBlodplasma.Location = New System.Drawing.Point(800, 245)
        Me.cboBlodplasma.Margin = New System.Windows.Forms.Padding(4)
        Me.cboBlodplasma.Name = "cboBlodplasma"
        Me.cboBlodplasma.Size = New System.Drawing.Size(160, 24)
        Me.cboBlodplasma.TabIndex = 3
        Me.cboBlodplasma.Text = "1"
        '
        'cboBlodlegeme
        '
        Me.cboBlodlegeme.FormattingEnabled = True
        Me.cboBlodlegeme.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cboBlodlegeme.Location = New System.Drawing.Point(800, 206)
        Me.cboBlodlegeme.Margin = New System.Windows.Forms.Padding(4)
        Me.cboBlodlegeme.Name = "cboBlodlegeme"
        Me.cboBlodlegeme.Size = New System.Drawing.Size(160, 24)
        Me.cboBlodlegeme.TabIndex = 2
        Me.cboBlodlegeme.Text = "1"
        '
        'gridBlodlager
        '
        Me.gridBlodlager.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.gridBlodlager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridBlodlager.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Blodtype, Me.Blodplasma, Me.Blodplater, Me.Blodceller})
        Me.gridBlodlager.Location = New System.Drawing.Point(11, 23)
        Me.gridBlodlager.Margin = New System.Windows.Forms.Padding(4)
        Me.gridBlodlager.Name = "gridBlodlager"
        Me.gridBlodlager.Size = New System.Drawing.Size(591, 464)
        Me.gridBlodlager.TabIndex = 0
        '
        'Blodtype
        '
        Me.Blodtype.HeaderText = "Blodtype"
        Me.Blodtype.Name = "Blodtype"
        Me.Blodtype.ReadOnly = True
        '
        'Blodplasma
        '
        Me.Blodplasma.HeaderText = "Blodplasma"
        Me.Blodplasma.Name = "Blodplasma"
        Me.Blodplasma.ReadOnly = True
        '
        'Blodplater
        '
        Me.Blodplater.HeaderText = "Blodplater"
        Me.Blodplater.Name = "Blodplater"
        Me.Blodplater.ReadOnly = True
        '
        'Blodceller
        '
        Me.Blodceller.HeaderText = "Blodceller"
        Me.Blodceller.Name = "Blodceller"
        Me.Blodceller.ReadOnly = True
        '
        'Blodgivning
        '
        Me.Blodgivning.Controls.Add(Me.NumericUpDown1)
        Me.Blodgivning.Controls.Add(Me.btnBlodgivning)
        Me.Blodgivning.Controls.Add(Me.lblMengde)
        Me.Blodgivning.Controls.Add(Me.lblPersnr)
        Me.Blodgivning.Controls.Add(Me.txtboxPersnr)
        Me.Blodgivning.Location = New System.Drawing.Point(4, 25)
        Me.Blodgivning.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Blodgivning.Name = "Blodgivning"
        Me.Blodgivning.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Blodgivning.Size = New System.Drawing.Size(1004, 530)
        Me.Blodgivning.TabIndex = 1
        Me.Blodgivning.Text = "Blodgivning"
        Me.Blodgivning.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(197, 107)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(137, 22)
        Me.NumericUpDown1.TabIndex = 18
        '
        'btnBlodgivning
        '
        Me.btnBlodgivning.Location = New System.Drawing.Point(364, 32)
        Me.btnBlodgivning.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBlodgivning.Name = "btnBlodgivning"
        Me.btnBlodgivning.Size = New System.Drawing.Size(228, 142)
        Me.btnBlodgivning.TabIndex = 17
        Me.btnBlodgivning.Text = "Send inn"
        Me.btnBlodgivning.UseVisualStyleBackColor = True
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
        Me.txtboxPersnr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.Innkalling.Controls.Add(Me.cboRhesus)
        Me.Innkalling.Controls.Add(Me.lblRhesus)
        Me.Innkalling.Controls.Add(Me.cboBlodtypeInnkalling)
        Me.Innkalling.Controls.Add(Me.btnInnkalling)
        Me.Innkalling.Controls.Add(Me.lblBlodtypeØnsket)
        Me.Innkalling.Location = New System.Drawing.Point(4, 25)
        Me.Innkalling.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Innkalling.Name = "Innkalling"
        Me.Innkalling.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Innkalling.Size = New System.Drawing.Size(1004, 530)
        Me.Innkalling.TabIndex = 0
        Me.Innkalling.Text = "Innkalling"
        Me.Innkalling.UseVisualStyleBackColor = True
        '
        'txtboxTilgjengelig
        '
        Me.txtboxTilgjengelig.Location = New System.Drawing.Point(579, 139)
        Me.txtboxTilgjengelig.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxTilgjengelig.Name = "txtboxTilgjengelig"
        Me.txtboxTilgjengelig.Size = New System.Drawing.Size(121, 22)
        Me.txtboxTilgjengelig.TabIndex = 14
        '
        'lblTilgjengeligeGivere
        '
        Me.lblTilgjengeligeGivere.AutoSize = True
        Me.lblTilgjengeligeGivere.Location = New System.Drawing.Point(413, 143)
        Me.lblTilgjengeligeGivere.Name = "lblTilgjengeligeGivere"
        Me.lblTilgjengeligeGivere.Size = New System.Drawing.Size(162, 17)
        Me.lblTilgjengeligeGivere.TabIndex = 13
        Me.lblTilgjengeligeGivere.Text = "Tilgjengelige blodgivere:"
        '
        'txtAntallGivere
        '
        Me.txtAntallGivere.Location = New System.Drawing.Point(239, 139)
        Me.txtAntallGivere.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAntallGivere.Name = "txtAntallGivere"
        Me.txtAntallGivere.Size = New System.Drawing.Size(121, 22)
        Me.txtAntallGivere.TabIndex = 12
        '
        'lblØnskedeGivere
        '
        Me.lblØnskedeGivere.AutoSize = True
        Me.lblØnskedeGivere.Location = New System.Drawing.Point(67, 142)
        Me.lblØnskedeGivere.Name = "lblØnskedeGivere"
        Me.lblØnskedeGivere.Size = New System.Drawing.Size(167, 17)
        Me.lblØnskedeGivere.TabIndex = 11
        Me.lblØnskedeGivere.Text = "Antall blodgivere ønsket: "
        '
        'cboRhesus
        '
        Me.cboRhesus.FormattingEnabled = True
        Me.cboRhesus.Items.AddRange(New Object() {"+", "-"})
        Me.cboRhesus.Location = New System.Drawing.Point(579, 78)
        Me.cboRhesus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboRhesus.Name = "cboRhesus"
        Me.cboRhesus.Size = New System.Drawing.Size(109, 24)
        Me.cboRhesus.TabIndex = 10
        Me.cboRhesus.Text = "+"
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
        'cboBlodtypeInnkalling
        '
        Me.cboBlodtypeInnkalling.FormattingEnabled = True
        Me.cboBlodtypeInnkalling.Items.AddRange(New Object() {"A", "B", "AB", "0"})
        Me.cboBlodtypeInnkalling.Location = New System.Drawing.Point(239, 81)
        Me.cboBlodtypeInnkalling.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboBlodtypeInnkalling.Name = "cboBlodtypeInnkalling"
        Me.cboBlodtypeInnkalling.Size = New System.Drawing.Size(121, 24)
        Me.cboBlodtypeInnkalling.TabIndex = 8
        Me.cboBlodtypeInnkalling.Text = "A"
        '
        'btnInnkalling
        '
        Me.btnInnkalling.Location = New System.Drawing.Point(239, 287)
        Me.btnInnkalling.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInnkalling.Name = "btnInnkalling"
        Me.btnInnkalling.Size = New System.Drawing.Size(416, 23)
        Me.btnInnkalling.TabIndex = 7
        Me.btnInnkalling.Text = "Send innkalling"
        Me.btnInnkalling.UseVisualStyleBackColor = True
        '
        'lblBlodtypeØnsket
        '
        Me.lblBlodtypeØnsket.AutoSize = True
        Me.lblBlodtypeØnsket.Location = New System.Drawing.Point(115, 81)
        Me.lblBlodtypeØnsket.Name = "lblBlodtypeØnsket"
        Me.lblBlodtypeØnsket.Size = New System.Drawing.Size(119, 17)
        Me.lblBlodtypeØnsket.TabIndex = 6
        Me.lblBlodtypeØnsket.Text = "Ønsket blodtype: "
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Innkalling)
        Me.TabControl1.Controls.Add(Me.Søk)
        Me.TabControl1.Controls.Add(Me.Blodgivning)
        Me.TabControl1.Controls.Add(Me.Lager)
        Me.TabControl1.Controls.Add(Me.Reservasjoner)
        Me.TabControl1.Controls.Add(Me.Statistikk)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1012, 559)
        Me.TabControl1.TabIndex = 1
        '
        'Søk
        '
        Me.Søk.Controls.Add(Me.Label8)
        Me.Søk.Controls.Add(Me.cboBlodType)
        Me.Søk.Controls.Add(Me.btnEndreInfo)
        Me.Søk.Controls.Add(Me.lbPoststed)
        Me.Søk.Controls.Add(Me.txtPostnummer)
        Me.Søk.Controls.Add(Me.txtAdresse)
        Me.Søk.Controls.Add(Me.lbPoststedLabel)
        Me.Søk.Controls.Add(Me.txtFodselsdato)
        Me.Søk.Controls.Add(Me.lbPostnummer)
        Me.Søk.Controls.Add(Me.lbAdresse)
        Me.Søk.Controls.Add(Me.lbFodselsdato)
        Me.Søk.Controls.Add(Me.lbTelefon)
        Me.Søk.Controls.Add(Me.lbEtternavn)
        Me.Søk.Controls.Add(Me.lbFornavn)
        Me.Søk.Controls.Add(Me.txtTelefon)
        Me.Søk.Controls.Add(Me.txtEtternavn)
        Me.Søk.Controls.Add(Me.txtFornavn)
        Me.Søk.Controls.Add(Me.btnSok)
        Me.Søk.Controls.Add(Me.txtSok)
        Me.Søk.Controls.Add(Me.lblSok)
        Me.Søk.Location = New System.Drawing.Point(4, 25)
        Me.Søk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Søk.Name = "Søk"
        Me.Søk.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Søk.Size = New System.Drawing.Size(1004, 530)
        Me.Søk.TabIndex = 6
        Me.Søk.Text = "Søk/Endre"
        Me.Søk.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(181, 380)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 17)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Blodtype"
        '
        'cboBlodType
        '
        Me.cboBlodType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBlodType.FormattingEnabled = True
        Me.cboBlodType.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "0+", "0-", "AB+", "AB-"})
        Me.cboBlodType.Location = New System.Drawing.Point(259, 374)
        Me.cboBlodType.Margin = New System.Windows.Forms.Padding(4)
        Me.cboBlodType.Name = "cboBlodType"
        Me.cboBlodType.Size = New System.Drawing.Size(57, 26)
        Me.cboBlodType.TabIndex = 30
        '
        'btnEndreInfo
        '
        Me.btnEndreInfo.Location = New System.Drawing.Point(708, 330)
        Me.btnEndreInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEndreInfo.Name = "btnEndreInfo"
        Me.btnEndreInfo.Size = New System.Drawing.Size(109, 32)
        Me.btnEndreInfo.TabIndex = 29
        Me.btnEndreInfo.Text = "Endre info"
        Me.btnEndreInfo.UseVisualStyleBackColor = True
        '
        'lbPoststed
        '
        Me.lbPoststed.AutoSize = True
        Me.lbPoststed.Location = New System.Drawing.Point(645, 279)
        Me.lbPoststed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPoststed.Name = "lbPoststed"
        Me.lbPoststed.Size = New System.Drawing.Size(0, 17)
        Me.lbPoststed.TabIndex = 28
        '
        'txtPostnummer
        '
        Me.txtPostnummer.Location = New System.Drawing.Point(645, 225)
        Me.txtPostnummer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPostnummer.Name = "txtPostnummer"
        Me.txtPostnummer.Size = New System.Drawing.Size(132, 22)
        Me.txtPostnummer.TabIndex = 27
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(645, 174)
        Me.txtAdresse.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(196, 22)
        Me.txtAdresse.TabIndex = 26
        '
        'lbPoststedLabel
        '
        Me.lbPoststedLabel.AutoSize = True
        Me.lbPoststedLabel.Location = New System.Drawing.Point(573, 279)
        Me.lbPoststedLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPoststedLabel.Name = "lbPoststedLabel"
        Me.lbPoststedLabel.Size = New System.Drawing.Size(63, 17)
        Me.lbPoststedLabel.TabIndex = 25
        Me.lbPoststedLabel.Text = "Poststed"
        '
        'txtFodselsdato
        '
        Me.txtFodselsdato.Location = New System.Drawing.Point(259, 276)
        Me.txtFodselsdato.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFodselsdato.Name = "txtFodselsdato"
        Me.txtFodselsdato.Size = New System.Drawing.Size(132, 22)
        Me.txtFodselsdato.TabIndex = 24
        '
        'lbPostnummer
        '
        Me.lbPostnummer.AutoSize = True
        Me.lbPostnummer.Location = New System.Drawing.Point(551, 229)
        Me.lbPostnummer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPostnummer.Name = "lbPostnummer"
        Me.lbPostnummer.Size = New System.Drawing.Size(87, 17)
        Me.lbPostnummer.TabIndex = 23
        Me.lbPostnummer.Text = "Postnummer"
        '
        'lbAdresse
        '
        Me.lbAdresse.AutoSize = True
        Me.lbAdresse.Location = New System.Drawing.Point(577, 178)
        Me.lbAdresse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbAdresse.Name = "lbAdresse"
        Me.lbAdresse.Size = New System.Drawing.Size(60, 17)
        Me.lbAdresse.TabIndex = 22
        Me.lbAdresse.Text = "Adresse"
        '
        'lbFodselsdato
        '
        Me.lbFodselsdato.AutoSize = True
        Me.lbFodselsdato.Location = New System.Drawing.Point(157, 279)
        Me.lbFodselsdato.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbFodselsdato.Name = "lbFodselsdato"
        Me.lbFodselsdato.Size = New System.Drawing.Size(85, 17)
        Me.lbFodselsdato.TabIndex = 21
        Me.lbFodselsdato.Text = "Fødselsdato"
        '
        'lbTelefon
        '
        Me.lbTelefon.AutoSize = True
        Me.lbTelefon.Location = New System.Drawing.Point(181, 330)
        Me.lbTelefon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTelefon.Name = "lbTelefon"
        Me.lbTelefon.Size = New System.Drawing.Size(56, 17)
        Me.lbTelefon.TabIndex = 20
        Me.lbTelefon.Text = "Telefon"
        '
        'lbEtternavn
        '
        Me.lbEtternavn.AutoSize = True
        Me.lbEtternavn.Location = New System.Drawing.Point(172, 234)
        Me.lbEtternavn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbEtternavn.Name = "lbEtternavn"
        Me.lbEtternavn.Size = New System.Drawing.Size(69, 17)
        Me.lbEtternavn.TabIndex = 19
        Me.lbEtternavn.Text = "Etternavn"
        '
        'lbFornavn
        '
        Me.lbFornavn.AutoSize = True
        Me.lbFornavn.Location = New System.Drawing.Point(181, 182)
        Me.lbFornavn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbFornavn.Name = "lbFornavn"
        Me.lbFornavn.Size = New System.Drawing.Size(60, 17)
        Me.lbFornavn.TabIndex = 18
        Me.lbFornavn.Text = "Fornavn"
        '
        'txtTelefon
        '
        Me.txtTelefon.Location = New System.Drawing.Point(259, 326)
        Me.txtTelefon.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(132, 22)
        Me.txtTelefon.TabIndex = 17
        '
        'txtEtternavn
        '
        Me.txtEtternavn.Location = New System.Drawing.Point(259, 230)
        Me.txtEtternavn.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEtternavn.Name = "txtEtternavn"
        Me.txtEtternavn.Size = New System.Drawing.Size(132, 22)
        Me.txtEtternavn.TabIndex = 16
        '
        'txtFornavn
        '
        Me.txtFornavn.Location = New System.Drawing.Point(259, 178)
        Me.txtFornavn.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFornavn.Name = "txtFornavn"
        Me.txtFornavn.Size = New System.Drawing.Size(132, 22)
        Me.txtFornavn.TabIndex = 15
        '
        'btnSok
        '
        Me.btnSok.Location = New System.Drawing.Point(551, 102)
        Me.btnSok.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSok.Name = "btnSok"
        Me.btnSok.Size = New System.Drawing.Size(75, 23)
        Me.btnSok.TabIndex = 2
        Me.btnSok.Text = "Søk!"
        Me.btnSok.UseVisualStyleBackColor = True
        '
        'txtSok
        '
        Me.txtSok.Location = New System.Drawing.Point(324, 103)
        Me.txtSok.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSok.Name = "txtSok"
        Me.txtSok.Size = New System.Drawing.Size(207, 22)
        Me.txtSok.TabIndex = 1
        '
        'lblSok
        '
        Me.lblSok.AutoSize = True
        Me.lblSok.Location = New System.Drawing.Point(151, 105)
        Me.lblSok.Name = "lblSok"
        Me.lblSok.Size = New System.Drawing.Size(168, 17)
        Me.lblSok.TabIndex = 0
        Me.lblSok.Text = "Søk etter personnummer:"
        '
        'Ansattside
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 580)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Ansattside"
        Me.Text = "Ansattside"
        Me.Statistikk.ResumeLayout(False)
        Me.Statistikk.PerformLayout()
        Me.Reservasjoner.ResumeLayout(False)
        Me.Reservasjoner.PerformLayout()
        Me.Lager.ResumeLayout(False)
        Me.Lager.PerformLayout()
        CType(Me.gridBlodlager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Blodgivning.ResumeLayout(False)
        Me.Blodgivning.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Innkalling.ResumeLayout(False)
        Me.Innkalling.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Søk.ResumeLayout(False)
        Me.Søk.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Statistikk As TabPage
    Friend WithEvents Reservasjoner As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Reservasjonskalender As MonthCalendar
    Friend WithEvents Lager As TabPage
    Friend WithEvents Blodgivning As TabPage
    Friend WithEvents btnBlodgivning As Button
    Friend WithEvents lblMengde As Label
    Friend WithEvents lblPersnr As Label
    Friend WithEvents txtboxPersnr As TextBox
    Friend WithEvents Innkalling As TabPage
    Friend WithEvents txtAntallGivere As TextBox
    Friend WithEvents lblØnskedeGivere As Label
    Friend WithEvents cboRhesus As ComboBox
    Friend WithEvents lblRhesus As Label
    Friend WithEvents cboBlodtypeInnkalling As ComboBox
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
    Friend WithEvents gridBlodlager As DataGridView
    Friend WithEvents btnEndreInfo As Button
    Friend WithEvents lbPoststed As Label
    Friend WithEvents txtPostnummer As TextBox
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents lbPoststedLabel As Label
    Friend WithEvents txtFodselsdato As TextBox
    Friend WithEvents lbPostnummer As Label
    Friend WithEvents lbAdresse As Label
    Friend WithEvents lbFodselsdato As Label
    Friend WithEvents lbTelefon As Label
    Friend WithEvents lbEtternavn As Label
    Friend WithEvents lbFornavn As Label
    Friend WithEvents txtTelefon As TextBox
    Friend WithEvents txtEtternavn As TextBox
    Friend WithEvents txtFornavn As TextBox
    Friend WithEvents Blodtype As DataGridViewTextBoxColumn
    Friend WithEvents Blodplasma As DataGridViewTextBoxColumn
    Friend WithEvents Blodplater As DataGridViewTextBoxColumn
    Friend WithEvents Blodceller As DataGridViewTextBoxColumn
    Friend WithEvents btnTest As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLagerPersonnummer As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboBlodplater As ComboBox
    Friend WithEvents cboBlodplasma As ComboBox
    Friend WithEvents cboBlodlegeme As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboBlodType As ComboBox
End Class
