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
                while(number<1 || number>7)
                {
                    Console.WriteLine("Пожалуйста, введите день недели: ");
                    number = Convert.ToInt32(Console.ReadLine()); 
                }

                if (number == 6 || number == 7 )
                {
                Console.WriteLine("Выходной"); 
                }
                else if (number > 0 && number < 6 )
                {
                Console.WriteLine("Рабочий"); 
                }
            }





        }
    }
}   









