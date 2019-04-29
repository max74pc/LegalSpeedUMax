Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace LSDataModelNS

    <Table("Province")>
    Public Class Provincia

        ''' <summary>
        ''' Codice identificativo della provincia italiana.
        ''' </summary>
        ''' <returns>Ritorna il valore numerico del codice identificativo della provincia italiana.</returns>
        <Key>
        <Required>
        Public Property IdProvincia() As Integer

        ''' <summary>
        ''' Codice della sigla automobilistica della provincia italiana.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico del codice della sigla automobilistica della provincia italiana.</returns>
        <MaxLength(2)>
        <Required>
        Public Property SiglaAutoProvincia() As String

        ''' <summary>
        ''' Denominazione della provincia italiana.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico della denominazione della provincia italiana.</returns>
        <MaxLength(150)>
        <Required>
        Public Property DenominazioneProvincia() As String

        ''' <summary>
        ''' Denominazione della regione italiana.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico della denominazione della regione italiana.</returns>
        <MaxLength(150)>
        <Required>
        Public Property DenominazioneRegione() As String

    End Class

End Namespace
