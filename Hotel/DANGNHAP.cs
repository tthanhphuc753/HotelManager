using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel
{
    public partial class DANGNHAP : DevExpress.XtraEditors.XtraForm
    {
        public DANGNHAP()
        {
            InitializeComponent();
        }

        bool thoat = true;



        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N744942\SQLANH;Initial Catalog=HotelManager;Integrated Security=True");
            try
            {
                conn.Open();
                string username = txt_username.Text;
                string passw = txt_password.Text;
                string sql = "select *from TAIKHOAN where username ='" + username + "' and Password='" + passw + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();

                if (dta.Read())
                {
                    thoat = false;
                    MainMenu menu = new MainMenu();
                    this.Hide();
                    menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại. Sai mật khẩu hoặc tài khoản !!");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Đăng nhập thất bại ");
            }


        }

        private void DANGNHAP_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thoat)
                Application.Exit();
        }
    }
}