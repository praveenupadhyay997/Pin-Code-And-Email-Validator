using System;
using System.Security.Cryptography.X509Certificates;

namespace PinCodeAndEmailEvaluator
{
    class Program
    {
        public static string pinCode;
        public static string emailId;
        public static PinCodeAndEmailRegexValidator pinCodeAndEmailRegex = new PinCodeAndEmailRegexValidator();
        /// <summary>
        /// Main method recalling all the implementing functions
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {   
           
            Console.WriteLine("===========================================");
            Console.WriteLine("Welcome to the Pin Code and Email Validator");
            Console.WriteLine("===========================================");

            bool validationKey;
            Console.WriteLine("Enter the pin code=");
            pinCode = Console.ReadLine();
            validationKey = pinCodeAndEmailRegex.maximumDigitValidator(pinCode);

            Console.WriteLine(validationKey? "The Pin Code {0} is Valid.": "The Pin Code {0} is Not Valid.", pinCode);

            Console.WriteLine("Enter the Email-ID=");
            emailId = Console.ReadLine();
            validationKey = pinCodeAndEmailRegex.emailIDValidator(emailId);

            Console.WriteLine(validationKey ? "The Email-Id {0} is Valid." : "The Email-Id {0} is Not Valid.", emailId);
        }
    }
}
