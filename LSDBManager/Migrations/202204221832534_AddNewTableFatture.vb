Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddNewTableFatture
        Inherits DbMigration

        Public Overrides Sub Up()
            CreateTable(
                "dbo.Fatture",
                Function(c) New With
                    {
                        .IdFattura = c.Int(nullable:=False, identity:=True),
                        .NumFattura = c.Int(nullable:=False),
                        .OggettoFattura = c.String(nullable:=False, maxLength:=250),
                        .DataFattura = c.DateTime(nullable:=False, precision:=7, storeType:="datetime2"),
                        .DataInserimento = c.DateTime(precision:=7, storeType:="datetime2"),
                        .NomeCliente = c.String(maxLength:=100),
                        .ImportoTotaleFattura = c.Decimal(nullable:=True, precision:=6, scale:=2)
                    }) _
                .PrimaryKey(Function(t) t.IdFattura)
        End Sub

        Public Overrides Sub Down()
            DropTable("dbo.Fatture")
        End Sub
    End Class
End Namespace
