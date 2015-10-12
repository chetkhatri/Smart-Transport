<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbilltype
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim a As New validation
        a.GridPropery(GridView1)

    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmbilltype))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txtbilltype = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.grdtypes = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.type_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtbilltype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grdtypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtbilltype)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(1, 1)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(281, 73)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Bill Types"
        '
        'txtbilltype
        '
        Me.txtbilltype.Location = New System.Drawing.Point(69, 35)
        Me.txtbilltype.Name = "txtbilltype"
        Me.txtbilltype.Size = New System.Drawing.Size(127, 20)
        Me.txtbilltype.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 38)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Bill Type"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grdtypes)
        Me.GroupControl2.Location = New System.Drawing.Point(1, 138)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(281, 168)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Bill Types Details"
        '
        'grdtypes
        '
        Me.grdtypes.Location = New System.Drawing.Point(2, 20)
        Me.grdtypes.MainView = Me.GridView1
        Me.grdtypes.Name = "grdtypes"
        Me.grdtypes.Size = New System.Drawing.Size(279, 148)
        Me.grdtypes.TabIndex = 0
        Me.grdtypes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.type, Me.type_id})
        Me.GridView1.GridControl = Me.grdtypes
        Me.GridView1.Name = "GridView1"
        '
        'type
        '
        Me.type.Caption = "Bill Type"
        Me.type.FieldName = "type"
        Me.type.Name = "type"
        Me.type.Visible = True
        Me.type.VisibleIndex = 0
        '
        'type_id
        '
        Me.type_id.Caption = "type_id"
        Me.type_id.FieldName = "type_id"
        Me.type_id.Name = "type_id"
        '
        'btncancel
        '
        Me.btncancel.Image = Global.SmartTransport.My.Resources.Resources.Delete
        Me.btncancel.Location = New System.Drawing.Point(155, 90)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(69, 31)
        Me.btncancel.TabIndex = 12
        Me.btncancel.Text = "Cancel"
        '
        'btnsave
        '
        Me.btnsave.Image = Global.SmartTransport.My.Resources.Resources.Icon_Disk01_Blue
        Me.btnsave.Location = New System.Drawing.Point(50, 90)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(69, 31)
        Me.btnsave.TabIndex = 11
        Me.btnsave.Text = "Save"
        '
        'frmbilltype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 307)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmbilltype"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bill Types"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtbilltype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grdtypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtbilltype As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdtypes As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents type_id As DevExpress.XtraGrid.Columns.GridColumn
End Class
