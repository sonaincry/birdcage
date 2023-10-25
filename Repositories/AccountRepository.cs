using BussinessObject.Models;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public Account getAccountByEmailAndPassword(string email, string password) =>
            AccountDAO.Instance.getAccountByEmailAndPassword(email, password);
    }
}
