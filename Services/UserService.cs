using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;
using Repositories;

namespace Services;
public class UserService : IUserService
{
    private readonly IUserRepository userRepository;
    public UserService()
    {
        userRepository = new UserRepository();
    }
    public void AddUser(User user)
    {
        userRepository.AddUser(user);
    }

    public string GetMaxUserId()
    {
        return userRepository.GetMaxUserId();
    }

    public User GetUserByEmail(string email)
    {
        return userRepository.GetUserByEmail(email);
    }

    public User GetUserByEmailAndPassword(string email, string password)
    {
        return userRepository.GetUserByEmailAndPassword(email, password);
    }

    public User GetUserById(string id)
    {
        return userRepository.GetUserById(id);
    }
}
