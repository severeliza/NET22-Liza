using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.MockImitation
{
    internal class LoginManager
    {
        private readonly ICreateLogin _service;
        public LoginManager(ICreateLogin service) { _service = service; }
        public string PrintLogin() => $"Result: {_service.SendLogin()}";
    }
}
