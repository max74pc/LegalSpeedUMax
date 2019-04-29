Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace LSDataModelNS

    <Table("Parti")>
    Public Class Parte : Inherits Persona

        ''' <summary>
        ''' EMail della parte.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico dell'email della parte.</returns>
        <MaxLength(150)>
        Public Property EMail() As String

        ''' <summary>
        ''' PEC della parte.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico della PEC della parte.</returns>
        <MaxLength(150)>
        Public Property EmailPEC() As String

        ''' <summary>
        ''' Indirizzo della sede legale della parte.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico dell'indirizzo della sede legale della parte.</returns>
        <MaxLength(200)>
        Public Property IndirizzoSedeLegale() As String

        ''' <summary>
        ''' Indirizzo della sede operativa della parte.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico dell'indirizzo della sede operativa della parte.</returns>
        <MaxLength(200)>
        Public Property IndirizzoSedeOperativa() As String

        ''' <summary>
        ''' Codice Identificativo del legale rappresentante.
        ''' </summary>
        ''' <returns>Ritorna il valore numerico dell'identificativo del legale rappresentante.</returns>
        Public Property IdLegaleRappresentante() As Integer

        ''' <summary>
        ''' Denominazione del legale rappresentante.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico della denominazione del legale rappresentante.</returns>
        <MaxLength(150)>
        Public Property DenominazioneLegaleRappresentante() As String

    End Class

End Namespace

