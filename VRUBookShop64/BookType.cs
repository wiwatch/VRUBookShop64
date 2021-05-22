using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace VRUBookShop64
{
    class BookType
    {
        // กำหนด properties ของคลาส
        public int BookTypeID { get; set; }
        public string BookTypeName { get; set; }


        SqlConnection con;
        // คอนสตรัคเตอร์ เชื่อมกับฐานข้อมูล
        public BookType()
        {
            string connectionString = "server=.\\sqlexpress;database=dbBookShop;integrated security=true";
            con = new SqlConnection(connectionString);
        }

        public DataTable read() // SELECT
        {
            this.checkConnection();
            string sql = "SELECT * FROM tbBookType";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public void create() // INSERT
        {
            this.checkConnection();
            string sql = "INSERT INTO tbBookType (BookTypeName) VALUES(@BookTypeName)";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@BookTypeName", this.BookTypeName);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public void update()
        {
            this.checkConnection();
            string sql = "UPDATE tbBookType SET BookTypeName=@BookTypeName  " +
                " WHERE BookTypeID=@BookTypeID";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@BookTypeName", this.BookTypeName);
            cm.Parameters.AddWithValue("@BookTypeID", this.BookTypeID);
            cm.ExecuteNonQuery();
            con.Close();
        }

        public void delete()
        {
            this.checkConnection();
            string sql = "DELETE FROM tbBookType WHERE BookTypeID=@BookTypeID";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@BookTypeID", this.BookTypeID);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public DataTable searchByID()
        {
            this.checkConnection();
            string sql = "SELECT * FROM tbBookType WHERE BookTypeID=@BookTypeID";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("@BookTypeID", this.BookTypeID);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable searchByName()
        {
            this.checkConnection();
            string sql = "SELECT * FROM tbBookType WHERE BookTypeName LIKE @BookTypeName";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("@BookTypeName", this.BookTypeName+"%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public void checkConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
        }
    }
}
