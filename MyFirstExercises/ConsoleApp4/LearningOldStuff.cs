using System;
class LearningOldStuff
{
    static void Main()
    {
        Console.WriteLine("Запиши първо име, а после години.");
        string name = Console.ReadLine();
        int godini = int.Parse(Console.ReadLine());
        Console.WriteLine("Моето име е {0}, аз съм на {1} годинки", name, godini);
        if (name == "Georgi")
        {
            Console.WriteLine("Ти си много велик и умен, защо5то си Георги");
        }
        else
        {
            Console.WriteLine("Не ставаш за нищо");
        }
    }
}