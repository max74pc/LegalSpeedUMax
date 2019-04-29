<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LSUltraCasellaTesto
    Inherits System.Windows.Forms.UserControl

    'UserControl1 esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UTxtCasellaTesto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ULblDescrizione = New Infragistics.Win.Misc.UltraLabel()
        Me.ULblCampoObbligatorio = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.UTxtCasellaTesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UTxtCasellaTesto
        '
        Me.UTxtCasellaTesto.Font = New System.Drawing.Font("Linux Libertine Display G", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UTxtCasellaTesto.Location = New System.Drawing.Point(221, 3)
        Me.UTxtCasellaTesto.Name = "UTxtCasellaTesto"
        Me.UTxtCasellaTesto.Size = New System.Drawing.Size(204, 26)
        Me.UTxtCasellaTesto.TabIndex = 0
        '
        'ULblDescrizione
        '
        Me.ULblDescrizione.Font = New System.Drawing.Font("Linux Libertine Display G", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ULblDescrizione.Location = New System.Drawing.Point(4, 3)
        Me.ULblDescrizione.Name = "ULblDescrizione"
        Me.ULblDescrizione.Size = New System.Drawing.Size(209, 23)
        Me.ULblDescrizione.TabIndex = 1
        Me.ULblDescrizione.Text = "Descrizione"
        '
        'ULblCampoObbligatorio
        '
        Appearance1.ForeColor = System.Drawing.Color.Red
        Me.ULblCampoObbligatorio.Appearance = Appearance1
        Me.ULblCampoObbligatorio.Font = New System.Drawing.Font("Linux Libertine Display G", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ULblCampoObbligatorio.Location = New System.Drawing.Point(431, 4)
        Me.ULblCampoObbligatorio.Name = "ULblCampoObbligatorio"
        Me.ULblCampoObbligatorio.Size = New System.Drawing.Size(26, 23)
        Me.ULblCampoObbligatorio.TabIndex = 2
        Me.ULblCampoObbligatorio.Text = "*"
        '
        'LSUltraCasellaTesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ULblCampoObbligatorio)
        Me.Controls.Add(Me.ULblDescrizione)
        Me.Controls.Add(Me.UTxtCasellaTesto)
        Me.Name = "LSUltraCasellaTesto"
        Me.Size = New System.Drawing.Size(460, 30)
        CType(Me.UTxtCasellaTesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UTxtCasellaTesto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ULblDescrizione As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ULblCampoObbligatorio As Infragistics.Win.Misc.UltraLabel
End Class
