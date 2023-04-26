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
            this.Close();
            DANGNHAP login = new DANGNHAP();
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

        }

        private void btnUnAvailable_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

    }
}