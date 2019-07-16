Imports Infragistics.Windows.DockManager
Imports System.Windows.Forms
Imports LSCtrlAnaAvv
Imports LSCtrlAnaParti
Imports LSCtrlAnaControparti
Imports LSCtrlAnaPersone
Imports LSCtrlAnaUtenti
Imports LSCtrlComAtti

Class MainWindow

    Private _isBusy As Boolean = True

    Public Property IsBusyProp() As Boolean
        Get
            Return _isBusy
        End Get
        Set(ByVal value As Boolean)
            _isBusy = value
        End Set
    End Property

    Private Sub FormChiusa()
        ChiudiContentPaneAttivo()
    End Sub

    Public Sub ChiudiContentPaneAttivo()
        If TabGroupPaneMain.Items.Count = 0 Then Exit Sub
        If TabGroupPaneMain.SelectedIndex < 0 Then Exit Sub
        TabGroupPaneMain.Items.RemoveAt(TabGroupPaneMain.SelectedIndex)
        If TabGroupPaneMain.Items.Count = 0 Then Focus()
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        WindowState = WindowState.Maximized
    End Sub

    Private Sub BtnToolAnaAvv_Click(sender As Object, e As RoutedEventArgs)
        IsBusyProp = True
        'Creato un nuovo ContentPane e imposto la proprietà Header
        Dim AnaAvvPane As New ContentPane With {
            .Header = "Anagrafica Avvocati"
        }

        'Aggiungo il ContentPane appena creato alla collezzione dei panelli del TabGroupPaneMain
        TabGroupPaneMain.Items.Add(AnaAvvPane)

        'Creo un nuov StackPanel
        Dim panelAnaAvv As New StackPanel()

        'Imposto la proprietà Content della ContentPane allo StackPanel appena creato
        AnaAvvPane.Content = panelAnaAvv

        'Creo un nuovo WindowsFormsHost
        Dim HostAnaAvv As New Integration.WindowsFormsHost()

        Dim CtrlAnaAvv As New UsrCtrlAnaAvv With {
            .Dock = DockStyle.Fill,
            .Visible = True
        }
        AddHandler CtrlAnaAvv.Disposed, AddressOf FormChiusa

        'Assegno alla proprietà Child del WindowsFormHost il controllo Anagrafica Avvocato
        HostAnaAvv.Child = CtrlAnaAvv

        HostAnaAvv.Height = Me.Height
        'Aggiungo allo StackPanel come nuovo figlio il WindowsFormsHost Host2
        panelAnaAvv.Children.Add(HostAnaAvv)
        IsBusyProp = False
    End Sub

    Private Sub BtnAnaParti_Click(sender As Object, e As RoutedEventArgs) Handles BtnAnaParti.Click
        'Creato un nuovo ContentPane e imposto la proprietà Header
        Dim AnaPartiPane As New ContentPane With {
            .Header = "Anagrafica Parti"
        }

        'Aggiungo il ContentPane appena creato alla collezzione dei panelli del TabGroupPaneMain
        TabGroupPaneMain.Items.Add(AnaPartiPane)

        'Creo un nuov StackPanel
        Dim panelAnaParti As New StackPanel()

        'Imposto la proprietà Content della ContentPane allo StackPanel appena creato
        AnaPartiPane.Content = panelAnaParti

        'Creo un nuovo WindowsFormsHost
        Dim HostAnaParti As New Integration.WindowsFormsHost()

        Dim CtrlAnaParti As New UsrCtrlAnaParti With {
            .Dock = DockStyle.Fill,
            .Visible = True
        }
        AddHandler CtrlAnaParti.Disposed, AddressOf FormChiusa

        'Assegno alla proprietà Child del WindowsFormHost il controllo Anagrafica Avvocato
        HostAnaParti.Child = CtrlAnaParti

        HostAnaParti.Height = Me.Height
        'Aggiungo allo StackPanel come nuovo figlio il WindowsFormsHost Host2
        panelAnaParti.Children.Add(HostAnaParti)
    End Sub

    Private Sub BtnAnaControparti_Click(sender As Object, e As RoutedEventArgs) Handles BtnAnaControparti.Click
        'Creato un nuovo ContentPane e imposto la proprietà Header
        Dim AnaContropartiPane As New ContentPane With {
            .Header = "Anagrafica Controparti"
        }

        'Aggiungo il ContentPane appena creato alla collezzione dei panelli del TabGroupPaneMain
        TabGroupPaneMain.Items.Add(AnaContropartiPane)

        'Creo un nuov StackPanel
        Dim panelAnaControparti As New StackPanel()

        'Imposto la proprietà Content della ContentPane allo StackPanel appena creato
        AnaContropartiPane.Content = panelAnaControparti

        'Creo un nuovo WindowsFormsHost
        Dim HostAnaControparti As New Integration.WindowsFormsHost()

        Dim CtrlAnaControparti As New UsrCtrlAnaControparti With {
            .Dock = DockStyle.Fill,
            .Visible = True
        }
        AddHandler CtrlAnaControparti.Disposed, AddressOf FormChiusa

        'Assegno alla proprietà Child del WindowsFormHost il controllo Anagrafica Avvocato
        HostAnaControparti.Child = CtrlAnaControparti

        HostAnaControparti.Height = Me.Height
        'Aggiungo allo StackPanel come nuovo figlio il WindowsFormsHost Host2
        panelAnaControparti.Children.Add(HostAnaControparti)
    End Sub

    Private Sub BtnAnaPersone_Click(sender As Object, e As RoutedEventArgs) Handles BtnAnaPersone.Click
        'Creato un nuovo ContentPane e imposto la proprietà Header
        Dim AnaPersPane As New ContentPane With {
            .Header = "Anagrafica Persone"
        }

        'Aggiungo il ContentPane appena creato alla collezzione dei panelli del TabGroupPaneMain
        TabGroupPaneMain.Items.Add(AnaPersPane)

        'Creo un nuov StackPanel
        Dim panelAnaPers As New StackPanel()

        'Imposto la proprietà Content della ContentPane allo StackPanel appena creato
        AnaPersPane.Content = panelAnaPers

        'Creo un nuovo WindowsFormsHost
        Dim HostAnaPers As New Integration.WindowsFormsHost()

        Dim CtrlAnaPers As New UsrCtrlAnaPersone With {
            .Dock = DockStyle.Fill,
            .Visible = True
        }
        AddHandler CtrlAnaPers.Disposed, AddressOf FormChiusa

        'Assegno alla proprietà Child del WindowsFormHost il controllo Anagrafica Avvocato
        HostAnaPers.Child = CtrlAnaPers

        HostAnaPers.Height = Me.Height
        'Aggiungo allo StackPanel come nuovo figlio il WindowsFormsHost Host2
        panelAnaPers.Children.Add(HostAnaPers)
    End Sub

    Private Sub BtnAnaUtenti_Click(sender As Object, e As RoutedEventArgs) Handles BtnAnaUtenti.Click
        'Creato un nuovo ContentPane e imposto la proprietà Header
        Dim AnaUtentiPane As New ContentPane With {
            .Header = "Anagrafica Utenti"
        }

        'Aggiungo il ContentPane appena creato alla collezzione dei panelli del TabGroupPaneMain
        TabGroupPaneMain.Items.Add(AnaUtentiPane)

        'Creo un nuov StackPanel
        Dim panelAnaUtenti As New StackPanel()

        'Imposto la proprietà Content della ContentPane allo StackPanel appena creato
        AnaUtentiPane.Content = panelAnaUtenti

        'Creo un nuovo WindowsFormsHost
        Dim HostAnaUtenti As New Integration.WindowsFormsHost()

        Dim CtrlAnaUtenti As New UsrCtrlAnaUtenti With {
            .Dock = DockStyle.Fill,
            .Visible = True
        }
        AddHandler CtrlAnaUtenti.Disposed, AddressOf FormChiusa
        'Assegno alla proprietà Child del WindowsFormHost il controllo Anagrafica Avvocato
        HostAnaUtenti.Child = CtrlAnaUtenti

        HostAnaUtenti.Height = Me.Height
        'Aggiungo allo StackPanel come nuovo figlio il WindowsFormsHost Host2
        panelAnaUtenti.Children.Add(HostAnaUtenti)
    End Sub

    Private Sub BtnComAtti_Click(sender As Object, e As RoutedEventArgs) Handles BtnComAtti.Click
        'Creato un nuovo ContentPane e imposto la proprietà Header
        Dim ComAttiPane As New ContentPane With {
            .Header = "Compositore Atti"
        }

        'Aggiungo il ContentPane appena creato alla collezzione dei panelli del TabGroupPaneMain
        TabGroupPaneMain.Items.Add(ComAttiPane)

        'Creo un nuov StackPanel
        Dim panelComAtti As New StackPanel()

        'Imposto la proprietà Content della ContentPane allo StackPanel appena creato
        ComAttiPane.Content = panelComAtti

        'Creo un nuovo WindowsFormsHost
        Dim HostComAtti As New Integration.WindowsFormsHost()

        Dim CtrlComAtti As New UsrCtrlComAtti With {
            .Dock = DockStyle.Fill,
            .Visible = True
        }
        AddHandler CtrlComAtti.Disposed, AddressOf FormChiusa

        'Assegno alla proprietà Child del WindowsFormHost il controllo Anagrafica Avvocato
        HostComAtti.Child = CtrlComAtti

        HostComAtti.Height = Me.Height
        'Aggiungo allo StackPanel come nuovo figlio il WindowsFormsHost Host2
        panelComAtti.Children.Add(HostComAtti)
    End Sub

    Private Sub BtnADSBilancio_Click(sender As Object, e As RoutedEventArgs) Handles BtnADSBilancio.Click
        'TODO
    End Sub

    Private Sub BtnFatGenera_Click(sender As Object, e As RoutedEventArgs) Handles BtnFatGenera.Click
        'TODO
    End Sub

    Private Sub BtnLinkAppSLPCT_Click(sender As Object, e As RoutedEventArgs) Handles BtnLinkAppSLPCT.Click
        'TODO
    End Sub

    Private Sub BtnScaAgenda_Click(sender As Object, e As RoutedEventArgs) Handles BtnScaAgenda.Click
        'TODO
    End Sub

    Private Sub BtnUtiCodificaCF_Click(sender As Object, e As RoutedEventArgs) Handles BtnUtiCodificaCF.Click
        'TODO
    End Sub

    Private Sub BtnDecodificaCF_Click(sender As Object, e As RoutedEventArgs) Handles BtnDecodificaCF.Click
        'TODO
    End Sub

    Private Sub BtnEsci_Click(sender As Object, e As RoutedEventArgs) Handles BtnEsci.Click
        Me.Close()
    End Sub
End Class
