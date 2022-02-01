using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Palindrome
    {
        public bool IsPalindrome(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);


            if(str == temp)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
