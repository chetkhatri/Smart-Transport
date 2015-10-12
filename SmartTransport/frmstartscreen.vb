Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient
Imports System.IO


Public Class frmstartscreen
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cmd As New SqlCommand
    Dim d As New databind
    Private Sub frmstartscreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableFormSkins()
        UserLookAndFeel.Default.SetSkinStyle("The Asphalt World")

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("The Asphalt World")
        DevExpress.LookAndFeel.UserLookAndFeel.Default.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "The Asphalt World"
        d.conn()
        Me.Hide()





        frmlogin.Show()
        If frmlogin.btnlogin.Tag = "log" Then
            Me.Visible = True

        End If
        Me.Visible = False

    End Sub

    Private Sub RibbonStatusBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmstartscreen_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (XtraMessageBox.Show("Are you sure you want to Close?", "Smart Transport", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
            e.Cancel = False
            XtraMessageBox.Show("Thank you", "Smart Transport", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btnadddest_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnadddest.ItemClick
        frmdesti_entry.ShowDialog()

    End Sub

    Private Sub btnnewin_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnnewin.ItemClick

        frmnewinvoice.ShowDialog()

    End Sub

    

    Private Sub btnbackup_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnbackup.ItemClick
        If Not Directory.Exists("D:\SmartBackup") Then
            Directory.CreateDirectory("D:\SmartBackup")
            backup()

        Else
            backup()


        End If

    End Sub
    Private Sub backup()
        Try
            Dim dte As String = Now.Date
            Directory.CreateDirectory("D:\SmartBackup\" & dte)
            Dim newpath As String = "D:\SmartBackup\" & dte & "\dbsmart.accdb"
            Dim StrPath As String = Application.StartupPath & "\dbsmart.accdb"

            File.Copy(StrPath, newpath, True)
            XtraMessageBox.Show("Backup Success to " & newpath, "SmartTransport", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnchngpw_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnchngpw.ItemClick
        frmchangepw.ShowDialog()

    End Sub

    Private Sub btnabt_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnabt.ItemClick
        frmabt.ShowDialog()

    End Sub

    Private Sub btnviewrate_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnviewrate.ItemClick
        frmviewrate.ShowDialog()

    End Sub

    Private Sub btnviewin_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnviewin.ItemClick
        frmviewinvoice.ShowDialog()

    End Sub

    Private Sub btniinvoicetype_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btniinvoicetype.ItemClick
        frmbilltype.ShowDialog()


    End Sub
End Class