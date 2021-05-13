using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalCoffeCost = 0;
            
            start:
            Console.WriteLine("Enter Your Coffe Size : \n 1 - Small \n 2 - Meduim \n 3 - Large");
            int UserChoice = int.Parse(Console.ReadLine());
            switch(UserChoice)
            {
                case 1:
                    Console.WriteLine("Your Choice is Small");
                    TotalCoffeCost += 1;
                    break;
                case 2:
                    Console.WriteLine("Your Choice is Meduim");
                    TotalCoffeCost += 2;
                    break;
                case 3:
                    Console.WriteLine("Your Choice is Large");
                    TotalCoffeCost += 3;
                    break;
                default:
                    Console.WriteLine("Your Choice is {0} invalid ",UserChoice);
                    goto start;  
            }

            decide:
            Console.WriteLine("Do you want to make anoter? Yes or No");
            string UserDecision = Console.ReadLine();
            switch(UserDecision.ToUpper())
            {
                case "YES":
                    goto start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("You Entered invalid Decison");
                    goto decide;
            }
            Console.WriteLine("Thanks for shopping with us...");
            Console.WriteLine("Your Total Coffee Cost is {0}" , TotalCoffeCost);
        }
    }
}
