Imports LSDBManager.LSDBContextNS
Imports LSDataModel.LSDataModelNS
Imports LSCommon.LSCommonNS

Public Class FrmLogin

    Private Sub UBtnAnnulla_Click(sender As Object, e As EventArgs) Handles UBtnAnnulla.Click
        Try
            End
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmLogin: UBtnAnnulla_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UBtnOk_Click(sender As Object, e As EventArgs) Handles UBtnOk.Click
        Dim frmMain As New FrmMain
        Dim listaUtenti As New List(Of Utente)
        Dim listaParametri As New Dictionary(Of String, String)
        Dim sPasswordCriptata As String = ""

        Try
            'Codifico la password
            If LSUTxtPassword.ValorePassword.Trim <> "" Then
                sPasswordCriptata = ClsComune.CodificaPwd(LSUTxtPassword.ValorePassword.Trim)
            End If

            'Creo la lista dei fitri di ricerca
            If sPasswordCriptata <> "" Then
                listaParametri.Add("PasswordCriptata", sPasswordCriptata)
            End If
            If Trim(LSUTxtNomeUtente.ValoreCasellaTesto <> "") Then
                listaParametri.Add("NomeUtente", LSUTxtNomeUtente.ValoreCasellaTesto)
            End If

            'Verifica Username e Password
            listaUtenti = Operazioni.CaricaDatiFiltrati(Of Utente)(listaParametri)

            If listaUtenti.Count = 1 Then
                ClsComune.GlbStrUserNameLS = LSUTxtNomeUtente.ValoreCasellaTesto
                Me.Hide()
                frmMain.Show()
            Else
                MessageBox.Show(Me, "Impossibile accedere!" & Environment.NewLine & "Dati inseriti non corretti", "Errore di autenticazione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmLogin: UBtnOk_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

End Class