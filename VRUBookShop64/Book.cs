using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace VRUBookShop64
{
    class Book
    {
        // กำหนด Properties - คุณสมบัติของคลาส
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string  Publisher { get; set; }
        public int Cost { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public string BookPicture { get; set; }
        public int BookTypeID { get; set; }

        SqlConnection con;
        // สร้าง Method ใช้งาน
        public Book()
        {
            string connectionString = "server=.\\sqlexpress;database=dbBookShop;integrated security=true";
            con = new SqlConnection(connectionString);
        }

        public void create()
        {
            con.Open();
            string sql = "INSERT INTO tbBooks (BookName,Author,Publisher,Cost,Price,Stock,BookPicture,BookTypeID) " +
                " VALUES(@BookName,@Author,@Publisher,@Cost,@Price,@Stock,@BookPicture,@BookTypeID)";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@BookName", this.BookName);
            cm.Parameters.AddWithValue("@Author", this.Author);
            cm.Parameters.AddWithValue("@Publisher", this.Publisher);
            cm.Parameters.AddWithValue("@Cost", this.Cost);
            cm.Parameters.AddWithValue("@Price", this.Price);
            cm.Parameters.AddWithValue("@Stock", this.Stock);
            cm.Parameters.AddWithValue("@Bookpicture", this.BookPicture);
            cm.Parameters.AddWithValue("@BookTypeID", this.BookTypeID);
            cm.ExecuteNonQuery();
            con.Close();
        }

        public DataTable read()
        {
            con.Open();
            DataTable dt = new DataTable();
            string sql = "SELECT BookID,BookName,Author,Publisher,Cost,Price,Stock,BookPicture,BookTypeName " +
                " FROM tbBooks LEFT JOIN tbBookType " +
                " ON tbBooks.BookTypeID=tbBookType.BookTypeID";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public void update()
        {
            con.Open();
            string sql = "UPDATE tbBooks SET  " +
                "BookName=@BookName, " +
                "Author=@Author," +
                "Publisher=@Publisher," +
                "Cost=@Cost," +
                "Price=@Price," +
                "Stock=@Stock," +
                "BookPicture=@BookPicture," +
                "BookTypeID=@BookTypeID  " +
                "WHERE BookID=@BookID";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@BookName", this.BookName);
            cm.Parameters.AddWithValue("@Author", this.Author);
            cm.Parameters.AddWithValue("@Publisher", this.Publisher);
            cm.Parameters.AddWithValue("@Cost", this.Cost);
            cm.Parameters.AddWithValue("@Price", this.Price);
            cm.Parameters.AddWithValue("@Stock", this.Stock);
            cm.Parameters.AddWithValue("@Bookpicture", this.BookPicture);
            cm.Parameters.AddWithValue("@BookTypeID", this.BookTypeID);
            cm.Parameters.AddWithValue("@BookID", this.BookID);
            cm.ExecuteNonQuery();
            con.Close();
        }

        public void delete()
        {
            con.Open();
            string sql = "DELETE FROM tbBooks WHERE BookID=@BookID";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@BookID", this.BookID);
            cm.ExecuteNonQuery();
            con.Close();
        }

        public DataTable searchByID()
        {
            con.Open();
            string sql = "SELECT BookID,BookName,Author,Publisher,Cost,Price,Stock,BookPicture,BookTypeName " +
                " FROM tbBooks LEFT JOIN tbBookType " +
                " ON tbBooks.BookTypeID=tbBookType.BookTypeID " +
                " WHERE BookID=@BookID";
            SqlDataAdapter da= new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("@BookID", this.BookID);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable searchByName()
        {
            con.Open();
            string sql = "SELECT BookID,BookName,Author,Publisher,Cost,Price,Stock,BookPicture,BookTypeName " +
                " FROM tbBooks LEFT JOIN tbBookType " +
                " ON tbBooks.BookTypeID=tbBookType.BookTypeID " +
                " WHERE BookName LIKE @BookName";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("@BookName", this.BookName+"%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
