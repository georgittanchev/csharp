using System;
class AreaPerimeterCircle
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double area = Math.PI * r * r;
        double perimeter = 2 * Math.PI * r;
        Console.WriteLine("{0:f2}, {1:f2}", area, perimeter);

    }
}

//Напишете програма, която чете от конзолата число r и пресмята и отпечатва лицето и периметъра на кръг /
//окръжност с радиус r, като форматирате изхода до втория знак след десетичната запетая.
//Насоки
//За изчисленията можете да използвате следните формули:
// area = Math.PI* r * r
// perimeter = 2 * Math.PI * r