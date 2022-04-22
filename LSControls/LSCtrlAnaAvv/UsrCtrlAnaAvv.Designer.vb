<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsrCtrlAnaAvv
    Inherits System.Windows.Forms.UserControl

    'UserControl1 esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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
        Me.components = New System.ComponentModel.Container()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsrCtrlAnaAvv))
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim DockAreaPane4 As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedTop, New System.Guid("97c2ed93-f1ba-4bc5-b8a8-dcd491601297"))
        Dim DockableControlPane4 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("862ae136-1f90-4c2f-a51c-cc9389153556"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("97c2ed93-f1ba-4bc5-b8a8-dcd491601297"), 0)
        Dim DockAreaPane5 As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedRight, New System.Guid("7fb753d1-3ccd-4e71-872d-71ed3ee9ea2b"))
        Dim DockableControlPane5 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("48440a24-6df5-4980-9b59-b3fd66c17942"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("7fb753d1-3ccd-4e71-872d-71ed3ee9ea2b"), 0)
        Dim DockAreaPane6 As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedTop, New System.Guid("a5f09bbf-1865-4b5a-88ab-07dd37ad60eb"))
        Dim DockableControlPane6 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("df31f873-6e13-4ca3-9eff-879232ee0e68"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("a5f09bbf-1865-4b5a-88ab-07dd37ad60eb"), -1)
        Me.UPanelToolbar = New Infragistics.Win.Misc.UltraPanel()
        Me.UGrpBoxToolbar = New Infragistics.Win.Misc.UltraGroupBox()
        Me.PicBoxEsportaExcel = New System.Windows.Forms.PictureBox()
        Me.PicBoxEsportaPDF = New System.Windows.Forms.PictureBox()
        Me.UlblTitoloAnaBase = New Infragistics.Win.Misc.UltraLabel()
        Me.UlblRigaTitolo = New Infragistics.Win.Misc.UltraLabel()
        Me.PicBoxRicercaDati = New System.Windows.Forms.PictureBox()
        Me.PicBoxInserisciRiga = New System.Windows.Forms.PictureBox()
        Me.PicBoxEliminaRiga = New System.Windows.Forms.PictureBox()
        Me.PicBoxSalvaDati = New System.Windows.Forms.PictureBox()
        Me.PicBoxChiudiFinestra = New System.Windows.Forms.PictureBox()
        Me.UPanelDatiDett = New Infragistics.Win.Misc.UltraPanel()
        Me.UGrpBoxDatiDett = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UPicBoxLogoAvv = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.LSUTxtIndirizzoStudio = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUTxtCellulare = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUTxtNumFaxStudio = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUTxtNumTelStudio = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUTxtEmailPEC = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUTxtEmail = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUTxtNazionalita = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUTxtInidirizzoResidenza = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUTxtPartitaIVA = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUTxtCodiceFiscale = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUTxtNomeCompleto = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUDataIscrizAlboCass = New LSUltraDataOraSel.LSUltraDataOraSel()
        Me.LSUDataIscrizAlboAvv = New LSUltraDataOraSel.LSUltraDataOraSel()
        Me.LSUDataNascita = New LSUltraDataOraSel.LSUltraDataOraSel()
        Me.LSUCboEditForoAppartenenza = New LSUltraMenuTendina.LSMenuTendina()
        Me.LSUCboEditStatoResidenza = New LSUltraMenuTendina.LSMenuTendina()
        Me.LSUCboEditLuogoNascita = New LSUltraMenuTendina.LSMenuTendina()
        Me.LSUCboEditProvNascita = New LSUltraMenuTendina.LSMenuTendina()
        Me.LSUCboEditLuogoResidenza = New LSUltraMenuTendina.LSMenuTendina()
        Me.LSUCboEditProvResidenza = New LSUltraMenuTendina.LSMenuTendina()
        Me.LSUCboEditStatoNascita = New LSUltraMenuTendina.LSMenuTendina()
        Me.LSUCboEditSesso = New LSUltraMenuTendina.LSMenuTendina()
        Me.LSUCboEditTipoPersona = New LSUltraMenuTendina.LSMenuTendina()
        Me.UlblRigaDatiTett = New Infragistics.Win.Misc.UltraLabel()
        Me.UPanelFiltriRicerca = New Infragistics.Win.Misc.UltraPanel()
        Me.UGrpBoxFiltrirRicerca = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UBtnConfermaAvvTrovato = New Infragistics.Win.Misc.UltraButton()
        Me.LSUTxtIndirizzoStudioRicerca = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUTxtNominativoRicerca = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.UPanelDatiGriglia = New Infragistics.Win.Misc.UltraPanel()
        Me.UGrdAnaAvv = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UGrpBoxTitoloDatiGriglia = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UlblTitoloDatiGriglia = New Infragistics.Win.Misc.UltraLabel()
        Me.UDockManAnaAvv = New Infragistics.Win.UltraWinDock.UltraDockManager(Me.components)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._UsrCtrlAnaAvvAutoHideControl = New Infragistics.Win.UltraWinDock.AutoHideControl()
        Me.ImageListAnaAvv = New System.Windows.Forms.ImageList(Me.components)
        Me.WindowDockingArea2 = New Infragistics.Win.UltraWinDock.WindowDockingArea()
        Me.DockableWindow1 = New Infragistics.Win.UltraWinDock.DockableWindow()
        Me.WindowDockingArea3 = New Infragistics.Win.UltraWinDock.WindowDockingArea()
        Me.DockableWindow2 = New Infragistics.Win.UltraWinDock.DockableWindow()
        Me.WindowDockingArea1 = New Infragistics.Win.UltraWinDock.WindowDockingArea()
        Me.DockableWindow3 = New Infragistics.Win.UltraWinDock.DockableWindow()
        Me.UltraGridBagLayoutManager1 = New Infragistics.Win.Misc.UltraGridBagLayoutManager(Me.components)
        Me.UPanelToolbar.ClientArea.SuspendLayout()
        Me.UPanelToolbar.SuspendLayout()
        CType(Me.UGrpBoxToolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UGrpBoxToolbar.SuspendLayout()
        CType(Me.PicBoxEsportaExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxEsportaPDF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxRicercaDati, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxInserisciRiga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxEliminaRiga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxSalvaDati, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxChiudiFinestra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UPanelDatiDett.ClientArea.SuspendLayout()
        Me.UPanelDatiDett.SuspendLayout()
        CType(Me.UGrpBoxDatiDett, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UGrpBoxDatiDett.SuspendLayout()
        Me.UPanelFiltriRicerca.ClientArea.SuspendLayout()
        Me.UPanelFiltriRicerca.SuspendLayout()
        CType(Me.UGrpBoxFiltrirRicerca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UGrpBoxFiltrirRicerca.SuspendLayout()
        Me.UPanelDatiGriglia.ClientArea.SuspendLayout()
        Me.UPanelDatiGriglia.SuspendLayout()
        CType(Me.UGrdAnaAvv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UGrpBoxTitoloDatiGriglia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UGrpBoxTitoloDatiGriglia.SuspendLayout()
        CType(Me.UDockManAnaAvv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WindowDockingArea2.SuspendLayout()
        Me.DockableWindow1.SuspendLayout()
        Me.WindowDockingArea3.SuspendLayout()
        Me.DockableWindow2.SuspendLayout()
        Me.WindowDockingArea1.SuspendLayout()
        Me.DockableWindow3.SuspendLayout()
        CType(Me.UltraGridBagLayoutManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UPanelToolbar
        '
        '
        'UPanelToolbar.ClientArea
        '
        Me.UPanelToolbar.ClientArea.Controls.Add(Me.UGrpBoxToolbar)
        Me.UPanelToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.UPanelToolbar.Location = New System.Drawing.Point(0, 19)
        Me.UPanelToolbar.MaximumSize = New System.Drawing.Size(2300, 90)
        Me.UPanelToolbar.MinimumSize = New System.Drawing.Size(1300, 90)
        Me.UPanelToolbar.Name = "UPanelToolbar"
        Me.UPanelToolbar.Size = New System.Drawing.Size(1772, 90)
        Me.UPanelToolbar.TabIndex = 0
        '
        'UGrpBoxToolbar
        '
        Appearance6.ImageBackground = CType(resources.GetObject("Appearance6.ImageBackground"), System.Drawing.Image)
        Me.UGrpBoxToolbar.Appearance = Appearance6
        Me.UGrpBoxToolbar.Controls.Add(Me.PicBoxEsportaExcel)
        Me.UGrpBoxToolbar.Controls.Add(Me.PicBoxEsportaPDF)
        Me.UGrpBoxToolbar.Controls.Add(Me.UlblTitoloAnaBase)
        Me.UGrpBoxToolbar.Controls.Add(Me.UlblRigaTitolo)
        Me.UGrpBoxToolbar.Controls.Add(Me.PicBoxRicercaDati)
        Me.UGrpBoxToolbar.Controls.Add(Me.PicBoxInserisciRiga)
        Me.UGrpBoxToolbar.Controls.Add(Me.PicBoxEliminaRiga)
        Me.UGrpBoxToolbar.Controls.Add(Me.PicBoxSalvaDati)
        Me.UGrpBoxToolbar.Controls.Add(Me.PicBoxChiudiFinestra)
        Me.UGrpBoxToolbar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UGrpBoxToolbar.Location = New System.Drawing.Point(0, 0)
        Me.UGrpBoxToolbar.Name = "UGrpBoxToolbar"
        Me.UGrpBoxToolbar.Size = New System.Drawing.Size(1772, 90)
        Me.UGrpBoxToolbar.TabIndex = 1
        '
        'PicBoxEsportaExcel
        '
        Me.PicBoxEsportaExcel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PicBoxEsportaExcel.Image = CType(resources.GetObject("PicBoxEsportaExcel.Image"), System.Drawing.Image)
        Me.PicBoxEsportaExcel.InitialImage = CType(resources.GetObject("PicBoxEsportaExcel.InitialImage"), System.Drawing.Image)
        Me.PicBoxEsportaExcel.Location = New System.Drawing.Point(1254, 0)
        Me.PicBoxEsportaExcel.Name = "PicBoxEsportaExcel"
        Me.PicBoxEsportaExcel.Size = New System.Drawing.Size(68, 75)
        Me.PicBoxEsportaExcel.TabIndex = 12
        Me.PicBoxEsportaExcel.TabStop = False
        '
        'PicBoxEsportaPDF
        '
        Me.PicBoxEsportaPDF.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PicBoxEsportaPDF.Image = CType(resources.GetObject("PicBoxEsportaPDF.Image"), System.Drawing.Image)
        Me.PicBoxEsportaPDF.InitialImage = CType(resources.GetObject("PicBoxEsportaPDF.InitialImage"), System.Drawing.Image)
        Me.PicBoxEsportaPDF.Location = New System.Drawing.Point(1328, 0)
        Me.PicBoxEsportaPDF.Name = "PicBoxEsportaPDF"
        Me.PicBoxEsportaPDF.Size = New System.Drawing.Size(68, 75)
        Me.PicBoxEsportaPDF.TabIndex = 11
        Me.PicBoxEsportaPDF.TabStop = False
        '
        'UlblTitoloAnaBase
        '
        Appearance7.BackColorAlpha = Infragistics.Win.Alpha.Transparent
        Me.UlblTitoloAnaBase.Appearance = Appearance7
        Me.UlblTitoloAnaBase.Font = New System.Drawing.Font("Linux Libertine Display G", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UlblTitoloAnaBase.Location = New System.Drawing.Point(19, 12)
        Me.UlblTitoloAnaBase.Name = "UlblTitoloAnaBase"
        Me.UlblTitoloAnaBase.Size = New System.Drawing.Size(372, 40)
        Me.UlblTitoloAnaBase.TabIndex = 10
        Me.UlblTitoloAnaBase.Text = "Anagrafica Avvocati"
        '
        'UlblRigaTitolo
        '
        Me.UlblRigaTitolo.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UlblRigaTitolo.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UlblRigaTitolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UlblRigaTitolo.Location = New System.Drawing.Point(19, 52)
        Me.UlblRigaTitolo.Name = "UlblRigaTitolo"
        Me.UlblRigaTitolo.Size = New System.Drawing.Size(597, 3)
        Me.UlblRigaTitolo.TabIndex = 9
        '
        'PicBoxRicercaDati
        '
        Me.PicBoxRicercaDati.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PicBoxRicercaDati.Image = CType(resources.GetObject("PicBoxRicercaDati.Image"), System.Drawing.Image)
        Me.PicBoxRicercaDati.Location = New System.Drawing.Point(1402, 0)
        Me.PicBoxRicercaDati.Name = "PicBoxRicercaDati"
        Me.PicBoxRicercaDati.Size = New System.Drawing.Size(68, 75)
        Me.PicBoxRicercaDati.TabIndex = 5
        Me.PicBoxRicercaDati.TabStop = False
        '
        'PicBoxInserisciRiga
        '
        Me.PicBoxInserisciRiga.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PicBoxInserisciRiga.Image = CType(resources.GetObject("PicBoxInserisciRiga.Image"), System.Drawing.Image)
        Me.PicBoxInserisciRiga.Location = New System.Drawing.Point(1476, 0)
        Me.PicBoxInserisciRiga.Name = "PicBoxInserisciRiga"
        Me.PicBoxInserisciRiga.Size = New System.Drawing.Size(68, 75)
        Me.PicBoxInserisciRiga.TabIndex = 4
        Me.PicBoxInserisciRiga.TabStop = False
        '
        'PicBoxEliminaRiga
        '
        Me.PicBoxEliminaRiga.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PicBoxEliminaRiga.Image = CType(resources.GetObject("PicBoxEliminaRiga.Image"), System.Drawing.Image)
        Me.PicBoxEliminaRiga.Location = New System.Drawing.Point(1550, 0)
        Me.PicBoxEliminaRiga.Name = "PicBoxEliminaRiga"
        Me.PicBoxEliminaRiga.Size = New System.Drawing.Size(68, 75)
        Me.PicBoxEliminaRiga.TabIndex = 3
        Me.PicBoxEliminaRiga.TabStop = False
        '
        'PicBoxSalvaDati
        '
        Me.PicBoxSalvaDati.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PicBoxSalvaDati.Image = CType(resources.GetObject("PicBoxSalvaDati.Image"), System.Drawing.Image)
        Me.PicBoxSalvaDati.Location = New System.Drawing.Point(1624, 0)
        Me.PicBoxSalvaDati.Name = "PicBoxSalvaDati"
        Me.PicBoxSalvaDati.Size = New System.Drawing.Size(68, 75)
        Me.PicBoxSalvaDati.TabIndex = 2
        Me.PicBoxSalvaDati.TabStop = False
        '
        'PicBoxChiudiFinestra
        '
        Me.PicBoxChiudiFinestra.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PicBoxChiudiFinestra.Image = CType(resources.GetObject("PicBoxChiudiFinestra.Image"), System.Drawing.Image)
        Me.PicBoxChiudiFinestra.Location = New System.Drawing.Point(1698, 0)
        Me.PicBoxChiudiFinestra.Name = "PicBoxChiudiFinestra"
        Me.PicBoxChiudiFinestra.Size = New System.Drawing.Size(68, 75)
        Me.PicBoxChiudiFinestra.TabIndex = 1
        Me.PicBoxChiudiFinestra.TabStop = False
        '
        'UPanelDatiDett
        '
        '
        'UPanelDatiDett.ClientArea
        '
        Me.UPanelDatiDett.ClientArea.Controls.Add(Me.UGrpBoxDatiDett)
        Me.UPanelDatiDett.Dock = System.Windows.Forms.DockStyle.Right
        Me.UPanelDatiDett.Location = New System.Drawing.Point(0, 19)
        Me.UPanelDatiDett.Name = "UPanelDatiDett"
        Me.UPanelDatiDett.Size = New System.Drawing.Size(1286, 577)
        Me.UPanelDatiDett.TabIndex = 1
        '
        'UGrpBoxDatiDett
        '
        Me.UGrpBoxDatiDett.Controls.Add(Me.UPicBoxLogoAvv)
        Me.UGrpBoxDatiDett.Controls.Add(Me.LSUTxtIndirizzoStudio)
        Me.UGrpBoxDatiDett.Controls.Add(Me.LSUTxtCellulare)
        Me.UGrpBoxDatiDett.Controls.Add(Me.LSUTxtNumFaxStudio)
        Me.UGrpBoxDatiDett.Controls.Add(Me.LSUTxtNumTelStudio)
        Me.UGrpBoxDatiDett.Controls.Add(Me.LSUTxtEmailPEC)
        Me.UGrpBoxDatiDett.Controls.Add(Me.LSUTxtEmail)
        Me.UGrpBoxDatiDett.Controls.Add(Me.LSUTxtNazionalita)
        Me.UGrpBoxDatiDett.Controls.Add(Me.LSUTxtInidirizzoResidenza)
        Me.UGrpBoxDatiDett.Controls.Add(Me.LSUTxtPartitaIVA)
        Me.UGrpBoxDatiDett.Controls.Add(Me.LSUTxtCodiceFiscale)
        Me.UGrpBoxDatiDett.Controls.Add(Me.LSUTxtNomeCompleto)
        Me.UGrpBoxDatiDett.Controls.Add(Me.LSUDataIscrizAlboCass)
        Me.UGrpBoxDatiDett.Controls.Add(Me.LSUDataIscrizAlboAvv)
        Me.UGrpBoxDatiDett.Controls.Add(Me.LSUDataNascita)
        Me.UGrpBoxDatiDett.Controls.Add(Me.LSUCboEditForoAppartenenza)
        Me.UGrpBoxDatiDett.Controls.Add(Me.LSUCboEditStatoResidenza)
        Me.UGrpBoxDatiDett.Controls.Add(Me.LSUCboEditLuogoNascita)
        Me.UGrpBoxDatiDett.Controls.Add(Me.LSUCboEditProvNascita)
        Me.UGrpBoxDatiDett.Controls.Add(Me.LSUCboEditLuogoResidenza)
        Me.UGrpBoxDatiDett.Controls.Add(Me.LSUCboEditProvResidenza)
        Me.UGrpBoxDatiDett.Controls.Add(Me.LSUCboEditStatoNascita)
        Me.UGrpBoxDatiDett.Controls.Add(Me.LSUCboEditSesso)
        Me.UGrpBoxDatiDett.Controls.Add(Me.LSUCboEditTipoPersona)
        Me.UGrpBoxDatiDett.Controls.Add(Me.UlblRigaDatiTett)
        Me.UGrpBoxDatiDett.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UGrpBoxDatiDett.Location = New System.Drawing.Point(0, 0)
        Me.UGrpBoxDatiDett.Name = "UGrpBoxDatiDett"
        Me.UGrpBoxDatiDett.Size = New System.Drawing.Size(1286, 577)
        Me.UGrpBoxDatiDett.TabIndex = 2
        '
        'UPicBoxLogoAvv
        '
        Me.UPicBoxLogoAvv.BorderShadowColor = System.Drawing.Color.Empty
        Me.UPicBoxLogoAvv.Image = CType(resources.GetObject("UPicBoxLogoAvv.Image"), Object)
        Me.UPicBoxLogoAvv.Location = New System.Drawing.Point(29, 6)
        Me.UPicBoxLogoAvv.Name = "UPicBoxLogoAvv"
        Me.UPicBoxLogoAvv.Size = New System.Drawing.Size(64, 64)
        Me.UPicBoxLogoAvv.TabIndex = 69
        '
        'LSUTxtIndirizzoStudio
        '
        Me.LSUTxtIndirizzoStudio.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtIndirizzoStudio.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtIndirizzoStudio.LarghezzaCasellaTesto = 300
        Me.LSUTxtIndirizzoStudio.LarghezzaEtichetta = 178
        Me.LSUTxtIndirizzoStudio.Location = New System.Drawing.Point(6, 501)
        Me.LSUTxtIndirizzoStudio.Name = "LSUTxtIndirizzoStudio"
        Me.LSUTxtIndirizzoStudio.Obbligatorio = True
        Me.LSUTxtIndirizzoStudio.Size = New System.Drawing.Size(636, 30)
        Me.LSUTxtIndirizzoStudio.TabIndex = 68
        Me.LSUTxtIndirizzoStudio.TestoEtichetta = "Indirizzo Studio:"
        Me.LSUTxtIndirizzoStudio.ValoreCasellaTesto = ""
        '
        'LSUTxtCellulare
        '
        Me.LSUTxtCellulare.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtCellulare.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtCellulare.LarghezzaCasellaTesto = 204
        Me.LSUTxtCellulare.LarghezzaEtichetta = 180
        Me.LSUTxtCellulare.Location = New System.Drawing.Point(4, 465)
        Me.LSUTxtCellulare.Name = "LSUTxtCellulare"
        Me.LSUTxtCellulare.Obbligatorio = False
        Me.LSUTxtCellulare.Size = New System.Drawing.Size(607, 30)
        Me.LSUTxtCellulare.TabIndex = 65
        Me.LSUTxtCellulare.TestoEtichetta = "Num. Cellulare:"
        Me.LSUTxtCellulare.ValoreCasellaTesto = ""
        '
        'LSUTxtNumFaxStudio
        '
        Me.LSUTxtNumFaxStudio.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtNumFaxStudio.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtNumFaxStudio.LarghezzaCasellaTesto = 204
        Me.LSUTxtNumFaxStudio.LarghezzaEtichetta = 195
        Me.LSUTxtNumFaxStudio.Location = New System.Drawing.Point(613, 465)
        Me.LSUTxtNumFaxStudio.Name = "LSUTxtNumFaxStudio"
        Me.LSUTxtNumFaxStudio.Obbligatorio = False
        Me.LSUTxtNumFaxStudio.Size = New System.Drawing.Size(655, 30)
        Me.LSUTxtNumFaxStudio.TabIndex = 66
        Me.LSUTxtNumFaxStudio.TestoEtichetta = "Num. Fax Studio"
        Me.LSUTxtNumFaxStudio.ValoreCasellaTesto = ""
        '
        'LSUTxtNumTelStudio
        '
        Me.LSUTxtNumTelStudio.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtNumTelStudio.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtNumTelStudio.LarghezzaCasellaTesto = 204
        Me.LSUTxtNumTelStudio.LarghezzaEtichetta = 195
        Me.LSUTxtNumTelStudio.Location = New System.Drawing.Point(613, 428)
        Me.LSUTxtNumTelStudio.Name = "LSUTxtNumTelStudio"
        Me.LSUTxtNumTelStudio.Obbligatorio = False
        Me.LSUTxtNumTelStudio.Size = New System.Drawing.Size(658, 30)
        Me.LSUTxtNumTelStudio.TabIndex = 64
        Me.LSUTxtNumTelStudio.TestoEtichetta = "Num. Tel. Studio:"
        Me.LSUTxtNumTelStudio.ValoreCasellaTesto = ""
        '
        'LSUTxtEmailPEC
        '
        Me.LSUTxtEmailPEC.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtEmailPEC.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtEmailPEC.LarghezzaCasellaTesto = 204
        Me.LSUTxtEmailPEC.LarghezzaEtichetta = 195
        Me.LSUTxtEmailPEC.Location = New System.Drawing.Point(613, 353)
        Me.LSUTxtEmailPEC.Name = "LSUTxtEmailPEC"
        Me.LSUTxtEmailPEC.Obbligatorio = False
        Me.LSUTxtEmailPEC.Size = New System.Drawing.Size(655, 30)
        Me.LSUTxtEmailPEC.TabIndex = 60
        Me.LSUTxtEmailPEC.TestoEtichetta = "E-Mail PEC:"
        Me.LSUTxtEmailPEC.ValoreCasellaTesto = ""
        '
        'LSUTxtEmail
        '
        Me.LSUTxtEmail.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtEmail.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtEmail.LarghezzaCasellaTesto = 204
        Me.LSUTxtEmail.LarghezzaEtichetta = 178
        Me.LSUTxtEmail.Location = New System.Drawing.Point(6, 352)
        Me.LSUTxtEmail.Name = "LSUTxtEmail"
        Me.LSUTxtEmail.Obbligatorio = True
        Me.LSUTxtEmail.Size = New System.Drawing.Size(608, 30)
        Me.LSUTxtEmail.TabIndex = 59
        Me.LSUTxtEmail.TestoEtichetta = "E-Mail:"
        Me.LSUTxtEmail.ValoreCasellaTesto = ""
        '
        'LSUTxtNazionalita
        '
        Me.LSUTxtNazionalita.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtNazionalita.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtNazionalita.LarghezzaCasellaTesto = 204
        Me.LSUTxtNazionalita.LarghezzaEtichetta = 195
        Me.LSUTxtNazionalita.Location = New System.Drawing.Point(613, 316)
        Me.LSUTxtNazionalita.Name = "LSUTxtNazionalita"
        Me.LSUTxtNazionalita.Obbligatorio = False
        Me.LSUTxtNazionalita.Size = New System.Drawing.Size(658, 30)
        Me.LSUTxtNazionalita.TabIndex = 58
        Me.LSUTxtNazionalita.TestoEtichetta = "Nazionalità:"
        Me.LSUTxtNazionalita.ValoreCasellaTesto = ""
        '
        'LSUTxtInidirizzoResidenza
        '
        Me.LSUTxtInidirizzoResidenza.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtInidirizzoResidenza.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtInidirizzoResidenza.LarghezzaCasellaTesto = 204
        Me.LSUTxtInidirizzoResidenza.LarghezzaEtichetta = 180
        Me.LSUTxtInidirizzoResidenza.Location = New System.Drawing.Point(6, 316)
        Me.LSUTxtInidirizzoResidenza.Name = "LSUTxtInidirizzoResidenza"
        Me.LSUTxtInidirizzoResidenza.Obbligatorio = False
        Me.LSUTxtInidirizzoResidenza.Size = New System.Drawing.Size(611, 30)
        Me.LSUTxtInidirizzoResidenza.TabIndex = 57
        Me.LSUTxtInidirizzoResidenza.TestoEtichetta = "Indirizzo di Residenza:"
        Me.LSUTxtInidirizzoResidenza.ValoreCasellaTesto = ""
        '
        'LSUTxtPartitaIVA
        '
        Me.LSUTxtPartitaIVA.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtPartitaIVA.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtPartitaIVA.LarghezzaCasellaTesto = 204
        Me.LSUTxtPartitaIVA.LarghezzaEtichetta = 180
        Me.LSUTxtPartitaIVA.Location = New System.Drawing.Point(5, 239)
        Me.LSUTxtPartitaIVA.Name = "LSUTxtPartitaIVA"
        Me.LSUTxtPartitaIVA.Obbligatorio = False
        Me.LSUTxtPartitaIVA.Size = New System.Drawing.Size(617, 30)
        Me.LSUTxtPartitaIVA.TabIndex = 53
        Me.LSUTxtPartitaIVA.TestoEtichetta = "Partita IVA:"
        Me.LSUTxtPartitaIVA.ValoreCasellaTesto = ""
        '
        'LSUTxtCodiceFiscale
        '
        Me.LSUTxtCodiceFiscale.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtCodiceFiscale.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtCodiceFiscale.LarghezzaCasellaTesto = 204
        Me.LSUTxtCodiceFiscale.LarghezzaEtichetta = 195
        Me.LSUTxtCodiceFiscale.Location = New System.Drawing.Point(613, 206)
        Me.LSUTxtCodiceFiscale.Name = "LSUTxtCodiceFiscale"
        Me.LSUTxtCodiceFiscale.Obbligatorio = True
        Me.LSUTxtCodiceFiscale.Size = New System.Drawing.Size(658, 30)
        Me.LSUTxtCodiceFiscale.TabIndex = 52
        Me.LSUTxtCodiceFiscale.TestoEtichetta = "Codice Fiscale:"
        Me.LSUTxtCodiceFiscale.ValoreCasellaTesto = ""
        '
        'LSUTxtNomeCompleto
        '
        Me.LSUTxtNomeCompleto.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtNomeCompleto.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtNomeCompleto.LarghezzaCasellaTesto = 204
        Me.LSUTxtNomeCompleto.LarghezzaEtichetta = 190
        Me.LSUTxtNomeCompleto.Location = New System.Drawing.Point(617, 94)
        Me.LSUTxtNomeCompleto.Name = "LSUTxtNomeCompleto"
        Me.LSUTxtNomeCompleto.Obbligatorio = True
        Me.LSUTxtNomeCompleto.Size = New System.Drawing.Size(648, 30)
        Me.LSUTxtNomeCompleto.TabIndex = 46
        Me.LSUTxtNomeCompleto.TestoEtichetta = "Nome Completo:"
        Me.LSUTxtNomeCompleto.ValoreCasellaTesto = ""
        '
        'LSUDataIscrizAlboCass
        '
        Me.LSUDataIscrizAlboCass.ColoreSfondoDataOraSelInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUDataIscrizAlboCass.ColoreSfondoDataOraSelInUscita = System.Drawing.Color.White
        Me.LSUDataIscrizAlboCass.LarghezzaDataOraSel = 114
        Me.LSUDataIscrizAlboCass.LarghezzaEtichetta = 191
        Me.LSUDataIscrizAlboCass.Location = New System.Drawing.Point(617, 389)
        Me.LSUDataIscrizAlboCass.Name = "LSUDataIscrizAlboCass"
        Me.LSUDataIscrizAlboCass.Obbligatorio = False
        Me.LSUDataIscrizAlboCass.Size = New System.Drawing.Size(654, 31)
        Me.LSUDataIscrizAlboCass.TabIndex = 62
        Me.LSUDataIscrizAlboCass.TestoEtichetta = "Data Iscriz. Albo Cass.:"
        Me.LSUDataIscrizAlboCass.ValoreDataOraSel = New Date(2019, 4, 2, 0, 0, 0, 0)
        '
        'LSUDataIscrizAlboAvv
        '
        Me.LSUDataIscrizAlboAvv.ColoreSfondoDataOraSelInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUDataIscrizAlboAvv.ColoreSfondoDataOraSelInUscita = System.Drawing.Color.White
        Me.LSUDataIscrizAlboAvv.LarghezzaDataOraSel = 114
        Me.LSUDataIscrizAlboAvv.LarghezzaEtichetta = 178
        Me.LSUDataIscrizAlboAvv.Location = New System.Drawing.Point(8, 389)
        Me.LSUDataIscrizAlboAvv.Name = "LSUDataIscrizAlboAvv"
        Me.LSUDataIscrizAlboAvv.Obbligatorio = True
        Me.LSUDataIscrizAlboAvv.Size = New System.Drawing.Size(603, 31)
        Me.LSUDataIscrizAlboAvv.TabIndex = 61
        Me.LSUDataIscrizAlboAvv.TestoEtichetta = "Data Iscriz. Albo Avv.:"
        Me.LSUDataIscrizAlboAvv.ValoreDataOraSel = New Date(2019, 4, 2, 0, 0, 0, 0)
        '
        'LSUDataNascita
        '
        Me.LSUDataNascita.ColoreSfondoDataOraSelInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUDataNascita.ColoreSfondoDataOraSelInUscita = System.Drawing.Color.White
        Me.LSUDataNascita.LarghezzaDataOraSel = 114
        Me.LSUDataNascita.LarghezzaEtichetta = 178
        Me.LSUDataNascita.Location = New System.Drawing.Point(8, 130)
        Me.LSUDataNascita.Name = "LSUDataNascita"
        Me.LSUDataNascita.Obbligatorio = True
        Me.LSUDataNascita.Size = New System.Drawing.Size(609, 31)
        Me.LSUDataNascita.TabIndex = 47
        Me.LSUDataNascita.TestoEtichetta = "Data di Nascita:"
        Me.LSUDataNascita.ValoreDataOraSel = New Date(2019, 4, 2, 0, 0, 0, 0)
        '
        'LSUCboEditForoAppartenenza
        '
        Me.LSUCboEditForoAppartenenza.ColoreSfondoMenuTendinaInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUCboEditForoAppartenenza.ColoreSfondoMenuTendinaInUscita = System.Drawing.Color.White
        Me.LSUCboEditForoAppartenenza.LarghezzaCasellaTesto = 241
        Me.LSUCboEditForoAppartenenza.LarghezzaEtichetta = 180
        Me.LSUCboEditForoAppartenenza.Location = New System.Drawing.Point(5, 426)
        Me.LSUCboEditForoAppartenenza.Name = "LSUCboEditForoAppartenenza"
        Me.LSUCboEditForoAppartenenza.Obbligatorio = False
        Me.LSUCboEditForoAppartenenza.Size = New System.Drawing.Size(612, 32)
        Me.LSUCboEditForoAppartenenza.TabIndex = 63
        Me.LSUCboEditForoAppartenenza.TestoEtichetta = "Foro di Appartenenza:"
        Me.LSUCboEditForoAppartenenza.ValoreMenuTendina = ""
        '
        'LSUCboEditStatoResidenza
        '
        Me.LSUCboEditStatoResidenza.ColoreSfondoMenuTendinaInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUCboEditStatoResidenza.ColoreSfondoMenuTendinaInUscita = System.Drawing.Color.White
        Me.LSUCboEditStatoResidenza.LarghezzaCasellaTesto = 241
        Me.LSUCboEditStatoResidenza.LarghezzaEtichetta = 190
        Me.LSUCboEditStatoResidenza.Location = New System.Drawing.Point(618, 239)
        Me.LSUCboEditStatoResidenza.Name = "LSUCboEditStatoResidenza"
        Me.LSUCboEditStatoResidenza.Obbligatorio = False
        Me.LSUCboEditStatoResidenza.Size = New System.Drawing.Size(658, 32)
        Me.LSUCboEditStatoResidenza.TabIndex = 54
        Me.LSUCboEditStatoResidenza.TestoEtichetta = "Stato di Residenza:"
        Me.LSUCboEditStatoResidenza.ValoreMenuTendina = ""
        '
        'LSUCboEditLuogoNascita
        '
        Me.LSUCboEditLuogoNascita.ColoreSfondoMenuTendinaInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUCboEditLuogoNascita.ColoreSfondoMenuTendinaInUscita = System.Drawing.Color.White
        Me.LSUCboEditLuogoNascita.LarghezzaCasellaTesto = 241
        Me.LSUCboEditLuogoNascita.LarghezzaEtichetta = 178
        Me.LSUCboEditLuogoNascita.Location = New System.Drawing.Point(8, 201)
        Me.LSUCboEditLuogoNascita.Name = "LSUCboEditLuogoNascita"
        Me.LSUCboEditLuogoNascita.Obbligatorio = True
        Me.LSUCboEditLuogoNascita.Size = New System.Drawing.Size(609, 32)
        Me.LSUCboEditLuogoNascita.TabIndex = 51
        Me.LSUCboEditLuogoNascita.TestoEtichetta = "Luogo di Nascita:"
        Me.LSUCboEditLuogoNascita.ValoreMenuTendina = ""
        '
        'LSUCboEditProvNascita
        '
        Me.LSUCboEditProvNascita.ColoreSfondoMenuTendinaInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUCboEditProvNascita.ColoreSfondoMenuTendinaInUscita = System.Drawing.Color.White
        Me.LSUCboEditProvNascita.LarghezzaCasellaTesto = 241
        Me.LSUCboEditProvNascita.LarghezzaEtichetta = 190
        Me.LSUCboEditProvNascita.Location = New System.Drawing.Point(617, 168)
        Me.LSUCboEditProvNascita.Name = "LSUCboEditProvNascita"
        Me.LSUCboEditProvNascita.Obbligatorio = True
        Me.LSUCboEditProvNascita.Size = New System.Drawing.Size(659, 32)
        Me.LSUCboEditProvNascita.TabIndex = 50
        Me.LSUCboEditProvNascita.TestoEtichetta = "Provincia di Nascita:"
        Me.LSUCboEditProvNascita.ValoreMenuTendina = ""
        '
        'LSUCboEditLuogoResidenza
        '
        Me.LSUCboEditLuogoResidenza.ColoreSfondoMenuTendinaInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUCboEditLuogoResidenza.ColoreSfondoMenuTendinaInUscita = System.Drawing.Color.White
        Me.LSUCboEditLuogoResidenza.LarghezzaCasellaTesto = 241
        Me.LSUCboEditLuogoResidenza.LarghezzaEtichetta = 191
        Me.LSUCboEditLuogoResidenza.Location = New System.Drawing.Point(616, 275)
        Me.LSUCboEditLuogoResidenza.Name = "LSUCboEditLuogoResidenza"
        Me.LSUCboEditLuogoResidenza.Obbligatorio = False
        Me.LSUCboEditLuogoResidenza.Size = New System.Drawing.Size(660, 32)
        Me.LSUCboEditLuogoResidenza.TabIndex = 56
        Me.LSUCboEditLuogoResidenza.TestoEtichetta = "Luogo di Residenza:"
        Me.LSUCboEditLuogoResidenza.ValoreMenuTendina = ""
        '
        'LSUCboEditProvResidenza
        '
        Me.LSUCboEditProvResidenza.ColoreSfondoMenuTendinaInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUCboEditProvResidenza.ColoreSfondoMenuTendinaInUscita = System.Drawing.Color.White
        Me.LSUCboEditProvResidenza.LarghezzaCasellaTesto = 241
        Me.LSUCboEditProvResidenza.LarghezzaEtichetta = 180
        Me.LSUCboEditProvResidenza.Location = New System.Drawing.Point(6, 278)
        Me.LSUCboEditProvResidenza.Name = "LSUCboEditProvResidenza"
        Me.LSUCboEditProvResidenza.Obbligatorio = False
        Me.LSUCboEditProvResidenza.Size = New System.Drawing.Size(612, 32)
        Me.LSUCboEditProvResidenza.TabIndex = 55
        Me.LSUCboEditProvResidenza.TestoEtichetta = "Provincia di Residenza:"
        Me.LSUCboEditProvResidenza.ValoreMenuTendina = ""
        '
        'LSUCboEditStatoNascita
        '
        Me.LSUCboEditStatoNascita.ColoreSfondoMenuTendinaInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUCboEditStatoNascita.ColoreSfondoMenuTendinaInUscita = System.Drawing.Color.White
        Me.LSUCboEditStatoNascita.LarghezzaCasellaTesto = 241
        Me.LSUCboEditStatoNascita.LarghezzaEtichetta = 180
        Me.LSUCboEditStatoNascita.Location = New System.Drawing.Point(4, 163)
        Me.LSUCboEditStatoNascita.Name = "LSUCboEditStatoNascita"
        Me.LSUCboEditStatoNascita.Obbligatorio = True
        Me.LSUCboEditStatoNascita.Size = New System.Drawing.Size(611, 32)
        Me.LSUCboEditStatoNascita.TabIndex = 49
        Me.LSUCboEditStatoNascita.TestoEtichetta = "Stato di Nascita:"
        Me.LSUCboEditStatoNascita.ValoreMenuTendina = ""
        '
        'LSUCboEditSesso
        '
        Me.LSUCboEditSesso.ColoreSfondoMenuTendinaInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUCboEditSesso.ColoreSfondoMenuTendinaInUscita = System.Drawing.Color.White
        Me.LSUCboEditSesso.LarghezzaCasellaTesto = 241
        Me.LSUCboEditSesso.LarghezzaEtichetta = 190
        Me.LSUCboEditSesso.Location = New System.Drawing.Point(617, 129)
        Me.LSUCboEditSesso.Name = "LSUCboEditSesso"
        Me.LSUCboEditSesso.Obbligatorio = True
        Me.LSUCboEditSesso.Size = New System.Drawing.Size(651, 32)
        Me.LSUCboEditSesso.TabIndex = 48
        Me.LSUCboEditSesso.TestoEtichetta = "Sesso:"
        Me.LSUCboEditSesso.ValoreMenuTendina = ""
        '
        'LSUCboEditTipoPersona
        '
        Me.LSUCboEditTipoPersona.ColoreSfondoMenuTendinaInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUCboEditTipoPersona.ColoreSfondoMenuTendinaInUscita = System.Drawing.Color.White
        Me.LSUCboEditTipoPersona.LarghezzaCasellaTesto = 241
        Me.LSUCboEditTipoPersona.LarghezzaEtichetta = 180
        Me.LSUCboEditTipoPersona.Location = New System.Drawing.Point(6, 92)
        Me.LSUCboEditTipoPersona.Name = "LSUCboEditTipoPersona"
        Me.LSUCboEditTipoPersona.Obbligatorio = True
        Me.LSUCboEditTipoPersona.Size = New System.Drawing.Size(612, 32)
        Me.LSUCboEditTipoPersona.TabIndex = 45
        Me.LSUCboEditTipoPersona.TestoEtichetta = "Tipolgia Persona:"
        Me.LSUCboEditTipoPersona.ValoreMenuTendina = ""
        '
        'UlblRigaDatiTett
        '
        Me.UlblRigaDatiTett.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UlblRigaDatiTett.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UlblRigaDatiTett.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UlblRigaDatiTett.Location = New System.Drawing.Point(8, 82)
        Me.UlblRigaDatiTett.Name = "UlblRigaDatiTett"
        Me.UlblRigaDatiTett.Size = New System.Drawing.Size(1250, 3)
        Me.UlblRigaDatiTett.TabIndex = 67
        '
        'UPanelFiltriRicerca
        '
        '
        'UPanelFiltriRicerca.ClientArea
        '
        Me.UPanelFiltriRicerca.ClientArea.Controls.Add(Me.UGrpBoxFiltrirRicerca)
        Me.UPanelFiltriRicerca.Dock = System.Windows.Forms.DockStyle.Top
        Me.UPanelFiltriRicerca.Location = New System.Drawing.Point(0, 19)
        Me.UPanelFiltriRicerca.Name = "UPanelFiltriRicerca"
        Me.UPanelFiltriRicerca.Size = New System.Drawing.Size(481, 195)
        Me.UPanelFiltriRicerca.TabIndex = 2
        '
        'UGrpBoxFiltrirRicerca
        '
        Me.UGrpBoxFiltrirRicerca.Controls.Add(Me.UBtnConfermaAvvTrovato)
        Me.UGrpBoxFiltrirRicerca.Controls.Add(Me.LSUTxtIndirizzoStudioRicerca)
        Me.UGrpBoxFiltrirRicerca.Controls.Add(Me.LSUTxtNominativoRicerca)
        Me.UGrpBoxFiltrirRicerca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UGrpBoxFiltrirRicerca.Location = New System.Drawing.Point(0, 0)
        Me.UGrpBoxFiltrirRicerca.Name = "UGrpBoxFiltrirRicerca"
        Me.UGrpBoxFiltrirRicerca.Size = New System.Drawing.Size(481, 195)
        Me.UGrpBoxFiltrirRicerca.TabIndex = 1
        '
        'UBtnConfermaAvvTrovato
        '
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UBtnConfermaAvvTrovato.Appearance = Appearance8
        Me.UBtnConfermaAvvTrovato.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.UBtnConfermaAvvTrovato.Font = New System.Drawing.Font("Linux Libertine Display G", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UBtnConfermaAvvTrovato.Location = New System.Drawing.Point(89, 126)
        Me.UBtnConfermaAvvTrovato.Name = "UBtnConfermaAvvTrovato"
        Me.UBtnConfermaAvvTrovato.Size = New System.Drawing.Size(298, 39)
        Me.UBtnConfermaAvvTrovato.TabIndex = 5
        Me.UBtnConfermaAvvTrovato.Text = "Conferma Avvocato Trovato"
        '
        'LSUTxtIndirizzoStudioRicerca
        '
        Me.LSUTxtIndirizzoStudioRicerca.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtIndirizzoStudioRicerca.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtIndirizzoStudioRicerca.LarghezzaCasellaTesto = 204
        Me.LSUTxtIndirizzoStudioRicerca.LarghezzaEtichetta = 215
        Me.LSUTxtIndirizzoStudioRicerca.Location = New System.Drawing.Point(0, 74)
        Me.LSUTxtIndirizzoStudioRicerca.Name = "LSUTxtIndirizzoStudioRicerca"
        Me.LSUTxtIndirizzoStudioRicerca.Obbligatorio = False
        Me.LSUTxtIndirizzoStudioRicerca.Size = New System.Drawing.Size(475, 30)
        Me.LSUTxtIndirizzoStudioRicerca.TabIndex = 4
        Me.LSUTxtIndirizzoStudioRicerca.TestoEtichetta = "Indirizzo Studio (compreso):"
        Me.LSUTxtIndirizzoStudioRicerca.ValoreCasellaTesto = ""
        '
        'LSUTxtNominativoRicerca
        '
        Me.LSUTxtNominativoRicerca.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtNominativoRicerca.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtNominativoRicerca.LarghezzaCasellaTesto = 204
        Me.LSUTxtNominativoRicerca.LarghezzaEtichetta = 209
        Me.LSUTxtNominativoRicerca.Location = New System.Drawing.Point(6, 22)
        Me.LSUTxtNominativoRicerca.Name = "LSUTxtNominativoRicerca"
        Me.LSUTxtNominativoRicerca.Obbligatorio = False
        Me.LSUTxtNominativoRicerca.Size = New System.Drawing.Size(474, 30)
        Me.LSUTxtNominativoRicerca.TabIndex = 3
        Me.LSUTxtNominativoRicerca.TestoEtichetta = "Nominativo (compreso)"
        Me.LSUTxtNominativoRicerca.ValoreCasellaTesto = ""
        '
        'UPanelDatiGriglia
        '
        '
        'UPanelDatiGriglia.ClientArea
        '
        Me.UPanelDatiGriglia.ClientArea.Controls.Add(Me.UGrdAnaAvv)
        Me.UPanelDatiGriglia.ClientArea.Controls.Add(Me.UGrpBoxTitoloDatiGriglia)
        Me.UPanelDatiGriglia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UPanelDatiGriglia.Location = New System.Drawing.Point(0, 324)
        Me.UPanelDatiGriglia.Name = "UPanelDatiGriglia"
        Me.UPanelDatiGriglia.Size = New System.Drawing.Size(481, 377)
        Me.UPanelDatiGriglia.TabIndex = 4
        '
        'UGrdAnaAvv
        '
        Me.UGrdAnaAvv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UGrdAnaAvv.Location = New System.Drawing.Point(0, 23)
        Me.UGrdAnaAvv.Name = "UGrdAnaAvv"
        Me.UGrdAnaAvv.Size = New System.Drawing.Size(481, 354)
        Me.UGrdAnaAvv.TabIndex = 2
        Me.UGrdAnaAvv.Text = "Griglia Anagrafica Avvocati"
        '
        'UGrpBoxTitoloDatiGriglia
        '
        Appearance9.BorderAlpha = Infragistics.Win.Alpha.Transparent
        Appearance9.ImageBackground = CType(resources.GetObject("Appearance9.ImageBackground"), System.Drawing.Image)
        Me.UGrpBoxTitoloDatiGriglia.Appearance = Appearance9
        Me.UGrpBoxTitoloDatiGriglia.Controls.Add(Me.UlblTitoloDatiGriglia)
        Me.UGrpBoxTitoloDatiGriglia.Dock = System.Windows.Forms.DockStyle.Top
        Me.UGrpBoxTitoloDatiGriglia.Location = New System.Drawing.Point(0, 0)
        Me.UGrpBoxTitoloDatiGriglia.Name = "UGrpBoxTitoloDatiGriglia"
        Me.UGrpBoxTitoloDatiGriglia.Size = New System.Drawing.Size(481, 23)
        Me.UGrpBoxTitoloDatiGriglia.TabIndex = 0
        '
        'UlblTitoloDatiGriglia
        '
        Appearance10.BackColorAlpha = Infragistics.Win.Alpha.Transparent
        Me.UlblTitoloDatiGriglia.Appearance = Appearance10
        Me.UlblTitoloDatiGriglia.Font = New System.Drawing.Font("Linux Libertine Display G", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UlblTitoloDatiGriglia.Location = New System.Drawing.Point(6, 3)
        Me.UlblTitoloDatiGriglia.Name = "UlblTitoloDatiGriglia"
        Me.UlblTitoloDatiGriglia.Size = New System.Drawing.Size(100, 19)
        Me.UlblTitoloDatiGriglia.TabIndex = 0
        Me.UlblTitoloDatiGriglia.Text = "Dati Griglia"
        '
        'UDockManAnaAvv
        '
        Me.UDockManAnaAvv.CompressUnpinnedTabs = False
        DockAreaPane4.DockedBefore = New System.Guid("7fb753d1-3ccd-4e71-872d-71ed3ee9ea2b")
        DockAreaPane4.MaximumSize = New System.Drawing.Size(2300, 100)
        DockAreaPane4.MinimumSize = New System.Drawing.Size(1300, 100)
        DockableControlPane4.Control = Me.UPanelToolbar
        DockableControlPane4.OriginalControlBounds = New System.Drawing.Rectangle(0, 0, 1300, 100)
        DockableControlPane4.Size = New System.Drawing.Size(100, 100)
        DockAreaPane4.Panes.AddRange(New Infragistics.Win.UltraWinDock.DockablePaneBase() {DockableControlPane4})
        DockAreaPane4.Size = New System.Drawing.Size(1772, 100)
        DockAreaPane5.DockedBefore = New System.Guid("a5f09bbf-1865-4b5a-88ab-07dd37ad60eb")
        DockableControlPane5.Control = Me.UPanelDatiDett
        DockableControlPane5.OriginalControlBounds = New System.Drawing.Rectangle(587, 129, 713, 572)
        DockableControlPane5.Size = New System.Drawing.Size(100, 100)
        DockableControlPane5.Text = "Dati di Dettaglio"
        DockAreaPane5.Panes.AddRange(New Infragistics.Win.UltraWinDock.DockablePaneBase() {DockableControlPane5})
        DockAreaPane5.Size = New System.Drawing.Size(1286, 596)
        DockableControlPane6.Control = Me.UPanelFiltriRicerca
        DockableControlPane6.OriginalControlBounds = New System.Drawing.Rectangle(0, 119, 539, 180)
        DockableControlPane6.Size = New System.Drawing.Size(100, 100)
        DockableControlPane6.Text = "Filtri di Ricerca"
        DockAreaPane6.Panes.AddRange(New Infragistics.Win.UltraWinDock.DockablePaneBase() {DockableControlPane6})
        DockAreaPane6.Size = New System.Drawing.Size(481, 214)
        Me.UDockManAnaAvv.DockAreas.AddRange(New Infragistics.Win.UltraWinDock.DockAreaPane() {DockAreaPane4, DockAreaPane5, DockAreaPane6})
        Me.UDockManAnaAvv.HostControl = Me
        Me.UDockManAnaAvv.ShowCloseButton = False
        Me.UDockManAnaAvv.ShowPinButton = False
        '
        '_UsrCtrlAnaAvvUnpinnedTabAreaLeft
        '
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.Location = New System.Drawing.Point(0, 0)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.Name = "_UsrCtrlAnaAvvUnpinnedTabAreaLeft"
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.Owner = Me.UDockManAnaAvv
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.Size = New System.Drawing.Size(0, 701)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.TabIndex = 5
        '
        '_UsrCtrlAnaAvvUnpinnedTabAreaRight
        '
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Dock = System.Windows.Forms.DockStyle.Right
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Location = New System.Drawing.Point(1772, 0)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Name = "_UsrCtrlAnaAvvUnpinnedTabAreaRight"
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Owner = Me.UDockManAnaAvv
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Size = New System.Drawing.Size(0, 701)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.TabIndex = 6
        '
        '_UsrCtrlAnaAvvUnpinnedTabAreaTop
        '
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.Dock = System.Windows.Forms.DockStyle.Top
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.Location = New System.Drawing.Point(0, 0)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.Name = "_UsrCtrlAnaAvvUnpinnedTabAreaTop"
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.Owner = Me.UDockManAnaAvv
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.Size = New System.Drawing.Size(1772, 0)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.TabIndex = 7
        '
        '_UsrCtrlAnaAvvUnpinnedTabAreaBottom
        '
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Location = New System.Drawing.Point(0, 701)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Name = "_UsrCtrlAnaAvvUnpinnedTabAreaBottom"
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Owner = Me.UDockManAnaAvv
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Size = New System.Drawing.Size(1772, 0)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.TabIndex = 8
        '
        '_UsrCtrlAnaAvvAutoHideControl
        '
        Me._UsrCtrlAnaAvvAutoHideControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._UsrCtrlAnaAvvAutoHideControl.Location = New System.Drawing.Point(0, 0)
        Me._UsrCtrlAnaAvvAutoHideControl.Name = "_UsrCtrlAnaAvvAutoHideControl"
        Me._UsrCtrlAnaAvvAutoHideControl.Owner = Me.UDockManAnaAvv
        Me._UsrCtrlAnaAvvAutoHideControl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._UsrCtrlAnaAvvAutoHideControl.Size = New System.Drawing.Size(0, 701)
        Me._UsrCtrlAnaAvvAutoHideControl.TabIndex = 9
        '
        'ImageListAnaAvv
        '
        Me.ImageListAnaAvv.ImageStream = CType(resources.GetObject("ImageListAnaAvv.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListAnaAvv.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListAnaAvv.Images.SetKeyName(0, "Chiudi-Finestra-68x75.png")
        Me.ImageListAnaAvv.Images.SetKeyName(1, "Chiudi-Finestra-highlight-68x75.png")
        Me.ImageListAnaAvv.Images.SetKeyName(2, "Salva Dati-68x75.png")
        Me.ImageListAnaAvv.Images.SetKeyName(3, "Salva Dati-highlight-68x75.png")
        Me.ImageListAnaAvv.Images.SetKeyName(4, "Elimina-Riga-68x75.png")
        Me.ImageListAnaAvv.Images.SetKeyName(5, "Elimina-Riga-highlight-68x75.png")
        Me.ImageListAnaAvv.Images.SetKeyName(6, "Inserisci-Riga-68x75.png")
        Me.ImageListAnaAvv.Images.SetKeyName(7, "Inserisci-Riga-highlight-68x75.png")
        Me.ImageListAnaAvv.Images.SetKeyName(8, "Ricerca-Dati-68x75.png")
        Me.ImageListAnaAvv.Images.SetKeyName(9, "Ricerca-Dati-highlight-68x75.png")
        Me.ImageListAnaAvv.Images.SetKeyName(10, "Esporta-PDF-68x75.png")
        Me.ImageListAnaAvv.Images.SetKeyName(11, "Esporta-PDF-highlight-68x75.png")
        Me.ImageListAnaAvv.Images.SetKeyName(12, "Esporta-Excel-68x75.png")
        Me.ImageListAnaAvv.Images.SetKeyName(13, "Esporta-Excel-highlight-68x75.png")
        '
        'WindowDockingArea2
        '
        Me.WindowDockingArea2.Controls.Add(Me.DockableWindow1)
        Me.WindowDockingArea2.Dock = System.Windows.Forms.DockStyle.Top
        Me.WindowDockingArea2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea2.Location = New System.Drawing.Point(0, 0)
        Me.WindowDockingArea2.Name = "WindowDockingArea2"
        Me.WindowDockingArea2.Owner = Me.UDockManAnaAvv
        Me.WindowDockingArea2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WindowDockingArea2.Size = New System.Drawing.Size(1772, 105)
        Me.WindowDockingArea2.TabIndex = 16
        '
        'DockableWindow1
        '
        Me.DockableWindow1.Controls.Add(Me.UPanelToolbar)
        Me.DockableWindow1.Location = New System.Drawing.Point(0, 0)
        Me.DockableWindow1.Name = "DockableWindow1"
        Me.DockableWindow1.Owner = Me.UDockManAnaAvv
        Me.DockableWindow1.Size = New System.Drawing.Size(1772, 100)
        Me.DockableWindow1.TabIndex = 17
        '
        'WindowDockingArea3
        '
        Me.WindowDockingArea3.Controls.Add(Me.DockableWindow2)
        Me.WindowDockingArea3.Dock = System.Windows.Forms.DockStyle.Right
        Me.WindowDockingArea3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea3.Location = New System.Drawing.Point(481, 105)
        Me.WindowDockingArea3.Name = "WindowDockingArea3"
        Me.WindowDockingArea3.Owner = Me.UDockManAnaAvv
        Me.WindowDockingArea3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WindowDockingArea3.Size = New System.Drawing.Size(1291, 596)
        Me.WindowDockingArea3.TabIndex = 15
        '
        'DockableWindow2
        '
        Me.DockableWindow2.Controls.Add(Me.UPanelDatiDett)
        Me.DockableWindow2.Location = New System.Drawing.Point(5, 0)
        Me.DockableWindow2.Name = "DockableWindow2"
        Me.DockableWindow2.Owner = Me.UDockManAnaAvv
        Me.DockableWindow2.Size = New System.Drawing.Size(1286, 596)
        Me.DockableWindow2.TabIndex = 18
        '
        'WindowDockingArea1
        '
        Me.WindowDockingArea1.Controls.Add(Me.DockableWindow3)
        Me.WindowDockingArea1.Dock = System.Windows.Forms.DockStyle.Top
        Me.WindowDockingArea1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea1.Location = New System.Drawing.Point(0, 105)
        Me.WindowDockingArea1.Name = "WindowDockingArea1"
        Me.WindowDockingArea1.Owner = Me.UDockManAnaAvv
        Me.WindowDockingArea1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WindowDockingArea1.Size = New System.Drawing.Size(481, 219)
        Me.WindowDockingArea1.TabIndex = 14
        '
        'DockableWindow3
        '
        Me.DockableWindow3.Controls.Add(Me.UPanelFiltriRicerca)
        Me.DockableWindow3.Location = New System.Drawing.Point(0, 0)
        Me.DockableWindow3.Name = "DockableWindow3"
        Me.DockableWindow3.Owner = Me.UDockManAnaAvv
        Me.DockableWindow3.Size = New System.Drawing.Size(481, 214)
        Me.DockableWindow3.TabIndex = 19
        '
        'UsrCtrlAnaAvv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._UsrCtrlAnaAvvAutoHideControl)
        Me.Controls.Add(Me.UPanelDatiGriglia)
        Me.Controls.Add(Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft)
        Me.Controls.Add(Me._UsrCtrlAnaAvvUnpinnedTabAreaTop)
        Me.Controls.Add(Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom)
        Me.Controls.Add(Me._UsrCtrlAnaAvvUnpinnedTabAreaRight)
        Me.Controls.Add(Me.WindowDockingArea1)
        Me.Controls.Add(Me.WindowDockingArea3)
        Me.Controls.Add(Me.WindowDockingArea2)
        Me.Name = "UsrCtrlAnaAvv"
        Me.Size = New System.Drawing.Size(1772, 701)
        Me.UPanelToolbar.ClientArea.ResumeLayout(False)
        Me.UPanelToolbar.ResumeLayout(False)
        CType(Me.UGrpBoxToolbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UGrpBoxToolbar.ResumeLayout(False)
        CType(Me.PicBoxEsportaExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxEsportaPDF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxRicercaDati, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxInserisciRiga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxEliminaRiga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxSalvaDati, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxChiudiFinestra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UPanelDatiDett.ClientArea.ResumeLayout(False)
        Me.UPanelDatiDett.ResumeLayout(False)
        CType(Me.UGrpBoxDatiDett, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UGrpBoxDatiDett.ResumeLayout(False)
        Me.UPanelFiltriRicerca.ClientArea.ResumeLayout(False)
        Me.UPanelFiltriRicerca.ResumeLayout(False)
        CType(Me.UGrpBoxFiltrirRicerca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UGrpBoxFiltrirRicerca.ResumeLayout(False)
        Me.UPanelDatiGriglia.ClientArea.ResumeLayout(False)
        Me.UPanelDatiGriglia.ResumeLayout(False)
        CType(Me.UGrdAnaAvv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UGrpBoxTitoloDatiGriglia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UGrpBoxTitoloDatiGriglia.ResumeLayout(False)
        CType(Me.UDockManAnaAvv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WindowDockingArea2.ResumeLayout(False)
        Me.DockableWindow1.ResumeLayout(False)
        Me.WindowDockingArea3.ResumeLayout(False)
        Me.DockableWindow2.ResumeLayout(False)
        Me.WindowDockingArea1.ResumeLayout(False)
        Me.DockableWindow3.ResumeLayout(False)
        CType(Me.UltraGridBagLayoutManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UPanelToolbar As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UGrpBoxToolbar As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UPanelDatiDett As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UPanelFiltriRicerca As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UPanelDatiGriglia As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UDockManAnaAvv As Infragistics.Win.UltraWinDock.UltraDockManager
    Friend WithEvents _UsrCtrlAnaAvvAutoHideControl As Infragistics.Win.UltraWinDock.AutoHideControl
    Friend WithEvents _UsrCtrlAnaAvvUnpinnedTabAreaBottom As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _UsrCtrlAnaAvvUnpinnedTabAreaTop As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _UsrCtrlAnaAvvUnpinnedTabAreaRight As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _UsrCtrlAnaAvvUnpinnedTabAreaLeft As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents PicBoxChiudiFinestra As PictureBox
    Friend WithEvents PicBoxSalvaDati As PictureBox
    Friend WithEvents PicBoxEliminaRiga As PictureBox
    Friend WithEvents PicBoxInserisciRiga As PictureBox
    Friend WithEvents PicBoxRicercaDati As PictureBox
    Friend WithEvents UlblRigaTitolo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UlblTitoloAnaBase As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UGrpBoxFiltrirRicerca As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UGrpBoxDatiDett As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UGrpBoxTitoloDatiGriglia As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UGrdAnaAvv As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UlblTitoloDatiGriglia As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ImageListAnaAvv As ImageList
    Friend WithEvents PicBoxEsportaExcel As PictureBox
    Friend WithEvents PicBoxEsportaPDF As PictureBox
    Friend WithEvents LSUTxtIndirizzoStudio As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtCellulare As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtNumFaxStudio As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtNumTelStudio As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtEmailPEC As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtEmail As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtNazionalita As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtInidirizzoResidenza As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtPartitaIVA As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtCodiceFiscale As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtNomeCompleto As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUDataIscrizAlboCass As LSUltraDataOraSel.LSUltraDataOraSel
    Friend WithEvents LSUDataIscrizAlboAvv As LSUltraDataOraSel.LSUltraDataOraSel
    Friend WithEvents LSUDataNascita As LSUltraDataOraSel.LSUltraDataOraSel
    Friend WithEvents LSUCboEditForoAppartenenza As LSUltraMenuTendina.LSMenuTendina
    Friend WithEvents LSUCboEditStatoResidenza As LSUltraMenuTendina.LSMenuTendina
    Friend WithEvents LSUCboEditLuogoNascita As LSUltraMenuTendina.LSMenuTendina
    Friend WithEvents LSUCboEditProvNascita As LSUltraMenuTendina.LSMenuTendina
    Friend WithEvents LSUCboEditLuogoResidenza As LSUltraMenuTendina.LSMenuTendina
    Friend WithEvents LSUCboEditProvResidenza As LSUltraMenuTendina.LSMenuTendina
    Friend WithEvents LSUCboEditStatoNascita As LSUltraMenuTendina.LSMenuTendina
    Friend WithEvents LSUCboEditSesso As LSUltraMenuTendina.LSMenuTendina
    Friend WithEvents LSUCboEditTipoPersona As LSUltraMenuTendina.LSMenuTendina
    Friend WithEvents UlblRigaDatiTett As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UBtnConfermaAvvTrovato As Infragistics.Win.Misc.UltraButton
    Friend WithEvents LSUTxtIndirizzoStudioRicerca As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtNominativoRicerca As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents UPicBoxLogoAvv As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents WindowDockingArea1 As Infragistics.Win.UltraWinDock.WindowDockingArea
    Friend WithEvents DockableWindow3 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents WindowDockingArea3 As Infragistics.Win.UltraWinDock.WindowDockingArea
    Friend WithEvents DockableWindow2 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents WindowDockingArea2 As Infragistics.Win.UltraWinDock.WindowDockingArea
    Friend WithEvents DockableWindow1 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents UltraGridBagLayoutManager1 As Infragistics.Win.Misc.UltraGridBagLayoutManager
End Class
