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
            user.Fullname = txtFullname.Text.Trim();
            user.Phone = txtPhone.Text.Trim();
            user.Address = txtAddress.Text.Trim();
            user.Role = int.Parse(txtRole.Text.Trim());
            userService.UpdateUser(user);
            MessageBox.Show("Update successfully!");
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
        }
    }
}
