<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmviewrate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmviewrate))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.btnexp = New DevExpress.XtraEditors.SimpleButton
        Me.btnprint = New DevExpress.XtraEditors.SimpleButton
        Me.btnpprev = New DevExpress.XtraEditors.SimpleButton
        Me.grdrates = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.desti_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bill_type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.labour = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grdrates, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnexp)
        Me.GroupControl1.Controls.Add(Me.btnprint)
        Me.GroupControl1.Controls.Add(Me.btnpprev)
        Me.GroupControl1.Controls.Add(Me.grdrates)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 1)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(360, 386)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Destinations Rate Information"
        '
        'btnexp
        '
        Me.btnexp.Image = Global.SmartTransport.My.Resources.Resources.excel__1_
        Me.btnexp.Location = New System.Drawing.Point(249, 22)
        Me.btnexp.Name = "btnexp"
        Me.btnexp.Size = New System.Drawing.Size(32, 32)
        Me.btnexp.TabIndex = 29
        '
        'btnprint
        '
        Me.btnprint.Image = Global.SmartTransport.My.Resources.Resources.Printer_icon
        Me.btnprint.Location = New System.Drawing.Point(161, 22)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(32, 32)
        Me.btnprint.TabIndex = 28
        '
        'btnpprev
        '
        Me.btnpprev.Image = Global.SmartTransport.My.Resources.Resources.document_print_preview
        Me.btnpprev.Location = New System.Drawing.Point(72, 22)
        Me.btnpprev.Name = "btnpprev"
        Me.btnpprev.Size = New System.Drawing.Size(32, 32)
        Me.btnpprev.TabIndex = 27
        '
        'grdrates
        '
        Me.grdrates.Location = New System.Drawing.Point(2, 55)
        Me.grdrates.MainView = Me.GridView1
        Me.grdrates.Name = "grdrates"
        Me.grdrates.Size = New System.Drawing.Size(358, 331)
        Me.grdrates.TabIndex = 0
        Me.grdrates.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.desti_name, Me.rate, Me.type, Me.bill_type, Me.labour})
        Me.GridView1.GridControl = Me.grdrates
        Me.GridView1.Name = "GridView1"
        '
        'desti_name
        '
        Me.desti_name.Caption = "Name"
        Me.desti_name.FieldName = "desti_name"
        Me.desti_name.Name = "desti_name"
        Me.desti_name.Visible = True
        Me.desti_name.VisibleIndex = 0
        '
        'rate
        '
        Me.rate.Caption = "FRT Rate"
        Me.rate.FieldName = "rate"
        Me.rate.Name = "rate"
        Me.rate.Visible = True
        Me.rate.VisibleIndex = 1
        '
        'type
        '
        Me.type.Caption = "Type"
        Me.type.FieldName = "type"
        Me.type.Name = "type"
        Me.type.Visible = True
        Me.type.VisibleIndex = 2
        '
        'bill_type
        '
        Me.bill_type.Caption = "Bill Type"
        Me.bill_type.FieldName = "bill_type"
        Me.bill_type.Name = "bill_type"
        Me.bill_type.Visible = True
        Me.bill_type.VisibleIndex = 3
        '
        'labour
        '
        Me.labour.Caption = "Labour"
        Me.labour.FieldName = "labour"
        Me.labour.Name = "labour"
        Me.labour.Visible = True
        Me.labour.VisibleIndex = 4
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Excel files (*.xls)|*.xls"
        '
        'frmviewrate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 387)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmviewrate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View All Destinations Rate"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grdrates, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdrates As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnprint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnpprev As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents desti_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents labour As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnexp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents bill_type As DevExpress.XtraGrid.Columns.GridColumn
End Class
