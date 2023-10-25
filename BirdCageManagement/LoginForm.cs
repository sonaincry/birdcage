using BussinessObject.Models;
using Services;

namespace BirdCageManagement
{
    public partial class LoginForm : Form
    {
        private IAccountService accountService;
        public LoginForm()
        {
            InitializeComponent();
            accountService = new AccountService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Account account = accountService.getAccountByEmailAndPassword(txtUsername.Text, txtPassword.Text);
            if (account != null && account.Role == 1)
            {
                BirdCageManagement bc = new BirdCageManagement();
                bc.ShowDialog();
                this.Hide();
            }
            if(account !=null && account.Role == 0)
            {
                BirdCageManagement bc = new BirdCageManagement();
                bc.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Password. Please try again!");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}