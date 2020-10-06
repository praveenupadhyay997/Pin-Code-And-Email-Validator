using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PinCodeAndEmailEvaluator
{
    class PinCodeAndEmailRegexValidator
    {
        public static string PIN_REGEXUC2 = "^(?![a-zA-Z#$%&'*+/=?^_`{|}~-][0-9]).{6}$";
        public static string pinCode;
        public static string emailID;

        public bool maximumDigitValidator(string pinCode)
        {
            return Regex.IsMatch(pinCode, PIN_REGEXUC2);
        }
    }
}
