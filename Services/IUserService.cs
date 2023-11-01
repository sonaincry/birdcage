using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;

namespace Services;
public interface IUserService
{
    User GetUserByEmailAndPassword(String email, String password);
    User GetUserById(string id);
    User GetUserByEmail(string email);
    public void AddUser(User user);
    string GetMaxUserId();
    List<User> GetUsers();
    void UpdateUser(User user);
    void DeleteUser(User user);
    bool IsEmailExist(string email);
}
