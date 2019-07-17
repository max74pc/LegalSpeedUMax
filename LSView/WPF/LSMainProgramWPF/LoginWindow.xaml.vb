Imports LSCommon.LSCommonNS
Imports LSDBManager.LSDBContextNS
Imports LSDataModel.LSDataModelNS
Imports System.Windows.Forms

Public Class LoginWindow
    Private Sub BtnOK_Click(sender As Object, e As RoutedEventArgs) Handles BtnOK.Click
        Dim mainWindow As New MainWindow
        Dim listaParametri As New Dictionary(Of String, String)
        Dim sPasswordCriptata As String = ""

        Try
            'Codifico la password
            If PwdBox.Password.ToString.Trim <> "" Then
                sPasswordCriptata = ClsComune.CodificaPwd(PwdBox.Password.ToString.Trim)
            End If

            'Creo la lista dei fitri di ricerca
            If sPasswordCriptata <> "" Then
                listaParametri.Add("PasswordCriptata", sPasswordCriptata)
            End If
            If Trim(TxtEdUsername.Text.Trim <> "") Then
                listaParametri.Add("NomeUtente", TxtEdUsername.Text.Trim)
            End If

            'Verifica Username e Password
            Dim listaUtenti As List(Of Utente) = Operazioni.CaricaDatiFiltrati(Of Utente)(listaParametri)

            'If listaUtenti.Count = 1 Then
            ClsComune.GlbStrUserNameLS = TxtEdUsername.Text.Trim
            Me.Close()
            mainWindow.Show()
            'Else
            'MessageBox.Show(Me, "Impossibile accedere!" & Environment.NewLine & "Dati inseriti non corretti", "Errore di autenticazione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "LoginWindows: BtnOK_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub BtnAnnulla_Click(sender As Object, e As RoutedEventArgs) Handles BtnAnnulla.Click
        Try
            End
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "LoginWindows: BtnAnnulla_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Dim host As New Integration.WindowsFormsHost()
        Dim WinFormPWD As New LSUltraPassword.LSUltraPassword
        WinFormPWD.Visible = True
        host.Child = WinFormPWD
        MainGrid.Children.Add(host)
    End Sub
End Class
