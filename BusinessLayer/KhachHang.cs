using DataLayer;
using System.Collections.Generic;
using System.Linq;

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
