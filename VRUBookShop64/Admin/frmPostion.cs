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
namespace VRUBookShop64.Admin
{
    public partial class frmPostion : Form
    {
        SqlConnection con = new SqlConnection();
        public frmPostion()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            // ค้นหาข้อมูล
            string sql = "SELECT * FROM tbPosition   ";
            bool isNumeric = int.TryParse(txtCondition.Text, out int PosID);
            if (isNumeric)
            {
                sql += "WHERE PosID=@PosID";
            } else
            {
                sql += "WHERE PosName LIKE @PosName";
            }
               
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            if (isNumeric)
                 da.SelectCommand.Parameters.AddWithValue("@PosID", txtCondition.Text);
            else
                da.SelectCommand.Parameters.AddWithValue("@PosName", txtCondition.Text+"%" );
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("ไม่พบข้อมูล");
                return;
            }
            dgvPosition.DataSource = dt;

        }

        private void frmPostion_Load(object sender, EventArgs e)
        {
            // Connect Database
            con.ConnectionString = "server=.\\sqlexpress;database=dbBookShop;integrated security=true";
            con.Open();
            // อ่านข้อมูลจากตาราง tbPosition
            this.showPostionData();
        }

        private void tsbShow_Click(object sender, EventArgs e)
        {
            // ต้องการแสดงข้อมูบตำแหน่งพนักงานทุกรายการ
            this.showPostionData();
        }

        //สร้างเมธอดสำหรับแสดงข้อมูลตำแหน่ง
        private void showPostionData()
        {
            string sql = "SELECT * FROM tbPosition";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            // นำข้อมูลใน dt ไปแสดงที่ DataGridView
            dgvPosition.DataSource = dt;
        }

        private void dgvPosition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            // จัดเก็บข้อมูล
            // ตรวจสอบการป้อนข้อมูล
            if (txtPosName.Text == "")
            {
                MessageBox.Show("ป้อนชื่อตำแหน่งก่อน", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // มีการป้อนข้อมูลแล้ว จะนำข้อมูลไปเก็บในตาราง tbPosition
            string sql = "INSERT INTO tbPosition (PosName) VALUES (@PosName)";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@PosName", txtPosName.Text);
            cm.ExecuteNonQuery();
            MessageBox.Show("จัดเก็บข้อมูลแล้ว");
            this.showPostionData();
            this.clear();
        }
        private void clear()
        {
            txtPosName.Text = ""; labPosID.Text = "";
        }

        private void dgvPosition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // อ่านข้อมูลจาก Cell ที่คลิกไปแสดงที่ txtPosName และ labPosID
            txtPosName.Text = dgvPosition.Rows[e.RowIndex].Cells["PosName"].Value.ToString();
            labPosID.Text = dgvPosition.Rows[e.RowIndex].Cells["PosID"].Value.ToString();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            // จะแก้ไขได้ต้องมีการคลิกเลือกรายการใน dgvPosition ก่อน
            if (labPosID.Text == "")
            {
                MessageBox.Show("เลือกข้อมูลที่จะแก้ไขก่อน");
                return;
            }
            // เขียนคำสั่งแก้ไขข้อมูล
            string sql = "UPDATE tbPosition SET PosName=@PosName WHERE PosID=@PosID";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@PosName", txtPosName.Text);
            cm.Parameters.AddWithValue("@PosID", labPosID.Text);
            cm.ExecuteNonQuery();
            this.showPostionData();
            this.clear();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (labPosID.Text == "")
            {
                MessageBox.Show("เลือกข้อมูลที่จะลบก่อน");
                return;
            }
            // แสดง MessageBox ยืนยันการลบ
            DialogResult result;
            result = MessageBox.Show("ต้องการลบข้อมูล " + txtPosName.Text + " ใช่หรือไม่", "ยืนยัน",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // ต้องการลบข้อมูล
                string sql = "DELETE FROM tbPosition WHERE PosID=@PosID";
                SqlCommand cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@PosID", labPosID.Text);
                cm.ExecuteNonQuery();
                this.showPostionData();
                this.clear();
            }
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
