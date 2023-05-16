using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class KhachHang
    {
        Entities db;
        public KhachHang()
        {
            db = Entities.CreateEntities();
        }
        public List<KHACHHANG> getAll()
        {
            return db.KHACHHANGs.ToList();
        }
    }
}
