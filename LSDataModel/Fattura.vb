Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace LSDataModelNS

    <Table("Fatture")>
    Public Class Fattura

        ''' <summary>
        ''' Codice identificativo della fatturA.
        ''' </summary>
        ''' <returns>Ritorna il valore intero del codice identificativo della fattura.</returns>
        <Key>
        <Required>
        Public Property IdFattura() As Integer

        ''' <summary>
        ''' Numero della fattura.
        ''' </summary>
        ''' <returns>Ritorna il valore numerico del numero della fattura.</returns>
        <Required>
        Public Property NumFattura() As Integer

        ''' <summary>
        ''' Oggetto della fattura.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico dell'oggetto della fattura.</returns>
        <MaxLength(250)>
        <Required>
        Public Property OggettoFattura() As String

        ''' <summary>
        ''' Data della fattura.
        ''' </summary>
        ''' <returns>Ritorna il valore della data della fattura (nel formato 'gg/mm/aaaa').</returns>
        <Column(TypeName:="datetime2")>
        <Required>
        Public Property DataFattura() As DateTime

        ''' <summary>
        ''' Data di inserimento della fattura.
        ''' </summary>
        ''' <returns>Ritorna il valore della data di inserimento della fattura (nel formato 'gg/mm/aaaa').</returns>
        <Column(TypeName:="datetime2")>
        Public Property DataInserimento() As DateTime

        ''' <summary>
        ''' Nome del cliente relativo alla fattura.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico del nome del cliente relativo alla fattura.</returns>
        <MaxLength(100)>
        Public Property NomeCliente() As String

        ''' <summary>
        ''' Importo totale delle fattura.
        ''' </summary>
        ''' <returns>Ritorna il valore numerico dell'importo totale della fattura.</returns>
        <RegularExpression("^\d+\.\d{0,2}$")>
        <Range(0, 999999.99)>
        Public Property ImportoTotaleFattura() As Decimal

    End Class

End Namespace
