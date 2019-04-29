Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace LSDataModelNS

    <Table("Amministrati")>
    Public Class Amministrato : Inherits Persona

        ''' <summary>
        ''' Data di inizio dell'ultima ADS.
        ''' </summary>
        ''' <returns>Ritorna il valore della data di inizio dell'ultima ADS (nel formato 'gg/mm/aaaa').</returns>
        <Column(TypeName:="datetime2")>
        Public Property DataInizioUltimaADS() As DateTime

    End Class

End Namespace
