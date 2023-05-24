using DataLayer;
using System.Linq;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class HoaDon
    {
        Entities db;
        public HoaDon()
        {
            db = Entities.CreateEntities();
        }
        public List<DataLayer.HOADON> getAll()
        {
            return db.HOADONs.ToList();
        }

    }
}
