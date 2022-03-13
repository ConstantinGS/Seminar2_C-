using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день: ");
            int day = Convert.ToInt32(Console.ReadLine());
            sravnenie (year,month,day);

            void sravnenie(int y, int m, int d)
            {
                int d_y = 2022 - y;
                if (m==2)
                {
                    if (d>1)
                    {
                        Console.WriteLine(d_y-1);
                    }
                    else
                    {
                        Console.WriteLine(d_y);
                    }
                }
                else if (m==1)
                {
                    Console.WriteLine(d_y);
                }
                else
                {
                    Console.WriteLine(d_y-1);
                } 
            }




        }
    }
}   
