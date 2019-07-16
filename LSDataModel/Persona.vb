Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace LSDataModelNS

    <Table("Persone")>
    Public Class Persona

        ''' <summary>
        ''' Codice identificativo della persona.
        ''' </summary>
        ''' <returns>Ritorna il valore intero del codice identificativo della persona.</returns>
        <Key>
        <Required>
        Public Property IdPersona() As Integer

        ''' <summary>
        ''' Nome della persona.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico del nome della persona (max 30 caratteri???).</returns>
        <MaxLength(30)>
        <Required>
        Public Property Nome() As String

        ''' <summary>
        ''' Cognome della persona.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico del cognome della persona (max 30 caratteri???).</returns>
        <MaxLength(30)>
        <Required>
        Public Property Cognome() As String

        ''' <summary>
        ''' Codice Fiscale della persona.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico del Codice fiscale della persona (fisso di 16 caratteri)</returns>
        <MaxLength(16), MinLength(16)>
        Public Property CodiceFiscale() As String

        ''' <summary>
        ''' Eventuale Partita Iva della persona.
        ''' </summary>
        ''' <returns>Ritorna l'eventuale valore numerico numerico della partita iva della persona</returns>
        <MaxLength(12)>
        Public Property PartitaIVA() As String

        ''' <summary>
        ''' Data di Nascita della persona.
        ''' </summary>
        ''' <returns>Ritorna la data di nascita della persona (nel formato 'gg/mm/aaaa')</returns>
        <Column(TypeName:="datetime2")>
        Public Property DataDiNascita() As DateTime

        ''' <summary>
        ''' Luogo di nascita della persona.
        ''' </summary>
        ''' <returns>ritorna il valore alfanumerico del luogo di nascita della persona.</returns>
        <MaxLength(50)>
        Public Property LuogoDiNascita() As String

        ''' <summary>
        ''' Provincia di nascita della persona
        ''' </summary>
        ''' <returns>Ritorna il valore numerico della provincia di nascita della persona.</returns>
        <MaxLength(50)>
        Public Property ProvinciaDiNascita() As String

        ''' <summary>
        ''' Stato di nascita della persona
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico dello stato di nascita della persona.</returns>
        <MaxLength(50)>
        Public Property StatoDiNascita() As String

        ''' <summary>
        ''' Indirizzo di residenza della persona.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico dell'indirizzo di residenza della persona.</returns>
        <MaxLength(150)>
        Public Property IndirizzoResidenza() As String

        ''' <summary>
        ''' Luogo di residenza della persona.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico del luogo di residenza della persona.</returns>
        <MaxLength(50)>
        Public Property LuogoResidenza() As String

        ''' <summary>
        '''  Provincia di residenza della persona.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico della provincia di residenza della persona.</returns>
        <MaxLength(50)>
        Public Property ProvinciaResidenza() As String

        ''' <summary>
        ''' Stato di residenza della persona.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico dello stato di residenza della persona.</returns>
        <MaxLength(50)>
        Public Property StatoResidenza() As String

        ''' <summary>
        ''' Sesso della persona.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico del sesso  della persona.</returns>
        <Required>
        <MaxLength(7)>
        Public Property Sesso() As String

        ''' <summary>
        ''' Eventuale data di morte della persona.
        ''' </summary>
        ''' <returns>Ritorna l'eventuale data di nascita della persona (nel formato 'gg/mm/aaaa')</returns>
        <Column(TypeName:="datetime2")>
        Public Property DataDiMorte() As DateTime?

        ''' <summary>
        ''' Nazionalità della persona.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico della nazionalita persona.</returns>
        <MaxLength(50)>
        Public Property Nazionalita() As String

        ''' <summary>
        ''' Tipologia della persona.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico della tipologia della persona (può assumere i valori "Persona Giuridica" - "Persona Fisica").</returns>
        <MaxLength(20)>
        <Required>
        Public Property TipologiaPersona() As String

        ''' <summary>
        ''' Età della persona.
        ''' </summary>
        ''' <returns>Ritorna il valore numerico dell'età della persona.</returns>
        Public ReadOnly Property Eta() As Integer
            Get
                If (DataDiMorte.HasValue) Then
                    Return DataDiMorte.Value.Year - DataDiNascita.Year
                Else
                    Return DateTime.Today.Year - DataDiNascita.Year
                End If
            End Get
        End Property

        ''' <summary>
        ''' Nome completo della persona.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico del nome completo della persona (nome e cognome)</returns>
        <MaxLength(60)>
        Public Property NomeCompleto() As String

    End Class

End Namespace
