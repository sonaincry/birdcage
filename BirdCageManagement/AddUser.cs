using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessObject.Models;
using Services;

namespace BirdCageManagement;
public partial class AddUser : Form
{
    private readonly IUserService userService;
    public AddUser()
    {
        InitializeComponent();
        userService = new UserService();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            bool isValid = true;
            User user = new User();
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                errorProvider1.SetError(txtEmail, "Required");
                isValid = false;
                return;
            }
            if (!IsValidEmail(txtEmail.Text.Trim()))
            {
                errorProvider1.SetError(txtEmail, "Invalid email");
                isValid = false;
                return;
            }
            if (userService.IsEmailExist(txtEmail.Text.Trim()))
            {
                errorProvider1.SetError(txtEmail, "Email already exist! Please try something else");
                isValid = false;
                return;
            }
            if (string.IsNullOrEmpty(txtFullname.Text.Trim()))
            {
                errorProvider1.SetError(txtFullname, "Required");
                isValid = false;
                return;
            }
            if (!isValidLength(txtFullname.Text.Trim()))
            {
                errorProvider1.SetError(txtFullname, "Must have at least 6 characters and maximum is 25!");
            }
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtPassword, "Required");
                isValid = false;
                return;
            }
            if (!isValidLength(txtPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtPassword, "Must have at least 6 characters and maximum is 25!");
            }
            if (string.IsNullOrEmpty(txtPhone.Text.Trim()))
            {
                errorProvider1.SetError(txtPhone, "Required");
                isValid = false;
                return;
            }
            if (!isValidPhone((txtPhone.Text.Trim())))
            {
                errorProvider1.SetError(txtPhone, "Invalid phone number!");
                isValid = false;
                return;
            }
            if (string.IsNullOrEmpty(txtAddress.Text.Trim()))
            {
                errorProvider1.SetError(txtAddress, "Required");
                isValid = false;
                return;
            }
            if (isValid)
            {
                user.Email = txtEmail.Text.Trim();
                user.Fullname = txtFullname.Text.Trim();
                user.Password = txtPassword.Text.Trim();
                user.Phone = txtPhone.Text.Trim();
                user.Address = txtAddress.Text.Trim();
                user.CreatedDate = DateTime.Now;
                user.Role = int.Parse(txtRole.Text.Trim());

                string maxUserId = userService.GetMaxUserId();

                int currentNumber = int.Parse(maxUserId.Substring(4));
                int newNumber = currentNumber + 1;


                string newUserNumber = newNumber.ToString("D2");
                user.UserId = "user" + newUserNumber;


                userService.AddUser(user);
                MessageBox.Show("Register successfully!");

                this.Hide();
                var us = new UserManagement();
                us.Show();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private static bool IsValidEmail(string email)
    {
        string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";

        return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
    }


    private bool isValidLength(string input)
    {

        return input.Length >= 6 && input.Length <= 25;
    }
    private bool isValidPhone(string phone)
    {
        string regex = @"^0\d{9}$";

        return Regex.IsMatch(phone, regex);
    }
}
