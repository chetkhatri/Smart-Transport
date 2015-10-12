<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmchangepw
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmchangepw))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.lblretype = New System.Windows.Forms.Label
        Me.lblnew = New System.Windows.Forms.Label
        Me.lblcurrent = New System.Windows.Forms.Label
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton
        Me.txtretype = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtnew = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtcurrent = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtretype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnew.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcurrent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lblretype)
        Me.GroupControl1.Controls.Add(Me.lblnew)
        Me.GroupControl1.Controls.Add(Me.lblcurrent)
        Me.GroupControl1.Controls.Add(Me.btncancel)
        Me.GroupControl1.Controls.Add(Me.btnsave)
        Me.GroupControl1.Controls.Add(Me.txtretype)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtnew)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtcurrent)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 1)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(286, 197)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Change Password"
        '
        'lblretype
        '
        Me.lblretype.AutoSize = True
        Me.lblretype.Location = New System.Drawing.Point(260, 109)
        Me.lblretype.Name = "lblretype"
        Me.lblretype.Size = New System.Drawing.Size(0, 13)
        Me.lblretype.TabIndex = 11
        '
        'lblnew
        '
        Me.lblnew.AutoSize = True
        Me.lblnew.Location = New System.Drawing.Point(260, 75)
        Me.lblnew.Name = "lblnew"
        Me.lblnew.Size = New System.Drawing.Size(0, 13)
        Me.lblnew.TabIndex = 10
        '
        'lblcurrent
        '
        Me.lblcurrent.AutoSize = True
        Me.lblcurrent.Location = New System.Drawing.Point(260, 41)
        Me.lblcurrent.Name = "lblcurrent"
        Me.lblcurrent.Size = New System.Drawing.Size(0, 13)
        Me.lblcurrent.TabIndex = 9
        '
        'btncancel
        '
        Me.btncancel.Image = Global.SmartTransport.My.Resources.Resources.Delete
        Me.btncancel.Location = New System.Drawing.Point(162, 148)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(69, 31)
        Me.btncancel.TabIndex = 8
        Me.btncancel.Text = "Cancel"
        '
        'btnsave
        '
        Me.btnsave.Image = Global.SmartTransport.My.Resources.Resources.Icon_Disk01_Blue
        Me.btnsave.Location = New System.Drawing.Point(57, 148)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(69, 31)
        Me.btnsave.TabIndex = 7
        Me.btnsave.Text = "Save"
        '
        'txtretype
        '
        Me.txtretype.Location = New System.Drawing.Point(112, 106)
        Me.txtretype.Name = "txtretype"
        Me.txtretype.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtretype.Size = New System.Drawing.Size(142, 20)
        Me.txtretype.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 109)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Retype Password"
        '
        'txtnew
        '
        Me.txtnew.Location = New System.Drawing.Point(112, 72)
        Me.txtnew.Name = "txtnew"
        Me.txtnew.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnew.Size = New System.Drawing.Size(142, 20)
        Me.txtnew.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 75)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "New Password"
        '
        'txtcurrent
        '
        Me.txtcurrent.Location = New System.Drawing.Point(112, 38)
        Me.txtcurrent.Name = "txtcurrent"
        Me.txtcurrent.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcurrent.Size = New System.Drawing.Size(142, 20)
        Me.txtcurrent.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 41)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Current Password"
        '
        'frmchangepw
        '
        Me.AcceptButton = Me.btnsave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 199)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmchangepw"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password Utility"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtretype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnew.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcurrent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtretype As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtnew As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcurrent As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblretype As System.Windows.Forms.Label
    Friend WithEvents lblnew As System.Windows.Forms.Label
    Friend WithEvents lblcurrent As System.Windows.Forms.Label
End Class
