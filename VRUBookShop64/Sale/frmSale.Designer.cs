
namespace VRUBookShop64.Sale
{
    partial class frmSale
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labSaleDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labCost = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labTotal = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.labPrice = new System.Windows.Forms.Label();
            this.labBookName = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.labTotalAmount = new System.Windows.Forms.Label();
            this.tDate = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.labEmpID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labEmpName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(731, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "วันที่ขาย";
            // 
            // labSaleDate
            // 
            this.labSaleDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labSaleDate.Location = new System.Drawing.Point(806, 46);
            this.labSaleDate.Name = "labSaleDate";
            this.labSaleDate.Size = new System.Drawing.Size(240, 34);
            this.labSaleDate.TabIndex = 1;
            this.labSaleDate.Text = "label2";
            this.labSaleDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labCost);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.labTotal);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.labPrice);
            this.groupBox1.Controls.Add(this.labBookName);
            this.groupBox1.Controls.Add(this.txtBookID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(33, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1041, 130);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // labCost
            // 
            this.labCost.AutoSize = true;
            this.labCost.Location = new System.Drawing.Point(453, 67);
            this.labCost.Name = "labCost";
            this.labCost.Size = new System.Drawing.Size(0, 20);
            this.labCost.TabIndex = 11;
            this.labCost.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::VRUBookShop64.Properties.Resources.iconfinder_001_01_95882;
            this.btnAdd.Location = new System.Drawing.Point(837, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(185, 65);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "เพิ่มรายการขาย";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labTotal
            // 
            this.labTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTotal.Location = new System.Drawing.Point(727, 61);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(65, 36);
            this.labTotal.TabIndex = 9;
            this.labTotal.Text = "label10";
            this.labTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(615, 61);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(79, 26);
            this.txtAmount.TabIndex = 8;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            // 
            // labPrice
            // 
            this.labPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labPrice.Location = new System.Drawing.Point(492, 57);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(65, 36);
            this.labPrice.TabIndex = 7;
            this.labPrice.Text = "label9";
            this.labPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labBookName
            // 
            this.labBookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labBookName.Location = new System.Drawing.Point(138, 59);
            this.labBookName.Name = "labBookName";
            this.labBookName.Size = new System.Drawing.Size(296, 35);
            this.labBookName.TabIndex = 6;
            this.labBookName.Text = "label8";
            this.labBookName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(36, 59);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(72, 26);
            this.txtBookID.TabIndex = 5;
            this.txtBookID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBookID_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(737, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "รวมเงิน";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(612, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "จำนวนที่ขาย";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "ราคาขาย";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "ชื่อหนังสือ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "รหัสหนังสือ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSale);
            this.groupBox2.Location = new System.Drawing.Point(30, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 302);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // dgvSale
            // 
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookName,
            this.Cost,
            this.Price,
            this.Amount,
            this.Total});
            this.dgvSale.Location = new System.Drawing.Point(16, 25);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.RowHeadersWidth = 62;
            this.dgvSale.RowTemplate.Height = 28;
            this.dgvSale.Size = new System.Drawing.Size(744, 249);
            this.dgvSale.TabIndex = 0;
            // 
            // BookID
            // 
            this.BookID.HeaderText = "รหัสหนังสือ";
            this.BookID.MinimumWidth = 8;
            this.BookID.Name = "BookID";
            this.BookID.Width = 60;
            // 
            // BookName
            // 
            this.BookName.HeaderText = "ชื่อหนังสือ";
            this.BookName.MinimumWidth = 8;
            this.BookName.Name = "BookName";
            this.BookName.Width = 180;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "ต้นทุน";
            this.Cost.MinimumWidth = 8;
            this.Cost.Name = "Cost";
            this.Cost.Visible = false;
            this.Cost.Width = 60;
            // 
            // Price
            // 
            this.Price.HeaderText = "ราคาขาย";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.Width = 60;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "จำนวนที่ขาย";
            this.Amount.MinimumWidth = 8;
            this.Amount.Name = "Amount";
            this.Amount.Width = 60;
            // 
            // Total
            // 
            this.Total.HeaderText = "จำนวนเงิน";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.Width = 60;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Location = new System.Drawing.Point(825, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 304);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::VRUBookShop64.Properties.Resources.iconfinder_close_delete_709753;
            this.btnClose.Location = new System.Drawing.Point(36, 226);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(185, 65);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "ปิดฟอร์ม";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::VRUBookShop64.Properties.Resources.iconfinder_print_560962;
            this.btnPrint.Location = new System.Drawing.Point(36, 155);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(185, 65);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "พิมพ์ใบเสร็จ";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Image = global::VRUBookShop64.Properties.Resources.iconfinder_Gnome_Edit_Clear_32_549703;
            this.btnClear.Location = new System.Drawing.Point(36, 84);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(185, 65);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "เคลียร์ฟอร์ม";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::VRUBookShop64.Properties.Resources.iconfinder_save_603162;
            this.btnSave.Location = new System.Drawing.Point(36, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(185, 65);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "บันทึกการขาย";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(517, 578);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(294, 46);
            this.label11.TabIndex = 5;
            this.label11.Text = "รวมเงินค่าหนังสือ";
            // 
            // labTotalAmount
            // 
            this.labTotalAmount.BackColor = System.Drawing.Color.Yellow;
            this.labTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalAmount.ForeColor = System.Drawing.Color.Red;
            this.labTotalAmount.Location = new System.Drawing.Point(831, 587);
            this.labTotalAmount.Name = "labTotalAmount";
            this.labTotalAmount.Size = new System.Drawing.Size(242, 70);
            this.labTotalAmount.TabIndex = 6;
            this.labTotalAmount.Text = "label12";
            this.labTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tDate
            // 
            this.tDate.Enabled = true;
            this.tDate.Interval = 1000;
            this.tDate.Tick += new System.EventHandler(this.tDate_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "รหัสพนักงาน";
            // 
            // labEmpID
            // 
            this.labEmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labEmpID.Location = new System.Drawing.Point(145, 42);
            this.labEmpID.Name = "labEmpID";
            this.labEmpID.Size = new System.Drawing.Size(47, 36);
            this.labEmpID.TabIndex = 8;
            this.labEmpID.Text = "label8";
            this.labEmpID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "ชื่อพนักงาน";
            // 
            // labEmpName
            // 
            this.labEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labEmpName.Location = new System.Drawing.Point(300, 42);
            this.labEmpName.Name = "labEmpName";
            this.labEmpName.Size = new System.Drawing.Size(197, 36);
            this.labEmpName.TabIndex = 10;
            this.labEmpName.Text = "label8";
            this.labEmpName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 681);
            this.Controls.Add(this.labEmpName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labEmpID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labTotalAmount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labSaleDate);
            this.Controls.Add(this.label1);
            this.Name = "frmSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ฟอร์มการขาย";
            this.Load += new System.EventHandler(this.frmSale_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labSaleDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label labBookName;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labTotalAmount;
        private System.Windows.Forms.Timer tDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labEmpID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}