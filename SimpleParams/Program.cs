using System;

namespace SimpleParams
{
    class Program
    {
        static void Main()
        {
            int sum = Sum(10,15); // Передача параметров по значению
            Console.WriteLine(sum);
            Console.WriteLine();
            int x = 10;
            int y = 15;
            Addition(ref x, y); // Вызов метода
            Console.WriteLine(x); // 25
            Console.WriteLine();

            int a = 5;
            Console.WriteLine($"Начальное значение переменной a = {a}");
            IncrementedVal(a);
            Console.WriteLine($"Переменная a после передачи по значению равна = {a}");
            IncrementedRef(ref a);
            Console.WriteLine($"Переменная а после передачи по ссылке равна = {a}");
            Console.WriteLine();
            int z = 2;
            int area;
            int perimetr;
            GetData(z, 3, out area, out perimetr);
            Console.WriteLine("Площадь:" + area);
            Console.WriteLine("Периметр:" + perimetr);
            Console.WriteLine();
            int p = 2;
            GetData2(p, 3, out int area2, out int perimetr2);
            Console.WriteLine("Площадь:" + area2);
            Console.WriteLine("Периметр:" + perimetr2);
            Console.WriteLine();
            Console.ReadKey();
        }
        static int Sum (int x, int y)
        {
            return x + y;
        }
        static void Addition (ref int x,int y)  // Параметр x передаётся по ссылке 
        {
            x += y;
        }
        static void IncrementedVal(int x)
        {
            x++;
            Console.WriteLine($"IncrementedValue: {x}");
        }
        static void IncrementedRef (ref int x)
        {
            x++;
            Console.WriteLine($"IncrementedReferal: {x}");
        }

        static void GetData(int x, int y, out int area, out int perimetr)
        {
            area = x * y;
            perimetr = (x + y) * 2;
        }
        static void GetData2(in int b, int n, out int area, out int perimetr)
        {
            //b = b + 10; нельзя изменить значение параметра x Входной параметр in передаёт аргументы только для чтения
            n += 10;
            area = b * n;
            perimetr = (b + n) * 2;
        }
    }
}
