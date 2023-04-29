using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class Phong
    {

        Entities db;
       public Phong ()
        {
            db = Entities.CreateEntities();
        }
        public List<PHONG> getAll()
        {
            return db.PHONGs.ToList();
        }
        public List<PHONG> getByTang(int idTang)
        {
            return db.PHONGs.Where(x => x.IDTang == idTang).ToList();
        }  
    }
}
