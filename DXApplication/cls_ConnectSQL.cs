using System;

using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

using System.Windows.Forms;

namespace DXApplication
{
    public class cls_ConnectSQL
    {
        public static Image Base64ToImage(string base64Image)
        {
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(base64Image)))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }
        //
        public static SqlConnection conn = new SqlConnection();
        public static void createConnect()
        {
            //Cấu trúc chuỗi kết nối
            conn.ConnectionString = @"Data Source =localhost; Initial Catalog =db_final_winform; User ID=hoanghaiduong; Password=Yeutuan1";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();

            }
        }

        public static void closeConnect()
        {
            conn.Close();
        }
        //Đổ dữ liệu vào datable
        public static DataTable getData(string query)
        {
            createConnect();
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
            sqlDataAdapter.Fill(dataTable);
            closeConnect();
            return dataTable;

        }
    }
}
