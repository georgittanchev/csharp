using System;

namespace _17.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            //                Поканени сте на 30-ти рожден ден, на който рожденикът черпи с огромна торта. 
            //            Той обаче не знае колко парчета могат да си вземат гостите от нея. Вашата задача е да напишете програма, 
            //                която изчислява броя на парчетата, които гостите са взели, преди тя да свърши. Ще получите размерите на тортата
            //                (широчина и дължина – цели числа в интервала [1...1000]) и след това на всеки ред, до получаване на командата
            //"STOP" 
            //                или докато не свърши тортата, броят на парчетата, които гостите вземат от нея. 
            ////Бележка: Едно парче торта е с размер 1х1 см.
            ////Да се отпечата на конзолата един от следните редове:
            ////•	"{брой парчета} pieces are left." - ако стигнете до STOP и не са свършили парчетата торта
            ////•	"No more cake left! You need {брой недостигащи парчета} pieces more." 


            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLenght = int.Parse(Console.ReadLine());
            int cakePieces = 0;
            int theWholeCake = cakeLenght * cakeWidth;


            while (theWholeCake >= 0)
            {
                string command = Console.ReadLine().ToUpper();

                if (command == "STOP")
                {

                    Console.WriteLine($"{theWholeCake} pieces are left.");
                    break;
                }

                cakePieces = int.Parse(command);
                theWholeCake = theWholeCake - cakePieces;
            }

            if (theWholeCake <= 0)
            {
                theWholeCake = Math.Abs(theWholeCake);
                Console.WriteLine($"No more cake left! You need {theWholeCake} pieces more.");
            }

        }
    }
}

