using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Double L1 = 0, L2 = 0;
            for(int i = 0; i <= 1; i++)
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
                if (i == 0)
                {
                    Console.WriteLine("Length of First Line :" + Length);
                     L1 = Length;
                }
                else 
                {
                    Console.WriteLine("Length of Second Line :" + Length);
                     L2 = Length;
                }
            }
            if(L1 == L2)
            {
                Console.WriteLine("Lines are Equal");
            }
            else
            {
                Console.WriteLine("Lines are not Equal");
            }

            
        }
    }
}
