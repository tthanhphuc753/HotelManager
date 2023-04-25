using DataLayer;
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
    public partial class frmketnoidb : DevExpress.XtraEditors.XtraForm
    {
        public frmketnoidb()
        {
            InitializeComponent();
        }

      
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection GetCon(string server, string database)
        {
            return new SqlConnection("Data Source=" + server + "; Initial Catalog=" + database + "; Integrated Security=true;");
        }


        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=" + txtServer.Text + ";Database=" + cboDatabase.Text + ";Trusted_Connection=True;");
            try
            {
                con.Open();
                MessageBox.Show("Kết nối thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string enCryptServ = Encryptor.Encrypt(txtServer.Text, "qwertyuiop", true);
            
            string enCryptData = Encryptor.Encrypt(cboDatabase.Text, "qwertyuiop", true);

            connect cn = new connect(enCryptServ, enCryptData);
            cn.SaveFile();
            MessageBox.Show("Lưu file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cboDatabase_MouseClick(object sender, MouseEventArgs e)
        {
            cboDatabase.Items.Clear();
            try
            {
                string Conn = "Data Source=" + txtServer.Text + "; Initial Catalog=" + cboDatabase.Text + "; Integrated Security=True;";
                SqlConnection con = new SqlConnection(Conn);
                con.Open();
                string sql = "select name from sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')";
                SqlCommand cmd = new SqlCommand(sql, con);
                IDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cboDatabase.Items.Add(dr[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}