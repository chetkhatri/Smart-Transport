Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Microsoft.VisualBasic.CompilerServices
Public Class frmdesti_entry
    Dim a As New validation

    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim d As New databind
    Private Sub frmsub_entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        d.PopulateCombo(cmbbilltype, "type_id", "type", "tbbill_type", Nothing, True, Nothing, -1)

        d.conn()
        cklabour.Checked = False
        a.GridPropery(GridView1)
        gridvalid()



        d.gridfill("select * from tbdesti", grddesti)


        starting()
        Dim _blankContextMenu As New ContextMenu()
        txtdestiname.ContextMenu = _blankContextMenu
        txtlabour.ContextMenu = _blankContextMenu
        txtfrtrate.ContextMenu = _blankContextMenu


    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()


    End Sub
    Private Sub gridvalid()
        GridView1.Columns("desti_name").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        GridView1.Columns("desti_name").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("rate").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("rate").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("type").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        GridView1.Columns("type").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("labour").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("labour").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("bill_type").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        GridView1.Columns("bill_type").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

    End Sub
    Public Sub starting()
        GroupControl2.Enabled = False
        btnsave.Enabled = False
        btnedit.Enabled = True
        btnadd.Enabled = True

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        btnsave.Tag = "ADD"
        txtfrtrate.Text = ""
        txtdestiname.Text = ""
        txtlabour.Text = ""
        cmbtype.Text = ""
        cmbbilltype.Text = ""

        GroupControl2.Enabled = True

        txtdestiname.Focus()
        btnsave.Enabled = True
        btnedit.Enabled = False
        Me.btnadd.Enabled = False
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Me.btnsave.Tag = "EDIT"
        GroupControl2.Enabled = True
        txtdestiname.Focus()
        btnsave.Enabled = True
        Me.btnedit.Enabled = False
        btnadd.Enabled = False
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

        If (Me.GridView1.FocusedRowHandle >= 0) Then
            Try
                Me.txtdestiname.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "desti_name")
                Me.txtfrtrate.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "rate")
                Me.cmbtype.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "type")
                Me.txtlabour.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "labour")
                Me.cmbbilltype.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "bill_type")
            Catch ex As Exception

            End Try







            GroupControl2.Enabled = False

            btnsave.Enabled = False
            btnedit.Enabled = True
            btnadd.Enabled = True



        End If


    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If a.txtstring(txtdestiname, lblname) = True Then
                XtraMessageBox.Show("Please Enter Destination Name", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf a.txtstring(txtfrtrate, lblfrtrate) = True Then
                XtraMessageBox.Show("Please Enter FRT Rate", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf a.txtstring(cmbtype, lbltype) = True Then
                XtraMessageBox.Show("Please Select Type", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
                
                

            Else

                If Me.btnsave.Tag = "ADD" Then
                    cmd = New OleDbCommand("select count(*) from  tbdesti where [desti_name] like '%" & Me.txtdestiname.Text & "%' and [bill_type]='" & cmbbilltype.Text & "' ", d.con)
                    Dim no As Integer = Conversions.ToInteger(cmd.ExecuteScalar())
                    If no > 0 Then
                        XtraMessageBox.Show("Destination Already Exists", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtdestiname.Focus()
                        txtdestiname.SelectAll()

                    ElseIf (no = 0) Then
                        If Not (txtlabour.Text = "") Then
                            cmd = New OleDbCommand("insert into tbdesti(desti_name,rate,type,bill_type,labour) values('" & txtdestiname.Text & "'," & txtfrtrate.Text & ",'" & cmbtype.Text & "','" & cmbbilltype.Text & "'," & txtlabour.Text & ")", d.con)
                            cmd.ExecuteNonQuery()
                            XtraMessageBox.Show("Destination Added Successfully", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            cmd = New OleDbCommand("insert into tbdesti(desti_name,rate,type,bill_type) values('" & txtdestiname.Text & "'," & txtfrtrate.Text & ",'" & cmbtype.Text & "','" & cmbbilltype.Text & "')", d.con)
                            cmd.ExecuteNonQuery()
                            XtraMessageBox.Show("Destination Added Successfully", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        End If
                        
                    End If

                ElseIf Me.btnsave.Tag = "EDIT" Then

                    If Not (txtlabour.Text = "") Then
                        cmd = New OleDbCommand("update tbdesti set[desti_name]='" & txtdestiname.Text & "',[rate]=" & txtfrtrate.Text & ",[labour]=" & txtlabour.Text & ",[type]='" & cmbtype.SelectedItem & "',[bill_type]='" & cmbbilltype.Text & "' where [desti_id]=" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "desti_id"), d.con)
                        cmd.ExecuteNonQuery()
                        XtraMessageBox.Show("Destination Updated Successfully", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        cmd = New OleDbCommand("update tbdesti set[desti_name]='" & txtdestiname.Text & "',[rate]=" & txtfrtrate.Text & ",[labour]=" & 0 & ",[type]='" & cmbtype.SelectedItem & "',[bill_type]='" & cmbbilltype.Text & "' where [desti_id]=" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "desti_id"), d.con)
                        cmd.ExecuteNonQuery()
                        XtraMessageBox.Show("Destination Updated Successfully", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If


                   


                End If
                d.gridfill("select * from tbdesti", grddesti)
                starting()
            End If




        Catch ex As Exception


        End Try
    End Sub

   

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cklabour.CheckedChanged
        If cklabour.Checked = True Then
            txtlabour.Enabled = True
        ElseIf cklabour.Checked = False Then
            txtlabour.Enabled = False
        End If
    End Sub

    Private Sub txtdestiname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdestiname.KeyPress

        Dim ch As Char = e.KeyChar
        If Not (Char.IsLetter(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtfrtrate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfrtrate.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtlabour_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlabour.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub
End Class