using BusinessLayer.Concrete;
using EntityLayer.Concrete;
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
        public ActionResult Index()
        {

            return View();
        }
        [HttpGet]
        public ActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendMessage(Contact p)
        {
            cm.BLContactAdd(p);
            return View();
        }
        public ActionResult SendBox()
        {
            var messagelist = cm.GetAll();
            return View(messagelist);
        }
        public ActionResult MessageDetails(int id)
        {
            Contact ct = cm.GetContactDetails(id);
            return View(ct);
        }
    }
}