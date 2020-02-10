using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3_Console_Input_Hand_In
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameAns;
            int ageAns;
            string year;
            int IntYear;
            int born;

            int FirstNum;
            int SecondNum;
            int ThirdNum;

            double Dist1;
            double Dist2;
            double Average;

            double Leg1;
            double Leg2;
            double Hypot;


            //Greetings
            Console.WriteLine("Hello! What is your first and last name?");
            nameAns = Console.ReadLine();
            Console.WriteLine("Great Job! Now, what is your current age?");
            ageAns = Convert.ToInt32(Console.ReadLine());
            year = System.DateTime.Now.ToString("yyyy");
            IntYear = Convert.ToInt32(year);
            born = (IntYear - ageAns);
            Console.WriteLine($"Fantastic! So your name is {nameAns} and you were maybe born in {born} depending on your birthday.");
            Console.WriteLine("");

            //Adder
            Console.WriteLine("Type three integers to be added.");
            FirstNum = Convert.ToInt32(Console.ReadLine());
            SecondNum = Convert.ToInt32(Console.ReadLine());
            ThirdNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The sum of your integers is {FirstNum + SecondNum + ThirdNum}.");

            //Distance
            Console.WriteLine("Enter two distances in Km to be rounded.");
            Dist1 = Convert.ToDouble(Console.ReadLine());
            Dist2 = Convert.ToDouble(Console.ReadLine());
            Average = Math.Round(((Dist1 + Dist2) / 2),2);
            Console.WriteLine($"The average of your entered distances is {Average}.");

            //Hypotenuse
            Console.WriteLine("Enter the length of two different legs of a right angle triangle.");
            Leg1 = Convert.ToDouble(Console.ReadLine());
            Leg2 = Convert.ToDouble(Console.ReadLine());
            Hypot = Math.Round(Math.Sqrt((Leg1 * Leg1) + (Leg2 * Leg2)),2);
            Console.WriteLine($"The hypotenuse of your triangle is {Hypot}.");



            Console.ReadLine();

        }
    }
}
