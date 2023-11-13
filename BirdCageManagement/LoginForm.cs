using BussinessObject;
using BussinessObject.Models;
using Services;

namespace BirdCageManagement
{
    public partial class LoginForm : Form
    {
        private IUserService userService;
        public LoginForm()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = userService.GetUserByEmailAndPassword(txtUsername.Text, txtPassword.Text);
            if (user != null)
            {
                if (user.Role == 0) //Admin
                {
                    this.Hide();
                    UserManagement bc = new UserManagement();
                    bc.ShowDialog();

                }
                if (user.Role == 2) //Staff
                {
                    this.Hide();
                    BirdCageManagement bc = new BirdCageManagement();
                    bc.ShowDialog();
                }
                if (user.Role == 1) //Manager
                {
                    this.Hide();
                    AdminForm bc = new AdminForm();
                    bc.ShowDialog();
                }
                else //Customer
                {
                    this.Hide();
                    UserInfo.UserId = user.UserId;
                    UserInfo.Email = user.Email;
                    UserInfo.Password = user.Password;
                    UserInfo.Role = user.Role;
                    UserInfo.Phone = user.Phone;
                    UserInfo.Address = user.Address;
                    UserInfo.Fullname = user.Fullname;
                    UserInfo.CreatedDate = user.CreatedDate;
                    var bc = new BirdCageShop();
                    bc.ShowDialog();

                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password. Please try again!");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var rf = new RegistrationForm();
            rf.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var bs = new BirdCageShop();
            bs.Show();
        }
    }
}