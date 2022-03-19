
using System.Windows.Forms;

namespace SaleManager
{
    partial class FormDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataViewDetail = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarraytyPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin hóa đơn";
            // 
            // dataViewDetail
            // 
            this.dataViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.NameCustomer,
            this.NameProduct,
            this.Quantity,
            this.TotalMoney,
            this.WarraytyPeriod});
            this.dataViewDetail.Location = new System.Drawing.Point(2, 51);
            this.dataViewDetail.Name = "dataViewDetail";
            this.dataViewDetail.RowTemplate.Height = 25;
            this.dataViewDetail.Size = new System.Drawing.Size(685, 181);
            this.dataViewDetail.TabIndex = 2;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // NameCustomer
            // 
            this.NameCustomer.DataPropertyName = "NameCustomer";
            this.NameCustomer.HeaderText = "Khách hàng";
            this.NameCustomer.Name = "NameCustomer";
            this.NameCustomer.Width = 200;
            // 
            // NameProduct
            // 
            this.NameProduct.DataPropertyName = "NameProduct";
            this.NameProduct.HeaderText = "Sản phẩm";
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            // 
            // TotalMoney
            // 
            this.TotalMoney.DataPropertyName = "TotalMoney";
            this.TotalMoney.HeaderText = "Tổng tiền";
            this.TotalMoney.Name = "TotalMoney";
            // 
            // WarraytyPeriod
            // 
            this.WarraytyPeriod.DataPropertyName = "WarraytyPeriod";
            this.WarraytyPeriod.HeaderText = "Thời gian bảo hành";
            this.WarraytyPeriod.Name = "WarraytyPeriod";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(25, 259);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(104, 23);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Xuất hóa đơn";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FormDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dataViewDetail);
            this.Controls.Add(this.label1);
            this.Name = "FormDetail";
            this.Text = "FormDetail";
            this.Load += new System.EventHandler(this.FormDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataViewDetail;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn NameCustomer;
        private DataGridViewTextBoxColumn NameProduct;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn TotalMoney;
        private DataGridViewTextBoxColumn WarraytyPeriod;
        private Button btnPrint;
    }
}