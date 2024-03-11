using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(100)]
        public string Mail { get; set; }
        [StringLength(300)]
        public string Message { get; set; }
        public int BlogID { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }
        public virtual Blog Blogs { get; set; }
    }
}
