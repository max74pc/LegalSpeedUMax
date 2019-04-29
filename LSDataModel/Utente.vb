Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace LSDataModelNS

    <Table("Utenti")>
    Public Class Utente

        ''' <summary>
        ''' Codice identificativo dell'utente.
        ''' </summary>
        ''' <returns>Ritorna il valore numerico del codice identificativo del tipo di ente giuridico.</returns>
        <Key>
        <Required>
        Public Property IdUtente() As Integer

        ''' <summary>
        ''' Nome utente.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico del nome utente.</returns>
        <MaxLength(50)>
        <Required>
        Public Property NomeUtente() As String

        ''' <summary>
        ''' Password criptata.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico della password criptata.</returns>
        <MaxLength(50)>
        <Required>
        Public Property PasswordCriptata() As String

        ''' <summary>
        ''' Permesso relativo alle anagrafiche.
        ''' </summary>
        ''' <returns>Ritorna il valore booleano del permesso relativo alle anagrafiche.</returns>
        <Required>
        Public Property PermessoAnagrafiche() As Boolean

        ''' <summary>
        ''' Permesso relativo alla gestione utenti.
        ''' </summary>
        ''' <returns>Ritorna il valore booleano del permesso relativo alla gestione utenti.</returns>
        <Required>
        Public Property PermessoGestioneUtenti() As Boolean

        ''' <summary>
        ''' Permesso relativo alla fatturazione.
        ''' </summary>
        ''' <returns>Ritorna il valore booleano del permesso relativo alla fatturazione.</returns>
        <Required>
        Public Property PermessoFatturazione() As Boolean

        ''' <summary>
        ''' Permesso relativo alla generazioni atti.
        ''' </summary>
        ''' <returns>Ritorna il valore booleano del permesso relativo alla generazioni atti.</returns>
        <Required>
        Public Property PermessoGenerazioneAtti() As Boolean

        ''' <summary>
        ''' Permesso relativo alle applicazioni esterne.
        ''' </summary>
        ''' <returns>Ritorna il valore booleano del permesso relativo alle applicazioni esterne.</returns>
        <Required>
        Public Property PermessoAppEsterne() As Boolean

        ''' <summary>
        ''' Permesso relativo all'agenda degli appuntamenti.
        ''' </summary>
        ''' <returns>Ritorna il valore booleano del permesso relativo all'agenda degli appuntamenti.</returns>
        <Required>
        Public Property PermessoAgenda() As Boolean

        ''' <summary>
        ''' Permesso relativo all'utility.
        ''' </summary>
        ''' <returns>Ritorna il valore booleano del permesso relativo all'utility.</returns>
        <Required>
        Public Property PermessoUtility() As Boolean

    End Class

End Namespace

