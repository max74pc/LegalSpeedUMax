Imports System.Drawing
Imports System.Windows.Forms
Imports Infragistics.Win.UltraWinEditors
Imports Infragistics
Imports System.ComponentModel

Public Class LSUltraDataOraSel
    Implements INotifyPropertyChanged

    Private mColoreSfondoDataOraSelInEntrata As Color = Color.FromArgb(255, 255, 118)
    Private mColoreSfondoDataOraSelInUscita As Color = Color.White

    Public Event ValoreDataOraSelCambiato As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Property ColoreSfondoDataOraSelInEntrata() As Color
        Get
            Return mColoreSfondoDataOraSelInEntrata
        End Get
        Set(ByVal value As Color)
            mColoreSfondoDataOraSelInEntrata = value
        End Set
    End Property

    Public Property ColoreSfondoDataOraSelInUscita() As Color
        Get
            Return mColoreSfondoDataOraSelInUscita
        End Get
        Set(ByVal value As Color)
            mColoreSfondoDataOraSelInUscita = value
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

    Public Property LarghezzaDataOraSel() As Integer
        Get
            Return UDataOraSel.Width
        End Get
        Set(ByVal value As Integer)
            UDataOraSel.Width = value
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

    Public Property ValoreDataOraSel() As DateTime
        Get
            Return UDataOraSel.DateTime
        End Get
        Set(ByVal value As DateTime)
            UDataOraSel.DateTime = value
        End Set
    End Property

    Public Overridable Shadows Sub Enter()
        UDataOraSel.Focus()
    End Sub

    Private Sub UDataOraSel_Enter(sender As Object, e As EventArgs) Handles UDataOraSel.Enter
        UDataOraSel.Appearance.BackColor = mColoreSfondoDataOraSelInEntrata
    End Sub

    Private Sub UDataOraSel_Leave(sender As Object, e As EventArgs) Handles UDataOraSel.Leave
        UDataOraSel.Appearance.BackColor = mColoreSfondoDataOraSelInUscita
    End Sub

    Private Sub RidimensionaControlli()
        UDataOraSel.Left = ULblDescrizione.Width + 10
        ULblCampoObbligatorio.Left = UDataOraSel.Left + UDataOraSel.Width + 10
        Me.Width = ULblDescrizione.Width + UDataOraSel.Width + ULblCampoObbligatorio.Width + 30
    End Sub

    Public Sub SvuotaDataOra()
        UDataOraSel.Value = ""
    End Sub

    Private Sub UDataOraSel_ValueChanged(sender As Object, e As EventArgs) Handles UDataOraSel.ValueChanged
        RaiseEvent ValoreDataOraSelCambiato(Me, New PropertyChangedEventArgs("ValoreDataOraSel"))
    End Sub
End Class
