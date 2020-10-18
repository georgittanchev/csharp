using System;

namespace _10.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal moneyInHand = decimal.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            decimal lightSaberPrice = decimal.Parse(Console.ReadLine());
            decimal robesPrice = decimal.Parse(Console.ReadLine());
            decimal beltsPrice = decimal.Parse(Console.ReadLine());

            decimal moreLightSabersInCase = Math.Ceiling(studentsCount * 0.1M);


            decimal freeBelts = studentsCount / 6;

            decimal totalPrice = ((studentsCount * beltsPrice) - (freeBelts * beltsPrice) + (studentsCount * lightSaberPrice) +
                (moreLightSabersInCase * lightSaberPrice) + (studentsCount * robesPrice));

            if (moneyInHand >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalPrice - moneyInHand:F2}lv more.");
            }



            //            Yoda is starting his newly created Jedi academy. So, he asked master Ivan Cho to buy the needed equipment.
            //                The number of items depends on how many students will sign up. The equipment for the Padawan contains 
            //                lightsabers, belts and robes.
            //            You will be given the amount of money Ivan Cho has, the number of students and the prices of each item.You have 
            //            to help Ivan Cho calculate if the money he has is enough to buy all of the equipment, or how much more money he needs.
            //Because the lightsabres sometimes brakes, Ivan Cho should buy 10 % more(taken from the students count), rounded up to the
            //                next integer. Also, every sixth belt is free.
            //Input / Constraints

            //The input data will always be valid.There is no need to check it explicitly.
            //Output
            //The output should be printed on the console.
            //•	If the calculated price of the equipment is less or equal to the money Ivan Cho has:
            //o   "The money is enough - it would cost {the cost of the equipment}lv."
            //•	If the calculated price of the equipment is more than the money Ivan Cho has:
            //o    "Ivan Cho will need {neededMoney}lv more."
            //•	All prices must be rounded to two digits after the decimal point.


        }
    }
}
