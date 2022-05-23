using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Code For Printing String
            Console.WriteLine("------------------------------------------------------Welcome to C# Programming!----------------------------------------");
            Console.WriteLine("Enter Your First Name:");
            String FirstName = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name:");
            String LastName = Console.ReadLine();
            Console.WriteLine("Enter Your Education:");
            String Education = Console.ReadLine();
            Console.WriteLine("Enter Your Skills");
            String Skill = Console.ReadLine();
            Console.WriteLine("Enter Your Phone No.");
            String Phone = Console.ReadLine();
            Console.WriteLine("Your Profile is Ready. You can check it below!");
            Console.WriteLine(FirstName + " " + LastName);
            Console.WriteLine(Education);
            Console.WriteLine(Skill);
            Console.WriteLine(Phone);
            Console.WriteLine("My name is: " + FirstName + " " + LastName + "." + " I have degree of " + Education + "." + 
                " My SkillSet consists of " + Skill + "." + " Want to work with me! Just contact me:" + Phone + ".");
            Console.ReadLine();

            //Code For Printing Integer
            Console.WriteLine("------------------------------------------------------Integer Printing-------------------------------------------------");
            //Addition
            Console.WriteLine("Enter Your First Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Second Number");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("Addition = " + sum);

            //Subtraction
            Console.WriteLine("Enter Your First Number");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Second Number");
            int num4 = int.Parse(Console.ReadLine());
            int sub = num3 - num4;
            Console.WriteLine("Subtracction = " + sub);

            //Multiplication
            Console.WriteLine("Enter Your First Number");
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Second Number");
            int num6 = int.Parse(Console.ReadLine());
            int mult = num5 * num6;
            Console.WriteLine("Multiplication = " + mult);

            //Division
            Console.WriteLine("Enter Your First Number");
            int num7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Second Number");
            int num8 = int.Parse(Console.ReadLine());
            int div = num7 / num8;
            Console.WriteLine("Division= " + div);
            Console.ReadLine();
        }
    }
}
