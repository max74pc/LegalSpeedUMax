Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace LSDataModelNS

    <Table("TipiEntiGiuridici")>
    Public Class TipoEnteGiuridico

        ''' <summary>
        ''' Codice identificativo del tipo di ente giuridico.
        ''' </summary>
        ''' <returns>Ritorna il valore numerico del codice identificativo del tipo di ente giuridico.</returns>
        <Key>
        <Required>
        Public Property IdTipoEnteGiuridico() As Integer

        ''' <summary>
        ''' Descrizione del tipo di ente giuridico.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico della descrizione del tipo di ente giuridico.</returns>
        <MaxLength(150)>
        <Required>
        Public Property DescrizioneTipoEnteGiuridico() As String

    End Class

End Namespace
