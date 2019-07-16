<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsrCtrlAnaUtenti
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsrCtrlAnaUtenti))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim DockAreaPane1 As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedTop, New System.Guid("97c2ed93-f1ba-4bc5-b8a8-dcd491601297"))
        Dim DockableControlPane1 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("862ae136-1f90-4c2f-a51c-cc9389153556"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("97c2ed93-f1ba-4bc5-b8a8-dcd491601297"), 0)
        Dim DockAreaPane2 As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedRight, New System.Guid("7fb753d1-3ccd-4e71-872d-71ed3ee9ea2b"))
        Dim DockableControlPane2 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("48440a24-6df5-4980-9b59-b3fd66c17942"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("7fb753d1-3ccd-4e71-872d-71ed3ee9ea2b"), 0)
        Dim DockAreaPane3 As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedTop, New System.Guid("a5f09bbf-1865-4b5a-88ab-07dd37ad60eb"))
        Dim DockableControlPane3 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("df31f873-6e13-4ca3-9eff-879232ee0e68"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("a5f09bbf-1865-4b5a-88ab-07dd37ad60eb"), -1)
        Me.UPanelToolbar = New Infragistics.Win.Misc.UltraPanel()
        Me.UGrpBoxToolbar = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UlblTitoloAnaBase = New Infragistics.Win.Misc.UltraLabel()
        Me.UlblRigaTitolo = New Infragistics.Win.Misc.UltraLabel()
        Me.PicBoxRicercaDati = New System.Windows.Forms.PictureBox()
        Me.PicBoxInserisciRiga = New System.Windows.Forms.PictureBox()
        Me.PicBoxEliminaRiga = New System.Windows.Forms.PictureBox()
        Me.PicBoxSalvaDati = New System.Windows.Forms.PictureBox()
        Me.PicBoxChiudiFinestra = New System.Windows.Forms.PictureBox()
        Me.UPanelDatiDett = New Infragistics.Win.Misc.UltraPanel()
        Me.UGrpBoxDatiDett = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UChkEditPermessoUtility = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UChckEditPermessoAgenda = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UChckEditAppEsterne = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UChkEditPermessoGenAtti = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UChkEditPermessoFatt = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UChkEditPermessoGestioneUtenti = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UChkEditPermessoAnagrafiche = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.LSUPasswordDecriptata = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUTxtNomeUtente = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.UlblRigaDatiTett = New Infragistics.Win.Misc.UltraLabel()
        Me.UPanelFiltriRicerca = New Infragistics.Win.Misc.UltraPanel()
        Me.UGrpBoxFiltrirRicerca = New Infragistics.Win.Misc.UltraGroupBox()
        Me.LSUTxtPasswordRicerca = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUTxtNomeUtenteRicerca = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.UPanelDatiGriglia = New Infragistics.Win.Misc.UltraPanel()
        Me.UGrdAnaUtenti = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UGrpBoxTitoloDatiGriglia = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraDockAnaUtenti = New Infragistics.Win.UltraWinDock.UltraDockManager(Me.components)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._UsrCtrlAnaAvvAutoHideControl = New Infragistics.Win.UltraWinDock.AutoHideControl()
        Me.WindowDockingArea1 = New Infragistics.Win.UltraWinDock.WindowDockingArea()
        Me.DockableWindow1 = New Infragistics.Win.UltraWinDock.DockableWindow()
        Me.WindowDockingArea3 = New Infragistics.Win.UltraWinDock.WindowDockingArea()
        Me.DockableWindow2 = New Infragistics.Win.UltraWinDock.DockableWindow()
        Me.WindowDockingArea2 = New Infragistics.Win.UltraWinDock.WindowDockingArea()
        Me.DockableWindow3 = New Infragistics.Win.UltraWinDock.DockableWindow()
        Me.ImageListAnaUtenti = New System.Windows.Forms.ImageList(Me.components)
        Me.UPanelToolbar.ClientArea.SuspendLayout()
        Me.UPanelToolbar.SuspendLayout()
        CType(Me.UGrpBoxToolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UGrpBoxToolbar.SuspendLayout()
        CType(Me.PicBoxRicercaDati, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxInserisciRiga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxEliminaRiga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxSalvaDati, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxChiudiFinestra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UPanelDatiDett.ClientArea.SuspendLayout()
        Me.UPanelDatiDett.SuspendLayout()
        CType(Me.UGrpBoxDatiDett, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UGrpBoxDatiDett.SuspendLayout()
        CType(Me.UChkEditPermessoUtility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UChckEditPermessoAgenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UChckEditAppEsterne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UChkEditPermessoGenAtti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UChkEditPermessoFatt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UChkEditPermessoGestioneUtenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UChkEditPermessoAnagrafiche, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UPanelFiltriRicerca.ClientArea.SuspendLayout()
        Me.UPanelFiltriRicerca.SuspendLayout()
        CType(Me.UGrpBoxFiltrirRicerca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UGrpBoxFiltrirRicerca.SuspendLayout()
        Me.UPanelDatiGriglia.ClientArea.SuspendLayout()
        Me.UPanelDatiGriglia.SuspendLayout()
        CType(Me.UGrdAnaUtenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UGrpBoxTitoloDatiGriglia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UGrpBoxTitoloDatiGriglia.SuspendLayout()
        CType(Me.UltraDockAnaUtenti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WindowDockingArea1.SuspendLayout()
        Me.DockableWindow1.SuspendLayout()
        Me.WindowDockingArea3.SuspendLayout()
        Me.DockableWindow2.SuspendLayout()
        Me.WindowDockingArea2.SuspendLayout()
        Me.DockableWindow3.SuspendLayout()
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
        Me.UPanelToolbar.Size = New System.Drawing.Size(1802, 90)
        Me.UPanelToolbar.TabIndex = 0
        '
        'UGrpBoxToolbar
        '
        Appearance1.ImageBackground = CType(resources.GetObject("Appearance1.ImageBackground"), System.Drawing.Image)
        Me.UGrpBoxToolbar.Appearance = Appearance1
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
        Me.UGrpBoxToolbar.Size = New System.Drawing.Size(1802, 90)
        Me.UGrpBoxToolbar.TabIndex = 1
        '
        'UlblTitoloAnaBase
        '
        Appearance2.BackColorAlpha = Infragistics.Win.Alpha.Transparent
        Me.UlblTitoloAnaBase.Appearance = Appearance2
        Me.UlblTitoloAnaBase.Font = New System.Drawing.Font("Linux Libertine Display G", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UlblTitoloAnaBase.Location = New System.Drawing.Point(19, 12)
        Me.UlblTitoloAnaBase.Name = "UlblTitoloAnaBase"
        Me.UlblTitoloAnaBase.Size = New System.Drawing.Size(372, 40)
        Me.UlblTitoloAnaBase.TabIndex = 10
        Me.UlblTitoloAnaBase.Text = "Anagrafica Utenti"
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
        Me.PicBoxRicercaDati.Location = New System.Drawing.Point(1432, 0)
        Me.PicBoxRicercaDati.Name = "PicBoxRicercaDati"
        Me.PicBoxRicercaDati.Size = New System.Drawing.Size(68, 75)
        Me.PicBoxRicercaDati.TabIndex = 5
        Me.PicBoxRicercaDati.TabStop = False
        '
        'PicBoxInserisciRiga
        '
        Me.PicBoxInserisciRiga.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PicBoxInserisciRiga.Image = CType(resources.GetObject("PicBoxInserisciRiga.Image"), System.Drawing.Image)
        Me.PicBoxInserisciRiga.Location = New System.Drawing.Point(1506, 0)
        Me.PicBoxInserisciRiga.Name = "PicBoxInserisciRiga"
        Me.PicBoxInserisciRiga.Size = New System.Drawing.Size(68, 75)
        Me.PicBoxInserisciRiga.TabIndex = 4
        Me.PicBoxInserisciRiga.TabStop = False
        '
        'PicBoxEliminaRiga
        '
        Me.PicBoxEliminaRiga.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PicBoxEliminaRiga.Image = CType(resources.GetObject("PicBoxEliminaRiga.Image"), System.Drawing.Image)
        Me.PicBoxEliminaRiga.Location = New System.Drawing.Point(1580, 0)
        Me.PicBoxEliminaRiga.Name = "PicBoxEliminaRiga"
        Me.PicBoxEliminaRiga.Size = New System.Drawing.Size(68, 75)
        Me.PicBoxEliminaRiga.TabIndex = 3
        Me.PicBoxEliminaRiga.TabStop = False
        '
        'PicBoxSalvaDati
        '
        Me.PicBoxSalvaDati.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PicBoxSalvaDati.Image = CType(resources.GetObject("PicBoxSalvaDati.Image"), System.Drawing.Image)
        Me.PicBoxSalvaDati.Location = New System.Drawing.Point(1654, 0)
        Me.PicBoxSalvaDati.Name = "PicBoxSalvaDati"
        Me.PicBoxSalvaDati.Size = New System.Drawing.Size(68, 75)
        Me.PicBoxSalvaDati.TabIndex = 2
        Me.PicBoxSalvaDati.TabStop = False
        '
        'PicBoxChiudiFinestra
        '
        Me.PicBoxChiudiFinestra.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PicBoxChiudiFinestra.Image = CType(resources.GetObject("PicBoxChiudiFinestra.Image"), System.Drawing.Image)
        Me.PicBoxChiudiFinestra.Location = New System.Drawing.Point(1728, 0)
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
        Me.UGrpBoxDatiDett.Controls.Add(Me.UChkEditPermessoUtility)
        Me.UGrpBoxDatiDett.Controls.Add(Me.UChckEditPermessoAgenda)
        Me.UGrpBoxDatiDett.Controls.Add(Me.UChckEditAppEsterne)
        Me.UGrpBoxDatiDett.Controls.Add(Me.UChkEditPermessoGenAtti)
        Me.UGrpBoxDatiDett.Controls.Add(Me.UChkEditPermessoFatt)
        Me.UGrpBoxDatiDett.Controls.Add(Me.UChkEditPermessoGestioneUtenti)
        Me.UGrpBoxDatiDett.Controls.Add(Me.UChkEditPermessoAnagrafiche)
        Me.UGrpBoxDatiDett.Controls.Add(Me.LSUPasswordDecriptata)
        Me.UGrpBoxDatiDett.Controls.Add(Me.LSUTxtNomeUtente)
        Me.UGrpBoxDatiDett.Controls.Add(Me.UlblRigaDatiTett)
        Me.UGrpBoxDatiDett.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UGrpBoxDatiDett.Location = New System.Drawing.Point(0, 0)
        Me.UGrpBoxDatiDett.Name = "UGrpBoxDatiDett"
        Me.UGrpBoxDatiDett.Size = New System.Drawing.Size(1286, 577)
        Me.UGrpBoxDatiDett.TabIndex = 2
        '
        'UChkEditPermessoUtility
        '
        Appearance3.FontData.Name = "Linux Libertine Display G"
        Appearance3.FontData.SizeInPoints = 11.0!
        Me.UChkEditPermessoUtility.Appearance = Appearance3
        Me.UChkEditPermessoUtility.Location = New System.Drawing.Point(75, 295)
        Me.UChkEditPermessoUtility.Name = "UChkEditPermessoUtility"
        Me.UChkEditPermessoUtility.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UChkEditPermessoUtility.Size = New System.Drawing.Size(237, 23)
        Me.UChkEditPermessoUtility.TabIndex = 61
        Me.UChkEditPermessoUtility.Text = "         :Permesso Utility"
        '
        'UChckEditPermessoAgenda
        '
        Appearance4.FontData.Name = "Linux Libertine Display G"
        Appearance4.FontData.SizeInPoints = 11.0!
        Me.UChckEditPermessoAgenda.Appearance = Appearance4
        Me.UChckEditPermessoAgenda.Location = New System.Drawing.Point(572, 256)
        Me.UChckEditPermessoAgenda.Name = "UChckEditPermessoAgenda"
        Me.UChckEditPermessoAgenda.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UChckEditPermessoAgenda.Size = New System.Drawing.Size(364, 25)
        Me.UChckEditPermessoAgenda.TabIndex = 60
        Me.UChckEditPermessoAgenda.Text = "               :Permesso Agenda"
        '
        'UChckEditAppEsterne
        '
        Appearance5.FontData.Name = "Linux Libertine Display G"
        Appearance5.FontData.SizeInPoints = 11.0!
        Me.UChckEditAppEsterne.Appearance = Appearance5
        Me.UChckEditAppEsterne.Location = New System.Drawing.Point(78, 256)
        Me.UChckEditAppEsterne.Name = "UChckEditAppEsterne"
        Me.UChckEditAppEsterne.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UChckEditAppEsterne.Size = New System.Drawing.Size(234, 20)
        Me.UChckEditAppEsterne.TabIndex = 59
        Me.UChckEditAppEsterne.Text = ":Permesso App Esterne"
        '
        'UChkEditPermessoGenAtti
        '
        Appearance6.FontData.Name = "Linux Libertine Display G"
        Appearance6.FontData.SizeInPoints = 11.0!
        Me.UChkEditPermessoGenAtti.Appearance = Appearance6
        Me.UChkEditPermessoGenAtti.Location = New System.Drawing.Point(592, 216)
        Me.UChkEditPermessoGenAtti.Name = "UChkEditPermessoGenAtti"
        Me.UChkEditPermessoGenAtti.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UChkEditPermessoGenAtti.Size = New System.Drawing.Size(344, 20)
        Me.UChkEditPermessoGenAtti.TabIndex = 58
        Me.UChkEditPermessoGenAtti.Text = " :Permesso Generazione Atti"
        '
        'UChkEditPermessoFatt
        '
        Appearance7.FontData.Name = "Linux Libertine Display G"
        Appearance7.FontData.SizeInPoints = 11.0!
        Me.UChkEditPermessoFatt.Appearance = Appearance7
        Me.UChkEditPermessoFatt.Location = New System.Drawing.Point(78, 216)
        Me.UChkEditPermessoFatt.Name = "UChkEditPermessoFatt"
        Me.UChkEditPermessoFatt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UChkEditPermessoFatt.Size = New System.Drawing.Size(234, 20)
        Me.UChkEditPermessoFatt.TabIndex = 57
        Me.UChkEditPermessoFatt.Text = ":Permesso Fatturazione"
        '
        'UChkEditPermessoGestioneUtenti
        '
        Appearance8.FontData.Name = "Linux Libertine Display G"
        Appearance8.FontData.SizeInPoints = 11.0!
        Me.UChkEditPermessoGestioneUtenti.Appearance = Appearance8
        Me.UChkEditPermessoGestioneUtenti.Location = New System.Drawing.Point(581, 175)
        Me.UChkEditPermessoGestioneUtenti.Name = "UChkEditPermessoGestioneUtenti"
        Me.UChkEditPermessoGestioneUtenti.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UChkEditPermessoGestioneUtenti.Size = New System.Drawing.Size(355, 20)
        Me.UChkEditPermessoGestioneUtenti.TabIndex = 56
        Me.UChkEditPermessoGestioneUtenti.Text = "   :Permesso Gestione Utenti"
        '
        'UChkEditPermessoAnagrafiche
        '
        Appearance9.FontData.Name = "Linux Libertine Display G"
        Appearance9.FontData.SizeInPoints = 11.0!
        Me.UChkEditPermessoAnagrafiche.Appearance = Appearance9
        Me.UChkEditPermessoAnagrafiche.Location = New System.Drawing.Point(80, 175)
        Me.UChkEditPermessoAnagrafiche.Name = "UChkEditPermessoAnagrafiche"
        Me.UChkEditPermessoAnagrafiche.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UChkEditPermessoAnagrafiche.Size = New System.Drawing.Size(232, 20)
        Me.UChkEditPermessoAnagrafiche.TabIndex = 55
        Me.UChkEditPermessoAnagrafiche.Text = ":Permesso Anagrafiche"
        '
        'LSUPasswordDecriptata
        '
        Me.LSUPasswordDecriptata.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUPasswordDecriptata.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUPasswordDecriptata.LarghezzaCasellaTesto = 204
        Me.LSUPasswordDecriptata.LarghezzaEtichetta = 180
        Me.LSUPasswordDecriptata.Location = New System.Drawing.Point(668, 119)
        Me.LSUPasswordDecriptata.Name = "LSUPasswordDecriptata"
        Me.LSUPasswordDecriptata.Obbligatorio = True
        Me.LSUPasswordDecriptata.Size = New System.Drawing.Size(616, 30)
        Me.LSUPasswordDecriptata.TabIndex = 54
        Me.LSUPasswordDecriptata.TestoEtichetta = "Password Decriptata:"
        Me.LSUPasswordDecriptata.ValoreCasellaTesto = ""
        '
        'LSUTxtNomeUtente
        '
        Me.LSUTxtNomeUtente.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtNomeUtente.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtNomeUtente.LarghezzaCasellaTesto = 204
        Me.LSUTxtNomeUtente.LarghezzaEtichetta = 140
        Me.LSUTxtNomeUtente.Location = New System.Drawing.Point(93, 119)
        Me.LSUTxtNomeUtente.Name = "LSUTxtNomeUtente"
        Me.LSUTxtNomeUtente.Obbligatorio = True
        Me.LSUTxtNomeUtente.Size = New System.Drawing.Size(575, 30)
        Me.LSUTxtNomeUtente.TabIndex = 53
        Me.LSUTxtNomeUtente.TestoEtichetta = "Nome Utente:"
        Me.LSUTxtNomeUtente.ValoreCasellaTesto = ""
        '
        'UlblRigaDatiTett
        '
        Me.UlblRigaDatiTett.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UlblRigaDatiTett.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UlblRigaDatiTett.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UlblRigaDatiTett.Location = New System.Drawing.Point(17, 81)
        Me.UlblRigaDatiTett.Name = "UlblRigaDatiTett"
        Me.UlblRigaDatiTett.Size = New System.Drawing.Size(1250, 3)
        Me.UlblRigaDatiTett.TabIndex = 52
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
        Me.UPanelFiltriRicerca.Size = New System.Drawing.Size(511, 195)
        Me.UPanelFiltriRicerca.TabIndex = 2
        '
        'UGrpBoxFiltrirRicerca
        '
        Me.UGrpBoxFiltrirRicerca.Controls.Add(Me.LSUTxtPasswordRicerca)
        Me.UGrpBoxFiltrirRicerca.Controls.Add(Me.LSUTxtNomeUtenteRicerca)
        Me.UGrpBoxFiltrirRicerca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UGrpBoxFiltrirRicerca.Location = New System.Drawing.Point(0, 0)
        Me.UGrpBoxFiltrirRicerca.Name = "UGrpBoxFiltrirRicerca"
        Me.UGrpBoxFiltrirRicerca.Size = New System.Drawing.Size(511, 195)
        Me.UGrpBoxFiltrirRicerca.TabIndex = 1
        '
        'LSUTxtPasswordRicerca
        '
        Me.LSUTxtPasswordRicerca.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtPasswordRicerca.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtPasswordRicerca.LarghezzaCasellaTesto = 204
        Me.LSUTxtPasswordRicerca.LarghezzaEtichetta = 225
        Me.LSUTxtPasswordRicerca.Location = New System.Drawing.Point(6, 110)
        Me.LSUTxtPasswordRicerca.Name = "LSUTxtPasswordRicerca"
        Me.LSUTxtPasswordRicerca.Obbligatorio = False
        Me.LSUTxtPasswordRicerca.Size = New System.Drawing.Size(479, 39)
        Me.LSUTxtPasswordRicerca.TabIndex = 3
        Me.LSUTxtPasswordRicerca.TestoEtichetta = "Password Decriptata (Esatta):"
        Me.LSUTxtPasswordRicerca.ValoreCasellaTesto = ""
        '
        'LSUTxtNomeUtenteRicerca
        '
        Me.LSUTxtNomeUtenteRicerca.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtNomeUtenteRicerca.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtNomeUtenteRicerca.LarghezzaCasellaTesto = 204
        Me.LSUTxtNomeUtenteRicerca.LarghezzaEtichetta = 225
        Me.LSUTxtNomeUtenteRicerca.Location = New System.Drawing.Point(6, 45)
        Me.LSUTxtNomeUtenteRicerca.Name = "LSUTxtNomeUtenteRicerca"
        Me.LSUTxtNomeUtenteRicerca.Obbligatorio = False
        Me.LSUTxtNomeUtenteRicerca.Size = New System.Drawing.Size(485, 39)
        Me.LSUTxtNomeUtenteRicerca.TabIndex = 2
        Me.LSUTxtNomeUtenteRicerca.TestoEtichetta = "Nome Utente (Contenuto):"
        Me.LSUTxtNomeUtenteRicerca.ValoreCasellaTesto = ""
        '
        'UPanelDatiGriglia
        '
        '
        'UPanelDatiGriglia.ClientArea
        '
        Me.UPanelDatiGriglia.ClientArea.Controls.Add(Me.UGrdAnaUtenti)
        Me.UPanelDatiGriglia.ClientArea.Controls.Add(Me.UGrpBoxTitoloDatiGriglia)
        Me.UPanelDatiGriglia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UPanelDatiGriglia.Location = New System.Drawing.Point(0, 324)
        Me.UPanelDatiGriglia.Name = "UPanelDatiGriglia"
        Me.UPanelDatiGriglia.Size = New System.Drawing.Size(511, 377)
        Me.UPanelDatiGriglia.TabIndex = 4
        '
        'UGrdAnaUtenti
        '
        Me.UGrdAnaUtenti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UGrdAnaUtenti.Location = New System.Drawing.Point(0, 23)
        Me.UGrdAnaUtenti.Name = "UGrdAnaUtenti"
        Me.UGrdAnaUtenti.Size = New System.Drawing.Size(511, 354)
        Me.UGrdAnaUtenti.TabIndex = 2
        Me.UGrdAnaUtenti.Text = "Griglia Anagrafica Utenti"
        '
        'UGrpBoxTitoloDatiGriglia
        '
        Appearance10.BorderAlpha = Infragistics.Win.Alpha.Transparent
        Appearance10.ImageBackground = CType(resources.GetObject("Appearance10.ImageBackground"), System.Drawing.Image)
        Me.UGrpBoxTitoloDatiGriglia.Appearance = Appearance10
        Me.UGrpBoxTitoloDatiGriglia.Controls.Add(Me.UltraLabel1)
        Me.UGrpBoxTitoloDatiGriglia.Dock = System.Windows.Forms.DockStyle.Top
        Me.UGrpBoxTitoloDatiGriglia.Location = New System.Drawing.Point(0, 0)
        Me.UGrpBoxTitoloDatiGriglia.Name = "UGrpBoxTitoloDatiGriglia"
        Me.UGrpBoxTitoloDatiGriglia.Size = New System.Drawing.Size(511, 23)
        Me.UGrpBoxTitoloDatiGriglia.TabIndex = 0
        '
        'UltraLabel1
        '
        Appearance11.BackColorAlpha = Infragistics.Win.Alpha.Transparent
        Me.UltraLabel1.Appearance = Appearance11
        Me.UltraLabel1.Font = New System.Drawing.Font("Linux Libertine Display G", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(6, 3)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(100, 19)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "Dati Griglia"
        '
        'UltraDockAnaUtenti
        '
        Me.UltraDockAnaUtenti.CompressUnpinnedTabs = False
        DockAreaPane1.DockedBefore = New System.Guid("7fb753d1-3ccd-4e71-872d-71ed3ee9ea2b")
        DockAreaPane1.MaximumSize = New System.Drawing.Size(2300, 100)
        DockAreaPane1.MinimumSize = New System.Drawing.Size(1300, 100)
        DockableControlPane1.Control = Me.UPanelToolbar
        DockableControlPane1.OriginalControlBounds = New System.Drawing.Rectangle(0, 0, 1300, 100)
        DockableControlPane1.Size = New System.Drawing.Size(100, 100)
        DockAreaPane1.Panes.AddRange(New Infragistics.Win.UltraWinDock.DockablePaneBase() {DockableControlPane1})
        DockAreaPane1.Size = New System.Drawing.Size(1802, 100)
        DockAreaPane2.DockedBefore = New System.Guid("a5f09bbf-1865-4b5a-88ab-07dd37ad60eb")
        DockableControlPane2.Control = Me.UPanelDatiDett
        DockableControlPane2.OriginalControlBounds = New System.Drawing.Rectangle(587, 129, 713, 572)
        DockableControlPane2.Size = New System.Drawing.Size(100, 100)
        DockableControlPane2.Text = "Dati di Dettaglio"
        DockAreaPane2.Panes.AddRange(New Infragistics.Win.UltraWinDock.DockablePaneBase() {DockableControlPane2})
        DockAreaPane2.Size = New System.Drawing.Size(1286, 596)
        DockableControlPane3.Control = Me.UPanelFiltriRicerca
        DockableControlPane3.OriginalControlBounds = New System.Drawing.Rectangle(0, 119, 539, 180)
        DockableControlPane3.Size = New System.Drawing.Size(100, 100)
        DockableControlPane3.Text = "Filtri di Ricerca"
        DockAreaPane3.Panes.AddRange(New Infragistics.Win.UltraWinDock.DockablePaneBase() {DockableControlPane3})
        DockAreaPane3.Size = New System.Drawing.Size(511, 214)
        Me.UltraDockAnaUtenti.DockAreas.AddRange(New Infragistics.Win.UltraWinDock.DockAreaPane() {DockAreaPane1, DockAreaPane2, DockAreaPane3})
        Me.UltraDockAnaUtenti.HostControl = Me
        Me.UltraDockAnaUtenti.ShowCloseButton = False
        Me.UltraDockAnaUtenti.ShowPinButton = False
        '
        '_UsrCtrlAnaAvvUnpinnedTabAreaLeft
        '
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.Location = New System.Drawing.Point(0, 0)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.Name = "_UsrCtrlAnaAvvUnpinnedTabAreaLeft"
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.Owner = Me.UltraDockAnaUtenti
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.Size = New System.Drawing.Size(0, 701)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.TabIndex = 5
        '
        '_UsrCtrlAnaAvvUnpinnedTabAreaRight
        '
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Dock = System.Windows.Forms.DockStyle.Right
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Location = New System.Drawing.Point(1802, 0)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Name = "_UsrCtrlAnaAvvUnpinnedTabAreaRight"
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Owner = Me.UltraDockAnaUtenti
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Size = New System.Drawing.Size(0, 701)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.TabIndex = 6
        '
        '_UsrCtrlAnaAvvUnpinnedTabAreaTop
        '
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.Dock = System.Windows.Forms.DockStyle.Top
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.Location = New System.Drawing.Point(0, 0)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.Name = "_UsrCtrlAnaAvvUnpinnedTabAreaTop"
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.Owner = Me.UltraDockAnaUtenti
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.Size = New System.Drawing.Size(1802, 0)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.TabIndex = 7
        '
        '_UsrCtrlAnaAvvUnpinnedTabAreaBottom
        '
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Location = New System.Drawing.Point(0, 701)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Name = "_UsrCtrlAnaAvvUnpinnedTabAreaBottom"
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Owner = Me.UltraDockAnaUtenti
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Size = New System.Drawing.Size(1802, 0)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.TabIndex = 8
        '
        '_UsrCtrlAnaAvvAutoHideControl
        '
        Me._UsrCtrlAnaAvvAutoHideControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._UsrCtrlAnaAvvAutoHideControl.Location = New System.Drawing.Point(0, 0)
        Me._UsrCtrlAnaAvvAutoHideControl.Name = "_UsrCtrlAnaAvvAutoHideControl"
        Me._UsrCtrlAnaAvvAutoHideControl.Owner = Me.UltraDockAnaUtenti
        Me._UsrCtrlAnaAvvAutoHideControl.Size = New System.Drawing.Size(0, 701)
        Me._UsrCtrlAnaAvvAutoHideControl.TabIndex = 9
        '
        'WindowDockingArea1
        '
        Me.WindowDockingArea1.Controls.Add(Me.DockableWindow1)
        Me.WindowDockingArea1.Dock = System.Windows.Forms.DockStyle.Top
        Me.WindowDockingArea1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea1.Location = New System.Drawing.Point(0, 0)
        Me.WindowDockingArea1.Name = "WindowDockingArea1"
        Me.WindowDockingArea1.Owner = Me.UltraDockAnaUtenti
        Me.WindowDockingArea1.Size = New System.Drawing.Size(1802, 105)
        Me.WindowDockingArea1.TabIndex = 14
        '
        'DockableWindow1
        '
        Me.DockableWindow1.Controls.Add(Me.UPanelToolbar)
        Me.DockableWindow1.Location = New System.Drawing.Point(0, 0)
        Me.DockableWindow1.Name = "DockableWindow1"
        Me.DockableWindow1.Owner = Me.UltraDockAnaUtenti
        Me.DockableWindow1.Size = New System.Drawing.Size(1802, 100)
        Me.DockableWindow1.TabIndex = 17
        '
        'WindowDockingArea3
        '
        Me.WindowDockingArea3.Controls.Add(Me.DockableWindow2)
        Me.WindowDockingArea3.Dock = System.Windows.Forms.DockStyle.Right
        Me.WindowDockingArea3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea3.Location = New System.Drawing.Point(511, 105)
        Me.WindowDockingArea3.Name = "WindowDockingArea3"
        Me.WindowDockingArea3.Owner = Me.UltraDockAnaUtenti
        Me.WindowDockingArea3.Size = New System.Drawing.Size(1291, 596)
        Me.WindowDockingArea3.TabIndex = 15
        '
        'DockableWindow2
        '
        Me.DockableWindow2.Controls.Add(Me.UPanelDatiDett)
        Me.DockableWindow2.Location = New System.Drawing.Point(5, 0)
        Me.DockableWindow2.Name = "DockableWindow2"
        Me.DockableWindow2.Owner = Me.UltraDockAnaUtenti
        Me.DockableWindow2.Size = New System.Drawing.Size(1286, 596)
        Me.DockableWindow2.TabIndex = 18
        '
        'WindowDockingArea2
        '
        Me.WindowDockingArea2.Controls.Add(Me.DockableWindow3)
        Me.WindowDockingArea2.Dock = System.Windows.Forms.DockStyle.Top
        Me.WindowDockingArea2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea2.Location = New System.Drawing.Point(0, 105)
        Me.WindowDockingArea2.Name = "WindowDockingArea2"
        Me.WindowDockingArea2.Owner = Me.UltraDockAnaUtenti
        Me.WindowDockingArea2.Size = New System.Drawing.Size(511, 219)
        Me.WindowDockingArea2.TabIndex = 16
        '
        'DockableWindow3
        '
        Me.DockableWindow3.Controls.Add(Me.UPanelFiltriRicerca)
        Me.DockableWindow3.Location = New System.Drawing.Point(0, 0)
        Me.DockableWindow3.Name = "DockableWindow3"
        Me.DockableWindow3.Owner = Me.UltraDockAnaUtenti
        Me.DockableWindow3.Size = New System.Drawing.Size(511, 214)
        Me.DockableWindow3.TabIndex = 19
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
        'UsrCtrlAnaUtenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._UsrCtrlAnaAvvAutoHideControl)
        Me.Controls.Add(Me.UPanelDatiGriglia)
        Me.Controls.Add(Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft)
        Me.Controls.Add(Me._UsrCtrlAnaAvvUnpinnedTabAreaTop)
        Me.Controls.Add(Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom)
        Me.Controls.Add(Me._UsrCtrlAnaAvvUnpinnedTabAreaRight)
        Me.Controls.Add(Me.WindowDockingArea2)
        Me.Controls.Add(Me.WindowDockingArea3)
        Me.Controls.Add(Me.WindowDockingArea1)
        Me.Name = "UsrCtrlAnaUtenti"
        Me.Size = New System.Drawing.Size(1802, 701)
        Me.UPanelToolbar.ClientArea.ResumeLayout(False)
        Me.UPanelToolbar.ResumeLayout(False)
        CType(Me.UGrpBoxToolbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UGrpBoxToolbar.ResumeLayout(False)
        CType(Me.PicBoxRicercaDati, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxInserisciRiga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxEliminaRiga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxSalvaDati, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxChiudiFinestra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UPanelDatiDett.ClientArea.ResumeLayout(False)
        Me.UPanelDatiDett.ResumeLayout(False)
        CType(Me.UGrpBoxDatiDett, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UGrpBoxDatiDett.ResumeLayout(False)
        CType(Me.UChkEditPermessoUtility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UChckEditPermessoAgenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UChckEditAppEsterne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UChkEditPermessoGenAtti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UChkEditPermessoFatt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UChkEditPermessoGestioneUtenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UChkEditPermessoAnagrafiche, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UPanelFiltriRicerca.ClientArea.ResumeLayout(False)
        Me.UPanelFiltriRicerca.ResumeLayout(False)
        CType(Me.UGrpBoxFiltrirRicerca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UGrpBoxFiltrirRicerca.ResumeLayout(False)
        Me.UPanelDatiGriglia.ClientArea.ResumeLayout(False)
        Me.UPanelDatiGriglia.ResumeLayout(False)
        CType(Me.UGrdAnaUtenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UGrpBoxTitoloDatiGriglia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UGrpBoxTitoloDatiGriglia.ResumeLayout(False)
        CType(Me.UltraDockAnaUtenti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WindowDockingArea1.ResumeLayout(False)
        Me.DockableWindow1.ResumeLayout(False)
        Me.WindowDockingArea3.ResumeLayout(False)
        Me.DockableWindow2.ResumeLayout(False)
        Me.WindowDockingArea2.ResumeLayout(False)
        Me.DockableWindow3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UPanelToolbar As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UGrpBoxToolbar As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UPanelDatiDett As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UPanelFiltriRicerca As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UPanelDatiGriglia As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraDockAnaUtenti As Infragistics.Win.UltraWinDock.UltraDockManager
    Friend WithEvents _UsrCtrlAnaAvvAutoHideControl As Infragistics.Win.UltraWinDock.AutoHideControl
    Friend WithEvents WindowDockingArea2 As Infragistics.Win.UltraWinDock.WindowDockingArea
    Friend WithEvents DockableWindow3 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents WindowDockingArea3 As Infragistics.Win.UltraWinDock.WindowDockingArea
    Friend WithEvents DockableWindow2 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents WindowDockingArea1 As Infragistics.Win.UltraWinDock.WindowDockingArea
    Friend WithEvents DockableWindow1 As Infragistics.Win.UltraWinDock.DockableWindow
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
    Friend WithEvents UGrdAnaUtenti As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents LSUTxtPasswordRicerca As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtNomeUtenteRicerca As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents UChkEditPermessoUtility As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UChckEditPermessoAgenda As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UChckEditAppEsterne As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UChkEditPermessoGenAtti As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UChkEditPermessoFatt As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UChkEditPermessoGestioneUtenti As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UChkEditPermessoAnagrafiche As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents LSUPasswordDecriptata As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtNomeUtente As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents UlblRigaDatiTett As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ImageListAnaUtenti As ImageList
End Class
