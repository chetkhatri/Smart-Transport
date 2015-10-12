Imports DevExpress.LookAndFeel
Imports System.Data.OleDb
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.XtraEditors



Public Class frmlogin
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim max, j As Integer
    Dim both, uid, pw As Integer
    Private dlg As DevExpress.Utils.WaitDialogForm = Nothing
    Dim i As Integer = 1
    Dim d As New databind
    Public user As String





    Public Sub WaitDlg(ByVal sStatus As sWaitDlgStatus, Optional ByVal Caption As String = "Loading Default Settings...", Optional ByVal Title As String = "Wait")
        Try
            Select Case sStatus
                Case sWaitDlgStatus.Show
                    If Title <> "Wait" Then
                        If Not dlg Is Nothing Then
                            dlg.Dispose()
                        End If
                        dlg = New DevExpress.Utils.WaitDialogForm(Caption, Title)
                    Else
                        If dlg Is Nothing Then
                            dlg = New DevExpress.Utils.WaitDialogForm(Caption, Title)
                        End If
                        dlg.SetCaption(Caption)
                        dlg.Show()
                    End If
                Case sWaitDlgStatus.Hide
                    If Not dlg Is Nothing Then
                        dlg.Hide()
                    End If
            End Select
            'Application.DoEvents()
        Catch ex As Exception
        End Try
    End Sub

    Enum sWaitDlgStatus
        Show = 0
        Hide = 1
    End Enum
    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        
        If (txtusername.Text = "" And txtpassword.Text = "") Then
            XtraMessageBox.Show("Username And Password Are Empty", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtusername.Focus()
        Else
            Try
                cmd = New OleDbCommand("select count(*) from user_master where [u_name]='" + txtusername.Text + "'", d.con)
                Dim no As Integer = cmd.ExecuteScalar
                If no > 0 Then
                    da = New OleDbDataAdapter("select * from user_master where [u_name]='" + txtusername.Text + "'", d.con)
                    da.Fill(ds, "user")
                    If txtpassword.Text = ds.Tables("user").Rows(0).Item("pwd") Then
                        Try
                            logged()

                        Catch ex As Exception

                        End Try


                    Else
                        XtraMessageBox.Show("Incorrect Password", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        txtpassword.Text = ""
                        txtpassword.Focus()
                    End If

                ElseIf (no = 0) Then
                    XtraMessageBox.Show("Incorrect UserName", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtusername.Focus()
                    txtusername.SelectAll()
                End If
            Catch ex As Exception

            End Try
        End If

       
    End Sub
    Public Sub logged()
        XtraMessageBox.Show("You Logged successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        WaitDlg(frmlogin.sWaitDlgStatus.Show)
        Timer1.Start()

        Me.Hide()
        frmstartscreen.Enabled = True
        btnlogin.Tag = "log"
    End Sub

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        d.conn()

         SkinManager.EnableFormSkins()
        UserLookAndFeel.Default.SetSkinStyle("The Asphalt World")

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("The Asphalt World")
        DevExpress.LookAndFeel.UserLookAndFeel.Default.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "The Asphalt World"

        Dim _blankContextMenu As New ContextMenu()
        txtpassword.ContextMenu = _blankContextMenu
        txtusername.ContextMenu = _blankContextMenu

    End Sub


  

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
        frmstartscreen.Close()


    End Sub
   
   

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        i = i + 14

        If i > 64 Then
            WaitDlg(frmlogin.sWaitDlgStatus.Hide)
            frmstartscreen.Show()
            frmstartscreen.Enabled = True
            frmstartscreen.Opacity = 100%
            Timer1.Stop()


            Me.Close()


        End If
    End Sub

    Private Sub GroupControl1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GroupControl1.Paint

    End Sub
End Class