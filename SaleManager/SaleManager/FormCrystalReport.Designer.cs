
namespace SaleManager
{
    partial class FormCrystalReport
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
            this.cryViewBill = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryViewBill
            // 
            this.cryViewBill.ActiveViewIndex = -1;
            this.cryViewBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryViewBill.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryViewBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryViewBill.Location = new System.Drawing.Point(0, 0);
            this.cryViewBill.Name = "cryViewBill";
            this.cryViewBill.Size = new System.Drawing.Size(800, 450);
            this.cryViewBill.TabIndex = 0;
            this.cryViewBill.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FormCrystalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cryViewBill);
            this.Name = "FormCrystalReport";
            this.Text = "FormCrystalReport";
            this.Load += new System.EventHandler(this.FormCrystalReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryViewBill;
    }
}