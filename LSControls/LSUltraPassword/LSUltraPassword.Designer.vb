<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LSUltraPassword
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LSUltraPassword))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ULblDescrizione = New Infragistics.Win.Misc.UltraLabel()
        Me.UTxtPassword = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ImgListPassword = New System.Windows.Forms.ImageList(Me.components)
        Me.UPicBoxOcchio = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.ULblCampoObbligatorio = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.UTxtPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ULblDescrizione
        '
        Me.ULblDescrizione.Font = New System.Drawing.Font("Linux Libertine Display G", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ULblDescrizione.Location = New System.Drawing.Point(0, 5)
        Me.ULblDescrizione.Name = "ULblDescrizione"
        Me.ULblDescrizione.Size = New System.Drawing.Size(100, 23)
        Me.ULblDescrizione.TabIndex = 0
        Me.ULblDescrizione.Text = "Password:"
        '
        'UTxtPassword
        '
        Me.UTxtPassword.Font = New System.Drawing.Font("Linux Libertine Display G", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UTxtPassword.Location = New System.Drawing.Point(93, 3)
        Me.UTxtPassword.Name = "UTxtPassword"
        Me.UTxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.UTxtPassword.Size = New System.Drawing.Size(252, 26)
        Me.UTxtPassword.TabIndex = 1
        '
        'ImgListPassword
        '
        Me.ImgListPassword.ImageStream = CType(resources.GetObject("ImgListPassword.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgListPassword.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgListPassword.Images.SetKeyName(0, "eye-32x32.png")
        Me.ImgListPassword.Images.SetKeyName(1, "no-eye-32x32.png")
        '
        'UPicBoxOcchio
        '
        Me.UPicBoxOcchio.BorderShadowColor = System.Drawing.Color.Empty
        Me.UPicBoxOcchio.Image = CType(resources.GetObject("UPicBoxOcchio.Image"), Object)
        Me.UPicBoxOcchio.Location = New System.Drawing.Point(351, 0)
        Me.UPicBoxOcchio.Name = "UPicBoxOcchio"
        Me.UPicBoxOcchio.Size = New System.Drawing.Size(32, 32)
        Me.UPicBoxOcchio.TabIndex = 2
        '
        'ULblCampoObbligatorio
        '
        Appearance1.ForeColor = System.Drawing.Color.Red
        Me.ULblCampoObbligatorio.Appearance = Appearance1
        Me.ULblCampoObbligatorio.Font = New System.Drawing.Font("Linux Libertine Display G", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ULblCampoObbligatorio.Location = New System.Drawing.Point(415, 5)
        Me.ULblCampoObbligatorio.Name = "ULblCampoObbligatorio"
        Me.ULblCampoObbligatorio.Size = New System.Drawing.Size(26, 23)
        Me.ULblCampoObbligatorio.TabIndex = 3
        Me.ULblCampoObbligatorio.Text = "*"
        '
        'LSUltraPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ULblCampoObbligatorio)
        Me.Controls.Add(Me.UPicBoxOcchio)
        Me.Controls.Add(Me.UTxtPassword)
        Me.Controls.Add(Me.ULblDescrizione)
        Me.Name = "LSUltraPassword"
        Me.Size = New System.Drawing.Size(444, 31)
        CType(Me.UTxtPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ULblDescrizione As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UTxtPassword As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ImgListPassword As ImageList
    Friend WithEvents UPicBoxOcchio As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents ULblCampoObbligatorio As Infragistics.Win.Misc.UltraLabel
End Class
