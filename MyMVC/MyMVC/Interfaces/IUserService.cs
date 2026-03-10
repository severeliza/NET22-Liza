using MyMVC.Models;

namespace MyMVC.Interfaces
{
    public interface IUserService
    {
        bool Register(User user);
        bool Login(string username, string password);
        bool UserExists(string username);
        bool GetCurrentUsername();
        bool Logout();
        bool IsAuthenticated();

    }
}
