namespace PsychologyThesis
{
    using System;
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            string trait1, trait2;

            Console.WriteLine("Do you like meeting new people?");
            Console.WriteLine("1)Yes");
            Console.WriteLine("2)No");
            Console.WriteLine("3)Sometimes");

            Console.WriteLine("Select the number as the answer:");
            string userAns1 = Console.ReadLine() ;
            int ans1 = Convert.ToInt32(userAns1);

            
            if (ans1 == 1)
            {
                trait1 = "Extrovert";
                
            }else if(ans1 == 2)
            {
                trait1 = "Introvert";
            }
            else
            {
                trait1 = "Ambivert";
            }

            Console.WriteLine("\nAre you easily disappointed?");

            Console.WriteLine("1)Yes");
            Console.WriteLine("2)No");
            Console.WriteLine("3)Sometimes");

            Console.WriteLine("Select the number as the answer:");
            string userAns2 = Console.ReadLine();
            int ans2 = Convert.ToInt32(userAns2);

            if (ans2 == 1)
            {
                trait2 = "care free";

            }
            else if (ans2 == 2)
            {
                trait2 = "very pessimitic";
            }
            else
            {
                trait2 = "optimistic";
            }

            Console.WriteLine("\nYou are " + trait1 + " and " + trait2);


            Console.WriteLine("\nEnter your birthmonth in number to calculate your zodiac");
            int zodiacInt = Convert.ToInt32(Console.ReadLine());

            int partnerInt = Convert.ToInt32((zodiacInt * 2) % 12) + 1;
            Console.WriteLine("\nYour partner was born in the month of: " + partnerInt);
        }
    }
}