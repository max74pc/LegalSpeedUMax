Imports LSDBManager.LSDBContextNS
Imports LSDataModel.LSDataModelNS

Public Class FrmLogin

    Private Sub UBtnAnnulla_Click(sender As Object, e As EventArgs) Handles UBtnAnnulla.Click
        End
    End Sub

    Private Sub UBtnOk_Click(sender As Object, e As EventArgs) Handles UBtnOk.Click
        Dim frmMain As New FrmMain
        Dim operazioni As New Operazioni
        Dim listaUtenti As New List(Of Utente)
        Dim listaParametri As New Dictionary(Of String, String)
        Dim sPasswordCriptata As String = ""

        'Codifico la password
        If LSUTxtPassword.ValorePassword.Trim <> "" Then
            sPasswordCriptata = CodificaPwd(LSUTxtPassword.ValorePassword.Trim)
        End If

        'Creo la lista dei fitri di ricerca
        If sPasswordCriptata <> "" Then
            listaParametri.Add("PasswordCriptata", sPasswordCriptata)
        End If
        If Trim(LSUTxtNomeUtente.ValoreCasellaTesto <> "") Then
            listaParametri.Add("NomeUtente", LSUTxtNomeUtente.ValoreCasellaTesto)
        End If

        'Verifica Username e Password
        listaUtenti = operazioni.CaricaDatiFiltrati(Of Utente)(listaParametri)

        'If listaUtenti.Count = 1 Then
        Me.Hide()
        frmMain.Show()
        'Else
        'MessageBox.Show("Impossibile accedere.Dati inseriti non corretti")
        'End If
    End Sub

    ''' <summary>
    ''' Metodo che dato in input una stringa la decodifica con logiche Mie
    ''' </summary>
    ''' <param name="PwdCodificata"></param>
    ''' <returns></returns>
    Public Function DecodificaPwd(PwdCodificata As String) As String
        '/* TT 101294 */
        Dim Codice() As Integer
        Dim Chiave() As Integer
        ReDim Codice(48)
        ReDim Chiave(48)
        Dim StringaChiave As String
        Dim PwdDecodificata As String
        Dim LunghezzaPwd As Integer
        Dim Incremento As Integer
        Dim i As Integer

        On Error Resume Next
        LunghezzaPwd = Len(PwdCodificata)
        ' ATTENZIONE!!!! In StringaChiave  usare solo lettere maiuscole
        StringaChiave = "MARIAREGINADELLAPACEPREGAPERNOIEPERILMONDOINTERO"
        ' ATTENZIONE!!!! In StringaChiave  usare solo lettere maiuscole
        PwdDecodificata = ""
        Incremento = Asc(Mid$(PwdCodificata, 1, 1)) - Asc("[")
        For i = 1 To LunghezzaPwd - 1
            Chiave(i) = Asc(Mid$(StringaChiave, i, 1)) - Asc("M")
            Codice(i) = Asc(Mid$(PwdCodificata, i + 1, 1))
            Codice(i) = Codice(i) - Chiave(i) - Incremento - i
            PwdDecodificata = PwdDecodificata + Chr(Codice(i))
        Next i
        DecodificaPwd = PwdDecodificata
        Exit Function
    End Function

    ''' <summary>
    ''' Metodo che dato in input una stringa la codifica con logiche Mie
    ''' </summary>
    ''' <param name="PwdInchiaro"></param>
    ''' <returns></returns>
    Public Function CodificaPwd(ByVal PwdInchiaro As String) As String
        '/* TT 101294 */
        Dim Codice() As Integer
        Dim Chiave() As Integer
        ReDim Codice(48)
        ReDim Chiave(48)
        Dim StringaChiave As String
        Dim PwdCodificata As String
        Dim LunghezzaPwd As Integer
        Dim Somma As Integer
        Dim Incremento As Integer
        Dim I As Integer

        On Error Resume Next
        LunghezzaPwd = Len(PwdInchiaro)

        Somma = 0
        ' ATTENZIONE!!!! In StringaChiave  usare solo lettere maiuscole
        StringaChiave = "MARIAREGINADELLAPACEPREGAPERNOIEPERILMONDOINTERO"
        ' ATTENZIONE!!!! In StringaChiave  usare solo lettere maiuscole
        For I = 1 To LunghezzaPwd
            Chiave(I) = Asc(Mid(StringaChiave, I, 1)) - Asc("M")
            Codice(I) = Asc(Mid(PwdInchiaro, I, 1))
            Somma = Somma + Codice(I)
        Next I

        Incremento = (Somma Mod 7)
        PwdCodificata = Chr(Incremento + Asc("["))

        For I = 1 To LunghezzaPwd
            Codice(I) = Codice(I) + Chiave(I) + Incremento + I
            PwdCodificata = PwdCodificata + Chr(Codice(I))
        Next I

        CodificaPwd = PwdCodificata

        Exit Function

    End Function

End Class