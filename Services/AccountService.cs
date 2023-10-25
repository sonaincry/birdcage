using BussinessObject.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AccountService : IAccountService
    {
        private IAccountRepository accountRepository;
        public AccountService()
        {
            this.accountRepository = new AccountRepository();
        }
        public Account getAccountByEmailAndPassword(string email, string password)
        {
            return accountRepository.getAccountByEmailAndPassword(email, password);
        }
    }
}
