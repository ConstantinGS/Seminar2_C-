using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день недели: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Number_week(number);


            void Number_week(int n_w)
            { 
                while(n_w<1 || n_w>7)
                {
                    Console.WriteLine("Пожалуйста, введите день недели: ");
                    n_w = Convert.ToInt32(Console.ReadLine()); 
                }

                if (n_w == 6 || n_w == 7 )
                {
                Console.WriteLine("Выходной"); 
                }
                else if (n_w > 0 && n_w < 6 )
                {
                Console.WriteLine("Рабочий"); 
                }
            }





        }
    }
}   









