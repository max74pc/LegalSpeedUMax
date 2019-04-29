Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace LSDataModelNS

    <Table("Controparti")>
    Public Class Controparte : Inherits Persona

        ''' <summary>
        ''' EMail della controparte.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico dell'email della controparte.</returns>
        <MaxLength(150)>
        Public Property EMail() As String

        ''' <summary>
        ''' PEC della controparte.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico della PEC della controparte.</returns>
        <MaxLength(150)>
        Public Property EmailPEC() As String

        ''' <summary>
        ''' Indirizzo della sede legale della controparte.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico dell'indirizzo della sede legale della controparte.</returns>
        <MaxLength(200)>
        Public Property IndirizzoSedeLegale() As String

        ''' <summary>
        ''' Indirizzo della sede operativa della controparte.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico dell'indirizzo della sede operativa della controparte.</returns>
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
