using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        Repository<Category> repocategory = new Repository<Category>();
        public List<Category> GetAll()
        {
            return repocategory.List();
        }
        public int CategoryAddBL(Category p)
        {
            if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryName.Length > 100 || p.CategoryDescription.Length > 200 || p.CategoryDescription == "" ||
                p.CategoryDescription.Length <= 10)
            {
                return -1;
            }
            return repocategory.Insert(p);
        }
        public Category FindCategory(int id)
        {
            return repocategory.Find(x => x.CategoryID == id);
        }
        public int EditCategory(Category p)
        {
            Category c = repocategory.Find(x => x.CategoryID == p.CategoryID);
            if (p.CategoryName == "" || p.CategoryName.Length < 3 || p.CategoryDescription == "")
            {
                return -1;
            }
            c.CategoryName = p.CategoryName;
            c.CategoryDescription = p.CategoryDescription;
            return repocategory.Update(c);
        }
        public int ChangeCategoryStatusBL(int id)
        {
            Category c = repocategory.Find(x => x.CategoryID == id);
            if (c.CategoryStatus == true)
            {
                c.CategoryStatus = false;
                return repocategory.Update(c);

            }
            c.CategoryStatus = true;
            return repocategory.Update(c);
        }
       
    }
}
