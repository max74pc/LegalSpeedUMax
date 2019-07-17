Imports LSCommon.LSCommonNS
Imports LSDBManager.LSDBContextNS
Imports LSDataModel.LSDataModelNS
Imports System.Windows.Forms

Public Class LoginWindow
    Public WinFormTxtUsername As New LSUltraCasellaTesto.LSUltraCasellaTesto
    Public WinFormPWD As New LSUltraPassword.LSUltraPassword

    Private Sub BtnOK_Click(sender As Object, e As RoutedEventArgs) Handles BtnOK.Click
        Dim mainWindow As New MainWindow
        Dim listaParametri As New Dictionary(Of String, String)
        Dim sPasswordCriptata As String = ""

        Try
            'Codifico la password
            If WinFormPWD.ValorePassword.Trim <> "" Then
                sPasswordCriptata = ClsComune.CodificaPwd(WinFormPWD.ValorePassword.Trim)
            End If

            'Creo la lista dei fitri di ricerca
            If sPasswordCriptata <> "" Then
                listaParametri.Add("PasswordCriptata", sPasswordCriptata)
            End If
            If Trim(WinFormTxtUsername.ValoreCasellaTesto.Trim <> "") Then
                listaParametri.Add("NomeUtente", WinFormTxtUsername.ValoreCasellaTesto.Trim)
            End If

            'Verifica Username e Password
            Dim listaUtenti As List(Of Utente) = Operazioni.CaricaDatiFiltrati(Of Utente)(listaParametri)

            'If listaUtenti.Count = 1 Then
            ClsComune.GlbStrUserNameLS = WinFormTxtUsername.ValoreCasellaTesto.Trim
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
        Dim host1 As New Integration.WindowsFormsHost()
        Dim host2 As New Integration.WindowsFormsHost()
        WinFormTxtUsername.TestoEtichetta = "Username:"
        WinFormTxtUsername.LarghezzaEtichetta = 80
        WinFormTxtUsername.LarghezzaCasellaTesto = 255
        host1.Child = WinFormTxtUsername
        StackPanel1.Children.Add(host1)
        host2.Child = WinFormPWD
        StackPanel2.Children.Add(host2)
    End Sub
End Class
