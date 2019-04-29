Imports LSDBManager.LSDBContextNS
Imports LSDataModel.LSDataModelNS

Public Class FrmAnaUtenti

    Dim bDatoDettaglioCambiato As Boolean
    Dim bInseritoNuovoUtente As Boolean
    Dim bModificatoUtente As Boolean

    Public Sub InizializzaControlli()

        Dim operazioni As New Operazioni
        Dim listaUtenti As New List(Of Utente)

        UltraDockAnaParti.DockAreas(2).Size = New System.Drawing.Size(Me.Width, Me.Height - 81)
        UltraDockAnaParti.DockAreas(0).Size = New System.Drawing.Size(Me.Width, 81)

        listaUtenti = operazioni.CaricaTutti(Of Utente)()
        UGrdAnaParti.DataSource = listaUtenti

        'UGrdAnaParti.DisplayLayout.Bands(0).Columns(0).Hidden = True
        'UGrdAnaParti.DisplayLayout.Bands(0).Columns(1).Hidden = True
        'UGrdAnaParti.DisplayLayout.Bands(0).Columns(2).Header.Caption = "E-Mail PEC"
        'UGrdAnaParti.DisplayLayout.Bands(0).Columns(3).Header.Caption = "Foro di Appartenenza"
        'UGrdAnaParti.DisplayLayout.Bands(0).Columns(4).Hidden = True
        'UGrdAnaParti.DisplayLayout.Bands(0).Columns(5).Hidden = True
        'UGrdAnaParti.DisplayLayout.Bands(0).Columns(6).Hidden = True
        'UGrdAnaParti.DisplayLayout.Bands(0).Columns(7).Hidden = True
        'UGrdAnaParti.DisplayLayout.Bands(0).Columns(8).Header.Caption = "Num. Cellulare"

    End Sub

    Public Sub SvuotaCampiDettaglio()

        'LSUTxtNomeCompleto.ValoreCasellaTesto = ""

    End Sub

    Public Sub CompilaCampiDatiDettaglio(ByVal parte As Parte)

        'LSUTxtNomeCompleto.ValoreCasellaTesto = parte.NomeCompleto

    End Sub

    Public Sub RicavaDatiDettaglioInseriti(ByVal parte As Parte)

        'parte.CodiceFiscale = LSUTxtCodiceFiscale.ValoreCasellaTesto

    End Sub

    Private Sub FrmAnaAvvocati_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.WindowState = FormWindowState.Maximized

        InizializzaControlli()

    End Sub

    Private Sub UltraPicBoxChiudiFinestra_MouseClick(sender As Object, e As MouseEventArgs) Handles UPicBoxChiudiFinestra.MouseClick
        Dim risultatoChiusura As Integer
        If bDatoDettaglioCambiato = True Then
            risultatoChiusura = MessageBox.Show(text:="Attenzione: la chiusura provoca la perdita delle modifiche pendenti. Sei sicuro di voler chiudere la finestra?", caption:="Conferma chiusura finestra", icon:=MessageBoxIcon.Warning, buttons:=MessageBoxButtons.YesNo)
            If risultatoChiusura = vbYes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub UGrdAnaAvv_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles UGrdAnaParti.DoubleClickRow
        Dim intIdParte As Integer
        Dim operazioni As New Operazioni
        Dim parte As New Parte

        If Not IsNothing(UGrdAnaParti.ActiveRow) Then
            intIdParte = UGrdAnaParti.ActiveRow.Cells("IdParte").Value
            parte = operazioni.CaricaRigaDatoId(Of Parte)(intIdParte)
            CompilaCampiDatiDettaglio(parte)
        End If

    End Sub

    Private Sub UPicBoxInserisciRiga_Click(sender As Object, e As EventArgs) Handles UPicBoxInserisciRiga.Click
        If bInseritoNuovoUtente Or bModificatoUtente Then
            'se ci sono modifiche nei dati di dettaglio do' un messaggio di avvertimento che verranno persi i dati

        End If
        'Svuoto tutti i campi di dettaglio
        SvuotaCampiDettaglio()
        bInseritoNuovoUtente = True
        bModificatoUtente = False
        UGrdAnaParti.ActiveRow = Nothing
    End Sub

    Private Sub UPicBoxEliminaRiga_Click(sender As Object, e As EventArgs) Handles UPicBoxEliminaRiga.Click
        Dim intIdParte As Integer
        Dim operazioni As New Operazioni

        If Not IsNothing(UGrdAnaParti.ActiveRow) Then
            intIdParte = UGrdAnaParti.ActiveRow.Cells("IdParte").Value
            operazioni.Elimina(Of Parte)(intIdParte)

            'aggiorno la griglia
            UGrdAnaParti.DataSource = operazioni.CaricaTutti(Of Parte)()

        End If

    End Sub

    Private Sub UPicBoxRicercaDati_Click(sender As Object, e As EventArgs) Handles UPicBoxRicercaDati.Click

        'If Trim(LSUTxtNominativoRicerca.ValoreCasellaTesto <> "") Or Trim(LSUTxtIndirizzoStudioRicerca.ValoreCasellaTesto) <> "" Then
        '    Dim operazioni As New Operazioni
        '    Dim listaAvvocati As New List(Of Avvocato)
        '    Dim listaParametri As New Dictionary(Of String, String)

        '    'Creo la lista dei fitri di ricerca
        '    If Trim(LSUTxtNominativoRicerca.ValoreCasellaTesto <> "") Then
        '        listaParametri.Add("Nominativo", LSUTxtNominativoRicerca.ValoreCasellaTesto)
        '    End If
        '    If Trim(LSUTxtIndirizzoStudioRicerca.ValoreCasellaTesto <> "") Then
        '        listaParametri.Add("IndirizzoStudio", LSUTxtIndirizzoStudioRicerca.ValoreCasellaTesto)
        '    End If

        '    listaAvvocati = operazioni.CaricaDatiFiltrati(Of Avvocato)(listaParametri)
        '    UGrdAnaParti.DataSource = listaAvvocati

        'End If

    End Sub

    Private Sub UPicBoxSalvaDati_Click(sender As Object, e As EventArgs) Handles UPicBoxSalvaDati.Click
        Dim intIdParte As Integer = 0
        Dim operazioni As New Operazioni
        Dim parte As New Parte
        Dim pers As New Persona

        If bInseritoNuovoUtente Then

            'Ricavo il nuovo idAvvocato da aggiungere
            intIdParte = operazioni.RicavaMaxId(Of Parte)

            'Ricavo dai valori dei controlli tutti i nuovi dati da aggiungere e creo la nuova entità avvocato da aggiungere
            RicavaDatiDettaglioInseriti(parte)

            operazioni.Aggiungi(Of Parte)(intIdParte, parte)

            bInseritoNuovoUtente = False

        End If

        If bModificatoUtente Then

            intIdParte = UGrdAnaParti.ActiveRow.Cells("IdParte").Value

            'Ricavo dai valori dei controlli tutti i nuovi dati da aggiungere e creo la nuova entità avvocato da aggiungere
            RicavaDatiDettaglioInseriti(parte)

            operazioni.Aggiorna(Of Parte)(intIdParte, parte)

            bModificatoUtente = False

        End If

        'aggiorno la griglia
        UGrdAnaParti.DataSource = operazioni.CaricaTutti(Of Avvocato)()

    End Sub

    Private Sub UltraPicBoxChiudiFinestra_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxChiudiFinestra.MouseHover
        UPicBoxChiudiFinestra.Image = ImageListAnaUtenti.Images(1)
    End Sub

    Private Sub UltraPicBoxChiudiFinestra_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxChiudiFinestra.MouseLeave
        UPicBoxChiudiFinestra.Image = ImageListAnaUtenti.Images(0)
    End Sub

    Private Sub UPicBoxSalvaDati_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxSalvaDati.MouseHover
        UPicBoxSalvaDati.Image = ImageListAnaUtenti.Images(3)
    End Sub

    Private Sub UPicBoxSalvaDati_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxSalvaDati.MouseLeave
        UPicBoxSalvaDati.Image = ImageListAnaUtenti.Images(2)
    End Sub

    Private Sub UPicBoxEliminaRiga_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxEliminaRiga.MouseHover
        UPicBoxEliminaRiga.Image = ImageListAnaUtenti.Images(5)
    End Sub

    Private Sub UPicBoxEliminaRiga_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxEliminaRiga.MouseLeave
        UPicBoxEliminaRiga.Image = ImageListAnaUtenti.Images(4)
    End Sub

    Private Sub UPicBoxInserisciRiga_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxInserisciRiga.MouseHover
        UPicBoxInserisciRiga.Image = ImageListAnaUtenti.Images(7)
    End Sub

    Private Sub UPicBoxInserisciRiga_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxInserisciRiga.MouseLeave
        UPicBoxInserisciRiga.Image = ImageListAnaUtenti.Images(6)
    End Sub

    Private Sub UPicBoxRicercaDati_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxRicercaDati.MouseHover
        UPicBoxRicercaDati.Image = ImageListAnaUtenti.Images(9)
    End Sub

    Private Sub UPicBoxRicercaDati_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxRicercaDati.MouseLeave
        UPicBoxRicercaDati.Image = ImageListAnaUtenti.Images(8)
    End Sub

    Private Sub LSUTxtEmailPEC_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs)

        'If LSUTxtEmailPEC.ValoreCasellaTesto <> "" Then
        '    bModificatoAvv = True
        'End If

    End Sub

End Class