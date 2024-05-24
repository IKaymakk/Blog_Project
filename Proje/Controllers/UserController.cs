using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Proje.Controllers
{

    public class UserController : Controller
    {
        // GET: User
        UserProfileManager um = new UserProfileManager();
        BlogManager bm = new BlogManager();
        Context ctx = new Context();
        CategoryManager ctg = new CategoryManager();

        public ActionResult Index()
        {
            var mail = (string)Session["AuthorMail"];
            var adsoyad = ctx.Authors.Where(x => x.AuthorMail == mail).Select(x => x.AuthorName).FirstOrDefault();
            var resim = ctx.Authors.Where(x => x.AuthorMail == mail).Select(x => x.AuthorImg).FirstOrDefault();
            ViewBag.adsoyad = adsoyad;
            ViewBag.resim = resim;
            return View();
        }
        public PartialViewResult Partial1(string p)
        {
            p = (string)Session["AuthorMail"];
            var profilevalues = um.GetAuthorByMail(p);
            return PartialView(profilevalues);
        }
        public ActionResult BlogList(string p, int page = 1)
        {
            //int id = 1;
            var mail = (string)Session["AuthorMail"];
            var adsoyad = ctx.Authors.Where(x => x.AuthorMail == mail).Select(x => x.AuthorName).FirstOrDefault();
            var resim = ctx.Authors.Where(x => x.AuthorMail == mail).Select(x => x.AuthorImg).FirstOrDefault();
            ViewBag.adsoyad = adsoyad;
            ViewBag.resim = resim;
            p = (string)Session["AuthorMail"];
            Context c = new Context();
            int id = c.Authors.Where(x => x.AuthorMail == p).Select(y => y.AuthorID).FirstOrDefault();
            var blogs = um.GetBlogByAuthor(id).ToPagedList(page, 5);
            return View(blogs);
        }
        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            var mail = (string)Session["AuthorMail"];
            var adsoyad = ctx.Authors.Where(x => x.AuthorMail == mail).Select(x => x.AuthorName).FirstOrDefault();
            var resim = ctx.Authors.Where(x => x.AuthorMail == mail).Select(x => x.AuthorImg).FirstOrDefault();
            ViewBag.adsoyad = adsoyad;
            ViewBag.resim = resim;
            Blog blog = bm.FindBlog(id);
            Context c = new Context();
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.values = values;
            ////////////////////////
            List<SelectListItem> values2 = (from x in c.Authors.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.AuthorName,
                                                Value = x.AuthorID.ToString()
                                            }).ToList();
            ViewBag.values2 = values2;

            return View(blog);
        }
        [HttpPost]
        public ActionResult UpdateBlog(Blog p)
        {
            bm.UpdateBlog(p);
            return RedirectToAction("BlogList");
        }
        [HttpGet]
        public ActionResult AddNewBlog()
        {
            var mail = (string)Session["AuthorMail"];
            var adsoyad = ctx.Authors.Where(x => x.AuthorMail == mail).Select(x => x.AuthorName).FirstOrDefault();
            var resim = ctx.Authors.Where(x => x.AuthorMail == mail).Select(x => x.AuthorImg).FirstOrDefault();
            ViewBag.adsoyad = adsoyad;
            ViewBag.resim = resim;
            Context c = new Context();
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.values = values;
            ////////////////////////
            List<SelectListItem> values2 = (from x in c.Authors.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.AuthorName,
                                                Value = x.AuthorID.ToString()
                                            }).ToList();
            ViewBag.values2 = values2;
            return View();
        }
        [HttpPost]
        public ActionResult AddNewBlog(Blog b)
        {
            bm.BlogAddBL(b);
            return RedirectToAction("BlogList");
        }
        public ActionResult UpdateUserProfile(Author p)
        {
            um.EditAuthor(p);
            return RedirectToAction("Index");
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("AuthorLogin", "Login");
        }
        public ActionResult UserCategoryList(int page = 1)
        {
            var mail = (string)Session["AuthorMail"];
            var adsoyad = ctx.Authors.Where(x => x.AuthorMail == mail).Select(x => x.AuthorName).FirstOrDefault();
            var resim = ctx.Authors.Where(x => x.AuthorMail == mail).Select(x => x.AuthorImg).FirstOrDefault();
            ViewBag.adsoyad = adsoyad;
            ViewBag.resim = resim;
            var ctlist = ctg.GetAll().ToPagedList(page, 6);
            return View(ctlist);
        }
    }
}