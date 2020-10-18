using System;

namespace _10.Company
{
    class Program
    {
        static void Main(string[] args)
        {

            int tabsOpened = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 0; i < tabsOpened; i++)
            {
                string webSites = Console.ReadLine();

                if (salary != 0)
                {

                    if (webSites == "Facebook")
                    {
                        salary -= 150;
                    }
                    else if (webSites == "Instagram")
                    {
                        salary -= 100;
                    }
                    else if (webSites == "Reddit")
                    {
                        salary -= 50;
                    }
                }
                if (salary == 0)
                {
                    Console.WriteLine("You have lost your salary. ");
                    break;
                }

  
            }

            if (salary != 0)
            {
                Console.WriteLine($"{salary}");
            }
           







        }
    }
}
