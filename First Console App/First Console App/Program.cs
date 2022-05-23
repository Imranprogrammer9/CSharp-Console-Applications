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
        }
    }
}
