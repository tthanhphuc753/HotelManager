using System;
using System.Data.SqlClient;
namespace Hotel
{
    public partial class Hoadon : DevExpress.XtraEditors.XtraForm
    {

        public Hoadon(string tenphong)
        {
            InitializeComponent();
            laythongtin(tenphong);
          
        }
        string idHoadon = "";
        string Tenphong = ""; 
        string connectionString = @"Data Source=SORA\PHUCTT;Initial Catalog=HotelManager;Integrated Security=True;";

        private void laythongtin(string tenphong)
        {
            lblPhong.Text = tenphong;
            string idkhachhang = "";
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                Tenphong = tenphong; 

                string query = "SELECT HD.IDhoadon, HD.IDkhachhang, HD.Ngaydat, HD.Ngaytra, HD.Songayo, HD.Tongtien, LP.IDloaiphong " +
                 "FROM HOADON HD " +
                 "INNER JOIN PHONG P ON HD.IDphong = P.IDphong " +
                 "INNER JOIN LOAIPHONG LP ON P.IDloaiphong = LP.IDloaiphong " +
                 "WHERE P.Tenphong = @tenphong AND HD.Trangthai = 0;";



                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tenphong", tenphong);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        { 
                            lblIdkhachhang.Text = reader["IDkhachhang"].ToString();
                            idkhachhang = lblIdkhachhang.Text;
                            lblIDhoadon.Text = reader["IDhoadon"].ToString();
                            idHoadon = lblIDhoadon.Text; 
                            lblNgaydatphong.Text = reader["NgayDat"].ToString();
                            lblNgaytraphong.Text = reader["NgayTra"].ToString();
                            lblLoaiphong.Text = reader["IDloaiphong"].ToString();
                            txtThanhtien.Text = reader["Tongtien"].ToString(); 

                        }
                    }
                }
                string hvtquery = "SELECT Tenkhachhang, [CCCD/CMND] " +
                  "FROM KHACHHANG " +
                  "WHERE IDkhachhang = @idkhachhang;";

                using (SqlCommand cmd1 = new SqlCommand(hvtquery, conn))
                {
                    cmd1.Parameters.AddWithValue("@idkhachhang", idkhachhang);
                    using (SqlDataReader reader1 = cmd1.ExecuteReader())
                    {
                        if (reader1.Read())
                        {
                            lblHovaten.Text = reader1["Tenkhachhang"].ToString();
                            lblCmnd.Text = reader1["CCCD/CMND"].ToString();
                        }
                    }

                }
                string infoquery = "SELECT Tenkhachhang, [CCCD/CMND] " +
                  "FROM KHACHHANG " +
                  "WHERE IDkhachhang = @idkhachhang;";

                using (SqlCommand cmd1 = new SqlCommand(infoquery, conn))
                {
                    cmd1.Parameters.AddWithValue("@idkhachhang", idkhachhang);
                    using (SqlDataReader reader1 = cmd1.ExecuteReader())
                    {
                        if (reader1.Read())
                        {
                            lblHovaten.Text = reader1["Tenkhachhang"].ToString();
                            lblCmnd.Text = reader1["CCCD/CMND"].ToString();
                        }
                    }

                }
                
            }
        }



        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Hide();

        }
       
        private void btn_xuathoadon_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                string updateHoadonquery = "UPDATE HOADON SET Trangthai = 1 WHERE IDhoadon = @idhoadon;";
                SqlCommand updateHoadonCommand = new SqlCommand(updateHoadonquery, connection);
                updateHoadonCommand.Parameters.AddWithValue("@idhoadon", idHoadon);
                updateHoadonCommand.ExecuteNonQuery();
                string updatePhongQuery = "UPDATE PHONG SET Trangthai = 0 WHERE Tenphong = @tenphong;";
                SqlCommand updatePhongCommand = new SqlCommand(updatePhongQuery, connection);
                updatePhongCommand.Parameters.AddWithValue("@tenphong", Tenphong);
                updatePhongCommand.ExecuteNonQuery();
                this.Hide();
            }
        }
    }
}









