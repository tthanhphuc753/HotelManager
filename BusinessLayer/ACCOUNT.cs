using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class ACCOUNT
    {
        Entities db;
        public ACCOUNT ()
        {
            db = Entities.CreateEntities();
        }
        public List<TAIKHOAN>getAll()
        {
            return db.TAIKHOANs.ToList();
        }
    }
}
