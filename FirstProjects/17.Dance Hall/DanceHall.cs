using System;
namespace _18.DanceHall
{
    class DanceHall
    {
        static void Main()
        {
            double lengthHall = double.Parse(Console.ReadLine());
            double widthHall = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());

            double hallArea = lengthHall * widthHall;
            double wardrobeArea = wardrobeSide * wardrobeSide;
            double hallBench = hallArea / 10;

            double freeArea = hallArea - wardrobeArea - hallBench;

            double dancerCount = freeArea / 0.704;

            Console.WriteLine(Math.Floor(dancerCount));



       
        }
    }
}
