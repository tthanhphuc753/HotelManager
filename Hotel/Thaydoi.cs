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
        SqlCommand commandGiatien; 
        string str = @"Data Source = SORA\PHUCTT;Initial Catalog = HotelManager; Integrated Security = True";
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
            try
            {

                command.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("thiếu dữ liệu ");
            }
            loading();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                command = connection.CreateCommand();
                command.CommandText = "delete from LOAIPHONG where IDloaiphong= '" + txtloaiphong.Text + "'";
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Thông báo");

                }
                catch(SqlException)
                {
                    MessageBox.Show("thiếu dữ liệu ");
                }
                loading();
            }
        }
       
        private void sua_Click(object sender, EventArgs e)
        {
            commandGiatien = connection.CreateCommand();
            command = connection.CreateCommand();
            commandGiatien.CommandText = "update LOAIPHONG set Giatien = '" + txtgiatien.Text + "' where IDloaiphong = '" + txtloaiphong.Text + "' ";
            command.CommandText = "update LOAIPHONG set Songuoimax = '" + txtsonguoi.Text + "' where IDloaiphong = '" + txtloaiphong.Text + "' ";
           
            if(txtgiatien.Text != "" && txtloaiphong.Text!="" || txtsonguoi.Text != "" && txtloaiphong.Text!="")
            {

                if(txtgiatien.Text!="")
                {
                    commandGiatien.ExecuteNonQuery();
                }

                if(txtsonguoi.Text!="")
                {
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Sửa thành công", "Thông báo");
            }
            else if(txtgiatien.Text == "" && txtsonguoi.Text == "" || txtloaiphong.Text== "")
            {
                MessageBox.Show("dữ liệu trống");
            }
            
            loading();
        }

        private void khoitao_Click(object sender, EventArgs e)
        {
            txtloaiphong.Text = "";
            txtgiatien.Text = "";
            txtsonguoi.Text = "";
        }
    }
}