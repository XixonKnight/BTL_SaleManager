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
    public partial class FormDetail : Form
    {
        private string id;
        public FormDetail(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FormDetail_Load(object sender, EventArgs e)
        {
            loadDataDetailBillById();
        }

        private void loadDataDetailBillById()
        {
            DataTable dt = Details.getInfoBillById(this.id);
            dataViewDetail.DataSource = dt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataViewDetail.Rows[i].Cells["STT"].Value = i + 1;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FormCrystalReport frmCrystal = new FormCrystalReport(id);
            //this.Hide();
            frmCrystal.Show();
            //ReportBill rpt = new ReportBill();
            //rpt.show();
        }
    }
}
