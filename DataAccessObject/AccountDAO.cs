using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class AccountDAO
    {
        private static AccountDAO instance = null;
        public AccountDAO() { }
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }
        }
        public Account getAccountByEmailAndPassword(String  email, String password)
        {
            var DbContext = new BirdCageContext();
            return DbContext.Accounts.SingleOrDefault(m => m.Email.Equals(email) && m.Password.Equals(password));
        
        }

    }
}
