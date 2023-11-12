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

    public void DeleteUser(User user)
    {
        userRepository.DeleteUser(user);
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

    public List<User> GetUsers()
    {
        return userRepository.GetUsers();
    }

    public bool IsEmailExist(string email)
    {
        return userRepository.IsEmailExist(email);
    }

    public bool isValidPhone(string phone)
    {
        return userRepository.isValidPhone(phone);
    }

    public void UpdateUser(User user)
    {
        userRepository.UpdateUser(user);
    }
}
