using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            double Dollar = 2.66;
            double Euro = 3.55;
            Console.WriteLine("Введите сумму рублей");
            double rouble = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cумма в долларах: " + rouble / Dollar);
            Console.WriteLine("Cумма в евро: " + rouble / Euro);
            
        }
    }
}
