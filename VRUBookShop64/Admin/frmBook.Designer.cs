
namespace VRUBookShop64.Admin
{
    partial class frmBook
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtCondition = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbShow = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.cboBookTypeID = new System.Windows.Forms.ComboBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.btnSelectPicture = new System.Windows.Forms.Button();
            this.labBookID = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClear,
            this.toolStripSeparator1,
            this.tsbSave,
            this.tsbEdit,
            this.toolStripSeparator2,
            this.tsbDelete,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.txtCondition,
            this.tsbSearch,
            this.toolStripSeparator4,
            this.tsbShow,
            this.tsbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1463, 82);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbClear
            // 
            this.tsbClear.Image = global::VRUBookShop64.Properties.Resources.iconfinder_Gnome_Edit_Clear_32_54970;
            this.tsbClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClear.Name = "tsbClear";
            this.tsbClear.Size = new System.Drawing.Size(98, 77);
            this.tsbClear.Text = "เคลียร์ฟอร์ม";
            this.tsbClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbClear.Click += new System.EventHandler(this.tsbClear_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 82);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = global::VRUBookShop64.Properties.Resources.iconfinder_Save1;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(60, 77);
            this.tsbSave.Text = "จัดเก็บ";
            this.tsbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::VRUBookShop64.Properties.Resources.edit1;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(53, 77);
            this.tsbEdit.Text = "แก้ไข";
            this.tsbEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 82);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::VRUBookShop64.Properties.Resources.delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(52, 77);
            this.tsbDelete.Text = "ลบ";
            this.tsbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 82);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(224, 77);
            this.toolStripLabel1.Text = "ป้อนรหัสประเภทหรือชื่อประเภท";
            // 
            // txtCondition
            // 
            this.txtCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCondition.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(200, 82);
            // 
            // tsbSearch
            // 
            this.tsbSearch.Image = global::VRUBookShop64.Properties.Resources.iconfinder_search_2856511;
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(97, 77);
            this.tsbSearch.Text = "ค้นหาข้อมูล";
            this.tsbSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 82);
            // 
            // tsbShow
            // 
            this.tsbShow.Image = global::VRUBookShop64.Properties.Resources.report2;
            this.tsbShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShow.Name = "tsbShow";
            this.tsbShow.Size = new System.Drawing.Size(52, 77);
            this.tsbShow.Text = "แสดง";
            this.tsbShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbShow.Click += new System.EventHandler(this.tsbShow_Click);
            // 
            // tsbExit
            // 
            this.tsbExit.Image = global::VRUBookShop64.Properties.Resources.exit1;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(76, 77);
            this.tsbExit.Text = "ปิดฟอร์ม";
            this.tsbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // dgvBook
            // 
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(396, 126);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowHeadersWidth = 62;
            this.dgvBook.RowTemplate.Height = 28;
            this.dgvBook.Size = new System.Drawing.Size(1033, 581);
            this.dgvBook.TabIndex = 3;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ชื่อหนังสือ *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ชื่อผู้แต่ง";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "สำนักพิมพ์";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "ต้นทุน";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "ราคาขาย";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "จำนวน";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "ประเภทหนังสือ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 521);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "รูปภาพ";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(117, 126);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(216, 26);
            this.txtBookName.TabIndex = 12;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(116, 178);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(216, 26);
            this.txtAuthor.TabIndex = 13;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(116, 237);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(216, 26);
            this.txtPublisher.TabIndex = 14;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(116, 297);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(216, 26);
            this.txtCost.TabIndex = 15;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(116, 347);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(216, 26);
            this.txtPrice.TabIndex = 16;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(116, 401);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(216, 26);
            this.txtStock.TabIndex = 17;
            // 
            // cboBookTypeID
            // 
            this.cboBookTypeID.FormattingEnabled = true;
            this.cboBookTypeID.Location = new System.Drawing.Point(143, 452);
            this.cboBookTypeID.Name = "cboBookTypeID";
            this.cboBookTypeID.Size = new System.Drawing.Size(189, 28);
            this.cboBookTypeID.TabIndex = 18;
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Location = new System.Drawing.Point(115, 515);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(156, 166);
            this.picture.TabIndex = 19;
            this.picture.TabStop = false;
            // 
            // btnSelectPicture
            // 
            this.btnSelectPicture.Location = new System.Drawing.Point(115, 686);
            this.btnSelectPicture.Name = "btnSelectPicture";
            this.btnSelectPicture.Size = new System.Drawing.Size(155, 43);
            this.btnSelectPicture.TabIndex = 20;
            this.btnSelectPicture.Text = "เลือกรูปภาพ";
            this.btnSelectPicture.UseVisualStyleBackColor = true;
            this.btnSelectPicture.Click += new System.EventHandler(this.btnSelectPicture_Click);
            // 
            // labBookID
            // 
            this.labBookID.AutoSize = true;
            this.labBookID.Location = new System.Drawing.Point(349, 129);
            this.labBookID.Name = "labBookID";
            this.labBookID.Size = new System.Drawing.Size(0, 20);
            this.labBookID.TabIndex = 21;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1463, 787);
            this.Controls.Add(this.labBookID);
            this.Controls.Add(this.btnSelectPicture);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.cboBookTypeID);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "รายการหนังสือ";
            this.Load += new System.EventHandler(this.frmBook_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtCondition;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbShow;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.ComboBox cboBookTypeID;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button btnSelectPicture;
        private System.Windows.Forms.Label labBookID;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}