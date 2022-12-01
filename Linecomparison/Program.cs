using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x1-cordinate :");
            int x1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter y1-cordinate :");
            int y1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter x2-cordinate :");
            int x2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter y2-cordinate :");
            int y2 = Convert.ToInt16(Console.ReadLine());

            Double Length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine(Length);
        }
    }
}
