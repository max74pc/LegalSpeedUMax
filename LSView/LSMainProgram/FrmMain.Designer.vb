<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim RibbonTab1 As Infragistics.Win.UltraWinToolbars.RibbonTab = New Infragistics.Win.UltraWinToolbars.RibbonTab("ribMain")
        Dim RibbonGroup7 As Infragistics.Win.UltraWinToolbars.RibbonGroup = New Infragistics.Win.UltraWinToolbars.RibbonGroup("ribGrpAna")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("BtnAnaAvv")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Dim RibbonGroup8 As Infragistics.Win.UltraWinToolbars.RibbonGroup = New Infragistics.Win.UltraWinToolbars.RibbonGroup("ribGrpComAtti")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("BtnComAtti")
        Dim RibbonGroup9 As Infragistics.Win.UltraWinToolbars.RibbonGroup = New Infragistics.Win.UltraWinToolbars.RibbonGroup("ribGrpADS")
        Dim RibbonGroup10 As Infragistics.Win.UltraWinToolbars.RibbonGroup = New Infragistics.Win.UltraWinToolbars.RibbonGroup("ribGrpFat")
        Dim RibbonGroup11 As Infragistics.Win.UltraWinToolbars.RibbonGroup = New Infragistics.Win.UltraWinToolbars.RibbonGroup("ribGrpLin")
        Dim RibbonGroup12 As Infragistics.Win.UltraWinToolbars.RibbonGroup = New Infragistics.Win.UltraWinToolbars.RibbonGroup("ribGrpUti")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool(" ")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("BtnAnaAvv")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("BtnComAtti")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Me.UltraTlbrsManagerMain = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._FrmMain_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._FrmMain_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._FrmMain_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._FrmMain_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraStatusBarMain = New Infragistics.Win.UltraWinStatusBar.UltraStatusBar()
        Me.UltraTabbedMdiManager = New Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager(Me.components)
        CType(Me.UltraTlbrsManagerMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraStatusBarMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabbedMdiManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTlbrsManagerMain
        '
        Me.UltraTlbrsManagerMain.DesignerFlags = 1
        Me.UltraTlbrsManagerMain.DockWithinContainer = Me
        Me.UltraTlbrsManagerMain.DockWithinContainerBaseType = GetType(System.Windows.Forms.Form)
        RibbonTab1.Caption = "Principale"
        RibbonGroup7.Caption = "Anagrafiche"
        RibbonGroup7.PreferredToolSize = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        ButtonTool3.InstanceProps.AppearancesSmall.Appearance = Appearance1
        ButtonTool3.InstanceProps.Caption = "Avvocati"
        RibbonGroup7.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool3})
        RibbonGroup8.Caption = "Compositore Atti"
        ButtonTool1.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large
        RibbonGroup8.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1})
        RibbonGroup9.Caption = "ADS"
        RibbonGroup10.Caption = "Fatture"
        RibbonGroup11.Caption = "Link App"
        RibbonGroup12.Caption = "Utility"
        RibbonTab1.Groups.AddRange(New Infragistics.Win.UltraWinToolbars.RibbonGroup() {RibbonGroup7, RibbonGroup8, RibbonGroup9, RibbonGroup10, RibbonGroup11, RibbonGroup12})
        Me.UltraTlbrsManagerMain.Ribbon.NonInheritedRibbonTabs.AddRange(New Infragistics.Win.UltraWinToolbars.RibbonTab() {RibbonTab1})
        Me.UltraTlbrsManagerMain.Ribbon.Visible = True
        Me.UltraTlbrsManagerMain.ShowFullMenusDelay = 500
        ButtonTool2.SharedPropsInternal.Caption = " "
        ButtonTool4.SharedPropsInternal.Caption = "Avvocati"
        ButtonTool4.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        ButtonTool5.SharedPropsInternal.AppearancesLarge.Appearance = Appearance2
        ButtonTool5.SharedPropsInternal.Caption = "Atti"
        ButtonTool5.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool7.SharedPropsInternal.Caption = "Nuova Categoria"
        Me.UltraTlbrsManagerMain.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool2, ButtonTool4, ButtonTool5, ButtonTool7})
        '
        '_FrmMain_Toolbars_Dock_Area_Left
        '
        Me._FrmMain_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._FrmMain_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._FrmMain_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._FrmMain_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._FrmMain_Toolbars_Dock_Area_Left.InitialResizeAreaExtent = 9
        Me._FrmMain_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 182)
        Me._FrmMain_Toolbars_Dock_Area_Left.Name = "_FrmMain_Toolbars_Dock_Area_Left"
        Me._FrmMain_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(9, 535)
        Me._FrmMain_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraTlbrsManagerMain
        '
        '_FrmMain_Toolbars_Dock_Area_Right
        '
        Me._FrmMain_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._FrmMain_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._FrmMain_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._FrmMain_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._FrmMain_Toolbars_Dock_Area_Right.InitialResizeAreaExtent = 9
        Me._FrmMain_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(1271, 182)
        Me._FrmMain_Toolbars_Dock_Area_Right.Name = "_FrmMain_Toolbars_Dock_Area_Right"
        Me._FrmMain_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(9, 535)
        Me._FrmMain_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraTlbrsManagerMain
        '
        '_FrmMain_Toolbars_Dock_Area_Top
        '
        Me._FrmMain_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._FrmMain_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._FrmMain_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._FrmMain_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._FrmMain_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._FrmMain_Toolbars_Dock_Area_Top.Name = "_FrmMain_Toolbars_Dock_Area_Top"
        Me._FrmMain_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(1280, 182)
        Me._FrmMain_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraTlbrsManagerMain
        '
        '_FrmMain_Toolbars_Dock_Area_Bottom
        '
        Me._FrmMain_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._FrmMain_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._FrmMain_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._FrmMain_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._FrmMain_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 717)
        Me._FrmMain_Toolbars_Dock_Area_Bottom.Name = "_FrmMain_Toolbars_Dock_Area_Bottom"
        Me._FrmMain_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(1280, 0)
        Me._FrmMain_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraTlbrsManagerMain
        '
        'UltraStatusBarMain
        '
        Me.UltraStatusBarMain.Location = New System.Drawing.Point(0, 717)
        Me.UltraStatusBarMain.Name = "UltraStatusBarMain"
        Me.UltraStatusBarMain.Size = New System.Drawing.Size(1280, 23)
        Me.UltraStatusBarMain.TabIndex = 5
        '
        'UltraTabbedMdiManager
        '
        Me.UltraTabbedMdiManager.MdiParent = Me
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 740)
        Me.Controls.Add(Me._FrmMain_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._FrmMain_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._FrmMain_Toolbars_Dock_Area_Bottom)
        Me.Controls.Add(Me.UltraStatusBarMain)
        Me.Controls.Add(Me._FrmMain_Toolbars_Dock_Area_Top)
        Me.IsMdiContainer = True
        Me.Name = "FrmMain"
        Me.Text = "Finestra Principale"
        CType(Me.UltraTlbrsManagerMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraStatusBarMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabbedMdiManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UltraTlbrsManagerMain As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents _FrmMain_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _FrmMain_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _FrmMain_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _FrmMain_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraStatusBarMain As Infragistics.Win.UltraWinStatusBar.UltraStatusBar
    Friend WithEvents UltraTabbedMdiManager As Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager
End Class
