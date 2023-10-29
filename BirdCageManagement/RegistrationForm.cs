using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessObject.Models;
using Services;

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
            User user = new User();
            user.Email = txtEmail.Text.Trim();
            user.Fullname = txtFullname.Text.Trim();
            user.Password = txtPassword.Text.Trim();
            string maxUserId = userService.GetMaxUserId();

            int currentNumber = int.Parse(maxUserId.Substring(4)); // Assumes "userXX" format
            int newNumber = currentNumber + 1;

            // Create the new user ID by formatting it with leading zeros
            string newUserNumber = newNumber.ToString("D2"); // "D2" format ensures it's two digits
            user.UserId = "user" + newUserNumber;


            userService.AddUser(user);
            MessageBox.Show("Register successfully!");
        }catch(Exception ex)
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
}
