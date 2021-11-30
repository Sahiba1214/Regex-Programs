using System;
using System.Text.RegularExpressions;

namespace CreateRegexProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            { UserRegistration validation = new UserRegistration();
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Welcome to the User Registration validation program");
                Console.WriteLine("Enter the validation to be executed : \n 1. First Name \n 2. Last Name \n 3. Email ID \n 4. Mobile \n 5. Password Rule-1 \n 6. Password Rule-2 \n 7. Password Rule-3 \n 8. Password Rule-4 \n 9. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine(validation.ValidateFirstName("Sahiba"));
                        break;
                    case 2:
                        Console.WriteLine(validation.ValidateLastName("Fatma"));
                        break;
                    case 3:
                        Console.WriteLine(validation.ValidateEmail("sahiba1214@gmail.com"));
                        break;
                    case 4:
                        Console.WriteLine(validation.ValidateMobile("91 7004830003"));
                        break;
                    case 5:
                        Console.WriteLine(validation.ValidatePassword1("sahiba1214"));
                        break;
                    case 6:
                        Console.WriteLine(validation.ValidatePassword2("sahiba1"));
                        break;
                    case 7:
                        Console.WriteLine(validation.ValidatePassword3("sahiba2"));
                        break;
                    case 8:
                        Console.WriteLine(validation.ValidatePassword4("sahiba3"));
                        break;
                    case 9:
                        flag = false;
                        break;
                }
            }            
        }
    }
}
                
            


                

