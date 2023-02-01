using FinancialManager.Data.Repositories;
using FinancialManager.Data.Models;
namespace FinancialManager.UI.Controls
{
    
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //UserRepository<User> userRepository = new UserRepository<User>();
            //User user = userRepository.GetByEntity(
            //    new User() { UserName = txtUserName.Text, Password = txtPassword.Text});

            //if (user != null)
            //{
            //    Console.WriteLine("continue");
            //}
            //else
            //{
            //    Console.WriteLine("Failed to Login");
            //}
        }
    }
}