<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/E5053/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/E5053/Controllers/HomeController.vb))
* [ProductsReport.cs](./CS/E5053/Reports/ProductsReport.cs) (VB: [ProductsReport.vb](./VB/E5053/Reports/ProductsReport.vb))
* **[_DocumentViewerPartial.cshtml](./CS/E5053/Views/Home/_DocumentViewerPartial.cshtml)**
* [Index.cshtml](./CS/E5053/Views/Home/Index.cshtml)
<!-- default file list end -->
# DocumentViewer - How to customize a report parameter editor in MVC application
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e5053/)**
<!-- run online end -->


# DocumentViewer - How to customize a report parameter editor in an MVC application

This example demonstrates how you can customize the editor used to edit the XtraReport parameter in the ASP.NET MVC application. The ComboBox editor bound to the Entity Framework model data is used there to edit the report's "CategoryID" parameter, instead of using a regular TextBox parameter editor.


The [DocumentViewerSettings.SetCustomParameter](https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.DocumentViewerSettings.SetCustomParameter.overloads) method is used to customize the parameter editor. Use the [MVCxDocumentViewerParameter.PropertiesEdit](https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.MVCxDocumentViewerParameter.PropertiesEdit) property to get/set the parameter editor properties.
  
 <strong>See also:</strong>
- [MVC DocumentViewer extension - Creating a multi-select parameter](https://supportcenter.devexpress.com/ticket/details/t191944)


