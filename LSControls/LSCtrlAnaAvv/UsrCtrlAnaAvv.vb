Imports LSDBManager.LSDBContextNS
Imports LSDataModel.LSDataModelNS
Imports LSCommon.LSCommonNS
Imports System.Runtime.InteropServices
Imports System.Threading

Public Class UsrCtrlAnaAvv

    Private ReadOnly bDatoDettaglioCambiato As Boolean = False
    Private bInseritoNuovoAvv As Boolean = False
    Private bModificatoAvv As Boolean = False

    Private mIdAvvocato As Integer
    Private mNomeCompletoAvvocato As String
    Private mVisualizzaDaAltraFinestra As Boolean


    Private Const WM_SYSCOMMAND = &H112
    Private Const SC_CLOSE = &HF060&

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Public Shared Function SendMessage(ByVal hWnd As Integer, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As IntPtr) As Integer
    End Function

    Public _HWND As Integer
    Public Property HWND() As Integer
        Get
            Return _HWND
        End Get
        Set(ByVal value As Integer)
            _HWND = value
        End Set
    End Property

    Public Property VisualizzaDaAltraFinestra() As Boolean
        Get
            Return mVisualizzaDaAltraFinestra
        End Get
        Set(ByVal value As Boolean)
            mVisualizzaDaAltraFinestra = value
        End Set
    End Property

    Public Property IdAvvocato() As Integer
        Get
            Return mIdAvvocato
        End Get
        Set(ByVal value As Integer)
            mIdAvvocato = value
        End Set
    End Property

    Public Property NomeCompletoAvvocato() As String
        Get
            Return mNomeCompletoAvvocato
        End Get
        Set(ByVal value As String)
            mNomeCompletoAvvocato = value
        End Set
    End Property

    Public Sub InizializzaControlli()
        Dim listaParametriForo As New Dictionary(Of String, String)

        Try
            UBtnConfermaAvvTrovato.Visible = mVisualizzaDaAltraFinestra

            Dim listaAvvocati As List(Of Avvocato) = Operazioni.CaricaTutti(Of Avvocato)()
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

            'Carico tutti i fori di competenza dalla tabella EntiGiuridici filtrata
            listaParametriForo.Add("ForoCompetenza", "Tribunale Ordinario")
            Dim listaForiCompetenza As List(Of EnteGiuridico) = Operazioni.CaricaDatiFiltrati(Of EnteGiuridico)(listaParametriForo)

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

            If _HWND <> IntPtr.Zero Then
                SendMessage(_HWND, WM_SYSCOMMAND, SC_CLOSE, 0)
            End If

        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: Sub InizializzaControlli. ", True, ClsComune.GlbStrUserNameLS, "", True)
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
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: Sub SvuotaCampiDettaglio. ", True, ClsComune.GlbStrUserNameLS, "", True)
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
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: Sub CompilaCampiDatiDettaglio. ", True, ClsComune.GlbStrUserNameLS, "", True)
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
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: Sub RicavaDatiDettaglioInseriti. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UsrCtrlAnaAvv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            InizializzaControlli()
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv_Load. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UGrdAnaAvv_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles UGrdAnaAvv.DoubleClickRow
        Dim intIdPersona As Integer
        Dim unused As New Avvocato
        Try

            If Not IsNothing(UGrdAnaAvv.ActiveRow) Then
                intIdPersona = UGrdAnaAvv.ActiveRow.Cells("IdPersona").Value
                Dim avv As Avvocato = Operazioni.CaricaRigaDatoId(Of Avvocato)(intIdPersona)
                CompilaCampiDatiDettaglio(avv)
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: UGrdAnaAvv_DoubleClickRow. ", True, ClsComune.GlbStrUserNameLS, "", True)
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
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: PicBoxChiudiFinestra_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxSalvaDati_Click(sender As Object, e As EventArgs) Handles PicBoxSalvaDati.Click
        Dim avv As New Avvocato
        Dim pers As New Persona
        Try
            Dim intIdPersona As Integer
            If bInseritoNuovoAvv Then

                'Ricavo il nuovo IdPersona da aggiungere
                intIdPersona = Operazioni.RicavaMaxId(Of Avvocato)

                'Ricavo dai valori dei controlli tutti i nuovi dati da aggiungere e creo la nuova entità avvocato da aggiungere
                RicavaDatiDettaglioInseriti(avv)

                Operazioni.Aggiungi(Of Avvocato)(avv)

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
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: PicBoxSalvaDati_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxEliminaRiga_Click(sender As Object, e As EventArgs) Handles PicBoxEliminaRiga.Click
        Dim intIdPersona As Integer
        Try
            If Not IsNothing(UGrdAnaAvv.ActiveRow) Then
                intIdPersona = UGrdAnaAvv.ActiveRow.Cells("IdPersona").Value
                Operazioni.Elimina(Of Avvocato)(intIdPersona)

                'aggiorno la griglia
                UGrdAnaAvv.DataSource = Operazioni.CaricaTutti(Of Avvocato)()

            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: PicBoxEliminaRiga_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxInserisciRiga_Click(sender As Object, e As EventArgs) Handles PicBoxInserisciRiga.Click
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
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: PicBoxInserisciRiga_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxRicercaDati_Click(sender As Object, e As EventArgs) Handles PicBoxRicercaDati.Click
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
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: PicBoxRicercaDati_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxEsportaPDF_Click(sender As Object, e As EventArgs) Handles PicBoxEsportaPDF.Click
        Try
            'TODO
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: PicBoxEsportaPDF_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxEsportaExcel_Click(sender As Object, e As EventArgs) Handles PicBoxEsportaExcel.Click
        Try
            'TODO
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: PicBoxEsportaExcel_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxChiudiFinestra_MouseHover(sender As Object, e As EventArgs) Handles PicBoxChiudiFinestra.MouseHover
        Try
            PicBoxChiudiFinestra.Image = ImageListAnaAvv.Images(1)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: PicBoxChiudiFinestra_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxChiudiFinestra_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxChiudiFinestra.MouseLeave
        Try
            PicBoxChiudiFinestra.Image = ImageListAnaAvv.Images(0)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: PicBoxChiudiFinestra_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxSalvaDati_MouseHover(sender As Object, e As EventArgs) Handles PicBoxSalvaDati.MouseHover
        Try
            PicBoxSalvaDati.Image = ImageListAnaAvv.Images(3)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: PicBoxSalvaDati_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxSalvaDati_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxSalvaDati.MouseLeave
        Try
            PicBoxSalvaDati.Image = ImageListAnaAvv.Images(2)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: PicBoxSalvaDati_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxEliminaRiga_MouseHover(sender As Object, e As EventArgs) Handles PicBoxEliminaRiga.MouseHover
        Try
            PicBoxEliminaRiga.Image = ImageListAnaAvv.Images(5)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: PicBoxEliminaRiga_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxEliminaRiga_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxEliminaRiga.MouseLeave
        Try
            PicBoxEliminaRiga.Image = ImageListAnaAvv.Images(4)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: PicBoxEliminaRiga_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxInserisciRiga_MouseHover(sender As Object, e As EventArgs) Handles PicBoxInserisciRiga.MouseHover
        Try
            PicBoxInserisciRiga.Image = ImageListAnaAvv.Images(7)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: PicBoxInserisciRiga_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxInserisciRiga_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxInserisciRiga.MouseLeave
        Try
            PicBoxInserisciRiga.Image = ImageListAnaAvv.Images(6)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: PicBoxInserisciRiga_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxRicercaDati_MouseHover(sender As Object, e As EventArgs) Handles PicBoxRicercaDati.MouseHover
        Try
            PicBoxRicercaDati.Image = ImageListAnaAvv.Images(9)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: PicBoxRicercaDati_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxRicercaDati_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxRicercaDati.MouseLeave
        Try
            PicBoxRicercaDati.Image = ImageListAnaAvv.Images(8)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: PicBoxRicercaDati_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxEsportaPDF_MouseHover(sender As Object, e As EventArgs) Handles PicBoxEsportaPDF.MouseHover
        Try
            PicBoxEsportaPDF.Image = ImageListAnaAvv.Images(11)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: PicBoxEsportaPDF_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxEsportaPDF_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxEsportaPDF.MouseLeave
        Try
            PicBoxEsportaPDF.Image = ImageListAnaAvv.Images(10)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: PicBoxEsportaPDF_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxEsportaExcel_MouseHover(sender As Object, e As EventArgs) Handles PicBoxEsportaExcel.MouseHover
        Try
            PicBoxEsportaExcel.Image = ImageListAnaAvv.Images(13)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: PicBoxEsportaExcel_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxEsportaExcel_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxEsportaExcel.MouseLeave
        Try
            PicBoxEsportaExcel.Image = ImageListAnaAvv.Images(12)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: PicBoxEsportaExcel_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditTipoPersona_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditTipoPersona.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditTipoPersona.ValoreMenuTendina <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: LSUCboEditTipoPersona_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtNomeCompleto_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNomeCompleto.ValoreCasellaTestoCambiato
        Try
            If LSUTxtNomeCompleto.ValoreCasellaTesto <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: LSUTxtNomeCompleto_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUDataNascita_ValoreDataOraSelCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUDataNascita.ValoreDataOraSelCambiato
        Try
            If LSUDataNascita.ValoreDataOraSel.ToString <> "01/01/1753 00:00:00" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: LSUDataNascita_ValoreDataOraSelCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditSesso_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditSesso.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditSesso.ValoreMenuTendina <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: LSUCboEditSesso_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditStatoNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditStatoNascita.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditStatoNascita.ValoreMenuTendina <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: LSUCboEditStatoNascita_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditProvNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditProvNascita.ValoreMenuTendinaCambiato
        Dim unused As New List(Of ComuneItaliano)
        Dim listaParametri As New Dictionary(Of String, String)

        Try
            If LSUCboEditProvNascita.ValoreMenuTendina.Trim() <> "" Then

                bModificatoAvv = True

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
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: LSUCboEditProvNascita_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditLuogoNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditLuogoNascita.ValoreMenuTendinaCambiato
        Dim unused As New List(Of ComuneItaliano)
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
                Dim listaComuni As List(Of ComuneItaliano) = Operazioni.CaricaDatiFiltrati(Of ComuneItaliano)(listaParametri)

                For Each comune In listaComuni
                    sCodiceCatasto = comune.CodiceCatastaleComune
                Next
                LSUTxtCodiceFiscale.ValoreCasellaTesto = ClsComune.CalcolaCodiceFiscale(LSUTxtNomeCompleto.ValoreCasellaTesto, LSUDataNascita.ValoreDataOraSel,
                                                LSUCboEditSesso.ValoreMenuTendina.ToUpper, sCodiceCatasto)
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: LSUCboEditLuogoNascita_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtCodiceFiscale_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtCodiceFiscale.ValoreCasellaTestoCambiato
        Try
            If LSUTxtCodiceFiscale.ValoreCasellaTesto <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: LSUTxtCodiceFiscale_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtPartitaIVA_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtPartitaIVA.ValoreCasellaTestoCambiato
        Try
            If LSUTxtPartitaIVA.ValoreCasellaTesto <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: LSUTxtPartitaIVA_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditStatoResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditStatoResidenza.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditStatoResidenza.ValoreMenuTendina <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: LSUCboEditStatoResidenza_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditProvResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditProvResidenza.ValoreMenuTendinaCambiato
        Dim unused As New List(Of ComuneItaliano)
        Dim listaParametri As New Dictionary(Of String, String)

        Try
            If LSUCboEditProvResidenza.ValoreMenuTendina.Trim() <> "" Then

                bModificatoAvv = True

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
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: LSUCboEditProvResidenza_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try

    End Sub

    Private Sub LSUCboEditLuogoResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditLuogoResidenza.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditLuogoResidenza.ValoreMenuTendina <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: LSUCboEditLuogoResidenza_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtInidirizzoResidenza_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtInidirizzoResidenza.ValoreCasellaTestoCambiato
        Try
            If LSUTxtInidirizzoResidenza.ValoreCasellaTesto <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: LSUTxtInidirizzoResidenza_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtNazionalita_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNazionalita.ValoreCasellaTestoCambiato
        Try
            If LSUTxtNazionalita.ValoreCasellaTesto <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: LSUTxtNazionalita_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtEmail_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtEmail.ValoreCasellaTestoCambiato
        Try
            If LSUTxtEmail.ValoreCasellaTesto <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: LSUTxtEmail_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtEmailPEC_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtEmailPEC.ValoreCasellaTestoCambiato
        Try
            If LSUTxtEmailPEC.ValoreCasellaTesto <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: LSUTxtEmailPEC_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUDataIscrizAlboAvv_ValoreDataOraSelCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUDataIscrizAlboAvv.ValoreDataOraSelCambiato
        Try
            If LSUDataIscrizAlboAvv.ValoreDataOraSel.ToString <> "01/01/1753 00:00:00" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: LSUDataIscrizAlboAvv_ValoreDataOraSelCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUDataIscrizAlboCass_ValoreDataOraSelCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUDataIscrizAlboCass.ValoreDataOraSelCambiato
        Try
            If LSUDataIscrizAlboCass.ValoreDataOraSel.ToString <> "01/01/1753 00:00:00" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: LSUDataIscrizAlboCass_ValoreDataOraSelCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditForoAppartenenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditForoAppartenenza.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditForoAppartenenza.ValoreMenuTendina <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: LSUCboEditForoAppartenenza_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtNumTelStudio_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNumTelStudio.ValoreCasellaTestoCambiato
        Try
            If LSUTxtNumTelStudio.ValoreCasellaTesto <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: LSUTxtNumTelStudio_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtCellulare_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtCellulare.ValoreCasellaTestoCambiato
        Try
            If LSUTxtNumTelStudio.ValoreCasellaTesto <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: LSUTxtCellulare_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtNumFaxStudio_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNumFaxStudio.ValoreCasellaTestoCambiato
        Try
            If LSUTxtNumFaxStudio.ValoreCasellaTesto <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: LSUTxtNumFaxStudio_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtIndirizzoStudio_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtIndirizzoStudio.ValoreCasellaTestoCambiato
        Try
            If LSUTxtIndirizzoStudio.ValoreCasellaTesto <> "" Then
                bModificatoAvv = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: LSUTxtIndirizzoStudio_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UBtnConfermaAvvTrovato_Click(sender As Object, e As EventArgs) Handles UBtnConfermaAvvTrovato.Click
        Try
            mNomeCompletoAvvocato = LSUTxtNomeCompleto.ValoreCasellaTesto
            mIdAvvocato = UGrdAnaAvv.ActiveRow.Cells("IdPersona").Value
            Dispose()
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaAvv: UBtnConfermaAvvTrovato_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub
End Class
