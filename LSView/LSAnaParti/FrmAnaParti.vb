Imports LSDBManager.LSDBContextNS
Imports LSDataModel.LSDataModelNS
Imports LSAnaPersone
Imports LSCommon.LSCommonNS

Public Class FrmAnaParti

    Dim bDatoDettaglioCambiato As Boolean = False
    Dim bInseritaNuovaParte As Boolean = False
    Dim bModificataParte As Boolean = False

    Private mIdParte As Integer
    Private mDenominazioneParte As String
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

    Public Property _IdParte() As Integer
        Get
            Return mIdParte
        End Get
        Set(ByVal value As Integer)
            mIdParte = value
        End Set
    End Property

    Public Property _DenominazioneParte() As String
        Get
            Return mDenominazioneParte
        End Get
        Set(ByVal value As String)
            mDenominazioneParte = value
        End Set
    End Property

    Public Sub InizializzaControlli()

        Dim listaParti As New List(Of Parte)
        Dim listaProvince As New List(Of Provincia)
        Dim listaNazioni As New List(Of Nazione)

        Try

            UBtnConfermaControparteTrovata.Visible = mVisualizzaDaAltraFinestra

            UltraDockAnaParti.DockAreas(2).Size = New System.Drawing.Size(Me.Width, Me.Height - 81)
            UltraDockAnaParti.DockAreas(0).Size = New System.Drawing.Size(Me.Width, 81)

            listaParti = Operazioni.CaricaTutti(Of Parte)()
            UGrdAnaParti.DataSource = listaParti

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
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: Sub InizializzaControlli. ", True, ClsComune.GlbStrUserNameLS, "", True)
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
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: Sub SvuotaCampiDettaglio. ", True, ClsComune.GlbStrUserNameLS, "", True)
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
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: Sub CompilaCampiDatiDettaglio. ", True, ClsComune.GlbStrUserNameLS, "", True)
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
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: Sub RicavaDatiDettaglioInseriti. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub FrmAnaParti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized

            InizializzaControlli()
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti_Load. ", True, ClsComune.GlbStrUserNameLS, "", True)
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
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: UltraPicBoxChiudiFinestra_MouseClick. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UGrdAnaParti_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles UGrdAnaParti.DoubleClickRow
        Dim intIdParte As Integer
        Dim parte As New Parte
        Try
            If Not IsNothing(UGrdAnaParti.ActiveRow) Then
                intIdParte = UGrdAnaParti.ActiveRow.Cells("IdPersona").Value
                parte = Operazioni.CaricaRigaDatoId(Of Parte)(intIdParte)
                CompilaCampiDatiDettaglio(parte)
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: UGrdAnaParti_DoubleClickRow. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxInserisciRiga_Click(sender As Object, e As EventArgs) Handles UPicBoxInserisciRiga.Click
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
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: UPicBoxInserisciRiga_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxEliminaRiga_Click(sender As Object, e As EventArgs) Handles UPicBoxEliminaRiga.Click
        Dim intIdParte As Integer
        Try
            If Not IsNothing(UGrdAnaParti.ActiveRow) Then
                intIdParte = UGrdAnaParti.ActiveRow.Cells("IdParte").Value
                Operazioni.Elimina(Of Parte)(intIdParte)

                'aggiorno la griglia
                UGrdAnaParti.DataSource = Operazioni.CaricaTutti(Of Parte)()

            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: UPicBoxEliminaRiga_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicercaDati_Click(sender As Object, e As EventArgs) Handles UPicBoxRicercaDati.Click
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
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: UPicBoxRicercaDati_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxSalvaDati_Click(sender As Object, e As EventArgs) Handles UPicBoxSalvaDati.Click
        Dim intIdParte As Integer = 0
        Dim parte As New Parte
        Dim pers As New Persona

        Try
            If bInseritaNuovaParte Then

                'Ricavo il nuovo idPersona da aggiungere
                intIdParte = Operazioni.RicavaMaxId(Of Parte)

                'Ricavo dai valori dei controlli tutti i nuovi dati da aggiungere e creo la nuova entità Parte da aggiungere
                RicavaDatiDettaglioInseriti(parte)

                Operazioni.Aggiungi(Of Parte)(intIdParte, parte)

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
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: UPicBoxSalvaDati_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UltraPicBoxChiudiFinestra_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxChiudiFinestra.MouseHover
        Try
            UPicBoxChiudiFinestra.Image = ImageListAnaParti.Images(1)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: UltraPicBoxChiudiFinestra_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UltraPicBoxChiudiFinestra_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxChiudiFinestra.MouseLeave
        Try
            UPicBoxChiudiFinestra.Image = ImageListAnaParti.Images(0)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: UltraPicBoxChiudiFinestra_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxSalvaDati_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxSalvaDati.MouseHover
        Try
            UPicBoxSalvaDati.Image = ImageListAnaParti.Images(3)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: UPicBoxSalvaDati_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxSalvaDati_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxSalvaDati.MouseLeave
        Try
            UPicBoxSalvaDati.Image = ImageListAnaParti.Images(2)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: UPicBoxSalvaDati_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxEliminaRiga_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxEliminaRiga.MouseHover
        Try
            UPicBoxEliminaRiga.Image = ImageListAnaParti.Images(5)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: UPicBoxEliminaRiga_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxEliminaRiga_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxEliminaRiga.MouseLeave
        Try
            UPicBoxEliminaRiga.Image = ImageListAnaParti.Images(4)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: UPicBoxEliminaRiga_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxInserisciRiga_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxInserisciRiga.MouseHover
        Try
            UPicBoxInserisciRiga.Image = ImageListAnaParti.Images(7)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: UPicBoxInserisciRiga_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxInserisciRiga_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxInserisciRiga.MouseLeave
        Try
            UPicBoxInserisciRiga.Image = ImageListAnaParti.Images(6)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: UPicBoxInserisciRiga_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicercaDati_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxRicercaDati.MouseHover
        Try
            UPicBoxRicercaDati.Image = ImageListAnaParti.Images(9)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: UPicBoxRicercaDati_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicercaDati_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxRicercaDati.MouseLeave
        Try
            UPicBoxRicercaDati.Image = ImageListAnaParti.Images(8)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: UPicBoxRicercaDati_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditTipoPersona_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditTipoPersona.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditTipoPersona.ValoreMenuTendina <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: LSUCboEditTipoPersona_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtNomeCompleto_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNomeCompleto.ValoreCasellaTestoCambiato
        Try
            If LSUTxtNomeCompleto.ValoreCasellaTesto <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: LSUTxtNomeCompleto_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUDataNascita_ValoreDataOraSelCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUDataNascita.ValoreDataOraSelCambiato
        Try
            If LSUDataNascita.ValoreDataOraSel.ToString <> "01/01/1753 00:00:00" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: LSUDataNascita_ValoreDataOraSelCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditSesso_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditSesso.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditSesso.ValoreMenuTendina <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: LSUCboEditSesso_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditStatoNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditStatoNascita.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditStatoNascita.ValoreMenuTendina <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: LSUCboEditStatoNascita_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtCodiceFiscale_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtCodiceFiscale.ValoreCasellaTestoCambiato
        Try
            If LSUTxtCodiceFiscale.ValoreCasellaTesto <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: LSUTxtCodiceFiscale_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtPartitaIVA_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtPartitaIVA.ValoreCasellaTestoCambiato
        Try
            If LSUTxtPartitaIVA.ValoreCasellaTesto <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: LSUTxtPartitaIVA_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditStatoResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditStatoResidenza.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditStatoResidenza.ValoreMenuTendina <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: LSUCboEditStatoResidenza_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditProvResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditProvResidenza.ValoreMenuTendinaCambiato

        Dim listaComuni As New List(Of ComuneItaliano)
        Dim listaParametri As New Dictionary(Of String, String)
        Dim strSiglaAutoSel As String = ""
        Try
            If LSUCboEditProvResidenza.ValoreMenuTendina.Trim() <> "" Then

                bModificataParte = True

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
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: LSUCboEditProvResidenza_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditLuogoResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditLuogoResidenza.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditLuogoResidenza.ValoreMenuTendina <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: LSUCboEditLuogoResidenza_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtInidirizzoResidenza_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtInidirizzoResidenza.ValoreCasellaTestoCambiato
        Try
            If LSUTxtInidirizzoResidenza.ValoreCasellaTesto <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: LSUTxtInidirizzoResidenza_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtNazionalita_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNazionalita.ValoreCasellaTestoCambiato
        Try
            If LSUTxtNazionalita.ValoreCasellaTesto <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: LSUTxtNazionalita_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtEmail_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtEmail.ValoreCasellaTestoCambiato
        Try
            If LSUTxtEmail.ValoreCasellaTesto <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: LSUTxtEmail_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtEmailPEC_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtEmailPEC.ValoreCasellaTestoCambiato
        Try
            If LSUTxtEmailPEC.ValoreCasellaTesto <> "" Then
                bModificataParte = True
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: LSUTxtEmailPEC_ValoreCasellaTestoCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditProvNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditProvNascita.ValoreMenuTendinaCambiato
        Dim listaComuni As New List(Of ComuneItaliano)
        Dim listaParametri As New Dictionary(Of String, String)
        Dim sCodiceCatasto As String = ""
        Dim strSiglaAutoSel As String = ""
        Try
            If LSUCboEditProvNascita.ValoreMenuTendina.Trim() <> "" Then

                bModificataParte = True

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
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: LSUCboEditProvNascita_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditLuogoNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditLuogoNascita.ValoreMenuTendinaCambiato
        Dim listaComuni As New List(Of ComuneItaliano)
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
                listaComuni = Operazioni.CaricaDatiFiltrati(Of ComuneItaliano)(listaParametri)

                For Each comune In listaComuni
                    sCodiceCatasto = comune.CodiceCatastaleComune
                Next
                ClsComune.CalcolaCodiceFiscale(LSUTxtNomeCompleto.ValoreCasellaTesto, LSUDataNascita.ValoreDataOraSel,
                                                LSUCboEditSesso.ValoreMenuTendina, LSUCboEditLuogoNascita.ValoreMenuTendina, sCodiceCatasto)
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: LSUCboEditLuogoNascita_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
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
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: UPicBoxCaricaLegaleRappr_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UBtnConfermaParteTrovata_Click(sender As Object, e As EventArgs) Handles UBtnConfermaControparteTrovata.Click
        Try
            mDenominazioneParte = LSUTxtNomeCompleto.ValoreCasellaTesto
            mIdParte = UGrdAnaParti.ActiveRow.Cells("IdPersona").Value
            Me.Close()
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaParti: UBtnConfermaParteTrovata_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

End Class