using System;                           // Подключение пространсва имён

namespace SimpleIfElseSwitchCase        // Объявление пространства имён
{
    class Program                       // Объявление класса
    {
        static void Main()              // Объявление метода
        {
            //BasicInfo.IfElse();
            //BasicInfo.SwitchCase();
            //BasicInfo.TernarOp();
            //Extra.Numbers();
            //Extra.FiveToTen();
            //Extra.FiveToTen2();
            //Extra.Bank();
            Extra.Calc();
            Console.ReadKey();
        }                               // Конец объявления метода
    }                                   // Конец объявления класса
    public class BasicInfo
    {
        public static void IfElse()
        {
            int num1 = 8;   // Присваивание переменным значений
            int num2 = 6;
            if (num1 > num2) // Условная конструкция if проверяет истиность условия
            {
                Console.WriteLine($"Число {num1} больше чем {num2}");
            }
            else if (num1 < num2) // или
            {
                Console.WriteLine($"Число {num1} меньше чем {num2}");
            }
            else // Иначе
            {
                Console.WriteLine("Числа равны");
            }
            
        }
        public static void SwitchCase()
        {
            Console.WriteLine("Введите Y или N");   // Запрашиваем ввод данных у пользователя
            string selection = Console.ReadLine();  // Записываем введенное значение в переменную
            switch (selection)  // Условная конструкция switch сравнивает введенное выражение с описанными значениями 
            {
                case "Y":   // Если совпадение найдено
                    Console.WriteLine("Вы выбрали Y");  // Вывод на экран уведомления
                    break;  // Выход из условной конструкции
                case "N":
                    Console.WriteLine("Вы выбрали N");
                    goto case "GO"; // Переход к другому блоку конструкции
                case "GO":
                    Console.WriteLine("Мы перешли в другой случай");
                    break;
                default:    // Если вводимое значение не нашло совпадений
                    Console.WriteLine("Вы ввели неизвестное значение");
                    break;
            }
        }
        public static void TernarOp()
        {
            /* Тернарная операция */
            int x = 3;
            int y = 2;
            Console.WriteLine("Нажмите + или -");
            string select = Console.ReadLine();
            /*   1операнд  условие  2операнд: 3операнд  */
            int z = select == "+" ? (x + y) : (x - y);  // Если введенное значение равно + выполняется (x+y) иначе (x-y)
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
    public class Extra
    {
        public static void Numbers()
        {
            Console.WriteLine("Введите число");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1>number2)
            { Console.WriteLine($"{number1} больше {number2}"); }
            else if (number1<number2)
            {Console.WriteLine($"{number1} меньше {number2}");}
            else
            {Console.WriteLine("Числа равны");}
        }
        public static void FiveToTen()
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number>5 & number<10)
            {
                Console.WriteLine("Число больше 5 и меньше 10");
            }
            else { Console.WriteLine("Неизвестное число"); }
        }
        public static void FiveToTen2()
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 5 || number == 10)
            {
                Console.WriteLine("Число либо равно 5 либо равно 10");
            }
            else
            {Console.WriteLine("Неизвестное число");}
        }
        public static void Bank ()
        {
            Console.WriteLine("Введите сумму вклада");
            double sum = Convert.ToDouble(Console.ReadLine());
            double percent;
            if (sum<100)
            {
                percent = .05;
            }   
            else if (sum>=100 & sum<=200)
            {
                percent = 0.07;
            }
            else
            {
                percent = 0.1;
            }
            sum +=sum * percent +15;

            Console.WriteLine($"Текущая сумма вклада равна: {sum}");
        }
        public static void Calc()
        {
            Console.WriteLine("Введите первое число");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер операции 1:Сложение 2:Вычитание 3:Умножение 4:Деление");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    number1 += number2;
                    Console.WriteLine($"Сложение. Результат операции {number1}");
                    break;
                case 2:
                    number1 -= number2;
                    Console.WriteLine($"Вычитание. Результат операции {number1}");
                    break;
                case 3:
                    number1 *= number2;
                    Console.WriteLine($"Умножение. Результат операции {number1}");
                    break;
                case 4:
                    number1 /= number2;
                    Console.WriteLine($"Деление. Результат операции {number1}");
                    break;
                default:
                    Console.WriteLine("Операция не определена");
                    break;
            }
        }
        
    }
}   // Конец объявления пространства имён
