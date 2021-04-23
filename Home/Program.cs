using System;

namespace Home
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВВедите первое число ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            double c = double.Parse(Console.ReadLine());
            double d = a + b + c;
            double e = a * b * c;

            Console.WriteLine("Сумма " + d);
            Console.WriteLine("Произведение" + e);
        }
    }
}
