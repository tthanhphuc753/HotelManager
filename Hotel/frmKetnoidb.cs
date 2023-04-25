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
        SqlConnection Getcon(string server, string database)
        {
            return new SqlConnection("Data Source=" + server + ";Initial Catalog=master;Integrated Security=True");
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmKetnoidb_Load(object sender, EventArgs e)
        {

        }

        private void btnkiemtraketnoi_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Getcon(txtServer.Text, cbodatabase.Text);
            try
            {
                conn.Open();
                MessageBox.Show("kết nối thành công "); 


            }catch(Exception )
            {
                MessageBox.Show("Kết nối thất bại "); 
            }
        }

        private void btnDocfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Chọn tập tin ";
            op.Filter = "Text File (*.dba)|*.dba| ALLFiles(*.*)|*.*";
            if(op.ShowDialog()== DialogResult.OK)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.Open(op.FileName, FileMode.Open, FileAccess.Read);
                connect conn = (connect)bf.Deserialize(fs);
                string srv = Encryptor.Decrypt(conn.servername, "fsfuoufsd8935@!", true);
                string db = Encryptor.Decrypt(conn.database, "fsfuoufsd8935@!", true);
                txtServer.Text = srv;
                cbodatabase.Text = db; 
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbodatabase_MouseClick(object sender, MouseEventArgs e)
        {
            cbodatabase.Items.Clear();
            string conn = "Data Source=" + txtServer.Text + ";Initial Catalog=master;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string gr = "SELECT NAME FROM SYS.DATABASES";
            SqlCommand cmd = new SqlCommand(gr, con);
            IDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbodatabase.Items.Add(dr[0].ToString());
            }

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string svEncrypt = Encryptor.Encrypt(txtServer.Text, "fsfuoufsd8935@!", true);
            string dtEncrypt = Encryptor.Encrypt(cbodatabase.Text, "fsfuoufsd8935@!", true);
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Chọn nơi lưu trữ";
            sf.Filter = "Text File (*.dba)|*.dba| ALLFiles(*.*)|*.*";
            if(sf.ShowDialog() ==DialogResult.OK)
            {
                connect cn = new connect(svEncrypt,dtEncrypt);
                cn.SaveFile(sf.FileName);
                MessageBox.Show("Lưu file thành công! ");
            }
        }
    }
}