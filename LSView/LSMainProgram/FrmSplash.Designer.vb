<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSplash
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSplash))
        Me.ULblTitolo = New Infragistics.Win.Misc.UltraLabel()
        Me.UlblInfo = New Infragistics.Win.Misc.UltraLabel()
        Me.SuspendLayout()
        '
        'ULblTitolo
        '
        Me.ULblTitolo.Font = New System.Drawing.Font("Linux Libertine Display G", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ULblTitolo.Location = New System.Drawing.Point(74, 12)
        Me.ULblTitolo.Name = "ULblTitolo"
        Me.ULblTitolo.Size = New System.Drawing.Size(493, 35)
        Me.ULblTitolo.TabIndex = 0
        Me.ULblTitolo.Text = "Legal SpeeduMax - Gestionale per Avvocati"
        '
        'UlblInfo
        '
        Me.UlblInfo.Font = New System.Drawing.Font("Linux Libertine Display G", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UlblInfo.Location = New System.Drawing.Point(174, 506)
        Me.UlblInfo.Name = "UlblInfo"
        Me.UlblInfo.Size = New System.Drawing.Size(239, 35)
        Me.UlblInfo.TabIndex = 1
        Me.UlblInfo.Text = "Versione 1.0.0. - 2019 "
        '
        'FrmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(596, 553)
        Me.ControlBox = False
        Me.Controls.Add(Me.UlblInfo)
        Me.Controls.Add(Me.ULblTitolo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSplash"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ULblTitolo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UlblInfo As Infragistics.Win.Misc.UltraLabel
End Class
