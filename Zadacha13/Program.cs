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
            
            bool a = int.TryParse(number_string, out int num);
            if (a)
            {
                if (number_string.Length < 3)
                {
                    Console.WriteLine("Третьего числа нет");

                }
                else
                {
                    char[] b = {number_string[2]};
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









