using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Vvedite chislo:");
            int number = Convert.ToInt32(Console.ReadLine());
            Zerkalo(number);


            void Zerkalo(int int_number)
            {
                string number_string = Convert.ToString(int_number);
                while (number_string.Length !=3)
                {
                    Console.WriteLine("Вы ввели не трехзначное число. Попробуйте еще раз.");
                    int_number = Convert.ToInt32(Console.ReadLine());
                    number_string = Convert.ToString(int_number);

                }
                char[] a = {number_string[2], number_string[1], number_string[0]};
                Console.WriteLine(a);
            }









        }










    }
}