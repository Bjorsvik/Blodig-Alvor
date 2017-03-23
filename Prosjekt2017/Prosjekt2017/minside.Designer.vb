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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabBrukerinfo = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tabHistorikk = New System.Windows.Forms.TabPage()
        Me.tabReservasjon = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSkjema = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabBrukerinfo.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabBrukerinfo.Controls.Add(Me.DataGridView1)
        Me.tabBrukerinfo.Location = New System.Drawing.Point(4, 25)
        Me.tabBrukerinfo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabBrukerinfo.Name = "tabBrukerinfo"
        Me.tabBrukerinfo.Size = New System.Drawing.Size(1051, 519)
        Me.tabBrukerinfo.TabIndex = 0
        Me.tabBrukerinfo.Text = "Brukerinfo"
        Me.tabBrukerinfo.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(136, 26)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(759, 420)
        Me.DataGridView1.TabIndex = 20
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabReservasjon.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabBrukerinfo As TabPage
    Friend WithEvents tabHistorikk As TabPage
    Friend WithEvents tabReservasjon As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSkjema As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
