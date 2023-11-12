using BussinessObject;
using BussinessObject.Models;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdCageManagement
{
    public partial class CustomerRegisterForm : Form
    {
        private readonly IUserService _userService;
        public CustomerRegisterForm()
        {
            _userService = new UserService();
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var user = _userService.GetUserByEmail(txtEmail.Text.Trim());
                if (user == null)
                {
                    user = new User();
                    user.Email = txtEmail.Text.Trim();
                    user.Fullname = txtFullName.Text.Trim();
                    user.Password = txtPassword.Text.Trim();
                    user.Address = txtAddress.Text.Trim();
                    user.Phone = txtPhoneNumber.Text.Trim();
                    user.Role = 3;
                    string maxUserId = _userService.GetMaxUserId();

                    int currentNumber = int.Parse(maxUserId.Substring(4)); // Assumes "userXX" format
                    int newNumber = currentNumber + 1;

                    // Create the new user ID by formatting it with leading zeros
                    string newUserNumber = newNumber.ToString("D2"); // "D2" format ensures it's two digits
                    user.UserId = "user" + newUserNumber;


                    _userService.AddUser(user);
                    UserInfo.UserId = user.UserId;
                    MessageBox.Show("Register successfully!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This Email already exists!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    if (txtPhoneNumber.Text.Length > 9)
                    {
                        e.Handled = true;
                    }
                }
            }
        }
    }
}
