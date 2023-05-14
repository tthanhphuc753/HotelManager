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
        string connectionString = "Data Source=DESKTOP-LAUNSSS;Initial Catalog=HotelManager;Integrated Security=True;";
        private void btnHuy_Click(object sender, EventArgs e)
        {
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
                    string query = "SELECT * FROM PHONG WHERE IDloaiphong = @loaiPhong ";//TrangThai = 'Trống' AND không biết tại sao thêm Trạng Thái trống thì lỗi nên ai biết thì sửa hộ nha
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

            // thu thập dữ liệu từ gridControl
            int phong = gridView1.FocusedRowHandle;
            char[] loaiphong = gridView1.GetRowCellValue(phong, "Loại Phòng").ToString().ToCharArray();
            string quoctich = cbQuocTich.SelectedItem.ToString();
            int songuoi = int.Parse(cbSoNguoi.SelectedItem.ToString());

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Giatien FROM LOAIPHONG WHERE IDloaiphong = @loaiphong";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@loaiphong", loaiphong); ;
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

    }
}
