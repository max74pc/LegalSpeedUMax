<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LSUTxtNomeUtente = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.UBtnOk = New Infragistics.Win.Misc.UltraButton()
        Me.UBtnAnnulla = New Infragistics.Win.Misc.UltraButton()
        Me.LSUTxtPassword = New LSUltraPassword.LSUltraPassword()
        Me.SuspendLayout()
        '
        'LSUTxtNomeUtente
        '
        Me.LSUTxtNomeUtente.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtNomeUtente.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtNomeUtente.LarghezzaCasellaTesto = 204
        Me.LSUTxtNomeUtente.LarghezzaEtichetta = 120
        Me.LSUTxtNomeUtente.Location = New System.Drawing.Point(12, 50)
        Me.LSUTxtNomeUtente.Name = "LSUTxtNomeUtente"
        Me.LSUTxtNomeUtente.Obbligatorio = False
        Me.LSUTxtNomeUtente.Size = New System.Drawing.Size(556, 30)
        Me.LSUTxtNomeUtente.TabIndex = 0
        Me.LSUTxtNomeUtente.TestoEtichetta = "Nome Utente:"
        Me.LSUTxtNomeUtente.ValoreCasellaTesto = ""
        '
        'UBtnOk
        '
        Me.UBtnOk.Location = New System.Drawing.Point(111, 217)
        Me.UBtnOk.Name = "UBtnOk"
        Me.UBtnOk.Size = New System.Drawing.Size(131, 41)
        Me.UBtnOk.TabIndex = 2
        Me.UBtnOk.Text = "OK"
        '
        'UBtnAnnulla
        '
        Me.UBtnAnnulla.Location = New System.Drawing.Point(328, 217)
        Me.UBtnAnnulla.Name = "UBtnAnnulla"
        Me.UBtnAnnulla.Size = New System.Drawing.Size(131, 41)
        Me.UBtnAnnulla.TabIndex = 3
        Me.UBtnAnnulla.Text = "ANNULLA"
        '
        'LSUTxtPassword
        '
        Me.LSUTxtPassword.ColoreSfondoPasswordInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtPassword.ColoreSfondoPasswordInUscita = System.Drawing.Color.White
        Me.LSUTxtPassword.LarghezzaEtichetta = 120
        Me.LSUTxtPassword.LarghezzaPassword = 205
        Me.LSUTxtPassword.Location = New System.Drawing.Point(12, 139)
        Me.LSUTxtPassword.Name = "LSUTxtPassword"
        Me.LSUTxtPassword.Obbligatorio = False
        Me.LSUTxtPassword.Size = New System.Drawing.Size(556, 31)
        Me.LSUTxtPassword.TabIndex = 1
        Me.LSUTxtPassword.TestoEtichetta = "Password:"
        Me.LSUTxtPassword.ValorePassword = ""
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 322)
        Me.ControlBox = False
        Me.Controls.Add(Me.LSUTxtPassword)
        Me.Controls.Add(Me.UBtnAnnulla)
        Me.Controls.Add(Me.UBtnOk)
        Me.Controls.Add(Me.LSUTxtNomeUtente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finestra di Login"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LSUTxtNomeUtente As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents UBtnOk As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UBtnAnnulla As Infragistics.Win.Misc.UltraButton
    Friend WithEvents LSUTxtPassword As LSUltraPassword.LSUltraPassword
End Class
