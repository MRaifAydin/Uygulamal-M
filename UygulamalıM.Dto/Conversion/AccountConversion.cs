using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UygulamalıM.Dto.Dto;
using UygulamalıM.Entities;

namespace UygulamalıM.Dto.Conversion
{
    public class AccountConversion
    {
        public static Account ToEntity(AccountDto account)
        {
            return new Account
            {
                Username = account.Username,
                Password = account.Password,
            };
        }

        public static AccountDto ToApi(Account account)
        {
            return new AccountDto
            {
                Username = account.Username,
                Password = account.Password,
            };
        }
    }

}