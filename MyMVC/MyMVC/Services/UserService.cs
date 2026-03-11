using MyMVC.Interfaces;
using MyMVC.Models;
using System.Text.Json;

namespace MyMVC.Services
{
    public class UserService : IUserService
    {
        private readonly string _filePath;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserService(IWebHostEnvironment env, IHttpContextAccessor httpContextAccessor)
        {
            _filePath = Path.Combine(env.ContentRootPath, "Data", "users.json");
            _httpContextAccessor = httpContextAccessor;
            EnsureFileExists();
        }


        private void EnsureFileExists()
        {
            var directory = Path.GetDirectoryName(_filePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if (!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, "[]");
            }
        }

        private List<User> ReadUsersFromFile()
        {
            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }

        private void SaveUsersToFile(List<User> users)
        {
            var json = JsonSerializer.Serialize(users, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(_filePath, json);
        }

        public bool Register(User user)
        {
            var users = ReadUsersFromFile();

            // Проверяем, существует ли пользователь
            if (users.Any(u => u.Username == user.Username))
            {
                return false;
            }

            users.Add(user);
            SaveUsersToFile(users);

            // Автоматически логиним после регистрации
            Login(user.Username, user.Password);
            return true;
        }

        public bool Login(string username, string password)
        {
            var users = ReadUsersFromFile();
            var user = users.FirstOrDefault(u =>
                u.Username == username && u.Password == password);

            if (user != null)
            {
                // Создаем сессию
                _httpContextAccessor.HttpContext.Session.SetString("Username", user.Username);
                _httpContextAccessor.HttpContext.Session.SetString("IsAuthenticated", "true");
                return true;
            }

            return false;
        }

        public bool UserExists(string username)
        {
            var users = ReadUsersFromFile();
            return users.Any(u => u.Username == username);
        }

        public bool IsAuthenticated()
        {
            return _httpContextAccessor.HttpContext.Session.GetString("IsAuthenticated") == "true";
        }

        public string GetCurrentUsername()
        {
            return _httpContextAccessor.HttpContext.Session.GetString("Username");
        }

        public void Logout()
        {
            _httpContextAccessor.HttpContext.Session.Remove("Username");
            _httpContextAccessor.HttpContext.Session.Remove("IsAuthenticated");
        }
    }
}
