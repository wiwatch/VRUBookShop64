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
using System.Globalization;
namespace VRUBookShop64.Sale
{
    public partial class frmReportSale : Form
    {
        string EmpID;
        SqlConnection con = new SqlConnection();
        public frmReportSale(string EmpID)
        {
            InitializeComponent();
            this.EmpID = EmpID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReportSale_Load(object sender, EventArgs e)
        {

        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            dgvSumary.Visible = false;
            dgvSale.Visible = true;
            if (con.State == ConnectionState.Open)
                con.Close();
            con.ConnectionString = "server=.\\sqlexpress;database=dbBookShop;integrated security=true";
            con.Open();

            // Engilsh Format
            CultureInfo _cultureinfo = new CultureInfo("en-Us");
            DateTime dtBegin = Convert.ToDateTime(this.dtBegin.Value, _cultureinfo);
            DateTime dtEnd = Convert.ToDateTime(this.dtEnd.Value, _cultureinfo);

            string sql = "SELECT SaleDate, tbSaleDetail.BookID, BookName, Amount, tbSaleDetail.Price, Total " +
                "FROM tbSale LEFT JOIN tbSaleDetail " +
                "ON tbSale.SaleID=tbSaleDetail.SaleID " +
                "LEFT JOIN tbBooks ON " +
                "tbSaleDetail.BookID=tbBooks.BookID " +
                "WHERE EmpID=@EmpID  " +
                "AND convert(varchar(10), SaleDate, 120) >=@dBegin " +
                "AND convert(varchar(10), SaleDate, 120) <=@dEnd ";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("@EmpID", this.EmpID);
            da.SelectCommand.Parameters.AddWithValue("@dBegin", dtBegin.ToString("yyyy-MM-dd", _cultureinfo));
            da.SelectCommand.Parameters.AddWithValue("@dEnd", dtEnd.ToString("yyyy-MM-dd", _cultureinfo));
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                dgvSale.DataSource = dt;
                this.setDgvSaleHeader();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void setDgvSaleHeader()
        {
            dgvSale.Columns[0].HeaderText = "วันที่ขาย";
            dgvSale.Columns[1].HeaderText = "รหัสหนังสือ";
            dgvSale.Columns[2].HeaderText = "ชื่อหนังสือ";
            dgvSale.Columns[3].HeaderText = "จำนวนที่ซื้อ";
            dgvSale.Columns[4].HeaderText = "ราคาขาย";
            dgvSale.Columns[5].HeaderText = "รวมเงิน";
        }

        private void btnSumary_Click(object sender, EventArgs e)
        {
            dgvSumary.Visible = true;
            dgvSale.Visible = false;
        }
    }
}
