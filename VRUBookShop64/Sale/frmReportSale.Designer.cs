
namespace VRUBookShop64.Sale
{
    partial class frmReportSale
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSumary = new System.Windows.Forms.Button();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.dgvSumary = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumary)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtEnd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtBegin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เลือกเงื่อนไข";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.btnSumary);
            this.groupBox2.Controls.Add(this.btnSale);
            this.groupBox2.Location = new System.Drawing.Point(592, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 128);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "วันที่";
            // 
            // dtBegin
            // 
            this.dtBegin.Location = new System.Drawing.Point(62, 62);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(200, 26);
            this.dtBegin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ถึง";
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(322, 62);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(200, 26);
            this.dtEnd.TabIndex = 3;
            // 
            // btnSale
            // 
            this.btnSale.Image = global::VRUBookShop64.Properties.Resources.iconfinder_search_button_36847;
            this.btnSale.Location = new System.Drawing.Point(24, 34);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(151, 78);
            this.btnSale.TabIndex = 0;
            this.btnSale.Text = "แสดงรายการขาย";
            this.btnSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::VRUBookShop64.Properties.Resources.iconfinder_close_delete_709754;
            this.btnClose.Location = new System.Drawing.Point(495, 34);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 78);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "ปิดฟอร์ม";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::VRUBookShop64.Properties.Resources.iconfinder_print_560963;
            this.btnPrint.Location = new System.Drawing.Point(338, 33);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(151, 78);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "พิมพ์รายงาน";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnSumary
            // 
            this.btnSumary.Image = global::VRUBookShop64.Properties.Resources.iconfinder_search_button_36847;
            this.btnSumary.Location = new System.Drawing.Point(181, 33);
            this.btnSumary.Name = "btnSumary";
            this.btnSumary.Size = new System.Drawing.Size(151, 78);
            this.btnSumary.TabIndex = 1;
            this.btnSumary.Text = "แสดงสรุปรายการขาย";
            this.btnSumary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSumary.UseVisualStyleBackColor = true;
            this.btnSumary.Click += new System.EventHandler(this.btnSumary_Click);
            // 
            // dgvSale
            // 
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Location = new System.Drawing.Point(29, 172);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.RowHeadersWidth = 62;
            this.dgvSale.RowTemplate.Height = 28;
            this.dgvSale.Size = new System.Drawing.Size(1292, 494);
            this.dgvSale.TabIndex = 2;
            // 
            // dgvSumary
            // 
            this.dgvSumary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSumary.Location = new System.Drawing.Point(32, 174);
            this.dgvSumary.Name = "dgvSumary";
            this.dgvSumary.RowHeadersWidth = 62;
            this.dgvSumary.RowTemplate.Height = 28;
            this.dgvSumary.Size = new System.Drawing.Size(1289, 491);
            this.dgvSumary.TabIndex = 3;
            this.dgvSumary.Visible = false;
            // 
            // frmReportSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 690);
            this.Controls.Add(this.dgvSumary);
            this.Controls.Add(this.dgvSale);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReportSale";
            this.Text = "รายงานการขายสินค้า";
            this.Load += new System.EventHandler(this.frmReportSale_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSumary;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.DataGridView dgvSumary;
    }
}