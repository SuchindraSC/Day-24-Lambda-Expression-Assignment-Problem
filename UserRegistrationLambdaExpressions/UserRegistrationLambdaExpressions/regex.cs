using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationLambdaExpressions
{
    public class regex
    {
        public static string firstName = "^[A-Z][a-z]{3,}$";
        public static string lastName = "^[A-Z][a-z]{3,}$";
        public static string emailId = @"^([a-z]{3})+[\.+]([a-z]{3,})+@([a-z]{2})+[\.+]([a-z]{2})+[\.+]([a-z]{2,})$";
        public static string phoneNumber = "([1-9]{2})+[ ][1-9]+([0-9]{9})";
        public static string password = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!*@#$%^&+=]).{8,}$";
    }
}
