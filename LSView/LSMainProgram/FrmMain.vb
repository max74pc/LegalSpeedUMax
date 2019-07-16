'Imports LSAnaAvvocati
'Imports LSAnaParti
'Imports LSAnaControparti
'Imports LSAnaPersone
'Imports LSAnaUtenti
'Imports LSComAtti
Imports LSCommon.LSCommonNS
Imports Infragistics.Win.Misc
Imports LSCtrlAnaAvv

Public Class FrmMain

    Private Sub UltraTlbrsManagerMain_ToolClick(sender As Object, e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraTlbrsManagerMain.ToolClick
        'Dim frmDllAnaAvv As New FrmAnaAvvocati
        'Dim frmDllComAtti As New FrmComAtti
        'Dim frmDllAnaParti As New FrmAnaParti
        'Dim frmDllAnaControparti As New FrmAnaControparti
        'Dim frmDllAnaPersone As New FrmAnaPersone
        'Dim frmDllAnaUtenti As New FrmAnaUtenti

        Try
            '    'Apre l'Anagrafica Avvocati
            '    If e.Tool.Key = "BtnToolAnaAvv" Then
            '        'frmDllAnaAvv._VisualizzaDaAltraFinestra = False
            '        'frmDllAnaAvv.MdiParent = Me
            '        'frmDllAnaAvv.Show()
            '        Dim frmContenitCtrl As New Form With {
            '            .Text = "Anagrafica Avvocati"
            '        }
            '        Dim panelConCtrl As New UltraPanel With {
            '            .Dock = DockStyle.Fill
            '        }
            '        frmContenitCtrl.Controls.Add(panelConCtrl)
            '        Dim myControl = New UsrCtrlAnaAvv With {
            '            .Dock = DockStyle.Fill
            '        }
            '        panelConCtrl.ClientArea.Controls.Add(myControl)
            '        frmContenitCtrl.MdiParent = Me
            '        frmContenitCtrl.Show()
            '    End If

            '    'Apre l'Anagrafica Parti
            '    If e.Tool.Key = "BtnToolAnaParti" Then
            '        frmDllAnaParti.VisualizzaDaAltraFinestra = False
            '        frmDllAnaParti.MdiParent = Me
            '        frmDllAnaParti.Show()
            '    End If

            '    'Apre l'Anagrafica Controparti
            '    If e.Tool.Key = "BtnToolAnaControparti" Then
            '        frmDllAnaControparti.VisualizzaDaAltraFinestra = False
            '        frmDllAnaControparti.MdiParent = Me
            '        frmDllAnaControparti.Show()
            '    End If

            '    'Apre l'Anagrafica Persone
            '    If e.Tool.Key = "BtnToolAnaPersone" Then
            '        'frmDllAnaPersone._VisualizzaDaAltraFinestra = False
            '        frmDllAnaPersone.MdiParent = Me
            '        frmDllAnaPersone.Show()
            '    End If

            '    'Apre l'Anagrafica Utenti
            '    If e.Tool.Key = "BtnToolAnaUtenti" Then
            '        frmDllAnaUtenti.MdiParent = Me
            '        frmDllAnaUtenti.Show()
            '    End If

            '    'Apre il Compositore Atti
            '    If e.Tool.Key = "BtnToolComAtti" Then
            '        frmDllComAtti.MdiParent = Me
            '        frmDllComAtti.Show()
            '    End If

            '    'Apre L'SLPCT
            '    If e.Tool.Key = "BtnToolSLPCT" Then
            '        Dim proc As Process = Process.Start("C:\Program Files (x86)\Evoluzioni Software\SLpct\SLpct.exe")
            '    End If

            '    'Esce dall'applicazione
            '    If e.Tool.Key = "BtnToolEsci" Then
            '        Me.Close()
            '    End If

        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmMain: UltraTlbrsManagerMain_ToolClick. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.WindowState = FormWindowState.Maximized
        Catch ex As Exception
            ClsComune.GestisciEccezzioni(ex, "FrmMain_Load. ", True, ClsComune.GlbStrUserNameLS, "", True)
        End Try
    End Sub
End Class
