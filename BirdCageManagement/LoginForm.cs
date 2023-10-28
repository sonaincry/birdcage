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
                if (user.Role == 0 || user.Role == 1 || user.Role == 2) //Role Admin && Role Manager && Role Staff  
                {
                    BirdCageManagement bc = new BirdCageManagement();
                    bc.ShowDialog();
                    this.Hide();
                }
                else //Role Customer
                {
                    MessageBox.Show("You do not have permission");
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