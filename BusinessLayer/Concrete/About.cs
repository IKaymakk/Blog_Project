using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class Aboutmanager
    {
        Repository<About> repocategory = new Repository<About>();
        public List<About> GetAll()
        {
            return repocategory.List();
        }
        public int BMUpdateAbout(About p)
        {
            About about = repocategory.Find(x=>x.BlogID== p.BlogID);
            about.AboutContent1 = p.AboutContent1;
            about.AboutContent2 = p.AboutContent2;
            about.AboutImage1 = p.AboutImage1;
            about.AboutImage2 = p.AboutImage2;
            about.BlogID= p.BlogID;
            return repocategory.Update(about);
        }
    }
}
