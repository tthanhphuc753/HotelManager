using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace Hotel
{
    public partial class MainMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        bool thoat = true;
        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            thoat = false;
            DANGNHAP login = new DANGNHAP();
            this.Hide();
            this.Close();
            login.ShowDialog();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if( thoat)
            Application.Exit();
        }
        private void btnHome_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnAvailable_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridphong.Visible = true; 
            Account account = new Account();
            gridphong.DataSource = account.getAll();
        }

        private void btnUnAvailable_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Tang tang = new BusinessLayer.Tang();

        }
    }
}