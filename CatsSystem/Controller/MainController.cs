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
    }
}
