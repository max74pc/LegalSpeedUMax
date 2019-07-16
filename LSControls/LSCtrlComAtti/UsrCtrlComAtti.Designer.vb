<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsrCtrlComAtti
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsrCtrlComAtti))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTreeNode4 As Infragistics.Win.UltraWinTree.UltraTreeNode = New Infragistics.Win.UltraWinTree.UltraTreeNode()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Me.UlblAltriDati = New Infragistics.Win.Misc.UltraLabel()
        Me.UPanelDatiControparti = New Infragistics.Win.Misc.UltraPanel()
        Me.UPicBoxRicavaControparte = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.LSUTxtNomiControparti = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.UlblDatiControparti = New Infragistics.Win.Misc.UltraLabel()
        Me.UPanelDatiParti = New Infragistics.Win.Misc.UltraPanel()
        Me.UPicBoxRicavaParte = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.LSUTxtNomiParti = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.UlblDatiParti = New Infragistics.Win.Misc.UltraLabel()
        Me.UPaneDatiAvvocati = New Infragistics.Win.Misc.UltraPanel()
        Me.UPicBoxRicavaAvv = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.LSUTxtNomiAvv = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.UlblDatiAvvocati = New Infragistics.Win.Misc.UltraLabel()
        Me.UPanelEnteGiuridico = New Infragistics.Win.Misc.UltraPanel()
        Me.LSUCboEditSedeEnte = New LSUltraMenuTendina.LSMenuTendina()
        Me.LSUCboEditTipoEnte = New LSUltraMenuTendina.LSMenuTendina()
        Me.UlblDatiEnte = New Infragistics.Win.Misc.UltraLabel()
        Me.UPanelEstremiAtto = New Infragistics.Win.Misc.UltraPanel()
        Me.LSUTxtNumRuolo = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.LSUTxtDescrizioneAtto = New LSUltraCasellaTesto.LSUltraCasellaTesto()
        Me.UlblEstremiAtto = New Infragistics.Win.Misc.UltraLabel()
        Me.UPanelDatiDett = New Infragistics.Win.Misc.UltraPanel()
        Me.UGrpBoxDatiDett = New Infragistics.Win.Misc.UltraGroupBox()
        Me.DocViewer1 = New Spire.DocViewer.Forms.DocViewer()
        Me.UPanelDatiGriglia = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraTreeModelliAtti = New Infragistics.Win.UltraWinTree.UltraTree()
        Me.UGrpBoxTitoloDatiGriglia = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UlblTitoloModelliAtti = New Infragistics.Win.Misc.UltraLabel()
        Me.UDockManagerComAtti = New Infragistics.Win.UltraWinDock.UltraDockManager(Me.components)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._UsrCtrlAnaAvvAutoHideControl = New Infragistics.Win.UltraWinDock.AutoHideControl()
        Me.ImageListComAtti = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageListComAtti2 = New System.Windows.Forms.ImageList(Me.components)
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
        Me.UPanelAltriDati.ClientArea.SuspendLayout()
        Me.UPanelAltriDati.SuspendLayout()
        Me.UPanelDatiControparti.ClientArea.SuspendLayout()
        Me.UPanelDatiControparti.SuspendLayout()
        Me.UPanelDatiParti.ClientArea.SuspendLayout()
        Me.UPanelDatiParti.SuspendLayout()
        Me.UPaneDatiAvvocati.ClientArea.SuspendLayout()
        Me.UPaneDatiAvvocati.SuspendLayout()
        Me.UPanelEnteGiuridico.ClientArea.SuspendLayout()
        Me.UPanelEnteGiuridico.SuspendLayout()
        Me.UPanelEstremiAtto.ClientArea.SuspendLayout()
        Me.UPanelEstremiAtto.SuspendLayout()
        Me.UPanelDatiDett.ClientArea.SuspendLayout()
        Me.UPanelDatiDett.SuspendLayout()
        CType(Me.UGrpBoxDatiDett, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UGrpBoxDatiDett.SuspendLayout()
        Me.UPanelDatiGriglia.ClientArea.SuspendLayout()
        Me.UPanelDatiGriglia.SuspendLayout()
        CType(Me.UltraTreeModelliAtti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UGrpBoxTitoloDatiGriglia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UGrpBoxTitoloDatiGriglia.SuspendLayout()
        CType(Me.UDockManagerComAtti, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.UlblTitoloAnaBase.Font = New System.Drawing.Font("Linux Libertine Display G", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UlblTitoloAnaBase.Location = New System.Drawing.Point(19, 12)
        Me.UlblTitoloAnaBase.Name = "UlblTitoloAnaBase"
        Me.UlblTitoloAnaBase.Size = New System.Drawing.Size(372, 40)
        Me.UlblTitoloAnaBase.TabIndex = 10
        Me.UlblTitoloAnaBase.Text = "Compositore Atti"
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
        '
        'UPanelAltriDati.ClientArea
        '
        Me.UPanelAltriDati.ClientArea.Controls.Add(Me.UlblAltriDati)
        Me.UPanelAltriDati.Dock = System.Windows.Forms.DockStyle.Top
        Me.UPanelAltriDati.Location = New System.Drawing.Point(3, 157)
        Me.UPanelAltriDati.Name = "UPanelAltriDati"
        Me.UPanelAltriDati.Size = New System.Drawing.Size(1331, 30)
        Me.UPanelAltriDati.TabIndex = 11
        '
        'UlblAltriDati
        '
        Appearance3.BackColor = System.Drawing.Color.LightBlue
        Appearance3.TextHAlignAsString = "Center"
        Me.UlblAltriDati.Appearance = Appearance3
        Me.UlblAltriDati.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UlblAltriDati.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UlblAltriDati.Location = New System.Drawing.Point(3, 3)
        Me.UlblAltriDati.Name = "UlblAltriDati"
        Me.UlblAltriDati.Size = New System.Drawing.Size(174, 23)
        Me.UlblAltriDati.TabIndex = 2
        Me.UlblAltriDati.Text = "Altri Dati"
        '
        'UPanelDatiControparti
        '
        '
        'UPanelDatiControparti.ClientArea
        '
        Me.UPanelDatiControparti.ClientArea.Controls.Add(Me.UPicBoxRicavaControparte)
        Me.UPanelDatiControparti.ClientArea.Controls.Add(Me.LSUTxtNomiControparti)
        Me.UPanelDatiControparti.ClientArea.Controls.Add(Me.UlblDatiControparti)
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
        'LSUTxtNomiControparti
        '
        Me.LSUTxtNomiControparti.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtNomiControparti.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtNomiControparti.LarghezzaCasellaTesto = 300
        Me.LSUTxtNomiControparti.LarghezzaEtichetta = 220
        Me.LSUTxtNomiControparti.Location = New System.Drawing.Point(205, 0)
        Me.LSUTxtNomiControparti.Name = "LSUTxtNomiControparti"
        Me.LSUTxtNomiControparti.Obbligatorio = True
        Me.LSUTxtNomiControparti.Size = New System.Drawing.Size(782, 30)
        Me.LSUTxtNomiControparti.TabIndex = 11
        Me.LSUTxtNomiControparti.TestoEtichetta = "Denominazioni Controparti:"
        Me.LSUTxtNomiControparti.ValoreCasellaTesto = ""
        '
        'UlblDatiControparti
        '
        Appearance4.BackColor = System.Drawing.Color.LightBlue
        Appearance4.TextHAlignAsString = "Center"
        Me.UlblDatiControparti.Appearance = Appearance4
        Me.UlblDatiControparti.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UlblDatiControparti.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UlblDatiControparti.Location = New System.Drawing.Point(3, 6)
        Me.UlblDatiControparti.Name = "UlblDatiControparti"
        Me.UlblDatiControparti.Size = New System.Drawing.Size(174, 23)
        Me.UlblDatiControparti.TabIndex = 2
        Me.UlblDatiControparti.Text = "Dati Controparti"
        '
        'UPanelDatiParti
        '
        '
        'UPanelDatiParti.ClientArea
        '
        Me.UPanelDatiParti.ClientArea.Controls.Add(Me.UPicBoxRicavaParte)
        Me.UPanelDatiParti.ClientArea.Controls.Add(Me.LSUTxtNomiParti)
        Me.UPanelDatiParti.ClientArea.Controls.Add(Me.UlblDatiParti)
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
        'LSUTxtNomiParti
        '
        Me.LSUTxtNomiParti.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtNomiParti.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtNomiParti.LarghezzaCasellaTesto = 300
        Me.LSUTxtNomiParti.LarghezzaEtichetta = 220
        Me.LSUTxtNomiParti.Location = New System.Drawing.Point(205, 0)
        Me.LSUTxtNomiParti.Name = "LSUTxtNomiParti"
        Me.LSUTxtNomiParti.Obbligatorio = True
        Me.LSUTxtNomiParti.Size = New System.Drawing.Size(782, 30)
        Me.LSUTxtNomiParti.TabIndex = 10
        Me.LSUTxtNomiParti.TestoEtichetta = "Denominazioni Parti:"
        Me.LSUTxtNomiParti.ValoreCasellaTesto = ""
        '
        'UlblDatiParti
        '
        Appearance5.BackColor = System.Drawing.Color.LightBlue
        Appearance5.TextHAlignAsString = "Center"
        Me.UlblDatiParti.Appearance = Appearance5
        Me.UlblDatiParti.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UlblDatiParti.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UlblDatiParti.Location = New System.Drawing.Point(3, 3)
        Me.UlblDatiParti.Name = "UlblDatiParti"
        Me.UlblDatiParti.Size = New System.Drawing.Size(174, 23)
        Me.UlblDatiParti.TabIndex = 2
        Me.UlblDatiParti.Text = "Dati Parti"
        '
        'UPaneDatiAvvocati
        '
        '
        'UPaneDatiAvvocati.ClientArea
        '
        Me.UPaneDatiAvvocati.ClientArea.Controls.Add(Me.UPicBoxRicavaAvv)
        Me.UPaneDatiAvvocati.ClientArea.Controls.Add(Me.LSUTxtNomiAvv)
        Me.UPaneDatiAvvocati.ClientArea.Controls.Add(Me.UlblDatiAvvocati)
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
        'LSUTxtNomiAvv
        '
        Me.LSUTxtNomiAvv.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtNomiAvv.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtNomiAvv.LarghezzaCasellaTesto = 300
        Me.LSUTxtNomiAvv.LarghezzaEtichetta = 220
        Me.LSUTxtNomiAvv.Location = New System.Drawing.Point(205, 0)
        Me.LSUTxtNomiAvv.Name = "LSUTxtNomiAvv"
        Me.LSUTxtNomiAvv.Obbligatorio = True
        Me.LSUTxtNomiAvv.Size = New System.Drawing.Size(782, 30)
        Me.LSUTxtNomiAvv.TabIndex = 9
        Me.LSUTxtNomiAvv.TestoEtichetta = "Denominazioni Avvocati:"
        Me.LSUTxtNomiAvv.ValoreCasellaTesto = ""
        '
        'UlblDatiAvvocati
        '
        Appearance6.BackColor = System.Drawing.Color.LightBlue
        Appearance6.TextHAlignAsString = "Center"
        Me.UlblDatiAvvocati.Appearance = Appearance6
        Me.UlblDatiAvvocati.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UlblDatiAvvocati.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UlblDatiAvvocati.Location = New System.Drawing.Point(3, 3)
        Me.UlblDatiAvvocati.Name = "UlblDatiAvvocati"
        Me.UlblDatiAvvocati.Size = New System.Drawing.Size(174, 23)
        Me.UlblDatiAvvocati.TabIndex = 2
        Me.UlblDatiAvvocati.Text = "Dati Avvocati"
        '
        'UPanelEnteGiuridico
        '
        '
        'UPanelEnteGiuridico.ClientArea
        '
        Me.UPanelEnteGiuridico.ClientArea.Controls.Add(Me.LSUCboEditSedeEnte)
        Me.UPanelEnteGiuridico.ClientArea.Controls.Add(Me.LSUCboEditTipoEnte)
        Me.UPanelEnteGiuridico.ClientArea.Controls.Add(Me.UlblDatiEnte)
        Me.UPanelEnteGiuridico.Dock = System.Windows.Forms.DockStyle.Top
        Me.UPanelEnteGiuridico.Location = New System.Drawing.Point(3, 31)
        Me.UPanelEnteGiuridico.Name = "UPanelEnteGiuridico"
        Me.UPanelEnteGiuridico.Size = New System.Drawing.Size(1331, 31)
        Me.UPanelEnteGiuridico.TabIndex = 7
        '
        'LSUCboEditSedeEnte
        '
        Me.LSUCboEditSedeEnte.ColoreSfondoMenuTendinaInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUCboEditSedeEnte.ColoreSfondoMenuTendinaInUscita = System.Drawing.Color.White
        Me.LSUCboEditSedeEnte.LarghezzaCasellaTesto = 300
        Me.LSUCboEditSedeEnte.LarghezzaEtichetta = 80
        Me.LSUCboEditSedeEnte.Location = New System.Drawing.Point(740, -1)
        Me.LSUCboEditSedeEnte.Name = "LSUCboEditSedeEnte"
        Me.LSUCboEditSedeEnte.Obbligatorio = True
        Me.LSUCboEditSedeEnte.Size = New System.Drawing.Size(532, 32)
        Me.LSUCboEditSedeEnte.TabIndex = 3
        Me.LSUCboEditSedeEnte.TestoEtichetta = "Sede Ente:"
        Me.LSUCboEditSedeEnte.ValoreMenuTendina = ""
        '
        'LSUCboEditTipoEnte
        '
        Me.LSUCboEditTipoEnte.ColoreSfondoMenuTendinaInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUCboEditTipoEnte.ColoreSfondoMenuTendinaInUscita = System.Drawing.Color.White
        Me.LSUCboEditTipoEnte.LarghezzaCasellaTesto = 300
        Me.LSUCboEditTipoEnte.LarghezzaEtichetta = 85
        Me.LSUCboEditTipoEnte.Location = New System.Drawing.Point(183, 0)
        Me.LSUCboEditTipoEnte.Name = "LSUCboEditTipoEnte"
        Me.LSUCboEditTipoEnte.Obbligatorio = True
        Me.LSUCboEditTipoEnte.Size = New System.Drawing.Size(563, 32)
        Me.LSUCboEditTipoEnte.TabIndex = 2
        Me.LSUCboEditTipoEnte.TestoEtichetta = "Tipo Ente:"
        Me.LSUCboEditTipoEnte.ValoreMenuTendina = ""
        '
        'UlblDatiEnte
        '
        Appearance7.BackColor = System.Drawing.Color.LightBlue
        Appearance7.TextHAlignAsString = "Center"
        Me.UlblDatiEnte.Appearance = Appearance7
        Me.UlblDatiEnte.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UlblDatiEnte.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UlblDatiEnte.Location = New System.Drawing.Point(3, 3)
        Me.UlblDatiEnte.Name = "UlblDatiEnte"
        Me.UlblDatiEnte.Size = New System.Drawing.Size(174, 23)
        Me.UlblDatiEnte.TabIndex = 1
        Me.UlblDatiEnte.Text = "Dati Ente"
        '
        'UPanelEstremiAtto
        '
        '
        'UPanelEstremiAtto.ClientArea
        '
        Me.UPanelEstremiAtto.ClientArea.Controls.Add(Me.LSUTxtNumRuolo)
        Me.UPanelEstremiAtto.ClientArea.Controls.Add(Me.LSUTxtDescrizioneAtto)
        Me.UPanelEstremiAtto.ClientArea.Controls.Add(Me.UlblEstremiAtto)
        Me.UPanelEstremiAtto.Dock = System.Windows.Forms.DockStyle.Top
        Me.UPanelEstremiAtto.Location = New System.Drawing.Point(3, 3)
        Me.UPanelEstremiAtto.Name = "UPanelEstremiAtto"
        Me.UPanelEstremiAtto.Size = New System.Drawing.Size(1331, 28)
        Me.UPanelEstremiAtto.TabIndex = 6
        '
        'LSUTxtNumRuolo
        '
        Me.LSUTxtNumRuolo.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtNumRuolo.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtNumRuolo.LarghezzaCasellaTesto = 120
        Me.LSUTxtNumRuolo.LarghezzaEtichetta = 120
        Me.LSUTxtNumRuolo.Location = New System.Drawing.Point(776, -2)
        Me.LSUTxtNumRuolo.Name = "LSUTxtNumRuolo"
        Me.LSUTxtNumRuolo.Obbligatorio = True
        Me.LSUTxtNumRuolo.Size = New System.Drawing.Size(421, 30)
        Me.LSUTxtNumRuolo.TabIndex = 9
        Me.LSUTxtNumRuolo.TestoEtichetta = "Num di Ruolo:"
        Me.LSUTxtNumRuolo.ValoreCasellaTesto = ""
        '
        'LSUTxtDescrizioneAtto
        '
        Me.LSUTxtDescrizioneAtto.ColoreSfondoCasellaTestoInEntrata = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.LSUTxtDescrizioneAtto.ColoreSfondoCasellaTestoInUscita = System.Drawing.Color.White
        Me.LSUTxtDescrizioneAtto.LarghezzaCasellaTesto = 300
        Me.LSUTxtDescrizioneAtto.LarghezzaEtichetta = 100
        Me.LSUTxtDescrizioneAtto.Location = New System.Drawing.Point(183, -2)
        Me.LSUTxtDescrizioneAtto.Name = "LSUTxtDescrizioneAtto"
        Me.LSUTxtDescrizioneAtto.Obbligatorio = True
        Me.LSUTxtDescrizioneAtto.Size = New System.Drawing.Size(604, 30)
        Me.LSUTxtDescrizioneAtto.TabIndex = 8
        Me.LSUTxtDescrizioneAtto.TestoEtichetta = "Descrizione:"
        Me.LSUTxtDescrizioneAtto.ValoreCasellaTesto = ""
        '
        'UlblEstremiAtto
        '
        Appearance8.BackColor = System.Drawing.Color.LightBlue
        Appearance8.TextHAlignAsString = "Center"
        Me.UlblEstremiAtto.Appearance = Appearance8
        Me.UlblEstremiAtto.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UlblEstremiAtto.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UlblEstremiAtto.Location = New System.Drawing.Point(3, 3)
        Me.UlblEstremiAtto.Name = "UlblEstremiAtto"
        Me.UlblEstremiAtto.Size = New System.Drawing.Size(174, 23)
        Me.UlblEstremiAtto.TabIndex = 0
        Me.UlblEstremiAtto.Text = "Estremi Atto"
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
        Me.UPanelDatiGriglia.ClientArea.Controls.Add(Me.UltraTreeModelliAtti)
        Me.UPanelDatiGriglia.ClientArea.Controls.Add(Me.UGrpBoxTitoloDatiGriglia)
        Me.UPanelDatiGriglia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UPanelDatiGriglia.Location = New System.Drawing.Point(0, 105)
        Me.UPanelDatiGriglia.Name = "UPanelDatiGriglia"
        Me.UPanelDatiGriglia.Size = New System.Drawing.Size(354, 596)
        Me.UPanelDatiGriglia.TabIndex = 4
        '
        'UltraTreeModelliAtti
        '
        Appearance9.FontData.SizeInPoints = 12.0!
        Me.UltraTreeModelliAtti.Appearance = Appearance9
        Me.UltraTreeModelliAtti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTreeModelliAtti.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.UltraTreeModelliAtti.Location = New System.Drawing.Point(0, 23)
        Me.UltraTreeModelliAtti.Name = "UltraTreeModelliAtti"
        Me.UltraTreeModelliAtti.NodeConnectorColor = System.Drawing.SystemColors.ControlDark
        UltraTreeNode4.Text = "Atti"
        Me.UltraTreeModelliAtti.Nodes.AddRange(New Infragistics.Win.UltraWinTree.UltraTreeNode() {UltraTreeNode4})
        Me.UltraTreeModelliAtti.Size = New System.Drawing.Size(354, 573)
        Me.UltraTreeModelliAtti.TabIndex = 1
        '
        'UGrpBoxTitoloDatiGriglia
        '
        Appearance10.BorderAlpha = Infragistics.Win.Alpha.Transparent
        Appearance10.ImageBackground = CType(resources.GetObject("Appearance10.ImageBackground"), System.Drawing.Image)
        Me.UGrpBoxTitoloDatiGriglia.Appearance = Appearance10
        Me.UGrpBoxTitoloDatiGriglia.Controls.Add(Me.UlblTitoloModelliAtti)
        Me.UGrpBoxTitoloDatiGriglia.Dock = System.Windows.Forms.DockStyle.Top
        Me.UGrpBoxTitoloDatiGriglia.Location = New System.Drawing.Point(0, 0)
        Me.UGrpBoxTitoloDatiGriglia.Name = "UGrpBoxTitoloDatiGriglia"
        Me.UGrpBoxTitoloDatiGriglia.Size = New System.Drawing.Size(354, 23)
        Me.UGrpBoxTitoloDatiGriglia.TabIndex = 0
        '
        'UlblTitoloModelliAtti
        '
        Appearance11.BackColorAlpha = Infragistics.Win.Alpha.Transparent
        Me.UlblTitoloModelliAtti.Appearance = Appearance11
        Me.UlblTitoloModelliAtti.Font = New System.Drawing.Font("Linux Libertine Display G", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UlblTitoloModelliAtti.Location = New System.Drawing.Point(6, 3)
        Me.UlblTitoloModelliAtti.Name = "UlblTitoloModelliAtti"
        Me.UlblTitoloModelliAtti.Size = New System.Drawing.Size(100, 19)
        Me.UlblTitoloModelliAtti.TabIndex = 0
        Me.UlblTitoloModelliAtti.Text = "Modelli Atti"
        '
        'UDockManagerComAtti
        '
        Me.UDockManagerComAtti.CompressUnpinnedTabs = False
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
        Me.UDockManagerComAtti.DockAreas.AddRange(New Infragistics.Win.UltraWinDock.DockAreaPane() {DockAreaPane1, DockAreaPane2})
        Me.UDockManagerComAtti.HostControl = Me
        Me.UDockManagerComAtti.ShowCloseButton = False
        Me.UDockManagerComAtti.ShowPinButton = False
        '
        '_UsrCtrlAnaAvvUnpinnedTabAreaLeft
        '
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.Location = New System.Drawing.Point(0, 0)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.Name = "_UsrCtrlAnaAvvUnpinnedTabAreaLeft"
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.Owner = Me.UDockManagerComAtti
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.Size = New System.Drawing.Size(0, 701)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaLeft.TabIndex = 5
        '
        '_UsrCtrlAnaAvvUnpinnedTabAreaRight
        '
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Dock = System.Windows.Forms.DockStyle.Right
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Location = New System.Drawing.Point(1696, 0)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Name = "_UsrCtrlAnaAvvUnpinnedTabAreaRight"
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Owner = Me.UDockManagerComAtti
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.Size = New System.Drawing.Size(0, 701)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaRight.TabIndex = 6
        '
        '_UsrCtrlAnaAvvUnpinnedTabAreaTop
        '
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.Dock = System.Windows.Forms.DockStyle.Top
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.Location = New System.Drawing.Point(0, 0)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.Name = "_UsrCtrlAnaAvvUnpinnedTabAreaTop"
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.Owner = Me.UDockManagerComAtti
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.Size = New System.Drawing.Size(1696, 0)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaTop.TabIndex = 7
        '
        '_UsrCtrlAnaAvvUnpinnedTabAreaBottom
        '
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Location = New System.Drawing.Point(0, 701)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Name = "_UsrCtrlAnaAvvUnpinnedTabAreaBottom"
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Owner = Me.UDockManagerComAtti
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.Size = New System.Drawing.Size(1696, 0)
        Me._UsrCtrlAnaAvvUnpinnedTabAreaBottom.TabIndex = 8
        '
        '_UsrCtrlAnaAvvAutoHideControl
        '
        Me._UsrCtrlAnaAvvAutoHideControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._UsrCtrlAnaAvvAutoHideControl.Location = New System.Drawing.Point(0, 0)
        Me._UsrCtrlAnaAvvAutoHideControl.Name = "_UsrCtrlAnaAvvAutoHideControl"
        Me._UsrCtrlAnaAvvAutoHideControl.Owner = Me.UDockManagerComAtti
        Me._UsrCtrlAnaAvvAutoHideControl.Size = New System.Drawing.Size(0, 701)
        Me._UsrCtrlAnaAvvAutoHideControl.TabIndex = 9
        '
        'ImageListComAtti
        '
        Me.ImageListComAtti.ImageStream = CType(resources.GetObject("ImageListComAtti.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListComAtti.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListComAtti.Images.SetKeyName(0, "Chiudi-Finestra-68x75.png")
        Me.ImageListComAtti.Images.SetKeyName(1, "Chiudi-Finestra-highlight-68x75.png")
        Me.ImageListComAtti.Images.SetKeyName(2, "Genera-Documento-68x75.png")
        Me.ImageListComAtti.Images.SetKeyName(3, "Genera-Documento-highlight-68x75.png")
        Me.ImageListComAtti.Images.SetKeyName(4, "Nuovo-Modello-68x75.png")
        Me.ImageListComAtti.Images.SetKeyName(5, "Nuovo-Modello-highlight-68x75.png")
        Me.ImageListComAtti.Images.SetKeyName(6, "Nuova-Categoria-68x75.png")
        Me.ImageListComAtti.Images.SetKeyName(7, "Nuova-Categoria-highlight-68x75.png")
        '
        'ImageListComAtti2
        '
        Me.ImageListComAtti2.ImageStream = CType(resources.GetObject("ImageListComAtti2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListComAtti2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListComAtti2.Images.SetKeyName(0, "tre-punti.bmp")
        Me.ImageListComAtti2.Images.SetKeyName(1, "tre-punti-highlight.bmp")
        '
        'WindowDockingArea3
        '
        Me.WindowDockingArea3.Controls.Add(Me.DockableWindow1)
        Me.WindowDockingArea3.Dock = System.Windows.Forms.DockStyle.Top
        Me.WindowDockingArea3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea3.Location = New System.Drawing.Point(0, 0)
        Me.WindowDockingArea3.Name = "WindowDockingArea3"
        Me.WindowDockingArea3.Owner = Me.UDockManagerComAtti
        Me.WindowDockingArea3.Size = New System.Drawing.Size(1696, 105)
        Me.WindowDockingArea3.TabIndex = 15
        '
        'DockableWindow1
        '
        Me.DockableWindow1.Controls.Add(Me.UPanelToolbar)
        Me.DockableWindow1.Location = New System.Drawing.Point(0, 0)
        Me.DockableWindow1.Name = "DockableWindow1"
        Me.DockableWindow1.Owner = Me.UDockManagerComAtti
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
        Me.WindowDockingArea2.Owner = Me.UDockManagerComAtti
        Me.WindowDockingArea2.Size = New System.Drawing.Size(1342, 596)
        Me.WindowDockingArea2.TabIndex = 16
        '
        'DockableWindow2
        '
        Me.DockableWindow2.Controls.Add(Me.UPanelFiltriRicerca)
        Me.DockableWindow2.Location = New System.Drawing.Point(5, 0)
        Me.DockableWindow2.Name = "DockableWindow2"
        Me.DockableWindow2.Owner = Me.UDockManagerComAtti
        Me.DockableWindow2.Size = New System.Drawing.Size(1337, 201)
        Me.DockableWindow2.TabIndex = 18
        '
        'DockableWindow3
        '
        Me.DockableWindow3.Controls.Add(Me.UPanelDatiDett)
        Me.DockableWindow3.Location = New System.Drawing.Point(5, 206)
        Me.DockableWindow3.Name = "DockableWindow3"
        Me.DockableWindow3.Owner = Me.UDockManagerComAtti
        Me.DockableWindow3.Size = New System.Drawing.Size(1337, 390)
        Me.DockableWindow3.TabIndex = 19
        '
        'UsrCtrlComAtti
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
        Me.Name = "UsrCtrlComAtti"
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
        Me.UPanelAltriDati.ClientArea.ResumeLayout(False)
        Me.UPanelAltriDati.ResumeLayout(False)
        Me.UPanelDatiControparti.ClientArea.ResumeLayout(False)
        Me.UPanelDatiControparti.ResumeLayout(False)
        Me.UPanelDatiParti.ClientArea.ResumeLayout(False)
        Me.UPanelDatiParti.ResumeLayout(False)
        Me.UPaneDatiAvvocati.ClientArea.ResumeLayout(False)
        Me.UPaneDatiAvvocati.ResumeLayout(False)
        Me.UPanelEnteGiuridico.ClientArea.ResumeLayout(False)
        Me.UPanelEnteGiuridico.ResumeLayout(False)
        Me.UPanelEstremiAtto.ClientArea.ResumeLayout(False)
        Me.UPanelEstremiAtto.ResumeLayout(False)
        Me.UPanelDatiDett.ClientArea.ResumeLayout(False)
        Me.UPanelDatiDett.ResumeLayout(False)
        CType(Me.UGrpBoxDatiDett, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UGrpBoxDatiDett.ResumeLayout(False)
        Me.UPanelDatiGriglia.ClientArea.ResumeLayout(False)
        Me.UPanelDatiGriglia.ResumeLayout(False)
        CType(Me.UltraTreeModelliAtti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UGrpBoxTitoloDatiGriglia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UGrpBoxTitoloDatiGriglia.ResumeLayout(False)
        CType(Me.UDockManagerComAtti, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents UDockManagerComAtti As Infragistics.Win.UltraWinDock.UltraDockManager
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
    Friend WithEvents ImageListComAtti As ImageList
    Friend WithEvents ImageListComAtti2 As ImageList
    Friend WithEvents UltraTreeModelliAtti As Infragistics.Win.UltraWinTree.UltraTree
    Friend WithEvents DocViewer1 As Spire.DocViewer.Forms.DocViewer
    Friend WithEvents UPanelAltriDati As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UlblAltriDati As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UPanelDatiControparti As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UPicBoxRicavaControparte As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents LSUTxtNomiControparti As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents UlblDatiControparti As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UPanelDatiParti As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UPicBoxRicavaParte As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents LSUTxtNomiParti As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents UlblDatiParti As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UPaneDatiAvvocati As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UPicBoxRicavaAvv As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents LSUTxtNomiAvv As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents UlblDatiAvvocati As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UPanelEnteGiuridico As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents LSUCboEditSedeEnte As LSUltraMenuTendina.LSMenuTendina
    Friend WithEvents LSUCboEditTipoEnte As LSUltraMenuTendina.LSMenuTendina
    Friend WithEvents UlblDatiEnte As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UPanelEstremiAtto As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents LSUTxtNumRuolo As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents LSUTxtDescrizioneAtto As LSUltraCasellaTesto.LSUltraCasellaTesto
    Friend WithEvents UlblEstremiAtto As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents WindowDockingArea2 As Infragistics.Win.UltraWinDock.WindowDockingArea
    Friend WithEvents DockableWindow2 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents DockableWindow3 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents WindowDockingArea3 As Infragistics.Win.UltraWinDock.WindowDockingArea
    Friend WithEvents DockableWindow1 As Infragistics.Win.UltraWinDock.DockableWindow
End Class
