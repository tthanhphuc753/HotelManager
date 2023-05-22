using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BusinessLayer; 

namespace Hotel
{
    public partial class DatPhong : Form
    {

        public event EventHandler DatPhongCanceled;

        public DatPhong()
        {
            InitializeComponent();
        }
        

        string connectionString = @"Data Source=DESKTOP-GUVFKN1\SQLNGHIA;Initial Catalog=HotelManager;Integrated Security=True;";
        SqlConnection sqlcon = null;
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DatPhongCanceled?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void DatPhong_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonA.Checked)
            {
                HienThiPhong("A");
                cbSoNguoi.Visible = true; 
            }
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(connectionString);
            }
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from LOAIPHONG where IDloaiphong = 'A'";

            command.Connection = sqlcon;

            cbSoNguoi.Items.Clear();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int songmax = reader.GetInt32(2);

                for (int i = 0; i < songmax; i++)
                {
                    cbSoNguoi.Items.Add(i + 1);
                }
            }
            reader.Close();

        
    }

        private void radioButtonB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonB.Checked)
            {
                HienThiPhong("B");
                cbSoNguoi.Visible = true;
            }
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(connectionString);
            }
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from LOAIPHONG where IDloaiphong = 'B'";

            command.Connection = sqlcon;

            cbSoNguoi.Items.Clear();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int songmax = reader.GetInt32(2);

                for (int i = 0; i < songmax; i++)
                {
                    cbSoNguoi.Items.Add(i + 1);
                }
            }
            reader.Close();
        }

        private void radioButtonC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonC.Checked)
            {
                HienThiPhong("C");
                cbSoNguoi.Visible = true;
            }
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(connectionString);
            }
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from LOAIPHONG where IDloaiphong = 'C'";

            command.Connection = sqlcon;

            cbSoNguoi.Items.Clear();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int songmax = reader.GetInt32(2);

                for (int i = 0; i < songmax; i++)
                {
                    cbSoNguoi.Items.Add(i + 1);
                }
            }
            reader.Close();
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


        private void TinhTongTien()
        {   // tính số ngày đặt phòng
            DateTime NgayDat = dtNgayDat.Value;
            DateTime NgayTra = dtNgayTra.Value;
            int songay = (int)(NgayTra - NgayDat).TotalDays + 1;
            string quoctich ="";
            int phong = gridView1.FocusedRowHandle;
            string loaiphong = gridView1.GetRowCellValue(phong, "IDloaiphong").ToString();
            quoctich = cbQuocTich.SelectedItem?.ToString();
            int songuoi = int.Parse(cbSoNguoi.SelectedItem.ToString());

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Giatien FROM LOAIPHONG WHERE IDloaiphong = @loaiphong ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@loaiphong", loaiphong);
                decimal giaphong = (decimal)command.ExecuteScalar();
                decimal tong = giaphong * songay;

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
            if (txtHoTen.Text != "" && txtCCCD.Text != "" && txtDiaChi.Text != "" && cbQuocTich.Text != "" && cbGioiTinh.Text != "" && cbSoNguoi.Text != "")
            {
                string hoten = txtHoTen.Text;
                string cccd = txtCCCD.Text;
                string diachi = txtDiaChi.Text;
                string quoctich = cbQuocTich.SelectedItem.ToString();
                bool Isnuocngoai = (cbQuocTich.SelectedItem.ToString() == "Nước ngoài");

                DateTime NgayDat = dtNgayDat.Value;
                DateTime NgayTra = dtNgayTra.Value;
                int songay = (int)(NgayTra - NgayDat).TotalDays;
                decimal Tongtien = decimal.Parse(txtTongTien.Text);

                int idphong = 0;
                int phong = gridView1.FocusedRowHandle;
                string tenphong = gridView1.GetRowCellValue(phong, "Tenphong").ToString();
                if (MessageBox.Show("Bạn có chắc thông tin chính xác chưa?", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                   
                  using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string insertKhachHangQuery = "INSERT INTO KHACHHANG (Tenkhachhang, [CCCD/CMND], Diachi, Loaikhach) VALUES (@hoten, @cccd, @diachi, @Isnuocngoai); SELECT SCOPE_IDENTITY();";
                        SqlCommand insertKhachHangCommand = new SqlCommand(insertKhachHangQuery, connection);
                        insertKhachHangCommand.Parameters.AddWithValue("@hoten", hoten);
                        insertKhachHangCommand.Parameters.AddWithValue("@cccd", cccd);
                        insertKhachHangCommand.Parameters.AddWithValue("@diachi", diachi);
                        insertKhachHangCommand.Parameters.AddWithValue("@Isnuocngoai", Isnuocngoai);
                        int idkhachhang = Convert.ToInt32(insertKhachHangCommand.ExecuteScalar());

                        string getPhongIdQuery = "SELECT IDphong FROM PHONG WHERE Tenphong = @tenphong;";
                        SqlCommand getPhongIdCommand = new SqlCommand(getPhongIdQuery, connection);
                        getPhongIdCommand.Parameters.AddWithValue("@tenphong", tenphong);
                        idphong = Convert.ToInt32(getPhongIdCommand.ExecuteScalar());

                        string insertDatPhongQuery = "INSERT INTO HOADON (IDkhachhang, IDphong, Ngaydat, Ngaytra, Songayo,Tongtien) VALUES (@idkhachhang, @idphong, @NgayDat, @NgayTra, @songay,@tongtien);";
                        SqlCommand insertDatPhongCommand = new SqlCommand(insertDatPhongQuery, connection);
                        insertDatPhongCommand.Parameters.AddWithValue("@idkhachhang", idkhachhang);
                        insertDatPhongCommand.Parameters.AddWithValue("@idphong", idphong);
                        insertDatPhongCommand.Parameters.AddWithValue("@NgayDat", NgayDat);
                        insertDatPhongCommand.Parameters.AddWithValue("@NgayTra", NgayTra);
                        insertDatPhongCommand.Parameters.AddWithValue("@songay", songay);
                        insertDatPhongCommand.Parameters.AddWithValue("@tongtien", Tongtien);
                        insertDatPhongCommand.Parameters.AddWithValue("@songayo", songay);

                        insertDatPhongCommand.ExecuteNonQuery();
                        string updateHoadonquery = "UPDATE HOADON SET Trangthai = 0 WHERE IDphong = (SELECT IDphong FROM PHONG WHERE Tenphong = @tenphong)";

                        string updatePhongQuery = "UPDATE PHONG SET Trangthai = 1 WHERE Tenphong = @tenphong;";

                        SqlCommand updatePhongCommand = new SqlCommand(updatePhongQuery, connection);
                        SqlCommand updateHoadonCommand = new SqlCommand(updateHoadonquery, connection);

                        updatePhongCommand.Parameters.AddWithValue("@tenphong", tenphong);
                        updateHoadonCommand.Parameters.AddWithValue("@tenphong", tenphong);

                        updateHoadonCommand.ExecuteNonQuery();
                        updatePhongCommand.ExecuteNonQuery();

                        connection.Close();
                    }
                    MessageBox.Show("Lưu thành công");
                }
                
            }
            else { MessageBox.Show("Cần điền đầy đủ thông tin", "Thông báo"); }
            

        }

        private void cbSoNguoi_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {

                TinhTongTien();
            }
            catch(Exception exx)
            {
                MessageBox.Show("vui lòng chọn Quốc tịch");
            }
        }

        private void gControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
