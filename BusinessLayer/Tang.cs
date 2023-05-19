using DataLayer;
using System.Collections.Generic;
using System.Linq;

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
