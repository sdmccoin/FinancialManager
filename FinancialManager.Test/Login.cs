namespace FinancialManager.Test
{
    using FinancialManager.Data.Repositories;
    using FinancialManager.Data.Models;
    using System.Drawing.Text;

    [TestClass]
    public class Login
    {
        private const string username = "admin";
        private const string password = "admin";

        [TestMethod]
        public void TestLogin()
        {
            
            UserRepository<User> uRepo = new UserRepository<User>();
            User user = new User()
            {
                UserName = username,
                Password = password
            };

            User u = uRepo.GetByEntity(user);
            Assert.AreEqual(user.UserName, u.UserName);
        }

        [TestMethod]
        public void TestLoginNoUsernameFailure()
        {

            UserRepository<User> uRepo = new UserRepository<User>();
            User user = new User()
            {
                UserName = "",
                Password = password
            };

            User u = uRepo.GetByEntity(user);
            Assert.AreNotEqual(user.UserName, u.UserName);
        }

        [TestMethod]
        public void TestLoginNoPasswordFailure()
        {

            UserRepository<User> uRepo = new UserRepository<User>();
            User user = new User()
            {
                UserName = username,
                Password = ""
            };

            User u = uRepo.GetByEntity(user);
            Assert.AreNotEqual(user.UserName, u.UserName);
        }
    }
}