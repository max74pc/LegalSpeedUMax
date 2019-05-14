<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAnaParti
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAnaParti))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim DockAreaPane1 As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedTop, New System.Guid("d9501c4d-5458-4a0f-b82b-4f4a16acfbaa"))
        Dim DockableControlPane1 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("7283cb70-7756-4407-a457-1d02c1436f2a"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("d9501c4d-5458-4a0f-b82b-4f4a16acfbaa"), -1)
        Dim DockAreaPane2 As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedLeft, New System.Guid("db9e0f80-60a3-406f-abdc-c9fc787c6999"))
        Dim DockableControlPane2 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("62a51697-5f31-45b7-9b25-80dac0f03867"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("db9e0f80-60a3-406f-abdc-c9fc787c6999"), -1)
        Dim DockableControlPane3 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("6029bd90-90fd-4439-8379-062051332a5b"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("db9e0f80-60a3-406f-abdc-c9fc787c6999"), -1)
        Dim DockAreaPane3 As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedTop, New System.Guid("d5029311-2436-4210-a52c-8b45b6c51370"))
        Dim DockableControlPane4 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("1c0f9105-e6ba-45e1-9ec0-9d46526b79c3"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("d5029311-2436-4210-a52c-8b45b6c51370"), 0)
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraPanelToolbar = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraGroupBoxtoolbar = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UPicBoxRicercaDati = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.UPicBoxInserisciRiga = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.UPicBoxEliminaRiga = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.UPicBoxSalvaDati = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.UlblRigaTitolo = New Infragistics.Win.Misc.UltraLabel()
        Me.UlblTitoloAnaParti = New Infragistics.Win.Misc.UltraLabel()
        Me.UPicBoxChiudiFinestra = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.UltraPanelFiltriRicerca = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraGroupBoxFiltriRicerca = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UBtnConfermaControparteTrovata = New Infragistics.Win.Misc.UltraButton()
        Me.LSUTxtNominativoRicerca = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.UltraPanelDatiGrglia = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraGroupBoxDatiGriglia = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UGrdAnaParti = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraPanelDatiDett = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraGroupBoxdatiDett = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UPicBoxCaricaLegaleRappr = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.LSUTxtNomeLegaleRappr = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUTxtIndirizzoSedeOperativa = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUTxtIndirizzoSedeLegale = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUTxtEmailPEC = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUTxtEmail = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUTxtNazionalita = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUTxtInidirizzoResidenza = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUTxtPartitaIVA = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUTxtCodiceFiscale = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUTxtNomeCompleto = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUDataNascita = New LSUltraDataOraSel.LSUltraDataOraSel()
        Me.LSUCboEditStatoResidenza = New LSUltraMenuTendina.LSMenuTendina()
        Me.LSUCboEditLuogoNascita = New LSUltraMenuTendina.LSMenuTendina()
        Me.LSUCboEditProvNascita = New LSUltraMenuTendina.LSMenuTendina()
        Me.LSUCboEditLuogoResidenza = New LSUltraMenuTendina.LSMenuTendina()
        Me.LSUCboEditProvResidenza = New LSUltraMenuTendina.LSMenuTendina()
        Me.LSUCboEditStatoNascita = New LSUltraMenuTendina.LSMenuTendina()
        Me.LSUCboEditSesso = New LSUltraMenuTendina.LSMenuTendina()
        Me.LSUCboEditTipoPersona = New LSUltraMenuTendina.LSMenuTendina()
        Me.UlblRigaDatiTett = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraDockAnaParti = New Infragistics.Win.UltraWinDock.UltraDockManager(Me.components)
        Me._FrmAnaPartiUnpinnedTabAreaLeft = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._FrmAnaPartiUnpinnedTabAreaRight = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._FrmAnaPartiUnpinnedTabAreaTop = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._FrmAnaPartiUnpinnedTabAreaBottom = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._FrmAnaPartiAutoHideControl = New Infragistics.Win.UltraWinDock.AutoHideControl()
        Me.WindowDockingArea1 = New Infragistics.Win.UltraWinDock.WindowDockingArea()
        Me.DockableWindow1 = New Infragistics.Win.UltraWinDock.DockableWindow()
        Me.DockableWindow3 = New Infragistics.Win.UltraWinDock.DockableWindow()
        Me.DockableWindow2 = New Infragistics.Win.UltraWinDock.DockableWindow()
        Me.DockableWindow4 = New Infragistics.Win.UltraWinDock.DockableWindow()
        Me.WindowDockingArea2 = New Infragistics.Win.UltraWinDock.WindowDockingArea()
        Me.WindowDockingArea3 = New Infragistics.Win.UltraWinDock.WindowDockingArea()
        Me.ImageListAnaParti = New System.Windows.Forms.ImageList(Me.components)
        Me.LSUTxtCFRicerca = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.UltraPanelToolbar.ClientArea.SuspendLayout()
        Me.UltraPanelToolbar.SuspendLayout()
        CType(Me.UltraGroupBoxtoolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBoxtoolbar.SuspendLayout()
        Me.UltraPanelFiltriRicerca.ClientArea.SuspendLayout()
        Me.UltraPanelFiltriRicerca.SuspendLayout()
        CType(Me.UltraGroupBoxFiltriRicerca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBoxFiltriRicerca.SuspendLayout()
        Me.UltraPanelDatiGrglia.ClientArea.SuspendLayout()
        Me.UltraPanelDatiGrglia.SuspendLayout()
        CType(Me.UltraGroupBoxDatiGriglia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBoxDatiGriglia.SuspendLayout()
        CType(Me.UGrdAnaParti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanelDatiDett.ClientArea.SuspendLayout()
        Me.UltraPanelDatiDett.SuspendLayout()
        CType(Me.UltraGroupBoxdatiDett, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBoxdatiDett.SuspendLayout()
        CType(Me.UltraDockAnaParti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WindowDockingArea1.SuspendLayout()
        Me.DockableWindow1.SuspendLayout()
        Me.DockableWindow3.SuspendLayout()
        Me.DockableWindow2.SuspendLayout()
        Me.DockableWindow4.SuspendLayout()
        Me.WindowDockingArea2.SuspendLayout()
        Me.WindowDockingArea3.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraPanelToolbar
        '
        Appearance1.ImageBackground = CType(resources.GetObject("Appearance1.ImageBackground"), System.Drawing.Image)
        Me.UltraPanelToolbar.Appearance = Appearance1
        '
        'UltraPanelToolbar.ClientArea
        '
        Me.UltraPanelToolbar.ClientArea.Controls.Add(Me.UltraGroupBoxtoolbar)
        Me.UltraPanelToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraPanelToolbar.Location = New System.Drawing.Point(0, 19)
        Me.UltraPanelToolbar.MaximumSize = New System.Drawing.Size(3000, 81)
        Me.UltraPanelToolbar.MinimumSize = New System.Drawing.Size(1100, 81)
        Me.UltraPanelToolbar.Name = "UltraPanelToolbar"
        Me.UltraPanelToolbar.Size = New System.Drawing.Size(1762, 81)
        Me.UltraPanelToolbar.TabIndex = 5
        '
        'UltraGroupBoxtoolbar
        '
        Appearance2.BackColorAlpha = Infragistics.Win.Alpha.Transparent
        Me.UltraGroupBoxtoolbar.Appearance = Appearance2
        Me.UltraGroupBoxtoolbar.Controls.Add(Me.UPicBoxRicercaDati)
        Me.UltraGroupBoxtoolbar.Controls.Add(Me.UPicBoxInserisciRiga)
        Me.UltraGroupBoxtoolbar.Controls.Add(Me.UPicBoxEliminaRiga)
        Me.UltraGroupBoxtoolbar.Controls.Add(Me.UPicBoxSalvaDati)
        Me.UltraGroupBoxtoolbar.Controls.Add(Me.UlblRigaTitolo)
        Me.UltraGroupBoxtoolbar.Controls.Add(Me.UlblTitoloAnaParti)
        Me.UltraGroupBoxtoolbar.Controls.Add(Me.UPicBoxChiudiFinestra)
        Me.UltraGroupBoxtoolbar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBoxtoolbar.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBoxtoolbar.Name = "UltraGroupBoxtoolbar"
        Me.UltraGroupBoxtoolbar.Size = New System.Drawing.Size(1762, 81)
        Me.UltraGroupBoxtoolbar.TabIndex = 1
        '
        'UPicBoxRicercaDati
        '
        Me.UPicBoxRicercaDati.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UPicBoxRicercaDati.BorderShadowColor = System.Drawing.Color.Empty
        Me.UPicBoxRicercaDati.Image = CType(resources.GetObject("UPicBoxRicercaDati.Image"), Object)
        Me.UPicBoxRicercaDati.Location = New System.Drawing.Point(1395, 3)
        Me.UPicBoxRicercaDati.Name = "UPicBoxRicercaDati"
        Me.UPicBoxRicercaDati.Size = New System.Drawing.Size(68, 75)
        Me.UPicBoxRicercaDati.TabIndex = 12
        '
        'UPicBoxInserisciRiga
        '
        Me.UPicBoxInserisciRiga.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UPicBoxInserisciRiga.BorderShadowColor = System.Drawing.Color.Empty
        Me.UPicBoxInserisciRiga.Image = CType(resources.GetObject("UPicBoxInserisciRiga.Image"), Object)
        Me.UPicBoxInserisciRiga.Location = New System.Drawing.Point(1469, 3)
        Me.UPicBoxInserisciRiga.Name = "UPicBoxInserisciRiga"
        Me.UPicBoxInserisciRiga.Size = New System.Drawing.Size(68, 75)
        Me.UPicBoxInserisciRiga.TabIndex = 11
        '
        'UPicBoxEliminaRiga
        '
        Me.UPicBoxEliminaRiga.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UPicBoxEliminaRiga.BorderShadowColor = System.Drawing.Color.Empty
        Me.UPicBoxEliminaRiga.Image = CType(resources.GetObject("UPicBoxEliminaRiga.Image"), Object)
        Me.UPicBoxEliminaRiga.Location = New System.Drawing.Point(1543, 3)
        Me.UPicBoxEliminaRiga.Name = "UPicBoxEliminaRiga"
        Me.UPicBoxEliminaRiga.Size = New System.Drawing.Size(68, 75)
        Me.UPicBoxEliminaRiga.TabIndex = 10
        '
        'UPicBoxSalvaDati
        '
        Me.UPicBoxSalvaDati.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UPicBoxSalvaDati.BorderShadowColor = System.Drawing.Color.Empty
        Me.UPicBoxSalvaDati.Image = CType(resources.GetObject("UPicBoxSalvaDati.Image"), Object)
        Me.UPicBoxSalvaDati.Location = New System.Drawing.Point(1617, 3)
        Me.UPicBoxSalvaDati.Name = "UPicBoxSalvaDati"
        Me.UPicBoxSalvaDati.Size = New System.Drawing.Size(68, 75)
        Me.UPicBoxSalvaDati.TabIndex = 9
        '
        'UlblRigaTitolo
        '
        Me.UlblRigaTitolo.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UlblRigaTitolo.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UlblRigaTitolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UlblRigaTitolo.Location = New System.Drawing.Point(12, 60)
        Me.UlblRigaTitolo.Name = "UlblRigaTitolo"
        Me.UlblRigaTitolo.Size = New System.Drawing.Size(597, 3)
        Me.UlblRigaTitolo.TabIndex = 8
        '
        'UlblTitoloAnaParti
        '
        Me.UlblTitoloAnaParti.Font = New System.Drawing.Font("Linux Libertine Display G", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UlblTitoloAnaParti.Location = New System.Drawing.Point(12, 14)
        Me.UlblTitoloAnaParti.Name = "UlblTitoloAnaParti"
        Me.UlblTitoloAnaParti.Size = New System.Drawing.Size(372, 40)
        Me.UlblTitoloAnaParti.TabIndex = 7
        Me.UlblTitoloAnaParti.Text = "Anagrafica Parti"
        '
        'UPicBoxChiudiFinestra
        '
        Me.UPicBoxChiudiFinestra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UPicBoxChiudiFinestra.BorderShadowColor = System.Drawing.Color.Empty
        Me.UPicBoxChiudiFinestra.Image = CType(resources.GetObject("UPicBoxChiudiFinestra.Image"), Object)
        Me.UPicBoxChiudiFinestra.Location = New System.Drawing.Point(1691, 3)
        Me.UPicBoxChiudiFinestra.Name = "UPicBoxChiudiFinestra"
        Me.UPicBoxChiudiFinestra.Size = New System.Drawing.Size(68, 75)
        Me.UPicBoxChiudiFinestra.TabIndex = 2
        '
        'UltraPanelFiltriRicerca
        '
        '
        'UltraPanelFiltriRicerca.ClientArea
        '
        Me.UltraPanelFiltriRicerca.ClientArea.Controls.Add(Me.UltraGroupBoxFiltriRicerca)
        Me.UltraPanelFiltriRicerca.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraPanelFiltriRicerca.Location = New System.Drawing.Point(0, 19)
        Me.UltraPanelFiltriRicerca.Name = "UltraPanelFiltriRicerca"
        Me.UltraPanelFiltriRicerca.Size = New System.Drawing.Size(488, 190)
        Me.UltraPanelFiltriRicerca.TabIndex = 7
        '
        'UltraGroupBoxFiltriRicerca
        '
        Me.UltraGroupBoxFiltriRicerca.Controls.Add(Me.LSUTxtCFRicerca)
        Me.UltraGroupBoxFiltriRicerca.Controls.Add(Me.UBtnConfermaControparteTrovata)
        Me.UltraGroupBoxFiltriRicerca.Controls.Add(Me.LSUTxtNominativoRicerca)
        Me.UltraGroupBoxFiltriRicerca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBoxFiltriRicerca.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBoxFiltriRicerca.Name = "UltraGroupBoxFiltriRicerca"
        Me.UltraGroupBoxFiltriRicerca.Size = New System.Drawing.Size(488, 190)
        Me.UltraGroupBoxFiltriRicerca.TabIndex = 1
        '
        'UBtnConfermaControparteTrovata
        '
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UBtnConfermaControparteTrovata.Appearance = Appearance3
        Me.UBtnConfermaControparteTrovata.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.UBtnConfermaControparteTrovata.Font = New System.Drawing.Font("Linux Libertine Display G", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UBtnConfermaControparteTrovata.Location = New System.Drawing.Point(86, 135)
        Me.UBtnConfermaControparteTrovata.Name = "UBtnConfermaControparteTrovata"
        Me.UBtnConfermaControparteTrovata.Size = New System.Drawing.Size(298, 39)
        Me.UBtnConfermaControparteTrovata.TabIndex = 3
        Me.UBtnConfermaControparteTrovata.Text = "Conferma Parte Trovata"
        '
        'LSUTxtNominativoRicerca
        '
        Me.LSUTxtNominativoRicerca.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtNominativoRicerca.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtNominativoRicerca.LarghezzaCasellaTesto = 204
        Me.LSUTxtNominativoRicerca.LarghezzaEtichetta = 209
        Me.LSUTxtNominativoRicerca.Location = New System.Drawing.Point(6, 29)
        Me.LSUTxtNominativoRicerca.Name = "LSUTxtNominativoRicerca"
        Me.LSUTxtNominativoRicerca.Obbligatorio = False
        Me.LSUTxtNominativoRicerca.Size = New System.Drawing.Size(474, 30)
        Me.LSUTxtNominativoRicerca.TabIndex = 0
        Me.LSUTxtNominativoRicerca.TestoEtichetta = "Nominativo (compreso)"
        Me.LSUTxtNominativoRicerca.ValoreCasellaTesto = ""
        '
        'UltraPanelDatiGrglia
        '
        '
        'UltraPanelDatiGrglia.ClientArea
        '
        Me.UltraPanelDatiGrglia.ClientArea.Controls.Add(Me.UltraGroupBoxDatiGriglia)
        Me.UltraPanelDatiGrglia.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraPanelDatiGrglia.Location = New System.Drawing.Point(0, 19)
        Me.UltraPanelDatiGrglia.Name = "UltraPanelDatiGrglia"
        Me.UltraPanelDatiGrglia.Size = New System.Drawing.Size(488, 346)
        Me.UltraPanelDatiGrglia.TabIndex = 8
        '
        'UltraGroupBoxDatiGriglia
        '
        Me.UltraGroupBoxDatiGriglia.Controls.Add(Me.UGrdAnaParti)
        Me.UltraGroupBoxDatiGriglia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBoxDatiGriglia.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBoxDatiGriglia.Name = "UltraGroupBoxDatiGriglia"
        Me.UltraGroupBoxDatiGriglia.Size = New System.Drawing.Size(488, 346)
        Me.UltraGroupBoxDatiGriglia.TabIndex = 1
        '
        'UGrdAnaParti
        '
        Me.UGrdAnaParti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UGrdAnaParti.Location = New System.Drawing.Point(3, 3)
        Me.UGrdAnaParti.Name = "UGrdAnaParti"
        Me.UGrdAnaParti.Size = New System.Drawing.Size(482, 340)
        Me.UGrdAnaParti.TabIndex = 1
        Me.UGrdAnaParti.Text = "Griglia Anagrafica Parti"
        '
        'UltraPanelDatiDett
        '
        '
        'UltraPanelDatiDett.ClientArea
        '
        Me.UltraPanelDatiDett.ClientArea.Controls.Add(Me.UltraGroupBoxdatiDett)
        Me.UltraPanelDatiDett.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraPanelDatiDett.Location = New System.Drawing.Point(0, 19)
        Me.UltraPanelDatiDett.Name = "UltraPanelDatiDett"
        Me.UltraPanelDatiDett.Size = New System.Drawing.Size(1269, 555)
        Me.UltraPanelDatiDett.TabIndex = 6
        '
        'UltraGroupBoxdatiDett
        '
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.UPicBoxCaricaLegaleRappr)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.LSUTxtNomeLegaleRappr)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.LSUTxtIndirizzoSedeOperativa)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.LSUTxtIndirizzoSedeLegale)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.LSUTxtEmailPEC)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.LSUTxtEmail)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.LSUTxtNazionalita)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.LSUTxtInidirizzoResidenza)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.LSUTxtPartitaIVA)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.LSUTxtCodiceFiscale)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.LSUTxtNomeCompleto)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.LSUDataNascita)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.LSUCboEditStatoResidenza)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.LSUCboEditLuogoNascita)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.LSUCboEditProvNascita)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.LSUCboEditLuogoResidenza)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.LSUCboEditProvResidenza)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.LSUCboEditStatoNascita)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.LSUCboEditSesso)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.LSUCboEditTipoPersona)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.UlblRigaDatiTett)
        Me.UltraGroupBoxdatiDett.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBoxdatiDett.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBoxdatiDett.Name = "UltraGroupBoxdatiDett"
        Me.UltraGroupBoxdatiDett.Size = New System.Drawing.Size(1269, 555)
        Me.UltraGroupBoxdatiDett.TabIndex = 1
        '
        'UPicBoxCaricaLegaleRappr
        '
        Me.UPicBoxCaricaLegaleRappr.BorderShadowColor = System.Drawing.Color.Empty
        Me.UPicBoxCaricaLegaleRappr.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UPicBoxCaricaLegaleRappr.Image = CType(resources.GetObject("UPicBoxCaricaLegaleRappr.Image"), Object)
        Me.UPicBoxCaricaLegaleRappr.Location = New System.Drawing.Point(625, 436)
        Me.UPicBoxCaricaLegaleRappr.Name = "UPicBoxCaricaLegaleRappr"
        Me.UPicBoxCaricaLegaleRappr.Size = New System.Drawing.Size(32, 32)
        Me.UPicBoxCaricaLegaleRappr.TabIndex = 46
        '
        'LSUTxtNomeLegaleRappr
        '
        Me.LSUTxtNomeLegaleRappr.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtNomeLegaleRappr.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtNomeLegaleRappr.LarghezzaCasellaTesto = 240
        Me.LSUTxtNomeLegaleRappr.LarghezzaEtichetta = 220
        Me.LSUTxtNomeLegaleRappr.Location = New System.Drawing.Point(7, 438)
        Me.LSUTxtNomeLegaleRappr.Name = "LSUTxtNomeLegaleRappr"
        Me.LSUTxtNomeLegaleRappr.Obbligatorio = True
        Me.LSUTxtNomeLegaleRappr.Size = New System.Drawing.Size(613, 30)
        Me.LSUTxtNomeLegaleRappr.TabIndex = 45
        Me.LSUTxtNomeLegaleRappr.TestoEtichetta = "Nome Legale Rappresentante:"
        Me.LSUTxtNomeLegaleRappr.ValoreCasellaTesto = ""
        '
        'LSUTxtIndirizzoSedeOperativa
        '
        Me.LSUTxtIndirizzoSedeOperativa.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtIndirizzoSedeOperativa.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtIndirizzoSedeOperativa.LarghezzaCasellaTesto = 300
        Me.LSUTxtIndirizzoSedeOperativa.LarghezzaEtichetta = 190
        Me.LSUTxtIndirizzoSedeOperativa.Location = New System.Drawing.Point(615, 392)
        Me.LSUTxtIndirizzoSedeOperativa.Name = "LSUTxtIndirizzoSedeOperativa"
        Me.LSUTxtIndirizzoSedeOperativa.Obbligatorio = True
        Me.LSUTxtIndirizzoSedeOperativa.Size = New System.Drawing.Size(651, 30)
        Me.LSUTxtIndirizzoSedeOperativa.TabIndex = 44
        Me.LSUTxtIndirizzoSedeOperativa.TestoEtichetta = "Indirizzo Sede Operativa:"
        Me.LSUTxtIndirizzoSedeOperativa.ValoreCasellaTesto = ""
        '
        'LSUTxtIndirizzoSedeLegale
        '
        Me.LSUTxtIndirizzoSedeLegale.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtIndirizzoSedeLegale.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtIndirizzoSedeLegale.LarghezzaCasellaTesto = 300
        Me.LSUTxtIndirizzoSedeLegale.LarghezzaEtichetta = 178
        Me.LSUTxtIndirizzoSedeLegale.Location = New System.Drawing.Point(7, 392)
        Me.LSUTxtIndirizzoSedeLegale.Name = "LSUTxtIndirizzoSedeLegale"
        Me.LSUTxtIndirizzoSedeLegale.Obbligatorio = True
        Me.LSUTxtIndirizzoSedeLegale.Size = New System.Drawing.Size(613, 30)
        Me.LSUTxtIndirizzoSedeLegale.TabIndex = 43
        Me.LSUTxtIndirizzoSedeLegale.TestoEtichetta = "Indirizzo Sede Legale:"
        Me.LSUTxtIndirizzoSedeLegale.ValoreCasellaTesto = ""
        '
        'LSUTxtEmailPEC
        '
        Me.LSUTxtEmailPEC.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtEmailPEC.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtEmailPEC.LarghezzaCasellaTesto = 204
        Me.LSUTxtEmailPEC.LarghezzaEtichetta = 195
        Me.LSUTxtEmailPEC.Location = New System.Drawing.Point(611, 347)
        Me.LSUTxtEmailPEC.Name = "LSUTxtEmailPEC"
        Me.LSUTxtEmailPEC.Obbligatorio = False
        Me.LSUTxtEmailPEC.Size = New System.Drawing.Size(655, 30)
        Me.LSUTxtEmailPEC.TabIndex = 17
        Me.LSUTxtEmailPEC.TestoEtichetta = "E-Mail PEC:"
        Me.LSUTxtEmailPEC.ValoreCasellaTesto = ""
        '
        'LSUTxtEmail
        '
        Me.LSUTxtEmail.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtEmail.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtEmail.LarghezzaCasellaTesto = 204
        Me.LSUTxtEmail.LarghezzaEtichetta = 178
        Me.LSUTxtEmail.Location = New System.Drawing.Point(7, 347)
        Me.LSUTxtEmail.Name = "LSUTxtEmail"
        Me.LSUTxtEmail.Obbligatorio = True
        Me.LSUTxtEmail.Size = New System.Drawing.Size(608, 30)
        Me.LSUTxtEmail.TabIndex = 16
        Me.LSUTxtEmail.TestoEtichetta = "E-Mail:"
        Me.LSUTxtEmail.ValoreCasellaTesto = ""
        '
        'LSUTxtNazionalita
        '
        Me.LSUTxtNazionalita.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtNazionalita.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtNazionalita.LarghezzaCasellaTesto = 204
        Me.LSUTxtNazionalita.LarghezzaEtichetta = 195
        Me.LSUTxtNazionalita.Location = New System.Drawing.Point(611, 310)
        Me.LSUTxtNazionalita.Name = "LSUTxtNazionalita"
        Me.LSUTxtNazionalita.Obbligatorio = False
        Me.LSUTxtNazionalita.Size = New System.Drawing.Size(658, 30)
        Me.LSUTxtNazionalita.TabIndex = 15
        Me.LSUTxtNazionalita.TestoEtichetta = "Nazionalità:"
        Me.LSUTxtNazionalita.ValoreCasellaTesto = ""
        '
        'LSUTxtInidirizzoResidenza
        '
        Me.LSUTxtInidirizzoResidenza.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtInidirizzoResidenza.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtInidirizzoResidenza.LarghezzaCasellaTesto = 204
        Me.LSUTxtInidirizzoResidenza.LarghezzaEtichetta = 180
        Me.LSUTxtInidirizzoResidenza.Location = New System.Drawing.Point(4, 310)
        Me.LSUTxtInidirizzoResidenza.Name = "LSUTxtInidirizzoResidenza"
        Me.LSUTxtInidirizzoResidenza.Obbligatorio = False
        Me.LSUTxtInidirizzoResidenza.Size = New System.Drawing.Size(611, 30)
        Me.LSUTxtInidirizzoResidenza.TabIndex = 14
        Me.LSUTxtInidirizzoResidenza.TestoEtichetta = "Inidirizzo di Residenza:"
        Me.LSUTxtInidirizzoResidenza.ValoreCasellaTesto = ""
        '
        'LSUTxtPartitaIVA
        '
        Me.LSUTxtPartitaIVA.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtPartitaIVA.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtPartitaIVA.LarghezzaCasellaTesto = 204
        Me.LSUTxtPartitaIVA.LarghezzaEtichetta = 180
        Me.LSUTxtPartitaIVA.Location = New System.Drawing.Point(3, 236)
        Me.LSUTxtPartitaIVA.Name = "LSUTxtPartitaIVA"
        Me.LSUTxtPartitaIVA.Obbligatorio = False
        Me.LSUTxtPartitaIVA.Size = New System.Drawing.Size(617, 30)
        Me.LSUTxtPartitaIVA.TabIndex = 10
        Me.LSUTxtPartitaIVA.TestoEtichetta = "Partita IVA:"
        Me.LSUTxtPartitaIVA.ValoreCasellaTesto = ""
        '
        'LSUTxtCodiceFiscale
        '
        Me.LSUTxtCodiceFiscale.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtCodiceFiscale.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtCodiceFiscale.LarghezzaCasellaTesto = 204
        Me.LSUTxtCodiceFiscale.LarghezzaEtichetta = 195
        Me.LSUTxtCodiceFiscale.Location = New System.Drawing.Point(611, 200)
        Me.LSUTxtCodiceFiscale.Name = "LSUTxtCodiceFiscale"
        Me.LSUTxtCodiceFiscale.Obbligatorio = True
        Me.LSUTxtCodiceFiscale.Size = New System.Drawing.Size(658, 30)
        Me.LSUTxtCodiceFiscale.TabIndex = 9
        Me.LSUTxtCodiceFiscale.TestoEtichetta = "Codice Fiscale:"
        Me.LSUTxtCodiceFiscale.ValoreCasellaTesto = ""
        '
        'LSUTxtNomeCompleto
        '
        Me.LSUTxtNomeCompleto.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtNomeCompleto.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtNomeCompleto.LarghezzaCasellaTesto = 204
        Me.LSUTxtNomeCompleto.LarghezzaEtichetta = 190
        Me.LSUTxtNomeCompleto.Location = New System.Drawing.Point(615, 88)
        Me.LSUTxtNomeCompleto.Name = "LSUTxtNomeCompleto"
        Me.LSUTxtNomeCompleto.Obbligatorio = True
        Me.LSUTxtNomeCompleto.Size = New System.Drawing.Size(648, 30)
        Me.LSUTxtNomeCompleto.TabIndex = 3
        Me.LSUTxtNomeCompleto.TestoEtichetta = "Nome Completo:"
        Me.LSUTxtNomeCompleto.ValoreCasellaTesto = ""
        '
        'LSUDataNascita
        '
        Me.LSUDataNascita.ColoreSfondoDataOraSelInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUDataNascita.ColoreSfondoDataOraSelInUscita = System.Drawing.Color.White
        Me.LSUDataNascita.LarghezzaDataOraSel = 114
        Me.LSUDataNascita.LarghezzaEtichetta = 178
        Me.LSUDataNascita.Location = New System.Drawing.Point(6, 124)
        Me.LSUDataNascita.Name = "LSUDataNascita"
        Me.LSUDataNascita.Obbligatorio = True
        Me.LSUDataNascita.Size = New System.Drawing.Size(609, 31)
        Me.LSUDataNascita.TabIndex = 4
        Me.LSUDataNascita.TestoEtichetta = "Data di Nascita:"
        Me.LSUDataNascita.ValoreDataOraSel = New Date(2019, 4, 2, 0, 0, 0, 0)
        '
        'LSUCboEditStatoResidenza
        '
        Me.LSUCboEditStatoResidenza.ColoreSfondoMenuTendinaInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUCboEditStatoResidenza.ColoreSfondoMenuTendinaInUscita = System.Drawing.Color.White
        Me.LSUCboEditStatoResidenza.LarghezzaCasellaTesto = 241
        Me.LSUCboEditStatoResidenza.LarghezzaEtichetta = 190
        Me.LSUCboEditStatoResidenza.Location = New System.Drawing.Point(615, 236)
        Me.LSUCboEditStatoResidenza.Name = "LSUCboEditStatoResidenza"
        Me.LSUCboEditStatoResidenza.Obbligatorio = False
        Me.LSUCboEditStatoResidenza.Size = New System.Drawing.Size(658, 32)
        Me.LSUCboEditStatoResidenza.TabIndex = 11
        Me.LSUCboEditStatoResidenza.TestoEtichetta = "Stato di Residenza:"
        Me.LSUCboEditStatoResidenza.ValoreMenuTendina = ""
        '
        'LSUCboEditLuogoNascita
        '
        Me.LSUCboEditLuogoNascita.ColoreSfondoMenuTendinaInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUCboEditLuogoNascita.ColoreSfondoMenuTendinaInUscita = System.Drawing.Color.White
        Me.LSUCboEditLuogoNascita.LarghezzaCasellaTesto = 241
        Me.LSUCboEditLuogoNascita.LarghezzaEtichetta = 178
        Me.LSUCboEditLuogoNascita.Location = New System.Drawing.Point(6, 195)
        Me.LSUCboEditLuogoNascita.Name = "LSUCboEditLuogoNascita"
        Me.LSUCboEditLuogoNascita.Obbligatorio = True
        Me.LSUCboEditLuogoNascita.Size = New System.Drawing.Size(609, 32)
        Me.LSUCboEditLuogoNascita.TabIndex = 8
        Me.LSUCboEditLuogoNascita.TestoEtichetta = "Luogo di Nascita:"
        Me.LSUCboEditLuogoNascita.ValoreMenuTendina = ""
        '
        'LSUCboEditProvNascita
        '
        Me.LSUCboEditProvNascita.ColoreSfondoMenuTendinaInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUCboEditProvNascita.ColoreSfondoMenuTendinaInUscita = System.Drawing.Color.White
        Me.LSUCboEditProvNascita.LarghezzaCasellaTesto = 241
        Me.LSUCboEditProvNascita.LarghezzaEtichetta = 190
        Me.LSUCboEditProvNascita.Location = New System.Drawing.Point(615, 162)
        Me.LSUCboEditProvNascita.Name = "LSUCboEditProvNascita"
        Me.LSUCboEditProvNascita.Obbligatorio = True
        Me.LSUCboEditProvNascita.Size = New System.Drawing.Size(659, 32)
        Me.LSUCboEditProvNascita.TabIndex = 7
        Me.LSUCboEditProvNascita.TestoEtichetta = "Provincia di Nascita:"
        Me.LSUCboEditProvNascita.ValoreMenuTendina = ""
        '
        'LSUCboEditLuogoResidenza
        '
        Me.LSUCboEditLuogoResidenza.ColoreSfondoMenuTendinaInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUCboEditLuogoResidenza.ColoreSfondoMenuTendinaInUscita = System.Drawing.Color.White
        Me.LSUCboEditLuogoResidenza.LarghezzaCasellaTesto = 241
        Me.LSUCboEditLuogoResidenza.LarghezzaEtichetta = 191
        Me.LSUCboEditLuogoResidenza.Location = New System.Drawing.Point(614, 273)
        Me.LSUCboEditLuogoResidenza.Name = "LSUCboEditLuogoResidenza"
        Me.LSUCboEditLuogoResidenza.Obbligatorio = False
        Me.LSUCboEditLuogoResidenza.Size = New System.Drawing.Size(660, 32)
        Me.LSUCboEditLuogoResidenza.TabIndex = 13
        Me.LSUCboEditLuogoResidenza.TestoEtichetta = "Luogo di Residenza:"
        Me.LSUCboEditLuogoResidenza.ValoreMenuTendina = ""
        '
        'LSUCboEditProvResidenza
        '
        Me.LSUCboEditProvResidenza.ColoreSfondoMenuTendinaInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUCboEditProvResidenza.ColoreSfondoMenuTendinaInUscita = System.Drawing.Color.White
        Me.LSUCboEditProvResidenza.LarghezzaCasellaTesto = 241
        Me.LSUCboEditProvResidenza.LarghezzaEtichetta = 180
        Me.LSUCboEditProvResidenza.Location = New System.Drawing.Point(3, 272)
        Me.LSUCboEditProvResidenza.Name = "LSUCboEditProvResidenza"
        Me.LSUCboEditProvResidenza.Obbligatorio = False
        Me.LSUCboEditProvResidenza.Size = New System.Drawing.Size(612, 32)
        Me.LSUCboEditProvResidenza.TabIndex = 12
        Me.LSUCboEditProvResidenza.TestoEtichetta = "Provincia di Residenza:"
        Me.LSUCboEditProvResidenza.ValoreMenuTendina = ""
        '
        'LSUCboEditStatoNascita
        '
        Me.LSUCboEditStatoNascita.ColoreSfondoMenuTendinaInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUCboEditStatoNascita.ColoreSfondoMenuTendinaInUscita = System.Drawing.Color.White
        Me.LSUCboEditStatoNascita.LarghezzaCasellaTesto = 241
        Me.LSUCboEditStatoNascita.LarghezzaEtichetta = 180
        Me.LSUCboEditStatoNascita.Location = New System.Drawing.Point(4, 161)
        Me.LSUCboEditStatoNascita.Name = "LSUCboEditStatoNascita"
        Me.LSUCboEditStatoNascita.Obbligatorio = True
        Me.LSUCboEditStatoNascita.Size = New System.Drawing.Size(611, 32)
        Me.LSUCboEditStatoNascita.TabIndex = 6
        Me.LSUCboEditStatoNascita.TestoEtichetta = "Stato di Nascita:"
        Me.LSUCboEditStatoNascita.ValoreMenuTendina = ""
        '
        'LSUCboEditSesso
        '
        Me.LSUCboEditSesso.ColoreSfondoMenuTendinaInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUCboEditSesso.ColoreSfondoMenuTendinaInUscita = System.Drawing.Color.White
        Me.LSUCboEditSesso.LarghezzaCasellaTesto = 241
        Me.LSUCboEditSesso.LarghezzaEtichetta = 190
        Me.LSUCboEditSesso.Location = New System.Drawing.Point(615, 124)
        Me.LSUCboEditSesso.Name = "LSUCboEditSesso"
        Me.LSUCboEditSesso.Obbligatorio = True
        Me.LSUCboEditSesso.Size = New System.Drawing.Size(651, 32)
        Me.LSUCboEditSesso.TabIndex = 5
        Me.LSUCboEditSesso.TestoEtichetta = "Sesso:"
        Me.LSUCboEditSesso.ValoreMenuTendina = ""
        '
        'LSUCboEditTipoPersona
        '
        Me.LSUCboEditTipoPersona.ColoreSfondoMenuTendinaInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUCboEditTipoPersona.ColoreSfondoMenuTendinaInUscita = System.Drawing.Color.White
        Me.LSUCboEditTipoPersona.LarghezzaCasellaTesto = 241
        Me.LSUCboEditTipoPersona.LarghezzaEtichetta = 180
        Me.LSUCboEditTipoPersona.Location = New System.Drawing.Point(3, 85)
        Me.LSUCboEditTipoPersona.Name = "LSUCboEditTipoPersona"
        Me.LSUCboEditTipoPersona.Obbligatorio = True
        Me.LSUCboEditTipoPersona.Size = New System.Drawing.Size(612, 32)
        Me.LSUCboEditTipoPersona.TabIndex = 2
        Me.LSUCboEditTipoPersona.TestoEtichetta = "Tipolgia Persona:"
        Me.LSUCboEditTipoPersona.ValoreMenuTendina = ""
        '
        'UlblRigaDatiTett
        '
        Me.UlblRigaDatiTett.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UlblRigaDatiTett.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UlblRigaDatiTett.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UlblRigaDatiTett.Location = New System.Drawing.Point(6, 76)
        Me.UlblRigaDatiTett.Name = "UlblRigaDatiTett"
        Me.UlblRigaDatiTett.Size = New System.Drawing.Size(1250, 3)
        Me.UlblRigaDatiTett.TabIndex = 42
        '
        'UltraDockAnaParti
        '
        Me.UltraDockAnaParti.CompressUnpinnedTabs = False
        DockAreaPane1.DockedBefore = New System.Guid("db9e0f80-60a3-406f-abdc-c9fc787c6999")
        DockableControlPane1.Control = Me.UltraPanelToolbar
        DockableControlPane1.OriginalControlBounds = New System.Drawing.Rectangle(0, 0, 1095, 100)
        DockableControlPane1.Size = New System.Drawing.Size(100, 100)
        DockAreaPane1.Panes.AddRange(New Infragistics.Win.UltraWinDock.DockablePaneBase() {DockableControlPane1})
        DockAreaPane1.Size = New System.Drawing.Size(1762, 95)
        DockAreaPane2.DockedBefore = New System.Guid("d5029311-2436-4210-a52c-8b45b6c51370")
        DockableControlPane2.Control = Me.UltraPanelFiltriRicerca
        DockableControlPane2.OriginalControlBounds = New System.Drawing.Rectangle(0, 100, 526, 187)
        DockableControlPane2.Size = New System.Drawing.Size(100, 45)
        DockableControlPane2.Text = "Filtri di Ricerca"
        DockableControlPane3.Control = Me.UltraPanelDatiGrglia
        DockableControlPane3.OriginalControlBounds = New System.Drawing.Rectangle(100, 100, 526, 478)
        DockableControlPane3.Size = New System.Drawing.Size(100, 79)
        DockableControlPane3.Text = "Dati Griglia"
        DockAreaPane2.Panes.AddRange(New Infragistics.Win.UltraWinDock.DockablePaneBase() {DockableControlPane2, DockableControlPane3})
        DockAreaPane2.SelectedTabIndex = 1
        DockAreaPane2.Size = New System.Drawing.Size(488, 579)
        DockableControlPane4.Control = Me.UltraPanelDatiDett
        DockableControlPane4.OriginalControlBounds = New System.Drawing.Rectangle(536, 578, 569, 0)
        DockableControlPane4.Size = New System.Drawing.Size(100, 100)
        DockableControlPane4.Text = "Dati di Dettaglio"
        DockAreaPane3.Panes.AddRange(New Infragistics.Win.UltraWinDock.DockablePaneBase() {DockableControlPane4})
        DockAreaPane3.Size = New System.Drawing.Size(1269, 574)
        Me.UltraDockAnaParti.DockAreas.AddRange(New Infragistics.Win.UltraWinDock.DockAreaPane() {DockAreaPane1, DockAreaPane2, DockAreaPane3})
        Me.UltraDockAnaParti.HostControl = Me
        Appearance4.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.UltraDockAnaParti.SplitterBarAppearance = Appearance4
        '
        '_FrmAnaPartiUnpinnedTabAreaLeft
        '
        Me._FrmAnaPartiUnpinnedTabAreaLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me._FrmAnaPartiUnpinnedTabAreaLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FrmAnaPartiUnpinnedTabAreaLeft.Location = New System.Drawing.Point(0, 0)
        Me._FrmAnaPartiUnpinnedTabAreaLeft.Name = "_FrmAnaPartiUnpinnedTabAreaLeft"
        Me._FrmAnaPartiUnpinnedTabAreaLeft.Owner = Me.UltraDockAnaParti
        Me._FrmAnaPartiUnpinnedTabAreaLeft.Size = New System.Drawing.Size(0, 679)
        Me._FrmAnaPartiUnpinnedTabAreaLeft.TabIndex = 0
        '
        '_FrmAnaPartiUnpinnedTabAreaRight
        '
        Me._FrmAnaPartiUnpinnedTabAreaRight.Dock = System.Windows.Forms.DockStyle.Right
        Me._FrmAnaPartiUnpinnedTabAreaRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FrmAnaPartiUnpinnedTabAreaRight.Location = New System.Drawing.Point(1762, 0)
        Me._FrmAnaPartiUnpinnedTabAreaRight.Name = "_FrmAnaPartiUnpinnedTabAreaRight"
        Me._FrmAnaPartiUnpinnedTabAreaRight.Owner = Me.UltraDockAnaParti
        Me._FrmAnaPartiUnpinnedTabAreaRight.Size = New System.Drawing.Size(0, 679)
        Me._FrmAnaPartiUnpinnedTabAreaRight.TabIndex = 1
        '
        '_FrmAnaPartiUnpinnedTabAreaTop
        '
        Me._FrmAnaPartiUnpinnedTabAreaTop.Dock = System.Windows.Forms.DockStyle.Top
        Me._FrmAnaPartiUnpinnedTabAreaTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FrmAnaPartiUnpinnedTabAreaTop.Location = New System.Drawing.Point(0, 0)
        Me._FrmAnaPartiUnpinnedTabAreaTop.Name = "_FrmAnaPartiUnpinnedTabAreaTop"
        Me._FrmAnaPartiUnpinnedTabAreaTop.Owner = Me.UltraDockAnaParti
        Me._FrmAnaPartiUnpinnedTabAreaTop.Size = New System.Drawing.Size(1762, 0)
        Me._FrmAnaPartiUnpinnedTabAreaTop.TabIndex = 2
        '
        '_FrmAnaPartiUnpinnedTabAreaBottom
        '
        Me._FrmAnaPartiUnpinnedTabAreaBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._FrmAnaPartiUnpinnedTabAreaBottom.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FrmAnaPartiUnpinnedTabAreaBottom.Location = New System.Drawing.Point(0, 679)
        Me._FrmAnaPartiUnpinnedTabAreaBottom.Name = "_FrmAnaPartiUnpinnedTabAreaBottom"
        Me._FrmAnaPartiUnpinnedTabAreaBottom.Owner = Me.UltraDockAnaParti
        Me._FrmAnaPartiUnpinnedTabAreaBottom.Size = New System.Drawing.Size(1762, 0)
        Me._FrmAnaPartiUnpinnedTabAreaBottom.TabIndex = 3
        '
        '_FrmAnaPartiAutoHideControl
        '
        Me._FrmAnaPartiAutoHideControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FrmAnaPartiAutoHideControl.Location = New System.Drawing.Point(0, 0)
        Me._FrmAnaPartiAutoHideControl.Name = "_FrmAnaPartiAutoHideControl"
        Me._FrmAnaPartiAutoHideControl.Owner = Me.UltraDockAnaParti
        Me._FrmAnaPartiAutoHideControl.Size = New System.Drawing.Size(0, 0)
        Me._FrmAnaPartiAutoHideControl.TabIndex = 4
        '
        'WindowDockingArea1
        '
        Me.WindowDockingArea1.Controls.Add(Me.DockableWindow1)
        Me.WindowDockingArea1.Dock = System.Windows.Forms.DockStyle.Top
        Me.WindowDockingArea1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea1.Location = New System.Drawing.Point(0, 0)
        Me.WindowDockingArea1.Name = "WindowDockingArea1"
        Me.WindowDockingArea1.Owner = Me.UltraDockAnaParti
        Me.WindowDockingArea1.Size = New System.Drawing.Size(1762, 100)
        Me.WindowDockingArea1.TabIndex = 9
        '
        'DockableWindow1
        '
        Me.DockableWindow1.Controls.Add(Me.UltraPanelToolbar)
        Me.DockableWindow1.Location = New System.Drawing.Point(0, 0)
        Me.DockableWindow1.Name = "DockableWindow1"
        Me.DockableWindow1.Owner = Me.UltraDockAnaParti
        Me.DockableWindow1.Size = New System.Drawing.Size(1762, 95)
        Me.DockableWindow1.TabIndex = 14
        '
        'DockableWindow3
        '
        Me.DockableWindow3.Controls.Add(Me.UltraPanelFiltriRicerca)
        Me.DockableWindow3.Location = New System.Drawing.Point(0, 0)
        Me.DockableWindow3.Name = "DockableWindow3"
        Me.DockableWindow3.Owner = Me.UltraDockAnaParti
        Me.DockableWindow3.Size = New System.Drawing.Size(488, 209)
        Me.DockableWindow3.TabIndex = 15
        '
        'DockableWindow2
        '
        Me.DockableWindow2.Controls.Add(Me.UltraPanelDatiGrglia)
        Me.DockableWindow2.Location = New System.Drawing.Point(0, 214)
        Me.DockableWindow2.Name = "DockableWindow2"
        Me.DockableWindow2.Owner = Me.UltraDockAnaParti
        Me.DockableWindow2.Size = New System.Drawing.Size(488, 365)
        Me.DockableWindow2.TabIndex = 16
        '
        'DockableWindow4
        '
        Me.DockableWindow4.Controls.Add(Me.UltraPanelDatiDett)
        Me.DockableWindow4.Location = New System.Drawing.Point(0, 0)
        Me.DockableWindow4.Name = "DockableWindow4"
        Me.DockableWindow4.Owner = Me.UltraDockAnaParti
        Me.DockableWindow4.Size = New System.Drawing.Size(1269, 574)
        Me.DockableWindow4.TabIndex = 17
        '
        'WindowDockingArea2
        '
        Me.WindowDockingArea2.Controls.Add(Me.DockableWindow2)
        Me.WindowDockingArea2.Controls.Add(Me.DockableWindow3)
        Me.WindowDockingArea2.Dock = System.Windows.Forms.DockStyle.Left
        Me.WindowDockingArea2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea2.Location = New System.Drawing.Point(0, 100)
        Me.WindowDockingArea2.Name = "WindowDockingArea2"
        Me.WindowDockingArea2.Owner = Me.UltraDockAnaParti
        Me.WindowDockingArea2.Size = New System.Drawing.Size(493, 579)
        Me.WindowDockingArea2.TabIndex = 10
        '
        'WindowDockingArea3
        '
        Me.WindowDockingArea3.Controls.Add(Me.DockableWindow4)
        Me.WindowDockingArea3.Dock = System.Windows.Forms.DockStyle.Top
        Me.WindowDockingArea3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea3.Location = New System.Drawing.Point(493, 100)
        Me.WindowDockingArea3.Name = "WindowDockingArea3"
        Me.WindowDockingArea3.Owner = Me.UltraDockAnaParti
        Me.WindowDockingArea3.Size = New System.Drawing.Size(1269, 579)
        Me.WindowDockingArea3.TabIndex = 13
        '
        'ImageListAnaParti
        '
        Me.ImageListAnaParti.ImageStream = CType(resources.GetObject("ImageListAnaParti.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListAnaParti.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListAnaParti.Images.SetKeyName(0, "Chiudi-Finestra-68x75.png")
        Me.ImageListAnaParti.Images.SetKeyName(1, "Chiudi-Finestra-highlight-68x75.png")
        Me.ImageListAnaParti.Images.SetKeyName(2, "Salva Dati-68x75.png")
        Me.ImageListAnaParti.Images.SetKeyName(3, "Salva Dati-highlight-68x75.png")
        Me.ImageListAnaParti.Images.SetKeyName(4, "Elimina-Riga-68x75.png")
        Me.ImageListAnaParti.Images.SetKeyName(5, "Elimina-Riga-highlight-68x75.png")
        Me.ImageListAnaParti.Images.SetKeyName(6, "Inserisci-Riga-68x75.png")
        Me.ImageListAnaParti.Images.SetKeyName(7, "Inserisci-Riga-highlight-68x75.png")
        Me.ImageListAnaParti.Images.SetKeyName(8, "Ricerca-Dati-68x75.png")
        Me.ImageListAnaParti.Images.SetKeyName(9, "Ricerca-Dati-highlight-68x75.png")
        '
        'LSUTxtCFRicerca
        '
        Me.LSUTxtCFRicerca.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtCFRicerca.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtCFRicerca.LarghezzaCasellaTesto = 204
        Me.LSUTxtCFRicerca.LarghezzaEtichetta = 209
        Me.LSUTxtCFRicerca.Location = New System.Drawing.Point(7, 80)
        Me.LSUTxtCFRicerca.Name = "LSUTxtCFRicerca"
        Me.LSUTxtCFRicerca.Obbligatorio = False
        Me.LSUTxtCFRicerca.Size = New System.Drawing.Size(474, 30)
        Me.LSUTxtCFRicerca.TabIndex = 4
        Me.LSUTxtCFRicerca.TestoEtichetta = "Codice Fiscale (compreso)"
        Me.LSUTxtCFRicerca.ValoreCasellaTesto = ""
        '
        'FrmAnaParti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1762, 679)
        Me.Controls.Add(Me._FrmAnaPartiAutoHideControl)
        Me.Controls.Add(Me.WindowDockingArea3)
        Me.Controls.Add(Me.WindowDockingArea2)
        Me.Controls.Add(Me.WindowDockingArea1)
        Me.Controls.Add(Me._FrmAnaPartiUnpinnedTabAreaBottom)
        Me.Controls.Add(Me._FrmAnaPartiUnpinnedTabAreaTop)
        Me.Controls.Add(Me._FrmAnaPartiUnpinnedTabAreaRight)
        Me.Controls.Add(Me._FrmAnaPartiUnpinnedTabAreaLeft)
        Me.Name = "FrmAnaParti"
        Me.Text = "Anagrafiche Parti"
        Me.UltraPanelToolbar.ClientArea.ResumeLayout(False)
        Me.UltraPanelToolbar.ResumeLayout(False)
        CType(Me.UltraGroupBoxtoolbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBoxtoolbar.ResumeLayout(False)
        Me.UltraPanelFiltriRicerca.ClientArea.ResumeLayout(False)
        Me.UltraPanelFiltriRicerca.ResumeLayout(False)
        CType(Me.UltraGroupBoxFiltriRicerca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBoxFiltriRicerca.ResumeLayout(False)
        Me.UltraPanelDatiGrglia.ClientArea.ResumeLayout(False)
        Me.UltraPanelDatiGrglia.ResumeLayout(False)
        CType(Me.UltraGroupBoxDatiGriglia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBoxDatiGriglia.ResumeLayout(False)
        CType(Me.UGrdAnaParti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanelDatiDett.ClientArea.ResumeLayout(False)
        Me.UltraPanelDatiDett.ResumeLayout(False)
        CType(Me.UltraGroupBoxdatiDett, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBoxdatiDett.ResumeLayout(False)
        CType(Me.UltraDockAnaParti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WindowDockingArea1.ResumeLayout(False)
        Me.DockableWindow1.ResumeLayout(False)
        Me.DockableWindow3.ResumeLayout(False)
        Me.DockableWindow2.ResumeLayout(False)
        Me.DockableWindow4.ResumeLayout(False)
        Me.WindowDockingArea2.ResumeLayout(False)
        Me.WindowDockingArea3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UltraDockAnaParti As Infragistics.Win.UltraWinDock.UltraDockManager
    Friend WithEvents _FrmAnaPartiAutoHideControl As Infragistics.Win.UltraWinDock.AutoHideControl
    Friend WithEvents _FrmAnaPartiUnpinnedTabAreaBottom As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _FrmAnaPartiUnpinnedTabAreaTop As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _FrmAnaPartiUnpinnedTabAreaRight As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _FrmAnaPartiUnpinnedTabAreaLeft As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents UltraPanelToolbar As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraPanelFiltriRicerca As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraPanelDatiGrglia As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraPanelDatiDett As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents WindowDockingArea3 As Infragistics.Win.UltraWinDock.WindowDockingArea
    Friend WithEvents DockableWindow4 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents WindowDockingArea2 As Infragistics.Win.UltraWinDock.WindowDockingArea
    Friend WithEvents DockableWindow2 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents DockableWindow3 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents WindowDockingArea1 As Infragistics.Win.UltraWinDock.WindowDockingArea
    Friend WithEvents DockableWindow1 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents UltraGroupBoxtoolbar As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UPicBoxChiudiFinestra As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents UlblTitoloAnaParti As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UlblRigaTitolo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBoxFiltriRicerca As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBoxDatiGriglia As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBoxdatiDett As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ImageListAnaParti As ImageList
    Friend WithEvents UGrdAnaParti As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UlblRigaDatiTett As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UPicBoxSalvaDati As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents UPicBoxRicercaDati As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents UPicBoxInserisciRiga As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents UPicBoxEliminaRiga As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents LSUCboEditTipoPersona As LSUltraMenuTendina.LSMenuTendina
    Friend WithEvents LSUCboEditSesso As LSUltraMenuTendina.LSMenuTendina
    Friend WithEvents LSUCboEditStatoNascita As LSUltraMenuTendina.LSMenuTendina
    Friend WithEvents LSUCboEditProvResidenza As LSUltraMenuTendina.LSMenuTendina
    Friend WithEvents LSUCboEditLuogoResidenza As LSUltraMenuTendina.LSMenuTendina
    Friend WithEvents LSUCboEditProvNascita As LSUltraMenuTendina.LSMenuTendina
    Friend WithEvents LSUCboEditLuogoNascita As LSUltraMenuTendina.LSMenuTendina
    Friend WithEvents LSUCboEditStatoResidenza As LSUltraMenuTendina.LSMenuTendina
    Friend WithEvents LSUDataNascita As LSUltraDataOraSel.LSUltraDataOraSel
    Friend WithEvents LSUTxtNomeCompleto As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtCodiceFiscale As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtPartitaIVA As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtInidirizzoResidenza As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtNazionalita As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtEmail As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtEmailPEC As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtNominativoRicerca As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtIndirizzoSedeOperativa As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtIndirizzoSedeLegale As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtNomeLegaleRappr As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents UPicBoxCaricaLegaleRappr As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents UBtnConfermaControparteTrovata As Infragistics.Win.Misc.UltraButton
    Friend WithEvents LSUTxtCFRicerca As LSUltraCasellaTesto.LSUltraCasellaTesto
End Class
