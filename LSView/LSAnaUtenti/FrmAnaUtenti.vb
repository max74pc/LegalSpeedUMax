Imports LSDBManager.LSDBContextNS
Imports LSDataModel.LSDataModelNS
Imports LSCommon.LSCommonNS

Public Class FrmAnaUtenti

    Dim bDatoDettaglioCambiato As Boolean
    Dim bInseritoNuovoUtente As Boolean
    Dim bModificatoUtente As Boolean

    Public Sub InizializzaControlli()

        Dim listaUtenti As New List(Of Utente)

        Try
            UltraDockAnaUtenti.DockAreas(2).Size = New System.Drawing.Size(Me.Width, Me.Height - 81)
            UltraDockAnaUtenti.DockAreas(0).Size = New System.Drawing.Size(Me.Width, 81)

            listaUtenti = Operazioni.CaricaTutti(Of Utente)()
            UGrdAnaUtenti.DataSource = listaUtenti

            UGrdAnaUtenti.DisplayLayout.Bands(0).Columns(0).Hidden = True
            UGrdAnaUtenti.DisplayLayout.Bands(0).Columns(1).Header.Caption = "Nome Utente"
            UGrdAnaUtenti.DisplayLayout.Bands(0).Columns(2).Header.Caption = "Password Criptata"
            UGrdAnaUtenti.DisplayLayout.Bands(0).Columns(3).Hidden = True
            UGrdAnaUtenti.DisplayLayout.Bands(0).Columns(4).Hidden = True
            UGrdAnaUtenti.DisplayLayout.Bands(0).Columns(5).Hidden = True
            UGrdAnaUtenti.DisplayLayout.Bands(0).Columns(6).Hidden = True
            UGrdAnaUtenti.DisplayLayout.Bands(0).Columns(7).Hidden = True
            UGrdAnaUtenti.DisplayLayout.Bands(0).Columns(8).Hidden = True
            UGrdAnaUtenti.DisplayLayout.Bands(0).Columns(9).Hidden = True

        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaUtenti: Sub InizializzaControlli. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Public Sub SvuotaCampiDettaglio()
        Try
            LSUTxtNomeUtente.ValoreCasellaTesto = ""
            LSUPasswordDecriptata.ValoreCasellaTesto = ""
            UChkEditPermessoAnagrafiche.Checked = False
            UChkEditPermessoGestioneUtenti.Checked = False
            UChkEditPermessoFatt.Checked = False
            UChkEditPermessoGenAtti.Checked = False
            UChckEditAppEsterne.Checked = False
            UChckEditPermessoAgenda.Checked = False
            UChkEditPermessoUtility.Checked = False
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaUtenti: Sub SvuotaCampiDettaglio. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Public Sub CompilaCampiDatiDettaglio(ByVal utente As Utente)
        Try
            LSUTxtNomeUtente.ValoreCasellaTesto = utente.NomeUtente
            LSUPasswordDecriptata.ValoreCasellaTesto = ClsComune.DecodificaPwd(utente.PasswordCriptata)
            UChckEditPermessoAgenda.Checked = utente.PermessoAgenda
            UChkEditPermessoAnagrafiche.Checked = utente.PermessoAnagrafiche
            UChckEditAppEsterne.Checked = utente.PermessoAppEsterne
            UChkEditPermessoFatt.Checked = utente.PermessoFatturazione
            UChkEditPermessoGenAtti.Checked = utente.PermessoGenerazioneAtti
            UChkEditPermessoGestioneUtenti.Checked = utente.PermessoGestioneUtenti
            UChkEditPermessoUtility.Checked = utente.PermessoUtility
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaUtenti: Sub CompilaCampiDatiDettaglio. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Public Sub RicavaDatiDettaglioInseriti(ByVal utente As Utente)
        Try
            utente.NomeUtente = LSUTxtNomeUtente.ValoreCasellaTesto
            utente.PasswordCriptata = ClsComune.CodificaPwd(LSUPasswordDecriptata.ValoreCasellaTesto.ToString)
            utente.PermessoAgenda = IIf(UChckEditPermessoAgenda.Checked = True, 1, 0)
            utente.PermessoAnagrafiche = IIf(UChkEditPermessoAnagrafiche.Checked = True, 1, 0)
            utente.PermessoAppEsterne = IIf(UChckEditAppEsterne.Checked = True, 1, 0)
            utente.PermessoFatturazione = IIf(UChkEditPermessoFatt.Checked = True, 1, 0)
            utente.PermessoGenerazioneAtti = IIf(UChkEditPermessoGenAtti.Checked = True, 1, 0)
            utente.PermessoGestioneUtenti = IIf(UChkEditPermessoUtility.Checked = True, 1, 0)
            utente.PermessoUtility = IIf(UChkEditPermessoGestioneUtenti.Checked = True, 1, 0)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaUtenti: Sub RicavaDatiDettaglioInseriti. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub FrmAnaUtenti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized

            InizializzaControlli()
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaUtenti_Load. ", True, ClsComune.GlbStrUserNameLS, "", True)
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
            ClsComune.GestisciEccezzioni(ex, "FrmAnaUtenti: UltraPicBoxChiudiFinestra_MouseClick. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UGrdAnaUtenti_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles UGrdAnaUtenti.DoubleClickRow
        Dim intIdUtente As Integer
        Dim utente As New Utente
        Try
            If Not IsNothing(UGrdAnaUtenti.ActiveRow) Then
                intIdUtente = UGrdAnaUtenti.ActiveRow.Cells("IdUtente").Value
                utente = Operazioni.CaricaRigaDatoId(Of Utente)(intIdUtente)
                CompilaCampiDatiDettaglio(utente)
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaUtenti: UGrdAnaUtenti_DoubleClickRow. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxInserisciRiga_Click(sender As Object, e As EventArgs) Handles UPicBoxInserisciRiga.Click
        Try
            If bInseritoNuovoUtente Or bModificatoUtente Then
                'se ci sono modifiche nei dati di dettaglio do' un messaggio di avvertimento che verranno persi i dati

            End If
            'Svuoto tutti i campi di dettaglio
            SvuotaCampiDettaglio()
            bInseritoNuovoUtente = True
            bModificatoUtente = False
            UGrdAnaUtenti.ActiveRow = Nothing
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaUtenti: UPicBoxInserisciRiga_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxEliminaRiga_Click(sender As Object, e As EventArgs) Handles UPicBoxEliminaRiga.Click
        Dim intIdUtente As Integer
        Try
            If Not IsNothing(UGrdAnaUtenti.ActiveRow) Then
                intIdUtente = UGrdAnaUtenti.ActiveRow.Cells("IdUtente").Value
                Operazioni.Elimina(Of Utente)(intIdUtente)

                'aggiorno la griglia
                UGrdAnaUtenti.DataSource = Operazioni.CaricaTutti(Of Utente)()

            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaUtenti: UPicBoxEliminaRiga_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicercaDati_Click(sender As Object, e As EventArgs) Handles UPicBoxRicercaDati.Click
        Try
            If Trim(LSUTxtNomeUtenteRicerca.ValoreCasellaTesto <> "") Or Trim(LSUTxtPasswordRicerca.ValoreCasellaTesto) <> "" Then
                Dim listaUtenti As New List(Of Utente)
                Dim listaParametri As New Dictionary(Of String, String)

                'Creo la lista dei fitri di ricerca
                If Trim(LSUTxtNomeUtenteRicerca.ValoreCasellaTesto <> "") Then
                    listaParametri.Add("NomeUtente", LSUTxtNomeUtenteRicerca.ValoreCasellaTesto)
                End If
                If Trim(LSUTxtPasswordRicerca.ValoreCasellaTesto <> "") Then
                    listaParametri.Add("PasswordCriptata", ClsComune.CodificaPwd(LSUTxtPasswordRicerca.ValoreCasellaTesto))
                End If

                listaUtenti = Operazioni.CaricaDatiFiltrati(Of Utente)(listaParametri)
                UGrdAnaUtenti.DataSource = listaUtenti

            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaUtenti: UPicBoxRicercaDati_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxSalvaDati_Click(sender As Object, e As EventArgs) Handles UPicBoxSalvaDati.Click
        Dim intIdUtente As Integer = 0
        Dim utente As New Utente
        Dim pers As New Persona
        Try
            If bInseritoNuovoUtente Then

                'Ricavo il nuovo idAvvocato da aggiungere
                intIdUtente = Operazioni.RicavaMaxId(Of Utente)

                'Ricavo dai valori dei controlli tutti i nuovi dati da aggiungere e creo la nuova entità avvocato da aggiungere
                RicavaDatiDettaglioInseriti(utente)

                Operazioni.Aggiungi(Of Utente)(intIdUtente, utente)

            End If

            If bModificatoUtente And bInseritoNuovoUtente = False Then

                intIdUtente = UGrdAnaUtenti.ActiveRow.Cells("IdUtente").Value

                'Ricavo dai valori dei controlli tutti i nuovi dati da aggiungere e creo la nuova entità avvocato da aggiungere
                RicavaDatiDettaglioInseriti(utente)

                Operazioni.Aggiorna(Of Utente)(intIdUtente, utente)

                bModificatoUtente = False

            End If

            bInseritoNuovoUtente = False

            'aggiorno la griglia
            UGrdAnaUtenti.DataSource = Operazioni.CaricaTutti(Of Utente)()

        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaUtenti: UPicBoxSalvaDati_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UltraPicBoxChiudiFinestra_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxChiudiFinestra.MouseHover
        Try
            UPicBoxChiudiFinestra.Image = ImageListAnaUtenti.Images(1)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaUtenti: UltraPicBoxChiudiFinestra_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UltraPicBoxChiudiFinestra_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxChiudiFinestra.MouseLeave
        Try
            UPicBoxChiudiFinestra.Image = ImageListAnaUtenti.Images(0)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaUtenti: UltraPicBoxChiudiFinestra_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxSalvaDati_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxSalvaDati.MouseHover
        Try
            UPicBoxSalvaDati.Image = ImageListAnaUtenti.Images(3)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaUtenti: UPicBoxSalvaDati_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxSalvaDati_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxSalvaDati.MouseLeave
        Try
            UPicBoxSalvaDati.Image = ImageListAnaUtenti.Images(2)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaUtenti: UPicBoxSalvaDati_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxEliminaRiga_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxEliminaRiga.MouseHover
        Try
            UPicBoxEliminaRiga.Image = ImageListAnaUtenti.Images(5)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaUtenti: UPicBoxEliminaRiga_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxEliminaRiga_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxEliminaRiga.MouseLeave
        Try
            UPicBoxEliminaRiga.Image = ImageListAnaUtenti.Images(4)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaUtenti: UPicBoxEliminaRiga_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxInserisciRiga_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxInserisciRiga.MouseHover
        Try
            UPicBoxInserisciRiga.Image = ImageListAnaUtenti.Images(7)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaUtenti: UPicBoxInserisciRiga_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxInserisciRiga_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxInserisciRiga.MouseLeave
        Try
            UPicBoxInserisciRiga.Image = ImageListAnaUtenti.Images(6)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaUtenti: UPicBoxInserisciRiga_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicercaDati_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxRicercaDati.MouseHover
        Try
            UPicBoxRicercaDati.Image = ImageListAnaUtenti.Images(9)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaUtenti: UPicBoxRicercaDati_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicercaDati_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxRicercaDati.MouseLeave
        Try
            UPicBoxRicercaDati.Image = ImageListAnaUtenti.Images(8)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmAnaUtenti: UPicBoxRicercaDati_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUTxtNomeUtente_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUTxtNomeUtente.ValoreCasellaTestoCambiato
        If LSUTxtNomeUtente.ValoreCasellaTesto <> "" Then
            bModificatoUtente = True
        End If
    End Sub

    Private Sub LSUPasswordDecriptata_ValoreCasellaTestoCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUPasswordDecriptata.ValoreCasellaTestoCambiato
        If LSUPasswordDecriptata.ValoreCasellaTesto <> "" Then
            bModificatoUtente = True
        End If
    End Sub


End Class