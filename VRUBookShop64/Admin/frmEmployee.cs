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
using System.IO;
namespace VRUBookShop64.Admin
{
    public partial class frmEmployee : Form
    {
        SqlConnection con = new SqlConnection();
        bool selectPic = false;
        string imagePath = Application.StartupPath.Substring(0, Application.StartupPath.Length - 9) + "images\\";
        public frmEmployee()
        {
            InitializeComponent();
        }

  

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "server=.\\sqlexpress;database=dbBookShop;integrated security=true";
            con.Open();
            // เรียกเมธอดที่นำข้อมูลพนักงานมาแสดงที่ dgvEmp
            this.showEmpData();
            this.showPosData();
        }
        private void showPosData()
        {
            string sql = "SELECT * FROM tbPosition";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //นำ dt ใส่ combobox
            cboPosition.DataSource = dt;
            cboPosition.DisplayMember = "PosName";
            cboPosition.ValueMember = "PosID";
            cboPosition.Text = "";
        }
        private void showEmpData()
        {
            string sql = "SELECT EmpID,EmpName,Gender,Address,Telephone,Username,Password,PosName,Picture " +
                "FROM tbEmployee " +
                "LEFT JOIN " +
                "tbPosition " +
                "ON tbEmployee.PosID=tbPosition.PosID ";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvEmp.DataSource = dt;
            this.setDgvEmpHeader();
        }

        private void setDgvEmpHeader()
        {
            dgvEmp.Columns[5].Visible = false;
            dgvEmp.Columns[6].Visible = false;
        }
        private void tsbSearch_Click(object sender, EventArgs e)
        {
            if (txtCondition.Text == "")
            {
                MessageBox.Show("ป้อนข้อมูลที่ค้นหาก่อน", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // ค้นหาข้อมูล
            string sql = "SELECT EmpID, EmpName, Gender, Address, Telephone,Username,Password, PosName " +
                "FROM tbEmployee " +
                "LEFT JOIN " +
                "tbPosition " +
                "ON tbEmployee.PosID=tbPosition.PosID ";
            bool isNumeric = int.TryParse(txtCondition.Text, out int EmpID);
            if (isNumeric)
            {
                sql += "WHERE EmpID=@EmpID";
            }
            else
            {
                sql += "WHERE EmpName LIKE @EmpName";
            }

            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            if (isNumeric)
                da.SelectCommand.Parameters.AddWithValue("@EmpID", txtCondition.Text);
            else
                da.SelectCommand.Parameters.AddWithValue("@EmpName", txtCondition.Text + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                this.showErrorMessage("ไม่พบข้อมูล");
                txtCondition.Text = "";
                return;
            }
            dgvEmp.DataSource = dt;
            this.setDgvEmpHeader();
            txtCondition.Text = "";
        }

        private void tsbShow_Click(object sender, EventArgs e)
        {
            this.showEmpData();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (labEmpID.Text == "")
            {
                MessageBox.Show("เลือกข้อมูลที่จะลบก่อน","ผิดพลาด",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            // แสดง MessageBox ยืนยันการลบ
            DialogResult result;
            result = MessageBox.Show("ต้องการลบข้อมูล " + txtEmpName.Text + " ใช่หรือไม่", "ยืนยัน",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // ต้องการลบข้อมูล
                string sql = "DELETE FROM tbEmployee WHERE EmpID=@EmpID";
                SqlCommand cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@EmpID", labEmpID.Text);
                cm.ExecuteNonQuery();
                this.showEmpData();
                this.clear();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmpName.Text = dgvEmp.Rows[e.RowIndex].Cells["EmpName"].Value.ToString();
            labEmpID.Text = dgvEmp.Rows[e.RowIndex].Cells["EmpID"].Value.ToString();
            if (dgvEmp.Rows[e.RowIndex].Cells["Gender"].Value.ToString() == "ชาย")
                radMale.Checked = true;
            else if (dgvEmp.Rows[e.RowIndex].Cells["Gender"].Value.ToString() == "หญิง")
                radFemale.Checked = true;
            txtAddress.Text = dgvEmp.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            txtTelphone.Text = dgvEmp.Rows[e.RowIndex].Cells["Telephone"].Value.ToString();
            txtUsername.Text = dgvEmp.Rows[e.RowIndex].Cells["Username"].Value.ToString();
            txtPassword.Text = dgvEmp.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            cboPosition.Text = dgvEmp.Rows[e.RowIndex].Cells["PosName"].Value.ToString();
            // แสดงรูปภาพ
            string picname= dgvEmp.Rows[e.RowIndex].Cells["Picture"].Value.ToString();
            if (File.Exists(imagePath + picname))
            {
                pic.Image = Image.FromFile(imagePath + picname);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pic.Image = null;
            }
        }

        private void clear()
        {
            txtEmpName.Text = "";
            labEmpID.Text = "";
            txtAddress.Text = "";
            txtTelphone.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            cboPosition.Text = "";
            radMale.Checked = false;
            radFemale.Checked = false;
            pic.Image = null;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            string picname = "";
            // ตรวจสอบการป้อนข้อมูล
            if (txtEmpName.Text == "" || txtUsername.Text=="" || txtPassword.Text=="")
            {
                this.showErrorMessage("ป้อนข้อมูลที่กำหนดก่อน");
                return;
            }

            if (labEmpID.Text != "")
            {
                this.showErrorMessage("คูณเลือกทำงานแก้ไขข้อมูลหรือลบข้อมูลอยู่");
                return;
            }

            // เขียนคำสั่งจัดเก็บข้อมูล
            string Gender = this.checkGender();
            string sql = "INSERT INTO tbEmployee (EmpName,Gender,Address,Telephone,Username,Password,PosID,Picture) " +
                "VALUES(@EmpName,@Gender,@Address,@Telephone,@Username,@Password,@PosID,@Picture)";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@EmpName", txtEmpName.Text);
            cm.Parameters.AddWithValue("@Gender", Gender);
            cm.Parameters.AddWithValue("@Address", txtAddress.Text);
            cm.Parameters.AddWithValue("@Telephone", txtTelphone.Text);
            cm.Parameters.AddWithValue("@Username", txtUsername.Text);
            cm.Parameters.AddWithValue("@Password", txtPassword.Text);
            cm.Parameters.AddWithValue("@PosID", cboPosition.SelectedValue.ToString());
       
            if(selectPic)   // if(selectPic == true)
            {
                 picname = this.changePicName();
             //    MessageBox.Show(picname);
             //    return;
                //  cm.Parameters.AddWithValue("@Picture", ofd.SafeFileName);
                cm.Parameters.AddWithValue("@Picture", picname);
            }
            else
            {
                cm.Parameters.AddWithValue("@Picture", "");
            }
            cm.ExecuteNonQuery();
            if(selectPic)
            {
                 //File.Copy(ofd.FileName, imagePath + ofd.SafeFileName, true);
                File.Copy(ofd.FileName, imagePath + picname, true);
            }
            this.showEmpData();
            this.clear();
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showErrorMessage(string text)
        {
            MessageBox.Show(text, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSelectPic_Click(object sender, EventArgs e)
        {
            // ปุ่มเลือกรูปภาพ
            ofd.Filter = "เลือกไฟล์รูปภาพ|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)  // เปิดหน้า open แล้วมีการเลือกรูปภาพ
            {
                pic.Image = Image.FromFile(ofd.FileName);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                // กำหนดตัวแปร เช็คว่ามีการเลือกภาพ
                selectPic = true;
            }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            string picname = "";
            string Gender = this.checkGender();
            if (labEmpID.Text == "")
            {
                this.showErrorMessage("เลือกข้อมูลที่จะแก้ไขก่อน");
                return;
            }
            // ตรวจสอบ txtUsername.Text ว่าซ้ำกับข้อมูลในตารางหรือไม่ นศ.ไปทำเอง
            string sql = "UPDATE tbEmployee SET " +
                " EmpName=@EmpName," +
                " Gender=@Gender," +
                " Address=@Address," +
                " Telephone=@Telephone," +
                " Username=@Username," +
                " Password=@Password," +
                " PosID=@PosID ";
            if (selectPic)
            {
                sql  += ",Picture=@Picture";
            }
            sql += " WHERE EmpID=@EmpID";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@EmpID", labEmpID.Text);
            cm.Parameters.AddWithValue("@EmpName", txtEmpName.Text);
            cm.Parameters.AddWithValue("Gender", Gender);
            cm.Parameters.AddWithValue("@Address", txtAddress.Text);
            cm.Parameters.AddWithValue("@Telephone", txtTelphone.Text);
            cm.Parameters.AddWithValue("@Username", txtUsername.Text);
            cm.Parameters.AddWithValue("@Password", txtPassword.Text);
            cm.Parameters.AddWithValue("@PosID", cboPosition.SelectedValue.ToString());
            if (selectPic)
            {
                picname = this.changePicName();
                cm.Parameters.AddWithValue("@Picture", picname);
            }
            cm.ExecuteNonQuery();
            this.showEmpData();
            this.clear();
            if (selectPic)
            {
                File.Copy(ofd.FileName, imagePath + picname, true);
            }
        }

        private string checkGender()
        {
            string gender = "";
            if (radMale.Checked)
                gender = "ชาย";
            else if (radFemale.Checked)
                gender = "หญิง";
            return gender;
        }

        private string changePicName() // ใช้เปลี่ยนชื่อไฟล์รูปภาพ
        {
            string[] data = ofd.SafeFileName.Split('.');
         //   MessageBox.Show(data[0]);
       //     MessageBox.Show(data[1]);
            string newPicName = txtUsername.Text + "." + data[1];
            return newPicName;
        }
    }
}
