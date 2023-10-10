using System;
using System.Security.Policy;
using DelegateAndEventsLib;

namespace Day10Assign
{
    internal class StringOperMain :EventArgs
    {
        public static event  Greeting GreetEvent;
        public static event MakeFirstChUpper FirstCharEvent;
        static void Main(string[] args)
        {
            StringOperations stringOperations = new StringOperations();

            AttachStringToEachOther d1 = new AttachStringToEachOther(stringOperations.ConcatStrings);
            Console.WriteLine("Enter String one to Combine");
            string n1=Console.ReadLine();
            Console.WriteLine("Enter String two to Combine");
            string n2 = Console.ReadLine();
            String s1=d1(n1, n2);

            Console.WriteLine($"Combined String : {s1}");
            Console.WriteLine();

            FindLength d2 =new FindLength(stringOperations.StringLength);
            Console.WriteLine("enter string for count length : ");
            string n3=Console.ReadLine();
            int l = d2(n3);
            Console.WriteLine($"Length : {l}");
            Console.WriteLine();


            Greeting d3 = new Greeting(stringOperations.Greet);
            Console.WriteLine("Enter Your Name");
            string s2 = Console.ReadLine();
            GreetEvent += d3;
            GreetEvent(s2);
            Console.WriteLine();

            MakeFirstChUpper d4 = new MakeFirstChUpper(stringOperations.MakeFirstCharacterUppecase);
            FirstCharEvent += d4;
            Console.WriteLine("Enter String to make first character Upper : ");
            string s3 = Console.ReadLine();
            string s=FirstCharEvent(s3);
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
