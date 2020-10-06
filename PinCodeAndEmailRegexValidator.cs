using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PinCodeAndEmailEvaluator
{
    class PinCodeAndEmailRegexValidator
    {
        public static string PIN_REGEXUC4 = "^[0-9]{3}[ ]?[0-9]{3}$";
        public static string EMAIL_REGEX = "^[0-9A-Za-z]+([+-_.][a-zA-Z]+)*$";
        public static string pinCode;
        public static string emailID;

        public bool maximumDigitValidator(string pinCode)
        {
            return Regex.IsMatch(pinCode, PIN_REGEXUC4);
        }

        public bool emailIDValidator(string emailId)
        {
            return Regex.IsMatch(emailId, EMAIL_REGEX);
        }
    }
}
