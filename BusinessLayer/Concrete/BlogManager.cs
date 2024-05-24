using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager
    {
        Repository<Blog> repoblog = new Repository<Blog>();
        public List<Blog> GetAll()
        {
            return repoblog.List();
        }
        public List<Blog> GetBlogByID(int id)
        {
            return repoblog.List(x => x.BlogID == id);
        }
        public List<Blog> GetBlogByAuthor(int id)
        {
            return repoblog.List(x => x.AuthorID == id);

        }
        public List<Blog> GetBlogByCategory(int id)
        {
            return repoblog.List(x => x.CategoryID == id);
        }
        public List<Blog> GetLastBlogByCategory(int id)
        {
            return repoblog.List(x => x.CategoryID == id);
        }
        public int BlogAddBL(Blog p)
        {
            if (p.BlogTitle == "" || p.BlogTitle.Length <= 6 || p.BlogImage == "" ||
                p.BlogContent.Length <= 100)
            {
                return -1;
            }
            return repoblog.Insert(p);
        }
        public int DeleteBlogBL(int p)
        {
            Blog blog = repoblog.Find(x => x.BlogID == p);
            return repoblog.Delete(blog);
        }
        public Blog FindBlog(int id)
        {
            return repoblog.Find(x => x.BlogID == id);
        }
        public int UpdateBlog(Blog p)
        {
            Blog abc = repoblog.Find(x => x.BlogID == p.BlogID);
            abc.BlogTitle = p.BlogTitle;
            abc.BlogContent = p.BlogContent;
            abc.BlogDate = p.BlogDate;
            abc.BlogImage = p.BlogImage;
            abc.AuthorID = p.AuthorID;
            abc.CategoryID = p.CategoryID;
            return repoblog.Update(abc);
        }
    }
}
