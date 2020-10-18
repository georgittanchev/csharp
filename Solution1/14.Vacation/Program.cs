using System;

namespace _14.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationMoney = double.Parse(Console.ReadLine());
            double moneyAtTheMoment = double.Parse(Console.ReadLine());
            string action = "";
            double moneySaved = 0;
            int counter = 0;
            int spendCounter = 0;
            
            while (vacationMoney > moneyAtTheMoment)
            {
                action = Console.ReadLine();
                moneySaved = double.Parse(Console.ReadLine());

                if (action == "spend")
                {
                    moneyAtTheMoment -= moneySaved;
                    spendCounter++;

                    if (moneySaved > moneyAtTheMoment)
                    {
                        moneyAtTheMoment = 0;
                    }
                }
                else if (action == "save")
                {
                    moneyAtTheMoment += moneySaved;
                    spendCounter -= spendCounter;
                }
                counter++;

                if (spendCounter >= 5)
                {
                    Console.WriteLine($"You can't save the money.");
                    Console.WriteLine($"{counter}");
                    break;
                }

               
            }

            if (vacationMoney <= moneyAtTheMoment)
            {
                 Console.WriteLine($"You saved the money for {counter} days.");
            }



        }
    }
}
