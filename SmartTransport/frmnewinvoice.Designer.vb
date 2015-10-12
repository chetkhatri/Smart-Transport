<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmnewinvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmnewinvoice))
        Me.grpbasicinfo = New DevExpress.XtraEditors.GroupControl
        Me.lblinvdte = New System.Windows.Forms.Label
        Me.lblinvoiceno = New System.Windows.Forms.Label
        Me.lblbilltype = New System.Windows.Forms.Label
        Me.cmbbilltype = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.dtpinvdte = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtinvoiceno = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.lblbilldte = New System.Windows.Forms.Label
        Me.lblbillno = New System.Windows.Forms.Label
        Me.dtpdate = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtbillno = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.grptransdtl = New DevExpress.XtraEditors.GroupControl
        Me.lbldestitype = New System.Windows.Forms.Label
        Me.cmbdestitype = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtamt = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.lblremarks = New System.Windows.Forms.Label
        Me.lbldismt = New System.Windows.Forms.Label
        Me.lbltruckno = New System.Windows.Forms.Label
        Me.lbldesti = New System.Windows.Forms.Label
        Me.lblconsignee = New System.Windows.Forms.Label
        Me.lbllrno = New System.Windows.Forms.Label
        Me.txtremarks = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.txtnetamt = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.txtlbour = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.txtfrt = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.txtdispmt = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.txttruckno = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.cmbdesti = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.txtconsname = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtlrno = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnadd = New DevExpress.XtraEditors.SimpleButton
        Me.btnreset = New DevExpress.XtraEditors.SimpleButton
        Me.btnedit = New DevExpress.XtraEditors.SimpleButton
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.grdtrans = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.billno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dte = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lrno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.consign = New DevExpress.XtraGrid.Columns.GridColumn
        Me.desti = New DevExpress.XtraGrid.Columns.GridColumn
        Me.truckno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.mmt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.frt_rte = New DevExpress.XtraGrid.Columns.GridColumn
        Me.amtt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.labourr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.net_amt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.invoiceid = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bill_type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.desti_type = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.grpbasicinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbasicinfo.SuspendLayout()
        CType(Me.cmbbilltype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpinvdte.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpinvdte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtinvoiceno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpdate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpdate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbillno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grptransdtl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grptransdtl.SuspendLayout()
        CType(Me.cmbdestitype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtamt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtremarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnetamt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtlbour.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfrt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdispmt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttruckno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbdesti.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtconsname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtlrno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.grdtrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpbasicinfo
        '
        Me.grpbasicinfo.Controls.Add(Me.lblinvdte)
        Me.grpbasicinfo.Controls.Add(Me.lblinvoiceno)
        Me.grpbasicinfo.Controls.Add(Me.lblbilltype)
        Me.grpbasicinfo.Controls.Add(Me.cmbbilltype)
        Me.grpbasicinfo.Controls.Add(Me.LabelControl1)
        Me.grpbasicinfo.Controls.Add(Me.dtpinvdte)
        Me.grpbasicinfo.Controls.Add(Me.LabelControl7)
        Me.grpbasicinfo.Controls.Add(Me.txtinvoiceno)
        Me.grpbasicinfo.Controls.Add(Me.LabelControl6)
        Me.grpbasicinfo.Controls.Add(Me.lblbilldte)
        Me.grpbasicinfo.Controls.Add(Me.lblbillno)
        Me.grpbasicinfo.Controls.Add(Me.dtpdate)
        Me.grpbasicinfo.Controls.Add(Me.LabelControl3)
        Me.grpbasicinfo.Controls.Add(Me.txtbillno)
        Me.grpbasicinfo.Controls.Add(Me.LabelControl2)
        Me.grpbasicinfo.Location = New System.Drawing.Point(1, 1)
        Me.grpbasicinfo.Name = "grpbasicinfo"
        Me.grpbasicinfo.Size = New System.Drawing.Size(263, 221)
        Me.grpbasicinfo.TabIndex = 0
        Me.grpbasicinfo.Text = "Basic Information"
        '
        'lblinvdte
        '
        Me.lblinvdte.AutoSize = True
        Me.lblinvdte.Location = New System.Drawing.Point(234, 178)
        Me.lblinvdte.Name = "lblinvdte"
        Me.lblinvdte.Size = New System.Drawing.Size(0, 13)
        Me.lblinvdte.TabIndex = 35
        '
        'lblinvoiceno
        '
        Me.lblinvoiceno.AutoSize = True
        Me.lblinvoiceno.Location = New System.Drawing.Point(234, 143)
        Me.lblinvoiceno.Name = "lblinvoiceno"
        Me.lblinvoiceno.Size = New System.Drawing.Size(0, 13)
        Me.lblinvoiceno.TabIndex = 34
        '
        'lblbilltype
        '
        Me.lblbilltype.AutoSize = True
        Me.lblbilltype.Location = New System.Drawing.Point(234, 107)
        Me.lblbilltype.Name = "lblbilltype"
        Me.lblbilltype.Size = New System.Drawing.Size(0, 13)
        Me.lblbilltype.TabIndex = 33
        '
        'cmbbilltype
        '
        Me.cmbbilltype.Location = New System.Drawing.Point(72, 104)
        Me.cmbbilltype.Name = "cmbbilltype"
        Me.cmbbilltype.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbbilltype.Size = New System.Drawing.Size(158, 20)
        Me.cmbbilltype.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 107)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl1.TabIndex = 32
        Me.LabelControl1.Text = "Bill Type"
        '
        'dtpinvdte
        '
        Me.dtpinvdte.EditValue = Nothing
        Me.dtpinvdte.Location = New System.Drawing.Point(72, 175)
        Me.dtpinvdte.Name = "dtpinvdte"
        Me.dtpinvdte.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpinvdte.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtpinvdte.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpinvdte.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtpinvdte.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpinvdte.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtpinvdte.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpinvdte.Size = New System.Drawing.Size(158, 20)
        Me.dtpinvdte.TabIndex = 5
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(12, 178)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl7.TabIndex = 28
        Me.LabelControl7.Text = "Inv. Date"
        '
        'txtinvoiceno
        '
        Me.txtinvoiceno.Location = New System.Drawing.Point(72, 140)
        Me.txtinvoiceno.Name = "txtinvoiceno"
        Me.txtinvoiceno.Size = New System.Drawing.Size(158, 20)
        Me.txtinvoiceno.TabIndex = 4
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(12, 143)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl6.TabIndex = 26
        Me.LabelControl6.Text = "Invoice No"
        '
        'lblbilldte
        '
        Me.lblbilldte.AutoSize = True
        Me.lblbilldte.Location = New System.Drawing.Point(234, 71)
        Me.lblbilldte.Name = "lblbilldte"
        Me.lblbilldte.Size = New System.Drawing.Size(0, 13)
        Me.lblbilldte.TabIndex = 12
        '
        'lblbillno
        '
        Me.lblbillno.AutoSize = True
        Me.lblbillno.Location = New System.Drawing.Point(234, 36)
        Me.lblbillno.Name = "lblbillno"
        Me.lblbillno.Size = New System.Drawing.Size(0, 13)
        Me.lblbillno.TabIndex = 11
        '
        'dtpdate
        '
        Me.dtpdate.EditValue = Nothing
        Me.dtpdate.Location = New System.Drawing.Point(72, 69)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpdate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtpdate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpdate.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtpdate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpdate.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtpdate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpdate.Size = New System.Drawing.Size(158, 20)
        Me.dtpdate.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(11, 71)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Bill Date "
        '
        'txtbillno
        '
        Me.txtbillno.EditValue = "SE="
        Me.txtbillno.Location = New System.Drawing.Point(72, 34)
        Me.txtbillno.Name = "txtbillno"
        Me.txtbillno.Size = New System.Drawing.Size(158, 20)
        Me.txtbillno.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(11, 37)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Bill No. "
        '
        'grptransdtl
        '
        Me.grptransdtl.Controls.Add(Me.lbldestitype)
        Me.grptransdtl.Controls.Add(Me.cmbdestitype)
        Me.grptransdtl.Controls.Add(Me.LabelControl4)
        Me.grptransdtl.Controls.Add(Me.txtamt)
        Me.grptransdtl.Controls.Add(Me.LabelControl14)
        Me.grptransdtl.Controls.Add(Me.lblremarks)
        Me.grptransdtl.Controls.Add(Me.lbldismt)
        Me.grptransdtl.Controls.Add(Me.lbltruckno)
        Me.grptransdtl.Controls.Add(Me.lbldesti)
        Me.grptransdtl.Controls.Add(Me.lblconsignee)
        Me.grptransdtl.Controls.Add(Me.lbllrno)
        Me.grptransdtl.Controls.Add(Me.txtremarks)
        Me.grptransdtl.Controls.Add(Me.LabelControl17)
        Me.grptransdtl.Controls.Add(Me.txtnetamt)
        Me.grptransdtl.Controls.Add(Me.LabelControl16)
        Me.grptransdtl.Controls.Add(Me.txtlbour)
        Me.grptransdtl.Controls.Add(Me.LabelControl15)
        Me.grptransdtl.Controls.Add(Me.txtfrt)
        Me.grptransdtl.Controls.Add(Me.LabelControl13)
        Me.grptransdtl.Controls.Add(Me.txtdispmt)
        Me.grptransdtl.Controls.Add(Me.LabelControl12)
        Me.grptransdtl.Controls.Add(Me.txttruckno)
        Me.grptransdtl.Controls.Add(Me.LabelControl11)
        Me.grptransdtl.Controls.Add(Me.cmbdesti)
        Me.grptransdtl.Controls.Add(Me.LabelControl10)
        Me.grptransdtl.Controls.Add(Me.txtconsname)
        Me.grptransdtl.Controls.Add(Me.LabelControl9)
        Me.grptransdtl.Controls.Add(Me.txtlrno)
        Me.grptransdtl.Controls.Add(Me.LabelControl8)
        Me.grptransdtl.Location = New System.Drawing.Point(264, 1)
        Me.grptransdtl.Name = "grptransdtl"
        Me.grptransdtl.Size = New System.Drawing.Size(735, 221)
        Me.grptransdtl.TabIndex = 1
        Me.grptransdtl.Text = "Transport Details"
        '
        'lbldestitype
        '
        Me.lbldestitype.AutoSize = True
        Me.lbldestitype.Location = New System.Drawing.Point(209, 184)
        Me.lbldestitype.Name = "lbldestitype"
        Me.lbldestitype.Size = New System.Drawing.Size(0, 13)
        Me.lbldestitype.TabIndex = 37
        '
        'cmbdestitype
        '
        Me.cmbdestitype.Location = New System.Drawing.Point(104, 182)
        Me.cmbdestitype.Name = "cmbdestitype"
        Me.cmbdestitype.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbdestitype.Properties.Items.AddRange(New Object() {"Trade", "Non-Trade", "Dump", "Point"})
        Me.cmbdestitype.Size = New System.Drawing.Size(99, 20)
        Me.cmbdestitype.TabIndex = 9
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 184)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl4.TabIndex = 36
        Me.LabelControl4.Text = "Destination Type"
        '
        'txtamt
        '
        Me.txtamt.Location = New System.Drawing.Point(312, 148)
        Me.txtamt.Name = "txtamt"
        Me.txtamt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtamt.Properties.Appearance.Options.UseFont = True
        Me.txtamt.Properties.ReadOnly = True
        Me.txtamt.Size = New System.Drawing.Size(133, 20)
        Me.txtamt.TabIndex = 35
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(249, 149)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl14.TabIndex = 34
        Me.LabelControl14.Text = "Amount"
        '
        'lblremarks
        '
        Me.lblremarks.AutoSize = True
        Me.lblremarks.Location = New System.Drawing.Point(698, 114)
        Me.lblremarks.Name = "lblremarks"
        Me.lblremarks.Size = New System.Drawing.Size(0, 13)
        Me.lblremarks.TabIndex = 33
        '
        'lbldismt
        '
        Me.lbldismt.AutoSize = True
        Me.lbldismt.Location = New System.Drawing.Point(449, 74)
        Me.lbldismt.Name = "lbldismt"
        Me.lbldismt.Size = New System.Drawing.Size(0, 13)
        Me.lbldismt.TabIndex = 30
        '
        'lbltruckno
        '
        Me.lbltruckno.AutoSize = True
        Me.lbltruckno.Location = New System.Drawing.Point(449, 36)
        Me.lbltruckno.Name = "lbltruckno"
        Me.lbltruckno.Size = New System.Drawing.Size(0, 13)
        Me.lbltruckno.TabIndex = 29
        '
        'lbldesti
        '
        Me.lbldesti.AutoSize = True
        Me.lbldesti.Location = New System.Drawing.Point(210, 148)
        Me.lbldesti.Name = "lbldesti"
        Me.lbldesti.Size = New System.Drawing.Size(0, 13)
        Me.lbldesti.TabIndex = 28
        '
        'lblconsignee
        '
        Me.lblconsignee.AutoSize = True
        Me.lblconsignee.Location = New System.Drawing.Point(209, 85)
        Me.lblconsignee.Name = "lblconsignee"
        Me.lblconsignee.Size = New System.Drawing.Size(0, 13)
        Me.lblconsignee.TabIndex = 27
        '
        'lbllrno
        '
        Me.lbllrno.AutoSize = True
        Me.lbllrno.Location = New System.Drawing.Point(209, 35)
        Me.lbllrno.Name = "lbllrno"
        Me.lbllrno.Size = New System.Drawing.Size(0, 13)
        Me.lbllrno.TabIndex = 26
        '
        'txtremarks
        '
        Me.txtremarks.Location = New System.Drawing.Point(560, 110)
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Size = New System.Drawing.Size(132, 95)
        Me.txtremarks.TabIndex = 16
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(496, 112)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl17.TabIndex = 22
        Me.LabelControl17.Text = "Remarks"
        '
        'txtnetamt
        '
        Me.txtnetamt.Location = New System.Drawing.Point(559, 72)
        Me.txtnetamt.Name = "txtnetamt"
        Me.txtnetamt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtnetamt.Properties.Appearance.Options.UseFont = True
        Me.txtnetamt.Properties.ReadOnly = True
        Me.txtnetamt.Size = New System.Drawing.Size(133, 20)
        Me.txtnetamt.TabIndex = 18
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(496, 75)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl16.TabIndex = 20
        Me.LabelControl16.Text = "Net Amount"
        '
        'txtlbour
        '
        Me.txtlbour.Location = New System.Drawing.Point(559, 36)
        Me.txtlbour.Name = "txtlbour"
        Me.txtlbour.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtlbour.Properties.Appearance.Options.UseFont = True
        Me.txtlbour.Properties.ReadOnly = True
        Me.txtlbour.Size = New System.Drawing.Size(133, 20)
        Me.txtlbour.TabIndex = 17
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(496, 39)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl15.TabIndex = 18
        Me.LabelControl15.Text = "Labour"
        '
        'txtfrt
        '
        Me.txtfrt.Location = New System.Drawing.Point(312, 110)
        Me.txtfrt.Name = "txtfrt"
        Me.txtfrt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtfrt.Properties.Appearance.Options.UseFont = True
        Me.txtfrt.Properties.ReadOnly = True
        Me.txtfrt.Size = New System.Drawing.Size(133, 20)
        Me.txtfrt.TabIndex = 15
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(251, 112)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl13.TabIndex = 14
        Me.LabelControl13.Text = "FRT.Rate"
        '
        'txtdispmt
        '
        Me.txtdispmt.Location = New System.Drawing.Point(312, 72)
        Me.txtdispmt.Name = "txtdispmt"
        Me.txtdispmt.Size = New System.Drawing.Size(133, 20)
        Me.txtdispmt.TabIndex = 11
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(251, 74)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl12.TabIndex = 12
        Me.LabelControl12.Text = "Disp.M.T."
        '
        'txttruckno
        '
        Me.txttruckno.Location = New System.Drawing.Point(312, 34)
        Me.txttruckno.Name = "txttruckno"
        Me.txttruckno.Size = New System.Drawing.Size(133, 20)
        Me.txttruckno.TabIndex = 10
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(251, 37)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl11.TabIndex = 10
        Me.LabelControl11.Text = "Truck No"
        '
        'cmbdesti
        '
        Me.cmbdesti.Location = New System.Drawing.Point(73, 147)
        Me.cmbdesti.Name = "cmbdesti"
        Me.cmbdesti.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbdesti.Size = New System.Drawing.Size(130, 20)
        Me.cmbdesti.TabIndex = 8
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(12, 149)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl10.TabIndex = 8
        Me.LabelControl10.Text = "Destination"
        '
        'txtconsname
        '
        Me.txtconsname.Location = New System.Drawing.Point(73, 83)
        Me.txtconsname.Name = "txtconsname"
        Me.txtconsname.Size = New System.Drawing.Size(130, 50)
        Me.txtconsname.TabIndex = 7
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(15, 64)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl9.TabIndex = 6
        Me.LabelControl9.Text = "Consignee Name"
        '
        'txtlrno
        '
        Me.txtlrno.Location = New System.Drawing.Point(73, 33)
        Me.txtlrno.Name = "txtlrno"
        Me.txtlrno.Size = New System.Drawing.Size(130, 20)
        Me.txtlrno.TabIndex = 6
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(15, 35)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl8.TabIndex = 4
        Me.LabelControl8.Text = "L.R.No."
        '
        'btncancel
        '
        Me.btncancel.Image = Global.SmartTransport.My.Resources.Resources.Delete
        Me.btncancel.Location = New System.Drawing.Point(801, 247)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(73, 31)
        Me.btncancel.TabIndex = 19
        Me.btncancel.Text = "Cancel"
        '
        'btnadd
        '
        Me.btnadd.Image = Global.SmartTransport.My.Resources.Resources.plus_27
        Me.btnadd.Location = New System.Drawing.Point(126, 247)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(69, 31)
        Me.btnadd.TabIndex = 15
        Me.btnadd.Text = "Add"
        '
        'btnreset
        '
        Me.btnreset.Image = Global.SmartTransport.My.Resources.Resources.reset
        Me.btnreset.Location = New System.Drawing.Point(633, 247)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(73, 31)
        Me.btnreset.TabIndex = 18
        Me.btnreset.Text = "Reset"
        '
        'btnedit
        '
        Me.btnedit.Image = Global.SmartTransport.My.Resources.Resources.Edit
        Me.btnedit.Location = New System.Drawing.Point(447, 247)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(73, 31)
        Me.btnedit.TabIndex = 17
        Me.btnedit.Text = "Edit"
        '
        'btnsave
        '
        Me.btnsave.Image = Global.SmartTransport.My.Resources.Resources.Icon_Disk01_Blue
        Me.btnsave.Location = New System.Drawing.Point(283, 247)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(73, 31)
        Me.btnsave.TabIndex = 16
        Me.btnsave.Text = "Save"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.grdtrans)
        Me.GroupControl3.Location = New System.Drawing.Point(1, 301)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(998, 344)
        Me.GroupControl3.TabIndex = 20
        Me.GroupControl3.Text = "Transport Bill Information"
        '
        'grdtrans
        '
        Me.grdtrans.Location = New System.Drawing.Point(2, 20)
        Me.grdtrans.MainView = Me.GridView1
        Me.grdtrans.Name = "grdtrans"
        Me.grdtrans.Size = New System.Drawing.Size(996, 322)
        Me.grdtrans.TabIndex = 0
        Me.grdtrans.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.billno, Me.dte, Me.lrno, Me.consign, Me.desti, Me.truckno, Me.mmt, Me.frt_rte, Me.amtt, Me.labourr, Me.net_amt, Me.invoiceid, Me.bill_type, Me.desti_type})
        Me.GridView1.GridControl = Me.grdtrans
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
        Me.dte.Caption = "Bill date"
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
        'mmt
        '
        Me.mmt.Caption = "Disp.M.T"
        Me.mmt.FieldName = "mt"
        Me.mmt.Name = "mmt"
        Me.mmt.Visible = True
        Me.mmt.VisibleIndex = 6
        '
        'frt_rte
        '
        Me.frt_rte.Caption = "FRT. Rate"
        Me.frt_rte.FieldName = "frt_rte"
        Me.frt_rte.Name = "frt_rte"
        Me.frt_rte.Visible = True
        Me.frt_rte.VisibleIndex = 7
        '
        'amtt
        '
        Me.amtt.Caption = "Amount"
        Me.amtt.FieldName = "amt"
        Me.amtt.Name = "amtt"
        Me.amtt.Visible = True
        Me.amtt.VisibleIndex = 8
        '
        'labourr
        '
        Me.labourr.Caption = "Labour"
        Me.labourr.FieldName = "labour"
        Me.labourr.Name = "labourr"
        Me.labourr.Visible = True
        Me.labourr.VisibleIndex = 9
        '
        'net_amt
        '
        Me.net_amt.Caption = "Net Amount"
        Me.net_amt.FieldName = "net_amt"
        Me.net_amt.Name = "net_amt"
        Me.net_amt.Visible = True
        Me.net_amt.VisibleIndex = 10
        '
        'invoiceid
        '
        Me.invoiceid.Caption = "invoice_id"
        Me.invoiceid.FieldName = "invoice_id"
        Me.invoiceid.Name = "invoiceid"
        '
        'bill_type
        '
        Me.bill_type.Caption = "bill_type"
        Me.bill_type.FieldName = "bill_type"
        Me.bill_type.Name = "bill_type"
        '
        'desti_type
        '
        Me.desti_type.Caption = "desti_type"
        Me.desti_type.FieldName = "desti_type"
        Me.desti_type.Name = "desti_type"
        '
        'frmnewinvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 645)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.grptransdtl)
        Me.Controls.Add(Me.grpbasicinfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmnewinvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Invoice Generation"
        CType(Me.grpbasicinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbasicinfo.ResumeLayout(False)
        Me.grpbasicinfo.PerformLayout()
        CType(Me.cmbbilltype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpinvdte.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpinvdte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtinvoiceno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpdate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpdate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbillno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grptransdtl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grptransdtl.ResumeLayout(False)
        Me.grptransdtl.PerformLayout()
        CType(Me.cmbdestitype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtamt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtremarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnetamt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtlbour.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfrt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdispmt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttruckno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbdesti.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtconsname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtlrno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.grdtrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpbasicinfo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dtpdate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grptransdtl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtfrt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtdispmt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txttruckno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbdesti As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtconsname As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtlrno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtremarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtnetamt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtlbour As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnadd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnreset As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnedit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdtrans As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblbilldte As System.Windows.Forms.Label
    Friend WithEvents lblbillno As System.Windows.Forms.Label
    Friend WithEvents lbldismt As System.Windows.Forms.Label
    Friend WithEvents lbltruckno As System.Windows.Forms.Label
    Friend WithEvents lbldesti As System.Windows.Forms.Label
    Friend WithEvents lblconsignee As System.Windows.Forms.Label
    Friend WithEvents lbllrno As System.Windows.Forms.Label
    Friend WithEvents lblremarks As System.Windows.Forms.Label
    Friend WithEvents txtamt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents billno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lrno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents consign As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents desti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents truckno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents frt_rte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents amtt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents labourr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents net_amt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents mmt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents invoiceid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtbillno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpinvdte As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtinvoiceno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbbilltype As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbdestitype As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblinvdte As System.Windows.Forms.Label
    Friend WithEvents lblinvoiceno As System.Windows.Forms.Label
    Friend WithEvents lblbilltype As System.Windows.Forms.Label
    Friend WithEvents lbldestitype As System.Windows.Forms.Label
    Friend WithEvents bill_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents desti_type As DevExpress.XtraGrid.Columns.GridColumn
End Class
