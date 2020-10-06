using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PinCodeAndEmailEvaluator
{
    class PinCodeAndEmailRegexValidator
    {
        public static string PIN_REGEXUC4 = "^[0-9]{3}[ ]?[0-9]{3}$";
        public static string EMAIL_REGEX = "^[0-9A-Za-z]+([+-_.][a-zA-Z]+)*[@][0-9A-Za-z]+[.][0-9A-Za-z]{2,3}([.][A-Za-z]{2})$";
        /// <summary>
        /// Maximums the digit validator.
        /// </summary>
        /// <param name="pinCode">The pin code.</param>
        /// <returns></returns>
        public bool maximumDigitValidator(string pinCode)
        {
            return Regex.IsMatch(pinCode, PIN_REGEXUC4);
        }
        /// <summary>
        /// Emails the identifier validator.
        /// </summary>
        /// <param name="emailId">The email identifier.</param>
        /// <returns></returns>
        public bool emailIDValidator(string emailId)
        {
            return Regex.IsMatch(emailId, EMAIL_REGEX);
        }
    }
}
