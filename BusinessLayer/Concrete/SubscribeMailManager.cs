using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubscribeMailManager
    {
        Repository<SubscribeMail> repo = new Repository<SubscribeMail>();
        public int BLAdd(SubscribeMail p)
        {
            if(p.Mail.Length<=6 || p.Mail.Length>75)
            {
                return -1;
            }
            return repo.Insert(p);
        }
    }
}
