<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdesti_entry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdesti_entry))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.btnadd = New DevExpress.XtraEditors.SimpleButton
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnedit = New DevExpress.XtraEditors.SimpleButton
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.grddesti = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.desti_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bill_type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.labour = New DevExpress.XtraGrid.Columns.GridColumn
        Me.desti_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.cmbbilltype = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.lbllabour = New System.Windows.Forms.Label
        Me.lbltype = New System.Windows.Forms.Label
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.cmbtype = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cklabour = New DevExpress.XtraEditors.CheckEdit
        Me.txtlabour = New DevExpress.XtraEditors.TextEdit
        Me.lblsem = New System.Windows.Forms.Label
        Me.lblfrtrate = New System.Windows.Forms.Label
        Me.lblname = New System.Windows.Forms.Label
        Me.txtfrtrate = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtdestiname = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.grddesti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.cmbbilltype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbtype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cklabour.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtlabour.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfrtrate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdestiname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnadd)
        Me.GroupControl1.Controls.Add(Me.btncancel)
        Me.GroupControl1.Controls.Add(Me.btnedit)
        Me.GroupControl1.Controls.Add(Me.btnsave)
        Me.GroupControl1.Controls.Add(Me.GroupControl3)
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 1)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(366, 434)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Transport Destination LookUp"
        '
        'btnadd
        '
        Me.btnadd.Image = Global.SmartTransport.My.Resources.Resources.plus_27
        Me.btnadd.Location = New System.Drawing.Point(15, 162)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(69, 31)
        Me.btnadd.TabIndex = 3
        Me.btnadd.Text = "Add"
        '
        'btncancel
        '
        Me.btncancel.Image = Global.SmartTransport.My.Resources.Resources.Delete
        Me.btncancel.Location = New System.Drawing.Point(282, 162)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(69, 31)
        Me.btncancel.TabIndex = 6
        Me.btncancel.Text = "Cancel"
        '
        'btnedit
        '
        Me.btnedit.Image = Global.SmartTransport.My.Resources.Resources.Edit
        Me.btnedit.Location = New System.Drawing.Point(194, 162)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(69, 31)
        Me.btnedit.TabIndex = 5
        Me.btnedit.Text = "Edit"
        '
        'btnsave
        '
        Me.btnsave.Image = Global.SmartTransport.My.Resources.Resources.Icon_Disk01_Blue
        Me.btnsave.Location = New System.Drawing.Point(105, 162)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(69, 31)
        Me.btnsave.TabIndex = 4
        Me.btnsave.Text = "Save"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.grddesti)
        Me.GroupControl3.Location = New System.Drawing.Point(1, 208)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(365, 224)
        Me.GroupControl3.TabIndex = 3
        Me.GroupControl3.Text = "Destination Information"
        '
        'grddesti
        '
        Me.grddesti.Location = New System.Drawing.Point(2, 20)
        Me.grddesti.MainView = Me.GridView1
        Me.grddesti.Name = "grddesti"
        Me.grddesti.Size = New System.Drawing.Size(363, 204)
        Me.grddesti.TabIndex = 0
        Me.grddesti.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.desti_name, Me.rate, Me.type, Me.bill_type, Me.labour, Me.desti_id})
        Me.GridView1.GridControl = Me.grddesti
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
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
        'desti_id
        '
        Me.desti_id.Caption = "desti_id"
        Me.desti_id.FieldName = "desti_id"
        Me.desti_id.Name = "desti_id"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.cmbbilltype)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.lbllabour)
        Me.GroupControl2.Controls.Add(Me.lbltype)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.cmbtype)
        Me.GroupControl2.Controls.Add(Me.cklabour)
        Me.GroupControl2.Controls.Add(Me.txtlabour)
        Me.GroupControl2.Controls.Add(Me.lblsem)
        Me.GroupControl2.Controls.Add(Me.lblfrtrate)
        Me.GroupControl2.Controls.Add(Me.lblname)
        Me.GroupControl2.Controls.Add(Me.txtfrtrate)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.txtdestiname)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Location = New System.Drawing.Point(1, 19)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.ShowCaption = False
        Me.GroupControl2.Size = New System.Drawing.Size(365, 128)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "GroupControl2"
        '
        'cmbbilltype
        '
        Me.cmbbilltype.Location = New System.Drawing.Point(65, 89)
        Me.cmbbilltype.Name = "cmbbilltype"
        Me.cmbbilltype.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbbilltype.Size = New System.Drawing.Size(118, 20)
        Me.cmbbilltype.TabIndex = 16
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(9, 92)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl4.TabIndex = 15
        Me.LabelControl4.Text = "Bill Type"
        '
        'lbllabour
        '
        Me.lbllabour.AutoSize = True
        Me.lbllabour.Location = New System.Drawing.Point(351, 55)
        Me.lbllabour.Name = "lbllabour"
        Me.lbllabour.Size = New System.Drawing.Size(0, 13)
        Me.lbllabour.TabIndex = 14
        '
        'lbltype
        '
        Me.lbltype.AutoSize = True
        Me.lbltype.Location = New System.Drawing.Point(352, 20)
        Me.lbltype.Name = "lbltype"
        Me.lbltype.Size = New System.Drawing.Size(0, 13)
        Me.lbltype.TabIndex = 13
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(207, 18)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl3.TabIndex = 12
        Me.LabelControl3.Text = "Desti.Type"
        '
        'cmbtype
        '
        Me.cmbtype.Location = New System.Drawing.Point(266, 15)
        Me.cmbtype.Name = "cmbtype"
        Me.cmbtype.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbtype.Properties.Items.AddRange(New Object() {"Trade", "Non-Trade", "Dump", "Point"})
        Me.cmbtype.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbtype.Size = New System.Drawing.Size(78, 20)
        Me.cmbtype.TabIndex = 11
        '
        'cklabour
        '
        Me.cklabour.EditValue = True
        Me.cklabour.Location = New System.Drawing.Point(202, 51)
        Me.cklabour.Name = "cklabour"
        Me.cklabour.Properties.Caption = "Labour"
        Me.cklabour.Size = New System.Drawing.Size(58, 19)
        Me.cklabour.TabIndex = 6
        '
        'txtlabour
        '
        Me.txtlabour.Location = New System.Drawing.Point(266, 51)
        Me.txtlabour.Name = "txtlabour"
        Me.txtlabour.Size = New System.Drawing.Size(78, 20)
        Me.txtlabour.TabIndex = 3
        '
        'lblsem
        '
        Me.lblsem.AutoSize = True
        Me.lblsem.Location = New System.Drawing.Point(339, 20)
        Me.lblsem.Name = "lblsem"
        Me.lblsem.Size = New System.Drawing.Size(0, 13)
        Me.lblsem.TabIndex = 8
        '
        'lblfrtrate
        '
        Me.lblfrtrate.AutoSize = True
        Me.lblfrtrate.Location = New System.Drawing.Point(191, 56)
        Me.lblfrtrate.Name = "lblfrtrate"
        Me.lblfrtrate.Size = New System.Drawing.Size(0, 13)
        Me.lblfrtrate.TabIndex = 5
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(191, 20)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(0, 13)
        Me.lblname.TabIndex = 4
        '
        'txtfrtrate
        '
        Me.txtfrtrate.Location = New System.Drawing.Point(65, 52)
        Me.txtfrtrate.Name = "txtfrtrate"
        Me.txtfrtrate.Size = New System.Drawing.Size(118, 20)
        Me.txtfrtrate.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(9, 56)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "FRT Rate"
        '
        'txtdestiname
        '
        Me.txtdestiname.Location = New System.Drawing.Point(65, 15)
        Me.txtdestiname.Name = "txtdestiname"
        Me.txtdestiname.Size = New System.Drawing.Size(118, 20)
        Me.txtdestiname.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(9, 19)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Name"
        '
        'frmdesti_entry
        '
        Me.AcceptButton = Me.btnsave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 434)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmdesti_entry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Destination Information"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.grddesti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.cmbbilltype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbtype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cklabour.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtlabour.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfrtrate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdestiname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnadd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnedit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grddesti As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblfrtrate As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents txtfrtrate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtdestiname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblsem As System.Windows.Forms.Label
    Friend WithEvents txtlabour As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cklabour As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents desti_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents labour As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbtype As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbllabour As System.Windows.Forms.Label
    Friend WithEvents lbltype As System.Windows.Forms.Label
    Friend WithEvents desti_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbbilltype As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bill_type As DevExpress.XtraGrid.Columns.GridColumn
End Class
