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
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager();
        // GET: Contact

        [AllowAnonymous]
        public ActionResult Index()
        {

            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult SendMessage()
        {
            return View();
        }


        [AllowAnonymous]
        [HttpPost]
        public ActionResult SendMessage(Contact p)
        {
            cm.BLContactAdd(p);
            return View();
        }
        public ActionResult SendBox(int page = 1)
        {
            var messagelist = cm.GetAll().ToPagedList(page, 7);
            return View(messagelist);
        }

        public ActionResult MessageDetails(int id)
        {
            Contact ct = cm.GetContactDetails(id);
            return View(ct);
        }
        public ActionResult DeleteMessage(int id)
        {
            cm.DeleteMessage(id);
            return RedirectToAction("SendBox");
        }
    }
}