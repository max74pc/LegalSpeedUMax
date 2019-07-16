Imports LSDBManager.LSDBContextNS
Imports LSDataModel.LSDataModelNS
Imports LSCtrlAnaPersone
Imports LSCommon.LSCommonNS

Public Class UsrCtrlAnaParti
    ReadOnly bDatoDettaglioCambiato As Boolean = False
    Dim bInseritaNuovaParte As Boolean = False
    Dim bModificataParte As Boolean = False

    Private mIdParte As Integer
    Private mDenominazioneParte As String
    Private mVisualizzaDaAltraFinestra As Boolean

    Private glbIdPersona As Integer

    Public usrCtrlAnaPers As New UsrCtrlAnaPersone With {
            .VisualizzaPersDaAltraFinestra = True
        }

    Public Property VisualizzaDaAltraFinestra() As Boolean
        Get
            Return mVisualizzaDaAltraFinestra
        End Get
        Set(ByVal value As Boolean)
            mVisualizzaDaAltraFinestra = value
        End Set
    End Property

    Public Property IdParte() As Integer
        Get
            Return mIdParte
        End Get
        Set(ByVal value As Integer)
            mIdParte = value
        End Set
    End Property

    Public Property DenominazioneParte() As String
        Get
            Return mDenominazioneParte
        End Get
        Set(ByVal value As String)
            mDenominazioneParte = value
        End Set
    End Property

    Public Sub InizializzaControlli()
        Try

            UBtnConfermaControparteTrovata.Visible = mVisualizzaDaAltraFinestra

            Dim listaParti As List(Of Parte) = Operazioni.CaricaTutti(Of Parte)()
            UGrdAnaParti.DataSource = listaParti

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

            UGrdAnaParti.DisplayLayout.Bands(0).Columns(0).Hidden = True
            UGrdAnaParti.DisplayLayout.Bands(0).Columns(1).Header.Caption = "E-Mail PEC"
            UGrdAnaParti.DisplayLayout.Bands(0).Columns(2).Hidden = True
            UGrdAnaParti.DisplayLayout.Bands(0).Columns(3).Hidden = True
            UGrdAnaParti.DisplayLayout.Bands(0).Columns(4).Hidden = True
            UGrdAnaParti.DisplayLayout.Bands(0).Columns(5).Hidden = True
            UGrdAnaParti.DisplayLayout.Bands(0).Columns(6).Hidden = True
            UGrdAnaParti.DisplayLayout.Bands(0).Columns(7).Hidden = True
            UGrdAnaParti.DisplayLayout.Bands(0).Columns(8).Hidden = True
            UGrdAnaParti.DisplayLayout.Bands(0).Columns(9).Header.Caption = "Codice Fiscale"
            UGrdAnaParti.DisplayLayout.Bands(0).Columns(10).Hidden = True
            UGrdAnaParti.DisplayLayout.Bands(0).Columns(11).Hidden = True
            UGrdAnaParti.DisplayLayout.Bands(0).Columns(12).Hidden = True
            UGrdAnaParti.DisplayLayout.Bands(0).Columns(13).Hidden = True
            UGrdAnaParti.DisplayLayout.Bands(0).Columns(14).Hidden = True
            UGrdAnaParti.DisplayLayout.Bands(0).Columns(15).Hidden = True
            UGrdAnaParti.DisplayLayout.Bands(0).Columns(16).Hidden = True
            UGrdAnaParti.DisplayLayout.Bands(0).Columns(17).Hidden = True
            UGrdAnaParti.DisplayLayout.Bands(0).Columns(18).Hidden = True
            UGrdAnaParti.DisplayLayout.Bands(0).Columns(19).Hidden = True
            UGrdAnaParti.DisplayLayout.Bands(0).Columns(20).Hidden = True
            UGrdAnaParti.DisplayLayout.Bands(0).Columns(21).Hidden = True
            UGrdAnaParti.DisplayLayout.Bands(0).Columns(22).Hidden = True
            UGrdAnaParti.DisplayLayout.Bands(0).Columns(23).Hidden = True
            UGrdAnaParti.DisplayLayout.Bands(0).Columns(24).Header.Caption = "Nominativo"

        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: Sub InizializzaControlli. ", True, ClsComune.GlbStrUserNameLS, "", True)
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
            LSUCboEditTipoPersona.ValoreMenuTendina = ""
            LSUTxtIndirizzoSedeLegale.ValoreCasellaTesto = ""
            LSUTxtIndirizzoSedeOperativa.ValoreCasellaTesto = ""
            LSUTxtNomeLegaleRappr.ValoreCasellaTesto = ""

        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: Sub SvuotaCampiDettaglio. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Public Sub CompilaCampiDatiDettaglio(ByVal parte As Parte)

        Try
            LSUTxtNomeCompleto.ValoreCasellaTesto = parte.NomeCompleto
            LSUTxtCodiceFiscale.ValoreCasellaTesto = parte.CodiceFiscale
            LSUTxtPartitaIVA.ValoreCasellaTesto = parte.PartitaIVA
            LSUDataNascita.ValoreDataOraSel = parte.DataDiNascita
            LSUCboEditLuogoNascita.ValoreMenuTendina = parte.LuogoDiNascita
            LSUCboEditProvNascita.ValoreMenuTendina = parte.ProvinciaDiNascita
            LSUCboEditStatoNascita.ValoreMenuTendina = parte.StatoDiNascita
            LSUTxtInidirizzoResidenza.ValoreCasellaTesto = parte.IndirizzoResidenza
            LSUCboEditLuogoResidenza.ValoreMenuTendina = parte.LuogoResidenza
            LSUCboEditProvResidenza.ValoreMenuTendina = parte.ProvinciaResidenza
            LSUCboEditStatoResidenza.ValoreMenuTendina = parte.StatoResidenza
            LSUTxtNazionalita.ValoreCasellaTesto = parte.Nazionalita
            LSUCboEditSesso.ValoreMenuTendina = parte.Sesso
            LSUTxtEmail.ValoreCasellaTesto = parte.EMail
            LSUTxtEmailPEC.ValoreCasellaTesto = parte.EmailPEC
            LSUCboEditTipoPersona.ValoreMenuTendina = parte.TipologiaPersona
            LSUTxtIndirizzoSedeLegale.ValoreCasellaTesto = parte.IndirizzoSedeLegale
            LSUTxtIndirizzoSedeOperativa.ValoreCasellaTesto = parte.IndirizzoSedeOperativa
            LSUTxtNomeLegaleRappr.ValoreCasellaTesto = parte.DenominazioneLegaleRappresentante
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: Sub CompilaCampiDatiDettaglio. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Public Sub RicavaDatiDettaglioInseriti(ByVal parte As Parte)
        Dim strNomeCompleto = Split(LSUTxtNomeCompleto.ValoreCasellaTesto, " ")

        Try
            parte.Nome = strNomeCompleto(0)
            parte.Cognome = strNomeCompleto(1)
            parte.CodiceFiscale = LSUTxtCodiceFiscale.ValoreCasellaTesto
            parte.PartitaIVA = LSUTxtPartitaIVA.ValoreCasellaTesto
            parte.DataDiNascita = LSUDataNascita.ValoreDataOraSel
            parte.LuogoDiNascita = LSUCboEditLuogoNascita.ValoreMenuTendina
            parte.ProvinciaDiNascita = LSUCboEditProvNascita.ValoreMenuTendina
            parte.StatoDiNascita = LSUCboEditStatoNascita.ValoreMenuTendina
            parte.IndirizzoResidenza = LSUTxtInidirizzoResidenza.ValoreCasellaTesto
            parte.LuogoResidenza = LSUCboEditLuogoResidenza.ValoreMenuTendina
            parte.ProvinciaResidenza = LSUCboEditProvResidenza.ValoreMenuTendina
            parte.StatoResidenza = LSUCboEditStatoResidenza.ValoreMenuTendina
            parte.Nazionalita = LSUTxtNazionalita.ValoreCasellaTesto
            parte.Sesso = LSUCboEditSesso.ValoreMenuTendina
            parte.EMail = LSUTxtEmail.ValoreCasellaTesto
            parte.EmailPEC = LSUTxtEmailPEC.ValoreCasellaTesto
            parte.TipologiaPersona = LSUCboEditTipoPersona.ValoreMenuTendina
            parte.IndirizzoSedeLegale = LSUTxtIndirizzoSedeLegale.ValoreCasellaTesto
            parte.IndirizzoSedeOperativa = LSUTxtIndirizzoSedeOperativa.ValoreCasellaTesto
            parte.IdLegaleRappresentante = glbIdPersona
            parte.DenominazioneLegaleRappresentante = LSUTxtNomeLegaleRappr.ValoreCasellaTesto
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: Sub RicavaDatiDettaglioInseriti. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxChiudiFinestra_MouseHover(sender As Object, e As EventArgs) Handles PicBoxChiudiFinestra.MouseHover
        Try
            PicBoxChiudiFinestra.Image = ImageListAnaParti.Images(1)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: PicBoxChiudiFinestra_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxChiudiFinestra_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxChiudiFinestra.MouseLeave
        Try
            PicBoxChiudiFinestra.Image = ImageListAnaParti.Images(0)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: PicBoxChiudiFinestra_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxSalvaDati_MouseHover(sender As Object, e As EventArgs) Handles PicBoxSalvaDati.MouseHover
        Try
            PicBoxSalvaDati.Image = ImageListAnaParti.Images(3)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: PicBoxSalvaDati_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxSalvaDati_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxSalvaDati.MouseLeave
        Try
            PicBoxSalvaDati.Image = ImageListAnaParti.Images(2)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: PicBoxSalvaDati_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxEliminaRiga_MouseHover(sender As Object, e As EventArgs) Handles PicBoxEliminaRiga.MouseHover
        Try
            PicBoxEliminaRiga.Image = ImageListAnaParti.Images(5)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: PicBoxEliminaRiga_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxEliminaRiga_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxEliminaRiga.MouseLeave
        Try
            PicBoxEliminaRiga.Image = ImageListAnaParti.Images(4)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: PicBoxEliminaRiga_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxInserisciRiga_MouseHover(sender As Object, e As EventArgs) Handles PicBoxInserisciRiga.MouseHover
        Try
            PicBoxInserisciRiga.Image = ImageListAnaParti.Images(7)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: PicBoxInserisciRiga_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxInserisciRiga_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxInserisciRiga.MouseLeave
        Try
            PicBoxInserisciRiga.Image = ImageListAnaParti.Images(6)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: PicBoxInserisciRiga_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxRicercaDati_MouseHover(sender As Object, e As EventArgs) Handles PicBoxRicercaDati.MouseHover
        Try
            PicBoxRicercaDati.Image = ImageListAnaParti.Images(9)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: PicBoxRicercaDati_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxRicercaDati_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxRicercaDati.MouseLeave
        Try
            PicBoxRicercaDati.Image = ImageListAnaParti.Images(8)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: PicBoxRicercaDati_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxChiudiFinestra_MouseClick(sender As Object, e As MouseEventArgs) Handles PicBoxChiudiFinestra.MouseClick
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
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: PicBoxChiudiFinestra_MouseClick. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxSalvaDati_Click(sender As Object, e As EventArgs) Handles PicBoxSalvaDati.Click
        Dim parte As New Parte
        Dim pers As New Persona

        Try
            Dim intIdParte As Integer
            If bInseritaNuovaParte Then

                'Ricavo il nuovo idPersona da aggiungere
                intIdParte = Operazioni.RicavaMaxId(Of Parte)

                'Ricavo dai valori dei controlli tutti i nuovi dati da aggiungere e creo la nuova entità Parte da aggiungere
                RicavaDatiDettaglioInseriti(parte)

                Operazioni.Aggiungi(Of Parte)(parte)

            End If

            If bModificataParte = True And bInseritaNuovaParte = False Then

                intIdParte = UGrdAnaParti.ActiveRow.Cells("IdPersona").Value

                'Ricavo dai valori dei controlli tutti i nuovi dati da aggiungere e creo la nuova entità Parte da aggiungere
                RicavaDatiDettaglioInseriti(parte)

                Operazioni.Aggiorna(Of Parte)(intIdParte, parte)

                bModificataParte = False

            End If

            bInseritaNuovaParte = False

            'aggiorno la griglia
            UGrdAnaParti.DataSource = Operazioni.CaricaTutti(Of Parte)()
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: PicBoxSalvaDati_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxEliminaRiga_Click(sender As Object, e As EventArgs) Handles PicBoxEliminaRiga.Click
        Dim intIdParte As Integer
        Try
            If Not IsNothing(UGrdAnaParti.ActiveRow) Then
                intIdParte = UGrdAnaParti.ActiveRow.Cells("IdParte").Value
                Operazioni.Elimina(Of Parte)(intIdParte)

                'aggiorno la griglia
                UGrdAnaParti.DataSource = Operazioni.CaricaTutti(Of Parte)()

            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: PicBoxEliminaRiga_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxInserisciRiga_Click(sender As Object, e As EventArgs) Handles PicBoxInserisciRiga.Click
        Try
            If bInseritaNuovaParte Or bModificataParte Then
                'se ci sono modifiche nei dati di dettaglio do' un messaggio di avvertimento che verranno persi i dati

            End If
            'Svuoto tutti i campi di dettaglio
            SvuotaCampiDettaglio()
            bInseritaNuovaParte = True
            bModificataParte = False
            UGrdAnaParti.ActiveRow = Nothing
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: PicBoxInserisciRiga_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxRicercaDati_Click(sender As Object, e As EventArgs) Handles PicBoxRicercaDati.Click
        Try

            If Trim(LSUTxtNominativoRicerca.ValoreCasellaTesto <> "") Or Trim(LSUTxtCFRicerca.ValoreCasellaTesto) <> "" Then
                Dim listaParti As New List(Of Parte)
                Dim listaParametri As New Dictionary(Of String, String)

                'Creo la lista dei fitri di ricerca
                If Trim(LSUTxtNominativoRicerca.ValoreCasellaTesto <> "") Then
                    listaParametri.Add("Nominativo", LSUTxtNominativoRicerca.ValoreCasellaTesto)
                End If
                If Trim(LSUTxtCFRicerca.ValoreCasellaTesto <> "") Then
                    listaParametri.Add("CodiceFiscale", LSUTxtCFRicerca.ValoreCasellaTesto)
                End If

                listaParti = Operazioni.CaricaDatiFiltrati(Of Parte)(listaParametri)
                UGrdAnaParti.DataSource = listaParti
            End If

        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: PicBoxRicercaDati_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UBtnConfermaControparteTrovata_Click(sender As Object, e As EventArgs) Handles UBtnConfermaControparteTrovata.Click
        Try
            mDenominazioneParte = LSUTxtNomeCompleto.ValoreCasellaTesto
            mIdParte = UGrdAnaParti.ActiveRow.Cells("IdPersona").Value
            Dispose()
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: UBtnConfermaParteTrovata_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UGrdAnaParti_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles UGrdAnaParti.DoubleClickRow
        Dim intIdParte As Integer
        Try
            If Not IsNothing(UGrdAnaParti.ActiveRow) Then
                intIdParte = UGrdAnaParti.ActiveRow.Cells("IdPersona").Value
                Dim parte As Parte = Operazioni.CaricaRigaDatoId(Of Parte)(intIdParte)
                CompilaCampiDatiDettaglio(parte)
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: UGrdAnaParti_DoubleClickRow. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditTipoPersona_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditTipoPersona.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditTipoPersona.ValoreMenuTendina <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: LSUCboEditTipoPersona_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtNomeCompleto_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNomeCompleto.ValoreCasellaTestoCambiato
        Try
            If LSUTxtNomeCompleto.ValoreCasellaTesto <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: LSUTxtNomeCompleto_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUDataNascita_ValoreDataOraSelCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUDataNascita.ValoreDataOraSelCambiato
        Try
            If LSUDataNascita.ValoreDataOraSel.ToString <> "01/01/1753 00:00:00" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: LSUDataNascita_ValoreDataOraSelCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditSesso_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditSesso.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditSesso.ValoreMenuTendina <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: LSUCboEditSesso_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditStatoNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditStatoNascita.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditStatoNascita.ValoreMenuTendina <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: LSUCboEditStatoNascita_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditProvNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditProvNascita.ValoreMenuTendinaCambiato
        Dim listaParametri As New Dictionary(Of String, String)

        Try
            If LSUCboEditProvNascita.ValoreMenuTendina.Trim() <> "" Then

                bModificataParte = True

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
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: LSUCboEditProvNascita_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditLuogoNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditLuogoNascita.ValoreMenuTendinaCambiato
        Dim listaParametri As New Dictionary(Of String, String)
        Dim sCodiceCatasto As String = ""
        Try
            If LSUCboEditLuogoNascita.ValoreMenuTendina <> "" Then
                bModificataParte = True
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
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: LSUCboEditLuogoNascita_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtCodiceFiscale_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtCodiceFiscale.ValoreCasellaTestoCambiato
        Try
            If LSUTxtCodiceFiscale.ValoreCasellaTesto <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: LSUTxtCodiceFiscale_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtPartitaIVA_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtPartitaIVA.ValoreCasellaTestoCambiato
        Try
            If LSUTxtPartitaIVA.ValoreCasellaTesto <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: LSUTxtPartitaIVA_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditStatoResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditStatoResidenza.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditStatoResidenza.ValoreMenuTendina <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: LSUCboEditStatoResidenza_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditProvResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditProvResidenza.ValoreMenuTendinaCambiato
        Dim listaParametri As New Dictionary(Of String, String)

        Try
            If LSUCboEditProvResidenza.ValoreMenuTendina.Trim() <> "" Then

                bModificataParte = True

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
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: LSUCboEditProvResidenza_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditLuogoResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditLuogoResidenza.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditLuogoResidenza.ValoreMenuTendina <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: LSUCboEditLuogoResidenza_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtInidirizzoResidenza_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtInidirizzoResidenza.ValoreCasellaTestoCambiato
        Try
            If LSUTxtInidirizzoResidenza.ValoreCasellaTesto <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: LSUTxtInidirizzoResidenza_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtNazionalita_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNazionalita.ValoreCasellaTestoCambiato
        Try
            If LSUTxtNazionalita.ValoreCasellaTesto <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: LSUTxtNazionalita_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtEmail_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtEmail.ValoreCasellaTestoCambiato
        Try
            If LSUTxtEmail.ValoreCasellaTesto <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: LSUTxtEmail_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtEmailPEC_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtEmailPEC.ValoreCasellaTestoCambiato
        Try
            If LSUTxtEmailPEC.ValoreCasellaTesto <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: LSUTxtEmailPEC_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtIndirizzoSedeLegale_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtIndirizzoSedeLegale.ValoreCasellaTestoCambiato
        Try
            If LSUTxtIndirizzoSedeLegale.ValoreCasellaTesto <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: LSUTxtIndirizzoSedeLegale_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtIndirizzoSedeOperativa_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtIndirizzoSedeOperativa.ValoreCasellaTestoCambiato
        Try
            If LSUTxtIndirizzoSedeOperativa.ValoreCasellaTesto <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: LSUTxtIndirizzoSedeOperativa_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtNomeLegaleRappr_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNomeLegaleRappr.ValoreCasellaTestoCambiato
        Try
            If LSUTxtNomeLegaleRappr.ValoreCasellaTesto <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: LSUTxtNomeLegaleRappr_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxCaricaLegaleRappr_Click(sender As Object, e As EventArgs) Handles UPicBoxCaricaLegaleRappr.Click
        Dim dr As DialogResult
        Dim frmAnaPers = New Form
        Dim usrCtrlAnaPers As New UsrCtrlAnaPersone With {
            .VisualizzaPersDaAltraFinestra = True,
            .Dock = DockStyle.Fill
        }
        Try
            frmAnaPers.Controls.Add(usrCtrlAnaPers)
            frmAnaPers.WindowState = FormWindowState.Maximized
            dr = frmAnaPers.ShowDialog()
            If dr = DialogResult.OK Then
                LSUTxtNomeLegaleRappr.ValoreCasellaTesto = usrCtrlAnaPers.DenominazionePersona
                glbIdPersona = usrCtrlAnaPers.IdPersona
                usrCtrlAnaPers = Nothing
                frmAnaPers.Close()
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti: UPicBoxCaricaLegaleRappr_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UsrCtrlAnaParti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            InizializzaControlli()
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaParti_Load. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub
End Class