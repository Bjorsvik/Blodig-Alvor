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
        Me.Reservasjoner = New System.Windows.Forms.TabPage()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Lageroppdatering = New System.Windows.Forms.TabPage()
        Me.Lagerbeholdning = New System.Windows.Forms.TabPage()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Blodgivning = New System.Windows.Forms.TabPage()
        Me.Innkalling = New System.Windows.Forms.TabPage()
        Me.lblBlodtype = New System.Windows.Forms.Label()
        Me.btnInnkalling = New System.Windows.Forms.Button()
        Me.cboxBlodtype = New System.Windows.Forms.ComboBox()
        Me.lblRhesus = New System.Windows.Forms.Label()
        Me.cboxRhesus = New System.Windows.Forms.ComboBox()
        Me.lblAntallGivere = New System.Windows.Forms.Label()
        Me.txtAntallGivere = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.KalenderGivning = New System.Windows.Forms.MonthCalendar()
        Me.lblGivningDato = New System.Windows.Forms.Label()
        Me.lblMengde = New System.Windows.Forms.Label()
        Me.lblPersnr = New System.Windows.Forms.Label()
        Me.txtMengde = New System.Windows.Forms.TextBox()
        Me.txtboxPersnr = New System.Windows.Forms.TextBox()
        Me.btnBlodgivning = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.Reservasjoner.SuspendLayout()
        Me.Lagerbeholdning.SuspendLayout()
        Me.Blodgivning.SuspendLayout()
        Me.Innkalling.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Statistikk
        '
        Me.Statistikk.Location = New System.Drawing.Point(4, 25)
        Me.Statistikk.Name = "Statistikk"
        Me.Statistikk.Padding = New System.Windows.Forms.Padding(3)
        Me.Statistikk.Size = New System.Drawing.Size(886, 512)
        Me.Statistikk.TabIndex = 5
        Me.Statistikk.Text = "Statistikk"
        Me.Statistikk.UseVisualStyleBackColor = True
        '
        'Reservasjoner
        '
        Me.Reservasjoner.Controls.Add(Me.Label2)
        Me.Reservasjoner.Controls.Add(Me.ListBox1)
        Me.Reservasjoner.Controls.Add(Me.MonthCalendar2)
        Me.Reservasjoner.Controls.Add(Me.Label6)
        Me.Reservasjoner.Controls.Add(Me.ListBox3)
        Me.Reservasjoner.Controls.Add(Me.Label5)
        Me.Reservasjoner.Controls.Add(Me.Label4)
        Me.Reservasjoner.Controls.Add(Me.TextBox5)
        Me.Reservasjoner.Controls.Add(Me.TextBox4)
        Me.Reservasjoner.Controls.Add(Me.TextBox3)
        Me.Reservasjoner.Location = New System.Drawing.Point(4, 25)
        Me.Reservasjoner.Name = "Reservasjoner"
        Me.Reservasjoner.Padding = New System.Windows.Forms.Padding(3)
        Me.Reservasjoner.Size = New System.Drawing.Size(886, 512)
        Me.Reservasjoner.TabIndex = 4
        Me.Reservasjoner.Text = "Reservasjoner"
        Me.Reservasjoner.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(685, 375)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(685, 403)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 22)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(685, 431)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 22)
        Me.TextBox5.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(543, 404)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Blodplasma:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(543, 436)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Blodplater: "
        '
        'Lageroppdatering
        '
        Me.Lageroppdatering.Location = New System.Drawing.Point(4, 25)
        Me.Lageroppdatering.Name = "Lageroppdatering"
        Me.Lageroppdatering.Padding = New System.Windows.Forms.Padding(3)
        Me.Lageroppdatering.Size = New System.Drawing.Size(886, 512)
        Me.Lageroppdatering.TabIndex = 3
        Me.Lageroppdatering.Text = "Lageroppdatering"
        Me.Lageroppdatering.UseVisualStyleBackColor = True
        '
        'Lagerbeholdning
        '
        Me.Lagerbeholdning.Controls.Add(Me.Label1)
        Me.Lagerbeholdning.Controls.Add(Me.ListBox2)
        Me.Lagerbeholdning.Controls.Add(Me.MonthCalendar1)
        Me.Lagerbeholdning.Location = New System.Drawing.Point(4, 25)
        Me.Lagerbeholdning.Name = "Lagerbeholdning"
        Me.Lagerbeholdning.Padding = New System.Windows.Forms.Padding(3)
        Me.Lagerbeholdning.Size = New System.Drawing.Size(886, 512)
        Me.Lagerbeholdning.TabIndex = 2
        Me.Lagerbeholdning.Text = "Lagerbeholdning"
        Me.Lagerbeholdning.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(49, 61)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(404, 61)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(291, 324)
        Me.ListBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(401, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Blodgivning
        '
        Me.Blodgivning.Controls.Add(Me.btnBlodgivning)
        Me.Blodgivning.Controls.Add(Me.KalenderGivning)
        Me.Blodgivning.Controls.Add(Me.lblGivningDato)
        Me.Blodgivning.Controls.Add(Me.lblMengde)
        Me.Blodgivning.Controls.Add(Me.lblPersnr)
        Me.Blodgivning.Controls.Add(Me.txtMengde)
        Me.Blodgivning.Controls.Add(Me.txtboxPersnr)
        Me.Blodgivning.Location = New System.Drawing.Point(4, 25)
        Me.Blodgivning.Name = "Blodgivning"
        Me.Blodgivning.Padding = New System.Windows.Forms.Padding(3)
        Me.Blodgivning.Size = New System.Drawing.Size(886, 512)
        Me.Blodgivning.TabIndex = 1
        Me.Blodgivning.Text = "Blodgivning"
        Me.Blodgivning.UseVisualStyleBackColor = True
        '
        'Innkalling
        '
        Me.Innkalling.Controls.Add(Me.txtAntallGivere)
        Me.Innkalling.Controls.Add(Me.lblAntallGivere)
        Me.Innkalling.Controls.Add(Me.cboxRhesus)
        Me.Innkalling.Controls.Add(Me.lblRhesus)
        Me.Innkalling.Controls.Add(Me.cboxBlodtype)
        Me.Innkalling.Controls.Add(Me.btnInnkalling)
        Me.Innkalling.Controls.Add(Me.lblBlodtype)
        Me.Innkalling.Location = New System.Drawing.Point(4, 25)
        Me.Innkalling.Name = "Innkalling"
        Me.Innkalling.Padding = New System.Windows.Forms.Padding(3)
        Me.Innkalling.Size = New System.Drawing.Size(886, 512)
        Me.Innkalling.TabIndex = 0
        Me.Innkalling.Text = "Innkalling"
        Me.Innkalling.UseVisualStyleBackColor = True
        '
        'lblBlodtype
        '
        Me.lblBlodtype.AutoSize = True
        Me.lblBlodtype.Location = New System.Drawing.Point(165, 81)
        Me.lblBlodtype.Name = "lblBlodtype"
        Me.lblBlodtype.Size = New System.Drawing.Size(119, 17)
        Me.lblBlodtype.TabIndex = 6
        Me.lblBlodtype.Text = "Ønsket blodtype: "
        '
        'btnInnkalling
        '
        Me.btnInnkalling.Location = New System.Drawing.Point(488, 156)
        Me.btnInnkalling.Name = "btnInnkalling"
        Me.btnInnkalling.Size = New System.Drawing.Size(152, 23)
        Me.btnInnkalling.TabIndex = 7
        Me.btnInnkalling.Text = "Send innkalling"
        Me.btnInnkalling.UseVisualStyleBackColor = True
        '
        'cboxBlodtype
        '
        Me.cboxBlodtype.FormattingEnabled = True
        Me.cboxBlodtype.Items.AddRange(New Object() {"A", "B", "AB", "0"})
        Me.cboxBlodtype.Location = New System.Drawing.Point(290, 81)
        Me.cboxBlodtype.Name = "cboxBlodtype"
        Me.cboxBlodtype.Size = New System.Drawing.Size(121, 24)
        Me.cboxBlodtype.TabIndex = 8
        '
        'lblRhesus
        '
        Me.lblRhesus.AutoSize = True
        Me.lblRhesus.Location = New System.Drawing.Point(431, 81)
        Me.lblRhesus.Name = "lblRhesus"
        Me.lblRhesus.Size = New System.Drawing.Size(64, 17)
        Me.lblRhesus.TabIndex = 9
        Me.lblRhesus.Text = "Rhesus: "
        '
        'cboxRhesus
        '
        Me.cboxRhesus.FormattingEnabled = True
        Me.cboxRhesus.Items.AddRange(New Object() {"+", "-"})
        Me.cboxRhesus.Location = New System.Drawing.Point(501, 81)
        Me.cboxRhesus.Name = "cboxRhesus"
        Me.cboxRhesus.Size = New System.Drawing.Size(109, 24)
        Me.cboxRhesus.TabIndex = 10
        '
        'lblAntallGivere
        '
        Me.lblAntallGivere.AutoSize = True
        Me.lblAntallGivere.Location = New System.Drawing.Point(165, 162)
        Me.lblAntallGivere.Name = "lblAntallGivere"
        Me.lblAntallGivere.Size = New System.Drawing.Size(117, 17)
        Me.lblAntallGivere.TabIndex = 11
        Me.lblAntallGivere.Text = "Antall blodgivere:"
        '
        'txtAntallGivere
        '
        Me.txtAntallGivere.Location = New System.Drawing.Point(290, 162)
        Me.txtAntallGivere.Name = "txtAntallGivere"
        Me.txtAntallGivere.Size = New System.Drawing.Size(121, 22)
        Me.txtAntallGivere.TabIndex = 12
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Innkalling)
        Me.TabControl1.Controls.Add(Me.Blodgivning)
        Me.TabControl1.Controls.Add(Me.Lagerbeholdning)
        Me.TabControl1.Controls.Add(Me.Lageroppdatering)
        Me.TabControl1.Controls.Add(Me.Reservasjoner)
        Me.TabControl1.Controls.Add(Me.Statistikk)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(894, 541)
        Me.TabControl1.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(543, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Oversikt over bestillinger:"
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 16
        Me.ListBox3.Location = New System.Drawing.Point(546, 70)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(226, 276)
        Me.ListBox3.TabIndex = 11
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
        Me.lblMengde.Location = New System.Drawing.Point(55, 85)
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
        'txtMengde
        '
        Me.txtMengde.Location = New System.Drawing.Point(197, 82)
        Me.txtMengde.Name = "txtMengde"
        Me.txtMengde.Size = New System.Drawing.Size(137, 22)
        Me.txtMengde.TabIndex = 12
        '
        'txtboxPersnr
        '
        Me.txtboxPersnr.Location = New System.Drawing.Point(197, 54)
        Me.txtboxPersnr.Name = "txtboxPersnr"
        Me.txtboxPersnr.Size = New System.Drawing.Size(137, 22)
        Me.txtboxPersnr.TabIndex = 11
        '
        'btnBlodgivning
        '
        Me.btnBlodgivning.Location = New System.Drawing.Point(398, 69)
        Me.btnBlodgivning.Name = "btnBlodgivning"
        Me.btnBlodgivning.Size = New System.Drawing.Size(355, 278)
        Me.btnBlodgivning.TabIndex = 17
        Me.btnBlodgivning.Text = "Send inn"
        Me.btnBlodgivning.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(325, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Label2"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(299, 70)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(115, 212)
        Me.ListBox1.TabIndex = 14
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(11, 70)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 13
        '
        'Ansattside
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 532)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Ansattside"
        Me.Text = "Ansattside"
        Me.Reservasjoner.ResumeLayout(False)
        Me.Reservasjoner.PerformLayout()
        Me.Lagerbeholdning.ResumeLayout(False)
        Me.Lagerbeholdning.PerformLayout()
        Me.Blodgivning.ResumeLayout(False)
        Me.Blodgivning.PerformLayout()
        Me.Innkalling.ResumeLayout(False)
        Me.Innkalling.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Statistikk As TabPage
    Friend WithEvents Reservasjoner As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents Label6 As Label
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Lageroppdatering As TabPage
    Friend WithEvents Lagerbeholdning As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Blodgivning As TabPage
    Friend WithEvents btnBlodgivning As Button
    Friend WithEvents KalenderGivning As MonthCalendar
    Friend WithEvents lblGivningDato As Label
    Friend WithEvents lblMengde As Label
    Friend WithEvents lblPersnr As Label
    Friend WithEvents txtMengde As TextBox
    Friend WithEvents txtboxPersnr As TextBox
    Friend WithEvents Innkalling As TabPage
    Friend WithEvents txtAntallGivere As TextBox
    Friend WithEvents lblAntallGivere As Label
    Friend WithEvents cboxRhesus As ComboBox
    Friend WithEvents lblRhesus As Label
    Friend WithEvents cboxBlodtype As ComboBox
    Friend WithEvents btnInnkalling As Button
    Friend WithEvents lblBlodtype As Label
    Friend WithEvents TabControl1 As TabControl
End Class
