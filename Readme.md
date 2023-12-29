<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/E5053/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/E5053/Controllers/HomeController.vb))
* [ProductsReport.cs](./CS/E5053/Reports/ProductsReport.cs) (VB: [ProductsReport.vb](./VB/E5053/Reports/ProductsReport.vb))
* **[_DocumentViewerPartial.cshtml](./CS/E5053/Views/Home/_DocumentViewerPartial.cshtml)**
* [Index.cshtml](./CS/E5053/Views/Home/Index.cshtml)
<!-- default file list end -->
# DocumentViewer - How to customize a report parameter editor in MVC application


<p>DocumentViewer - How to customize a report parameter editor in an MVC application</p>
<br />
<p>This example demonstrates how you can customize the editor used to edit the XtraReport parameter in the ASP.NET MVC application. The ComboBox editor bound to the Entity Framework model data is used there to edit the report's "CategoryID" parameter, instead of using a regular TextBox parameter editor.</p>
<br />
<p>The <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebMvcDocumentViewerSettings_SetCustomParametertopic2003"><u>DocumentViewerSettings.SetCustomParameter</u></a> method is used to customize the parameter editor. Use the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebMvcMVCxDocumentViewerParameter_PropertiesEdittopic"><u>MVCxDocumentViewerParameter.PropertiesEdit</u></a> property to get/set the parameter editor properties.<br /><br /><strong>See also:</strong><br /><a href="https://www.devexpress.com/Support/Center/p/T191944">MVC DocumentViewer extension - Creating a multi-select parameter</a></p>

<br/>


