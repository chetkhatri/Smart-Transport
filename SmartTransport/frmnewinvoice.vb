Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Runtime.CompilerServices

Public Class frmnewinvoice
    Dim a As New validation

    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim d As New databind
    Dim mt, frt, amt, labour, netamt, netlab As Integer

    Private Sub frmnewinvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        d.PopulateCombo(cmbbilltype, "type_id", "type", "tbbill_type", Nothing, True, Nothing, -1)
        d.PopulateCombo(cmbdesti, "desti_id", "desti_name", "tbdesti", Nothing, True, Nothing, -1)

        d.conn()
        GridView1.OptionsView.ShowAutoFilterRow = True
        d.gridfill("select * from tbinvoice_master order by invoice_id asc", grdtrans)


        GridView1.Columns("billno").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        GridView1.Columns("billno").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("dte").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("dte").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("lrno").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("lrno").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("consign").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        GridView1.Columns("consign").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("desti").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        GridView1.Columns("desti").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("truckno").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("truckno").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("mt").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("mt").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("frt_rte").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("frt_rte").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("amt").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("amt").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("labour").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("labour").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("net_amt").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("net_amt").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center


    End Sub

    
    Private Sub cmbdesti_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdesti.SelectedIndexChanged
        transaction()

    End Sub
    Private Sub transaction()
        Try


            cmd = New OleDbCommand("select rate from tbdesti where[desti_name]='" & cmbdesti.Text & "' and [bill_type]='" & cmbbilltype.Text & "' and [type]='" & cmbdestitype.Text & "'", d.con)
            txtfrt.Text = cmd.ExecuteScalar()

        Catch ex As Exception

        End Try
        Try
            cmd = New OleDbCommand("select labour from tbdesti  where[desti_name]='" & cmbdesti.Text & "' and [bill_type]='" & cmbbilltype.Text & "' and [type]='" & cmbdestitype.Text & "'", d.con)
            labour = cmd.ExecuteScalar

        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

        If (Me.GridView1.FocusedRowHandle >= 0) Then
            Try
                txtbillno.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "billno")
                dtpdate.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "dte")
                txtinvoiceno.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "invoiceno")
                dtpinvdte.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "inv_dte")
                txtlrno.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "lrno")
                txtconsname.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "consign")
                cmbdesti.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "desti")
                txttruckno.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "truckno")
                txtdispmt.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "mt")
                txtfrt.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "frt_rte")
                txtamt.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "amt")
                txtlbour.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "labour")
                txtnetamt.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "net_amt")




                If Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "bill_type"))) Then
                    cmbbilltype.Text = ""
                Else
                    cmbbilltype.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "bill_type")

                End If

                If Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "desti_type"))) Then
                    cmbdestitype.Text = ""
                Else
                    cmbdestitype.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "desti_type")

                End If

                If Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "remark"))) Then
                    txtremarks.Text = ""
                Else
                    txtremarks.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "remark")

                End If


            Catch ex As Exception

            End Try

            










            btnsave.Enabled = False
            btnedit.Enabled = True
            btnadd.Enabled = True
            btnreset.Enabled = False
            grpbasicinfo.Enabled = False
            grptransdtl.Enabled = False



        End If


    End Sub
    

    Private Sub txtdispmt_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdispmt.EditValueChanged
        amount()

    End Sub
    Private Sub amount()
        Try
            mt = Val(txtdispmt.Text)
            frt = Val(txtfrt.Text)
            amt = (mt * frt)
            netlab = (mt * labour)
            netamt = (amt + netlab)

            txtamt.Text = amt
            txtlbour.Text = netlab
            txtnetamt.Text = netamt
        Catch ex As Exception

        End Try

    End Sub

 

   

    Private Sub txtinvoiceno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim ch As Char = e.KeyChar
        If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtlrno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlrno.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txttruckno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttruckno.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8) Or Char.IsLetter(ch)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtdispmt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdispmt.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        resetall()

        btnedit.Enabled = False
        grpbasicinfo.Enabled = True
        grptransdtl.Enabled = True
        btnadd.Enabled = False
        btnsave.Enabled = True
        txtbillno.Focus()
        btnsave.Tag = "add"
        btnreset.Enabled = True
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        grpbasicinfo.Enabled = True
        grptransdtl.Enabled = True
        btnedit.Enabled = False
        btnsave.Enabled = True
        btnadd.Enabled = False
        btnreset.Enabled = True
        btnsave.Tag = "update"
    End Sub
    Private Sub resetall()
        Try
            txtbillno.Text = "SE="
            dtpdate.EditValue = Now.ToString("dd/MM/yyyy")
            cmbbilltype.Text = ""
            cmbdestitype.Text = ""
            dtpinvdte.EditValue = Now.ToString("dd/MM/yyyy")
            txtinvoiceno.Text = ""
            cmbdesti.Text = ""
            txtlrno.Text = ""
            txtconsname.Text = ""
            txttruckno.Text = ""
            txtdispmt.Text = ""
            txtfrt.Text = ""
            txtamt.Text = ""
            txtlbour.Text = ""
            txtnetamt.Text = ""
            txtremarks.Text = ""
            txtbillno.Focus()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        resetall()

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()


    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If a.txtstring(txtbillno, lblbillno) = True Then
            XtraMessageBox.Show("Please Enter Bill No.", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(dtpdate, lblbilldte) = True Then
            XtraMessageBox.Show("Please Select Bill date", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(cmbbilltype, lblbilltype) = True Then
            XtraMessageBox.Show("Please Select Bill Type", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf a.txtstring(txtinvoiceno, lblinvoiceno) = True Then
            XtraMessageBox.Show("Please Enter Invoice No.", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(dtpinvdte, lblinvdte) = True Then
            XtraMessageBox.Show("Please Select Inventory Date", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtlrno, lbllrno) = True Then
            XtraMessageBox.Show("Please Enter L.R.No.", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtconsname, lblconsignee) = True Then
            XtraMessageBox.Show("Please Enter Consignee Name", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(cmbdesti, lbldesti) = True Then
            XtraMessageBox.Show("Please Select Destination", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(cmbdestitype, lbldestitype) = True Then
            XtraMessageBox.Show("Please Select Destination Type", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txttruckno, lbltruckno) = True Then
            XtraMessageBox.Show("Please Enter Truck No.", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtdispmt, lbldismt) = True Then
            XtraMessageBox.Show("Please Enter Disp.M.T.", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Me.btnsave.Tag = "add" Then
                Try
                    If Not (txtremarks.Text = "") Then
                        Try
                            cmd = New OleDbCommand("insert into tbinvoice_master(billno,dte,bill_type,invoiceno,inv_dte,lrno,consign,desti,desti_type,truckno,mt,frt_rte,amt,labour,net_amt,remark) values ('" & txtbillno.Text & "','" & dtpdate.Text & "','" & cmbbilltype.Text & "'," & txtinvoiceno.Text & ",'" & dtpinvdte.Text & "'," & txtlrno.Text & ",'" & txtconsname.Text & "','" & cmbdesti.Text & "','" & cmbdestitype.Text & "','" & txttruckno.Text & "'," & txtdispmt.Text & "," & txtfrt.Text & "," & txtamt.Text & "," & txtlbour.Text & "," & txtnetamt.Text & ",'" & txtremarks.Text & "')", d.con)
                            cmd.ExecuteNonQuery()
                            XtraMessageBox.Show("Invoice Entry Success", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            d.gridfill("select * from tbinvoice_master order by invoice_id asc", grdtrans)
                            resetall()
                        Catch ex As Exception

                        End Try

                    Else
                        Try
                            cmd = New OleDbCommand("insert into tbinvoice_master(billto,billno,bill_type,dte,pan,stax,invoiceno,inv_dte,lrno,consign,desti,desti_type,truckno,mt,frt_rte,amt,labour,net_amt) values ('" & txtbillno.Text & "','" & dtpdate.Text & "','" & cmbbilltype.Text & "'," & txtinvoiceno.Text & ",'" & dtpinvdte.Text & "'," & txtlrno.Text & ",'" & txtconsname.Text & "','" & cmbdesti.Text & "','" & cmbdestitype.Text & "','" & txttruckno.Text & "'," & txtdispmt.Text & "," & txtfrt.Text & "," & txtamt.Text & "," & txtlbour.Text & "," & txtnetamt.Text & ")", d.con)
                            cmd.ExecuteNonQuery()
                            XtraMessageBox.Show("Invoice Entry Success", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            d.gridfill("select * from tbinvoice_master order by invoice_id asc", grdtrans)
                            resetall()
                        Catch ex As Exception

                        End Try

                    End If

                Catch ex As Exception

                End Try
            ElseIf Me.btnsave.Tag = "update" Then

                If Not (txtremarks.Text = "") Then
                    Try
                        cmd = New OleDbCommand("update tbinvoice_master set[billno]='" & txtbillno.Text & "',[dte]='" & dtpdate.Text & "',[bill_type]='" & cmbbilltype.Text & "',[invoiceno]=" & txtinvoiceno.Text & ",[desti_type]='" & cmbdestitype.Text & "',[inv_dte]='" & dtpinvdte.Text & "',[lrno]=" & txtlrno.Text & ",[consign]='" & txtconsname.Text & "',[desti]='" & cmbdesti.Text & "',[truckno]='" & txttruckno.Text & "',[mt]=" & txtdispmt.Text & ",[frt_rte]=" & txtfrt.Text & ",[amt]=" & txtamt.Text & ",[labour]=" & txtlbour.Text & ",[net_amt]=" & txtnetamt.Text & ",[remark]='" & txtremarks.Text & "' where [invoice_id]=" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "invoice_id"), d.con)
                        cmd.ExecuteNonQuery()
                        XtraMessageBox.Show("Invoice Entry Updated Successfully", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        d.gridfill("select * from tbinvoice_master order by invoice_id asc", grdtrans)

                    Catch ex As Exception

                    End Try
                Else
                    Try
                        cmd = New OleDbCommand("update tbinvoice_master set[billno]='" & txtbillno.Text & "',[dte]='" & dtpdate.Text & "',[bill_type]='" & cmbbilltype.Text & "',[invoiceno]=" & txtinvoiceno.Text & ",[desti_type]='" & cmbdestitype.Text & "',[inv_dte]='" & dtpinvdte.Text & "',[lrno]=" & txtlrno.Text & ",[consign]='" & txtconsname.Text & "',[desti]='" & cmbdesti.Text & "',[truckno]='" & txttruckno.Text & "',[mt]=" & txtdispmt.Text & ",[frt_rte]=" & txtfrt.Text & ",[amt]=" & txtamt.Text & ",[labour]=" & txtlbour.Text & ",[net_amt]=" & txtnetamt.Text & " where [invoice_id]=" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "invoice_id"), d.con)
                        cmd.ExecuteNonQuery()
                        XtraMessageBox.Show("Invoice Entry Updated Successfully", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        d.gridfill("select * from tbinvoice_master order by invoice_id asc", grdtrans)

                    Catch ex As Exception

                    End Try
                End If
            End If

        End If
    End Sub

    Private Sub txtfrt_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfrt.EditValueChanged
        amount()

    End Sub

    Private Sub cmbbilltype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbilltype.SelectedIndexChanged
        transaction()

    End Sub

    Private Sub cmbdestitype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdestitype.SelectedIndexChanged
        transaction()

    End Sub

    
    Private Sub frmnewinvoice_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed


    End Sub
End Class