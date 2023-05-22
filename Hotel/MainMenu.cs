using BusinessLayer;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel
{
    public partial class MainMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private Hoadon hoadonForm;
        public string tenphong;
        Tang _tang;
        Phong _phong;
        bool thoat = true;
        GalleryItem item = null;
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
            if (thoat)
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
            HienThiPhong(false);
        }

        private void btnUnAvailable_ItemClick(object sender, ItemClickEventArgs e)
        {
            HienThiPhong(true);
        }
        private void HienThiPhong(bool status)
        {
            string connectionString = @"Data Source=SORA\PHUCTT;Initial Catalog=HotelManager;Integrated Security=True;";
            try
            {
                gridControl.Visible = true;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM PHONG WHERE Trangthai = @status";
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
            gControl.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside;
            gControl.Gallery.ImageSize = new Size(64, 64);
            gControl.Gallery.ShowItemText = true;
            gControl.Gallery.ShowGroupCaption = true;
            foreach (var t in lsTang)
            {
                var galleryItem = new GalleryItemGroup();
                galleryItem.Caption = t.Tentang;
                galleryItem.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch;
                var lsPhong = _phong.getByTang(t.IDtang);
                foreach (var p in lsPhong)
                {
                    var gc_item = new GalleryItem();
                    gc_item.Caption = p.Tenphong;
                    gc_item.Value = p.IDphong;
                    if (p.Trangthai == false)
                        gc_item.ImageOptions.Image = imageList1.Images[0];
                    else if (p.Trangthai == true)
                        gc_item.ImageOptions.Image = imageList1.Images[1];
                    galleryItem.Items.Add(gc_item);
                }
                gControl.Gallery.Groups.Add(galleryItem);
            }

        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            _tang = new Tang();
            _phong = new Phong();
            ShowRoom();
        }


        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            DatPhong datphong = new DatPhong();
            datphong.DatPhongCanceled += DatPhongCanceledHandler;
            datphong.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            HienThiPhong(true);
        }


        private void btnThanhToan_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (item != null)
            {

                hoadonForm = new Hoadon(tenphong);
                hoadonForm.HoadonCompleted += HoadonCompletedHandler;
                this.Hide();
                hoadonForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Thanh toán lỗi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void popupMenu1_Popup_1(object sender, EventArgs e)
        {
            Point point = gControl.PointToClient(Control.MousePosition);
            RibbonHitInfo hitInfo = gControl.CalcHitInfo(point);
            if (hitInfo.InGalleryItem || hitInfo.HitTest == RibbonHitTest.GalleryImage)
            {
                item = hitInfo.GalleryItem;
                tenphong = item.Caption.ToString();

            }
        }
 
        private void DatPhongCanceledHandler(object sender, EventArgs e)
        {
            UpdateRoomStatus();
        }
        private void HoadonCompletedHandler(object sender, EventArgs e)
        {
            UpdateRoomStatus();
        }
        private void UpdateRoomStatus()
        {
            gControl.Gallery.Groups.Clear();
            _tang = new Tang();
            _phong = new Phong();
            ShowRoom();
        }

        private void srcPhong_EditValueChanged(object sender, EventArgs e)
        {
            string srcphong = srcPhong.EditValue?.ToString();       
            gControl.Gallery.Groups.Clear();
            if( string.IsNullOrEmpty(srcphong))
            {
                ShowRoom();
            }
            else
            {
                BeginInvoke(new Action(() => HienThiPhongTimKiem(srcphong)));
            }

        }
        void HienThiPhongTimKiem(string srcphong)
        {

            List<GalleryItemGroup> filteredGroups = new List<GalleryItemGroup>();
            var lsTang = _tang.getAll();

            foreach (var t in lsTang)
            {
                var galleryItem = new GalleryItemGroup();
                galleryItem.Caption = t.Tentang;
                galleryItem.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch;

                var lsPhong = _phong.getByTang(t.IDtang);

                foreach (var p in lsPhong)
                {
                    if (p.Tenphong.Contains(srcphong))
                    {
                        var gc_item = new GalleryItem();
                        gc_item.Caption = p.Tenphong;
                        gc_item.Value = p.IDphong;

                        if (p.Trangthai == false)
                            gc_item.ImageOptions.Image = imageList1.Images[0];
                        else if (p.Trangthai == true)
                            gc_item.ImageOptions.Image = imageList1.Images[1];

                        galleryItem.Items.Add(gc_item);
                    }
                }
                if (galleryItem.Items.Count > 0)
                    filteredGroups.Add(galleryItem);
            }
            gControl.Gallery.Groups.AddRange(filteredGroups.ToArray());
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Thaydoi td = new Thaydoi();
            td.ShowDialog();
        }
    }
}

