using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using PagedList;
using PagedList.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace Proje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        BlogManager bm = new BlogManager();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AllBlogs(int page = 1)
        {
            var bloglist = bm.GetAll().ToPagedList(page, 9);
            return View(bloglist);
        }
        public PartialViewResult BlogList(int a = 1)
        {
            var bloglist = bm.GetAll().ToPagedList(a, 9);
            return PartialView(bloglist);
        }
        public PartialViewResult FeaturedPost()
        {
            var posttitle1 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 1).Select(z => z.BlogTitle).FirstOrDefault();
            var postcontent1 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 1).Select(z => z.BlogImage).FirstOrDefault();
            var postdate1 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 1).Select(z => z.BlogDate).FirstOrDefault();
            var blogid1 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 1).Select(z => z.BlogID).FirstOrDefault();
            ViewBag.bid1 = blogid1;
            ViewBag.p1 = posttitle1;
            ViewBag.p2 = postcontent1;
            ViewBag.p3 = postdate1;

            var posttitle2 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 2).Select(z => z.BlogTitle).FirstOrDefault();
            var postimage2 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 2).Select(z => z.BlogImage).FirstOrDefault();
            var postdate2 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 2).Select(z => z.BlogDate).FirstOrDefault();
            var blogid2 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 2).Select(z => z.BlogID).FirstOrDefault();
            ViewBag.bid2 = blogid2;
            ViewBag.p4 = posttitle2;
            ViewBag.p5 = postimage2;
            ViewBag.p6 = postdate2;

            var posttitle3 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 4).Select(z => z.BlogTitle).FirstOrDefault();
            var postimage3 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 4).Select(z => z.BlogImage).FirstOrDefault();
            var postdate3 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 4).Select(z => z.BlogDate).FirstOrDefault();
            var postcategory = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 4).Select(x => x.Category.CategoryName).FirstOrDefault();
            var blogid4 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 4).Select(z => z.BlogID).FirstOrDefault();
            ViewBag.bid4 = blogid4;
            ViewBag.p7 = posttitle3;
            ViewBag.p8 = postimage3;
            ViewBag.p9 = postdate3;

            var posttitle4 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 3).Select(z => z.BlogTitle).FirstOrDefault();
            var postimage4 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 3).Select(z => z.BlogImage).FirstOrDefault();
            var postdate4 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 3).Select(z => z.BlogDate).FirstOrDefault();
            var blogid3 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 3).Select(z => z.BlogID).FirstOrDefault();
            ViewBag.bid3 = blogid3;
            ViewBag.p11 = posttitle4;
            ViewBag.p12 = postimage4;
            ViewBag.p13 = postdate4;

            var posttitle5 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 5).Select(z => z.BlogTitle).FirstOrDefault();
            var postimage5 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 5).Select(z => z.BlogImage).FirstOrDefault();
            var postdate5 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 5).Select(z => z.BlogDate).FirstOrDefault();
            var blogid5 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 5).Select(z => z.BlogID).FirstOrDefault();
            ViewBag.bid5 = blogid5;
            ViewBag.p14 = posttitle5;
            ViewBag.p15 = postimage5;
            ViewBag.p16 = postdate5;
            return PartialView();
        }
        public PartialViewResult OtherPost()
        {
            var posttitle1 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 1).Select(z => z.BlogTitle).FirstOrDefault();
            var postcontent1 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 1).Select(z => z.BlogImage).FirstOrDefault();
            var postdate1 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 1).Select(z => z.BlogDate).FirstOrDefault();
            var blogid1 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 1).Select(z => z.BlogID).FirstOrDefault();
            ViewBag.bid1 = blogid1;
            ViewBag.p1 = posttitle1;
            ViewBag.p2 = postcontent1;
            ViewBag.p3 = postdate1;

            var posttitle2 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 2).Select(z => z.BlogTitle).FirstOrDefault();
            var postimage2 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 2).Select(z => z.BlogImage).FirstOrDefault();
            var postdate2 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 2).Select(z => z.BlogDate).FirstOrDefault();
            var blogid2 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 2).Select(z => z.BlogID).FirstOrDefault();
            ViewBag.bid2 = blogid2;
            ViewBag.p4 = posttitle2;
            ViewBag.p5 = postimage2;
            ViewBag.p6 = postdate2;

            var posttitle3 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 4).Select(z => z.BlogTitle).FirstOrDefault();
            var postimage3 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 4).Select(z => z.BlogImage).FirstOrDefault();
            var postdate3 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 4).Select(z => z.BlogDate).FirstOrDefault();
            var postcategory = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 4).Select(x => x.Category.CategoryName).FirstOrDefault();
            var blogid4 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 4).Select(z => z.BlogID).FirstOrDefault();
            ViewBag.bid4 = blogid4;
            ViewBag.p7 = posttitle3;
            ViewBag.p8 = postimage3;
            ViewBag.p9 = postdate3;

            var posttitle4 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 3).Select(z => z.BlogTitle).FirstOrDefault();
            var postimage4 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 3).Select(z => z.BlogImage).FirstOrDefault();
            var postdate4 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 3).Select(z => z.BlogDate).FirstOrDefault();
            var blogid3 = bm.GetAll().OrderByDescending(x => x.BlogID).Where(y => y.CategoryID == 3).Select(z => z.BlogID).FirstOrDefault();
            ViewBag.bid3 = blogid3;
            ViewBag.p11 = posttitle4;
            ViewBag.p12 = postimage4;
            ViewBag.p13 = postdate4;
            return PartialView();
        }
        //public PartialViewResult MailSubscribe()
        //{
        //    return PartialView();
        //}
        public ActionResult BlogDetails()
        {
            return View();
        }
        public PartialViewResult BlogCover(int id)
        {
            var BlogDetailsList = bm.GetBlogByID(id);
            return PartialView(BlogDetailsList);
        }
        public PartialViewResult BlogReadAll(int id)
        {
            var BlogDetailsList = bm.GetBlogByID(id);
            return PartialView(BlogDetailsList);
        }
        public ActionResult BlogByCategory(int id)
        {
            var BlogListByCategory = bm.GetBlogByCategory(id);
            var CategoryName = bm.GetBlogByCategory(id).Select(y => y.Category.CategoryName)
                .FirstOrDefault();
            ViewBag.cName = CategoryName;
            var CategoryDescpriction = bm.GetBlogByCategory(id).Select(x => x.Category.CategoryDescription)
                .FirstOrDefault();
            ViewBag.cDescp = CategoryDescpriction;
            return View(BlogListByCategory);
        }

        public ActionResult AdminBlogList()
        {
            var bloglist = bm.GetAll();
            return View(bloglist);
        }
        public ActionResult AdminBlogList2()
        {
            var bloglist = bm.GetAll();
            return View(bloglist);
        }
        [HttpGet]
        public ActionResult AddNewBlog()
        {
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
            return RedirectToAction("AdminBlogList");
        }
        public ActionResult DeleteBlog(int id)
        {
            bm.DeleteBlogBL(id);
            return RedirectToAction("AdminBlogList");
        }
        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {

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

            Blog blog = bm.FindBlog(id);
            return View(blog);
        }
        [HttpPost]
        public ActionResult UpdateBlog(Blog p)
        {
            bm.UpdateBlog(p);
            return RedirectToAction("AdminBlogList");
        }
        public ActionResult GetCommentByBlog(int id)
        {
            CommentManager cm = new CommentManager();
            var commentlist = cm.CommentByBlog(id);
            return View(commentlist);
        }
    }
}