using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager
    {
        Repository<Contact> rc = new Repository<Contact>();

        public int BLContactAdd(Contact c)
        {
            if (c.ContactMail == "" || c.ContactMessage == "" || c.ContactName == "" || c.ContactSubject == "" || c.ContactSurname == "" || c.ContactMail.Length <= 8 || c.ContactSubject.Length <= 3)
            {
                return -1;
            }
            else
            {
                return rc.Insert(c);
            }
        }
        public List<Contact> GetAll()
        {
            return rc.List();
        }

    }
}
