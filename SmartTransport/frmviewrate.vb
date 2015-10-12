Imports DevExpress.XtraEditors
Imports System.Data.OleDb
Public Class frmviewrate
    Dim a As New validation
    Dim d As New databind
    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub frmviewrate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        d.conn()

        d.gridfill("select * from tbdesti", grdrates)

        GridView1.OptionsView.ShowAutoFilterRow = True


        GridView1.Columns("desti_name").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        GridView1.Columns("desti_name").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("rate").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("rate").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("type").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        GridView1.Columns("type").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("labour").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("labour").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

    End Sub
    Private Sub reporting()
        da = New OleDbDataAdapter("select * from tbdesti", d.con)
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
            Dim report2 As New rptrate
            report2.DataSource = ds.Tables("abc")
            report2.DataMember = "abc"
            report2.xrname.DataBindings.Add("Text", ds.Tables("abc"), "abc.desti_name")
            report2.xrfrtrate.DataBindings.Add("Text", ds.Tables("abc"), "abc.rate")
            report2.xrtype.DataBindings.Add("Text", ds.Tables("abc"), "abc.type")
            report2.xrbilltype.DataBindings.Add("Text", ds.Tables("abc"), "abc.bill_type")
            report2.xrlabour.DataBindings.Add("Text", ds.Tables("abc"), "abc.labour")



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
End Class