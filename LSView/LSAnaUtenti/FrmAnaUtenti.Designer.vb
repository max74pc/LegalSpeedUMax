<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAnaUtenti
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAnaUtenti))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim DockAreaPane1 As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedTop, New System.Guid("d9501c4d-5458-4a0f-b82b-4f4a16acfbaa"))
        Dim DockableControlPane1 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("7283cb70-7756-4407-a457-1d02c1436f2a"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("d9501c4d-5458-4a0f-b82b-4f4a16acfbaa"), -1)
        Dim DockAreaPane2 As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedLeft, New System.Guid("db9e0f80-60a3-406f-abdc-c9fc787c6999"))
        Dim DockableControlPane2 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("62a51697-5f31-45b7-9b25-80dac0f03867"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("db9e0f80-60a3-406f-abdc-c9fc787c6999"), -1)
        Dim DockableControlPane3 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("6029bd90-90fd-4439-8379-062051332a5b"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("db9e0f80-60a3-406f-abdc-c9fc787c6999"), -1)
        Dim DockAreaPane3 As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedTop, New System.Guid("d5029311-2436-4210-a52c-8b45b6c51370"))
        Dim DockableControlPane4 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("1c0f9105-e6ba-45e1-9ec0-9d46526b79c3"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("d5029311-2436-4210-a52c-8b45b6c51370"), 0)
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Me.LSUTxtPasswordRicerca = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUTxtNomeUtenteRicerca = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.UltraPanelDatiGrglia = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraGroupBoxDatiGriglia = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UGrdAnaParti = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraPanelDatiDett = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraGroupBoxdatiDett = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UChckEditPermessoAgenda = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UChckEditAppEsterne = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UChkEditPermessoGenAtti = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UChkEditPermessoFatt = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UChkEditPermessoGestioneUtenti = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UChkEditPermessoAnagrafiche = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.LSUPasswordDecriptata = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUTxtNomeUtente = New LSUltraCasellaTesto.LSUltraCasellaTesto()
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
        Me.ImageListAnaUtenti = New System.Windows.Forms.ImageList(Me.components)
        Me.UChkEditPermessoUtility = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
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
        CType(Me.UChckEditPermessoAgenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UChckEditAppEsterne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UChkEditPermessoGenAtti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UChkEditPermessoFatt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UChkEditPermessoGestioneUtenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UChkEditPermessoAnagrafiche, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDockAnaParti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WindowDockingArea1.SuspendLayout()
        Me.DockableWindow1.SuspendLayout()
        Me.DockableWindow3.SuspendLayout()
        Me.DockableWindow2.SuspendLayout()
        Me.DockableWindow4.SuspendLayout()
        Me.WindowDockingArea2.SuspendLayout()
        Me.WindowDockingArea3.SuspendLayout()
        CType(Me.UChkEditPermessoUtility, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.UlblTitoloAnaParti.Text = "Anagrafica Utenti"
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
        Me.UltraGroupBoxFiltriRicerca.Controls.Add(Me.LSUTxtPasswordRicerca)
        Me.UltraGroupBoxFiltriRicerca.Controls.Add(Me.LSUTxtNomeUtenteRicerca)
        Me.UltraGroupBoxFiltriRicerca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBoxFiltriRicerca.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBoxFiltriRicerca.Name = "UltraGroupBoxFiltriRicerca"
        Me.UltraGroupBoxFiltriRicerca.Size = New System.Drawing.Size(488, 190)
        Me.UltraGroupBoxFiltriRicerca.TabIndex = 1
        '
        'LSUTxtPasswordRicerca
        '
        Me.LSUTxtPasswordRicerca.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtPasswordRicerca.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtPasswordRicerca.LarghezzaCasellaTesto = 204
        Me.LSUTxtPasswordRicerca.LarghezzaEtichetta = 209
        Me.LSUTxtPasswordRicerca.Location = New System.Drawing.Point(8, 105)
        Me.LSUTxtPasswordRicerca.Name = "LSUTxtPasswordRicerca"
        Me.LSUTxtPasswordRicerca.Obbligatorio = False
        Me.LSUTxtPasswordRicerca.Size = New System.Drawing.Size(474, 30)
        Me.LSUTxtPasswordRicerca.TabIndex = 1
        Me.LSUTxtPasswordRicerca.TestoEtichetta = "Password:"
        Me.LSUTxtPasswordRicerca.ValoreCasellaTesto = ""
        '
        'LSUTxtNomeUtenteRicerca
        '
        Me.LSUTxtNomeUtenteRicerca.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtNomeUtenteRicerca.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtNomeUtenteRicerca.LarghezzaCasellaTesto = 204
        Me.LSUTxtNomeUtenteRicerca.LarghezzaEtichetta = 209
        Me.LSUTxtNomeUtenteRicerca.Location = New System.Drawing.Point(13, 39)
        Me.LSUTxtNomeUtenteRicerca.Name = "LSUTxtNomeUtenteRicerca"
        Me.LSUTxtNomeUtenteRicerca.Obbligatorio = False
        Me.LSUTxtNomeUtenteRicerca.Size = New System.Drawing.Size(474, 30)
        Me.LSUTxtNomeUtenteRicerca.TabIndex = 0
        Me.LSUTxtNomeUtenteRicerca.TestoEtichetta = "Nome Utente:"
        Me.LSUTxtNomeUtenteRicerca.ValoreCasellaTesto = ""
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
        Me.UGrdAnaParti.Text = "Griglia Anagrafica Utenti"
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
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.UChkEditPermessoUtility)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.UChckEditPermessoAgenda)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.UChckEditAppEsterne)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.UChkEditPermessoGenAtti)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.UChkEditPermessoFatt)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.UChkEditPermessoGestioneUtenti)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.UChkEditPermessoAnagrafiche)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.LSUPasswordDecriptata)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.LSUTxtNomeUtente)
        Me.UltraGroupBoxdatiDett.Controls.Add(Me.UlblRigaDatiTett)
        Me.UltraGroupBoxdatiDett.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBoxdatiDett.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBoxdatiDett.Name = "UltraGroupBoxdatiDett"
        Me.UltraGroupBoxdatiDett.Size = New System.Drawing.Size(1269, 555)
        Me.UltraGroupBoxdatiDett.TabIndex = 1
        '
        'UChckEditPermessoAgenda
        '
        Appearance4.FontData.Name = "Linux Libertine Display G"
        Appearance4.FontData.SizeInPoints = 11.0!
        Me.UChckEditPermessoAgenda.Appearance = Appearance4
        Me.UChckEditPermessoAgenda.Location = New System.Drawing.Point(522, 251)
        Me.UChckEditPermessoAgenda.Name = "UChckEditPermessoAgenda"
        Me.UChckEditPermessoAgenda.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UChckEditPermessoAgenda.Size = New System.Drawing.Size(179, 20)
        Me.UChckEditPermessoAgenda.TabIndex = 50
        Me.UChckEditPermessoAgenda.Text = ":Permesso Agenda"
        '
        'UChckEditAppEsterne
        '
        Appearance5.FontData.Name = "Linux Libertine Display G"
        Appearance5.FontData.SizeInPoints = 11.0!
        Me.UChckEditAppEsterne.Appearance = Appearance5
        Me.UChckEditAppEsterne.Location = New System.Drawing.Point(19, 251)
        Me.UChckEditAppEsterne.Name = "UChckEditAppEsterne"
        Me.UChckEditAppEsterne.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UChckEditAppEsterne.Size = New System.Drawing.Size(216, 20)
        Me.UChckEditAppEsterne.TabIndex = 49
        Me.UChckEditAppEsterne.Text = ":Permesso App Esterne"
        '
        'UChkEditPermessoGenAtti
        '
        Appearance6.FontData.Name = "Linux Libertine Display G"
        Appearance6.FontData.SizeInPoints = 11.0!
        Me.UChkEditPermessoGenAtti.Appearance = Appearance6
        Me.UChkEditPermessoGenAtti.Location = New System.Drawing.Point(496, 211)
        Me.UChkEditPermessoGenAtti.Name = "UChkEditPermessoGenAtti"
        Me.UChkEditPermessoGenAtti.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UChkEditPermessoGenAtti.Size = New System.Drawing.Size(260, 20)
        Me.UChkEditPermessoGenAtti.TabIndex = 48
        Me.UChkEditPermessoGenAtti.Text = ":Permesso Generazione Atti"
        '
        'UChkEditPermessoFatt
        '
        Appearance7.FontData.Name = "Linux Libertine Display G"
        Appearance7.FontData.SizeInPoints = 11.0!
        Me.UChkEditPermessoFatt.Appearance = Appearance7
        Me.UChkEditPermessoFatt.Location = New System.Drawing.Point(19, 211)
        Me.UChkEditPermessoFatt.Name = "UChkEditPermessoFatt"
        Me.UChkEditPermessoFatt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UChkEditPermessoFatt.Size = New System.Drawing.Size(216, 20)
        Me.UChkEditPermessoFatt.TabIndex = 47
        Me.UChkEditPermessoFatt.Text = ":Permesso Fatturazione"
        '
        'UChkEditPermessoGestioneUtenti
        '
        Appearance8.FontData.Name = "Linux Libertine Display G"
        Appearance8.FontData.SizeInPoints = 11.0!
        Me.UChkEditPermessoGestioneUtenti.Appearance = Appearance8
        Me.UChkEditPermessoGestioneUtenti.Location = New System.Drawing.Point(509, 170)
        Me.UChkEditPermessoGestioneUtenti.Name = "UChkEditPermessoGestioneUtenti"
        Me.UChkEditPermessoGestioneUtenti.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UChkEditPermessoGestioneUtenti.Size = New System.Drawing.Size(247, 20)
        Me.UChkEditPermessoGestioneUtenti.TabIndex = 46
        Me.UChkEditPermessoGestioneUtenti.Text = ":Permesso Gestione Utenti"
        '
        'UChkEditPermessoAnagrafiche
        '
        Appearance9.FontData.Name = "Linux Libertine Display G"
        Appearance9.FontData.SizeInPoints = 11.0!
        Me.UChkEditPermessoAnagrafiche.Appearance = Appearance9
        Me.UChkEditPermessoAnagrafiche.Location = New System.Drawing.Point(19, 170)
        Me.UChkEditPermessoAnagrafiche.Name = "UChkEditPermessoAnagrafiche"
        Me.UChkEditPermessoAnagrafiche.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UChkEditPermessoAnagrafiche.Size = New System.Drawing.Size(216, 20)
        Me.UChkEditPermessoAnagrafiche.TabIndex = 45
        Me.UChkEditPermessoAnagrafiche.Text = ":Permesso Anagrafiche"
        '
        'LSUPasswordDecriptata
        '
        Me.LSUPasswordDecriptata.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUPasswordDecriptata.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUPasswordDecriptata.LarghezzaCasellaTesto = 204
        Me.LSUPasswordDecriptata.LarghezzaEtichetta = 209
        Me.LSUPasswordDecriptata.Location = New System.Drawing.Point(522, 114)
        Me.LSUPasswordDecriptata.Name = "LSUPasswordDecriptata"
        Me.LSUPasswordDecriptata.Obbligatorio = True
        Me.LSUPasswordDecriptata.Size = New System.Drawing.Size(460, 30)
        Me.LSUPasswordDecriptata.TabIndex = 44
        Me.LSUPasswordDecriptata.TestoEtichetta = "Password Decriptata:"
        Me.LSUPasswordDecriptata.ValoreCasellaTesto = ""
        '
        'LSUTxtNomeUtente
        '
        Me.LSUTxtNomeUtente.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtNomeUtente.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtNomeUtente.LarghezzaCasellaTesto = 204
        Me.LSUTxtNomeUtente.LarghezzaEtichetta = 180
        Me.LSUTxtNomeUtente.Location = New System.Drawing.Point(30, 114)
        Me.LSUTxtNomeUtente.Name = "LSUTxtNomeUtente"
        Me.LSUTxtNomeUtente.Obbligatorio = True
        Me.LSUTxtNomeUtente.Size = New System.Drawing.Size(440, 30)
        Me.LSUTxtNomeUtente.TabIndex = 43
        Me.LSUTxtNomeUtente.TestoEtichetta = "Nome Utente:"
        Me.LSUTxtNomeUtente.ValoreCasellaTesto = ""
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
        DockableControlPane1.Text = "UltraPanelToolbar"
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
        Appearance10.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.UltraDockAnaParti.SplitterBarAppearance = Appearance10
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
        'ImageListAnaUtenti
        '
        Me.ImageListAnaUtenti.ImageStream = CType(resources.GetObject("ImageListAnaUtenti.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListAnaUtenti.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListAnaUtenti.Images.SetKeyName(0, "Chiudi-Finestra-68x75.png")
        Me.ImageListAnaUtenti.Images.SetKeyName(1, "Chiudi-Finestra-highlight-68x75.png")
        Me.ImageListAnaUtenti.Images.SetKeyName(2, "Salva Dati-68x75.png")
        Me.ImageListAnaUtenti.Images.SetKeyName(3, "Salva Dati-highlight-68x75.png")
        Me.ImageListAnaUtenti.Images.SetKeyName(4, "Elimina-Riga-68x75.png")
        Me.ImageListAnaUtenti.Images.SetKeyName(5, "Elimina-Riga-highlight-68x75.png")
        Me.ImageListAnaUtenti.Images.SetKeyName(6, "Inserisci-Riga-68x75.png")
        Me.ImageListAnaUtenti.Images.SetKeyName(7, "Inserisci-Riga-highlight-68x75.png")
        Me.ImageListAnaUtenti.Images.SetKeyName(8, "Ricerca-Dati-68x75.png")
        Me.ImageListAnaUtenti.Images.SetKeyName(9, "Ricerca-Dati-highlight-68x75.png")
        '
        'UChkEditPermessoUtility
        '
        Appearance3.FontData.Name = "Linux Libertine Display G"
        Appearance3.FontData.SizeInPoints = 11.0!
        Me.UChkEditPermessoUtility.Appearance = Appearance3
        Me.UChkEditPermessoUtility.Location = New System.Drawing.Point(19, 297)
        Me.UChkEditPermessoUtility.Name = "UChkEditPermessoUtility"
        Me.UChkEditPermessoUtility.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UChkEditPermessoUtility.Size = New System.Drawing.Size(179, 20)
        Me.UChkEditPermessoUtility.TabIndex = 51
        Me.UChkEditPermessoUtility.Text = ":Permesso Utility"
        '
        'FrmAnaUtenti
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
        Me.Name = "FrmAnaUtenti"
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
        CType(Me.UChckEditPermessoAgenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UChckEditAppEsterne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UChkEditPermessoGenAtti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UChkEditPermessoFatt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UChkEditPermessoGestioneUtenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UChkEditPermessoAnagrafiche, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDockAnaParti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WindowDockingArea1.ResumeLayout(False)
        Me.DockableWindow1.ResumeLayout(False)
        Me.DockableWindow3.ResumeLayout(False)
        Me.DockableWindow2.ResumeLayout(False)
        Me.DockableWindow4.ResumeLayout(False)
        Me.WindowDockingArea2.ResumeLayout(False)
        Me.WindowDockingArea3.ResumeLayout(False)
        CType(Me.UChkEditPermessoUtility, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ImageListAnaUtenti As ImageList
    Friend WithEvents UGrdAnaParti As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UlblRigaDatiTett As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UPicBoxSalvaDati As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents UPicBoxRicercaDati As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents UPicBoxInserisciRiga As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents UPicBoxEliminaRiga As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents LSUTxtNomeUtenteRicerca As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtPasswordRicerca As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtNomeUtente As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents UChkEditPermessoGestioneUtenti As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UChkEditPermessoAnagrafiche As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents LSUPasswordDecriptata As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents UChkEditPermessoFatt As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UChkEditPermessoGenAtti As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UChckEditAppEsterne As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UChckEditPermessoAgenda As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UChkEditPermessoUtility As Infragistics.Win.UltraWinEditors.UltraCheckEditor
End Class
