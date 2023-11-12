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
public partial class UserManagement : Form
{
    private readonly IUserService userService;
    public UserManagement()
    {
        InitializeComponent();
        userService = new UserService();
    }

    private void UserManagement_Load(object sender, EventArgs e)
    {
        dgvUser.DataSource = userService.GetUsers().Select(u => new { u.UserId, u.Fullname, u.Email, u.Address, u.Phone, u.Role, u.CreatedDate }).ToList();
    }

    private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        txtUserID.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
        txtFullname.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
        txtEmail.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();
        txtAddress.Text = dgvUser.CurrentRow.Cells[3].Value.ToString();
        txtPhone.Text = dgvUser.CurrentRow.Cells[4].Value.ToString();
        txtRole.Text = dgvUser.CurrentRow.Cells[5].Value.ToString();
        dtpDate.Text = dgvUser.CurrentRow.Cells[6].Value.ToString();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Hide();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        User user = userService.GetUserById(txtUserID.Text.Trim());
        if (user != null)
        {
            bool isValid = true;
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
                user.Fullname = txtFullname.Text.Trim();
                user.Phone = txtPhone.Text.Trim();
                user.Address = txtAddress.Text.Trim();
                user.Role = int.Parse(txtRole.Text.Trim());
                user.CreatedDate = DateTime.Now;
                user.Password = "123456";
                userService.UpdateUser(user);
                MessageBox.Show("Update successfully!");

                dgvUser.DataSource = userService.GetUsers();
            }

        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        this.Hide();
        var us = new AddUser();
        us.Show();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        User user = userService.GetUserById(txtUserID.Text.Trim());
        if (user != null)
        {
            userService.DeleteUser(user);
            MessageBox.Show("Delete successfully!");
            dgvUser.DataSource = userService.GetUsers();
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

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        this.Hide();
        var lf = new LoginForm();
        lf.Show();
    }
}
