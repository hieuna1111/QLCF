using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMemQLCafe.DAOModel;

namespace PhanMemQLCafe
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();

            //LoadAccountList();
        }

        void LoadAccountList()
        {
            /* SqlConnection connection = new SqlConnection(connectionStr); //Tạo kết nối

            //string query = "SELECT UserName as N'Tên tài khoản', PassWord as N'Mật khẩu' FROM dbo.Staff"; //Câu query truy vấn

            connection.Open(); //Mở connection

            SqlCommand command = new SqlCommand(query, connection); //Thực thi câu Query trên Connection

            DataTable data = new DataTable(); //Tạo vùng lưu dữ liệu theo dạng bảng

            SqlDataAdapter adapter = new SqlDataAdapter(command); //Trung gian thực hiện câu truy vấn

            adapter.Fill(data); //Đổ dữ liệu lấy ra 

            connection.Close();// Đóng connection tránh nhập nhằng dữ liệu

            //dtgvAccount.DataSource = data; //hiển thi dữ liệu về datagridview */

            //-----------------------------------------------------------------------------------------------------------------------
            //string query = "exec usp_GetAccountByUserName @userName";

            //DataProvider provider = new DataProvider();

            //dtgvAccount.DataSource = provider.ExecuteQuery(query, new object[] { "member0" });

            string query = "exec usp_GetAccountByUserName @userName";

            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { "member0" });
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
