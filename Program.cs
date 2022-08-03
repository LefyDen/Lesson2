using System;

namespace HOME2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дай мені перше число:");
            int num = Convert.ToInt32(Console.ReadLine());


            double x = -6 * Math.Pow(num, 3) + 5 * Math.Pow(num, 2) - 10 * num + 15;
            Console.WriteLine(x);

            Console.WriteLine("Дай мені друге число:");
            int num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(Math.Abs(num2) * Math.Sin(num2));

            Console.WriteLine(Math.PI * num2 * 2);

            Console.WriteLine(Math.Max(num, num2));
            Console.WriteLine(Math.Max(num, num2));
        }
    }
}
