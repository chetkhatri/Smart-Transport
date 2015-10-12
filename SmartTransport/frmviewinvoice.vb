Imports System.Data.OleDb
Imports System.Data.DataColumn
Imports DevExpress.XtraEditors
Imports System.Type
Public Class frmviewinvoice
    Dim a As New validation
    Dim d As New databind
    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet

   

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click

        txtbillno.Text = ""
        dtpbilldate.Text = ""
        txtbillno.Focus()

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        If (txtbillno.Text = "" And dtpbilldate.Text = "") Then
            XtraMessageBox.Show("Please Enter Any One Field", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtbillno.Focus()

        Else
            If Not (txtbillno.Text = "") Then
                d.gridfill("select * from tbinvoice_master where [billno]='" & txtbillno.Text & "' ", grdinvdtl)

            ElseIf Not (dtpbilldate.Text = "") Then
                d.gridfill("select * from tbinvoice_master where [dte]='" & dtpbilldate.Text & "'", grdinvdtl)
            End If
        End If
    End Sub

    Private Sub frmviewinvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        d.conn()
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

        d.gridfill("", grdinvdtl)

        txtbillno.Text = ""
        dtpbilldate.Text = ""
        txtbillno.Focus()

    End Sub

  
    Private Sub dtpbilldate_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpbilldate.EditValueChanged
        If Not (dtpbilldate.Text = "") Then
            txtbillno.Enabled = False
        Else
            txtbillno.Enabled = True
        End If
    End Sub

    Private Sub txtbillno_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbillno.EditValueChanged
        If Not (txtbillno.Text = "") Then
            dtpbilldate.Enabled = False
        Else
            dtpbilldate.Enabled = True
        End If
    End Sub

    Private Sub btnpprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpprev.Click
        btnpprev.Tag = "prv"
        reporting()
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        btnpprev.Tag = "prn"
        reporting()
    End Sub

    Private Sub btnexp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexp.Click
        btnpprev.Tag = "exp"
        reporting()
    End Sub
    Private Sub reporting()
        If (txtbillno.Text = "" And dtpbilldate.Text = "") Then
            XtraMessageBox.Show("Please Enter Any One Field", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtbillno.Focus()
        Else
            If Not (txtbillno.Text = "") Then
                'd.gridfill("select * from tbinvoice_master where [billno]='" & txtbillno.Text & "' ", grdinvdtl)
                da = New OleDbDataAdapter("select * from tbinvoice_master where [billno]='" & txtbillno.Text & "'", d.con)
            ElseIf Not (dtpbilldate.Text = "") Then
                'd.gridfill("select * from tbinvoice_master where [dte]='" & dtpbilldate.Text & "'", grdinvdtl)
                da = New OleDbDataAdapter("select * from tbinvoice_master where [dte]='" & dtpbilldate.Text & "'", d.con)

            End If

        End If

        

        If btnpprev.Tag = "prv" Then
            rempinfo("prv")
        ElseIf btnpprev.Tag = "prn" Then
            rempinfo("prn")
        ElseIf btnpprev.Tag = "exp" Then
            rempinfo("exp")
        End If
    End Sub
    Private Sub rempinfo(ByVal rpttype As String)
        Try
            ds.Clear()

            da.Fill(ds, "abc")

            ds.Tables("abc").Columns.Add("srno", GetType(Integer), Nothing)
            

            For i = 0 To ds.Tables("abc").Rows.Count - 1
                ds.Tables("abc").Rows(i).Item("srno") = i + 1
            Next



            Dim report2 As New rptinvoice
            report2.DataSource = ds.Tables("abc")
            report2.DataMember = "abc"
            report2.xrbillno.DataBindings.Add("Text", ds.Tables("abc"), "abc.billno")
            report2.xrbilldte.DataBindings.Add("Text", ds.Tables("abc"), "abc.dte")
            report2.xrinvoiceno.DataBindings.Add("Text", ds.Tables("abc"), "abc.invoiceno")
            report2.xrinvdte.DataBindings.Add("Text", ds.Tables("abc"), "abc.inv_dte")
            report2.xrlrno.DataBindings.Add("Text", ds.Tables("abc"), "abc.lrno")
            report2.xrconsign.DataBindings.Add("Text", ds.Tables("abc"), "abc.consign")
            report2.xrdesti.DataBindings.Add("Text", ds.Tables("abc"), "abc.desti")
            report2.xrtruckno.DataBindings.Add("Text", ds.Tables("abc"), "abc.truckno")
            report2.xrdispmt.DataBindings.Add("Text", ds.Tables("abc"), "abc.mt")
            report2.xrfrtrate.DataBindings.Add("Text", ds.Tables("abc"), "abc.frt_rte")
            report2.xramt.DataBindings.Add("Text", ds.Tables("abc"), "abc.amt")
            report2.xrlabour.DataBindings.Add("Text", ds.Tables("abc"), "abc.labour")
            report2.xrnetamt.DataBindings.Add("Text", ds.Tables("abc"), "abc.net_amt")



            '''''just exprienments'''''''''''''


            'For i = 1 To ds.Tables("abc").Rows.Count
            '    ds.Tables("abc").Columns.Add("srno", GetType(Integer), Nothing)
            'Next

            'ds.Tables("abc").Columns.Add("srno", GetType(Integer), Nothing)
            'ds.Tables("abc").Columns("srno").AutoIncrement = True
            'ds.Tables("abc").Columns("srno").AutoIncrementSeed = 1
            'ds.Tables("abc").Columns("srno").AutoIncrementStep = ds.Tables("abc").Rows.Count


            report2.xrsrno.DataBindings.Add("Text", ds.Tables("abc"), "abc.srno")



            Try
                If Not (txtbillno.Text = "") Then

                    da = New OleDbDataAdapter("select sum(mt) as tmt,sum(frt_rte) as tfrt,sum(amt) as tamt,sum(labour) as tlabour,sum(net_amt) as tnetamt from tbinvoice_master where [billno]='" & txtbillno.Text & "'", d.con)

                ElseIf Not (dtpbilldate.Text = "") Then


                    da = New OleDbDataAdapter("select sum(mt) as tmt,sum(frt_rte) as tfrt,sum(amt) as tamt,sum(labour) as tlabour,sum(net_amt) as tnetamt from tbinvoice_master where [dte]='" & dtpbilldate.Text & "'", d.con)

                End If

                Dim ds1 As New DataSet
                da.Fill(ds1, "total")

                report2.xrtdispmt.DataBindings.Add("Text", ds1.Tables("total"), "abc.tmt")
                report2.xrtfrt.DataBindings.Add("Text", ds1.Tables("total"), "abc.tfrt")
                report2.xrtamt.DataBindings.Add("Text", ds1.Tables("total"), "abc.tamt")
                report2.xrtlabour.DataBindings.Add("Text", ds1.Tables("total"), "abc.tlabour")
                report2.xrtnetamt.DataBindings.Add("Text", ds1.Tables("total"), "abc.tnetamt")

            Catch ex As Exception

            End Try









            If rpttype = "prv" Then
                report2.ShowPreview()
            ElseIf rpttype = "prn" Then
                report2.Print()
            ElseIf rpttype = "exp" Then
                SaveFileDialog1.ShowDialog()
                If SaveFileDialog1.FileName = "" Then
                    XtraMessageBox.Show("Please Choose location for File", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    report2.ExportToXls(SaveFileDialog1.FileName)
                End If


            End If
        Catch ex As Exception

        End Try
    End Sub
End Class