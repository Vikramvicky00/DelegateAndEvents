using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventsLib
{
    public delegate String AttachStringToEachOther(string s1, string s2);
    public delegate int FindLength(string s1);
    public delegate String Greeting(string s);
    public delegate String MakeFirstChUpper(string s);
    public class StringOperations
    {
        public string ConcatStrings(string s1,string s2)
        {
            return s1 + s2;
        }

        public int StringLength(string s)
        {
            return s.Length;
        }
     
       public string Greet(string name) {
            string s = $"Hello {name}, How are you?";
            Console.WriteLine(s);
            return null;
        }

        public string MakeFirstCharacterUppecase(string str) {
            return char.ToUpper(str[0]) + str.Substring(1);
        }
    }
}
