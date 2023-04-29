using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class Tang
    {
        Entities db;

        public Tang()
        {
            db = Entities.CreateEntities();
        }

        public List<TANG> getAll()
        {
            return db.TANGs.ToList();
        }

    }
}
