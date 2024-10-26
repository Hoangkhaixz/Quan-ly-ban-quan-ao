using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace Quan_ly_ban_quan_ao
{

    public partial class FormUser : Form
    {
        // Chuỗi kết nối đến cơ sở dữ liệu
        string connectstring = @"Data Source=LAPTOP-I70VJAFS\SQLEXPRESS;Initial Catalog=A1;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection con; // Đối tượng kết nối SQL
        SqlCommand cmd; // Đối tượng lệnh SQL
        SqlDataAdapter adt; // Đối tượng để lấy dữ liệu từ DB
        DataTable dt = new DataTable(); // Bảng dữ liệu để lưu trữ sản phẩm
        public FormUser()
        {
            InitializeComponent();

        }
        private void FormUser_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectstring); // Khởi tạo kết nối với cơ sở dữ liệu
            try
            {
                con.Open(); // Mở kết nối
                cmd = new SqlCommand("select * from Products", con); // Tạo lệnh SQL để lấy tất cả sản phẩm
                adt = new SqlDataAdapter(cmd); // Tạo SqlDataAdapter từ lệnh
                adt.Fill(dt); // Điền dữ liệu vào DataTable
                GrView_spUser.DataSource = dt; // Gán DataTable cho DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Hiển thị thông báo lỗi nếu có
            }
            finally
            {
                con.Close(); // Đóng kết nối
            }
        }

        private void GrView_spUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu chỉ số dòng hợp lệ
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = GrView_spUser.Rows[e.RowIndex];

                // Hiển thị dữ liệu trong TextBox
                try
                {
                    // Gán giá trị từ dòng được chọn vào các TextBox tương ứng
                    txtB_idSP.Text = selectedRow.Cells["ProductID"].Value.ToString();
                    txtB_nameSP.Text = selectedRow.Cells["ProductName"].Value.ToString();
                    txtB_sizeSP.Text = selectedRow.Cells["SizeProduct"].Value.ToString();
                    txtB_sellSP.Text = selectedRow.Cells["SellingPrice"].Value.ToString();
                    txtB_inventorySP.Text = selectedRow.Cells["InventoryPrice"].Value.ToString();

                    // Hiển thị hình ảnh trong PictureBox
                    if (selectedRow.Cells["ProductImage"].Value != DBNull.Value)
                    {
                        byte[] imageData = (byte[])selectedRow.Cells["ProductImage"].Value; // Lấy dữ liệu hình ảnh
                        if (imageData != null && imageData.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(imageData)) // Chuyển đổi byte array thành hình ảnh
                            {
                                picB_imageProduct.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            picB_imageProduct.Image = null; // Hoặc hình ảnh mặc định
                        }
                    }
                    else
                    {
                        picB_imageProduct.Image = null; // Hoặc hình ảnh mặc định
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message); // Hiển thị thông báo lỗi nếu có
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string productId = txtB_searchSP.Text.Trim(); // Lấy ID sản phẩm từ TextBox

            if (!string.IsNullOrEmpty(productId)) // Kiểm tra ID không rỗng
            {
                using (SqlConnection con = new SqlConnection(connectstring)) // Tạo kết nối mới
                {
                    try
                    {
                        con.Open(); // Mở kết nối
                                    // Tạo truy vấn để lấy thông tin sản phẩm theo ProductID
                        string query = "SELECT ProductID, ProductName, SizeProduct, InventoryPrice, SellingPrice, ProductImage FROM Products WHERE ProductID = @ProductID";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@ProductID", productId); // Thêm tham số ProductID
                            SqlDataReader reader = cmd.ExecuteReader(); // Thực thi truy vấn

                            if (reader.Read()) // Nếu có dữ liệu trả về
                            {
                                // Lấy thông tin sản phẩm
                                string id = reader["ProductID"].ToString();
                                string name = reader["ProductName"].ToString();
                                string size = reader["SizeProduct"].ToString();
                                decimal inventoryQuantity = reader.GetDecimal(reader.GetOrdinal("InventoryPrice")); // Số lượng tồn kho
                                decimal sellingPrice = reader.GetDecimal(reader.GetOrdinal("SellingPrice")); // Giá bán

                                // Hiển thị thông tin sản phẩm
                                MessageBox.Show($"Thông tin sản phẩm:\nID: {id}\nTên: {name}\nKích thước: {size}\nSố lượng tồn kho: {inventoryQuantity}\nGiá bán: {sellingPrice:VND}");
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy sản phẩm với ID: " + productId); // Thông báo nếu không tìm thấy
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Database error: {ex.Message}"); // Hiển thị lỗi cơ sở dữ liệu nếu có
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ID sản phẩm để tìm kiếm."); // Thông báo nếu ID rỗng
            }
        }
        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (GrView_spUser.SelectedRows.Count > 0) // Kiểm tra xem có dòng nào được chọn không
            {
                // Lấy dòng sản phẩm được chọn
                var selectedProductRow = GrView_spUser.SelectedRows[0];

                // Lấy thông tin sản phẩm
                string productId = selectedProductRow.Cells["ProductID"].Value.ToString();
                string productname = selectedProductRow.Cells["ProductName"].Value.ToString();
                decimal sellingPrice = Convert.ToDecimal(selectedProductRow.Cells["SellingPrice"].Value); // Giá bán
                decimal inventoryQuantity = Convert.ToDecimal(selectedProductRow.Cells["InventoryPrice"].Value); // Số lượng tồn kho

                // Kiểm tra số lượng tồn kho
                if (inventoryQuantity <= 0)
                {
                    MessageBox.Show("Sản phẩm đã hết hàng. Không thể thanh toán.");
                    return; // Thoát nếu hết hàng
                }

                // Lấy số lượng bán ra từ TextBox
                if (!int.TryParse(txtB_Quantity.Text, out int quantitySold) || quantitySold <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng bán ra hợp lệ."); // Thông báo nếu số lượng không hợp lệ
                    return; // Thoát nếu không hợp lệ
                }

                // Kiểm tra số lượng bán ra không vượt quá số lượng tồn kho
                if (quantitySold > inventoryQuantity)
                {
                    MessageBox.Show("Số lượng bán ra không được vượt quá số lượng tồn kho.");
                    btn_pay.Enabled = false;
                }

                // Tính tổng giá trị bán
                decimal totalPrice = sellingPrice * quantitySold;
                // Ghi ngày bán
                DateTime saleDate = DateTime.Now;
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn thanh toán cho sản phẩm:\n\nID: {productId}\n Name: {productname}\n Giá: {sellingPrice:C}\nSố lượng tồn kho: {inventoryQuantity}\nTotal: {totalPrice}\n\nNhấn OK để xác nhận.", "Xác Nhận Thanh Toán", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    // Thực hiện thanh toán
                    MessageBox.Show("Thanh toán thành công cho sản phẩm: " + productname);
                    // Cập nhật số lượng tồn kho
                    UpdateInventory(productId, inventoryQuantity - 1);
                    LoadProducts();

                    FormUser form4 = new FormUser();
                    form4.Show();

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để thanh toán."); // Thông báo nếu không có dòng nào được chọn
            }
        }
        private void UpdateInventory(string productId, decimal newQuantity)
        {
            string connectionString = @"Data Source=LAPTOP-I70VJAFS\SQLEXPRESS;Initial Catalog=A1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Products SET InventoryPrice = @NewQuantity WHERE ProductID = @ProductID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm các tham số
                    command.Parameters.AddWithValue("@NewQuantity", newQuantity);
                    command.Parameters.AddWithValue("@ProductID", productId);

                    command.ExecuteNonQuery(); // Thực thi câu lệnh UPDATE
                }
            }
        }
        private void LoadProducts()
        {
            dt.Clear(); // Xóa dữ liệu cũ trong DataTable
            using (SqlConnection con = new SqlConnection(connectstring)) // Tạo kết nối mới
            {
                try
                {
                    con.Open(); // Mở kết nối
                    cmd = new SqlCommand("SELECT * FROM Products", con); // Tạo lệnh SQL để lấy tất cả sản phẩm
                    adt = new SqlDataAdapter(cmd); // Tạo SqlDataAdapter từ lệnh
                    adt.Fill(dt); // Điền dữ liệu vào DataTable
                    GrView_spUser.DataSource = dt; // Gán DataTable cho DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); // Hiển thị thông báo lỗi nếu có
                }
            }
        }
    }
}
