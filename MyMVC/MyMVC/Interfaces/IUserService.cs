using MyMVC.Models;

namespace MyMVC.Interfaces
{
    public interface IUserService
    {
        bool Register(User user);
        bool Login(string username, string password);
        bool UserExists(string username);
        string GetCurrentUsername();
        void Logout();
        bool IsAuthenticated();

    }
}
