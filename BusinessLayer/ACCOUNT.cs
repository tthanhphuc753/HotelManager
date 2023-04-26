using DataLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class Account
    {
        Entities db;
        public Account()
        {
            db = Entities.CreateEntities();
        }
        public List<TAIKHOAN> getAll()
        {
            return db.TAIKHOANs.ToList();
        }
    }
}
