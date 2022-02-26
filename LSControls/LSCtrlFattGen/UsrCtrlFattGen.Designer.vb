<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsrCtrlFattGen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsrCtrlFattGen))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim DockAreaPane1 As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedTop, New System.Guid("97c2ed93-f1ba-4bc5-b8a8-dcd491601297"))
        Dim DockableControlPane1 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("862ae136-1f90-4c2f-a51c-cc9389153556"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("97c2ed93-f1ba-4bc5-b8a8-dcd491601297"), 0)
        Dim DockAreaPane2 As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedRight, New System.Guid("7fb753d1-3ccd-4e71-872d-71ed3ee9ea2b"))
        Dim DockableControlPane2 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("df31f873-6e13-4ca3-9eff-879232ee0e68"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("7fb753d1-3ccd-4e71-872d-71ed3ee9ea2b"), -1)
        Dim DockableControlPane3 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("48440a24-6df5-4980-9b59-b3fd66c17942"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("7fb753d1-3ccd-4e71-872d-71ed3ee9ea2b"), 0)
        Me.UPanelToolbar = New Infragistics.Win.Misc.UltraPanel()
        Me.UGrpBoxToolbar = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UlblTitoloAnaBase = New Infragistics.Win.Misc.UltraLabel()
        Me.UlblRigaTitolo = New Infragistics.Win.Misc.UltraLabel()
        Me.PictBoxNuovaCat = New System.Windows.Forms.PictureBox()
        Me.PicBoxNuovoModello = New System.Windows.Forms.PictureBox()
        Me.PicBoxGenDoc = New System.Windows.Forms.PictureBox()
        Me.PicBoxChiudiFinestra = New System.Windows.Forms.PictureBox()
        Me.UPanelFiltriRicerca = New Infragistics.Win.Misc.UltraPanel()
        Me.UGrpBoxFiltrirRicerca = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UPanelAltriDati = New Infragistics.Win.Misc.UltraPanel()
        Me.UPanelDatiControparti = New Infragistics.Win.Misc.UltraPanel()
        Me.UPicBoxRicavaControparte = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.UPanelDatiParti = New Infragistics.Win.Misc.UltraPanel()
        Me.UPicBoxRicavaParte = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.UPaneDatiAvvocati = New Infragistics.Win.Misc.UltraPanel()
        Me.UPicBoxRicavaAvv = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.UPanelEnteGiuridico = New Infragistics.Win.Misc.UltraPanel()
        Me.UPanelEstremiAtto = New Infragistics.Win.Misc.UltraPanel()
        Me.UPanelDatiDett = New Infragistics.Win.Misc.UltraPanel()
        Me.UGrpBoxDatiDett = New Infragistics.Win.Misc.UltraGroupBox()
        Me.DocViewer1 = New Spire.DocViewer.Forms.DocViewer()
        Me.UPanelDatiGriglia = New Infragistics.Win.Misc.UltraPanel()
        Me.UGrpBoxTitoloDatiGriglia = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UlblTitoloModelliAtti = New Infragistics.Win.Misc.UltraLabel()
        Me.UDockManagerGenFatt = New Infragistics.Win.UltraWinDock.UltraDockManager(Me.components)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._UsrCtrlAnaAvvAutoHideControl = New Infragistics.Win.UltraWinDock.AutoHideControl()
        Me.ImageListGenFatt = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageListGenFatt2 = New System.Windows.Forms.ImageList(Me.components)
        Me.WindowDockingArea3 = New Infragistics.Win.UltraWinDock.WindowDockingArea()
        Me.DockableWindow1 = New Infragistics.Win.UltraWinDock.DockableWindow()
        Me.WindowDockingArea2 = New Infragistics.Win.UltraWinDock.WindowDockingArea()
        Me.DockableWindow2 = New Infragistics.Win.UltraWinDock.DockableWindow()
        Me.DockableWindow3 = New Infragistics.Win.UltraWinDock.DockableWindow()
        Me.UPanelToolbar.ClientArea.SuspendLayout()
        Me.UPanelToolbar.SuspendLayout()
        CType(Me.UGrpBoxToolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UGrpBoxToolbar.SuspendLayout()
        CType(Me.PictBoxNuovaCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxNuovoModello, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxGenDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxChiudiFinestra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UPanelFiltriRicerca.ClientArea.SuspendLayout()
        Me.UPanelFiltriRicerca.SuspendLayout()
        CType(Me.UGrpBoxFiltrirRicerca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UGrpBoxFiltrirRicerca.SuspendLayout()
        Me.UPanelAltriDati.SuspendLayout()
        Me.UPanelDatiControparti.ClientArea.SuspendLayout()
        Me.UPanelDatiControparti.SuspendLayout()
        Me.UPanelDatiParti.ClientArea.SuspendLayout()
        Me.UPanelDatiParti.SuspendLayout()
        Me.UPaneDatiAvvocati.ClientArea.SuspendLayout()
        Me.UPaneDatiAvvocati.SuspendLayout()
        Me.UPanelEnteGiuridico.SuspendLayout()
        Me.UPanelEstremiAtto.SuspendLayout()
        Me.UPanelDatiDett.ClientArea.SuspendLayout()
        Me.UPanelDatiDett.SuspendLayout()
        CType(Me.UGrpBoxDatiDett, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UGrpBoxDatiDett.SuspendLayout()
        Me.UPanelDatiGriglia.ClientArea.SuspendLayout()
        Me.UPanelDatiGriglia.SuspendLayout()
        CType(Me.UGrpBoxTitoloDatiGriglia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UGrpBoxTitoloDatiGriglia.SuspendLayout()
        CType(Me.UDockManagerGenFatt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WindowDockingArea3.SuspendLayout()
        Me.DockableWindow1.SuspendLayout()
        Me.WindowDockingArea2.SuspendLayout()
        Me.DockableWindow2.SuspendLayout()
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
        Me.UPanelToolbar.Size = New System.Drawing.Size(1696, 90)
        Me.UPanelToolbar.TabIndex = 0
        '
        'UGrpBoxToolbar
        '
        Appearance1.ImageBackground = CType(resources.GetObject("Appearance1.ImageBackground"), System.Drawing.Image)
        Me.UGrpBoxToolbar.Appearance = Appearance1
        Me.UGrpBoxToolbar.Controls.Add(Me.UlblTitoloAnaBase)
        Me.UGrpBoxToolbar.Controls.Add(Me.UlblRigaTitolo)
        Me.UGrpBoxToolbar.Controls.Add(Me.PictBoxNuovaCat)
        Me.UGrpBoxToolbar.Controls.Add(Me.PicBoxNuovoModello)
        Me.UGrpBoxToolbar.Controls.Add(Me.PicBoxGenDoc)
        Me.UGrpBoxToolbar.Controls.Add(Me.PicBoxChiudiFinestra)
        Me.UGrpBoxToolbar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UGrpBoxToolbar.Location = New System.Drawing.Point(0, 0)
        Me.UGrpBoxToolbar.Name = "UGrpBoxToolbar"
        Me.UGrpBoxToolbar.Size = New System.Drawing.Size(1696, 90)
        Me.UGrpBoxToolbar.TabIndex = 1
        '
        'UlblTitoloAnaBase
        '
        Appearance2.BackColorAlpha = Infragistics.Win.Alpha.Transparent
        Me.UlblTitoloAnaBase.Appearance = Appearance2
        Me.UlblTitoloAnaBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UlblTitoloAnaBase.Location = New System.Drawing.Point(19, 12)
        Me.UlblTitoloAnaBase.Name = "UlblTitoloAnaBase"
        Me.UlblTitoloAnaBase.Size = New System.Drawing.Size(372, 40)
        Me.UlblTitoloAnaBase.TabIndex = 10
        Me.UlblTitoloAnaBase.Text = "Generazione Fatture"
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
        'PictBoxNuovaCat
        '
        Me.PictBoxNuovaCat.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictBoxNuovaCat.Image = CType(resources.GetObject("PictBoxNuovaCat.Image"), System.Drawing.Image)
        Me.PictBoxNuovaCat.Location = New System.Drawing.Point(1400, 0)
        Me.PictBoxNuovaCat.Name = "PictBoxNuovaCat"
        Me.PictBoxNuovaCat.Size = New System.Drawing.Size(68, 75)
        Me.PictBoxNuovaCat.TabIndex = 4
        Me.PictBoxNuovaCat.TabStop = False
        '
        'PicBoxNuovoModello
        '
        Me.PicBoxNuovoModello.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PicBoxNuovoModello.Image = CType(resources.GetObject("PicBoxNuovoModello.Image"), System.Drawing.Image)
        Me.PicBoxNuovoModello.Location = New System.Drawing.Point(1474, 0)
        Me.PicBoxNuovoModello.Name = "PicBoxNuovoModello"
        Me.PicBoxNuovoModello.Size = New System.Drawing.Size(68, 75)
        Me.PicBoxNuovoModello.TabIndex = 3
        Me.PicBoxNuovoModello.TabStop = False
        '
        'PicBoxGenDoc
        '
        Me.PicBoxGenDoc.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PicBoxGenDoc.Image = CType(resources.GetObject("PicBoxGenDoc.Image"), System.Drawing.Image)
        Me.PicBoxGenDoc.Location = New System.Drawing.Point(1548, 0)
        Me.PicBoxGenDoc.Name = "PicBoxGenDoc"
        Me.PicBoxGenDoc.Size = New System.Drawing.Size(68, 75)
        Me.PicBoxGenDoc.TabIndex = 2
        Me.PicBoxGenDoc.TabStop = False
        '
        'PicBoxChiudiFinestra
        '
        Me.PicBoxChiudiFinestra.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PicBoxChiudiFinestra.Image = CType(resources.GetObject("PicBoxChiudiFinestra.Image"), System.Drawing.Image)
        Me.PicBoxChiudiFinestra.Location = New System.Drawing.Point(1622, 0)
        Me.PicBoxChiudiFinestra.Name = "PicBoxChiudiFinestra"
        Me.PicBoxChiudiFinestra.Size = New System.Drawing.Size(68, 75)
        Me.PicBoxChiudiFinestra.TabIndex = 1
        Me.PicBoxChiudiFinestra.TabStop = False
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
        Me.UPanelFiltriRicerca.Size = New System.Drawing.Size(1337, 182)
        Me.UPanelFiltriRicerca.TabIndex = 2
        '
        'UGrpBoxFiltrirRicerca
        '
        Me.UGrpBoxFiltrirRicerca.Controls.Add(Me.UPanelAltriDati)
        Me.UGrpBoxFiltrirRicerca.Controls.Add(Me.UPanelDatiControparti)
        Me.UGrpBoxFiltrirRicerca.Controls.Add(Me.UPanelDatiParti)
        Me.UGrpBoxFiltrirRicerca.Controls.Add(Me.UPaneDatiAvvocati)
        Me.UGrpBoxFiltrirRicerca.Controls.Add(Me.UPanelEnteGiuridico)
        Me.UGrpBoxFiltrirRicerca.Controls.Add(Me.UPanelEstremiAtto)
        Me.UGrpBoxFiltrirRicerca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UGrpBoxFiltrirRicerca.Location = New System.Drawing.Point(0, 0)
        Me.UGrpBoxFiltrirRicerca.Name = "UGrpBoxFiltrirRicerca"
        Me.UGrpBoxFiltrirRicerca.Size = New System.Drawing.Size(1337, 182)
        Me.UGrpBoxFiltrirRicerca.TabIndex = 1
        '
        'UPanelAltriDati
        '
        Me.UPanelAltriDati.Dock = System.Windows.Forms.DockStyle.Top
        Me.UPanelAltriDati.Location = New System.Drawing.Point(3, 157)
        Me.UPanelAltriDati.Name = "UPanelAltriDati"
        Me.UPanelAltriDati.Size = New System.Drawing.Size(1331, 30)
        Me.UPanelAltriDati.TabIndex = 11
        '
        'UPanelDatiControparti
        '
        '
        'UPanelDatiControparti.ClientArea
        '
        Me.UPanelDatiControparti.ClientArea.Controls.Add(Me.UPicBoxRicavaControparte)
        Me.UPanelDatiControparti.Dock = System.Windows.Forms.DockStyle.Top
        Me.UPanelDatiControparti.Location = New System.Drawing.Point(3, 122)
        Me.UPanelDatiControparti.Name = "UPanelDatiControparti"
        Me.UPanelDatiControparti.Size = New System.Drawing.Size(1331, 35)
        Me.UPanelDatiControparti.TabIndex = 10
        '
        'UPicBoxRicavaControparte
        '
        Me.UPicBoxRicavaControparte.BorderShadowColor = System.Drawing.Color.Empty
        Me.UPicBoxRicavaControparte.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UPicBoxRicavaControparte.Image = CType(resources.GetObject("UPicBoxRicavaControparte.Image"), Object)
        Me.UPicBoxRicavaControparte.Location = New System.Drawing.Point(993, 0)
        Me.UPicBoxRicavaControparte.Name = "UPicBoxRicavaControparte"
        Me.UPicBoxRicavaControparte.Size = New System.Drawing.Size(32, 32)
        Me.UPicBoxRicavaControparte.TabIndex = 49
        '
        'UPanelDatiParti
        '
        '
        'UPanelDatiParti.ClientArea
        '
        Me.UPanelDatiParti.ClientArea.Controls.Add(Me.UPicBoxRicavaParte)
        Me.UPanelDatiParti.Dock = System.Windows.Forms.DockStyle.Top
        Me.UPanelDatiParti.Location = New System.Drawing.Point(3, 92)
        Me.UPanelDatiParti.Name = "UPanelDatiParti"
        Me.UPanelDatiParti.Size = New System.Drawing.Size(1331, 30)
        Me.UPanelDatiParti.TabIndex = 9
        '
        'UPicBoxRicavaParte
        '
        Me.UPicBoxRicavaParte.BorderShadowColor = System.Drawing.Color.Empty
        Me.UPicBoxRicavaParte.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UPicBoxRicavaParte.Image = CType(resources.GetObject("UPicBoxRicavaParte.Image"), Object)
        Me.UPicBoxRicavaParte.Location = New System.Drawing.Point(993, 0)
        Me.UPicBoxRicavaParte.Name = "UPicBoxRicavaParte"
        Me.UPicBoxRicavaParte.Size = New System.Drawing.Size(32, 32)
        Me.UPicBoxRicavaParte.TabIndex = 48
        '
        'UPaneDatiAvvocati
        '
        '
        'UPaneDatiAvvocati.ClientArea
        '
        Me.UPaneDatiAvvocati.ClientArea.Controls.Add(Me.UPicBoxRicavaAvv)
        Me.UPaneDatiAvvocati.Dock = System.Windows.Forms.DockStyle.Top
        Me.UPaneDatiAvvocati.Location = New System.Drawing.Point(3, 62)
        Me.UPaneDatiAvvocati.Name = "UPaneDatiAvvocati"
        Me.UPaneDatiAvvocati.Size = New System.Drawing.Size(1331, 30)
        Me.UPaneDatiAvvocati.TabIndex = 8
        '
        'UPicBoxRicavaAvv
        '
        Me.UPicBoxRicavaAvv.BorderShadowColor = System.Drawing.Color.Empty
        Me.UPicBoxRicavaAvv.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UPicBoxRicavaAvv.Image = CType(resources.GetObject("UPicBoxRicavaAvv.Image"), Object)
        Me.UPicBoxRicavaAvv.Location = New System.Drawing.Point(993, 0)
        Me.UPicBoxRicavaAvv.Name = "UPicBoxRicavaAvv"
        Me.UPicBoxRicavaAvv.Size = New System.Drawing.Size(32, 32)
        Me.UPicBoxRicavaAvv.TabIndex = 47
        '
        'UPanelEnteGiuridico
        '
        Me.UPanelEnteGiuridico.Dock = System.Windows.Forms.DockStyle.Top
        Me.UPanelEnteGiuridico.Location = New System.Drawing.Point(3, 31)
        Me.UPanelEnteGiuridico.Name = "UPanelEnteGiuridico"
        Me.UPanelEnteGiuridico.Size = New System.Drawing.Size(1331, 31)
        Me.UPanelEnteGiuridico.TabIndex = 7
        '
        'UPanelEstremiAtto
        '
        Me.UPanelEstremiAtto.Dock = System.Windows.Forms.DockStyle.Top
        Me.UPanelEstremiAtto.Location = New System.Drawing.Point(3, 3)
        Me.UPanelEstremiAtto.Name = "UPanelEstremiAtto"
        Me.UPanelEstremiAtto.Size = New System.Drawing.Size(1331, 28)
        Me.UPanelEstremiAtto.TabIndex = 6
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
        Me.UPanelDatiDett.Size = New System.Drawing.Size(1337, 371)
        Me.UPanelDatiDett.TabIndex = 1
        '
        'UGrpBoxDatiDett
        '
        Me.UGrpBoxDatiDett.Controls.Add(Me.DocViewer1)
        Me.UGrpBoxDatiDett.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UGrpBoxDatiDett.Location = New System.Drawing.Point(0, 0)
        Me.UGrpBoxDatiDett.Name = "UGrpBoxDatiDett"
        Me.UGrpBoxDatiDett.Size = New System.Drawing.Size(1337, 371)
        Me.UGrpBoxDatiDett.TabIndex = 2
        '
        'DocViewer1
        '
        Me.DocViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocViewer1.IsToolBarVisible = True
        Me.DocViewer1.Location = New System.Drawing.Point(3, 3)
        Me.DocViewer1.Name = "DocViewer1"
        Me.DocViewer1.Size = New System.Drawing.Size(1331, 365)
        Me.DocViewer1.TabIndex = 0
        Me.DocViewer1.Text = "DocViewer1"
        '
        'UPanelDatiGriglia
        '
        '
        'UPanelDatiGriglia.ClientArea
        '
        Me.UPanelDatiGriglia.ClientArea.Controls.Add(Me.UGrpBoxTitoloDatiGriglia)
        Me.UPanelDatiGriglia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UPanelDatiGriglia.Location = New System.Drawing.Point(0, 105)
        Me.UPanelDatiGriglia.Name = "UPanelDatiGriglia"
        Me.UPanelDatiGriglia.Size = New System.Drawing.Size(354, 596)
        Me.UPanelDatiGriglia.TabIndex = 4
        '
        'UGrpBoxTitoloDatiGriglia
        '
        Appearance3.BorderAlpha = Infragistics.Win.Alpha.Transparent
        Appearance3.ImageBackground = CType(resources.GetObject("Appearance3.ImageBackground"), System.Drawing.Image)
        Me.UGrpBoxTitoloDatiGriglia.Appearance = Appearance3
        Me.UGrpBoxTitoloDatiGriglia.Controls.Add(Me.UlblTitoloModelliAtti)
        Me.UGrpBoxTitoloDatiGriglia.Dock = System.Windows.Forms.DockStyle.Top
        Me.UGrpBoxTitoloDatiGriglia.Location = New System.Drawing.Point(0, 0)
        Me.UGrpBoxTitoloDatiGriglia.Name = "UGrpBoxTitoloDatiGriglia"
        Me.UGrpBoxTitoloDatiGriglia.Size = New System.Drawing.Size(354, 23)
        Me.UGrpBoxTitoloDatiGriglia.TabIndex = 0
        '
        'UlblTitoloModelliAtti
        '
        Appearance4.BackColorAlpha = Infragistics.Win.Alpha.Transparent
        Me.UlblTitoloModelliAtti.Appearance = Appearance4
        Me.UlblTitoloModelliAtti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UlblTitoloModelliAtti.Location = New System.Drawing.Point(6, 3)
        Me.UlblTitoloModelliAtti.Name = "UlblTitoloModelliAtti"
        Me.UlblTitoloModelliAtti.Size = New System.Drawing.Size(100, 19)
        Me.UlblTitoloModelliAtti.TabIndex = 0
        Me.UlblTitoloModelliAtti.Text = "Modelli Atti"
        '
        'UDockManagerGenFatt
        '
        Me.UDockManagerGenFatt.CompressUnpinnedTabs = False
        DockAreaPane1.DockedBefore = New System.Guid("7fb753d1-3ccd-4e71-872d-71ed3ee9ea2b")
        DockAreaPane1.MaximumSize = New System.Drawing.Size(2300, 100)
        DockAreaPane1.MinimumSize = New System.Drawing.Size(1300, 100)
        DockableControlPane1.Control = Me.UPanelToolbar
        DockableControlPane1.OriginalControlBounds = New System.Drawing.Rectangle(0, 0, 1300, 100)
        DockableControlPane1.Size = New System.Drawing.Size(100, 100)
        DockAreaPane1.Panes.AddRange(New Infragistics.Win.UltraWinDock.DockablePaneBase() {DockableControlPane1})
        DockAreaPane1.Size = New System.Drawing.Size(1696, 100)
        DockableControlPane2.Control = Me.UPanelFiltriRicerca
        DockableControlPane2.OriginalControlBounds = New System.Drawing.Rectangle(0, 119, 539, 180)
        DockableControlPane2.Size = New System.Drawing.Size(100, 53)
        DockableControlPane2.Text = "Dati Documento"
        DockableControlPane3.Control = Me.UPanelDatiDett
        DockableControlPane3.OriginalControlBounds = New System.Drawing.Rectangle(587, 129, 713, 572)
        DockableControlPane3.Size = New System.Drawing.Size(100, 103)
        DockableControlPane3.Text = "Documento"
        DockAreaPane2.Panes.AddRange(New Infragistics.Win.UltraWinDock.DockablePaneBase() {DockableControlPane2, DockableControlPane3})
        DockAreaPane2.Size = New System.Drawing.Size(1337, 596)
        Me.UDockManagerGenFatt.DockAreas.AddRange(New Infragistics.Win.UltraWinDock.DockAreaPane() {DockAreaPane1, DockAreaPane2})
        Me.UDockManagerGenFatt.HostControl = Me
        Me.UDockManagerGenFatt.ShowCloseButton = False
        Me.UDockManagerGenFatt.ShowPinButton = False
        '
        '_UsrCtrlAnaAvvUnpinnedTabAreaLeft
        '
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.Location = New System.Drawing.Point(0, 0)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.Name = "_UsrCtrlAnaAvvUnpinnedTabAreaLeft"
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.Owner = Me.UDockManagerGenFatt
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.Size = New System.Drawing.Size(0, 701)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.TabIndex = 5
        '
        '_UsrCtrlAnaAvvUnpinnedTabAreaRight
        '
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Dock = System.Windows.Forms.DockStyle.Right
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Location = New System.Drawing.Point(1696, 0)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Name = "_UsrCtrlAnaAvvUnpinnedTabAreaRight"
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Owner = Me.UDockManagerGenFatt
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
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.Owner = Me.UDockManagerGenFatt
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.Size = New System.Drawing.Size(1696, 0)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.TabIndex = 7
        '
        '_UsrCtrlAnaAvvUnpinnedTabAreaBottom
        '
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Location = New System.Drawing.Point(0, 701)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Name = "_UsrCtrlAnaAvvUnpinnedTabAreaBottom"
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Owner = Me.UDockManagerGenFatt
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Size = New System.Drawing.Size(1696, 0)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.TabIndex = 8
        '
        '_UsrCtrlAnaAvvAutoHideControl
        '
        Me._UsrCtrlAnaAvvAutoHideControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._UsrCtrlAnaAvvAutoHideControl.Location = New System.Drawing.Point(0, 0)
        Me._UsrCtrlAnaAvvAutoHideControl.Name = "_UsrCtrlAnaAvvAutoHideControl"
        Me._UsrCtrlAnaAvvAutoHideControl.Owner = Me.UDockManagerGenFatt
        Me._UsrCtrlAnaAvvAutoHideControl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._UsrCtrlAnaAvvAutoHideControl.Size = New System.Drawing.Size(0, 701)
        Me._UsrCtrlAnaAvvAutoHideControl.TabIndex = 9
        '
        'ImageListGenFatt
        '
        Me.ImageListGenFatt.ImageStream = CType(resources.GetObject("ImageListGenFatt.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListGenFatt.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListGenFatt.Images.SetKeyName(0, "Chiudi-Finestra-68x75.png")
        Me.ImageListGenFatt.Images.SetKeyName(1, "Chiudi-Finestra-highlight-68x75.png")
        Me.ImageListGenFatt.Images.SetKeyName(2, "Genera-Documento-68x75.png")
        Me.ImageListGenFatt.Images.SetKeyName(3, "Genera-Documento-highlight-68x75.png")
        Me.ImageListGenFatt.Images.SetKeyName(4, "Nuovo-Modello-68x75.png")
        Me.ImageListGenFatt.Images.SetKeyName(5, "Nuovo-Modello-highlight-68x75.png")
        Me.ImageListGenFatt.Images.SetKeyName(6, "Nuova-Categoria-68x75.png")
        Me.ImageListGenFatt.Images.SetKeyName(7, "Nuova-Categoria-highlight-68x75.png")
        '
        'ImageListGenFatt2
        '
        Me.ImageListGenFatt2.ImageStream = CType(resources.GetObject("ImageListGenFatt2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListGenFatt2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListGenFatt2.Images.SetKeyName(0, "tre-punti.bmp")
        Me.ImageListGenFatt2.Images.SetKeyName(1, "tre-punti-highlight.bmp")
        '
        'WindowDockingArea3
        '
        Me.WindowDockingArea3.Controls.Add(Me.DockableWindow1)
        Me.WindowDockingArea3.Dock = System.Windows.Forms.DockStyle.Top
        Me.WindowDockingArea3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea3.Location = New System.Drawing.Point(0, 0)
        Me.WindowDockingArea3.Name = "WindowDockingArea3"
        Me.WindowDockingArea3.Owner = Me.UDockManagerGenFatt
        Me.WindowDockingArea3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WindowDockingArea3.Size = New System.Drawing.Size(1696, 105)
        Me.WindowDockingArea3.TabIndex = 15
        '
        'DockableWindow1
        '
        Me.DockableWindow1.Controls.Add(Me.UPanelToolbar)
        Me.DockableWindow1.Location = New System.Drawing.Point(0, 0)
        Me.DockableWindow1.Name = "DockableWindow1"
        Me.DockableWindow1.Owner = Me.UDockManagerGenFatt
        Me.DockableWindow1.Size = New System.Drawing.Size(1696, 100)
        Me.DockableWindow1.TabIndex = 17
        '
        'WindowDockingArea2
        '
        Me.WindowDockingArea2.Controls.Add(Me.DockableWindow2)
        Me.WindowDockingArea2.Controls.Add(Me.DockableWindow3)
        Me.WindowDockingArea2.Dock = System.Windows.Forms.DockStyle.Right
        Me.WindowDockingArea2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea2.Location = New System.Drawing.Point(354, 105)
        Me.WindowDockingArea2.Name = "WindowDockingArea2"
        Me.WindowDockingArea2.Owner = Me.UDockManagerGenFatt
        Me.WindowDockingArea2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WindowDockingArea2.Size = New System.Drawing.Size(1342, 596)
        Me.WindowDockingArea2.TabIndex = 16
        '
        'DockableWindow2
        '
        Me.DockableWindow2.Controls.Add(Me.UPanelFiltriRicerca)
        Me.DockableWindow2.Location = New System.Drawing.Point(5, 0)
        Me.DockableWindow2.Name = "DockableWindow2"
        Me.DockableWindow2.Owner = Me.UDockManagerGenFatt
        Me.DockableWindow2.Size = New System.Drawing.Size(1337, 201)
        Me.DockableWindow2.TabIndex = 18
        '
        'DockableWindow3
        '
        Me.DockableWindow3.Controls.Add(Me.UPanelDatiDett)
        Me.DockableWindow3.Location = New System.Drawing.Point(5, 206)
        Me.DockableWindow3.Name = "DockableWindow3"
        Me.DockableWindow3.Owner = Me.UDockManagerGenFatt
        Me.DockableWindow3.Size = New System.Drawing.Size(1337, 390)
        Me.DockableWindow3.TabIndex = 19
        '
        'UsrCtrlFattGen
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
        Me.Name = "UsrCtrlFattGen"
        Me.Size = New System.Drawing.Size(1696, 701)
        Me.UPanelToolbar.ClientArea.ResumeLayout(False)
        Me.UPanelToolbar.ResumeLayout(False)
        CType(Me.UGrpBoxToolbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UGrpBoxToolbar.ResumeLayout(False)
        CType(Me.PictBoxNuovaCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxNuovoModello, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxGenDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxChiudiFinestra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UPanelFiltriRicerca.ClientArea.ResumeLayout(False)
        Me.UPanelFiltriRicerca.ResumeLayout(False)
        CType(Me.UGrpBoxFiltrirRicerca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UGrpBoxFiltrirRicerca.ResumeLayout(False)
        Me.UPanelAltriDati.ResumeLayout(False)
        Me.UPanelDatiControparti.ClientArea.ResumeLayout(False)
        Me.UPanelDatiControparti.ResumeLayout(False)
        Me.UPanelDatiParti.ClientArea.ResumeLayout(False)
        Me.UPanelDatiParti.ResumeLayout(False)
        Me.UPaneDatiAvvocati.ClientArea.ResumeLayout(False)
        Me.UPaneDatiAvvocati.ResumeLayout(False)
        Me.UPanelEnteGiuridico.ResumeLayout(False)
        Me.UPanelEstremiAtto.ResumeLayout(False)
        Me.UPanelDatiDett.ClientArea.ResumeLayout(False)
        Me.UPanelDatiDett.ResumeLayout(False)
        CType(Me.UGrpBoxDatiDett, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UGrpBoxDatiDett.ResumeLayout(False)
        Me.UPanelDatiGriglia.ClientArea.ResumeLayout(False)
        Me.UPanelDatiGriglia.ResumeLayout(False)
        CType(Me.UGrpBoxTitoloDatiGriglia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UGrpBoxTitoloDatiGriglia.ResumeLayout(False)
        CType(Me.UDockManagerGenFatt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WindowDockingArea3.ResumeLayout(False)
        Me.DockableWindow1.ResumeLayout(False)
        Me.WindowDockingArea2.ResumeLayout(False)
        Me.DockableWindow2.ResumeLayout(False)
        Me.DockableWindow3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UPanelToolbar As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UGrpBoxToolbar As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UPanelDatiDett As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UPanelFiltriRicerca As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UPanelDatiGriglia As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UDockManagerGenFatt As Infragistics.Win.UltraWinDock.UltraDockManager
    Friend WithEvents _UsrCtrlAnaAvvAutoHideControl As Infragistics.Win.UltraWinDock.AutoHideControl
    Friend WithEvents _UsrCtrlAnaAvvUnpinnedTabAreaBottom As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _UsrCtrlAnaAvvUnpinnedTabAreaTop As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _UsrCtrlAnaAvvUnpinnedTabAreaRight As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _UsrCtrlAnaAvvUnpinnedTabAreaLeft As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents PicBoxChiudiFinestra As PictureBox
    Friend WithEvents PicBoxGenDoc As PictureBox
    Friend WithEvents PicBoxNuovoModello As PictureBox
    Friend WithEvents PictBoxNuovaCat As PictureBox
    Friend WithEvents UlblRigaTitolo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UlblTitoloAnaBase As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UGrpBoxFiltrirRicerca As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UGrpBoxDatiDett As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UGrpBoxTitoloDatiGriglia As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UlblTitoloModelliAtti As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ImageListGenFatt As ImageList
    Friend WithEvents ImageListGenFatt2 As ImageList
    Friend WithEvents DocViewer1 As Spire.DocViewer.Forms.DocViewer
    Friend WithEvents UPanelAltriDati As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UPanelDatiControparti As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UPicBoxRicavaControparte As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents UPanelDatiParti As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UPicBoxRicavaParte As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents UPaneDatiAvvocati As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UPicBoxRicavaAvv As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents UPanelEnteGiuridico As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UPanelEstremiAtto As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents WindowDockingArea2 As Infragistics.Win.UltraWinDock.WindowDockingArea
    Friend WithEvents DockableWindow2 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents DockableWindow3 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents WindowDockingArea3 As Infragistics.Win.UltraWinDock.WindowDockingArea
    Friend WithEvents DockableWindow1 As Infragistics.Win.UltraWinDock.DockableWindow
End Class
