Imports System.Drawing
Imports System.Windows.Forms
Imports Infragistics.Win.UltraWinEditors
Imports Infragistics
Imports System.ComponentModel

Public Class LSMenuTendina
    Implements INotifyPropertyChanged

    Private mColoreSfondoMenuTendinaInEntrata As Color = Color.FromArgb(255, 255, 118)
    Private mColoreSfondoMenuTendinaInUscita As Color = Color.White

    Public Event ValoreMenuTendinaCambiato As System.ComponentModel.PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Sub LSMenuTendina()
        UMenuTendina.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub

    Public Property ColoreSfondoMenuTendinaInEntrata() As Color
        Get
            Return mColoreSfondoMenuTendinaInEntrata
        End Get
        Set(ByVal value As Color)
            mColoreSfondoMenuTendinaInEntrata = value
        End Set
    End Property

    Public Property ColoreSfondoMenuTendinaInUscita() As Color
        Get
            Return mColoreSfondoMenuTendinaInUscita
        End Get
        Set(ByVal value As Color)
            mColoreSfondoMenuTendinaInUscita = value
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
            Return UMenuTendina.Width
        End Get
        Set(ByVal value As Integer)
            UMenuTendina.Width = value
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

    Public Property ValoreMenuTendina() As String
        Get
            Return UMenuTendina.Text
        End Get
        Set(ByVal value As String)
            UMenuTendina.Text = value

            RaiseEvent ValoreMenuTendinaCambiato(Me, New PropertyChangedEventArgs("ValoreMenuTendina"))
        End Set
    End Property

    Public Overridable Shadows Sub Enter()
        UMenuTendina.Focus()
    End Sub

    Private Sub UMenuTendina_Enter(sender As Object, e As EventArgs) Handles UMenuTendina.Enter
        UMenuTendina.Appearance.BackColor = mColoreSfondoMenuTendinaInEntrata
    End Sub

    Private Sub UMenuTendina_Leave(sender As Object, e As EventArgs) Handles UMenuTendina.Leave
        UMenuTendina.Appearance.BackColor = mColoreSfondoMenuTendinaInUscita
    End Sub

    Public Sub AggiungiElemento(ByVal iChiave As Integer, ByVal sValore As String)
        UMenuTendina.Items.Add(iChiave, sValore)
    End Sub

    Public Sub PulisciElementi()
        UMenuTendina.Items.Clear()
    End Sub

    Private Sub RidimensionaControlli()
        UMenuTendina.Left = ULblDescrizione.Width + 10
        ULblCampoObbligatorio.Left = UMenuTendina.Left + UMenuTendina.Width + 10
        Me.Width = ULblDescrizione.Width + UMenuTendina.Width + ULblCampoObbligatorio.Width + 30
    End Sub

    Private Sub UMenuTendina_ValueChanged(sender As Object, e As EventArgs) Handles UMenuTendina.ValueChanged
        RaiseEvent ValoreMenuTendinaCambiato(Me, New PropertyChangedEventArgs("ValoreMenuTendina"))
    End Sub
End Class


