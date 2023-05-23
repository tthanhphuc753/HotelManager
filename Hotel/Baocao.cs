using BusinessLayer;
using DataLayer;
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
    public partial class Baocao : Form
    {
        public Baocao()
        {
            InitializeComponent();
        }
        public class Baocaodt
        {
            public string loaiPhong { get; set; }
            public decimal doanhThu { get; set; }
            public decimal tyLe { get; set; }
        }
        public class Baocaomdsdp
        {
            public string tenPhong { get; set; }
            public decimal soNgayThue { get; set; }
            public decimal tyLe { get; set; }
        }
        Phong _phong;
        HoaDon _hoadon;
        LoaiPhong _loaiphong;
        private void Baocaodoanhthutheoloaiphong()
        {

            DateTime tungay = dttungay.Value;
            DateTime denngay = dtdenngay.Value;
            var lsloaiphong = _loaiphong.getAll();
            var lshoadon = _hoadon.getAll();
            var lsphong = _phong.getAll();
            decimal tong = 0;
            foreach (var hd1 in lshoadon)
            {
                if (hd1.Ngaydat >= tungay && hd1.Ngaytra <= denngay)
                {
                    tong = tong + (decimal)hd1.Tongtien;
                }
            }
            List<Baocaodt> ds = new List<Baocaodt>();
            foreach (var lp in lsloaiphong)
            {
                Baocaodt bc;
                decimal doanhthu = 0;
                foreach (var hd in lshoadon)
                {
                    foreach (var p in lsphong)
                    {
                        if (hd.IDphong == p.IDphong)
                        {
                            if (lp.IDloaiphong == p.IDloaiphong)
                            {
                                if (hd.Ngaydat >= tungay && hd.Ngaytra <= denngay)
                                {
                                    doanhthu = doanhthu + (decimal)hd.Tongtien;
                                }
                            }
                        }
                    }
                }
                bc = new Baocaodt() { loaiPhong = lp.IDloaiphong, doanhThu = doanhthu, tyLe = doanhthu / tong * 100 };
                ds.Add(bc);
            }
            dataGridView1.DataSource = ds;
        }
        private void Baocaomatdosudungphong()
        {
            DateTime tungay = dttungay.Value;
            DateTime denngay = dtdenngay.Value;
            var lshoadon = _hoadon.getAll();
            var lsphong = _phong.getAll();

            decimal tong = 0;
            foreach (var hd1 in lshoadon)
            {
                if (hd1.Ngaydat >= tungay && hd1.Ngaytra <= denngay)
                {
                    tong = tong + (decimal)hd1.Songayo;
                }
            }
            List<Baocaomdsdp> ds = new List<Baocaomdsdp>();
            foreach (var p in lsphong)
            {
                Baocaomdsdp bc;
                int songaythue = 0;
                foreach (var hd in lshoadon)
                {
                    if (p.IDphong == hd.IDphong)
                    {
                        if (hd.Ngaydat >= tungay && hd.Ngaytra <= denngay)
                        {
                            songaythue = songaythue + (int)hd.Songayo;
                        }
                    }
                }
                bc = new Baocaomdsdp() { tenPhong = p.Tenphong, soNgayThue = songaythue, tyLe = songaythue / tong * 100 };
                ds.Add(bc);
            }
            dataGridView1.DataSource = ds;
        }
       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Baocaodoanhthutheoloaiphong();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Baocaomatdosudungphong();
        }

        private void Baocao_Load_1(object sender, EventArgs e)
        {
            _hoadon = new HoaDon();
            _phong = new Phong();
            _loaiphong = new LoaiPhong();
        }
    }
}
