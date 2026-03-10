using MyMVC.Interfaces;
using MyMVC.Models;

namespace MyMVC.Services
{
    public class UserService : IUserService
    {
         
        public bool GetCurrentUsername()
        {
            throw new NotImplementedException();
        }

        public bool IsAuthenticated()
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool Logout()
        {
            throw new NotImplementedException();
        }

        public bool Register(User user)
        {
            throw new NotImplementedException();
        }

        public bool UserExists(string username)
        {
            throw new NotImplementedException();
        }
    }
}
