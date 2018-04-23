using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using E5053.Reports;

namespace E5053.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }        

        public ActionResult DocumentViewerPartial() {
            ProductsReport report = new ProductsReport();
            return PartialView("_DocumentViewerPartial", report);
        }

        public ActionResult DocumentViewerPartialExport() {
            ProductsReport report = new ProductsReport();
            return DocumentViewerExtension.ExportTo(report);
        }
    }
}