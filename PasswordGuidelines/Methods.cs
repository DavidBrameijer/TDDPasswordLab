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
            if (password == "admin")
            {
                foreach(string p in passwords)
                {
                    if (p == "admin")
                    {
                        return false;
                    }
                }
                return true;
            }
            if(password == "mod")
            {
                foreach (string p in passwords)
                {
                    if (p == "mod")
                    {
                        return false;
                    }
                }
                return true;
            }
            foreach (string p in passwords)
            {
                if (p == password)
                {
                    return false;
                }

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
                if (numberButNot6 = false || capitalVowelsCount < 2)
                {
                    return false;
                }
            }

            if(password.Length < 7 && password.Length > 12)
            {
                return false;
            }
            else if (password.Contains(" "))
            {
                return false;
            }
            passwords.Add(password);
            return true;

        }
    }
}
