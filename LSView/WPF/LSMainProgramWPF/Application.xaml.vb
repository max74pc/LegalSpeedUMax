Imports System.Threading

Class Application
    Private Sub Application_Startup(sender As Object, e As StartupEventArgs)
        Dim splash As New SplashScreen
        Dim loginWindow As New LoginWindow
        splash.Show()
        Thread.Sleep(3000)
        splash.Close()
    End Sub

    ' Gli eventi a livello di applicazione, ad esempio Startup, Exit e DispatcherUnhandledException,
    ' possono essere gestiti in questo file.

End Class
