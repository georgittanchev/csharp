﻿using System;
class ZooShop
{
    static void Main()
    {
        double dogs = double.Parse(Console.ReadLine());
        double otherDogs = double.Parse(Console.ReadLine());
        double expenses = (dogs * 2.50) + (otherDogs * 4);
        Console.WriteLine("Крайната сума е: {0:f2}лв.", expenses);
    }
}


//8. Зоомагазин
//Напишете програма, която пресмята нужните разходи за закупуването на храна за кучета.Храната се
//пазарува основно за кучета, от зоомагазин, но понякога стопанинът им купува и за животните на съседа му.
//Една опаковка храна за кучета е на цена 2.50лв., а всяка останала, която не е за тях струва 4лв.
//Вход
//От конзолата се четат 2 реда:
//3. Броят на кучетата – цяло число в интервала [0… 100]
//4. Броят на останалите животни - цяло число в интервала [0… 100]
//Изход
//На конзолата се отпечатва:
//&quot;{крайната сума} lv.&quot;
//Резултатът трябва да бъде форматиран до втората цифра след десетичния знак.