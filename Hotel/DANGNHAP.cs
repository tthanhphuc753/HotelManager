using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using BusinessLayer; 
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
            Account _account = new Account();
            var accountList = _account.getAll();
            string username = txt_username.Text;
            int passw = int.Parse(txt_password.Text);
            foreach(var a in accountList)
            {
                bool flag = false; 
                if(a.Username == username && a.Password == passw)
                {
                    flag = true;  
                    thoat = false;
                    MainMenu menu = new MainMenu();
                    this.Hide();
                    menu.ShowDialog();
                }

                if(!flag)
                {                   
                    MessageBox.Show("Đăng nhập thất bại. Sai mật khẩu hoặc tài khoản !!");                 
                }
            }            
        }
        private void DANGNHAP_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thoat)
                Application.Exit();
        }
    }
}