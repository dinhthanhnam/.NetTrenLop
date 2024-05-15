using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Ktra2_ontap
{
    public class Functions
    {
        public static SqlConnection Conn;
        public static string connString;
        public static void Connect()
        {
            //Thiết lập giá trị cho chuỗi kết nối
            connString = @"Data Source=Admin-PC;Initial Catalog=Ktra2;
                           Integrated Security=True
                           ";
            Conn = new SqlConnection();         		//Cấp phát đối tượng
            Conn.ConnectionString = connString; 		//Kết nối
            Conn.Open();                        		//Mở kết nối
        }

        public static void Disconnect()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();   	//Đóng kết nối
                Conn.Dispose();     //Giải phóng tài nguyên
                Conn = null;
            }
        }

        internal static object GetDataToTable(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter();	// Khai báo
            // Tạo đối tượng Command thực hiện câu lệnh SELECT        
            Mydata.SelectCommand = new SqlCommand();
            Mydata.SelectCommand.Connection = Functions.Conn; 	// Kết nối CSDL
            Mydata.SelectCommand.CommandText = sql;	// Gán câu lệnh SELECT
            DataTable table = new DataTable();    // Khai báo DataTable nhận dữ liệu trả về
            Mydata.Fill(table); 	//Thực hiện câu lệnh SELECT và đổ dữ liệu vào bảng table
            return table;

        }
    }

}

