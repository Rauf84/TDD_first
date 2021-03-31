using System;
using System.Collections.Generic;
using System.Text;

namespace TDDFirst
{
    public class Userdata
    {
        /*
            o Måste vara längre än 6 tecken *
            o Får inte vara längre än 25 tecken *
            o Måste ha minst en versal bokstav *
            o Måste ha minst en gemen bokstav *
            o Måste ha minst ett av följande tecken: ! . : $ % & ( ) = /

        */
        public bool IsPasswordOk(string password)
        {
            bool upper = false;
            bool lower = false;
            if (password.Length > 6 && password.Length < 25) 
            {
                foreach (var i in password)
                {
                    string s = "$%&()=/";
                    foreach (var p in s)
                    {
                        if (password.Contains(p)) 
                        {
                             if (!Char.IsUpper(i))
                            {
                                upper = true;
                            }
                             if (!Char.IsLower(i))
                            {
                                lower = true;
                            }
                             if (upper && lower)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public bool IsEmailOk(string email)
        {
            return false;
        }

        public bool IsPhoneOk(string phone)
        {
            return false;
        }
    }
}
