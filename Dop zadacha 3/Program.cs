using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)
        {
            
            double deposit = 1000.0;
            double p = 1.05;
            int i=0;
            Console.WriteLine("Введите количество месяцев: ");
            int month = Convert.ToInt32(Console.ReadLine());
             // Не совсем понял условие. Каждый месяц увеличивается  на 1,5 от имеющейся суммы. От конечной или от начальной? 
             // Сделал от конечной. Если от начальной, то объявление  int s = deposit ; затем  s = s+deposit/100*1.5;
            while(month>i)
            {
                deposit = deposit*p;
                i++; 
            } 
            double s = Math.Round(deposit, 2, MidpointRounding.ToZero);  
            Console.WriteLine(s);


        }
    }
}   
