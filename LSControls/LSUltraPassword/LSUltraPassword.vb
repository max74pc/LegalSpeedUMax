Imports System.ComponentModel

Public Class LSUltraPassword
    Implements INotifyPropertyChanged

    Private mColoreSfondoPasswordInEntrata As Color = Color.FromArgb(255, 255, 118)
    Private mColoreSfondoPasswordInUscita As Color = Color.White

    Public Event ValorePasswordCambiato As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Property ColoreSfondoPasswordInEntrata() As Color
        Get
            Return mColoreSfondoPasswordInEntrata
        End Get
        Set(ByVal value As Color)
            mColoreSfondoPasswordInEntrata = value
        End Set
    End Property

    Public Property ColoreSfondoPasswordInUscita() As Color
        Get
            Return mColoreSfondoPasswordInUscita
        End Get
        Set(ByVal value As Color)
            mColoreSfondoPasswordInUscita = value
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

    Public Property LarghezzaPassword() As Integer
        Get
            Return UTxtPassword.Width
        End Get
        Set(ByVal value As Integer)
            UTxtPassword.Width = value
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

    Public Property ValorePassword() As String
        Get
            Return UTxtPassword.Text
        End Get
        Set(ByVal value As String)
            UTxtPassword.Text = value
        End Set
    End Property

    Public Overridable Shadows Sub Enter()
        UTxtPassword.Focus()
    End Sub

    Private Sub UTxtPassword_Enter(sender As Object, e As EventArgs) Handles UTxtPassword.Enter
        UTxtPassword.Appearance.BackColor = mColoreSfondoPasswordInEntrata
    End Sub

    Private Sub UTxtPassword_Leave(sender As Object, e As EventArgs) Handles UTxtPassword.Leave
        UTxtPassword.Appearance.BackColor = mColoreSfondoPasswordInUscita
    End Sub

    Private Sub RidimensionaControlli()
        UTxtPassword.Left = ULblDescrizione.Width + 10
        UPicBoxOcchio.Left = UTxtPassword.Left + UTxtPassword.Width + 10
        ULblCampoObbligatorio.Left = UPicBoxOcchio.Left + UPicBoxOcchio.Width + 15
        Me.Width = ULblDescrizione.Width + UTxtPassword.Width + UPicBoxOcchio.Width + ULblCampoObbligatorio.Width + 40
    End Sub

    Private Sub UTxtPassword_ValueChanged(sender As Object, e As EventArgs) Handles UTxtPassword.ValueChanged
        RaiseEvent ValorePasswordCambiato(Me, New PropertyChangedEventArgs("ValorePassword"))
    End Sub

    Private Sub UPicBoxOcchio_Click(sender As Object, e As EventArgs) Handles UPicBoxOcchio.Click
        If UTxtPassword.PasswordChar = "*" Then
            UTxtPassword.PasswordChar = ""
            UPicBoxOcchio.Image = ImgListPassword.Images(1)
        Else
            UTxtPassword.PasswordChar = "*"
            UPicBoxOcchio.Image = ImgListPassword.Images(0)
        End If
    End Sub
End Class
