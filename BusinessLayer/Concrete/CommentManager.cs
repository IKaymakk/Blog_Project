using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager
    {
        Repository<Comment> rc = new Repository<Comment>();
        public List<Comment> CommentList()
        {
            return rc.List();
        }
        public List<Comment> CommentByBlog(int id)
        {
            return rc.List(x => x.BlogID == id);
        }
        public List<Comment> CommentByStatus()
        {
            return rc.List(x => x.CommentStatus == true);
        }
        public List<Comment> CommentStatusFalse()
        {
            return rc.List(x => x.CommentStatus == false);
        }
        public int CommentAdd(Comment c)
        {
            if (c.Message.Length <= 10 || c.Message.Length > 250 || c.UserName == "" || c.UserName.Length <= 3 || c.UserName.Length > 50 || c.Mail == "")
            {
                return -1;
            }
            return rc.Insert(c);
        }
        public int CommentStatusChangeToFalse(int id)
        {
            Comment comment = rc.Find(x => x.CommentID == id);
            comment.CommentStatus = false;
            return rc.Update(comment);
        }
        public int CommentStatusChangeToTrue(int id)
        {
            Comment comment = rc.Find(x => x.CommentID == id);
            comment.CommentStatus = true;
            return rc.Update(comment);
        }
    }
}
