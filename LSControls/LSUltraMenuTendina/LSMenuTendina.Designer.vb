<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LSMenuTendina
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
        Me.ULblDescrizione = New Infragistics.Win.Misc.UltraLabel()
        Me.UMenuTendina = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.ULblCampoObbligatorio = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.UMenuTendina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ULblDescrizione
        '
        Me.ULblDescrizione.Font = New System.Drawing.Font("Linux Libertine Display G", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ULblDescrizione.Location = New System.Drawing.Point(3, 3)
        Me.ULblDescrizione.Name = "ULblDescrizione"
        Me.ULblDescrizione.Size = New System.Drawing.Size(156, 23)
        Me.ULblDescrizione.TabIndex = 0
        Me.ULblDescrizione.Text = "Descrizione"
        '
        'UMenuTendina
        '
        Me.UMenuTendina.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.UMenuTendina.Font = New System.Drawing.Font("Linux Libertine Display G", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UMenuTendina.Location = New System.Drawing.Point(165, 3)
        Me.UMenuTendina.Name = "UMenuTendina"
        Me.UMenuTendina.Size = New System.Drawing.Size(241, 26)
        Me.UMenuTendina.TabIndex = 1
        '
        'ULblCampoObbligatorio
        '
        Appearance1.ForeColor = System.Drawing.Color.Red
        Me.ULblCampoObbligatorio.Appearance = Appearance1
        Me.ULblCampoObbligatorio.Font = New System.Drawing.Font("Linux Libertine Display G", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ULblCampoObbligatorio.Location = New System.Drawing.Point(412, 4)
        Me.ULblCampoObbligatorio.Name = "ULblCampoObbligatorio"
        Me.ULblCampoObbligatorio.Size = New System.Drawing.Size(26, 23)
        Me.ULblCampoObbligatorio.TabIndex = 4
        Me.ULblCampoObbligatorio.Text = "*"
        '
        'LSMenuTendina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ULblCampoObbligatorio)
        Me.Controls.Add(Me.UMenuTendina)
        Me.Controls.Add(Me.ULblDescrizione)
        Me.Name = "LSMenuTendina"
        Me.Size = New System.Drawing.Size(440, 32)
        CType(Me.UMenuTendina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ULblDescrizione As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UMenuTendina As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ULblCampoObbligatorio As Infragistics.Win.Misc.UltraLabel
End Class
