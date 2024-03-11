using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }
        [StringLength(80)]
        public string AuthorName { get; set; }
        [StringLength(100)]
        public string AuthorImg { get; set; }
        [StringLength(350)]
        public string AuthorAbout { get; set; }
        [StringLength(50)]
        public string AuthorTitle { get; set; }
        [StringLength(100)]
        public string AuthorDetail { get; set; }
        [StringLength(100)]
        public string AuthorMail { get; set; }
        [StringLength(30)]
        public string AuthorPassword { get; set; }
        [StringLength(100)]
        public string AuthorPhoneNumber { get; set; }


        public ICollection<Blog> Blogs { get; set; }
    }
}
