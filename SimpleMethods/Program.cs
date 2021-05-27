using System;

namespace SimpleMethods
{
    class Program
    {
        static void Main()
        {
            string message = GetHello();
            int sum = GetSum();
            Console.WriteLine($"{message},{sum}");
            Console.WriteLine();
            int result = Sum(10, 15);
            Console.WriteLine(result);
            Console.WriteLine();
            int a = 25;
            int b = 35;
            result = Sum(a, b);
            Console.WriteLine(result);  //60
            Console.WriteLine();
            result = Sum(b, 45);
            Console.WriteLine(result);  //80
            result = Sum(a + b + 12, 18);   
            Console.WriteLine(result);  //90
            Display("Tom", 24);
            int optparam = OptionalParam(2, 3);
            Console.WriteLine(optparam);    //14
            int optparam2 = OptionalParam(2, 3, 10);
            Console.WriteLine(optparam2);   //19
            /* Именованные параметры, прямое указание на изменяемый параметр*/
            int optparam3 = OptionalParam(y: 2, x: 3, s: 10);   //z=5 по умолчанию
            Console.WriteLine(optparam3);   //20
            Console.ReadKey();
        }
        static string GetHello() => "Hello";
        static int GetSum()
        {
            int x = 2;
            int y = 3;
            return x + y;
        }
        static int Sum(int x, int y)
        {
            return x + y;
        }
        /* Передача переменных в параметры */
        static void Display(string name, int age) => Console.WriteLine($"Name: {name} Age: {age}");
        /* z s Необязательные параметры, можно выставить значение по умолчанию*/
        static int OptionalParam (int x, int y, int z=5, int s=4)
        {
            return x + y + z + s;
        }
        
    }
}
