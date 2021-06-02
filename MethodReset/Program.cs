using System;

namespace MethodReset
{
    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();
            calc.Add(1, 2);
            calc.Add(1, 2, 3);
            calc.Add(1, 2, 3, 4);
            calc.Add(1.4, 2.5);
            Console.ReadKey();
        }
    }
    class Calculator
    {
        public void Add (int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
        // Перегрузка метода с добавление параметра
        public void Add (int a, int b, int c)
        {
            int result = a + b + c;
            Console.WriteLine(result);
        }
        // Перегрузка метода с добавление параметра
        public void Add (int a, int b, int c, int d)
        {
            int result = a + b + c + d;
            Console.WriteLine(result);
        }
        // Перегрузка метода с изминением типа параметра
        public void Add (double a, double b)
        {
            double result = a + b;
            Console.WriteLine(result);
        }
        // Перегрузка метода с изминением параметра доступа к переменной
        public void Add (ref int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
    }
}
