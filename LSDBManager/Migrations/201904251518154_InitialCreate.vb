Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class InitialCreate
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Persone",
                Function(c) New With
                    {
                        .IdPersona = c.Int(nullable := False, identity := True),
                        .Nome = c.String(nullable := False, maxLength := 30),
                        .Cognome = c.String(nullable := False, maxLength := 30),
                        .CodiceFiscale = c.String(maxLength := 16),
                        .PartitaIVA = c.String(maxLength := 12),
                        .DataDiNascita = c.DateTime(nullable := False, precision := 7, storeType := "datetime2"),
                        .LuogoDiNascita = c.String(maxLength := 50),
                        .ProvinciaDiNascita = c.String(maxLength := 50),
                        .StatoDiNascita = c.String(maxLength := 50),
                        .IndirizzoResidenza = c.String(maxLength := 150),
                        .LuogoResidenza = c.String(maxLength := 50),
                        .ProvinciaResidenza = c.String(maxLength := 50),
                        .StatoResidenza = c.String(maxLength := 50),
                        .Sesso = c.String(nullable := False, maxLength := 7),
                        .DataDiMorte = c.DateTime(precision := 7, storeType := "datetime2"),
                        .Nazionalita = c.String(maxLength := 50),
                        .TipologiaPersona = c.String(nullable := False, maxLength := 20),
                        .NomeCompleto = c.String(maxLength := 60)
                    }) _
                .PrimaryKey(Function(t) t.IdPersona)
            
            CreateTable(
                "dbo.Atti",
                Function(c) New With
                    {
                        .IdAtto = c.Int(nullable := False, identity := True),
                        .DescrizioneAtto = c.String(nullable := False, maxLength := 200),
                        .TipoAtto = c.String(nullable := False, maxLength := 30),
                        .NumeroRuolo = c.String(nullable := False, maxLength := 10),
                        .DataOraCreazioneAtto = c.DateTime(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.IdAtto)
            
            CreateTable(
                "dbo.ComuniItaliani",
                Function(c) New With
                    {
                        .IdComune = c.Int(nullable := False, identity := True),
                        .DenominazioneComune = c.String(nullable := False, maxLength := 150),
                        .CodiceCatastaleComune = c.String(nullable := False, maxLength := 4),
                        .SiglaAutoProvincia = c.String(nullable := False, maxLength := 2)
                    }) _
                .PrimaryKey(Function(t) t.IdComune)
            
            CreateTable(
                "dbo.EntiGiuridici",
                Function(c) New With
                    {
                        .IdEnteGiuridico = c.Int(nullable := False, identity := True),
                        .DenominazioneEnte = c.String(nullable := False, maxLength := 150),
                        .EMailEnte = c.String(maxLength := 150),
                        .ResponsabileEnte = c.String(maxLength := 150),
                        .IndirizzoEnte = c.String(maxLength := 100),
                        .IdTipoEnteGiuridico = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.IdEnteGiuridico)
            
            CreateTable(
                "dbo.Nazioni",
                Function(c) New With
                    {
                        .IdNazione = c.Int(nullable := False, identity := True),
                        .CodiceNazione = c.String(nullable := False, maxLength := 4),
                        .DenominazioneNazione = c.String(nullable := False, maxLength := 150),
                        .SiglaBreveNazione = c.String(nullable := False, maxLength := 2),
                        .SiglaEstesaNazione = c.String(nullable := False, maxLength := 3),
                        .SiglaStatoSovrano = c.String(),
                        .Continente = c.String(),
                        .Soppressa = c.String(),
                        .PrefissoTelInternazionale = c.String(maxLength := 5)
                    }) _
                .PrimaryKey(Function(t) t.IdNazione)
            
            CreateTable(
                "dbo.Province",
                Function(c) New With
                    {
                        .IdProvincia = c.Int(nullable := False, identity := True),
                        .SiglaAutoProvincia = c.String(nullable := False, maxLength := 2),
                        .DenominazioneProvincia = c.String(nullable := False, maxLength := 150),
                        .DenominazioneRegione = c.String(nullable := False, maxLength := 150)
                    }) _
                .PrimaryKey(Function(t) t.IdProvincia)
            
            CreateTable(
                "dbo.TipiEntiGiuridici",
                Function(c) New With
                    {
                        .IdTipoEnteGiuridico = c.Int(nullable := False, identity := True),
                        .DescrizioneTipoEnteGiuridico = c.String(nullable := False, maxLength := 150)
                    }) _
                .PrimaryKey(Function(t) t.IdTipoEnteGiuridico)
            
            CreateTable(
                "dbo.Utenti",
                Function(c) New With
                    {
                        .IdUtente = c.Int(nullable := False, identity := True),
                        .NomeUtente = c.String(nullable := False, maxLength := 50),
                        .PasswordCriptata = c.String(nullable := False, maxLength := 50),
                        .PermessoAnagrafiche = c.Boolean(nullable := False),
                        .PermessoGestioneUtenti = c.Boolean(nullable := False),
                        .PermessoFatturazione = c.Boolean(nullable := False),
                        .PermessoGenerazioneAtti = c.Boolean(nullable := False),
                        .PermessoAppEsterne = c.Boolean(nullable := False),
                        .PermessoAgenda = c.Boolean(nullable := False),
                        .PermessoUtility = c.Boolean(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.IdUtente)
            
            CreateTable(
                "dbo.Amministrati",
                Function(c) New With
                    {
                        .IdPersona = c.Int(nullable := False),
                        .DataInizioUltimaADS = c.DateTime(nullable := False, precision := 7, storeType := "datetime2")
                    }) _
                .PrimaryKey(Function(t) t.IdPersona) _
                .ForeignKey("dbo.Persone", Function(t) t.IdPersona) _
                .Index(Function(t) t.IdPersona)
            
            CreateTable(
                "dbo.Avvocati",
                Function(c) New With
                    {
                        .IdPersona = c.Int(nullable := False),
                        .EMail = c.String(maxLength := 150),
                        .EmailPEC = c.String(maxLength := 150),
                        .ForoDiAppartenza = c.String(maxLength := 50),
                        .DataIscrizioneAlboAvv = c.DateTime(nullable := False, precision := 7, storeType := "datetime2"),
                        .DataIscrizioneAlboCassazionisti = c.DateTime(nullable := False, precision := 7, storeType := "datetime2"),
                        .TelefonoStudio = c.String(maxLength := 20),
                        .FaxStudio = c.String(maxLength := 20),
                        .Cellulare = c.String(maxLength := 20),
                        .IndirizzoStudio = c.String(maxLength := 200)
                    }) _
                .PrimaryKey(Function(t) t.IdPersona) _
                .ForeignKey("dbo.Persone", Function(t) t.IdPersona) _
                .Index(Function(t) t.IdPersona)
            
            CreateTable(
                "dbo.Controparti",
                Function(c) New With
                    {
                        .IdPersona = c.Int(nullable := False),
                        .EMail = c.String(maxLength := 150),
                        .EmailPEC = c.String(maxLength := 150),
                        .IndirizzoSedeLegale = c.String(maxLength := 200),
                        .IndirizzoSedeOperativa = c.String(maxLength := 200),
                        .IdLegaleRappresentante = c.Int(nullable := False),
                        .DenominazioneLegaleRappresentante = c.String(maxLength := 150)
                    }) _
                .PrimaryKey(Function(t) t.IdPersona) _
                .ForeignKey("dbo.Persone", Function(t) t.IdPersona) _
                .Index(Function(t) t.IdPersona)
            
            CreateTable(
                "dbo.Giudici",
                Function(c) New With
                    {
                        .IdPersona = c.Int(nullable := False),
                        .AreaCompetenza = c.String(maxLength := 6),
                        .Qualifica = c.String(maxLength := 20),
                        .Competenze = c.String(maxLength := 150)
                    }) _
                .PrimaryKey(Function(t) t.IdPersona) _
                .ForeignKey("dbo.Persone", Function(t) t.IdPersona) _
                .Index(Function(t) t.IdPersona)
            
            CreateTable(
                "dbo.Parti",
                Function(c) New With
                    {
                        .IdPersona = c.Int(nullable := False),
                        .EMail = c.String(maxLength := 150),
                        .EmailPEC = c.String(maxLength := 150),
                        .IndirizzoSedeLegale = c.String(maxLength := 200),
                        .IndirizzoSedeOperativa = c.String(maxLength := 200),
                        .IdLegaleRappresentante = c.Int(nullable := False),
                        .DenominazioneLegaleRappresentante = c.String(maxLength := 150)
                    }) _
                .PrimaryKey(Function(t) t.IdPersona) _
                .ForeignKey("dbo.Persone", Function(t) t.IdPersona) _
                .Index(Function(t) t.IdPersona)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Parti", "IdPersona", "dbo.Persone")
            DropForeignKey("dbo.Giudici", "IdPersona", "dbo.Persone")
            DropForeignKey("dbo.Controparti", "IdPersona", "dbo.Persone")
            DropForeignKey("dbo.Avvocati", "IdPersona", "dbo.Persone")
            DropForeignKey("dbo.Amministrati", "IdPersona", "dbo.Persone")
            DropIndex("dbo.Parti", New String() { "IdPersona" })
            DropIndex("dbo.Giudici", New String() { "IdPersona" })
            DropIndex("dbo.Controparti", New String() { "IdPersona" })
            DropIndex("dbo.Avvocati", New String() { "IdPersona" })
            DropIndex("dbo.Amministrati", New String() { "IdPersona" })
            DropTable("dbo.Parti")
            DropTable("dbo.Giudici")
            DropTable("dbo.Controparti")
            DropTable("dbo.Avvocati")
            DropTable("dbo.Amministrati")
            DropTable("dbo.Utenti")
            DropTable("dbo.TipiEntiGiuridici")
            DropTable("dbo.Province")
            DropTable("dbo.Nazioni")
            DropTable("dbo.EntiGiuridici")
            DropTable("dbo.ComuniItaliani")
            DropTable("dbo.Atti")
            DropTable("dbo.Persone")
        End Sub
    End Class
End Namespace
