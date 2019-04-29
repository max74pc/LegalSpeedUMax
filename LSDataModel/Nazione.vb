Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Namespace LSDataModelNS

    <Table("Nazioni")>
    Public Class Nazione

        ''' <summary>
        ''' Codice identificativo della nazione.
        ''' </summary>
        ''' <returns>Ritorna il valore intero del codice identificativo della nazione.</returns>
        <Key>
        <Required>
        Public Property IdNazione() As Integer

        ''' <summary>
        ''' Codice della nazione.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico del codice della nazione.</returns>
        <MaxLength(4)>
        <Required>
        Public Property CodiceNazione() As String

        ''' <summary>
        ''' Denominazione della nazione.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico della denominazione della nazione.</returns>
        <MaxLength(150)>
        <Required>
        Public Property DenominazioneNazione() As String

        ''' <summary>
        ''' Sigla breve della nazione.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico della sigla breve della nazione.</returns>
        <MaxLength(2)>
        <Required>
        Public Property SiglaBreveNazione() As String

        ''' <summary>
        ''' Sigla estesa della nazione.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico della sigla estesa della nazione.</returns>
        <MaxLength(3)>
        <Required>
        Public Property SiglaEstesaNazione() As String

        ''' <summary>
        ''' Sigla dello stato sovrano.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico della sigla dello stato sovrano.</returns>
        Public Property SiglaStatoSovrano() As String

        ''' <summary>
        ''' Continente in cui si trova la nazione.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico del continente in cui si trova la nazione.</returns>
        Public Property Continente() As String

        ''' <summary>
        ''' Nazioni Soppresse.
        ''' </summary>
        ''' <returns>Ritorna il valore booleano che indica se la nazione è stata soppressa.</returns>
        Public Property Soppressa() As String

        ''' <summary>
        ''' Prefisso telefonico internazionale della nazione.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico del prefisso telefonico internazionale della nazione.</returns>
        <MaxLength(5)>
        Public Property PrefissoTelInternazionale() As String

    End Class

End Namespace

