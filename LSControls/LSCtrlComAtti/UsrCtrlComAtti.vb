Imports LSDataModel.LSDataModelNS
Imports Spire.Doc
Imports LSCtrlAnaAvv
Imports LSCtrlAnaParti
Imports LSCtrlAnaControparti
Imports LSCommon.LSCommonNS
Imports LSDBManager.LSDBContextNS
Imports Infragistics.Win.UltraWinTree
Imports System.Windows.Controls.Primitives

Public Class UsrCtrlComAtti

    Private glbIdAvv As Integer
    Private glbIdParte As Integer
    Private glbIdControparte As Integer
    Private sGlbNomeAtto As String

    Private Sub UsrCtrlComAtti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim LData As String
            LData = "PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiIHN0YW5kYWxvbmU9InllcyI/Pgo8TGljZW5zZSBLZXk9ImNyOERaN1hKMkR5MUs2UUJBTkRPSVRLdlpjTzZkelVod2lsSHBnVlluQ3k0cXlHV2V6TFZubFJGeFAxNU1mSWZnUmdNWm1XaEdOQWRFNFRqZWZnQ1ovbFR2b1BkSXRIbDZXdDVBNWk1TVhFbnFkQnVPMUthRnovRFFzYUdWTGhzdjlySG1ybnRxSElFRGxJeGRxYUpNcGtLb0Frd1A3d1N6T01KMVkrbUNmVTVVRmV6REwvTjd1enJ4M0Y0d2I1SGErd0E2VFQ5VFJ3SzAzejlFS01aRmwzU1lSL3o0YVU3TE0wZFNYWTlqU0ZKZ2dqZlZzRFVLaUJyVm5td1ljaXVyOUVrYmw5Q3RaWTAzdG1yZm01QlplKzZnaHRFTm4wb2gzMzh0WlJleWpjcjc0QWs3MWhnWWtuTE9CQzE1VllmalhzcXVBVW13MlI2TWNWMlBPT2JyY1RSYlhBZ3pvUWJPeWQ4U2JFWmN3aE43NktQd1dzUVFTMUowdGlZSFVLeE9tMnQ0ZkJWMGhQVmhhOUI4Y0swNHFKUVp0MDBaMWNKRGEwd2I4VWx6RWs5QkhVVzJlbk9mVDE0UnlIQ2krWUdlbVBLY2RDUXJoMXpyWVRGN0ltb0x4N3h1NGV2RFRZc2xzV0JrbFFJb3g4NnJWckVVa1N0dXErQUNTWS9xVTM5L1Zhd3Y5S0FmUjVUZUVicGt3RGhTYjBOQkFqVDhBeXRsRFZkR2ZpZzBxS0czVllpVHBYRnc1cHRMVmgrYmtkK2RnN3Z4dHZyNDVaVVdKZXlyekdOR0g3YUZZZDZwLzJNRy9YSlRsR3ovU05RbzJDUExraU83SlhuOU5HZXhaN3BIbTBkZ3pNWmJHRVhxVmR2bG04MTJhL1hMMVNxeEdVWStvNVpsVUM3WTV4Z2dhRCtGZVA5enpoeUpxSUVwcDk3My9ScTRteG1wQWZMcVNzTzJSeHlTcStpdjFDc3AwQ3JvMDc4OEhybDFteWt4dVQweWRSWVpDNkRTeDhNMi9MWTNkOXNud3U3NkFmYjVDOVF1ZE9Zc0wzREh2aGZncmNVSWUvcUhmVFo5QWF6Y3pUanlyM2RPQkFjczBLZk12Y0xVUzRSeHZDdW1NNDVyNDJnMXJ3UGluN2JBcmYvZnNMTzZtS3g0WWRoSURNWlF6V3RjbkhFSTF5TXJ6aU9pdXhMdE8xalRBV25uU2VLVDJ0cXI3Tm42Qmg5TURHNjZZK2lJaW4xV05TUCtMdDFYdXRkajNKTyt4b1FNUVB5ZFpoZkJYZXpVMEhRMnd0eEdwdzRNczRTMTVJbFg1TEdXR3dXeUdYTWNjVWd3b1RDeFRGYmgyZFo0Vkg3OVZHTEVFR1JRWEZrNTRBdlFLdFBpdUcxY0w4RFo3WEoyRHkxSzZUUWVORE9YeFl2NFNveitCMHNBS0VwTVRrNCtTYWpYNksrSjlUOFhZVXRTOE8wWWZGUFZqZkhIYTZORWQyODdVcUlqMnJnQlF1bjVDV3hCczFHUm5BYmd1Z3MyL2ZQakcwZmdQemdSYzR5Q3ZObFg4V2pKUnloc3U5VFRKTjd1R3NOdnprU2IyZWlyQmhEaG1vQ0Jqa0wyYnMzT3I2d2pnNnBUNVpmNGhEdDF0STBJNXo1aytxQXVSZnRhd1lmamhXYmpMS0xKOTlUVk1kRDZaTCtTenNtQkNWN05lYm96V0RUTWgrRnJPT292R09ZbUk1bWp4Smd1MVRXNnI1V0JUK2oxSjBFNmJIb2tEMWo0Wm1DWUQreVBPUW1PMm1yUTNGdC9jVmZwQWlJdzliRkgwZ1FIbXQ4QnNuZnQ2MVV3c1h6cSs2akNvY1hOOUMvRXZPblhTczZuVlNGSkVBL3l1QmNIazZxOWdqanBnRG1NTEcrNlpxR1VjRWMzZEp2THpuK3pNT0p3TDI4WUQxN3BLSXBUNnd6WFBFVFJwWS9qNHhoMkQvaFhJRVNHcTk1eTVmZE9MNmx1QT09IiBWZXJzaW9uPSI5LjkiPgogICAgPFR5cGU+UnVudGltZTwvVHlwZT4KICAgIDxVc2VybmFtZT5Vc2VyTmFtZTwvVXNlcm5hbWU+CiAgICA8RW1haWw+ZU1haWxAaG9zdC5jb208L0VtYWlsPgogICAgPE9yZ2FuaXphdGlvbj5Pcmdhbml6YXRpb248L09yZ2FuaXphdGlvbj4KICAgIDxMaWNlbnNlZERhdGU+MjAxNi0wMS0wMVQxMjowMDowMFo8L0xpY2Vuc2VkRGF0ZT4KICAgIDxFeHBpcmVkRGF0ZT4yMDk5LTEyLTMxVDEyOjAwOjAwWjwvRXhwaXJlZERhdGU+CiAgICA8UHJvZHVjdHM+CiAgICAgICAgPFByb2R1Y3Q+CiAgICAgICAgICAgIDxOYW1lPlNwaXJlLk9mZmljZSBQbGF0aW51bTwvTmFtZT4KICAgICAgICAgICAgPFZlcnNpb24+OS45OTwvVmVyc2lvbj4KICAgICAgICAgICAgPFN1YnNjcmlwdGlvbj4KICAgICAgICAgICAgICAgIDxOdW1iZXJPZlBlcm1pdHRlZERldmVsb3Blcj45OTk5OTwvTnVtYmVyT2ZQZXJtaXR0ZWREZXZlbG9wZXI+CiAgICAgICAgICAgICAgICA8TnVtYmVyT2ZQZXJtaXR0ZWRTaXRlPjk5OTk5PC9OdW1iZXJPZlBlcm1pdHRlZFNpdGU+CiAgICAgICAgICAgIDwvU3Vic2NyaXB0aW9uPgogICAgICAgIDwvUHJvZHVjdD4KICAgIDwvUHJvZHVjdHM+CiAgICA8SXNzdWVyPgogICAgICAgIDxOYW1lPklzc3VlcjwvTmFtZT4KICAgICAgICA8RW1haWw+aXNzdWVyQGlzc3Vlci5jb208L0VtYWlsPgogICAgICAgIDxVcmw+aHR0cDovL3d3dy5pc3N1ZXIuY29tPC9Vcmw+CiAgICA8L0lzc3Vlcj4KPC9MaWNlbnNlPg=="
            Spire.License.LicenseProvider.SetLicenseKey(LData)

            'Carico tutte le tipologie di enti nel cosrrispondente menu a tendina
            Dim listaTipiEnti As List(Of TipoEnteGiuridico) = Operazioni.CaricaTutti(Of TipoEnteGiuridico)

            For Each tipiEnti In listaTipiEnti
                LSUCboEditTipoEnte.AggiungiElemento(tipiEnti.IdTipoEnteGiuridico, tipiEnti.DescrizioneTipoEnteGiuridico.Trim())
            Next
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti_Load. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxChiudiFinestra_MouseHover(sender As Object, e As EventArgs) Handles PicBoxChiudiFinestra.MouseHover
        Try
            PicBoxChiudiFinestra.Image = ImageListComAtti.Images(1)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: PicBoxChiudiFinestra_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxChiudiFinestra_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxChiudiFinestra.MouseLeave
        Try
            PicBoxChiudiFinestra.Image = ImageListComAtti.Images(0)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: PicBoxChiudiFinestra_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxGenDoc_MouseHover(sender As Object, e As EventArgs) Handles PicBoxGenDoc.MouseHover
        Try
            PicBoxGenDoc.Image = ImageListComAtti.Images(3)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: PicBoxGenDoc_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxGenDoc_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxGenDoc.MouseLeave
        Try
            PicBoxGenDoc.Image = ImageListComAtti.Images(2)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: PicBoxGenDoc_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxNuovoModello_MouseHover(sender As Object, e As EventArgs) Handles PicBoxNuovoModello.MouseHover
        Try
            PicBoxNuovoModello.Image = ImageListComAtti.Images(5)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: PicBoxNuovoModello_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxNuovoModello_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxNuovoModello.MouseLeave
        Try
            PicBoxNuovoModello.Image = ImageListComAtti.Images(4)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: PicBoxNuovoModello_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PictBoxNuovaCat_MouseHover(sender As Object, e As EventArgs) Handles PictBoxNuovaCat.MouseHover
        Try
            PictBoxNuovaCat.Image = ImageListComAtti.Images(7)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: PictBoxNuovaCat_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PictBoxNuovaCat_MouseLeave(sender As Object, e As EventArgs) Handles PictBoxNuovaCat.MouseLeave
        Try
            PictBoxNuovaCat.Image = ImageListComAtti.Images(6)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: PictBoxNuovaCat_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicavaAvv_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxRicavaAvv.MouseHover
        Try
            UPicBoxRicavaAvv.Image = ImageListComAtti2.Images(1)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: UPicBoxRicavaAvv_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicavaAvv_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxRicavaAvv.MouseLeave
        Try
            UPicBoxRicavaAvv.Image = ImageListComAtti2.Images(0)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: UPicBoxRicavaAvv_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicavaParte_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxRicavaParte.MouseHover
        Try
            UPicBoxRicavaParte.Image = ImageListComAtti2.Images(1)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: UPicBoxRicavaParte_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicavaParte_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxRicavaParte.MouseLeave
        Try
            UPicBoxRicavaParte.Image = ImageListComAtti2.Images(0)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: UPicBoxRicavaParte_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicavaControparte_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxRicavaControparte.MouseHover
        Try
            UPicBoxRicavaControparte.Image = ImageListComAtti2.Images(1)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: UPicBoxRicavaControparte_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicavaControparte_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxRicavaControparte.MouseLeave
        Try
            UPicBoxRicavaControparte.Image = ImageListComAtti2.Images(0)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: UPicBoxRicavaControparte_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxChiudiFinestra_Click(sender As Object, e As EventArgs) Handles PicBoxChiudiFinestra.Click
        Try
            Dispose()
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: PicBoxChiudiFinestra_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
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
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: UltraTreeModelliAtti_DoubleClick. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxGenDoc_Click(sender As Object, e As EventArgs) Handles PicBoxGenDoc.Click
        Try
            'Validazione Campi Obbligatori
            'TODO

            'Generazione Documento
            GeneraDocumento()
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: PicBoxGenDoc_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
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
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: Sub GeneraDocumento. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Public Sub GeneraDecretoIngiuntivo()
        Dim document As New Document()
        Try
            'Apro il file del modello
            document.LoadFromFile("D:\ProgettiVS2017\LegalSpeedUMax\Modelli Atti\ricorso per decreto iniguntivo.odt")

            document.Replace("{TipoEnte}", UCase(LSUCboEditTipoEnte.ValoreMenuTendina), False, True)
            document.Replace("{SedeEnte}", UCase(LSUCboEditSedeEnte.ValoreMenuTendina), False, True)

            'Ricavo i dati della parte
            Dim listaParametriParte As New Dictionary(Of String, String) From {
                {"IdParte", glbIdParte}
            }
            Dim listaParti As List(Of Parte) = Operazioni.CaricaDatiFiltrati(Of Parte)(listaParametriParte)
            For Each parte In listaParti
                document.Replace("{Parte.Denominazione}", parte.NomeCompleto, False, True)
                document.Replace("{Parte.PartitaIVA}", parte.PartitaIVA, False, True)
                document.Replace("{Parte.IndirizzoSedeLegale}", parte.IndirizzoSedeLegale, False, True)

                'Ricavo i dati del legale rappresentante della parte
                Dim listaParametriLR As New Dictionary(Of String, String) From {
                {"IdPersona", parte.IdLegaleRappresentante}
            }
                Dim listaLegaliRapprParte As List(Of Persona) = Operazioni.CaricaDatiFiltrati(Of Persona)(listaParametriLR)
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
            Dim listaControparti As List(Of Controparte) = Operazioni.CaricaDatiFiltrati(Of Controparte)(listaParametriControparte)
            For Each controparte In listaControparti
                document.Replace("{Controparte.Denominazione}", controparte.NomeCompleto, False, True)
                document.Replace("{Controparte.PartitaIVA}", controparte.PartitaIVA, False, True)
                document.Replace("{Controparte.IndirizzoSedeLegale}", controparte.IndirizzoSedeLegale, False, True)
                document.Replace("{Controparte.IndirizzoSedeOperativa}", controparte.IndirizzoSedeOperativa, False, True)

                'Ricavo i dati del legale rappresentante della parte
                Dim listaParametriLRC As New Dictionary(Of String, String) From {
                {"IdPersona", controparte.IdLegaleRappresentante}
            }
                Dim listaLegaliRapprControparte As List(Of Persona) = Operazioni.CaricaDatiFiltrati(Of Persona)(listaParametriLRC)
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
            Dim listaAvv As List(Of Avvocato) = Operazioni.CaricaDatiFiltrati(Of Avvocato)(listaParametriAvv)
            For Each avv In listaAvv
                document.Replace("{Avvocato.NomeCompleto}", avv.NomeCompleto, False, True)
                document.Replace("{Avvocato.CodiceFiscale}", avv.CodiceFiscale, False, True)
                document.Replace("{Avvocato.IndirizzoStudio}", avv.IndirizzoStudio, False, True)
                document.Replace("{Avvocato.EMailPEC}", avv.EmailPEC, False, True)
            Next

            document.SaveToFile("D:\DI_" & Now.Year & "." & Now.Month & "." & Now.Day & "-" & Now.Hour & "." & Now.Minute & ".docx", FileFormat.Docx)
            MessageBox.Show("Documento generato con successo!")
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: Sub GeneraDecretoIngiuntivo. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Public Sub GeneraAttoDiPrecetto()
        Try
            'TODO
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: Sub GeneraAttoDiPrecetto. ", True, ClsComune.GlbStrUserNameLS, "", True)
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
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: LSUCboEditTipoEnte_ValoreMenuTendinaCambiato. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicavaAvv_Click(sender As Object, e As EventArgs) Handles UPicBoxRicavaAvv.Click
        Dim dr As DialogResult
        Dim usrCtrlAnaAvv As New UsrCtrlAnaAvv With {
                .VisualizzaDaAltraFinestra = True,
                .Dock = DockStyle.Fill
            }
        Dim frmAnaAvv = New Form
        Try
            frmAnaAvv.Controls.Add(usrCtrlAnaAvv)
            frmAnaAvv.WindowState = FormWindowState.Maximized
            dr = frmAnaAvv.ShowDialog()
            If LSUTxtNomiAvv.ValoreCasellaTesto.Trim = "" And dr = DialogResult.OK Then
                LSUTxtNomiAvv.ValoreCasellaTesto = usrCtrlAnaAvv.NomeCompletoAvvocato
                glbIdAvv = usrCtrlAnaAvv.IdAvvocato
                usrCtrlAnaAvv = Nothing
                frmAnaAvv.Close()
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: UPicBoxRicavaAvv_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicavaParte_Click(sender As Object, e As EventArgs) Handles UPicBoxRicavaParte.Click
        Dim dr As DialogResult
        Dim usrCtrlAnaParti As New UsrCtrlAnaParti With {
            .VisualizzaDaAltraFinestra = True,
            .Dock = DockStyle.Fill
        }
        Dim frmAnaParti = New Form
        Try
            frmAnaParti.Controls.Add(usrCtrlAnaParti)
            frmAnaParti.WindowState = FormWindowState.Maximized
            dr = frmAnaParti.ShowDialog()
            If LSUTxtNomiParti.ValoreCasellaTesto.Trim = "" And dr = DialogResult.OK Then
                LSUTxtNomiParti.ValoreCasellaTesto = usrCtrlAnaParti.DenominazioneParte
                glbIdParte = usrCtrlAnaParti.IdParte
                usrCtrlAnaParti = Nothing
                frmAnaParti.Close()
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: UPicBoxRicavaParte_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicavaControparte_Click(sender As Object, e As EventArgs) Handles UPicBoxRicavaControparte.Click
        Dim dr As DialogResult
        Dim usrCtrlAnaControparti As New UsrCtrlAnaControparti With {
            .VisualizzaDaAltraFinestra = True,
            .Dock = DockStyle.Fill
        }
        Dim frmAnaControparti = New Form
        Try
            frmAnaControparti.Controls.Add(usrCtrlAnaControparti)
            frmAnaControparti.WindowState = FormWindowState.Maximized
            dr = frmAnaControparti.ShowDialog()
            If LSUTxtNomiControparti.ValoreCasellaTesto.Trim = "" And dr = DialogResult.OK Then
                LSUTxtNomiControparti.ValoreCasellaTesto = usrCtrlAnaControparti.DenominazioneControparte
                glbIdControparte = usrCtrlAnaControparti.IdControparte
                usrCtrlAnaControparti = Nothing
                frmAnaControparti.Close()
            End If
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmComAtti: UPicBoxRicavaControparte_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub
End Class
