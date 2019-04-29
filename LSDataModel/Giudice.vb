Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace LSDataModelNS

    <Table("Giudici")>
    Public Class Giudice : Inherits Persona

        ''' <summary>
        ''' Area di competenza del giudice. 
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico dell'area di competenza del giudice (civile o penale).</returns>
        <MaxLength(6), MinLength(6)>
        Public Property AreaCompetenza() As String

        ''' <summary>
        ''' Qualifica del giudice.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico della qualifica del giudice (Magistrato, Presidente, Giudice onorario, Giudice di pace).</returns>
        <MaxLength(20)>
        Public Property Qualifica() As String

        ''' <summary>
        ''' Competenze del giudice.
        ''' </summary>
        ''' <returns>Ritorna il valore alfanumerico delle competenze del giudice.</returns>
        <MaxLength(150)>
        Public Property Competenze() As String

    End Class

End Namespace
