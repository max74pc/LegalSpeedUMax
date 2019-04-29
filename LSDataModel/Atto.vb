Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace LSDataModelNS

    <Table("Atti")>
    Public Class Atto

        ''' <summary>
        ''' Codice identificativo dell'atto.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico del codice identificativo dell'atto.</returns>
        <Key>
        <Required>
        Public Property IdAtto() As Integer

        ''' <summary>
        ''' Descrizione dell'atto.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico della descrizione dell'atto.</returns>
        <MaxLength(200)>
        <Required>
        Public Property DescrizioneAtto() As String

        ''' <summary>
        ''' Tipo dell'atto.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico del tipo dell'atto.</returns>
        <MaxLength(30)>
        <Required>
        Public Property TipoAtto() As String

        ''' <summary>
        ''' Numero di ruolo dell'atto.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico del numero di ruolo dell'atto.</returns>
        <MaxLength(10)>
        <Required>
        Public Property NumeroRuolo() As String

        ''' <summary>
        ''' Data e ora di creazione dell'atto.
        ''' </summary>
        ''' <returns>Ritorna il valore della data e dell'ora di creazione dell'atto.</returns>
        <Required>
        Public Property DataOraCreazioneAtto() As DateTime

    End Class

End Namespace
