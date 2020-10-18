using System;

namespace _11.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());

            decimal headsetBrokenCounter = 0;
            decimal mouseBrokenCounter = 0;
            decimal keyboardBrokenCounter = 0;
            decimal displayBrokenCounter = 0;

            decimal price = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    headsetBrokenCounter++;
                    price += headsetPrice;

                }
                if (i % 3 == 0)
                {
                    mouseBrokenCounter++;
                    price += mousePrice;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardBrokenCounter++;
                    price += keyboardPrice;
                }
                if (keyboardBrokenCounter == 2)
                {
                    displayBrokenCounter++;
                    keyboardBrokenCounter = 0;
                    price += displayPrice;
                }


            }

            //decimal headsetTotalPrice = headsetBrokenCounter * headsetPrice;
            //decimal mouseTotalPrice = mouseBrokenCounter * mousePrice;
            //decimal keyboardTotalPrice = keyboardBrokenCounter * keyboardPrice;
            //decimal displayTotalPrice = displayBrokenCounter * displayPrice;

            //decimal totalExpenses = headsetTotalPrice + mouseTotalPrice + keyboardTotalPrice + displayTotalPrice;

            Console.WriteLine($"Rage expenses: {price:F2} lv.");







//            As a MOBA challenger player, Pesho has the bad habit to trash his PC 
//                when he loses a game and rage quits.His gaming setup consists of headset, mouse, 
//                keyboard and display. You will receive Pesho`s lost games count. 
//Every second lost game, Pesho trashes his headset.
//Every third lost game, Pesho trashes his mouse.
//When Pesho trashes both his mouse and headset in the same lost game, he also trashes his keyboard.
//Every second time, when he trashes his keyboard, he also trashes his display.
//You will receive the price of each item in his gaming setup.Calculate his rage expenses for renewing his gaming equipment.

        }
    }
}
