Imports LSDBManager.LSDBContextNS
Imports LSDataModel.LSDataModelNS
Imports LSCtrlAnaPersone
Imports LSCommon.LSCommonNS

Public Class UsrCtrlAnaControparti

    ReadOnly bDatoDettaglioCambiato As Boolean = False
    Dim bInseritoNuovoControp As Boolean = False
    Dim bModificatoControp As Boolean = False

    Private mIdControparte As Integer
    Private mDenominazioneControparte As String
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

    Public Property IdControparte() As Integer
        Get
            Return mIdControparte
        End Get
        Set(ByVal value As Integer)
            mIdControparte = value
        End Set
    End Property

    Public Property DenominazioneControparte() As String
        Get
            Return mDenominazioneControparte
        End Get
        Set(ByVal value As String)
            mDenominazioneControparte = value
        End Set
    End Property

    Public Sub InizializzaControlli()

        Try

            UBtnConfermaControparteTrovata.Visible = mVisualizzaDaAltraFinestra

            Dim listaControparti As List(Of Controparte) = Operazioni.CaricaTutti(Of Controparte)()
            UGrdAnaControparti.DataSource = listaControparti

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

            UGrdAnaControparti.DisplayLayout.Bands(0).Columns(0).Hidden = True
            UGrdAnaControparti.DisplayLayout.Bands(0).Columns(1).Header.Caption = "E-Mail PEC"
            UGrdAnaControparti.DisplayLayout.Bands(0).Columns(2).Hidden = True
            UGrdAnaControparti.DisplayLayout.Bands(0).Columns(3).Hidden = True
            UGrdAnaControparti.DisplayLayout.Bands(0).Columns(4).Hidden = True
            UGrdAnaControparti.DisplayLayout.Bands(0).Columns(5).Hidden = True
            UGrdAnaControparti.DisplayLayout.Bands(0).Columns(6).Hidden = True
            UGrdAnaControparti.DisplayLayout.Bands(0).Columns(7).Hidden = True
            UGrdAnaControparti.DisplayLayout.Bands(0).Columns(8).Hidden = True
            UGrdAnaControparti.DisplayLayout.Bands(0).Columns(9).Header.Caption = "Codice Fiscale"
            UGrdAnaControparti.DisplayLayout.Bands(0).Columns(10).Hidden = True
            UGrdAnaControparti.DisplayLayout.Bands(0).Columns(11).Hidden = True
            UGrdAnaControparti.DisplayLayout.Bands(0).Columns(12).Hidden = True
            UGrdAnaControparti.DisplayLayout.Bands(0).Columns(13).Hidden = True
            UGrdAnaControparti.DisplayLayout.Bands(0).Columns(14).Hidden = True
            UGrdAnaControparti.DisplayLayout.Bands(0).Columns(15).Hidden = True
            UGrdAnaControparti.DisplayLayout.Bands(0).Columns(16).Hidden = True
            UGrdAnaControparti.DisplayLayout.Bands(0).Columns(17).Hidden = True
            UGrdAnaControparti.DisplayLayout.Bands(0).Columns(18).Hidden = True
            UGrdAnaControparti.DisplayLayout.Bands(0).Columns(19).Hidden = True
            UGrdAnaControparti.DisplayLayout.Bands(0).Columns(20).Hidden = True
            UGrdAnaControparti.DisplayLayout.Bands(0).Columns(21).Hidden = True
            UGrdAnaControparti.DisplayLayout.Bands(0).Columns(22).Hidden = True
            UGrdAnaControparti.DisplayLayout.Bands(0).Columns(23).Hidden = True
            UGrdAnaControparti.DisplayLayout.Bands(0).Columns(24).Header.Caption = "Nominativo"


        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: Sub InizializzaControlli. ", True, ClsComune.GlbStrUserNameLS, "", True)
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
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: Sub SvuotaCampiDettaglio. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Public Sub CompilaCampiDatiDettaglio(ByVal controparte As Controparte)
        Try
            LSUTxtNomeCompleto.ValoreCasellaTesto = controparte.NomeCompleto
            LSUTxtCodiceFiscale.ValoreCasellaTesto = controparte.CodiceFiscale
            LSUTxtPartitaIVA.ValoreCasellaTesto = controparte.PartitaIVA
            LSUDataNascita.ValoreDataOraSel = controparte.DataDiNascita
            LSUCboEditLuogoNascita.ValoreMenuTendina = controparte.LuogoDiNascita
            LSUCboEditProvNascita.ValoreMenuTendina = controparte.ProvinciaDiNascita
            LSUCboEditStatoNascita.ValoreMenuTendina = controparte.StatoDiNascita
            LSUTxtInidirizzoResidenza.ValoreCasellaTesto = controparte.IndirizzoResidenza
            LSUCboEditLuogoResidenza.ValoreMenuTendina = controparte.LuogoResidenza
            LSUCboEditProvResidenza.ValoreMenuTendina = controparte.ProvinciaResidenza
            LSUCboEditStatoResidenza.ValoreMenuTendina = controparte.StatoResidenza
            LSUTxtNazionalita.ValoreCasellaTesto = controparte.Nazionalita
            LSUCboEditSesso.ValoreMenuTendina = controparte.Sesso
            LSUTxtEmail.ValoreCasellaTesto = controparte.EMail
            LSUTxtEmailPEC.ValoreCasellaTesto = controparte.EmailPEC
            LSUCboEditTipoPersona.ValoreMenuTendina = controparte.TipologiaPersona
            LSUTxtIndirizzoSedeLegale.ValoreCasellaTesto = controparte.IndirizzoSedeLegale
            LSUTxtIndirizzoSedeOperativa.ValoreCasellaTesto = controparte.IndirizzoSedeOperativa
            LSUTxtNomeLegaleRappr.ValoreCasellaTesto = controparte.DenominazioneLegaleRappresentante

        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: Sub CompilaCampiDatiDettaglio. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Public Sub RicavaDatiDettaglioInseriti(ByVal controparte As Controparte)

        Try
            Dim strNomeCompleto = Split(LSUTxtNomeCompleto.ValoreCasellaTesto, " ")
            controparte.Nome = strNomeCompleto(0)
            controparte.Cognome = strNomeCompleto(1)
            controparte.CodiceFiscale = LSUTxtCodiceFiscale.ValoreCasellaTesto
            controparte.PartitaIVA = LSUTxtPartitaIVA.ValoreCasellaTesto
            controparte.DataDiNascita = LSUDataNascita.ValoreDataOraSel
            controparte.LuogoDiNascita = LSUCboEditLuogoNascita.ValoreMenuTendina
            controparte.ProvinciaDiNascita = LSUCboEditProvNascita.ValoreMenuTendina
            controparte.StatoDiNascita = LSUCboEditStatoNascita.ValoreMenuTendina
            controparte.IndirizzoResidenza = LSUTxtInidirizzoResidenza.ValoreCasellaTesto
            controparte.LuogoResidenza = LSUCboEditLuogoResidenza.ValoreMenuTendina
            controparte.ProvinciaResidenza = LSUCboEditProvResidenza.ValoreMenuTendina
            controparte.StatoResidenza = LSUCboEditStatoResidenza.ValoreMenuTendina
            controparte.Nazionalita = LSUTxtNazionalita.ValoreCasellaTesto
            controparte.Sesso = LSUCboEditSesso.ValoreMenuTendina
            controparte.EMail = LSUTxtEmail.ValoreCasellaTesto
            controparte.EmailPEC = LSUTxtEmailPEC.ValoreCasellaTesto
            controparte.TipologiaPersona = LSUCboEditTipoPersona.ValoreMenuTendina
            controparte.IndirizzoSedeLegale = LSUTxtIndirizzoSedeLegale.ValoreCasellaTesto
            controparte.IndirizzoSedeOperativa = LSUTxtIndirizzoSedeOperativa.ValoreCasellaTesto
            controparte.IdLegaleRappresentante = glbIdPersona
            controparte.DenominazioneLegaleRappresentante = LSUTxtNomeLegaleRappr.ValoreCasellaTesto

        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: Sub RicavaDatiDettaglioInseriti. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UsrCtrlAnaControparti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            InizializzaControlli()
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti_Load. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UGrdAnaControparti_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles UGrdAnaControparti.DoubleClickRow
        Dim intIdPersona As Integer
        Try
            If Not IsNothing(UGrdAnaControparti.ActiveRow) Then
                intIdPersona = UGrdAnaControparti.ActiveRow.Cells("IdPersona").Value
                Dim controparte As Controparte = Operazioni.CaricaRigaDatoId(Of Controparte)(intIdPersona)
                CompilaCampiDatiDettaglio(controparte)
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: UGrdAnaControparti_DoubleClickRow. ", True, ClsComune.GlbStrUserNameLS, "", True)
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
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: PicBoxChiudiFinestra_MouseClick. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxSalvaDati_Click(sender As Object, e As EventArgs) Handles PicBoxSalvaDati.Click
        Dim controparte As New Controparte
        Dim pers As New Persona

        Try
            If bInseritoNuovoControp Then

                'Ricavo il nuovo IdPersona da aggiungere
                Dim intIdPersona As Integer = Operazioni.RicavaMaxId(Of Controparte)

                'Ricavo dai valori dei controlli tutti i nuovi dati da aggiungere e creo la nuova entità Controparte da aggiungere
                RicavaDatiDettaglioInseriti(controparte)

                Operazioni.Aggiungi(Of Controparte)(controparte)

            End If

            If bModificatoControp = True And bInseritoNuovoControp = False Then

                Dim intIdPersona As Integer = UGrdAnaControparti.ActiveRow.Cells("IdPersona").Value

                'Ricavo dai valori dei controlli tutti i nuovi dati da aggiungere e creo la nuova entità Controparte da aggiungere
                RicavaDatiDettaglioInseriti(controparte)

                Operazioni.Aggiorna(Of Controparte)(intIdPersona, controparte)

                bModificatoControp = False

            End If

            bInseritoNuovoControp = False

            'aggiorno la griglia
            UGrdAnaControparti.DataSource = Operazioni.CaricaTutti(Of Controparte)()
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: PicBoxSalvaDati_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxEliminaRiga_Click(sender As Object, e As EventArgs) Handles PicBoxEliminaRiga.Click
        Dim intIdPersona As Integer

        Try
            If Not IsNothing(UGrdAnaControparti.ActiveRow) Then
                intIdPersona = UGrdAnaControparti.ActiveRow.Cells("IdPersona").Value
                Operazioni.Elimina(Of Controparte)(intIdPersona)

                'aggiorno la griglia
                UGrdAnaControparti.DataSource = Operazioni.CaricaTutti(Of Controparte)()

            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: PicBoxEliminaRiga_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxInserisciRiga_Click(sender As Object, e As EventArgs) Handles PicBoxInserisciRiga.Click
        Try
            If bInseritoNuovoControp Or bModificatoControp Then
                'se ci sono modifiche nei dati di dettaglio do' un messaggio di Contropertimento che verranno persi i dati

            End If
            'Svuoto tutti i campi di dettaglio
            SvuotaCampiDettaglio()
            bInseritoNuovoControp = True
            bModificatoControp = False
            UGrdAnaControparti.ActiveRow = Nothing
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: PicBoxInserisciRiga_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxRicercaDati_Click(sender As Object, e As EventArgs) Handles PicBoxRicercaDati.Click
        Dim intIdPersona As Integer

        Try
            If Not IsNothing(UGrdAnaControparti.ActiveRow) Then
                intIdPersona = UGrdAnaControparti.ActiveRow.Cells("IdPersona").Value
                Operazioni.Elimina(Of Controparte)(intIdPersona)

                'aggiorno la griglia
                UGrdAnaControparti.DataSource = Operazioni.CaricaTutti(Of Controparte)()

            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: PicBoxRicercaDati_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxChiudiFinestra_MouseHover(sender As Object, e As EventArgs) Handles PicBoxChiudiFinestra.MouseHover
        Try
            PicBoxChiudiFinestra.Image = ImageListAnaControparti.Images(1)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: PicBoxChiudiFinestra_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxChiudiFinestra_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxChiudiFinestra.MouseLeave
        Try
            PicBoxChiudiFinestra.Image = ImageListAnaControparti.Images(0)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: PicBoxChiudiFinestra. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxSalvaDati_MouseHover(sender As Object, e As EventArgs) Handles PicBoxSalvaDati.MouseHover
        Try
            PicBoxSalvaDati.Image = ImageListAnaControparti.Images(3)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: PicBoxSalvaDati_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxSalvaDati_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxSalvaDati.MouseLeave
        Try
            PicBoxSalvaDati.Image = ImageListAnaControparti.Images(2)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: PicBoxSalvaDati_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxEliminaRiga_MouseHover(sender As Object, e As EventArgs) Handles PicBoxEliminaRiga.MouseHover
        Try
            PicBoxEliminaRiga.Image = ImageListAnaControparti.Images(5)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: PicBoxEliminaRiga_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxEliminaRiga_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxEliminaRiga.MouseLeave
        Try
            PicBoxEliminaRiga.Image = ImageListAnaControparti.Images(4)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: PicBoxEliminaRiga_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxInserisciRiga_MouseHover(sender As Object, e As EventArgs) Handles PicBoxInserisciRiga.MouseHover
        Try
            PicBoxInserisciRiga.Image = ImageListAnaControparti.Images(7)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: PicBoxInserisciRiga_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxInserisciRiga_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxInserisciRiga.MouseLeave
        Try
            PicBoxInserisciRiga.Image = ImageListAnaControparti.Images(6)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: PicBoxInserisciRiga_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxRicercaDati_MouseHover(sender As Object, e As EventArgs) Handles PicBoxRicercaDati.MouseHover
        Try
            PicBoxRicercaDati.Image = ImageListAnaControparti.Images(9)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: PicBoxRicercaDati_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxRicercaDati_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxRicercaDati.MouseLeave
        Try
            PicBoxRicercaDati.Image = ImageListAnaControparti.Images(8)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: PicBoxRicercaDati_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditTipoPersona_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditTipoPersona.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditTipoPersona.ValoreMenuTendina <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: LSUCboEditTipoPersona_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtNomeCompleto_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNomeCompleto.ValoreCasellaTestoCambiato
        Try
            If LSUTxtNomeCompleto.ValoreCasellaTesto <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: LSUTxtNomeCompleto_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUDataNascita_ValoreDataOraSelCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUDataNascita.ValoreDataOraSelCambiato
        Try
            If LSUDataNascita.ValoreDataOraSel.ToString <> "01/01/1753 00:00:00" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: LSUDataNascita_ValoreDataOraSelCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditSesso_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditSesso.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditSesso.ValoreMenuTendina <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: LSUCboEditSesso_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditStatoNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditStatoNascita.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditStatoNascita.ValoreMenuTendina <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: LSUCboEditStatoNascita_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditProvNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditProvNascita.ValoreMenuTendinaCambiato
        Dim listaParametri As New Dictionary(Of String, String)
        Try
            If LSUCboEditProvNascita.ValoreMenuTendina.Trim() <> "" Then

                bModificatoControp = True

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
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: LSUCboEditProvNascita_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditLuogoNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditLuogoNascita.ValoreMenuTendinaCambiato
        Dim listaParametri As New Dictionary(Of String, String)
        Dim sCodiceCatasto As String = ""
        Try
            If LSUCboEditLuogoNascita.ValoreMenuTendina <> "" Then
                bModificatoControp = True
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
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: LSUCboEditLuogoNascita_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtCodiceFiscale_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtCodiceFiscale.ValoreCasellaTestoCambiato
        Try
            If LSUTxtCodiceFiscale.ValoreCasellaTesto <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: LSUTxtCodiceFiscale_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtPartitaIVA_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtPartitaIVA.ValoreCasellaTestoCambiato
        Try
            If LSUTxtPartitaIVA.ValoreCasellaTesto <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: LSUTxtPartitaIVA_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditStatoResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditStatoResidenza.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditStatoResidenza.ValoreMenuTendina <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: LSUCboEditStatoResidenza_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditProvResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditProvResidenza.ValoreMenuTendinaCambiato
        Dim listaParametri As New Dictionary(Of String, String)
        Try
            If LSUCboEditProvResidenza.ValoreMenuTendina.Trim() <> "" Then

                bModificatoControp = True

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
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: LSUCboEditProvResidenza_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditLuogoResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditLuogoResidenza.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditLuogoResidenza.ValoreMenuTendina <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: LSUCboEditLuogoResidenza_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtInidirizzoResidenza_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtInidirizzoResidenza.ValoreCasellaTestoCambiato
        Try
            If LSUTxtInidirizzoResidenza.ValoreCasellaTesto <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: LSUTxtInidirizzoResidenza_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtNazionalita_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNazionalita.ValoreCasellaTestoCambiato
        Try
            If LSUTxtNazionalita.ValoreCasellaTesto <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: LSUTxtNazionalita_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtEmail_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtEmail.ValoreCasellaTestoCambiato
        Try
            If LSUTxtEmail.ValoreCasellaTesto <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: LSUTxtEmail_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtEmailPEC_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtEmailPEC.ValoreCasellaTestoCambiato
        Try
            If LSUTxtEmailPEC.ValoreCasellaTesto <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: LSUTxtEmailPEC_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtIndirizzoSedeLegale_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtIndirizzoSedeLegale.ValoreCasellaTestoCambiato
        Try
            If LSUTxtIndirizzoSedeLegale.ValoreCasellaTesto <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: LSUTxtIndirizzoSedeLegale_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtIndirizzoSedeOperativa_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtIndirizzoSedeOperativa.ValoreCasellaTestoCambiato
        Try
            If LSUTxtIndirizzoSedeOperativa.ValoreCasellaTesto <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: LSUTxtIndirizzoSedeOperativa_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtNomeLegaleRappr_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNomeLegaleRappr.ValoreCasellaTestoCambiato
        Try
            If LSUTxtNomeLegaleRappr.ValoreCasellaTesto <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: LSUTxtNomeLegaleRappr_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
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
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: UPicBoxCaricaLegaleRappr_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UBtnConfermaControparteTrovata_Click(sender As Object, e As EventArgs) Handles UBtnConfermaControparteTrovata.Click
        Try
            mDenominazioneControparte = LSUTxtNomeCompleto.ValoreCasellaTesto
            mIdControparte = UGrdAnaControparti.ActiveRow.Cells("IdPersona").Value
            Dispose()
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlAnaControparti: UBtnConfermaContoparteTrovata_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub
End Class