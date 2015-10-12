Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Public Class frmbilltype
    Dim a As New validation

    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim d As New databind
    Private Sub frmbilltype_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        d.conn()
        d.gridfill("select * from tbbill_type", grdtypes)
        GridView1.OptionsView.ShowAutoFilterRow = True
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        if txtbilltype.Text=""
            XtraMessageBox.Show("Please Enter Bill Type", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            
            cmd=new OleDbCommand("select count(*) from tbbill_type where [type]='"& txtbilltype.Text &"'",d.con)
            Dim no As Integer = cmd.ExecuteScalar()
            If no > 0 Then
                XtraMessageBox.Show("Bill Types Already Exists", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtbilltype.Focus()
                txtbilltype.SelectAll()

            ElseIf (no = 0) Then
                cmd = New OleDbCommand("insert into tbbill_type(type) values('" & txtbilltype.Text & "')", d.con)
                cmd.ExecuteNonQuery()
                XtraMessageBox.Show("Bill Types Added Successfully", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
                d.gridfill("select * from tbbill_type", grdtypes)


            End If


        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub
End Class