Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.Linq
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports E5053.Models

Namespace E5053.Reports
    Partial Public Class ProductsReport
        Inherits DevExpress.XtraReports.UI.XtraReport
        Private nWindContext As New NWINDEntities()

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub ProductsReport_DataSourceDemanded(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.DataSourceDemanded
            Dim categoryID As Integer = CInt(Fix(Parameters("CategoryID").Value))
            DataSource = From product In nWindContext.Products Where product.CategoryID = categoryID Select product
        End Sub

    End Class
End Namespace
