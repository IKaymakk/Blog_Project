using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserProfileManager
    {
        Repository<Author> repouser = new Repository<Author>();
        Repository<Blog> repouserblog = new Repository<Blog>();

        public List<Author> GetAuthorByMail(string p)
        {
            return repouser.List(x => x.AuthorMail == p);
        }
        public List<Blog> GetBlogByAuthor(int id)
        {
            return repouserblog.List(x => x.AuthorID == id);
        }
        public int EditAuthor(Author p)
        {
            Author author = repouser.Find(x => x.AuthorID == p.AuthorID);
            author.AuthorPhoneNumber = p.AuthorPhoneNumber;
            author.AuthorName = p.AuthorName;
            author.AuthorMail = p.AuthorMail;
            author.AuthorPassword = p.AuthorPassword;
            author.AuthorAbout = p.AuthorAbout;
            author.AuthorDetail = p.AuthorDetail;
            author.AuthorImg = p.AuthorImg;
            author.AuthorTitle = p.AuthorTitle;
            return repouser.Update(author);
        }
    }
}
