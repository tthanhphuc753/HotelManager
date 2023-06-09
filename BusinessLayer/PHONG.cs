﻿using DataLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class Phong
    {

        Entities db;
        public Phong()
        {
            db = Entities.CreateEntities();
        }
        public List<PHONG> getAll()
        {
            return db.PHONGs.ToList();
        }
        public List<PHONG> getByTang(int idTang)
        {
            return db.PHONGs.Where(x => x.IDtang == idTang).ToList();
        }
        public List<PHONG> GetAllByStatus(bool status)
        {
            return db.PHONGs.Where(p => p.Trangthai == status).ToList();
        }

    }
}
