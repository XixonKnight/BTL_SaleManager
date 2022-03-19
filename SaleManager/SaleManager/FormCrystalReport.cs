using CrystalDecisions.CrystalReports.Engine;
using SaleManager.Control;
using SaleManager.Crystal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManager
{
    public partial class FormCrystalReport : Form
    {
        private string idBill;
        public FormCrystalReport(string idBill)
        {
            this.idBill = idBill;
            InitializeComponent();
        }

        private void FormCrystalReport_Load(object sender, EventArgs e)
        {
            DataTable dtP = Product.getProductByIdBillAndDetail(idBill);
            dtP.TableName = "TabelBill";
            DataSet ds = new DataSet();
            DataTable dsBill = Bills.getBillByIdBill(idBill);
            dsBill.TableName = "TableData";
            ds.Tables.Add(dsBill);
            ds.Tables.Add(dtP);
            ReportBill report = new ReportBill();
            report.SetDataSource(ds);
            //report.SetDataSource(dsBill);
            cryViewBill.ReportSource = report;
        }
    }
}
