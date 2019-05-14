Imports LSDBManager.LSDBContextNS
Imports LSDataModel.LSDataModelNS
Imports LSAnaPersone
Imports LSCommon.LSCommonNS

Public Class FrmAnaControparti

    Dim bDatoDettaglioCambiato As Boolean = False
    Dim bInseritoNuovoControp As Boolean = False
    Dim bModificatoControp As Boolean = False

    Private mIdControparte As Integer
    Private mDenominazioneControparte As String
    Private mVisualizzaDaAltraFinestra As Boolean

    Private glbIdPersona As Integer

    Public frmDllAnaPersone As New FrmAnaPersone With {
            ._VisualizzaPersDaAltraFinestra = True
        }

    Public Property _VisualizzaDaAltraFinestra() As Boolean
        Get
            Return mVisualizzaDaAltraFinestra
        End Get
        Set(ByVal value As Boolean)
            mVisualizzaDaAltraFinestra = value
        End Set
    End Property

    Public Property _IdControparte() As Integer
        Get
            Return mIdControparte
        End Get
        Set(ByVal value As Integer)
            mIdControparte = value
        End Set
    End Property

    Public Property _DenominazioneControparte() As String
        Get
            Return mDenominazioneControparte
        End Get
        Set(ByVal value As String)
            mDenominazioneControparte = value
        End Set
    End Property

    Public Sub InizializzaControlli()

        Dim listaControparti As New List(Of Controparte)
        Dim listaProvince As New List(Of Provincia)
        Dim listaNazioni As New List(Of Nazione)

        Try

            UBtnConfermaControparteTrovata.Visible = mVisualizzaDaAltraFinestra

            UltraDockAnaParti.DockAreas(2).Size = New System.Drawing.Size(Me.Width, Me.Height - 81)
            UltraDockAnaParti.DockAreas(0).Size = New System.Drawing.Size(Me.Width, 81)

            listaControparti = Operazioni.CaricaTutti(Of Controparte)()
            UGrdAnaControparti.DataSource = listaControparti

            LSUDataNascita.SvuotaDataOra()

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

            listaNazioni = Operazioni.CaricaTutti(Of Nazione)

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
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: Sub InizializzaControlli. ", True, ClsComune.GlbStrUserNameLS, "", True)
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
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: Sub SvuotaCampiDettaglio. ", True, ClsComune.GlbStrUserNameLS, "", True)
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
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: Sub CompilaCampiDatiDettaglio. ", True, ClsComune.GlbStrUserNameLS, "", True)
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
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: Sub RicavaDatiDettaglioInseriti. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub FrmAnaContropocati_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.WindowState = FormWindowState.Maximized

            InizializzaControlli()
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaContropocati_Load. ", True, ClsComune.GlbStrUserNameLS, "", True)
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
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: UltraPicBoxChiudiFinestra_MouseClick. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try

    End Sub

    Private Sub UGrdAnaControp_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles UGrdAnaControparti.DoubleClickRow
        Dim intIdPersona As Integer
        Dim controparte As New Controparte

        Try
            If Not IsNothing(UGrdAnaControparti.ActiveRow) Then
                intIdPersona = UGrdAnaControparti.ActiveRow.Cells("IdPersona").Value
                controparte = Operazioni.CaricaRigaDatoId(Of Controparte)(intIdPersona)
                CompilaCampiDatiDettaglio(controparte)
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: UGrdAnaControp_DoubleClickRow. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxInserisciRiga_Click(sender As Object, e As EventArgs) Handles UPicBoxInserisciRiga.Click
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
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: UPicBoxInserisciRiga_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxEliminaRiga_Click(sender As Object, e As EventArgs) Handles UPicBoxEliminaRiga.Click
        Dim intIdPersona As Integer

        Try
            If Not IsNothing(UGrdAnaControparti.ActiveRow) Then
                intIdPersona = UGrdAnaControparti.ActiveRow.Cells("IdPersona").Value
                Operazioni.Elimina(Of Controparte)(intIdPersona)

                'aggiorno la griglia
                UGrdAnaControparti.DataSource = Operazioni.CaricaTutti(Of Controparte)()

            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: UPicBoxEliminaRiga_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicercaDati_Click(sender As Object, e As EventArgs) Handles UPicBoxRicercaDati.Click
        Try

            If Trim(LSUTxtNominativoRicerca.ValoreCasellaTesto <> "") Or Trim(LSUTxtCFRicerca.ValoreCasellaTesto) <> "" Then
                Dim listaControparti As New List(Of Parte)
                Dim listaParametri As New Dictionary(Of String, String)

                'Creo la lista dei fitri di ricerca
                If Trim(LSUTxtNominativoRicerca.ValoreCasellaTesto <> "") Then
                    listaParametri.Add("Nominativo", LSUTxtNominativoRicerca.ValoreCasellaTesto)
                End If
                If Trim(LSUTxtCFRicerca.ValoreCasellaTesto <> "") Then
                    listaParametri.Add("CodiceFiscale", LSUTxtCFRicerca.ValoreCasellaTesto)
                End If

                listaControparti = Operazioni.CaricaDatiFiltrati(Of Parte)(listaParametri)
                UGrdAnaControparti.DataSource = listaControparti
            End If

        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: UPicBoxRicercaDati_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxSalvaDati_Click(sender As Object, e As EventArgs) Handles UPicBoxSalvaDati.Click
        Dim intIdPersona As Integer = 0
        Dim controparte As New Controparte
        Dim pers As New Persona

        Try
            If bInseritoNuovoControp Then

                'Ricavo il nuovo IdPersona da aggiungere
                intIdPersona = Operazioni.RicavaMaxId(Of Controparte)

                'Ricavo dai valori dei controlli tutti i nuovi dati da aggiungere e creo la nuova entità Controparte da aggiungere
                RicavaDatiDettaglioInseriti(controparte)

                Operazioni.Aggiungi(Of Controparte)(intIdPersona, controparte)

            End If

            If bModificatoControp = True And bInseritoNuovoControp = False Then

                intIdPersona = UGrdAnaControparti.ActiveRow.Cells("IdPersona").Value

                'Ricavo dai valori dei controlli tutti i nuovi dati da aggiungere e creo la nuova entità Controparte da aggiungere
                RicavaDatiDettaglioInseriti(controparte)

                Operazioni.Aggiorna(Of Controparte)(intIdPersona, controparte)

                bModificatoControp = False

            End If

            bInseritoNuovoControp = False

            'aggiorno la griglia
            UGrdAnaControparti.DataSource = Operazioni.CaricaTutti(Of Controparte)()
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: UPicBoxSalvaDati_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UltraPicBoxChiudiFinestra_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxChiudiFinestra.MouseHover
        Try
            UPicBoxChiudiFinestra.Image = ImageListAnaControparti.Images(1)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: UltraPicBoxChiudiFinestra_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UltraPicBoxChiudiFinestra_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxChiudiFinestra.MouseLeave
        Try
            UPicBoxChiudiFinestra.Image = ImageListAnaControparti.Images(0)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: UltraPicBoxChiudiFinestra_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxSalvaDati_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxSalvaDati.MouseHover
        Try
            UPicBoxSalvaDati.Image = ImageListAnaControparti.Images(3)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: UPicBoxSalvaDati_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxSalvaDati_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxSalvaDati.MouseLeave
        Try
            UPicBoxSalvaDati.Image = ImageListAnaControparti.Images(2)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: UPicBoxSalvaDati_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxEliminaRiga_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxEliminaRiga.MouseHover
        Try
            UPicBoxEliminaRiga.Image = ImageListAnaControparti.Images(5)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: UPicBoxEliminaRiga_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxEliminaRiga_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxEliminaRiga.MouseLeave
        Try
            UPicBoxEliminaRiga.Image = ImageListAnaControparti.Images(4)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: UPicBoxEliminaRiga_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxInserisciRiga_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxInserisciRiga.MouseHover
        Try
            UPicBoxInserisciRiga.Image = ImageListAnaControparti.Images(7)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: UPicBoxInserisciRiga_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxInserisciRiga_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxInserisciRiga.MouseLeave
        Try
            UPicBoxInserisciRiga.Image = ImageListAnaControparti.Images(6)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: UPicBoxInserisciRiga_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicercaDati_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxRicercaDati.MouseHover
        Try
            UPicBoxRicercaDati.Image = ImageListAnaControparti.Images(9)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: UPicBoxRicercaDati_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicercaDati_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxRicercaDati.MouseLeave
        Try
            UPicBoxRicercaDati.Image = ImageListAnaControparti.Images(8)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: UPicBoxRicercaDati_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditTipoPersona_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditTipoPersona.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditTipoPersona.ValoreMenuTendina <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: LSUCboEditTipoPersona_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtNomeCompleto_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNomeCompleto.ValoreCasellaTestoCambiato
        Try
            If LSUTxtNomeCompleto.ValoreCasellaTesto <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: LSUTxtNomeCompleto_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUDataNascita_ValoreDataOraSelCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUDataNascita.ValoreDataOraSelCambiato
        Try
            If LSUDataNascita.ValoreDataOraSel.ToString <> "01/01/1753 00:00:00" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: LSUDataNascita_ValoreDataOraSelCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditSesso_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditSesso.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditSesso.ValoreMenuTendina <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: LSUCboEditSesso_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditStatoNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditStatoNascita.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditStatoNascita.ValoreMenuTendina <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: LSUCboEditStatoNascita_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtCodiceFiscale_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtCodiceFiscale.ValoreCasellaTestoCambiato
        Try
            If LSUTxtCodiceFiscale.ValoreCasellaTesto <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: LSUTxtCodiceFiscale_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtPartitaIVA_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtPartitaIVA.ValoreCasellaTestoCambiato
        Try
            If LSUTxtPartitaIVA.ValoreCasellaTesto <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: LSUTxtPartitaIVA_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditStatoResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditStatoResidenza.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditStatoResidenza.ValoreMenuTendina <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: LSUCboEditStatoResidenza_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditProvResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditProvResidenza.ValoreMenuTendinaCambiato

        Dim listaComuni As New List(Of ComuneItaliano)
        Dim listaParametri As New Dictionary(Of String, String)
        Dim strSiglaAutoSel As String = ""

        Try
            If LSUCboEditProvResidenza.ValoreMenuTendina.Trim() <> "" Then

                bModificatoControp = True

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
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: LSUCboEditProvResidenza_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditLuogoResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditLuogoResidenza.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditLuogoResidenza.ValoreMenuTendina <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: LSUCboEditLuogoResidenza_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtInidirizzoResidenza_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtInidirizzoResidenza.ValoreCasellaTestoCambiato
        Try
            If LSUTxtInidirizzoResidenza.ValoreCasellaTesto <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: LSUTxtInidirizzoResidenza_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtNazionalita_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNazionalita.ValoreCasellaTestoCambiato
        Try
            If LSUTxtNazionalita.ValoreCasellaTesto <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: LSUTxtNazionalita_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtEmail_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtEmail.ValoreCasellaTestoCambiato
        Try
            If LSUTxtEmail.ValoreCasellaTesto <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: LSUTxtEmail_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtEmailPEC_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtEmailPEC.ValoreCasellaTestoCambiato
        Try
            If LSUTxtEmailPEC.ValoreCasellaTesto <> "" Then
                bModificatoControp = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: LSUTxtEmailPEC_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditProvNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditProvNascita.ValoreMenuTendinaCambiato
        Dim listaComuni As New List(Of ComuneItaliano)
        Dim listaParametri As New Dictionary(Of String, String)
        Dim strSiglaAutoSel As String = ""

        Try
            If LSUCboEditProvNascita.ValoreMenuTendina.Trim() <> "" Then

                bModificatoControp = True

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
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: LSUCboEditProvNascita_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditLuogoNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditLuogoNascita.ValoreMenuTendinaCambiato
        Dim listaComuni As New List(Of ComuneItaliano)
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
                listaComuni = Operazioni.CaricaDatiFiltrati(Of ComuneItaliano)(listaParametri)

                For Each comune In listaComuni
                    sCodiceCatasto = comune.CodiceCatastaleComune
                Next
                ClsComune.CalcolaCodiceFiscale(LSUTxtNomeCompleto.ValoreCasellaTesto, LSUDataNascita.ValoreDataOraSel,
                                                LSUCboEditSesso.ValoreMenuTendina, LSUCboEditLuogoNascita.ValoreMenuTendina, sCodiceCatasto)
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: LSUCboEditLuogoNascita_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxCaricaLegaleRappr_Click(sender As Object, e As EventArgs) Handles UPicBoxCaricaLegaleRappr.Click
        Dim dr As DialogResult
        Try
            dr = frmDllAnaPersone.ShowDialog()
            If dr = DialogResult.OK Then
                LSUTxtNomeLegaleRappr.ValoreCasellaTesto = frmDllAnaPersone._DenominazionePersona
                glbIdPersona = frmDllAnaPersone._IdPersona
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: UPicBoxCaricaLegaleRappr_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UBtnConfermaContoparteTrovata_Click(sender As Object, e As EventArgs) Handles UBtnConfermaControparteTrovata.Click
        Try
            mDenominazioneControparte = LSUTxtNomeCompleto.ValoreCasellaTesto
            mIdControparte = UGrdAnaControparti.ActiveRow.Cells("IdPersona").Value
            Me.Close()
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaControparti: UBtnConfermaContoparteTrovata_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub
End Class