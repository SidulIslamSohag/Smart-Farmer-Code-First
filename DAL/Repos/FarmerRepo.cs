using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class FarmerRepo : Repo, IRepo<Farmer, int, Farmer>
    {
        public Farmer Add(Farmer obj)
        {
            db.Farmers.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public Farmer Delete(int id)
        {
            var dbobj = Get(id);
            if (dbobj != null)
            {
                db.Farmers.Remove(dbobj);
                if (db.SaveChanges() > 0)
                {
                    return dbobj;
                }
                return null;
            }
            return null;
        }

        public List<Farmer> Get()
        {
            return db.Farmers.ToList();
        }

        public Farmer Get(int id)
        {
            return db.Farmers.Find(id);
        }

        public Farmer Update(Farmer obj)
        {
            var dbco = Get(obj.Id);
            db.Entry(dbco).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}