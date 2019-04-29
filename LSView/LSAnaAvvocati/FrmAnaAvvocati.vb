Imports LSDBManager.LSDBContextNS
Imports LSDataModel.LSDataModelNS

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

        Dim operazioni As New Operazioni
        Dim listaAvvocati As New List(Of Avvocato)
        Dim listaProvince As New List(Of Provincia)
        Dim listaNazioni As New List(Of Nazione)
        Dim listaForiCompetenza As New List(Of EnteGiuridico)
        Dim listaParametriForo As New Dictionary(Of String, String)

        UBtnConfermaAvvTrovato.Visible = mVisualizzaDaAltraFinestra

        UltraDockAnaAvv.DockAreas(2).Size = New System.Drawing.Size(Me.Width, Me.Height - 81)
        UltraDockAnaAvv.DockAreas(0).Size = New System.Drawing.Size(Me.Width, 81)

        listaAvvocati = operazioni.CaricaTutti(Of Avvocato)()
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
        listaProvince = operazioni.CaricaTutti(Of Provincia)

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


    End Sub

    Public Sub SvuotaCampiDettaglio()

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

    End Sub

    Public Sub CompilaCampiDatiDettaglio(ByVal avv As Avvocato)

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

    End Sub

    Private Function StringCarattereControllo(ByVal CodiceFiscale As String) As String
        Dim risultato As Integer = 0
        Dim sommapari As Integer = 0
        Dim sommadispari As Integer = 0
        Dim ArrayChar() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        Dim ArrayCharPosizioneDispari() As Integer = {1, 0, 5, 7, 9, 13, 15, 17, 19, 21, 2, 4, 18, 20, 11, 3, 6, 8, 12, 14, 16, 10, 22, 25, 24, 23}
        Dim ArrayPari As New ArrayList
        Dim ArrayDispari As New ArrayList

        Try
            If CodiceFiscale.ToString <> "" Then
                For i As Integer = 0 To CodiceFiscale.Length - 1 Step 1
                    'Vi ricordo che l'array parte da zero ma noi dobbiamo calcolare come se fosse 1 
                    'e quindi Dispari si trovano nella posizione Pari e i Pari si trovano nella posizione Dispari
                    If i Mod (2) = 1 Then
                        'Indice Dispari - Posizione Dispari)
                        ArrayPari.Add(CodiceFiscale.Substring(i, 1).ToString)
                    Else
                        'Indice Pari - Posizione Pari
                        ArrayDispari.Add(CodiceFiscale.Substring(i, 1).ToString)
                    End If
                Next
                For i As Integer = 0 To ArrayPari.Count - 1 Step 1
                    If IsNumeric(ArrayPari(i).ToString) Then
                        sommapari = sommapari + ArrayPari(i).ToString
                    Else
                        For j As Integer = 0 To ArrayChar.Length - 1 Step 1
                            If (UCase(ArrayPari(i).ToString) = ArrayChar(j).ToString) Then
                                sommapari = sommapari + j
                                Exit For
                            End If
                        Next
                    End If
                Next
                For i As Integer = 0 To ArrayDispari.Count - 1 Step 1
                    If IsNumeric(ArrayDispari(i).ToString) Then
                        sommadispari = sommadispari + ArrayCharPosizioneDispari(ArrayDispari(i).ToString).ToString
                    Else
                        For j As Integer = 0 To ArrayChar.Length - 1 Step 1
                            If (UCase(ArrayDispari(i).ToString) = ArrayChar(j).ToString) Then
                                sommadispari = sommadispari + ArrayCharPosizioneDispari(j).ToString
                                Exit For
                            End If
                        Next
                    End If
                Next
                risultato = 0

            End If

            ArrayPari.Clear()
            ArrayDispari.Clear()
            risultato = (sommapari + sommadispari) Mod 26
            Return ArrayChar(risultato).ToString
        Catch ex As Exception
            'Errore generato da qualche numero e carattere strano
            Return "Errore"
        End Try
    End Function

    Private Sub CalcolaCodiceFiscale()
        Dim Cognome As String
        Dim Nome As String
        Dim Sesso As String
        Dim ArrayMesi() As String = {"A", "B", "C", "D", "E", "H", "L", "M", "P", "R", "S", "T"} 'Lettere che corrispondono al mese
        Dim ArrayVocali() As String = {"A", "E", "I", "O", "U"}
        Dim Parte1CodiceFiscale As String = ""
        Dim Parte2CodiceFiscale As String = ""
        Dim Parte3CodiceFiscale As String = ""
        Dim ArrayConsonanti As Array
        Dim Data As Date
        Dim giorno As Integer
        Dim mese As Integer
        Dim sTEMP As String
        Dim splitNomeCompleto() As String
        Dim operazioni As New Operazioni
        Dim listaComuni As New List(Of ComuneItaliano)
        Dim listaParametri As New Dictionary(Of String, String)
        Dim sCodiceCatasto As String = ""

        LSUTxtCodiceFiscale.ValoreCasellaTesto = ""

        splitNomeCompleto = Split(LSUTxtNomeCompleto.ValoreCasellaTesto, " ")

        Nome = UCase(splitNomeCompleto(0).Trim())
        Cognome = UCase(splitNomeCompleto(1).Trim())
        Sesso = UCase(LSUCboEditSesso.ValoreMenuTendina)
        Data = LSUDataNascita.ValoreDataOraSel
        giorno = Data.Day
        mese = Data.Month

        If IsDate(Data) Then

            If (Sesso = "FEMMINA") Then
                giorno = giorno + 40
            End If

            If giorno < 10 Then
                Parte2CodiceFiscale = Data.ToString("yy") & ArrayMesi(mese - 1) & "0" & giorno.ToString()
            Else
                Parte2CodiceFiscale = Data.ToString("yy") & ArrayMesi(mese - 1) & giorno.ToString()
            End If

        End If

        If Cognome.Length > 0 Then

            For i As Integer = 0 To Cognome.Length - 1
                For j As Integer = 0 To ArrayVocali.Length - 1
                    Cognome = Cognome.ToString.Replace(ArrayVocali(j).ToString, "")
                Next
            Next
        End If

        Select Case Cognome.Length
            Case Is = 3, Is > 3
                Parte1CodiceFiscale = Cognome.Substring(0, 3).ToString
            Case Is = 2
                Parte1CodiceFiscale = Cognome
                Parte1CodiceFiscale = Cognome.Substring(0, 2).ToString & Parte1CodiceFiscale(0).ToString
            Case Is = 1
                Parte1CodiceFiscale = Cognome
                Parte1CodiceFiscale = Cognome.Substring(0, 1).ToString & Parte1CodiceFiscale(0).ToString
            Case Is = 0
                Parte1CodiceFiscale = splitNomeCompleto(1).Trim()

                Select Case Parte1CodiceFiscale.Length
                    Case Is = 3, Is > 4
                        Parte1CodiceFiscale = Parte1CodiceFiscale.Substring(0, 3).ToString
                    Case Is = 2
                        Parte1CodiceFiscale = Parte1CodiceFiscale.Substring(0, 2).ToString & "X"
                    Case Is = 1
                        Parte1CodiceFiscale = Parte1CodiceFiscale.Substring(0, 1).ToString & "XX"
                    Case Is = 0
                        Parte1CodiceFiscale = "XXX"
                End Select
        End Select

        If Parte1CodiceFiscale.Length = 2 Then
            Parte1CodiceFiscale = Parte1CodiceFiscale & "X"
        End If

        If Nome.Length > 2 Then
            For i As Integer = 0 To Nome.Length - 1
                For j As Integer = 0 To ArrayVocali.Length - 1
                    Nome = Nome.ToString.Replace(ArrayVocali(j).ToString, "")
                Next
            Next
        End If

        Select Case Nome.Length
            Case Is = 4, Is > 4
                'Mariangela = MNG
                'Aldo Maria = LMR
                ArrayConsonanti = Nome.ToArray
                Parte1CodiceFiscale = Parte1CodiceFiscale & ArrayConsonanti(0).ToString & ArrayConsonanti(2).ToString & ArrayConsonanti(3).ToString
            Case Is = 3
                'Bruno = BRN
                ArrayConsonanti = Nome.ToArray
                Parte1CodiceFiscale = Parte1CodiceFiscale & ArrayConsonanti(0).ToString & ArrayConsonanti(1).ToString & ArrayConsonanti(2).ToString
            Case Is = 2
                'Luca = LCU
                ArrayConsonanti = Nome.ToArray
                sTEMP = Nome
                If sTEMP.Length > 0 Then
                    Parte1CodiceFiscale = Parte1CodiceFiscale & ArrayConsonanti(0).ToString & ArrayConsonanti(1).ToString & sTEMP(0).ToString
                Else
                    Parte1CodiceFiscale = Parte1CodiceFiscale & ArrayConsonanti(0).ToString & ArrayConsonanti(1).ToString & "X"
                End If
            Case Is = 1
                'Lia = LIA
                ArrayConsonanti = Nome.ToArray
                sTEMP = Nome
                If sTEMP.Length > 0 Then
                    Parte1CodiceFiscale = Parte1CodiceFiscale & ArrayConsonanti(0).ToString & sTEMP(0).ToString & sTEMP(1).ToString
                Else
                    Parte1CodiceFiscale = Parte1CodiceFiscale & ArrayConsonanti(0).ToString & "X"
                End If
            Case Is = 0
                Select Case splitNomeCompleto(0).Length
                    Case Is = 3, Is > 4
                        Parte1CodiceFiscale = Parte1CodiceFiscale & splitNomeCompleto(0).Substring(0, 3).ToString
                    Case Is = 2
                        Parte1CodiceFiscale = Parte1CodiceFiscale & splitNomeCompleto(0).Substring(0, 2).ToString & "X"
                    Case Is = 1
                        Parte1CodiceFiscale = Parte1CodiceFiscale & splitNomeCompleto(0).Substring(0, 1).ToString & "XX"
                    Case Is = 0
                        Parte1CodiceFiscale = Parte1CodiceFiscale & "XXX"
                End Select
        End Select

        'Ricavo il codice catasto dal nome del comune
        listaParametri.Add("CodiceCatasto", LSUCboEditLuogoNascita.ValoreMenuTendina)
        listaComuni = operazioni.CaricaDatiFiltrati(Of ComuneItaliano)(listaParametri)

        For Each comune In listaComuni
            sCodiceCatasto = comune.CodiceCatastaleComune
        Next

        Parte2CodiceFiscale = Parte2CodiceFiscale & sCodiceCatasto
        Parte2CodiceFiscale = Parte1CodiceFiscale & Parte2CodiceFiscale
        Parte3CodiceFiscale = StringCarattereControllo(Parte2CodiceFiscale)

        LSUTxtCodiceFiscale.ValoreCasellaTesto = Parte2CodiceFiscale & Parte3CodiceFiscale

    End Sub

    Public Sub RicavaDatiDettaglioInseriti(ByVal avv As Avvocato)
        Dim strNomeCompleto = Split(LSUTxtNomeCompleto.ValoreCasellaTesto, " ")
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

    Private Sub UGrdAnaAvv_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles UGrdAnaAvv.DoubleClickRow
        Dim intIdPersona As Integer
        Dim operazioni As New Operazioni
        Dim avv As New Avvocato

        If Not IsNothing(UGrdAnaAvv.ActiveRow) Then
            intIdPersona = UGrdAnaAvv.ActiveRow.Cells("IdPersona").Value
            avv = operazioni.CaricaRigaDatoId(Of Avvocato)(intIdPersona)
            CompilaCampiDatiDettaglio(avv)
        End If

    End Sub

    Private Sub UPicBoxInserisciRiga_Click(sender As Object, e As EventArgs) Handles UPicBoxInserisciRiga.Click
        If bInseritoNuovoAvv Or bModificatoAvv Then
            'se ci sono modifiche nei dati di dettaglio do' un messaggio di avvertimento che verranno persi i dati

        End If
        'Svuoto tutti i campi di dettaglio
        SvuotaCampiDettaglio()
        bInseritoNuovoAvv = True
        bModificatoAvv = False
        UGrdAnaAvv.ActiveRow = Nothing
    End Sub

    Private Sub UPicBoxEliminaRiga_Click(sender As Object, e As EventArgs) Handles UPicBoxEliminaRiga.Click
        Dim intIdPersona As Integer
        Dim operazioni As New Operazioni

        If Not IsNothing(UGrdAnaAvv.ActiveRow) Then
            intIdPersona = UGrdAnaAvv.ActiveRow.Cells("IdPersona").Value
            operazioni.Elimina(Of Avvocato)(intIdPersona)

            'aggiorno la griglia
            UGrdAnaAvv.DataSource = operazioni.CaricaTutti(Of Avvocato)()

        End If

    End Sub

    Private Sub UPicBoxRicercaDati_Click(sender As Object, e As EventArgs) Handles UPicBoxRicercaDati.Click

        If Trim(LSUTxtNominativoRicerca.ValoreCasellaTesto <> "") Or Trim(LSUTxtIndirizzoStudioRicerca.ValoreCasellaTesto) <> "" Then
            Dim operazioni As New Operazioni
            Dim listaAvvocati As New List(Of Avvocato)
            Dim listaParametri As New Dictionary(Of String, String)

            'Creo la lista dei fitri di ricerca
            If Trim(LSUTxtNominativoRicerca.ValoreCasellaTesto <> "") Then
                listaParametri.Add("Nominativo", LSUTxtNominativoRicerca.ValoreCasellaTesto)
            End If
            If Trim(LSUTxtIndirizzoStudioRicerca.ValoreCasellaTesto <> "") Then
                listaParametri.Add("IndirizzoStudio", LSUTxtIndirizzoStudioRicerca.ValoreCasellaTesto)
            End If

            listaAvvocati = operazioni.CaricaDatiFiltrati(Of Avvocato)(listaParametri)
            UGrdAnaAvv.DataSource = listaAvvocati

        End If

    End Sub

    Private Sub UPicBoxSalvaDati_Click(sender As Object, e As EventArgs) Handles UPicBoxSalvaDati.Click
        Dim intIdPersona As Integer = 0
        Dim operazioni As New Operazioni
        Dim avv As New Avvocato
        Dim pers As New Persona

        If bInseritoNuovoAvv Then

            'Ricavo il nuovo IdPersona da aggiungere
            intIdPersona = operazioni.RicavaMaxId(Of Avvocato)

            'Ricavo dai valori dei controlli tutti i nuovi dati da aggiungere e creo la nuova entità avvocato da aggiungere
            RicavaDatiDettaglioInseriti(avv)

            operazioni.Aggiungi(Of Avvocato)(intIdPersona, avv)

        End If

        If bModificatoAvv And bInseritoNuovoAvv = False Then

            intIdPersona = UGrdAnaAvv.ActiveRow.Cells("IdPersona").Value

            'Ricavo dai valori dei controlli tutti i nuovi dati da aggiungere e creo la nuova entità avvocato da aggiungere
            RicavaDatiDettaglioInseriti(avv)

            operazioni.Aggiorna(Of Avvocato)(intIdPersona, avv)

            bModificatoAvv = False

        End If

        bInseritoNuovoAvv = False


        'aggiorno la griglia
        UGrdAnaAvv.DataSource = operazioni.CaricaTutti(Of Avvocato)()

    End Sub

    Private Sub UltraPicBoxChiudiFinestra_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxChiudiFinestra.MouseHover
        UPicBoxChiudiFinestra.Image = ImageListAnaAvv.Images(1)
    End Sub

    Private Sub UltraPicBoxChiudiFinestra_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxChiudiFinestra.MouseLeave
        UPicBoxChiudiFinestra.Image = ImageListAnaAvv.Images(0)
    End Sub

    Private Sub UPicBoxSalvaDati_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxSalvaDati.MouseHover
        UPicBoxSalvaDati.Image = ImageListAnaAvv.Images(3)
    End Sub

    Private Sub UPicBoxSalvaDati_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxSalvaDati.MouseLeave
        UPicBoxSalvaDati.Image = ImageListAnaAvv.Images(2)
    End Sub

    Private Sub UPicBoxEliminaRiga_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxEliminaRiga.MouseHover
        UPicBoxEliminaRiga.Image = ImageListAnaAvv.Images(5)
    End Sub

    Private Sub UPicBoxEliminaRiga_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxEliminaRiga.MouseLeave
        UPicBoxEliminaRiga.Image = ImageListAnaAvv.Images(4)
    End Sub

    Private Sub UPicBoxInserisciRiga_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxInserisciRiga.MouseHover
        UPicBoxInserisciRiga.Image = ImageListAnaAvv.Images(7)
    End Sub

    Private Sub UPicBoxInserisciRiga_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxInserisciRiga.MouseLeave
        UPicBoxInserisciRiga.Image = ImageListAnaAvv.Images(6)
    End Sub

    Private Sub UPicBoxRicercaDati_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxRicercaDati.MouseHover
        UPicBoxRicercaDati.Image = ImageListAnaAvv.Images(9)
    End Sub

    Private Sub UPicBoxRicercaDati_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxRicercaDati.MouseLeave
        UPicBoxRicercaDati.Image = ImageListAnaAvv.Images(8)
    End Sub

    Private Sub LSUCboEditTipoPersona_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditTipoPersona.ValoreMenuTendinaCambiato

        If LSUCboEditTipoPersona.ValoreMenuTendina <> "" Then
            bModificatoAvv = True
        End If

    End Sub

    Private Sub LSUTxtNomeCompleto_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNomeCompleto.ValoreCasellaTestoCambiato

        If LSUTxtNomeCompleto.ValoreCasellaTesto <> "" Then
            bModificatoAvv = True
        End If

    End Sub

    Private Sub LSUDataNascita_ValoreDataOraSelCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUDataNascita.ValoreDataOraSelCambiato

        If LSUDataNascita.ValoreDataOraSel.ToString <> "01/01/1753 00:00:00" Then
            bModificatoAvv = True
        End If

    End Sub

    Private Sub LSUCboEditSesso_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditSesso.ValoreMenuTendinaCambiato

        If LSUCboEditSesso.ValoreMenuTendina <> "" Then
            bModificatoAvv = True
        End If

    End Sub

    Private Sub LSUCboEditStatoNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditStatoNascita.ValoreMenuTendinaCambiato

        If LSUCboEditStatoNascita.ValoreMenuTendina <> "" Then
            bModificatoAvv = True
        End If

    End Sub

    Private Sub LSUTxtCodiceFiscale_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtCodiceFiscale.ValoreCasellaTestoCambiato

        If LSUTxtCodiceFiscale.ValoreCasellaTesto <> "" Then
            bModificatoAvv = True
        End If

    End Sub

    Private Sub LSUTxtPartitaIVA_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtPartitaIVA.ValoreCasellaTestoCambiato

        If LSUTxtPartitaIVA.ValoreCasellaTesto <> "" Then
            bModificatoAvv = True
        End If

    End Sub

    Private Sub LSUCboEditStatoResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditStatoResidenza.ValoreMenuTendinaCambiato

        If LSUCboEditStatoResidenza.ValoreMenuTendina <> "" Then
            bModificatoAvv = True
        End If

    End Sub

    Private Sub LSUCboEditProvResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditProvResidenza.ValoreMenuTendinaCambiato

        Dim operazioni As New Operazioni
        Dim listaComuni As New List(Of ComuneItaliano)
        Dim listaParametri As New Dictionary(Of String, String)
        Dim strSiglaAutoSel As String = ""

        If LSUCboEditProvResidenza.ValoreMenuTendina.Trim() <> "" Then

            bModificatoAvv = True

            'Carico tutti i comuni relativi alla provincia selezionata
            strSiglaAutoSel = Mid(LSUCboEditProvResidenza.ValoreMenuTendina, LSUCboEditProvResidenza.ValoreMenuTendina.Length - 2, 2)
            listaParametri.Add("SiglaAutoProvincia", strSiglaAutoSel)
            listaComuni = operazioni.CaricaDatiFiltrati(Of ComuneItaliano)(listaParametri)
            LSUCboEditLuogoResidenza.PulisciElementi()

            For Each comune In listaComuni
                LSUCboEditLuogoResidenza.AggiungiElemento(comune.IdComune, comune.DenominazioneComune)
            Next

        End If

        If LSUCboEditProvResidenza.ValoreMenuTendina <> "" Then
            bModificatoAvv = True
        End If

    End Sub

    Private Sub LSUCboEditLuogoResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditLuogoResidenza.ValoreMenuTendinaCambiato

        If LSUCboEditLuogoResidenza.ValoreMenuTendina <> "" Then
            bModificatoAvv = True
        End If

    End Sub

    Private Sub LSUTxtInidirizzoResidenza_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtInidirizzoResidenza.ValoreCasellaTestoCambiato

        If LSUTxtInidirizzoResidenza.ValoreCasellaTesto <> "" Then
            bModificatoAvv = True
        End If

    End Sub

    Private Sub LSUTxtNazionalita_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNazionalita.ValoreCasellaTestoCambiato

        If LSUTxtNazionalita.ValoreCasellaTesto <> "" Then
            bModificatoAvv = True
        End If

    End Sub

    Private Sub LSUTxtEmail_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtEmail.ValoreCasellaTestoCambiato

        If LSUTxtEmail.ValoreCasellaTesto <> "" Then
            bModificatoAvv = True
        End If

    End Sub

    Private Sub LSUTxtEmailPEC_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtEmailPEC.ValoreCasellaTestoCambiato

        If LSUTxtEmailPEC.ValoreCasellaTesto <> "" Then
            bModificatoAvv = True
        End If

    End Sub

    Private Sub LSUDataIscrizAlboAvv_ValoreDataOraSelCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUDataIscrizAlboAvv.ValoreDataOraSelCambiato

        If LSUDataIscrizAlboAvv.ValoreDataOraSel.ToString <> "01/01/1753 00:00:00" Then
            bModificatoAvv = True
        End If

    End Sub

    Private Sub LSUDataIscrizAlboCass_ValoreDataOraSelCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUDataIscrizAlboCass.ValoreDataOraSelCambiato

        If LSUDataIscrizAlboCass.ValoreDataOraSel.ToString <> "01/01/1753 00:00:00" Then
            bModificatoAvv = True
        End If

    End Sub

    Private Sub LSUCboEditForoAppartenenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditForoAppartenenza.ValoreMenuTendinaCambiato

        If LSUCboEditForoAppartenenza.ValoreMenuTendina <> "" Then
            bModificatoAvv = True
        End If

    End Sub

    Private Sub LSUTxtNumTelStudio_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNumTelStudio.ValoreCasellaTestoCambiato

        If LSUTxtNumTelStudio.ValoreCasellaTesto <> "" Then
            bModificatoAvv = True
        End If

    End Sub

    Private Sub LSUTxtCellulare_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtCellulare.ValoreCasellaTestoCambiato

        If LSUTxtNumTelStudio.ValoreCasellaTesto <> "" Then
            bModificatoAvv = True
        End If

    End Sub

    Private Sub LSUTxtNumFaxStudio_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNumFaxStudio.ValoreCasellaTestoCambiato

        If LSUTxtNumFaxStudio.ValoreCasellaTesto <> "" Then
            bModificatoAvv = True
        End If

    End Sub

    Private Sub LSUCboEditProvNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditProvNascita.ValoreMenuTendinaCambiato
        Dim operazioni As New Operazioni
        Dim listaComuni As New List(Of ComuneItaliano)
        Dim listaParametri As New Dictionary(Of String, String)
        Dim strSiglaAutoSel As String = ""

        If LSUCboEditProvNascita.ValoreMenuTendina.Trim() <> "" Then

            bModificatoAvv = True

            'Carico tutti i comuni relativi alla provincia selezionata
            strSiglaAutoSel = Mid(LSUCboEditProvNascita.ValoreMenuTendina, LSUCboEditProvNascita.ValoreMenuTendina.Length - 2, 2)
            listaParametri.Add("SiglaAutoProvincia", strSiglaAutoSel)
            listaComuni = operazioni.CaricaDatiFiltrati(Of ComuneItaliano)(listaParametri)
            LSUCboEditLuogoNascita.PulisciElementi()

            For Each comune In listaComuni
                LSUCboEditLuogoNascita.AggiungiElemento(comune.IdComune, comune.DenominazioneComune)
            Next

        End If

    End Sub

    Private Sub LSUCboEditLuogoNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditLuogoNascita.ValoreMenuTendinaCambiato
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

            CalcolaCodiceFiscale()
        End If
    End Sub

    Private Sub LSUTxtIndirizzoStudio_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtIndirizzoStudio.ValoreCasellaTestoCambiato

        If LSUTxtIndirizzoStudio.ValoreCasellaTesto <> "" Then
            bModificatoAvv = True
        End If

    End Sub

    Private Sub UBtnConfermaAvvTrovato_Click(sender As Object, e As EventArgs) Handles UBtnConfermaAvvTrovato.Click
        mNomeCompletoAvvocato = LSUTxtNomeCompleto.ValoreCasellaTesto
        mIdAvvocato = UGrdAnaAvv.ActiveRow.Cells("IdPersona").Value
        Me.Close()
    End Sub

End Class