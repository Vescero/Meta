using System;

namespace SimpleRecursion
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine(Factorial(5));
            //Console.WriteLine(FibRec(5));
            Console.WriteLine(FibCicles(3));
            int a=1, b=1, tmp=0;
            tmp = a;
            Console.WriteLine($"tmp: {tmp} a: {a} b: {b}");
            a = b;
            Console.WriteLine($"tmp: {tmp} a: {a} b: {b}");
            b += tmp;
            Console.WriteLine($"tmp: {tmp} a: {a} b: {b}");

        }
        static int Factorial (int x)    // Факториал числа
        {
            if (x == 0)
            {
                return 1;
            }
            else
                return x * Factorial(x - 1);    // Метод вызывает сам себя (Рекурсия)
            
        }
        static int FibRec (int x)
        {
            if (x==0 || x==1)
            {
                return x;
            }
            else
            {
                return FibRec(x - 1) + FibRec(x - 2);   // Рекурсия
            }
        }
        static int FibCicles (int x)
        {
            int a = 0;
            int b = 1;
            int tmp;
            for (int i =0; i<x; i++)
            {
                tmp = a;
                a = b;
                b += tmp;
            }
            return a;
        }
    }
}
