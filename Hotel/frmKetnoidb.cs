using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class frmKetnoidb : DevExpress.XtraEditors.XtraForm
    {
        public frmKetnoidb()
        {
            InitializeComponent();
        }
        SqlConnection GetCon(string server, string username, string pass, string database)
        {
            return new SqlConnection("Data Source=" + server + "; Initial Catalog=" + database + "; User ID=" + username + "; Password=" + pass + ";");
        }

        private void frmKetnoidb_Load_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKiemtra_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = GetCon(txtservername.Text, txtusername.Text, txtpassw.Text, cboDatab.Text);
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


        private void btnLuufile_Click(object sender, EventArgs e)
        {

            string enCryptServ = Encryptor.Encrypt(txtservername.Text, "qwertyuiop", true);
            string enCryptPass = Encryptor.Encrypt(txtpassw.Text, "qwertyuiop", true);
            string enCryptData = Encryptor.Encrypt(cboDatab.Text, "qwertyuiop", true);
            string enCryptUser = Encryptor.Encrypt(txtusername.Text, "qwertyuiop", true);
            connect cn = new connect(enCryptServ, enCryptUser, enCryptPass, enCryptData);
            cn.SaveFile();
            MessageBox.Show("Lưu file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboDatab_MouseClick(object sender, MouseEventArgs e)
        {
            cboDatab.Items.Clear();
            try
            {
                string Conn = "server=" + txtservername.Text + ";User Id=" + txtusername.Text + ";pwd=" + txtpassw.Text + ";";
                SqlConnection con = new SqlConnection(Conn);
                con.Open();
                string sql = "select name from sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')";
                SqlCommand cmd = new SqlCommand(sql, con);
                IDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cboDatab.Items.Add(dr[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}