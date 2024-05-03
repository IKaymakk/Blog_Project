using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proje.Controllers
{
    [AllowAnonymous]
    public class MailSubscribeController : Controller
    {
        // GET: MailSubscribe
        [HttpGet]
        
        public PartialViewResult AddMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult AddMail(SubscribeMail p)
        {
            SubscribeMailManager sm = new SubscribeMailManager();
            sm.BLAdd(p);
            return PartialView();
        }
    }
}