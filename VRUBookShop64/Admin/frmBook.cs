using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace VRUBookShop64.Admin
{
    public partial class frmBook : Form
    {
        bool selectPic = false;
        string imagePath = Application.StartupPath.Substring(0, Application.StartupPath.Length - 9) + "images\\";
        string oldPicture = "";
        public frmBook()
        {
            InitializeComponent();
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            this.showDgvBook();
            this.showCboBookType();
        }

        private void showCboBookType()
        {
            BookType booktype = new BookType();
            DataTable dt = new DataTable();
            dt = booktype.read();
            cboBookTypeID.DataSource = dt;
            cboBookTypeID.DisplayMember = "BookTypeName";
            cboBookTypeID.ValueMember = "BookTypeID";
            cboBookTypeID.Text = "";
        }
        private void showDgvBook()
        {
            DataTable dt = new DataTable();
            Book book = new Book();
            dt = book.read();
            dgvBook.DataSource = dt;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if(txtBookName.Text == "" || txtCost.Text=="" || txtPrice.Text=="")
            {
                this.showErrorMessage("ป้อนข้อมูลที่กำหนดก่อน");
                return;
            }
            Book book = new Book();
            book.BookName = txtBookName.Text;
            book.Author = txtAuthor.Text;
            book.Publisher = txtPublisher.Text;
            book.Cost = int.Parse(txtCost.Text);
            book.Price = int.Parse(txtPrice.Text);
            book.Stock = int.Parse(txtStock.Text);
            if (selectPic)
                book.BookPicture = ofd.SafeFileName;
            else
                book.BookPicture = "";
            book.BookTypeID = int.Parse(cboBookTypeID.SelectedValue.ToString());
            book.create();
            if (selectPic)
                File.Copy(ofd.FileName, imagePath + ofd.SafeFileName, true);

            this.showDgvBook();
            this.clear();
        }

        private void clear()
        {
            labBookID.Text = "";
            txtBookName.Clear();
            txtAuthor.Clear();
            txtPublisher.Clear();
            txtCost.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            cboBookTypeID.Text = "";
            picture.Image = null;
            txtCondition.Text = "";
        }
        private void showErrorMessage(string text)
        {
            MessageBox.Show(text, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            ofd.Filter = "เลือกไฟล์รูปภาพ|*.jpg;*.png";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                picture.Image = Image.FromFile(ofd.FileName);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                selectPic = true;
            }
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (labBookID.Text == "")
            {
                this.showErrorMessage("เลือกข้อมูลที่จะแก้ไขก่อน");
                return;
            }
            Book book = new Book();
            book.BookID = int.Parse(labBookID.Text);
            book.BookName = txtBookName.Text;
            book.Author = txtAuthor.Text;
            book.Publisher = txtPublisher.Text;
            book.Cost = int.Parse(txtCost.Text);
            book.Price = int.Parse(txtPrice.Text);
            book.Stock = int.Parse(txtStock.Text);
            if (selectPic) // กรณีที่เลือกภาพ
                book.BookPicture = ofd.SafeFileName;
            else // กรณีที่ไม่เลือกภาพ ต้องใช้ภาพเดิม อาจมีภาพหรือไม่มี
                book.BookPicture = oldPicture;
            book.BookTypeID = int.Parse(cboBookTypeID.SelectedValue.ToString());
            book.update();
            if (selectPic)
                File.Copy(ofd.FileName, imagePath + ofd.SafeFileName, true);
            this.showDgvBook();
            this.clear();
            selectPic = false;
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labBookID.Text = dgvBook.Rows[e.RowIndex].Cells["BookID"].Value.ToString();
            txtBookName.Text = dgvBook.Rows[e.RowIndex].Cells["BookName"].Value.ToString();
            txtAuthor.Text= dgvBook.Rows[e.RowIndex].Cells["Author"].Value.ToString();
            txtPublisher.Text= dgvBook.Rows[e.RowIndex].Cells["Publisher"].Value.ToString();
            txtCost.Text = dgvBook.Rows[e.RowIndex].Cells["Cost"].Value.ToString();
            txtPrice.Text = dgvBook.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            txtStock.Text = dgvBook.Rows[e.RowIndex].Cells["Stock"].Value.ToString();
            cboBookTypeID.Text = dgvBook.Rows[e.RowIndex].Cells["BookTypeName"].Value.ToString();
            oldPicture = dgvBook.Rows[e.RowIndex].Cells["BookPicture"].Value.ToString();
            if (oldPicture != "" || oldPicture !=null)
            {
                if (File.Exists(imagePath + oldPicture))
                {
                    picture.Image = Image.FromFile(imagePath + oldPicture);
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                } else
                {
                    picture.Image = null;
                }
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (labBookID.Text == "")
            {
                this.showErrorMessage("เลือกข้อมูลที่จะลบก่อน");
                return;
            }
            DialogResult result;
            result = MessageBox.Show("ต้องการลบข้อมูลใช่หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;
            Book book = new Book();
            book.BookID = int.Parse(labBookID.Text);
            book.delete();
            this.showDgvBook();
            this.clear();
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            if (txtCondition.Text == "")
            {
                this.showErrorMessage("ป้อนรหัสหนังสือหรือชื่อหนังสือที่จะค้นหาก่อน");
                return;
            }
            Book book = new Book();
            DataTable dt = new DataTable();
            // ตรวจสอบว่าค่าที่ป้อนเป็นตัวเลขหรือข้อความ
            bool isnumber = int.TryParse(txtCondition.Text, out int BookID);
            if (isnumber)
            {
                book.BookID = BookID;
                dt = book.searchByID();
            } else
            {
                book.BookName = txtCondition.Text;
                dt = book.searchByName();
            }
            dgvBook.DataSource = dt;
            this.clear();
        }

        private void tsbShow_Click(object sender, EventArgs e)
        {
            this.showDgvBook();
        }
    }
}
