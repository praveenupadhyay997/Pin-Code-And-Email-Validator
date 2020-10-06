using System;
using System.Security.Cryptography.X509Certificates;

namespace PinCodeAndEmailEvaluator
{
    class Program
    {
        public static string pinCode;
        public static string emailId;
        public static PinCodeAndEmailRegexValidator pinCodeAndEmailRegex = new PinCodeAndEmailRegexValidator();

        static void Main(string[] args)
        {   
           
            Console.WriteLine("===========================================");
            Console.WriteLine("Welcome to the Pin Code and Email Validator");
            Console.WriteLine("===========================================");           
        }
    }
}
