<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsrCtrlAnaBase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsrCtrlAnaBase))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Me.UPanelFiltriRicerca = New Infragistics.Win.Misc.UltraPanel()
        Me.UGrpBoxFiltrirRicerca = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UPanelDatiGriglia = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UGrpBoxTitoloDatiGriglia = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UDockManAnaAvv = New Infragistics.Win.UltraWinDock.UltraDockManager(Me.components)
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
        Me.UPanelFiltriRicerca.ClientArea.SuspendLayout()
        Me.UPanelFiltriRicerca.SuspendLayout()
        CType(Me.UGrpBoxFiltrirRicerca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UPanelDatiGriglia.ClientArea.SuspendLayout()
        Me.UPanelDatiGriglia.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UGrpBoxTitoloDatiGriglia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UGrpBoxTitoloDatiGriglia.SuspendLayout()
        CType(Me.UDockManAnaAvv, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.UPanelToolbar.Size = New System.Drawing.Size(1431, 90)
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
        Me.UGrpBoxToolbar.Size = New System.Drawing.Size(1431, 90)
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
        Me.UlblTitoloAnaBase.Text = "Anagrafica Base"
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
        Me.PicBoxRicercaDati.Location = New System.Drawing.Point(1061, 0)
        Me.PicBoxRicercaDati.Name = "PicBoxRicercaDati"
        Me.PicBoxRicercaDati.Size = New System.Drawing.Size(68, 75)
        Me.PicBoxRicercaDati.TabIndex = 5
        Me.PicBoxRicercaDati.TabStop = False
        '
        'PicBoxInserisciRiga
        '
        Me.PicBoxInserisciRiga.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PicBoxInserisciRiga.Image = CType(resources.GetObject("PicBoxInserisciRiga.Image"), System.Drawing.Image)
        Me.PicBoxInserisciRiga.Location = New System.Drawing.Point(1135, 0)
        Me.PicBoxInserisciRiga.Name = "PicBoxInserisciRiga"
        Me.PicBoxInserisciRiga.Size = New System.Drawing.Size(68, 75)
        Me.PicBoxInserisciRiga.TabIndex = 4
        Me.PicBoxInserisciRiga.TabStop = False
        '
        'PicBoxEliminaRiga
        '
        Me.PicBoxEliminaRiga.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PicBoxEliminaRiga.Image = CType(resources.GetObject("PicBoxEliminaRiga.Image"), System.Drawing.Image)
        Me.PicBoxEliminaRiga.Location = New System.Drawing.Point(1209, 0)
        Me.PicBoxEliminaRiga.Name = "PicBoxEliminaRiga"
        Me.PicBoxEliminaRiga.Size = New System.Drawing.Size(68, 75)
        Me.PicBoxEliminaRiga.TabIndex = 3
        Me.PicBoxEliminaRiga.TabStop = False
        '
        'PicBoxSalvaDati
        '
        Me.PicBoxSalvaDati.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PicBoxSalvaDati.Image = CType(resources.GetObject("PicBoxSalvaDati.Image"), System.Drawing.Image)
        Me.PicBoxSalvaDati.Location = New System.Drawing.Point(1283, 0)
        Me.PicBoxSalvaDati.Name = "PicBoxSalvaDati"
        Me.PicBoxSalvaDati.Size = New System.Drawing.Size(68, 75)
        Me.PicBoxSalvaDati.TabIndex = 2
        Me.PicBoxSalvaDati.TabStop = False
        '
        'PicBoxChiudiFinestra
        '
        Me.PicBoxChiudiFinestra.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PicBoxChiudiFinestra.Image = CType(resources.GetObject("PicBoxChiudiFinestra.Image"), System.Drawing.Image)
        Me.PicBoxChiudiFinestra.Location = New System.Drawing.Point(1357, 0)
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
        Me.UPanelDatiDett.Size = New System.Drawing.Size(756, 577)
        Me.UPanelDatiDett.TabIndex = 1
        '
        'UGrpBoxDatiDett
        '
        Me.UGrpBoxDatiDett.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UGrpBoxDatiDett.Location = New System.Drawing.Point(0, 0)
        Me.UGrpBoxDatiDett.Name = "UGrpBoxDatiDett"
        Me.UGrpBoxDatiDett.Size = New System.Drawing.Size(756, 577)
        Me.UGrpBoxDatiDett.TabIndex = 2
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
        Me.UPanelFiltriRicerca.Size = New System.Drawing.Size(670, 195)
        Me.UPanelFiltriRicerca.TabIndex = 2
        '
        'UGrpBoxFiltrirRicerca
        '
        Me.UGrpBoxFiltrirRicerca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UGrpBoxFiltrirRicerca.Location = New System.Drawing.Point(0, 0)
        Me.UGrpBoxFiltrirRicerca.Name = "UGrpBoxFiltrirRicerca"
        Me.UGrpBoxFiltrirRicerca.Size = New System.Drawing.Size(670, 195)
        Me.UGrpBoxFiltrirRicerca.TabIndex = 1
        '
        'UPanelDatiGriglia
        '
        '
        'UPanelDatiGriglia.ClientArea
        '
        Me.UPanelDatiGriglia.ClientArea.Controls.Add(Me.UltraGrid1)
        Me.UPanelDatiGriglia.ClientArea.Controls.Add(Me.UGrpBoxTitoloDatiGriglia)
        Me.UPanelDatiGriglia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UPanelDatiGriglia.Location = New System.Drawing.Point(0, 324)
        Me.UPanelDatiGriglia.Name = "UPanelDatiGriglia"
        Me.UPanelDatiGriglia.Size = New System.Drawing.Size(670, 377)
        Me.UPanelDatiGriglia.TabIndex = 4
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 23)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(670, 354)
        Me.UltraGrid1.TabIndex = 2
        Me.UltraGrid1.Text = "Griglia Anagrafica Base"
        '
        'UGrpBoxTitoloDatiGriglia
        '
        Appearance3.BorderAlpha = Infragistics.Win.Alpha.Transparent
        Appearance3.ImageBackground = CType(resources.GetObject("Appearance3.ImageBackground"), System.Drawing.Image)
        Me.UGrpBoxTitoloDatiGriglia.Appearance = Appearance3
        Me.UGrpBoxTitoloDatiGriglia.Controls.Add(Me.UltraLabel1)
        Me.UGrpBoxTitoloDatiGriglia.Dock = System.Windows.Forms.DockStyle.Top
        Me.UGrpBoxTitoloDatiGriglia.Location = New System.Drawing.Point(0, 0)
        Me.UGrpBoxTitoloDatiGriglia.Name = "UGrpBoxTitoloDatiGriglia"
        Me.UGrpBoxTitoloDatiGriglia.Size = New System.Drawing.Size(670, 23)
        Me.UGrpBoxTitoloDatiGriglia.TabIndex = 0
        '
        'UltraLabel1
        '
        Appearance4.BackColorAlpha = Infragistics.Win.Alpha.Transparent
        Me.UltraLabel1.Appearance = Appearance4
        Me.UltraLabel1.Font = New System.Drawing.Font("Linux Libertine Display G", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(6, 3)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(100, 19)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "Dati Griglia"
        '
        'UDockManAnaAvv
        '
        Me.UDockManAnaAvv.CompressUnpinnedTabs = False
        DockAreaPane1.DockedBefore = New System.Guid("7fb753d1-3ccd-4e71-872d-71ed3ee9ea2b")
        DockAreaPane1.MaximumSize = New System.Drawing.Size(2300, 100)
        DockAreaPane1.MinimumSize = New System.Drawing.Size(1300, 100)
        DockableControlPane1.Control = Me.UPanelToolbar
        DockableControlPane1.OriginalControlBounds = New System.Drawing.Rectangle(0, 0, 1300, 100)
        DockableControlPane1.Size = New System.Drawing.Size(100, 100)
        DockAreaPane1.Panes.AddRange(New Infragistics.Win.UltraWinDock.DockablePaneBase() {DockableControlPane1})
        DockAreaPane1.Size = New System.Drawing.Size(1431, 100)
        DockAreaPane2.DockedBefore = New System.Guid("a5f09bbf-1865-4b5a-88ab-07dd37ad60eb")
        DockableControlPane2.Control = Me.UPanelDatiDett
        DockableControlPane2.OriginalControlBounds = New System.Drawing.Rectangle(587, 129, 713, 572)
        DockableControlPane2.Size = New System.Drawing.Size(100, 100)
        DockableControlPane2.Text = "Dati di Dettaglio"
        DockAreaPane2.Panes.AddRange(New Infragistics.Win.UltraWinDock.DockablePaneBase() {DockableControlPane2})
        DockAreaPane2.Size = New System.Drawing.Size(756, 596)
        DockableControlPane3.Control = Me.UPanelFiltriRicerca
        DockableControlPane3.OriginalControlBounds = New System.Drawing.Rectangle(0, 119, 539, 180)
        DockableControlPane3.Size = New System.Drawing.Size(100, 100)
        DockableControlPane3.Text = "Filtri di Ricerca"
        DockAreaPane3.Panes.AddRange(New Infragistics.Win.UltraWinDock.DockablePaneBase() {DockableControlPane3})
        DockAreaPane3.Size = New System.Drawing.Size(670, 214)
        Me.UDockManAnaAvv.DockAreas.AddRange(New Infragistics.Win.UltraWinDock.DockAreaPane() {DockAreaPane1, DockAreaPane2, DockAreaPane3})
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
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.Size = New System.Drawing.Size(0, 701)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.TabIndex = 5
        '
        '_UsrCtrlAnaAvvUnpinnedTabAreaRight
        '
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Dock = System.Windows.Forms.DockStyle.Right
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Location = New System.Drawing.Point(1431, 0)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Name = "_UsrCtrlAnaAvvUnpinnedTabAreaRight"
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Owner = Me.UDockManAnaAvv
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
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.Size = New System.Drawing.Size(1431, 0)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.TabIndex = 7
        '
        '_UsrCtrlAnaAvvUnpinnedTabAreaBottom
        '
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Location = New System.Drawing.Point(0, 701)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Name = "_UsrCtrlAnaAvvUnpinnedTabAreaBottom"
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Owner = Me.UDockManAnaAvv
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Size = New System.Drawing.Size(1431, 0)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.TabIndex = 8
        '
        '_UsrCtrlAnaAvvAutoHideControl
        '
        Me._UsrCtrlAnaAvvAutoHideControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._UsrCtrlAnaAvvAutoHideControl.Location = New System.Drawing.Point(0, 0)
        Me._UsrCtrlAnaAvvAutoHideControl.Name = "_UsrCtrlAnaAvvAutoHideControl"
        Me._UsrCtrlAnaAvvAutoHideControl.Owner = Me.UDockManAnaAvv
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
        Me.WindowDockingArea1.Owner = Me.UDockManAnaAvv
        Me.WindowDockingArea1.Size = New System.Drawing.Size(1431, 105)
        Me.WindowDockingArea1.TabIndex = 14
        '
        'DockableWindow1
        '
        Me.DockableWindow1.Controls.Add(Me.UPanelToolbar)
        Me.DockableWindow1.Location = New System.Drawing.Point(0, 0)
        Me.DockableWindow1.Name = "DockableWindow1"
        Me.DockableWindow1.Owner = Me.UDockManAnaAvv
        Me.DockableWindow1.Size = New System.Drawing.Size(1431, 100)
        Me.DockableWindow1.TabIndex = 17
        '
        'WindowDockingArea3
        '
        Me.WindowDockingArea3.Controls.Add(Me.DockableWindow2)
        Me.WindowDockingArea3.Dock = System.Windows.Forms.DockStyle.Right
        Me.WindowDockingArea3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea3.Location = New System.Drawing.Point(670, 105)
        Me.WindowDockingArea3.Name = "WindowDockingArea3"
        Me.WindowDockingArea3.Owner = Me.UDockManAnaAvv
        Me.WindowDockingArea3.Size = New System.Drawing.Size(761, 596)
        Me.WindowDockingArea3.TabIndex = 15
        '
        'DockableWindow2
        '
        Me.DockableWindow2.Controls.Add(Me.UPanelDatiDett)
        Me.DockableWindow2.Location = New System.Drawing.Point(5, 0)
        Me.DockableWindow2.Name = "DockableWindow2"
        Me.DockableWindow2.Owner = Me.UDockManAnaAvv
        Me.DockableWindow2.Size = New System.Drawing.Size(756, 596)
        Me.DockableWindow2.TabIndex = 18
        '
        'WindowDockingArea2
        '
        Me.WindowDockingArea2.Controls.Add(Me.DockableWindow3)
        Me.WindowDockingArea2.Dock = System.Windows.Forms.DockStyle.Top
        Me.WindowDockingArea2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea2.Location = New System.Drawing.Point(0, 105)
        Me.WindowDockingArea2.Name = "WindowDockingArea2"
        Me.WindowDockingArea2.Owner = Me.UDockManAnaAvv
        Me.WindowDockingArea2.Size = New System.Drawing.Size(670, 219)
        Me.WindowDockingArea2.TabIndex = 16
        '
        'DockableWindow3
        '
        Me.DockableWindow3.Controls.Add(Me.UPanelFiltriRicerca)
        Me.DockableWindow3.Location = New System.Drawing.Point(0, 0)
        Me.DockableWindow3.Name = "DockableWindow3"
        Me.DockableWindow3.Owner = Me.UDockManAnaAvv
        Me.DockableWindow3.Size = New System.Drawing.Size(670, 214)
        Me.DockableWindow3.TabIndex = 19
        '
        'UsrCtrlAnaBase
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
        Me.Name = "UsrCtrlAnaBase"
        Me.Size = New System.Drawing.Size(1431, 701)
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
        Me.UPanelFiltriRicerca.ClientArea.ResumeLayout(False)
        Me.UPanelFiltriRicerca.ResumeLayout(False)
        CType(Me.UGrpBoxFiltrirRicerca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UPanelDatiGriglia.ClientArea.ResumeLayout(False)
        Me.UPanelDatiGriglia.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UGrpBoxTitoloDatiGriglia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UGrpBoxTitoloDatiGriglia.ResumeLayout(False)
        CType(Me.UDockManAnaAvv, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents UDockManAnaAvv As Infragistics.Win.UltraWinDock.UltraDockManager
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
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
End Class
