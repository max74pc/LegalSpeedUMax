Imports LSDBManager.LSDBContextNS
Imports LSDataModel.LSDataModelNS
Imports LSCommon.LSCommonNS

Public Class UsrCtrlAnaPersone
    ReadOnly bDatoDettaglioCambiato As Boolean = False
    Dim bInseritaNuovaPers As Boolean = False
    Dim bModificataPers As Boolean = False

    Private mIdPersona As Integer
    Private mDenominazionePersona As String
    Private mVisualizzaPersDaAltraFinestra As Boolean

    Public Property VisualizzaPersDaAltraFinestra() As Boolean
        Get
            Return mVisualizzaPersDaAltraFinestra
        End Get
        Set(ByVal value As Boolean)
            mVisualizzaPersDaAltraFinestra = value
        End Set
    End Property

    Public Property IdPersona() As Integer
        Get
            Return mIdPersona
        End Get
        Set(ByVal value As Integer)
            mIdPersona = value
        End Set
    End Property

    Public Property DenominazionePersona() As String
        Get
            Return mDenominazionePersona
        End Get
        Set(ByVal value As String)
            mDenominazionePersona = value
        End Set
    End Property

    Public Sub InizializzaControlli()

        Try
            UBtnConfermaPersonaTrovata.Visible = mVisualizzaPersDaAltraFinestra

            Dim listaPersone As List(Of Persona) = Operazioni.CaricaTutti(Of Persona)()
            UGrdAnaPersone.DataSource = listaPersone

            LSUDataNascita.SvuotaDataOra()

            LSUCboEditTipoPersona.PulisciElementi()

            LSUCboEditTipoPersona.AggiungiElemento(1, "Persona Fisica")
            LSUCboEditTipoPersona.AggiungiElemento(2, "Persona Giuridica")

            LSUCboEditSesso.PulisciElementi()
            LSUCboEditSesso.AggiungiElemento(1, "Femmina")
            LSUCboEditSesso.AggiungiElemento(2, "Maschio")

            'Carico tutte le province nei menu a tendina delle province di nascita e di residenza
            Dim listaProvince As List(Of Provincia) = Operazioni.CaricaTutti(Of Provincia)

            For Each prov In listaProvince
                LSUCboEditProvNascita.AggiungiElemento(prov.IdProvincia, prov.DenominazioneProvincia & " (" & prov.SiglaAutoProvincia & ")")
                LSUCboEditProvResidenza.AggiungiElemento(prov.IdProvincia, prov.DenominazioneProvincia & " (" & prov.SiglaAutoProvincia & ")")
            Next

            'Carico tutte le nazioni nei menu a tendina degli stati di nascita e di residenza
            LSUCboEditStatoNascita.AggiungiElemento(0, "ITALIA")
            LSUCboEditStatoResidenza.AggiungiElemento(0, "ITALIA")

            Dim listaNazioni As List(Of Nazione) = Operazioni.CaricaTutti(Of Nazione)

            For Each nazione In listaNazioni
                LSUCboEditStatoNascita.AggiungiElemento(nazione.IdNazione, nazione.DenominazioneNazione)
                LSUCboEditStatoResidenza.AggiungiElemento(nazione.IdNazione, nazione.DenominazioneNazione)
            Next

            'UGrdAnaParti.DisplayLayout.Bands(0).Columns(0).Hidden = True
            'UGrdAnaParti.DisplayLayout.Bands(0).Columns(1).Hidden = True
            'UGrdAnaParti.DisplayLayout.Bands(0).Columns(2).Header.Caption = "E-Mail PEC"
            'UGrdAnaParti.DisplayLayout.Bands(0).Columns(3).Header.Caption = "Foro di Appartenenza"
            'UGrdAnaParti.DisplayLayout.Bands(0).Columns(4).Hidden = True
            'UGrdAnaParti.DisplayLayout.Bands(0).Columns(5).Hidden = True
            'UGrdAnaParti.DisplayLayout.Bands(0).Columns(6).Hidden = True
            'UGrdAnaParti.DisplayLayout.Bands(0).Columns(7).Hidden = True
            'UGrdAnaParti.DisplayLayout.Bands(0).Columns(8).Header.Caption = "Num. Cellulare"
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: Sub InizializzaControlli. ", True, ClsComune.GlbStrUserNameLS, "", True)
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
            LSUCboEditTipoPersona.ValoreMenuTendina = ""
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: Sub SvuotaCampiDettaglio. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Public Sub CompilaCampiDatiDettaglio(ByVal pers As Persona)
        Try
            LSUTxtNomeCompleto.ValoreCasellaTesto = pers.NomeCompleto
            LSUTxtCodiceFiscale.ValoreCasellaTesto = pers.CodiceFiscale
            LSUTxtPartitaIVA.ValoreCasellaTesto = pers.PartitaIVA
            LSUDataNascita.ValoreDataOraSel = pers.DataDiNascita
            LSUCboEditLuogoNascita.ValoreMenuTendina = pers.LuogoDiNascita
            LSUCboEditProvNascita.ValoreMenuTendina = pers.ProvinciaDiNascita
            LSUCboEditStatoNascita.ValoreMenuTendina = pers.StatoDiNascita
            LSUTxtInidirizzoResidenza.ValoreCasellaTesto = pers.IndirizzoResidenza
            LSUCboEditLuogoResidenza.ValoreMenuTendina = pers.LuogoResidenza
            LSUCboEditProvResidenza.ValoreMenuTendina = pers.ProvinciaResidenza
            LSUCboEditStatoResidenza.ValoreMenuTendina = pers.StatoResidenza
            LSUTxtNazionalita.ValoreCasellaTesto = pers.Nazionalita
            LSUCboEditSesso.ValoreMenuTendina = pers.Sesso
            LSUCboEditTipoPersona.ValoreMenuTendina = pers.TipologiaPersona
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: Sub CompilaCampiDatiDettaglio. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Public Sub RicavaDatiDettaglioInseriti(ByVal pers As Persona)
        Dim strNomeCompleto = Split(LSUTxtNomeCompleto.ValoreCasellaTesto, " ")
        Try
            pers.Nome = strNomeCompleto(0)
            pers.Cognome = strNomeCompleto(1)
            pers.CodiceFiscale = LSUTxtCodiceFiscale.ValoreCasellaTesto
            pers.PartitaIVA = LSUTxtPartitaIVA.ValoreCasellaTesto
            pers.DataDiNascita = LSUDataNascita.ValoreDataOraSel
            pers.LuogoDiNascita = LSUCboEditLuogoNascita.ValoreMenuTendina
            pers.ProvinciaDiNascita = LSUCboEditProvNascita.ValoreMenuTendina
            pers.StatoDiNascita = LSUCboEditStatoNascita.ValoreMenuTendina
            pers.IndirizzoResidenza = LSUTxtInidirizzoResidenza.ValoreCasellaTesto
            pers.LuogoResidenza = LSUCboEditLuogoResidenza.ValoreMenuTendina
            pers.ProvinciaResidenza = LSUCboEditProvResidenza.ValoreMenuTendina
            pers.StatoResidenza = LSUCboEditStatoResidenza.ValoreMenuTendina
            pers.Nazionalita = LSUTxtNazionalita.ValoreCasellaTesto
            pers.Sesso = LSUCboEditSesso.ValoreMenuTendina
            pers.TipologiaPersona = LSUCboEditTipoPersona.ValoreMenuTendina
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: Sub RicavaDatiDettaglioInseriti. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UsrCtrlAnaPersone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            InizializzaControlli()
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone_Load. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxChiudiFinestra_MouseHover(sender As Object, e As EventArgs) Handles PicBoxChiudiFinestra.MouseHover
        Try
            PicBoxChiudiFinestra.Image = ImageListAnaPersone.Images(1)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: PicBoxChiudiFinestra_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxChiudiFinestra_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxChiudiFinestra.MouseLeave
        Try
            PicBoxChiudiFinestra.Image = ImageListAnaPersone.Images(0)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: PicBoxChiudiFinestra_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxSalvaDati_MouseHover(sender As Object, e As EventArgs) Handles PicBoxSalvaDati.MouseHover
        Try
            PicBoxSalvaDati.Image = ImageListAnaPersone.Images(3)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: PicBoxSalvaDati_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxSalvaDati_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxSalvaDati.MouseLeave
        Try
            PicBoxSalvaDati.Image = ImageListAnaPersone.Images(2)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: PicBoxSalvaDati_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxEliminaRiga_MouseHover(sender As Object, e As EventArgs) Handles PicBoxEliminaRiga.MouseHover
        Try
            PicBoxEliminaRiga.Image = ImageListAnaPersone.Images(5)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: PicBoxEliminaRiga_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxEliminaRiga_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxEliminaRiga.MouseLeave
        Try
            PicBoxEliminaRiga.Image = ImageListAnaPersone.Images(4)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: PicBoxEliminaRiga_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxInserisciRiga_MouseHover(sender As Object, e As EventArgs) Handles PicBoxInserisciRiga.MouseHover
        Try
            PicBoxInserisciRiga.Image = ImageListAnaPersone.Images(7)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: PicBoxInserisciRiga_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxInserisciRiga_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxInserisciRiga.MouseLeave
        Try
            PicBoxInserisciRiga.Image = ImageListAnaPersone.Images(6)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: PicBoxInserisciRiga_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxRicercaDati_MouseHover(sender As Object, e As EventArgs) Handles PicBoxRicercaDati.MouseHover
        Try
            PicBoxRicercaDati.Image = ImageListAnaPersone.Images(9)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: PicBoxRicercaDati_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxRicercaDati_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxRicercaDati.MouseLeave
        Try
            PicBoxRicercaDati.Image = ImageListAnaPersone.Images(8)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: PicBoxRicercaDati_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxRicercaDati_MouseClick(sender As Object, e As MouseEventArgs) Handles PicBoxRicercaDati.MouseClick
        Dim risultatoChiusura As Integer
        Try
            If bDatoDettaglioCambiato = True Then
                risultatoChiusura = MessageBox.Show(text:="Attenzione: la chiusura provoca la perdita delle modifiche pendenti. Sei sicuro di voler chiudere la finestra?", caption:="Conferma chiusura finestra", icon:=MessageBoxIcon.Warning, buttons:=MessageBoxButtons.YesNo)
                If risultatoChiusura = vbYes Then
                    Dispose()
                End If
            Else
                Dispose()
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: PicBoxRicercaDati_MouseClick. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxSalvaDati_Click(sender As Object, e As EventArgs) Handles PicBoxSalvaDati.Click
        Dim pers As New Persona
        Try
            If bInseritaNuovaPers Then

                'Ricavo il nuovo idAvvocato da aggiungere
                Dim intIdPersona As Integer = Operazioni.RicavaMaxId(Of Persona)

                'Ricavo dai valori dei controlli tutti i nuovi dati da aggiungere e creo la nuova entità avvocato da aggiungere
                RicavaDatiDettaglioInseriti(pers)

                Operazioni.Aggiungi(Of Persona)(pers)

            End If

            If bModificataPers And bInseritaNuovaPers = False Then

                Dim intIdPersona As Integer = UGrdAnaPersone.ActiveRow.Cells("IdPersona").Value

                'Ricavo dai valori dei controlli tutti i nuovi dati da aggiungere e creo la nuova entità avvocato da aggiungere
                RicavaDatiDettaglioInseriti(pers)

                Operazioni.Aggiorna(Of Persona)(intIdPersona, pers)

                bModificataPers = False

            End If

            bInseritaNuovaPers = False

            'aggiorno la griglia
            UGrdAnaPersone.DataSource = Operazioni.CaricaTutti(Of Persona)()
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: PicBoxSalvaDati_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxEliminaRiga_Click(sender As Object, e As EventArgs) Handles PicBoxEliminaRiga.Click
        Dim intIdPersona As Integer
        Try
            If Not IsNothing(UGrdAnaPersone.ActiveRow) Then
                intIdPersona = UGrdAnaPersone.ActiveRow.Cells("IdPersona").Value
                Operazioni.Elimina(Of Persona)(intIdPersona)

                'aggiorno la griglia
                UGrdAnaPersone.DataSource = Operazioni.CaricaTutti(Of Persona)()

            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: PicBoxEliminaRiga_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxInserisciRiga_Click(sender As Object, e As EventArgs) Handles PicBoxInserisciRiga.Click
        Try
            If bInseritaNuovaPers Or bModificataPers Then
                'se ci sono modifiche nei dati di dettaglio do' un messaggio di avvertimento che verranno persi i dati

            End If
            'Svuoto tutti i campi di dettaglio
            SvuotaCampiDettaglio()
            bInseritaNuovaPers = True
            bModificataPers = False
            UGrdAnaPersone.ActiveRow = Nothing
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: PicBoxInserisciRiga_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxRicercaDati_Click(sender As Object, e As EventArgs) Handles PicBoxRicercaDati.Click
        Try
            'If Trim(LSUTxtNominativoRicerca.ValoreCasellaTesto <> "") Or Trim(LSUTxtIndirizzoStudioRicerca.ValoreCasellaTesto) <> "" Then
            '    Dim listaAvvocati As New List(Of Avvocato)
            '    Dim listaParametri As New Dictionary(Of String, String)

            '    'Creo la lista dei fitri di ricerca
            '    If Trim(LSUTxtNominativoRicerca.ValoreCasellaTesto <> "") Then
            '        listaParametri.Add("Nominativo", LSUTxtNominativoRicerca.ValoreCasellaTesto)
            '    End If
            '    If Trim(LSUTxtIndirizzoStudioRicerca.ValoreCasellaTesto <> "") Then
            '        listaParametri.Add("IndirizzoStudio", LSUTxtIndirizzoStudioRicerca.ValoreCasellaTesto)
            '    End If

            '    listaAvvocati = Operazioni.CaricaDatiFiltrati(Of Avvocato)(listaParametri)
            '    UGrdAnaParti.DataSource = listaAvvocati

            'End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: PicBoxRicercaDati_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UBtnConfermaPersonaTrovata_Click(sender As Object, e As EventArgs) Handles UBtnConfermaPersonaTrovata.Click
        Try
            mDenominazionePersona = LSUTxtNomeCompleto.ValoreCasellaTesto
            mIdPersona = UGrdAnaPersone.ActiveRow.Cells("IdPersona").Value
            Dispose()
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: UBtnConfermaPersonaTrovata_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UGrdAnaPersone_DoubleClick(sender As Object, e As EventArgs) Handles UGrdAnaPersone.DoubleClick
        Dim intIdPersona As Integer
        Try
            If Not IsNothing(UGrdAnaPersone.ActiveRow) Then
                intIdPersona = UGrdAnaPersone.ActiveRow.Cells("IdPersona").Value
                Dim pers As Persona = Operazioni.CaricaRigaDatoId(Of Persona)(intIdPersona)
                CompilaCampiDatiDettaglio(pers)
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: UGrdAnaPersone_DoubleClick. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditTipoPersona_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditTipoPersona.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditTipoPersona.ValoreMenuTendina <> "" Then
                bModificataPers = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: LSUCboEditTipoPersona_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtNomeCompleto_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNomeCompleto.ValoreCasellaTestoCambiato
        Try
            If LSUTxtNomeCompleto.ValoreCasellaTesto <> "" Then
                bModificataPers = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: LSUTxtNomeCompleto_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUDataNascita_ValoreDataOraSelCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUDataNascita.ValoreDataOraSelCambiato
        Try
            If LSUDataNascita.ValoreDataOraSel.ToString <> "01/01/1753 00:00:00" Then
                bModificataPers = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: LSUDataNascita_ValoreDataOraSelCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditSesso_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditSesso.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditSesso.ValoreMenuTendina <> "" Then
                bModificataPers = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: LSUCboEditSesso_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditStatoNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditStatoNascita.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditStatoNascita.ValoreMenuTendina <> "" Then
                bModificataPers = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: LSUCboEditStatoNascita_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditProvNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditProvNascita.ValoreMenuTendinaCambiato
        Dim listaParametri As New Dictionary(Of String, String)
        Try
            If LSUCboEditProvNascita.ValoreMenuTendina.Trim() <> "" Then

                bModificataPers = True

                'Carico tutti i comuni relativi alla provincia selezionata
                Dim strSiglaAutoSel As String = Mid(LSUCboEditProvNascita.ValoreMenuTendina, LSUCboEditProvNascita.ValoreMenuTendina.Length - 2, 2)
                listaParametri.Add("SiglaAutoProvincia", strSiglaAutoSel)
                Dim listaComuni As List(Of ComuneItaliano) = Operazioni.CaricaDatiFiltrati(Of ComuneItaliano)(listaParametri)
                LSUCboEditLuogoNascita.PulisciElementi()

                For Each comune In listaComuni
                    LSUCboEditLuogoNascita.AggiungiElemento(comune.IdComune, comune.DenominazioneComune)
                Next

            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: LSUCboEditProvNascita_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditLuogoNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditLuogoNascita.ValoreMenuTendinaCambiato
        Dim listaParametri As New Dictionary(Of String, String)
        Dim sCodiceCatasto As String = ""
        Try
            If LSUCboEditLuogoNascita.ValoreMenuTendina <> "" Then
                bModificataPers = True
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
                Dim listaComuni As List(Of ComuneItaliano) = Operazioni.CaricaDatiFiltrati(Of ComuneItaliano)(listaParametri)

                For Each comune In listaComuni
                    sCodiceCatasto = comune.CodiceCatastaleComune
                Next

                LSUTxtCodiceFiscale.ValoreCasellaTesto = ClsComune.CalcolaCodiceFiscale(LSUTxtNomeCompleto.ValoreCasellaTesto, LSUDataNascita.ValoreDataOraSel,
                                                LSUCboEditSesso.ValoreMenuTendina.ToUpper, sCodiceCatasto)
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: LSUCboEditLuogoNascita_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtCodiceFiscale_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtCodiceFiscale.ValoreCasellaTestoCambiato
        Try
            If LSUTxtCodiceFiscale.ValoreCasellaTesto <> "" Then
                bModificataPers = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: LSUTxtCodiceFiscale_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtPartitaIVA_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtPartitaIVA.ValoreCasellaTestoCambiato
        Try
            If LSUTxtPartitaIVA.ValoreCasellaTesto <> "" Then
                bModificataPers = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: LSUTxtPartitaIVA_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditStatoResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditStatoResidenza.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditStatoResidenza.ValoreMenuTendina <> "" Then
                bModificataPers = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: LSUCboEditStatoResidenza_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditProvResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditProvResidenza.ValoreMenuTendinaCambiato
        Dim listaParametri As New Dictionary(Of String, String)
        Try
            If LSUCboEditProvResidenza.ValoreMenuTendina.Trim() <> "" Then

                bModificataPers = True

                'Carico tutti i comuni relativi alla provincia selezionata
                Dim strSiglaAutoSel As String = Mid(LSUCboEditProvResidenza.ValoreMenuTendina, LSUCboEditProvResidenza.ValoreMenuTendina.Length - 2, 2)
                listaParametri.Add("SiglaAutoProvincia", strSiglaAutoSel)
                Dim listaComuni As List(Of ComuneItaliano) = Operazioni.CaricaDatiFiltrati(Of ComuneItaliano)(listaParametri)
                LSUCboEditLuogoResidenza.PulisciElementi()

                For Each comune In listaComuni
                    LSUCboEditLuogoResidenza.AggiungiElemento(comune.IdComune, comune.DenominazioneComune)
                Next

            End If

            If LSUCboEditProvResidenza.ValoreMenuTendina <> "" Then
                bModificataPers = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: LSUCboEditProvResidenza_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditLuogoResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditLuogoResidenza.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditLuogoResidenza.ValoreMenuTendina <> "" Then
                bModificataPers = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: LSUCboEditLuogoResidenza_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtInidirizzoResidenza_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtInidirizzoResidenza.ValoreCasellaTestoCambiato
        Try
            If LSUTxtInidirizzoResidenza.ValoreCasellaTesto <> "" Then
                bModificataPers = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: LSUTxtInidirizzoResidenza_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtNazionalita_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNazionalita.ValoreCasellaTestoCambiato
        Try
            If LSUTxtNazionalita.ValoreCasellaTesto <> "" Then
                bModificataPers = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: LSUTxtNazionalita_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxChiudiFinestra_Click(sender As Object, e As EventArgs) Handles PicBoxChiudiFinestra.Click
        Dim risultatoChiusura As Integer
        Try
            If bDatoDettaglioCambiato = True Then
                risultatoChiusura = MessageBox.Show(text:="Attenzione: la chiusura provoca la perdita delle modifiche pendenti. Sei sicuro di voler chiudere la finestra?", caption:="Conferma chiusura finestra", icon:=MessageBoxIcon.Warning, buttons:=MessageBoxButtons.YesNo)
                If risultatoChiusura = vbYes Then
                    Dispose()
                End If
            Else
                Dispose()
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaPersone: PicBoxChiudiFinestra_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub
End Class
