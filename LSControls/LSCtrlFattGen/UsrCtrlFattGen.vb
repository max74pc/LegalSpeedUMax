Imports LSDataModel.LSDataModelNS
Imports Spire.Doc
Imports LSCtrlAnaAvv
Imports LSCommon.LSCommonNS
Imports LSDBManager.LSDBContextNS
Imports System.Windows.Controls.Primitives

Public Class UsrCtrlFattGen

    Private ReadOnly sGlbNomeAtto As String

    Private Sub PicBoxChiudiFinestra_MouseHover(sender As Object, e As EventArgs) Handles PicBoxChiudiFinestra.MouseHover
        Try
            PicBoxChiudiFinestra.Image = ImageListGenFatt.Images(1)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: PicBoxChiudiFinestra_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxChiudiFinestra_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxChiudiFinestra.MouseLeave
        Try
            PicBoxChiudiFinestra.Image = ImageListGenFatt.Images(0)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: PicBoxChiudiFinestra_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxGenDoc_MouseHover(sender As Object, e As EventArgs) Handles PicBoxGenDoc.MouseHover
        Try
            PicBoxGenDoc.Image = ImageListGenFatt.Images(3)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: PicBoxGenDoc_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxGenDoc_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxGenDoc.MouseLeave
        Try
            PicBoxGenDoc.Image = ImageListGenFatt.Images(2)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: PicBoxGenDoc_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxNuovoModello_MouseHover(sender As Object, e As EventArgs) Handles PicBoxNuovoModello.MouseHover
        Try
            PicBoxNuovoModello.Image = ImageListGenFatt.Images(5)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: PicBoxNuovoModello_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxNuovoModello_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxNuovoModello.MouseLeave
        Try
            PicBoxNuovoModello.Image = ImageListGenFatt.Images(4)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: PicBoxNuovoModello_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PictBoxNuovaCat_MouseHover(sender As Object, e As EventArgs) Handles PictBoxNuovaCat.MouseHover
        Try
            PictBoxNuovaCat.Image = ImageListGenFatt.Images(7)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: PictBoxNuovaCat_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PictBoxNuovaCat_MouseLeave(sender As Object, e As EventArgs) Handles PictBoxNuovaCat.MouseLeave
        Try
            PictBoxNuovaCat.Image = ImageListGenFatt.Images(6)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: PictBoxNuovaCat_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicavaAvv_MouseHover(sender As Object, e As EventArgs) Handles UPicBoxRicavaDatiCliente.MouseHover
        Try
            UPicBoxRicavaDatiCliente.Image = ImageListGenFatt2.Images(1)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: UPicBoxRicavaAvv_MouseHover. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicavaAvv_MouseLeave(sender As Object, e As EventArgs) Handles UPicBoxRicavaDatiCliente.MouseLeave
        Try
            UPicBoxRicavaDatiCliente.Image = ImageListGenFatt2.Images(0)
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: UPicBoxRicavaAvv_MouseLeave. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub PicBoxChiudiFinestra_Click(sender As Object, e As EventArgs) Handles PicBoxChiudiFinestra.Click
        Try
            Dispose()
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: PicBoxChiudiFinestra_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
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
            'Select Case sGlbNomeAtto
            '    Case "Ricorso per Decreto Ingiuntivo"
            '        'GeneraDecretoIngiuntivo()
            '    Case "Atto di Precetto"
            '        'GeneraAttoDiPrecetto()
            'End Select
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: Sub GeneraDocumento. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    'Public Sub GeneraDecretoIngiuntivo()
    '    Dim document As New Document()
    '    Try
    '        'Apro il file del modello
    '        document.LoadFromFile("D:\ProgettiVS2017\LegalSpeedUMax\Modelli Atti\ricorso per decreto iniguntivo.odt")

    '        document.Replace("{SedeEnte}", UCase(LSUCboEditSedeEnte.ValoreMenuTendina), False, True)

    '        'Ricavo i dati della parte
    '        Dim listaParametriParte As New Dictionary(Of String, String) From {
    '            {"IdParte", glbIdParte}
    '        }
    '        Dim listaParti As List(Of Parte) = Operazioni.CaricaDatiFiltrati(Of Parte)(listaParametriParte)
    '        For Each parte In listaParti
    '            document.Replace("{Parte.Denominazione}", parte.NomeCompleto, False, True)
    '            document.Replace("{Parte.PartitaIVA}", parte.PartitaIVA, False, True)
    '            document.Replace("{Parte.IndirizzoSedeLegale}", parte.IndirizzoSedeLegale, False, True)

    '            'Ricavo i dati del legale rappresentante della parte
    '            Dim listaParametriLR As New Dictionary(Of String, String) From {
    '            {"IdPersona", parte.IdLegaleRappresentante}
    '        }
    '            Dim listaLegaliRapprParte As List(Of Persona) = Operazioni.CaricaDatiFiltrati(Of Persona)(listaParametriLR)
    '            For Each legaleRapprParte In listaLegaliRapprParte
    '                document.Replace("{LegaleRappresentanteParte.NomeCompleto}", legaleRapprParte.NomeCompleto, False, True)
    '                document.Replace("{LegaleRappresentanteParte.CodiceFiscale}", legaleRapprParte.CodiceFiscale, False, True)
    '                document.Replace("{LegaleRappresentanteParte.LuogoNascita}", legaleRapprParte.LuogoDiNascita, False, True)
    '                document.Replace("{LegaleRappresentanteParte.ProvNascita}", legaleRapprParte.ProvinciaDiNascita, False, True)
    '                document.Replace("{LegaleRappresentanteParte.DataNascita}", legaleRapprParte.DataDiNascita, False, True)
    '            Next
    '        Next

    '        'Ricavo i dati della controparte
    '        Dim listaParametriControparte As New Dictionary(Of String, String) From {
    '            {"IdControparte", glbIdControparte}
    '        }
    '        Dim listaControparti As List(Of Controparte) = Operazioni.CaricaDatiFiltrati(Of Controparte)(listaParametriControparte)
    '        For Each controparte In listaControparti
    '            document.Replace("{Controparte.Denominazione}", controparte.NomeCompleto, False, True)
    '            document.Replace("{Controparte.PartitaIVA}", controparte.PartitaIVA, False, True)
    '            document.Replace("{Controparte.IndirizzoSedeLegale}", controparte.IndirizzoSedeLegale, False, True)
    '            document.Replace("{Controparte.IndirizzoSedeOperativa}", controparte.IndirizzoSedeOperativa, False, True)

    '            'Ricavo i dati del legale rappresentante della parte
    '            Dim listaParametriLRC As New Dictionary(Of String, String) From {
    '            {"IdPersona", controparte.IdLegaleRappresentante}
    '        }
    '            Dim listaLegaliRapprControparte As List(Of Persona) = Operazioni.CaricaDatiFiltrati(Of Persona)(listaParametriLRC)
    '            For Each legaleRapprControparte In listaLegaliRapprControparte
    '                document.Replace("{LegaleRappresentanteControparte.NomeCompleto}", legaleRapprControparte.NomeCompleto, False, True)
    '                document.Replace("{LegaleRappresentanteControparte.CodiceFiscale}", legaleRapprControparte.CodiceFiscale, False, True)
    '                document.Replace("{LegaleRappresentanteControparte.LuogoNascita}", legaleRapprControparte.LuogoDiNascita, False, True)
    '                document.Replace("{LegaleRappresentanteControparte.ProvNascita}", legaleRapprControparte.ProvinciaDiNascita, False, True)
    '                document.Replace("{LegaleRappresentanteControparte.DataNascita}", legaleRapprControparte.DataDiNascita, False, True)
    '                document.Replace("{LegaleRappresentanteControparte.IndirizzoResidenza}", legaleRapprControparte.IndirizzoResidenza, False, True)
    '            Next
    '        Next

    '        'Ricavo i dati dell'avvocato
    '        Dim listaParametriAvv As New Dictionary(Of String, String) From {
    '            {"IdAvvocato", glbIdAvv}
    '        }
    '        Dim listaAvv As List(Of Avvocato) = Operazioni.CaricaDatiFiltrati(Of Avvocato)(listaParametriAvv)
    '        For Each avv In listaAvv
    '            document.Replace("{Avvocato.NomeCompleto}", avv.NomeCompleto, False, True)
    '            document.Replace("{Avvocato.CodiceFiscale}", avv.CodiceFiscale, False, True)
    '            document.Replace("{Avvocato.IndirizzoStudio}", avv.IndirizzoStudio, False, True)
    '            document.Replace("{Avvocato.EMailPEC}", avv.EmailPEC, False, True)
    '        Next

    '        document.SaveToFile("D:\DI_" & Now.Year & "." & Now.Month & "." & Now.Day & "-" & Now.Hour & "." & Now.Minute & ".docx", FileFormat.Docx)
    '        MessageBox.Show("Documento generato con successo!")
    '    Catch ex As Exception
    '        ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: Sub GeneraDecretoIngiuntivo. ", True, ClsComune.GlbStrUserNameLS, "", True)
    '    End Try
    'End Sub

    'Public Sub GeneraAttoDiPrecetto()
    '    Try
    '        'TODO
    '    Catch ex As Exception
    '        ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: Sub GeneraAttoDiPrecetto. ", True, ClsComune.GlbStrUserNameLS, "", True)
    '    End Try
    'End Sub

    Private Sub UPicBoxRicavaAvv_Click(sender As Object, e As EventArgs)
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

        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: UPicBoxRicavaAvv_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UsrCtrlFattGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim LData As String
            LData = "Idd65VXxKpEAgBvZ1nVhUN+w7vpItcbvurq9YsmKuDda+JAEE9qF2G4YzR3o0s96HLaSfKKXq8fmv/VifgjLP/ZHrAKRewKyimE+b1l5tI82tdsWa+W3TgkLfepngT3Ui+LuaUc8pxXYEPd/bacNeg6yvWi7xVPzxDsE/m3D+OyD1ifz4S4lkOhjUS4pJ9gIKv6eIx0aXzRyczi4c+55+yRRBjUsB3AUS5C4sGq4LaSbeVLRq52visiCeMQxIkO6G38uTOyJl3mplKPrB3tpSTpmDc0j1WLuce1KIA9GbtKqOgh5vJwnXnwR3qeVgEBY2Lgrt6Gu0RModahYN6N5ODyj526SSOsz50jUQsrjfnk2JYKq3D3GA+lshknDJsSyHHkqYNxXfha7GQ4e11FhxALPu81LBXLXez4l73XCV9n6cdvHnyOerI18clWh/g6lgfEG+N+ugko2oxET/WEeIVKoIvpEw9YMv5bQrD6oWlN5GthgiXawtPQ6kM41r0MKW75+6ojDqRbOqvyVwC4HNRf2MXjni/Bdo0KBG3SD119bQfa+4zBREiEz6X26Mv7Tc0n8YzGTcK7VZcRGqI06bp4RDiFvAMrn4Y83gJaVRX6MbSJqwpKXKugSrmf0ck6XzLmhQcjsznnLkToXxvBS2jh6Vy3JZXvt4l8JUF8zE9CPix+kpDcGedXA1MmN/dju6Ps4sgGGAnjrfl1YLHvbQR8kii+h9tKrUrjTT88xvjjwz5IXmC4MX2A6HjSqabQwLVm8wfwNF22Pp1nMuX5DVP2pyNMMYMHIewGlJRSQz3j/7gVbw264aeBJPGyVpxrZCRO7byu/Z8cKTk02S+vZTazhIjV4jmn8zLOsxH0wsbcEpDLw1XnrH4tUiIRDQxRO+EBtpPklyFx9Q8AYkIv91osUiQZ14MXfysJ8oHG8gqHa7uidcd+YgFc3FRlFlVXYqqQlABFg5/ZvUHUklZdiRLenTb2yfl3RffnzA1aevJcLy2sBoWUrTxZlAFu0u8D2+swu0V3juiLM8pO9VDB4gHtQh3n/cnvShuv8hls2fi0TTZvpxLdfBw=="
            Spire.License.LicenseProvider.SetLicenseKey(LData)

        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlFattGen_Load. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub UPicBoxRicavaDatiCliente_Click(sender As Object, e As EventArgs) Handles UPicBoxRicavaDatiCliente.Click
        'Dim dr As DialogResult
        'Dim usrCtrlAnaAvv As New UsrCtrlAnaAvv With {
        '        .VisualizzaDaAltraFinestra = True,
        '        .Dock = DockStyle.Fill
        '    }
        'Dim frmAnaAvv = New Form
        Try
            '    frmAnaAvv.Controls.Add(usrCtrlAnaAvv)
            '    frmAnaAvv.WindowState = FormWindowState.Maximized
            '    dr = frmAnaAvv.ShowDialog()

        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "UsrCtrlComAtti: UPicBoxRicavaDatiCliente_Click. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub
End Class
