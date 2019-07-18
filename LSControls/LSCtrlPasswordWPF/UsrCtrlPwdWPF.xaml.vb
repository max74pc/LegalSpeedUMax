Public Class UsrCtrlPwdWPF

    Private mColoreSfondoPasswordInEntrata As Color = Color.FromRgb(255, 255, 118)
    Private mColoreSfondoPasswordInUscita As Color = Color.FromRgb(255, 255, 255)

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

    Public Property TestoEtichetta() As String
        Get
            Return lblDescrizione.Content
        End Get
        Set(ByVal value As String)
            lblDescrizione.Content = value
        End Set
    End Property

    Public Property ValorePassword() As String
        Get
            Return PwdBox.Password
        End Get
        Set(ByVal value As String)
            PwdBox.Password = value
        End Set
    End Property

    Private Sub ImgOcchio_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles ImgOcchio.MouseLeftButtonDown
        If PwdBox.Visibility = Windows.Visibility.Hidden Then
            ImgOcchio.Source = New BitmapImage(New Uri("Img/eye-32x32.png", UriKind.Relative))
            PwdBox.Password = TxtEdPwdVisibile.Text
            TxtEdPwdVisibile.Visibility = Windows.Visibility.Hidden
            PwdBox.Visibility = Windows.Visibility.Visible
            PwdBox.Focus()
        Else
            ImgOcchio.Source = New BitmapImage(New Uri("Img/no-eye-32x32.png", UriKind.Relative))
            PwdBox.Visibility = Windows.Visibility.Hidden
            TxtEdPwdVisibile.Visibility = Windows.Visibility.Visible
            TxtEdPwdVisibile.Text = PwdBox.Password
            TxtEdPwdVisibile.Focus()
        End If
    End Sub

    Private Sub PwdBox_GotFocus(sender As Object, e As RoutedEventArgs) Handles PwdBox.GotFocus
        PwdBox.Background = New SolidColorBrush(Color.FromRgb(255, 255, 118))
    End Sub

    Private Sub PwdBox_LostFocus(sender As Object, e As RoutedEventArgs) Handles PwdBox.LostFocus
        PwdBox.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
    End Sub

    Private Sub TxtEdPwdVisibile_GotFocus(sender As Object, e As RoutedEventArgs) Handles TxtEdPwdVisibile.GotFocus
        TxtEdPwdVisibile.Background = New SolidColorBrush(Color.FromRgb(255, 255, 118))
    End Sub

    Private Sub TxtEdPwdVisibile_LostFocus(sender As Object, e As RoutedEventArgs) Handles TxtEdPwdVisibile.LostFocus
        TxtEdPwdVisibile.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
    End Sub
End Class
