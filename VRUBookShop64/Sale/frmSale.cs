using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VRUBookShop64.Sale
{
    public partial class frmSale : Form
    {
        string EmpName, EmpID;
        int i = 0; // นับแถวใน DataGridview
        int totalAll = 0; // เก็บเงินรวม
        public frmSale(string EmpName, string EmpID)
        {
            InitializeComponent();
            this.EmpID = EmpID;
            this.EmpName = EmpName;
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            this.showEmpData();
            this.showDateTime();
        }

        private void showDateTime()
        {
            labSaleDate.Text = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year +
                  " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
        }

        private void tDate_Tick(object sender, EventArgs e)
        {
            this.showDateTime();
        }

        private void txtBookID_KeyDown(object sender, KeyEventArgs e)
        {
            // ตรวจสอบว่ามีการกดปุ่ม Enter หรือยัง
            if (e.KeyCode == Keys.Enter) // กดปุ่ม Enter
            {
                // เช็คว่าป้อนรหัสถูกต้องหรือไม่
                bool isnumber = int.TryParse(txtBookID.Text, out int BookID);
                if (!isnumber)
                {
                    MessageBox.Show("ใส่รหัสไม่ถูกต้อง", "ผิดพลาด", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtBookID.Clear();
                    return;
                }
                // นำ รหัส ไปค้นในตาราง tbBook
                VRUBookShop db = new VRUBookShop();
                var row = db.tbBooks.Where(b => b.BookID == BookID).ToList();
                labBookName.Text = row[0].BookName;
                labCost.Text = row[0].Cost.ToString();
                labPrice.Text = row[0].Price.ToString();
                txtAmount.Focus();
            }
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            // ตรวจสอบว่ามีการกดปุ่ม Enter หรือยัง
            if (e.KeyCode == Keys.Enter) // กดปุ่ม Enter
            {
                // เช็คว่าป้อนรหัสถูกต้องหรือไม่
                bool isnumber = int.TryParse(txtAmount.Text, out int Amount);
                if (!isnumber)
                {
                    MessageBox.Show("ใส่จำนวนไม่ถูกต้อง", "ผิดพลาด", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtAmount.Clear();
                    return;
                }
                // คำนวณจำนวนเงิน
                labTotal.Text = (int.Parse(labPrice.Text) * int.Parse(txtAmount.Text)).ToString();
                btnAdd.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // นำรายการขายใส่ DataGridView
            dgvSale.Rows.Add();
            dgvSale.Rows[i].Cells["BookID"].Value = txtBookID.Text;
            dgvSale.Rows[i].Cells["BookName"].Value = labBookName.Text;
            dgvSale.Rows[i].Cells["Cost"].Value = labCost.Text;
            dgvSale.Rows[i].Cells["Price"].Value = labPrice.Text;
            dgvSale.Rows[i].Cells["Amount"].Value = txtAmount.Text;
            dgvSale.Rows[i].Cells["Total"].Value = labTotal.Text;
            i++;
           
            // คำนวณเงินรวม
            this.totalAll = this.totalAll + int.Parse(labTotal.Text);
            labTotalAmount.Text = this.totalAll.ToString();
            this.clearInput();
        }

        private void clearInput()
        {
            txtBookID.Clear(); labBookName.Text = ""; labCost.Text = ""; labPrice.Text = "";
            txtAmount.Clear(); labTotal.Text = ""; txtBookID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // บันทึกข้อมูลลงตาราง tbSale  -> ฟิลด์ที่จะบันทึก SaleID , EmpID, SaleDate, TotalAmount
            VRUBookShop db = new VRUBookShop();
            tbSale tbsale = new tbSale();
            tbsale.EmpID = int.Parse(labEmpID.Text);
            tbsale.SaleDate = DateTime.Now;
            tbsale.TotalAmount = int.Parse(labTotalAmount.Text);
            db.tbSale.Add(tbsale);
            db.SaveChanges();

            // นำข้อมูลการขายใน DataGridView บันทึกลงตาราง tbSaleDeatail -> ID, SaleID, BookID, Cost, Price, Amount, Total
            // อ่านค่า SaleID ออกมาก่อน
            int EmpID = int.Parse(labEmpID.Text);
            var row = db.tbSale.Where(sa => sa.EmpID == EmpID).OrderByDescending(sa => sa.SaleID).ToList();
            int SaleID = row[0].SaleID;
            // วนรอบอ่านข้อมูลใน DataGridView เพื่อจัดเก็บลงตาราง tbSaleDetail
            for (int i=0; i< dgvSale.Rows.Count-1; i++)
            {
                tbSaleDetail tbsaledetail = new tbSaleDetail();
                tbsaledetail.SaleID = SaleID;
                tbsaledetail.BookID = int.Parse(dgvSale.Rows[i].Cells["BookID"].Value.ToString());
                tbsaledetail.Cost= int.Parse(dgvSale.Rows[i].Cells["Cost"].Value.ToString());
                tbsaledetail.Price = int.Parse(dgvSale.Rows[i].Cells["Price"].Value.ToString());
                tbsaledetail.Amount = int.Parse(dgvSale.Rows[i].Cells["Amount"].Value.ToString());
                tbsaledetail.Total = int.Parse(dgvSale.Rows[i].Cells["Total"].Value.ToString());
                db.tbSaleDetail.Add(tbsaledetail);
                db.SaveChanges();

                // ตัดสต็อก update จำนวน ในตาราง tbBook
                int BookID = int.Parse(dgvSale.Rows[i].Cells["BookID"].Value.ToString());
                tbBooks tbbook = new tbBooks();
                var book = db.tbBooks.Single(b => b.BookID == BookID);
                book.Stock = book.Stock - int.Parse(dgvSale.Rows[i].Cells["Amount"].Value.ToString());
                db.SaveChanges();
            }
            this.clearDgvSale();
            i = 0;
            MessageBox.Show("บันทึกการขายแล้ว", "ผลลัพธ์", MessageBoxButtons.OK, MessageBoxIcon.Information);
            labTotalAmount.Text = "";
            this.totalAll = 0;
        }

        private void clearDgvSale()
        {
            dgvSale.DataSource = null;
            dgvSale.Rows.Clear();
        }
        private void showEmpData()
        {
            labEmpID.Text = this.EmpID;
            labEmpName.Text = this.EmpName;
        }
    }
}
