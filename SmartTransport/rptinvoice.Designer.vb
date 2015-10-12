<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptinvoice
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.xrsrno = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrinvoiceno = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrinvdte = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrlrno = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrconsign = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrdesti = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrtruckno = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrdispmt = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrfrtrate = New DevExpress.XtraReports.UI.XRTableCell
        Me.xramt = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrlabour = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrnetamt = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrbilldte = New DevExpress.XtraReports.UI.XRLabel
        Me.xrbillno = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrtdispmt = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrtfrt = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrtamt = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrtlabour = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrtnetamt = New DevExpress.XtraReports.UI.XRTableCell
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.Height = 25
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.XrTable2.Location = New System.Drawing.Point(0, 0)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.Size = New System.Drawing.Size(1083, 25)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrsrno, Me.xrinvoiceno, Me.xrinvdte, Me.xrlrno, Me.xrconsign, Me.xrdesti, Me.xrtruckno, Me.xrdispmt, Me.xrfrtrate, Me.xramt, Me.xrlabour, Me.xrnetamt})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Size = New System.Drawing.Size(1083, 25)
        '
        'xrsrno
        '
        Me.xrsrno.Location = New System.Drawing.Point(0, 0)
        Me.xrsrno.Name = "xrsrno"
        Me.xrsrno.Size = New System.Drawing.Size(51, 25)
        Me.xrsrno.Text = "xrsrno"
        '
        'xrinvoiceno
        '
        Me.xrinvoiceno.Location = New System.Drawing.Point(51, 0)
        Me.xrinvoiceno.Name = "xrinvoiceno"
        Me.xrinvoiceno.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.xrinvoiceno.Size = New System.Drawing.Size(130, 25)
        Me.xrinvoiceno.StylePriority.UsePadding = False
        Me.xrinvoiceno.StylePriority.UseTextAlignment = False
        Me.xrinvoiceno.Text = "xrinvoiceno"
        Me.xrinvoiceno.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrinvdte
        '
        Me.xrinvdte.Location = New System.Drawing.Point(181, 0)
        Me.xrinvdte.Name = "xrinvdte"
        Me.xrinvdte.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.xrinvdte.Size = New System.Drawing.Size(98, 25)
        Me.xrinvdte.StylePriority.UsePadding = False
        Me.xrinvdte.StylePriority.UseTextAlignment = False
        Me.xrinvdte.Text = "xrinvdte"
        Me.xrinvdte.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrlrno
        '
        Me.xrlrno.Location = New System.Drawing.Point(279, 0)
        Me.xrlrno.Name = "xrlrno"
        Me.xrlrno.Size = New System.Drawing.Size(76, 25)
        Me.xrlrno.Text = "xrlrno"
        '
        'xrconsign
        '
        Me.xrconsign.Location = New System.Drawing.Point(355, 0)
        Me.xrconsign.Name = "xrconsign"
        Me.xrconsign.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.xrconsign.Size = New System.Drawing.Size(131, 25)
        Me.xrconsign.StylePriority.UsePadding = False
        Me.xrconsign.StylePriority.UseTextAlignment = False
        Me.xrconsign.Text = "xrconsign"
        Me.xrconsign.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrdesti
        '
        Me.xrdesti.Location = New System.Drawing.Point(486, 0)
        Me.xrdesti.Name = "xrdesti"
        Me.xrdesti.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.xrdesti.Size = New System.Drawing.Size(118, 25)
        Me.xrdesti.StylePriority.UsePadding = False
        Me.xrdesti.StylePriority.UseTextAlignment = False
        Me.xrdesti.Text = "xrdesti"
        Me.xrdesti.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrtruckno
        '
        Me.xrtruckno.Location = New System.Drawing.Point(604, 0)
        Me.xrtruckno.Name = "xrtruckno"
        Me.xrtruckno.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.xrtruckno.Size = New System.Drawing.Size(88, 25)
        Me.xrtruckno.StylePriority.UsePadding = False
        Me.xrtruckno.StylePriority.UseTextAlignment = False
        Me.xrtruckno.Text = "xrtruckno"
        Me.xrtruckno.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrdispmt
        '
        Me.xrdispmt.Location = New System.Drawing.Point(692, 0)
        Me.xrdispmt.Name = "xrdispmt"
        Me.xrdispmt.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.xrdispmt.Size = New System.Drawing.Size(75, 25)
        Me.xrdispmt.StylePriority.UsePadding = False
        Me.xrdispmt.StylePriority.UseTextAlignment = False
        Me.xrdispmt.Text = "xrdispmt"
        Me.xrdispmt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrfrtrate
        '
        Me.xrfrtrate.Location = New System.Drawing.Point(767, 0)
        Me.xrfrtrate.Name = "xrfrtrate"
        Me.xrfrtrate.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.xrfrtrate.Size = New System.Drawing.Size(83, 25)
        Me.xrfrtrate.StylePriority.UsePadding = False
        Me.xrfrtrate.StylePriority.UseTextAlignment = False
        Me.xrfrtrate.Text = "xrfrtrate"
        Me.xrfrtrate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xramt
        '
        Me.xramt.Location = New System.Drawing.Point(850, 0)
        Me.xramt.Multiline = True
        Me.xramt.Name = "xramt"
        Me.xramt.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.xramt.Size = New System.Drawing.Size(75, 25)
        Me.xramt.StylePriority.UsePadding = False
        Me.xramt.StylePriority.UseTextAlignment = False
        Me.xramt.Text = "xramt"
        Me.xramt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrlabour
        '
        Me.xrlabour.Location = New System.Drawing.Point(925, 0)
        Me.xrlabour.Name = "xrlabour"
        Me.xrlabour.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.xrlabour.Size = New System.Drawing.Size(75, 25)
        Me.xrlabour.StylePriority.UsePadding = False
        Me.xrlabour.StylePriority.UseTextAlignment = False
        Me.xrlabour.Text = "xrlabour"
        Me.xrlabour.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrnetamt
        '
        Me.xrnetamt.Location = New System.Drawing.Point(1000, 0)
        Me.xrnetamt.Name = "xrnetamt"
        Me.xrnetamt.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.xrnetamt.Size = New System.Drawing.Size(83, 25)
        Me.xrnetamt.StylePriority.UsePadding = False
        Me.xrnetamt.StylePriority.UseTextAlignment = False
        Me.xrnetamt.Text = "xrnetamt"
        Me.xrnetamt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.PageHeader.Height = 25
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTable1.Location = New System.Drawing.Point(0, 0)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.Size = New System.Drawing.Size(1083, 25)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell3, Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell10, Me.XrTableCell6, Me.XrTableCell12, Me.XrTableCell11})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Size = New System.Drawing.Size(1083, 25)
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Size = New System.Drawing.Size(51, 25)
        Me.XrTableCell1.Text = "Sr.No"
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Location = New System.Drawing.Point(51, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Size = New System.Drawing.Size(130, 25)
        Me.XrTableCell2.Text = "Invoice No"
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Location = New System.Drawing.Point(181, 0)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Size = New System.Drawing.Size(98, 25)
        Me.XrTableCell4.Text = "Inv.Date"
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Location = New System.Drawing.Point(279, 0)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Size = New System.Drawing.Size(76, 25)
        Me.XrTableCell5.Text = "L.R.No"
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Location = New System.Drawing.Point(355, 0)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Size = New System.Drawing.Size(131, 25)
        Me.XrTableCell3.Text = "Consignee Name"
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Location = New System.Drawing.Point(486, 0)
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Size = New System.Drawing.Size(118, 25)
        Me.XrTableCell7.Text = "Destination"
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Location = New System.Drawing.Point(604, 0)
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Size = New System.Drawing.Size(88, 25)
        Me.XrTableCell8.Text = "Truck No"
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Location = New System.Drawing.Point(692, 0)
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Size = New System.Drawing.Size(75, 25)
        Me.XrTableCell9.Text = "Disp.M.T."
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Location = New System.Drawing.Point(767, 0)
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Size = New System.Drawing.Size(83, 25)
        Me.XrTableCell10.Text = "FRT.Rate"
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Location = New System.Drawing.Point(850, 0)
        Me.XrTableCell6.Multiline = True
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Size = New System.Drawing.Size(75, 25)
        Me.XrTableCell6.Text = "Amount" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Location = New System.Drawing.Point(925, 0)
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Size = New System.Drawing.Size(75, 25)
        Me.XrTableCell12.Text = "Labour"
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Location = New System.Drawing.Point(1000, 0)
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Size = New System.Drawing.Size(83, 25)
        Me.XrTableCell11.Text = "Net.Amt"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 31
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel12, Me.XrLabel11, Me.XrLabel8, Me.XrLabel7, Me.XrLine5, Me.XrLine4, Me.XrLine3, Me.XrLine2, Me.XrLabel10, Me.XrLabel9, Me.xrbilldte, Me.xrbillno, Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLine1, Me.XrLabel2, Me.XrLabel1})
        Me.ReportHeader.Height = 239
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 10.5!)
        Me.XrLabel12.Location = New System.Drawing.Point(17, 210)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.Size = New System.Drawing.Size(608, 29)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.Text = "Being The Frieight Bill Towards, Transportation From Grinding Unit to various Des" & _
            "tinations."
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.Location = New System.Drawing.Point(17, 158)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.Text = "Ahmedabad"
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.Location = New System.Drawing.Point(17, 133)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.Size = New System.Drawing.Size(167, 25)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.Text = "Sanghi Industries Limited"
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.Location = New System.Drawing.Point(17, 108)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.Text = "To,"
        '
        'XrLine5
        '
        Me.XrLine5.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine5.LineWidth = 2
        Me.XrLine5.Location = New System.Drawing.Point(1080, 111)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.Size = New System.Drawing.Size(8, 119)
        '
        'XrLine4
        '
        Me.XrLine4.LineWidth = 2
        Me.XrLine4.Location = New System.Drawing.Point(858, 225)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.Size = New System.Drawing.Size(225, 8)
        '
        'XrLine3
        '
        Me.XrLine3.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine3.LineWidth = 2
        Me.XrLine3.Location = New System.Drawing.Point(855, 113)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.Size = New System.Drawing.Size(8, 115)
        '
        'XrLine2
        '
        Me.XrLine2.LineWidth = 2
        Me.XrLine2.Location = New System.Drawing.Point(858, 108)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(225, 8)
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrLabel10.Location = New System.Drawing.Point(958, 200)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.Size = New System.Drawing.Size(125, 25)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.Text = "ARSPM1617L001"
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrLabel9.Location = New System.Drawing.Point(958, 175)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.Text = "ARSPM1617L"
        '
        'xrbilldte
        '
        Me.xrbilldte.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.xrbilldte.Location = New System.Drawing.Point(958, 150)
        Me.xrbilldte.Name = "xrbilldte"
        Me.xrbilldte.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrbilldte.Size = New System.Drawing.Size(100, 25)
        Me.xrbilldte.StylePriority.UseFont = False
        Me.xrbilldte.Text = "xrbilldte"
        '
        'xrbillno
        '
        Me.xrbillno.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.xrbillno.Location = New System.Drawing.Point(958, 125)
        Me.xrbillno.Name = "xrbillno"
        Me.xrbillno.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrbillno.Size = New System.Drawing.Size(100, 25)
        Me.xrbillno.StylePriority.UseFont = False
        Me.xrbillno.Text = "xrbillno"
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.Location = New System.Drawing.Point(875, 200)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.Text = "S.Tax No."
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.Location = New System.Drawing.Point(875, 175)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.Text = "PAN No.  "
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.Location = New System.Drawing.Point(875, 150)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "Bill Date:"
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.Location = New System.Drawing.Point(875, 125)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "Bill No." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'XrLine1
        '
        Me.XrLine1.Location = New System.Drawing.Point(0, 100)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Size = New System.Drawing.Size(1075, 2)
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel2.Location = New System.Drawing.Point(175, 75)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.Size = New System.Drawing.Size(692, 25)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UsePadding = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "A-Wing,Nr.Bajaj Allienze,R.T.O.Circle,Bhuj-Kutch 370001, Ph. +91 9913590233" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 36.0!)
        Me.XrLabel1.Location = New System.Drawing.Point(200, 0)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(642, 58)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Success Enterprise"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
        Me.GroupFooter1.Height = 25
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrTable3
        '
        Me.XrTable3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTable3.Location = New System.Drawing.Point(0, 0)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable3.Size = New System.Drawing.Size(1083, 25)
        Me.XrTable3.StylePriority.UseBorders = False
        Me.XrTable3.StylePriority.UseFont = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell13, Me.xrtdispmt, Me.xrtfrt, Me.xrtamt, Me.xrtlabour, Me.xrtnetamt})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Size = New System.Drawing.Size(1083, 25)
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Size = New System.Drawing.Size(692, 25)
        Me.XrTableCell13.Text = "Total"
        '
        'xrtdispmt
        '
        Me.xrtdispmt.Location = New System.Drawing.Point(692, 0)
        Me.xrtdispmt.Name = "xrtdispmt"
        Me.xrtdispmt.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.xrtdispmt.Size = New System.Drawing.Size(75, 25)
        Me.xrtdispmt.StylePriority.UsePadding = False
        Me.xrtdispmt.StylePriority.UseTextAlignment = False
        Me.xrtdispmt.Text = "Disp.M.T."
        Me.xrtdispmt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrtfrt
        '
        Me.xrtfrt.Location = New System.Drawing.Point(767, 0)
        Me.xrtfrt.Name = "xrtfrt"
        Me.xrtfrt.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.xrtfrt.Size = New System.Drawing.Size(83, 25)
        Me.xrtfrt.StylePriority.UsePadding = False
        Me.xrtfrt.StylePriority.UseTextAlignment = False
        Me.xrtfrt.Text = "FRT.Rate"
        Me.xrtfrt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrtamt
        '
        Me.xrtamt.Location = New System.Drawing.Point(850, 0)
        Me.xrtamt.Multiline = True
        Me.xrtamt.Name = "xrtamt"
        Me.xrtamt.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.xrtamt.Size = New System.Drawing.Size(75, 25)
        Me.xrtamt.StylePriority.UsePadding = False
        Me.xrtamt.StylePriority.UseTextAlignment = False
        Me.xrtamt.Text = "Amount" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.xrtamt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrtlabour
        '
        Me.xrtlabour.Location = New System.Drawing.Point(925, 0)
        Me.xrtlabour.Name = "xrtlabour"
        Me.xrtlabour.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.xrtlabour.Size = New System.Drawing.Size(75, 25)
        Me.xrtlabour.StylePriority.UsePadding = False
        Me.xrtlabour.StylePriority.UseTextAlignment = False
        Me.xrtlabour.Text = "Labour"
        Me.xrtlabour.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrtnetamt
        '
        Me.xrtnetamt.Location = New System.Drawing.Point(1000, 0)
        Me.xrtnetamt.Name = "xrtnetamt"
        Me.xrtnetamt.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.xrtnetamt.Size = New System.Drawing.Size(83, 25)
        Me.xrtnetamt.StylePriority.UsePadding = False
        Me.xrtnetamt.StylePriority.UseTextAlignment = False
        Me.xrtnetamt.Text = "Net.Amt"
        Me.xrtnetamt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'rptinvoice
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.ReportHeader, Me.GroupFooter1})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(50, 25, 80, 40)
        Me.PageHeight = 827
        Me.PageWidth = 1169
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Version = "8.3"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrbilldte As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrbillno As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrsrno As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrinvoiceno As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrinvdte As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrlrno As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrconsign As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrdesti As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrtruckno As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrdispmt As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrfrtrate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xramt As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrlabour As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrnetamt As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrtdispmt As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrtfrt As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrtamt As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrtlabour As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrtnetamt As DevExpress.XtraReports.UI.XRTableCell
End Class
