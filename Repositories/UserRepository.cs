using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;
using DataAccessObject;

namespace Repositories;
public class UserRepository : IUserRepository
{
    public void AddUser(User user) => UserDAO.Instance.AddUser(user);

    public User GetUserById(string id) => UserDAO.Instance.GetUserById(id);

    public User GetUserByEmail(string email) => UserDAO.Instance.GetUserByEmail(email);

    public User GetUserByEmailAndPassword(String email, String password) => UserDAO.Instance.GetUserByEmailAndPassword(email, password);

    public string GetMaxUserId() => UserDAO.Instance.GetMaxUserId();

    public List<User> GetUsers() => UserDAO.Instance.GetUsers();

    public void UpdateUser(User user) => UserDAO.Instance.UpdateUser(user);

    public void DeleteUser(User user) => UserDAO.Instance.DeleteUser(user);

    public bool IsEmailExist(string email) => UserDAO.Instance.IsEmailExist(email);
}
