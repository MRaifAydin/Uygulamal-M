using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UygulamalıM.Business.Abstract;
using UygulamalıM.DataAccess.Abstract;
using UygulamalıM.Dto.Conversion;
using UygulamalıM.Dto.Dto;

namespace UygulamalıM.Business.Concrete
{
    public class AccountManager : IAccountService
    {
        private IAccountRepository _accountRepository;

        public AccountManager(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public bool CheckUser(AccountDto account)
        {
            if ((_accountRepository.GetUser(AccountConversion.ToEntity(account)).Username != account.Username) && (account.Password == account.SPassword))
            {
                _accountRepository.CreateUser(AccountConversion.ToEntity(account));
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CreateUser(AccountDto account)
        {
            if (_accountRepository.GetUser(AccountConversion.ToEntity(account)).Password == account.Password)
            {
                return true;
            }
            else { return false; }
        }
    }
}
