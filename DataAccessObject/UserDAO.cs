using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class UserDAO
    {
        private static UserDAO instance = null;

        public UserDAO() { }
        public static UserDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserDAO();
                }
                return instance;
            }
        }
        public User GetUserByEmailAndPassword(String email, String password)
        {
            var DbContext = new BirdCageShopContext();
            return DbContext.Users.SingleOrDefault(m => m.Email.Equals(email) && m.Password.Equals(password));

        }
        public User GetUserById(string id)
        {
            try
            {
                var dbContext = new BirdCageShopContext();
                return dbContext.Users.SingleOrDefault(m => m.UserId.Equals(id));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public User GetUserByEmail(string email)
        {
            var DbContext = new BirdCageShopContext();
            return DbContext.Users.SingleOrDefault(m => m.Email.Equals(email));
        }
        public void AddUser(User user)
        {
            try
            {
                var dbContext = new BirdCageShopContext();
                User p = GetUserById(user.UserId);
                if (p == null)
                {
                    dbContext.Users.Add(user);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateUser(User user)
        {
            try
            {
                var dbContext = new BirdCageShopContext();
                if (user != null)
                {
                    dbContext.Users.Update(user);
                    dbContext.SaveChanges();
                }
                else
                {
                    throw new Exception("Nothing to update!");
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteUser(User user)
        {
            try
            {
                var dbContext = new BirdCageShopContext();
                if (user != null)
                {
                    dbContext.Users.Remove(user);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GetMaxUserId()
        {
            try
            {
                using (var dbContext = new BirdCageShopContext())
                {
                    var maxUserId = dbContext.Users
                        .Where(u => u.UserId.StartsWith("user"))
                        .OrderByDescending(u => u.UserId)
                        .Select(u => u.UserId)
                        .FirstOrDefault();

                    return maxUserId;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool IsEmailExist(string email)
        {
            using (var dbContext = new BirdCageShopContext())
            {
                bool existEmail = dbContext.Users.Any(u => u.Email == email);
                return existEmail;
            }
        }
        public bool isValidPhone(string phone)
        {
            using (var dbContext = new BirdCageShopContext())
            {
                bool existEmail = dbContext.Users.Any(u => u.Phone == phone);
                return existEmail;
            }
        }
        public List<User> GetUsers()
        {
            var dbContext = new BirdCageShopContext();
            return dbContext.Users.ToList();
        }
    }
}
