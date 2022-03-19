
using System.Windows.Forms;

namespace SaleManager
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCategories = new System.Windows.Forms.TabPage();
            this.btnClearCategory = new System.Windows.Forms.Button();
            this.lblIdCategory = new System.Windows.Forms.Label();
            this.txtIdCategory = new System.Windows.Forms.TextBox();
            this.cbbStatusCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnDelCategory = new System.Windows.Forms.Button();
            this.dataViewCategories = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.txtPId = new System.Windows.Forms.TextBox();
            this.btnPLoad = new System.Windows.Forms.Button();
            this.txtPPrice = new System.Windows.Forms.NumericUpDown();
            this.txtPQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtPSize = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPClear = new System.Windows.Forms.Button();
            this.btnPSearch = new System.Windows.Forms.Button();
            this.btnPDel = new System.Windows.Forms.Button();
            this.btnPEdit = new System.Windows.Forms.Button();
            this.btnPAdd = new System.Windows.Forms.Button();
            this.dataPView = new System.Windows.Forms.DataGridView();
            this.PSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PNameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PNameCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbPCategories = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabBill = new System.Windows.Forms.TabPage();
            this.txtBId = new System.Windows.Forms.TextBox();
            this.btnHLoadData = new System.Windows.Forms.Button();
            this.btnBClear = new System.Windows.Forms.Button();
            this.btnBLoad = new System.Windows.Forms.Button();
            this.btnBDel = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHNameCustomer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHBiller = new System.Windows.Forms.TextBox();
            this.dataViewBill = new System.Windows.Forms.DataGridView();
            this.HSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HBiller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HTotalMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabReceiptSlip = new System.Windows.Forms.TabPage();
            this.btnRLoad = new System.Windows.Forms.Button();
            this.txtRId = new System.Windows.Forms.TextBox();
            this.rRecevingTime = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dataViewReceiptSlip = new System.Windows.Forms.DataGridView();
            this.RSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNameCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RRecevier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLRecevingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLPayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRClear = new System.Windows.Forms.Button();
            this.btnRSearch = new System.Windows.Forms.Button();
            this.btnREdit = new System.Windows.Forms.Button();
            this.btnRDel = new System.Windows.Forms.Button();
            this.btnRAdd = new System.Windows.Forms.Button();
            this.rPayTime = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRRecevier = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtRAddress = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtRNameCustomer = new System.Windows.Forms.TextBox();
            this.tabEquipmentNeedWarrayty = new System.Windows.Forms.TabPage();
            this.txtEId = new System.Windows.Forms.TextBox();
            this.btnELoad = new System.Windows.Forms.Button();
            this.dataViewEquipmentNeedWarrayty = new System.Windows.Forms.DataGridView();
            this.ESTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEClear = new System.Windows.Forms.Button();
            this.btnESearch = new System.Windows.Forms.Button();
            this.btnEEdit = new System.Windows.Forms.Button();
            this.btnEDel = new System.Windows.Forms.Button();
            this.btnEAdd = new System.Windows.Forms.Button();
            this.txtEDescription = new System.Windows.Forms.TextBox();
            this.txtEStatus = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtENameProduct = new System.Windows.Forms.TextBox();
            this.tabRepairLog = new System.Windows.Forms.TabPage();
            this.txtRLId = new System.Windows.Forms.TextBox();
            this.btnRlLoad = new System.Windows.Forms.Button();
            this.dataViewRepairLog = new System.Windows.Forms.DataGridView();
            this.RLSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLEquipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLRepaier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLSolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vRLFixDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vRLRepairDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRlClear = new System.Windows.Forms.Button();
            this.btnRlSearch = new System.Windows.Forms.Button();
            this.btnRLEdit = new System.Windows.Forms.Button();
            this.btnRlDel = new System.Windows.Forms.Button();
            this.btnRlAdd = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.txtRLSolution = new System.Windows.Forms.TextBox();
            this.rlRepairDate = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.rlFixDate = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtRLRepaier = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtRLNameEquipment = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewCategories)).BeginInit();
            this.tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPView)).BeginInit();
            this.tabBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewBill)).BeginInit();
            this.tabReceiptSlip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewReceiptSlip)).BeginInit();
            this.tabEquipmentNeedWarrayty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewEquipmentNeedWarrayty)).BeginInit();
            this.tabRepairLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewRepairLog)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCategories);
            this.tabControl1.Controls.Add(this.tabProduct);
            this.tabControl1.Controls.Add(this.tabBill);
            this.tabControl1.Controls.Add(this.tabReceiptSlip);
            this.tabControl1.Controls.Add(this.tabEquipmentNeedWarrayty);
            this.tabControl1.Controls.Add(this.tabRepairLog);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 392);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCategories
            // 
            this.tabCategories.Controls.Add(this.btnClearCategory);
            this.tabCategories.Controls.Add(this.lblIdCategory);
            this.tabCategories.Controls.Add(this.txtIdCategory);
            this.tabCategories.Controls.Add(this.cbbStatusCategory);
            this.tabCategories.Controls.Add(this.label3);
            this.tabCategories.Controls.Add(this.btnEditCategory);
            this.tabCategories.Controls.Add(this.btnAddCategory);
            this.tabCategories.Controls.Add(this.btnDelCategory);
            this.tabCategories.Controls.Add(this.dataViewCategories);
            this.tabCategories.Controls.Add(this.txtSupplier);
            this.tabCategories.Controls.Add(this.label2);
            this.tabCategories.Controls.Add(this.txtNameCategory);
            this.tabCategories.Controls.Add(this.label1);
            this.tabCategories.Location = new System.Drawing.Point(4, 22);
            this.tabCategories.Name = "tabCategories";
            this.tabCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategories.Size = new System.Drawing.Size(676, 366);
            this.tabCategories.TabIndex = 0;
            this.tabCategories.Text = "Loại Sản Phẩm";
            this.tabCategories.UseVisualStyleBackColor = true;
            // 
            // btnClearCategory
            // 
            this.btnClearCategory.Location = new System.Drawing.Point(437, 92);
            this.btnClearCategory.Name = "btnClearCategory";
            this.btnClearCategory.Size = new System.Drawing.Size(64, 20);
            this.btnClearCategory.TabIndex = 12;
            this.btnClearCategory.Text = "Thiết lặp lại";
            this.btnClearCategory.UseVisualStyleBackColor = true;
            this.btnClearCategory.Click += new System.EventHandler(this.btnClearCategory_Click);
            // 
            // lblIdCategory
            // 
            this.lblIdCategory.AutoSize = true;
            this.lblIdCategory.Location = new System.Drawing.Point(414, 59);
            this.lblIdCategory.Name = "lblIdCategory";
            this.lblIdCategory.Size = new System.Drawing.Size(29, 13);
            this.lblIdCategory.TabIndex = 11;
            this.lblIdCategory.Text = "Guid";
            this.lblIdCategory.Visible = false;
            // 
            // txtIdCategory
            // 
            this.txtIdCategory.Location = new System.Drawing.Point(452, 52);
            this.txtIdCategory.Name = "txtIdCategory";
            this.txtIdCategory.ReadOnly = true;
            this.txtIdCategory.Size = new System.Drawing.Size(160, 20);
            this.txtIdCategory.TabIndex = 10;
            this.txtIdCategory.Visible = false;
            // 
            // cbbStatusCategory
            // 
            this.cbbStatusCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatusCategory.FormattingEnabled = true;
            this.cbbStatusCategory.Location = new System.Drawing.Point(107, 56);
            this.cbbStatusCategory.Name = "cbbStatusCategory";
            this.cbbStatusCategory.Size = new System.Drawing.Size(160, 21);
            this.cbbStatusCategory.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Trạng thái";
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Enabled = false;
            this.btnEditCategory.Location = new System.Drawing.Point(267, 92);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(64, 20);
            this.btnEditCategory.TabIndex = 7;
            this.btnEditCategory.Text = "Sửa";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(179, 92);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(64, 20);
            this.btnAddCategory.TabIndex = 6;
            this.btnAddCategory.Text = "Thêm mới";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnDelCategory
            // 
            this.btnDelCategory.Enabled = false;
            this.btnDelCategory.Location = new System.Drawing.Point(354, 92);
            this.btnDelCategory.Name = "btnDelCategory";
            this.btnDelCategory.Size = new System.Drawing.Size(64, 20);
            this.btnDelCategory.TabIndex = 5;
            this.btnDelCategory.Text = "Xoá";
            this.btnDelCategory.UseVisualStyleBackColor = true;
            this.btnDelCategory.Click += new System.EventHandler(this.btnDelCategory_Click);
            // 
            // dataViewCategories
            // 
            this.dataViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.NameCategory,
            this.NameSupplier,
            this.Status});
            this.dataViewCategories.Location = new System.Drawing.Point(3, 137);
            this.dataViewCategories.Name = "dataViewCategories";
            this.dataViewCategories.RowTemplate.Height = 25;
            this.dataViewCategories.Size = new System.Drawing.Size(672, 225);
            this.dataViewCategories.TabIndex = 4;
            this.dataViewCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewCategories_CellClick);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // NameCategory
            // 
            this.NameCategory.DataPropertyName = "NameCategory";
            this.NameCategory.HeaderText = "Tên Loại Sản Phẩm";
            this.NameCategory.Name = "NameCategory";
            this.NameCategory.Width = 200;
            // 
            // NameSupplier
            // 
            this.NameSupplier.DataPropertyName = "NameSupplier";
            this.NameSupplier.HeaderText = "Tên Nhà Cung Cấp";
            this.NameSupplier.Name = "NameSupplier";
            this.NameSupplier.Width = 200;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Trạng Thái";
            this.Status.Name = "Status";
            this.Status.Width = 150;
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(452, 16);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(160, 20);
            this.txtSupplier.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.Location = new System.Drawing.Point(107, 16);
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.Size = new System.Drawing.Size(160, 20);
            this.txtNameCategory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Loại Sản Phẩm";
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.txtPId);
            this.tabProduct.Controls.Add(this.btnPLoad);
            this.tabProduct.Controls.Add(this.txtPPrice);
            this.tabProduct.Controls.Add(this.txtPQuantity);
            this.tabProduct.Controls.Add(this.txtPSize);
            this.tabProduct.Controls.Add(this.label10);
            this.tabProduct.Controls.Add(this.btnPClear);
            this.tabProduct.Controls.Add(this.btnPSearch);
            this.tabProduct.Controls.Add(this.btnPDel);
            this.tabProduct.Controls.Add(this.btnPEdit);
            this.tabProduct.Controls.Add(this.btnPAdd);
            this.tabProduct.Controls.Add(this.dataPView);
            this.tabProduct.Controls.Add(this.label9);
            this.tabProduct.Controls.Add(this.label8);
            this.tabProduct.Controls.Add(this.txtPDescription);
            this.tabProduct.Controls.Add(this.label7);
            this.tabProduct.Controls.Add(this.cbbPCategories);
            this.tabProduct.Controls.Add(this.label6);
            this.tabProduct.Controls.Add(this.txtPColor);
            this.tabProduct.Controls.Add(this.label5);
            this.tabProduct.Controls.Add(this.txtPName);
            this.tabProduct.Controls.Add(this.label4);
            this.tabProduct.Location = new System.Drawing.Point(4, 22);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(676, 366);
            this.tabProduct.TabIndex = 1;
            this.tabProduct.Text = "Sản Phẩm";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // txtPId
            // 
            this.txtPId.Enabled = false;
            this.txtPId.Location = new System.Drawing.Point(402, 154);
            this.txtPId.Name = "txtPId";
            this.txtPId.Size = new System.Drawing.Size(137, 20);
            this.txtPId.TabIndex = 23;
            this.txtPId.Visible = false;
            // 
            // btnPLoad
            // 
            this.btnPLoad.Location = new System.Drawing.Point(297, 163);
            this.btnPLoad.Name = "btnPLoad";
            this.btnPLoad.Size = new System.Drawing.Size(64, 20);
            this.btnPLoad.TabIndex = 22;
            this.btnPLoad.Text = "Load";
            this.btnPLoad.UseVisualStyleBackColor = true;
            this.btnPLoad.Click += new System.EventHandler(this.btnPLoad_Click);
            // 
            // txtPPrice
            // 
            this.txtPPrice.Location = new System.Drawing.Point(402, 114);
            this.txtPPrice.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.txtPPrice.Name = "txtPPrice";
            this.txtPPrice.Size = new System.Drawing.Size(135, 20);
            this.txtPPrice.TabIndex = 21;
            // 
            // txtPQuantity
            // 
            this.txtPQuantity.Location = new System.Drawing.Point(122, 116);
            this.txtPQuantity.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.txtPQuantity.Name = "txtPQuantity";
            this.txtPQuantity.Size = new System.Drawing.Size(135, 20);
            this.txtPQuantity.TabIndex = 20;
            // 
            // txtPSize
            // 
            this.txtPSize.Location = new System.Drawing.Point(121, 154);
            this.txtPSize.Name = "txtPSize";
            this.txtPSize.Size = new System.Drawing.Size(137, 20);
            this.txtPSize.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Kích thước";
            // 
            // btnPClear
            // 
            this.btnPClear.Location = new System.Drawing.Point(486, 188);
            this.btnPClear.Name = "btnPClear";
            this.btnPClear.Size = new System.Drawing.Size(64, 20);
            this.btnPClear.TabIndex = 17;
            this.btnPClear.Text = "Thiết lặp lại";
            this.btnPClear.UseVisualStyleBackColor = true;
            this.btnPClear.Click += new System.EventHandler(this.btnPClear_Click);
            // 
            // btnPSearch
            // 
            this.btnPSearch.Location = new System.Drawing.Point(388, 188);
            this.btnPSearch.Name = "btnPSearch";
            this.btnPSearch.Size = new System.Drawing.Size(64, 20);
            this.btnPSearch.TabIndex = 16;
            this.btnPSearch.Text = "Tìm kiếm";
            this.btnPSearch.UseVisualStyleBackColor = true;
            this.btnPSearch.Click += new System.EventHandler(this.btnPSearch_Click);
            // 
            // btnPDel
            // 
            this.btnPDel.Enabled = false;
            this.btnPDel.Location = new System.Drawing.Point(297, 188);
            this.btnPDel.Name = "btnPDel";
            this.btnPDel.Size = new System.Drawing.Size(64, 20);
            this.btnPDel.TabIndex = 15;
            this.btnPDel.Text = "Xóa";
            this.btnPDel.UseVisualStyleBackColor = true;
            this.btnPDel.Click += new System.EventHandler(this.btnPDel_Click);
            // 
            // btnPEdit
            // 
            this.btnPEdit.Enabled = false;
            this.btnPEdit.Location = new System.Drawing.Point(193, 188);
            this.btnPEdit.Name = "btnPEdit";
            this.btnPEdit.Size = new System.Drawing.Size(64, 20);
            this.btnPEdit.TabIndex = 14;
            this.btnPEdit.Text = "Sửa";
            this.btnPEdit.UseVisualStyleBackColor = true;
            this.btnPEdit.Click += new System.EventHandler(this.btnPEdit_Click);
            // 
            // btnPAdd
            // 
            this.btnPAdd.Location = new System.Drawing.Point(85, 188);
            this.btnPAdd.Name = "btnPAdd";
            this.btnPAdd.Size = new System.Drawing.Size(64, 20);
            this.btnPAdd.TabIndex = 13;
            this.btnPAdd.Text = "Thêm mới";
            this.btnPAdd.UseVisualStyleBackColor = true;
            this.btnPAdd.Click += new System.EventHandler(this.btnPAdd_Click_1);
            // 
            // dataPView
            // 
            this.dataPView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PSTT,
            this.PNameProduct,
            this.PNameCategory,
            this.PColor,
            this.PSize,
            this.PQuantity,
            this.PPrice,
            this.PDescription});
            this.dataPView.Location = new System.Drawing.Point(0, 221);
            this.dataPView.Name = "dataPView";
            this.dataPView.RowTemplate.Height = 25;
            this.dataPView.Size = new System.Drawing.Size(677, 144);
            this.dataPView.TabIndex = 12;
            this.dataPView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPView_CellClick);
            // 
            // PSTT
            // 
            this.PSTT.DataPropertyName = "PSTT";
            this.PSTT.HeaderText = "STT";
            this.PSTT.Name = "PSTT";
            this.PSTT.Width = 50;
            // 
            // PNameProduct
            // 
            this.PNameProduct.DataPropertyName = "NameProduct";
            this.PNameProduct.HeaderText = "Tên sản phẩm";
            this.PNameProduct.Name = "PNameProduct";
            this.PNameProduct.Width = 200;
            // 
            // PNameCategory
            // 
            this.PNameCategory.DataPropertyName = "NameCategory";
            this.PNameCategory.HeaderText = "Tên loại sản phẩm";
            this.PNameCategory.Name = "PNameCategory";
            this.PNameCategory.Width = 200;
            // 
            // PColor
            // 
            this.PColor.DataPropertyName = "Color";
            this.PColor.HeaderText = "Màu sắc";
            this.PColor.Name = "PColor";
            // 
            // PSize
            // 
            this.PSize.DataPropertyName = "Size";
            this.PSize.HeaderText = "Kích thước";
            this.PSize.Name = "PSize";
            // 
            // PQuantity
            // 
            this.PQuantity.DataPropertyName = "Quantity";
            this.PQuantity.HeaderText = "Số lượng";
            this.PQuantity.Name = "PQuantity";
            // 
            // PPrice
            // 
            this.PPrice.DataPropertyName = "Price";
            this.PPrice.HeaderText = "Giá bán";
            this.PPrice.Name = "PPrice";
            // 
            // PDescription
            // 
            this.PDescription.DataPropertyName = "Description";
            this.PDescription.HeaderText = "Mô tả";
            this.PDescription.Name = "PDescription";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Số lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Giá bán";
            // 
            // txtPDescription
            // 
            this.txtPDescription.Location = new System.Drawing.Point(401, 12);
            this.txtPDescription.Multiline = true;
            this.txtPDescription.Name = "txtPDescription";
            this.txtPDescription.Size = new System.Drawing.Size(137, 90);
            this.txtPDescription.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mô tả";
            // 
            // cbbPCategories
            // 
            this.cbbPCategories.FormattingEnabled = true;
            this.cbbPCategories.Location = new System.Drawing.Point(121, 48);
            this.cbbPCategories.Name = "cbbPCategories";
            this.cbbPCategories.Size = new System.Drawing.Size(137, 21);
            this.cbbPCategories.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Loại sản phẩm";
            // 
            // txtPColor
            // 
            this.txtPColor.Location = new System.Drawing.Point(121, 81);
            this.txtPColor.Name = "txtPColor";
            this.txtPColor.Size = new System.Drawing.Size(137, 20);
            this.txtPColor.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Color";
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(121, 12);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(137, 20);
            this.txtPName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Sản Phẩm";
            // 
            // tabBill
            // 
            this.tabBill.Controls.Add(this.txtBId);
            this.tabBill.Controls.Add(this.btnHLoadData);
            this.tabBill.Controls.Add(this.btnBClear);
            this.tabBill.Controls.Add(this.btnBLoad);
            this.tabBill.Controls.Add(this.btnBDel);
            this.tabBill.Controls.Add(this.label12);
            this.tabBill.Controls.Add(this.txtHNameCustomer);
            this.tabBill.Controls.Add(this.label11);
            this.tabBill.Controls.Add(this.txtHBiller);
            this.tabBill.Controls.Add(this.dataViewBill);
            this.tabBill.Location = new System.Drawing.Point(4, 22);
            this.tabBill.Name = "tabBill";
            this.tabBill.Size = new System.Drawing.Size(676, 366);
            this.tabBill.TabIndex = 2;
            this.tabBill.Text = "Hoá Đơn";
            this.tabBill.UseVisualStyleBackColor = true;
            // 
            // txtBId
            // 
            this.txtBId.Location = new System.Drawing.Point(135, 62);
            this.txtBId.Name = "txtBId";
            this.txtBId.Size = new System.Drawing.Size(131, 20);
            this.txtBId.TabIndex = 16;
            this.txtBId.Visible = false;
            // 
            // btnHLoadData
            // 
            this.btnHLoadData.Location = new System.Drawing.Point(110, 152);
            this.btnHLoadData.Name = "btnHLoadData";
            this.btnHLoadData.Size = new System.Drawing.Size(64, 20);
            this.btnHLoadData.TabIndex = 15;
            this.btnHLoadData.Text = "Load";
            this.btnHLoadData.UseVisualStyleBackColor = true;
            this.btnHLoadData.Click += new System.EventHandler(this.btnHLoadData_Click);
            // 
            // btnBClear
            // 
            this.btnBClear.Location = new System.Drawing.Point(447, 152);
            this.btnBClear.Name = "btnBClear";
            this.btnBClear.Size = new System.Drawing.Size(64, 20);
            this.btnBClear.TabIndex = 14;
            this.btnBClear.Text = "Thiết lặp lại";
            this.btnBClear.UseVisualStyleBackColor = true;
            this.btnBClear.Click += new System.EventHandler(this.btnBClear_Click);
            // 
            // btnBLoad
            // 
            this.btnBLoad.Location = new System.Drawing.Point(322, 152);
            this.btnBLoad.Name = "btnBLoad";
            this.btnBLoad.Size = new System.Drawing.Size(64, 20);
            this.btnBLoad.TabIndex = 13;
            this.btnBLoad.Text = "Tìm kiếm";
            this.btnBLoad.UseVisualStyleBackColor = true;
            this.btnBLoad.Click += new System.EventHandler(this.btnBLoad_Click);
            // 
            // btnBDel
            // 
            this.btnBDel.Enabled = false;
            this.btnBDel.Location = new System.Drawing.Point(213, 152);
            this.btnBDel.Name = "btnBDel";
            this.btnBDel.Size = new System.Drawing.Size(64, 20);
            this.btnBDel.TabIndex = 11;
            this.btnBDel.Text = "Xóa";
            this.btnBDel.UseVisualStyleBackColor = true;
            this.btnBDel.Click += new System.EventHandler(this.btnBDel_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(359, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Tên Khách Hàng";
            // 
            // txtHNameCustomer
            // 
            this.txtHNameCustomer.Location = new System.Drawing.Point(468, 23);
            this.txtHNameCustomer.Name = "txtHNameCustomer";
            this.txtHNameCustomer.Size = new System.Drawing.Size(131, 20);
            this.txtHNameCustomer.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Người Lập Hóa Đơn";
            // 
            // txtHBiller
            // 
            this.txtHBiller.Location = new System.Drawing.Point(135, 21);
            this.txtHBiller.Name = "txtHBiller";
            this.txtHBiller.Size = new System.Drawing.Size(131, 20);
            this.txtHBiller.TabIndex = 1;
            // 
            // dataViewBill
            // 
            this.dataViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HSTT,
            this.HBiller,
            this.HCustomerName,
            this.HTotalMoney,
            this.HCreatedDate,
            this.HDetail});
            this.dataViewBill.Location = new System.Drawing.Point(0, 205);
            this.dataViewBill.Name = "dataViewBill";
            this.dataViewBill.RowTemplate.Height = 25;
            this.dataViewBill.Size = new System.Drawing.Size(675, 159);
            this.dataViewBill.TabIndex = 0;
            this.dataViewBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewBill_CellClick);
            this.dataViewBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewBill_CellContentClick);
            // 
            // HSTT
            // 
            this.HSTT.DataPropertyName = "HSTT";
            this.HSTT.HeaderText = "STT";
            this.HSTT.Name = "HSTT";
            this.HSTT.Width = 50;
            // 
            // HBiller
            // 
            this.HBiller.DataPropertyName = "Biller";
            this.HBiller.HeaderText = "Người lập hóa đơn";
            this.HBiller.Name = "HBiller";
            this.HBiller.Width = 200;
            // 
            // HCustomerName
            // 
            this.HCustomerName.DataPropertyName = "NameCustomer";
            this.HCustomerName.HeaderText = "Tên khách hàng";
            this.HCustomerName.Name = "HCustomerName";
            this.HCustomerName.Width = 200;
            // 
            // HTotalMoney
            // 
            this.HTotalMoney.DataPropertyName = "TotalMoney";
            this.HTotalMoney.HeaderText = "Tổng tiền";
            this.HTotalMoney.Name = "HTotalMoney";
            // 
            // HCreatedDate
            // 
            this.HCreatedDate.DataPropertyName = "CreateDate";
            this.HCreatedDate.HeaderText = "Ngày lập hóa đơn";
            this.HCreatedDate.Name = "HCreatedDate";
            // 
            // HDetail
            // 
            this.HDetail.DataPropertyName = "HDetail";
            this.HDetail.HeaderText = "Hành Động";
            this.HDetail.Name = "HDetail";
            this.HDetail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HDetail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabReceiptSlip
            // 
            this.tabReceiptSlip.Controls.Add(this.btnRLoad);
            this.tabReceiptSlip.Controls.Add(this.txtRId);
            this.tabReceiptSlip.Controls.Add(this.rRecevingTime);
            this.tabReceiptSlip.Controls.Add(this.label13);
            this.tabReceiptSlip.Controls.Add(this.dataViewReceiptSlip);
            this.tabReceiptSlip.Controls.Add(this.btnRClear);
            this.tabReceiptSlip.Controls.Add(this.btnRSearch);
            this.tabReceiptSlip.Controls.Add(this.btnREdit);
            this.tabReceiptSlip.Controls.Add(this.btnRDel);
            this.tabReceiptSlip.Controls.Add(this.btnRAdd);
            this.tabReceiptSlip.Controls.Add(this.rPayTime);
            this.tabReceiptSlip.Controls.Add(this.label15);
            this.tabReceiptSlip.Controls.Add(this.label16);
            this.tabReceiptSlip.Controls.Add(this.txtRRecevier);
            this.tabReceiptSlip.Controls.Add(this.label17);
            this.tabReceiptSlip.Controls.Add(this.txtRAddress);
            this.tabReceiptSlip.Controls.Add(this.label18);
            this.tabReceiptSlip.Controls.Add(this.txtRNameCustomer);
            this.tabReceiptSlip.Location = new System.Drawing.Point(4, 22);
            this.tabReceiptSlip.Name = "tabReceiptSlip";
            this.tabReceiptSlip.Size = new System.Drawing.Size(676, 366);
            this.tabReceiptSlip.TabIndex = 3;
            this.tabReceiptSlip.Text = "Phiếu nhận";
            this.tabReceiptSlip.UseVisualStyleBackColor = true;
            // 
            // btnRLoad
            // 
            this.btnRLoad.Location = new System.Drawing.Point(317, 140);
            this.btnRLoad.Name = "btnRLoad";
            this.btnRLoad.Size = new System.Drawing.Size(64, 20);
            this.btnRLoad.TabIndex = 32;
            this.btnRLoad.Text = "Load";
            this.btnRLoad.UseVisualStyleBackColor = true;
            this.btnRLoad.Click += new System.EventHandler(this.btnRLoad_Click);
            // 
            // txtRId
            // 
            this.txtRId.Enabled = false;
            this.txtRId.Location = new System.Drawing.Point(112, 109);
            this.txtRId.Name = "txtRId";
            this.txtRId.Size = new System.Drawing.Size(131, 20);
            this.txtRId.TabIndex = 31;
            this.txtRId.Visible = false;
            // 
            // rRecevingTime
            // 
            this.rRecevingTime.Location = new System.Drawing.Point(435, 107);
            this.rRecevingTime.Name = "rRecevingTime";
            this.rRecevingTime.Size = new System.Drawing.Size(172, 20);
            this.rRecevingTime.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(344, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Thời Gian Nhận";
            // 
            // dataViewReceiptSlip
            // 
            this.dataViewReceiptSlip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewReceiptSlip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RSTT,
            this.RNameCustomer,
            this.RAddress,
            this.RRecevier,
            this.RLRecevingTime,
            this.RLPayTime});
            this.dataViewReceiptSlip.Location = new System.Drawing.Point(1, 197);
            this.dataViewReceiptSlip.Name = "dataViewReceiptSlip";
            this.dataViewReceiptSlip.RowTemplate.Height = 25;
            this.dataViewReceiptSlip.Size = new System.Drawing.Size(676, 168);
            this.dataViewReceiptSlip.TabIndex = 28;
            this.dataViewReceiptSlip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewReceiptSlip_CellClick);
            // 
            // RSTT
            // 
            this.RSTT.HeaderText = "STT";
            this.RSTT.Name = "RSTT";
            this.RSTT.Width = 50;
            // 
            // RNameCustomer
            // 
            this.RNameCustomer.DataPropertyName = "NameCustomer";
            this.RNameCustomer.HeaderText = "Khách hàng";
            this.RNameCustomer.Name = "RNameCustomer";
            this.RNameCustomer.Width = 150;
            // 
            // RAddress
            // 
            this.RAddress.DataPropertyName = "Address";
            this.RAddress.HeaderText = "Địa chỉ";
            this.RAddress.Name = "RAddress";
            this.RAddress.Width = 200;
            // 
            // RRecevier
            // 
            this.RRecevier.DataPropertyName = "Receiver";
            this.RRecevier.HeaderText = "Người nhận";
            this.RRecevier.Name = "RRecevier";
            this.RRecevier.Width = 150;
            // 
            // RLRecevingTime
            // 
            this.RLRecevingTime.DataPropertyName = "ReceivingTime";
            this.RLRecevingTime.HeaderText = "Thời gian nhận";
            this.RLRecevingTime.Name = "RLRecevingTime";
            // 
            // RLPayTime
            // 
            this.RLPayTime.DataPropertyName = "PayTime";
            this.RLPayTime.HeaderText = "Thời gian trả";
            this.RLPayTime.Name = "RLPayTime";
            // 
            // btnRClear
            // 
            this.btnRClear.Location = new System.Drawing.Point(542, 140);
            this.btnRClear.Name = "btnRClear";
            this.btnRClear.Size = new System.Drawing.Size(64, 20);
            this.btnRClear.TabIndex = 27;
            this.btnRClear.Text = "Thiết lặp lại";
            this.btnRClear.UseVisualStyleBackColor = true;
            this.btnRClear.Click += new System.EventHandler(this.btnRClear_Click);
            // 
            // btnRSearch
            // 
            this.btnRSearch.Location = new System.Drawing.Point(417, 140);
            this.btnRSearch.Name = "btnRSearch";
            this.btnRSearch.Size = new System.Drawing.Size(64, 20);
            this.btnRSearch.TabIndex = 26;
            this.btnRSearch.Text = "Tìm kiếm";
            this.btnRSearch.UseVisualStyleBackColor = true;
            this.btnRSearch.Click += new System.EventHandler(this.btnRSearch_Click);
            // 
            // btnREdit
            // 
            this.btnREdit.Enabled = false;
            this.btnREdit.Location = new System.Drawing.Point(129, 140);
            this.btnREdit.Name = "btnREdit";
            this.btnREdit.Size = new System.Drawing.Size(64, 20);
            this.btnREdit.TabIndex = 25;
            this.btnREdit.Text = "Sửa";
            this.btnREdit.UseVisualStyleBackColor = true;
            this.btnREdit.Click += new System.EventHandler(this.btnREdit_Click);
            // 
            // btnRDel
            // 
            this.btnRDel.Enabled = false;
            this.btnRDel.Location = new System.Drawing.Point(229, 140);
            this.btnRDel.Name = "btnRDel";
            this.btnRDel.Size = new System.Drawing.Size(64, 20);
            this.btnRDel.TabIndex = 24;
            this.btnRDel.Text = "Xóa";
            this.btnRDel.UseVisualStyleBackColor = true;
            this.btnRDel.Click += new System.EventHandler(this.btnRDel_Click);
            // 
            // btnRAdd
            // 
            this.btnRAdd.Location = new System.Drawing.Point(41, 140);
            this.btnRAdd.Name = "btnRAdd";
            this.btnRAdd.Size = new System.Drawing.Size(64, 20);
            this.btnRAdd.TabIndex = 23;
            this.btnRAdd.Text = "Thêm mới";
            this.btnRAdd.UseVisualStyleBackColor = true;
            this.btnRAdd.Click += new System.EventHandler(this.btnRAdd_Click);
            // 
            // rPayTime
            // 
            this.rPayTime.Location = new System.Drawing.Point(437, 62);
            this.rPayTime.Name = "rPayTime";
            this.rPayTime.Size = new System.Drawing.Size(172, 20);
            this.rPayTime.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(346, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Thời Gian Trả";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(346, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Người Nhận";
            // 
            // txtRRecevier
            // 
            this.txtRRecevier.Location = new System.Drawing.Point(437, 18);
            this.txtRRecevier.Name = "txtRRecevier";
            this.txtRRecevier.Size = new System.Drawing.Size(172, 20);
            this.txtRRecevier.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Tên Khách Hàng";
            // 
            // txtRAddress
            // 
            this.txtRAddress.Location = new System.Drawing.Point(112, 62);
            this.txtRAddress.Name = "txtRAddress";
            this.txtRAddress.Size = new System.Drawing.Size(131, 20);
            this.txtRAddress.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(30, 65);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "Địa Chỉ";
            // 
            // txtRNameCustomer
            // 
            this.txtRNameCustomer.Location = new System.Drawing.Point(112, 14);
            this.txtRNameCustomer.Name = "txtRNameCustomer";
            this.txtRNameCustomer.Size = new System.Drawing.Size(131, 20);
            this.txtRNameCustomer.TabIndex = 15;
            // 
            // tabEquipmentNeedWarrayty
            // 
            this.tabEquipmentNeedWarrayty.Controls.Add(this.txtEId);
            this.tabEquipmentNeedWarrayty.Controls.Add(this.btnELoad);
            this.tabEquipmentNeedWarrayty.Controls.Add(this.dataViewEquipmentNeedWarrayty);
            this.tabEquipmentNeedWarrayty.Controls.Add(this.btnEClear);
            this.tabEquipmentNeedWarrayty.Controls.Add(this.btnESearch);
            this.tabEquipmentNeedWarrayty.Controls.Add(this.btnEEdit);
            this.tabEquipmentNeedWarrayty.Controls.Add(this.btnEDel);
            this.tabEquipmentNeedWarrayty.Controls.Add(this.btnEAdd);
            this.tabEquipmentNeedWarrayty.Controls.Add(this.txtEDescription);
            this.tabEquipmentNeedWarrayty.Controls.Add(this.txtEStatus);
            this.tabEquipmentNeedWarrayty.Controls.Add(this.label21);
            this.tabEquipmentNeedWarrayty.Controls.Add(this.label20);
            this.tabEquipmentNeedWarrayty.Controls.Add(this.label19);
            this.tabEquipmentNeedWarrayty.Controls.Add(this.txtENameProduct);
            this.tabEquipmentNeedWarrayty.Location = new System.Drawing.Point(4, 22);
            this.tabEquipmentNeedWarrayty.Name = "tabEquipmentNeedWarrayty";
            this.tabEquipmentNeedWarrayty.Size = new System.Drawing.Size(676, 366);
            this.tabEquipmentNeedWarrayty.TabIndex = 4;
            this.tabEquipmentNeedWarrayty.Text = "Thiết Bị Cần Bảo Hành";
            this.tabEquipmentNeedWarrayty.UseVisualStyleBackColor = true;
            // 
            // txtEId
            // 
            this.txtEId.Enabled = false;
            this.txtEId.Location = new System.Drawing.Point(135, 52);
            this.txtEId.Name = "txtEId";
            this.txtEId.Size = new System.Drawing.Size(150, 20);
            this.txtEId.TabIndex = 32;
            this.txtEId.Visible = false;
            // 
            // btnELoad
            // 
            this.btnELoad.Location = new System.Drawing.Point(315, 176);
            this.btnELoad.Name = "btnELoad";
            this.btnELoad.Size = new System.Drawing.Size(64, 20);
            this.btnELoad.TabIndex = 31;
            this.btnELoad.Text = "Load";
            this.btnELoad.UseVisualStyleBackColor = true;
            this.btnELoad.Click += new System.EventHandler(this.btnELoad_Click);
            // 
            // dataViewEquipmentNeedWarrayty
            // 
            this.dataViewEquipmentNeedWarrayty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewEquipmentNeedWarrayty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ESTT,
            this.ENameProduct,
            this.EStatus,
            this.EDescription});
            this.dataViewEquipmentNeedWarrayty.Location = new System.Drawing.Point(-3, 218);
            this.dataViewEquipmentNeedWarrayty.Name = "dataViewEquipmentNeedWarrayty";
            this.dataViewEquipmentNeedWarrayty.RowTemplate.Height = 25;
            this.dataViewEquipmentNeedWarrayty.Size = new System.Drawing.Size(681, 153);
            this.dataViewEquipmentNeedWarrayty.TabIndex = 30;
            this.dataViewEquipmentNeedWarrayty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewEquipmentNeedWarrayty_CellClick);
            // 
            // ESTT
            // 
            this.ESTT.HeaderText = "STT";
            this.ESTT.Name = "ESTT";
            this.ESTT.Width = 50;
            // 
            // ENameProduct
            // 
            this.ENameProduct.DataPropertyName = "NameProduct";
            this.ENameProduct.HeaderText = "Tên thiết bị";
            this.ENameProduct.Name = "ENameProduct";
            this.ENameProduct.Width = 150;
            // 
            // EStatus
            // 
            this.EStatus.DataPropertyName = "Status";
            this.EStatus.HeaderText = "Tình trạng";
            this.EStatus.Name = "EStatus";
            this.EStatus.Width = 200;
            // 
            // EDescription
            // 
            this.EDescription.DataPropertyName = "Description";
            this.EDescription.HeaderText = "Mô tả";
            this.EDescription.Name = "EDescription";
            this.EDescription.Width = 200;
            // 
            // btnEClear
            // 
            this.btnEClear.Location = new System.Drawing.Point(535, 177);
            this.btnEClear.Name = "btnEClear";
            this.btnEClear.Size = new System.Drawing.Size(64, 20);
            this.btnEClear.TabIndex = 29;
            this.btnEClear.Text = "Thiết lặp lại";
            this.btnEClear.UseVisualStyleBackColor = true;
            this.btnEClear.Click += new System.EventHandler(this.btnEClear_Click);
            // 
            // btnESearch
            // 
            this.btnESearch.Location = new System.Drawing.Point(422, 177);
            this.btnESearch.Name = "btnESearch";
            this.btnESearch.Size = new System.Drawing.Size(64, 20);
            this.btnESearch.TabIndex = 28;
            this.btnESearch.Text = "Tìm kiếm";
            this.btnESearch.UseVisualStyleBackColor = true;
            this.btnESearch.Click += new System.EventHandler(this.btnESearch_Click);
            // 
            // btnEEdit
            // 
            this.btnEEdit.Enabled = false;
            this.btnEEdit.Location = new System.Drawing.Point(116, 177);
            this.btnEEdit.Name = "btnEEdit";
            this.btnEEdit.Size = new System.Drawing.Size(64, 20);
            this.btnEEdit.TabIndex = 27;
            this.btnEEdit.Text = "Sửa";
            this.btnEEdit.UseVisualStyleBackColor = true;
            this.btnEEdit.Click += new System.EventHandler(this.btnEEdit_Click);
            // 
            // btnEDel
            // 
            this.btnEDel.Enabled = false;
            this.btnEDel.Location = new System.Drawing.Point(221, 177);
            this.btnEDel.Name = "btnEDel";
            this.btnEDel.Size = new System.Drawing.Size(64, 20);
            this.btnEDel.TabIndex = 26;
            this.btnEDel.Text = "Xóa";
            this.btnEDel.UseVisualStyleBackColor = true;
            this.btnEDel.Click += new System.EventHandler(this.btnEDel_Click);
            // 
            // btnEAdd
            // 
            this.btnEAdd.Location = new System.Drawing.Point(21, 177);
            this.btnEAdd.Name = "btnEAdd";
            this.btnEAdd.Size = new System.Drawing.Size(64, 20);
            this.btnEAdd.TabIndex = 25;
            this.btnEAdd.Text = "Thêm mới";
            this.btnEAdd.UseVisualStyleBackColor = true;
            this.btnEAdd.Click += new System.EventHandler(this.btnEAdd_Click);
            // 
            // txtEDescription
            // 
            this.txtEDescription.Location = new System.Drawing.Point(134, 79);
            this.txtEDescription.Multiline = true;
            this.txtEDescription.Name = "txtEDescription";
            this.txtEDescription.Size = new System.Drawing.Size(150, 73);
            this.txtEDescription.TabIndex = 24;
            // 
            // txtEStatus
            // 
            this.txtEStatus.Location = new System.Drawing.Point(410, 23);
            this.txtEStatus.Multiline = true;
            this.txtEStatus.Name = "txtEStatus";
            this.txtEStatus.Size = new System.Drawing.Size(229, 130);
            this.txtEStatus.TabIndex = 23;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(334, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 13);
            this.label21.TabIndex = 22;
            this.label21.Text = "Tình Trạng";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(18, 81);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "Mô tả nguyên nhân";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(33, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "Tên Thiết Bị";
            // 
            // txtENameProduct
            // 
            this.txtENameProduct.Location = new System.Drawing.Point(134, 23);
            this.txtENameProduct.Name = "txtENameProduct";
            this.txtENameProduct.Size = new System.Drawing.Size(150, 20);
            this.txtENameProduct.TabIndex = 19;
            // 
            // tabRepairLog
            // 
            this.tabRepairLog.Controls.Add(this.txtRLId);
            this.tabRepairLog.Controls.Add(this.btnRlLoad);
            this.tabRepairLog.Controls.Add(this.dataViewRepairLog);
            this.tabRepairLog.Controls.Add(this.btnRlClear);
            this.tabRepairLog.Controls.Add(this.btnRlSearch);
            this.tabRepairLog.Controls.Add(this.btnRLEdit);
            this.tabRepairLog.Controls.Add(this.btnRlDel);
            this.tabRepairLog.Controls.Add(this.btnRlAdd);
            this.tabRepairLog.Controls.Add(this.label26);
            this.tabRepairLog.Controls.Add(this.txtRLSolution);
            this.tabRepairLog.Controls.Add(this.rlRepairDate);
            this.tabRepairLog.Controls.Add(this.label25);
            this.tabRepairLog.Controls.Add(this.rlFixDate);
            this.tabRepairLog.Controls.Add(this.label23);
            this.tabRepairLog.Controls.Add(this.label22);
            this.tabRepairLog.Controls.Add(this.txtRLRepaier);
            this.tabRepairLog.Controls.Add(this.label24);
            this.tabRepairLog.Controls.Add(this.txtRLNameEquipment);
            this.tabRepairLog.Location = new System.Drawing.Point(4, 22);
            this.tabRepairLog.Name = "tabRepairLog";
            this.tabRepairLog.Size = new System.Drawing.Size(676, 366);
            this.tabRepairLog.TabIndex = 5;
            this.tabRepairLog.Text = "Lịch Sử Sửa Chữa";
            this.tabRepairLog.UseVisualStyleBackColor = true;
            // 
            // txtRLId
            // 
            this.txtRLId.Enabled = false;
            this.txtRLId.Location = new System.Drawing.Point(423, 146);
            this.txtRLId.Name = "txtRLId";
            this.txtRLId.Size = new System.Drawing.Size(172, 20);
            this.txtRLId.TabIndex = 43;
            this.txtRLId.Visible = false;
            // 
            // btnRlLoad
            // 
            this.btnRlLoad.Location = new System.Drawing.Point(339, 187);
            this.btnRlLoad.Name = "btnRlLoad";
            this.btnRlLoad.Size = new System.Drawing.Size(64, 20);
            this.btnRlLoad.TabIndex = 41;
            this.btnRlLoad.Text = "Load";
            this.btnRlLoad.UseVisualStyleBackColor = true;
            this.btnRlLoad.Click += new System.EventHandler(this.btnRlLoad_Click);
            // 
            // dataViewRepairLog
            // 
            this.dataViewRepairLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewRepairLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RLSTT,
            this.RLEquipment,
            this.RLRepaier,
            this.RLSolution,
            this.vRLFixDate,
            this.vRLRepairDate});
            this.dataViewRepairLog.Location = new System.Drawing.Point(-3, 223);
            this.dataViewRepairLog.Name = "dataViewRepairLog";
            this.dataViewRepairLog.RowTemplate.Height = 25;
            this.dataViewRepairLog.Size = new System.Drawing.Size(681, 135);
            this.dataViewRepairLog.TabIndex = 40;
            this.dataViewRepairLog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewRepairLog_CellClick);
            // 
            // RLSTT
            // 
            this.RLSTT.HeaderText = "STT";
            this.RLSTT.Name = "RLSTT";
            this.RLSTT.Width = 50;
            // 
            // RLEquipment
            // 
            this.RLEquipment.DataPropertyName = "NameProduct";
            this.RLEquipment.HeaderText = "Tên thiết bị";
            this.RLEquipment.Name = "RLEquipment";
            this.RLEquipment.Width = 150;
            // 
            // RLRepaier
            // 
            this.RLRepaier.DataPropertyName = "Repairer";
            this.RLRepaier.HeaderText = "Người sửa";
            this.RLRepaier.Name = "RLRepaier";
            this.RLRepaier.Width = 150;
            // 
            // RLSolution
            // 
            this.RLSolution.DataPropertyName = "Solution";
            this.RLSolution.HeaderText = "Cách giải quyết";
            this.RLSolution.Name = "RLSolution";
            this.RLSolution.Width = 200;
            // 
            // vRLFixDate
            // 
            this.vRLFixDate.DataPropertyName = "FixDate";
            this.vRLFixDate.HeaderText = "Ngày sửa";
            this.vRLFixDate.Name = "vRLFixDate";
            // 
            // vRLRepairDate
            // 
            this.vRLRepairDate.DataPropertyName = "RepairTime";
            this.vRLRepairDate.HeaderText = "Ngày hoàn thành";
            this.vRLRepairDate.Name = "vRLRepairDate";
            // 
            // btnRlClear
            // 
            this.btnRlClear.Location = new System.Drawing.Point(545, 189);
            this.btnRlClear.Name = "btnRlClear";
            this.btnRlClear.Size = new System.Drawing.Size(64, 20);
            this.btnRlClear.TabIndex = 39;
            this.btnRlClear.Text = "Thiết lặp lại";
            this.btnRlClear.UseVisualStyleBackColor = true;
            this.btnRlClear.Click += new System.EventHandler(this.btnRlClear_Click);
            // 
            // btnRlSearch
            // 
            this.btnRlSearch.Location = new System.Drawing.Point(435, 189);
            this.btnRlSearch.Name = "btnRlSearch";
            this.btnRlSearch.Size = new System.Drawing.Size(64, 20);
            this.btnRlSearch.TabIndex = 38;
            this.btnRlSearch.Text = "Tìm kiếm";
            this.btnRlSearch.UseVisualStyleBackColor = true;
            this.btnRlSearch.Click += new System.EventHandler(this.btnRlSearch_Click);
            // 
            // btnRLEdit
            // 
            this.btnRLEdit.Enabled = false;
            this.btnRLEdit.Location = new System.Drawing.Point(135, 189);
            this.btnRLEdit.Name = "btnRLEdit";
            this.btnRLEdit.Size = new System.Drawing.Size(64, 20);
            this.btnRLEdit.TabIndex = 37;
            this.btnRLEdit.Text = "Sửa";
            this.btnRLEdit.UseVisualStyleBackColor = true;
            this.btnRLEdit.Click += new System.EventHandler(this.btnRLEdit_Click);
            // 
            // btnRlDel
            // 
            this.btnRlDel.Enabled = false;
            this.btnRlDel.Location = new System.Drawing.Point(234, 189);
            this.btnRlDel.Name = "btnRlDel";
            this.btnRlDel.Size = new System.Drawing.Size(64, 20);
            this.btnRlDel.TabIndex = 36;
            this.btnRlDel.Text = "Xóa";
            this.btnRlDel.UseVisualStyleBackColor = true;
            this.btnRlDel.Click += new System.EventHandler(this.btnRlDel_Click);
            // 
            // btnRlAdd
            // 
            this.btnRlAdd.Location = new System.Drawing.Point(44, 189);
            this.btnRlAdd.Name = "btnRlAdd";
            this.btnRlAdd.Size = new System.Drawing.Size(64, 20);
            this.btnRlAdd.TabIndex = 35;
            this.btnRlAdd.Text = "Thêm mới";
            this.btnRlAdd.UseVisualStyleBackColor = true;
            this.btnRlAdd.Click += new System.EventHandler(this.btnRlAdd_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(334, 16);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(84, 13);
            this.label26.TabIndex = 34;
            this.label26.Text = "Cách Giải Quyết";
            // 
            // txtRLSolution
            // 
            this.txtRLSolution.Location = new System.Drawing.Point(423, 16);
            this.txtRLSolution.Multiline = true;
            this.txtRLSolution.Name = "txtRLSolution";
            this.txtRLSolution.Size = new System.Drawing.Size(223, 111);
            this.txtRLSolution.TabIndex = 33;
            // 
            // rlRepairDate
            // 
            this.rlRepairDate.Location = new System.Drawing.Point(110, 143);
            this.rlRepairDate.Name = "rlRepairDate";
            this.rlRepairDate.Size = new System.Drawing.Size(172, 20);
            this.rlRepairDate.TabIndex = 32;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(19, 148);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(95, 13);
            this.label25.TabIndex = 31;
            this.label25.Text = "Ngày Hoàn Thành";
            // 
            // rlFixDate
            // 
            this.rlFixDate.Location = new System.Drawing.Point(110, 101);
            this.rlFixDate.Name = "rlFixDate";
            this.rlFixDate.Size = new System.Drawing.Size(172, 20);
            this.rlFixDate.TabIndex = 30;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(19, 106);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(54, 13);
            this.label23.TabIndex = 29;
            this.label23.Text = "Ngày Sửa";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(19, 62);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 13);
            this.label22.TabIndex = 28;
            this.label22.Text = "Người Sửa";
            // 
            // txtRLRepaier
            // 
            this.txtRLRepaier.Location = new System.Drawing.Point(110, 59);
            this.txtRLRepaier.Name = "txtRLRepaier";
            this.txtRLRepaier.Size = new System.Drawing.Size(172, 20);
            this.txtRLRepaier.TabIndex = 27;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(19, 16);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 13);
            this.label24.TabIndex = 26;
            this.label24.Text = "Tên Thiết Bị";
            // 
            // txtRLNameEquipment
            // 
            this.txtRLNameEquipment.Location = new System.Drawing.Point(110, 16);
            this.txtRLNameEquipment.Name = "txtRLNameEquipment";
            this.txtRLNameEquipment.Size = new System.Drawing.Size(172, 20);
            this.txtRLNameEquipment.TabIndex = 25;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "Quản lý";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCategories.ResumeLayout(false);
            this.tabCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewCategories)).EndInit();
            this.tabProduct.ResumeLayout(false);
            this.tabProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPView)).EndInit();
            this.tabBill.ResumeLayout(false);
            this.tabBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewBill)).EndInit();
            this.tabReceiptSlip.ResumeLayout(false);
            this.tabReceiptSlip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewReceiptSlip)).EndInit();
            this.tabEquipmentNeedWarrayty.ResumeLayout(false);
            this.tabEquipmentNeedWarrayty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewEquipmentNeedWarrayty)).EndInit();
            this.tabRepairLog.ResumeLayout(false);
            this.tabRepairLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewRepairLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabCategories;
        private TabPage tabProduct;
        private TabPage tabBill;
        private TabPage tabReceiptSlip;
        private TabPage tabEquipmentNeedWarrayty;
        private TabPage tabRepairLog;
        private TextBox txtSupplier;
        private Label label2;
        private TextBox txtNameCategory;
        private Label label1;
        private ComboBox cbbStatusCategory;
        private Label label3;
        private Button btnEditCategory;
        private Button btnAddCategory;
        private Button btnDelCategory;
        private DataGridView dataViewCategories;
        private TextBox txtPColor;
        private Label label5;
        private TextBox txtPName;
        private Label label4;
        private Label label6;
        private ComboBox cbbPCategories;
        private TextBox txtPDescription;
        private Label label7;
        private Label label9;
        private Label label8;
        private DataGridView dataPView;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn NameCategory;
        private DataGridViewTextBoxColumn NameSupplier;
        private DataGridViewTextBoxColumn Status;
        private Label lblIdCategory;
        private TextBox txtIdCategory;
        private Button btnClearCategory;
        private Button btnPClear;
        private Button btnPSearch;
        private Button btnPDel;
        private Button btnPEdit;
        private Button btnPAdd;
        private TextBox txtPSize;
        private Label label10;
        private NumericUpDown txtPQuantity;
        private NumericUpDown txtPPrice;
        private DataGridViewTextBoxColumn PSTT;
        private DataGridViewTextBoxColumn PNameProduct;
        private DataGridViewTextBoxColumn PNameCategory;
        private DataGridViewTextBoxColumn PColor;
        private DataGridViewTextBoxColumn PSize;
        private DataGridViewTextBoxColumn PQuantity;
        private DataGridViewTextBoxColumn PPrice;
        private DataGridViewTextBoxColumn PDescription;
        private Button btnPLoad;
        private TextBox txtPId;
        private Label label11;
        private TextBox txtHBiller;
        private DataGridView dataViewBill;
        private Label label12;
        private TextBox txtHNameCustomer;
        private Button btnBLoad;
        private Button btnBDel;
        private Button btnRClear;
        private Button btnRSearch;
        private Button btnREdit;
        private Button btnRDel;
        private Button btnRAdd;
        private DateTimePicker rPayTime;
        private Label label15;
        private Label label16;
        private TextBox txtRRecevier;
        private Label label17;
        private TextBox txtRAddress;
        private Label label18;
        private TextBox txtRNameCustomer;
        private DataGridView dataViewReceiptSlip;
        private Label label19;
        private TextBox txtENameProduct;
        private TextBox txtEStatus;
        private Label label21;
        private Label label20;
        private DataGridView dataViewEquipmentNeedWarrayty;
        private Button btnEClear;
        private Button btnESearch;
        private Button btnEEdit;
        private Button btnEDel;
        private Button btnEAdd;
        private TextBox txtEDescription;
        private Label label24;
        private TextBox txtRLNameEquipment;
        private DateTimePicker rlRepairDate;
        private Label label25;
        private DateTimePicker rlFixDate;
        private Label label23;
        private Label label22;
        private TextBox txtRLRepaier;
        private DataGridView dataViewRepairLog;
        private Button btnRlClear;
        private Button btnRlSearch;
        private Button btnRLEdit;
        private Button btnRlDel;
        private Button btnRlAdd;
        private Label label26;
        private TextBox txtRLSolution;
        private Button btnBClear;
        private Button btnHLoadData;
        private DataGridViewTextBoxColumn HSTT;
        private DataGridViewTextBoxColumn HBiller;
        private DataGridViewTextBoxColumn HCustomerName;
        private DataGridViewTextBoxColumn HTotalMoney;
        private DataGridViewTextBoxColumn HCreatedDate;
        private DataGridViewButtonColumn HDetail;
        private TextBox txtBId;
        private DateTimePicker rRecevingTime;
        private Label label13;
        private TextBox txtRId;
        private Button btnRLoad;
        private DataGridViewTextBoxColumn RSTT;
        private DataGridViewTextBoxColumn RNameCustomer;
        private DataGridViewTextBoxColumn RAddress;
        private DataGridViewTextBoxColumn RRecevier;
        private DataGridViewTextBoxColumn RLRecevingTime;
        private DataGridViewTextBoxColumn RLPayTime;
        private Button btnELoad;
        private TextBox txtEId;
        private DataGridViewTextBoxColumn ESTT;
        private DataGridViewTextBoxColumn ENameProduct;
        private DataGridViewTextBoxColumn EStatus;
        private DataGridViewTextBoxColumn EDescription;
        private Button btnRlLoad;
        private DataGridViewTextBoxColumn RLSTT;
        private DataGridViewTextBoxColumn RLEquipment;
        private DataGridViewTextBoxColumn RLRepaier;
        private DataGridViewTextBoxColumn RLSolution;
        private DataGridViewTextBoxColumn vRLFixDate;
        private DataGridViewTextBoxColumn vRLRepairDate;
        private TextBox txtRLId;
    }
}