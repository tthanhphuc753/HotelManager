using DataLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class HoaDon
    {
        Entities db;

        public HoaDon()
        {
            db = Entities.CreateEntities();
        }
        public List<HOADON> getAll()
        {
            return db.HOADONs.ToList();
        }
    }
}
