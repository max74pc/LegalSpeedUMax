Imports LSDBManager.LSDBContextNS
Imports LSDataModel.LSDataModelNS
Imports LSCommon.LSCommonNS

Public Class FrmAnaAvvocati

    Dim bDatoDettaglioCambiato As Boolean = False
    Dim bInseritoNuovoAvv As Boolean = False
    Dim bModificatoAvv As Boolean = False

    Private mIdAvvocato As Integer
    Private mNomeCompletoAvvocato As String
    Private mVisualizzaDaAltraFinestra As Boolean

    Public Property _VisualizzaDaAltraFinestra() As Boolean
        Get
            Return mVisualizzaDaAltraFinestra
        End Get
        Set(ByVal value As Boolean)
            mVisualizzaDaAltraFinestra = value
        End Set
    End Property

    Public Property _IdAvvocato() As Integer
        Get
            Return mIdAvvocato
        End Get
        Set(ByVal value As Integer)
            mIdAvvocato = value
        End Set
    End Property

    Public Property _NomeCompletoAvvocato() As String
        Get
            Return mNomeCompletoAvvocato
        End Get
        Set(ByVal value As String)
            mNomeCompletoAvvocato = value
        End Set
    End Property

    Public Sub InizializzaControlli()

        Dim listaAvvocati As New List(Of Avvocato)
        Dim listaProvince As New List(Of Provincia)
        Dim listaNazioni As New List(Of Nazione)
        Dim listaForiCompetenza As New List(Of EnteGiuridico)
        Dim listaParametriForo As New Dictionary(Of String, String)

        Try
            UBtnConfermaAvvTrovato.Visible = mVisualizzaDaAltraFinestra

            UltraDockAnaAvv.DockAreas(2).Size = New System.Drawing.Size(Me.Width, Me.Height - 81)
            UltraDockAnaAvv.DockAreas(0).Size = New System.Drawing.Size(Me.Width, 81)

            listaAvvocati = Operazioni.CaricaTutti(Of Avvocato)()
            UGrdAnaAvv.DataSource = listaAvvocati

            LSUDataNascita.SvuotaDataOra()
            LSUDataIscrizAlboAvv.SvuotaDataOra()
            LSUDataIscrizAlboCass.SvuotaDataOra()

            LSUCboEditTipoPersona.PulisciElementi()

            LSUCboEditTipoPersona.AggiungiElemento(1, "Persona Fisica")
            LSUCboEditTipoPersona.AggiungiElemento(2, "Persona Giuridica")

            LSUCboEditSesso.PulisciElementi()
            LSUCboEditSesso.AggiungiElemento(1, "Femmina")
            LSUCboEditSesso.AggiungiElemento(2, "Maschio")

            'Carico tutte le province nei menu a tendina delle province di nascita e di residenza
            listaProvince = Operazioni.CaricaTutti(Of Provincia)

            For Each prov In listaProvince
                LSUCboEditProvNascita.AggiungiElemento(prov.IdProvincia, prov.DenominazioneProvincia & " (" & prov.SiglaAutoProvincia & ")")
                LSUCboEditProvResidenza.AggiungiElemento(prov.IdProvincia, prov.DenominazioneProvincia & " (" & prov.SiglaAutoProvincia & ")")
            Next

            'Carico tutte le nazioni nei menu a tendina degli stati di nascita e di residenza
            LSUCboEditStatoNascita.AggiungiElemento(0, "ITALIA")
            LSUCboEditStatoResidenza.AggiungiElemento(0, "ITALIA")

            listaNazioni = operazioni.CaricaTutti(Of Nazione)

            For Each nazione In listaNazioni
                LSUCboEditStatoNascita.AggiungiElemento(nazione.IdNazione, nazione.DenominazioneNazione)
                LSUCboEditStatoResidenza.AggiungiElemento(nazione.IdNazione, nazione.DenominazioneNazione)
            Next

            'Carico tutti i fori di competenza dalla tabella EntiGiuridici filtrata
            listaParametriForo.Add("ForoCompetenza", "Tribunale Ordinario")
            listaForiCompetenza = operazioni.CaricaDatiFiltrati(Of EnteGiuridico)(listaParametriForo)

            For Each foro In listaForiCompetenza
                LSUCboEditForoAppartenenza.AggiungiElemento(foro.IdEnteGiuridico, foro.DenominazioneEnte)
            Next

            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(0).Hidden = True
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(1).Header.Caption = "E-Mail PEC"
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(2).Header.Caption = "Foro di Appartenenza"
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(3).Hidden = True
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(4).Hidden = True
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(5).Hidden = True
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(6).Hidden = True
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(7).Header.Caption = "Num. Cellulare"
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(8).Hidden = True
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(9).Hidden = True
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(10).Hidden = True
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(11).Hidden = True
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(12).Hidden = True
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(13).Hidden = True
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(14).Hidden = True
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(15).Hidden = True
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(16).Hidden = True
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(17).Hidden = True
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(18).Hidden = True
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(19).Hidden = True
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(20).Hidden = True
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(21).Hidden = True
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(22).Hidden = True
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(23).Hidden = True
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(24).Hidden = True
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(25).Hidden = True
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(26).Hidden = True
            UGrdAnaAvv.DisplayLayout.Bands(0).Columns(27).Header.Caption = "Nome Completo"

        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: Sub InizializzaControlli. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Public Sub SvuotaCampiDettaglio()
        Try
            LSUTxtNomeCompleto.ValoreCasellaTesto = ""
            LSUTxtCodiceFiscale.ValoreCasellaTesto = ""
            LSUTxtPartitaIVA.ValoreCasellaTesto = ""
            LSUDataNascita.SvuotaDataOra()
            LSUCboEditLuogoNascita.ValoreMenuTendina = ""
            LSUCboEditProvNascita.ValoreMenuTendina = ""
            LSUCboEditStatoNascita.ValoreMenuTendina = ""
            LSUTxtInidirizzoResidenza.ValoreCasellaTesto = ""
            LSUCboEditLuogoResidenza.ValoreMenuTendina = ""
            LSUCboEditProvResidenza.ValoreMenuTendina = ""
            LSUCboEditStatoResidenza.ValoreMenuTendina = ""
            LSUTxtNazionalita.ValoreCasellaTesto = ""
            LSUCboEditSesso.ValoreMenuTendina = ""
            LSUTxtEmail.ValoreCasellaTesto = ""
            LSUTxtEmailPEC.ValoreCasellaTesto = ""
            LSUCboEditForoAppartenenza.ValoreMenuTendina = ""
            LSUDataIscrizAlboAvv.SvuotaDataOra()
            LSUDataIscrizAlboCass.SvuotaDataOra()
            LSUTxtNumTelStudio.ValoreCasellaTesto = ""
            LSUTxtNumFaxStudio.ValoreCasellaTesto = ""
            LSUTxtCellulare.ValoreCasellaTesto = ""
            LSUCboEditTipoPersona.ValoreMenuTendina = ""
            LSUTxtIndirizzoStudio.ValoreCasellaTesto = ""

        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: Sub SvuotaCampiDettaglio. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Public Sub CompilaCampiDatiDettaglio(ByVal avv As Avvocato)
        Try
            LSUTxtNomeCompleto.ValoreCasellaTesto = avv.NomeCompleto
            LSUTxtCodiceFiscale.ValoreCasellaTesto = avv.CodiceFiscale
            LSUTxtPartitaIVA.ValoreCasellaTesto = avv.PartitaIVA
            LSUDataNascita.ValoreDataOraSel = avv.DataDiNascita
            LSUCboEditLuogoNascita.ValoreMenuTendina = avv.LuogoDiNascita
            LSUCboEditProvNascita.ValoreMenuTendina = avv.ProvinciaDiNascita
            LSUCboEditStatoNascita.ValoreMenuTendina = avv.StatoDiNascita
            LSUTxtInidirizzoResidenza.ValoreCasellaTesto = avv.IndirizzoResidenza
            LSUCboEditLuogoResidenza.ValoreMenuTendina = avv.LuogoResidenza
            LSUCboEditProvResidenza.ValoreMenuTendina = avv.ProvinciaResidenza
            LSUCboEditStatoResidenza.ValoreMenuTendina = avv.StatoResidenza
            LSUTxtNazionalita.ValoreCasellaTesto = avv.Nazionalita
            LSUCboEditSesso.ValoreMenuTendina = avv.Sesso
            LSUTxtEmail.ValoreCasellaTesto = avv.EMail
            LSUTxtEmailPEC.ValoreCasellaTesto = avv.EmailPEC
            LSUCboEditForoAppartenenza.ValoreMenuTendina = avv.ForoDiAppartenza
            LSUDataIscrizAlboAvv.ValoreDataOraSel = avv.DataIscrizioneAlboAvv
            LSUDataIscrizAlboCass.ValoreDataOraSel = avv.DataIscrizioneAlboCassazionisti
            LSUTxtNumTelStudio.ValoreCasellaTesto = avv.TelefonoStudio
            LSUTxtNumFaxStudio.ValoreCasellaTesto = avv.FaxStudio
            LSUTxtCellulare.ValoreCasellaTesto = avv.Cellulare
            LSUCboEditTipoPersona.ValoreMenuTendina = avv.TipologiaPersona
            LSUTxtIndirizzoStudio.ValoreCasellaTesto = avv.IndirizzoStudio

        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: Sub CompilaCampiDatiDettaglio. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Public Sub RicavaDatiDettaglioInseriti(ByVal avv As Avvocato)
        Dim strNomeCompleto = Split(LSUTxtNomeCompleto.ValoreCasellaTesto, " ")

        Try
            avv.Nome = strNomeCompleto(0)
            avv.Cognome = strNomeCompleto(1)
            avv.CodiceFiscale = LSUTxtCodiceFiscale.ValoreCasellaTesto
            avv.PartitaIVA = LSUTxtPartitaIVA.ValoreCasellaTesto
            avv.DataDiNascita = LSUDataNascita.ValoreDataOraSel
            avv.LuogoDiNascita = LSUCboEditLuogoNascita.ValoreMenuTendina
            avv.ProvinciaDiNascita = LSUCboEditProvNascita.ValoreMenuTendina
            avv.StatoDiNascita = LSUCboEditStatoNascita.ValoreMenuTendina
            avv.IndirizzoResidenza = LSUTxtInidirizzoResidenza.ValoreCasellaTesto
            avv.LuogoResidenza = LSUCboEditLuogoResidenza.ValoreMenuTendina
            avv.ProvinciaResidenza = LSUCboEditProvResidenza.ValoreMenuTendina
            avv.StatoResidenza = LSUCboEditStatoResidenza.ValoreMenuTendina
            avv.Nazionalita = LSUTxtNazionalita.ValoreCasellaTesto
            avv.Sesso = LSUCboEditSesso.ValoreMenuTendina
            avv.EMail = LSUTxtEmail.ValoreCasellaTesto
            avv.EmailPEC = LSUTxtEmailPEC.ValoreCasellaTesto
            avv.ForoDiAppartenza = LSUCboEditForoAppartenenza.ValoreMenuTendina
            avv.DataIscrizioneAlboAvv = LSUDataIscrizAlboAvv.ValoreDataOraSel
            avv.DataIscrizioneAlboCassazionisti = LSUDataIscrizAlboCass.ValoreDataOraSel
            avv.TelefonoStudio = LSUTxtNumTelStudio.ValoreCasellaTesto
            avv.FaxStudio = LSUTxtNumFaxStudio.ValoreCasellaTesto
            avv.Cellulare = LSUTxtCellulare.ValoreCasellaTesto
            avv.TipologiaPersona = LSUCboEditTipoPersona.ValoreMenuTendina
            avv.IndirizzoStudio = LSUTxtIndirizzoStudio.ValoreCasellaTesto

        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: Sub RicavaDatiDettaglioInseriti. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub FrmAnaAvvocati_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.WindowState = FormWindowState.Maximized

            InizializzaControlli()

        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati_Load. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UltraPicBoxChiudiFinestra_MouseClick(sender As Object, e As MouseEventArgs) Handles UPicBoxChiudiFinestra.MouseClick
        Dim risultatoChiusura As Integer
        Try
            If bDatoDettaglioCambiato = True Then
                risultatoChiusura = MessageBox.Show(text:="Attenzione: la chiusura provoca la perdita delle modifiche pendenti. Sei sicuro di voler chiudere la finestra?", caption:="Conferma chiusura finestra", icon:=MessageBoxIcon.Warning, buttons:=MessageBoxButtons.YesNo)
                If risultatoChiusura = vbYes Then
                    Me.Close()
                End If
            Else
                Me.Close()
            End If

        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: UltraPicBoxChiudiFinestra_MouseClick. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UGrdAnaAvv_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles UGrdAnaAvv.DoubleClickRow
        Dim intIdPersona As Integer
        Dim avv As New Avvocato
        Try
            If Not IsNothing(UGrdAnaAvv.ActiveRow) Then
                intIdPersona = UGrdAnaAvv.ActiveRow.Cells("IdPersona").Value
                avv = Operazioni.CaricaRigaDatoId(Of Avvocato)(intIdPersona)
                CompilaCampiDatiDettaglio(avv)
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: UGrdAnaAvv_DoubleClickRow. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxInserisciRiga_Click(sender As Object, e As EventArgs) Handles UPicBoxInserisciRiga.Click
        Try
            If bInseritoNuovoAvv Or bModificatoAvv Then
                'se ci sono modifiche nei dati di dettaglio do' un messaggio di avvertimento che verranno persi i dati

            End If
            'Svuoto tutti i campi di dettaglio
            SvuotaCampiDettaglio()
            bInseritoNuovoAvv = True
            bModificatoAvv = False
            UGrdAnaAvv.ActiveRow = Nothing
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: UPicBoxInserisciRiga_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxEliminaRiga_Click(sender As Object, e As EventArgs) Handles UPicBoxEliminaRiga.Click
        Dim intIdPersona As Integer
        Try
            If Not IsNothing(UGrdAnaAvv.ActiveRow) Then
                intIdPersona = UGrdAnaAvv.ActiveRow.Cells("IdPersona").Value
                Operazioni.Elimina(Of Avvocato)(intIdPersona)

                'aggiorno la griglia
                UGrdAnaAvv.DataSource = Operazioni.CaricaTutti(Of Avvocato)()

            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: UPicBoxEliminaRiga_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicercaDati_Click(sender As Object, e As EventArgs) Handles UPicBoxRicercaDati.Click
        Try
            If Trim(LSUTxtNominativoRicerca.ValoreCasellaTesto <> "") Or Trim(LSUTxtIndirizzoStudioRicerca.ValoreCasellaTesto) <> "" Then
                Dim listaAvvocati As New List(Of Avvocato)
                Dim listaParametri As New Dictionary(Of String, String)

                'Creo la lista dei fitri di ricerca
                If Trim(LSUTxtNominativoRicerca.ValoreCasellaTesto <> "") Then
                    listaParametri.Add("Nominativo", LSUTxtNominativoRicerca.ValoreCasellaTesto)
                End If
                If Trim(LSUTxtIndirizzoStudioRicerca.ValoreCasellaTesto <> "") Then
                    listaParametri.Add("IndirizzoStudio", LSUTxtIndirizzoStudioRicerca.ValoreCasellaTesto)
                End If

                listaAvvocati = Operazioni.CaricaDatiFiltrati(Of Avvocato)(listaParametri)
                UGrdAnaAvv.DataSource = listaAvvocati

            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: UPicBoxRicercaDati_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxSalvaDati_Click(sender As Object, e As EventArgs) Handles UPicBoxSalvaDati.Click
        Dim intIdPersona As Integer = 0
        Dim avv As New Avvocato
        Dim pers As New Persona
        Try
            If bInseritoNuovoAvv Then

                'Ricavo il nuovo IdPersona da aggiungere
                intIdPersona = Operazioni.RicavaMaxId(Of Avvocato)

                'Ricavo dai valori dei controlli tutti i nuovi dati da aggiungere e creo la nuova entità avvocato da aggiungere
                RicavaDatiDettaglioInseriti(avv)

                Operazioni.Aggiungi(Of Avvocato)(intIdPersona, avv)

            End If

            If bModificatoAvv And bInseritoNuovoAvv = False Then

                intIdPersona = UGrdAnaAvv.ActiveRow.Cells("IdPersona").Value

                'Ricavo dai valori dei controlli tutti i nuovi dati da aggiungere e creo la nuova entità avvocato da aggiungere
                RicavaDatiDettaglioInseriti(avv)

                Operazioni.Aggiorna(Of Avvocato)(intIdPersona, avv)

                bModificatoAvv = False

            End If

            bInseritoNuovoAvv = False

            'aggiorno la griglia
            UGrdAnaAvv.DataSource = Operazioni.CaricaTutti(Of Avvocato)()
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: UPicBoxSalvaDati_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UltraPicBoxChiudiFinestra_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxChiudiFinestra.MouseHover
        Try
            UPicBoxChiudiFinestra.Image = ImageListAnaAvv.Images(1)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: UltraPicBoxChiudiFinestra_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UltraPicBoxChiudiFinestra_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxChiudiFinestra.MouseLeave
        Try
            UPicBoxChiudiFinestra.Image = ImageListAnaAvv.Images(0)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: UltraPicBoxChiudiFinestra_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxSalvaDati_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxSalvaDati.MouseHover
        Try
            UPicBoxSalvaDati.Image = ImageListAnaAvv.Images(3)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: UPicBoxSalvaDati_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxSalvaDati_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxSalvaDati.MouseLeave
        Try
            UPicBoxSalvaDati.Image = ImageListAnaAvv.Images(2)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: UPicBoxSalvaDati_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxEliminaRiga_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxEliminaRiga.MouseHover
        Try
            UPicBoxEliminaRiga.Image = ImageListAnaAvv.Images(5)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: UPicBoxEliminaRiga_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxEliminaRiga_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxEliminaRiga.MouseLeave
        Try
            UPicBoxEliminaRiga.Image = ImageListAnaAvv.Images(4)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: UPicBoxEliminaRiga_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxInserisciRiga_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxInserisciRiga.MouseHover
        Try
            UPicBoxInserisciRiga.Image = ImageListAnaAvv.Images(7)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: UPicBoxInserisciRiga_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxInserisciRiga_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxInserisciRiga.MouseLeave
        Try
            UPicBoxInserisciRiga.Image = ImageListAnaAvv.Images(6)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: UPicBoxInserisciRiga_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicercaDati_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxRicercaDati.MouseHover
        Try
            UPicBoxRicercaDati.Image = ImageListAnaAvv.Images(9)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: UPicBoxRicercaDati_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicercaDati_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxRicercaDati.MouseLeave
        Try
            UPicBoxRicercaDati.Image = ImageListAnaAvv.Images(8)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: UPicBoxRicercaDati_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditTipoPersona_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditTipoPersona.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditTipoPersona.ValoreMenuTendina <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: LSUCboEditTipoPersona_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtNomeCompleto_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNomeCompleto.ValoreCasellaTestoCambiato
        Try
            If LSUTxtNomeCompleto.ValoreCasellaTesto <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: LSUTxtNomeCompleto_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUDataNascita_ValoreDataOraSelCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUDataNascita.ValoreDataOraSelCambiato
        Try
            If LSUDataNascita.ValoreDataOraSel.ToString <> "01/01/1753 00:00:00" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: LSUDataNascita_ValoreDataOraSelCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditSesso_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditSesso.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditSesso.ValoreMenuTendina <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: LSUCboEditSesso_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditStatoNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditStatoNascita.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditStatoNascita.ValoreMenuTendina <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: LSUCboEditStatoNascita_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtCodiceFiscale_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtCodiceFiscale.ValoreCasellaTestoCambiato
        Try
            If LSUTxtCodiceFiscale.ValoreCasellaTesto <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: LSUTxtCodiceFiscale_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtPartitaIVA_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtPartitaIVA.ValoreCasellaTestoCambiato
        Try
            If LSUTxtPartitaIVA.ValoreCasellaTesto <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: LSUTxtPartitaIVA_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditStatoResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditStatoResidenza.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditStatoResidenza.ValoreMenuTendina <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: LSUCboEditStatoResidenza_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditProvResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditProvResidenza.ValoreMenuTendinaCambiato

        Dim listaComuni As New List(Of ComuneItaliano)
        Dim listaParametri As New Dictionary(Of String, String)
        Dim strSiglaAutoSel As String = ""

        Try
            If LSUCboEditProvResidenza.ValoreMenuTendina.Trim() <> "" Then

                bModificatoAvv = True

                'Carico tutti i comuni relativi alla provincia selezionata
                strSiglaAutoSel = Mid(LSUCboEditProvResidenza.ValoreMenuTendina, LSUCboEditProvResidenza.ValoreMenuTendina.Length - 2, 2)
                listaParametri.Add("SiglaAutoProvincia", strSiglaAutoSel)
                listaComuni = Operazioni.CaricaDatiFiltrati(Of ComuneItaliano)(listaParametri)
                LSUCboEditLuogoResidenza.PulisciElementi()

                For Each comune In listaComuni
                    LSUCboEditLuogoResidenza.AggiungiElemento(comune.IdComune, comune.DenominazioneComune)
                Next

            End If

            If LSUCboEditProvResidenza.ValoreMenuTendina <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: LSUCboEditProvResidenza_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditLuogoResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditLuogoResidenza.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditLuogoResidenza.ValoreMenuTendina <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: LSUCboEditLuogoResidenza_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtInidirizzoResidenza_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtInidirizzoResidenza.ValoreCasellaTestoCambiato
        Try
            If LSUTxtInidirizzoResidenza.ValoreCasellaTesto <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: LSUTxtInidirizzoResidenza_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtNazionalita_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNazionalita.ValoreCasellaTestoCambiato
        Try
            If LSUTxtNazionalita.ValoreCasellaTesto <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: LSUTxtNazionalita_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtEmail_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtEmail.ValoreCasellaTestoCambiato
        Try
            If LSUTxtEmail.ValoreCasellaTesto <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: LSUTxtEmail_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtEmailPEC_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtEmailPEC.ValoreCasellaTestoCambiato
        Try
            If LSUTxtEmailPEC.ValoreCasellaTesto <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: LSUTxtEmailPEC_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUDataIscrizAlboAvv_ValoreDataOraSelCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUDataIscrizAlboAvv.ValoreDataOraSelCambiato
        Try
            If LSUDataIscrizAlboAvv.ValoreDataOraSel.ToString <> "01/01/1753 00:00:00" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: LSUDataIscrizAlboAvv_ValoreDataOraSelCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUDataIscrizAlboCass_ValoreDataOraSelCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUDataIscrizAlboCass.ValoreDataOraSelCambiato
        Try
            If LSUDataIscrizAlboCass.ValoreDataOraSel.ToString <> "01/01/1753 00:00:00" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: LSUDataIscrizAlboCass_ValoreDataOraSelCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditForoAppartenenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditForoAppartenenza.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditForoAppartenenza.ValoreMenuTendina <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: LSUCboEditForoAppartenenza_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtNumTelStudio_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNumTelStudio.ValoreCasellaTestoCambiato
        Try
            If LSUTxtNumTelStudio.ValoreCasellaTesto <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: LSUTxtNumTelStudio_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtCellulare_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtCellulare.ValoreCasellaTestoCambiato
        Try
            If LSUTxtNumTelStudio.ValoreCasellaTesto <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: LSUTxtCellulare_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtNumFaxStudio_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNumFaxStudio.ValoreCasellaTestoCambiato
        Try
            If LSUTxtNumFaxStudio.ValoreCasellaTesto <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: LSUTxtNumFaxStudio_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditProvNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditProvNascita.ValoreMenuTendinaCambiato
        Dim listaComuni As New List(Of ComuneItaliano)
        Dim listaParametri As New Dictionary(Of String, String)
        Dim strSiglaAutoSel As String = ""

        Try
            If LSUCboEditProvNascita.ValoreMenuTendina.Trim() <> "" Then

                bModificatoAvv = True

                'Carico tutti i comuni relativi alla provincia selezionata
                strSiglaAutoSel = Mid(LSUCboEditProvNascita.ValoreMenuTendina, LSUCboEditProvNascita.ValoreMenuTendina.Length - 2, 2)
                listaParametri.Add("SiglaAutoProvincia", strSiglaAutoSel)
                listaComuni = Operazioni.CaricaDatiFiltrati(Of ComuneItaliano)(listaParametri)
                LSUCboEditLuogoNascita.PulisciElementi()

                For Each comune In listaComuni
                    LSUCboEditLuogoNascita.AggiungiElemento(comune.IdComune, comune.DenominazioneComune)
                Next

            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: LSUCboEditProvNascita_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditLuogoNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditLuogoNascita.ValoreMenuTendinaCambiato
        Dim listaComuni As New List(Of ComuneItaliano)
        Dim listaParametri As New Dictionary(Of String, String)
        Dim sCodiceCatasto As String = ""
        Try
            If LSUCboEditLuogoNascita.ValoreMenuTendina <> "" Then
                bModificatoAvv = True
            End If

            If (LSUTxtCodiceFiscale.ValoreCasellaTesto.Trim = "" Or LSUTxtCodiceFiscale.ValoreCasellaTesto.Length = 16) And
            LSUCboEditLuogoNascita.ValoreMenuTendina <> "" And
            LSUCboEditProvNascita.ValoreMenuTendina <> "" And
            LSUCboEditStatoNascita.ValoreMenuTendina <> "" And
            LSUCboEditSesso.ValoreMenuTendina <> "" And
            LSUDataNascita.ValoreDataOraSel.ToString <> "" And
            LSUTxtNomeCompleto.ValoreCasellaTesto <> "" Then

                'Ricavo il codice catastale del comune
                listaParametri.Add("CodiceCatasto", LSUCboEditLuogoNascita.ValoreMenuTendina)
                listaComuni = Operazioni.CaricaDatiFiltrati(Of ComuneItaliano)(listaParametri)

                For Each comune In listaComuni
                    sCodiceCatasto = comune.CodiceCatastaleComune
                Next
                ClsComune.CalcolaCodiceFiscale(LSUTxtNomeCompleto.ValoreCasellaTesto, LSUDataNascita.ValoreDataOraSel,
                                                LSUCboEditSesso.ValoreMenuTendina, LSUCboEditLuogoNascita.ValoreMenuTendina, sCodiceCatasto)
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: LSUCboEditLuogoNascita_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtIndirizzoStudio_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtIndirizzoStudio.ValoreCasellaTestoCambiato
        Try
            If LSUTxtIndirizzoStudio.ValoreCasellaTesto <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: LSUTxtIndirizzoStudio_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UBtnConfermaAvvTrovato_Click(sender As Object, e As EventArgs) Handles UBtnConfermaAvvTrovato.Click
        Try
            mNomeCompletoAvvocato = LSUTxtNomeCompleto.ValoreCasellaTesto
            mIdAvvocato = UGrdAnaAvv.ActiveRow.Cells("IdPersona").Value
            Me.Close()
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaAvvocati: UBtnConfermaAvvTrovato_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

End Class