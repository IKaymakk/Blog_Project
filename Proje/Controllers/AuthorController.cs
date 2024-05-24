using BusinessLayer.Concrete;
using PagedList;
using System;
using PagedList.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityLayer.Concrete;

namespace Proje.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        BlogManager bm = new BlogManager();
        AuthorManager aum = new AuthorManager();
       
        [AllowAnonymous]
        public PartialViewResult AuthorAbout(int id)
        {
            var BlogDetailsList = bm.GetBlogByID(id);
            return PartialView(BlogDetailsList);
        }

        [AllowAnonymous]
        public PartialViewResult AuthorPopularPost(int id, int page = 1)
        {
            var blogauthorid = bm.GetAll().Where(x => x.BlogID == id).Select(y => y.AuthorID).FirstOrDefault();
            var authorblogs = bm.GetBlogByAuthor(blogauthorid).OrderByDescending(x => x.BlogID).ToPagedList(page, 3);
            return PartialView(authorblogs); ;
        }
        public ActionResult AuthorList()
        {
            var alist = aum.GetAll();
            return View(alist);
        }
        [HttpGet]
        public ActionResult AddAuthor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAuthor(Author p)
        {
            aum.AddAuthorBL(p);
            return RedirectToAction("AuthorList");
        }
        [HttpGet]
        public ActionResult AuthorEdit(int id)
        {
            Author author = aum.FindAuthor(id);
            return View(author);
        }
        [HttpPost]
        public ActionResult AuthorEdit(Author p)
        {
            aum.EditAuthor(p);
            return RedirectToAction("AuthorList");
        }

    }
}