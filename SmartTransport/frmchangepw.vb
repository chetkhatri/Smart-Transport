Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Public Class frmchangepw
    Dim a As New validation

    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim d As New databind
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If a.txtstring(txtcurrent, lblcurrent) = True Then
            XtraMessageBox.Show("Please Enter Current Password", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf a.txtstring(txtnew, lblnew) = True Then
            XtraMessageBox.Show("Please Enter New Password", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf a.txtstring(txtretype, lblretype) = True Then
            XtraMessageBox.Show("Please Re-Enter New Password", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            da = New OleDbDataAdapter("select [pwd] from user_master", d.con)
            da.Fill(ds, "pass")
            If txtcurrent.Text = ds.Tables("pass").Rows(0).Item("pwd") Then

                If Not (txtnew.Text = txtretype.Text) Then
                    XtraMessageBox.Show("Password Combination does not match", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtcurrent.Text = ""
                    txtnew.Text = ""
                    txtretype.Text = ""
                    txtcurrent.Focus()
                Else
                    Try
                        cmd = New OleDbCommand("update user_master set[pwd]='" & txtnew.Text & "'", d.con)
                        cmd.ExecuteNonQuery()
                        XtraMessageBox.Show("Password Changed Successfully", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtcurrent.Text = ""
                        txtnew.Text = ""
                        txtretype.Text = ""
                        txtcurrent.Focus()
                    Catch ex As Exception

                    End Try
                End If
            Else
                XtraMessageBox.Show("Incorrect Password", "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtcurrent.Text = ""
                txtnew.Text = ""
                txtretype.Text = ""
                txtcurrent.Focus()
            End If


        End If
    End Sub

    Private Sub frmchangepw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        d.conn()

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub
End Class