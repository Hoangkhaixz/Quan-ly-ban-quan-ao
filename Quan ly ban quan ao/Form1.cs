using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quan_ly_ban_quan_ao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            string UserName = txtB_username.Text;
            string Password = txtB_pass.Text;

            // Kiểm tra đăng nhập từ CSDL
            string role = AuthenticateUser(UserName, Password);

            if (role == "Admin")
            {
                // Mở form dành cho Admin
                Form2 form2 = new Form2();
                form2.Show();                   //ADMIN
                this.Hide();
            }
            else if (role == "User")
            {
                // Mở form dành cho Người dùng
                FormUser form4 = new FormUser();
                form4.Show();                   //USER
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string AuthenticateUser(string UserName, string Password)
        {
            string connectionString = @"Data Source=LAPTOP-I70VJAFS\SQLEXPRESS;Initial Catalog=A4;Integrated Security=True;TrustServerCertificate=True";
            string role = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Role FROM Users WHERE UserName = @username AND Password = @password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", UserName);
                        cmd.Parameters.AddWithValue("@password", Password);

                        //sử dụng SqlDataAdapter để kiểm tra xem dữ liệu có trả về hay không
                        SqlDataAdapter adt = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adt.Fill(dt);

                        if (dt.Rows.Count > 0) // Nếu có kết quả
                        {
                            role = dt.Rows[0]["Role"].ToString(); // Lấy cột Role
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi kết nối SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Lỗi vận hành: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return role;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
