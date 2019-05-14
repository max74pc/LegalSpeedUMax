Imports System.Data.Entity
Imports LSDataModel.LSDataModelNS
Imports LSCommon.LSCommonNS

Namespace LSDBContextNS

    Public Class LSDBContext : Inherits DbContext

        'imposto il nome e il path che desidero per il database locale tramite il parametro del costruttore
        Public Sub New()
            MyBase.New("name=LSDBManager")
            Dim sLocalDBPath As String = "D:\ProgettiVS2017\LegalSpeedUMax\LSDBManager"
            AppDomain.CurrentDomain.SetData("DataDirectory", sLocalDBPath)
        End Sub

        Public Property Amministrati As DbSet(Of Amministrato)
        Public Property Atti As DbSet(Of Atto)
        Public Property Avvocati As DbSet(Of Avvocato)
        Public Property ComuniItaliani As DbSet(Of ComuneItaliano)
        Public Property Controparti As DbSet(Of Controparte)
        Public Property EntiGiuridici As DbSet(Of EnteGiuridico)
        Public Property Giudici As DbSet(Of Giudice)
        Public Property Nazioni As DbSet(Of Nazione)
        Public Property Parti As DbSet(Of Parte)
        Public Property Persone As DbSet(Of Persona)
        Public Property Province As DbSet(Of Provincia)
        Public Property TipiEntiGiuridici As DbSet(Of TipoEnteGiuridico)
        Public Property Utenti As DbSet(Of Utente)

    End Class

    ''' <summary>
    ''' Classe che espone metodi di comodo per effettuare le operazioni sul database
    ''' </summary>
    Public Class Operazioni

        Public Shared Sub Aggiungi(Of Entity)(ByVal intEntityID As Integer, myEntity As Entity)

            Using dbc = New LSDBContext()

                Try

                    If GetType(Entity) = GetType(Avvocato) Then

                        Dim strNomeCompleto() = Split(TryCast(myEntity, Avvocato).NomeCompleto, " ")

                        Dim iMaxIdPersona = RicavaMaxId(Of Persona)()

                        'Creo un nuovo avvocato
                        Dim avv = New Avvocato With
                        {
                            .IdPersona = iMaxIdPersona,
                            .Cellulare = TryCast(myEntity, Avvocato).Cellulare,
                            .DataIscrizioneAlboAvv = TryCast(myEntity, Avvocato).DataIscrizioneAlboAvv,
                            .DataIscrizioneAlboCassazionisti = TryCast(myEntity, Avvocato).DataIscrizioneAlboCassazionisti,
                            .EMail = TryCast(myEntity, Avvocato).EMail,
                            .EmailPEC = TryCast(myEntity, Avvocato).EmailPEC,
                            .FaxStudio = TryCast(myEntity, Avvocato).FaxStudio,
                            .ForoDiAppartenza = TryCast(myEntity, Avvocato).ForoDiAppartenza,
                            .TelefonoStudio = TryCast(myEntity, Avvocato).TelefonoStudio,
                            .Nome = strNomeCompleto(0),
                            .Cognome = strNomeCompleto(1),
                            .CodiceFiscale = TryCast(myEntity, Avvocato).CodiceFiscale,
                            .PartitaIVA = TryCast(myEntity, Avvocato).PartitaIVA,
                            .DataDiNascita = TryCast(myEntity, Avvocato).DataDiNascita,
                            .LuogoDiNascita = TryCast(myEntity, Avvocato).LuogoDiNascita,
                            .ProvinciaDiNascita = TryCast(myEntity, Avvocato).ProvinciaDiNascita,
                            .StatoDiNascita = TryCast(myEntity, Avvocato).StatoDiNascita,
                            .IndirizzoResidenza = TryCast(myEntity, Avvocato).IndirizzoResidenza,
                            .LuogoResidenza = TryCast(myEntity, Avvocato).LuogoResidenza,
                            .ProvinciaResidenza = TryCast(myEntity, Avvocato).ProvinciaResidenza,
                            .StatoResidenza = TryCast(myEntity, Avvocato).StatoResidenza,
                            .Sesso = TryCast(myEntity, Avvocato).Sesso,
                            .DataDiMorte = "01/01/1753 00:00:00.0000000",
                            .Nazionalita = TryCast(myEntity, Avvocato).Nazionalita,
                            .TipologiaPersona = TryCast(myEntity, Avvocato).TipologiaPersona,
                            .NomeCompleto = TryCast(myEntity, Avvocato).NomeCompleto,
                            .IndirizzoStudio = TryCast(myEntity, Avvocato).IndirizzoStudio
                        }

                        dbc.Set(Of Avvocato).Add(avv)

                    End If

                    If GetType(Entity) = GetType(Parte) Then

                        Dim strNomeCompleto() = Split(TryCast(myEntity, Parte).NomeCompleto, " ")

                        Dim iMaxIdPersona = RicavaMaxId(Of Persona)()

                        'Creo una nuova parte
                        Dim parte = New Parte With
                        {
                            .IdPersona = iMaxIdPersona,
                            .EMail = TryCast(myEntity, Parte).EMail,
                            .EmailPEC = TryCast(myEntity, Parte).EmailPEC,
                            .IndirizzoSedeLegale = TryCast(myEntity, Parte).IndirizzoSedeLegale,
                            .IndirizzoSedeOperativa = TryCast(myEntity, Parte).IndirizzoSedeOperativa,
                            .IdLegaleRappresentante = TryCast(myEntity, Parte).IdLegaleRappresentante,
                            .DenominazioneLegaleRappresentante = TryCast(myEntity, Parte).DenominazioneLegaleRappresentante,
                            .Nome = strNomeCompleto(0),
                            .Cognome = strNomeCompleto(1),
                            .CodiceFiscale = TryCast(myEntity, Parte).CodiceFiscale,
                            .PartitaIVA = TryCast(myEntity, Parte).PartitaIVA,
                            .DataDiNascita = TryCast(myEntity, Parte).DataDiNascita,
                            .LuogoDiNascita = TryCast(myEntity, Parte).LuogoDiNascita,
                            .ProvinciaDiNascita = TryCast(myEntity, Parte).ProvinciaDiNascita,
                            .StatoDiNascita = TryCast(myEntity, Parte).StatoDiNascita,
                            .IndirizzoResidenza = TryCast(myEntity, Parte).IndirizzoResidenza,
                            .LuogoResidenza = TryCast(myEntity, Parte).LuogoResidenza,
                            .ProvinciaResidenza = TryCast(myEntity, Parte).ProvinciaResidenza,
                            .StatoResidenza = TryCast(myEntity, Parte).StatoResidenza,
                            .Sesso = TryCast(myEntity, Parte).Sesso,
                            .DataDiMorte = "01/01/1753 00:00:00.0000000",
                            .Nazionalita = TryCast(myEntity, Parte).Nazionalita,
                            .TipologiaPersona = TryCast(myEntity, Parte).TipologiaPersona,
                            .NomeCompleto = TryCast(myEntity, Parte).NomeCompleto
                        }

                        dbc.Set(Of Parte).Add(parte)

                    End If

                    If GetType(Entity) = GetType(Controparte) Then

                        'devo creare una nuova persona e salvarla
                        Dim strNomeCompleto() = Split(TryCast(myEntity, Controparte).NomeCompleto, " ")

                        Dim iMaxIdPersona = RicavaMaxId(Of Persona)()

                        'Creo una nuova controparte associata alla persona appena creata
                        Dim controparte = New Controparte With
                        {
                            .IdPersona = iMaxIdPersona,
                            .EMail = TryCast(myEntity, Controparte).EMail,
                            .EmailPEC = TryCast(myEntity, Controparte).EmailPEC,
                            .IndirizzoSedeLegale = TryCast(myEntity, Controparte).IndirizzoSedeLegale,
                            .IndirizzoSedeOperativa = TryCast(myEntity, Controparte).IndirizzoSedeOperativa,
                            .IdLegaleRappresentante = TryCast(myEntity, Controparte).IdLegaleRappresentante,
                            .DenominazioneLegaleRappresentante = TryCast(myEntity, Controparte).DenominazioneLegaleRappresentante,
                            .Nome = strNomeCompleto(0),
                            .Cognome = strNomeCompleto(1),
                            .CodiceFiscale = TryCast(myEntity, Controparte).CodiceFiscale,
                            .PartitaIVA = TryCast(myEntity, Controparte).PartitaIVA,
                            .DataDiNascita = TryCast(myEntity, Controparte).DataDiNascita,
                            .LuogoDiNascita = TryCast(myEntity, Controparte).LuogoDiNascita,
                            .ProvinciaDiNascita = TryCast(myEntity, Controparte).ProvinciaDiNascita,
                            .StatoDiNascita = TryCast(myEntity, Controparte).StatoDiNascita,
                            .IndirizzoResidenza = TryCast(myEntity, Controparte).IndirizzoResidenza,
                            .LuogoResidenza = TryCast(myEntity, Controparte).LuogoResidenza,
                            .ProvinciaResidenza = TryCast(myEntity, Controparte).ProvinciaResidenza,
                            .StatoResidenza = TryCast(myEntity, Controparte).StatoResidenza,
                            .Sesso = TryCast(myEntity, Controparte).Sesso,
                            .DataDiMorte = "01/01/1753 00:00:00.0000000",
                            .Nazionalita = TryCast(myEntity, Controparte).Nazionalita,
                            .TipologiaPersona = TryCast(myEntity, Controparte).TipologiaPersona,
                            .NomeCompleto = TryCast(myEntity, Controparte).NomeCompleto
                        }

                        dbc.Set(Of Controparte).Add(controparte)

                    End If

                    If GetType(Entity) = GetType(Persona) Then

                        Dim strNomeCompleto() = Split(TryCast(myEntity, Persona).NomeCompleto, " ")

                        Dim pers = New Persona With
                        {
                            .Nome = strNomeCompleto(0),
                            .Cognome = strNomeCompleto(1),
                            .CodiceFiscale = TryCast(myEntity, Persona).CodiceFiscale,
                            .PartitaIVA = TryCast(myEntity, Persona).PartitaIVA,
                            .DataDiNascita = TryCast(myEntity, Persona).DataDiNascita,
                            .LuogoDiNascita = TryCast(myEntity, Persona).LuogoDiNascita,
                            .ProvinciaDiNascita = TryCast(myEntity, Persona).ProvinciaDiNascita,
                            .StatoDiNascita = TryCast(myEntity, Persona).StatoDiNascita,
                            .IndirizzoResidenza = TryCast(myEntity, Persona).IndirizzoResidenza,
                            .LuogoResidenza = TryCast(myEntity, Persona).LuogoResidenza,
                            .ProvinciaResidenza = TryCast(myEntity, Persona).ProvinciaResidenza,
                            .StatoResidenza = TryCast(myEntity, Persona).StatoResidenza,
                            .Sesso = TryCast(myEntity, Persona).Sesso,
                            .DataDiMorte = "01/01/1753 00:00:00.0000000",
                            .Nazionalita = TryCast(myEntity, Persona).Nazionalita,
                            .TipologiaPersona = TryCast(myEntity, Persona).TipologiaPersona,
                            .NomeCompleto = TryCast(myEntity, Persona).NomeCompleto
                        }

                        dbc.Set(Of Persona).Add(pers)

                    End If

                    dbc.SaveChanges()

                Catch ex As Exception
                    ClsComune.GestisciEccezzioni(ex, "Operazioni: Sub Aggiungi. ", True, ClsComune.GlbStrUserNameLS, "", True)
                End Try

            End Using

        End Sub

        Public Shared Sub Elimina(Of Entity)(ByVal intEntityID As Integer)

            Dim intID As Integer = 0

            Using dbc = New LSDBContext()

                Try
                    If GetType(Entity) = GetType(Avvocato) Then

                        Dim avv = dbc.Avvocati.FirstOrDefault(Function(w) w.IdPersona = intEntityID)

                        If Not IsDBNull(avv) Then
                            dbc.Avvocati.Remove(avv)
                            Dim pers = dbc.Persone.FirstOrDefault(Function(w) w.IdPersona = avv.IdPersona)
                            dbc.Persone.Remove(pers)
                        End If

                    End If

                    If GetType(Entity) = GetType(Parte) Then

                        Dim parte = dbc.Parti.FirstOrDefault(Function(w) w.IdPersona = intEntityID)

                        If Not IsDBNull(parte) Then
                            dbc.Parti.Remove(parte)
                            Dim pers = dbc.Persone.FirstOrDefault(Function(w) w.IdPersona = parte.IdPersona)
                            dbc.Persone.Remove(pers)
                        End If

                    End If

                    If GetType(Entity) = GetType(Controparte) Then

                        Dim controparte = dbc.Controparti.FirstOrDefault(Function(w) w.IdPersona = intEntityID)

                        If Not IsDBNull(controparte) Then
                            dbc.Persone.Remove(controparte)
                            Dim pers = dbc.Persone.FirstOrDefault(Function(w) w.IdPersona = controparte.IdPersona)
                            dbc.Persone.Remove(pers)
                        End If

                    End If

                    If GetType(Entity) = GetType(Persona) Then

                        Dim pers = dbc.Persone.FirstOrDefault(Function(w) w.IdPersona = intEntityID)

                        If Not IsDBNull(pers) Then
                            dbc.Persone.Remove(pers)
                        End If

                    End If

                    'salvo le modifiche del database
                    dbc.SaveChanges()

                Catch ex As Exception
                    ClsComune.GestisciEccezzioni(ex, "Operazioni: Elimina. ", True, ClsComune.GlbStrUserNameLS, "", True)
                End Try

            End Using

        End Sub

        Public Shared Sub Aggiorna(Of Entity)(ByVal intEntityID As Integer, myEntity As Entity)

            Using dbc = New LSDBContext()

                Try
                    dbc.Database.BeginTransaction()

                    If GetType(Entity) = GetType(Avvocato) Then

                        Dim listaPers = From pers In dbc.Persone
                                        Join avv1 In dbc.Avvocati
                                        On pers.IdPersona Equals avv1.IdPersona
                                        Select pers.Nome, pers.Cognome, pers.TipologiaPersona

                        Dim avv = dbc.Avvocati.FirstOrDefault(Function(w) w.IdPersona = intEntityID)

                        avv.IdPersona = intEntityID
                        avv.Cellulare = TryCast(myEntity, Avvocato).Cellulare
                        avv.CodiceFiscale = TryCast(myEntity, Avvocato).CodiceFiscale
                        avv.Cognome = listaPers.First.Cognome
                        avv.DataDiMorte = TryCast(myEntity, Avvocato).DataDiMorte
                        avv.DataDiNascita = TryCast(myEntity, Avvocato).DataDiNascita
                        avv.DataIscrizioneAlboAvv = TryCast(myEntity, Avvocato).DataIscrizioneAlboAvv
                        avv.DataIscrizioneAlboCassazionisti = TryCast(myEntity, Avvocato).DataIscrizioneAlboCassazionisti
                        avv.EMail = TryCast(myEntity, Avvocato).EMail
                        avv.EmailPEC = TryCast(myEntity, Avvocato).EmailPEC
                        avv.FaxStudio = TryCast(myEntity, Avvocato).FaxStudio
                        avv.ForoDiAppartenza = TryCast(myEntity, Avvocato).ForoDiAppartenza
                        avv.IndirizzoResidenza = TryCast(myEntity, Avvocato).IndirizzoResidenza
                        avv.LuogoDiNascita = TryCast(myEntity, Avvocato).LuogoDiNascita
                        avv.LuogoResidenza = TryCast(myEntity, Avvocato).LuogoResidenza
                        avv.Nazionalita = TryCast(myEntity, Avvocato).Nazionalita
                        avv.Nome = listaPers.First.Nome
                        avv.NomeCompleto = TryCast(myEntity, Avvocato).NomeCompleto
                        avv.PartitaIVA = TryCast(myEntity, Avvocato).PartitaIVA
                        avv.ProvinciaDiNascita = TryCast(myEntity, Avvocato).ProvinciaDiNascita
                        avv.ProvinciaResidenza = TryCast(myEntity, Avvocato).ProvinciaResidenza
                        avv.Sesso = TryCast(myEntity, Avvocato).Sesso
                        avv.StatoDiNascita = TryCast(myEntity, Avvocato).StatoDiNascita
                        avv.StatoResidenza = TryCast(myEntity, Avvocato).StatoResidenza
                        avv.TelefonoStudio = TryCast(myEntity, Avvocato).TelefonoStudio
                        avv.TipologiaPersona = listaPers.First.TipologiaPersona
                    End If

                    If GetType(Entity) = GetType(Parte) Then

                        Dim listaPers = From pers In dbc.Persone
                                        Join parte1 In dbc.Parti
                                        On pers.IdPersona Equals parte1.IdPersona
                                        Select pers.Nome, pers.Cognome, pers.TipologiaPersona

                        Dim parte = dbc.Parti.FirstOrDefault(Function(w) w.IdPersona = intEntityID)

                        parte.IdPersona = intEntityID
                        parte.CodiceFiscale = TryCast(myEntity, Parte).CodiceFiscale
                        parte.Cognome = listaPers.First.Cognome
                        parte.DataDiMorte = TryCast(myEntity, Parte).DataDiMorte
                        parte.DataDiNascita = TryCast(myEntity, Parte).DataDiNascita
                        parte.EMail = TryCast(myEntity, Parte).EMail
                        parte.EmailPEC = TryCast(myEntity, Parte).EmailPEC
                        parte.IndirizzoResidenza = TryCast(myEntity, Parte).IndirizzoResidenza
                        parte.LuogoDiNascita = TryCast(myEntity, Parte).LuogoDiNascita
                        parte.LuogoResidenza = TryCast(myEntity, Parte).LuogoResidenza
                        parte.Nazionalita = TryCast(myEntity, Parte).Nazionalita
                        parte.Nome = listaPers.First.Nome
                        parte.NomeCompleto = TryCast(myEntity, Parte).NomeCompleto
                        parte.PartitaIVA = TryCast(myEntity, Parte).PartitaIVA
                        parte.ProvinciaDiNascita = TryCast(myEntity, Parte).ProvinciaDiNascita
                        parte.ProvinciaResidenza = TryCast(myEntity, Parte).ProvinciaResidenza
                        parte.Sesso = TryCast(myEntity, Parte).Sesso
                        parte.StatoDiNascita = TryCast(myEntity, Parte).StatoDiNascita
                        parte.StatoResidenza = TryCast(myEntity, Parte).StatoResidenza
                        parte.TipologiaPersona = listaPers.First.TipologiaPersona
                        parte.IndirizzoSedeLegale = TryCast(myEntity, Parte).IndirizzoSedeLegale
                        parte.IndirizzoSedeOperativa = TryCast(myEntity, Parte).IndirizzoSedeOperativa
                        parte.IdLegaleRappresentante = TryCast(myEntity, Parte).IdLegaleRappresentante
                        parte.DenominazioneLegaleRappresentante = TryCast(myEntity, Parte).DenominazioneLegaleRappresentante
                    End If

                    If GetType(Entity) = GetType(Controparte) Then

                        Dim listaPers = From pers In dbc.Persone
                                        Join controparte1 In dbc.Controparti
                                        On pers.IdPersona Equals controparte1.IdPersona
                                        Select pers.Nome, pers.Cognome, pers.TipologiaPersona

                        Dim controparte = dbc.Controparti.FirstOrDefault(Function(w) w.IdPersona = intEntityID)

                        controparte.IdPersona = intEntityID
                        controparte.CodiceFiscale = TryCast(myEntity, Controparte).CodiceFiscale
                        controparte.Cognome = listaPers.First.Cognome
                        controparte.DataDiMorte = TryCast(myEntity, Controparte).DataDiMorte
                        controparte.DataDiNascita = TryCast(myEntity, Controparte).DataDiNascita
                        controparte.EMail = TryCast(myEntity, Controparte).EMail
                        controparte.EmailPEC = TryCast(myEntity, Controparte).EmailPEC
                        controparte.IndirizzoResidenza = TryCast(myEntity, Controparte).IndirizzoResidenza
                        controparte.LuogoDiNascita = TryCast(myEntity, Controparte).LuogoDiNascita
                        controparte.LuogoResidenza = TryCast(myEntity, Controparte).LuogoResidenza
                        controparte.Nazionalita = TryCast(myEntity, Controparte).Nazionalita
                        controparte.Nome = listaPers.First.Nome
                        controparte.NomeCompleto = TryCast(myEntity, Controparte).NomeCompleto
                        controparte.PartitaIVA = TryCast(myEntity, Controparte).PartitaIVA
                        controparte.ProvinciaDiNascita = TryCast(myEntity, Controparte).ProvinciaDiNascita
                        controparte.ProvinciaResidenza = TryCast(myEntity, Controparte).ProvinciaResidenza
                        controparte.Sesso = TryCast(myEntity, Controparte).Sesso
                        controparte.StatoDiNascita = TryCast(myEntity, Controparte).StatoDiNascita
                        controparte.StatoResidenza = TryCast(myEntity, Controparte).StatoResidenza
                        controparte.TipologiaPersona = listaPers.First.TipologiaPersona
                        controparte.IndirizzoSedeLegale = TryCast(myEntity, Controparte).IndirizzoSedeLegale
                        controparte.IndirizzoSedeOperativa = TryCast(myEntity, Controparte).IndirizzoSedeOperativa
                        controparte.IdLegaleRappresentante = TryCast(myEntity, Controparte).IdLegaleRappresentante
                        controparte.DenominazioneLegaleRappresentante = TryCast(myEntity, Controparte).DenominazioneLegaleRappresentante
                    End If

                    If GetType(Entity) = GetType(Persona) Then

                        Dim pers = dbc.Persone.FirstOrDefault(Function(w) w.IdPersona = intEntityID)

                        pers.IdPersona = intEntityID
                        pers.CodiceFiscale = TryCast(myEntity, Persona).CodiceFiscale
                        pers.Cognome = TryCast(myEntity, Persona).Cognome
                        pers.DataDiMorte = TryCast(myEntity, Persona).DataDiMorte
                        pers.DataDiNascita = TryCast(myEntity, Persona).DataDiNascita
                        pers.IndirizzoResidenza = TryCast(myEntity, Persona).IndirizzoResidenza
                        pers.LuogoDiNascita = TryCast(myEntity, Persona).LuogoDiNascita
                        pers.LuogoResidenza = TryCast(myEntity, Persona).LuogoResidenza
                        pers.Nazionalita = TryCast(myEntity, Persona).Nazionalita
                        pers.Nome = TryCast(myEntity, Persona).Nome
                        pers.NomeCompleto = TryCast(myEntity, Persona).NomeCompleto
                        pers.PartitaIVA = TryCast(myEntity, Persona).PartitaIVA
                        pers.ProvinciaDiNascita = TryCast(myEntity, Persona).ProvinciaDiNascita
                        pers.ProvinciaResidenza = TryCast(myEntity, Persona).ProvinciaResidenza
                        pers.Sesso = TryCast(myEntity, Persona).Sesso
                        pers.StatoDiNascita = TryCast(myEntity, Persona).StatoDiNascita
                        pers.StatoResidenza = TryCast(myEntity, Persona).StatoResidenza
                        pers.TipologiaPersona = TryCast(myEntity, Persona).TipologiaPersona

                    End If

                    If GetType(Entity) = GetType(Utente) Then

                        Dim utente = dbc.Utenti.FirstOrDefault(Function(w) w.IdUtente = intEntityID)

                        utente.IdUtente = intEntityID
                        utente.NomeUtente = TryCast(myEntity, Utente).NomeUtente
                        utente.PasswordCriptata = TryCast(myEntity, Utente).PasswordCriptata
                        utente.PermessoAgenda = TryCast(myEntity, Utente).PermessoAgenda
                        utente.PermessoAnagrafiche = TryCast(myEntity, Utente).PermessoAnagrafiche
                        utente.PermessoAppEsterne = TryCast(myEntity, Utente).PermessoAppEsterne
                        utente.PermessoFatturazione = TryCast(myEntity, Utente).PermessoFatturazione
                        utente.PermessoGenerazioneAtti = TryCast(myEntity, Utente).PermessoGenerazioneAtti
                        utente.PermessoGestioneUtenti = TryCast(myEntity, Utente).PermessoGestioneUtenti
                        utente.PermessoUtility = TryCast(myEntity, Utente).PermessoUtility
                    End If

                    'salvo le modifiche del database
                    dbc.SaveChanges()
                    dbc.Database.CurrentTransaction.Commit()

                Catch ex As Exception
                    ClsComune.GestisciEccezzioni(ex, "Operazioni: Aggiorna. ", True, ClsComune.GlbStrUserNameLS, "", True)
                End Try

            End Using

        End Sub

        Public Shared Function CaricaDatiFiltrati(Of Entity)(ByVal listaDiFiltri As Dictionary(Of String, String)) As List(Of Entity)

            Using dbc = New LSDBContext()

                Try

                    If GetType(Entity) = GetType(Avvocato) Then

                        Dim strSQL As String = "Select * From Avvocati Inner Join Persone On Avvocati.IdPersona = Persone.IdPersona Where "
                        Dim strSQLFilter As String = ""
                        Dim parametri As String() = Nothing
                        Dim iContaFiltri As Integer = 0

                        For Each filtro In listaDiFiltri

                            Select Case filtro.Key
                                Case "Nominativo"
                                    strSQLFilter = strSQLFilter & " And Persone.Cognome Like '%" & filtro.Value & "%'"
                                Case "IndirizzoStudio"
                                    strSQLFilter = strSQLFilter & " AND Persone.IndirizzoResidenza like '%" & filtro.Value & "%'"
                                Case "IdAvvocato"
                                    strSQLFilter = strSQLFilter & " And Avvocati.IdPersona = " & filtro.Value
                            End Select

                            If iContaFiltri = 0 Then
                                strSQLFilter = strSQLFilter.Substring(5, strSQLFilter.Length - 5)
                            End If
                            strSQL = strSQL & strSQLFilter

                                If (parametri Is Nothing) Then
                                Array.Resize(parametri, 1)
                            Else
                                Array.Resize(parametri, parametri.Length + 1)
                            End If

                            parametri(parametri.Length - 1) = filtro.Value

                            strSQLFilter = ""
                            iContaFiltri = iContaFiltri + 1
                        Next

                        If (Not parametri Is Nothing) Then
                            Dim listaAvv = dbc.Database.SqlQuery(Of Avvocato)(strSQL).ToList()
                            Return TryCast(CObj(listaAvv), List(Of Entity))
                        End If

                    End If

                    If GetType(Entity) = GetType(ComuneItaliano) Then

                        Dim strSQL As String = "Select * From ComuniItaliani Where "
                        Dim strSQLFilter As String = ""
                        Dim parametri As String() = Nothing
                        Dim iContaFiltri As Integer = 0

                        For Each filtro In listaDiFiltri

                            Select Case filtro.Key
                                Case "SiglaAutoProvincia"
                                    strSQLFilter = strSQLFilter & " And SiglaAutoProvincia Like '%" & filtro.Value & "%'"
                                Case "CodiceCatasto"
                                    strSQLFilter = strSQLFilter & " And DenominazioneComune = '" & filtro.Value & "'"
                            End Select

                            If iContaFiltri = 0 Then
                                strSQLFilter = strSQLFilter.Substring(5, strSQLFilter.Length - 5)
                            End If
                            strSQL = strSQL & strSQLFilter

                            If (parametri Is Nothing) Then
                                Array.Resize(parametri, 1)
                            Else
                                Array.Resize(parametri, parametri.Length + 1)
                            End If

                            parametri(parametri.Length - 1) = filtro.Value

                            strSQLFilter = ""
                            iContaFiltri = iContaFiltri + 1
                        Next

                        If (Not parametri Is Nothing) Then
                            Dim listaComuni = dbc.Database.SqlQuery(Of ComuneItaliano)(strSQL).ToList()
                            Return TryCast(CObj(listaComuni), List(Of Entity))
                        End If

                    End If

                    If GetType(Entity) = GetType(EnteGiuridico) Then

                        Dim strSQL As String = "Select distinct IdEnteGiuridico,SUBSTRING(DenominazioneEnte,24,len(DenominazioneEnte) - 23) As DenominazioneEnte, ' ' as EMailEnte,  ' ' as ResponsabileEnte, ' ' as IndirizzoEnte, 0 as IdTipoEnteGiuridico  "
                        Dim strSQLFilter As String = ""
                        Dim parametri As String() = Nothing
                        Dim strSQLTipoEnte As String = ""
                        Dim iContaFiltri As Integer = 0

                        strSQL = strSQL & "From EntiGiuridici Where "

                        For Each filtro In listaDiFiltri

                            Select Case filtro.Key
                                Case "ForoCompetenza"
                                    strSQLFilter = strSQLFilter & " And DenominazioneEnte Like '%" & filtro.Value & "%' and DenominazioneEnte not like '%Ufficio%' and DenominazioneEnte not like '%-%'"
                                Case "TipoEnteGiuridico"
                                    'Ricavo l'Id del tipo dalla descrizione passata come parametro
                                    strSQL = "Select * From EntiGiuridici Where "
                                    strSQLTipoEnte = "Select * " &
                                                 "From TipiEntiGiuridici " &
                                                 "Where DescrizioneTipoEnteGiuridico = '" & filtro.Value & "'"

                                    Dim listaTipiEnti = dbc.Database.SqlQuery(Of TipoEnteGiuridico)(strSQLTipoEnte).ToList()

                                    For Each tipoEnte In listaTipiEnti
                                        strSQLFilter = strSQLFilter & " And IdTipoEnteGiuridico =" & tipoEnte.IdTipoEnteGiuridico
                                    Next
                            End Select

                            If iContaFiltri = 0 Then
                                strSQLFilter = strSQLFilter.Substring(5, strSQLFilter.Length - 5)
                            End If
                            strSQL = strSQL & strSQLFilter & " order by DenominazioneEnte"

                            If (parametri Is Nothing) Then
                                Array.Resize(parametri, 1)
                            Else
                                Array.Resize(parametri, parametri.Length + 1)
                            End If

                            parametri(parametri.Length - 1) = filtro.Value

                            strSQLFilter = ""
                            iContaFiltri = iContaFiltri + 1
                        Next

                        If (Not parametri Is Nothing) Then
                            Dim listaEntiGiuridici = dbc.Database.SqlQuery(Of EnteGiuridico)(strSQL).ToList()
                            Return TryCast(CObj(listaEntiGiuridici), List(Of Entity))
                        End If
                    End If

                    If GetType(Entity) = GetType(Parte) Then

                        Dim strSQL As String = "Select * From Parti Inner Join Persone On Parti.IdPersona = Persone.IdPersona Where "
                        Dim strSQLFilter As String = ""
                        Dim parametri As String() = Nothing
                        Dim iContaFiltri As Integer = 0

                        For Each filtro In listaDiFiltri

                            Select Case filtro.Key
                                Case "Denominazione"
                                    strSQLFilter = strSQLFilter & " And Persone.Cognome Like '%" & filtro.Value & "%'"
                                Case "IdParte"
                                    strSQLFilter = strSQLFilter & " And Parti.IdPersona = " & filtro.Value
                                Case "Nominativo"
                                    strSQLFilter = strSQLFilter & " And (Persone.Cognome Like '%" & filtro.Value & "%' OR Persone.Nome Like '%" & filtro.Value & "%')"
                                Case "CodiceFiscale"
                                    strSQLFilter = strSQLFilter & " And Persone.CodiceFiscale Like '%" & filtro.Value & "%'"
                            End Select

                            If iContaFiltri = 0 Then
                                strSQLFilter = strSQLFilter.Substring(5, strSQLFilter.Length - 5)
                            End If
                            strSQL = strSQL & strSQLFilter

                            If (parametri Is Nothing) Then
                                Array.Resize(parametri, 1)
                            Else
                                Array.Resize(parametri, parametri.Length + 1)
                            End If

                            parametri(parametri.Length - 1) = filtro.Value

                            strSQLFilter = ""
                            iContaFiltri = iContaFiltri + 1
                        Next

                        If (Not parametri Is Nothing) Then
                            Dim listaParti = dbc.Database.SqlQuery(Of Parte)(strSQL).ToList()
                            Return TryCast(CObj(listaParti), List(Of Entity))
                        End If

                    End If

                    If GetType(Entity) = GetType(Controparte) Then

                        Dim strSQL As String = "Select * From Controparti Inner Join Persone On Controparti.IdPersona = Persone.IdPersona Where "
                        Dim strSQLFilter As String = ""
                        Dim parametri As String() = Nothing
                        Dim iContaFiltri As Integer = 0

                        For Each filtro In listaDiFiltri

                            Select Case filtro.Key
                                Case "Denominazione"
                                    strSQLFilter = strSQLFilter & " And Persone.Cognome Like '%" & filtro.Value & "%'"
                                Case "IdControparte"
                                    strSQLFilter = strSQLFilter & " And Controparti.IdPersona = " & filtro.Value
                                Case "Nominativo"
                                    strSQLFilter = strSQLFilter & " And (Persone.Cognome Like '%" & filtro.Value & "%' OR Persone.Nome Like '%" & filtro.Value & "%')"
                                Case "CodiceFiscale"
                                    strSQLFilter = strSQLFilter & " And Persone.CodiceFiscale Like '%" & filtro.Value & "%'"
                            End Select

                            If iContaFiltri = 0 Then
                                strSQLFilter = strSQLFilter.Substring(5, strSQLFilter.Length - 5)
                            End If
                            strSQL = strSQL & strSQLFilter

                            If (parametri Is Nothing) Then
                                Array.Resize(parametri, 1)
                            Else
                                Array.Resize(parametri, parametri.Length + 1)
                            End If

                            parametri(parametri.Length - 1) = filtro.Value

                            strSQLFilter = ""
                            iContaFiltri = iContaFiltri + 1
                        Next

                        If (Not parametri Is Nothing) Then
                            Dim listaControparti = dbc.Database.SqlQuery(Of Controparte)(strSQL).ToList()
                            Return TryCast(CObj(listaControparti), List(Of Entity))
                        End If

                    End If

                    If GetType(Entity) = GetType(Persona) Then

                        Dim strSQL As String = "Select * From Persone Where "
                        Dim strSQLFilter As String = ""
                        Dim parametri As String() = Nothing
                        Dim iContaFiltri As Integer = 0

                        For Each filtro In listaDiFiltri

                            Select Case filtro.Key
                                Case "Denominazione"
                                    strSQLFilter = strSQLFilter & " And Persone.Cognome Like '%" & filtro.Value & "%'"
                                Case "IdPersona"
                                    strSQLFilter = strSQLFilter & " And Persone.IdPersona = " & filtro.Value
                            End Select

                            If iContaFiltri = 0 Then
                                strSQLFilter = strSQLFilter.Substring(5, strSQLFilter.Length - 5)
                            End If
                            strSQL = strSQL & strSQLFilter

                            If (parametri Is Nothing) Then
                                Array.Resize(parametri, 1)
                            Else
                                Array.Resize(parametri, parametri.Length + 1)
                            End If

                            parametri(parametri.Length - 1) = filtro.Value

                            strSQLFilter = ""
                            iContaFiltri = iContaFiltri + 1
                        Next

                        If (Not parametri Is Nothing) Then
                            Dim listaPers = dbc.Database.SqlQuery(Of Persona)(strSQL).ToList()
                            Return TryCast(CObj(listaPers), List(Of Entity))
                        End If

                    End If

                    If GetType(Entity) = GetType(Utente) Then

                        Dim strSQL As String = "Select * From Utenti Where "
                        Dim strSQLFilter As String = ""
                        Dim parametri As String() = Nothing
                        Dim iContaFiltri As Integer = 0

                        For Each filtro In listaDiFiltri

                            Select Case filtro.Key
                                Case "NomeUtente"
                                    strSQLFilter = strSQLFilter & " And Utenti.NomeUtente Like '%" & filtro.Value & "%'"
                                Case "PasswordCriptata"
                                    strSQLFilter = strSQLFilter & " And Utenti.PasswordCriptata = '" & filtro.Value & "'"
                            End Select

                            If iContaFiltri = 0 Then
                                strSQLFilter = strSQLFilter.Substring(5, strSQLFilter.Length - 5)
                            End If
                            strSQL = strSQL & strSQLFilter

                            If (parametri Is Nothing) Then
                                Array.Resize(parametri, 1)
                            Else
                                Array.Resize(parametri, parametri.Length + 1)
                            End If

                            parametri(parametri.Length - 1) = filtro.Value

                            strSQLFilter = ""
                            iContaFiltri = iContaFiltri + 1
                        Next

                        If (Not parametri Is Nothing) Then
                            Dim listaUtenti = dbc.Database.SqlQuery(Of Utente)(strSQL).ToList()
                            Return TryCast(CObj(listaUtenti), List(Of Entity))
                        End If

                    End If

                Catch ex As Exception
                    ClsComune.GestisciEccezzioni(ex, "Operazioni: CaricaDatiFiltrati. ", True, ClsComune.GlbStrUserNameLS, "", True)
                End Try

                Return Nothing

            End Using

        End Function

        Public Shared Function CaricaTutti(Of Entity)() As List(Of Entity)

            Using dbc = New LSDBContext()

                Try
                    If GetType(Entity) = GetType(Avvocato) Then

                        Dim avvocatiList As New List(Of Avvocato)
                        avvocatiList = dbc.Avvocati.ToList()
                        Return TryCast(CObj(avvocatiList), List(Of Entity))

                    End If

                    If GetType(Entity) = GetType(Provincia) Then

                        Dim provList As New List(Of Provincia)
                        provList = dbc.Province.ToList()
                        Return TryCast(CObj(provList), List(Of Entity))

                    End If

                    If GetType(Entity) = GetType(Nazione) Then

                        Dim nazioneList As New List(Of Nazione)
                        nazioneList = dbc.Nazioni.ToList()
                        Return TryCast(CObj(nazioneList), List(Of Entity))

                    End If

                    If GetType(Entity) = GetType(TipoEnteGiuridico) Then

                        Dim tipiEntiList As New List(Of TipoEnteGiuridico)
                        tipiEntiList = dbc.TipiEntiGiuridici.ToList()
                        Return TryCast(CObj(tipiEntiList), List(Of Entity))

                    End If

                    If GetType(Entity) = GetType(Parte) Then

                        Dim partiList As New List(Of Parte)
                        partiList = dbc.Parti.ToList()
                        Return TryCast(CObj(partiList), List(Of Entity))

                    End If

                    If GetType(Entity) = GetType(Controparte) Then

                        Dim contropartiList As New List(Of Controparte)
                        contropartiList = dbc.Controparti.ToList()
                        Return TryCast(CObj(contropartiList), List(Of Entity))

                    End If

                    If GetType(Entity) = GetType(Persona) Then

                        Dim persList As New List(Of Persona)
                        persList = dbc.Persone.ToList()
                        Return TryCast(CObj(persList), List(Of Entity))

                    End If

                    If GetType(Entity) = GetType(Utente) Then

                        Dim utentiList As New List(Of Utente)
                        utentiList = dbc.Utenti.ToList()
                        Return TryCast(CObj(utentiList), List(Of Entity))

                    End If

                Catch ex As Exception
                    ClsComune.GestisciEccezzioni(ex, "Operazioni: CaricaTutti. ", True, ClsComune.GlbStrUserNameLS, "", True)
                End Try

            End Using

            Return Nothing

        End Function

        Private Shared Function Convert(Of T)(ByVal data As Object) As T
            Try
                If (data Is Nothing OrElse data Is DBNull.Value) Then
                    Return Nothing
                Else
                    Return CType(data, T)
                End If
            Catch ex As Exception
                ClsComune.GestisciEccezzioni(ex, "Operazioni: Convert. ", True, ClsComune.GlbStrUserNameLS, "", True)
            End Try
        End Function

        Public Shared Function CaricaRigaDatoId(Of Entity)(ByVal intIdEntita As Integer) As Entity

            Using dbc = New LSDBContext()
                Try
                    If GetType(Entity) = GetType(Avvocato) Then

                        Dim avv As Avvocato
                        avv = dbc.Avvocati.FirstOrDefault(Function(w) w.IdPersona = intIdEntita)

                        Return Convert(Of Entity)(avv)

                    End If

                    If GetType(Entity) = GetType(Parte) Then

                        Dim parte As Parte
                        parte = dbc.Parti.FirstOrDefault(Function(w) w.IdPersona = intIdEntita)

                        Return Convert(Of Entity)(parte)

                    End If

                    If GetType(Entity) = GetType(Controparte) Then

                        Dim controparte As Controparte
                        controparte = dbc.Controparti.FirstOrDefault(Function(w) w.IdPersona = intIdEntita)

                        Return Convert(Of Entity)(controparte)

                    End If

                    If GetType(Entity) = GetType(Persona) Then

                        Dim pers As Persona
                        pers = dbc.Persone.FirstOrDefault(Function(w) w.IdPersona = intIdEntita)

                        Return Convert(Of Entity)(pers)

                    End If

                    If GetType(Entity) = GetType(Utente) Then

                        Dim utente As Utente
                        utente = dbc.Utenti.FirstOrDefault(Function(w) w.IdUtente = intIdEntita)

                        Return Convert(Of Entity)(utente)

                    End If
                Catch ex As Exception
                    ClsComune.GestisciEccezzioni(ex, "Operazioni: CaricaRigaDatoId. ", True, ClsComune.GlbStrUserNameLS, "", True)
                End Try
            End Using

        End Function

        Public Shared Function RicavaMaxId(Of Entity)() As Integer

            Using dbc = New LSDBContext()
                Try

                    If GetType(Entity) = GetType(Avvocato) Then

                        Dim intMaxIdAvvocato = (From avv In dbc.Avvocati
                                                Select CType(avv.IdPersona, Integer?)).Max

                        If Not intMaxIdAvvocato Is Nothing Then
                            Return intMaxIdAvvocato
                        End If

                    End If

                    If GetType(Entity) = GetType(Persona) Then

                        Dim intMaxIdPersona = (From pers In dbc.Persone
                                               Select CType(pers.IdPersona, Integer?)).Max

                        If Not intMaxIdPersona Is Nothing Then
                            Return intMaxIdPersona
                        End If

                    End If

                    If GetType(Entity) = GetType(Parte) Then

                        Dim intMaxIdParte = (From parte In dbc.Parti
                                             Select CType(parte.IdPersona, Integer?)).Max

                        If Not intMaxIdParte Is Nothing Then
                            Return intMaxIdParte
                        End If

                    End If

                    If GetType(Entity) = GetType(Controparte) Then

                        Dim intMaxIdControparte = (From controparte In dbc.Controparti
                                                   Select CType(controparte.IdPersona, Integer?)).Max

                        If Not intMaxIdControparte Is Nothing Then
                            Return intMaxIdControparte
                        End If

                    End If

                Catch ex As Exception
                    ClsComune.GestisciEccezzioni(ex, "Operazioni: RicavaMaxId. ", True, ClsComune.GlbStrUserNameLS, "", True)
                End Try

            End Using

            Return 1

        End Function

    End Class

End Namespace