using Edukator.DataAccessLayer.Concrete;
using Edukator.EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.Abstract
{
    public interface IContactDal : IGenericDal<Contact>
    {
        public List<Contact> TGetLast4Message()
        {
            using var context = new Context();
            var values = context.Contacts.OrderByDescending(x => x.ContactID).Take(4).ToList();
            return values;
        }
    }
}
