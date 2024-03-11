using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AuthorManager
    {
        Repository<Author> ar = new Repository<Author>();
        public List<Author> GetAll()
        {
            return ar.List();
        }
        // Yeni yazar ekleme işlemi
        public int AddAuthorBL(Author p)
        {
            if (p.AuthorDetail == "" || p.AuthorName == "" || p.AuthorTitle == "")
            {
                return -1;
            }
            return ar.Insert(p);
        }
        //Yazarı ID'ye göre Edit View'ına Taşıma//
        public Author FindAuthor(int id)
        {
            return ar.Find(x => x.AuthorID == id);
        }
        public int EditAuthor(Author p)
        {
            Author author = ar.Find(x=>x.AuthorID == p.AuthorID);
            author.AuthorPhoneNumber = p.AuthorPhoneNumber;
            author.AuthorName = p.AuthorName;
            author.AuthorMail = p.AuthorMail;
            author.AuthorPassword = p.AuthorPassword;
            author.AuthorAbout = p.AuthorAbout;
            author.AuthorDetail = p.AuthorDetail;
            author.AuthorImg= p.AuthorImg;
            author.AuthorTitle= p.AuthorTitle;

            return ar.Update(author);
        }
    }

}
