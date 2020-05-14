using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lv4
{
    //Z6
    class EmailValidator : IEmailValidatorService
    {
        public int MinLength { get; private set; }
        public EmailValidator(int minLength)
        {
            this.MinLength = minLength;
        }
        public bool IsValidAddress(String candidate)
        {
            if (String.IsNullOrEmpty(candidate))
            {
                return false;
            }
            return IsLongEnough(candidate) && EmailIsValid(candidate);
        }
        private bool IsLongEnough(String candidate)
        {
            return candidate.Length >= this.MinLength;
        }
        public static bool EmailIsValid(string email)
        {
            string expression = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expression))
            {
                if (Regex.Replace(email, expression, string.Empty).Length == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
