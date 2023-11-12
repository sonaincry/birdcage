using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessObject.Models;
using Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BirdCageManagement;
public partial class RegistrationForm : Form
{
    private readonly IUserService userService;
    public RegistrationForm()
    {
        InitializeComponent();
        userService = new UserService();
    }

    private void btnRegister_Click(object sender, EventArgs e)
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
            if (!txtRepassword.Text.Trim().Equals(txtPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtRepassword, "Re-password should be match with password!");
                isValid = false;
                return;
            }
            if (string.IsNullOrEmpty(txtPhone.Text.Trim()))
            {
                errorProvider1.SetError(txtPhone, "Required");
                isValid = false;
                return;
            }
            if (userService.isValidPhone(txtPhone.Text.Trim()))
            {
                errorProvider1.SetError(txtPhone, "Phone number is already exist. Please try with another phone number");
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
                user.Role = 3;
                user.Phone = txtPhone.Text.Trim();
                user.Address = txtAddress.Text.Trim();
                user.CreatedDate = DateTime.Now;
                string maxUserId = userService.GetMaxUserId();

                int currentNumber = int.Parse(maxUserId.Substring(4));
                int newNumber = currentNumber + 1;


                string newUserNumber = newNumber.ToString("D2");
                user.UserId = "user" + newUserNumber;


                userService.AddUser(user);
                MessageBox.Show("Register successfully!");
                this.Hide();
                var lf = new LoginForm();
                lf.Show();
            }

        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        var lf = new LoginForm();
        lf.ShowDialog();
        this.Hide();
    }

    private void RegistrationForm_Load(object sender, EventArgs e)
    {

    }

    private void txtPhone_TextChanged(object sender, EventArgs e)
    {

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
    private void label1_Click(object sender, EventArgs e)
    {

    }
}
