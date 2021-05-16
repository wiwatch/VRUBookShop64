using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VRUBookShop64.Admin
{
    public partial class frmBookType : Form
    {
        public frmBookType()
        {
            InitializeComponent();
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {

        }

        private void frmBookType_Load(object sender, EventArgs e)
        {
            this.showDgvBookType();
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbShow_Click(object sender, EventArgs e)
        {
            this.showDgvBookType();
        }

        private void showDgvBookType()
        {
            DataTable dt = new DataTable();
            // สร้างอ็อบเจกต์ของคลาส BookType
            BookType booktype = new BookType();
            dt = booktype.read();
            dgvBookType.DataSource = dt;
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (txtCondition.Text == "")
            {
                this.showErrorMessage("ป้อนข้อมูลที่จะค้นหาก่อน");
                return;
            }
            BookType booktype = new BookType();
            bool isnumeric = int.TryParse(txtCondition.Text, out int BookTypeID);
            if (isnumeric)
            {
                booktype.BookTypeID = BookTypeID;
                dt= booktype.searchByID();
            }
            else // ไม่ใช่ตัวเลข
            {
                booktype.BookTypeName = txtCondition.Text;
                dt = booktype.searchByName();
            }
            dgvBookType.DataSource = dt;
        }

        private void showErrorMessage(string text)
        {
            MessageBox.Show(text, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
