using System;

namespace SimpleCortej
{
    class Program
    {
        static void Main()
        {
            var turple = (5, 10);// Кортеж с неявно указанным типом
            Console.WriteLine(turple.Item1);//5
            Console.WriteLine(turple.Item2);//10
            turple.Item1 += 26;
            Console.WriteLine(turple.Item1);//31

            (int,int) turple2 = (5, 10);// Кортеж с явным указанием типа

            (string, int, double) person = ("Tom", 25, 81.23);

            var turple3 = (count: 5, sum: 10);  //Можно дать название полям
            var (name, age) = ("Tom", 23);  // Можно не использовать переменную а поля
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(turple3.count);

            var turpleM = GetValues();
            Console.WriteLine(turpleM.Item1);   // 1
            Console.WriteLine(turpleM.Item2);   // 3
            Console.WriteLine();

            // Кортежу присваивается результат работы метода в который передаётся массив
            var turple4 = GetNamedValues(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            Console.WriteLine(turple4.count);
            Console.WriteLine(turple4.sum);
            Console.WriteLine();

            var (name2, age2) = GetTurple(("Tom", 23), 12);
            Console.WriteLine(name2);   // Tom
            Console.WriteLine(age2);    // 35

            Console.ReadKey();
        }
        /* Метод возвращает кортеж для возвращения 2х и более значений */
        private static (int,int) GetValues()    
        {
            var result = (1, 3);
            return result;
        }
        /* Метод возвращает кортеж с суммой значений массива и количества итераций */
        private static (int sum,int count) GetNamedValues(int[] numbers)
        {
            // Создаётся кортеж 
            var result = (sum: 0, count: 0);
            for (int i=0;i<numbers.Length;i++)
            {
                result.sum += numbers[i];
                result.count++;
            }
            return result;
        }
        /* Кортеж может передаваться в качестве параметрва в метод */
        private static (string name, int age) GetTurple((string n, int a) turple, int x)
        {
            var result = (name: turple.n, age: turple.a + x);
            return result;
        }
    }
}
