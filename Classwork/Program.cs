using System;


namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isTrue = true;
            Console.WriteLine((isTrue ? "I'am in true" : "I'am in false"));

            int age = 25;
            if (age < 18) { Console.WriteLine("Tu esi jaunietis "); }
            else if (age >= 70) { Console.WriteLine("Tu esi seniors "); }
            else { Console.WriteLine("Tu esi darbspējiga vecumā "); }

            int switchCase = 1;
            switch (switchCase)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    break;
                default:
                    Console.WriteLine("I dont know what it is ");
                    break;

            }


            string switchtext = "sasas";
            switch (switchtext)
            {
                case "uno":
                    Console.WriteLine("Case 1");
                    break;
                case "duos":
                    Console.WriteLine("Case 2");
                    break;
                case "bla bla":
                    Console.WriteLine("Case 3");
                    break;
                default:
                    Console.WriteLine("I dont know what it is ");
                    break;

            }

            Console.ReadLine();
        }
    }
}
