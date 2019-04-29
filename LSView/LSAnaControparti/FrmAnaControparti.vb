Imports LSDBManager.LSDBContextNS
Imports LSDataModel.LSDataModelNS
Imports LSAnaPersone

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

        Dim operazioni As New Operazioni
        Dim listaControparti As New List(Of Controparte)
        Dim listaProvince As New List(Of Provincia)
        Dim listaNazioni As New List(Of Nazione)

        UBtnConfermaControparteTrovata.Visible = mVisualizzaDaAltraFinestra

        UltraDockAnaParti.DockAreas(2).Size = New System.Drawing.Size(Me.Width, Me.Height - 81)
        UltraDockAnaParti.DockAreas(0).Size = New System.Drawing.Size(Me.Width, 81)

        listaControparti = operazioni.CaricaTutti(Of Controparte)()
        UGrdAnaControparti.DataSource = listaControparti

        LSUDataNascita.SvuotaDataOra()

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

        'UGrdAnaParti.DisplayLayout.Bands(0).Columns(0).Hidden = True
        'UGrdAnaParti.DisplayLayout.Bands(0).Columns(1).Hidden = True
        'UGrdAnaParti.DisplayLayout.Bands(0).Columns(2).Header.Caption = "E-Mail PEC"
        'UGrdAnaParti.DisplayLayout.Bands(0).Columns(3).Header.Caption = "Foro di Apcontropartenenza"
        'UGrdAnaParti.DisplayLayout.Bands(0).Columns(4).Hidden = True
        'UGrdAnaParti.DisplayLayout.Bands(0).Columns(5).Hidden = True
        'UGrdAnaParti.DisplayLayout.Bands(0).Columns(6).Hidden = True
        'UGrdAnaParti.DisplayLayout.Bands(0).Columns(7).Hidden = True
        'UGrdAnaParti.DisplayLayout.Bands(0).Columns(8).Header.Caption = "Num. Cellulare"

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
        LSUCboEditTipoPersona.ValoreMenuTendina = ""
        LSUTxtIndirizzoSedeLegale.ValoreCasellaTesto = ""
        LSUTxtIndirizzoSedeOperativa.ValoreCasellaTesto = ""
        LSUTxtNomeLegaleRappr.ValoreCasellaTesto = ""
    End Sub

    Public Sub CompilaCampiDatiDettaglio(ByVal controparte As Controparte)

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
        Dim parte1CodiceFiscale As String = ""
        Dim parte2CodiceFiscale As String = ""
        Dim parte3CodiceFiscale As String = ""
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
                parte2CodiceFiscale = Data.ToString("yy") & ArrayMesi(mese - 1) & "0" & giorno.ToString()
            Else
                parte2CodiceFiscale = Data.ToString("yy") & ArrayMesi(mese - 1) & giorno.ToString()
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
                parte1CodiceFiscale = Cognome.Substring(0, 3).ToString
            Case Is = 2
                parte1CodiceFiscale = Cognome
                parte1CodiceFiscale = Cognome.Substring(0, 2).ToString & parte1CodiceFiscale(0).ToString
            Case Is = 1
                parte1CodiceFiscale = Cognome
                parte1CodiceFiscale = Cognome.Substring(0, 1).ToString & parte1CodiceFiscale(0).ToString
            Case Is = 0
                parte1CodiceFiscale = splitNomeCompleto(1).Trim()

                Select Case parte1CodiceFiscale.Length
                    Case Is = 3, Is > 4
                        parte1CodiceFiscale = parte1CodiceFiscale.Substring(0, 3).ToString
                    Case Is = 2
                        parte1CodiceFiscale = parte1CodiceFiscale.Substring(0, 2).ToString & "X"
                    Case Is = 1
                        parte1CodiceFiscale = parte1CodiceFiscale.Substring(0, 1).ToString & "XX"
                    Case Is = 0
                        parte1CodiceFiscale = "XXX"
                End Select
        End Select

        If parte1CodiceFiscale.Length = 2 Then
            parte1CodiceFiscale = parte1CodiceFiscale & "X"
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
                parte1CodiceFiscale = parte1CodiceFiscale & ArrayConsonanti(0).ToString & ArrayConsonanti(2).ToString & ArrayConsonanti(3).ToString
            Case Is = 3
                'Bruno = BRN
                ArrayConsonanti = Nome.ToArray
                parte1CodiceFiscale = parte1CodiceFiscale & ArrayConsonanti(0).ToString & ArrayConsonanti(1).ToString & ArrayConsonanti(2).ToString
            Case Is = 2
                'Luca = LCU
                ArrayConsonanti = Nome.ToArray
                sTEMP = Nome
                If sTEMP.Length > 0 Then
                    parte1CodiceFiscale = parte1CodiceFiscale & ArrayConsonanti(0).ToString & ArrayConsonanti(1).ToString & sTEMP(0).ToString
                Else
                    parte1CodiceFiscale = parte1CodiceFiscale & ArrayConsonanti(0).ToString & ArrayConsonanti(1).ToString & "X"
                End If
            Case Is = 1
                'Lia = LIA
                ArrayConsonanti = Nome.ToArray
                sTEMP = Nome
                If sTEMP.Length > 0 Then
                    parte1CodiceFiscale = parte1CodiceFiscale & ArrayConsonanti(0).ToString & sTEMP(0).ToString & sTEMP(1).ToString
                Else
                    parte1CodiceFiscale = parte1CodiceFiscale & ArrayConsonanti(0).ToString & "X"
                End If
            Case Is = 0
                Select Case splitNomeCompleto(0).Length
                    Case Is = 3, Is > 4
                        parte1CodiceFiscale = parte1CodiceFiscale & splitNomeCompleto(0).Substring(0, 3).ToString
                    Case Is = 2
                        parte1CodiceFiscale = parte1CodiceFiscale & splitNomeCompleto(0).Substring(0, 2).ToString & "X"
                    Case Is = 1
                        parte1CodiceFiscale = parte1CodiceFiscale & splitNomeCompleto(0).Substring(0, 1).ToString & "XX"
                    Case Is = 0
                        parte1CodiceFiscale = parte1CodiceFiscale & "XXX"
                End Select
        End Select

        'Ricavo il codice catasto dal nome del comune
        listaParametri.Add("CodiceCatasto", LSUCboEditLuogoNascita.ValoreMenuTendina)
        listaComuni = operazioni.CaricaDatiFiltrati(Of ComuneItaliano)(listaParametri)

        For Each comune In listaComuni
            sCodiceCatasto = comune.CodiceCatastaleComune
        Next

        parte2CodiceFiscale = parte2CodiceFiscale & sCodiceCatasto
        parte2CodiceFiscale = parte1CodiceFiscale & parte2CodiceFiscale
        parte3CodiceFiscale = StringCarattereControllo(parte2CodiceFiscale)

        LSUTxtCodiceFiscale.ValoreCasellaTesto = parte2CodiceFiscale & parte3CodiceFiscale

    End Sub

    Public Sub RicavaDatiDettaglioInseriti(ByVal controparte As Controparte)
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
    End Sub

    Private Sub FrmAnaContropocati_Load(sender As Object, e As EventArgs) Handles Me.Load

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

    Private Sub UGrdAnaControp_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles UGrdAnaControparti.DoubleClickRow
        Dim intIdPersona As Integer
        Dim operazioni As New Operazioni
        Dim controparte As New Controparte

        If Not IsNothing(UGrdAnaControparti.ActiveRow) Then
            intIdPersona = UGrdAnaControparti.ActiveRow.Cells("IdPersona").Value
            controparte = operazioni.CaricaRigaDatoId(Of Controparte)(intIdPersona)
            CompilaCampiDatiDettaglio(controparte)
        End If

    End Sub

    Private Sub UPicBoxInserisciRiga_Click(sender As Object, e As EventArgs) Handles UPicBoxInserisciRiga.Click
        If bInseritoNuovoControp Or bModificatoControp Then
            'se ci sono modifiche nei dati di dettaglio do' un messaggio di Contropertimento che verranno persi i dati

        End If
        'Svuoto tutti i campi di dettaglio
        SvuotaCampiDettaglio()
        bInseritoNuovoControp = True
        bModificatoControp = False
        UGrdAnaControparti.ActiveRow = Nothing
    End Sub

    Private Sub UPicBoxEliminaRiga_Click(sender As Object, e As EventArgs) Handles UPicBoxEliminaRiga.Click
        Dim intIdPersona As Integer
        Dim operazioni As New Operazioni

        If Not IsNothing(UGrdAnaControparti.ActiveRow) Then
            intIdPersona = UGrdAnaControparti.ActiveRow.Cells("IdPersona").Value
            operazioni.Elimina(Of Controparte)(intIdPersona)

            'aggiorno la griglia
            UGrdAnaControparti.DataSource = operazioni.CaricaTutti(Of Controparte)()

        End If

    End Sub

    Private Sub UPicBoxRicercaDati_Click(sender As Object, e As EventArgs) Handles UPicBoxRicercaDati.Click

        'If Trim(LSUTxtNominativoRicerca.ValoreCasellaTesto <> "") Or Trim(LSUTxtIndirizzoStudioRicerca.ValoreCasellaTesto) <> "" Then
        '    Dim operazioni As New Operazioni
        '    Dim listaContropocati As New List(Of Controparte)
        '    Dim listaParametri As New Dictionary(Of String, String)

        '    'Creo la lista dei fitri di ricerca
        '    If Trim(LSUTxtNominativoRicerca.ValoreCasellaTesto <> "") Then
        '        listaParametri.Add("Nominativo", LSUTxtNominativoRicerca.ValoreCasellaTesto)
        '    End If
        '    If Trim(LSUTxtIndirizzoStudioRicerca.ValoreCasellaTesto <> "") Then
        '        listaParametri.Add("IndirizzoStudio", LSUTxtIndirizzoStudioRicerca.ValoreCasellaTesto)
        '    End If

        '    listaContropocati = operazioni.CaricaDatiFiltrati(Of Controparte)(listaParametri)
        '    UGrdAnaParti.DataSource = listaContropocati

        'End If

    End Sub

    Private Sub UPicBoxSalvaDati_Click(sender As Object, e As EventArgs) Handles UPicBoxSalvaDati.Click
        Dim intIdPersona As Integer = 0
        Dim operazioni As New Operazioni
        Dim controparte As New Controparte
        Dim pers As New Persona

        If bInseritoNuovoControp Then

            'Ricavo il nuovo IdPersona da aggiungere
            intIdPersona = operazioni.RicavaMaxId(Of Controparte)

            'Ricavo dai valori dei controlli tutti i nuovi dati da aggiungere e creo la nuova entità Controparte da aggiungere
            RicavaDatiDettaglioInseriti(controparte)

            operazioni.Aggiungi(Of Controparte)(intIdPersona, controparte)

        End If

        If bModificatoControp = True And bInseritoNuovoControp = False Then

            intIdPersona = UGrdAnaControparti.ActiveRow.Cells("IdPersona").Value

            'Ricavo dai valori dei controlli tutti i nuovi dati da aggiungere e creo la nuova entità Controparte da aggiungere
            RicavaDatiDettaglioInseriti(controparte)

            operazioni.Aggiorna(Of Controparte)(intIdPersona, controparte)

            bModificatoControp = False

        End If

        bInseritoNuovoControp = False

        'aggiorno la griglia
        UGrdAnaControparti.DataSource = operazioni.CaricaTutti(Of Controparte)()

    End Sub

    Private Sub UltraPicBoxChiudiFinestra_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxChiudiFinestra.MouseHover
        UPicBoxChiudiFinestra.Image = ImageListAnaControparti.Images(1)
    End Sub

    Private Sub UltraPicBoxChiudiFinestra_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxChiudiFinestra.MouseLeave
        UPicBoxChiudiFinestra.Image = ImageListAnaControparti.Images(0)
    End Sub

    Private Sub UPicBoxSalvaDati_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxSalvaDati.MouseHover
        UPicBoxSalvaDati.Image = ImageListAnaControparti.Images(3)
    End Sub

    Private Sub UPicBoxSalvaDati_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxSalvaDati.MouseLeave
        UPicBoxSalvaDati.Image = ImageListAnaControparti.Images(2)
    End Sub

    Private Sub UPicBoxEliminaRiga_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxEliminaRiga.MouseHover
        UPicBoxEliminaRiga.Image = ImageListAnaControparti.Images(5)
    End Sub

    Private Sub UPicBoxEliminaRiga_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxEliminaRiga.MouseLeave
        UPicBoxEliminaRiga.Image = ImageListAnaControparti.Images(4)
    End Sub

    Private Sub UPicBoxInserisciRiga_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxInserisciRiga.MouseHover
        UPicBoxInserisciRiga.Image = ImageListAnaControparti.Images(7)
    End Sub

    Private Sub UPicBoxInserisciRiga_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxInserisciRiga.MouseLeave
        UPicBoxInserisciRiga.Image = ImageListAnaControparti.Images(6)
    End Sub

    Private Sub UPicBoxRicercaDati_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxRicercaDati.MouseHover
        UPicBoxRicercaDati.Image = ImageListAnaControparti.Images(9)
    End Sub

    Private Sub UPicBoxRicercaDati_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxRicercaDati.MouseLeave
        UPicBoxRicercaDati.Image = ImageListAnaControparti.Images(8)
    End Sub

    Private Sub LSUCboEditTipoPersona_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditTipoPersona.ValoreMenuTendinaCambiato

        If LSUCboEditTipoPersona.ValoreMenuTendina <> "" Then
            bModificatoControp = True
        End If

    End Sub

    Private Sub LSUTxtNomeCompleto_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNomeCompleto.ValoreCasellaTestoCambiato

        If LSUTxtNomeCompleto.ValoreCasellaTesto <> "" Then
            bModificatoControp = True
        End If

    End Sub

    Private Sub LSUDataNascita_ValoreDataOraSelCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUDataNascita.ValoreDataOraSelCambiato

        If LSUDataNascita.ValoreDataOraSel.ToString <> "01/01/1753 00:00:00" Then
            bModificatoControp = True
        End If

    End Sub

    Private Sub LSUCboEditSesso_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditSesso.ValoreMenuTendinaCambiato

        If LSUCboEditSesso.ValoreMenuTendina <> "" Then
            bModificatoControp = True
        End If

    End Sub

    Private Sub LSUCboEditStatoNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditStatoNascita.ValoreMenuTendinaCambiato

        If LSUCboEditStatoNascita.ValoreMenuTendina <> "" Then
            bModificatoControp = True
        End If

    End Sub

    Private Sub LSUTxtCodiceFiscale_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtCodiceFiscale.ValoreCasellaTestoCambiato

        If LSUTxtCodiceFiscale.ValoreCasellaTesto <> "" Then
            bModificatoControp = True
        End If

    End Sub

    Private Sub LSUTxtPartitaIVA_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtPartitaIVA.ValoreCasellaTestoCambiato

        If LSUTxtPartitaIVA.ValoreCasellaTesto <> "" Then
            bModificatoControp = True
        End If

    End Sub

    Private Sub LSUCboEditStatoResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditStatoResidenza.ValoreMenuTendinaCambiato

        If LSUCboEditStatoResidenza.ValoreMenuTendina <> "" Then
            bModificatoControp = True
        End If

    End Sub

    Private Sub LSUCboEditProvResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditProvResidenza.ValoreMenuTendinaCambiato

        Dim operazioni As New Operazioni
        Dim listaComuni As New List(Of ComuneItaliano)
        Dim listaParametri As New Dictionary(Of String, String)
        Dim strSiglaAutoSel As String = ""

        If LSUCboEditProvResidenza.ValoreMenuTendina.Trim() <> "" Then

            bModificatoControp = True

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
            bModificatoControp = True
        End If

    End Sub

    Private Sub LSUCboEditLuogoResidenza_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditLuogoResidenza.ValoreMenuTendinaCambiato

        If LSUCboEditLuogoResidenza.ValoreMenuTendina <> "" Then
            bModificatoControp = True
        End If

    End Sub

    Private Sub LSUTxtInidirizzoResidenza_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtInidirizzoResidenza.ValoreCasellaTestoCambiato

        If LSUTxtInidirizzoResidenza.ValoreCasellaTesto <> "" Then
            bModificatoControp = True
        End If

    End Sub

    Private Sub LSUTxtNazionalita_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNazionalita.ValoreCasellaTestoCambiato

        If LSUTxtNazionalita.ValoreCasellaTesto <> "" Then
            bModificatoControp = True
        End If

    End Sub

    Private Sub LSUTxtEmail_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtEmail.ValoreCasellaTestoCambiato

        If LSUTxtEmail.ValoreCasellaTesto <> "" Then
            bModificatoControp = True
        End If

    End Sub

    Private Sub LSUTxtEmailPEC_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtEmailPEC.ValoreCasellaTestoCambiato

        If LSUTxtEmailPEC.ValoreCasellaTesto <> "" Then
            bModificatoControp = True
        End If

    End Sub

    Private Sub LSUCboEditProvNascita_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditProvNascita.ValoreMenuTendinaCambiato
        Dim operazioni As New Operazioni
        Dim listaComuni As New List(Of ComuneItaliano)
        Dim listaParametri As New Dictionary(Of String, String)
        Dim strSiglaAutoSel As String = ""

        If LSUCboEditProvNascita.ValoreMenuTendina.Trim() <> "" Then

            bModificatoControp = True

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
            bModificatoControp = True
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

    Private Sub UPicBoxCaricaLegaleRappr_Click(sender As Object, e As EventArgs) Handles UPicBoxCaricaLegaleRappr.Click
        Dim dr As DialogResult
        dr = frmDllAnaPersone.ShowDialog()
        If dr = DialogResult.OK Then
            LSUTxtNomeLegaleRappr.ValoreCasellaTesto = frmDllAnaPersone._DenominazionePersona
            glbIdPersona = frmDllAnaPersone._IdPersona
        End If
    End Sub

    Private Sub UBtnConfermaContoparteTrovata_Click(sender As Object, e As EventArgs) Handles UBtnConfermaControparteTrovata.Click
        mDenominazioneControparte = LSUTxtNomeCompleto.ValoreCasellaTesto
        mIdControparte = UGrdAnaControparti.ActiveRow.Cells("IdPersona").Value
        Me.Close()
    End Sub
End Class