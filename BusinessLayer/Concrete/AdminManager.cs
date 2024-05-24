using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManager
    {
        Repository<Admin> repoadmin = new Repository<Admin>();
        public List<Admin> GetAll()
        {
            return repoadmin.List();
        }
    }
}
