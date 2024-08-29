using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGuidelines
{
    public class Methods
    {
    //    public List<string> Passwords { get; set; }
    //    public string Password { get; set; }
    //    public Methods(string password, List<string> passwords)
    //    {
    //        Passwords = passwords;
    //        Password = password;
    //    }

        public static bool AddPassword(string password, List<string> passwords)
        {
            if(passwords.Any(p => p == password))
            {
                return false;
            }
            if (password == "admin" || password == "mod")
            {
                return true;
            }
            bool numberButNot6 = false;
            int capitalVowelsCount = 0;
            string capitalVowels = "AEIOUY";

            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    int digit = c;
                    if(digit != 6)
                    {
                        numberButNot6 = true;
                    }
                }
                foreach (char vowel in capitalVowels)
                    if(c == vowel)
                    {
                        capitalVowelsCount++;
                    }
            }
                if (numberButNot6 = false || capitalVowelsCount < 2)
                {
                    return false;
                }

            if(password.Length <= 7 || password.Length >= 12)
            {
                return false;
            }
            if (password.Contains(" "))
            {
                return false;
            }
            passwords.Add(password);
            return true;

        }
    }
}
