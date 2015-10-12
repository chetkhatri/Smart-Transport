<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmviewinvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmviewinvoice))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.dtpbilldate = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtbillno = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btnpprev = New DevExpress.XtraEditors.SimpleButton
        Me.btnsearch = New DevExpress.XtraEditors.SimpleButton
        Me.btnprint = New DevExpress.XtraEditors.SimpleButton
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnreset = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.grdinvdtl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.billno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dte = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lrno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.consign = New DevExpress.XtraGrid.Columns.GridColumn
        Me.desti = New DevExpress.XtraGrid.Columns.GridColumn
        Me.truckno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.mt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.frt_rte = New DevExpress.XtraGrid.Columns.GridColumn
        Me.amt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.labour = New DevExpress.XtraGrid.Columns.GridColumn
        Me.net_amt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnexp = New DevExpress.XtraEditors.SimpleButton
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.dtpbilldate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpbilldate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbillno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grdinvdtl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.dtpbilldate)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtbillno)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(1, 1)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1090, 141)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Enter Your Choice for Invoice Details"
        '
        'dtpbilldate
        '
        Me.dtpbilldate.EditValue = Nothing
        Me.dtpbilldate.Location = New System.Drawing.Point(500, 85)
        Me.dtpbilldate.Name = "dtpbilldate"
        Me.dtpbilldate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpbilldate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtpbilldate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpbilldate.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtpbilldate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpbilldate.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtpbilldate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpbilldate.Size = New System.Drawing.Size(136, 20)
        Me.dtpbilldate.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(409, 88)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Bill Date."
        '
        'txtbillno
        '
        Me.txtbillno.EditValue = "SE="
        Me.txtbillno.Location = New System.Drawing.Point(500, 49)
        Me.txtbillno.Name = "txtbillno"
        Me.txtbillno.Size = New System.Drawing.Size(136, 20)
        Me.txtbillno.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(409, 52)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Bill No."
        '
        'btnpprev
        '
        Me.btnpprev.Image = Global.SmartTransport.My.Resources.Resources.document_print_preview
        Me.btnpprev.Location = New System.Drawing.Point(158, 161)
        Me.btnpprev.Name = "btnpprev"
        Me.btnpprev.Size = New System.Drawing.Size(106, 31)
        Me.btnpprev.TabIndex = 6
        Me.btnpprev.Text = "Print Preview"
        '
        'btnsearch
        '
        Me.btnsearch.Image = Global.SmartTransport.My.Resources.Resources.p_search_icon
        Me.btnsearch.Location = New System.Drawing.Point(553, 161)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(73, 31)
        Me.btnsearch.TabIndex = 8
        Me.btnsearch.Text = "Search"
        '
        'btnprint
        '
        Me.btnprint.Image = Global.SmartTransport.My.Resources.Resources.Printer_icon
        Me.btnprint.Location = New System.Drawing.Point(334, 161)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(73, 31)
        Me.btnprint.TabIndex = 7
        Me.btnprint.Text = "Print"
        '
        'btncancel
        '
        Me.btncancel.Image = Global.SmartTransport.My.Resources.Resources.Delete
        Me.btncancel.Location = New System.Drawing.Point(846, 161)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(73, 31)
        Me.btncancel.TabIndex = 10
        Me.btncancel.Text = "Cancel"
        '
        'btnreset
        '
        Me.btnreset.Image = Global.SmartTransport.My.Resources.Resources.reset
        Me.btnreset.Location = New System.Drawing.Point(695, 161)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(73, 31)
        Me.btnreset.TabIndex = 9
        Me.btnreset.Text = "Reset"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grdinvdtl)
        Me.GroupControl2.Location = New System.Drawing.Point(1, 209)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1090, 292)
        Me.GroupControl2.TabIndex = 11
        Me.GroupControl2.Text = "Invoice Informations"
        '
        'grdinvdtl
        '
        Me.grdinvdtl.Location = New System.Drawing.Point(2, 20)
        Me.grdinvdtl.MainView = Me.GridView1
        Me.grdinvdtl.Name = "grdinvdtl"
        Me.grdinvdtl.Size = New System.Drawing.Size(1087, 271)
        Me.grdinvdtl.TabIndex = 0
        Me.grdinvdtl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.billno, Me.dte, Me.lrno, Me.consign, Me.desti, Me.truckno, Me.mt, Me.frt_rte, Me.amt, Me.labour, Me.net_amt})
        Me.GridView1.GridControl = Me.grdinvdtl
        Me.GridView1.Name = "GridView1"
        '
        'billno
        '
        Me.billno.Caption = "Bill No."
        Me.billno.FieldName = "billno"
        Me.billno.Name = "billno"
        Me.billno.Visible = True
        Me.billno.VisibleIndex = 0
        '
        'dte
        '
        Me.dte.Caption = "Bill Date"
        Me.dte.FieldName = "dte"
        Me.dte.Name = "dte"
        Me.dte.Visible = True
        Me.dte.VisibleIndex = 1
        '
        'lrno
        '
        Me.lrno.Caption = "L.R.No."
        Me.lrno.FieldName = "lrno"
        Me.lrno.Name = "lrno"
        Me.lrno.Visible = True
        Me.lrno.VisibleIndex = 2
        '
        'consign
        '
        Me.consign.Caption = "Consignee"
        Me.consign.FieldName = "consign"
        Me.consign.Name = "consign"
        Me.consign.Visible = True
        Me.consign.VisibleIndex = 3
        '
        'desti
        '
        Me.desti.Caption = "Destination"
        Me.desti.FieldName = "desti"
        Me.desti.Name = "desti"
        Me.desti.Visible = True
        Me.desti.VisibleIndex = 4
        '
        'truckno
        '
        Me.truckno.Caption = "Truck No"
        Me.truckno.FieldName = "truckno"
        Me.truckno.Name = "truckno"
        Me.truckno.Visible = True
        Me.truckno.VisibleIndex = 5
        '
        'mt
        '
        Me.mt.Caption = "Disp.M.T"
        Me.mt.FieldName = "mt"
        Me.mt.Name = "mt"
        Me.mt.Visible = True
        Me.mt.VisibleIndex = 6
        '
        'frt_rte
        '
        Me.frt_rte.Caption = "FRT.Rate"
        Me.frt_rte.FieldName = "frt_rte"
        Me.frt_rte.Name = "frt_rte"
        Me.frt_rte.Visible = True
        Me.frt_rte.VisibleIndex = 7
        '
        'amt
        '
        Me.amt.Caption = "Amount"
        Me.amt.FieldName = "amt"
        Me.amt.Name = "amt"
        Me.amt.Visible = True
        Me.amt.VisibleIndex = 8
        '
        'labour
        '
        Me.labour.Caption = "Labour"
        Me.labour.FieldName = "labour"
        Me.labour.Name = "labour"
        Me.labour.Visible = True
        Me.labour.VisibleIndex = 9
        '
        'net_amt
        '
        Me.net_amt.Caption = "Net Amount"
        Me.net_amt.FieldName = "net_amt"
        Me.net_amt.Name = "net_amt"
        Me.net_amt.Visible = True
        Me.net_amt.VisibleIndex = 10
        '
        'btnexp
        '
        Me.btnexp.Image = Global.SmartTransport.My.Resources.Resources.excel__1_
        Me.btnexp.Location = New System.Drawing.Point(462, 161)
        Me.btnexp.Name = "btnexp"
        Me.btnexp.Size = New System.Drawing.Size(32, 32)
        Me.btnexp.TabIndex = 30
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Excel files (*.xls)|*.xls"
        '
        'frmviewinvoice
        '
        Me.AcceptButton = Me.btnsearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 502)
        Me.Controls.Add(Me.btnexp)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.btnpprev)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmviewinvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice Details"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.dtpbilldate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpbilldate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbillno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grdinvdtl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtbillno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtpbilldate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnpprev As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnprint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnreset As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdinvdtl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents billno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lrno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents consign As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents desti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents truckno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents mt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents frt_rte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents amt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents labour As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents net_amt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnexp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
