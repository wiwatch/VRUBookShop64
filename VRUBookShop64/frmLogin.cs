using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using VRUBookShop64.Admin;
using VRUBookShop64.Sale;
using VRUBookShop64.Manager;
using VRUBookShop64.Stock;
namespace VRUBookShop64
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //ปิดฟอร์ม
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // ตรวจสอบการป้อนข้อมูล
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("ป้อนข้อมูลให้ครับก่อน", "ผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // มีการป้อนข้อมูลแล้ว นำ username, password ไปตรวจสอบกับข้อมูลในตาราง
            string connectionString = "server=.\\sqlexpress;database=dbBookShop;integrated security=true";
            using (SqlConnection con= new SqlConnection(connectionString))
            {
                con.Open();
                // MessageBox.Show("connect ok");
                // คลาสที่ใช้งานในการ SELECT ข้อมูล sqlDataAdapter, DataTable, คำสั่ง SQL
                //     string sql = "SELECT * FROM tbEmployee WHERE  Username=' " + txtUsername.Text+
                //           " ' AND Password=' "+ txtPassword.Text +" ' ";
                string sql = "SELECT * FROM tbEmployee WHERE Username=@Username AND Password=@Password";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.SelectCommand.Parameters.AddWithValue("@Username", txtUsername.Text);
                da.SelectCommand.Parameters.AddWithValue("@Password",txtPassword.Text);
                DataTable dt=new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count < 1)
                {
                    MessageBox.Show("ไม่พบข้อมูล","ผิดพลาด", 
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                // กรณีพบข้อมูล ตรวจสอบสถานะผู้ใช้งาน
               if (dt.Rows[0]["PosID"].ToString() == "1")
                {
                    // MessageBox.Show("พนักงานขาย");
                    frmSaleMenu frm = new frmSaleMenu(dt.Rows[0]["EmpName"].ToString());
                    frm.Show();
                    this.Hide();
                } 
                else if (dt.Rows[0]["PosID"].ToString() == "2")
                {
                    // MessageBox.Show("พนักงานคลังสินค้า");
                    frmStock frm = new frmStock();
                    frm.Show();
                    this.Hide();
                }
                else if (dt.Rows[0]["PosID"].ToString() == "3")
                {
                    //  MessageBox.Show("ผู้จัดการร้าน");
                    frmManager frm = new frmManager();
                    frm.Show();
                    
                }
                else if (dt.Rows[0]["PosID"].ToString() == "4")
                {
                    /// MessageBox.Show("ผู้ดูแลระบบ");
                    frmAdmin frm = new frmAdmin(dt.Rows[0]["EmpName"].ToString());
                    frm.Show();
                }
            }
        }
    }
}
