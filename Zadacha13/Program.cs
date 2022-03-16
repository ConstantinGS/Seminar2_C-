using System;
namespace ConsoleApp
{
    class Programm
    {
        static 
        void Main(string[] args)

        {

            Console.WriteLine("Vvedite chislo:");
            string number_string = Convert.ToString(Console.ReadLine());
            num_3(number_string);

            void num_3(string number)
            {
                bool a = int.TryParse(number, out int num);
                if (a)
                {
                    if (number.Length < 3)
                    {
                        Console.WriteLine("Третьего числа нет");

                    }
                    else
                    {
                        char[] b = {number[2]};
                        Console.WriteLine(b);
                    }
                
                }
                else
                {
                    Console.WriteLine("Вы ввели не число ");
                 
                }
            }


           

        }

    }
}   









