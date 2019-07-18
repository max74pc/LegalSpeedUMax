Public Class UsrCtrlCasellaTestoWPF

    Private mColoreSfondoCasellaTestoInEntrata As Color = Color.FromRgb(255, 255, 118)
    Private mColoreSfondoCasellaTestoInUscita As Color = Color.FromRgb(255, 255, 255)

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

    Public Property TestoEtichetta() As String
        Get
            Return lblDescrizione.Content
        End Get
        Set(ByVal value As String)
            lblDescrizione.Content = value
        End Set
    End Property

    Public Property ValoreCasellaTesto() As String
        Get
            Return txtEdCasellatestoWPF.Text
        End Get
        Set(ByVal value As String)
            txtEdCasellatestoWPF.Text = value
        End Set
    End Property

    Private Sub TxtEdCasellatestoWPF_GotFocus(sender As Object, e As RoutedEventArgs) Handles txtEdCasellatestoWPF.GotFocus
        txtEdCasellatestoWPF.Background = New SolidColorBrush(Color.FromRgb(255, 255, 118))
    End Sub

    Private Sub TxtEdCasellatestoWPF_LostFocus(sender As Object, e As RoutedEventArgs) Handles txtEdCasellatestoWPF.LostFocus
        txtEdCasellatestoWPF.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
    End Sub

End Class
