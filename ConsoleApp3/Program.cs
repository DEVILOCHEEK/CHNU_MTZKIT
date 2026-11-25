using System;

namespace DraftForLab3
{
    class Program
    {
        static long CalcSumOfDivisors(long m)
        {
            if (m < 2)
                return 0;

            long sum = 1;

            for (long d = 2; d * d <= m; d++)
            {
                if (m % d == 0)
                {
                    sum += d;

                    if (d != m / d)
                        sum += m / d;
                }
            }

            return sum;
        }

        static void PrintAllPerfectNumbers(long n)
        {
            Console.WriteLine("Досконалi числа з промiжку [2, {0}]:", n);

            int count = 0;

            for (long i = 2; i <= n; i++)
            {
                long s = CalcSumOfDivisors(i);

                if (s == i)
                {
                    Console.WriteLine(i);
                    count++;
                }
            }

            if (count == 0)
                Console.WriteLine("Досконалих чисел у цьому промiжку немає");
        }

        static void PrintAllAmicableNumbersPairs(long n)
        {
            Console.WriteLine("Пари дружнiх чисел з промiжку [2, {0}]:", n);

            int count = 0;

            for (long a = 2; a <= n; a++)
            {
                long b = CalcSumOfDivisors(a);

                if (b > a && b <= n)
                {
                    long c = CalcSumOfDivisors(b);

                    if (c == a)
                    {
                        Console.WriteLine("{0} i {1}", a, b);
                        count++;
                    }
                }
            }

            if (count == 0)
                Console.WriteLine("Пар дружнiх чисел у цьому промiжку немає");
        }

        static void Main(string[] args)
        {
            Console.Write("Введiть n: ");
            long n = long.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("n має бути не менше 2");
                return;
            }

            PrintAllPerfectNumbers(n);
            PrintAllAmicableNumbersPairs(n);
        }
    }
}
