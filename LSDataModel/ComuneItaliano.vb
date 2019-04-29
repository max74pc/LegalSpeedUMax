Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace LSDataModelNS

    <Table("ComuniItaliani")>
    Public Class ComuneItaliano

        ''' <summary>
        ''' Codice identificativo del comune italiano.
        ''' </summary>
        ''' <returns>Ritorna il valore intero del codice identificativo del comune italiano.</returns>
        <Key>
        <Required>
        Public Property IdComune() As Integer

        ''' <summary>
        ''' Denominazione del comune italiano.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico della denominazione del comune italiano.</returns>
        <MaxLength(150)>
        <Required>
        Public Property DenominazioneComune() As String

        ''' <summary>
        ''' Codice catastale del comune italiano.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico del codice catastale del comune italiano.</returns>
        <MaxLength(4)>
        <Required>
        Public Property CodiceCatastaleComune() As String

        ''' <summary>
        ''' Denominazione della sigla automobilistica della provincia italiana.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico della sigla automobilistica della provincia italiana.</returns>
        <MaxLength(2)>
        <Required>
        Public Property SiglaAutoProvincia() As String

    End Class

End Namespace


