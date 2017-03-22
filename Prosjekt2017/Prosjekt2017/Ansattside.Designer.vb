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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtAntallGivere = New System.Windows.Forms.TextBox()
        Me.lblAntallGivere = New System.Windows.Forms.Label()
        Me.cboxRhesus = New System.Windows.Forms.ComboBox()
        Me.lblRhesus = New System.Windows.Forms.Label()
        Me.cboxBlodtype = New System.Windows.Forms.ComboBox()
        Me.btnInnkalling = New System.Windows.Forms.Button()
        Me.lblBlodtype = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblBestillinger = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(894, 541)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtAntallGivere)
        Me.TabPage1.Controls.Add(Me.lblAntallGivere)
        Me.TabPage1.Controls.Add(Me.cboxRhesus)
        Me.TabPage1.Controls.Add(Me.lblRhesus)
        Me.TabPage1.Controls.Add(Me.cboxBlodtype)
        Me.TabPage1.Controls.Add(Me.btnInnkalling)
        Me.TabPage1.Controls.Add(Me.lblBlodtype)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(886, 512)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Innkalling av blodgivere"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtAntallGivere
        '
        Me.txtAntallGivere.Location = New System.Drawing.Point(290, 162)
        Me.txtAntallGivere.Name = "txtAntallGivere"
        Me.txtAntallGivere.Size = New System.Drawing.Size(121, 22)
        Me.txtAntallGivere.TabIndex = 12
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
        'cboxRhesus
        '
        Me.cboxRhesus.FormattingEnabled = True
        Me.cboxRhesus.Items.AddRange(New Object() {"+", "-"})
        Me.cboxRhesus.Location = New System.Drawing.Point(501, 81)
        Me.cboxRhesus.Name = "cboxRhesus"
        Me.cboxRhesus.Size = New System.Drawing.Size(109, 24)
        Me.cboxRhesus.TabIndex = 10
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
        'cboxBlodtype
        '
        Me.cboxBlodtype.FormattingEnabled = True
        Me.cboxBlodtype.Items.AddRange(New Object() {"A", "B", "AB", "0"})
        Me.cboxBlodtype.Location = New System.Drawing.Point(290, 81)
        Me.cboxBlodtype.Name = "cboxBlodtype"
        Me.cboxBlodtype.Size = New System.Drawing.Size(121, 24)
        Me.cboxBlodtype.TabIndex = 8
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
        'lblBlodtype
        '
        Me.lblBlodtype.AutoSize = True
        Me.lblBlodtype.Location = New System.Drawing.Point(165, 81)
        Me.lblBlodtype.Name = "lblBlodtype"
        Me.lblBlodtype.Size = New System.Drawing.Size(119, 17)
        Me.lblBlodtype.TabIndex = 6
        Me.lblBlodtype.Text = "Ønsket blodtype: "
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblBestillinger)
        Me.TabPage2.Controls.Add(Me.ListBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(886, 512)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Utleveringer og bestillinger"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.ListBox2)
        Me.TabPage3.Controls.Add(Me.MonthCalendar1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(886, 512)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Oversikt av reservasjoner"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(886, 512)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Statistikk"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(886, 512)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Tapping"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(35, 104)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(226, 276)
        Me.ListBox1.TabIndex = 0
        '
        'lblBestillinger
        '
        Me.lblBestillinger.AutoSize = True
        Me.lblBestillinger.Location = New System.Drawing.Point(32, 51)
        Me.lblBestillinger.Name = "lblBestillinger"
        Me.lblBestillinger.Size = New System.Drawing.Size(168, 17)
        Me.lblBestillinger.TabIndex = 1
        Me.lblBestillinger.Text = "Oversikt over bestillinger:"
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
        'Ansattside
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 532)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Ansattside"
        Me.Text = "Ansattside"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents lblAntallGivere As Label
    Friend WithEvents cboxRhesus As ComboBox
    Friend WithEvents lblRhesus As Label
    Friend WithEvents cboxBlodtype As ComboBox
    Friend WithEvents btnInnkalling As Button
    Friend WithEvents lblBlodtype As Label
    Friend WithEvents txtAntallGivere As TextBox
    Friend WithEvents lblBestillinger As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
End Class
