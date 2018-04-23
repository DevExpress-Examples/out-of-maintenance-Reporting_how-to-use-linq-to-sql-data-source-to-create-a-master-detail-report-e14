Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace LinqToSqlMasterDetail
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim dc As New NwindDataContext()
            Dim report As New XtraReport1()
            Dim bs As BindingSource = CType(report.DataSource, BindingSource)
            bs.DataSource = dc.Orders
            report.ShowPreviewDialog()
        End Sub
    End Class
End Namespace
