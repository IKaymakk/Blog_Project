using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proje.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        CommentManager cm = new CommentManager();

        [AllowAnonymous]
        public PartialViewResult CommentList(int id)
        {
            var clist = cm.CommentByBlog(id);
            return PartialView(clist);
        }
        [HttpGet]

        [AllowAnonymous]
        public PartialViewResult LeaveComment(int id)
        {
            ViewBag.CommentId = id;
            return PartialView();
        }
        [HttpPost]

        [AllowAnonymous]
        public PartialViewResult LeaveComment(Comment c)
        {
            c.CommentStatus = true;
            cm.CommentAdd(c);
            return PartialView();
        }
        public ActionResult AdminCommentListTrue(int page = 1)
        {
            var commenlist = cm.CommentByStatus().OrderByDescending(x => x.CommentID).ToPagedList(page, 10);
            return View(commenlist);
        }
        public ActionResult ChangeCommentStatus(int id)
        {
            cm.CommentStatusChangeToFalse(id);
            return RedirectToAction("AdminCommentListTrue");
        }
        public ActionResult AdminCommentListFalse(int page = 1)
        {
            var commentlist = cm.CommentStatusFalse().OrderByDescending(x => x.CommentID).ToPagedList(page, 10);
            return View(commentlist);
        }
        public ActionResult ChangeCommentStatusTrue(int id)
        {
            cm.CommentStatusChangeToTrue(id);
            return RedirectToAction("AdminCommentListFalse");
        }
    }
}