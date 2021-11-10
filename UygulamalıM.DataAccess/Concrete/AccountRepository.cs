using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UygulamalıM.DataAccess.Abstract;
using UygulamalıM.Entities;

namespace UygulamalıM.DataAccess.Concrete
{
    public class AccountRepository : IAccountRepository
    {
        public Account CreateUser(Account account)
        {
            using (var databaseContext = new DatabaseContext())
            {
                databaseContext.Accounts.Add(account);
                databaseContext.SaveChanges();
                return account;
            }
        }

        public Account GetUser(Account account)
        {
            using (var databaseContext = new DatabaseContext())
            {
                var user = databaseContext.Accounts.FirstOrDefault(r => r.Username == account.Username);
                if (user == null)
                {
                    return new Account();
                }
                return user;
            }
        }
    }
}
