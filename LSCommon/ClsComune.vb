Option Infer On

Imports System.Windows.Forms
Imports System.Text
Imports System.IO
Imports System.Reflection
Imports System.Data.Entity

Namespace LSCommonNS

    Public Class ClsComune

        Public Shared Property GlbStrUserNameLS() As String

        ''' <summary>
        ''' gestore delle eccezioni
        ''' </summary>
        ''' <param name="ex">oggetto</param>
        ''' <param name="bVieneDaForm">Errore da form</param>
        ''' <param name="bVisualizzaMsg">Visualizza POPUP dettaglio di errore</param>
        ''' <returns>tripletta int-string-bool : 
        ''' integer = nr. di errore
        ''' string = messaggio aggiuntivo da visualizzare
        ''' true = errore riconosciuto/gestito, false=errore non gestito
        ''' </returns>
        Public Shared Function GestisciEccezzioni(ex As Exception,
                                                  Optional sChiHaGeneratoEccezzione As String = "",
                                                  Optional bVieneDaForm As Boolean = False,
                                                  Optional sUserName As String = "",
                                                  Optional sSql As String = "",
                                                  Optional bVisualizzaMsg As Boolean = False) As Tuple(Of Integer, String, Boolean)

            NotificaEccezzioneInFileLog(ex, sChiHaGeneratoEccezzione, bVieneDaForm, sUserName, sSql, bVisualizzaMsg)

            ' inizializza come errore non conosciuto
            Dim err As New Tuple(Of Integer, String, Boolean)(35, ex.Message, False)

            If (TypeOf (ex) Is SqlClient.SqlException) Then
                Dim ex2 = DirectCast(ex, SqlClient.SqlException)
                err = New Tuple(Of Integer, String, Boolean)(ex2.Number, ex2.Message, True)
            ElseIf (TypeOf (ex) Is Validation.DbEntityValidationException) Then
                Dim strFullErrorMessages As String = ""

                For Each a In DirectCast(ex, Validation.DbEntityValidationException).EntityValidationErrors
                    For Each b In a.ValidationErrors
                        strFullErrorMessages = strFullErrorMessages & "; " & b.ErrorMessage
                    Next
                Next

                Dim sMsgEccezzione = String.Concat(ex.Message, " Gli errori di validazione sono: ", Mid(strFullErrorMessages, 3, Len(strFullErrorMessages) - 2))
                err = New Tuple(Of Integer, String, Boolean)(35, sMsgEccezzione, True)
            End If

            Return err

        End Function

        ''' <summary>
        ''' Costruisce dettaglio eccezione e la inoltra nel file log
        ''' </summary>
        ''' <param name="ex"></param>
        ''' <param name="bVieneDaForm"></param>
        ''' <param name="sUserName"></param>
        ''' <param name="bNotificaAdUtente"></param>
        Public Shared Sub NotificaEccezzioneInFileLog(ex As Exception,
                                                      Optional sChiHaGeneratoEccezzione As String = "",
                                                      Optional bVieneDaForm As Boolean = False,
                                                      Optional sUserName As String = "",
                                                      Optional sSql As String = "",
                                                      Optional ByVal bNotificaAdUtente As Boolean = False)
            Dim strCtlName As String = ""
            Dim strFormName As String = ""
            Dim strText As String = ""
            Try
                If (bVieneDaForm) Then
                    If Not IsNothing(Form.ActiveForm) Then
                        strFormName = Form.ActiveForm.Name
                        If Not IsNothing(Form.ActiveForm.ActiveControl) Then
                            strCtlName = Form.ActiveForm.ActiveControl.Name
                            strText = Form.ActiveForm.ActiveControl.Text
                        End If
                    End If
                End If

                ' cerca di capire da Reflection se c'e' una form che ha generato l'errore
                Dim frm = RicavaUltimaFormChiamante()
                If (Not String.IsNullOrWhiteSpace(frm.Item1)) Then
                    strFormName = frm.Item1
                End If

                ' se parametro non precisato rileva l'utente corrente
                If (String.IsNullOrWhiteSpace(sUserName)) Then
                    sUserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name
                End If

                Dim sb = New StringBuilder()
                sb.AppendLine("")
                sb.AppendLine("------------------------------------------------------------------------------------------------------------------------")
                sb.AppendLine(String.Concat("Nome del computer           : ", System.Environment.GetEnvironmentVariable("COMPUTERNAME")))
                sb.AppendLine(String.Concat("Nome della Form             : ", strFormName))
                sb.AppendLine(String.Concat("Procededura                 : ", sChiHaGeneratoEccezzione))
                sb.AppendLine(String.Concat("Controllo attivo            : ", strCtlName, "; Text = ", strText))
                sb.AppendLine(String.Concat("Nome utente                 : ", sUserName))
                sb.AppendLine(String.Concat("Data/Ora                    : ", DateTime.Now.ToString()))
                sb.AppendLine(String.Concat("Descrizione dell'eccezzione : ", ex.Message))
                sb.AppendLine(String.Concat("Sorgente dell'eccezzione    : ", ex.Source))
                sb.AppendLine(String.Concat("Stack dell'eccezzione       : ", ex.StackTrace))
                If (ex.InnerException IsNot Nothing) Then _
                sb.AppendLine(String.Concat("InnerException              : ", ex.InnerException.Message))
                If bNotificaAdUtente Then
                    sb.AppendLine("Notifica ad utente                    : Si")
                Else
                    sb.AppendLine("Notifica ad utente                    : No")
                End If
                If (Not String.IsNullOrWhiteSpace(sSql)) Then _
                sb.AppendLine(String.Concat("SQL                         : ", sSql.Trim()))
                sb.AppendLine("------------------------------------------------------------------------------------------------------------------------")

                ScriviInFileLog(sb.ToString())

                If (bNotificaAdUtente) Then
                    'Notifico a video l'errore
                    MessageBox.Show("Utente: " & GlbStrUserNameLS & Environment.NewLine &
                                    "Procedura: " & sChiHaGeneratoEccezzione & Environment.NewLine &
                                    "Errore: " & ex.Message, ex.Source,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
                End If
            Catch exc As Exception
                ScriviInFileLog("Errore in LSCommonNS.ClsComune.NotificaEccezzioneInFileLog : " & exc.Message)
            End Try
        End Sub

        ''' <summary>
        ''' restituisce il nome la form chiamante-nome assembly dallo stack trace corrente
        ''' </summary>
        ''' <returns>coppia classe-assembly</returns>
        ''' <remarks>la ricerca nello stack avviene per assembly sullo stesso path di quello corrente</remarks>
        Friend Shared Function RicavaUltimaFormChiamante() As Tuple(Of String, String)
            Try
                ' path assembly corrente
                Dim currentAssemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)

                ' stack chiamate per arrivare qui
                Dim frames = New StackTrace().GetFrames()

                ' tutti gli assembly chimati per arrivare qui
                Dim allAssembly = From f In frames
                                  Select f.GetMethod().ReflectedType.Assembly

                ' solo assembly univoci
                Dim distinctAssembly = (From f In frames
                                        Select f.GetMethod().ReflectedType.Assembly
                         ).Distinct()

                ' solo gli assembly del path assembly corrente
                Dim distinctAssemblyCurrentPath = distinctAssembly.Where(Function(x) Path.GetDirectoryName(x.Location) = currentAssemblyPath)

                ' stack solo del path locale
                Dim framesCurrentPath = frames.Where(Function(x) distinctAssemblyCurrentPath.Contains(x.GetMethod().ReflectedType.Assembly))

                Dim FramesFormsCurrentPath As New List(Of StackFrame)
                ' solo i frames di tipo windows form o ereditano da windows form
                ' o che riflettono windows form
                ' il problema nasce quando la richiesta di xmesso e' su un thread separato : si deve cercare in ReflectedType
                For Each frm In framesCurrentPath
                    If (frm.GetMethod().DeclaringType?.BaseType?.FullName = "System.Windows.Forms.Form" OrElse
                    frm.GetMethod().DeclaringType?.BaseType?.BaseType?.FullName = "System.Windows.Forms.Form" OrElse
                    frm.GetMethod().DeclaringType?.BaseType?.BaseType?.BaseType?.FullName = "System.Windows.Forms.Form" OrElse
                    frm.GetMethod().ReflectedType?.DeclaringType?.BaseType?.FullName = "System.Windows.Forms.Form" OrElse
                    frm.GetMethod().ReflectedType?.DeclaringType?.BaseType?.BaseType?.FullName = "System.Windows.Forms.Form") Then
                        FramesFormsCurrentPath.Add(frm)
                    End If
                Next

                ' nomi files assembly forms singole
                Dim distinctAssemblyFormsFileName = FramesFormsCurrentPath.Select(Function(x) Path.GetFileName(x.GetMethod().ReflectedType.Assembly.Location)).Distinct()

                ' solo i nomi forms singoli a doppio livello di DeclaringType
                Dim distinctForms = FramesFormsCurrentPath.Select(Function(x) x.GetMethod().DeclaringType?.DeclaringType?.FullName).Distinct()

                ' nome completo classe ultima form chiamante
                Dim lastFormName = distinctForms.FirstOrDefault()

                ' se vuota occorre cercare e fermarsi al primo livello di DeclaringType
                If (String.IsNullOrWhiteSpace(lastFormName)) Then
                    distinctForms = FramesFormsCurrentPath.Select(Function(x) x.GetMethod().DeclaringType?.FullName).Distinct()
                    lastFormName = distinctForms.FirstOrDefault()
                End If

                ' nome file assembly ultima form chiamante
                Dim lastFormFileName = distinctAssemblyFormsFileName.FirstOrDefault()

                Return New Tuple(Of String, String)(lastFormName, lastFormFileName)
            Catch ex As Exception
                Return New Tuple(Of String, String)("", "")
            End Try
        End Function

        Public Shared Sub ScriviInFileLog(strMessage As String)
            Dim strFile As String = Application.StartupPath() & "\Log\LogFile-" & Now.Day & "." & Now.Month & "." & Now.Year & ".txt"
            Dim fileExists As Boolean = File.Exists(strFile)
            Try
                Using sw As New StreamWriter(File.Open(strFile, FileMode.OpenOrCreate))
                    sw.Write(IIf(fileExists, strMessage, ""))
                End Using
            Catch ex As Exception
                GestisciEccezzioni(ex, "LSCommon.ClsComune: Sub ScriviInFileLog. ", False, GlbStrUserNameLS, "", True)
            End Try
        End Sub

        Private Shared Function StringCarattereControllo(ByVal CodiceFiscale As String) As String
            Dim sommapari As Integer = 0
            Dim sommadispari As Integer = 0
            Dim ArrayChar() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
            Dim ArrayCharPosizioneDispari() As Integer = {1, 0, 5, 7, 9, 13, 15, 17, 19, 21, 2, 4, 18, 20, 11, 3, 6, 8, 12, 14, 16, 10, 22, 25, 24, 23}
            Dim ArrayPari As New ArrayList
            Dim ArrayDispari As New ArrayList

            Try
                Dim risultato As Integer
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
                            sommapari += ArrayPari(i).ToString
                        Else
                            For j As Integer = 0 To ArrayChar.Length - 1 Step 1
                                If (UCase(ArrayPari(i).ToString) = ArrayChar(j).ToString) Then
                                    sommapari += j
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                    For i As Integer = 0 To ArrayDispari.Count - 1 Step 1
                        If IsNumeric(ArrayDispari(i).ToString) Then
                            sommadispari += ArrayCharPosizioneDispari(ArrayDispari(i).ToString).ToString
                        Else
                            For j As Integer = 0 To ArrayChar.Length - 1 Step 1
                                If (UCase(ArrayDispari(i).ToString) = ArrayChar(j).ToString) Then
                                    sommadispari += ArrayCharPosizioneDispari(j).ToString
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
                GestisciEccezzioni(ex, "LSCommon.ClsComune: Function StringCarattereControllo. ", False, GlbStrUserNameLS, "", True)
                Return "X"
            End Try
        End Function

        Public Shared Function CalcolaCodiceFiscale(sNomeCompleto As String, dtDataNascita As Date,
                                                    sSesso As String, sCodiceCatasto As String) As String
            Dim sCognome As String
            Dim sNome As String
            Dim ArrayMesi() As String = {"A", "B", "C", "D", "E", "H", "L", "M", "P", "R", "S", "T"} 'Lettere che corrispondono al mese
            Dim ArrayConsonantiTemp() As String = {"B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Y", "Z"}
            Dim ArrayVocali() As String = {"A", "E", "I", "O", "U"}
            Dim Parte1CodiceFiscale As String = ""
            Dim Parte2CodiceFiscale As String = ""
            Dim ArrayConsonanti As Array
            Dim giorno As Integer
            Dim mese As Integer
            Dim sNomeTEMP As String
            Dim splitNomeCompleto() As String

            Try

                splitNomeCompleto = Split(sNomeCompleto, " ")

                sNome = UCase(splitNomeCompleto(0).Trim())
                sCognome = UCase(splitNomeCompleto(1).Trim())
                giorno = dtDataNascita.Day
                mese = dtDataNascita.Month

                If IsDate(dtDataNascita) Then

                    If (sSesso = "FEMMINA") Then
                        giorno += 40
                    End If

                    If giorno < 10 Then
                        Parte2CodiceFiscale = dtDataNascita.ToString("yy") & ArrayMesi(mese - 1) & "0" & giorno.ToString()
                    Else
                        Parte2CodiceFiscale = dtDataNascita.ToString("yy") & ArrayMesi(mese - 1) & giorno.ToString()
                    End If

                End If

                If sCognome.Length > 0 Then

                    For i As Integer = 0 To sCognome.Length - 1
                        For j As Integer = 0 To ArrayVocali.Length - 1
                            sCognome = sCognome.ToString.Replace(ArrayVocali(j).ToString, "")
                        Next
                    Next
                End If

                Select Case sCognome.Length
                    Case Is = 3, Is > 3
                        Parte1CodiceFiscale = sCognome.Substring(0, 3).ToString
                    Case Is = 2
                        Parte1CodiceFiscale = sCognome
                        Parte1CodiceFiscale = sCognome.Substring(0, 2).ToString & Parte1CodiceFiscale(0).ToString
                    Case Is = 1
                        Parte1CodiceFiscale = sCognome
                        Parte1CodiceFiscale = sCognome.Substring(0, 1).ToString & Parte1CodiceFiscale(0).ToString
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
                    Parte1CodiceFiscale &= "X"
                End If

                sNomeTEMP = sNome
                If sNome.Length > 2 Then
                    For i As Integer = 0 To sNome.Length - 1
                        For j As Integer = 0 To ArrayVocali.Length - 1
                            sNome = sNome.ToString.Replace(ArrayVocali(j).ToString, "")
                        Next
                    Next
                End If

                If sNomeTEMP.Length > 2 Then
                    For i As Integer = 0 To sNomeTEMP.Length - 1
                        For j As Integer = 0 To ArrayConsonantiTemp.Length - 1
                            sNomeTEMP = sNomeTEMP.ToString.Replace(ArrayConsonantiTemp(j).ToString, "")
                        Next
                    Next
                End If

                Select Case sNome.Length
                    Case Is = 4, Is > 4
                        'Mariangela = MNG
                        'Aldo Maria = LMR
                        ArrayConsonanti = sNome.ToArray
                        Parte1CodiceFiscale = Parte1CodiceFiscale & ArrayConsonanti(0).ToString & ArrayConsonanti(2).ToString & ArrayConsonanti(3).ToString
                    Case Is = 3
                        'Bruno = BRN
                        ArrayConsonanti = sNome.ToArray
                        Parte1CodiceFiscale = Parte1CodiceFiscale & ArrayConsonanti(0).ToString & ArrayConsonanti(1).ToString & ArrayConsonanti(2).ToString
                    Case Is = 2
                        'Luca = LCU
                        ArrayConsonanti = sNome.ToArray
                        If sNome.Length > 0 Then
                            Parte1CodiceFiscale = Parte1CodiceFiscale & ArrayConsonanti(0).ToString & ArrayConsonanti(1).ToString & sNomeTEMP(0).ToString
                        Else
                            Parte1CodiceFiscale = Parte1CodiceFiscale & ArrayConsonanti(0).ToString & ArrayConsonanti(1).ToString & "X"
                        End If
                    Case Is = 1
                        'Lia = LIA
                        ArrayConsonanti = sNome.ToArray
                        If sNome.Length > 0 Then
                            Parte1CodiceFiscale = Parte1CodiceFiscale & ArrayConsonanti(0).ToString & sNomeTEMP(0).ToString & sNomeTEMP(1).ToString
                        Else
                            Parte1CodiceFiscale = Parte1CodiceFiscale & ArrayConsonanti(0).ToString & "XX"
                        End If
                    Case Is = 0
                        Select Case splitNomeCompleto(0).Length
                            Case Is = 3, Is > 4
                                Parte1CodiceFiscale &= splitNomeCompleto(0).Substring(0, 3).ToString
                            Case Is = 2
                                Parte1CodiceFiscale = Parte1CodiceFiscale & splitNomeCompleto(0).Substring(0, 2).ToString & "X"
                            Case Is = 1
                                Parte1CodiceFiscale = Parte1CodiceFiscale & splitNomeCompleto(0).Substring(0, 1).ToString & "XX"
                            Case Is = 0
                                Parte1CodiceFiscale &= "XXX"
                        End Select
                End Select

                Parte2CodiceFiscale &= sCodiceCatasto
                Parte2CodiceFiscale = Parte1CodiceFiscale & Parte2CodiceFiscale
                Dim Parte3CodiceFiscale As String = StringCarattereControllo(Parte2CodiceFiscale)

                CalcolaCodiceFiscale = Parte2CodiceFiscale & Parte3CodiceFiscale
            Catch ex As Exception
                GestisciEccezzioni(ex, "LSCommon.ClsComune: Function CalcolaCodiceFiscale. ", False, GlbStrUserNameLS, "", True)
                Return ""
            End Try
        End Function

        ''' <summary>
        ''' Metodo che dato in input una stringa la decodifica con logiche Mie
        ''' </summary>
        ''' <param name="sPwdCodificata"></param>
        ''' <returns></returns>
        Public Shared Function DecodificaPwd(sPwdCodificata As String) As String
            '/* TT 101294 */
            Dim iCodice() As Integer
            Dim iChiave() As Integer
            ReDim iCodice(48)
            ReDim iChiave(48)
            Dim sStringaChiave As String
            Dim sPwdDecodificata As String
            Dim iLunghezzaPwd As Integer
            Dim iIncremento As Integer
            Dim i As Integer

            Try

                iLunghezzaPwd = Len(sPwdCodificata)
                ' ATTENZIONE!!!! In StringaChiave  usare solo lettere maiuscole
                sStringaChiave = "MARIAREGINADELLAPACEPREGAPERNOIEPERILMONDOINTERO"
                ' ATTENZIONE!!!! In StringaChiave  usare solo lettere maiuscole
                sPwdDecodificata = ""
                iIncremento = Asc(Mid$(sPwdCodificata, 1, 1)) - Asc("[")
                For i = 1 To iLunghezzaPwd - 1
                    iChiave(i) = Asc(Mid$(sStringaChiave, i, 1)) - Asc("M")
                    iCodice(i) = Asc(Mid$(sPwdCodificata, i + 1, 1))
                    iCodice(i) = iCodice(i) - iChiave(i) - iIncremento - i
                    sPwdDecodificata += Chr(iCodice(i))
                Next i
                DecodificaPwd = sPwdDecodificata
            Catch ex As Exception
                GestisciEccezzioni(ex, "LSCommon.ClsComune: Function DecodificaPwd. ", False, GlbStrUserNameLS, "", True)
                Return ""
            End Try
        End Function

        ''' <summary>
        ''' Metodo che dato in input una stringa la codifica con logiche Mie
        ''' </summary>
        ''' <param name="sPwdInchiaro"></param>
        ''' <returns></returns>
        Public Shared Function CodificaPwd(ByVal sPwdInchiaro As String) As String
            '/* TT 101294 */
            Dim iCodice() As Integer
            Dim iChiave() As Integer
            ReDim iCodice(48)
            ReDim iChiave(48)
            Dim sStringaChiave As String
            Dim sPwdCodificata As String
            Dim iLunghezzaPwd As Integer
            Dim iSomma As Integer
            Dim iIncremento As Integer
            Dim I As Integer

            Try
                iLunghezzaPwd = Len(sPwdInchiaro)

                iSomma = 0
                ' ATTENZIONE!!!! In StringaChiave  usare solo lettere maiuscole
                sStringaChiave = "MARIAREGINADELLAPACEPREGAPERNOIEPERILMONDOINTERO"
                ' ATTENZIONE!!!! In StringaChiave  usare solo lettere maiuscole
                For I = 1 To iLunghezzaPwd
                    iChiave(I) = Asc(Mid(sStringaChiave, I, 1)) - Asc("M")
                    iCodice(I) = Asc(Mid(sPwdInchiaro, I, 1))
                    iSomma += iCodice(I)
                Next I

                iIncremento = (iSomma Mod 7)
                sPwdCodificata = Chr(iIncremento + Asc("["))

                For I = 1 To iLunghezzaPwd
                    iCodice(I) = iCodice(I) + iChiave(I) + iIncremento + I
                    sPwdCodificata += Chr(iCodice(I))
                Next I

                CodificaPwd = sPwdCodificata
            Catch ex As Exception
                GestisciEccezzioni(ex, "LSCommon.ClsComune: Function CodificaPwd. ", False, GlbStrUserNameLS, "", True)
                Return ""
            End Try
        End Function

    End Class

End Namespace