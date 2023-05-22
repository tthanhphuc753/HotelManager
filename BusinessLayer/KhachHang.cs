using DataLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
  public  class KhachHang
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

        public void SaveAll(List<KHACHHANG> khachhangs)
        {
            db.SaveChanges();
        }
    }
}
