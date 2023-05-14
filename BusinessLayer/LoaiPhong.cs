using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class LoaiPhong
    {
        private Entities db;

        public LoaiPhong()
        {
            db = Entities.CreateEntities();
        }

        public List<DataLayer.LOAIPHONG> getAll()
        {
            return db.LOAIPHONGs.ToList(); 
        }

        public DataLayer.LOAIPHONG GetLoaiPhongById(string id)
        {
            return db.LOAIPHONGs.FirstOrDefault(lp => lp.IDloaiphong == id); 
        }
    }
}
