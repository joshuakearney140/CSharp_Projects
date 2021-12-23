using System;

namespace Subroutine_Input_validation__length_validation_
{
    class Program
    {
        
        
        static void GetInputLengthCheck()
        {
            bool valid = false;
            while (!valid)
            {
                Console.WriteLine("Enter password: ");
                string password = Console.ReadLine();

                if(password.Length < 8)
                {
                    valid = false;
                }
                else
                {
                    valid = true;
                }
            }           
        }
         
        static void Main(string[] args)
        {
            GetInputLengthCheck();
            Console.WriteLine("Valid password!");
        }
    }
}
