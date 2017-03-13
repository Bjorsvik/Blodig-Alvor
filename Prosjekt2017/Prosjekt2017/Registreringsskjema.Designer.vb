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
        Me.lblFødselsdato = New System.Windows.Forms.Label()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.lblPostnummer = New System.Windows.Forms.Label()
        Me.lblPoststed = New System.Windows.Forms.Label()
        Me.txtFornavn = New System.Windows.Forms.TextBox()
        Me.txtEtternavn = New System.Windows.Forms.TextBox()
        Me.txtFodselsdato = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.txtPostnummer = New System.Windows.Forms.TextBox()
        Me.btnRegistrer = New System.Windows.Forms.Button()
        Me.txtTlf = New System.Windows.Forms.TextBox()
        Me.lbTlf = New System.Windows.Forms.Label()
        Me.txtBrukernavn = New System.Windows.Forms.TextBox()
        Me.txtPassord = New System.Windows.Forms.TextBox()
        Me.lbBrukernavn = New System.Windows.Forms.Label()
        Me.lbPassord = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBekreftPassord = New System.Windows.Forms.TextBox()
        Me.lbPoststed = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFornavn
        '
        Me.lblFornavn.AutoSize = True
        Me.lblFornavn.Location = New System.Drawing.Point(18, 37)
        Me.lblFornavn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFornavn.Name = "lblFornavn"
        Me.lblFornavn.Size = New System.Drawing.Size(67, 20)
        Me.lblFornavn.TabIndex = 0
        Me.lblFornavn.Text = "Fornavn"
        '
        'lblEtternavn
        '
        Me.lblEtternavn.AutoSize = True
        Me.lblEtternavn.Location = New System.Drawing.Point(344, 37)
        Me.lblEtternavn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEtternavn.Name = "lblEtternavn"
        Me.lblEtternavn.Size = New System.Drawing.Size(78, 20)
        Me.lblEtternavn.TabIndex = 1
        Me.lblEtternavn.Text = "Etternavn"
        '
        'lblFødselsdato
        '
        Me.lblFødselsdato.AutoSize = True
        Me.lblFødselsdato.Location = New System.Drawing.Point(18, 102)
        Me.lblFødselsdato.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFødselsdato.Name = "lblFødselsdato"
        Me.lblFødselsdato.Size = New System.Drawing.Size(97, 20)
        Me.lblFødselsdato.TabIndex = 2
        Me.lblFødselsdato.Text = "Fødslesdato"
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Location = New System.Drawing.Point(20, 198)
        Me.lblAdresse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(68, 20)
        Me.lblAdresse.TabIndex = 3
        Me.lblAdresse.Text = "Adresse"
        '
        'lblPostnummer
        '
        Me.lblPostnummer.AutoSize = True
        Me.lblPostnummer.Location = New System.Drawing.Point(20, 254)
        Me.lblPostnummer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPostnummer.Name = "lblPostnummer"
        Me.lblPostnummer.Size = New System.Drawing.Size(99, 20)
        Me.lblPostnummer.TabIndex = 4
        Me.lblPostnummer.Text = "Postnummer"
        '
        'lblPoststed
        '
        Me.lblPoststed.AutoSize = True
        Me.lblPoststed.Location = New System.Drawing.Point(27, 300)
        Me.lblPoststed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPoststed.Name = "lblPoststed"
        Me.lblPoststed.Size = New System.Drawing.Size(72, 20)
        Me.lblPoststed.TabIndex = 5
        Me.lblPoststed.Text = "Poststed"
        '
        'txtFornavn
        '
        Me.txtFornavn.Location = New System.Drawing.Point(158, 32)
        Me.txtFornavn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFornavn.Name = "txtFornavn"
        Me.txtFornavn.Size = New System.Drawing.Size(148, 26)
        Me.txtFornavn.TabIndex = 6
        '
        'txtEtternavn
        '
        Me.txtEtternavn.Location = New System.Drawing.Point(432, 32)
        Me.txtEtternavn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEtternavn.Name = "txtEtternavn"
        Me.txtEtternavn.Size = New System.Drawing.Size(148, 26)
        Me.txtEtternavn.TabIndex = 7
        '
        'txtFodselsdato
        '
        Me.txtFodselsdato.Location = New System.Drawing.Point(158, 102)
        Me.txtFodselsdato.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFodselsdato.Name = "txtFodselsdato"
        Me.txtFodselsdato.Size = New System.Drawing.Size(148, 26)
        Me.txtFodselsdato.TabIndex = 8
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(158, 188)
        Me.txtAdresse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(148, 26)
        Me.txtAdresse.TabIndex = 9
        '
        'txtPostnummer
        '
        Me.txtPostnummer.Location = New System.Drawing.Point(158, 251)
        Me.txtPostnummer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPostnummer.Name = "txtPostnummer"
        Me.txtPostnummer.Size = New System.Drawing.Size(148, 26)
        Me.txtPostnummer.TabIndex = 10
        '
        'btnRegistrer
        '
        Me.btnRegistrer.Location = New System.Drawing.Point(432, 445)
        Me.btnRegistrer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRegistrer.Name = "btnRegistrer"
        Me.btnRegistrer.Size = New System.Drawing.Size(146, 63)
        Me.btnRegistrer.TabIndex = 12
        Me.btnRegistrer.Text = "Registrer"
        Me.btnRegistrer.UseVisualStyleBackColor = True
        '
        'txtTlf
        '
        Me.txtTlf.Location = New System.Drawing.Point(432, 102)
        Me.txtTlf.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTlf.Name = "txtTlf"
        Me.txtTlf.Size = New System.Drawing.Size(148, 26)
        Me.txtTlf.TabIndex = 13
        '
        'lbTlf
        '
        Me.lbTlf.AutoSize = True
        Me.lbTlf.Location = New System.Drawing.Point(352, 106)
        Me.lbTlf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTlf.Name = "lbTlf"
        Me.lbTlf.Size = New System.Drawing.Size(62, 20)
        Me.lbTlf.TabIndex = 14
        Me.lbTlf.Text = "Telefon"
        '
        'txtBrukernavn
        '
        Me.txtBrukernavn.Location = New System.Drawing.Point(158, 440)
        Me.txtBrukernavn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBrukernavn.Name = "txtBrukernavn"
        Me.txtBrukernavn.Size = New System.Drawing.Size(148, 26)
        Me.txtBrukernavn.TabIndex = 15
        '
        'txtPassord
        '
        Me.txtPassord.Location = New System.Drawing.Point(158, 480)
        Me.txtPassord.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPassord.Name = "txtPassord"
        Me.txtPassord.Size = New System.Drawing.Size(148, 26)
        Me.txtPassord.TabIndex = 16
        '
        'lbBrukernavn
        '
        Me.lbBrukernavn.AutoSize = True
        Me.lbBrukernavn.Location = New System.Drawing.Point(62, 445)
        Me.lbBrukernavn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbBrukernavn.Name = "lbBrukernavn"
        Me.lbBrukernavn.Size = New System.Drawing.Size(90, 20)
        Me.lbBrukernavn.TabIndex = 17
        Me.lbBrukernavn.Text = "Brukernavn"
        '
        'lbPassord
        '
        Me.lbPassord.AutoSize = True
        Me.lbPassord.Location = New System.Drawing.Point(81, 485)
        Me.lbPassord.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPassord.Name = "lbPassord"
        Me.lbPassord.Size = New System.Drawing.Size(67, 20)
        Me.lbPassord.TabIndex = 18
        Me.lbPassord.Text = "Passord"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 520)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Bekreft passord"
        '
        'txtBekreftPassord
        '
        Me.txtBekreftPassord.Location = New System.Drawing.Point(158, 515)
        Me.txtBekreftPassord.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBekreftPassord.Name = "txtBekreftPassord"
        Me.txtBekreftPassord.Size = New System.Drawing.Size(148, 26)
        Me.txtBekreftPassord.TabIndex = 20
        '
        'lbPoststed
        '
        Me.lbPoststed.AutoSize = True
        Me.lbPoststed.Location = New System.Drawing.Point(154, 300)
        Me.lbPoststed.Name = "lbPoststed"
        Me.lbPoststed.Size = New System.Drawing.Size(57, 20)
        Me.lbPoststed.TabIndex = 21
        Me.lbPoststed.Text = "Label2"
        '
        'Registreringsskjema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 597)
        Me.Controls.Add(Me.lbPoststed)
        Me.Controls.Add(Me.txtBekreftPassord)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbPassord)
        Me.Controls.Add(Me.lbBrukernavn)
        Me.Controls.Add(Me.txtPassord)
        Me.Controls.Add(Me.txtBrukernavn)
        Me.Controls.Add(Me.lbTlf)
        Me.Controls.Add(Me.txtTlf)
        Me.Controls.Add(Me.btnRegistrer)
        Me.Controls.Add(Me.txtPostnummer)
        Me.Controls.Add(Me.txtAdresse)
        Me.Controls.Add(Me.txtFodselsdato)
        Me.Controls.Add(Me.txtEtternavn)
        Me.Controls.Add(Me.txtFornavn)
        Me.Controls.Add(Me.lblPoststed)
        Me.Controls.Add(Me.lblPostnummer)
        Me.Controls.Add(Me.lblAdresse)
        Me.Controls.Add(Me.lblFødselsdato)
        Me.Controls.Add(Me.lblEtternavn)
        Me.Controls.Add(Me.lblFornavn)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Registreringsskjema"
        Me.Text = "Registreringsskjema"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFornavn As Label
    Friend WithEvents lblEtternavn As Label
    Friend WithEvents lblFødselsdato As Label
    Friend WithEvents lblAdresse As Label
    Friend WithEvents lblPostnummer As Label
    Friend WithEvents lblPoststed As Label
    Friend WithEvents txtFornavn As TextBox
    Friend WithEvents txtEtternavn As TextBox
    Friend WithEvents txtFodselsdato As TextBox
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents txtPostnummer As TextBox
    Friend WithEvents btnRegistrer As Button
    Friend WithEvents txtTlf As TextBox
    Friend WithEvents lbTlf As Label
    Friend WithEvents txtBrukernavn As TextBox
    Friend WithEvents txtPassord As TextBox
    Friend WithEvents lbBrukernavn As Label
    Friend WithEvents lbPassord As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBekreftPassord As TextBox
    Friend WithEvents lbPoststed As Label
End Class
