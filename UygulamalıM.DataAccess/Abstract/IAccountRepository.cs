using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UygulamalıM.Entities;

namespace UygulamalıM.DataAccess.Abstract
{
    public interface IAccountRepository
    {
        Account GetUser(Account account);

        Account CreateUser(Account account);
    }
}
