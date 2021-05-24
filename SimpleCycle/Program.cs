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
            //BasicInfo.SimpleContinue();
            //Extra.Bank();
            //Extra.BankWhile();
            //Extra.Multi();
            Extra.MultiTable();
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
            Console.WriteLine("Введите сумму вклада");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("На сколько месяц оформляется вклад?");
            int months = Convert.ToInt32(Console.ReadLine());
            double percent = 0.07;
            Console.WriteLine($"Сумма вклада {sum} \n Колличество месяцев {months}");
            for (int i = 0; i<months; i++)
            {
                sum +=sum * (decimal)percent;
                Console.WriteLine(sum);
            }
        }

        public static void BankWhile()
        {
            Console.WriteLine("Введите сумму вклада");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("На сколько месяц оформляется вклад?");
            int months = Convert.ToInt32(Console.ReadLine());
            double percent = 0.07;
            Console.WriteLine($"Сумма вклада {sum} \n Колличество месяцев {months}");
            int i = months;
            while (i>0)
            {
                sum += sum * (decimal)percent;
                i--;
                Console.WriteLine(sum);
            }
        }

        public static void Multi()
        {
            int number1, number2, sum;
            while (true)
            {
                Console.WriteLine("Введите число");
                //number1 = Convert.ToInt32(Console.ReadLine());
                while(!int.TryParse(Console.ReadLine(),out number1))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число");
                }
                
                Console.WriteLine("Введите второе число");
                while (!int.TryParse(Console.ReadLine(), out number2))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число");
                }

                if (number1<0 || number1>10 || number2<0 || number2>10)
                {
                    Console.WriteLine("Числа должные быть больше 0 и меньше 10");
                }
                else
                {
                    sum = number1 * number2;
                    Console.WriteLine($"Результат умножения двух чисел: {number1} и {number2} = {sum}");
                }
            }
        }
        
        public static void MultiTable()
        {
            for (int x = 1; x<10; x++)
            {
                for (int y=1; y<10; y++)
                {
                    Console.Write($"{x*y} \t");
                }
            }
        }
    }
}
