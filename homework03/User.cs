using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework03
{
    internal class User
    {
        private string _password;
        public string UserName { get; set; }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Yanlish password formati");
                }
            }
        }
        public User(string userName)
        {
            if (userName.Length >= 8)
            {
                UserName = userName;
            }
            else
            {
                Console.WriteLine("Istifadeci adi duzgun daxil edilmadi");
            }
        }
        public bool PasswordChecker(string password)
        {
            if (password.Length > 8 && !string.IsNullOrEmpty(password))
            {
                bool isDigit = false;
                bool isUpper = false;
                bool isLower = false;

                for (int i = 0; i < password.Length; i++)
                {

                    if (char.IsDigit(password[i]))
                    {
                        isDigit = true;
                    }
                    else if (char.IsUpper(password[i]))
                    {
                        isUpper = true;
                    }
                    else if (char.IsLower(password[i]))
                    {
                        isLower = true;
                    }
                    if (isDigit && isLower && isUpper)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
