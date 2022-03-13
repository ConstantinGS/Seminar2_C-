using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину первой стороны: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину второй стороны: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину третьей стороны: ");
            int c = Convert.ToInt32(Console.ReadLine());
            sravnenie (a,b,c);

            void sravnenie(int number1, int number2, int number3)
            {
                if (number1==number2 || number3==number2 || number1==number3)
                {
                    Console.WriteLine("Треугольник равнобедренный");
                }
                else 
                {
                Console.WriteLine("Треугольник не является равнобедренным");
                }

            }
            
            





        }
    }
}   
