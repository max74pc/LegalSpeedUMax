Imports System.Drawing
Imports System.Windows.Forms
Imports Infragistics.Win.UltraWinEditors
Imports Infragistics
Imports System.ComponentModel

Public Class LSUltraCasellaTesto
    Implements INotifyPropertyChanged

    Private mColoreSfondoCasellaTestoInEntrata As Color = Color.FromArgb(255, 255, 118)
    Private mColoreSfondoCasellaTestoInUscita As Color = Color.White

    Public Event ValoreCasellaTestoCambiato As System.ComponentModel.PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Property ColoreSfondoCasellaTestoInEntrata() As Color
        Get
            Return mColoreSfondoCasellaTestoInEntrata
        End Get
        Set(ByVal value As Color)
            mColoreSfondoCasellaTestoInEntrata = value
        End Set
    End Property

    Public Property ColoreSfondoCasellaTestoInUscita() As Color
        Get
            Return mColoreSfondoCasellaTestoInUscita
        End Get
        Set(ByVal value As Color)
            mColoreSfondoCasellaTestoInUscita = value
        End Set
    End Property

    Public Property LarghezzaEtichetta() As Integer
        Get
            Return ULblDescrizione.Width
        End Get
        Set(ByVal value As Integer)
            ULblDescrizione.Width = value
            RidimensionaControlli()
        End Set
    End Property

    Public Property LarghezzaCasellaTesto() As Integer
        Get
            Return UTxtCasellaTesto.Width
        End Get
        Set(ByVal value As Integer)
            UTxtCasellaTesto.Width = value
            RidimensionaControlli()
        End Set
    End Property

    Public Property Obbligatorio() As Boolean
        Get
            Return ULblCampoObbligatorio.Visible
        End Get
        Set(ByVal value As Boolean)
            ULblCampoObbligatorio.Visible = value
        End Set
    End Property

    Public Property TestoEtichetta() As String
        Get
            Return ULblDescrizione.Text
        End Get
        Set(ByVal value As String)
            ULblDescrizione.Text = value
        End Set
    End Property

    Public Property ValoreCasellaTesto() As String
        Get
            Return UTxtCasellaTesto.Text
        End Get
        Set(ByVal value As String)
            UTxtCasellaTesto.Text = value
        End Set
    End Property

    Public Overridable Shadows Sub Enter()
        UTxtCasellaTesto.Focus()
    End Sub

    Private Sub UTxtCasellaTesto_Enter(sender As Object, e As EventArgs) Handles UTxtCasellaTesto.Enter
        UTxtCasellaTesto.Appearance.BackColor = mColoreSfondoCasellaTestoInEntrata
    End Sub

    Private Sub UTxtCasellaTesto_Leave(sender As Object, e As EventArgs) Handles UTxtCasellaTesto.Leave
        UTxtCasellaTesto.Appearance.BackColor = mColoreSfondoCasellaTestoInUscita
    End Sub

    Private Sub RidimensionaControlli()
        UTxtCasellaTesto.Left = ULblDescrizione.Width + 10
        ULblCampoObbligatorio.Left = UTxtCasellaTesto.Left + UTxtCasellaTesto.Width + 10
        Me.Width = ULblDescrizione.Width + UTxtCasellaTesto.Width + ULblCampoObbligatorio.Width + 30
    End Sub

    Private Sub UTxtCasellaTesto_ValueChanged(sender As Object, e As EventArgs) Handles UTxtCasellaTesto.ValueChanged
        RaiseEvent ValoreCasellaTestoCambiato(Me, New PropertyChangedEventArgs("ValoreCasellaTesto"))
    End Sub

End Class
