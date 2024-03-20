using BusinessLayer.Concrete;
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
    }
}