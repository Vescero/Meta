using System;

namespace SimpleMassParams
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Вызов метода Addition");
            Addition(1,"Hello",1, 2, 3, 4, 5);
            int[] array = { 1, 2, 3, 4 };
            Addition(2,"World",array);
            Addition(3,"!",new int[] { 1,2,3,5,9,6,8,7,8,9,});
            Console.WriteLine("Вызов метода AdditionMass");
            AdditionMass(array, 2);
            Console.ReadLine();
        }
        /* params позволяет передавать неопределенное колличество параметров которые 
         * упаковываются в массив при соблюдении одного типа*/
        static void Addition (int x, string mes,params int [] integers)
        {
            int result = 0;
            for (int i=0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            Console.WriteLine(result);
            Console.WriteLine($"{x}{mes}");
        }
        /* Передача массива в параметр */
        static void AdditionMass(int[] integers, int k)
        {
            int result = 0;
            for (int i=0; i<integers.Length;i++)
            {
                result += (integers[i] * k);
            }
            Console.WriteLine(result);
        }
    }
}
