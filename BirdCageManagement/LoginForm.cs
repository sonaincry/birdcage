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
                if(user.Role == 2) //Staff
                {
                    this.Hide();
                    BirdCageManagement bc = new BirdCageManagement();
                    bc.ShowDialog();
                }
                if(user.Role == 1) //Manager
                {
                    this.Hide();
                    AdminForm bc = new AdminForm();
                    bc.ShowDialog();
                }
                else //Customer
                {
                    this.Hide();
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
    }
}