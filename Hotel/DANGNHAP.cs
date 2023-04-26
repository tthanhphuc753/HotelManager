using DevExpress.XtraEditors;
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

namespace Hotel
{
    public partial class DANGNHAP : DevExpress.XtraEditors.XtraForm
    {
        public DANGNHAP()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=SORA\PHUCTT;Initial Catalog=HotelManager;Integrated Security=True");
            try
            {
                conn.Open();
                string username = txt_username.Text;
                string passw = txt_password.Text;
                string sql = "select *from TAIKHOAN where username ='" + username + "' and Password='" + passw + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader(); 
                
                if(dta.Read() )
                {
                    MessageBox.Show("Đăng nhập thành công");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại. Sai mật khẩu hoặc tài khoản !!");
                }

            }catch(Exception ex)
            {
                MessageBox.Show("ĐĂng nhập thất bại ");
            }
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

      
        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void DANGNHAP_Load(object sender, EventArgs e)
        {

        }
    }
}