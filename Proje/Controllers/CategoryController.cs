using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proje.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager();
        BlogManager bm = new BlogManager();
        Context _context = new Context();
        public ActionResult Index()
        {
            var cvalues = cm.GetAll();
            return View(cvalues);
        }

        [AllowAnonymous]
        public PartialViewResult BlogDetailsCategories()
        {
            var cvalues = cm.GetAll();
            return PartialView(cvalues);
        }

        public ActionResult CategoryDetails(int id)
        {
            var lastcategory = bm.GetLastBlogByCategory(id).OrderByDescending(x => x.BlogID);
            var CategoryName = bm.GetBlogByCategory(id).Select(y => y.Category.CategoryName)
                .FirstOrDefault();
            ViewBag.cName = CategoryName;
            var CategoryDescpriction = bm.GetBlogByCategory(id).Select(x => x.Category.CategoryDescription)
                .FirstOrDefault();
            ViewBag.cDescp = CategoryDescpriction;
            return View(lastcategory);
        }
        public ActionResult AdminCategoryList(int page = 1)
        {
            var ctlist = cm.GetAll().ToPagedList(page,6);
            return View(ctlist);
        }
        [HttpGet]
        public ActionResult AdminCategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminCategoryAdd(Category p)
        {
            cm.CategoryAddBL(p);
            return RedirectToAction("AdminCategoryList");
        }

        [HttpGet]
        public ActionResult CategoryEdit(int id)
        {
            Category category = cm.FindCategory(id);
            return View(category);
        }
        [HttpPost]
        public ActionResult CategoryEdit(Category p)
        {
            cm.EditCategory(p);
            return RedirectToAction("AdminCategoryList");
        }
        public ActionResult ChangeCategoryStatus(int id)
        {
            cm.ChangeCategoryStatusBL(id);
            return RedirectToAction("AdminCategoryList");
        }


    }
}