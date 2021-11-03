using System;

namespace RegexWithLambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*************\nWELCOME TO USER REGISTRATION PROBLEMS\n*************");

            bool isExit = false;
            int options;
            while (!isExit)
            {
                Console.WriteLine("Choose 1.FirstNameValidate\n 2. LastNameValidate\n 3. EmailValidate\n 4.PhnoValidate\n 5.PasswordValidate\n 6.LambaExpressionToValidateUserDetails");
                options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        RegularExpressionValidation regularExpression = new RegularExpressionValidation();
                        Console.WriteLine("enter firstname");
                        string firstName = Console.ReadLine();
                        string result = regularExpression.FirstnameCheck(firstName);
                        Console.WriteLine(result);
                        break;
                    case 2:
                        RegularExpressionValidation regularExpression1 = new RegularExpressionValidation();
                        Console.WriteLine("enter lastname");
                        string lastName = Console.ReadLine();
                        regularExpression1.LastNameCheck(lastName);
                        break;
                    case 3:
                        RegularExpressionValidation regularExpression2 = new RegularExpressionValidation();
                        Console.WriteLine("enter email");
                        string email = Console.ReadLine();
                        string result1 = regularExpression2.EmailCheck(email);
                        Console.WriteLine(result1);
                        break;
                    case 4:
                        RegularExpressionValidation regularExpression3 = new RegularExpressionValidation();
                        Console.WriteLine("enter phno");
                        string phno = Console.ReadLine();
                        string result2 = regularExpression3.PHNoCheck(phno);
                        Console.WriteLine(result2);
                        break;
                    case 5:
                        RegularExpressionValidation regularExpression4 = new RegularExpressionValidation();
                        Console.WriteLine("enter password");
                        string password = Console.ReadLine();
                        regularExpression4.PasswordCheck(password);
                        break;
                    case 6:
                        RegularExpressionValidation regularExpression9 = new RegularExpressionValidation();
                        Console.WriteLine("enter firstname");
                        string firstName1 = Console.ReadLine();
                        string output1 = regularExpression9.LambdaExpressionFirstnameCheck(firstName1);
                        Console.WriteLine(output1);
                        Console.WriteLine("enter lastname");
                        string lastName1 = Console.ReadLine();
                        string output2 = regularExpression9.LambdaExpressionLastnameCheck(lastName1);
                        Console.WriteLine(output2);
                        Console.WriteLine("enter email");
                        string email1 = Console.ReadLine();
                        string output3 = regularExpression9.LambdaExpressionEmailCheck(email1);
                        Console.WriteLine(output3);
                        Console.WriteLine("enter phno");
                        string phno1 = Console.ReadLine();
                        string output4 = regularExpression9.LambdaExpressionPhoneNumberCheck(phno1);
                        Console.WriteLine(output4);
                        Console.WriteLine("enter password");
                        string password1 = Console.ReadLine();
                        string output5 = regularExpression9.LambdaExpressionpasswordCheck(password1);
                        Console.WriteLine(output5);
                        break;
                    default:
                        Console.WriteLine("choose valid options");
                        break;
                }
            }
        }
    }
}