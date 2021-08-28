using System;
using System.Text.RegularExpressions;

namespace UserRegistrationLambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name: ");
            string userFirstName = Console.ReadLine();
            if (LambdaFunction.isFirstNameValidornot(userFirstName, regex.firstName) == true)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadKey();

            Console.WriteLine("Enter Last Name: ");
            string userLastName = Console.ReadLine();
            if (LambdaFunction.IsLastNameValidornot(userLastName, regex.lastName) == true)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadKey();

            
            Console.WriteLine("Enter EmailId: ");
            string userEmailId = Console.ReadLine();
            if (LambdaFunction.IsEmailIdValidornot(userEmailId, regex.emailId) == true)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadKey();

            Console.WriteLine("Enter Phone Number: ");
            string userPhoneNumber = Console.ReadLine();
            if (LambdaFunction.IsPhoneNoValidornot(userPhoneNumber, regex.phoneNumber) == true)
            {
                    Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadKey();

            Console.WriteLine("Enter Password: ");
            string userPassword = Console.ReadLine();
            if (LambdaFunction.isPasswordValidornot(userPassword, regex.password) == true)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
