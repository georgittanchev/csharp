using System;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {


            //            Георги трябва да построи космически кораб, който да събира част от екипажа му. За целта, той трябва 
            //                да го направи така, че да има място за поне трима астронавти, но за не повече от 10.Всеки астронавт се нуждае о
            //                т малка стая, която да е с размери: 2 метра ширина, 2 метра дължина и с 40 см по-висока от средната височина 
           // на астронавтите.
            //Напишете програма, която изчислява обема на кораба, колко астронавта ще събере и принтира на конзолата дали  той е 
            // достатъчно голям.
            //Вход
            //Входът се чете от конзолата и съдържа точно 4 реда:
            //•	На първия ред е широчината на кораба - реално число в интервала[1.00... 10.00]
            //•	На втория ред е  дължината на кораба - реално число в интервала[1.00…10.00]
            //•	На третия ред е височината на кораба - реално число в интервала[1.00…20.00]
            //•	На четвъртия ред е средната височина на астронавтите  -реално число в интервала[1.50 … 1.90]

            double spaceWidth = double.Parse(Console.ReadLine());
            double spaceLength = double.Parse(Console.ReadLine());
            double spaceHeight = double.Parse(Console.ReadLine());
            double astronautsHeight = double.Parse(Console.ReadLine());

            double fullSpaceSize = spaceHeight * spaceLength * spaceWidth;

            double allowableSpaceHeight = astronautsHeight + 0.40;
            double fullRoomSize = (2 * 2) * allowableSpaceHeight;

            double howMany = Math.Floor(fullSpaceSize / fullRoomSize);

            if (howMany >= 3 && howMany <= 10)
            {
                Console.WriteLine($"The spacecraft holds {howMany} astronauts.");
            }
            else if (howMany < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (howMany > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }



















        }
    }
}
