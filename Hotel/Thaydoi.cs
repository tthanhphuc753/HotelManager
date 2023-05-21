using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel
{
    public partial class Thaydoi : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source = DESKTOP-N744942\SQLANH;Initial Catalog = HotelManager; Integrated Security = True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loading()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from LOAIPHONG ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dvg.DataSource = table;
        }
        public Thaydoi()
        {
            InitializeComponent();
        }

        private void Thaydoi_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loading();
        }

        private void dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dvg.CurrentRow.Index;
            txtloaiphong.Text = dvg.Rows[i].Cells[0].Value.ToString();
            txtgiatien.Text = dvg.Rows[i].Cells[1].Value.ToString();
            txtsonguoi.Text = dvg.Rows[i].Cells[2].Value.ToString();
        }

        private void them_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into LOAIPHONG values('" + txtloaiphong.Text + "', '" + txtgiatien.Text + "','" + txtsonguoi.Text + "')";
            command.ExecuteNonQuery();
            loading();
            MessageBox.Show("Thêm thành công", "Thông báo");
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                command = connection.CreateCommand();
                command.CommandText = "delete from LOAIPHONG where IDloaiphong= '" + txtloaiphong.Text + "'";
                command.ExecuteNonQuery();
                loading();
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update LOAIPHONG set Giatien = '" + txtgiatien.Text + "', Songuoimax = '" + txtsonguoi.Text + "' where IDloaiphong = '" + txtloaiphong.Text + "' ";
            command.ExecuteNonQuery();
            loading();
            MessageBox.Show("Sữa thành công", "Thông báo");
        }

        private void khoitao_Click(object sender, EventArgs e)
        {
            txtloaiphong.Text = "";
            txtgiatien.Text = "";
            txtsonguoi.Text = "";
        }
    }
}