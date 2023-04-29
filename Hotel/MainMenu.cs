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
using System.Data.SqlClient;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon;

namespace Hotel
{
    public partial class MainMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        Tang _tang;
        Phong _phong;
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
            MainMenu main = new MainMenu();
            this.Hide();
            this.Close();
            main.ShowDialog();  
        }

        private void btnAvailable_ItemClick(object sender, ItemClickEventArgs e)
        {
            HienThiPhong("Trống");
        }

        private void btnUnAvailable_ItemClick(object sender, ItemClickEventArgs e)
        {
            HienThiPhong("Đang thuê");
        }
        private void HienThiPhong(string status)
        {
            string connectionString = "Data Source=DESKTOP-LAUNSSS;Initial Catalog=HotelManager;Integrated Security=True;";
            try
            {
                gridControl.Visible = true;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM PHONG WHERE TrangThai = @status";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@status", status);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    gridControl.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        void ShowRoom()
        {
            var lsTang = _tang.getAll();
            Control.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside;
            Control.Gallery.ImageSize = new Size(64, 64);
            Control.Gallery.ShowItemText = true;
            Control.Gallery.ShowGroupCaption = true;
            foreach (var t in lsTang)
            {
                var galleryItem = new GalleryItemGroup();
                galleryItem.Caption = t.TenTang;
                galleryItem.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch;
                var lsPhong = _phong.getByTang(t.IDTang);
                foreach(var p in lsPhong)
                {
                    var gc_item = new GalleryItem();
                    gc_item.Caption = p.TenPhong;
                    gc_item.Value = p.IDPhong;
                    if (p.TrangThai == "Trống")
                        gc_item.ImageOptions.Image = imageList1.Images[0];
                    else if(p.TrangThai == "Đang thuê")
                        gc_item.ImageOptions.Image = imageList1.Images[1];
                    galleryItem.Items.Add(gc_item);
                }
                Control.Gallery.Groups.Add(galleryItem);
            }
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            _tang = new Tang();
            _phong = new Phong();
            ShowRoom();
        }


    }
}