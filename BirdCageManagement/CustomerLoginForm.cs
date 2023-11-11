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
    public partial class CustomerLoginForm : Form
    {
        private readonly IUserService _userService;
        public CustomerLoginForm()
        {
            _userService = new UserService();
            InitializeComponent();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerRegisterForm frm = new CustomerRegisterForm();
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                var user = _userService.GetUserById(UserInfo.UserId);
                if (user != null)
                {
                    UserInfo.Email = user.Email;
                    UserInfo.Password = user.Password;
                    UserInfo.Role = user.Role;
                    UserInfo.Phone = user.Phone;
                    UserInfo.Address = user.Address;
                    UserInfo.Fullname = user.Fullname;
                    UserInfo.CreatedDate = user.CreatedDate;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = _userService.GetUserByEmailAndPassword(txtEmail.Text, txtPassword.Text);
            if (user != null)
            {
                if (user.Role == 0 || user.Role == 1 || user.Role == 2) //Role Admin && Role Manager && Role Staff  
                {
                    MessageBox.Show("This is not a Customer Account!");
                }
                else //Role Customer
                {
                    UserInfo.UserId = user.UserId;
                    UserInfo.Email = user.Email;
                    UserInfo.Password = user.Password;
                    UserInfo.Role = user.Role;
                    UserInfo.Phone = user.Phone;
                    UserInfo.Address = user.Address;
                    UserInfo.Fullname = user.Fullname;
                    UserInfo.CreatedDate = user.CreatedDate;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password. Please try again!");
            }
        }
    }
}
