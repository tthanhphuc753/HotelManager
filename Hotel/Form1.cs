using BusinessLayer;
using System;



namespace Hotel
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Account account = new Account();
            gridControl1.DataSource = account.getAll();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
