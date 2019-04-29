Imports LSAnaAvvocati
Imports LSComAtti

Public Class FrmMain
    Private Sub UltraTlbrsManagerMain_ToolClick(sender As Object, e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraTlbrsManagerMain.ToolClick
        Dim frmDllAnaAvv As New FrmAnaAvvocati
        Dim frmDllComAtti As New FrmComAtti

        'Apre l'Anagrafica Avvocati
        If e.Tool.Key = "BtnAnaAvv" Then
            frmDllAnaAvv._VisualizzaDaAltraFinestra = False
            frmDllAnaAvv.MdiParent = Me
            frmDllAnaAvv.Show()
            StopActivityIndicator()
            SetActivityIndicatorHidden()
        End If

        'Apre il Compositore Atti
        If e.Tool.Key = "BtnComAtti" Then
            frmDllComAtti.MdiParent = Me
            frmDllComAtti.Show()
        End If
    End Sub

    Private Sub StopActivityIndicator()



    End Sub

    Private Sub SetActivityIndicatorHidden()



    End Sub


    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class
