using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Proje.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult AuthorLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AuthorLogin(Author p)
        {
            Context c = new Context();
            var logindata = c.Authors.FirstOrDefault(x => x.AuthorMail ==
            p.AuthorMail && x.AuthorPassword == p.AuthorPassword);
            if (logindata != null)
            {
                FormsAuthentication.SetAuthCookie(logindata.AuthorMail, false);
                Session["AuthorMail"] = logindata.AuthorMail.ToString();
                return RedirectToAction("Index", "User");
            }
            else
            {
                return RedirectToAction("AuthorLogin", "Login");
            }
        }
    }
}