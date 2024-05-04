using BusinessLayer.Concrete;
using EntityLayer.Concrete;
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
        public ActionResult AdminCategoryList()
        {
            var ctlist = cm.GetAll();
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
        public ActionResult ChangeCategoryStatus (int id)
        {
            cm.ChangeCategoryStatusBL(id);
            return RedirectToAction("AdminCategoryList");
        }
    }
}