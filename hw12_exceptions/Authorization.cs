using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace hw12_exception
{
    public class MyAuthorization
    {
        public static bool ValidateAuthorization(string Login, string Password, string ConfirmPassword)
        {
            bool result = false;

            if (!ValidateLoginInput(Login))
            {
                throw new WrongLoginException("Incorrect login."); 
            }

            if (!ValidatePassword(Password) || (Password != ConfirmPassword))
            {
                throw new WrongPasswordException("Incorrect password."); 
            }

            result = true;

            return result;
        }

        private static bool ValidateLoginInput(string input)
        {
            if (input!= null && input.Length < 20 && !input.Contains(' '))
            {
                return true;
            }

            return false;
        }

        private static bool ValidatePassword(string input)
        {
            if (ValidateLoginInput(input) && Regex.IsMatch(input, @"\w*\d+\w*"))
            {
                return true;
            }

            return false;
        }
    }
}
