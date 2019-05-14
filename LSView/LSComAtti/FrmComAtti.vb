
Imports System.Runtime.InteropServices
Imports Infragistics.Win.UltraWinTree
Imports LSDBManager.LSDBContextNS
Imports LSDataModel.LSDataModelNS
Imports Spire.Doc
Imports LSAnaAvvocati
Imports LSAnaParti
Imports LSAnaControparti
Imports LSCommon.LSCommonNS

Public Class FrmComAtti

    Private glbIdAvv As Integer
    Private glbIdParte As Integer
    Private glbIdControparte As Integer
    Private sGlbNomeAtto As String

    Public frmDllAnaAvv As New FrmAnaAvvocati With {
            ._VisualizzaDaAltraFinestra = True
        }

    Public frmDllAnaControParti As New FrmAnaControparti With {
            ._VisualizzaDaAltraFinestra = True
        }

    Public frmDllAnaParti As New FrmAnaParti With {
        ._VisualizzaDaAltraFinestra = True
    }
    Private Sub FrmComAtti_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim listaTipiEnti As New List(Of TipoEnteGiuridico)
        Try
            Me.WindowState = FormWindowState.Maximized
            UltraDockManagerComAtti.DockAreas(0).Size = New System.Drawing.Size(Me.Width, Me.Height - 86)
            UltraDockManagerComAtti.DockAreas(2).Size = New System.Drawing.Size(Me.Width, 86)
            Spire.License.LicenseProvider.SetLicenseFileFullPath("D:\ProgettiVS2017\LegalSpeedUMax\LSView\LSComAtti\license.elic.xml")

            'Carico tutte le tipologie di enti nel cosrrispondente menu a tendina
            listaTipiEnti = Operazioni.CaricaTutti(Of TipoEnteGiuridico)

            For Each tipiEnti In listaTipiEnti
                LSUCboEditTipoEnte.AggiungiElemento(tipiEnti.IdTipoEnteGiuridico, tipiEnti.DescrizioneTipoEnteGiuridico.Trim())
            Next
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti_Load. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UltraPicBoxChiudiFinestra_MouseHover(sender As Object, e As EventArgs) Handles UltraPicBoxChiudiFinestra.MouseHover
        Try
            UltraPicBoxChiudiFinestra.Image = ImageListComAtti.Images(1)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: UltraPicBoxChiudiFinestra_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UltraPicBoxChiudiFinestra_MouseLeave(sender As Object, e As EventArgs) Handles UltraPicBoxChiudiFinestra.MouseLeave
        Try
            UltraPicBoxChiudiFinestra.Image = ImageListComAtti.Images(0)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: UltraPicBoxChiudiFinestra_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UltraPicBoxGenDoc_MouseHover(sender As Object, e As EventArgs) Handles UltraPicBoxGenDoc.MouseHover
        Try
            UltraPicBoxGenDoc.Image = ImageListComAtti.Images(3)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: UltraPicBoxGenDoc_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UltraPicBoxGenDoc_MouseLeave(sender As Object, e As EventArgs) Handles UltraPicBoxGenDoc.MouseLeave
        Try
            UltraPicBoxGenDoc.Image = ImageListComAtti.Images(2)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: UltraPicBoxGenDoc_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UltraPicBoxNewModel_MouseHover(sender As Object, e As EventArgs) Handles UltraPicBoxNewModel.MouseHover
        Try
            UltraPicBoxNewModel.Image = ImageListComAtti.Images(5)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: UltraPicBoxNewModel_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UltraPicBoxNewModel_MouseLeave(sender As Object, e As EventArgs) Handles UltraPicBoxNewModel.MouseLeave
        Try
            UltraPicBoxNewModel.Image = ImageListComAtti.Images(4)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: UltraPicBoxNewModel_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UltraPictBoxNewCat_MouseHover(sender As Object, e As EventArgs) Handles UltraPictBoxNewCat.MouseHover
        Try
            UltraPictBoxNewCat.Image = ImageListComAtti.Images(7)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: UltraPictBoxNewCat_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UltraPictBoxNewCat_MouseLeave(sender As Object, e As EventArgs) Handles UltraPictBoxNewCat.MouseLeave
        Try
            UltraPictBoxNewCat.Image = ImageListComAtti.Images(6)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: UltraPictBoxNewCat_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicavaAvv_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxRicavaAvv.MouseHover
        Try
            UPicBoxRicavaAvv.Image = ImageListComAtti2.Images(1)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: UPicBoxRicavaAvv_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicavaAvv_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxRicavaAvv.MouseLeave
        Try
            UPicBoxRicavaAvv.Image = ImageListComAtti2.Images(0)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: UPicBoxRicavaAvv_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicavaParte_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxRicavaParte.MouseHover
        Try
            UPicBoxRicavaParte.Image = ImageListComAtti2.Images(1)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: UPicBoxRicavaParte_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicavaParte_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxRicavaParte.MouseLeave
        Try
            UPicBoxRicavaParte.Image = ImageListComAtti2.Images(0)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: UPicBoxRicavaParte_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicavaControparte_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxRicavaControparte.MouseHover
        Try
            UPicBoxRicavaControparte.Image = ImageListComAtti2.Images(1)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: UPicBoxRicavaControparte_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicavaControparte_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxRicavaControparte.MouseLeave
        Try
            UPicBoxRicavaControparte.Image = ImageListComAtti2.Images(0)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: UPicBoxRicavaControparte_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UltraPicBoxChiudiFinestra_MouseClick(sender As Object, e As MouseEventArgs) Handles UltraPicBoxChiudiFinestra.MouseClick
        Try
            Me.Close()
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: UltraPicBoxChiudiFinestra_MouseClick. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UltraTreeModelliAtti_DoubleClick(sender As Object, e As EventArgs) Handles UltraTreeModelliAtti.DoubleClick
        Dim node As UltraTreeNode = UltraTreeModelliAtti.ActiveNode
        Dim strPathModelli As String = "D:\ProgettiVS2017\LegalSpeedUMax\Modelli Atti\"
        Try
            Select Case node.Text
                Case "Ricorso per Decreto Ingiuntivo"
                    DocViewer1.LoadFromFile(strPathModelli & "ricorso per decreto iniguntivo.odt")
                Case "Atto di Precetto"
                    DocViewer1.LoadFromFile(strPathModelli & "ATTO DI PRECETTO ALFACND SRL.odt")
            End Select
            sGlbNomeAtto = node.Text
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: UltraTreeModelliAtti_DoubleClick. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub LSUCboEditTipoEnte_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditTipoEnte.ValoreMenuTendinaCambiato
        Try
            If LSUCboEditTipoEnte.ValoreMenuTendina <> "" Then
                'Carico tutte i nomi delle sedi del tipo ente selezionato
                Dim listaEntiGiuridici As New List(Of EnteGiuridico)
                Dim listaEntiGiuridiciOrdinato As New List(Of EnteGiuridico)
                Dim listaParametri As New Dictionary(Of String, String) From {
                {"TipoEnteGiuridico", LSUCboEditTipoEnte.ValoreMenuTendina}
            }
                Dim iPosizioneStringa As Integer = 0
                Dim strSedeEnte As String = ""
                Dim dizionarioEnti As New Dictionary(Of Integer, String)

                listaEntiGiuridici = Operazioni.CaricaDatiFiltrati(Of EnteGiuridico)(listaParametri)

                LSUCboEditSedeEnte.PulisciElementi()

                For Each ente In listaEntiGiuridici
                    Select Case ente.IdTipoEnteGiuridico
                        Case 1
                            iPosizioneStringa = 20
                        Case 2
                            iPosizioneStringa = 17
                        Case 3
                            iPosizioneStringa = 41
                        Case 4
                            iPosizioneStringa = 21
                        Case 5
                            iPosizioneStringa = 32
                        Case 6
                            iPosizioneStringa = 20
                        Case 7
                            iPosizioneStringa = 80
                        Case 8
                            iPosizioneStringa = 65
                        Case 9
                            If ente.DenominazioneEnte.Contains("Cassazione") Then
                                iPosizioneStringa = 75
                            Else
                                iPosizioneStringa = 65
                            End If
                        Case 10
                            iPosizioneStringa = 26
                        Case 11
                            iPosizioneStringa = 45
                        Case 12
                            iPosizioneStringa = 30
                        Case 13
                            iPosizioneStringa = 24
                        Case 14
                            iPosizioneStringa = 30
                        Case 15
                            iPosizioneStringa = 76
                    End Select

                    strSedeEnte = Mid(ente.DenominazioneEnte, iPosizioneStringa, Len(ente.DenominazioneEnte) - (iPosizioneStringa - 1)).Trim()

                    dizionarioEnti.Add(ente.IdEnteGiuridico, strSedeEnte)
                Next

                Dim ordinato = From paia In dizionarioEnti
                               Order By paia.Value
                Dim dizionarioEntiOrdinato = ordinato.ToDictionary(Function(p) p.Key, Function(p) p.Value)

                For Each elemento In dizionarioEntiOrdinato
                    LSUCboEditSedeEnte.AggiungiElemento(elemento.Key, elemento.Value)
                Next
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: LSUCboEditTipoEnte_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UltraPicBoxGenDoc_Click(sender As Object, e As EventArgs) Handles UltraPicBoxGenDoc.Click
        Try
            'Validazione Campi Obbligatori
            'TODO

            'Generazione Documento
            GeneraDocumento()
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: UltraPicBoxGenDoc_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub GeneraDocumento()
        Try
            Select Case sGlbNomeAtto
                Case "Ricorso per Decreto Ingiuntivo"
                    GeneraDecretoIngiuntivo()
                Case "Atto di Precetto"
                    GeneraAttoDiPrecetto()
            End Select
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: Sub GeneraDocumento. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Public Sub GeneraDecretoIngiuntivo()
        Dim document As New Document()
        Dim listaParti As New List(Of Parte)
        Dim listaControparti As New List(Of Controparte)
        Dim listaLegaliRapprParte As New List(Of Persona)
        Dim listaLegaliRapprControparte As New List(Of Persona)
        Dim listaAvv As New List(Of Avvocato)

        Try
            'Apro il file del modello
            document.LoadFromFile("D:\ProgettiVS2017\LegalSpeedUMax\Modelli Atti\ricorso per decreto iniguntivo.odt")

            document.Replace("{TipoEnte}", UCase(LSUCboEditTipoEnte.ValoreMenuTendina), False, True)
            document.Replace("{SedeEnte}", UCase(LSUCboEditSedeEnte.ValoreMenuTendina), False, True)

            'Ricavo i dati della parte
            Dim listaParametriParte As New Dictionary(Of String, String) From {
                {"IdParte", glbIdParte}
            }
            listaParti = Operazioni.CaricaDatiFiltrati(Of Parte)(listaParametriParte)
            For Each parte In listaParti
                document.Replace("{Parte.Denominazione}", parte.NomeCompleto, False, True)
                document.Replace("{Parte.PartitaIVA}", parte.PartitaIVA, False, True)
                document.Replace("{Parte.IndirizzoSedeLegale}", parte.IndirizzoSedeLegale, False, True)

                'Ricavo i dati del legale rappresentante della parte
                Dim listaParametriLR As New Dictionary(Of String, String) From {
                {"IdPersona", parte.IdLegaleRappresentante}
            }
                listaLegaliRapprParte = Operazioni.CaricaDatiFiltrati(Of Persona)(listaParametriLR)
                For Each legaleRapprParte In listaLegaliRapprParte
                    document.Replace("{LegaleRappresentanteParte.NomeCompleto}", legaleRapprParte.NomeCompleto, False, True)
                    document.Replace("{LegaleRappresentanteParte.CodiceFiscale}", legaleRapprParte.CodiceFiscale, False, True)
                    document.Replace("{LegaleRappresentanteParte.LuogoNascita}", legaleRapprParte.LuogoDiNascita, False, True)
                    document.Replace("{LegaleRappresentanteParte.ProvNascita}", legaleRapprParte.ProvinciaDiNascita, False, True)
                    document.Replace("{LegaleRappresentanteParte.DataNascita}", legaleRapprParte.DataDiNascita, False, True)
                Next
            Next

            'Ricavo i dati della controparte
            Dim listaParametriControparte As New Dictionary(Of String, String) From {
                {"IdControparte", glbIdControparte}
            }
            listaControparti = Operazioni.CaricaDatiFiltrati(Of Controparte)(listaParametriControparte)
            For Each controparte In listaControparti
                document.Replace("{Controparte.Denominazione}", controparte.NomeCompleto, False, True)
                document.Replace("{Controparte.PartitaIVA}", controparte.PartitaIVA, False, True)
                document.Replace("{Controparte.IndirizzoSedeLegale}", controparte.IndirizzoSedeLegale, False, True)
                document.Replace("{Controparte.IndirizzoSedeOperativa}", controparte.IndirizzoSedeOperativa, False, True)

                'Ricavo i dati del legale rappresentante della parte
                Dim listaParametriLRC As New Dictionary(Of String, String) From {
                {"IdPersona", controparte.IdLegaleRappresentante}
            }
                listaLegaliRapprControparte = Operazioni.CaricaDatiFiltrati(Of Persona)(listaParametriLRC)
                For Each legaleRapprControparte In listaLegaliRapprControparte
                    document.Replace("{LegaleRappresentanteControparte.NomeCompleto}", legaleRapprControparte.NomeCompleto, False, True)
                    document.Replace("{LegaleRappresentanteControparte.CodiceFiscale}", legaleRapprControparte.CodiceFiscale, False, True)
                    document.Replace("{LegaleRappresentanteControparte.LuogoNascita}", legaleRapprControparte.LuogoDiNascita, False, True)
                    document.Replace("{LegaleRappresentanteControparte.ProvNascita}", legaleRapprControparte.ProvinciaDiNascita, False, True)
                    document.Replace("{LegaleRappresentanteControparte.DataNascita}", legaleRapprControparte.DataDiNascita, False, True)
                    document.Replace("{LegaleRappresentanteControparte.IndirizzoResidenza}", legaleRapprControparte.IndirizzoResidenza, False, True)
                Next
            Next

            'Ricavo i dati dell'avvocato
            Dim listaParametriAvv As New Dictionary(Of String, String) From {
                {"IdAvvocato", glbIdAvv}
            }
            listaAvv = Operazioni.CaricaDatiFiltrati(Of Avvocato)(listaParametriAvv)
            For Each avv In listaAvv
                document.Replace("{Avvocato.NomeCompleto}", avv.NomeCompleto, False, True)
                document.Replace("{Avvocato.CodiceFiscale}", avv.CodiceFiscale, False, True)
                document.Replace("{Avvocato.IndirizzoStudio}", avv.IndirizzoStudio, False, True)
                document.Replace("{Avvocato.EMailPEC}", avv.EmailPEC, False, True)
            Next

            document.SaveToFile("D:\DI_" & Now.Year & "." & Now.Month & "." & Now.Day & "-" & Now.Hour & "." & Now.Minute & ".docx", FileFormat.Docx)
            MessageBox.Show("Documento generato con successo!")
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: Sub GeneraDecretoIngiuntivo. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Public Sub GeneraAttoDiPrecetto()
        Try
            'TODO
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: Sub GeneraAttoDiPrecetto. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicavaAvv_Click(sender As Object, e As EventArgs) Handles UPicBoxRicavaAvv.Click
        Dim dr As DialogResult
        Try
            dr = frmDllAnaAvv.ShowDialog()
            If LSUTxtNomiAvv.ValoreCasellaTesto.Trim = "" And dr = DialogResult.OK Then
                LSUTxtNomiAvv.ValoreCasellaTesto = frmDllAnaAvv._NomeCompletoAvvocato
                glbIdAvv = frmDllAnaAvv._IdAvvocato
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: UPicBoxRicavaAvv_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicavaParte_Click(sender As Object, e As EventArgs) Handles UPicBoxRicavaParte.Click
        Dim dr As DialogResult
        Try
            dr = frmDllAnaParti.ShowDialog()
            If LSUTxtNomiParti.ValoreCasellaTesto.Trim = "" And dr = DialogResult.OK Then
                LSUTxtNomiParti.ValoreCasellaTesto = frmDllAnaParti._DenominazioneParte
                glbIdParte = frmDllAnaParti._IdParte
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: UPicBoxRicavaParte_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicavaControparte_Click(sender As Object, e As EventArgs) Handles UPicBoxRicavaControparte.Click
        Dim dr As DialogResult
        Try
            dr = frmDllAnaControParti.ShowDialog()
            If LSUTxtNomiControparti.ValoreCasellaTesto.Trim = "" And dr = DialogResult.OK Then
                LSUTxtNomiControparti.ValoreCasellaTesto = frmDllAnaControParti._DenominazioneControparte
                glbIdControparte = frmDllAnaControParti._IdControparte
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: UPicBoxRicavaControparte_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

End Class
