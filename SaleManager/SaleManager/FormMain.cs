using SaleManager.Common;
using SaleManager.Control;
using SaleManager.Model;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            getDataCategory();
            setDataForCbb();
        }

        private void setDataForCbb()
        {
            customCbbStatusCategory();
            customCbbCategoryForProduct();
        }

        private void customCbbStatusCategory()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("status");
            dt.Columns.Add("value");
            dt.Rows.Add(true, Constants.ACTIVE);
            dt.Rows.Add(false, Constants.DISABLED);
            cbbStatusCategory.Items.Clear();
            cbbStatusCategory.DataSource = dt;
            cbbStatusCategory.DisplayMember = "value";
            cbbStatusCategory.ValueMember = "status";
            cbbStatusCategory.SelectedIndex = 0;
        }

        private void clearDataCategory()
        {
            txtNameCategory.Clear();
            txtSupplier.Clear();
            txtIdCategory.Clear();
            cbbStatusCategory.SelectedIndex = 0;
            txtIdCategory.Visible = false;
            lblIdCategory.Visible = false;
            btnDelCategory.Enabled = false;
            btnEditCategory.Enabled = false;
            btnAddCategory.Enabled = true;

        }

        private void getDataCategory()
        {
            DataTable dt = Category.getAllCategories(Constants.ACTION_GET_ALL);
            dataViewCategories.DataSource = dt;
            dataViewCategories.Columns["Id"].Visible = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataViewCategories.Rows[i].Cells[0].Value = i + 1;
            }

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string guid = Guid.NewGuid().ToString();
            string nameCategory = txtNameCategory.Text;
            string nameSupplier = txtSupplier.Text;
            string valueCbb = cbbPCategories.Text;
            bool status = bool.Parse((string)cbbStatusCategory.SelectedValue);
            Category category = new Category();
            bool flag = category.saveOrUpdateCategory(guid, nameCategory, nameSupplier, status, Constants.ACTION_ADD);
            if (flag)
            {
                getDataCategory();
                clearDataCategory();
            }
            else
            {
                MessageBox.Show("Thêm mới không thành công!!", "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            string txtId = txtIdCategory.Text;
            string txtNameSupplier = txtSupplier.Text;
            string txtCategory = txtNameCategory.Text;
            bool status = bool.Parse((string)cbbStatusCategory.SelectedValue);
            Category category = new Category();
            bool flag = category.saveOrUpdateCategory(txtId, txtCategory, txtNameSupplier, status, Constants.ACTION_UPDATE);
            if (flag)
            {
                getDataCategory();
                clearDataCategory();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!!", "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void dataViewCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataViewCategories.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                btnDelCategory.Enabled = true;
                btnEditCategory.Enabled = true;
                txtIdCategory.Visible = true;
                lblIdCategory.Visible = true;
                btnAddCategory.Enabled = false;
                dataViewCategories.CurrentRow.Selected = true;
                txtIdCategory.Text = dataViewCategories.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                txtNameCategory.Text = dataViewCategories.Rows[e.RowIndex].Cells["NameCategory"].FormattedValue.ToString();
                txtSupplier.Text = dataViewCategories.Rows[e.RowIndex].Cells["NameSupplier"].FormattedValue.ToString();
                if (dataViewCategories.Rows[e.RowIndex].Cells["Status"].FormattedValue.ToString().Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    cbbStatusCategory.SelectedIndex = 0;
                }
                else if (dataViewCategories.Rows[e.RowIndex].Cells["Status"].FormattedValue.ToString().Equals("false", StringComparison.OrdinalIgnoreCase))
                {
                    cbbStatusCategory.SelectedIndex = 1;
                }
            }

        }

        private void btnDelCategory_Click(object sender, EventArgs e)
        {
            string guid = txtIdCategory.Text;
            Category category = new Category();
            bool flag = category.delCategory(guid);
            if (flag)
            {
                getDataCategory();
                clearDataCategory();
            }
            else
            {
                MessageBox.Show("Xóa không thành công!!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnClearCategory_Click(object sender, EventArgs e)
        {
            clearDataCategory();
        }


        private void loadDataProduct()
        {
            DataTable dt = Product.getAllProduct();
            dataPView.DataSource = dt;
            dataPView.Columns["Id"].Visible = false;
            dataPView.Columns["IdCategory"].Visible = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataPView.Rows[i].Cells["PSTT"].Value = i + 1;
            }

        }

        private void customCbbCategoryForProduct()
        {
            DataTable dt = Category.getAllCategories(Constants.ACTION_GET_FOR_CBB);
            cbbPCategories.DataSource = dt;
            cbbPCategories.DisplayMember = "NameCategory";
            cbbPCategories.ValueMember = "Id";
        }

        private void clearDataProduct()
        {
            txtPColor.Clear();
            txtPDescription.Clear();
            txtPName.Clear();
            txtPPrice.Value = 0;
            txtPQuantity.Value = 0;
            txtPSize.Clear();
            btnPEdit.Enabled = false;
            btnPDel.Enabled = false;
            btnPAdd.Enabled = true;
            cbbPCategories.SelectedIndex = 0;


        }

        private void btnPAdd_Click_1(object sender, EventArgs e)
        {
            ProductBean productBean = new ProductBean();
            productBean.id = Guid.NewGuid().ToString();
            productBean.idCategory = (string)cbbPCategories.SelectedValue;
            productBean.nameProduct = txtPName.Text;
            productBean.color = txtPColor.Text;
            productBean.size = txtPSize.Text;
            productBean.price = (double)txtPPrice.Value;
            productBean.quantity = (int)txtPQuantity.Value;
            productBean.createdDate = DateTime.Now;
            productBean.description = txtPDescription.Text;
            bool flag = Product.saveOrUpdateProduct(productBean, Constants.ACTION_ADD);
            if (flag)
            {
                loadDataProduct();
                clearDataProduct();
            }
            else
            {
                MessageBox.Show("Thêm mới không thành công!!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void dataPView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataPView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                btnPEdit.Enabled = true;
                btnPDel.Enabled = true;
                btnPAdd.Enabled = false;
                txtPName.Text = dataPView.Rows[e.RowIndex].Cells["PNameProduct"].FormattedValue.ToString();
                txtPDescription.Text = dataPView.Rows[e.RowIndex].Cells["PDescription"].FormattedValue.ToString();
                txtPColor.Text = dataPView.Rows[e.RowIndex].Cells["PColor"].FormattedValue.ToString();
                cbbPCategories.SelectedValue = dataPView.Rows[e.RowIndex].Cells["IdCategory"].FormattedValue.ToString();
                txtPId.Text = dataPView.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                txtPSize.Text = dataPView.Rows[e.RowIndex].Cells["PSize"].FormattedValue.ToString();
                txtPQuantity.Value = int.Parse(dataPView.Rows[e.RowIndex].Cells["PQuantity"].FormattedValue.ToString());
                txtPPrice.Value = decimal.Parse(dataPView.Rows[e.RowIndex].Cells["PPrice"].FormattedValue.ToString());
            }
        }

        private void btnPLoad_Click(object sender, EventArgs e)
        {
            loadDataProduct();
            customCbbCategoryForProduct();
        }

        private void btnPEdit_Click(object sender, EventArgs e)
        {
            ProductBean productBean = new ProductBean();
            productBean.id = txtPId.Text;
            productBean.idCategory = (string)cbbPCategories.SelectedValue;
            productBean.nameProduct = txtPName.Text;
            productBean.color = txtPColor.Text;
            productBean.size = txtPSize.Text;
            productBean.price = (double)txtPPrice.Value;
            productBean.quantity = (int)txtPQuantity.Value;
            productBean.description = txtPDescription.Text;
            bool flag = Product.saveOrUpdateProduct(productBean, Constants.ACTION_UPDATE);
            if (flag)
            {
                loadDataProduct();
                clearDataProduct();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnPClear_Click(object sender, EventArgs e)
        {
            clearDataProduct();
        }

        private void btnPDel_Click(object sender, EventArgs e)
        {
            string guid = txtPId.Text;
            bool flag = Product.delProductById(guid);
            if (flag)
            {
                loadDataProduct();
                clearDataProduct();
            }
            else
            {
                MessageBox.Show("Xóa không thành công!!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnPSearch_Click(object sender, EventArgs e)
        {
            ProductBean bean = new ProductBean();
            bean.idCategory = (string)cbbPCategories.SelectedValue;
            if (!String.IsNullOrEmpty(txtPName.Text))
            {
                bean.nameProduct = txtPName.Text;
            }
            if (!String.IsNullOrEmpty(txtPColor.Text))
            {
                bean.color = txtPColor.Text;
            }
            if (!String.IsNullOrEmpty(txtPDescription.Text))
            {
                bean.description = txtPDescription.Text;
            }
            DataTable dt = Product.seachProduct(bean);
            dataPView.DataSource = dt;
            dataPView.Columns["Id"].Visible = false;
            dataPView.Columns["IdCategory"].Visible = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataPView.Rows[i].Cells["PSTT"].Value = i + 1;
            }
        }



        private void dataViewBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataViewBill.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                btnBDel.Enabled = true;
                txtBId.Text = dataViewBill.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
            }
        }


        private void dataViewBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                FormDetail frmDetail = new FormDetail(txtBId.Text);
                frmDetail.ShowDialog();
            }
        }

        private void btnRAdd_Click(object sender, EventArgs e)
        {
            ReceiptSlipBean bean = new ReceiptSlipBean();
            bean.Id = Guid.NewGuid().ToString();
            bean.NameCustomer = txtRNameCustomer.Text;
            bean.Address = txtRAddress.Text;
            bean.RecevingTime = rRecevingTime.Value;
            bean.Recevier = txtRRecevier.Text;
            bean.PayTime = rPayTime.Value;
            bool flag = ReceiptSlip.saveOrUpdateReceiptSlip(bean, true);
            if (flag)
            {
                loadDataReceiptSlip();
                clearDataReceiptSlip();
            }
            else
            {
                MessageBox.Show("Thêm mới không thành công!!", "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void clearDataReceiptSlip()
        {
            txtRNameCustomer.Clear();
            txtRRecevier.Clear();
            txtRAddress.Clear();
            txtRId.Clear();
            rRecevingTime.Value = DateTime.Now;
            rPayTime.Value = DateTime.Now;
            btnRDel.Enabled = false;
            btnREdit.Enabled = false;
            btnRAdd.Enabled = true;
        }

        private void btnRLoad_Click(object sender, EventArgs e)
        {
            loadDataReceiptSlip();
        }

        private void loadDataReceiptSlip()
        {
            DataTable dt = ReceiptSlip.getDataReceiptSlip(new ReceiptSlipBean());
            dataViewReceiptSlip.DataSource = dt;
            dataViewReceiptSlip.Columns["Id"].Visible = false;
            dataViewReceiptSlip.Columns["RLRecevingTime"].DefaultCellStyle.Format = "d";
            dataViewReceiptSlip.Columns["RLPayTime"].DefaultCellStyle.Format = "d";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataViewReceiptSlip.Rows[i].Cells["RSTT"].Value = i + 1;
            }
        }

        private void btnRDel_Click(object sender, EventArgs e)
        {
            string guid = txtRId.Text;
            bool flag = ReceiptSlip.delReceiptSlipId(guid);
            if (flag)
            {
                loadDataReceiptSlip();
                clearDataReceiptSlip();
            }
            else
            {
                MessageBox.Show("Xóa không thành công!!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void dataViewReceiptSlip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataViewReceiptSlip.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                btnRDel.Enabled = true;
                btnREdit.Enabled = true;
                btnRAdd.Enabled = false;
                txtRId.Text = dataViewReceiptSlip.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                txtRNameCustomer.Text = dataViewReceiptSlip.Rows[e.RowIndex].Cells["RNameCustomer"].FormattedValue.ToString();
                txtRRecevier.Text = dataViewReceiptSlip.Rows[e.RowIndex].Cells["RRecevier"].FormattedValue.ToString();
                txtRAddress.Text = dataViewReceiptSlip.Rows[e.RowIndex].Cells["RAddress"].FormattedValue.ToString();
                rPayTime.Value = Convert.ToDateTime(dataViewReceiptSlip.Rows[e.RowIndex].Cells["RLPayTime"].Value);
                rRecevingTime.Value = Convert.ToDateTime(dataViewReceiptSlip.Rows[e.RowIndex].Cells["RLRecevingTime"].Value);
            }
        }

        private void btnRClear_Click(object sender, EventArgs e)
        {
            clearDataReceiptSlip();
        }

        private void btnRSearch_Click(object sender, EventArgs e)
        {
            ReceiptSlipBean bean = new ReceiptSlipBean();
            bean.NameCustomer = txtRNameCustomer.Text;
            DataTable dt = ReceiptSlip.getDataReceiptSlip(bean);
            dataViewReceiptSlip.DataSource = dt;
            dataViewReceiptSlip.Columns["Id"].Visible = false;
            dataViewReceiptSlip.Columns["RLRecevingTime"].DefaultCellStyle.Format = "d";
            dataViewReceiptSlip.Columns["RLPayTime"].DefaultCellStyle.Format = "d";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataViewReceiptSlip.Rows[i].Cells["RSTT"].Value = i + 1;
            }

        }

        private void btnREdit_Click(object sender, EventArgs e)
        {
            ReceiptSlipBean bean = new ReceiptSlipBean();
            bean.Id = txtRId.Text;
            bean.NameCustomer = txtRNameCustomer.Text;
            bean.Address = txtRAddress.Text;
            bean.RecevingTime = rRecevingTime.Value;
            bean.Recevier = txtRRecevier.Text;
            bean.PayTime = rPayTime.Value;
            bool flag = ReceiptSlip.saveOrUpdateReceiptSlip(bean, false);
            if (flag)
            {
                loadDataReceiptSlip();
                clearDataReceiptSlip();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnELoad_Click(object sender, EventArgs e)
        {
            loadDataEquipmentNeedWarrayty();
        }

        private void loadDataEquipmentNeedWarrayty()
        {
            DataTable dt = EquipmentNeedWarrayty.getDataEquipmentNeedWarrayty(new EquipmentNeedWarraytyBean());
            dataViewEquipmentNeedWarrayty.DataSource = dt;
            dataViewEquipmentNeedWarrayty.Columns["Id"].Visible = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataViewEquipmentNeedWarrayty.Rows[i].Cells["ESTT"].Value = i + 1;
            }
        }

        private void clearDataEquipmentNeedWarrayty()
        {
            txtENameProduct.Clear();
            txtEStatus.Clear();
            txtEDescription.Clear();
            btnEAdd.Enabled = true;
            btnEEdit.Enabled = false;
            btnEDel.Enabled = false;
        }

        private void btnEAdd_Click(object sender, EventArgs e)
        {
            EquipmentNeedWarraytyBean bean = new EquipmentNeedWarraytyBean();
            bean.Id = Guid.NewGuid().ToString();
            bean.NameProduct = txtENameProduct.Text;
            bean.Status = txtEStatus.Text;
            bean.Description = txtEDescription.Text;
            bool flag = EquipmentNeedWarrayty.saveOrUpdateEquipmentNeedWarrayty(bean, true);
            if (flag)
            {
                loadDataEquipmentNeedWarrayty();
                clearDataEquipmentNeedWarrayty();
            }
            else
            {
                MessageBox.Show("Thêm mới không thành công!!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnEEdit_Click(object sender, EventArgs e)
        {
            EquipmentNeedWarraytyBean bean = new EquipmentNeedWarraytyBean();
            bean.Id = txtEId.Text;
            bean.NameProduct = txtENameProduct.Text;
            bean.Status = txtEStatus.Text;
            bean.Description = txtEDescription.Text;
            bool flag = EquipmentNeedWarrayty.saveOrUpdateEquipmentNeedWarrayty(bean, false);
            if (flag)
            {
                loadDataEquipmentNeedWarrayty();
                clearDataEquipmentNeedWarrayty();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void dataViewEquipmentNeedWarrayty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataViewEquipmentNeedWarrayty.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                btnEDel.Enabled = true;
                btnEEdit.Enabled = true;
                btnEAdd.Enabled = false;
                txtEId.Text = dataViewEquipmentNeedWarrayty.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                txtENameProduct.Text = dataViewEquipmentNeedWarrayty.Rows[e.RowIndex].Cells["ENameProduct"].FormattedValue.ToString();
                txtEStatus.Text = dataViewEquipmentNeedWarrayty.Rows[e.RowIndex].Cells["EStatus"].FormattedValue.ToString();
                txtEDescription.Text = dataViewEquipmentNeedWarrayty.Rows[e.RowIndex].Cells["EDescription"].FormattedValue.ToString();
            }
        }

        private void btnEDel_Click(object sender, EventArgs e)
        {
            string guid = txtEId.Text;
            bool flag = EquipmentNeedWarrayty.delEquipmentNeedWarraytyId(guid);
            if (flag)
            {
                loadDataEquipmentNeedWarrayty();
                clearDataEquipmentNeedWarrayty();
            }
            else
            {
                MessageBox.Show("Xóa không thành công!!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnEClear_Click(object sender, EventArgs e)
        {
            clearDataEquipmentNeedWarrayty();
        }

        private void btnESearch_Click(object sender, EventArgs e)
        {
            EquipmentNeedWarraytyBean bean = new EquipmentNeedWarraytyBean();
            bean.NameProduct = txtENameProduct.Text;
            DataTable dt = EquipmentNeedWarrayty.getDataEquipmentNeedWarrayty(bean);
            dataViewEquipmentNeedWarrayty.DataSource = dt;
            dataViewEquipmentNeedWarrayty.Columns["Id"].Visible = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataViewEquipmentNeedWarrayty.Rows[i].Cells["ESTT"].Value = i + 1;
            }

        }


        private void clearDataRepairLog()
        {
            txtRLNameEquipment.Clear();
            txtRLRepaier.Clear();
            txtRLSolution.Clear();
            rlFixDate.Value = DateTime.Now;
            rlRepairDate.Value = DateTime.Now;
            btnRlAdd.Enabled = true;
            btnRlDel.Enabled = false;
            btnRLEdit.Enabled = false;

        }

        private void loadDataRepairLog()
        {
            DataTable dt = DataRepairLog.getDataDataRepairLog(new Model.RepairLogBean());
            dataViewRepairLog.DataSource = dt;
            dataViewRepairLog.Columns["Id"].Visible = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataViewRepairLog.Rows[i].Cells["RLSTT"].Value = i + 1;
            }
        }

        private void btnRlAdd_Click(object sender, EventArgs e)
        {
            Model.RepairLogBean bean = new Model.RepairLogBean();
            bean.Id = Guid.NewGuid().ToString();
            bean.NameProduct = txtRLNameEquipment.Text;
            bean.Repairer = txtRLRepaier.Text;
            bean.Solution = txtRLSolution.Text;
            bean.FixDate = rlFixDate.Value;
            bean.RepairDate = rlRepairDate.Value;
            bool flag = DataRepairLog.saveOrUpdateDataRepairLog(bean, true);
            if (flag)
            {
                loadDataRepairLog();
                clearDataRepairLog();
            }
            else
            {
                MessageBox.Show("Thêm mới không thành công!!", "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void btnRlLoad_Click(object sender, EventArgs e)
        {
            loadDataRepairLog();
        }

        private void btnRlSearch_Click(object sender, EventArgs e)
        {
            RepairLogBean bean = new RepairLogBean();
            bean.NameProduct = txtRLNameEquipment.Text;
            DataTable dt = DataRepairLog.getDataDataRepairLog(bean);
            dataViewRepairLog.DataSource = dt;
            dataViewRepairLog.Columns["Id"].Visible = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataViewRepairLog.Rows[i].Cells["RLSTT"].Value = i + 1;
            }
        }

        private void btnRlDel_Click(object sender, EventArgs e)
        {
            string guid = txtRLId.Text;
            bool flag = DataRepairLog.delRepairLogId(guid);
            if (flag)
            {
                loadDataRepairLog();
                clearDataRepairLog();
            }
            else
            {
                MessageBox.Show("Xóa không thành công!!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnRLEdit_Click(object sender, EventArgs e)
        {
            RepairLogBean bean = new RepairLogBean();
            bean.Id = txtRLId.Text;
            bean.NameProduct = txtRLNameEquipment.Text;
            bean.Repairer = txtRLRepaier.Text;
            bean.Solution = txtRLSolution.Text;
            bean.FixDate = rlFixDate.Value;
            bean.RepairDate = rlRepairDate.Value;
            bool flag = DataRepairLog.saveOrUpdateDataRepairLog(bean, false);
            if (flag)
            {
                loadDataRepairLog();
                clearDataRepairLog();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void dataViewRepairLog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataViewRepairLog.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                btnRlDel.Enabled = true;
                btnRLEdit.Enabled = true;
                btnRlAdd.Enabled = false;
                txtRLId.Text = dataViewRepairLog.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                txtRLNameEquipment.Text = dataViewRepairLog.Rows[e.RowIndex].Cells["RLEquipment"].FormattedValue.ToString();
                txtRLRepaier.Text = dataViewRepairLog.Rows[e.RowIndex].Cells["RLRepaier"].FormattedValue.ToString();
                txtRLSolution.Text = dataViewRepairLog.Rows[e.RowIndex].Cells["RLSolution"].FormattedValue.ToString();
                rlFixDate.Value = Convert.ToDateTime(dataViewRepairLog.Rows[e.RowIndex].Cells["vRLFixDate"].Value);
                rlRepairDate.Value = Convert.ToDateTime(dataViewRepairLog.Rows[e.RowIndex].Cells["vRLRepairDate"].Value);
            }
        }

        private void btnRlClear_Click(object sender, EventArgs e)
        {
            clearDataRepairLog();
        }


        private void loadDataBill()
        {

            DataTable dt = Bills.getDataBill(new BillBean());
            dataViewBill.DataSource = dt;
            dataViewBill.Columns["Id"].Visible = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataViewBill.Rows[i].Cells["HSTT"].Value = i + 1;
                dataViewBill.Rows[i].Cells["HDetail"].Value = "Chi tiết";
            }
        }
        private void btnBDel_Click(object sender, EventArgs e)
        {
            string guid = txtBId.Text;
            bool flag = Bills.delBillId(guid);
            if (flag)
            {
                loadDataBill();
                clearDataBill();
            }
            else
            {
                MessageBox.Show("Xóa không thành công!!", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void clearDataBill()
        {
            txtHBiller.Clear();
            txtHNameCustomer.Clear();
            btnBDel.Enabled = false;
        }

        private void btnHLoadData_Click(object sender, EventArgs e)
        {
            loadDataBill();
        }

        private void btnBClear_Click(object sender, EventArgs e)
        {
            clearDataBill();
        }

        private void btnBLoad_Click(object sender, EventArgs e)
        {
            BillBean bean = new BillBean();
            bean.Biller = txtHBiller.Text;
            bean.NameCustomer = txtHNameCustomer.Text;
            DataTable dt = Bills.getDataBill(bean);
            dataViewBill.DataSource = dt;
            dataViewBill.Columns["Id"].Visible = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataViewBill.Rows[i].Cells["HSTT"].Value = i + 1;
                dataViewBill.Rows[i].Cells["HDetail"].Value = "Chi tiết";

            }
        }
    }
}
