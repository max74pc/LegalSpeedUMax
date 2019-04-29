Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace LSDataModelNS

    <Table("Avvocati")>
    Public Class Avvocato : Inherits Persona

        ''' <summary>
        ''' EMail dell'avvocato.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico dell'email dell'avvocato.</returns>
        <MaxLength(150)>
        Public Property EMail() As String

        ''' <summary>
        ''' PEC dell'avvocato.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico della PEC dell'avvocato.</returns>
        <MaxLength(150)>
        Public Property EmailPEC() As String

        ''' <summary>
        ''' Foro di appartenza dell'avvocato.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico del foro di appartenza.</returns>
        <MaxLength(50)>
        Public Property ForoDiAppartenza() As String

        ''' <summary>
        ''' Data di iscrizione all'albo degli avvocati.
        ''' </summary>
        ''' <returns>Ritorna il valore della data di iscrizione all'albo degli avvocati (nel formato 'gg/mm/aaaa').</returns>
        <Column(TypeName:="datetime2")>
        Public Property DataIscrizioneAlboAvv() As DateTime

        ''' <summary>
        ''' Data di iscrizione all'albo dei cassazionisti.
        ''' </summary>
        ''' <returns>Ritorna il valore della data di iscrizione all'albo dei cassazionisti (nel formato 'gg/mm/aaaa').</returns>
        <Column(TypeName:="datetime2")>
        Public Property DataIscrizioneAlboCassazionisti() As DateTime

        ''' <summary>
        ''' Numero di telefono dello studio dell'avvocato.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico del numero di telefono dello studio dell'avvocato.</returns>
        <MaxLength(20)>
        Public Property TelefonoStudio() As String

        ''' <summary>
        ''' Numero di fax dello studio dell'avvocato.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico del numero di fax dello studio.</returns>
        <MaxLength(20)>
        Public Property FaxStudio() As String

        ''' <summary>
        ''' Numero di cellulare dell'avvocato.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico del numero di cellulare dell'avvocato.</returns>
        <MaxLength(20)>
        Public Property Cellulare() As String

        ''' <summary>
        ''' Indirizzo dello studio dell'avvocato.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico dell'indirizzo dello studio dell'avvocato.</returns>
        <MaxLength(200)>
        Public Property IndirizzoStudio() As String

    End Class

End Namespace
