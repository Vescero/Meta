using System;

namespace SimpleCycle
{
    class Program
    {
        static void Main()
        {
            //BasicInfo.SimpleFor();
            //BasicInfo.SimpleDo();
            //BasicInfo.SimpleWhile();
            //BasicInfo.SimpleBreak();
            BasicInfo.SimpleContinue();
        }
    }
    public class BasicInfo
    {
        public static void SimpleFor()
        {
            for (int i=0; i<9; i++) // Проверка выполнения условия затем действие в цикле
            {
                Console.WriteLine($"Квадрат числа {i} равен {i*i}");    // Цикл выполнится 9 раз, с 0 до 8
            }
            Console.WriteLine();
        }
        public static void SimpleDo()
        {
            int i = 6;
            do
            {
                Console.WriteLine(i);   // Цикл выполнится 6 раз, от 6 до 1
                i--;
            } while (i>0);
            Console.WriteLine();
        }
        public static void SimpleWhile()
        {
            int i = 6;
            while (i>0)
            {
                Console.WriteLine(i);   // Цикл выполнится 6 раз, от 6 до 1
                i--;
            }
            Console.WriteLine();
        }
        public static void SimpleBreak()
        {
            for (int i = 0; i<9;i++)
            {
                Console.WriteLine(i);
                if (i == 5) // При достижении циклом значения 5 цикл останавливается
                    break;
            }
        }
        public static void SimpleContinue()
        {
            for (int i = 0; i < 9; i++)
            {
                if (i == 5)
                    continue;
                Console.WriteLine(i);   // При достижении циклом значения 5 цикл пропустит его и продолжит работу далее
            }    
        }

    }
    public class Extra
    {
        public static void Bank()
        {

        }
    }
}
