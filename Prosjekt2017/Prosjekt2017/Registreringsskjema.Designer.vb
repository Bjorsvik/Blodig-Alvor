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
        Me.txtPoststed = New System.Windows.Forms.TextBox()
        Me.btnRegistrer = New System.Windows.Forms.Button()
        Me.txtTlf = New System.Windows.Forms.TextBox()
        Me.lbTlf = New System.Windows.Forms.Label()
        Me.txtBrukernavn = New System.Windows.Forms.TextBox()
        Me.txtPassord = New System.Windows.Forms.TextBox()
        Me.lbBrukernavn = New System.Windows.Forms.Label()
        Me.lbPassord = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFornavn
        '
        Me.lblFornavn.AutoSize = True
        Me.lblFornavn.Location = New System.Drawing.Point(12, 24)
        Me.lblFornavn.Name = "lblFornavn"
        Me.lblFornavn.Size = New System.Drawing.Size(46, 13)
        Me.lblFornavn.TabIndex = 0
        Me.lblFornavn.Text = "Fornavn"
        '
        'lblEtternavn
        '
        Me.lblEtternavn.AutoSize = True
        Me.lblEtternavn.Location = New System.Drawing.Point(229, 24)
        Me.lblEtternavn.Name = "lblEtternavn"
        Me.lblEtternavn.Size = New System.Drawing.Size(53, 13)
        Me.lblEtternavn.TabIndex = 1
        Me.lblEtternavn.Text = "Etternavn"
        '
        'lblFødselsdato
        '
        Me.lblFødselsdato.AutoSize = True
        Me.lblFødselsdato.Location = New System.Drawing.Point(12, 66)
        Me.lblFødselsdato.Name = "lblFødselsdato"
        Me.lblFødselsdato.Size = New System.Drawing.Size(64, 13)
        Me.lblFødselsdato.TabIndex = 2
        Me.lblFødselsdato.Text = "Fødslesdato"
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Location = New System.Drawing.Point(13, 129)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(45, 13)
        Me.lblAdresse.TabIndex = 3
        Me.lblAdresse.Text = "Adresse"
        '
        'lblPostnummer
        '
        Me.lblPostnummer.AutoSize = True
        Me.lblPostnummer.Location = New System.Drawing.Point(13, 165)
        Me.lblPostnummer.Name = "lblPostnummer"
        Me.lblPostnummer.Size = New System.Drawing.Size(65, 13)
        Me.lblPostnummer.TabIndex = 4
        Me.lblPostnummer.Text = "Postnummer"
        '
        'lblPoststed
        '
        Me.lblPoststed.AutoSize = True
        Me.lblPoststed.Location = New System.Drawing.Point(13, 200)
        Me.lblPoststed.Name = "lblPoststed"
        Me.lblPoststed.Size = New System.Drawing.Size(48, 13)
        Me.lblPoststed.TabIndex = 5
        Me.lblPoststed.Text = "Poststed"
        '
        'txtFornavn
        '
        Me.txtFornavn.Location = New System.Drawing.Point(105, 21)
        Me.txtFornavn.Name = "txtFornavn"
        Me.txtFornavn.Size = New System.Drawing.Size(100, 20)
        Me.txtFornavn.TabIndex = 6
        '
        'txtEtternavn
        '
        Me.txtEtternavn.Location = New System.Drawing.Point(288, 21)
        Me.txtEtternavn.Name = "txtEtternavn"
        Me.txtEtternavn.Size = New System.Drawing.Size(100, 20)
        Me.txtEtternavn.TabIndex = 7
        '
        'txtFodselsdato
        '
        Me.txtFodselsdato.Location = New System.Drawing.Point(105, 66)
        Me.txtFodselsdato.Name = "txtFodselsdato"
        Me.txtFodselsdato.Size = New System.Drawing.Size(100, 20)
        Me.txtFodselsdato.TabIndex = 8
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(105, 122)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(100, 20)
        Me.txtAdresse.TabIndex = 9
        '
        'txtPostnummer
        '
        Me.txtPostnummer.Location = New System.Drawing.Point(105, 158)
        Me.txtPostnummer.Name = "txtPostnummer"
        Me.txtPostnummer.Size = New System.Drawing.Size(100, 20)
        Me.txtPostnummer.TabIndex = 10
        '
        'txtPoststed
        '
        Me.txtPoststed.Location = New System.Drawing.Point(105, 193)
        Me.txtPoststed.Name = "txtPoststed"
        Me.txtPoststed.Size = New System.Drawing.Size(100, 20)
        Me.txtPoststed.TabIndex = 11
        '
        'btnRegistrer
        '
        Me.btnRegistrer.Location = New System.Drawing.Point(288, 289)
        Me.btnRegistrer.Name = "btnRegistrer"
        Me.btnRegistrer.Size = New System.Drawing.Size(97, 41)
        Me.btnRegistrer.TabIndex = 12
        Me.btnRegistrer.Text = "Registrer"
        Me.btnRegistrer.UseVisualStyleBackColor = True
        '
        'txtTlf
        '
        Me.txtTlf.Location = New System.Drawing.Point(288, 66)
        Me.txtTlf.Name = "txtTlf"
        Me.txtTlf.Size = New System.Drawing.Size(100, 20)
        Me.txtTlf.TabIndex = 13
        '
        'lbTlf
        '
        Me.lbTlf.AutoSize = True
        Me.lbTlf.Location = New System.Drawing.Point(235, 69)
        Me.lbTlf.Name = "lbTlf"
        Me.lbTlf.Size = New System.Drawing.Size(43, 13)
        Me.lbTlf.TabIndex = 14
        Me.lbTlf.Text = "Telefon"
        '
        'txtBrukernavn
        '
        Me.txtBrukernavn.Location = New System.Drawing.Point(105, 286)
        Me.txtBrukernavn.Name = "txtBrukernavn"
        Me.txtBrukernavn.Size = New System.Drawing.Size(100, 20)
        Me.txtBrukernavn.TabIndex = 15
        '
        'txtPassord
        '
        Me.txtPassord.Location = New System.Drawing.Point(105, 312)
        Me.txtPassord.Name = "txtPassord"
        Me.txtPassord.Size = New System.Drawing.Size(100, 20)
        Me.txtPassord.TabIndex = 16
        '
        'lbBrukernavn
        '
        Me.lbBrukernavn.AutoSize = True
        Me.lbBrukernavn.Location = New System.Drawing.Point(41, 289)
        Me.lbBrukernavn.Name = "lbBrukernavn"
        Me.lbBrukernavn.Size = New System.Drawing.Size(62, 13)
        Me.lbBrukernavn.TabIndex = 17
        Me.lbBrukernavn.Text = "Brukernavn"
        '
        'lbPassord
        '
        Me.lbPassord.AutoSize = True
        Me.lbPassord.Location = New System.Drawing.Point(54, 315)
        Me.lbPassord.Name = "lbPassord"
        Me.lbPassord.Size = New System.Drawing.Size(45, 13)
        Me.lbPassord.TabIndex = 18
        Me.lbPassord.Text = "Passord"
        '
        'Registreringsskjema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 388)
        Me.Controls.Add(Me.lbPassord)
        Me.Controls.Add(Me.lbBrukernavn)
        Me.Controls.Add(Me.txtPassord)
        Me.Controls.Add(Me.txtBrukernavn)
        Me.Controls.Add(Me.lbTlf)
        Me.Controls.Add(Me.txtTlf)
        Me.Controls.Add(Me.btnRegistrer)
        Me.Controls.Add(Me.txtPoststed)
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
    Friend WithEvents txtPoststed As TextBox
    Friend WithEvents btnRegistrer As Button
    Friend WithEvents txtTlf As TextBox
    Friend WithEvents lbTlf As Label
    Friend WithEvents txtBrukernavn As TextBox
    Friend WithEvents txtPassord As TextBox
    Friend WithEvents lbBrukernavn As Label
    Friend WithEvents lbPassord As Label
End Class
