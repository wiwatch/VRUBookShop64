using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // เรียกใช้

namespace VRUBookShop64
{
    public partial class frmTestConnection : Form
    {
        public frmTestConnection()
        {
            InitializeComponent();
        }

        private void frmTestConnection_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.\\sqlexpress;database=dbBookShop;integrated security=true";
            try
            {
                 con.Open();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            // Read Data 
            string sql = "SELECT * FROM tbPosition ";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            try
            {
                 da.Fill(dt);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("พบข้อมูล " + dt.Rows.Count + " แถว");
            MessageBox.Show(dt.Rows[1]["posName"].ToString());
        }
    }
}
