using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proje.Controllers
{
    public class AboutController : Controller
    {
        Aboutmanager abm = new Aboutmanager();
        // GET: About
        public ActionResult Index()
        {
            var aboutcontent = abm.GetAll();
            return View(aboutcontent);
        }
        public PartialViewResult MeetTheTeam()
        {
            AuthorManager authorinfo = new AuthorManager();
            var authorlist=authorinfo.GetAll();
            return PartialView(authorlist);
        }
    }
}