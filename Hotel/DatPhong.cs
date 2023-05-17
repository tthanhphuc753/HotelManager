using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel
{
    public partial class DatPhong : Form
    {
        public DatPhong()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=SORA\\PHUCTT;Initial Catalog=HotelManager;Integrated Security=True;";
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DatPhong_Load(object sender, EventArgs e)
        {
            txtTongTien.Text = "3000";
        }

        private void radioButtonA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonA.Checked)
            {
                HienThiPhong("A"); 
            }
        }

        private void radioButtonB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonB.Checked)
            {
                HienThiPhong("B"); 
            }
        }
            
        private void radioButtonC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonC.Checked)
            {
                HienThiPhong("C");
            }
        }
        private void HienThiPhong(string loaiPhong)
        {
            
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM PHONG WHERE IDloaiphong = @loaiPhong AND Trangthai = 0";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@loaiPhong", loaiPhong);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    gControl.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void cbSoNguoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void TinhTongTien()
        {   // tính số ngày đặt phòng
            DateTime NgayDat = dtNgayDat.Value;
            DateTime NgayTra = dtNgayTra.Value;
            int songay = (int)(NgayTra - NgayDat).TotalDays;

            int phong = gridView1.FocusedRowHandle;
            string loaiphong = gridView1.GetRowCellValue(phong, "IDloaiphong").ToString();
            string quoctich = cbQuocTich.SelectedItem.ToString();
            int songuoi = int.Parse(cbSoNguoi.SelectedItem.ToString());

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Giatien FROM LOAIPHONG WHERE IDloaiphong = @loaiphong ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@loaiphong", loaiphong);
                decimal giaphong = (decimal)command.ExecuteScalar();
                decimal tong = giaphong * songay ;

                if (quoctich == "Nội địa" && songuoi == 3)
                {
                    tong += tong * 0.25m;
                }
                else if (quoctich == "Nước ngoài")
                {
                    tong *= 1.5m;
                }
                txtTongTien.Text = tong.ToString();
            }
            

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string hoten = txtHoTen.Text;
            string cccd = txtCCCD.Text;
            string quoctich = cbQuocTich.SelectedItem.ToString();
            bool Isnuocngoai = (cbQuocTich.SelectedItem.ToString() == "Nước ngoài");

            DateTime NgayDat = dtNgayDat.Value;
            DateTime NgayTra = dtNgayTra.Value;
            int songay = (int)(NgayTra - NgayDat).TotalDays;

            int idphong = 0;
            int phong = gridView1.FocusedRowHandle;
            string tenphong = gridView1.GetRowCellValue(phong, "Tenphong").ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string insertKhachHangQuery = "INSERT INTO KHACHHANG (Tenkhachhang, [CCCD/CMND], Loaikhach) VALUES (@hoten, @cccd, @Isnuocngoai); SELECT SCOPE_IDENTITY();";
                SqlCommand insertKhachHangCommand = new SqlCommand(insertKhachHangQuery, connection);
                insertKhachHangCommand.Parameters.AddWithValue("@hoten", hoten);
                insertKhachHangCommand.Parameters.AddWithValue("@cccd", cccd);
                insertKhachHangCommand.Parameters.AddWithValue("@Isnuocngoai", Isnuocngoai);
                int idkhachhang = Convert.ToInt32(insertKhachHangCommand.ExecuteScalar());

                string getPhongIdQuery = "SELECT IDphong FROM PHONG WHERE Tenphong = @tenphong;";
                SqlCommand getPhongIdCommand = new SqlCommand(getPhongIdQuery, connection);
                getPhongIdCommand.Parameters.AddWithValue("@tenphong", tenphong);
                idphong = Convert.ToInt32(getPhongIdCommand.ExecuteScalar());

                string insertDatPhongQuery = "INSERT INTO DATPHONG (IDkhachhang, IDphong, Ngaydat, Ngaytra, Songayo) VALUES (@idkhachhang, @idphong, @NgayDat, @NgayTra, @songay);";
                SqlCommand insertDatPhongCommand = new SqlCommand(insertDatPhongQuery, connection);
                insertDatPhongCommand.Parameters.AddWithValue("@idkhachhang", idkhachhang);
                insertDatPhongCommand.Parameters.AddWithValue("@idphong", idphong);
                insertDatPhongCommand.Parameters.AddWithValue("@NgayDat", NgayDat);
                insertDatPhongCommand.Parameters.AddWithValue("@NgayTra", NgayTra);
                insertDatPhongCommand.Parameters.AddWithValue("@songay", songay);
                insertDatPhongCommand.ExecuteNonQuery();

                string updatePhongQuery = "UPDATE PHONG SET Trangthai = 1 WHERE Tenphong = @tenphong;";
                SqlCommand updatePhongCommand = new SqlCommand(updatePhongQuery, connection);
                updatePhongCommand.Parameters.AddWithValue("@tenphong", tenphong);
                updatePhongCommand.ExecuteNonQuery();

                connection.Close();
            }
            MessageBox.Show("Lưu thành công");

           
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            txtTongTien.Text = "3000";
        }
    }
}
