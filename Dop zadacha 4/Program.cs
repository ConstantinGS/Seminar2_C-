using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Vvedite chislo:");
            int number = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            int min = 10;
            int i =0;
            int i_max=0;
            int i_min=0;
            while((number/10!=0)||(number%10!=0))
            {
                if (number%10>max)
                {
                    max=number%10;
                    i_max=i;
                }
                if (number%10<min)
                {
                    min=number%10;
                    i_min=i;
                }
                number=number/10;
                i++;
            }

            if (i_min>i_max)
            {
                Console.WriteLine("Минимальная цифра левее");
            }

            else if (i_min<i_max)
            {
                Console.WriteLine("Максимальная цифра левее");

            }
            else
            {
                Console.WriteLine("Все цифры в числе одинаковы");

            }
            



            
            

            

        }
    }
}   
