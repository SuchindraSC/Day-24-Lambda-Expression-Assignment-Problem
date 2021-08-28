using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationLambdaExpressions
{
    public class LambdaFunction
    {
        public static Func<string, string, bool> isFirstNameValidornot = (string userfirstName, string firstName) => Regex.IsMatch(userfirstName, firstName);
        public static Func<string, string, bool> IsLastNameValidornot = (string userLastName, string lastName) => Regex.IsMatch(userLastName, lastName);
        public static Func<string, string, bool> IsEmailIdValidornot = (string userEmailId, string emailId) => Regex.IsMatch(userEmailId, emailId);
        public static Func<string, string, bool> IsPhoneNoValidornot = (string userPhoneNumber, string phoneNumber) => Regex.IsMatch(userPhoneNumber, phoneNumber);
        public static Func<string, string, bool> isPasswordValidornot = (string userPassword, string password) => Regex.IsMatch(userPassword, password);
    }
}
