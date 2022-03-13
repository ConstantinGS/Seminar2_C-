using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Vvedite chislo:");
            int number = Convert.ToInt32(Console.ReadLine());
            string number_string = Convert.ToString(number);
            while (number_string.Length !=3)
            {
               Console.WriteLine("Вы ввели не трехзначное число. Попробуйте еще раз.");
               number = Convert.ToInt32(Console.ReadLine());
               number_string = Convert.ToString(number);

            }
            char[] a = {number_string[2], number_string[1], number_string[0]};
            Console.WriteLine(a);









        }










    }
}