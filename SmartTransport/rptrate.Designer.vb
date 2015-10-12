<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptrate
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
        Me.xrname = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrfrtrate = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrtype = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrbilltype = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrlabour = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.XrTable2.Location = New System.Drawing.Point(75, 0)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.Size = New System.Drawing.Size(575, 25)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrname, Me.xrfrtrate, Me.xrtype, Me.xrbilltype, Me.xrlabour})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Size = New System.Drawing.Size(575, 25)
        '
        'xrname
        '
        Me.xrname.Location = New System.Drawing.Point(0, 0)
        Me.xrname.Name = "xrname"
        Me.xrname.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.xrname.Size = New System.Drawing.Size(186, 25)
        Me.xrname.StylePriority.UsePadding = False
        Me.xrname.StylePriority.UseTextAlignment = False
        Me.xrname.Text = "xrname"
        Me.xrname.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrfrtrate
        '
        Me.xrfrtrate.Location = New System.Drawing.Point(186, 0)
        Me.xrfrtrate.Name = "xrfrtrate"
        Me.xrfrtrate.Size = New System.Drawing.Size(114, 25)
        Me.xrfrtrate.Text = "xrfrtrate"
        '
        'xrtype
        '
        Me.xrtype.Location = New System.Drawing.Point(300, 0)
        Me.xrtype.Name = "xrtype"
        Me.xrtype.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.xrtype.Size = New System.Drawing.Size(83, 25)
        Me.xrtype.StylePriority.UsePadding = False
        Me.xrtype.StylePriority.UseTextAlignment = False
        Me.xrtype.Text = "xrtype"
        Me.xrtype.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrbilltype
        '
        Me.xrbilltype.Location = New System.Drawing.Point(383, 0)
        Me.xrbilltype.Name = "xrbilltype"
        Me.xrbilltype.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.xrbilltype.Size = New System.Drawing.Size(109, 25)
        Me.xrbilltype.StylePriority.UsePadding = False
        Me.xrbilltype.StylePriority.UseTextAlignment = False
        Me.xrbilltype.Text = "xrbilltype"
        Me.xrbilltype.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrlabour
        '
        Me.xrlabour.Location = New System.Drawing.Point(492, 0)
        Me.xrlabour.Name = "xrlabour"
        Me.xrlabour.Size = New System.Drawing.Size(83, 25)
        Me.xrlabour.Text = "xrlabour"
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
        Me.XrTable1.Location = New System.Drawing.Point(75, 0)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.Size = New System.Drawing.Size(575, 25)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell5, Me.XrTableCell4, Me.XrTableCell3})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Size = New System.Drawing.Size(575, 25)
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Size = New System.Drawing.Size(186, 25)
        Me.XrTableCell1.Text = "Name"
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Location = New System.Drawing.Point(186, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Size = New System.Drawing.Size(114, 25)
        Me.XrTableCell2.Text = "FRT Rate"
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Location = New System.Drawing.Point(300, 0)
        Me.XrTableCell5.Multiline = True
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Size = New System.Drawing.Size(83, 25)
        Me.XrTableCell5.Text = "Type" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Location = New System.Drawing.Point(383, 0)
        Me.XrTableCell4.Multiline = True
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Size = New System.Drawing.Size(109, 25)
        Me.XrTableCell4.Text = "Bill Type" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Location = New System.Drawing.Point(492, 0)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Size = New System.Drawing.Size(83, 25)
        Me.XrTableCell3.Text = "Labour"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 30
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.XrLabel2, Me.XrLabel1})
        Me.ReportHeader.Height = 106
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLine1
        '
        Me.XrLine1.Location = New System.Drawing.Point(0, 100)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Size = New System.Drawing.Size(692, 2)
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel2.Location = New System.Drawing.Point(8, 75)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
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
        Me.XrLabel1.Location = New System.Drawing.Point(33, 0)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(642, 58)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Success Enterprise"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'rptrate
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.ReportHeader})
        Me.Margins = New System.Drawing.Printing.Margins(30, 100, 100, 100)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Version = "8.3"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrname As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrfrtrate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrbilltype As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrlabour As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrtype As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
End Class
