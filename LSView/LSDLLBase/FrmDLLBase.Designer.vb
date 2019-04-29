<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDLLBase
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraToolbarsManager1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me.FrmDLLBase_Fill_Panel = New Infragistics.Win.Misc.UltraPanel()
        Me._FrmDLLBase_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._FrmDLLBase_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._FrmDLLBase_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._FrmDLLBase_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrmDLLBase_Fill_Panel.ClientArea.SuspendLayout()
        Me.FrmDLLBase_Fill_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(246, 176)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(353, 48)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "Form DLL Base"
        '
        'UltraToolbarsManager1
        '
        Me.UltraToolbarsManager1.DesignerFlags = 1
        Me.UltraToolbarsManager1.DockWithinContainer = Me
        Me.UltraToolbarsManager1.DockWithinContainerBaseType = GetType(System.Windows.Forms.Form)
        '
        'FrmDLLBase_Fill_Panel
        '
        '
        'FrmDLLBase_Fill_Panel.ClientArea
        '
        Me.FrmDLLBase_Fill_Panel.ClientArea.Controls.Add(Me.UltraLabel1)
        Me.FrmDLLBase_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.FrmDLLBase_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmDLLBase_Fill_Panel.Location = New System.Drawing.Point(0, 0)
        Me.FrmDLLBase_Fill_Panel.Name = "FrmDLLBase_Fill_Panel"
        Me.FrmDLLBase_Fill_Panel.Size = New System.Drawing.Size(800, 450)
        Me.FrmDLLBase_Fill_Panel.TabIndex = 0
        '
        '_FrmDLLBase_Toolbars_Dock_Area_Left
        '
        Me._FrmDLLBase_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._FrmDLLBase_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._FrmDLLBase_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._FrmDLLBase_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._FrmDLLBase_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 0)
        Me._FrmDLLBase_Toolbars_Dock_Area_Left.Name = "_FrmDLLBase_Toolbars_Dock_Area_Left"
        Me._FrmDLLBase_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 450)
        Me._FrmDLLBase_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_FrmDLLBase_Toolbars_Dock_Area_Right
        '
        Me._FrmDLLBase_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._FrmDLLBase_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._FrmDLLBase_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._FrmDLLBase_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._FrmDLLBase_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(800, 0)
        Me._FrmDLLBase_Toolbars_Dock_Area_Right.Name = "_FrmDLLBase_Toolbars_Dock_Area_Right"
        Me._FrmDLLBase_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 450)
        Me._FrmDLLBase_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_FrmDLLBase_Toolbars_Dock_Area_Top
        '
        Me._FrmDLLBase_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._FrmDLLBase_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._FrmDLLBase_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._FrmDLLBase_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._FrmDLLBase_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._FrmDLLBase_Toolbars_Dock_Area_Top.Name = "_FrmDLLBase_Toolbars_Dock_Area_Top"
        Me._FrmDLLBase_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(800, 0)
        Me._FrmDLLBase_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_FrmDLLBase_Toolbars_Dock_Area_Bottom
        '
        Me._FrmDLLBase_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._FrmDLLBase_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._FrmDLLBase_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._FrmDLLBase_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._FrmDLLBase_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 450)
        Me._FrmDLLBase_Toolbars_Dock_Area_Bottom.Name = "_FrmDLLBase_Toolbars_Dock_Area_Bottom"
        Me._FrmDLLBase_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(800, 0)
        Me._FrmDLLBase_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManager1
        '
        'FrmDLLBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FrmDLLBase_Fill_Panel)
        Me.Controls.Add(Me._FrmDLLBase_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._FrmDLLBase_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._FrmDLLBase_Toolbars_Dock_Area_Bottom)
        Me.Controls.Add(Me._FrmDLLBase_Toolbars_Dock_Area_Top)
        Me.Name = "FrmDLLBase"
        Me.Text = "Form DLL Base"
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrmDLLBase_Fill_Panel.ClientArea.ResumeLayout(False)
        Me.FrmDLLBase_Fill_Panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraToolbarsManager1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents FrmDLLBase_Fill_Panel As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents _FrmDLLBase_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _FrmDLLBase_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _FrmDLLBase_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _FrmDLLBase_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
End Class
