using System;
using System.Drawing;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using E5053.Models;

namespace E5053.Reports {
    public partial class ProductsReport : DevExpress.XtraReports.UI.XtraReport {
        NWINDEntities nWindContext = new NWINDEntities();

        public ProductsReport() {
            InitializeComponent();
        }

        private void ProductsReport_DataSourceDemanded(object sender, EventArgs e) {
            int categoryID = (int)Parameters["CategoryID"].Value;
            DataSource = from product in nWindContext.Products
                         where product.CategoryID == categoryID
                         select product;
        }

    }
}
