Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace LSDataModelNS

    <Table("EntiGiuridici")>
    Public Class EnteGiuridico

        ''' <summary>
        ''' Codice identificativo dell'ente giuridico.
        ''' </summary>
        ''' <returns>Ritorna il valore intero del codice identificativo dell'ente giuridico.</returns>
        <Key>
        <Required>
        Public Property IdEnteGiuridico() As Integer

        ''' <summary>
        ''' Denominazione dell'ente giuridico.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico della denominazione dell'ente giuridico.</returns>
        <MaxLength(150)>
        <Required>
        Public Property DenominazioneEnte() As String

        ''' <summary>
        ''' EMail del tribunale.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico dell'email dell'ente giuridico.</returns>
        <MaxLength(150)>
        Public Property EMailEnte() As String

        ''' <summary>
        '''  Responsabile del tribunale.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico del responsabile dell'ente giuridico.</returns>
        <MaxLength(150)>
        Public Property ResponsabileEnte() As String

        ''' <summary>
        ''' Indirizzo del tribunale.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico dell'indirizzo dell'ente giuridico.</returns>
        <MaxLength(100)>
        Public Property IndirizzoEnte() As String

        ''' <summary>
        ''' Tipo dell'ente giuridico.
        ''' </summary>
        ''' <returns>Ritorna il valore numerico del tipo dell'ente giuridico.</returns>
        Public Property IdTipoEnteGiuridico() As Integer

    End Class

End Namespace
