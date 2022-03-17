using CatsSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsSystem.Controller
{
    class MainController
    {
        //READ
        public List<Cat> GetAllCats()
        {
            using (CatsDBEntities db = new CatsDBEntities())
            {
                return db.Cats.ToList();
            }
        }

        //CREATE - TEAM LEADER
        public void AddCat(Cat cat)
        {
            using (CatsDBEntities db = new CatsDBEntities())
            {
                cat.Id = db.Cats.ToList().LastOrDefault().Id + 1;
                db.Cats.Add(cat);
                db.SaveChanges();
            }
        }

        //UPDATE - DEV 1
        public void UpdateCat(int id, Cat cat)
        {
            using (CatsDBEntities db = new CatsDBEntities())
            {
                var catToUpdate = db.Cats.Where(c => c.Id == id).FirstOrDefault();
                if(catToUpdate != null)
                {
                    catToUpdate.Id = id;
                    catToUpdate.Name = cat.Name;
                    catToUpdate.Age = cat.Age;
                    db.SaveChanges();
                }
            }
        }

        //DELETE - DEV 2
        public void DeleteCat(int id)
        {
            using (CatsDBEntities db = new CatsDBEntities())
            {
                var catToDelete = db.Cats.Where(c => c.Id == id).FirstOrDefault();
                if (catToDelete != null)
                {
                    db.Cats.Remove(catToDelete);
                    db.SaveChanges();
                }
            }
        }
    }
}
