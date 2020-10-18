using System;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {

            double hallLenght = double.Parse(Console.ReadLine()) * 100;
            double hallWidth = double.Parse(Console.ReadLine()) * 100;
            double A = double.Parse(Console.ReadLine());

            double hallSize = (hallLenght * hallWidth);
            double cupBoardSize = (A*100) * (A*100);
            double benge = hallSize / 10;

            double realHallSize = hallSize - cupBoardSize - benge;

            double onePerson = 40 + 7000;

            double howMany = realHallSize / onePerson;

            Console.WriteLine(Math.Floor(howMany));


          

        }
    }
}
