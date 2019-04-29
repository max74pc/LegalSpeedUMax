
Imports System.Runtime.InteropServices
Imports Infragistics.Win.UltraWinTree
Imports LSDBManager.LSDBContextNS
Imports LSDataModel.LSDataModelNS
Imports Spire.Doc
Imports LSAnaAvvocati
Imports LSAnaParti
Imports LSAnaControparti

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

        Dim operazioni As New Operazioni
        Dim listaTipiEnti As New List(Of TipoEnteGiuridico)

        Me.WindowState = FormWindowState.Maximized
        UltraDockManagerComAtti.DockAreas(0).Size = New System.Drawing.Size(Me.Width, Me.Height - 86)
        UltraDockManagerComAtti.DockAreas(2).Size = New System.Drawing.Size(Me.Width, 86)
        Spire.License.LicenseProvider.SetLicenseFileFullPath("D:\ProgettiVS2017\LegalSpeedUMax\LSView\LSComAtti\license.elic.xml")

        'Carico tutte le tipologie di enti nel cosrrispondente menu a tendina
        listaTipiEnti = operazioni.CaricaTutti(Of TipoEnteGiuridico)

        For Each tipiEnti In listaTipiEnti
            LSUCboEditTipoEnte.AggiungiElemento(tipiEnti.IdTipoEnteGiuridico, tipiEnti.DescrizioneTipoEnteGiuridico.Trim())
        Next

    End Sub

    Private Sub UltraPicBoxChiudiFinestra_MouseHover(sender As Object, e As EventArgs) Handles UltraPicBoxChiudiFinestra.MouseHover
        UltraPicBoxChiudiFinestra.Image = ImageListComAtti.Images(1)
    End Sub

    Private Sub UltraPicBoxChiudiFinestra_MouseLeave(sender As Object, e As EventArgs) Handles UltraPicBoxChiudiFinestra.MouseLeave
        UltraPicBoxChiudiFinestra.Image = ImageListComAtti.Images(0)
    End Sub

    Private Sub UltraPicBoxGenDoc_MouseHover(sender As Object, e As EventArgs) Handles UltraPicBoxGenDoc.MouseHover
        UltraPicBoxGenDoc.Image = ImageListComAtti.Images(3)
    End Sub

    Private Sub UltraPicBoxGenDoc_MouseLeave(sender As Object, e As EventArgs) Handles UltraPicBoxGenDoc.MouseLeave
        UltraPicBoxGenDoc.Image = ImageListComAtti.Images(2)
    End Sub

    Private Sub UltraPicBoxNewModel_MouseHover(sender As Object, e As EventArgs) Handles UltraPicBoxNewModel.MouseHover
        UltraPicBoxNewModel.Image = ImageListComAtti.Images(5)
    End Sub

    Private Sub UltraPicBoxNewModel_MouseLeave(sender As Object, e As EventArgs) Handles UltraPicBoxNewModel.MouseLeave
        UltraPicBoxNewModel.Image = ImageListComAtti.Images(4)
    End Sub

    Private Sub UltraPictBoxNewCat_MouseHover(sender As Object, e As EventArgs) Handles UltraPictBoxNewCat.MouseHover
        UltraPictBoxNewCat.Image = ImageListComAtti.Images(7)
    End Sub

    Private Sub UltraPictBoxNewCat_MouseLeave(sender As Object, e As EventArgs) Handles UltraPictBoxNewCat.MouseLeave
        UltraPictBoxNewCat.Image = ImageListComAtti.Images(6)
    End Sub

    Private Sub UPicBoxRicavaAvv_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxRicavaAvv.MouseHover
        UPicBoxRicavaAvv.Image = ImageListComAtti2.Images(1)
    End Sub

    Private Sub UPicBoxRicavaAvv_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxRicavaAvv.MouseLeave
        UPicBoxRicavaAvv.Image = ImageListComAtti2.Images(0)
    End Sub

    Private Sub UPicBoxRicavaParte_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxRicavaParte.MouseHover
        UPicBoxRicavaParte.Image = ImageListComAtti2.Images(1)
    End Sub

    Private Sub UPicBoxRicavaParte_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxRicavaParte.MouseLeave
        UPicBoxRicavaParte.Image = ImageListComAtti2.Images(0)
    End Sub

    Private Sub UPicBoxRicavaControparte_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxRicavaControparte.MouseHover
        UPicBoxRicavaControparte.Image = ImageListComAtti2.Images(1)
    End Sub

    Private Sub UPicBoxRicavaControparte_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxRicavaControparte.MouseLeave
        UPicBoxRicavaControparte.Image = ImageListComAtti2.Images(0)
    End Sub

    Private Sub UltraPicBoxChiudiFinestra_MouseClick(sender As Object, e As MouseEventArgs) Handles UltraPicBoxChiudiFinestra.MouseClick
        Me.Close()
    End Sub

    Private Sub UltraTreeModelliAtti_DoubleClick(sender As Object, e As EventArgs) Handles UltraTreeModelliAtti.DoubleClick
        Dim node As UltraTreeNode = UltraTreeModelliAtti.ActiveNode
        Dim strPathModelli As String = "D:\ProgettiVS2017\LegalSpeedUMax\Modelli Atti\"
        Select Case node.Text
            Case "Ricorso per Decreto Ingiuntivo"
                DocViewer1.LoadFromFile(strPathModelli & "ricorso per decreto iniguntivo.odt")
            Case "Atto di Precetto"
                DocViewer1.LoadFromFile(strPathModelli & "ATTO DI PRECETTO ALFACND SRL.odt")
        End Select
        sGlbNomeAtto = node.Text
    End Sub

    Private Sub LSUCboEditTipoEnte_ValoreMenuTendinaCambiato(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles LSUCboEditTipoEnte.ValoreMenuTendinaCambiato

        If LSUCboEditTipoEnte.ValoreMenuTendina <> "" Then
            'Carico tutte i nomi delle sedi del tipo ente selezionato
            Dim operazioni As New Operazioni
            Dim listaEntiGiuridici As New List(Of EnteGiuridico)
            Dim listaEntiGiuridiciOrdinato As New List(Of EnteGiuridico)
            Dim listaParametri As New Dictionary(Of String, String) From {
                {"TipoEnteGiuridico", LSUCboEditTipoEnte.ValoreMenuTendina}
            }
            Dim iPosizioneStringa As Integer = 0
            Dim strSedeEnte As String = ""
            Dim dizionarioEnti As New Dictionary(Of Integer, String)

            listaEntiGiuridici = operazioni.CaricaDatiFiltrati(Of EnteGiuridico)(listaParametri)

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

    End Sub

    Private Sub UltraPicBoxGenDoc_Click(sender As Object, e As EventArgs) Handles UltraPicBoxGenDoc.Click

        'Validazione Campi Obbligatori
        'TODO

        'Generazione Documento
        GeneraDocumento

    End Sub

    Private Sub GeneraDocumento()

        Select Case sGlbNomeAtto
            Case "Ricorso per Decreto Ingiuntivo"
                GeneraDecretoIngiuntivo()
            Case "Atto di Precetto"
                GeneraAttoDiPrecetto()
        End Select

    End Sub

    Public Sub GeneraDecretoIngiuntivo()
        Dim document As New Document()
        Dim operazioni As New Operazioni
        Dim listaParti As New List(Of Parte)
        Dim listaControparti As New List(Of Controparte)
        Dim listaLegaliRapprParte As New List(Of Persona)
        Dim listaLegaliRapprControparte As New List(Of Persona)
        Dim listaAvv As New List(Of Avvocato)

        'Apro il file del modello
        document.LoadFromFile("D:\ProgettiVS2017\LegalSpeedUMax\Modelli Atti\ricorso per decreto iniguntivo.odt")

        Document.Replace("{TipoEnte}", UCase(LSUCboEditTipoEnte.ValoreMenuTendina), False, True)
        Document.Replace("{SedeEnte}", UCase(LSUCboEditSedeEnte.ValoreMenuTendina), False, True)

        'Ricavo i dati della parte
        Dim listaParametriParte As New Dictionary(Of String, String) From {
                {"IdParte", glbIdParte}
            }
        listaParti = Operazioni.CaricaDatiFiltrati(Of Parte)(listaParametriParte)
        For Each parte In listaParti
            Document.Replace("{Parte.Denominazione}", parte.NomeCompleto, False, True)
            Document.Replace("{Parte.PartitaIVA}", parte.PartitaIVA, False, True)
            Document.Replace("{Parte.IndirizzoSedeLegale}", parte.IndirizzoSedeLegale, False, True)

            'Ricavo i dati del legale rappresentante della parte
            Dim listaParametriLR As New Dictionary(Of String, String) From {
                {"IdPersona", parte.IdLegaleRappresentante}
            }
            listaLegaliRapprParte = Operazioni.CaricaDatiFiltrati(Of Persona)(listaParametriLR)
            For Each legaleRapprParte In listaLegaliRapprParte
                Document.Replace("{LegaleRappresentanteParte.NomeCompleto}", legaleRapprParte.NomeCompleto, False, True)
                Document.Replace("{LegaleRappresentanteParte.CodiceFiscale}", legaleRapprParte.CodiceFiscale, False, True)
                Document.Replace("{LegaleRappresentanteParte.LuogoNascita}", legaleRapprParte.LuogoDiNascita, False, True)
                Document.Replace("{LegaleRappresentanteParte.ProvNascita}", legaleRapprParte.ProvinciaDiNascita, False, True)
                Document.Replace("{LegaleRappresentanteParte.DataNascita}", legaleRapprParte.DataDiNascita, False, True)
            Next
        Next

        'Ricavo i dati della controparte
        Dim listaParametriControparte As New Dictionary(Of String, String) From {
                {"IdControparte", glbIdControparte}
            }
        listaControparti = Operazioni.CaricaDatiFiltrati(Of Controparte)(listaParametriControparte)
        For Each controparte In listaControparti
            Document.Replace("{Controparte.Denominazione}", controparte.NomeCompleto, False, True)
            Document.Replace("{Controparte.PartitaIVA}", controparte.PartitaIVA, False, True)
            Document.Replace("{Controparte.IndirizzoSedeLegale}", controparte.IndirizzoSedeLegale, False, True)
            Document.Replace("{Controparte.IndirizzoSedeOperativa}", controparte.IndirizzoSedeOperativa, False, True)

            'Ricavo i dati del legale rappresentante della parte
            Dim listaParametriLRC As New Dictionary(Of String, String) From {
                {"IdPersona", controparte.IdLegaleRappresentante}
            }
            listaLegaliRapprControparte = Operazioni.CaricaDatiFiltrati(Of Persona)(listaParametriLRC)
            For Each legaleRapprControparte In listaLegaliRapprControparte
                Document.Replace("{LegaleRappresentanteControparte.NomeCompleto}", legaleRapprControparte.NomeCompleto, False, True)
                Document.Replace("{LegaleRappresentanteControparte.CodiceFiscale}", legaleRapprControparte.CodiceFiscale, False, True)
                Document.Replace("{LegaleRappresentanteControparte.LuogoNascita}", legaleRapprControparte.LuogoDiNascita, False, True)
                Document.Replace("{LegaleRappresentanteControparte.ProvNascita}", legaleRapprControparte.ProvinciaDiNascita, False, True)
                Document.Replace("{LegaleRappresentanteControparte.DataNascita}", legaleRapprControparte.DataDiNascita, False, True)
                Document.Replace("{LegaleRappresentanteControparte.IndirizzoResidenza}", legaleRapprControparte.IndirizzoResidenza, False, True)
            Next
        Next

        'Ricavo i dati dell'avvocato
        Dim listaParametriAvv As New Dictionary(Of String, String) From {
                {"IdAvvocato", glbIdAvv}
            }
        listaAvv = Operazioni.CaricaDatiFiltrati(Of Avvocato)(listaParametriAvv)
        For Each avv In listaAvv
            Document.Replace("{Avvocato.NomeCompleto}", avv.NomeCompleto, False, True)
            Document.Replace("{Avvocato.CodiceFiscale}", avv.CodiceFiscale, False, True)
            Document.Replace("{Avvocato.IndirizzoStudio}", avv.IndirizzoStudio, False, True)
            Document.Replace("{Avvocato.EMailPEC}", avv.EmailPEC, False, True)
        Next

        document.SaveToFile("D:\DI_" & Now.Year & "." & Now.Month & "." & Now.Day & "-" & Now.Hour & "." & Now.Minute & ".docx", FileFormat.Docx)
        MessageBox.Show("Documento generato con successo!")
    End Sub

    Public Sub GeneraAttoDiPrecetto()

    End Sub

    Private Sub UPicBoxRicavaAvv_Click(sender As Object, e As EventArgs) Handles UPicBoxRicavaAvv.Click
        Dim dr As DialogResult
        dr = frmDllAnaAvv.ShowDialog()
        If LSUTxtNomiAvv.ValoreCasellaTesto.Trim = "" And dr = DialogResult.OK Then
            LSUTxtNomiAvv.ValoreCasellaTesto = frmDllAnaAvv._NomeCompletoAvvocato
            glbIdAvv = frmDllAnaAvv._IdAvvocato
        End If
    End Sub

    Private Sub UPicBoxRicavaParte_Click(sender As Object, e As EventArgs) Handles UPicBoxRicavaParte.Click
        Dim dr As DialogResult
        dr = frmDllAnaParti.ShowDialog()
        If LSUTxtNomiParti.ValoreCasellaTesto.Trim = "" And dr = DialogResult.OK Then
            LSUTxtNomiParti.ValoreCasellaTesto = frmDllAnaParti._DenominazioneParte
            glbIdParte = frmDllAnaParti._IdParte
        End If
    End Sub

    Private Sub UPicBoxRicavaControparte_Click(sender As Object, e As EventArgs) Handles UPicBoxRicavaControparte.Click
        Dim dr As DialogResult
        dr = frmDllAnaControParti.ShowDialog()
        If LSUTxtNomiControparti.ValoreCasellaTesto.Trim = "" And dr = DialogResult.OK Then
            LSUTxtNomiControparti.ValoreCasellaTesto = frmDllAnaControParti._DenominazioneControparte
            glbIdControparte = frmDllAnaControParti._IdControparte
        End If
    End Sub

End Class
